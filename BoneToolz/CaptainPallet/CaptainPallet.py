import json
import os

# Crate Object Template
objTmp = {
	"barcode" : "",
	"barcodeOld" : "",
	"slimCode" : "",
	"title" : "",
	"description" : "",
	"unlockable" : "",
	"redacted" : "",
	"mainAsset" : "",
	"tags" : [],
	"packedAssets" : [],
	"colliderBounds": {
		"center": { "x": 0.0, "y": 0.0, "z": 0.0 },
		"extents": { "x": 0.0, "y": 0.0, "z": 0.0 }
	},
	"isa": {
		"type": "t:2"
	}	
}

# Header Template
headerTmp = {
	"version": 1,
	"root": {
		"ref": "o:1",
		"type": "t:1"
	},
	"objects": {
		"o:1": {
			"barcode": "SLZ.BONELAB.InternalPallet",
			"barcodeOld": "SLZ.BONELAB.InternalPallet",
			"title": "BONELAB Internal Contente",
			"description": "",
			"unlockable": False,
			"redacted": False,
			"author": "SLZ",
			"version": "0.0.0",
			"sdkVersion": "0.0.0",
			"internal": True,
			"crates": [
				# {
				#	 "ref": "o:2",
				# 	 "type": "t:2"
				# },
			],
			"tags": [],
			"changelogs": [],
			"isa": {
				"type": "t:1"
			}
		}
	},
	"types": {
		"t:1": {
			"type": "t:1",
			"fullname": "SLZ.Marrow.Warehouse.Pallet, SLZ.Marrow.SDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"
		},
		"t:2": {
			"type": "t:2",
			"fullname": "SLZ.Marrow.Warehouse.SpawnableCrate, SLZ.Marrow.SDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null"
		}
	}
}

# Byte Array to SlimCode Mapping
slimMap = [ 3, 2, 1, 0, 5, 4, 7, 6, 8, 9, 10, 11, 12, 13, 14, 15 ]

## Function to convert a byte array to a slim code
def BytesToSlim(slimArray):
	tmp = ""
	
	# If we don't have exactly 16 bytes, this is not a valid slim code array
	if(len(slimArray) != 16):
		return "00000000-0000-0000-0000-000000000000" # Return a null code
	
	# Go through each mapped byte and convert into hex
	for i in slimMap:
		# It would be easier to use a string format expression here to ensure the integer
		# is convert to a 2 byte hex (I.E. 0x05 instead of 0x5). But I'm leaving it like this
		# because I feel like it's easier for someone unfamiliar with the code to understand
		if(slimArray[i] < 16):
			tmp += "0" + hex(slimArray[i])[2:]
		else:
			tmp += hex(slimArray[i])[2:]
	
	# Add in the dashes and return
	tmp = tmp[0:8]+"-"+tmp[8:12]+"-"+tmp[12:16]+"-"+tmp[16:20]+"-"+tmp[20:]
	return tmp

# Object index, and variables to store our parsed crate and object arrays
index = 1
crates = []
objects = {}

# Loop through each json file in the directory the script resides in
for path in os.listdir(".\\"):
	# Make sure it's a file
	if(os.path.isfile(path)):
		# make sure it's a valid json file, and doesn't begin with '_'
		# continue if neither is the case
		if(path[len(path)-5:] != ".json" or path[0:1] == "_"):
			continue
		
		# open the file and load the json data
		f = open(path)
		json_data = json.load(f)
		f.close()
		# make a working copy of the object template
		tmp = objTmp.copy()

		# Parse each item in the template
		tmp["barcode"] = json_data["_barcode"]["_id"]
		tmp["barcodeOld"] = json_data["_barcodeOld"]["_id"]
		tmp["slimCode"] = BytesToSlim(json_data["_slimCode"]["_byteArray"])
		tmp["title"] = json_data["_title"]
		tmp["description"] = json_data["_description"]
		tmp["unlockable"] = bool(json_data["_unlockable"])
		tmp["redacted"] = bool(json_data["_redacted"])
		tmp["mainAsset"] = json_data["_mainAsset"]["_assetGUID"]
		tmp["tags"] = json_data["_tags"]
		# Handle edge case where some items might not have a preview mesh
		if "_previewMesh" in json_data:
			tmp["packedAssets"] = [ { "title": "PreviewMesh", "guid": json_data["_previewMesh"]["_assetGUID"] } ]
		else:
			tmp["packedAssets"] = [ { "title": "PreviewMesh", "guid": "" } ]
		# handle edge casae where some items might not have collider bounds
		if "_colliderBounds" in json_data:
			tmp["colliderBounds"]["center"] = json_data["_colliderBounds"]["m_Center"]
			tmp["colliderBounds"]["extents"] = json_data["_colliderBounds"]["m_Extent"]
		else:
			tmp["colliderBounds"] = { }
		
		# Increment index and incrementally build crate and objects json data
		index += 1
		crates.append({ "ref": "o:"+str(index), "type": "t:2" })
		objects.update( { "o:" + str(index): tmp } )

# Add in the parsed data into the header
headerTmp["objects"]["o:1"]["crates"] = crates
headerTmp["objects"].update(objects)

# Write the output of parsing the data
out_json = json.dumps(headerTmp, indent=4)
with open("output.json", "w") as out:
	out.write(out_json)
	
print ("Done!")
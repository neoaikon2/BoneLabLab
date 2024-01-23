import os
import json

strAssetMeta = ".asset.meta"
strPreviewMesh = " PreviewMesh.asset.meta"
dataPath = ".\\PreviewMeshes";

previewGuids = [];

# Loop through all of the meta files for the preview meshes
for path in os.listdir(dataPath):
	# Make sure it's a file	
	if(os.path.isfile(os.path.join(dataPath, path))):		
		if(path[len(path)-len(strAssetMeta):] == strAssetMeta):
			# Open the file and read it line-by-line
			f = open(os.path.join(dataPath, path))			
			for line in f.readlines():				
				# When we find the GUID
				if("guid:" in line):
					# Append the title and guid
					previewGuids.append({ path[0:len(path)-len(strPreviewMesh)]: line[6:len(line)-1]});

# Open the pallet json with bad preview guids, load the json data
f = open("pallet.json")
jd = json.load(f)

# Get a reference to the object in the pallet
objects = jd["objects"]

# Loop through all the objects
for obj in objects:
	if "packedAssets" in jd["objects"][obj]:
		# Get the title and GUID for this pallet object
		title = jd["objects"][obj]["title"]		
		guid = jd["objects"][obj]["packedAssets"][0]["guid"]
		
		# Loop through all the previewGuids looking for a match for the title
		for pg in previewGuids:
			if(title in pg):
				# On a match, update the guid if they're different
				if(pg[title] != guid):
					jd["objects"][obj]["packedAssets"][0]["guid"] = pg[title]

# Write the output of parsing the data
out_json = json.dumps(jd, indent=4)
with open("pallet_fixed.json", "w") as out:
	out.write(out_json)

print("Done!")
# BoneToolz  
  
 - BoneDoc  
	 Takes an old SDK and a new SDK rip and updates the old files with the newly ripped GUIDs  
	 Put your old SDK files into a folder called BASE, put your newly ripped SDK files into a folder called DUMP, make an empty folder called SDK_UPDATE. Run the script, and the generated update file will be placed in SDK_UPDATE. It also creates a guidmap.txt that can be used with UnFracture to update your prefabs as well  
	   
 - Captain Pallet  
	 In most rips is a folder called internal_pallet, or something similar; this is a collection of JSON files of all the palletized objects in BoneLab, drop this script into that folder and run it and it will generate output.json, which you can import into Unity using the SLZ Void Tools to easily add in-game items to your mods.  
	   
 - UnFracture  
	 Uses the contents of the guidmap.txt file created by BoneDoc, past the contents of this file into the appropriate spot in the script and put your prefabs into a folder called PREFABS, then run the script and it will fix all the missing script references.  
	 

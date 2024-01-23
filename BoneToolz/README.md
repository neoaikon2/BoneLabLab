# BoneToolz  
  
**NOTE**: These tools are provided as-is, they are mostly written for my use and also as one-offs, I've tried to comment everything I can to make it easier to figure out what they're doing for those interested. My apologies for the vastly inconsistent usage between them; I am not a smart man.  
  
## BoneDoc

Takes an old SDK and a new SDK rip and updates the old files with the newly ripped GUIDs  
Put your old SDK files into the folder called BASE, put your newly ripped Scripts folder into DUMP, run the script and the generated update files will be placed in SDK_UPDATE. It also creates a guidmap.txt that can be used with Splint to update your assets as well!

## Splint

A unity editor script that lets you take the guidmap.txt you got from BoneDoc and apply the updated GUIDs across the entirety of your project updating any missing references.

## Palatine

Along with the internal pallet data it's also possible to rip a majority of the preview meshes. One can link these up manually, or you can use Palatine to link up everything automatically (well, the thinks with matching object -> preview mesh names anyway). Just put the preview mesh assets and meta files into a folder called 'PreviewMeshes' (it's usually called that in the rip as well), rename the output of Captain Pallet to "pallet.json" and put both of those in the same directory as the 'PreviewMeshes' folder. Run it and it should link up everything it can.

## Sharp Sort

Take a folder of disorganized unity scripts and organizes them by the first namespace found in the file.

## Pallet to JSON

Right click on a pallet, and get the pallet.json directly on your clipboard. Paste it into a file, name it <something>.json and share your pallet dependancies to your hearts content! Can also be useful in cases where you only have the pallet data (I.E. Extracting the ripped internal assets)
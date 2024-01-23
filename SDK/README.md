# BonerLab SDK

In preparation for patch 4 I've officially renamed this to BonerLab SDK, I plan on keeping it up to date with major releases at least. This is still my personal SDK, but you can look forward to it getting consistent updates.

This SDK is based on the extended SDK, but has diverged a lot from it to the point it's kind of it's own thing. It is currently the most complete sdk available, with all the exported scripts available for use.

~~These files are my working fork of the SDK, it is NOT guaranteed to be compatible entirely with Boneworks Patch 2. The files here are updated on an *as-needed basis* **only** for compatibility. If you need an SDK that is entirely compatible with Patch 2 please download from the repository made by [Swipez (Click Here)](https://github.com/notnotnotswipez/Marrow-ExtendedSDK-PATCH-2).~~

## SDK Flow

MarrowSDK_Ext -> BonerLab Patch 2 -> BonerLab Patch 3 (current)

## Things you can make with this fork

- Spawnables, Levels, and Avatars (as usual)  
- Weapons and other objects the require grips  
- Damage Volumes  
- NPCs (Good luck!)

##How to Install

Follow steps 1-5 from the official SDK over at https://github.com/StressLevelZero/MarrowSDK/wiki#project-setup
  
In step 6, you'll want to import these three packages via github URL:
  
- https://github.com/StressLevelZero/Custom-RenderPipelineCore.git#Bonelab  
- https://github.com/StressLevelZero/Custom-URP.git#Bonelab  
- https://github.com/StressLevelZero/MarrowSDK.git  

Using the green Code dropdown at the top of this page, download a zip of this repositry, and unzip the contents of the **SDK** folder into your Assets folder to have:

- Assets/BonerLab Configs 		BoneLab configuration files, things like Hand Poses and whatnot
- Assets/BonerLab Deps			BonerLab SDK dependancies, also contains a importable tags and layer mapping
- Assets/BonerLab SDK			The main SDK directory

Continue following steps 7+ from the official SDK documentation.

## TODO

Add examples for different things?
Museum of Unofficial Interactions? :)
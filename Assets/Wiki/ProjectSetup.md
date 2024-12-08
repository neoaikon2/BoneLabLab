# Project Setup

Requirements
---
* Unity Version `2021.3.16f1`
  * Only SLZ-URP compatible shaders will render properly
* Basic Unity Knowledge

## Download and Install Unity

- Download [Unity Hub](https://unity.com/download). 
- If you already have Unity Hub installed (recommended), you can quickly install Unity version `2021.3.16f` by copying the following unityhub link into a browser: `unityhub://2021.3.16f1`.  The [Unity Hub](https://unity3d.com/get-unity/download) is recommended to help manage different versions of Unity and multiple projects.  Otherwise, [download](https://unity3d.com/get-unity/download/archive) Unity `2021.3.16f` manually from the Unity Archives. 
- When installing Unity `2021.3.16f`, be sure to include the following modules: Under <b>Platforms</b>, select *Android Build Support* and it's sub-items, *Android SDK & NDK Tools* and the *OpenJDK*.  Lower down the list, add *Windows Build Support (IL2CPP)*.

![Image](https://github.com/StressLevelZero/MarrowSDK/tree/main/Docs/Images/UnityProjectModules/android_platform.png) ![Image](https://github.com/StressLevelZero/MarrowSDK/tree/main/Docs/Images/UnityProjectModules/windows_platform.png)

- Once Unity is installed, create a <b>New Project</b>.  If you have other Unity Editor versions, be sure to select `2021.3.16f` from the list at the top of the window. 

![3dcore](https://github.com/StressLevelZero/MarrowSDK/tree/main/Docs/Images/UnityProjectModules/hub3dcore_install.png)
- Create a new `3D Core` project for your mod. (Note this change from older MarrowSDK versions... do <i><b>not</b></i> choose 3D (URP))  

## Add the SLZ Scoped Registry

- Select `Window` → `Package Manager` → `Gear Icon` → `Advanced Project Settings`

![AdvancedProjSettings](https://github.com/StressLevelZero/MarrowSDK/tree/main/Docs/Images/UnityProjectModules/add_scoped_registry.gif)

#### Copy each line into the new scoped registry

![scopedregistry](https://github.com/StressLevelZero/MarrowSDK/tree/main/Docs/Images/UnityProjectModules/scoped_registry_copypaste.gif)

> [!IMPORTANT]
> <img align="center" src="https://github.com/StressLevelZero/MarrowSDK/tree/main/Docs/Images/UnityProjectModules/important_copy.gif" /> Use the copy button on the right of each line to avoid errors

> Name 
```
SLZ
```
> URL
```
https://registry.stresslevelzero.com
```
> Scopes
```
com.stresslevelzero
```
```
com.unity.render-pipelines
```
```
com.unity.shadergraph
```
- Click Save.

#### Add Additional Packages

Make sure `Packages: Unity Registry` is selected in the Project Manager Window and install the following packages:
* Animation-Rigging
* Input System
* ML-Agents
* ARCore XR Plugin
* ARCore Foundation
* XR Interaction Toolkit
* OpenXR Plugin

#### Install The Extended SDK

Next, be sure `Packages: My Registries` is selected in the Project Manager Window and install the following packages from under the <b>Stress Level Zero</b> menu.

* SLZ Universal RP
* SLZ Core RP Library

Next install the following package from its Github URL

* https://github.com/neoaikon2/com.bonerlab.marrow.sdk.git

The last package to install is the 'Marrow SDK Backlot' from under the <b>Stress Level Zero</b> menu from before.

Finally, download this repository as a ZIP file, and copy the SDK folder from 'Assets' into your project, all of the errors should go away. You are done!
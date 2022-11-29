## BoneLab Grabbable Configuration Quick Reference
List items enclosed in square brackets ('[]') are empty objects and should be named *EXACTLY* as they appear here
Items that are not enclosed
* \<Root\> - Name this whatever your prefab is supposed to be called
\- Req. Components: Rigidbody, Interactable Host
\- Opt. Components: Rigidbody Settings
	* [Art]
		* Mesh Objects
\- Make sure to remove any colliders, should be **ONLY** meshrenderers
	* [Colliders]
		* Collider Objects (Box, Cylinder, etc)
	* [Grip]
	\- Req. Components: Collider (Box, Cylinder, etc), Grip (Box, Cylinder, etc)
	\- Opt. Components: Interactable Icon
		* [Target]
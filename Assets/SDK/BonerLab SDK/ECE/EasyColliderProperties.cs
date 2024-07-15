using UnityEngine;

namespace ECE
{
	public struct EasyColliderProperties
	{
		public bool IsTrigger;

		public int Layer;

		public PhysicMaterial PhysicMaterial;

		public COLLIDER_ORIENTATION Orientation;

		public GameObject AttachTo;

		public EasyColliderProperties(bool isTrigger, int layer, PhysicMaterial physicMaterial, GameObject attachTo, COLLIDER_ORIENTATION orientation = COLLIDER_ORIENTATION.NORMAL)
		{
			IsTrigger = false;
			Layer = 0;
			PhysicMaterial = null;
			Orientation = default(COLLIDER_ORIENTATION);
			AttachTo = null;
		}
	}
}

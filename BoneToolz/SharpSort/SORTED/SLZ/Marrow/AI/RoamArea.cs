using UnityEngine;

namespace SLZ.Marrow.AI
{
	public class RoamArea : MonoBehaviour
	{
		private Color gizmoColorRoam;

		public Vector2 roamScale;

		public Vector3 roamScale3D;

		public float uniformScale;

		[HideInInspector]
		public bool roamScaleVis;

		[HideInInspector]
		public bool roamScale3DVis;

		public Vector3 GetRoamTarget()
		{
			return default(Vector3);
		}

		public Vector3 GetRoamTarget3D()
		{
			return default(Vector3);
		}
	}
}

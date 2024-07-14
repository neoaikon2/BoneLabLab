using UnityEngine;

namespace SLZ.Marrow.Input
{
	public class XRHMD : XRDevice
	{
		public override bool IsConnected => false;

		public bool IsUserPresent => false;

		public float LeftGazeConfidence { get; protected set; }

		public Vector3 LeftGazePosition { get; protected set; }

		public Quaternion LeftGazeRotation { get; protected set; }

		public float RightGazeConfidence { get; protected set; }

		public Vector3 RightGazePosition { get; protected set; }

		public Quaternion RightGazeRotation { get; protected set; }
	}
}

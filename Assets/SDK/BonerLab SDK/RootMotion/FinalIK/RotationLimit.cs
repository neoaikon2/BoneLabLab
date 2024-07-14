using UnityEngine;

namespace RootMotion.FinalIK
{
	public abstract class RotationLimit : MonoBehaviour
	{
		public Vector3 axis;

		[HideInInspector]
		public Quaternion defaultLocalRotation;

		private bool initiated;

		private bool applicationQuit;

		private bool defaultLocalRotationSet;

		public Vector3 secondaryAxis => default(Vector3);

		public Vector3 crossAxis => default(Vector3);

		public void SetDefaultLocalRotation()
		{
		}

		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			changed = default(bool);
			return default(Quaternion);
		}

		public bool Apply()
		{
			return false;
		}

		public void Disable()
		{
		}

		protected abstract Quaternion LimitRotation(Quaternion rotation);

		private void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public void LogWarning(string message)
		{
		}

		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return 0f;
		}
	}
}

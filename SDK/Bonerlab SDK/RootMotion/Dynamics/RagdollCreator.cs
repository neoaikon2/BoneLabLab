using System;
using UnityEngine;

namespace RootMotion.Dynamics
{
	public abstract class RagdollCreator : MonoBehaviour
	{
		[Serializable]
		public enum ColliderType
		{
			Box = 0,
			Capsule = 1
		}

		[Serializable]
		public enum JointType
		{
			Configurable = 0,
			Character = 1
		}

		[Serializable]
		public enum Direction
		{
			X = 0,
			Y = 1,
			Z = 2
		}

		public struct CreateJointParams
		{
			public struct Limits
			{
				public float minSwing;

				public float maxSwing;

				public float swing2;

				public float twist;

				public Limits(float _minSwing, float _maxSwing, float _swing2, float _twist)
				{
					minSwing = _minSwing;
					maxSwing = _maxSwing;
					swing2 = _swing2;
					twist = _twist;
				}
			}

			public Rigidbody rigidbody;

			public Rigidbody connectedBody;

			public Transform child;

			public Vector3 worldSwingAxis;

			public Limits limits;

			public JointType type;

			public CreateJointParams(Rigidbody _rigidbody, Rigidbody _connectedBody, Transform _child, Vector3 _worldSwingAxis, Limits _limits, JointType _type)
			{
				rigidbody = _rigidbody;
				connectedBody = _connectedBody;
				child = _child;
				worldSwingAxis = _worldSwingAxis;
				limits = _limits;
				type = _type;
			}
		}

		public static void ClearAll(Transform root)
		{
		}

		protected static void ClearTransform(Transform transform)
		{
		}

		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width)
		{
		}

		protected static void CreateCollider(Transform t, Vector3 startPoint, Vector3 endPoint, ColliderType colliderType, float lengthOverlap, float width, float proportionAspect, Vector3 widthDirection)
		{
		}

		protected static float GetScaleF(Transform t)
		{
			return 0f;
		}

		protected static Vector3 Abs(Vector3 v)
		{
			return default(Vector3);
		}

		protected static void Vector3Abs(ref Vector3 v)
		{
		}

		protected static Vector3 DirectionIntToVector3(int dir)
		{
			return default(Vector3);
		}

		protected static Vector3 DirectionToVector3(Direction dir)
		{
			return default(Vector3);
		}

		protected static int DirectionVector3ToInt(Vector3 dir)
		{
			return 0;
		}

		protected static Vector3 GetLocalOrthoDirection(Transform transform, Vector3 worldDir)
		{
			return default(Vector3);
		}

		protected static Rigidbody GetConnectedBody(Transform bone, ref Transform[] bones)
		{
			return null;
		}

		protected static void CreateJoint(CreateJointParams p)
		{
		}

		private static SoftJointLimit ToSoftJointLimit(float limit)
		{
			return default(SoftJointLimit);
		}
	}
}

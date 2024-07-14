using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using Unity.Mathematics;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	[RequireComponent(typeof(Rigidbody))]
	public class SplineJoint : MonoBehaviour
	{
		private static float3 _right;

		private static float3 _up;

		private static float3 _forward;

		[Header("Configuration")]
		[SerializeField]
		private ContactCount _contactCount;

		[SerializeField]
		private Vector3 _axis;

		[SerializeField]
		private Vector3 _secondaryAxis;

		[SerializeField]
		private Vector2 _size;

		[SerializeField]
		private Vector3 _anchor;

		[SerializeField]
		[Space(15f)]
		private float _linearXDriveSpeed;

		[SerializeField]
		private DampenContactDrive _linearXDrive;

		[Space(15f)]
		[SerializeField]
		[Tooltip("Sets rotational twist motion on the configured axis")]
		private ConfigurableJointMotion _angularXMotion;

		[Range(-177f, 177f)]
		[SerializeField]
		private float _angularXMinLimit;

		[Range(-177f, 177f)]
		[SerializeField]
		private float _angularXMaxLimit;

		[SerializeField]
		private float _angularXDriveSpeed;

		[SerializeField]
		private SpringContactDrive _angularXDrive;

		[SerializeField]
		[Space(15f)]
		private SplineJointMotion _linearYZMotion;

		[SerializeField]
		private SoftSplineJointLimit _linearYZLimit;

		[SerializeField]
		private SpringContactDrive _linearYZDrive;

		[SerializeField]
		[Space(15f)]
		[Tooltip("Sets rotational swing motion on the configured axis")]
		private ConfigurableJointMotion _angularYZMotion;

		[Range(0f, 177f)]
		[SerializeField]
		private float _angularYZLimit;

		[SerializeField]
		private SpringContactDrive _angularYZDrive;

		[Header("References")]
		[SerializeField]
		private Rigidbody _rigidbody;

		[SerializeField]
		private PolyLine polyLine;

		private List<Contact> _contacts;

		private int _curSplineIndex;

		private Quaternion AnchorRotation => default(Quaternion);

		private Vector3 Size => default(Vector3);

		private Vector3 FrontContact => default(Vector3);

		private Vector3 RightContact => default(Vector3);

		private void Reset()
		{
		}

		private void Awake()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetAngularXDriveSpeed(float speed)
		{
		}

		public void SetAngularXDrivePositionSpring(float springForce)
		{
		}

		public void SetAngularXDrivePositionDamper(float damperForce)
		{
		}

		public void SetAngularXDriveMaxForce(float maxForce)
		{
		}

		public void SetYZDrivePositionSpring(float springForce)
		{
		}

		public void SetYZDrivePositionDamper(float damperForce)
		{
		}

		public void SetYZDriveMaxForce(float maxForce)
		{
		}

		public void SetLinearXDriveSpeed(float speed)
		{
		}

		public void SetLinearXDrivePositionDamper(float damperForce)
		{
		}

		public void SetLinearXDriveMaxForce(float maxForce)
		{
		}

		private static quaternion SynthesizeRotation(float3 right, float3 up)
		{
			return default(quaternion);
		}

		private void Update()
		{
		}

		private void Solve()
		{
		}

		private void AttachToBackPoint(float3 position, quaternion rotation)
		{
		}

		private bool IsBodyInverted(quaternion anchorRotation, quaternion rotation)
		{
			return false;
		}

		private void CalculateTwoPointContact(float3 worldPos, out float3 frontPosition, out float3 backPosition, out quaternion lookRotation, out quaternion frontRotation, out quaternion backRotation, out int frontIndex, out bool isFrontCapped, out bool isBackCapped)
		{
			frontPosition = default(float3);
			backPosition = default(float3);
			lookRotation = default(quaternion);
			frontRotation = default(quaternion);
			backRotation = default(quaternion);
			frontIndex = default(int);
			isFrontCapped = default(bool);
			isBackCapped = default(bool);
		}

		private void Attach()
		{
		}

		private void RefreshContactConfig()
		{
		}

		public SimpleTransform GetContactOriginInWorld()
		{
			return default(SimpleTransform);
		}

		public void PlaceOnSpline()
		{
		}

		public void SetPolyLine(PolyLine polyline)
		{
		}
	}
}

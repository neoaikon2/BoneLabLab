using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		public class CharacterPosition
		{
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Tooltip("Angle offset from the default forward direction.")]
			[Range(-180f, 180f)]
			public float angleOffset;

			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			[Range(0f, 180f)]
			public float maxAngle;

			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			public Vector3 offset3D => default(Vector3);

			public Vector3 direction3D => default(Vector3);

			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				error = default(float);
				return false;
			}
		}

		[Serializable]
		public class CameraPosition
		{
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget;

			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			[Range(0f, 180f)]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			public float maxAngle;

			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				error = default(float);
				return false;
			}
		}

		[Serializable]
		public class Range
		{
			[Serializable]
			public class Interaction
			{
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;
			}

			[SerializeField]
			[HideInInspector]
			public string name;

			[HideInInspector]
			[SerializeField]
			public bool show;

			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				maxError = default(float);
				return false;
			}
		}

		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		private void Start()
		{
		}

		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return 0;
		}
	}
}

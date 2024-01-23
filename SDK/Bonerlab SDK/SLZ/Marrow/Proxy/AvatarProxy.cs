using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	public class AvatarProxy : BoneProxy
	{
		[InspectorDisplayName("Animator")]
		[SerializeField]
		[Header("Avatar Required Settings")]
		private Animator _proxyAnimator;

		[SerializeField]
		[Range(0.02f, 0.2f)]
		private float _headOffset;

		[Tooltip("Neck Radius")]
		[Range(0.018f, 0.08f)]
		[SerializeField]
		private float _neckRadius;

		[Tooltip("Horizontal Eye Depth Offset")]
		[Range(0f, 0.16f)]
		[SerializeField]
		[InspectorDisplayName("Eye Offset")]
		private float _eyeOffset;

		[InspectorDisplayName("Eye Center Override")]
		[SerializeField]
		[Header("Avatar Optional Settings")]
		private Transform _proxyEyeCenterOverride;

		[Header("Optional Bones")]
		[InspectorDisplayName("Upper Neck")]
		[SerializeField]
		private Transform _proxyUpperNeck;

		[SerializeField]
		[InspectorDisplayName("Scapula Left")]
		private Transform _proxyScapulaLeft;

		[SerializeField]
		[InspectorDisplayName("Scapula Right")]
		private Transform _proxyScapulaRight;

		[Header("Optional Hand Bones")]
		[SerializeField]
		[InspectorDisplayName("Wrist Left")]
		private Transform _proxyWristLeft;

		[InspectorDisplayName("Wrist Right")]
		[SerializeField]
		private Transform _proxyWristRight;

		[InspectorDisplayName("Carpal Left")]
		[SerializeField]
		private Transform _proxyCarpalLeft;

		[SerializeField]
		[InspectorDisplayName("Carpal Right")]
		private Transform _proxyCarpalRight;

		[InspectorDisplayName("Upper Arm Twist Left")]
		[SerializeField]
		[Header("Optional Arm Bones")]
		private Transform _proxyUpperArmTwistLeft;

		[SerializeField]
		[InspectorDisplayName("Upper Arm Twist Right")]
		private Transform _proxyUpperArmTwistRight;

		[InspectorDisplayName("Lower Arm Twist Left")]
		[SerializeField]
		private Transform _proxyLowerArmTwistLeft;

		[InspectorDisplayName("Lower Arm Twist Right")]
		[SerializeField]
		private Transform _proxyLowerArmTwistRight;

		[SerializeField]
		[Tooltip("Sternum Z / AvatarHeight")]
		[Range(0.02f, 0.3f)]
		[Header("Chest Values")]
		private float _sternumEllipseZ;

		[Tooltip("Sternum Neg Z / AvatarHeight")]
		[SerializeField]
		[Range(0.02f, 0.3f)]
		private float _sternumEllipseNegZ;

		[Tooltip("Chest Width on Z / AvatarHeight")]
		[Range(0.02f, 0.3f)]
		[SerializeField]
		private float _chestEllipseZ;

		[Tooltip("Chest Width on Neg Z / AvatarHeight")]
		[Range(0.02f, 0.3f)]
		[SerializeField]
		private float _chestEllipseNegZ;

		[Tooltip("Waist Width on Z / AvatarHeight")]
		[Range(0.02f, 0.3f)]
		[SerializeField]
		private float _waistEllipseZ;

		[Range(0.02f, 0.3f)]
		[SerializeField]
		[Tooltip("Waist Width on Neg Z / AvatarHeight")]
		private float _waistEllipseNegZ;

		[SerializeField]
		[Tooltip("Hips Width on Z / AvatarHeight")]
		[Range(0.02f, 0.3f)]
		private float _hipsEllipseZ;

		[SerializeField]
		[Range(0.02f, 0.3f)]
		[Tooltip("Hips Width on Neg Z / AvatarHeight")]
		private float _hipsEllipseNegZ;

		[SerializeField]
		[Range(0.04f, 0.3f)]
		[Tooltip("Chest Width on X / AvatarHeight. Default is .1")]
		private float _chestEllipseX;

		[SerializeField]
		[Range(0.04f, 0.3f)]
		[Tooltip("Waist Width on X / AvatarHeight. Default is .09")]
		private float _waistEllipseX;

		[SerializeField]
		[Range(0.04f, 0.3f)]
		[Tooltip("Hips Width on X / AvatarHeight. Default is .09")]
		private float _hipsEllipseX;

		public Animator Animator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float HeadOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float NeckRadius
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float EyeOffset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Transform EyeCenterOverride
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform UpperNeck
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform ScapulaLeft
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform ScapulaRight
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform WristLeft
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform WristRight
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform CarpalLeft
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform CarpalRight
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform UpperArmTwistLeft
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform UpperArmTwistRight
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform LowerArmTwistLeft
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform LowerArmTwistRight
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float SternumEllipseZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float SternumEllipseNegZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ChestEllipseZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ChestEllipseNegZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float WaistEllipseZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float WaistEllipseNegZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float HipsEllipseZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float HipsEllipseNegZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ChestEllipseX
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float WaistEllipseX
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float HipsEllipseX
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		protected override void SetupProperties()
		{
		}

		public AvatarProxy()
			: base()
		{
		}
	}
}

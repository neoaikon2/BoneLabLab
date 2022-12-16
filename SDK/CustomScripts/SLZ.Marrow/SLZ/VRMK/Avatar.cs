using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Data;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.VRMK
{
	[Serializable]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/Avatars")]
	[AddComponentMenu("MarrowSDK/Avatar")]
	public class Avatar : MonoBehaviour
	{
		public class Constants
		{
			public const float UnderbustYMin = 0.3f;

			public const float UnderbustYMax = 0.4f;

			public const float UnderbustYDefault = 0.35f;

			public const float WaistYMin = 0.5f;

			public const float WaistYMax = 0.7f;

			public const float WaistYDefault = 0.62f;

			public const float HighHipYMin = 0.75f;

			public const float HighHipYMax = 0.85f;

			public const float HighHipYDefault = 0.81f;

			public const float CrotchBottomMin = 0.02f;

			public const float CrotchBottomMax = 0.2f;

			public const float CrotchBottomDefault = 0.04f;

			public Constants()
				: base()
			{
			}
		}

		[Serializable]
		public class ArtOffsets
		{
			public Vector3 scLfOffset;

			public Vector3 scRtOffset;

			public Vector3 acLfOffset;

			public Vector3 acRtOffset;

			public Vector3 palmLfPosOffset;

			public Vector3 palmRtPosOffset;

			public Quaternion hipOffset;

			public Quaternion spineOffset;

			public Quaternion chestOffset;

			public Quaternion upperChestOffset;

			public Quaternion neckOffset;

			public Quaternion headOffest;

			public Quaternion jawOffset;

			public Quaternion eyeLfOffset;

			public Quaternion eyeRtOffset;

			public Quaternion shoulderLfOffset;

			public Quaternion scapLfOffset;

			public Quaternion armUpperLfOffset;

			public Quaternion armLowerLfOffset;

			public Quaternion handLfOffset;

			public Quaternion shoulderRtOffset;

			public Quaternion scapRtOffset;

			public Quaternion armUpperRtOffset;

			public Quaternion armLowerRtOffset;

			public Quaternion handRtOffset;

			public Quaternion legUpperLfOffset;

			public Quaternion legLowerLfOffset;

			public Quaternion footLfOffset;

			public Quaternion toeLfOffset;

			public Quaternion legUpperRtOffset;

			public Quaternion legLowerRtOffset;

			public Quaternion footRtOffset;

			public Quaternion toeRtOffset;

			public Quaternion indexLf1Offset;

			public Quaternion middleLf1Offset;

			public Quaternion ringLf1Offset;

			public Quaternion pinkyLf1Offset;

			public Quaternion thumbLf1Offset;

			public Quaternion thumbLf2Offset;

			public Quaternion thumbLf3Offset;

			public Quaternion indexRt1Offset;

			public Quaternion middleRt1Offset;

			public Quaternion ringRt1Offset;

			public Quaternion pinkyRt1Offset;

			public Quaternion thumbRt1Offset;

			public Quaternion thumbRt2Offset;

			public Quaternion thumbRt3Offset;

			public SimpleTransform breastLfOffset;

			public SimpleTransform breastRtOffset;

			public SimpleTransform buttLfOffset;

			public SimpleTransform buttRtOffset;

			public ArtOffsets()
				: base()
			{
			}
		}

		[Serializable]
		public struct HandSchematic
		{
			public Vector3 thumb1;

			public Vector3 index1;

			public Vector3 middle1;

			public Vector3 ring1;

			public Vector3 pinky1;

			public float thumb2;

			public float thumb3;

			public float index2;

			public float index3;

			public float middle2;

			public float middle3;

			public float ring2;

			public float ring3;

			public float pinky2;

			public float pinky3;

			public static HandSchematic DefaultLf
			{
				get
				{
					return default(HandSchematic);
				}
			}

			public static HandSchematic DefaultRt
			{
				get
				{
					return default(HandSchematic);
				}
			}

			public HandSchematic(Vector3 thumb1, float thumb2, float thumb3, Vector3 index1, float index2, float index3, Vector3 middle1, float middle2, float middle3, Vector3 ring1, float ring2, float ring3, Vector3 pinky1, float pinky2, float pinky3)
			{
				this.pinky3 = default(float);
				this.pinky2 = default(float);
				this.ring3 = default(float);
				this.ring2 = default(float);
				this.middle3 = default(float);
				this.middle2 = default(float);
				this.index3 = default(float);
				this.index2 = default(float);
				this.thumb3 = default(float);
				this.thumb2 = default(float);
				this.pinky1 = default(Vector3);
				this.ring1 = default(Vector3);
				this.middle1 = default(Vector3);
				this.index1 = default(Vector3);
				this.thumb1 = default(Vector3);
			}
		}

		[Serializable]
		public struct SoftEllipse
		{
			[StructLayout(LayoutKind.Sequential, Size = 1)]
			public struct Constants
			{
				public const float RadiusMin = 0.01f;

				public const float RadiusMax = 0.1f;

				public const float RadiusDefault = 0.03f;

				public const float BiasMin = -1f;

				public const float BiasMax = 1f;

				public const float BiasDefault = 0f;
			}

			[Range(0.01f, 0.1f)]
			public float XRadius;

			[Range(-1f, 1f)]
			public float XBias;

			[Range(0.01f, 0.1f)]
			public float ZRadius;

			[Range(-1f, 1f)]
			public float ZBias;

			public SoftEllipse(float xRadius = 0.03f, float xBias = 0f, float zRadius = 0.03f, float zBias = 0f)
			{
				this.ZBias = default(float);
				this.ZRadius = default(float);
				this.XBias = default(float);
				this.XRadius = default(float);
			}
		}

		[Serializable]
		public class SoftBulge
		{
			[Range(0f, 90f)]
			public float apexX;

			[Range(0.01f, 0.99f)]
			public float apexY;

			[Range(0f, 0.08f)]
			public float apexZ;

			[Range(0f, 1f)]
			public float upperY;

			[Range(0f, 1f)]
			public float lowerY;

			[Range(0f, 80f)]
			public float innerX;

			[Range(0f, 80f)]
			public float outerX;

			[Range(0f, 1f)]
			public float roundUpperInner;

			[Range(0f, 1f)]
			public float roundUpperOuter;

			[Range(0f, 1f)]
			public float roundLowerInner;

			[Range(0f, 1f)]
			public float roundLowerOuter;

			[Range(0f, 0.5f)]
			public float swellUpper;

			[Range(0f, 0.5f)]
			public float swellLower;

			[Range(0f, 0.5f)]
			public float swellInner;

			[Range(0f, 0.5f)]
			public float swellOuter;

			[Range(0f, 1f)]
			public float rigidity;

			public Transform primaryRt;

			public Transform secondaryLf;

			public static SoftBulge DefaultBreastFemale
			{
				get
				{
					return null;
				}
			}

			public static SoftBulge DefaultBreastMale
			{
				get
				{
					return null;
				}
			}

			public static SoftBulge DefaultAbdomen
			{
				get
				{
					return null;
				}
			}

			public static SoftBulge DefaultGroinMale
			{
				get
				{
					return null;
				}
			}

			public Vector3 ComputeBulge(float yPerc, Vector2 sin, float bulgeYTop, float bulgeYBot, bool onBack)
			{
				return default(Vector3);
			}

			public void Copy(SoftBulge bulge)
			{
			}

			public SoftBulge()
				: base()
			{
			}
		}

		private static ComponentCache<Avatar> _cache;

		public Animator animator;

		[HideInInspector]
		public bool requiredBonesOrRefsMissing;

		[Tooltip("Use this to override eyeCenter in case an avatar doesn't feature eye bones")]
		public Transform eyeCenterOverride;

		[Tooltip("Required field for all meshes that are not seperate head or hair meshes")]
		public SkinnedMeshRenderer[] bodyMeshes;

		[Tooltip("Optional field for models with seperate head mesh(es)")]
		public SkinnedMeshRenderer[] headMeshes;

		[Tooltip("Optional field for all meshes related to the hair")]
		public SkinnedMeshRenderer[] hairMeshes;

		[Range(0f, 0.16f)]
		public float eyeOffset;

		public Transform wristLf;

		public Transform wristRt;

		public Transform neck2;

		public Transform scapulaLf;

		public Transform scapulaRt;

		public Transform carpalLf;

		public Transform carpalRt;

		public Transform twistUpperArmLf;

		public Transform twistUpperArmRt;

		public Transform twistForearmLf;

		public Transform twistForearmRt;

		public Transform twistUpperThighLf;

		public Transform twistUpperThighRt;

		[Tooltip("Crown of head Y from EyeHeight / eyeHeight. Default is .068")]
		[SerializeField]
		[Range(0.02f, 0.2f)]
		private float _headTop;

		[SerializeField]
		[Range(0.02f, 0.2f)]
		private float _chinY;

		[Range(0.3f, 0.4f)]
		[SerializeField]
		protected float _underbustY;

		[Range(0.5f, 0.7f)]
		[SerializeField]
		protected float _waistY;

		[Range(0.75f, 0.85f)]
		[SerializeField]
		protected float _highHipY;

		[Tooltip("Bottom of crotch from hipCenter / eyeHeight. Default is .04")]
		[Range(0.02f, 0.2f)]
		[SerializeField]
		private float _crotchBottom;

		[SerializeField]
		[Range(0.02f, 0.2f)]
		[Tooltip("Forehead Width on X / AvatarHeight. Default is .044")]
		private float _headEllipseX;

		[SerializeField]
		[Range(0.02f, 0.2f)]
		[Tooltip("Jaw Width on X / AvatarHeight. Default is .044")]
		private float _jawEllipseX;

		[Tooltip("Neck Width on X / AvatarHeight. Default is .04")]
		[Range(0.018f, 0.08f)]
		[SerializeField]
		private float _neckEllipseX;

		[Tooltip("Chest Width on X / AvatarHeight. Default is .1")]
		[Range(0.04f, 0.24f)]
		[SerializeField]
		private float _chestEllipseX;

		[Range(0.04f, 0.24f)]
		[Tooltip("Waist Width on X / AvatarHeight. Default is .09")]
		[SerializeField]
		private float _waistEllipseX;

		[Tooltip("High Hips Width on X / AvatarHeight. Default is .09")]
		[Range(0.04f, 0.24f)]
		[SerializeField]
		private float _highHipsEllipseX;

		[Tooltip("Hips Width on X / AvatarHeight. Default is .09")]
		[SerializeField]
		[Range(0.04f, 0.24f)]
		private float _hipsEllipseX;

		[Tooltip("Forehead Z Fwd / AvatarHeight. Default is .06")]
		[Range(0.02f, 0.2f)]
		[SerializeField]
		private float _headEllipseZ;

		[Tooltip("Jaw Z Fwd / AvatarHeight. Default is .06")]
		[SerializeField]
		[Range(0.02f, 0.2f)]
		private float _jawEllipseZ;

		[SerializeField]
		[Range(0.018f, 0.08f)]
		[Tooltip("Neck Z / AvatarHeight. Default is .04")]
		private float _neckEllipseZ;

		[Range(0.01f, 0.24f)]
		[Tooltip("Sternum Z / AvatarHeight. Default is .068")]
		[SerializeField]
		private float _sternumEllipseZ;

		[SerializeField]
		[Tooltip("Chest Width on Z / AvatarHeight. Default is .068")]
		[Range(0.01f, 0.24f)]
		private float _chestEllipseZ;

		[Tooltip("Waist Width on Z / AvatarHeight. Default is .068")]
		[Range(0.01f, 0.24f)]
		[SerializeField]
		private float _waistEllipseZ;

		[Range(0.01f, 0.24f)]
		[SerializeField]
		[Tooltip("High Hips Width on Z / AvatarHeight. Default is .068")]
		private float _highHipsEllipseZ;

		[Tooltip("Hips Width on Z / AvatarHeight. Default is .068")]
		[Range(0.01f, 0.24f)]
		[SerializeField]
		private float _hipsEllipseZ;

		[Range(0.02f, 0.2f)]
		[Tooltip("Forehead Z Neg / AvatarHeight. Default is .06")]
		[SerializeField]
		private float _headEllipseNegZ;

		[SerializeField]
		[Range(0.02f, 0.2f)]
		[Tooltip("Jaw Z Neg / AvatarHeight. Default is .06")]
		private float _jawEllipseNegZ;

		[Tooltip("Neck Z / AvatarHeight. Default is .03")]
		[SerializeField]
		[Range(0.018f, 0.08f)]
		private float _neckEllipseNegZ;

		[Tooltip("Sternum Neg Z / AvatarHeight. Default is .068")]
		[Range(0.01f, 0.22f)]
		[SerializeField]
		private float _sternumEllipseNegZ;

		[Range(0.01f, 0.22f)]
		[SerializeField]
		[Tooltip("Chest Width on Neg Z / AvatarHeight. Default is .068")]
		private float _chestEllipseNegZ;

		[Tooltip("Waist Width on Neg Z / AvatarHeight. Default is .06")]
		[Range(0.01f, 0.22f)]
		[SerializeField]
		private float _waistEllipseNegZ;

		[SerializeField]
		[Range(0.01f, 0.22f)]
		[Tooltip("High Hips Width on Neg Z / AvatarHeight. Default is .07")]
		private float _highHipsEllipseNegZ;

		[Tooltip("Hips Width on Neg Z / AvatarHeight. Default is .068")]
		[Range(0.01f, 0.22f)]
		[SerializeField]
		private float _hipsEllipseNegZ;

		[SerializeField]
		private SoftEllipse _thighUpperEllipse;

		[SerializeField]
		private SoftEllipse _kneeEllipse;

		[SerializeField]
		private SoftEllipse _calfEllipse;

		[SerializeField]
		private SoftEllipse _ankleEllipse;

		[SerializeField]
		private SoftEllipse _upperarmEllipse;

		[SerializeField]
		private SoftEllipse _elbowEllipse;

		[SerializeField]
		private SoftEllipse _forearmEllipse;

		[SerializeField]
		private SoftEllipse _wristEllipse;

		public SoftBulge bulgeBreast;

		public SoftBulge bulgeUpperBack;

		public SoftBulge bulgeAbdomen;

		public SoftBulge bulgeLowerBack;

		public SoftBulge bulgeGroin;

		public SoftBulge bulgeButt;

		private float _massHead;

		private float _massChest;

		private float _massPelvis;

		private float _massArm;

		private float _massLeg;

		private float _massTotal;

		private float _strengthUpper;

		private float _strengthLower;

		private float _intelligence;

		private float _agility;

		private float _speed;

		private float _vitality;

		private float _strengthGrip;

		public AudioVarianceData footstepsWalk;

		public AudioVarianceData footstepsJog;

		public AudioVarianceData highFallOntoFeet;

		public AudioVarianceData torsoImpactSoft;

		public AudioVarianceData torsoImpactHard;

		public AudioVarianceData limbImpactSoft;

		public AudioVarianceData limbImpactHard;

		public AudioVarianceData headImpactSoft;

		public AudioVarianceData headImpactHard;

		public AudioVarianceData spawn;

		public AudioVarianceData smallEffort;

		public AudioVarianceData bigEffort;

		public AudioVarianceData smallPain;

		public AudioVarianceData bigPain;

		public AudioVarianceData agro;

		public AudioVarianceData unAgro;

		public AudioVarianceData dying;

		public AudioVarianceData dead;

		public AudioVarianceData recovery;

		public Action OnWriteTransforms;

		public Action OnRefreshBodyMeasurements;

		protected float _armLength;

		protected float _armUpperLength;

		protected float _armLowerLength;

		protected float _carpalLength;

		protected float _clavicleLength;

		protected float _legUpperLength;

		protected float _legLowerLength;

		protected float _footLength;

		protected float _armPercent;

		protected float _shoulderToPalmPercent;

		protected float _palmOffsetLength;

		protected float _skullHeight;

		protected float _chestHeight;

		protected float _pelvisHeight;

		protected AnimationCurve _spineZ;

		protected AnimationCurve _ellipseZ;

		protected AnimationCurve _ellipseNegZ;

		protected AnimationCurve _ellipseX;

		[Tooltip("Height from top of head to bottom of feet in meters")]
		protected float _height;

		protected float _eyeHeight;

		[Tooltip("midEyeHeight / AvatarHeight. Default is .914")]
		protected float _heightPercent;

		[Tooltip("midEyeHeight / AvatarHeight. Default is .914")]
		protected float _eyeHeightPercent;

		[Tooltip("SkulljointHeight / AvatarHeight. Default is .914")]
		protected float _c1HeightPercent;

		[Tooltip("ChestHeight / AvatarHeight. Default is .862")]
		protected float _t1HeightPercent;

		[Tooltip("PelvisHeight / AvatarHeight. Default is .572")]
		protected float _sacrumHeightPercent;

		[Tooltip("Shoulder from chest / AvatarHeight. Default is .0907")]
		protected float _chestToShoulderPerc;

		[Tooltip("x = flexion, y = rotation, z = lateral flexion, w = extension")]
		protected Vector4 _cervicalRom;

		[Tooltip("x = flexion, y = rotation, z = lateral flexion, w = extension")]
		protected Vector4 _thoracicRom;

		[Tooltip("x = flexion, y = rotation, z = lateral flexion, w = extension")]
		protected Vector4 _lumbarRom;

		[Tooltip("x = forward, y = backward, z = up, w = down")]
		protected Vector4 _clavicularRom;

		protected Vector3 _skullCameraLocal;

		protected Vector3 _eyeLfLocal;

		protected Vector3 _eyeRtLocal;

		protected Vector3 _jawLocal;

		protected Vector3 _cervicalHalfLocal;

		protected Vector3 _t7Local;

		protected Vector3 _l1Local;

		protected Vector3 _l3Local;

		protected Vector3 _sacrumLocal;

		protected Vector3 _scLfLocal;

		protected Vector3 _acLfLocal;

		protected Vector3 _ghLfLocal;

		protected Vector3 _scRtLocal;

		protected Vector3 _acRtLocal;

		protected Vector3 _ghRtLocal;

		protected Vector3 _legUpperLfLocal;

		protected Vector3 _legUpperRtLocal;

		protected Vector3 _toeLfLocal;

		protected Vector3 _toeRtLocal;

		protected Vector3 _palmLfLocalPerc;

		protected Vector3 _palmRtLocalPerc;

		protected Vector3 _sternumOffsetPercent;

		protected Vector3 _hipOffsetPercent;

		protected Vector3 _spineT3ToS3Percent;

		protected Vector3 _spineT3ToUnderbustPerc;

		protected Vector3 _spineUnderbustToWaistPerc;

		protected Vector3 _spineWaistToHighHipsPerc;

		protected Vector3 _spineHighHipsToS3Perc;

		protected float _armUpperPercent;

		protected float _armLowerPercent;

		protected float _legUpperPercent;

		protected float _legLowerPercent;

		protected float _carpalPercent;

		protected float _toeHeightPercent;

		protected float _tippyToeExt;

		protected float _handSizeMult;

		protected float _t7OffsetZ;

		protected float _l1OffsetZ;

		protected float _l3OffsetZ;

		protected float _t7Y;

		protected float _l1Y;

		protected float _l3Y;

		protected bool _hasUpperChest;

		protected Vector2 _palmSize;

		public ArtOffsets artOffsets;

		private Vector4 _nipple;

		private bool PreComputed;

		public static ComponentCache<Avatar> Cache
		{
			get
			{
				return null;
			}
		}

		public bool hasUpperChest
		{
			get
			{
				return default(bool);
			}
		}

		public float height
		{
			get
			{
				return default(float);
			}
		}

		public float eyeHeight
		{
			get
			{
				return default(float);
			}
		}

		public float skullHeight
		{
			get
			{
				return default(float);
			}
		}

		public float chestHeight
		{
			get
			{
				return default(float);
			}
		}

		public float pelvisHeight
		{
			get
			{
				return default(float);
			}
		}

		public float armLength
		{
			get
			{
				return default(float);
			}
		}

		public float clavicleLength
		{
			get
			{
				return default(float);
			}
		}

		public float armUpperLength
		{
			get
			{
				return default(float);
			}
		}

		public float armLowerLength
		{
			get
			{
				return default(float);
			}
		}

		public float carpalLength
		{
			get
			{
				return default(float);
			}
		}

		public float legUpperLength
		{
			get
			{
				return default(float);
			}
		}

		public float legLowerLength
		{
			get
			{
				return default(float);
			}
		}

		public float footLength
		{
			get
			{
				return default(float);
			}
		}

		public float tippyToeExtension
		{
			get
			{
				return default(float);
			}
		}

		public float heightPercent
		{
			get
			{
				return default(float);
			}
		}

		public float eyeHeightPercent
		{
			get
			{
				return default(float);
			}
		}

		public float c1HeightPercent
		{
			get
			{
				return default(float);
			}
		}

		public float t1HeightPercent
		{
			get
			{
				return default(float);
			}
		}

		public float sacrumHeightPercent
		{
			get
			{
				return default(float);
			}
		}

		public float chestToShoulderPercent
		{
			get
			{
				return default(float);
			}
		}

		public float armPercent
		{
			get
			{
				return default(float);
			}
		}

		public float shoulderToPalmPercent
		{
			get
			{
				return default(float);
			}
		}

		public Vector3 spineT3ToS3
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 spineT3ToUnderbust
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 spineUnderbustToWaist
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 spineWaistToHighHips
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 spineHighHipsToS3
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 sternumOffset
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 hipPelvisOffset
		{
			get
			{
				return default(Vector3);
			}
		}

		public float handSizeMult
		{
			get
			{
				return default(float);
			}
		}

		public float palmOffsetLength
		{
			get
			{
				return default(float);
			}
		}

		public Vector2 handSize
		{
			get
			{
				return default(Vector2);
			}
		}

		public float massTotal
		{
			get
			{
				return default(float);
			}
		}

		public float massChest
		{
			get
			{
				return default(float);
			}
		}

		public float massPelvis
		{
			get
			{
				return default(float);
			}
		}

		public float massHead
		{
			get
			{
				return default(float);
			}
		}

		public float massArm
		{
			get
			{
				return default(float);
			}
		}

		public float massLeg
		{
			get
			{
				return default(float);
			}
		}

		public float strengthUpper
		{
			get
			{
				return default(float);
			}
		}

		public float strengthLower
		{
			get
			{
				return default(float);
			}
		}

		public float strengthGrip
		{
			get
			{
				return default(float);
			}
		}

		public float intelligence
		{
			get
			{
				return default(float);
			}
		}

		public float agility
		{
			get
			{
				return default(float);
			}
		}

		public float speed
		{
			get
			{
				return default(float);
			}
		}

		public float vitality
		{
			get
			{
				return default(float);
			}
		}

		public SoftEllipse wristEllipse
		{
			get
			{
				return default(SoftEllipse);
			}
			set
			{
			}
		}

		public SoftEllipse forearmEllipse
		{
			get
			{
				return default(SoftEllipse);
			}
			set
			{
			}
		}

		public SoftEllipse elbowEllipse
		{
			get
			{
				return default(SoftEllipse);
			}
			set
			{
			}
		}

		public SoftEllipse upperarmEllipse
		{
			get
			{
				return default(SoftEllipse);
			}
			set
			{
			}
		}

		public SoftEllipse ankleEllipse
		{
			get
			{
				return default(SoftEllipse);
			}
			set
			{
			}
		}

		public SoftEllipse calfEllipse
		{
			get
			{
				return default(SoftEllipse);
			}
			set
			{
			}
		}

		public SoftEllipse kneeEllipse
		{
			get
			{
				return default(SoftEllipse);
			}
			set
			{
			}
		}

		public SoftEllipse thighUpperEllipse
		{
			get
			{
				return default(SoftEllipse);
			}
			set
			{
			}
		}

		public Vector3 skullCameraLocal
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 eyeLfLocal
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 eyeRtLocal
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 jawLocal
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 cervicalHalfLocal
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 t7Local
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 l1Local
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 l3Local
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 sacrumLocal
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 legUpperLfLocal
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 legUpperRtLocal
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 toeLfLocal
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 toeRtLocal
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 scLfLocal
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 scRtLocal
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 acLfLocal
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 acRtLocal
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 ghLfLocal
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 ghRtLocal
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 palmLfLocalScaled
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 palmRtLocalScaled
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 palmLfPosOffset
		{
			get
			{
				return default(Vector3);
			}
		}

		public Vector3 palmRtPosOffset
		{
			get
			{
				return default(Vector3);
			}
		}

		public HandSchematic handSchematicLf { get; protected set; }

		public HandSchematic handSchematicRt { get; protected set; }

		public float t7OffsetZ
		{
			get
			{
				return default(float);
			}
		}

		public float l1OffsetZ
		{
			get
			{
				return default(float);
			}
		}

		public float l3OffsetZ
		{
			get
			{
				return default(float);
			}
		}

		public float t7Y
		{
			get
			{
				return default(float);
			}
		}

		public float l1Y
		{
			get
			{
				return default(float);
			}
		}

		public float l3Y
		{
			get
			{
				return default(float);
			}
		}

		public Vector4 cervicalRom
		{
			get
			{
				return default(Vector4);
			}
		}

		public Vector4 thoracicRom
		{
			get
			{
				return default(Vector4);
			}
		}

		public Vector4 lumbarRom
		{
			get
			{
				return default(Vector4);
			}
		}

		public Vector4 clavicularRom
		{
			get
			{
				return default(Vector4);
			}
		}

		public float HeadTop
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ChinY
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float UnderbustY
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float WaistY
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float HighHipsY
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float CrotchBottom
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ForeheadEllipseZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float ForeheadEllipseNegZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float JawEllipseZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float JawEllipseNegZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float NeckEllipseZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float NeckEllipseNegZ
		{
			get
			{
				return default(float);
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

		public float HighHipsEllipseZ
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float HighHipsEllipseNegZ
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

		public float ForeheadEllipseX
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float JawEllipseX
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float NeckEllipseX
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

		public float HighHipsEllipseX
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

		public virtual void Awake()
		{
		}

		public virtual void PrecomputeAvatar(float eyeHeight)
		{
		}

		public virtual void PrecomputeAvatar()
		{
		}

		public static void GuessLimbAxis(Vector3 limbDown, Quaternion boneRotInRoot, [Out] Vector3 fwd, [Out] Vector3 up)
		{
		}

		private Quaternion HandRotationOffset(Vector3 indexHandWorld, Vector3 ringHandWorld, Quaternion handWorld, bool isRight = false)
		{
			return default(Quaternion);
		}

		private void SetBounds(SkinnedMeshRenderer renderer, bool isHead = false)
		{
		}

		private void Reset()
		{
		}

		public virtual void RefreshBodyMeasurements(Avatar calibrationAvatar)
		{
		}

		public virtual void RefreshBodyMeasurements()
		{
		}

		public virtual void UpdateBlender()
		{
		}

		public void TempCopyHands(Avatar inAvatar)
		{
		}

		public virtual void OnDrawGizmosSelected()
		{
		}

		private void DrawLimb(Transform upper, Transform mid, Transform lower, SoftEllipse upperHigh, SoftEllipse upperLow, SoftEllipse midHigh, SoftEllipse midLow, float upperHighY, float upperLowY, float midHighY, float midLowY, float eyeCenterHeight, bool mirror = false)
		{
		}

		private void DrawHexaRing(Vector3 worldPos, Vector3 fwd, Vector3 right, SoftEllipse ellipse, float eyeHeight, bool mirror = false)
		{
		}

		private void DrawRingConnnection(Vector3 fromWorldPos, Vector3 toWorldPos, Vector3 fwd, Vector3 right, Vector3 fwd2, Vector3 right2, SoftEllipse fromEllipse, SoftEllipse toEllipse, float eyeHeight, bool mirror = false)
		{
		}

		private void DrawBulge(SoftBulge bulge, float bulgeYTop, float bulgeYBot, Vector3 sternumWorld, Vector3 hipsWorld, Vector3 fwd, Vector3 right, AnimationCurve spineZ, AnimationCurve ellipseX, AnimationCurve ellipseZ, AnimationCurve ellipseNegZ, float eyeCenterHeight, bool mirror = false, bool onBack = false)
		{
		}

		private SimpleTransform GetSpineInWorldForGizmos(float yPerc, float eyeCenterHeight, SimpleTransform head, SimpleTransform sternum, SimpleTransform hipCenter)
		{
			return default(SimpleTransform);
		}

		public Mesh GenerateSkullMesh(Vector3 offset)
		{
			return null;
		}

		public Mesh GenerateChestMesh(Vector3 offset)
		{
			return null;
		}

		public Mesh GenerateSpineMesh(Vector3 offset)
		{
			return null;
		}

		public Mesh GenerateSpineLowMesh(Vector3 offset)
		{
			return null;
		}

		public Mesh GeneratePelvisMesh(Vector3 offset)
		{
			return null;
		}

		public Mesh GenerateArmUpperMesh(Vector3 offset, float choakGirth = 1f, float choakLength = 1f, bool mirrorX = false)
		{
			return null;
		}

		public Mesh GenerateArmLowerMesh(Vector3 offset, float choakGirth = 1f, float choakLength = 1f, bool mirrorX = false)
		{
			return null;
		}

		public Mesh GenerateLegUpperMesh(Vector3 offset, float choakGirth = 1f, float choakLength = 1f, bool mirrorX = false)
		{
			return null;
		}

		public Mesh GenerateLegLowerMesh(Vector3 offset, float choakGirth = 1f, float choakLength = 1f, bool mirrorX = false)
		{
			return null;
		}

		public Mesh GenerateBreastMesh(Vector3 offset, bool mirrorX = false)
		{
			return null;
		}

		public Mesh GenerateButtMesh(Vector3 offset, bool mirrorX = false)
		{
			return null;
		}

		private Mesh PrepAndGenerateLimbMesh(Vector3 offset, float choakGirth, float choakLength, bool mirrorX, SoftEllipse upper, SoftEllipse mid, SoftEllipse lower, float length, float midT)
		{
			return null;
		}

		private Mesh GenerateTorsoMesh(Vector3 offset, float topCapX, float topCapY, float topCapZ, float topCapNegZ, float upperX, float upperY, float upperZ, float upperNegZ, float lowerX, float lowerY, float lowerZ, float lowerNegZ, float botCapX, float botCapY, float botCapZ, float botCapNegZ, float upperOffset, float lowerOffset)
		{
			return null;
		}

		private Mesh GenerateLimbMesh(Vector3 offset, float topCapZ, float upperX, float upperNegX, float upperY, float upperNegY, float upperZ, float midX, float midNegX, float midY, float midNegY, float midZ, float lowerX, float lowerNegX, float lowerY, float lowerNegY, float lowerZ, float botCapZ)
		{
			return null;
		}

		private Mesh GenerateBulgeMesh(Vector3 offset, SoftBulge bulge, float bulgeYTop, float bulgeYBot, Vector3 fwd, Vector3 right, AnimationCurve spineZ, AnimationCurve ellipseX, AnimationCurve ellipseZ, AnimationCurve ellipseNegZ, float eyeCenterHeight, bool mirror = false, bool onBack = false)
		{
			return null;
		}

		public Vector2 GetTorsoEllipseInMeters(float yPerc, bool front = true)
		{
			return default(Vector2);
		}

		public Vector3 GetSoftTorso(float yPerc, Vector2 sin, AnimationCurve ellipseX, AnimationCurve ellipseZ, AnimationCurve ellipseNegZ, [Out] Vector3 softDisplacement)
		{
			return default(Vector3);
		}

		public Vector3 GetSoftTorsoInMetersUsingBulge(float yPerc, Vector2 sin, [Out] Vector3 maxSoftDisplacement)
		{
			return default(Vector3);
		}

		public Vector3 GetSoftUpperArm(float yPerc, Vector2 sin, bool isLeft)
		{
			return default(Vector3);
		}

		public Vector3 GetSoftLowerArm(float yPerc, Vector2 sin, bool isLeft)
		{
			return default(Vector3);
		}

		public Vector3 GetSoftUpperLeg(float yPerc, Vector2 sin, bool isLeft)
		{
			return default(Vector3);
		}

		public Vector3 GetSoftLowerLeg(float yPerc, Vector2 sin, bool isLeft)
		{
			return default(Vector3);
		}

		private Vector3 GetLimbLocal(float yPerc, Vector2 sin, bool mirrorX, SoftEllipse upper, SoftEllipse mid, SoftEllipse lower, float length, float midT)
		{
			return default(Vector3);
		}

		public Vector3 GetBreastRoot(bool isLeft = false)
		{
			return default(Vector3);
		}

		public void SetTorsoFromCircumferences(float chestPerc, float underbustPerc, float waistPerc, float hipsPerc)
		{
		}

		public virtual void SetPlayerWingspan(float wingspan, float height)
		{
		}

		public virtual void SetPlayerInseam(float inseem, float height)
		{
		}

		public Vector3 GetHandBounds(bool isLeft, float fistPerc, [Out] Vector3 positiveBounds, [Out] Vector3 negativeBounds)
		{
			return default(Vector3);
		}

		private Vector2 EllipseAxesFromPerimeter(float perimeterInMeters, float aspectRatio = 0.667f)
		{
			return default(Vector2);
		}

		private float EllipsePerimeterFromAxes(float majorAxis, float minorAxis)
		{
			return default(float);
		}

		public AnimationCurve GenerateSpineCurve(float eyeHeight, Vector3 t7Local, Vector3 l1Local, Vector3 l3Local, Vector3 sacrumLocal, Vector3 sternumOffsetPerc, Vector3 hipsOffsetPerc, float t1HeightPerc)
		{
			return null;
		}

		public AnimationCurve GenerateTorsoZCurve(Vector3 sternumOffsetPerc, float t1HeightPerc, AnimationCurve spineZ)
		{
			return null;
		}

		public AnimationCurve GenerateTorsoNegZCurve(Vector3 sternumOffsetPerc, float t1HeightPerc, AnimationCurve spineZ)
		{
			return null;
		}

		public AnimationCurve GenerateTorsoXCurve(float sternumEllipseX, float hipEllipseX, Vector3 sternumOffsetPerc, float t1HeightPerc)
		{
			return null;
		}

		private ValueTuple<float, float> GetNeckAndJawT(Vector3 sternumOffsetPerc, float t1HeightPerc)
		{
			return default(ValueTuple<float, float>);
		}

		public float Derivative(AnimationCurve self, float time)
		{
			return default(float);
		}

		private float Derivative(Keyframe from, Keyframe to, float lerp)
		{
			return default(float);
		}

		public void ComputeMass(float normalizeTo82 = 0.5f)
		{
		}

		public void ComputeBaseStats()
		{
		}

		public Avatar()
			: base()
		{
		}
	}
}

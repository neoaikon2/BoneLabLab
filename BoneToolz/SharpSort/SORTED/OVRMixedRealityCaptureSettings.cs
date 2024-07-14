using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OVRMixedRealityCaptureSettings : ScriptableObject, OVRMixedRealityCaptureConfiguration
{
	public bool enableMixedReality;

	public LayerMask extraHiddenLayers;

	public LayerMask extraVisibleLayers;

	public bool dynamicCullingMask;

	public OVRManager.CompositionMethod compositionMethod;

	public Color externalCompositionBackdropColorRift;

	public Color externalCompositionBackdropColorQuest;

	[Obsolete("Deprecated", false)]
	public OVRManager.CameraDevice capturingCameraDevice;

	public bool flipCameraFrameHorizontally;

	public bool flipCameraFrameVertically;

	public float handPoseStateLatency;

	public float sandwichCompositionRenderLatency;

	public int sandwichCompositionBufferedFrames;

	public Color chromaKeyColor;

	public float chromaKeySimilarity;

	public float chromaKeySmoothRange;

	public float chromaKeySpillRange;

	public bool useDynamicLighting;

	[Obsolete("Deprecated", false)]
	public OVRManager.DepthQuality depthQuality;

	public float dynamicLightingSmoothFactor;

	public float dynamicLightingDepthVariationClampingValue;

	[Obsolete("Deprecated", false)]
	public OVRManager.VirtualGreenScreenType virtualGreenScreenType;

	public float virtualGreenScreenTopY;

	public float virtualGreenScreenBottomY;

	public bool virtualGreenScreenApplyDepthCulling;

	public float virtualGreenScreenDepthTolerance;

	public OVRManager.MrcActivationMode mrcActivationMode;

	private const string configFileName = "mrc.config";

	private bool OVRMixedRealityCaptureConfiguration_002EenableMixedReality
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private LayerMask OVRMixedRealityCaptureConfiguration_002EextraHiddenLayers
	{
		get
		{
			return default(LayerMask);
		}
		set
		{
		}
	}

	private LayerMask OVRMixedRealityCaptureConfiguration_002EextraVisibleLayers
	{
		get
		{
			return default(LayerMask);
		}
		set
		{
		}
	}

	private bool OVRMixedRealityCaptureConfiguration_002EdynamicCullingMask
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private OVRManager.CompositionMethod OVRMixedRealityCaptureConfiguration_002EcompositionMethod
	{
		get
		{
			return default(OVRManager.CompositionMethod);
		}
		set
		{
		}
	}

	private Color OVRMixedRealityCaptureConfiguration_002EexternalCompositionBackdropColorRift
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	private Color OVRMixedRealityCaptureConfiguration_002EexternalCompositionBackdropColorQuest
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	[Obsolete("Deprecated", false)]
	private OVRManager.CameraDevice OVRMixedRealityCaptureConfiguration_002EcapturingCameraDevice
	{
		get
		{
			return default(OVRManager.CameraDevice);
		}
		set
		{
		}
	}

	private bool OVRMixedRealityCaptureConfiguration_002EflipCameraFrameHorizontally
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool OVRMixedRealityCaptureConfiguration_002EflipCameraFrameVertically
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EhandPoseStateLatency
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EsandwichCompositionRenderLatency
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private int OVRMixedRealityCaptureConfiguration_002EsandwichCompositionBufferedFrames
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private Color OVRMixedRealityCaptureConfiguration_002EchromaKeyColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EchromaKeySimilarity
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EchromaKeySmoothRange
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EchromaKeySpillRange
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private bool OVRMixedRealityCaptureConfiguration_002EuseDynamicLighting
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Obsolete("Deprecated", false)]
	private OVRManager.DepthQuality OVRMixedRealityCaptureConfiguration_002EdepthQuality
	{
		get
		{
			return default(OVRManager.DepthQuality);
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EdynamicLightingSmoothFactor
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EdynamicLightingDepthVariationClampingValue
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	[Obsolete("Deprecated", false)]
	private OVRManager.VirtualGreenScreenType OVRMixedRealityCaptureConfiguration_002EvirtualGreenScreenType
	{
		get
		{
			return default(OVRManager.VirtualGreenScreenType);
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EvirtualGreenScreenTopY
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EvirtualGreenScreenBottomY
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private bool OVRMixedRealityCaptureConfiguration_002EvirtualGreenScreenApplyDepthCulling
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private float OVRMixedRealityCaptureConfiguration_002EvirtualGreenScreenDepthTolerance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private OVRManager.MrcActivationMode OVRMixedRealityCaptureConfiguration_002EmrcActivationMode
	{
		get
		{
			return default(OVRManager.MrcActivationMode);
		}
		set
		{
		}
	}

	private OVRManager.InstantiateMrcCameraDelegate OVRMixedRealityCaptureConfiguration_002EinstantiateMixedRealityCameraGameObject
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	bool OVRMixedRealityCaptureConfiguration.enableMixedReality { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	LayerMask OVRMixedRealityCaptureConfiguration.extraHiddenLayers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	LayerMask OVRMixedRealityCaptureConfiguration.extraVisibleLayers { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	bool OVRMixedRealityCaptureConfiguration.dynamicCullingMask { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	OVRManager.CompositionMethod OVRMixedRealityCaptureConfiguration.compositionMethod { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	Color OVRMixedRealityCaptureConfiguration.externalCompositionBackdropColorRift { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	Color OVRMixedRealityCaptureConfiguration.externalCompositionBackdropColorQuest { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	OVRManager.CameraDevice OVRMixedRealityCaptureConfiguration.capturingCameraDevice { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	bool OVRMixedRealityCaptureConfiguration.flipCameraFrameHorizontally { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	bool OVRMixedRealityCaptureConfiguration.flipCameraFrameVertically { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.handPoseStateLatency { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.sandwichCompositionRenderLatency { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	int OVRMixedRealityCaptureConfiguration.sandwichCompositionBufferedFrames { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	Color OVRMixedRealityCaptureConfiguration.chromaKeyColor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.chromaKeySimilarity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.chromaKeySmoothRange { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.chromaKeySpillRange { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	bool OVRMixedRealityCaptureConfiguration.useDynamicLighting { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	OVRManager.DepthQuality OVRMixedRealityCaptureConfiguration.depthQuality { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.dynamicLightingSmoothFactor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.dynamicLightingDepthVariationClampingValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	OVRManager.VirtualGreenScreenType OVRMixedRealityCaptureConfiguration.virtualGreenScreenType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.virtualGreenScreenTopY { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.virtualGreenScreenBottomY { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	bool OVRMixedRealityCaptureConfiguration.virtualGreenScreenApplyDepthCulling { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	float OVRMixedRealityCaptureConfiguration.virtualGreenScreenDepthTolerance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	OVRManager.MrcActivationMode OVRMixedRealityCaptureConfiguration.mrcActivationMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	public OVRManager.InstantiateMrcCameraDelegate instantiateMixedRealityCameraGameObject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

	public void WriteToConfigurationFile()
	{
	}

	public void CombineWithConfigurationFile()
	{
	}
}

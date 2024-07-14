using System;
using UnityEngine;

public interface OVRMixedRealityCaptureConfiguration
{
	bool enableMixedReality { get; set; }

	LayerMask extraHiddenLayers { get; set; }

	LayerMask extraVisibleLayers { get; set; }

	bool dynamicCullingMask { get; set; }

	OVRManager.CompositionMethod compositionMethod { get; set; }

	Color externalCompositionBackdropColorRift { get; set; }

	Color externalCompositionBackdropColorQuest { get; set; }

	[Obsolete("Deprecated", false)]
	OVRManager.CameraDevice capturingCameraDevice { get; set; }

	bool flipCameraFrameHorizontally { get; set; }

	bool flipCameraFrameVertically { get; set; }

	float handPoseStateLatency { get; set; }

	float sandwichCompositionRenderLatency { get; set; }

	int sandwichCompositionBufferedFrames { get; set; }

	Color chromaKeyColor { get; set; }

	float chromaKeySimilarity { get; set; }

	float chromaKeySmoothRange { get; set; }

	float chromaKeySpillRange { get; set; }

	bool useDynamicLighting { get; set; }

	[Obsolete("Deprecated", false)]
	OVRManager.DepthQuality depthQuality { get; set; }

	float dynamicLightingSmoothFactor { get; set; }

	float dynamicLightingDepthVariationClampingValue { get; set; }

	[Obsolete("Deprecated", false)]
	OVRManager.VirtualGreenScreenType virtualGreenScreenType { get; set; }

	float virtualGreenScreenTopY { get; set; }

	float virtualGreenScreenBottomY { get; set; }

	bool virtualGreenScreenApplyDepthCulling { get; set; }

	float virtualGreenScreenDepthTolerance { get; set; }

	OVRManager.MrcActivationMode mrcActivationMode { get; set; }

	OVRManager.InstantiateMrcCameraDelegate instantiateMixedRealityCameraGameObject { get; set; }
}

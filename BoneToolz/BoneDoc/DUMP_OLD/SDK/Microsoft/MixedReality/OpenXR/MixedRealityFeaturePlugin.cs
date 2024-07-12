using System;
using System.Collections.Generic;
using UnityEngine;

namespace Microsoft.MixedReality.OpenXR
{
	[NativeLibToken(NativeLibToken = NativeLibToken.HoloLens)]
	internal class MixedRealityFeaturePlugin : OpenXRFeaturePlugin<MixedRealityFeaturePlugin>
	{
		internal const string featureId = "com.microsoft.openxr.feature.hololens";

		internal const string featureName = "Mixed Reality Features";

		internal const string mixedRealityExtensions = "XR_MSFT_unbounded_reference_space XR_MSFT_spatial_anchor XR_MSFT_secondary_view_configuration XR_MSFT_first_person_observer XR_MSFT_spatial_graph_bridge XR_MSFT_perception_anchor_interop XR_MSFT_spatial_anchor_persistence XR_MSFT_scene_understanding XR_MSFT_scene_understanding_serialization XR_MSFT_spatial_anchor_export_preview XR_MSFT_composition_layer_reprojection";

		internal const string requestedExtensions = "XR_MSFT_holographic_window_attachment XR_KHR_win32_convert_performance_counter_time XR_MSFT_unbounded_reference_space XR_MSFT_spatial_anchor XR_MSFT_secondary_view_configuration XR_MSFT_first_person_observer XR_MSFT_spatial_graph_bridge XR_MSFT_perception_anchor_interop XR_MSFT_spatial_anchor_persistence XR_MSFT_scene_understanding XR_MSFT_scene_understanding_serialization XR_MSFT_spatial_anchor_export_preview XR_MSFT_composition_layer_reprojection";

		[SerializeField]
		[Header("Mixed Reality Plugin Settings")]
		[Tooltip("Using first person observer, Mixed Reality Capture (MRC) will render from the perspective of the PV camera with an extra rendering pass. This provides better hologram quality and alignment to the physical world but may use more rendering resources. When this flag is set, MRC will render from one of the eyes without an extra rendering pass, reducing the rendering cost for MRC but potentially introducing visual disparity, especially on hand tracking visuals.")]
		[LabelWidth(250f)]
		private bool disableFirstPersonObserver;

		[Tooltip("Using the before-render pose update allows the app to use lower latency action poses in the render scripts.However, this pose update adds cost in the pre-render phase. The before-render pose update is disabled by default so that action poses are updated once a frame in the update phase which has 2 frames of latency.")]
		[LabelWidth(250f)]
		[SerializeField]
		private bool enablePoseUpdateOnBeforeRender;

		private SessionSubsystemController m_sessionSubsystemController;

		private PlaneSubsystemController m_planeSubsystemController;

		private AnchorSubsystemController m_anchorSubsystemController;

		private RaycastSubsystemController m_raycastSubsystemController;

		private MeshSubsystemController m_meshSubsystemController;

		private OpenXRViewConfigurationSettings m_viewConfigurationSettings;

		internal IReadOnlyList<ViewConfiguration> EnabledViewConfigurations
		{
			get
			{
				return null;
			}
		}

		internal MixedRealityFeaturePlugin()
			: base()
		{
		}

		protected override bool OnInstanceCreate(ulong instance)
		{
			return default(bool);
		}

		protected override IntPtr HookGetInstanceProcAddr(IntPtr func)
		{
			return default(IntPtr);
		}
	}
}

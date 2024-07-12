using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;

namespace Microsoft.MixedReality.OpenXR
{
	internal class AnchorSubsystem : XRAnchorSubsystem
	{
		private class OpenXRProvider : Provider
		{
			private readonly NativeLibToken nativeLibToken;

			public override void Start()
			{
			}

			public override void Stop()
			{
			}

			public override void Destroy()
			{
			}

			public override TrackableChanges<XRAnchor> GetChanges(XRAnchor defaultAnchor, Allocator allocator)
			{
				return default(TrackableChanges<XRAnchor>);
			}

			private XRAnchor ToXRAnchor(NativeAnchor nativeAnchor)
			{
				return default(XRAnchor);
			}

			public override bool TryAddAnchor(Pose pose, [Out] XRAnchor anchor)
			{
				return default(bool);
			}

			public override bool TryAttachAnchor(TrackableId trackableToAffix, Pose pose, [Out] XRAnchor anchor)
			{
				return default(bool);
			}

			public override bool TryRemoveAnchor(TrackableId anchorId)
			{
				return default(bool);
			}

			public OpenXRProvider()
				: base()
			{
			}
		}

		public const string Id = "OpenXR Anchors Subsystem";

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void RegisterDescriptor()
		{
		}

		public AnchorSubsystem()
			: base()
		{
		}
	}
}

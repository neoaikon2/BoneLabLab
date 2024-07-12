using Unity.Collections;
using UnityEngine;
using UnityEngine.XR.ARSubsystems;

namespace Microsoft.MixedReality.OpenXR
{
	internal class PlaneSubsystem : XRPlaneSubsystem
	{
		private class OpenXRProvider : Provider
		{
			private readonly NativeLibToken nativeLibToken;

			private PlaneDetectionMode m_planeDetectionMode;

			public override PlaneDetectionMode currentPlaneDetectionMode
			{
				get
				{
					return default(PlaneDetectionMode);
				}
			}

			public override PlaneDetectionMode requestedPlaneDetectionMode
			{
				get
				{
					return default(PlaneDetectionMode);
				}
				set
				{
				}
			}

			public override void Start()
			{
			}

			public override void Stop()
			{
			}

			public override void Destroy()
			{
			}

			public override TrackableChanges<BoundedPlane> GetChanges(BoundedPlane defaultPlane, Allocator allocator)
			{
				return default(TrackableChanges<BoundedPlane>);
			}

			private PlaneClassification ToPlaneClassification(XrSceneObjectTypeMSFT type)
			{
				return default(PlaneClassification);
			}

			private BoundedPlane ToBoundedPlane(NativePlane nativePlane, BoundedPlane defaultPlane)
			{
				return default(BoundedPlane);
			}

			public OpenXRProvider()
				: base()
			{
			}
		}

		public const string Id = "OpenXR Planefinding";

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void RegisterDescriptor()
		{
		}

		public PlaneSubsystem()
			: base()
		{
		}
	}
}

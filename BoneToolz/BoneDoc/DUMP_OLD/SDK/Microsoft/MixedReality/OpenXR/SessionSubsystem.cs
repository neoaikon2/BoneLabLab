using System;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.XR.ARSubsystems;

namespace Microsoft.MixedReality.OpenXR
{
	[Preserve]
	internal class SessionSubsystem : XRSessionSubsystem
	{
		private class OpenXRProvider : Provider
		{
			private readonly NativeLibToken m_nativeLibToken;

			private readonly Guid m_sessionGuid;

			private readonly Feature m_allSupportedFeatures;

			private readonly Feature m_requestedBaseFeatures;

			private Feature m_requestedTrackingMode;

			private NativeSpaceLocationFlags m_trackingStateFlags;

			public override Feature currentTrackingMode
			{
				get
				{
					return default(Feature);
				}
			}

			public override Feature requestedTrackingMode
			{
				get
				{
					return default(Feature);
				}
				set
				{
				}
			}

			public override TrackingState trackingState
			{
				get
				{
					return default(TrackingState);
				}
			}

			public override NotTrackingReason notTrackingReason
			{
				get
				{
					return default(NotTrackingReason);
				}
			}

			public override bool matchFrameRateEnabled
			{
				get
				{
					return default(bool);
				}
			}

			public override bool matchFrameRateRequested
			{
				get
				{
					return default(bool);
				}
			}

			public override int frameRate
			{
				get
				{
					return default(int);
				}
			}

			public override Feature requestedFeatures
			{
				get
				{
					return default(Feature);
				}
			}

			public override IntPtr nativePtr
			{
				get
				{
					return default(IntPtr);
				}
			}

			public override Guid sessionId
			{
				get
				{
					return default(Guid);
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

			public override Promise<SessionAvailability> GetAvailabilityAsync()
			{
				return null;
			}

			public override NativeArray<ConfigurationDescriptor> GetConfigurationDescriptors(Allocator allocator)
			{
				return default(NativeArray<ConfigurationDescriptor>);
			}

			public override void OnApplicationPause()
			{
			}

			public override void OnApplicationResume()
			{
			}

			public override void Update(XRSessionUpdateParams updateParams, Configuration configuration)
			{
			}

			public override void Update(XRSessionUpdateParams updateParams)
			{
			}

			public OpenXRProvider()
				: base()
			{
			}
		}

		public const string Id = "OpenXR Session";

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void RegisterDescriptor()
		{
		}

		public SessionSubsystem()
			: base()
		{
		}
	}
}

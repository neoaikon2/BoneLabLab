using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

namespace Microsoft.MixedReality.OpenXR
{
	internal class RaycastSubsystem : XRRaycastSubsystem
	{
		private class OpenXRProvider : Provider
		{
			private ARPlaneManager m_arPlaneManager;

			public override bool TryAddRaycast(Vector2 screenPoint, float estimatedDistance, [Out] XRRaycast raycast)
			{
				return default(bool);
			}

			public override bool TryAddRaycast(Ray ray, float estimatedDistance, [Out] XRRaycast raycast)
			{
				return default(bool);
			}

			public override void RemoveRaycast(TrackableId trackableId)
			{
			}

			public override TrackableChanges<XRRaycast> GetChanges(XRRaycast defaultRaycast, Allocator allocator)
			{
				return default(TrackableChanges<XRRaycast>);
			}

			public override void Stop()
			{
			}

			public override void Destroy()
			{
			}

			public override NativeArray<XRRaycastHit> Raycast(XRRaycastHit defaultRaycastHit, Ray ray, TrackableType trackableTypeMask, Allocator allocator)
			{
				return default(NativeArray<XRRaycastHit>);
			}

			public OpenXRProvider()
				: base()
			{
			}
		}

		public const string Id = "OpenXR Raycasting";

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void RegisterDescriptor()
		{
		}

		public RaycastSubsystem()
			: base()
		{
		}
	}
}

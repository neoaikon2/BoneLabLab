using System;
using UnityEngine.XR.ARSubsystems;

namespace Microsoft.MixedReality.OpenXR
{
	public static class AnchorConverter
	{
		public static ulong ToOpenXRHandle(IntPtr nativePtr)
		{
			return default(ulong);
		}

		internal static TrackableId CreateFromOpenXRHandle(ulong openxrAnchorHandle)
		{
			return default(TrackableId);
		}

		public static object ToPerceptionSpatialAnchor(IntPtr nativePtr)
		{
			return null;
		}

		public static object ToPerceptionSpatialAnchor(TrackableId trackableId)
		{
			return null;
		}

		[Obsolete("Obsolete and will be removed in future releases.  Use the `CreateFromPerceptionSpatialAnchor` function instead.")]
		public static TrackableId FromPerceptionSpatialAnchor(object spatialAnchor)
		{
			return default(TrackableId);
		}

		public static TrackableId CreateFromPerceptionSpatialAnchor(object spatialAnchor)
		{
			return default(TrackableId);
		}

		public static TrackableId ReplaceSpatialAnchor(object spatialAnchor, TrackableId existingId)
		{
			return default(TrackableId);
		}
	}
}

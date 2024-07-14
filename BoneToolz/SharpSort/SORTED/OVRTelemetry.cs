using System;

internal static class OVRTelemetry
{
	public readonly struct MarkerPoint : IDisposable
	{
		public int NameHandle { get; }

		public MarkerPoint(string name)
		{
			NameHandle = 0;
		}

		public void Dispose()
		{
		}
	}

	public abstract class TelemetryClient
	{
		public abstract void MarkerStart(int markerId, int instanceKey = 0, long timestampMs = -1L);

		public abstract void MarkerPointCached(int markerId, int nameHandle, int instanceKey = 0, long timestampMs = -1L);

		public abstract void MarkerAnnotation(int markerId, string annotationKey, string annotationValue, int instanceKey = 0);

		public abstract void MarkerEnd(int markerId, OVRPlugin.Qpl.ResultType resultTypeId = OVRPlugin.Qpl.ResultType.Success, int instanceKey = 0, long timestampMs = -1L);

		public abstract bool CreateMarkerHandle(string name, out int nameHandle);

		public abstract bool DestroyMarkerHandle(int nameHandle);
	}

	private class NullTelemetryClient : TelemetryClient
	{
		public override void MarkerStart(int markerId, int instanceKey = 0, long timestampMs = -1L)
		{
		}

		public override void MarkerPointCached(int markerId, int nameHandle, int instanceKey = 0, long timestampMs = -1L)
		{
		}

		public override void MarkerAnnotation(int markerId, string annotationKey, string annotationValue, int instanceKey = 0)
		{
		}

		public override void MarkerEnd(int markerId, OVRPlugin.Qpl.ResultType resultTypeId = OVRPlugin.Qpl.ResultType.Success, int instanceKey = 0, long timestampMs = -1L)
		{
		}

		public override bool CreateMarkerHandle(string name, out int nameHandle)
		{
			nameHandle = default(int);
			return false;
		}

		public override bool DestroyMarkerHandle(int nameHandle)
		{
			return false;
		}
	}

	private class QPLTelemetryClient : TelemetryClient
	{
		public override void MarkerStart(int markerId, int instanceKey = 0, long timestampMs = -1L)
		{
		}

		public override void MarkerPointCached(int markerId, int nameHandle, int instanceKey = 0, long timestampMs = -1L)
		{
		}

		public override void MarkerAnnotation(int markerId, string annotationKey, string annotationValue, int instanceKey = 0)
		{
		}

		public override void MarkerEnd(int markerId, OVRPlugin.Qpl.ResultType resultTypeId = OVRPlugin.Qpl.ResultType.Success, int instanceKey = 0, long timestampMs = -1L)
		{
		}

		public override bool CreateMarkerHandle(string name, out int nameHandle)
		{
			nameHandle = default(int);
			return false;
		}

		public override bool DestroyMarkerHandle(int nameHandle)
		{
			return false;
		}
	}

	private static readonly TelemetryClient InactiveClient;

	public static readonly TelemetryClient ActiveClient;

	private static string _sdkVersionString;

	internal static bool IsActive => false;

	public static TelemetryClient Client => null;

	public static OVRTelemetryMarker Start(int markerId, int instanceKey = 0, long timestampMs = -1L)
	{
		return default(OVRTelemetryMarker);
	}

	public static void SendEvent(int markerId, OVRPlugin.Qpl.ResultType result = OVRPlugin.Qpl.ResultType.Success)
	{
	}

	public static OVRTelemetryMarker AddSDKVersionAnnotation(this OVRTelemetryMarker marker)
	{
		return default(OVRTelemetryMarker);
	}
}

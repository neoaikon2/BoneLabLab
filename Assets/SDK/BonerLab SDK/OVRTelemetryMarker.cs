using System;

internal struct OVRTelemetryMarker : IDisposable
{
	internal struct OVRTelemetryMarkerState
	{
		public bool Sent { get; set; }

		public OVRPlugin.Qpl.ResultType Result { get; set; }

		public OVRTelemetryMarkerState(bool sent, OVRPlugin.Qpl.ResultType result)
		{
			Sent = false;
			Result = default(OVRPlugin.Qpl.ResultType);
		}
	}

	private readonly OVRTelemetry.TelemetryClient _client;

	private static string _applicationIdentifier;

	private static string _unityVersion;

	private OVRTelemetryMarkerState State { get; set; }

	public bool Sent => false;

	public OVRPlugin.Qpl.ResultType Result => default(OVRPlugin.Qpl.ResultType);

	public int MarkerId { get; }

	public int InstanceKey { get; }

	private static string ApplicationIdentifier => null;

	private static string UnityVersion => null;

	public OVRTelemetryMarker(int markerId, int instanceKey = 0, long timestampMs = -1L)
	{
		State = default(OVRTelemetryMarkerState);
		MarkerId = 0;
		InstanceKey = 0;
		_client = null;
	}

	internal OVRTelemetryMarker(OVRTelemetry.TelemetryClient client, int markerId, int instanceKey = 0, long timestampMs = -1L)
	{
		State = default(OVRTelemetryMarkerState);
		MarkerId = 0;
		InstanceKey = 0;
		_client = null;
	}

	public OVRTelemetryMarker SetResult(OVRPlugin.Qpl.ResultType result)
	{
		return default(OVRTelemetryMarker);
	}

	public OVRTelemetryMarker AddAnnotation(string annotationKey, string annotationValue)
	{
		return default(OVRTelemetryMarker);
	}

	public OVRTelemetryMarker AddAnnotationIfNotNullOrEmpty(string annotationKey, string annotationValue)
	{
		return default(OVRTelemetryMarker);
	}

	public OVRTelemetryMarker Send()
	{
		return default(OVRTelemetryMarker);
	}

	public OVRTelemetryMarker SendIf(bool condition)
	{
		return default(OVRTelemetryMarker);
	}

	public OVRTelemetryMarker AddPoint(OVRTelemetry.MarkerPoint point)
	{
		return default(OVRTelemetryMarker);
	}

	public void Dispose()
	{
	}
}

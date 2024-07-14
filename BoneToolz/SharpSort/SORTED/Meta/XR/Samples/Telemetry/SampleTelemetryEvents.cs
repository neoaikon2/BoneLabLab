namespace Meta.XR.Samples.Telemetry
{
	internal static class SampleTelemetryEvents
	{
		public static class EventTypes
		{
			public const int Open = 163055403;

			public const int Close = 163056880;

			public const int Run = 163061602;
		}

		public static class AnnotationTypes
		{
			public const string Sample = "Sample";

			public const string TimeSpent = "TimeSpent";

			public const string TimeSinceEditorStart = "TimeSinceEditorStart";

			public const string BuildTarget = "BuildTarget";

			public const string RuntimePlatform = "RuntimePlatform";

			public const string InEditor = "InEditor";
		}
	}
}

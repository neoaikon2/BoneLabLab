internal static class OVRTelemetryConstants
{
	public static class OVRManager
	{
		public static class MarkerId
		{
			public const int Init = 163069401;

			public const int Consent = 163056770;
		}

		public static class AnnotationTypes
		{
			public const string ProjectName = "ProjectName";

			public const string ProjectGuid = "ProjectGuid";

			public const string Origin = "Origin";

			public const string EngineVersion = "developer_platform_version";
		}

		public enum ConsentOrigins
		{
			Popup = 0,
			Settings = 1,
			Legacy = 2
		}

		public static readonly OVRTelemetry.MarkerPoint InitializeInsightPassthrough;

		public static readonly OVRTelemetry.MarkerPoint InitPermissionRequest;
	}

	public static class Editor
	{
		public static class MarkerId
		{
			public const int Start = 163067235;

			public const int ComponentAdd = 163060094;
		}

		public static class AnnotationType
		{
			public const string ComponentName = "ComponentName";
		}
	}

	public static class BB
	{
		public static class MarkerId
		{
			public const int OpenWindow = 163062905;

			public const int AddBlock = 163060420;

			public const int UpdateBlock = 163064521;

			public const int RunBlock = 163063912;

			public const int InstallSDK = 163067801;

			public const int RemoveSDK = 163067560;

			public const int InstallBlockData = 163065449;

			public const int OpenSceneWithBlock = 163063649;
		}

		public static class AnnotationType
		{
			public const string BlockId = "BlockId";

			public const string BlockName = "BlockName";

			public const string InstanceId = "InstanceId";

			public const string Version = "Version";

			public const string ActionTrigger = "action_trigger";

			public const string Error = "error";
		}
	}
}

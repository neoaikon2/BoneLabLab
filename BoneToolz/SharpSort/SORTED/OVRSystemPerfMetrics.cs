using UnityEngine;

public class OVRSystemPerfMetrics
{
	public class PerfMetrics
	{
		public int frameCount;

		public float frameTime;

		public float deltaFrameTime;

		public bool appCpuTime_IsValid;

		public float appCpuTime;

		public bool appGpuTime_IsValid;

		public float appGpuTime;

		public bool compositorCpuTime_IsValid;

		public float compositorCpuTime;

		public bool compositorGpuTime_IsValid;

		public float compositorGpuTime;

		public bool compositorDroppedFrameCount_IsValid;

		public int compositorDroppedFrameCount;

		public bool compositorSpaceWarpMode_IsValid;

		public int compositorSpaceWarpMode;

		public bool systemGpuUtilPercentage_IsValid;

		public float systemGpuUtilPercentage;

		public bool systemCpuUtilAveragePercentage_IsValid;

		public float systemCpuUtilAveragePercentage;

		public bool systemCpuUtilWorstPercentage_IsValid;

		public float systemCpuUtilWorstPercentage;

		public bool deviceCpuClockFrequencyInMHz_IsValid;

		public float deviceCpuClockFrequencyInMHz;

		public bool deviceGpuClockFrequencyInMHz_IsValid;

		public float deviceGpuClockFrequencyInMHz;

		public bool deviceCpuClockLevel_IsValid;

		public int deviceCpuClockLevel;

		public bool deviceGpuClockLevel_IsValid;

		public int deviceGpuClockLevel;

		public bool[] deviceCpuCoreUtilPercentage_IsValid;

		public float[] deviceCpuCoreUtilPercentage;

		public string ToJSON()
		{
			return null;
		}

		public bool LoadFromJSON(string json)
		{
			return false;
		}
	}

	public class OVRSystemPerfMetricsTcpServer : MonoBehaviour
	{
		public static OVRSystemPerfMetricsTcpServer singleton;

		private OVRNetwork.OVRNetworkTcpServer tcpServer;

		public int listeningPort;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		public PerfMetrics GatherPerfMetrics()
		{
			return null;
		}
	}

	public const int TcpListeningPort = 32419;

	public const int PayloadTypeMetrics = 100;

	public const int MaxBufferLength = 65536;

	public const int MaxMessageLength = 65532;
}

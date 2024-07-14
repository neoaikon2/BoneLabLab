using System.Collections.Generic;
using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_haptics")]
public static class OVRHaptics
{
	public static class Config
	{
		public static int SampleRateHz { get; private set; }

		public static int SampleSizeInBytes { get; private set; }

		public static int MinimumSafeSamplesQueued { get; private set; }

		public static int MinimumBufferSamplesCount { get; private set; }

		public static int OptimalBufferSamplesCount { get; private set; }

		public static int MaximumBufferSamplesCount { get; private set; }

		static Config()
		{
		}

		public static void Load()
		{
		}
	}

	public class OVRHapticsChannel
	{
		private OVRHapticsOutput m_output;

		public OVRHapticsChannel(uint outputIndex)
		{
		}

		public void Preempt(OVRHapticsClip clip)
		{
		}

		public void Queue(OVRHapticsClip clip)
		{
		}

		public void Mix(OVRHapticsClip clip)
		{
		}

		public void Clear()
		{
		}
	}

	private class OVRHapticsOutput
	{
		private class ClipPlaybackTracker
		{
			public int ReadCount { get; set; }

			public OVRHapticsClip Clip { get; set; }

			public ClipPlaybackTracker(OVRHapticsClip clip)
			{
			}
		}

		private bool m_lowLatencyMode;

		private bool m_paddingEnabled;

		private int m_prevSamplesQueued;

		private float m_prevSamplesQueuedTime;

		private int m_numPredictionHits;

		private int m_numPredictionMisses;

		private int m_numUnderruns;

		private List<ClipPlaybackTracker> m_pendingClips;

		private uint m_controller;

		private OVRNativeBuffer m_nativeBuffer;

		private OVRHapticsClip m_paddingClip;

		private int PrevSampleRateHz;

		public OVRHapticsOutput(uint controller)
		{
		}

		public void Process()
		{
		}

		public void Preempt(OVRHapticsClip clip)
		{
		}

		public void Queue(OVRHapticsClip clip)
		{
		}

		public void Mix(OVRHapticsClip clip)
		{
		}

		public void Clear()
		{
		}
	}

	public static readonly OVRHapticsChannel[] Channels;

	public static readonly OVRHapticsChannel LeftChannel;

	public static readonly OVRHapticsChannel RightChannel;

	private static readonly OVRHapticsOutput[] m_outputs;

	static OVRHaptics()
	{
	}

	public static void Process()
	{
	}
}

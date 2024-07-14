using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_haptics_clip")]
public class OVRHapticsClip
{
	public int Count { get; private set; }

	public int Capacity { get; private set; }

	public byte[] Samples { get; private set; }

	public OVRHapticsClip()
	{
	}

	public OVRHapticsClip(int capacity)
	{
	}

	public OVRHapticsClip(byte[] samples, int samplesCount)
	{
	}

	public OVRHapticsClip(OVRHapticsClip a, OVRHapticsClip b)
	{
	}

	public OVRHapticsClip(AudioClip audioClip, int channel = 0)
	{
	}

	public void WriteSample(byte sample)
	{
	}

	public void Reset()
	{
	}

	private void InitializeFromAudioFloatTrack(float[] sourceData, double sourceFrequency, int sourceChannelCount, int sourceChannel)
	{
	}
}

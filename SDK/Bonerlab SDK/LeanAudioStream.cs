using UnityEngine;

public class LeanAudioStream
{
	public int position;

	public AudioClip audioClip;

	public float[] audioArr;

	public LeanAudioStream(float[] audioArr)
	{
	}

	public void OnAudioRead(float[] data)
	{
	}

	public void OnAudioSetPosition(int newPosition)
	{
	}
}

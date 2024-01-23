using System.Runtime.InteropServices;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SLZAudioRouting : MonoBehaviour
{
	public int target;

	private bool ready;

	[PreserveSig]
	private static extern void Routing_GetData(int target, float[] data, int numsamples, int numchannels);

	private void Start()
	{
	}

	private void OnAudioFilterRead(float[] data, int numchannels)
	{
	}
}

using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

public class SimpleSFX : MonoBehaviour
{
	public enum PlayBehavior
	{
		random = 0,
		order = 1,
		single = 2
	}

	public GameObject audioPlacementOverride;

	public AudioMixerGroup mixerGroup;

	public AudioClip[] simpleClip;

	[Range(0f, 1f)]
	[Tooltip("Is the sound 2d or 3d?")]
	public float spatialBlend;

	[Tooltip("Radius of min sphere")]
	[Range(0.1f, 10f)]
	public float sourceRadius;

	[Range(0f, 1f)]
	[Tooltip("Higher than 1 numbers increase min sphere by 1 meter per unit over 1")]
	public float volume;

	private AudioPlayer _ap;

	private int _last_clip;

	public bool isLooping;

	public PlayBehavior playBehavior;

	public AudioPlayer audioPlayer => null;

	private void Start()
	{
	}

	public void SIMPLEPLAY(int clipSpecific = 0)
	{
	}

	public void SAMPLEPLAY(AudioClip sampleOverride)
	{
	}

	public void RANDOMPLAY()
	{
	}

	public void AUDIOPLAY(int clipSpecific = 0, PlayBehavior behavior = PlayBehavior.order, AudioClip clipOverride = null, Transform location = null)
	{
	}

	private void PlayAudio(AudioClip clipToPlay, Transform location = null, bool following = true)
	{
	}
}

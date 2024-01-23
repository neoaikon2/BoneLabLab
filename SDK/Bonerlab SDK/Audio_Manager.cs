using UnityEngine;
using UnityEngine.Audio;

public class Audio_Manager : MonoBehaviour
{
	public AudioMixer audioMixer;

	public float audio_GlobalVolume;

	public float audio_MusicVolume;

	public float audio_SFXVolume;

	public float audio_Master
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float audio_Music
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float audio_SFX
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void LPF(float lpf)
	{
	}

	public void SETMIXERS()
	{
	}
}

using SLZ.Player;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Control_UI_PopUpMenu : MonoBehaviour
	{
		[Header("SETTINGS")]
		public float offset_Pos;

		public Vector3 offset_Rot;

		public Transform parentTransfrom;

		public Transform spawnFromTransform;

		[Header("MODULES")]
		[Space(10f)]
		public GameObject ui_Core;

		[Space(10f)]
		[Header("BUTTONS")]
		public GameObject[] but_Compass;

		[Space(10f)]
		[Header("SELECTION ")]
		public AudioClip[] clips_Confirm;

		public AudioClip[] clips_Deny;

		public AudioClip[] clips_Clicks;

		public AudioClip[] clips_Hover;

		public AudioClip[] clips_Activate;

		public AudioClip[] clips_Deactivate;

		private Haptor haptor;

		private AudioSource src_Audio;

		public bool leftHand { get; set; }

		private void Start()
		{
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}

		public void BUTTON_Cancel()
		{
		}

		private void PlayAudio(AudioClip clipToPlay)
		{
		}

		private void Click(bool down = false)
		{
		}

		private void Hover()
		{
		}
	}
}

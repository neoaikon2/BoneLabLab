using SLZ.Rig;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class UIRig : MonoBehaviour
	{
		public OpenControllerRig openCtrlRig;

		public PopUpMenuView popUpMenu;

		public UI_HUD uiHud;

		public Transform[] scaleOffset;

		[HideInInspector]
		public float cur_avatarArmScaleMult;

		public Control_Player controlPlayer;

		public Feedback_Audio feedbackAudio;

		public Feedback_Tactile feedbackTactile;

		private float standardArmLength;

		private float uiScale;

		public static UIRig Instance { get; private set; }

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Awake()
		{
		}

		private void EarlyUpdate()
		{
		}

		public void UI_AVATARSCALE(float armLength)
		{
		}
	}
}
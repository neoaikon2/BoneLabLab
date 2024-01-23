using System.Runtime.CompilerServices;
using SLZ.Bonelab;
using SLZ.UI;
using UnityEngine;

namespace SLZ.Rig
{
	public class UIRig : MonoBehaviour
	{
		public RigManager manager;

		[CompilerGenerated]
		private static UIRig _003CInstance_003Ek__BackingField;

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

		public static UIRig Instance
		{
			[CompilerGenerated]
			get
			{
				return _003CInstance_003Ek__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				_003CInstance_003Ek__BackingField = (UIRig)value;
			}
		}

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

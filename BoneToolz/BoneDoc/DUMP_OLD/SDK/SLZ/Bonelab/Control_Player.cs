using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace SLZ.Bonelab
{
	public class Control_Player : MonoBehaviour
	{
		public UIRig uiRig;

		[HideInInspector]
		public BodyVitals body_vitals;

		[HideInInspector]
		public float stored_offset_Sitting;

		public RigScreenOptions rigScreen;

		public UniversalRenderPipelineAsset CustomPipelineAsset;

		public bool toolTipDisplay
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int physicsUpdateRate
		{
			get
			{
				return default(int);
			}
		}

		public void OnEnable()
		{
		}

		private void Startup()
		{
		}

		public void STANDING()
		{
		}

		public void SendHeight()
		{
		}

		public void UpdateSpectator()
		{
		}

		public void SEND_GRAPHICS()
		{
		}

		public void SEND_VITALS()
		{
		}

		public void AUDIOUPDATE()
		{
		}

		public void SEND_BODYLOG_VITALS()
		{
		}

		public Control_Player()
			: base()
		{
		}
	}
}

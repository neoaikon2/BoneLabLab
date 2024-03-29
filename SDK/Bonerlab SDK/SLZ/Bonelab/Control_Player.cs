using SLZ.Rig;
using SLZ.SaveData;
using SLZ.VRMK;
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

		public Audio_Manager audioManager;

		public Control_GlobalTime control_GlobalTime;

		public UniversalRenderPipelineAsset CustomPipelineAsset;

		public bool toolTipDisplay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int physicsUpdateRate => 0;

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		private void InstanceOnDataManagerEventPublished(object sender, DataManagerEventArgs args)
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
	}
}

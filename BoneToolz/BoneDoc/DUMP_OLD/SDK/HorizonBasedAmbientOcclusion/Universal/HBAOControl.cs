using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace HorizonBasedAmbientOcclusion.Universal
{
	public class HBAOControl : MonoBehaviour
	{
		public VolumeProfile postProcessProfile;

		public Slider aoRadiusSlider;

		private bool m_HbaoDisplayed;

		public void Start()
		{
		}

		public void ToggleHBAO()
		{
		}

		public void ToggleShowAO()
		{
		}

		public void UpdateAoRadius()
		{
		}

		public HBAOControl()
			: base()
		{
		}
	}
}

using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Endpoints/VoidLogic Sound Player")]
	public class SoundPlayer : MonoBehaviour, InputDescribable
	{
		[Tooltip("Previous node in the chain")]
		[SerializeField]
		private BaseNode _previousNode;

		[SerializeField]
		private AnimationCurve _curve;

		private float _priorValue;

		protected bool _wasOn;

		[Header("Audio")]
		[SerializeField]
		private AudioMixerGroup _mixerGroup;

		[SerializeField]
		private AudioClip _onSound;

		[SerializeField]
		private AudioClip _offSound;

		private static readonly IReadOnlyList<InputDescription> _inputs;

		public BaseNode PreviousNode => null;

		private void Update()
		{
		}

		public void AppendEndpointInfo(StringBuilder sb)
		{
		}

		private IReadOnlyList<InputDescription> SLZ_002EMarrow_002EVoidLogic_002EInputDescribable_002EDescribeInputs()
		{
			return null;
		}

		public IReadOnlyList<InputDescription> DescribeInputs()
		{
			throw new System.NotImplementedException();
		}
	}
}

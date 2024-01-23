using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Endpoints/VoidLogic Tone Generator")]
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/ToneGenerator")]
	public class ToneGenerator : MonoBehaviour, InputDescribable
	{
		[Tooltip("Previous node(s) in the chain")]
		[SerializeField]
		protected List<BaseNode> _previous;

		[Range(0f, 1f)]
		[SerializeField]
		private float _volume;

		[SerializeField]
		private AnimationCurve _curve;

		private float _frequency;

		private int _sampleRate;

		private float _phase;

		private bool _running;

		private static readonly IReadOnlyList<InputDescription> _inputs;

		public List<BaseNode> PreviousNodes
		{
			get
			{
				return null;
			}
		}

		public float Volume
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		public void AppendEndpointInfo(StringBuilder sb)
		{
		}

		IReadOnlyList<InputDescription> InputDescribable.DescribeInputs()
		{
			return null;
		}

		public ToneGenerator()
			: base()
		{
		}
	}
}

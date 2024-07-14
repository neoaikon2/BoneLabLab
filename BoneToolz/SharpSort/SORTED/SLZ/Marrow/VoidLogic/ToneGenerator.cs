using SLZ.Algorithms.Unity;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/ToneGenerator")]
	[AddComponentMenu("VoidLogic/Sinks/VoidLogic Tone Generator")]
	[Support(SupportFlags.AlphaSupported, "This is intended mainly for debugging, and as such its serialization compatibility is not guaranteed.")]
	public class ToneGenerator : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		[SerializeField]
		[Interface(typeof(IVoidLogicSource), false)]
		[Tooltip("Previous node(s) in the chain")]
		protected internal MonoBehaviour[] _previous;

		[Range(0f, 1f)]
		[SerializeField]
		private float _volume;

		[SerializeField]
		private AnimationCurve _curve;

		private float _frequency;

		private int _sampleRate;

		private float _phase;

		private bool _running;

		private static readonly PortMetadata _portMetadata;

		[field: SerializeField]
		[field: ReadOnly(false)]
		public VoidLogicSubgraph Subgraph { get; set; }

		public float Volume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int InputCount => 0;

		public PortMetadata PortMetadata => default(PortMetadata);

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		private void SLZ_002EMarrow_002EVoidLogic_002EIVoidLogicActuator_002EActuate(ref NodeState nodeState)
		{
		}

		private void OnAudioFilterRead(float[] data, int channels)
		{
		}

		public bool TryGetInputAtIndex(uint idx, out IVoidLogicSource input)
		{
			input = null;
			return false;
		}

		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return false;
		}

		public void Actuate(ref NodeState nodeState)
		{
			throw new System.NotImplementedException();
		}
	}
}

using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/SequencerNode")]
	[AddComponentMenu("VoidLogic/Nodes/VoidLogic Sequencer")]
	[Support(SupportFlags.AlphaSupported, "This needs to be updated to use sensors and actuators.")]
	public class SequencerNode : BaseNode
	{
		private bool _isRunning;

		private float _time;

		private float _cachedEndKeyTime;

		private float _cachedValue;

		private static readonly PortMetadata _portMetadata;

		private AnimationCurve Sequence { get; set; }

		public bool RealTime { get; private set; }

		public float TimeScale { get; private set; }

		public bool Loop { get; private set; }

		public bool ResetTimeOnSequenceCompletion { get; private set; }

		private EdgeDetector StartEdgeDetector { get; set; }

		private EdgeDetector ResetEdgeDetector { get; set; }

		public override PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public override void Calculate(NodeState nodeState)
		{
		}

		public SequencerNode()
			: base()
		{
		}
	}
}

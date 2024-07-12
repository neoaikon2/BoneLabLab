using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Algorithms.Unity;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu("VoidLogic/Sinks/VoidLogic Legacy Sound Player")]
	[Support(SupportFlags.CowboySupported, "It's unclear how exactly we want to properly support playing sound. This probably isn't it, but it's supported for now.")]
	public class LegacySoundPlayer : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		[Tooltip("Previous node in the chain")]
		[SerializeField]
		[Interface(typeof(IVoidLogicSource), false)]
		private MonoBehaviour _previousNode;

		[SerializeField]
		private AnimationCurve _curve;

		private float _priorValue;

		protected bool _wasOn;

		[Header("Audio")]
		[SerializeField]
		private AudioClip _onSound;

		[SerializeField]
		private AudioClip _offSound;

		private static readonly PortMetadata _portMetadata;

		public VoidLogicSubgraph Subgraph { get; set; }

		public int InputCount
		{
			get
			{
				return default(int);
			}
		}

		public PortMetadata PortMetadata
		{
			get
			{
				return default(PortMetadata);
			}
		}

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

		void IVoidLogicActuator.Actuate(NodeState nodeState)
		{
		}

		public bool TryGetInputAtIndex(uint idx, [Out] IVoidLogicSource input)
		{
			return default(bool);
		}

		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return default(bool);
		}

		public LegacySoundPlayer()
			: base()
		{
		}
	}
}

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Algorithms.Unity;
using UltEvents;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[HelpURL("https://github.com/StressLevelZero/MarrowSDK/wiki/VoidLogic/EventAdapter")]
	[AddComponentMenu("VoidLogic/Sinks/VoidLogic Event Adapter")]
	[Support(SupportFlags.Supported, "<b>Reminder</b>: Is there a better way to do this?")]
	public sealed class EventAdapter : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		[Tooltip("Previous node in the chain")]
		[Interface(typeof(IVoidLogicSource), false)]
		[SerializeField]
		private MonoBehaviour _previousNode;

		[SerializeField]
		private float lowThreshold;

		[SerializeField]
		private float highThreshold;

		[Tooltip("When the input value changes (EXPENSIVE, runs all callbacks on every value update)")]
		[Header("Events")]
		public UltEvent<EventAdapter, IVoidLogicSource, float> InputUpdated;

		[Tooltip("When the input value rises above the high threshold")]
		public UltEvent<EventAdapter, IVoidLogicSource, float> InputRose;

		[Tooltip("When the input value holds above the high threshold")]
		public UltEvent<EventAdapter, IVoidLogicSource, float> InputHeld;

		[Tooltip("When the input value lowers beneath the low threshold")]
		public UltEvent<EventAdapter, IVoidLogicSource, float> InputFell;

		[Tooltip("When the input value rises above the high threshold (for the first time only)")]
		public UltEvent<EventAdapter, IVoidLogicSource, float> InputRoseOneShot;

		private float _priorValue;

		private bool _isHigh;

		private bool _hasBeenHigh;

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

		private void Start()
		{
		}

		void IVoidLogicActuator.Actuate(NodeState nodeState)
		{
		}

		private void _invokeInputUpdated(IVoidLogicSource source, float f)
		{
		}

		private void _invokeInputRose(IVoidLogicSource source, float f)
		{
		}

		private void _invokeInputRoseOneShot(IVoidLogicSource source, float f)
		{
		}

		private void _invokeInputFell(IVoidLogicSource source, float f)
		{
		}

		private void _invokeInputHeld(IVoidLogicSource source, float f)
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

		public EventAdapter()
			: base()
		{
		}
	}
}

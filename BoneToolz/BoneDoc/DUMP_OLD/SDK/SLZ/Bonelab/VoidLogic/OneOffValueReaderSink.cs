using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.VoidLogic;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[AddComponentMenu("VoidLogic/Bonelab/Internal Only/VoidLogic Value Reader One-off Sink")]
	[Support(SupportFlags.CowboySupported, "This is a one-off. Your bugs are your own unless or until we have a plan to generalize this into Marrow.")]
	public sealed class OneOffValueReaderSink : MonoBehaviour, IVoidLogicSink, IVoidLogicNode
	{
		[Tooltip("Previous node in the chain")]
		[Interface(typeof(IVoidLogicSource), false)]
		[SerializeField]
		private MonoBehaviour _previousNode;

		private float _priorValue;

		[SerializeField]
		private TextMeshPro tmp;

		public string labelText;

		private static readonly PortMetadata _portMetadata;

		public VoidLogicSubgraph Subgraph { get; set; }

		public int InputCount
		{
			get
			{
				return default(int);
			}
		}

		PortMetadata IVoidLogicNode.PortMetadata
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

		private void Update()
		{
		}

		private void UpdateText()
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

		public OneOffValueReaderSink()
			: base()
		{
		}
	}
}

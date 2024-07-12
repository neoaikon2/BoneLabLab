using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Algorithms.Unity;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	[Support(SupportFlags.Unsupported, "This is a one-off for testing.")]
	[AddComponentMenu(null)]
	public sealed class OneOffDriveEuler : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicActuator
	{
		[Interface(typeof(IVoidLogicSource), false)]
		[SerializeField]
		[Tooltip("Previous node(s) in the chain")]
		internal MonoBehaviour[] _previous;

		[SerializeField]
		private ConfigurableJoint target;

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

		public void Actuate(NodeState nodeState)
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

		public OneOffDriveEuler()
			: base()
		{
		}
	}
}

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Algorithms.Unity;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	public abstract class BaseNode : MonoBehaviour, IVoidLogicSink, IVoidLogicNode, IVoidLogicSource
	{
		[Tooltip("Previous node(s) in the chain")]
		[SerializeField]
		[Interface(typeof(IVoidLogicSource), false)]
		protected internal MonoBehaviour[] _previous;

		public VoidLogicSubgraph Subgraph { get; set; }

		public abstract PortMetadata PortMetadata { get; }

		public int InputCount
		{
			get
			{
				return default(int);
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected static bool EqualWithTolerance(float term1, float term2, float tolerance)
		{
			return default(bool);
		}

		public bool TryGetInputAtIndex(uint idx, [Out] IVoidLogicSource input)
		{
			return default(bool);
		}

		public bool TrySetInputAtIndex(uint idx, IVoidLogicSource input)
		{
			return default(bool);
		}

		public abstract void Calculate(NodeState nodeState);

		public BaseNode()
			: base()
		{
		}
	}
}

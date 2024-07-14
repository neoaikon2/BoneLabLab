using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu(null)]
	public class VoidLogicSubgraph : MonoBehaviour
	{
		internal Dictionary<MonoBehaviour, int> _node2Index;

		[field: SerializeField]
		public bool Enabled { get; private set; }

		[field: SerializeField]
		public bool Valid { get; internal set; }

		[field: SerializeField]
		public MonoBehaviour[] Nodes { get; internal set; }

		[field: SerializeField]
		public MonoBehaviour[] Sensors { get; internal set; }

		[field: SerializeField]
		public MonoBehaviour[] Sources { get; internal set; }

		[field: SerializeField]
		public MonoBehaviour[] Actuators { get; internal set; }

		[field: SerializeField]
		internal NodeState[] CachedStates { get; set; }

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Reset()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public int ProcessSubgraph()
		{
			return 0;
		}

		public void EnableNode(MonoBehaviour nodeMb)
		{
		}

		public void DisableMode(MonoBehaviour nodeMb)
		{
		}
	}
}

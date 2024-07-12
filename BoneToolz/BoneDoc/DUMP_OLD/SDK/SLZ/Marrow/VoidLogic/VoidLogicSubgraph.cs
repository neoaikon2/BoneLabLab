using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	[AddComponentMenu(null)]
	public class VoidLogicSubgraph : MonoBehaviour
	{
		internal Dictionary<MonoBehaviour, int> _node2Index;

		public bool Enabled { get; private set; }

		public bool Valid { get; internal set; }

		public MonoBehaviour[] Nodes { get; internal set; }

		public MonoBehaviour[] Sensors { get; internal set; }

		public MonoBehaviour[] Sources { get; internal set; }

		public MonoBehaviour[] Actuators { get; internal set; }

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
			return default(int);
		}

		public void EnableNode(MonoBehaviour nodeMb)
		{
		}

		public void DisableMode(MonoBehaviour nodeMb)
		{
		}

		public VoidLogicSubgraph()
			: base()
		{
		}
	}
}

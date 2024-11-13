using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.VoidLogic;
using UnityEngine;

namespace SLZ.Bonelab.VoidLogic
{
	public class SubgraphTracker : MonoBehaviour
	{
		[HideInInspector]
		[SerializeField]
		private bool _deprecated;

		private bool _wasEnabled;

		private Mesh _quadMesh;

		private Dictionary<(IVoidLogicSource from, IVoidLogicSink to), LineRenderer> _lineRenderers;

		private Dictionary<IVoidLogicNode, (GameObject, MaterialPropertyBlock)> _icons;

		[field: SerializeField]
		public VoidLogicToolSettings ToolSettings { get; set; }

		[field: ReadOnly(false)]		
		[field: SerializeField]
		public VoidLogicSubgraph Subgraph { get; set; }

		public bool Deprecated => false;

		[field: ReadOnly(false)]
		[field: SerializeField]
		public GameObject LineRenderersGO { get; set; }

		[field: ReadOnly(false)]
		[field: SerializeField]
		public GameObject IconRenderersGO { get; set; }

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void DisplaySubgraph()
		{
		}

		private void HideSubgraph()
		{
		}
	}
}

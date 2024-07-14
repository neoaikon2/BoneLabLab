using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Interaction
{
	public class ArtCull : MarrowBehaviour
	{
		[SerializeField]
		private LODGroup[] _lodGroups;

		[SerializeField]
		private Renderer[] _renderers;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}

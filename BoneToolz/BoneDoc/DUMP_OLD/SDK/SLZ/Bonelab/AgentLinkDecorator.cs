using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(CrateSpawner))]
	public class AgentLinkDecorator : SpawnDecorator
	{
		public bool enableAgentLinking;

		public override void OnSpawn(GameObject go)
		{
		}

		public AgentLinkDecorator()
			: base()
		{
		}
	}
}

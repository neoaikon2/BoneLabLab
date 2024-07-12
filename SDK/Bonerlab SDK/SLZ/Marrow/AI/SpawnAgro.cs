using SLZ.Marrow.Interaction;
using SLZ.Marrow.PuppetMasta;
using SLZ.Marrow.Warehouse;
using SLZ.Marrow.Zones;
using UnityEngine;

namespace SLZ.Marrow.AI
{
	[RequireComponent(typeof(CrateSpawner))]
	public class SpawnAgro : ZoneLinkItem, ISpawnListenable
	{
		public enum MentalMode
		{
			INVESTIGATE = 0,
			AGRO = 1,
			NONE = 2
		}

		public CrateSpawner _crateSpawner;

		private AIBrain brain;

		private MarrowEntity activatorEntity;

		[Tooltip("Agro mental state: agro on player proxy, Investigate mental state: increase bubble and move to player position")]
		public MentalMode mentalMode;

		[Tooltip("Duration in seconds npc spends investigating player position")]
		public float investigateTimeout;

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public void OnDespawn(GameObject go)
		{
		}

		public void OnSpawn(GameObject go)
		{
		}

		public void OnDeath(AIBrain brain)
		{
		}

		public void PostReactivate(BehaviourBaseNav baseNav)
		{
		}

		protected override void OnEnter(MarrowEntity activatorEntity)
		{
		}

		public void MentalOnEnter(MarrowEntity entity)
		{
		}

		public SpawnAgro()
			: base()
		{
		}
	}
}

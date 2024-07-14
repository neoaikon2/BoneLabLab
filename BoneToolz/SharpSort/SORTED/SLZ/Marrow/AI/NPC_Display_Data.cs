using System;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;

namespace SLZ.Marrow.AI
{
	[Serializable]
	public class NPC_Display_Data
	{
		public enum NPC_State
		{
			ALIVE = 0,
			DEAD = 1,
			DESPAWNED = 2
		}

		public AIBrain brain;

		public SpawnGroup spawnGroup;

		public BehaviourBaseNav baseNav;

		public PuppetMaster puppet;

		public Texture iconImage;

		public NPC_State npcState;
	}
}

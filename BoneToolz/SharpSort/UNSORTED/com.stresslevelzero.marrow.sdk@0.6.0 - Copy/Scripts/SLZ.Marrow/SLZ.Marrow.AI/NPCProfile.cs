using SLZ.Marrow.Data;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;

namespace SLZ.Marrow.AI
{
	[CreateAssetMenu(fileName = "NPCProfile", menuName = "StressLevelZero / NPC_Profile", order = 1)]
	public class NPCProfile : ScriptableObject
	{
		public Spawnable spawnable;

		public BaseEnemyConfig baseConfig;
	}
}

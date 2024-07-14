using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.AI
{
	[CreateAssetMenu(fileName = "EncounterProfile", menuName = "StressLevelZero / EncounterProfile", order = 1)]
	public class EncounterProfile : ScriptableObject
	{
		public List<NPCProfile> npcProfileList;
	}
}

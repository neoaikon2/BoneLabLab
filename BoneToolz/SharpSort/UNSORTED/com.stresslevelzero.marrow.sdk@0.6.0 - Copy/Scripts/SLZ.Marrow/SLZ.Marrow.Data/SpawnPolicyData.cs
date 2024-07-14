using UnityEngine;

namespace SLZ.Marrow.Data
{
	[CreateAssetMenu(fileName = "Spawn Policy Data", menuName = "StressLevelZero/Spawn Policy Data")]
	public class SpawnPolicyData : ScriptableObject
	{
		public enum PolicyRule
		{
			GROW = 0,
			REUSEOLDEST = 1,
			REUSENEWEST = 2,
			REUSENONE = 3
		}

		[Tooltip("Grouping pools by crate will apply policy rules per-crate")]
		public bool groupByCrate;

		[Tooltip("Maximum size the pool will contain")]
		public int maxSize;

		[Tooltip("Determines what happens when a pool reaches the max size")]
		public PolicyRule mode;

		[Tooltip("Skips Enable/Disable phase of the poolee in cases where it is recycled on the same frame")]
		public bool canHotPool;
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public abstract class BonelabInternalGameControl : BonelabGameControl
	{
		private Dictionary<string, int> storyLevelBarcodeKeyPair;

		[field: SerializeField]
		[field: Header("BONELAB INTERNAL")]
		protected LevelCrateReference NextCampaignLevel { get; set; }

		[field: SerializeField]
		protected List<GenericCrateReference> Unlocks { get; set; }

		[field: SerializeField]
		protected double LevelLoadBufferTime { get; set; }

		public override void Awake()
		{
		}

		public void SetHubSpawnLocation(int hubSpawnLocation)
		{
		}

		public void JustJumpToLevel(LevelCrateReference level)
		{
		}

		public void LevelComplete()
		{
		}
		public UniTaskVoid LevelCompleteWithDelayAsync(TimeSpan timeSpan)
		{
			return default(UniTaskVoid);
		}

		public virtual void DoLevelComplete()
		{
		}
	}
}

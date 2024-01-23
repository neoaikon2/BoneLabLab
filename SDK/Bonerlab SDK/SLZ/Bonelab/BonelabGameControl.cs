using System;
using System.Collections.Generic;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using SLZ.SaveData;
using UnityEngine;
using UnityEngine.Serialization;

namespace SLZ.Bonelab
{
	public class BonelabGameControl : MonoBehaviour
	{
		public static readonly LevelCrateReference HubLevel;

		[Tooltip("Name of the level in the save data")]
		[field: SerializeField]
		public string LevelKey { get; protected set; }

		[Tooltip("Mark level complete after level load")]
		[field: SerializeField]
		public bool CompleteOnLoad { get; protected set; }

		[Tooltip("Does this level save completion/progress/ammo/inventory?")]
		[field: SerializeField]
		public SaveFeatures SaveFeatures { get; protected set; }

		[Tooltip("Crate reference to the loading screen level")]
		[field: SerializeField]
		public LevelCrateReference LoadScreenLevel { get; protected set; }

		[Tooltip("Crate references to levels to possibly load")]
		[field: SerializeField]
		public List<LevelCrateReference> LevelJumpList { get; protected set; }

		[field: FormerlySerializedAs("rm")]
		[field: SerializeField]
		[field: Obsolete("This shouldn't be exported. See note in source code.")]
		public RigManager PlayerRigManager { get; protected set; }

		[field: SerializeField]
		public Spawnable VfxFadeOutSpawnable { get; protected set; }

		[field: SerializeField]
		protected List<string> PriorLevels { get; set; }

		[field: SerializeField]
		protected string NextLevel { get; set; }

		[field: SerializeField]
		protected List<ResumePoint> ProgressionPoint { get; set; }

		[field: SerializeField]
		public List<RegisteredSaveableInfo> RegisteredSaveables { get; set; }

		[field: SerializeField]
		public InventorySaveFilter InventorySaveFilter { get; set; }

		public int Progress { get; protected set; }

		public bool IsResuming { get; protected set; }

		public static bool IsCompleted(PlayerProgression progression, string levelKey)
		{
			return false;
		}

		public static void SetCompleted(PlayerProgression progression, string levelKey, bool completed)
		{
		}

		public virtual void Awake()
		{
		}

		public virtual void Start()
		{
		}

		public void TeleportToProgress()
		{
		}

		private void ResumeProgress()
		{
		}

		public void SetCompleted()
		{
		}

		public void SetProgress(int progress)
		{
		}

		public void FinalizeAmmo()
		{
		}

		public void FinalizeInventory()
		{
		}

		public void JustSave()
		{
		}

		public void JustJumpToLevelAtIndex(int levelIndex = 0)
		{
		}

		public void FinalizeThenJumpToLevelAtIndex(int levelIndex = 0)
		{
		}
	}
}

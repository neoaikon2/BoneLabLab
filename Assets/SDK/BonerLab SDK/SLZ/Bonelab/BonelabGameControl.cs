using System.Collections.Generic;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class BonelabGameControl : MonoBehaviour
	{
		public static readonly LevelCrateReference HubLevel;

		protected bool _isLoadCalled;

		[Tooltip("Name of the level in the save data")]
		[field: SerializeField]
		public string LevelKey { get; protected set; }

		[Tooltip("Mark level complete after level load")]
		[field: SerializeField]
		public bool CompleteOnLoad { get; protected set; }

		[Tooltip("Does this level save completion/progress/ammo/inventory?")]
		[field: SerializeField]
		public SaveFeatures SaveFeatures { get; protected set; }

		[Tooltip("Crate reference to a fadeout VFX override, if any")]
		[field: SerializeField]
		public SpawnableCrateReference FadeoutVFXOverride { get; protected set; }

		[Tooltip("Crate references to levels to possibly load")]
		[field: SerializeField]
		public List<LevelCrateReference> LevelJumpList { get; protected set; }

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

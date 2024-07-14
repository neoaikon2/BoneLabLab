using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using SLZ.Marrow.SaveData;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow
{
	public class MarrowGameControl<TDataManager, TSave, TSettings, TProgression, TUnlocks, TResumePoint> : MonoBehaviour where TDataManager : MarrowDataManager<TDataManager, TSave, TSettings, TProgression, TUnlocks> where TSave : class, ISave<TProgression, TUnlocks>, new() where TSettings : class, ISettings, new() where TProgression : class, IProgression, new() where TUnlocks : class, IUnlocks, new() where TResumePoint : IResumePoint
	{
		private static bool ShouldResumeProgressForThisLoad { get; set; }

		[Tooltip("Name of the level in the save data")]
		[field: SerializeField]
		public string LevelKey { get; protected set; }

		[Tooltip("Mark level complete after level load")]
		[field: SerializeField]
		public bool CompleteOnLoad { get; protected set; }

		public bool EnableSavingCompletion { get; protected set; }

		public bool EnableSavingPartialProgress { get; protected set; }

		[Tooltip("Crate reference to the loading screen level")]
		[field: SerializeField]
		public LevelCrateReference LoadScreenLevel { get; protected set; }

		[Tooltip("Crate references to levels to possibly load")]
		[field: SerializeField]
		public List<LevelCrateReference> LevelJumpList { get; protected set; }

		[field: SerializeField]
		protected List<TResumePoint> ProgressionPoint { get; set; }

		[field: SerializeField]
		public List<RegisteredSaveableInfo> RegisteredSaveables { get; set; }

		[field: NonSerialized]
		public int Progress { get; protected set; }

		[field: NonSerialized]
		public bool IsResumingFromProgress { get; protected set; }

		public static void ThisLoadShouldResumeProgress()
		{
		}

		public virtual void Awake()
		{
		}

		public virtual void Start()
		{
		}

		private void TeleportToProgress()
		{
		}

		private protected virtual void OnLevelResumingFromProgress()
		{
		}

		private protected virtual void OnLevelLoaded()
		{
		}

		[PublicAPI]
		public void SetCompleted()
		{
		}

		[PublicAPI]
		public void SetProgress(int progress)
		{
		}

		[PublicAPI]
		public void JustSave()
		{
		}

		[PublicAPI]
		public void JustJumpToLevelAtIndex(int levelIndex = 0)
		{
		}

		[PublicAPI]
		public void FinalizeThenJumpToLevelAtIndex(int levelIndex = 0)
		{
		}

		private protected virtual void PerformJump(int levelIndex)
		{
		}

		private protected virtual void OnLevelProgressSet()
		{
		}

		private protected virtual void OnLevelFinalize()
		{
		}
	}
}

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using SLZ.Marrow.SaveData;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow
{
	public class MarrowGameControl<TDataManager, TSave, TProgression, TUnlocks, TSettings, TResumePoint> : MonoBehaviour where TDataManager : MarrowDataManager<TDataManager, TSave, TSettings, TProgression, TUnlocks> where TSave : class, ISave<TProgression, TUnlocks>, new()where TProgression : class, IProgression, new()where TUnlocks : class, IUnlocks, new()where TSettings : class, ISettings, new()where TResumePoint : IResumePoint
	{
		private static bool ShouldResumeProgressForThisLoad { get; set; }

		[Tooltip("Name of the level in the save data")]
		public string LevelKey { get; protected set; }

		[Tooltip("Mark level complete after level load")]
		public bool CompleteOnLoad { get; protected set; }

		public bool EnableSavingCompletion { get; protected set; }

		public bool EnableSavingPartialProgress { get; protected set; }

		[Tooltip("Crate reference to the loading screen level")]
		public LevelCrateReference LoadScreenLevel { get; protected set; }

		[Tooltip("Crate references to levels to possibly load")]
		public List<LevelCrateReference> LevelJumpList { get; protected set; }

		protected List<TResumePoint> ProgressionPoint { get; set; }

		public List<RegisteredSaveableInfo> RegisteredSaveables { get; set; }

		public int Progress { get; protected set; }

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

		public MarrowGameControl()
			: base()
		{
		}
	}
}

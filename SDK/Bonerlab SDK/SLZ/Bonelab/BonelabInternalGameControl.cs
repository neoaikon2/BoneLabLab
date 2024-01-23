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
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CLevelCompleteWithDelayAsync_003Ed__16
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public TimeSpan timeSpan;

			public BonelabInternalGameControl _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[field: Header("BONELAB INTERNAL")]
		[field: SerializeField]
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

		[AsyncStateMachine(typeof(_003CLevelCompleteWithDelayAsync_003Ed__16))]
		public UniTaskVoid LevelCompleteWithDelayAsync(TimeSpan timeSpan)
		{
			return default(UniTaskVoid);
		}

		public virtual void DoLevelComplete()
		{
		}
	}
}

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Data;
using SLZ.Props.Weapons;
using UnityEngine;

public class AmmoPouchTester : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSwitchMagazine_003Ed__9
	{
		public int _003C_003E1__state;

		public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

		public AmmoPouchTester _003C_003E4__this;

		public Spawnable spawnable;

		private UniTask.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSpawnAndPlaceMagazine_003Ed__10
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public AmmoPouchTester _003C_003E4__this;

		public Spawnable spawnable;

		private Transform _003Ct_003E5__2;

		private Magazine _003Cmagazine_003E5__3;

		private UniTask<SLZ.Marrow.Pool.AssetPoolee>.Awaiter _003C_003Eu__1;

		private UniTask.Awaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public Spawnable[] magazines;

	public CartridgeData cartridge;

	private List<Magazine> _magazineArts;

	private int _curMagIdx;

	private Spawnable _nextMagazine;

	private bool _isSwitching;

	private bool _hasMagazineInQueue;

	[ContextMenu("TestSwitch")]
	private void TestSwitch()
	{
	}

	[ContextMenu("TestSwitchSpam")]
	private void TestSwitchSpam()
	{
	}

	[AsyncStateMachine(typeof(_003CSwitchMagazine_003Ed__9))]
	private UniTaskVoid SwitchMagazine(Spawnable spawnable)
	{
		return default(UniTaskVoid);
	}

	[AsyncStateMachine(typeof(_003CSpawnAndPlaceMagazine_003Ed__10))]
	private UniTask SpawnAndPlaceMagazine(Spawnable spawnable)
	{
		return default(UniTask);
	}
}

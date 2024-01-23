using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Warehouse;
using SLZ.Mods;
using SLZ.Rig;
using SLZ.VRMK;
using UnityEngine;

public class Mirror : MonoBehaviour
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSwapReflectionAvatar_003Ed__14
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public Mirror _003C_003E4__this;

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
	private struct _003CSwapReflectionAvatar_003Ed__15
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public string barcode;

		public Mirror _003C_003E4__this;

		private AvatarCrate _003Ccrate_003E5__2;

		private UniTask<AvatarCrate>.Awaiter _003C_003Eu__1;

		private UniTask<GameObject>.Awaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[ReadOnly(false)]
	public RigManager rigManager;

	[SerializeField]
	[ReadOnly(false)]
	private SLZ.VRMK.Avatar _reflection;

	[SerializeField]
	private BonelabSerializableDictionaries.StringAvatarDictionary _cachedReflections;

	[SerializeField]
	private Transform _reflectTran;

	[SerializeField]
	private Transform _avatarsTran;

	[SerializeField]
	private Transform _reflectionInitalTran;

	[SerializeField]
	public UniTask.Awaiter globalAwaiter;

	private Action swapperAction;

	public SLZ.VRMK.Avatar Reflection => null;

	private void OnTriggerEnter(Collider c)
	{
	}

	private void OnTriggerExit(Collider c)
	{
	}

	private void LateUpdate()
	{
	}

	private void WriteTransforms()
	{
	}

	[AsyncStateMachine(typeof(_003CSwapReflectionAvatar_003Ed__14))]
	private UniTask SwapReflectionAvatar()
	{
		return default(UniTask);
	}

	[AsyncStateMachine(typeof(_003CSwapReflectionAvatar_003Ed__15))]
	private UniTask SwapReflectionAvatar(string barcode)
	{
		return default(UniTask);
	}
}

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public sealed class PatchNotesLoader : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetPatchNotes_003Ed__16
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public PatchNotesLoader _003C_003E4__this;

			private UniTask<UnityEngine.Networking.UnityWebRequest>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[CompilerGenerated]
		private static string _003CCachedPatchNotes_003Ek__BackingField;

		[SerializeField]
		private string backupPatchNotes;

		[field: SerializeField]
		private TMP_Text tmp_PatchNotes { get; set; }

		[field: SerializeField]
		private string PatchName { get; set; }

		private static string CachedPatchNotes
		{
			[CompilerGenerated]
			get
			{
				return _003CCachedPatchNotes_003Ek__BackingField;
			}
			[CompilerGenerated]
			set
			{
				_003CCachedPatchNotes_003Ek__BackingField = "";
			}
		}

		private string PatchUrl => null;

		private void Awake()
		{
		}

		[AsyncStateMachine(typeof(_003CGetPatchNotes_003Ed__16))]
		private UniTaskVoid GetPatchNotes()
		{
			return default(UniTaskVoid);
		}
	}
}

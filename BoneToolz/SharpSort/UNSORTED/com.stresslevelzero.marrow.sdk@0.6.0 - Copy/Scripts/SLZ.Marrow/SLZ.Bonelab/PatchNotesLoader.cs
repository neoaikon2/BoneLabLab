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
		[SerializeField]
		private string backupPatchNotes;

		[field: SerializeField]
		private TMP_Text tmp_PatchNotes { get; set; }

		[field: SerializeField]
		private string PatchName { get; set; }

		private static string CachedPatchNotes { get; set; }

		private string PatchUrl => null;

		private void Awake()
		{
		}
		private UniTaskVoid GetPatchNotes()
		{
			return default(UniTaskVoid);
		}
	}
}

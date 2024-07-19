using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PlayerAvatarManager : MonoBehaviour
	{
		public bool loadAvatarFromSaveData;

		private bool _hasAvatarOverride;

		private void Start()
		{
		}
		public UniTask LoadAvatarFromSaveDataAsync()
		{
			return default(UniTask);
		}

		public void OverrideAvatar(Barcode barcode, bool cached)
		{
		}
	}
}

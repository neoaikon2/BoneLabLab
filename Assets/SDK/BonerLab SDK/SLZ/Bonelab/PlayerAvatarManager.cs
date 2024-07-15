using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PlayerAvatarManager : MonoBehaviour
	{
		public RigManager rigManager;

		public bool loadAvatarFromSaveData;

		private bool _hasAvatarOverride;

		private void Start()
		{
		}
		public UniTask LoadAvatarFromSaveDataAsync()
		{
			return default(UniTask);
		}

		public void OverrideAvatar(string barcode, bool cached)
		{
		}
	}
}

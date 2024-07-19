using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class RandomAvatar : MonoBehaviour
	{
		public RigManager rm;

		[Header("Avatars")]
		public AvatarCrateReference[] avatarCrates;

		public void RANDOMAVATAR()
		{
		}
		private UniTaskVoid SwapAvatar(AvatarCrate avatarCrate)
		{
			return default(UniTaskVoid);
		}
	}
}

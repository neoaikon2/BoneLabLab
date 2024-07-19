using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class LoadMenuScene : MonoBehaviour
	{
		public LevelCrateReference MenuHollowCrateRef;

		public LevelCrateReference VoidG114CrateRef;

		private static PlayerProgression p => null;
		public UniTaskVoid Load()
		{
			return default(UniTaskVoid);
		}
	}
}

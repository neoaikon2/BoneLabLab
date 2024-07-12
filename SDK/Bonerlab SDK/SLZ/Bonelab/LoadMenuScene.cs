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

		public LevelCrateReference LevelLoaderCrateRef;

		private static PlayerProgression p
		{
			get
			{
				return null;
			}
		}

		public UniTaskVoid Load()
		{
			return default(UniTaskVoid);
		}

		public LoadMenuScene()
			: base()
		{
		}
	}
}

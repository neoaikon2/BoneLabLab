using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Warehouse;
using TMPro;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class SceneBootstrapper_Bonelab : MonoBehaviour
	{
		public LevelCrateReference ShaderPrewarmCrateRef;

		public LevelCrateReference MenuHollowCrateRef;

		public LevelCrateReference VoidG114CrateRef;

		public TextMeshProUGUI tmp;

		public GameObject Overlay2d;

		public Mesh ReplacementCube;

		private static PlayerProgression p => null;
		private UniTaskVoid Start()
		{
			return default(UniTaskVoid);
		}

		private void UpdateLog(string msg)
		{
		}
	}
}

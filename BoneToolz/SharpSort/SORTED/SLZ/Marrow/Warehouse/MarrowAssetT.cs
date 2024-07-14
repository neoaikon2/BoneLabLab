using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class MarrowAssetT<TObject> : MarrowAsset where TObject : UnityEngine.Object
	{
		public new TObject Asset => null;

		public override Type AssetType => null;

		public MarrowAssetT()
		{
		}

		public MarrowAssetT(string guid)
		{
		}
		public UniTask<TObject> LoadAssetAsync()
		{
			return default(UniTask<TObject>);
		}

		public void LoadAsset(Action<TObject> loadCallback)
		{
		}
	}
}

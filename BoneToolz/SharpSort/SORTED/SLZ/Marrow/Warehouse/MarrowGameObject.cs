using System;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class MarrowGameObject : MarrowAssetT<GameObject>
	{
		public MarrowGameObject()
		{
		}

		public MarrowGameObject(string guid)
		{
		}

		protected override void InitialAssetModifications<TObject>(TObject resultResult)
		{
		}
	}
}

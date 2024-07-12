using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using SLZ.Serialize;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	public abstract class DataCard : Scannable
	{
		[NonSerialized]
		private Pallet _pallet;

		[SerializeField]
		private MarrowAssetT<DataCard> _dataCardAsset;

		public Pallet Pallet
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MarrowAssetT<DataCard> DataCardAsset
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void GenerateBarcodeInternal(bool forceGeneration = false)
		{
		}

		public virtual bool IsBundledDataCard()
		{
			return default(bool);
		}

		public override void ImportPackedAssets(Dictionary<string, PackedAsset> packedAssets)
		{
		}

		public override List<PackedAsset> ExportPackedAssets()
		{
			return null;
		}

		public override void Pack(ObjectStore store, JObject json)
		{
		}

		public override void Unpack(ObjectStore store, string objectId)
		{
		}

		public static DataCard CreateDataCard(Type type, Pallet pallet, string title, bool generateBarcode = true)
		{
			return null;
		}

		public static T CreateDataCard<T>(Pallet pallet, string title, bool generateBarcode = true) where T : DataCard
		{
			return null;
		}

		public DataCard()
			: base()
		{
		}
	}
}

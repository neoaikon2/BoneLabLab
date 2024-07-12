using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Newtonsoft.Json.Linq;
using SLZ.Marrow.Utilities;
using SLZ.Serialize;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	public abstract class Scannable : ScriptableObject, IScannable, IReadOnlyScannable, IPackable, IPackedAssets
	{
		[SerializeField]
		private Barcode _barcode;

		[SerializeField]
		private Barcode _barcodeOld;

		[SerializeField]
		private MarrowGuid _slimCode;

		[SerializeField]
		[Delayed]
		private string _title;

		[SerializeField]
		[Delayed]
		private string _description;

		[SerializeField]
		[Tooltip("Locks the crate from the user until it is unlocked")]
		private bool _unlockable;

		[SerializeField]
		[Tooltip("Hides the crate from Menus")]
		private bool _redacted;

		private List<PackedAsset> _packedAssets;

		public Barcode Barcode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Barcode BarcodeOld
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MarrowGuid SlimCode
		{
			get
			{
				return default(MarrowGuid);
			}
			set
			{
			}
		}

		public string Title
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Description
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Unlockable
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool Redacted
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public List<PackedAsset> PackedAssets
		{
			get
			{
				return null;
			}
		}

		public void GenerateBarcode(bool forceGeneration = false)
		{
		}

		public abstract void GenerateBarcodeInternal(bool forceGeneration = false);

		public virtual void ImportPackedAssets(Dictionary<string, PackedAsset> packedAssets)
		{
		}

		public virtual List<PackedAsset> ExportPackedAssets()
		{
			return null;
		}

		public virtual UniTask PreloadAssets()
		{
			return default(UniTask);
		}

		public virtual void Pack(ObjectStore store, JObject json)
		{
		}

		public virtual void Unpack(ObjectStore store, string objectId)
		{
		}

		public void PackJsonPackedAssets(JObject json)
		{
		}

		public void UnpackJsonPackedAssets(ObjectStore store, string objectId)
		{
		}

		public Scannable()
			: base()
		{
		}
	}
}

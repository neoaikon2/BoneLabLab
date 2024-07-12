using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SLZ.Serialize;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	public class Pallet : Scannable, ISerializationCallbackReceiver
	{
		[Serializable]
		public struct ChangeLog
		{
			public string version;

			public string title;

			[TextArea(4, 20)]
			public string text;

			[JsonConstructor]
			public ChangeLog(string version, string title, string text)
			{
				this.text = default(string);
				this.title = default(string);
				this.version = default(string);
			}
		}

		[SerializeField]
		private string _author;

		[SerializeField]
		private string _version;

		[SerializeField]
		private string _sdkVersion;

		[Tooltip("NO LONGER USED")]
		[SerializeField]
		private bool _internal;

		[SerializeField]
		private List<Crate> _crates;

		[SerializeField]
		private List<DataCard> _dataCards;

		[SerializeField]
		private List<string> _tags;

		[SerializeField]
		private List<ChangeLog> _changeLogs;

		public static readonly string PALLET_JSON_FILENAME;

		[SerializeField]
		private List<PalletReference> _palletDependencies;

		public string Author
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Version
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string SDKVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Internal
		{
			[Obsolete("Use Pallet.IsInMarrowGame()")]
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public List<Crate> Crates
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<DataCard> DataCards
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<string> Tags
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<ChangeLog> ChangeLogs
		{
			get
			{
				return null;
			}
		}

		public List<PalletReference> PalletDependencies
		{
			get
			{
				return null;
			}
		}

		public override void GenerateBarcodeInternal(bool forceGeneration = false)
		{
		}

		public void GetScannables(List<Scannable> scannables)
		{
		}

		public bool IsInMarrowGame()
		{
			return default(bool);
		}

		public bool IsInMarrowGame(string marrowGameTitle)
		{
			return default(bool);
		}

		public override void Pack(ObjectStore store, JObject json)
		{
		}

		public override void Unpack(ObjectStore store, string objectId)
		{
		}

		public static Pallet CreatePallet(string title, string author, bool generateBarcode = true)
		{
			return null;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public Pallet()
			: base()
		{
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;
using SLZ.Marrow.Forklift.Model;
using SLZ.Serialize;
using UnityEngine.AddressableAssets.ResourceLocators;

namespace SLZ.Marrow.Warehouse
{
	public sealed class PalletManifest : IPackable
	{
		private string _palletBarcode;

		private string _palletPath;

		private string _catalogPath;

		private string _version;

		private string _installedDate;

		private string _updatedDate;

		private ModListing _modListing;

		private Pallet _pallet;

		private IResourceLocator _catalog;

		private string _manifestPath;

		private bool _active;

		public const string EXTENSION_NAME = "manifest";

		public string PalletBarcode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string PalletPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string CatalogPath
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

		public string InstalledDate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string UpdatedDate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ModListing ModListing
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public IResourceLocator Catalog
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ManifestPath
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Active
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public PalletManifest()
			: base()
		{
		}

		public PalletManifest(PalletManifest otherManifest)
			: this()
		{
		}

		public void SetInstalledDateToNow()
		{
		}

		public void SetUpdateDateToNow()
		{
		}

		public static string GetManifestPath(Pallet pallet)
		{
			return null;
		}

		public static PalletManifest CreateManifest(Type manifestType)
		{
			return null;
		}

		public void CopyTo(PalletManifest otherManifest)
		{
		}

		public void Pack(ObjectStore store, JObject json)
		{
		}

		public void Unpack(ObjectStore store, string objectId)
		{
		}
	}
}

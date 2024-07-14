using System;
 
 
 
using Newtonsoft.Json.Linq;
using SLZ.Marrow.Forklift.Model;
using SLZ.Serialize;
using UnityEngine;
using UnityEngine.AddressableAssets.ResourceLocators;

namespace SLZ.Marrow.Warehouse
{
    public sealed class PalletManifest : IPackable
    {
        public PalletManifest()
        {
        }

        public PalletManifest(PalletManifest otherManifest)
        {
            otherManifest.CopyTo(this);
        }

        private string _palletBarcode;
        public string PalletBarcode { get => _palletBarcode; set => _palletBarcode = value; }

        private string _palletPath;
        public string PalletPath { get => _palletPath; set => _palletPath = value; }

        private string _catalogPath;
        public string CatalogPath { get => _catalogPath; set => _catalogPath = value; }

        private string _version;
        public string Version { get => _version; set => _version = value; }

        private string _installedDate;
        public string InstalledDate { get => _installedDate; set => _installedDate = value; }

        private string _updatedDate;
        public string UpdatedDate { get => _updatedDate; set => _updatedDate = value; }

        private ModListing _modListing;
        public ModListing ModListing { get => _modListing; set => _modListing = value; }

        private Pallet _pallet;
        public Pallet Pallet { get => _pallet; set => _pallet = value; }

        private IResourceLocator _catalog;
        public IResourceLocator Catalog { get => _catalog; set => _catalog = value; }

        private string _manifestPath = String.Empty;
        public string ManifestPath
        {
            get
            {
                if (string.IsNullOrEmpty(_manifestPath) && Pallet != null)
                {
                    _manifestPath = GetManifestPath(Pallet);
                }

                return _manifestPath;
            }

            set => _manifestPath = value;
        }

        private bool _active = true;
        public bool Active { get => _active; set => _active = value; }

        public const string EXTENSION_NAME = "manifest";
        public void SetInstalledDateToNow()
        {
            var timeNow = new DateTimeOffset(DateTime.UtcNow);
            _installedDate = timeNow.ToUnixTimeMilliseconds().ToString();
        }

        public void SetUpdateDateToNow()
        {
            var timeNow = new DateTimeOffset(DateTime.UtcNow);
            _updatedDate = timeNow.ToUnixTimeMilliseconds().ToString();
        }

        public static string GetManifestPath(Pallet pallet)
        {
            return System.IO.Path.Combine(MarrowSDK.RuntimeModsPath, $"{pallet.Barcode}.{EXTENSION_NAME}");
        }

        public static PalletManifest CreateManifest(Type manifestType)
        {
            return new PalletManifest();
        }

        public void CopyTo(PalletManifest otherManifest)
        {
            otherManifest.Pallet = this.Pallet;
            otherManifest.PalletBarcode = this.PalletBarcode;
            otherManifest.PalletPath = this.PalletPath;
            otherManifest.CatalogPath = this.CatalogPath;
            otherManifest.Version = this.Version;
            otherManifest.InstalledDate = this.InstalledDate;
            otherManifest.UpdatedDate = this.UpdatedDate;
            otherManifest.Catalog = this.Catalog;
            otherManifest.ManifestPath = this.ManifestPath;
            if (this.ModListing != null)
            {
                otherManifest.ModListing = new ModListing();
                otherManifest.ModListing.Author = this.ModListing.Author;
                otherManifest.ModListing.Barcode = this.ModListing.Barcode;
                otherManifest.ModListing.Description = this.ModListing.Description;
                otherManifest.ModListing.Title = this.ModListing.Title;
                otherManifest.ModListing.Version = this.ModListing.Version;
                otherManifest.ModListing.ThumbnailUrl = this.ModListing.ThumbnailUrl;
                otherManifest.ModListing.Targets = new StringModTargetListingDictionary();
                foreach (var entry in this.ModListing.Targets)
                {
                    otherManifest.ModListing.Targets.Add(entry.Key, entry.Value);
                }
            }

            otherManifest.Active = this.Active;
        }

        public void Pack(ObjectStore store, JObject json)
        {
            json.Add("palletBarcode", _palletBarcode);
            json.Add("palletPath", _palletPath);
            json.Add("catalogPath", _catalogPath);
            json.Add("version", _version);
            json.Add("installedDate", _installedDate);
            json.Add("updateDate", _updatedDate);
            if (_modListing != null)
                json.Add("modListing", store.PackReference(_modListing));
            json.Add("active", _active);
        }

        public void Unpack(ObjectStore store, string objectId)
        {
            if (store.TryGetJSON("palletBarcode", objectId, out JToken palletBarcodeValue))
            {
                _palletBarcode = palletBarcodeValue.ToObject<string>();
            }

            if (store.TryGetJSON("palletPath", objectId, out JToken palletPathValue))
            {
                _palletPath = palletPathValue.ToObject<string>();
            }

            if (store.TryGetJSON("catalogPath", objectId, out JToken catalogPathValue))
            {
                _catalogPath = catalogPathValue.ToObject<string>();
            }

            if (store.TryGetJSON("version", objectId, out JToken versionValue))
            {
                _version = versionValue.ToString();
            }

            if (store.TryGetJSON("installedDate", objectId, out JToken installValue))
            {
                _installedDate = installValue.ToString();
            }

            if (store.TryGetJSON("updateDate", objectId, out JToken updateValue))
            {
                _updatedDate = updateValue.ToString();
            }

            try
            {
                if (store.TryGetJSON("modListing", objectId, out JToken modTargetValue))
                {
                    store.TryCreateFromReference(modTargetValue, out _modListing, t => new ModListing());
                }
            }
            catch (Exception)
            {
                Debug.LogWarning($"PalletManifest: Failed to unpack modListing for pallet {_palletBarcode}");
            }

            if (store.TryGetJSON("active", objectId, out JToken activeValue))
            {
                _active = activeValue.ToObject<bool>();
            }
        }
    }
}
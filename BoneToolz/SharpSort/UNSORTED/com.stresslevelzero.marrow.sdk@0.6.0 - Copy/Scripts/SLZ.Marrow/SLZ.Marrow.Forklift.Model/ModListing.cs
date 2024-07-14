using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using SLZ.Marrow.Utilities;
using SLZ.Marrow.Warehouse;
using SLZ.Serialize;
using UnityEngine;

namespace SLZ.Marrow.Forklift.Model
{
    using ModTargetName = String;

    [Serializable]
    public class ModListing : IPackable, IReadOnlyScannable
    {
#if UNITY_2021_3_OR_NEWER
        [field: SerializeField]
#endif
        public Barcode Barcode { get; set; }

#if UNITY_2021_3_OR_NEWER
        [field: SerializeField]
#endif
        public string Title { get; set; }

#if UNITY_2021_3_OR_NEWER
        [field: SerializeField]
#endif
        public string Description { get; set; }

#if UNITY_2021_3_OR_NEWER
        [field: SerializeField]
#endif
        public string Author { get; set; }

#if UNITY_2021_3_OR_NEWER
        [field: SerializeField]
#endif
        public string Version { get; set; } = "0.0.1";

#if UNITY_2021_3_OR_NEWER
        [field: SerializeField]
#endif
        public string ThumbnailUrl { get; set; }

#if UNITY_2021_3_OR_NEWER
        [field: SerializeField]
        public StringModTargetListingDictionary Targets { get; set; } = new();
#else
#endif
        public ISet<ModTargetName> targetNames => new HashSet<ModTargetName>(Targets.Keys);

        private WeakReference<ModRepository> _repository;
        public ModRepository Repository
        {
            get
            {
                if (_repository != null && _repository.TryGetTarget(out var repository))
                {
                    return repository;
                }

                return null;
            }

            set
            {
                if (_repository != null)
                {
                    _repository.SetTarget(value);
                }
                else
                {
                    _repository = new WeakReference<ModRepository>(value);
                }
            }
        }

        public TListingType GetTargetListing<TListingType>(ModTargetName targetName)
            where TListingType : ModTarget
        {
            if (Targets.TryGetValue(targetName, out var listing))
            {
                if (listing is TListingType type)
                {
                    return type;
                }
            }

            return null;
        }

        public void Pack(ObjectStore store, JObject json)
        {
            json.Add("barcode", Barcode.ID);
            json.Add("title", Title);
            json.Add("description", Description);
            json.Add("author", Author);
            json.Add("version", Version);
            json.Add("thumbnailUrl", ThumbnailUrl);
            var jsonTargets = new JObject();
            if (Targets != null && Targets.Count > 0)
            {
                foreach (var target in Targets)
                {
                    ModTargetName targetName = target.Key;
                    ModTarget targetListing = target.Value;
                    jsonTargets[targetName] = store.PackReference(targetListing);
                }
            }

            json.Add("targets", jsonTargets);
        }

        public void Unpack(ObjectStore store, string objectId)
        {
            if (store.TryGetJSON("barcode", objectId, out JToken barcodeValue))
            {
                Barcode = new Barcode(barcodeValue.ToObject<string>());
            }

            if (store.TryGetJSON("title", objectId, out JToken titleValue))
            {
                Title = titleValue.ToObject<string>();
            }

            if (store.TryGetJSON("description", objectId, out JToken descriptionValue))
            {
                Description = descriptionValue.ToObject<string>();
            }

            if (store.TryGetJSON("author", objectId, out JToken authorValue))
            {
                Author = authorValue.ToObject<string>();
            }

            if (store.TryGetJSON("version", objectId, out JToken versionValue))
            {
                Version = versionValue.ToObject<string>();
            }

            if (store.TryGetJSON("thumbnailUrl", objectId, out JToken thumbnailUrlValue))
            {
                ThumbnailUrl = thumbnailUrlValue.ToObject<string>();
            }

            if (store.TryGetJSON("targets", objectId, out JToken targetsValue))
            {
                var targets = (JObject)targetsValue;
#if UNITY_2021_3_OR_NEWER
                Targets = new StringModTargetListingDictionary();
#else
#endif
                foreach (var targetProperty in targets)
                {
                    store.TryCreateFromReference(targetProperty.Value, out ModTarget target, ModTarget.Create);
                    Targets[targetProperty.Key] = target;
                }
            }
        }
    }

#if UNITY_2021_3_OR_NEWER
    [Serializable]
    public class StringModTargetListingDictionary : SerializableDictionary<string, ModTarget>
    {
    }
#endif
}
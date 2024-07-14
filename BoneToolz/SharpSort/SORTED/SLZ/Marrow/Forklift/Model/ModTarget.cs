using System;
using Newtonsoft.Json.Linq;
using SLZ.Serialize;
using UnityEngine;

namespace SLZ.Marrow.Forklift.Model
{
    [Serializable]
    public abstract class ModTarget : IPackable
    {
#if UNITY_2021_3_OR_NEWER
        [field: SerializeField]
#endif
        public string ThumbnailOverride { get; set; }

        public virtual void Pack(ObjectStore store, JObject json)
        {
            json.Add("thumbnailOverride", ThumbnailOverride);
        }

        public virtual void Unpack(ObjectStore store, string objectId)
        {
            if (store.TryGetJSON("thumbnailOverride", objectId, out var thumbnailOverrideValue))
            {
                ThumbnailOverride = thumbnailOverrideValue.ToObject<string>();
            }
        }

        public static ModTarget Create(Type type)
        {
            if (type == typeof(DownloadableModTarget))
            {
                return new DownloadableModTarget();
            }

            if (type == typeof(ModIOModTarget))
            {
                return new ModIOModTarget();
            }

            return null;
        }
    }
}
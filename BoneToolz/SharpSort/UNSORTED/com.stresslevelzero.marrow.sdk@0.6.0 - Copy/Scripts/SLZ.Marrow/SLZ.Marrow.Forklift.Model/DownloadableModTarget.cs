using System;
using Newtonsoft.Json.Linq;
using SLZ.Serialize;
using UnityEngine;

namespace SLZ.Marrow.Forklift.Model
{
    [Serializable]
    public class DownloadableModTarget : ModTarget
    {
#if UNITY_2021_3_OR_NEWER
        [field: SerializeField]
#endif
        public string Url { get; set; }

        public override void Pack(ObjectStore store, JObject json)
        {
            base.Pack(store, json);
            json.Add("url", Url);
        }

        public override void Unpack(ObjectStore store, string objectId)
        {
            base.Unpack(store, objectId);
            if (store.TryGetJSON("url", objectId, out var urlValue))
            {
                Url = urlValue.ToObject<string>();
            }
        }
    }
}
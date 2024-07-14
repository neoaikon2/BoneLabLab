using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using SLZ.Serialize;
using UnityEngine;

namespace SLZ.Marrow.Forklift.Model
{
    
    

    [Serializable]
    public class ModRepository : IPackable
    {
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
        public List<ModListing> Mods { get; set; } = new List<ModListing>();

        public void Pack(ObjectStore store, JObject json)
        {
            json.Add("title", Title);
            json.Add("description", Description);
            var jsonModsArray = new JArray();
            if (Mods != null && Mods.Count > 0)
            {
                foreach (var mod in Mods)
                {
                    if (mod != null)
                    {
                        jsonModsArray.Add(store.PackReference(mod));
                    }
                }
            }

            json.Add(new JProperty("mods", jsonModsArray));
        }

        public void Unpack(ObjectStore store, string objectId)
        {
            if (store.TryGetJSON("title", objectId, out var nameValue))
            {
                Title = nameValue.ToObject<string>();
            }

            if (store.TryGetJSON("description", objectId, out var descriptionValue))
            {
                Description = descriptionValue.ToObject<string>();
            }

            if (store.TryGetJSON("mods", objectId, out var modsValue))
            {
                var arr = (JArray)modsValue;
                Mods = new List<ModListing>();
                if (arr.Count > 0)
                {
                    foreach (var modValue in arr)
                    {
                        var mod = new ModListing();
                        store.TryUnpackReference(modValue, ref mod);
                        mod.Repository = this;
                        Mods.Add(mod);
                    }
                }
            }
        }
    }
}
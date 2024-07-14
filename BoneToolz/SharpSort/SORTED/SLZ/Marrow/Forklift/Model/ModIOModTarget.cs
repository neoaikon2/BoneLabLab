using System;
using Newtonsoft.Json.Linq;
using SLZ.Serialize;
using UnityEngine;

namespace SLZ.Marrow.Forklift.Model
{
    [Serializable]
    public sealed class ModIOModTarget : ModTarget
    {
#if UNITY_2021_3_OR_NEWER
        [field: SerializeField]
#endif
        public long GameId { get; set; }

#if UNITY_2021_3_OR_NEWER
        [field: SerializeField]
#endif
        public long ModId { get; set; }

#if UNITY_2021_3_OR_NEWER
        [field: SerializeField]
#endif
        public long ModfileId { get; set; }

        public override void Pack(ObjectStore store, JObject json)
        {
            base.Pack(store, json);
            json.Add("gameId", GameId);
            json.Add("modId", ModId);
            json.Add("modfileId", ModfileId);
        }

        public override void Unpack(ObjectStore store, string objectId)
        {
            base.Unpack(store, objectId);
            if (store.TryGetJSON("gameId", objectId, out var gameIdValue))
            {
                GameId = gameIdValue.ToObject<long>();
            }

            if (store.TryGetJSON("modId", objectId, out var modIdValue))
            {
                ModId = modIdValue.ToObject<long>();
            }

            if (store.TryGetJSON("modfileId", objectId, out var modfileId))
            {
                ModfileId = modfileId.ToObject<long>();
            }
        }
    }
}
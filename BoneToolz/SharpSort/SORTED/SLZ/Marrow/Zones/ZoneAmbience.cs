using SLZ.Marrow.Data;
 
 
using UnityEngine;
using UnityEngine.Serialization;
using SLZ.Marrow.Warehouse;

 

namespace SLZ.Marrow.Zones
{
    [AddComponentMenu("MarrowSDK/Zones/Zone Ambience")]
    public class ZoneAmbience : ZoneLinkItem
    {
        [Header("Ambience")]
        [Tooltip("Ambience to play.")]
        public AudioClip clipMain;
        [Tooltip("Ambience to play.")]
        public DataCardReference<MonoDisc> ambientTrack;
        [Tooltip("Recommended range is .05 to .25! You need to leave headroom for gunshots, impacts and music above your ambience, only turn higher if track is mixed quietly.")]
        [Range(0f, 1f)]
        public float volume = .1f;
        [Tooltip("Good practice to always fade at least a small ammount to prevent audio pops. Unit is in seconds.")]
        [Range(.25f, 10f)]
        public float fadeInTime = 3f;
        [Tooltip("Good practice to always fade at least a small ammount to prevent audio pops. Unit is in seconds.")]
        [Range(.25f, 10f)]
        public float fadeOutTime = 3f;
        [Header("Reverb")]
        [FormerlySerializedAs("reverbObj")]
        public AudioReverbData reverbSettings;
        [HideInInspector]
        public static bool zoneAmbiencePasted = false;
    }
}
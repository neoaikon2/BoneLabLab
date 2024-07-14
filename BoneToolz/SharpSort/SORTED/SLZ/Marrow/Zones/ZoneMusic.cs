 
 
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Serialization;

 

namespace SLZ.Marrow.Zones
{
    [AddComponentMenu("MarrowSDK/Zones/Zone Music")]
    public class ZoneMusic : ZoneLinkItem
    {
        [Header("ZoneMusic")]
        [FormerlySerializedAs("clipToCue")]
        [Tooltip("Track to play.")]
        public AudioClip clipMain;
        [Tooltip("Track to play.")]
        public DataCardReference<MonoDisc> track;
        [Range(0f, 1f)]
        [Tooltip("Recommended to keep volume below .3! You need to leave headroom for gunshots and impacts above your music, only turn higher if track is mixed quietly.")]
        public float volume = .2f;
        [Header("Music Actions")]
        [Tooltip("Play track when entering zone. Fades in for fadeInTime.")]
        public bool playOnEnter = true;
        [Tooltip("Stop current track when entering zone. Fades out for fadeOutTime.")]
        public bool stopOnEnter = false;
        [Tooltip("Stop current track when exiting zone. Fades out for fadeOutTime.")]
        public bool stopOnExit = false;
        [Range(.1f, 10f)]
        [Tooltip("Good practice to always fade at least a small ammount to prevent audio pops. Unit is in seconds.")]
        public float fadeInTime = 1f;
        [Range(.1f, 10f)]
        [Tooltip("Good practice to always fade at least a small ammount to prevent audio pops. Unit is in seconds.")]
        public float fadeOutTime = 3f;
        [FormerlySerializedAs("onlyPlayOnce")]
        [Tooltip("Select to only trigger music actions the first time this zone is triggered. Defaulted to true because I love it. - Brandon")]
        public bool onlyTriggerOnce = true;
        [Header("Looping options")]
        [Tooltip("Select to loop track until something else plays or a ZoneMusic with StopOnEnter/Exit is triggered. Defaulted to false because it's better to leave them wanting more - Brandon")]
        public bool loop = false;
        [Tooltip("Optional intro track that will only play a single time before clip main is played. Useful if you want to have an attention grabbing intro that blends into a main body that cleanly loops.")]
        public AudioClip clipIntro;
        [Tooltip("Optional intro track that will only play a single time before clip main is played. Useful if you want to have an attention grabbing intro that blends into a main body that cleanly loops.")]
        public DataCardReference<MonoDisc> introTrack;
        [HideInInspector]
        public static bool zoneMusicPasted = false;
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Serialization;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_scene_manager")]
public class OVRSceneManager : MonoBehaviour
{
	public static class Classification
	{
		public const string Floor = "FLOOR";

		public const string Ceiling = "CEILING";

		public const string WallFace = "WALL_FACE";

		[Obsolete("Deprecated. Use Table classification instead.")]
		public const string Desk = "DESK";

		public const string Couch = "COUCH";

		public const string DoorFrame = "DOOR_FRAME";

		public const string WindowFrame = "WINDOW_FRAME";

		public const string Other = "OTHER";

		public const string Storage = "STORAGE";

		public const string Bed = "BED";

		public const string Screen = "SCREEN";

		public const string Lamp = "LAMP";

		public const string Plant = "PLANT";

		public const string Table = "TABLE";

		public const string WallArt = "WALL_ART";

		public const string InvisibleWallFace = "INVISIBLE_WALL_FACE";

		public const string GlobalMesh = "GLOBAL_MESH";

		public static IReadOnlyList<string> List { get; }
	}

	[Obsolete("RoomLayoutInformation is obsoleted. For each room's layout information (floor, ceiling, walls) see OVRSceneRoom.", false)]
	public class RoomLayoutInformation
	{
		public OVRScenePlane Floor;

		public OVRScenePlane Ceiling;

		public List<OVRScenePlane> Walls;
	}
		
	internal struct LogForwarder
	{
		public void Log(string context, string message, GameObject gameObject = null)
		{
		}

		public void LogWarning(string context, string message, GameObject gameObject = null)
		{
		}

		public void LogError(string context, string message, GameObject gameObject = null)
		{
		}
	}

	internal static class Development
	{
		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public static void Log(string context, string message, GameObject gameObject = null)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public static void LogWarning(string context, string message, GameObject gameObject = null)
		{
		}

		[Conditional("DEVELOPMENT_BUILD")]
		[Conditional("UNITY_EDITOR")]
		public static void LogError(string context, string message, GameObject gameObject = null)
		{
		}
	}
	[FormerlySerializedAs("planePrefab")]
	[Tooltip("A prefab that will be used to instantiate any Plane found when querying the Scene model. If the anchor contains both Volume and Plane elements, Volume will be used instead.")]
	public OVRSceneAnchor PlanePrefab;

	[Tooltip("A prefab that will be used to instantiate any Volume found when querying the Scene model. This anchor may also contain Plane elements.")]
	[FormerlySerializedAs("volumePrefab")]
	public OVRSceneAnchor VolumePrefab;

	[FormerlySerializedAs("prefabOverrides")]
	[Tooltip("Overrides the instantiation of the generic Plane/Volume prefabs with specialized ones.")]
	public List<OVRScenePrefabOverride> PrefabOverrides;

	[Tooltip("Scene manager will only present the room(s) the user is currently in.")]
	public bool ActiveRoomsOnly;

	[FormerlySerializedAs("verboseLogging")]
	[Tooltip("When enabled, verbose debug logs will be emitted.")]
	public bool VerboseLogging;

	[Tooltip("The maximum number of scene anchors that will be updated each frame.")]
	public int MaxSceneAnchorUpdatesPerFrame;

	[SerializeField]
	[Tooltip("(Optional) The parent transform for each new scene anchor. Changing this value does not affect existing scene anchors. May be null.")]
	internal Transform _initialAnchorParent;

	public Action SceneModelLoadedSuccessfully;

	public Action NoSceneModelToLoad;

	public Action SceneCaptureReturnedWithoutError;

	public Action UnexpectedErrorWithSceneCapture;

	public Action NewSceneModelAvailable;

	[Obsolete("RoomLayout is obsoleted. For each room's layout information (floor, ceiling, walls) see OVRSceneRoom.", false)]
	public RoomLayoutInformation RoomLayout;

	private ulong _sceneCaptureRequestId;

	private OVRCameraRig _cameraRig;

	private int _sceneAnchorUpdateIndex;

	private int _roomCounter;

	private Action<bool, List<OVRAnchor>> _onAnchorsFetchCompleted;

	private bool _hasLoadedScene;

	private Action<bool> _onFloorAnchorsFetchCompleted;

	private Action<bool, OVRAnchor> _onFloorAnchorLocalizationCompleted;

	private List<OVRAnchor> _floorAnchors;

	private readonly HashSet<Guid> _pendingLocatable;

	private Dictionary<Guid, OVRAnchor> _roomAndFloorPairs;

	private List<OVRAnchor> _roomLayoutAnchors;

	public Transform InitialAnchorParent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal LogForwarder? Verbose => null;

	private void Awake()
	{
	}
	internal void OnApplicationPause(bool isPaused)
	{
	}
	private void QueryForExistingAnchorsTransform()
	{
	}

	public bool LoadSceneModel()
	{
		return false;
	}

	private void OnAnchorsFetchCompleted(bool success, List<OVRAnchor> roomLayoutAnchors)
	{
	}

	private void InstantiateActiveRooms(List<OVRAnchor> roomLayoutAnchors)
	{
	}

	private void OnFloorAnchorsFetchCompleted(bool success)
	{
	}

	private void OnFloorAnchorLocalizationCompleted(bool success, OVRAnchor anchor)
	{
	}

	private void LocateUserInRoom(OVRAnchor anchor)
	{
	}

	private void InstantiateSceneRooms(List<OVRAnchor> roomLayoutAnchors)
	{
	}

	internal void OnSceneRoomLoadCompleted()
	{
	}

	private void DestroyExistingAnchors()
	{
	}

	public bool RequestSceneCapture()
	{
		return false;
	}

	public bool RequestSceneCapture(IEnumerable<string> requestedAnchorClassifications)
	{
		return false;
	}

	public OVRTask<bool> DoesRoomSetupExist(IEnumerable<string> requestedAnchorClassifications)
	{
		return default(OVRTask<bool>);
	}

	private static void CheckIfClassificationsAreValid(IEnumerable<string> requestedAnchorClassifications)
	{
	}

	private static void GetUuidsToQuery(OVRAnchor anchor, HashSet<Guid> uuidsToQuery)
	{
	}

	private static void CheckClassificationsInRooms(bool success, List<OVRAnchor> rooms, IEnumerable<string> requestedAnchorClassifications, OVRTask<bool> task)
	{
	}

	private static void CheckIfAnchorsContainClassifications(bool success, List<OVRAnchor> roomAnchors, IEnumerable<string> requestedAnchorClassifications, OVRTask<bool> task)
	{
	}

	private static void CollectLabelsFromAnchors(List<OVRAnchor> anchors, List<string> labels)
	{
	}

	private static void OnTrackingSpaceChanged(Transform trackingSpace)
	{
	}

	private void Update()
	{
	}

	private static void UpdateAllSceneAnchors()
	{
	}

	private void UpdateSomeSceneAnchors()
	{
	}

	private RoomLayoutInformation GetRoomLayoutInformation()
	{
		return null;
	}

	private bool RequestSceneCapture(string requestString)
	{
		return false;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	internal static bool PointInPolygon2D(NativeArray<Vector2> boundaryVertices, Vector2 target)
	{
		return false;
	}

	private void OVRManager_SceneCaptureComplete(ulong requestId, bool result)
	{
	}

	internal OVRSceneAnchor InstantiateSceneAnchor(OVRAnchor anchor, OVRSceneAnchor prefab)
	{
		return null;
	}
}

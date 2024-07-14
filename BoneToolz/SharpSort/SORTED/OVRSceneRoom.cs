using System;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(OVRSceneAnchor))]
[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_scene_room")]
public class OVRSceneRoom : MonoBehaviour, IOVRSceneComponent
{
	internal List<OVRScenePlane> _walls;

	private readonly Dictionary<Guid, int> _orderedRoomGuids;

	private Comparison<OVRScenePlane> _wallOrderComparer;

	private OVRSceneAnchor _sceneAnchor;

	private OVRSceneManager _sceneManager;

	internal HashSet<Guid> _uuidToQuery;

	private List<OVRAnchor> _roomAnchors;

	internal static readonly Dictionary<Guid, OVRSceneRoom> SceneRooms;

	internal static readonly List<OVRSceneRoom> SceneRoomsList;

	private int _taskCount;

	private Action<bool> _onFetchAnchorsCompleted;

	private Action<bool, OVRAnchor> _onAnchorLocalizationCompleted;

	public OVRScenePlane Floor { get; private set; }

	public OVRScenePlane Ceiling { get; private set; }

	public OVRScenePlane[] Walls { get; private set; }

	private void Awake()
	{
	}

	private void IOVRSceneComponent_002EInitialize()
	{
	}

	internal void LoadRoom()
	{
	}

	private void OnFetchAnchorsCompleted(bool success)
	{
	}

	private void OnLocalizationCompleted(bool success, OVRAnchor anchor)
	{
	}

	private void UpdateRoomInformation(OVRScenePlane plane)
	{
	}

	private void GetUuidsToQuery()
	{
	}

	private void OnDestroy()
	{
	}

	public void Initialize()
	{
		throw new NotImplementedException();
	}
}

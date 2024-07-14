using System;
using System.Collections.Generic;
using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_scene_anchor")]
[DisallowMultipleComponent]
public sealed class OVRSceneAnchor : MonoBehaviour
{
	private static readonly Quaternion RotateY180;

	private OVRPlugin.Posef? _pose;

	private bool _isLocatable;

	private readonly List<OVRPlugin.SpaceComponentType> _supportedComponents;

	private static readonly Dictionary<OVRSpace, int> AnchorReferenceCountDictionary;

	internal static readonly Dictionary<Guid, OVRSceneAnchor> SceneAnchors;

	internal static readonly List<OVRSceneAnchor> SceneAnchorsList;

	public OVRSpace Space { get; private set; }

	public Guid Uuid { get; private set; }

	public OVRAnchor Anchor { get; private set; }

	public bool IsTracked { get; internal set; }

	private bool IsComponentSupported(OVRPlugin.SpaceComponentType spaceComponentType)
	{
		return false;
	}

	internal bool IsComponentEnabled(OVRPlugin.SpaceComponentType spaceComponentType)
	{
		return false;
	}

	private void SyncComponent<T>(OVRPlugin.SpaceComponentType spaceComponentType) where T : MonoBehaviour, IOVRSceneComponent
	{
	}

	internal void ClearPoseCache()
	{
	}

	public void Initialize(OVRAnchor anchor)
	{
	}

	public void InitializeFrom(OVRSceneAnchor other)
	{
	}

	public static void GetSceneAnchors(List<OVRSceneAnchor> anchors)
	{
	}

	internal bool TryUpdateTransform(bool useCache)
	{
		return false;
	}

	private void OnDestroy()
	{
	}
}

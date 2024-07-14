using System;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_scene_prefab_override")]
public class OVRScenePrefabOverride : ISerializationCallbackReceiver
{
	[FormerlySerializedAs("prefab")]
	public OVRSceneAnchor Prefab;

	[FormerlySerializedAs("classificationLabel")]
	public string ClassificationLabel;

	[SerializeField]
	[FormerlySerializedAs("editorClassificationIndex")]
	private int _editorClassificationIndex;

	private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
	{
	}

	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
		throw new NotImplementedException();
	}

	public void OnAfterDeserialize()
	{
		throw new NotImplementedException();
	}
}

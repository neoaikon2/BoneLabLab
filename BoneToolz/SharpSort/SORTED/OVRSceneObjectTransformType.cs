using System;
using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_scene_object_transform_type")]
public class OVRSceneObjectTransformType : MonoBehaviour
{
	[Serializable]
	public enum Transformation
	{
		Volume = 0,
		Plane = 1,
		None = 2
	}

	[Tooltip("Choose the type of scene anchor (volume/plane) that may modify this transform.")]
	public Transformation TransformType;
}

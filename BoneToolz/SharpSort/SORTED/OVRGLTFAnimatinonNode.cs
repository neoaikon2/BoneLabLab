using System;
using System.Collections.Generic;
using OVRSimpleJSON;
using UnityEngine;

public class OVRGLTFAnimatinonNode
{
	private enum ThumbstickDirection
	{
		None = 0,
		North = 1,
		NorthEast = 2,
		East = 3,
		SouthEast = 4,
		South = 5,
		SouthWest = 6,
		West = 7,
		NorthWest = 8
	}

	private enum OVRGLTFTransformType
	{
		None = 0,
		Translation = 1,
		Rotation = 2,
		Scale = 3,
		Weights = 4
	}

	private enum OVRInterpolationType
	{
		None = 0,
		LINEAR = 1,
		STEP = 2,
		CUBICSPLINE = 3
	}

	private struct InputNodeState
	{
		public bool down;

		public float t;

		public Vector2 vecT;
	}

	private OVRGLTFInputNode m_intputNodeType;

	private JSONNode m_jsonData;

	private GameObject m_gameObj;

	private InputNodeState m_inputNodeState;

	private OVRGLTFAnimationNodeMorphTargetHandler m_morphTargetHandler;

	private List<Vector3> m_translations;

	private List<Quaternion> m_rotations;

	private List<Vector3> m_scales;

	private List<float> m_weights;

	private int m_additiveWeightIndex;

	private static Dictionary<OVRGLTFInputNode, int> InputNodeKeyFrames;

	private static List<int> ThumbStickKeyFrames;

	private static Vector2[] CardDirections;

	public OVRGLTFAnimatinonNode(OVRGLTFInputNode inputNodeType, GameObject gameObj, OVRGLTFAnimationNodeMorphTargetHandler morphTargetHandler)
	{
	}

	public void AddChannel(JSONNode channel, JSONNode samplers, OVRGLTFAccessor dataAccessor)
	{
	}

	public void UpdatePose(bool down)
	{
	}

	public void UpdatePose(float t, bool applyDeadZone = true)
	{
	}

	public void UpdatePose(Vector2 joystick)
	{
	}

	private Tuple<ThumbstickDirection, ThumbstickDirection> GetCardinalThumbsticks(Vector2 joystick)
	{
		return null;
	}

	private Vector2 GetCardinalWeights(Vector2 joystick, Tuple<ThumbstickDirection, ThumbstickDirection> cardinals)
	{
		return default(Vector2);
	}

	private void ProcessAnimationSampler(JSONNode samplerNode, int nodeId, OVRGLTFTransformType transformType, JSONNode extras, OVRGLTFAccessor _dataAccessor)
	{
	}

	private OVRGLTFTransformType GetTransformType(string transform)
	{
		return default(OVRGLTFTransformType);
	}

	private OVRInterpolationType ToOVRInterpolationType(string interpolationType)
	{
		return default(OVRInterpolationType);
	}

	private void CopyData<T>(ref List<T> dest, T[] src)
	{
	}

	private Vector3 CloneVector3(Vector3 v)
	{
		return default(Vector3);
	}

	private Quaternion CloneQuaternion(Quaternion q)
	{
		return default(Quaternion);
	}

	private void SetScale(Vector3 scale)
	{
	}
}

using UnityEngine;

[RequireComponent(typeof(SkinnedMeshRenderer))]
[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_custom_face")]
public class OVRCustomFace : OVRFace
{
	public enum RetargetingType
	{
		OculusFace = 0,
		Custom = 1
	}

	[SerializeField]
	[Tooltip("The mapping between Face Expressions to the blendshapes available on the shared mesh of the skinned mesh renderer")]
	internal OVRFaceExpressions.FaceExpression[] _mappings;

	[SerializeField]
	[HideInInspector]
	internal RetargetingType retargetingType;

	[SerializeField]
	[Tooltip("Allow duplicates when mapping blendshapes to Face Expressions")]
	internal bool _allowDuplicateMapping;

	public OVRFaceExpressions.FaceExpression[] Mappings
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected RetargetingType RetargetingValue
	{
		get
		{
			return default(RetargetingType);
		}
		set
		{
		}
	}

	protected bool AllowDuplicateMapping
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override void Start()
	{
	}

	protected internal override OVRFaceExpressions.FaceExpression GetFaceExpression(int blendShapeIndex)
	{
		return default(OVRFaceExpressions.FaceExpression);
	}

	protected internal virtual (string[], OVRFaceExpressions.FaceExpression[]) GetCustomBlendShapeNameAndExpressionPairs()
	{
		return default((string[], OVRFaceExpressions.FaceExpression[]));
	}
}

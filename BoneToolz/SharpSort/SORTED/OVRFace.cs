using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_face")]
[RequireComponent(typeof(SkinnedMeshRenderer))]
public class OVRFace : MonoBehaviour
{
	[SerializeField]
	[Tooltip("The OVRFaceExpressions Component to fetch the Face Tracking weights from that are to be applied")]
	protected internal OVRFaceExpressions _faceExpressions;

	[SerializeField]
	[Tooltip("A multiplier to the weights read from the OVRFaceExpressions to exaggerate facial expressions")]
	protected internal float _blendShapeStrengthMultiplier;

	private SkinnedMeshRenderer _skinnedMeshRenderer;

	public OVRFaceExpressions FaceExpressions
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float BlendShapeStrengthMultiplier
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected SkinnedMeshRenderer SkinnedMesh => null;

	internal SkinnedMeshRenderer RetrieveSkinnedMeshRenderer()
	{
		return null;
	}

	protected virtual void Awake()
	{
	}

	internal OVRFaceExpressions SearchFaceExpressions()
	{
		return null;
	}

	protected virtual void Start()
	{
	}

	protected virtual void Update()
	{
	}

	protected internal virtual OVRFaceExpressions.FaceExpression GetFaceExpression(int blendShapeIndex)
	{
		return default(OVRFaceExpressions.FaceExpression);
	}

	protected internal virtual bool GetWeightValue(int blendShapeIndex, out float weightValue)
	{
		weightValue = default(float);
		return false;
	}
}

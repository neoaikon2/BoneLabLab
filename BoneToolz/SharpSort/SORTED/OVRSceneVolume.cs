using UnityEngine;

[DisallowMultipleComponent]
[RequireComponent(typeof(OVRSceneAnchor))]
[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_scene_volume")]
public class OVRSceneVolume : MonoBehaviour, IOVRSceneComponent
{
	[Tooltip("When enabled, scales the child transforms according to the dimensions of this volume. If both Volume and Plane components exist on the game object, the volume takes precedence.")]
	[SerializeField]
	internal bool _scaleChildren;

	[Tooltip("When enabled, offsets the child transforms according to the offset of this volume. If both Volume and Plane components exist on the game object, the volume takes precedence.")]
	[SerializeField]
	internal bool _offsetChildren;

	private OVRSceneAnchor _sceneAnchor;

	public float Width { get; private set; }

	public float Height { get; private set; }

	public float Depth { get; private set; }

	public Vector3 Dimensions => default(Vector3);

	public Vector3 Offset { get; private set; }

	public bool ScaleChildren
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool OffsetChildren
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void IOVRSceneComponent_002EInitialize()
	{
	}

	private void SetChildScale()
	{
	}

	private void SetChildOffset()
	{
	}

	internal void UpdateTransform()
	{
	}

	public void Initialize()
	{
		throw new System.NotImplementedException();
	}
}

using UnityEngine;

[ExecuteInEditMode]
public class VolumetricMedia : MonoBehaviour
{
	public enum ShapeType
	{
		Sphere = 0,
		Box = 1
	}

	public ShapeType shapeType;

	[Tooltip("3d texture. RGB is color")]
	public Texture3D Texture;

	public Vector3 Scale;

	[HideInInspector]
	[SerializeField]
	public Vector3 NormalizedScale;

	[HideInInspector]
	[SerializeField]
	public Vector3 Corner;

	[Range(0.01f, 100f)]
	public float ViewDistance;

	[Range(0f, 1f)]
	public float falloffDistance;

	public float LocalExtinction()
	{
		return 0f;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void OnValidate()
	{
	}
}

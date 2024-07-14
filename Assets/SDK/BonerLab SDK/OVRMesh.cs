using UnityEngine;

public class OVRMesh : MonoBehaviour
{
	public interface IOVRMeshDataProvider
	{
		MeshType GetMeshType();
	}

	public enum MeshType
	{
		None = -1,
		HandLeft = 0,
		HandRight = 1
	}

	[SerializeField]
	private IOVRMeshDataProvider _dataProvider;

	[SerializeField]
	private MeshType _meshType;

	private Mesh _mesh;

	public bool IsInitialized { get; private set; }

	public Mesh Mesh => null;

	internal MeshType GetMeshType()
	{
		return default(MeshType);
	}

	internal void SetMeshType(MeshType type)
	{
	}

	private void Awake()
	{
	}

	private bool ShouldInitialize()
	{
		return false;
	}

	private void Initialize(MeshType meshType)
	{
	}

	private void TransformOvrpMesh(OVRPlugin.Mesh ovrpMesh, Mesh mesh)
	{
	}
}

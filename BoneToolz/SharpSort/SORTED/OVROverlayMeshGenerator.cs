using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

[ExecuteAlways]
[RequireComponent(typeof(MeshFilter))]
[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_overlay_mesh_generator")]
[RequireComponent(typeof(MeshRenderer))]
public class OVROverlayMeshGenerator : MonoBehaviour
{
	private enum CubeFace
	{
		Bottom = 0,
		Front = 1,
		Back = 2,
		Right = 3,
		Left = 4,
		Top = 5,
		COUNT = 6
	}

	private readonly List<int> _Tris;

	private readonly List<Vector2> _UV;

	private readonly List<Vector4> _CubeUV;

	private readonly List<Vector3> _Verts;

	private Transform _CameraRoot;

	private Rect _LastDestRectLeft;

	private Vector3 _LastPosition;

	private Quaternion _LastRotation;

	private Vector3 _LastScale;

	private TextureDimension _LastTextureDimension;

	private OVROverlay.OverlayShape _LastShape;

	private Rect _LastSrcRectLeft;

	private Mesh _Mesh;

	private MeshCollider _MeshCollider;

	private MeshFilter _MeshFilter;

	private MeshRenderer _MeshRenderer;

	private OVROverlay _Overlay;

	private Transform _Transform;

	private Material _PreviewMaterial;

	protected void OnEnable()
	{
	}

	protected void OnDestroy()
	{
	}

	private void Initialize()
	{
	}

	public void SetOverlay(OVROverlay overlay)
	{
	}

	private void TryUpdateMesh()
	{
	}

	private void UpdateMesh(OVROverlay.OverlayShape shape, Vector3 position, Quaternion rotation, Vector3 scale, Rect rect, bool cubemap = false)
	{
	}

	public static void GenerateMesh(List<Vector3> verts, List<Vector2> uvs, List<Vector4> cubeUVs, List<int> tris, OVROverlay.OverlayShape shape, Vector3 position, Quaternion rotation, Vector3 scale, Rect rect)
	{
	}

	[MethodImpl(256)]
	private static Vector3 InverseTransformVert(in Vector3 vert, in Vector3 position, in Vector3 scale, float worldScale)
	{
		return default(Vector3);
	}

	[MethodImpl(256)]
	private static Vector2 GetSphereUV(float theta, float phi, float expandScale)
	{
		return default(Vector2);
	}

	[MethodImpl(256)]
	private static Vector3 GetSphereVert(float theta, float phi)
	{
		return default(Vector3);
	}

	public static void BuildSphere(List<Vector3> verts, List<Vector2> uv, List<int> triangles, Vector3 position, Quaternion rotation, Vector3 scale, Rect rect, float worldScale = 800f, int latitudes = 128, int longitudes = 128, float expandCoefficient = 1f)
	{
	}

	[MethodImpl(256)]
	private static Vector2 GetCubeUV(CubeFace face, float sideU, float sideV, float expandScale, float expandOffset)
	{
		return default(Vector2);
	}

	[MethodImpl(256)]
	private static Vector3 GetCubeVert(CubeFace face, float sideU, float sideV)
	{
		return default(Vector3);
	}

	public static void BuildCube(List<Vector3> verts, List<Vector2> uv, List<Vector4> cubeUV, List<int> triangles, Vector3 position, Quaternion rotation, Vector3 scale, float worldScale = 800f, int subQuads = 1, float expandCoefficient = 1.01f)
	{
	}

	public static void BuildQuad(List<Vector3> verts, List<Vector2> uv, List<int> triangles, Rect rect)
	{
	}

	public static void BuildHemicylinder(List<Vector3> verts, List<Vector2> uv, List<int> triangles, Vector3 scale, Rect rect, int longitudes = 128)
	{
	}
}

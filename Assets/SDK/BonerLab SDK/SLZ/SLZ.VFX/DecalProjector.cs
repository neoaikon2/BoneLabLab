using System.Collections.Generic;
using UnityEngine;

namespace SLZ.VFX
{
	public class DecalProjector : MonoBehaviour
	{
		public enum DecalProjectionMethod
		{
			GridRaycastProjection = 0,
			RadialRaycastProjection = 1
		}

		private struct DebugRayInfo
		{
			public Vector3 Origin;

			public Vector3 HitPoint;
		}

		[Header("General Settings")]
		public Material decalMaterial;

		[Tooltip("Offset from surface normal (m)")]
		public float offset;

		[Tooltip("Vertex Color")]
		[ColorUsage(true, true)]
		public Color vertexColor;

		[Tooltip("Collider that will be raycast to")]
		[Header("Raycast Settings")]
		public Collider targetCollider;

		[Tooltip("Diameter or width (m)")]
		public float decalSize;

		[Tooltip("The distance the raycasts (m)")]
		public float raycastDistance;

		[Header("Mesh mode Settings")]
		public DecalProjectionMethod projectionMethod;

		[Range(1f, 8f)]
		[Header("Grid Settings")]
		public int decalResolution;

		[Range(3f, 16f)]
		[Header("Radial Settings")]
		public int radialSegments;

		[Range(1f, 5f)]
		public int radialSubdivisions;

		[Header("Atlas Settings")]
		public DecalAtlasData atlasData;

		public int atlasSelection;

		public bool randomizeSelection;

		[SerializeField]
		[Header("Generated Decal")]
		private MeshFilter meshFilter;

		[SerializeField]
		private MeshRenderer meshRenderer;

		private readonly List<Vector3> _vertices;

		private readonly List<Vector2> _uvs;

		private readonly List<Color> _colorsz;

		private readonly List<int> _triangles;

		private readonly List<bool> _hits;

		private readonly List<Vector3> _positionGrid;

		private readonly List<bool> _hitGrid;

		private Dictionary<int, Mesh> _meshes;

		private List<DebugRayInfo> debugRayInfos;

		private void Reset()
		{
		}

		[ContextMenu("Apply Decal")]
		public void ApplyDecal()
		{
		}

		public static Vector2 LerpVector2Components(Vector2 a, Vector2 b, Vector2 t)
		{
			return default(Vector2);
		}

		public static Vector2 LerpVector2Components(Vector2 a, Vector2 b, float t1, float t2)
		{
			return default(Vector2);
		}

		private void CreateConformedMesh(float size)
		{
		}

		private void ApplyToMesh()
		{
		}

		private void CreateRadialLayout(float size)
		{
		}

		public void FindCollider()
		{
		}

		public void RandomizeSelection()
		{
		}

		private DebugRayInfo DefineRayInfo(Vector3 point1, Vector3 point2)
		{
			return default(DebugRayInfo);
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}

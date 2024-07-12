using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	public struct TMP_MeshInfo
	{
		private static readonly Color32 s_DefaultColor;

		private static readonly Vector3 s_DefaultNormal;

		private static readonly Vector4 s_DefaultTangent;

		private static readonly Bounds s_DefaultBounds;

		public Mesh mesh;

		public int vertexCount;

		public Vector3[] vertices;

		public Vector3[] normals;

		public Vector4[] tangents;

		public Vector2[] uvs0;

		public Vector2[] uvs2;

		public Color32[] colors32;

		public int[] triangles;

		public Material material;

		public TMP_MeshInfo(Mesh mesh, int size)
		{
			this.material = default(Material);
			this.triangles = default(int[]);
			this.colors32 = default(Color32[]);
			this.uvs2 = default(Vector2[]);
			this.uvs0 = default(Vector2[]);
			this.tangents = default(Vector4[]);
			this.normals = default(Vector3[]);
			this.vertices = default(Vector3[]);
			this.vertexCount = default(int);
			this.mesh = default(Mesh);
		}

		public TMP_MeshInfo(Mesh mesh, int size, bool isVolumetric)
		{
			this.material = default(Material);
			this.triangles = default(int[]);
			this.colors32 = default(Color32[]);
			this.uvs2 = default(Vector2[]);
			this.uvs0 = default(Vector2[]);
			this.tangents = default(Vector4[]);
			this.normals = default(Vector3[]);
			this.vertices = default(Vector3[]);
			this.vertexCount = default(int);
			this.mesh = default(Mesh);
		}

		public void ResizeMeshInfo(int size)
		{
		}

		public void ResizeMeshInfo(int size, bool isVolumetric)
		{
		}

		public void Clear()
		{
		}

		public void Clear(bool uploadChanges)
		{
		}

		public void ClearUnusedVertices()
		{
		}

		public void ClearUnusedVertices(int startIndex)
		{
		}

		public void ClearUnusedVertices(int startIndex, bool updateMesh)
		{
		}

		public void SortGeometry(VertexSortingOrder order)
		{
		}

		public void SortGeometry(IList<int> sortingOrder)
		{
		}

		public void SwapVertexData(int src, int dst)
		{
		}
	}
}

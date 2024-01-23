using System.Collections.Generic;
using UnityEngine;

namespace SplineMesh
{
	public struct SourceMesh
	{
		private Vector3 translation;

		private Quaternion rotation;

		private Vector3 scale;

		private List<MeshVertex> vertices;

		private int[] triangles;

		private float minX;

		private float length;

		internal Mesh Mesh { get; }

		internal List<MeshVertex> Vertices => null;

		internal int[] Triangles => null;

		internal float MinX => 0f;

		internal float Length => 0f;
		
		private SourceMesh(Mesh mesh)
		{
			translation = Vector3.zero;
			rotation = Quaternion.identity;
			scale = Vector3.one;
			vertices = new List<MeshVertex>();
			triangles = new int[0];
			minX = 0;
			length = 0;
			Mesh = mesh;
		}

		private SourceMesh(SourceMesh other)
		{
			translation = Vector3.zero;
			rotation = Quaternion.identity;
			scale = Vector3.one;
			vertices = new List<MeshVertex>();
			triangles = new int[0];
			minX = 0;
			length = 0;
			Mesh = other.Mesh;	
		}

		public static SourceMesh Build(Mesh mesh)
		{
			return default(SourceMesh);
		}

		public SourceMesh Translate(Vector3 translation)
		{
			return default(SourceMesh);
		}

		public SourceMesh Translate(float x, float y, float z)
		{
			return default(SourceMesh);
		}

		public SourceMesh Rotate(Quaternion rotation)
		{
			return default(SourceMesh);
		}

		public SourceMesh Scale(Vector3 scale)
		{
			return default(SourceMesh);
		}

		public SourceMesh Scale(float x, float y, float z)
		{
			return default(SourceMesh);
		}

		private void BuildData()
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(SourceMesh sm1, SourceMesh sm2)
		{
			return false;
		}

		public static bool operator !=(SourceMesh sm1, SourceMesh sm2)
		{
			return false;
		}
	}
}

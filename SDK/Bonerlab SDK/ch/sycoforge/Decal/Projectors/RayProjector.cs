using System;
using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors
{
	[Serializable]
	internal class RayProjector : Projector
	{
		private float width;

		private float length;

		internal Vector3[] sourceVertices;

		internal Vector2[] sourceUVs;

		internal int[] sourceTriangles;

		internal HashSet<int> invalidIndices;

		internal List<int> validIndices;

		internal RayProjector(EasyDecal decal)
		{
		}

		private void CreateProjectionGrid()
		{
		}

		private void CreatePlaneMesh()
		{
		}

		internal override void OnGeometryPropertyChanged()
		{
		}

		internal override void Project()
		{
		}

		internal override void Dispose()
		{
		}

		internal override void DrawGizmos(bool selected)
		{
		}
	}
}

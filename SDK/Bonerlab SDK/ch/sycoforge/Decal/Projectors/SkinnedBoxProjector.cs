using System.Collections.Generic;
using UnityEngine;

namespace ch.sycoforge.Decal.Projectors
{
	internal class SkinnedBoxProjector : BoxProjector
	{
		internal SkinnedBoxProjector(EasyDecal decal) : base(decal)
		{
		}

		internal override void Project()
		{
		}

		private void ProjectUsingList()
		{
		}

		private void ProjectUsingEnviroment()
		{
		}

		protected override void ProcessReceiver(GameObject receiver, int recursiveStepUp, int recursiveStepDown, bool ignoreTerrain = true)
		{
		}

		private void AddMesh(SkinnedMeshRenderer renderer, Transform receiver, Matrix4x4 localToWorld)
		{
		}

		private IList<Transform> GetBones(SkinnedMeshRenderer renderer)
		{
			return null;
		}

		private List<Transform> GetAllChildren(Transform root, List<Transform> r)
		{
			return null;
		}

		internal override void Dispose()
		{
		}

		public static Mesh BakeNoScale(SkinnedMeshRenderer skinnedMeshRenderer)
		{
			return null;
		}
	}
}

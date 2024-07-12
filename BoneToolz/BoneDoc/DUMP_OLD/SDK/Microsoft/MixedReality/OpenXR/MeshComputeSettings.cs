using System;
using System.Runtime.InteropServices;

namespace Microsoft.MixedReality.OpenXR
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 12)]
	public struct MeshComputeSettings
	{
		private MeshType meshType;

		private VisualMeshLevelOfDetail visualMeshLevelOfDetail;

		private MeshComputeConsistency meshComputeConsistency;

		[Obsolete("Obsolete; only visual meshes are supplied through the mesh subsystem. Use a MeshCollider or the method XRMeshSubsystem.GenerateMeshAsync to get collider meshes as needed.")]
		public MeshType MeshType
		{
			get
			{
				return default(MeshType);
			}
			set
			{
			}
		}

		public VisualMeshLevelOfDetail VisualMeshLevelOfDetail
		{
			get
			{
				return default(VisualMeshLevelOfDetail);
			}
			set
			{
			}
		}

		public MeshComputeConsistency MeshComputeConsistency
		{
			get
			{
				return default(MeshComputeConsistency);
			}
			set
			{
			}
		}
	}
}

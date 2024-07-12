using System.Collections.Generic;
using UnityEngine.XR;

namespace Microsoft.MixedReality.OpenXR
{
	internal class MeshSubsystemController : SubsystemController
	{
		public const string Id = "OpenXR Mesh Extension";

		private readonly NativeLibToken nativeLibToken;

		private static List<XRMeshSubsystemDescriptor> s_MeshDescriptors;

		public MeshSubsystemController(NativeLibToken token, IOpenXRContext context)
			: base(context)
		{
		}

		public override void OnSubsystemCreate(ISubsystemPlugin plugin)
		{
		}

		public override void OnSubsystemDestroy(ISubsystemPlugin plugin)
		{
		}
	}
}

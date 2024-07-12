using System.Collections.Generic;
using UnityEngine.XR.ARSubsystems;

namespace Microsoft.MixedReality.OpenXR
{
	internal class RaycastSubsystemController : SubsystemController
	{
		private readonly NativeLibToken nativeLibToken;

		private static List<XRRaycastSubsystemDescriptor> s_RaycastDescriptors;

		public RaycastSubsystemController(NativeLibToken token, IOpenXRContext context)
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

using System.Collections.Generic;
using UnityEngine.XR.ARSubsystems;

namespace Microsoft.MixedReality.OpenXR
{
	internal class PlaneSubsystemController : SubsystemController
	{
		private readonly NativeLibToken nativeLibToken;

		private static List<XRPlaneSubsystemDescriptor> s_PlaneDescriptors;

		public PlaneSubsystemController(NativeLibToken token, IOpenXRContext context)
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

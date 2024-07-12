using System.Collections.Generic;
using UnityEngine.XR.ARSubsystems;

namespace Microsoft.MixedReality.OpenXR
{
	internal class AnchorSubsystemController : SubsystemController
	{
		private readonly NativeLibToken nativeLibToken;

		private static List<XRAnchorSubsystemDescriptor> s_AnchorDescriptors;

		public AnchorSubsystemController(NativeLibToken token, IOpenXRContext context)
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

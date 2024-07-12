using System.Collections.Generic;
using UnityEngine.XR.ARSubsystems;

namespace Microsoft.MixedReality.OpenXR
{
	internal class SessionSubsystemController : SubsystemController
	{
		private readonly NativeLibToken nativeLibToken;

		private static List<XRSessionSubsystemDescriptor> s_SessionDescriptors;

		public SessionSubsystemController(NativeLibToken token, IOpenXRContext context)
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

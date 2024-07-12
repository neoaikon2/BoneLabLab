using UnityEngine.XR;

namespace Microsoft.MixedReality.OpenXR
{
	internal class HandTrackingSubsystemController : SubsystemController
	{
		public const string Id = "OpenXR Input Extension";

		private XRInputSubsystem m_inputExtensionSubsystem;

		public HandTrackingSubsystemController(IOpenXRContext context)
			: base(context)
		{
		}

		public override void OnSubsystemCreate(ISubsystemPlugin plugin)
		{
		}

		public override void OnSubsystemStart(ISubsystemPlugin plugin)
		{
		}

		public override void OnSubsystemStop(ISubsystemPlugin plugin)
		{
		}

		public override void OnSubsystemDestroy(ISubsystemPlugin plugin)
		{
		}
	}
}

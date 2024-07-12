namespace Microsoft.MixedReality.OpenXR
{
	internal abstract class SubsystemController
	{
		protected readonly IOpenXRContext Context;

		public SubsystemController(IOpenXRContext context)
			: base()
		{
		}

		public virtual void OnSubsystemCreate(ISubsystemPlugin plugin)
		{
		}

		public virtual void OnSubsystemStart(ISubsystemPlugin plugin)
		{
		}

		public virtual void OnSubsystemStop(ISubsystemPlugin plugin)
		{
		}

		public virtual void OnSubsystemDestroy(ISubsystemPlugin plugin)
		{
		}
	}
}

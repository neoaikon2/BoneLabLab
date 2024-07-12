namespace Grpc.Core
{
	public class ContextPropagationOptions
	{
		public static readonly ContextPropagationOptions Default;

		private bool propagateDeadline;

		private bool propagateCancellation;

		public bool IsPropagateDeadline
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsPropagateCancellation
		{
			get
			{
				return default(bool);
			}
		}

		public ContextPropagationOptions(bool propagateDeadline = true, bool propagateCancellation = true)
			: base()
		{
		}
	}
}

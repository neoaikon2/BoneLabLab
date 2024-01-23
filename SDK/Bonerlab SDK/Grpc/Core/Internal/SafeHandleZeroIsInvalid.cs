using System.Runtime.InteropServices;

namespace Grpc.Core.Internal
{
	internal abstract class SafeHandleZeroIsInvalid : SafeHandle
	{
		public override bool IsInvalid
		{
			get
			{
				return default(bool);
			}
		}

		public SafeHandleZeroIsInvalid()
			: base(default(System.IntPtr), default(System.Boolean))
		{
		}
	}
}

using System;
using System.Threading;
using Grpc.Core.Internal;

namespace Grpc.Core
{
	public class ContextPropagationToken
	{
		private readonly CallSafeHandle parentCall;

		private readonly DateTime deadline;

		private readonly CancellationToken cancellationToken;

		private readonly ContextPropagationOptions options;

		internal CallSafeHandle ParentCall
		{
			get
			{
				return null;
			}
		}

		internal DateTime ParentDeadline
		{
			get
			{
				return default(DateTime);
			}
		}

		internal CancellationToken ParentCancellationToken
		{
			get
			{
				return default(CancellationToken);
			}
		}

		internal ContextPropagationOptions Options
		{
			get
			{
				return null;
			}
		}

		public ContextPropagationToken()
			: base()
		{
		}
	}
}

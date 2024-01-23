using System;
using System.Runtime.InteropServices;
using System.Threading;
using Grpc.Core.Internal;

namespace Grpc.Core
{
	public struct CallOptions
	{
		private Metadata headers;

		private DateTime? deadline;

		private CancellationToken cancellationToken;

		private WriteOptions writeOptions;

		private ContextPropagationToken propagationToken;

		private CallCredentials credentials;

		private CallFlags flags;

		public Metadata Headers
		{
			get
			{
				return null;
			}
		}

		public DateTime? Deadline
		{
			get
			{
				return null;
			}
		}

		public CancellationToken CancellationToken
		{
			get
			{
				return default(CancellationToken);
			}
		}

		public WriteOptions WriteOptions
		{
			get
			{
				return null;
			}
		}

		public ContextPropagationToken PropagationToken
		{
			get
			{
				return null;
			}
		}

		public CallCredentials Credentials
		{
			get
			{
				return null;
			}
		}

		internal CallFlags Flags
		{
			get
			{
				return default(CallFlags);
			}
		}

		public CallOptions(Metadata headers = default(Metadata), DateTime? deadline = default(DateTime?), CancellationToken cancellationToken = default(CancellationToken), WriteOptions writeOptions = default(WriteOptions), ContextPropagationToken propagationToken = default(ContextPropagationToken), CallCredentials credentials = default(CallCredentials))
		{
			this.flags = default(CallFlags);
			this.credentials = default(CallCredentials);
			this.propagationToken = default(ContextPropagationToken);
			this.writeOptions = default(WriteOptions);
			this.cancellationToken = default(CancellationToken);
			this.deadline = default(DateTime?);
			this.headers = default(Metadata);
		}

		internal CallOptions Normalize()
		{
			return default(CallOptions);
		}
	}
}

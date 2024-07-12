using System;

namespace Grpc.Core.Internal
{
	internal struct Timespec
	{
		private static readonly NativeMethods Native;

		private static readonly DateTime UnixEpoch;

		private long tv_sec;

		private int tv_nsec;

		private ClockType clock_type;

		public static Timespec InfFuture
		{
			get
			{
				return default(Timespec);
			}
		}

		public static Timespec InfPast
		{
			get
			{
				return default(Timespec);
			}
		}

		public long TimevalSeconds
		{
			get
			{
				return default(long);
			}
		}

		public int TimevalNanos
		{
			get
			{
				return default(int);
			}
		}

		internal static Timespec PreciseNow
		{
			get
			{
				return default(Timespec);
			}
		}

		public Timespec(long tv_sec, int tv_nsec)
		{
			this.clock_type = default(ClockType);
			this.tv_nsec = default(int);
			this.tv_sec = default(long);
		}

		public Timespec(long tv_sec, int tv_nsec, ClockType clock_type)
		{
			this.clock_type = default(ClockType);
			this.tv_nsec = default(int);
			this.tv_sec = default(long);
		}

		public static Timespec FromDateTime(DateTime dateTime)
		{
			return default(Timespec);
		}
	}
}

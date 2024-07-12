using System;

namespace Microsoft.Extensions.Logging
{
	[Flags]
	public enum ActivityTrackingOptions
	{
		None = 0,
		SpanId = 1,
		TraceId = 2,
		ParentId = 4,
		TraceState = 8,
		TraceFlags = 0x10,
		Tags = 0x20,
		Baggage = 0x40
	}
}

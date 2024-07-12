using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public enum Syntax
	{
		[OriginalName("SYNTAX_PROTO2")]
		Proto2 = 0,
		[OriginalName("SYNTAX_PROTO3")]
		Proto3 = 1
	}
}

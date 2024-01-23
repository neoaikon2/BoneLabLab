namespace Google.Protobuf
{
	public static class WireFormat
	{
		public enum WireType : uint
		{
			Varint = 0u,
			Fixed64 = 1u,
			LengthDelimited = 2u,
			StartGroup = 3u,
			EndGroup = 4u,
			Fixed32 = 5u
		}

		public static WireType GetTagWireType(uint tag)
		{
			return default(WireType);
		}

		public static int GetTagFieldNumber(uint tag)
		{
			return default(int);
		}

		public static uint MakeTag(int fieldNumber, WireType wireType)
		{
			return default(uint);
		}
	}
}

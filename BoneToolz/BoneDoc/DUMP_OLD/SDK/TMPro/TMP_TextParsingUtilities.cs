namespace TMPro
{
	public class TMP_TextParsingUtilities
	{
		private static readonly TMP_TextParsingUtilities s_Instance;

		private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";

		private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

		public static TMP_TextParsingUtilities instance
		{
			get
			{
				return null;
			}
		}

		static TMP_TextParsingUtilities()
		{
		}

		public static int GetHashCode(string s)
		{
			return default(int);
		}

		public static int GetHashCodeCaseSensitive(string s)
		{
			return default(int);
		}

		public static char ToLowerASCIIFast(char c)
		{
			return default(char);
		}

		public static char ToUpperASCIIFast(char c)
		{
			return default(char);
		}

		public static uint ToUpperASCIIFast(uint c)
		{
			return default(uint);
		}

		public static uint ToLowerASCIIFast(uint c)
		{
			return default(uint);
		}

		public static bool IsHighSurrogate(uint c)
		{
			return default(bool);
		}

		public static bool IsLowSurrogate(uint c)
		{
			return default(bool);
		}

		internal static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate)
		{
			return default(uint);
		}

		public TMP_TextParsingUtilities()
			: base()
		{
		}
	}
}

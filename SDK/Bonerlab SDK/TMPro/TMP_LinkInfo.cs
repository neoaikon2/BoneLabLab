namespace TMPro
{
	public struct TMP_LinkInfo
	{
		public TMP_Text textComponent;

		public int hashCode;

		public int linkIdFirstCharacterIndex;

		public int linkIdLength;

		public int linkTextfirstCharacterIndex;

		public int linkTextLength;

		internal char[] linkID;

		internal void SetLinkID(char[] text, int startIndex, int length)
		{
		}

		public string GetLinkText()
		{
			return null;
		}

		public string GetLinkID()
		{
			return null;
		}
	}
}

using System.Text;

namespace OVRSimpleJSON
{
	public class JSONNull : JSONNode
	{
		private static JSONNull m_StaticInstance;

		public static bool reuseSameInstance;

		public override JSONNodeType Tag => default(JSONNodeType);

		public override bool IsNull => false;

		public override string Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override bool AsBool
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static JSONNull CreateOrGet()
		{
			return null;
		}

		private JSONNull()
		{
		}

		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		public override JSONNode Clone()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}
	}
}

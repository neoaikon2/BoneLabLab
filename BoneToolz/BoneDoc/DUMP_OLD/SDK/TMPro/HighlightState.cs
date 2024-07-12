using UnityEngine;

namespace TMPro
{
	public struct HighlightState
	{
		public Color32 color;

		public TMP_Offset padding;

		public HighlightState(Color32 color, TMP_Offset padding)
		{
			this.padding = default(TMP_Offset);
			this.color = default(Color32);
		}

		public static bool operator ==(HighlightState lhs, HighlightState rhs)
		{
			return default(bool);
		}

		public static bool operator !=(HighlightState lhs, HighlightState rhs)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public bool Equals(HighlightState other)
		{
			return default(bool);
		}
	}
}

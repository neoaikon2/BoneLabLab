using System;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public class TMP_Style
	{
		internal static TMP_Style k_NormalStyle;

		[SerializeField]
		private string m_Name;

		[SerializeField]
		private int m_HashCode;

		[SerializeField]
		private string m_OpeningDefinition;

		[SerializeField]
		private string m_ClosingDefinition;

		[SerializeField]
		private int[] m_OpeningTagArray;

		[SerializeField]
		private int[] m_ClosingTagArray;

		[SerializeField]
		internal uint[] m_OpeningTagUnicodeArray;

		[SerializeField]
		internal uint[] m_ClosingTagUnicodeArray;

		public static TMP_Style NormalStyle
		{
			get
			{
				return null;
			}
		}

		public string name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int hashCode
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public string styleOpeningDefinition
		{
			get
			{
				return null;
			}
		}

		public string styleClosingDefinition
		{
			get
			{
				return null;
			}
		}

		public int[] styleOpeningTagArray
		{
			get
			{
				return null;
			}
		}

		public int[] styleClosingTagArray
		{
			get
			{
				return null;
			}
		}

		internal TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition)
			: base()
		{
		}

		public void RefreshStyle()
		{
		}
	}
}

using System;
using System.Collections.Generic;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	[ExcludeFromPreset]
	public class TMP_StyleSheet : ScriptableObject
	{
		[SerializeField]
		private List<TMP_Style> m_StyleList;

		private Dictionary<int, TMP_Style> m_StyleLookupDictionary;

		internal List<TMP_Style> styles
		{
			get
			{
				return null;
			}
		}

		private void Reset()
		{
		}

		public TMP_Style GetStyle(int hashCode)
		{
			return null;
		}

		public TMP_Style GetStyle(string name)
		{
			return null;
		}

		public void RefreshStyles()
		{
		}

		private void LoadStyleDictionaryInternal()
		{
		}

		public TMP_StyleSheet()
			: base()
		{
		}
	}
}

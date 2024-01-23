using System;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public abstract class TMP_InputValidator : ScriptableObject
	{
		public abstract char Validate(string text, int pos, char ch);

		public TMP_InputValidator()
			: base()
		{
		}
	}
}

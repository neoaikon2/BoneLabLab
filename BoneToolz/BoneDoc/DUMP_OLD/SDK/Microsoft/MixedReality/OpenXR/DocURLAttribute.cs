using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Microsoft.MixedReality.OpenXR
{
	[AttributeUsage(AttributeTargets.Field)]
	internal class DocURLAttribute : PropertyAttribute
	{
		public string Url { get; }

		public DocURLAttribute(string url)
			: base()
		{
		}
	}
}

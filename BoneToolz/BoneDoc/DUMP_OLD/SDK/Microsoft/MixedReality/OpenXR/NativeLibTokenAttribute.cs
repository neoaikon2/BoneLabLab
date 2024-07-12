using System;
using System.Runtime.CompilerServices;

namespace Microsoft.MixedReality.OpenXR
{
	[AttributeUsage(AttributeTargets.Class)]
	internal class NativeLibTokenAttribute : Attribute
	{
		public NativeLibToken NativeLibToken { get; set; }

		public NativeLibTokenAttribute()
			: base()
		{
		}
	}
}

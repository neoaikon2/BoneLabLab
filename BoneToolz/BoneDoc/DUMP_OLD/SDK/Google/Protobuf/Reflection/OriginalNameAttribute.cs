using System;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	[AttributeUsage(AttributeTargets.Field)]
	public class OriginalNameAttribute : Attribute
	{
		public string Name { get; set; }

		public bool PreferredAlias { get; set; }

		public OriginalNameAttribute(string name)
			: base()
		{
		}
	}
}

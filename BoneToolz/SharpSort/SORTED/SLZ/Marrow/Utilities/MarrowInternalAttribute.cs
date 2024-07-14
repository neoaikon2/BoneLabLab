using System;

namespace SLZ.Marrow.Utilities
{
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property, Inherited = false)]
	public class MarrowInternalAttribute : Attribute
	{
	}
}

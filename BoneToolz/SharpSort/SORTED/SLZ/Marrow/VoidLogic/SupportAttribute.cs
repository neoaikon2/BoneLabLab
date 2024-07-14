using System;

namespace SLZ.Marrow.VoidLogic
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
	public class SupportAttribute : Attribute
	{
		public SupportAttribute(SupportFlags supportFlags, string comment = null)
		{
		}
	}
}

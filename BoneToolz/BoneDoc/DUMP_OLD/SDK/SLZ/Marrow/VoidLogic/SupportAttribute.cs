using System;
using System.Runtime.InteropServices;

namespace SLZ.Marrow.VoidLogic
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
	public class SupportAttribute : Attribute
	{
		public SupportAttribute(SupportFlags supportFlags, string comment = default(string))
			: base()
		{
		}
	}
}

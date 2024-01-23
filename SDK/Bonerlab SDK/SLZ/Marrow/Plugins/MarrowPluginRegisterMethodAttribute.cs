using System;
using JetBrains.Annotations;

namespace SLZ.Marrow.Plugins
{
	[MeansImplicitUse]
	[AttributeUsage(AttributeTargets.Method)]
	public class MarrowPluginRegisterMethodAttribute : Attribute
	{
		public MarrowPluginRegisterMethodAttribute()
			: base()
		{
		}
	}
}

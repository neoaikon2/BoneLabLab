using System;
using JetBrains.Annotations;

namespace SLZ.Marrow.Plugins
{
	[AttributeUsage(AttributeTargets.Method)]
	[MeansImplicitUse]
	public class MarrowPluginRegisterMethodAttribute : Attribute
	{
	}
}

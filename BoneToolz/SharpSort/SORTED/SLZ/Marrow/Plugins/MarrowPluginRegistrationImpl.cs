using System;
using System.Collections.Generic;

namespace SLZ.Marrow.Plugins
{
	internal class MarrowPluginRegistrationImpl : IMarrowPluginRegistration
	{
		public Type PluginType { get; internal set; }

		public MarrowPluginAttribute MarrowPluginAttribute { get; internal set; }

		public HashSet<string> Dependencies { get; internal set; }

		public void AddDependency(string qualifiedName)
		{
		}
	}
}

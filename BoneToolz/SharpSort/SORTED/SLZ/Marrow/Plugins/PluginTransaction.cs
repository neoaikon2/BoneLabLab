using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace SLZ.Marrow.Plugins
{
	internal sealed class PluginTransaction : IDisposable
	{
		internal static ThreadLocal<PluginTransaction> _tl_CurrentTransaction;

		private bool _disposedValue;

		private List<(Type type, MarrowPluginAttribute attribute)> PendingPlugins;

		[MethodImpl(256)]
		public static PluginTransaction OpenTransaction()
		{
			return null;
		}

		private void Dispose(bool disposing)
		{
		}

		~PluginTransaction()
		{
		}

		private void System_002EIDisposable_002EDispose()
		{
		}

		public void AddPlugin((Type type, MarrowPluginAttribute attribute) type)
		{
		}

		public bool ContainsPluginType(Type pluginType)
		{
			return false;
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}

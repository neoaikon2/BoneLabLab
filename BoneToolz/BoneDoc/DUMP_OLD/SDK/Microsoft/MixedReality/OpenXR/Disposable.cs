using System;
using System.Runtime.CompilerServices;

namespace Microsoft.MixedReality.OpenXR
{
	internal abstract class Disposable : IDisposable
	{
		protected bool disposedValue { get; private set; }

		protected virtual void DisposeManagedResources()
		{
		}

		protected virtual void DisposeNativeResources()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		~Disposable()
		{
		}

		public void Dispose()
		{
		}

		public Disposable()
			: base()
		{
		}
	}
}

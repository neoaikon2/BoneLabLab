using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace WebSocketSharp.Net
{
	internal class HttpListenerAsyncResult : IAsyncResult
	{
		private AsyncCallback _callback;

		private bool _completed;

		private bool _completedSynchronously;

		private HttpListenerContext _context;

		private bool _endCalled;

		private Exception _exception;

		private object _state;

		private object _sync;

		private ManualResetEvent _waitHandle;

		internal HttpListenerContext Context
		{
			get
			{
				return null;
			}
		}

		internal bool EndCalled
		{
			set
			{
			}
		}

		public object AsyncState
		{
			get
			{
				return null;
			}
		}

		public WaitHandle AsyncWaitHandle
		{
			get
			{
				return null;
			}
		}

		public bool CompletedSynchronously
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsCompleted
		{
			get
			{
				return default(bool);
			}
		}

		internal HttpListenerAsyncResult(AsyncCallback callback, object state)
			: base()
		{
		}

		private void complete()
		{
		}

		internal void Complete(Exception exception)
		{
		}

		internal void Complete(HttpListenerContext context, bool completedSynchronously)
		{
		}
	}
}

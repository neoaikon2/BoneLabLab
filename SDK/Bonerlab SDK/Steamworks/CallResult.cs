using System;
using System.Runtime.CompilerServices;
using Steamworks.Data;

namespace Steamworks
{
	internal struct CallResult<T> : INotifyCompletion where T : struct, ICallbackData
	{
		private SteamAPICall_t call;

		private ISteamUtils utils;

		private bool server;

		public bool IsCompleted
		{
			get
			{
				return default(bool);
			}
		}

		public CallResult(SteamAPICall_t call, bool server)
		{
			this.server = default(bool);
			this.utils = default(ISteamUtils);
			this.call = default(SteamAPICall_t);
		}

		public void OnCompleted(Action continuation)
		{
		}

		public T? GetResult()
		{
			return null;
		}

		internal CallResult<T> GetAwaiter()
		{
			return default(CallResult<T>);
		}
	}
}

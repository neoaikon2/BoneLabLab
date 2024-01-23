using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Steamworks.Data;

namespace Steamworks
{
	public static class Dispatch
	{
		[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 24)]
		internal struct CallbackMsg_t
		{
			public HSteamUser m_hSteamUser;

			public CallbackType Type;

			public IntPtr Data;

			public int DataSize;
		}

		private struct ResultCallback
		{
			public Action continuation;

			public bool server;
		}

		private struct Callback
		{
			public Action<IntPtr> action;

			public bool server;
		}

		public static Action<CallbackType, string, bool> OnDebugCallback;

		public static Action<Exception> OnException;

		private static bool runningFrame;

		private static List<Action<IntPtr>> actionsToCall;

		private static Dictionary<ulong, ResultCallback> ResultCallbacks;

		private static Dictionary<CallbackType, List<Callback>> Callbacks;

		internal static HSteamPipe ClientPipe { get; set; }

		internal static HSteamPipe ServerPipe { get; }

		internal static extern void SteamAPI_ManualDispatch_Init();

		internal static extern void SteamAPI_ManualDispatch_RunFrame(HSteamPipe pipe);

		internal static extern bool SteamAPI_ManualDispatch_GetNextCallback(HSteamPipe pipe, [In][Out] CallbackMsg_t msg);

		internal static extern bool SteamAPI_ManualDispatch_FreeLastCallback(HSteamPipe pipe);

		internal static void Init()
		{
		}

		internal static void Frame(HSteamPipe pipe)
		{
		}

		private static void ProcessCallback(CallbackMsg_t msg, bool isServer)
		{
		}

		internal static string CallbackToString(CallbackType type, IntPtr data, int expectedsize)
		{
			return null;
		}

		private static void ProcessResult(CallbackMsg_t msg)
		{
		}

		[DebuggerStepThrough]
		internal static void LoopClientAsync()
		{
		}

		internal static void OnCallComplete<T>(SteamAPICall_t call, Action continuation, bool server) where T : struct, ICallbackData
		{
		}

		internal static void Install<T>(Action<T> p, bool server = false) where T : ICallbackData
		{
		}

		internal static void ShutdownClient()
		{
		}
	}
}

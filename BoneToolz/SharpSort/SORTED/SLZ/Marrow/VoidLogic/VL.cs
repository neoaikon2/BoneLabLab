using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	public static class VL
	{
		private static NodeState _badState;

		[MethodImpl(256)]
		public static void AddNode(IVoidLogicNode node)
		{
		}

		[MethodImpl(256)]
		public static void RemoveNode(IVoidLogicNode node)
		{
		}

		[MethodImpl(256)]
		public static void EnableNode(IVoidLogicNode node)
		{
		}

		[MethodImpl(256)]
		public static void DisableNode(IVoidLogicNode node)
		{
		}

		[MethodImpl(256)]
		public static void UpdateInput(IVoidLogicSink sink, uint index, IVoidLogicSource source)
		{
		}

		public static float GetValue(MonoBehaviour sourceMb, float defaultValue = 0f)
		{
			return 0f;
		}

		public static bool TryGetInputValueAtIndex(this IVoidLogicSink sink, uint index, out float value)
		{
			value = default(float);
			return false;
		}

		[MethodImpl(256)]
		public static float InputValueOrDefault(this IVoidLogicSink sink, uint index, float defaultValue = 0f)
		{
			return 0f;
		}

		/*
		public unsafe static ref NodeState State(MonoBehaviour sourceMb)
		{
			return ref *(NodeState*)null;
		}

		public unsafe static ref NodeState State(this IVoidLogicSource source)
		{
			return ref *(NodeState*)null;
		}
		*/
	}
}

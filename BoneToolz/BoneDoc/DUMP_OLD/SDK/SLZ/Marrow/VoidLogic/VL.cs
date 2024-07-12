using System.Runtime.InteropServices;
using UnityEngine;

namespace SLZ.Marrow.VoidLogic
{
	public static class VL
	{
		private static NodeState _badState;

		public static void AddNode(IVoidLogicNode node)
		{
		}

		public static void RemoveNode(IVoidLogicNode node)
		{
		}

		public static void EnableNode(IVoidLogicNode node)
		{
		}

		public static void DisableNode(IVoidLogicNode node)
		{
		}

		public static void UpdateInput(IVoidLogicSink sink, uint index, IVoidLogicSource source)
		{
		}

		public static float GetValue(MonoBehaviour sourceMb, float defaultValue = 0f)
		{
			return default(float);
		}

		public static bool TryGetInputValueAtIndex(this IVoidLogicSink sink, uint index, [Out] float value)
		{
			return default(bool);
		}

		public static float InputValueOrDefault(this IVoidLogicSink sink, uint index, float defaultValue = 0f)
		{
			return default(float);
		}

		public static NodeState State(MonoBehaviour sourceMb)
		{
			return default(NodeState);
		}

		public static NodeState State(this IVoidLogicSource source)
		{
			return default(NodeState);
		}
	}
}

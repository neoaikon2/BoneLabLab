using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Google.Protobuf.Reflection
{
	internal static class ReflectionUtil
	{
		private interface IReflectionHelper
		{
			Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method);

			Action<IMessage> CreateActionIMessage(MethodInfo method);

			Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method);

			Action<IMessage, object> CreateActionIMessageObject(MethodInfo method);

			Func<IMessage, bool> CreateFuncIMessageBool(MethodInfo method);
		}

		internal interface IExtensionReflectionHelper
		{
			object GetExtension(IMessage message);

			bool HasExtension(IMessage message);
		}

		private class ReflectionHelper<T1, T2> : IReflectionHelper
		{
			public Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method)
			{
				return null;
			}

			public Action<IMessage> CreateActionIMessage(MethodInfo method)
			{
				return null;
			}

			public Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method)
			{
				return null;
			}

			public Action<IMessage, object> CreateActionIMessageObject(MethodInfo method)
			{
				return null;
			}

			public Func<IMessage, bool> CreateFuncIMessageBool(MethodInfo method)
			{
				return null;
			}

			public ReflectionHelper()
				: base()
			{
			}
		}

		private class ExtensionReflectionHelper<T1, T3> : IExtensionReflectionHelper where T1 : IExtendableMessage<T1>
		{
			private readonly Extension extension;

			public object GetExtension(IMessage message)
			{
				return null;
			}

			public bool HasExtension(IMessage message)
			{
				return default(bool);
			}

			public ExtensionReflectionHelper()
				: base()
			{
			}
		}

		public enum SampleEnum
		{
			X = 0
		}

		internal static readonly Type[] EmptyTypes;

		private static bool CanConvertEnumFuncToInt32Func { get; }

		static ReflectionUtil()
		{
		}

		internal static void ForceInitialize<T>()
		{
		}

		internal static Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method)
		{
			return null;
		}

		internal static Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method)
		{
			return null;
		}

		internal static Action<IMessage, object> CreateActionIMessageObject(MethodInfo method)
		{
			return null;
		}

		internal static Action<IMessage> CreateActionIMessage(MethodInfo method)
		{
			return null;
		}

		internal static Func<IMessage, bool> CreateFuncIMessageBool(MethodInfo method)
		{
			return null;
		}

		internal static IExtensionReflectionHelper CreateExtensionHelper(Extension extension)
		{
			return null;
		}

		private static IReflectionHelper GetReflectionHelper(Type t1, Type t2)
		{
			return null;
		}

		private static bool CheckCanConvertEnumFuncToInt32Func()
		{
			return default(bool);
		}

		public static SampleEnum SampleEnumMethod()
		{
			return default(SampleEnum);
		}
	}
}

namespace Grpc.Core.Utils
{
	public static class GrpcPreconditions
	{
		public static void CheckArgument(bool condition)
		{
		}

		public static void CheckArgument(bool condition, string errorMessage)
		{
		}

		public static T CheckNotNull<T>(T reference)
		{
			return (T)default(T);
		}

		public static T CheckNotNull<T>(T reference, string paramName)
		{
			return (T)default(T);
		}

		public static void CheckState(bool condition)
		{
		}

		public static void CheckState(bool condition, string errorMessage)
		{
		}
	}
}

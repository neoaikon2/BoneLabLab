using UnityEngine;

namespace RootMotion
{
	public static class Warning
	{
		public delegate void Logger(string message);

		public static bool logged;

		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}

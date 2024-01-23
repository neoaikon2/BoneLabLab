using UnityEngine;

namespace RootMotion
{
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		private static T sInstance;

		public static T instance => null;

		protected virtual void Awake()
		{
		}
	}
}

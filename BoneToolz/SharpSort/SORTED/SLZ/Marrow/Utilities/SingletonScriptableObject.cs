using UnityEngine;

namespace SLZ.Marrow.Utilities
{
	public abstract class SingletonScriptableObject<T> : ScriptableObject where T : ScriptableObject
	{
		private static T _instance;

		private bool _killing;

		private static bool creatingInstance;

		private static bool debug;

		public static T Instance => null;

		public bool Killing
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public static bool HasInstance()
		{
			return false;
		}

		protected virtual void OnEnable()
		{
		}
	}
}

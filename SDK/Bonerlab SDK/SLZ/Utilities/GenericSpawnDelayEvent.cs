using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Pool;
using UnityEngine.Events;

namespace SLZ.Utilities
{
	public class GenericSpawnDelayEvent : SpawnEvents
	{
		public float secondsUntilEvent;

		public UnityEvent delayedEvent;

		public override void OnPoolInitialize()
		{
		}

		private UniTaskVoid AsyncDespawn(int timeMs)
		{
			return default(UniTaskVoid);
		}

		public GenericSpawnDelayEvent()
			: base()
		{
		}
	}
}

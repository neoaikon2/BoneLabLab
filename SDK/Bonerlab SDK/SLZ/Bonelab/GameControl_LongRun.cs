using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class GameControl_LongRun : BonelabInternalGameControl
	{
		private Player_Health playerHealth;

		public UnityEvent onDeathEvent;

		private bool playerDeathActive;

		private float cashedDeathTimeAmount;

		private float cashedInstaDeathTimeAmount;

		public override void Start()
		{
		}

		public void OnDisable()
		{
		}

		public void PlayerDeath()
		{
		}

		private void Initialize()
		{
		}

		public void KillPlayerFast()
		{
		}

		private UniTaskVoid KillPlayerAndReset()
		{
			return default(UniTaskVoid);
		}

		public GameControl_LongRun()
			: base()
		{
		}
	}
}

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class TutorialShaft : MonoBehaviour
	{
		public enum ShaftState
		{
			STOPPED = 0,
			MOVING_UP = 1,
			MOVING_DOWN = 2
		}

		public TutorialElevator elevator;

		public ShaftState shaftState;

		public float speed;

		public float shaftHeight;

		public float loopHeight;

		private CancellationTokenSource cts;

		[ContextMenu("StartShaftLoop")]
		public void StartShaftLoop()
		{
		}

		[ContextMenu("StopShaftLoop")]
		public void StopShaftLoop()
		{
		}

		private void OnDestroy()
		{
		}

		private UniTaskVoid MoveShaftLoop(CancellationToken ct)
		{
			return default(UniTaskVoid);
		}

		public TutorialShaft()
			: base()
		{
		}
	}
}

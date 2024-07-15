using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace SLZ.Bonelab
{
	public class CartMultiStop : MonoBehaviour
	{
		[Header("Options")]
		public float maxSpeed;

		public AudioClip startClip;

		public AudioClip stopClip;

		[Header("References")]
		public Transform[] floorTransforms;

		public ConfigurableJoint joint;

		public Rigidbody rb;

		public UnityEvent StopAction;

		private int goalFloor;

		private CancellationTokenSource loopToken;

		private Vector3 targetPosition;

		public void Reset()
		{
		}

		public void Awake()
		{
		}
		private UniTaskVoid CoMoveTargetTransform(int floor, CancellationToken cts)
		{
			return default(UniTaskVoid);
		}

		public void Go(int floor)
		{
		}

		public void GoForward()
		{
		}

		public void GoBackward()
		{
		}
	}
}

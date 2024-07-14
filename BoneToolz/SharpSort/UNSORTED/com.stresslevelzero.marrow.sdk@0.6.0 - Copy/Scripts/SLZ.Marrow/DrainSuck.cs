using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

public class DrainSuck : MonoBehaviour
{
	[SerializeField]
	private LayerMask layerFilter;

	[SerializeField]
	private float impulseTune;

	[SerializeField]
	private float impulseClamp;

	[SerializeField]
	private float suckRange;

	[SerializeField]
	private AnimationCurve suckCurve;

	private List<Rigidbody> filteredRBs;

	private CancellationTokenSource suckCancelToken;

	public void STARTSUCK()
	{
	}

	public void STOPSUCK()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
	private UniTaskVoid SuckLoop(CancellationToken cancelToken)
	{
		return default(UniTaskVoid);
	}
}

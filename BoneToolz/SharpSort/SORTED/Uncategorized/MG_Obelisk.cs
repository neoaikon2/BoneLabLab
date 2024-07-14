using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

public class MG_Obelisk : MonoBehaviour
{
	[SerializeField]
	private GameObject laserObj;

	[SerializeField]
	private GameObject obeliskMoverObj;

	[SerializeField]
	private GameObject[] railTargetObjs;

	[SerializeField]
	private GameObject[] railGuardObjs;

	[SerializeField]
	private float distToRailTarg;

	[SerializeField]
	private int currRailTarg;

	private int currGuard;

	private bool targetReached;

	[SerializeField]
	private GameObject[] damageObjs;

	private int currDamage;

	[SerializeField]
	private GameObject[] sliderObjs;

	[SerializeField]
	private GameObject[] sliderStartObjs;

	[SerializeField]
	private GameObject[] sliderEndObjs;

	private float slideDuration;

	private CancellationTokenSource sliderCTS;

	private CancellationTokenSource laserCTS;

	private void Update()
	{
	}

	private void GoalTargetReached()
	{
	}

	private void SwapGuards()
	{
	}

	private void Obelisk_TakeDamage()
	{
	}

	private void Explode()
	{
	}

	private void FireTheLasers()
	{
	}

	private void StopTheLasers()
	{
	}

	[ContextMenu("MoveSlidersUp")]
	public void MoveSlidersUp()
	{
	}

	[ContextMenu("MoveSlidersDown")]
	public void MoveSlidersDown()
	{
	}

	[ContextMenu("CancelSliderLoop")]
	public void CancelSliderLoop()
	{
	}

	public void MoveSliders(bool up)
	{
	}
	private UniTaskVoid LaserLoop(CancellationToken ct)
	{
		return default(UniTaskVoid);
	}
	private UniTaskVoid SliderLoop(bool up, CancellationToken ct)
	{
		return default(UniTaskVoid);
	}
}

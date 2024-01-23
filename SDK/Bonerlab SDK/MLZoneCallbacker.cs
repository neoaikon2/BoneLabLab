using System;
using System.Runtime.CompilerServices;
using SLZ.Zones;
using UnityEngine;

public class MLZoneCallbacker : MonoBehaviour
{
	private MLZoneSpawner mlSpawner;

	public event Action OnNewTarget
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}
}

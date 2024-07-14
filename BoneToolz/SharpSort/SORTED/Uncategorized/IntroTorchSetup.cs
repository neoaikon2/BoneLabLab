using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Zones;
using UnityEngine;

public class IntroTorchSetup : SpawnDecorator
{
	public Rigidbody attachPoint;

	public int index;

	private ConfigurableJoint _torchJoint;

	public override void OnSpawn(GameObject go)
	{
	}

	private void SetJoint(ConfigurableJoint joint, Rigidbody _connectedBody)
	{
	}

	public void BreakJoint()
	{
	}
	private UniTaskVoid ReactivateTimmer(GameObject go)
	{
		return default(UniTaskVoid);
	}
}

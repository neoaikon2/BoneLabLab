using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Bonelab;
using UnityEngine;

public class LaserCursorJockey : MonoBehaviour
{
	public LaserCursor laserCursor;

	public GameObject uiGameObj;
	public UniTaskVoid TOGGLEUI(bool active = true)
	{
		return default(UniTaskVoid);
	}
}

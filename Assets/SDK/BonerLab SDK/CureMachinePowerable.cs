using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PuppetMasta;
using SLZ.Bonelab;
using SLZ.Bonelab.Obsolete;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.SFX;
using TMPro;
using UnityEngine;

public class CureMachinePowerable : Powerable
{
	[SerializeField]
	private Arena_GameController AGC;

	[SerializeField]
	private List<CuredBrett> curedEnemyList;

	[SerializeField]
	private SubBehaviourFaceanim.FaceEvent[] curedFaceEvents;

	[SerializeField]
	private SubBehaviourFaceanim.FaceEvent[] gameOverFaceEvents;

	[SerializeField]
	private float lineTimeToDisable;

	[SerializeField]
	private int currBatteries;

	[SerializeField]
	private int totalBatteries;

	public int remainingBatteries;

	public float percentageComplete;

	[SerializeField]
	private GameObject[] batteryObjs;

	[SerializeField]
	private List<Transform> batterySpawns;

	[SerializeField]
	private List<Transform> easySpawns;

	[SerializeField]
	private List<Transform> medSpawns;

	[SerializeField]
	private List<Transform> hardSpawns;

	[SerializeField]
	private GameObject batteryLightObj;

	private LineRenderer lineRend;

	[SerializeField]
	private Spawnable friendlyFordSpawnableObject;

	[SerializeField]
	private Spawnable nullRatSpawnableObject;

	[SerializeField]
	private GameObject butterflyPrefab;

	[SerializeField]
	private Transform needleTip;

	[SerializeField]
	private List<Vector3> linePoints;

	[SerializeField]
	private Vector3 point1;

	[SerializeField]
	private Vector3 point2;

	[SerializeField]
	private Vector3 point3;

	[SerializeField]
	private Vector3 point4;

	[SerializeField]
	private GameObject batteryTextParent;

	[SerializeField]
	private TMP_Text batteryText;

	[SerializeField]
	private HeadSFX headSFX;

	[SerializeField]
	private AudioClip winClip;

	[SerializeField]
	private AudioClip confettiClip;

	[SerializeField]
	private AudioClip machineClip;

	[SerializeField]
	private AudioClip cureClip;

	[SerializeField]
	private Grip[] _grips;

	[SerializeField]
	private GameObject glowOrbObject;

	[SerializeField]
	private GameObject moveCylinderObj;

	[SerializeField]
	private GameObject[] glassObjs;

	[SerializeField]
	private ElectricInteractionVolume[] batteryVols;

	[SerializeField]
	private LightControlPowerable leverLightControl;

	[SerializeField]
	private GameObject leverObj;

	public bool isCuring;

	private Coroutine disRoutine;

	[SerializeField]
	private GameObject glowMoverObj;

	private Coroutine moveRoutine;

	[SerializeField]
	private AnimationCurve scaleCurve;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}
	private IEnumerator CoWarmUp()
	{
		return null;
	}

	private void SpawnBattery()
	{
	}

	private void OnCure(Vector3 pos)
	{
	}

	[ContextMenu("TestSplineDraw")]
	public void TestSplineDraw()
	{
	}

	private void DrawCurvedSplineToTarget(Vector3 target, float timeToDisable)
	{
	}

	[ContextMenu("StartMove")]
	public void StartMove()
	{
	}
	private IEnumerator SmoothMoveAlongPoints(float duration)
	{
		return null;
	}
	private IEnumerator CoDisableLR(float time)
	{
		return null;
	}

	public void DisableLineRend()
	{
	}

	public void ToggleBattery()
	{
	}

	private void OnBatteryVolChanged(ElectricInteractionVolume vol, IGrippable host)
	{
	}
	private IEnumerator CoMoveCylinder()
	{
		return null;
	}
	public IEnumerator CoCureAllEnemies()
	{
		return null;
	}

	public void LEVER(float voltage)
	{
	}

	public void DEBUG_CURE_ALL()
	{
	}

	[ContextMenu("TeleportBatToMachine")]
	public void TeleCurrBattToMachine()
	{
	}
}

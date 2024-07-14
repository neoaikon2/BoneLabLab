using System.Collections.Generic;
using SLZ.Marrow.PuppetMasta;
using SLZ.Marrow.Zones;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Splines;

namespace SLZ.Marrow.AI
{
	public class SpawnAISettings : SpawnDecorator
	{
		[FormerlySerializedAs("baseConfig")]
		public BaseEnemyConfig overrideConfig;

		public Transform homeTransform;

		public bool homeIsPost;

		public bool isSoundAggroWhenInSecondaryZone;

		public float investigateTimeout;

		public RoamArea roamArea;

		public bool overrideRoam;

		public Vector2 roamXz;

		public Vector3 roamXyz;

		public Vector2 roamOffset;

		public Vector3 roamOffset3D;

		[Tooltip("Defaults: LegBehaviours:1.35, Omni:2.5, Crablet:1")]
		public float roamSpeed;

		public float wpWaitDuration;

		public float waypointMinTime;

		public int startWaypointIndex;

		public Vector2 spawnerOffset;

		public Vector3 spawnerOffset3D;

		public BehaviourBaseNav.RoamMode roamMode;

		public BehaviourBaseNav.WaypointEvalMode waypointEvalMode;

		public SplineContainer roamSpline;

		public GameObject[] objectPoints;

		public Zone zone;

		public List<Vector3> orderedWaypointList;

		private GameObject _playerObject;

		private List<BehaviourBaseNav> _behaviours;

		[HideInInspector]
		public static bool spawnAIPasted;

		private void Awake()
		{
		}

		private void GetAIBrain()
		{
		}

		public override void OnSpawn(GameObject go)
		{
		}

		public void PostReactivate(BehaviourBaseNav baseNav)
		{
		}

		public void OnDeath(AIBrain brain)
		{
		}

		public void CreateRoamArea()
		{
		}

		[ContextMenu("ResetZoneRoamArea")]
		public void GetZoneArea()
		{
		}

		[ContextMenu("ResetZoneRoamArea3D")]
		public void GetZoneArea3D()
		{
		}

		[ContextMenu("CreateWaypointList")]
		public void CreateListFromSpline()
		{
		}

		[ContextMenu("GetClosestWaypoint")]
		public void GetStartIndexByDist()
		{
		}

		private int GetClosestWaypoint()
		{
			return 0;
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}

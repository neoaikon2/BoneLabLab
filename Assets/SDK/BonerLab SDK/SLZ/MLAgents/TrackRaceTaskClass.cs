using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class TrackRaceTaskClass : TaskClass
	{
		[Header("Objective Section")]
		[Tooltip("The context of the current task")]
		private VehicleSceneContextManager context;

		[Tooltip("Objective not currently being used in race since the checkpoints are spawned by the track generator")]
		private GameObject objectiveObj;

		[Tooltip("Objective not currently being used in race since the checkpoints are spawned by the track generator")]
		public GameObject objectivePrefab;

		[Tooltip("Master clock for how long this track task objective has been active")]
		[Header("Timer Section")]
		public float currentTrackTime;

		[Tooltip("The max amount of time this task can be active for before resetting")]
		public float maxTrackTime;

		[Tooltip("To use the master timer or not")]
		public bool useTrackTimer;

		[Tooltip("The actual race track that is generated")]
		[Header("Race Specific Section")]
		public InfiniteTrackClass infTrack;

		[Tooltip("Best times for each checkpoint")]
		public float[] checkpointTimes;

		[Tooltip("To use both a reward for completing a lap and finishing a race (max laps)")]
		public bool useLapRewards;

		[Tooltip("The reward for completing a single lap")]
		public float singleLapReward;

		[Tooltip("The reward for completing maxLaps number of laps")]
		public float raceCompleteReward;

		[Tooltip("Total laps before race is complete and track is reset")]
		public int maxLaps;

		[Tooltip("The farthest checkpoint indicie thats been passed through")]
		public int currentMaxCp;

		[Tooltip("The farthest contestant on the track")]
		public RaceTaskContestant leader;

		private bool firstTime;

		private RaceUtils raceUtils;

		public event Action RaceComplete
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

		public event Action RaceResetComplete
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

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void FixedUpdate()
		{
		}

		public override void GenerateTask()
		{
		}
		private IEnumerator CheckVP()
		{
			return null;
		}

		private void LinkCheckpoints()
		{
		}

		private void PopulateTask()
		{
		}

		protected override void ClearContestants()
		{
		}

		private void ClearTask()
		{
		}

		private void ClearObjective()
		{
		}

		[ContextMenu("ResetTask")]
		public override void ResetTask()
		{
		}

		private void CheckPointCompleted(RaceTaskContestant contestant, int cp_ind, float currentCpTime)
		{
		}

		private void HandleTaskCompleted(bool successful)
		{
		}

		private void UpdateContestantSpeeds(float desiredSpeed)
		{
		}

		private void HandleTrackTimer()
		{
		}

		protected void ContestantRegistration(RaceTaskContestant temp_contestant, int c)
		{
		}

		protected override void PlaceAndRegisterContestants()
		{
		}

		private void ContestantLapCompleted(Contestant contestant, int lap_number)
		{
		}

		private void SetSizeRanges()
		{
		}

		public new void AddStats()
		{
		}

		public float SplitTime(int checkpointCounter, float cp_time)
		{
			return 0f;
		}
	}
}

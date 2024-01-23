using System;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace SLZ.AI
{
	public class TriggerManager : MonoBehaviour
	{
		public readonly struct TriggerCompareResult
		{
			public readonly int triggerIndex;

			public readonly int targetIndex;

			public readonly int isInTrigger;

			public readonly int hasStateChanged;

			public readonly float distance;

			public readonly Vector3 direction;

			public readonly float angleFromForward;

			public TriggerCompareResult(int _triggerIndex, int _targetIndex, int _isInTrigger, int _hasStateChanged, float _distance, Vector3 _direction, float _angleFromForward)
			{
				triggerIndex = _triggerIndex;
				targetIndex = _targetIndex;
				isInTrigger = _isInTrigger;
				hasStateChanged = _hasStateChanged;
				distance = _distance;
				direction = _direction;
				angleFromForward = _angleFromForward;
			}
		}

		public readonly struct JobTransform
		{
			public readonly Vector3 position;

			public readonly Quaternion rotation;

			public JobTransform(Vector3 _position, Quaternion _rotation)
			{
				position = _position;
				rotation = _rotation;
			}
		}

		public struct TriggerEventGroup
		{
			public bool wasInTrigger;

			public readonly Action<AITarget> onTriggerEnterDelegate;

			public readonly Action<AITarget> onTriggerExitDelegate;

			public TriggerEventGroup(Action<AITarget> onTriggerEnter, Action<AITarget> onTriggerExit)
			{
				wasInTrigger = false;
				onTriggerEnterDelegate = onTriggerEnter;
				onTriggerExitDelegate = onTriggerExit;
			}
		}

		public readonly struct TriggerData
		{
			public readonly int enterTriggerType;

			public readonly float enterRadius;

			public readonly float enterFovAngle;

			public readonly int exitTriggerType;

			public readonly float exitRadius;

			public readonly float exitFovAngle;

			public TriggerData(int triggerType, float radius, float fovAngle)
			{
				enterTriggerType = triggerType;
				enterRadius = radius;
				enterFovAngle = fovAngle;
				exitTriggerType = triggerType ;
				exitRadius = radius;
				exitFovAngle = fovAngle;
			}

			public TriggerData(int _enterTriggerType, float _enterRadius, float _enterFovAngle, int _exitTriggerType, float _exitRadius, float _exitFovAngle)
			{
				enterTriggerType = _enterTriggerType;
				enterRadius = _enterRadius;
				enterFovAngle = _enterFovAngle;
				exitTriggerType = _enterTriggerType;
				exitRadius = _exitRadius;
				exitFovAngle = _exitFovAngle;
			}
		}

		public readonly struct TargetData
		{
			public readonly int targetType;

			public readonly float radius;

			public TargetData(int _targetType, float _radius)
			{
				targetType = _targetType;
				radius = _radius;
			}
		}

		public enum TriggerTypes
		{
			Sphere = 1,
			Cone = 2
		}

		public enum TargetTypes
		{
			Sphere = 1
		}

		public struct AICompareJob : IJobParallelFor
		{
			[ReadOnly]
			public NativeArray<TriggerData> triggerInputs;

			[ReadOnly]
			public NativeArray<JobTransform> triggerTransforms;

			[ReadOnly]
			public NativeArray<TargetData> targetInputs;

			[ReadOnly]
			public NativeArray<JobTransform> targetTransforms;

			[ReadOnly]
			public int targetsLengths;

			[ReadOnly]
			public int targetsLength;

			public NativeArray<TriggerCompareResult> aiResults;

			public void Execute(int i)
			{
			}
		}

		private static TriggerManager _instance;

		private AICompareJob _aiCompareJob;

		private JobHandle _aiCompareJobHandle;

		public int defaultBufferSize;

		private Dictionary<AITrigger, Dictionary<AITarget, TriggerCompareResult>> _resultLookupTable;

		private Dictionary<AITrigger, int> _triggerInputTracker;

		private AITrigger[] _aiTriggers;

		private NativeArray<TriggerData> _triggerInputs;

		private TriggerEventGroup[] _triggerEventGroups;

		private NativeArray<JobTransform> _triggerJobTransforms;

		private int _triggersLength;

		private Dictionary<AITarget, int> _targetInputTracker;

		private AITarget[] _aiTargets;

		private NativeArray<TargetData> _targetInputs;

		private NativeArray<JobTransform> _targetJobTransforms;

		private int _targetsLength;

		private NativeArray<TriggerCompareResult> _aiResults;

		private bool _isFirstPass;

		public static TriggerManager Instance => null;

		private void Awake()
		{
		}

		public bool TryGetResult(AITrigger trigger, AITarget target, out TriggerCompareResult result)
		{
			result = default(TriggerCompareResult);
			return false;
		}

		public static void CreateTrigger(AITrigger aiTrigger, in TriggerData triggerData, Action<AITarget> onTriggerEnter, Action<AITarget> onTriggerExit)
		{
		}

		public static void UpdateTriggerData(AITrigger aiTrigger, in TriggerData triggerData)
		{
		}

		public static void DestroyTrigger(AITrigger aiTrigger)
		{
		}

		public static void CreateTarget(AITarget aiTarget, TargetData targetData)
		{
		}

		public static void UpdateTargetData(AITarget aiTarget, TargetData targetData)
		{
		}

		public static void DestroyTarget(AITarget aiTarget)
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDestroy()
		{
		}
	}
}

using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

[RequireComponent(typeof(OVRSceneAnchor))]
[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_scene_plane")]
[DisallowMultipleComponent]
public class OVRScenePlane : MonoBehaviour, IOVRSceneComponent
{
	private struct GetBoundaryLengthJob : IJob
	{
		public OVRSpace Space;

		[WriteOnly]
		public NativeArray<int> Length;

		public void Execute()
		{
		}
	}

	private struct GetBoundaryJob : IJob
	{
		public OVRSpace Space;

		public NativeArray<Vector2> Boundary;

		public NativeArray<Vector2> PreviousBoundary;

		private bool HasBoundaryChanged()
		{
			return false;
		}

		private static void SetNaN(NativeArray<Vector2> array)
		{
		}

		public void Execute()
		{
		}
	}

	[SerializeField]
	[Tooltip("When enabled, scales the child transforms according to the dimensions of this plane. If both Volume and Plane components exist on the game object, the volume takes precedence.")]
	internal bool _scaleChildren;

	[Tooltip("When enabled, offsets the child transforms according to the offset of this plane. If both Volume and Plane components exist on the game object, the volume takes precedence.")]
	[SerializeField]
	internal bool _offsetChildren;

	internal JobHandle? _jobHandle;

	private NativeArray<Vector2> _previousBoundary;

	private NativeArray<int> _boundaryLength;

	private NativeArray<Vector2> _boundaryBuffer;

	private bool _boundaryRequested;

	private OVRSceneAnchor _sceneAnchor;

	private readonly List<Vector2> _boundary;

	public float Width { get; private set; }

	public float Height { get; private set; }

	public Vector2 Offset { get; private set; }

	public Vector2 Dimensions => default(Vector2);

	public IReadOnlyList<Vector2> Boundary => null;

	public bool ScaleChildren
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool OffsetChildren
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void SetChildScale()
	{
	}

	private void SetChildOffset()
	{
	}

	internal void UpdateTransform()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void IOVRSceneComponent_002EInitialize()
	{
	}

	internal void ScheduleGetLengthJob()
	{
	}

	internal void RequestBoundary()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	public void Initialize()
	{
		throw new System.NotImplementedException();
	}
}

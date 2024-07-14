using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_player_controller")]
public class OVRPlayerController : MonoBehaviour
{
	public float Acceleration;

	public float Damping;

	public float BackAndSideDampen;

	public float JumpForce;

	public float RotationAmount;

	public float RotationRatchet;

	[Tooltip("The player will rotate in fixed steps if Snap Rotation is enabled.")]
	public bool SnapRotation;

	[Tooltip("[Deprecated] When enabled, snap rotation will happen about the center of the guardian rather than the center of the player/camera viewpoint. This (legacy) option should be left off except for edge cases that require extreme behavioral backwards compatibility.")]
	public bool RotateAroundGuardianCenter;

	[Tooltip("How many fixed speeds to use with linear movement? 0=linear control")]
	public int FixedSpeedSteps;

	public bool HmdResetsY;

	public bool HmdRotatesY;

	public float GravityModifier;

	public bool useProfileData;

	[NonSerialized]
	public float CameraHeight;

	[NonSerialized]
	public bool Teleported;

	public bool EnableLinearMovement;

	public bool EnableRotation;

	public bool RotationEitherThumbstick;

	protected CharacterController Controller;

	protected OVRCameraRig CameraRig;

	private float MoveScale;

	private Vector3 MoveThrottle;

	private float FallSpeed;

	private OVRPose? InitialPose;

	private float MoveScaleMultiplier;

	private float RotationScaleMultiplier;

	private bool SkipMouseRotation;

	private bool HaltUpdateMovement;

	private bool prevHatLeft;

	private bool prevHatRight;

	private float SimulationRate;

	private float buttonRotation;

	private bool ReadyToSnapTurn;

	private bool playerControllerEnabled;

	public float InitialYRotation { get; private set; }

	public event Action<Transform> TransformUpdated
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

	public event Action CameraUpdated
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

	public event Action PreCharacterMove
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

	private void Start()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	protected virtual void UpdateController()
	{
	}

	public virtual void UpdateMovement()
	{
	}

	public void UpdateTransform(OVRCameraRig rig)
	{
	}

	public bool Jump()
	{
		return false;
	}

	public void Stop()
	{
	}

	public void GetMoveScaleMultiplier(ref float moveScaleMultiplier)
	{
	}

	public void SetMoveScaleMultiplier(float moveScaleMultiplier)
	{
	}

	public void GetRotationScaleMultiplier(ref float rotationScaleMultiplier)
	{
	}

	public void SetRotationScaleMultiplier(float rotationScaleMultiplier)
	{
	}

	public void GetSkipMouseRotation(ref bool skipMouseRotation)
	{
	}

	public void SetSkipMouseRotation(bool skipMouseRotation)
	{
	}

	public void GetHaltUpdateMovement(ref bool haltUpdateMovement)
	{
	}

	public void SetHaltUpdateMovement(bool haltUpdateMovement)
	{
	}

	public void ResetOrientation()
	{
	}
}

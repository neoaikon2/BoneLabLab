using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_grabber")]
public class OVRGrabber : MonoBehaviour
{
	public float grabBegin;

	public float grabEnd;

	[SerializeField]
	protected bool m_parentHeldObject;

	[SerializeField]
	protected bool m_moveHandPosition;

	[SerializeField]
	protected Transform m_gripTransform;

	[SerializeField]
	protected Collider[] m_grabVolumes;

	[SerializeField]
	protected OVRInput.Controller m_controller;

	[SerializeField]
	protected Transform m_parentTransform;

	[SerializeField]
	protected GameObject m_player;

	protected bool m_grabVolumeEnabled;

	protected Vector3 m_lastPos;

	protected Quaternion m_lastRot;

	protected Quaternion m_anchorOffsetRotation;

	protected Vector3 m_anchorOffsetPosition;

	protected float m_prevFlex;

	protected OVRGrabbable m_grabbedObj;

	protected Vector3 m_grabbedObjectPosOff;

	protected Quaternion m_grabbedObjectRotOff;

	protected Dictionary<OVRGrabbable, int> m_grabCandidates;

	protected bool m_operatingWithoutOVRCameraRig;

	public OVRGrabbable grabbedObject => null;

	public void ForceRelease(OVRGrabbable grabbable)
	{
	}

	protected virtual void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	public virtual void Update()
	{
	}

	private void OnUpdatedAnchors()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnTriggerEnter(Collider otherCollider)
	{
	}

	private void OnTriggerExit(Collider otherCollider)
	{
	}

	protected void CheckForGrabOrRelease(float prevFlex)
	{
	}

	protected virtual void GrabBegin()
	{
	}

	protected virtual void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
	{
	}

	protected void GrabEnd()
	{
	}

	protected void GrabbableRelease(Vector3 linearVelocity, Vector3 angularVelocity)
	{
	}

	protected virtual void GrabVolumeEnable(bool enabled)
	{
	}

	protected virtual void OffhandGrabbed(OVRGrabbable grabbable)
	{
	}

	protected void SetPlayerIgnoreCollision(GameObject grabbable, bool ignore)
	{
	}
}

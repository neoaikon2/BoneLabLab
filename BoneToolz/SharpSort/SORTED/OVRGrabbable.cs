using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_grabbable")]
public class OVRGrabbable : MonoBehaviour
{
	[SerializeField]
	protected bool m_allowOffhandGrab;

	[SerializeField]
	protected bool m_snapPosition;

	[SerializeField]
	protected bool m_snapOrientation;

	[SerializeField]
	protected Transform m_snapOffset;

	[SerializeField]
	protected Collider[] m_grabPoints;

	protected bool m_grabbedKinematic;

	protected Collider m_grabbedCollider;

	protected OVRGrabber m_grabbedBy;

	public bool allowOffhandGrab => false;

	public bool isGrabbed => false;

	public bool snapPosition => false;

	public bool snapOrientation => false;

	public Transform snapOffset => null;

	public OVRGrabber grabbedBy => null;

	public Transform grabbedTransform => null;

	public Rigidbody grabbedRigidbody => null;

	public Collider[] grabPoints => null;

	public virtual void GrabBegin(OVRGrabber hand, Collider grabPoint)
	{
	}

	public virtual void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
	{
	}

	private void Awake()
	{
	}

	protected virtual void Start()
	{
	}

	private void OnDestroy()
	{
	}
}

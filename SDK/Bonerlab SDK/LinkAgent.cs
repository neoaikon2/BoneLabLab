using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using UnityEngine;

public class LinkAgent : Agent
{
	public Rigidbody m_AgentRb;

	private RaycastHit linkCast;

	public float maxLinkDistance;

	private float lookingAtLink;

	private int defaultMask;

	public HingeJoint[] connectPoints;

	private GameObject farthestBack;

	public float LookForLinks()
	{
		return 0f;
	}

	public void AttemptLink()
	{
	}

	public void MoveAgent(ActionSegment<int> act)
	{
	}

	public override void OnActionReceived(ActionBuffers actionBuffers)
	{
	}

	public override void Heuristic(in ActionBuffers actionsOut)
	{
	}

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}

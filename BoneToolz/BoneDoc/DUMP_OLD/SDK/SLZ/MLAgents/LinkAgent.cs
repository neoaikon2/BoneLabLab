using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using UnityEngine;

namespace SLZ.MLAgents
{
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
			return default(float);
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

		public override void Heuristic([In] ActionBuffers actionsOut)
		{
		}

		private void Start()
		{
		}

		private void FixedUpdate()
		{
		}

		public LinkAgent()
			: base()
		{
		}
	}
}

using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using Unity.MLAgentsExamples;
using UnityEngine;

public class BoidAgent : Agent
{
	private OrientationCubeController orientation_cube;

	private BoidController boidController;

	private BoidSensor boidSensor;

	public BoidBallManager boidBallMngr;

	public float rotation_slerp_mod;

	public float move_mod;

	public Rigidbody _rb;

	private float roll;

	private float pitch;

	private float yaw;

	public bool use_cohesion;

	public bool use_alignment;

	public bool use_neighbor;

	public bool ep_rndm_start;

	private float ray_val;

	public bool log_losses;

	public bool log_cum_reward;

	private EnvironmentParameters envParams;

	public override void Initialize()
	{
	}

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	public override void OnEpisodeBegin()
	{
	}

	public void MoveAgent(ActionSegment<int> act)
	{
	}

	public override void Heuristic(in ActionBuffers actionsOut)
	{
	}

	public override void OnActionReceived(ActionBuffers actionBuffers)
	{
	}

	public override void CollectObservations(VectorSensor sensor)
	{
	}

	private void AgentCollisionLoss()
	{
	}

	private void NonAgentCollisionLoss()
	{
	}

	private void UpdateOrientationObjects()
	{
	}
}

using System;
using SLZ.AI;
using UnityEngine;

namespace SLZ.Bonelab
{
	[Serializable]
	public class DeadData
	{
		public AIBrain aiBrain;

		public int spawnOrder;

		public Vector3 deathPos;

		public int round;

		public int wave;

		public DeadData()
			: base()
		{
		}
	}
}

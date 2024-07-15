using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SLZ.Marrow.AI;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BoidBullet : MonoBehaviour
	{
		public delegate void OnDespawnDelegate(BehaviourBoidAgent_SlicedInference boid);
		public float maxTimeAlive;

		public float currentTimeAlive;

		public BehaviourBoidAgent_SlicedInference boidAgent;

		private TriggerRefProxy temp_trp;

		public event OnDespawnDelegate OnDespawn
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
		public IEnumerator DespawnCounter()
		{
			return null;
		}

		private void OnCollisionEnter(Collision collision)
		{
		}
	}
}

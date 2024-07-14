using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class FABRIKChain
	{
		public FABRIK ik;

		[Range(0f, 1f)]
		public float pull;

		[Range(0f, 1f)]
		public float pin;

		public int[] children;

		public bool IsValid(ref string message)
		{
			return false;
		}

		public void Initiate()
		{
		}

		public void Stage1(FABRIKChain[] chain)
		{
		}

		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}
	}
}

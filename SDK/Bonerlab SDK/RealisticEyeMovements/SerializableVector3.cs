using System;
using UnityEngine;

namespace RealisticEyeMovements
{
	[Serializable]
	public struct SerializableVector3
	{
		public float x;

		public float y;

		public float z;

		public SerializableVector3(float rX, float rY, float rZ)
		{
			x = rX;
			y = rY;
			z = rZ;
		}

		public override string ToString()
		{
			return null;
		}

		public static implicit operator Vector3(SerializableVector3 rValue)
		{
			return default(Vector3);
		}

		public static implicit operator SerializableVector3(Vector3 rValue)
		{
			return default(SerializableVector3);
		}
	}
}

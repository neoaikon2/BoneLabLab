using System;
using UnityEngine;

namespace RealisticEyeMovements
{
	[Serializable]
	public struct SerializableQuaternion
	{
		public float x;

		public float y;

		public float z;

		public float w;

		public SerializableQuaternion(float rX, float rY, float rZ, float rW)
		{
			x = 0f;
			y = 0f;
			z = 0f;
			w = 0f;
		}

		public override string ToString()
		{
			return null;
		}

		public static implicit operator Quaternion(SerializableQuaternion rValue)
		{
			return default(Quaternion);
		}

		public static implicit operator SerializableQuaternion(Quaternion rValue)
		{
			return default(SerializableQuaternion);
		}
	}
}

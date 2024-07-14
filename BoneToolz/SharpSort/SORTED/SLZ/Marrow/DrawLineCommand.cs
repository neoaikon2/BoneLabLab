using UnityEngine;

namespace SLZ.Marrow
{
	public struct DrawLineCommand
	{
		public float startTime;

		public float duration;

		public Vector3[] verticies;

		public Color[] colors;

		public int[] indicies;

		public bool isDrawOnce;

		public void Draw(Vector3 start, Vector3 end, Color color, float startTime, float duration, bool isDrawOnce)
		{
		}

		public void CopyToBuffers(int startBufferIndex, in Vector3[] verticies, in Color[] colors, in int[] indicies, ref int vertLength)
		{
		}

		public void CopyToCommand(ref DrawLineCommand other)
		{
		}
	}
}

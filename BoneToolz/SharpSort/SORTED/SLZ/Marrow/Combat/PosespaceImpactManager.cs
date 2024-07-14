using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Marrow.Combat
{
	[Serializable]
	public class PosespaceImpactManager
	{
		private const int MAX_HITS = 32;

		public static int EllipsoidPosArrayID;

		public static int NumberOfHitsID;

		[NonSerialized]
		public Matrix4x4[] hitDataMatrixArray;

		[NonSerialized]
		private int m_Count;

		[NonSerialized]
		private int ptr;

		public int count => 0;

		[MethodImpl(256)]
		public void AddImpact(ref Matrix4x4 hitMatrix)
		{
		}

		public void RemoveImpacts(int removeCount)
		{
		}

		public void ClearImpacts()
		{
		}

		public Matrix4x4 GetImpact(int index)
		{
			return default(Matrix4x4);
		}

		public void SetImpactsOnMaterial(Material mat)
		{
		}
	}
}

using System;
using UnityEngine;

namespace TMPro
{
	[Serializable]
	public class TMP_TextInfo
	{
		internal static Vector2 k_InfinityVectorPositive;

		internal static Vector2 k_InfinityVectorNegative;

		public TMP_Text textComponent;

		public int characterCount;

		public int spriteCount;

		public int spaceCount;

		public int wordCount;

		public int linkCount;

		public int lineCount;

		public int pageCount;

		public int materialCount;

		public TMP_CharacterInfo[] characterInfo;

		public TMP_WordInfo[] wordInfo;

		public TMP_LinkInfo[] linkInfo;

		public TMP_LineInfo[] lineInfo;

		public TMP_PageInfo[] pageInfo;

		public TMP_MeshInfo[] meshInfo;

		private TMP_MeshInfo[] m_CachedMeshInfo;

		public TMP_TextInfo()
			: base()
		{
		}

		internal TMP_TextInfo(int characterCount)
			: this()
		{
		}

		public TMP_TextInfo(TMP_Text textComponent)
			: this()
		{
		}

		public void Clear()
		{
		}

		internal void ClearAllData()
		{
		}

		public void ClearMeshInfo(bool updateMesh)
		{
		}

		public void ClearAllMeshInfo()
		{
		}

		public void ResetVertexLayout(bool isVolumetric)
		{
		}

		public void ClearUnusedVertices(MaterialReference[] materials)
		{
		}

		public void ClearLineInfo()
		{
		}

		internal void ClearPageInfo()
		{
		}

		public TMP_MeshInfo[] CopyMeshInfoVertexData()
		{
			return null;
		}

		public static void Resize<T>(T[] array, int size)
		{
		}

		public static void Resize<T>(T[] array, int size, bool isBlockAllocated)
		{
		}
	}
}

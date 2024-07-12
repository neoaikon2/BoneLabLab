using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;

namespace SLZ.Bonelab
{
	[PreferBinarySerialization]
	public class VtxStructCollection : ScriptableObject
	{
		[Serializable]
		public class ShaderLayout
		{
			public Shader shader;

			public List<SerializedVtxAttrArray> vtxAttr;

			public HashSet<ulong> m_VtxAttrSet;

			public HashSet<ulong> vtxAttrSet
			{
				get
				{
					return null;
				}
			}

			public ShaderLayout(Shader shader)
				: base()
			{
			}

			public ShaderLayout(Shader shader, VertexAttributeDescriptor[] vtxAttribute)
				: base()
			{
			}

			public ShaderLayout(Shader shader, VertexAttributeDescriptor[] vtxAttribute, ulong hashCode)
				: base()
			{
			}

			public void AddLayout(VertexAttributeDescriptor[] vtxAttribute)
			{
			}

			public void AddLayout(VertexAttributeDescriptor[] vtxAttribute, ulong vtxHash)
			{
			}

			public VertexAttributeDescriptor[] GetLayout(int index)
			{
				return null;
			}
		}

		[Serializable]
		public struct SerializedVtxAttrArray
		{
			public SerializedVtxAttrDesc[] desc;

			public SerializedVtxAttrArray(SerializedVtxAttrDesc[] desc)
			{
				this.desc = default(SerializedVtxAttrDesc[]);
			}

			public SerializedVtxAttrArray(VertexAttributeDescriptor[] desc)
			{
				this.desc = default(SerializedVtxAttrDesc[]);
			}

			public ulong GetLongHashCode()
			{
				return default(ulong);
			}

			public override int GetHashCode()
			{
				return default(int);
			}

			public ShaderWarmupSetup GetWarmupSetup()
			{
				return default(ShaderWarmupSetup);
			}
		}

		[Serializable]
		[StructLayout(2)]
		public struct SerializedVtxAttrDesc
		{
			public VertexAttribute attribute;

			public VertexAttributeFormat format;

			public int dimension;

			public int stream;
		}

		public List<ShaderLayout> shaderLayouts;

		[NonSerialized]
		private Dictionary<Shader, int> m_ShaderToLayout;

		public Dictionary<Shader, int> shaderToLayout
		{
			get
			{
				return null;
			}
		}

		public void RefreshShaderToLayout()
		{
		}

		public static ulong GetVtxAttributeHashCode(VertexAttributeDescriptor[] desc)
		{
			return default(ulong);
		}

		public static SerializedVtxAttrDesc[] ToSerialized(VertexAttributeDescriptor[] desc)
		{
			return null;
		}

		public static VertexAttributeDescriptor[] FromSerialized(SerializedVtxAttrDesc[] desc)
		{
			return null;
		}

		public void AddLayoutForShader(Shader s, VertexAttributeDescriptor[] vtxAttribute)
		{
		}

		public void AddLayoutForShader(Shader s, VertexAttributeDescriptor[] vtxAttribute, ulong vtxAttributeHash)
		{
		}

		public void PreWarmShaders()
		{
		}

		public void PreWarmShadersWithCollection(ShaderVariantCollection collection)
		{
		}

		public void PreWarmShaderBruteForce()
		{
		}

		public VtxStructCollection()
			: base()
		{
		}
	}
}
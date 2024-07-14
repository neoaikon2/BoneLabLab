using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using OVRSimpleJSON;
using UnityEngine;

public class OVRGLTFLoader
{
	private const float LoadingMaxTimePerFrame = 1f / 70f;

	private readonly Func<Stream> m_deferredStream;

	private JSONNode m_jsonData;

	private Stream m_glbStream;

	private GameObject[] m_Nodes;

	private Dictionary<OVRGLTFInputNode, OVRGLTFAnimatinonNode> m_InputAnimationNodes;

	private Dictionary<int, OVRGLTFAnimatinonNode[]> m_AnimationLookup;

	private Dictionary<int, OVRGLTFAnimationNodeMorphTargetHandler> m_morphTargetHandlers;

	private Shader m_Shader;

	private Shader m_AlphaBlendShader;

	private OVRTextureQualityFiltering m_TextureQuality;

	private float m_TextureMipmapBias;

	public OVRGLTFScene scene;

	public static readonly Vector3 GLTFToUnitySpace;

	public static readonly Vector3 GLTFToUnityTangent;

	public static readonly Vector4 GLTFToUnitySpace_Rotation;

	private static Dictionary<string, OVRGLTFInputNode> InputNodeNameMap;

	public Func<string, Material, Texture2D> textureUriHandler;

	private Dictionary<int, Texture2D> m_textures;

	private Dictionary<int, Material> m_materials;

	private float m_processingNodesStart;

	private OVRGLTFAccessor _dataAccessor;

	public OVRGLTFLoader(string fileName)
	{
	}

	public OVRGLTFLoader(byte[] data)
	{
	}

	public OVRGLTFLoader(Func<Stream> deferredStream)
	{
	}

	public OVRGLTFScene LoadGLB(bool supportAnimation, bool loadMips = true)
	{
		return default(OVRGLTFScene);
	}
	public IEnumerator LoadGLBCoroutine(bool supportAnimation, bool loadMips = true)
	{
		return null;
	}

	private JSONNode InitializeGLBLoad()
	{
		return null;
	}

	public void SetModelShader(Shader shader)
	{
	}

	public void SetModelAlphaBlendShader(Shader shader)
	{
	}

	public void SetTextureQualityFiltering(OVRTextureQualityFiltering loadedTexturesQuality)
	{
	}

	public void SetMipMapBias(float loadedTexturesMipmapBiasing)
	{
	}

	public static OVRTextureQualityFiltering DetectTextureQuality(in Texture2D srcTexture)
	{
		return default(OVRTextureQualityFiltering);
	}

	public static void ApplyTextureQuality(OVRTextureQualityFiltering qualityLevel, ref Texture2D destTexture)
	{
	}

	public static bool ValidateGLB(Stream glbStream)
	{
		return false;
	}

	public static byte[] ReadChunk(Stream glbStream, OVRChunkType type)
	{
		return null;
	}

	public static bool ValidateChunk(Stream glbStream, OVRChunkType type, out uint chunkLength)
	{
		chunkLength = default(uint);
		return false;
	}
	private IEnumerator LoadGLTF(bool supportAnimation, bool loadMips)
	{
		return null;
	}
	private IEnumerator ProcessNode(JSONArray nodes, int nodeId, bool loadMips, Transform parent)
	{
		return null;
	}

	private OVRMeshData ProcessMesh(JSONNode meshNode, bool loadMips)
	{
		return default(OVRMeshData);
	}

	private static void FlipTriangleIndices(ref int[] indices)
	{
	}

	private OVRMeshAttributes ReadMeshAttributes(JSONNode jsonAttributes, int totalVertexCount, int vertexOffset)
	{
		return default(OVRMeshAttributes);
	}

	private void ProcessSkin(JSONNode skinNode, SkinnedMeshRenderer renderer)
	{
	}

	private OVRMaterialData ProcessMaterial(int matId)
	{
		return default(OVRMaterialData);
	}

	private OVRTextureData ProcessTexture(int textureId)
	{
		return default(OVRTextureData);
	}

	private void TranscodeTexture(ref OVRTextureData textureData)
	{
	}

	private Material CreateUnityMaterial(OVRMaterialData matData, bool loadMips)
	{
		return null;
	}

	private OVRGLTFInputNode GetInputNodeType(string name)
	{
		return default(OVRGLTFInputNode);
	}
	private IEnumerator ProcessAnimations()
	{
		return null;
	}
}

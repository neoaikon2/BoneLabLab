using System;
using System.Collections.Generic;
using System.IO;
using OVRSimpleJSON;
using UnityEngine;

public class OVRGLTFAccessor : IDisposable
{
	private struct GLTFAccessor
	{
		public OVRGLTFType Type;

		public OVRGLTFComponentType ComponentType;

		public int ComponentTypeStride;

		public int BufferViewIndex;

		public int ByteOffset;

		public int Count;

		public JSONNode Min;

		public JSONNode Max;
	}

	private struct GLTFBufferView
	{
		public int BufferIndex;

		public int ByteOffset;

		public int ByteLength;

		public int ByteStride;
	}

	private struct GLTFBuffer
	{
		public int ByteLength;
	}

	private readonly List<GLTFAccessor> _accessors;

	private readonly List<GLTFBufferView> _bufferViews;

	private readonly List<GLTFBuffer> _buffers;

	private readonly Stream _binaryChunk;

	private readonly int _binaryChunkLength;

	private readonly int _binaryChunkStart;

	private readonly BinaryReader _reader;

	private GLTFAccessor _activeGltfAccessor;

	private GLTFBufferView _activeBufferView;

	private GLTFBuffer _activeBuffer;

	private int _activeBufferOffset;

	private bool _requireStrideSeek;

	public static bool TryCreate(JSONNode accessorsRoot, JSONNode bufferViewsRoot, JSONNode buffersRoot, Stream binaryChunk, out OVRGLTFAccessor dataAccessor)
	{
		dataAccessor = null;
		return false;
	}

	private OVRGLTFAccessor(JSONNode accessorsRoot, JSONNode bufferViewsRoot, JSONNode buffersRoot, BinaryReader binaryChunkReader, int binaryChinkStart, int binaryChunkLength)
	{
	}

	private static OVRGLTFType ToOVRType(string type)
	{
		return default(OVRGLTFType);
	}

	public void Seek(int accessorIndex, bool onlyBufferView = false)
	{
	}

	private void SeekStride(int strideIndex)
	{
	}

	public float[] ReadFloat()
	{
		return null;
	}

	public int[] ReadInt()
	{
		return null;
	}

	public Vector2[] ReadVector2()
	{
		return null;
	}

	public Vector3[] ReadVector3(Vector3 conversionScale)
	{
		return null;
	}

	public Vector4[] ReadVector4(Vector4 conversionScale)
	{
		return null;
	}

	private static int ReadAsInt(BinaryReader reader, OVRGLTFComponentType type)
	{
		return 0;
	}

	private static float ReadAsFloat(BinaryReader reader, OVRGLTFComponentType type)
	{
		return 0f;
	}

	public Color[] ReadColor()
	{
		return null;
	}

	public void ReadWeights(ref BoneWeight[] resultsBoneWeights)
	{
	}

	public void ReadJoints(ref BoneWeight[] resultsBoneWeights)
	{
	}

	public Quaternion[] ReadQuaterion(Vector4 gltfToUnitySpaceRotation)
	{
		return null;
	}

	public Matrix4x4[] ReadMatrix4x4(Vector3 conversionScale)
	{
		return null;
	}

	private int GetStrideForType(OVRGLTFComponentType type)
	{
		return 0;
	}

	private float GetMaxValueForType(OVRGLTFComponentType type)
	{
		return 0f;
	}

	public byte[] ReadBuffer(int bufferViewIndex)
	{
		return null;
	}

	public void Dispose()
	{
	}

	public int GetDataCount()
	{
		return 0;
	}
}

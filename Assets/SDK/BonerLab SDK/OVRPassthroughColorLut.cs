using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

[HelpURL("https://developer.oculus.com/reference/unity/latest/class_o_v_r_passthrough_color_lut")]
public class OVRPassthroughColorLut : IDisposable
{
	public enum ColorChannels
	{
		Rgb = 1,
		Rgba = 2
	}

	private struct WriteColorsAsBytesJob : IJobParallelFor
	{
		[WriteOnly]
		[NativeDisableParallelForRestriction]
		public NativeArray<byte> target;

		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public NativeArray<Color> source;

		public int channelCount;

		public void Execute(int index)
		{
		}
	}

	private static class ColorLutTextureConverter
	{
		private struct MapColorValuesJob : IJobParallelFor
		{
			public TextureSettings settings;

			[NativeDisableParallelForRestriction]
			[WriteOnly]
			public NativeArray<byte> target;

			[ReadOnly]
			[NativeDisableParallelForRestriction]
			public NativeArray<byte> source;

			public void Execute(int index)
			{
			}
		}

		private struct TextureSettings
		{
			public int Width { get; }

			public int Height { get; }

			public int Resolution { get; }

			public int SlicesPerRow { get; }

			public int ChannelCount { get; }

			public bool FlipY { get; }

			public TextureSettings(int width, int height, int resolution, int slicesPerRow, int channelCount, bool flipY)
			{
				Width = 0;
				Height = 0;
				Resolution = 0;
				SlicesPerRow = 0;
				ChannelCount = 0;
				FlipY = false;
			}
		}

		public static void TextureToColorByteMap(Texture2D lut, int channelCount, byte[] target, bool flipY)
		{
		}

		private static void MapColorValues(TextureSettings settings, NativeArray<byte> source, byte[] target)
		{
		}

		private static TextureSettings GetTextureSettings(Texture2D lut, int channelCount, bool flipY)
		{
			return default(TextureSettings);
		}

		internal static bool TryGetTextureLayout(int width, int height, out int resolution, out int slicesPerRow, out string errorMessage)
		{
			resolution = default(int);
			slicesPerRow = default(int);
			errorMessage = null;
			return false;
		}
	}

	private enum CreateState
	{
		Invalid = 0,
		Pending = 1,
		Created = 2
	}

	private const int RecomendedBatchSize = 128;

	internal ulong _colorLutHandle;

	private GCHandle _allocHandle;

	private OVRPlugin.PassthroughColorLutData _lutData;

	private int _channelCount;

	private byte[] _colorBytes;

	private object _locker;

	private CreateState _createState;

	public uint Resolution { get; private set; }

	public ColorChannels Channels { get; private set; }

	[Obsolete("IsInitialized is obsoleted. Instead use IsValid.", false)]
	public bool IsInitialized => false;

	public bool IsValid => false;

	public OVRPassthroughColorLut(Texture2D initialLutTexture, bool flipY = true)
	{
	}

	public OVRPassthroughColorLut(Color[] initialColorLut, ColorChannels channels)
	{
	}

	public OVRPassthroughColorLut(Color32[] initialColorLut, ColorChannels channels)
	{
	}

	public OVRPassthroughColorLut(byte[] initialColorLut, ColorChannels channels)
	{
	}

	public void UpdateFrom(Color[] colors)
	{
	}

	public void UpdateFrom(Color32[] colors)
	{
	}

	public void UpdateFrom(byte[] colors)
	{
	}

	public void UpdateFrom(Texture2D lutTexture, bool flipY = true)
	{
	}

	public void Dispose()
	{
	}

	private void FreeAllocHandle()
	{
	}

	public static bool IsTextureSupported(Texture2D texture, out string errorMessage)
	{
		errorMessage = null;
		return false;
	}

	private OVRPassthroughColorLut(int size, ColorChannels channels)
	{
	}

	private bool IsValidUpdateResolution(int lutSize, int elementByteSize)
	{
		return false;
	}

	private bool IsValidLutUpdate<T>(T[] colorArray, int elementByteSize)
	{
		return false;
	}

	private static ColorChannels GetChannelsForTextureFormat(TextureFormat format)
	{
		return default(ColorChannels);
	}

	private static int GetTextureSizeFromByteArray(byte[] initialColorLut, ColorChannels channels)
	{
		return 0;
	}

	private static int GetTextureSize(Texture2D texture)
	{
		return 0;
	}

	private static int GetArraySize<T>(T[] array)
	{
		return 0;
	}

	private static int ChannelsToCount(ColorChannels channels)
	{
		return 0;
	}

	private static bool IsResolutionAccepted(uint resolution, int size, out string errorMessage)
	{
		errorMessage = null;
		return false;
	}

	private static bool IsPowerOfTwo(uint x)
	{
		return false;
	}

	private void Create(OVRPlugin.PassthroughColorLutData lutData)
	{
	}

	private void RefreshIfInitialized(bool isInitialized)
	{
	}

	private void Recreate()
	{
	}

	private void InternalCreate()
	{
	}

	private static uint GetResolutionFromSize(int size)
	{
		return 0u;
	}

	private OVRPlugin.PassthroughColorLutData CreateLutData(out byte[] colorBytes)
	{
		colorBytes = null;
		return default(OVRPlugin.PassthroughColorLutData);
	}

	private OVRPlugin.PassthroughColorLutData CreateLutDataFromTexture(Texture2D lut, bool flipY)
	{
		return default(OVRPlugin.PassthroughColorLutData);
	}

	private OVRPlugin.PassthroughColorLutData CreateLutDataFromArray(Color[] colors)
	{
		return default(OVRPlugin.PassthroughColorLutData);
	}

	private OVRPlugin.PassthroughColorLutData CreateLutDataFromArray(Color32[] colors)
	{
		return default(OVRPlugin.PassthroughColorLutData);
	}

	private OVRPlugin.PassthroughColorLutData CreateLutDataFromArray(byte[] colors)
	{
		return default(OVRPlugin.PassthroughColorLutData);
	}

	private void WriteColorsAsBytes(Color[] colors, byte[] target)
	{
	}

	private void WriteColorsAsBytes(Color32[] colors, byte[] target)
	{
	}

	~OVRPassthroughColorLut()
	{
	}

	private void Destroy()
	{
	}
}

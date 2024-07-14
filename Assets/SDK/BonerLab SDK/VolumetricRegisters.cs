using System.Collections.Generic;

public class VolumetricRegisters
{
	public static List<VolumetricMedia> VolumetricMediaEntities;

	public static List<BakedVolumetricArea> volumetricAreas;

	public static List<VolumetricRendering> volumetricRenderers;

	public static bool _meshObjectsNeedRebuilding;

	public static void RegisterVolumetricArea(BakedVolumetricArea volumetricArea)
	{
	}

	public static void UnregisterVolumetricArea(BakedVolumetricArea volumetricArea)
	{
	}

	public static void RegisterParticipatingMedia(VolumetricMedia volumetricMedia)
	{
	}

	public static void UnregisterParticipatingMedia(VolumetricMedia volumetricMedia)
	{
	}

	public static void RegisterVolumetricRenderer(VolumetricRendering volumetricRenderer)
	{
	}

	public static void UnregisterVolumetricRenderer(VolumetricRendering volumetricRenderer)
	{
	}

	public static void ForceRefreshClipmaps()
	{
	}
}

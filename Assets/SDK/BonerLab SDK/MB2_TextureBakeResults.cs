using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DigitalOpus.MB.Core;
using UnityEngine;

public class MB2_TextureBakeResults : ScriptableObject
{
	public class CoroutineResult
	{
		public bool isComplete;
	}

	public enum ResultType
	{
		atlas = 0,
		textureArray = 1
	}
	public int version;

	public ResultType resultType;

	public MB_MaterialAndUVRect[] materialsAndUVRects;

	public MB_MultiMaterial[] resultMaterials;

	public MB_MultiMaterialTexArray[] resultMaterialsTexArray;

	public bool doMultiMaterial;

	public static int VERSION => 0;

	private void OnEnable()
	{
	}

	public int NumResultMaterials()
	{
		return 0;
	}

	public Material GetCombinedMaterialForSubmesh(int idx)
	{
		return null;
	}
	public IEnumerator FindRuntimeMaterialsFromAddresses(CoroutineResult isComplete)
	{
		return null;
	}

	public bool GetConsiderMeshUVs(int idxInSrcMats, Material srcMaterial)
	{
		return false;
	}

	public List<Material> GetSourceMaterialsUsedByResultMaterial(int resultMatIdx)
	{
		return null;
	}

	public static MB2_TextureBakeResults CreateForMaterialsOnRenderer(GameObject[] gos, List<Material> matsOnTargetRenderer)
	{
		return null;
	}

	public bool DoAnyResultMatsUseConsiderMeshUVs()
	{
		return false;
	}

	public bool ContainsMaterial(Material m)
	{
		return false;
	}

	public string GetDescription()
	{
		return null;
	}

	public void UpgradeToCurrentVersion(MB2_TextureBakeResults tbr)
	{
	}

	public static bool IsMeshAndMaterialRectEnclosedByAtlasRect(MB_TextureTilingTreatment tilingTreatment, Rect uvR, Rect sourceMaterialTiling, Rect samplingEncapsulatinRect, MB2_LogLevel logLevel)
	{
		return false;
	}
}

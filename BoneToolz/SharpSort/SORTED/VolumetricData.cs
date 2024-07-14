using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(fileName = "Volumetric Rendering Settings", menuName = "Rendering/Volumetric Rendering Settings", order = 10)]
public class VolumetricData : ScriptableObject
{
	[Header("Volumetric camera settings")]
	[Tooltip("Near Clip plane")]
	public float near;

	[Tooltip("Far Clip plane")]
	public float far;

	[Tooltip("Resolution")]
	public int FroxelWidthResolution;

	[Tooltip("Resolution")]
	public int FroxelHeightResolution;

	[Tooltip("Resolution")]
	public int FroxelDepthResolution;

	[Tooltip("Textile resolution per unit")]
	[Header("Prebaked clipmap settings - Controls both cascades")]
	public int ClipMapResolution;

	[Tooltip("Size of inner clipmap in units. Outter clipmap is 5x the size")]
	public float ClipmapScale;

	public float ClipmapScale2;

	[Tooltip("Distance (m) from previous sampling point to trigger resampling clipmap")]
	public float ClipmapResampleThreshold;
}

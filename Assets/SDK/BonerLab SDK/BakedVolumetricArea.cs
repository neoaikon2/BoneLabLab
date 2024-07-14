using UnityEngine;

[ExecuteInEditMode]
public class BakedVolumetricArea : MonoBehaviour
{
	[Tooltip("Texel density per meter. Controls the resolution of the baked texture.")]
	[SerializeField]
	public float TexelDensity;

	[SerializeField]
	public Vector3 BoxScale;

	[SerializeField]
	public Texture3D bakedTexture;

	[SerializeField]
	public Vector3Int NormalizedTexelDensity;

	[SerializeField]
	[HideInInspector]
	public Vector3 NormalizedScale;

	[HideInInspector]
	[SerializeField]
	public Vector3 Corner;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnValidate()
	{
	}
}

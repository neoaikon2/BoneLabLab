using System;
using SLZ.Marrow.Data;
using UnityEngine;

namespace SLZ.Data
{
	[Serializable]
	[CreateAssetMenu(fileName = "Surface", menuName = "Variables/Surface", order = 10)]
	public class SurfaceData : ScriptableObject
	{
		[Serializable]
		public struct MaterialLevel
		{
			public Material material;

			public float size;

			public DecalAtlasData atlasData;

			public bool useVertexColor;
		}

		[Header("Options")]
		[Range(0.001f, 1f)]
		public float PenetrationResistance;

		public float megaPascal;

		public bool isFlammable;

		public float fireResistance;

		[ColorUsage(true, true)]
		public Color ParicleColorTint;

		[Header("References")]
		public PhysicMaterial physicMaterial;

		public Spawnable impactEffectSpawnable;

		public Spawnable bulletDecalSpawnable;

		public MaterialLevel[] BulletDecal;

		public MaterialLevel[] BluntDecal;
	}
}

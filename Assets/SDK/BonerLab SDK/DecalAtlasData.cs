using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DecalAtlasData", menuName = "ScriptableObjects/DecalAtlasData")]
public class DecalAtlasData : ScriptableObject
{
	[Serializable]
	public class AtlasInfo
	{
		public Vector2 atlasMin;

		public Vector2 atlasMax;
	}

	public List<AtlasInfo> data;

	public Texture2D atlasTexture;
}

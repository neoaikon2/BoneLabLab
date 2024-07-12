using System;
using System.Collections.Generic;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class TagList
	{
		[SerializeField]
		public List<BoneTagReference> _tags;

		private HashSet<string> _cachedTagBarcodes;

		private ITaggable _inheritTags;

		private bool initialCache;

		public List<BoneTagReference> Tags
		{
			get
			{
				return null;
			}
		}

		public HashSet<string> CachedTagBarcodes
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ITaggable InheritTags
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void UpdateCache(bool initializeOnly = false)
		{
		}

		public TagList()
			: base()
		{
		}
	}
}

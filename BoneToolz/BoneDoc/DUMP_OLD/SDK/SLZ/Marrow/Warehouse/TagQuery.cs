using System;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class TagQuery
	{
		[SerializeField]
		private BoneTagReference _boneTag;

		[SerializeField]
		[Tooltip("Exclude")]
		public bool _invert;

		public BoneTagReference BoneTag
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Invert
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public TagQuery()
			: base()
		{
		}
	}
}

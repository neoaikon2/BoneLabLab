using System;
using System.Collections.Generic;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public class MarrowQuery
	{
		public enum LogicOperator
		{
			And = 0,
			Or = 1
		}

		[SerializeField]
		[Tooltip("Matches if contains ALL listed tags")]
		private List<TagQuery> _tags;

		[SerializeField]
		[Tooltip("Sets the operator between Tags/Crates")]
		private LogicOperator _operator;

		[Tooltip("Matches if is any listed crates")]
		[SerializeField]
		private List<GenericCrateReference> _crates;

		private HashSet<string> tagQuickLookup;

		private HashSet<string> tagExclusionQuickLookup;

		private HashSet<string> crateQuickLookup;

		public List<TagQuery> Tags
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LogicOperator TagCrateOperator
		{
			get
			{
				return default(LogicOperator);
			}
			set
			{
			}
		}

		public List<GenericCrateReference> Crates
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void Cache()
		{
		}

		public bool Matches(MarrowBody marrowBody)
		{
			return default(bool);
		}

		public bool Matches(MarrowEntity marrowEntity)
		{
			return default(bool);
		}

		public bool Matches(ITaggable taggable)
		{
			return default(bool);
		}

		public MarrowQuery()
			: base()
		{
		}
	}
}

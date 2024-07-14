using System;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow
{
	[Serializable]
	public class RegisteredSaveableInfo
	{
		[field: ReadOnly(false)]
		[field: SerializeField]
		public Saveable Saveable { get; private set; }

		[field: ReadOnly(false)]
		[field: SerializeField]
		public string UniqueId { get; private set; }

		public RegisteredSaveableInfo(Saveable saveable, string uniqueId)
		{
		}
	}
}

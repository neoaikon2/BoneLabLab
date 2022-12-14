using System;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Bonelab
{
	[Serializable]
	public class RegisteredSaveableInfo
	{
		[SerializeField]
		[ReadOnly(false)]
		private Saveable _saveable;

		[SerializeField]
		[ReadOnly(false)]
		private string _uniqueId;

		public Saveable Saveable
		{
			get
			{
				return null;
			}
		}

		public string UniqueId
		{
			get
			{
				return null;
			}
		}

		public RegisteredSaveableInfo(string uniqueId, Saveable saveable)
			: base()
		{
		}
	}
}

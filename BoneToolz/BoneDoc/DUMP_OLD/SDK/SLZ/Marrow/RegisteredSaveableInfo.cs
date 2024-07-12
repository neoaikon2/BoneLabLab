using System;
using System.Runtime.CompilerServices;

namespace SLZ.Marrow
{
	[Serializable]
	public class RegisteredSaveableInfo
	{
		public Saveable Saveable { get; private set; }

		public string UniqueId { get; private set; }

		public RegisteredSaveableInfo(Saveable saveable, string uniqueId)
			: base()
		{
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using SLZ.Marrow.Warehouse;

namespace SLZ.Bonelab.SaveData
{
	[Serializable]
	public struct Replacement
	{
		public SpawnableCrateReference From
		{			
			get;
			private set; }

		public SpawnableCrateReference To
		{
			get;
			private set; }
	}
}

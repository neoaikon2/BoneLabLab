using System.Collections.Generic;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class CrateFilters : MonoBehaviour
	{
		public class UnlockedNotUnlockableAndNotRedactedFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return default(bool);
			}

			public UnlockedNotUnlockableAndNotRedactedFilter()
				: base()
			{
			}
		}

		public class UnlockableNotUnlockedAndNotRedactedFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return default(bool);
			}

			public UnlockableNotUnlockedAndNotRedactedFilter()
				: base()
			{
			}
		}

		public class UnlockableAndNotRedactedCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return default(bool);
			}

			public UnlockableAndNotRedactedCrateFilter()
				: base()
			{
			}
		}

		public class UnlockedAndNotRedactedCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return default(bool);
			}

			public UnlockedAndNotRedactedCrateFilter()
				: base()
			{
			}
		}

		public class UnlockedCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return default(bool);
			}

			public UnlockedCrateFilter()
				: base()
			{
			}
		}

		public class NonAvatarCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return default(bool);
			}

			public NonAvatarCrateFilter()
				: base()
			{
			}
		}

		public class NonRedactedCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return default(bool);
			}

			public NonRedactedCrateFilter()
				: base()
			{
			}
		}

		public class NonUnlockableCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return default(bool);
			}

			public NonUnlockableCrateFilter()
				: base()
			{
			}
		}

		public class RedactedCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return default(bool);
			}

			public RedactedCrateFilter()
				: base()
			{
			}
		}

		public class UnlockableCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return default(bool);
			}

			public UnlockableCrateFilter()
				: base()
			{
			}
		}

		public class BlackListCrateFilter : ICrateFilter<Crate>
		{
			private List<string> blackList;

			public BlackListCrateFilter(List<string> blackList)
				: base()
			{
			}

			public bool Filter(Crate crate)
			{
				return default(bool);
			}
		}

		public class DevToolCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return default(bool);
			}

			public DevToolCrateFilter()
				: base()
			{
			}
		}

		public class FavoritesCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return default(bool);
			}

			public FavoritesCrateFilter()
				: base()
			{
			}
		}

		public class GunCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return default(bool);
			}

			public GunCrateFilter()
				: base()
			{
			}
		}

		public class NPCCrateFilter : ICrateFilter<Crate>
		{
			public bool Filter(Crate crate)
			{
				return default(bool);
			}

			public NPCCrateFilter()
				: base()
			{
			}
		}

		private static PlayerUnlocks u
		{
			get
			{
				return null;
			}
		}

		private static PlayerSettings p
		{
			get
			{
				return null;
			}
		}

		public CrateFilters()
			: base()
		{
		}
	}
}

using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using SLZ.Marrow.Plugins;
using SLZ.Marrow.Warehouse;

namespace SLZ.Marrow.Interaction
{
	[MarrowPlugin("SLZ.Marrow.Interaction", "EntityManager", "0.0.1")]
	public class EntityManager : IMarrowPluginLevelCallbacks, IMarrowPlugin
	{
		private static EntityManager _manager;

		private HashSet<MarrowEntity> _entities;

		private Dictionary<string, List<MarrowEntity>> _tagIDToEntity;

		public static EntityManager Instance
		{
			get
			{
				return null;
			}
		}

		UniTask IMarrowPluginLevelCallbacks.OnBeforeLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}

		public bool TryGetEntitiesWithTag(BoneTag boneTag, [Out] IReadOnlyList<MarrowEntity> entities)
		{
			return default(bool);
		}

		public bool TryGetFirstEntityWithTag(BoneTag boneTag, [Out] MarrowEntity entity)
		{
			return default(bool);
		}

		public void RegisterEntity(MarrowEntity entity)
		{
		}

		public void UnregisterEntity(MarrowEntity entity)
		{
		}

		private void RemoveEntityFromTag(string boneTagID, MarrowEntity entity)
		{
		}

		private void AddEntityToTag(string boneTagID, MarrowEntity entity)
		{
		}

		public EntityManager()
			: base()
		{
		}
	}
}

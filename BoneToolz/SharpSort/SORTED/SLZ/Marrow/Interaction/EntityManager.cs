using System.Collections.Generic;
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

		public static EntityManager Instance => null;

		private UniTask SLZ_002EMarrow_002EPlugins_002EIMarrowPluginLevelCallbacks_002EOnBeforeLevelLoad(LevelCrateReference level)
		{
			return default(UniTask);
		}

		public bool TryGetEntitiesWithTag(BoneTag boneTag, out IReadOnlyList<MarrowEntity> entities)
		{
			entities = null;
			return false;
		}

		public bool TryGetFirstEntityWithTag(BoneTag boneTag, out MarrowEntity entity)
		{
			entity = null;
			return false;
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
	}
}

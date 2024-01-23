using UnityEngine;
using UnityEngine.AI;
using Unity.AI.Navigation;

namespace SLZ.Bonelab
{
	public class NavSurfBakery : MonoBehaviour
	{
		public GameObject[] enableObjs;

		public GameObject[] disableObjs;

		private NavMeshSurface[] navMeshSurfaces;

		[ContextMenu("Bake All Navs")]
		public void BakeAllSurfaces()
		{
		}
	}
}

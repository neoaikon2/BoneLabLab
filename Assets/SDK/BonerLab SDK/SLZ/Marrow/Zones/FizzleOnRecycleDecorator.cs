using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Marrow.Zones
{
	[RequireComponent(typeof(CrateSpawner))]
	public class FizzleOnRecycleDecorator : MonoBehaviour, IRecycleListenable
	{
		[HideInInspector]
		[SerializeField]
		protected CrateSpawner crateSpawner;

		private void Awake()
		{
		}

		public void OnRecycle(GameObject go)
		{
		}

		private void Reset()
		{
		}
	}
}

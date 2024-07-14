using UnityEngine;

namespace SLZ.Marrow.Data
{
	[CreateAssetMenu(fileName = "New Bullet Value", menuName = "Variables/Bullet Item", order = 3)]
	public class CartridgeData : ScriptableObject
	{
		private string _name;

		public ProjectileData projectile;

		[Header("Dependencies")]
		public Spawnable cartridgeSpawnable;

		public Spawnable cartridgeCaseSpawnable;

		public string Name => null;

		private void Awake()
		{
		}
	}
}

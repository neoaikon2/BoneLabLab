using SLZ.VFX;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class DestructibleDamageForwarder : MonoBehaviour
	{
		public ObjectDestructible[] destructables;

		public float attackDamage;

		public void BREAKEVENT()
		{
		}

		public DestructibleDamageForwarder()
			: base()
		{
		}
	}
}

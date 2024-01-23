using SLZ.Marrow.Utilities;
using SLZ.SFX;
using UnityEngine;

namespace SLZ.Props
{
	public class SpawnFragment : MonoBehaviour
	{
		private static ComponentCache<SpawnFragment> _cache;

		[SerializeField]
		private Renderer[] matRenderer;

		public Rigidbody[] rigidbodies;

		public ImpactSFX[] sfx;

		private Rigidbody _activeFragment;

		private Renderer _activeRenderer;

		public static ComponentCache<SpawnFragment> Cache => null;

		public void SetRigidbody(int idx, Vector3? velocity = null, Vector3? angularVelocity = null, float? mass = null, Vector3? worldCenter = null, float? explosiveForce = null)
		{
		}

		public void SetTransform(int idx, Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		public void SetMaterial(int idx, Material newMaterial)
		{
		}

		public void EnableSound(int idx, float pitchMultiplier = 1f)
		{
		}

		public void Awake()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDestroy()
		{
		}
	}
}

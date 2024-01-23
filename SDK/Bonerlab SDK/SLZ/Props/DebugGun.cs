using SLZ.Interaction;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Warehouse;
using TMPro;
using UnityEngine;

namespace SLZ.Props
{
	public class DebugGun : MonoBehaviour
	{
		public TargetGrip triggerGrip;

		public Transform firePoint;

		public float range;

		public LayerMask collisionLayers;

		public TextMeshPro mainUIPanel;

		public GameObject laserPointer;

		private RaycastHit hitInfo;

		private Rigidbody hitRb;

		private InteractableHost hitHost;

		private AssetPoolee hitPoolee;

		private Crate hitCrate;

		private LODGroup hitLODGroup;

		private LOD[] lods;

		private int lodIndex;

		private int lodCur;

		private int rendererCount;

		private int materialCount;

		private int impactPropCount;

		private bool impactPropMisconfig;

		private int colliderCount;

		private bool missingPhysicsMaterial;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnHandAttached(Hand hand)
		{
		}

		private void OnHandDetached(Hand hand)
		{
		}

		private void OnHandAttachedUpdate(Hand hand)
		{
		}

		private void UpdateUI()
		{
		}
	}
}

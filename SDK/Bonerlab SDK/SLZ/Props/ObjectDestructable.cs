using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLZ.Combat;
using SLZ.Marrow.Data;
using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using SLZ.SFX;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Serialization;

namespace SLZ.Props
{
	public class ObjectDestructable : SpawnEvents, IAttackReceiver, IEventSystemHandler
	{
		private static ComponentCache<ObjectDestructable> _cache;

		public LootTableData lootTable;

		public DestructableLootSpawnEvent OnLootSpawn;

		public Transform spawnTarget;

		public float minVelocityDeltaSqr;

		public bool damageFromImpact;

		public SpawnFragmentArray[] spawnFragments;

		public GameObject[] CustomFragmentObjects;

		[Tooltip("Prop's maximum health")]
		[Space(10f)]
		[Header("HEALTH")]
		public float maxHealth;

		[Tooltip("Required hits to break, 1 = default")]
		public int reqHitCount;

		[Range(0f, 1f)]
		[Tooltip("0-1 as percent for when bloodied effects 0 = no effect")]
		public float perBloodied;

		public float explosiveForceOnDestruct;

		[Header("ATTACKED")]
		[Space(10f)]
		[Tooltip("Can be damaged by attacks")]
		public bool damageFromAttack;

		[Tooltip("Modifier multiplier to attack damage")]
		public float attackMod;

		[Tooltip("Attack type high damage")]
		[EnumFlags]
		public AttackType attackType;

		[Tooltip("Modifier multiplier to attack type")]
		public float modTypeDamage;

		[Space(10f)]
		[Header("CRITICAL HIT")]
		[Tooltip("Colliders for critical hits")]
		public Collider[] colCrit;

		[Tooltip("Critical hit modifier percent")]
		public float modCrit;

		[Tooltip("Modifier multiplier to collision")]
		public float modImpact;

		[Tooltip("Threshold of impact magnitude required to damage")]
		[FormerlySerializedAs("thrNewtons")]
		public float thrImpact;

		public float feetDamageMult;

		[SerializeField]
		private ImpactSFX _impactSfx;

		private bool _isDead;

		private Rigidbody _rb;

		private int _hits;

		private int _feetLayer;

		private bool _bloodied;

		private float _health;

		private float _thrImpCache;

		private List<int> _fragmentIndexBuffer;

		private int[] _randomFragmentIndices;

		public Action<ObjectDestructable> OnDestruction;

		public UnityEvent OnDestruct;

		[Space(10f)]
		[Header("DEPENDENCIES")]
		[SerializeField]
		private Spawnable blasterDustSpawnable;

		[SerializeField]
		private Vector3 blasterScale;

		[SerializeField]
		private Vector3 BlasterPosition;

		[SerializeField]
		private Color BlasterTint;

		[SerializeField]
		private Spawnable impactSmokerSpawnable;

		[SerializeField]
		private Spawnable breakEffectSpawnable;

		public static ComponentCache<ObjectDestructable> Cache => null;

		public static event Action<ObjectDestructable> OnStatDestruction
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected void Awake()
		{
		}

		private void Reset()
		{
		}

		private void OnCollisionEnter(Collision c)
		{
		}

		private void OnDestroy()
		{
		}

		protected override void OnSpawn(GameObject go)
		{
		}

		private void OnSignificantCollision(Collision c, float impactionVelocity)
		{
		}

		public void DestroyNoDebris()
		{
		}

		public void SendDamage(float damage)
		{
		}

		private void TakeDamage(Vector3 normal, float damage, bool crit = false, AttackType attackType = AttackType.None)
		{
		}

		public void ReceiveAttack(Attack attack)
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}

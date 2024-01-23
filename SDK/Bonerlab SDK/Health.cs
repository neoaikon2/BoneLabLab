using SLZ.Combat;
using SLZ.Marrow.Data;
using SLZ.Rig;
using SLZ.SFX;
using SLZ.VRMK;
using UnityEngine;

public class Health : MonoBehaviour
{
	public enum HealthMode
	{
		Invincible = 0,
		Mortal = 1,
		InsantDeath = 2
	}

	protected RigManager _rigManager;

	protected HeadSFX _headSfx;

	public HealthMode healthMode;

	protected HealthMode prevHealthMode;

	[Space(10f)]
	[Header("HEALTH")]
	[Tooltip("Enemy maximum health")]
	public float max_Health;

	[SerializeField]
	public float curr_Health;

	[Tooltip("Required hits to kill, 1 = default")]
	public int req_hit_count;

	[HideInInspector]
	public int hits;

	[Header("ATTACKED")]
	[Space(10f)]
	[Tooltip("Can be damaged by attacks")]
	public bool damageFromAttack;

	[Tooltip("Modifier multiplier to attack damage")]
	public float mod_Attack;

	[Tooltip("Can this use an attackType to adjust damage")]
	public bool useType;

	[Tooltip("Attack type high damage")]
	public AttackType mod_Type;

	[Tooltip("Modifier multiplier to attack type")]
	public float mod_TypeDamage;

	[HideInInspector]
	public bool alive;

	[SerializeField]
	protected bool _testRagdollOnDeath;

	protected virtual void Awake()
	{
	}

	public virtual void OnReceivedDamage(Attack attack, PlayerDamageReceiver.BodyPart part)
	{
	}

	public virtual void TAKEDAMAGE(float damage)
	{
	}

	public virtual void SetAvatar(SLZ.VRMK.Avatar avatar)
	{
	}

	public void SetHealthMode(int newHealthMode)
	{
	}
}

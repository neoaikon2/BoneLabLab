using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SLZ.Combat;
using UnityEngine;

namespace PuppetMasta
{
	[Serializable]
	public class SubBehaviourHealth : SubBehaviourBase
	{
		public enum StunGroup
		{
			Spine = 0,
			ArmLf = 1,
			ArmRt = 2,
			LegLf = 3,
			LegRt = 4,
			Head = 5
		}

		public delegate void NPCDamageRecieved(float damageAmount);

		[Serializable]
		public struct UsageSettings
		{
			public float hips;

			public float spine;

			public float legLf;

			public float legRt;

			public float armLf;

			public float armRt;

			public static UsageSettings Default
			{
				get
				{
					return default(UsageSettings);
				}
			}

			public UsageSettings(float hips = 1f, float spine = 1f, float legLf = 1f, float legRt = 1f, float armLf = 1f, float armRt = 1f)
			{
				this.armRt = default(float);
				this.armLf = default(float);
				this.legRt = default(float);
				this.legLf = default(float);
				this.spine = default(float);
				this.hips = default(float);
			}
		}

		[Header("Health")]
		public float maxHitPoints = 1.0f;

		public float maxAppendageHp = 1.0f;

		public float stunRecovery = 1.0f;

		public float maxStunSeconds = 2.0f;

        public float minHeadImpact = 10.0f;

		public float minSpineImpact = 10.0f;

		public float minLimbImpact = 10.0f;

		public bool isOrganic;

		public bool stunActive;

		public float bluntMult = 1.0f;

		public float stabMult = 1.0f;

        public float pierceMult = 1.0f;

        [Tooltip("These should be set to kinda match what is in PuppetMasta")]
		public StunGroup[] muscles;

		[Range(0f, 1f)]
		public float cur_hp = 1.0f;

		[Range(0f, 1f)]
		public float cur_arm_lf = 1.0f;

        [Range(0f, 1f)]
		public float cur_arm_rt = 1.0f;

        [Range(0f, 1f)]
		public float cur_leg_lf = 1.0f;

        [Range(0f, 1f)]
		public float cur_leg_rt = 1.0f;

        public float stun_spine = 1.0f;

        public float stun_arm_lf = 1.0f;

        public float stun_arm_rt = 1.0f;

        public float stun_leg_lf = 1.0f;

        public float stun_leg_rt = 1.0f;

        public float usage_hips = 1.0f;

        public float usage_spine = 1.0f;

        public float usage_arm_lf = 1.0f;

        public float usage_arm_rt = 1.0f;

        public float usage_leg_lf = 1.0f;

        public float usage_leg_rt = 1.0f;

        [Tooltip("Current state of agro, will move up and down based on damage received / dealt")]
		[Range(0f, 1f)]
		[Header("Disposition")]
		public float aggression = 0.0f;

		[Range(0f, 10f)]
		[Tooltip("Nonfunctioning")]
		public float irritability = 1.0f;

		[Tooltip("Multiplier, Decreases aggression based on damage dealt")]
		[Range(0f, 10f)]
		public float placability = 1.0f;

		[Tooltip("Multiplier, Increases aggression based on damage received")]
		[Range(0f, 10f)]
		public float vengefulness = 1.0f;

		[HideInInspector]
		public int damageScore;

		public static Action OnHeadShot;

		public void Initiate(BehaviourBase b)
		{
		}

		public void Resurrect()
		{
		}

		public void Kill()
		{
		}

		public void SetUsage(float hips, float spine = 1f, float legLf = 1f, float legRt = 1f, float armLf = 1f, float armRt = 1f)
		{
		}

		public void SetUsage(UsageSettings s)
		{
		}

		public void UpdateMuscleStates(float footSupported)
		{
		}

		public float Stun(int m, float stun)
		{
			return default(float);
		}

		public float TakeDamage(int m, Attack attack)
		{
			return default(float);
		}

		private void DamageScore(int m, float damage)
		{
		}

		public bool UpdateStun()
		{
			return default(bool);
		}

		public float GetStun(int m, [Out] float health)
		{
			return default(float);
		}

		public SubBehaviourHealth()
			: base()
		{
		}

		public static event NPCDamageRecieved OnNPCDamage;
	}
}

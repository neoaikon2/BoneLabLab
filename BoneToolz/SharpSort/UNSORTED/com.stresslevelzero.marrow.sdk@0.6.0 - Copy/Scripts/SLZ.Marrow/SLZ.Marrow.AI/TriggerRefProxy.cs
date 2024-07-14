using System;
using UnityEngine;

namespace SLZ.Marrow.AI
{
	public class TriggerRefProxy : MonoBehaviour
	{
		public enum TriggerType
		{
			Player = 0,
			Proxy = 1,
			Npc = 2
		}

		[Flags]
		public enum NpcType
		{
			FordHair = 1,
			FordShortHair = 2,
			EarlyExit = 4,
			NullBody = 8,
			Fordlet = 0x10,
			Crablet = 0x20,
			OmniProjector = 0x40,
			OmniWrecker = 0x80,
			OmniTurret = 0x100,
			Turret = 0x200,
			NullRat = 0x400,
			Voidman = 0x800
		}

		private AIBrain _aiManager;

		public TriggerType triggerType;

		public NpcType npcType;

		public int teamNumber;

		public GameObject root;

		public Rigidbody targetHead;

		public Rigidbody lfHandRb;

		public Rigidbody rtHandRb;

		public Transform chestTran;

		public Transform feetTran;

		public Transform legacyProxy;

		public AIBrain aiManager => null;

		public void Start()
		{
		}
	}
}

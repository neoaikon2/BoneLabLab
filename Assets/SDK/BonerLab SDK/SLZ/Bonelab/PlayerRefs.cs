using System;
using SLZ.Marrow;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class PlayerRefs : MonoBehaviour
	{
		public Action OnRefsComplete;

		[SerializeField]
		public GameObject[] _enableWhenReadyObjects;

		[SerializeField]
		private BodyVitals _bodyVitals;

		[SerializeField]
		private PlayerAvatarManager _avatarManager;

		public static PlayerRefs Instance { get; private set; }

		public bool HasRefs { get; private set; }

		public RigManager PlayerRigManager { get; private set; }

		public InventoryAmmoReceiver PlayerInvAmmoReceiver { get; private set; }

		public PhysicsRig PlayerPhysicsRig { get; private set; }

		public OpenControllerRig OpenControllerRig { get; private set; }

		public BodyVitals PlayerBodyVitals => null;

		public PlayerAvatarManager playerAvatarManager => null;

		private void Awake()
		{
		}

		private void OnPersistentLoad()
		{
		}
	}
}

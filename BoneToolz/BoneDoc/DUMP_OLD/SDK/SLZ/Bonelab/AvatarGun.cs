using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Audio;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class AvatarGun : MonoBehaviour
	{
		public Grip triggerGrip;

		public Transform firePoint;

		public GameObject selectorKnob;

		public LayerMask playerLayerMask;

		[Header("Avatars")]
		public AvatarCrateReference[] avatarCrates;

		private AvatarCrateReference initialAvatar;

		private AvatarCrateReference lastAvatar;

		private int avatarIndex;

		[SerializeField]
		[Header("VFX")]
		private Spawnable vfxBlasterSpawnable;

		[SerializeField]
		private Spawnable avatarBlaster;

		public GameObject laser;

		[Header("Audio")]
		public AudioClip[] fireSFX;

		public AudioClip[] misfireSFX;

		public AudioClip[] modeSFX;

		private ManagedAudioPlayer _map;

		private int choice;

		private RigManager rigManager;

		public LayerMask collisionLayers;

		public float effectiveRange;

		private List<string> defaultFavoriteAvatarsBarcodes;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnTriggerGripAttached(Hand hand)
		{
		}

		private void OnTriggerGripDetached(Hand hand)
		{
		}

		private void OnTriggerGripUpdate(Hand hand)
		{
		}

		private UniTaskVoid LoadFavoriteAvatars()
		{
			return default(UniTaskVoid);
		}

		private UniTaskVoid SwapAvatar(AvatarCrateReference avatarCrate, RigManager targetRig)
		{
			return default(UniTaskVoid);
		}

		private void PlayParticles(SkinnedMeshRenderer[] meshs)
		{
		}

		private float GetVolumeSurface(Vector3 size)
		{
			return default(float);
		}

		public AvatarGun()
			: base()
		{
		}
	}
}

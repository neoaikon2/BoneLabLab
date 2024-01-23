using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Interaction;
using SLZ.Marrow.Data;
using SLZ.Marrow.Warehouse;
using SLZ.Rig;
using SLZ.Utilities;
using UnityEngine;
using UnityEngine.Audio;

namespace SLZ.Props
{
	public class AvatarGun : MonoBehaviour
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CLoadFavoriteAvatars_003Ed__26
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public AvatarGun _003C_003E4__this;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSwapAvatar_003Ed__27
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public RigManager targetRig;

			public AvatarCrateReference avatarCrate;

			public AvatarGun _003C_003E4__this;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private RigManager rigManager;

		public Grip triggerGrip;

		public Transform firePoint;

		public GameObject selectorKnob;

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
		public AudioMixerGroup outputMixer;

		public AudioClip[] fireSFX;

		public AudioClip[] misfireSFX;

		public AudioClip[] modeSFX;

		private AudioPlayer ap;

		private int choice;

		public LayerMask collisionLayers;

		public float effectiveRange;

		private List<string> defaultFavoriteAvatarsBarcodes;

		private void Awake()
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

		[AsyncStateMachine(typeof(_003CLoadFavoriteAvatars_003Ed__26))]
		private UniTaskVoid LoadFavoriteAvatars()
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CSwapAvatar_003Ed__27))]
		private UniTaskVoid SwapAvatar(AvatarCrateReference avatarCrate, RigManager targetRig)
		{
			return default(UniTaskVoid);
		}

		private void PlayParticles(SkinnedMeshRenderer[] meshs)
		{
		}

		private void PlaySFX(AudioClip[] audioClips, Vector3 position)
		{
		}

		private float GetVolumeSurface(Vector3 size)
		{
			return 0f;
		}
	}
}

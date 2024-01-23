using SLZ.Interaction;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Props
{
	public class MagazineReciever : InteractionReciever
	{
		[Range(0f, 10f)]
		public float priority;

		private static ComponentCache<MagazineReciever> _cache;

		[Header("References")]
		public AudioClip[] grabClips;

		public static ComponentCache<MagazineReciever> Cache => null;

		protected override void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public override void OnInteractableHostDrop(InteractableHost host)
		{
		}
	}
}

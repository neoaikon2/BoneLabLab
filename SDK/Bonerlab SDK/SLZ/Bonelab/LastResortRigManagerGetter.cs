using System;
using SLZ.AI;
using SLZ.Rig;
using UnityEngine;

namespace SLZ.Bonelab
{
	[Obsolete("You had better know what you're doing, using this component!")]
	public class LastResortRigManagerGetter : MonoBehaviour
	{
		[field: SerializeField]
		public RigManager RigManager { get; private set; }

		public void ClearRigManager(bool areYouSure)
		{
		}

		public void ClearRigManagerAndImmediatelyTryToGetItAgain(bool areYouSure)
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		internal static bool TryGetTriggerRefProxy_HACKY(out TriggerRefProxy triggerRefProxy)
		{
			triggerRefProxy = null;
			return false;
		}

		internal static bool TryGetRigManager_HACKY(out RigManager rigManager)
		{
			rigManager = null;
			return false;
		}

		private void SearchDesperatelyForRigManager()
		{
		}
	}
}

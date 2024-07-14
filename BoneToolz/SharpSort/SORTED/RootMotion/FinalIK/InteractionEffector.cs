using System;
using System.Collections.Generic;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Serializable]
	public class InteractionEffector
	{
		private Poser poser;

		private IKEffector effector;

		private float timer;

		private float length;

		private float weight;

		private float fadeInSpeed;

		private float defaultPositionWeight;

		private float defaultRotationWeight;

		private float defaultPull;

		private float defaultReach;

		private float defaultPush;

		private float defaultPushParent;

		private float resetTimer;

		private bool positionWeightUsed;

		private bool rotationWeightUsed;

		private bool pullUsed;

		private bool reachUsed;

		private bool pushUsed;

		private bool pushParentUsed;

		private bool pickedUp;

		private bool defaults;

		private bool pickUpOnPostFBBIK;

		private Vector3 pickUpPosition;

		private Vector3 pausePositionRelative;

		private Quaternion pickUpRotation;

		private Quaternion pauseRotationRelative;

		private InteractionTarget interactionTarget;

		private Transform target;

		private List<bool> triggered;

		private InteractionSystem interactionSystem;

		private bool started;

		public FullBodyBipedEffector effectorType { get; private set; }

		public bool isPaused { get; private set; }

		public InteractionObject interactionObject { get; private set; }

		public bool inInteraction => false;

		public float progress => 0f;

		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		private void StoreDefaults()
		{
		}

		public bool ResetToDefaults(float speed)
		{
			return false;
		}

		public bool Pause()
		{
			return false;
		}

		public bool Resume()
		{
			return false;
		}

		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return false;
		}

		public void Update(Transform root, float speed)
		{
		}

		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
			pickUp = default(bool);
			pause = default(bool);
		}

		private void PickUp(Transform root)
		{
		}

		public bool Stop()
		{
			return false;
		}

		public void OnPostFBBIK()
		{
		}
	}
}

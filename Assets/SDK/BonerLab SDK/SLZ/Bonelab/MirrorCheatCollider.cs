using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class MirrorCheatCollider : MonoBehaviour
	{
		public GameObject avatarRoot;

		public GameObject reflectionCollider;

		private List<GameObject> avatars;

		private bool doReflectionTrack;

		private IEnumerator reflectionTrackCoroutine;

		private static readonly WaitForSeconds waitPointOneSeconds;

		public void Start()
		{
		}

		public void StartReflectionTrack()
		{
		}

		public void StopReflectionTrack()
		{
		}
		private IEnumerator ReflectionCoroutine()
		{
			return null;
		}
	}
}

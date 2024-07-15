using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SLZ.Marrow.Interaction;
using UnityEngine;

namespace SLZ.Bonelab
{
	[Obsolete("Uses obsolete zone components")]
	public class HeadTitlesTrigger : MonoBehaviour
	{
		public AudioClip clipToPlay;

		public string string_Title;

		public string string_SubTitle;

		public Sprite spriteToDisplay;

		public float bufferTime;

		[Tooltip("delay in seconds till headtitle starts")]
		public float startDelay;

		[Header("LEVEL TRIGGER")]
		public bool isLevel;

		public Sprite[] levelSprites;

		[Header("AVATAR LEVEL TRIGGER")]
		public bool isAvatarLevel;

		public Sprite spriteA;

		public Sprite spriteB;

		public Sprite spriteC;

		public Sprite spriteD;

		private float timeToSend;

		private string currentTag;

		public void DelayedSENDTITLES(MarrowEntity entity)
		{
		}
		private UniTaskVoid DelayedSENDTITLES_async(MarrowEntity entity)
		{
			return default(UniTaskVoid);
		}

		public void SENDTITLES(MarrowEntity entity)
		{
		}
	}
}

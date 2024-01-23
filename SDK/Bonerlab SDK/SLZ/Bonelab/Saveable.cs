using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Bonelab
{
	public class Saveable : MonoBehaviour
	{
		[field: SerializeField]
		[field: HideInInspector]
		public string BakedObjectPath { get; private set; }

		[field: SerializeField]
		[field: HideInInspector]
		public string HashAlgorithm { get; private set; }

		[field: SerializeField]
		[field: ReadOnly(false)]
		public string UniqueId { get; private set; }

		[field: SerializeField]
		[field: ReadOnly(false)]
		public string LastBaked { get; private set; }

		[field: SerializeField]
		public string Data { get; set; }

		public void CopyFrom(Saveable other)
		{
		}

		public void Unbake(bool thisIsRiskyAndIKnowWhatImDoing = false)
		{
		}
	}
}

using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class Keycard : MonoBehaviour
	{
		private static ComponentCache<Keycard> _cache;

		[EnumFlags]
		public KeycardReciever.Code code;

		public static ComponentCache<Keycard> Cache => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}
	}
}

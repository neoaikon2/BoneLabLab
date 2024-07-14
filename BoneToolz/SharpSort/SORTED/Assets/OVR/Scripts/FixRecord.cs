using UnityEngine;

namespace Assets.OVR.Scripts
{
	public class FixRecord : Record
	{
		public FixMethodDelegate fixMethod;

		public Object targetObject;

		public string[] buttonNames;

		public bool editModeRequired;

		public bool complete;

		public FixRecord(int order, string cat, string msg, FixMethodDelegate fix, Object target, bool editRequired, string[] buttons)
			: base(0, null, null)
		{
		}
	}
}

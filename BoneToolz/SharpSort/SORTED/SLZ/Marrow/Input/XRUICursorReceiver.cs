using SLZ.Marrow.Pool;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.UI;

namespace SLZ.Marrow.Input
{
	public class XRUICursorReceiver : MonoBehaviour
	{
		[SerializeField]
		private XRUIInputModule _InputModule;

		[SerializeField]
		private Poolee _poolee;

		private static XRUICursorReceiver _instance;

		private void Awake()
		{
		}

		public static XRUIInputModule Register(IUIInteractor uiInteractor)
		{
			return null;
		}

		public static void UnRegister(IUIInteractor uiInteractor)
		{
		}
	}
}

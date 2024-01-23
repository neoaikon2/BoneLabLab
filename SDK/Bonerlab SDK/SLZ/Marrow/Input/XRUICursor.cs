using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.UI;

namespace SLZ.Marrow.Input
{
	public class XRUICursor : MonoBehaviour, IUIInteractor
	{
		[SerializeField]
		private float _maxRaycastDistance;

		[SerializeField]
		private bool _isLeft;

		[SerializeField]
		private LayerMask _raycastMask;

		private XRUIInputModule _InputModule;

		private XRUIInputModule _RegisteredInputModule;

		private static TrackedDeviceModel _invalidTrackedDeviceModel { get; }

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		private void FindOrCreateXRUIInputModule()
		{
		}

		private void RegisterWithXRUIInputModule()
		{
		}

		private void UnregisterFromXRUIInputModule()
		{
		}

		public virtual void UpdateUIModel(TrackedDeviceModel model)
		{
		}

		public bool TryGetUIModel([Out] TrackedDeviceModel model)
		{
			return default(bool);
		}

		public void UpdateUIModel(ref TrackedDeviceModel model)
		{
			throw new System.NotImplementedException();
		}

		public bool TryGetUIModel(out TrackedDeviceModel model)
		{
			throw new System.NotImplementedException();
		}

		public XRUICursor()
			: base()
		{
		}
	}
}

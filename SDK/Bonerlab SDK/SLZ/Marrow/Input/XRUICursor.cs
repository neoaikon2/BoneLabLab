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
		private LayerMask _raycastMask;

		private bool _isClicked;

		private XRUIInputModule _inputModule;

		private static TrackedDeviceModel _invalidTrackedDeviceModel { get; }

		public Vector3 HitPoint { get; private set; }

		public bool IsHit { get; private set; }

		protected void OnEnable()
		{
		}

		protected void OnDisable()
		{
		}

		public virtual void UpdateUIModel(TrackedDeviceModel model)
		{
		}

		public bool TryGetUIModel([Out] TrackedDeviceModel model)
		{
			return default(bool);
		}

		public void Click(bool isClicked)
		{
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

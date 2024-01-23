using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	public class BoxGripProxy : GripProxy
	{
		[Header("Required Settings")]
		[SerializeField]
		[InspectorDisplayName("BoxCollider")]
		private BoxCollider _proxyBoxCollider;

		public BoxCollider BoxCollider
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void SetupProperties()
		{
		}

		public BoxGripProxy()
			: base()
		{
		}
	}
}

using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	public class BarrelGripProxy : GripProxy
	{
		[SerializeField]
		[Header("Required Settings")]
		[InspectorDisplayName("CapsuleCollider")]
		private CapsuleCollider _proxyCapsuleCollider;

		public CapsuleCollider CapsuleCollider
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

		public BarrelGripProxy()
			: base()
		{
		}
	}
}

using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	public class SphereGripProxy : GripProxy
	{
		[Header("Required Settings")]
		[SerializeField]
		[InspectorDisplayName("SphereCollider")]
		private SphereCollider _proxySphereCollider;

		public SphereCollider SphereCollider
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

		public SphereGripProxy()
			: base()
		{
		}
	}
}

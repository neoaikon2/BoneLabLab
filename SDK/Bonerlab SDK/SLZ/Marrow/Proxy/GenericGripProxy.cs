using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	public class GenericGripProxy : GripProxy
	{
		[Header("Required Settings")]
		[SerializeField]
		[InspectorDisplayName("MeshCollider")]
		private MeshCollider _proxyMeshCollider;

		public MeshCollider MeshCollider
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

		public GenericGripProxy()
			: base()
		{
		}
	}
}

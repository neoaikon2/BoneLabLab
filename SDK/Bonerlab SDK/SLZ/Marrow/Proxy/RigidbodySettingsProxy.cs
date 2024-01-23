using System.Runtime.CompilerServices;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Marrow.Proxy
{
	public class RigidbodySettingsProxy : BoneProxy
	{
		[SerializeField]
		[InspectorDisplayName("Center Of Mass")]
		private Transform _proxyCenterOfMass;

		public Transform CenterOfMass
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

		public RigidbodySettingsProxy()
			: base()
		{
		}
	}
}

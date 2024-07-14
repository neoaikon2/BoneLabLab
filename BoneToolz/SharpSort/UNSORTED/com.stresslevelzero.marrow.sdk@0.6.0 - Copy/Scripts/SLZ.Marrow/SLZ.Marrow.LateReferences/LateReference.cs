using System;
using SLZ.Marrow.Utilities;
using UltEvents;
using UnityEngine;

namespace SLZ.Marrow.LateReferences
{
	public abstract class LateReference : ISerializationCallbackReceiver
	{
		[field: SerializeField]
		[field: ReadOnly(false)]
		public string StaticType { get; private protected set; }

		[field: ReadOnly(false)]
		[field: SerializeField]
		public string DynamicType { get; private protected set; }

		[field: ReadOnly(false)]
		[field: SerializeField]
		public string UniqueId { get; protected internal set; }

		public bool ReferenceLinked { get; private protected set; }

		public abstract UnityEngine.Object InternalObject { get; set; }

		public abstract void OnBeforeSerialize();

		public abstract void OnAfterDeserialize();

		public abstract void LateReferenceDidLink(ExportTable exportTable, UnityEngine.Object obj);

		public abstract Type GetStaticType();
	}
	[Serializable]
	public class LateReference<T> : LateReference where T : UnityEngine.Object
	{
		[field: SerializeField]
		public T Object { get; set; }

		[field: SerializeField]
		public UltEvent<ExportTable, LateReference> OnLateReferenceLinked { get; protected internal set; }

		[Obsolete("For internal use. Use Object instead")]
		public override UnityEngine.Object InternalObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void OnBeforeSerialize()
		{
		}

		public override void OnAfterDeserialize()
		{
		}

		public override void LateReferenceDidLink(ExportTable exportTable, UnityEngine.Object obj)
		{
		}

		public override Type GetStaticType()
		{
			return null;
		}
	}
}

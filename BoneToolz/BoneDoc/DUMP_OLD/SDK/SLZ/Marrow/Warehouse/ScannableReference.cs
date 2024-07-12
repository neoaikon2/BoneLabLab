using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SLZ.Marrow.Warehouse
{
	[Serializable]
	public abstract class ScannableReference
	{
		[SerializeField]
		protected Barcode _barcode;

		public Barcode Barcode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual Type ScannableType
		{
			get
			{
				return null;
			}
		}

		public Scannable Scannable
		{
			get
			{
				return null;
			}
		}

		public ScannableReference()
			: base()
		{
		}

		public ScannableReference(string barcode)
			: this()
		{
		}

		public bool TryGetScannable([Out] Scannable scannable)
		{
			return default(bool);
		}

		public bool IsValid()
		{
			return default(bool);
		}

		public static bool IsValid(ScannableReference scannableReference)
		{
			return default(bool);
		}
	}
	[Serializable]
	public class ScannableReference<T> : ScannableReference where T : Scannable
	{
		public override Type ScannableType
		{
			get
			{
				return null;
			}
		}

		public new T Scannable
		{
			get
			{
				return null;
			}
		}

		public ScannableReference()
			: base()
		{
		}

		public ScannableReference(string barcode)
			: this()
		{
		}

		public bool TryGetScannable([Out] T scannable)
		{
			return default(bool);
		}
	}
}

using System;
using UnityEngine;

namespace SLZ.Algorithms.Unity
{
	public sealed class InterfaceAttribute : PropertyAttribute
	{
		public readonly Type InterfaceType;

		public readonly bool ShowName;

		public InterfaceAttribute(Type type, bool showName = false)
		{
		}
	}
}

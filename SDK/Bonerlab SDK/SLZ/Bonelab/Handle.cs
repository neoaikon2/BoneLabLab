using UnityEngine;

namespace SLZ.Bonelab
{
	public abstract class Handle<T> : MonoBehaviour where T : MonoBehaviour
	{
		protected T value;
	}
}

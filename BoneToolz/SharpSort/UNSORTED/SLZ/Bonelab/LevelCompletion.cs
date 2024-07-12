using UnityEngine;

namespace SLZ.Bonelab
{
	public class LevelCompletion : MonoBehaviour
	{
		[field: SerializeField]
		protected virtual string LevelKey { get; }

		public virtual void SaveWrite()
		{
		}
	}
}

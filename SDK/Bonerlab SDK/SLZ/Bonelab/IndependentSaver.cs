using UnityEngine;

namespace SLZ.Bonelab
{
	public class IndependentSaver : MonoBehaviour
	{
		[field: SerializeField]
		public string LevelKey { get; set; }

		[field: SerializeField]
		public Saveable Saveable { get; set; }

		public void UpdateSave()
		{
		}
	}
}

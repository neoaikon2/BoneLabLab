using UnityEngine;

namespace SLZ.Bonelab
{
	public class Cable_Spawner : MonoBehaviour
	{
		[Space(5f)]
		[Header("CABLE LIFT REF")]
		[ContextMenuItem("Generate Cable", "Generate")]
		public CabletSeUp[] cableSetup;

		[Space(5f)]
		public bool isBinary;

		private float colOffset;

		public void Generate()
		{
		}
	}
}

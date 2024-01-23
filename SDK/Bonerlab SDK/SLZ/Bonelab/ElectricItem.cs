using UnityEngine;

namespace SLZ.Bonelab
{
	[CreateAssetMenu(fileName = "Electronic", menuName = "Variables/Electronic", order = 5)]
	public class ElectricItem : ScriptableObject
	{
		[Space(5f)]
		[Header("UI")]
		public Material Icon;
	}
}

using System.Collections.Generic;

namespace UnityEngine.AI
{
	[HelpURL("https://github.com/Unity-Technologies/NavMeshComponents#documentation-draft")]
	[AddComponentMenu("Navigation/NavMeshModifier", 32)]
	[ExecuteInEditMode]
	public class NavMeshModifier : MonoBehaviour
	{
		[SerializeField]
		private bool m_OverrideArea;

		[SerializeField]
		private int m_Area;

		[SerializeField]
		private bool m_IgnoreFromBuild;

		[SerializeField]
		private List<int> m_AffectedAgents;

		private static readonly List<NavMeshModifier> s_NavMeshModifiers;

		public bool overrideArea
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int area
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool ignoreFromBuild
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static List<NavMeshModifier> activeModifiers => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public bool AffectsAgentType(int agentTypeID)
		{
			return false;
		}
	}
}

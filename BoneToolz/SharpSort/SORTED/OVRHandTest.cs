using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class OVRHandTest : MonoBehaviour
{
	public class BoolMonitor
	{
		public delegate bool BoolGenerator();

		private string m_name;

		private BoolGenerator m_generator;

		private bool m_prevValue;

		private bool m_currentValue;

		private bool m_currentValueRecentlyChanged;

		private float m_displayTimeout;

		private float m_displayTimer;

		public BoolMonitor(string name, BoolGenerator generator, float displayTimeout = 0.5f)
		{
		}

		public void Update()
		{
		}

		public void AppendToStringBuilder(ref StringBuilder sb)
		{
		}
	}

	public Text uiText;

	private List<BoolMonitor> monitors;

	private StringBuilder data;

	private OVRPlugin.HandState hs_LH;

	private OVRPlugin.HandState hs_RH;

	private OVRPlugin.Skeleton skel_LH;

	private OVRPlugin.Skeleton skel_RH;

	private OVRPlugin.Mesh mesh_LH;

	private OVRPlugin.Mesh mesh_RH;

	private bool result_skel_LH;

	private bool result_skel_RH;

	private bool result_mesh_LH;

	private bool result_mesh_RH;

	private static string prevConnected;

	private static BoolMonitor controllers;

	private void Start()
	{
	}

	private void Update()
	{
	}
}

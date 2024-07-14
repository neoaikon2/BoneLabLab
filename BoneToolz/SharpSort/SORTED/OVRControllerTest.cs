using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class OVRControllerTest : MonoBehaviour
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

	private static string prevConnected;

	private static BoolMonitor controllers;

	private void Start()
	{
	}

	private void Update()
	{
	}
}

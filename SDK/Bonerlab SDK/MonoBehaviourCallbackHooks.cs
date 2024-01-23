using System;
using UnityEngine.ResourceManagement.Util;

internal class MonoBehaviourCallbackHooks : ComponentSingleton<MonoBehaviourCallbackHooks>
{
	internal Action<float> m_OnUpdateDelegate;

	public event Action<float> OnUpdateDelegate
	{
		add
		{
		}
		remove
		{
		}
	}

	protected override string GetGameObjectName()
	{
		return null;
	}

	internal void Update()
	{
	}

	public MonoBehaviourCallbackHooks()
		: base()
	{
	}
}

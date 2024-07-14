using System;
using UnityEngine.ResourceManagement.Util;

internal class MonoBehaviourCallbackHooks : ComponentSingleton<MonoBehaviourCallbackHooks>
{
	internal Action<float> m_OnUpdateDelegate;

	internal Action<float> m_OnLateUpdateDelegate;

	public event Action<float> OnUpdateDelegate
	{
		add
		{
		}
		remove
		{
		}
	}

	internal event Action<float> OnLateUpdateDelegate
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

	internal void LateUpdate()
	{
	}
}

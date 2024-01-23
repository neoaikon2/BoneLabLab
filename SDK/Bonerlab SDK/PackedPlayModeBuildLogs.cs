using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PackedPlayModeBuildLogs
{
	[Serializable]
	public struct RuntimeBuildLog
	{
		public LogType Type;

		public string Message;

		public RuntimeBuildLog(LogType type, string message)
		{
			this.Message = default(string);
			this.Type = default(LogType);
		}
	}

	[SerializeField]
	private List<RuntimeBuildLog> m_RuntimeBuildLogs;

	public List<RuntimeBuildLog> RuntimeBuildLogs
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public PackedPlayModeBuildLogs()
		: base()
	{
	}
}

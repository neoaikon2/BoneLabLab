using System.Collections.Generic;

public class ProcessPort
{
	public string processName { get; set; }

	public int processId { get; set; }

	public string portNumber { get; set; }

	public string protocol { get; set; }

	public override string ToString()
	{
		return null;
	}

	private static string LookupProcess(int pid)
	{
		return null;
	}

	public static List<ProcessPort> GetProcessesByPort(string targetPort)
	{
		return null;
	}
}

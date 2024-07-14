using System;

namespace Oculus.Platform.Models
{
	public class ApplicationVersion
	{
		public readonly int CurrentCode;

		public readonly string CurrentName;

		public readonly int LatestCode;

		public readonly string LatestName;

		public readonly long ReleaseDate;

		public readonly string Size;

		public ApplicationVersion(IntPtr o)
		{
		}
	}
}

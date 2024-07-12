using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public struct FilehashObject
	{
		[JsonProperty("md5")]
		public string Md5 { get; }

		[JsonConstructor]
		public FilehashObject([JsonProperty("md5")] string md5)
		{
			this.Md5 = default(string);
		}
	}
}

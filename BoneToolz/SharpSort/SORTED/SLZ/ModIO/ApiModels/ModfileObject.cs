using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SLZ.ModIO.ApiModels
{
	[Serializable]
	public readonly struct ModfileObject
	{
		[JsonProperty("id")]
		public long Id { get; }

		[JsonProperty("mod_id")]
		public long ModId { get; }

		[JsonProperty("date_added")]
		public long DateAdded { get; }

		[JsonProperty("date_scanned")]
		public long DateScanned { get; }

		[JsonProperty("virus_status")]
		public int VirusStatus { get; }

		[JsonProperty("virus_positive")]
		public int VirusPositive { get; }

		[JsonProperty("virustotal_hash")]
		public string VirustotalHash { get; }

		[JsonProperty("filesize")]
		public long Filesize { get; }

		[JsonProperty("filehash")]
		public FilehashObject Filehash { get; }

		[JsonProperty("filename")]
		public string Filename { get; }

		[JsonProperty("version")]
		public string Version { get; }

		[JsonProperty("changelog")]
		public string Changelog { get; }

		[JsonProperty("metadata_blob")]
		public string MetadataBlob { get; }

		[JsonProperty("download")]
		public DownloadObject Download { get; }

		[JsonProperty("platforms")]
		public IReadOnlyList<ModfilePlatformObject> Platforms { get; }

		[JsonConstructor]
		public ModfileObject([JsonProperty("id")] long id, [JsonProperty("mod_id")] long modId, [JsonProperty("date_added")] long dateAdded, [JsonProperty("date_scanned")] long dateScanned, [JsonProperty("virus_status")] int virusStatus, [JsonProperty("virus_positive")] int virusPositive, [JsonProperty("virustotal_hash")] string virustotalHash, [JsonProperty("filesize")] long filesize, [JsonProperty("filehash")] FilehashObject filehash, [JsonProperty("filename")] string filename, [JsonProperty("version")] string version, [JsonProperty("changelog")] string changelog, [JsonProperty("metadata_blob")] string metadataBlob, [JsonProperty("download")] DownloadObject download, [JsonProperty("platforms")] List<ModfilePlatformObject> platforms)
		{
			Id = 0L;
			ModId = 0L;
			DateAdded = 0L;
			DateScanned = 0L;
			VirusStatus = 0;
			VirusPositive = 0;
			VirustotalHash = null;
			Filesize = 0L;
			Filehash = default(FilehashObject);
			Filename = null;
			Version = null;
			Changelog = null;
			MetadataBlob = null;
			Download = default(DownloadObject);
			Platforms = null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}

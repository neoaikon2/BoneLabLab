using Newtonsoft.Json.Linq;

namespace SLZ.Serialize
{
	public interface IPackable
	{
		void Pack(ObjectStore store, JObject json);

		void Unpack(ObjectStore store, string objectId);
	}
}

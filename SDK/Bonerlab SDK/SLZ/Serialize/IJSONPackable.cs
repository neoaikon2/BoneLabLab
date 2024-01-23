using Newtonsoft.Json.Linq;

namespace SLZ.Serialize
{
	public interface IJSONPackable
	{
		void Pack(ObjectStore store, JObject json);

		void Unpack(ObjectStore store, ObjectId objectId);
	}
}

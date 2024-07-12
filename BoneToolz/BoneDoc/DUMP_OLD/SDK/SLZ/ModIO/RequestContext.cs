using System.Runtime.CompilerServices;

namespace SLZ.ModIO
{
	[System.Runtime.CompilerServices.NullableContext(2)]
	[System.Runtime.CompilerServices.Nullable(0)]
	public sealed class RequestContext
	{
		public Platform Platform { get; set; }

		public Portal Portal { get; set; }

		public string ApiKey { get; set; }

		public string AccessToken { get; set; }

		public bool IsAuthorized
		{
			get
			{
				return default(bool);
			}
		}

		public RequestContext()
			: base()
		{
		}
	}
}

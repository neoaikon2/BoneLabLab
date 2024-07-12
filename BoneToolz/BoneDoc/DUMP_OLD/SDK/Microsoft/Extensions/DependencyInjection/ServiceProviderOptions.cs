using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection
{
	public class ServiceProviderOptions
	{
		[System.Runtime.CompilerServices.Nullable(1)]
		internal static readonly ServiceProviderOptions Default;

		public bool ValidateScopes { get; }

		public bool ValidateOnBuild { get; }

		public ServiceProviderOptions()
			: base()
		{
		}
	}
}

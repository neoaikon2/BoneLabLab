using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection.ServiceLookup
{
	[System.Runtime.CompilerServices.NullableContext(1)]
	[System.Runtime.CompilerServices.Nullable(0)]
	internal sealed class ILEmitResolverBuilderContext
	{
		public ILGenerator Generator { get; set; }

		public List<object> Constants { get; set; }

		public List<Func<IServiceProvider, object>> Factories { get; set; }

		public ILEmitResolverBuilderContext()
			: base()
		{
		}
	}
}

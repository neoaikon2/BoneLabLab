using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;

namespace Microsoft.Extensions.DependencyInjection
{
	[System.Runtime.CompilerServices.NullableContext(1)]
	[System.Runtime.CompilerServices.Nullable(new byte[] { 0, 1 })]
	internal sealed class CallSiteJsonFormatter : CallSiteVisitor<CallSiteJsonFormatter.CallSiteFormatterContext, object>
	{
		[System.Runtime.CompilerServices.Nullable(0)]
		internal struct CallSiteFormatterContext
		{
			private readonly HashSet<ServiceCallSite> _processedCallSites;

			private bool _firstItem;

			public int Offset
			{
				[IsReadOnly]
				get;
			}

			public StringBuilder Builder
			{
				[IsReadOnly]
				get;
			}

			public CallSiteFormatterContext(StringBuilder builder, int offset, HashSet<ServiceCallSite> processedCallSites)
			{
				this.Builder = default(StringBuilder);
				this.Offset = default(int);
				this._firstItem = default(bool);
				this._processedCallSites = default(HashSet<ServiceCallSite>);
			}

			public bool ShouldFormat(ServiceCallSite serviceCallSite)
			{
				return default(bool);
			}

			public CallSiteFormatterContext IncrementOffset()
			{
				return default(CallSiteFormatterContext);
			}

			public CallSiteFormatterContext StartObject()
			{
				return default(CallSiteFormatterContext);
			}

			public void EndObject()
			{
			}

			public void StartProperty(string name)
			{
			}

			public void StartArrayItem()
			{
			}

			public void WriteProperty(string name, object value)
			{
			}

			public CallSiteFormatterContext StartArray()
			{
				return default(CallSiteFormatterContext);
			}

			public void EndArray()
			{
			}
		}

		internal static CallSiteJsonFormatter Instance;

		private CallSiteJsonFormatter()
			: base()
		{
		}

		public string Format(ServiceCallSite callSite)
		{
			return null;
		}

		protected override object VisitConstructor(ConstructorCallSite constructorCallSite, CallSiteFormatterContext argument)
		{
			return null;
		}

		protected override object VisitCallSiteMain(ServiceCallSite callSite, CallSiteFormatterContext argument)
		{
			return null;
		}

		protected override object VisitConstant(ConstantCallSite constantCallSite, CallSiteFormatterContext argument)
		{
			return null;
		}

		protected override object VisitServiceProvider(ServiceProviderCallSite serviceProviderCallSite, CallSiteFormatterContext argument)
		{
			return null;
		}

		protected override object VisitIEnumerable(IEnumerableCallSite enumerableCallSite, CallSiteFormatterContext argument)
		{
			return null;
		}

		protected override object VisitFactory(FactoryCallSite factoryCallSite, CallSiteFormatterContext argument)
		{
			return null;
		}
	}
}

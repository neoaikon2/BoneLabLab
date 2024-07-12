using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Primitives
{
	public static class ChangeToken
	{
		private sealed class ChangeTokenRegistration<TState> : IDisposable
		{
			private sealed class NoopDisposable : IDisposable
			{
				public void Dispose()
				{
				}

				public NoopDisposable()
					: base()
				{
				}
			}

			private readonly Func<IChangeToken> _changeTokenProducer;

			private readonly Action<TState> _changeTokenConsumer;

			private readonly TState _state;

			private IDisposable _disposable;

			private static readonly NoopDisposable _disposedSentinel;

			public ChangeTokenRegistration(Func<IChangeToken> changeTokenProducer, Action<TState> changeTokenConsumer, TState state)
				: base()
			{
			}

			private void OnChangeTokenFired()
			{
			}

			private void RegisterChangeTokenCallback(IChangeToken token)
			{
			}

			private void SetDisposable(IDisposable disposable)
			{
			}

			public void Dispose()
			{
			}
		}

		public static IDisposable OnChange(Func<IChangeToken> changeTokenProducer, Action changeTokenConsumer)
		{
			return null;
		}

		public static IDisposable OnChange<TState>(Func<IChangeToken> changeTokenProducer, Action<TState> changeTokenConsumer, TState state)
		{
			return null;
		}
	}
}

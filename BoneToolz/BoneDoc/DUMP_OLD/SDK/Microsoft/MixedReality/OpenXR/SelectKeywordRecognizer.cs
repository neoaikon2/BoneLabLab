using System;
using UnityEngine.Windows.Speech;

namespace Microsoft.MixedReality.OpenXR
{
	public sealed class SelectKeywordRecognizer : IDisposable
	{
		private SelectKeywordRecognizerProvider m_provider;

		public static bool IsSupported
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsRunning
		{
			get
			{
				return default(bool);
			}
		}

		public event PhraseRecognizer.PhraseRecognizedDelegate OnPhraseRecognized
		{
			add
			{
			}
			remove
			{
			}
		}

		public void Start()
		{
		}

		public void Stop()
		{
		}

		public void Dispose()
		{
		}

		public SelectKeywordRecognizer()
			: base()
		{
		}
	}
}

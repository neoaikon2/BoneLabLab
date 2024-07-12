using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine.Windows.Speech;

namespace Microsoft.MixedReality.OpenXR
{
	internal class SelectKeywordRecognizerProvider
	{
		private const long m_selectKeywordDurationInTicks = 10000000L;

		private static readonly Type[] m_recogEventArgsConstructorArgTypes;

		private static readonly Dictionary<string, string> m_localizedSelectKeywordLookup;

		private static readonly string m_currentSystemLanguage;

		private static readonly string m_localizedSelectKeyword;

		private static readonly ConstructorInfo m_recogEventArgsConstructorInfo;

		private static bool? m_isPlatformSupported;

		internal static bool IsSupported
		{
			get
			{
				return default(bool);
			}
		}

		internal bool IsRunning { get; private set; }

		private static bool IsPlatformSupported
		{
			get
			{
				return default(bool);
			}
		}

		private static bool IsUnityVersionSupported
		{
			get
			{
				return default(bool);
			}
		}

		private static bool IsSystemLanguageSupported
		{
			get
			{
				return default(bool);
			}
		}

		internal SelectKeywordRecognizerProvider()
			: base()
		{
		}

		internal void Start()
		{
		}

		internal void Stop()
		{
		}

		internal void Dispose()
		{
		}

		private static bool CheckPlatformSupport()
		{
			return default(bool);
		}

		private static PhraseRecognizedEventArgs GeneratePhraseRecognizedEventArgs()
		{
			return default(PhraseRecognizedEventArgs);
		}

		private static ConstructorInfo GetPhraseRecognizedEventArgsConstructorInfo()
		{
			return null;
		}

		private static string GetLocalizedKeyword()
		{
			return null;
		}

		internal event PhraseRecognizer.PhraseRecognizedDelegate OnPhraseRecognized;
	}
}

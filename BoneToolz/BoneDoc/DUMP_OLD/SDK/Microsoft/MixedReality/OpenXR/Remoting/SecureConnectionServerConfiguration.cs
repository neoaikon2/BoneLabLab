using System;
using System.Runtime.InteropServices;

namespace Microsoft.MixedReality.OpenXR.Remoting
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 48)]
	internal struct SecureConnectionServerConfiguration
	{
		public bool SecureListen;

		public string CertificateStorePath;

		public string SubjectName;

		public string KeyPassphrase;

		public string AuthenticationRealm;

		public string Token;
	}
}

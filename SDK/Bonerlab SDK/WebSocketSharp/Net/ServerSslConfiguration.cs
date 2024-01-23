using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace WebSocketSharp.Net
{
	public class ServerSslConfiguration
	{
		private bool _checkCertRevocation;

		private bool _clientCertRequired;

		private RemoteCertificateValidationCallback _clientCertValidationCallback;

		private SslProtocols _enabledSslProtocols;

		private X509Certificate2 _serverCert;

		public bool CheckCertificateRevocation
		{
			get
			{
				return default(bool);
			}
		}

		public bool ClientCertificateRequired
		{
			get
			{
				return default(bool);
			}
		}

		public RemoteCertificateValidationCallback ClientCertificateValidationCallback
		{
			get
			{
				return null;
			}
		}

		public SslProtocols EnabledSslProtocols
		{
			get
			{
				return default(SslProtocols);
			}
		}

		public X509Certificate2 ServerCertificate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ServerSslConfiguration()
			: base()
		{
		}

		public ServerSslConfiguration(ServerSslConfiguration configuration)
			: this()
		{
		}

		private static bool defaultValidateClientCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}
	}
}

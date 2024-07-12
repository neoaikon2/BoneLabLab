namespace Microsoft.MixedReality.OpenXR.Remoting
{
	public enum DisconnectReason
	{
		None = 0,
		Unknown = 1,
		NoServerCertificate = 2,
		HandshakePortBusy = 3,
		HandshakeUnreachable = 4,
		HandshakeConnectionFailed = 5,
		AuthenticationFailed = 6,
		RemotingVersionMismatch = 7,
		IncompatibleTransportProtocols = 8,
		HandshakeFailed = 9,
		TransportPortBusy = 10,
		TransportUnreachable = 11,
		TransportConnectionFailed = 12,
		ProtocolVersionMismatch = 13,
		ProtocolError = 14,
		VideoCodecNotAvailable = 15,
		Canceled = 16,
		ConnectionLost = 17,
		DeviceLost = 18,
		DisconnectRequest = 19,
		HandshakeNetworkUnreachable = 20,
		HandshakeConnectionRefused = 21,
		VideoFormatNotAvailable = 22,
		PeerDisconnectRequest = 23,
		PeerDisconnectTimeout = 24,
		SessionOpenTimeout = 25,
		RemotingHandshakeTimeout = 26,
		InternalError = 27,
		HandshakePermissionDenied = 28
	}
}

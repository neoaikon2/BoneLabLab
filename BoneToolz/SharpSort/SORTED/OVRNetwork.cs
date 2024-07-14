using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading;

public class OVRNetwork
{
	private struct FrameHeader
	{
		public uint protocolIdentifier;

		public int payloadType;

		public int payloadLength;

		public const int StructSize = 12;

		public byte[] ToBytes()
		{
			return null;
		}

		public static FrameHeader FromBytes(byte[] arr)
		{
			return default(FrameHeader);
		}
	}

	public class OVRNetworkTcpServer
	{
		public TcpListener tcpListener;

		private readonly object clientsLock;

		public readonly List<TcpClient> clients;

		public void StartListening(int listeningPort)
		{
		}

		public void StopListening()
		{
		}

		private void DoAcceptTcpClientCallback(IAsyncResult ar)
		{
		}

		public bool HasConnectedClient()
		{
			return false;
		}

		public void Broadcast(int payloadType, byte[] payload)
		{
		}

		private void DoWriteDataCallback(IAsyncResult ar)
		{
		}
	}

	public class OVRNetworkTcpClient
	{
		public enum ConnectionState
		{
			Disconnected = 0,
			Connected = 1,
			Connecting = 2
		}

		public Action connectionStateChangedCallback;

		public Action<int, byte[], int, int> payloadReceivedCallback;

		private TcpClient tcpClient;

		private byte[][] receivedBuffers;

		private int receivedBufferIndex;

		private int receivedBufferDataSize;

		private ManualResetEvent readyReceiveDataEvent;

		public ConnectionState connectionState => default(ConnectionState);

		public bool Connected => false;

		public void Connect(int listeningPort)
		{
		}

		private void ConnectCallback(IAsyncResult ar)
		{
		}

		public void Disconnect()
		{
		}

		public void Tick()
		{
		}

		private void OnReadDataCallback(IAsyncResult ar)
		{
		}
	}

	public const int MaxBufferLength = 65536;

	public const int MaxPayloadLength = 65524;

	public const uint FrameHeaderMagicIdentifier = 1384359787u;
}

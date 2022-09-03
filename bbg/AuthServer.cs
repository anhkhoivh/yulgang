using RxjhServer;
using System;
using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace bbg
{
	public class AuthServer
	{
		private string ip;

		private int port;

		public static ArrayList clients;

		private Socket listenSocket;

		private MessageeDelegaterE eval_d;

		public int totalReceive = 0;

		public int totalSend = 0;

		public event MessageeDelegaterE OnSockMessage
		{
			add
			{
				MessageeDelegaterE messageeDelegaterE = eval_d;
				MessageeDelegaterE messageeDelegaterE2;
				do
				{
					messageeDelegaterE2 = messageeDelegaterE;
					MessageeDelegaterE value2 = (MessageeDelegaterE)Delegate.Combine(messageeDelegaterE2, value);
					messageeDelegaterE = Interlocked.CompareExchange(ref eval_d, value2, messageeDelegaterE2);
				}
				while (messageeDelegaterE != messageeDelegaterE2);
			}
			remove
			{
				MessageeDelegaterE messageeDelegaterE = eval_d;
				MessageeDelegaterE messageeDelegaterE2;
				do
				{
					messageeDelegaterE2 = messageeDelegaterE;
					MessageeDelegaterE value2 = (MessageeDelegaterE)Delegate.Remove(messageeDelegaterE2, value);
					messageeDelegaterE = Interlocked.CompareExchange(ref eval_d, value2, messageeDelegaterE2);
				}
				while (messageeDelegaterE != messageeDelegaterE2);
			}
		}

		static AuthServer()
		{
			old_acctor_mc();
		}

		public AuthServer(string i, int pt)
		{
			ip = i;
			port = pt;
			Start();
		}

		public void CloseServer()
		{
			listenSocket.Close();
		}

		public void Dispose()
		{
			while (clients.Count > 0)
			{
				((SockClienT)clients[0]).Dispose();
			}
			try
			{
				listenSocket.Shutdown(SocketShutdown.Both);
			}
			catch
			{
			}
			if (listenSocket != null)
			{
				listenSocket.Close();
			}
		}

		private void eval_a(object A_0, SockClienT A_1)
		{
			if (eval_d != null)
			{
				eval_d(A_0, A_1);
			}
		}

		private void eval_b(object A_0, SockClienT A_1)
		{
			eval_a(A_0, A_1);
		}

		private static void old_acctor_mc()
		{
			clients = new ArrayList();
		}

		public virtual void OnAccept(IAsyncResult ar)
		{
			try
			{
				Socket socket = listenSocket.EndAccept(ar);
				if (socket != null)
				{
					ClientConnection clientConnection = new ClientConnection(socket, RemoveClient);
					clients.Add(clientConnection);
					clientConnection.OnSockMessage += eval_b;
					clientConnection.Start();
				}
			}
			catch (Exception arg)
			{
				Console.WriteLine("{0}", arg);
			}
			try
			{
				listenSocket.BeginAccept(OnAccept, listenSocket);
			}
			catch
			{
				Dispose();
			}
		}

		public void RemoveClient(SockClienT client)
		{
			using (new Lock(clients, "RemoveClient"))
			{
				clients.Remove(client);
			}
		}

		public bool Start()
		{
			try
			{
				listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				listenSocket.Bind(new IPEndPoint(IPAddress.Any, port));
				Form1.WriteLine(1, "开始监听百宝端口 " + port + " IP " + ip.ToString());
				listenSocket.Listen(10);
				listenSocket.BeginAccept(OnAccept, listenSocket);
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Failled to list on port {0}\n{1}", port, ex.Message);
				Form1.WriteLine(1, "监听百宝端口出错 " + port + "   " + ex.Message);
				listenSocket = null;
				return false;
			}
		}
	}
}

using HelperTools;
using RxjhServer;
using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace bbg
{
	public class SockClienT
	{
		private MemoryStream ms = new MemoryStream();

		public Socket clientSocket;

		private byte[] dataReceive = new byte[1500];

		private bool disposed = false;

		private RemoveClientDelegateE removeFromTheServerList;

		private MessageeDelegaterE eval_e;

		public bool Disposed => disposed;

		public IPAddress IP
		{
			get
			{
				try
				{
					if (disposed)
					{
						return null;
					}
					return ((IPEndPoint)clientSocket.RemoteEndPoint).Address;
				}
				catch
				{
					Dispose();
				}
				return null;
			}
		}

		public event MessageeDelegaterE OnSockMessage
		{
			add
			{
				MessageeDelegaterE messageeDelegaterE = eval_e;
				MessageeDelegaterE messageeDelegaterE2;
				do
				{
					messageeDelegaterE2 = messageeDelegaterE;
					MessageeDelegaterE value2 = (MessageeDelegaterE)Delegate.Combine(messageeDelegaterE2, value);
					messageeDelegaterE = Interlocked.CompareExchange(ref eval_e, value2, messageeDelegaterE2);
				}
				while (messageeDelegaterE != messageeDelegaterE2);
			}
			remove
			{
				MessageeDelegaterE messageeDelegaterE = eval_e;
				MessageeDelegaterE messageeDelegaterE2;
				do
				{
					messageeDelegaterE2 = messageeDelegaterE;
					MessageeDelegaterE value2 = (MessageeDelegaterE)Delegate.Remove(messageeDelegaterE2, value);
					messageeDelegaterE = Interlocked.CompareExchange(ref eval_e, value2, messageeDelegaterE2);
				}
				while (messageeDelegaterE != messageeDelegaterE2);
			}
		}

		public SockClienT(Socket from, RemoveClientDelegateE rftsl)
		{
			removeFromTheServerList = rftsl;
			clientSocket = from;
		}

		public void Dispose()
		{
			if (!disposed)
			{
				disposed = true;
				try
				{
					if (removeFromTheServerList != null)
					{
						removeFromTheServerList(this);
					}
					clientSocket.Shutdown(SocketShutdown.Both);
				}
				catch
				{
				}
				if (clientSocket != null)
				{
					clientSocket.Close();
				}
				clientSocket = null;
			}
		}

		public virtual void OnReceiveData(IAsyncResult ar)
		{
			try
			{
				if (!disposed)
				{
					int num = clientSocket.EndReceive(ar);
					if (num <= 0)
					{
						Dispose();
					}
					else
					{
						ProcessDataReceived(dataReceive, num);
						Dispose();
					}
				}
			}
			catch (Exception)
			{
				Dispose();
			}
		}

		public void OnSended(IAsyncResult ar)
		{
			try
			{
				if (!disposed)
				{
					clientSocket.EndSend(ar);
					clientSocket.BeginReceive((ar.AsyncState as SockClienT).dataReceive, 0, (ar.AsyncState as SockClienT).dataReceive.Length, SocketFlags.None, OnReceiveData, ar.AsyncState);
				}
			}
			catch
			{
				Dispose();
			}
		}

		public void OnSended2(IAsyncResult ar)
		{
			try
			{
				if (!disposed)
				{
					clientSocket.EndSend(ar);
				}
			}
			catch (Exception)
			{
				Dispose();
			}
		}

		public virtual void ProcessDataReceived(byte[] data, int length)
		{
		}

		public void RaiseMessageEvent(string Msg)
		{
			if (eval_e != null)
			{
				eval_e(Msg, this);
			}
		}

		public virtual void Send(string str)
		{
			try
			{
				int t = 0;
				if (!disposed)
				{
					byte[] array = new byte[str.Length];
					Converter.ToBytes(str, array, ref t);
					clientSocket.BeginSend(array, 0, t, SocketFlags.None, OnSended2, this);
				}
			}
			catch (Exception)
			{
				Dispose();
			}
		}

		public virtual void Send(byte[] toSendBuff, int len)
		{
			try
			{
				if (!disposed)
				{
					byte[] array = new byte[len + 6];
					array[0] = 170;
					array[1] = 102;
					Buffer.BlockCopy(BitConverter.GetBytes(len), 0, array, 2, 4);
					Buffer.BlockCopy(toSendBuff, 0, array, 6, len);
					clientSocket.BeginSend(array, 0, array.Length, SocketFlags.None, OnSended2, this);
				}
			}
			catch (Exception)
			{
				Dispose();
			}
		}

		public virtual void Send(char[] toSendBuff, int len)
		{
			try
			{
				if (!disposed)
				{
					byte[] array = new byte[len];
					Buffer.BlockCopy(toSendBuff, 0, array, 0, len);
					clientSocket.BeginSend(array, 0, len, SocketFlags.None, OnSended2, this);
				}
			}
			catch (Exception)
			{
				Dispose();
			}
		}

		public virtual void Send(byte[] toSendBuff, int offset, int len)
		{
			try
			{
				if (!disposed)
				{
					byte[] array = new byte[len];
					Buffer.BlockCopy(toSendBuff, offset, array, 0, len);
					if (!disposed)
					{
						clientSocket.BeginSend(array, 0, len, SocketFlags.None, OnSended2, this);
					}
				}
			}
			catch (Exception)
			{
				Dispose();
			}
		}

		public virtual void Sendd(string str)
		{
			byte[] bytes = Encoding.Default.GetBytes(str);
			Send(bytes, bytes.Length);
		}

		public void Start()
		{
			clientSocket.BeginReceive(dataReceive, 0, dataReceive.Length, SocketFlags.None, OnReceiveData, this);
		}
	}
}

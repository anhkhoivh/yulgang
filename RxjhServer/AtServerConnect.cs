using RxjhServer.RxjhServer;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Timers;

namespace RxjhServer
{
	public class AtServerConnect
	{
		private readonly System.Timers.Timer 自动连接 = new System.Timers.Timer(5000.0);

		private readonly byte[] dataReceive = new byte[1024];

		private Socket listenSocket;

		public AtServerConnect()
		{
			自动连接.Elapsed += 自动连接事件;
			自动连接.AutoReset = true;
			自动连接.Enabled = true;
		}

		public void Dispose()
		{
			if (自动连接 != null)
			{
				自动连接.Enabled = false;
				自动连接.Close();
				自动连接.Dispose();
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
			listenSocket = null;
		}

		private void ConnectCallback(IAsyncResult ar)
		{
			try
			{
				((Socket)ar.AsyncState).EndConnect(ar);
				try
				{
					Form1.WriteLine(2, "攻击伺服器连接成功 端口 " + World.AtPort.ToString() + " IP " + World.帐号验证服务器ip);
					string msg = "攻击伺服器连接|" + World.游戏服务器端口.ToString();
					发送(msg);
					listenSocket.BeginReceive(dataReceive, 0, dataReceive.Length, SocketFlags.None, OnReceiveData, this);
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "攻击伺服器ConnectCallback出错：" + ex.Message);
				}
			}
			catch (Exception ex2)
			{
				Form1.WriteLine(1, "攻击伺服器连接出错：" + ex2.Message);
			}
		}

		private void 自动连接事件(object sender, ElapsedEventArgs e)
		{
			if (!listenSocket.Connected)
			{
				Sestup();
			}
		}

		public virtual void OnReceiveData(IAsyncResult ar)
		{
			try
			{
				int num = listenSocket.EndReceive(ar);
				if (num > 0)
				{
					if (dataReceive[0] == 170 && dataReceive[1] == 102)
					{
						VerifyAttack(dataReceive, num);
					}
					listenSocket.BeginReceive(dataReceive, 0, dataReceive.Length, SocketFlags.None, OnReceiveData, this);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "攻击伺服器接收出错：" + ex.Message);
			}
		}

		public void VerifyAttack(byte[] data, int length)
		{
			try
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(data, 2, array, 0, 4);
				int num = BitConverter.ToInt32(array, 0);
				byte[] array2 = new byte[num];
				Buffer.BlockCopy(data, 6, array2, 0, num);
				int key = BitConverter.ToInt16(array2, 5);
				if (World.AllConnectedChars.TryGetValue(key, out Players value))
				{
					value.VerifyAttack(array2, num);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "攻击确认发送出错：" + ex.Message);
			}
		}

		public void OnSended2(IAsyncResult ar)
		{
			try
			{
				listenSocket.EndSend(ar);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "攻击伺服器发送出错：" + ex.Message);
			}
		}

		public void ProcessDataReceived(byte[] data, int length)
		{
			try
			{
				int num = 0;
				if (170 == data[0] && 102 == data[1])
				{
					byte[] array = new byte[4];
					Buffer.BlockCopy(data, 2, array, 0, 4);
					int num2 = BitConverter.ToInt32(array, 0);
					if (length >= num2 + 6)
					{
						while (true)
						{
							if (World.JlMsg == 1)
							{
								Form1.WriteLine(0, "ProcessDataReceived");
							}
							byte[] array2 = new byte[num2];
							Buffer.BlockCopy(data, num + 6, array2, 0, num2);
							num += num2 + 6;
							World.FindPlayerbyID(BitConverter.ToInt16(array2, 5))?.VerifyAttack(array2, num2);
							if (num >= length || data[num] != 170 || data[num + 1] != 102)
							{
								break;
							}
							Buffer.BlockCopy(data, num + 2, array, 0, 4);
							num2 = BitConverter.ToInt16(array, 0);
						}
					}
				}
				else
				{
					Form1.WriteLine(1, "攻击确认发送错包：" + data[0] + " " + data[1]);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "攻击确认发送出错：" + ex.Message);
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.Source);
				Console.WriteLine(ex.StackTrace);
			}
		}

		public virtual void Send(byte[] toSendBuff, int len)
		{
			try
			{
				byte[] array = new byte[len + 6];
				array[0] = 170;
				array[1] = 102;
				Buffer.BlockCopy(BitConverter.GetBytes(len), 0, array, 2, 4);
				Buffer.BlockCopy(toSendBuff, 0, array, 6, len);
				listenSocket.BeginSend(array, 0, len + 6, SocketFlags.None, OnSended2, this);
			}
			catch (SocketException ex)
			{
				Form1.WriteLine(1, "攻击伺服器发送出错：" + ex.Message);
			}
			catch (Exception ex2)
			{
				Form1.WriteLine(1, "攻击伺服器发送出错：" + ex2.Message);
			}
		}

		public void Sestup()
		{
			try
			{
				IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(World.帐号验证服务器ip), World.AtPort);
				listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				listenSocket.UseOnlyOverlappedIO = true;
				listenSocket.BeginConnect(remoteEP, ConnectCallback, listenSocket);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(2, "连接攻击伺服器出错 " + World.帐号验证服务器端口.ToString() + " IP " + World.帐号验证服务器ip.ToString() + " " + ex.Message);
			}
		}

		public void 发送(string msg)
		{
			try
			{
				if (listenSocket != null && listenSocket.Connected)
				{
					byte[] bytes = Encoding.Default.GetBytes(msg);
					Send(bytes, bytes.Length);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "攻击伺服器发送出错：" + msg + ex.Message);
			}
		}
	}
}

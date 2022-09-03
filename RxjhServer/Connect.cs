using Network;
using RxjhServer.RxjhServer;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Timers;

namespace RxjhServer
{
	public class Connect
	{
		private System.Timers.Timer 自动连接 = new System.Timers.Timer(5000.0);

		private Socket listenSocket;

		private byte[] dataReceive = new byte[102400];

		public Connect()
		{
			自动连接.Elapsed += 自动连接事件;
			自动连接.AutoReset = true;
			自动连接.Enabled = true;
		}

		public void DataReceived(byte[] data, int length)
		{
			string @string = Encoding.Default.GetString(data);
			try
			{
				string[] array = @string.Split('|');
				string text = array[0];
				if (text != null)
				{
					if (text == "用户登陆")
					{
						用户登陆(int.Parse(array[2]), array[1], array[4], int.Parse(array[3]));
					}
					else if (text == "用户踢出")
					{
						if (!(array[1] == ""))
						{
							用户踢出(int.Parse(array[1]));
						}
					}
					else if (text == "发送公告")
					{
						发送公告(int.Parse(array[1]), array[2]);
					}
					else if (text == "狮子吼")
					{
						NetState value;
						if (array[1] == "OK")
						{
							World.发送全服狮子吼消息广播数据(int.Parse(array[2]), array[3], int.Parse(array[4]), array[5], int.Parse(array[6]), int.Parse(array[7]));
						}
						else if (World.List.TryGetValue(int.Parse(array[2]), out value))
						{
							value.Player.GameMessage("狮子吼列队以满请等待.....", 9);
						}
					}
					else if (text == "ChatGuild")
					{
						if (array[1] == "OK")
						{
							string name = array[3];
							string text2 = array[5];
							int num = int.Parse(array[6]);
							string b = array[7];
							if (World.服务器id != num)
							{
								foreach (Players value2 in World.AllConnectedChars.Values)
								{
									if (value2.Guild_Name == b)
									{
										value2.GameMessage("(" + num + ") " + text2, 3, name);
									}
									else if (value2.GM模式 != 0)
									{
										value2.GameMessage("(" + num + ") " + text2, 3, name);
									}
								}
							}
						}
					}
					else if (text == "NhanItem" && array[1] == "OK")
					{
						string name = array[2];
						int boxID = int.Parse(array[3]);
						string boxName = array[4];
						int itemID = int.Parse(array[5]);
						string itemName = array[6];
						int num = int.Parse(array[7]);
						if (World.服务器id != num)
						{
							using (IEnumerator<Players> enumerator = World.AllConnectedChars.Values.GetEnumerator())
							{
								if (enumerator.MoveNext())
								{
									Players current2 = enumerator.Current;
									current2.ThongBaoNhanItem(1, boxID, boxName, itemID, itemName, num, name);
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "验证服务器接收出错：" + @string + ex.Message);
			}
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

		private void ConnectCallback(IAsyncResult A_0)
		{
			try
			{
				((Socket)A_0.AsyncState).EndConnect(A_0);
				try
				{
					发送("服务器连接登陆|" + World.服务器id + "|" + World.最大在线 + "|" + CRC32.GetEXECRC32());
					Form1.WriteLine(2, "帐号服务器连接成功 端口 " + World.帐号验证服务器端口 + " IP " + World.帐号验证服务器ip);
					listenSocket.BeginReceive(dataReceive, 0, dataReceive.Length, SocketFlags.None, OnReceiveData, this);
					Thread.Sleep(500);
					发送("更新服务器端口|" + World.服务器id + "|" + World.游戏服务器端口2);
					复查用户登陆();
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "验证服务器ConnectCallback出错：" + ex.Message);
				}
			}
			catch (Exception ex2)
			{
				Form1.WriteLine(1, "帐号服务器连接出错：" + ex2.Message);
			}
		}

		private void 自动连接事件(object sender, ElapsedEventArgs e)
		{
			if (World.JlMsg == 1)
			{
			}
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
					ProcessDataReceived(dataReceive, num);
					listenSocket.BeginReceive(dataReceive, 0, dataReceive.Length, SocketFlags.None, OnReceiveData, this);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "帐号服务器 接收出错：" + ex.Message);
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
				Form1.WriteLine(1, "帐号服务器 发送出错：" + ex.Message);
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
							DataReceived(array2, num2);
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
					Form1.WriteLine(1, "错包：" + data[0] + " " + data[1]);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "出错：" + ex.Message);
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
				Form1.WriteLine(1, "帐号服务器 发送出错：" + ex.Message);
			}
			catch (Exception ex2)
			{
				Form1.WriteLine(1, "帐号服务器 发送出错：" + ex2.Message);
			}
		}

		public void Sestup()
		{
			try
			{
				IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(World.帐号验证服务器ip), World.帐号验证服务器端口);
				listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				listenSocket.UseOnlyOverlappedIO = true;
				listenSocket.BeginConnect(remoteEP, ConnectCallback, listenSocket);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(2, "连接帐号验证服务器出错 " + World.帐号验证服务器端口 + " IP " + World.帐号验证服务器ip.ToString() + " " + ex.Message);
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
				Form1.WriteLine(1, "验证服务器发送出错：" + msg + ex.Message);
			}
		}

		public void 发送公告(int ggid, string txt)
		{
			try
			{
				foreach (Players value in World.AllConnectedChars.Values)
				{
					if (value != null)
					{
						switch (ggid)
						{
						case 0:
							value.系统公告(txt);
							break;
						case 1:
							value.系统滚动公告(txt);
							break;
						case 2:
							value.GameMessage(txt, 10);
							break;
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "发送公告出错：" + ex.Message);
			}
		}

		public void 复查用户登陆()
		{
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (NetState value in World.List.Values)
				{
					stringBuilder.Append(value.Player.Userid);
					stringBuilder.Append("-");
					stringBuilder.Append(value.ToString());
					stringBuilder.Append(",");
				}
				if (stringBuilder.Length > 0)
				{
					stringBuilder.Remove(stringBuilder.Length - 1, 1);
				}
				World.Conn.发送("复查用户登陆|" + stringBuilder);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "复查用户登陆 错误" + ex.Message);
			}
		}

		public void 用户登陆(int serverid, string userid, string txt, int channel)
		{
			try
			{
				if (World.List.TryGetValue(serverid, out NetState value))
				{
					value.Player.连接登陆2(userid, txt, channel);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "验证服务器用户登陆出错：" + ex.Message);
			}
		}

		public void 用户踢出(int userid)
		{
			try
			{
				if (World.List.TryGetValue(userid, out NetState value))
				{
					Form1.WriteLine(3, "用户踢出 [" + value.Player.Userid + "]-[" + value.Player.UserName + "]" + value.ToString());
					Players players = World.FindPlayerbyName(value.Player.UserName);
					if (players != null)
					{
						players.GameMessage("Coì ngýõÌi ðaÞ ðãng nhâòp taÌi khoaÒn naÌy, ngãìt kêìt nôìi.", 24);
						players.GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 2", 7);
						players.SaveDataCharacter();
						players.Logout();
						players.Dispose();
					}
					value.Dispose();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "验证服务器用户踢出出错：" + userid + " " + ex.Message);
			}
		}
	}
}

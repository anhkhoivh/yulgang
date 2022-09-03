using HelperTools;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
using RxjhServer;
using RxjhServer.RxjhServer;
using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Timers;

namespace Network
{
	public class NetState : IDisposable
	{
		[Flags]
		private enum AsyncState
		{
			Paused = 0x2,
			Pending = 0x1
		}

		[StructLayout(LayoutKind.Sequential)]
		public class IO_Net_DATA
		{
			public NetState NetStat;
		}

		private const int BufferSize = 1024;

		private byte[] Key = new byte[32]
		{
			4,
			59,
			194,
			124,
			236,
			235,
			63,
			139,
			52,
			131,
			91,
			36,
			67,
			248,
			106,
			32,
			193,
			231,
			2,
			232,
			92,
			237,
			241,
			255,
			89,
			139,
			13,
			8,
			51,
			65,
			0,
			137
		};

		private byte[] CODE = new byte[65536];

		public int dwStop;

		private AsyncState m_AsyncState;

		private static BufferPool m_ReceiveBufferPool;

		private SendQueue m_SendQueue;

		private Socket m_Socket;

		private IPAddress m_Address;

		private AsyncCallback m_OnReceive;

		private AsyncCallback m_OnSend;

		private object m_AsyncLock = new object();

		private byte[] m_RecvBuffer;

		private Queue BuffPool = Queue.Synchronized(new Queue());

		private Players _Player;

		private ByteQueue m_Buffer;

		private bool m_Running;

		private bool _FLD_Offline;

		private string m_ToString;

		private ManualResetEvent sendDone = new ManualResetEvent(initialState: false);

		public byte[] g_cur_key = new byte[8]
		{
			201,
			39,
			147,
			1,
			162,
			108,
			49,
			151
		};

		public int Key2 = 2138432278;

		public DateTime Ljtime = DateTime.Now;

		private bool 退出;

		public int WorldId;

		public bool 版本验证;

		public bool 登陆;

		public DateTime 登陆sj = DateTime.Now;

		public bool 加密;

		public bool 在线;

		public System.Timers.Timer 自动断开;

		public ByteQueue Buffer => m_Buffer;

		public bool FLD_Offline
		{
			get
			{
				return _FLD_Offline;
			}
			set
			{
				_FLD_Offline = value;
			}
		}

		public Players Player
		{
			get
			{
				return _Player;
			}
			set
			{
				_Player = value;
			}
		}

		public bool Running => m_Running;

		static NetState()
		{
			old_acctor_mc();
		}

		public NetState(Socket socket)
		{
			Ljtime = DateTime.Now;
			m_Socket = socket;
			m_Running = false;
			m_SendQueue = new SendQueue();
			m_Buffer = new ByteQueue();
			m_RecvBuffer = m_ReceiveBufferPool.eval_c();
			try
			{
				m_Address = ((IPEndPoint)m_Socket.RemoteEndPoint).Address;
				m_ToString = m_Address.ToString();
			}
			catch
			{
				m_Address = IPAddress.None;
				m_ToString = "(error)";
			}
			WorldId = (int)socket.Handle;
			addWorldIdd();
			Player = new Players(this);
			Form1.WriteLine(3, WorldId + " joined - IP: " + ToString());
			FLD_Offline = false;
			自动断开 = new System.Timers.Timer(World.版本验证时间);
			自动断开.Elapsed += 自动断开事件;
			自动断开.AutoReset = true;
			自动断开.Enabled = true;
		}

		private bool Flush()
		{
			if (World.JlMsg == 1)
			{
			}
			if (m_Socket != null && m_SendQueue.IsFlushReady)
			{
				SendQueue.Gram gram;
				lock (m_SendQueue)
				{
					gram = m_SendQueue.CheckFlushReady();
				}
				if (gram != null)
				{
					try
					{
						m_Socket.BeginSend(gram.Buffer, 0, gram.Length, SocketFlags.None, m_OnSend, m_Socket);
						return true;
					}
					catch (Exception)
					{
					}
				}
			}
			return false;
		}

		public void addWorldIdd()
		{
			try
			{
				int num = 300;
				while (true)
				{
					if (num >= 10000)
					{
						return;
					}
					if (!World.List.ContainsKey(num))
					{
						break;
					}
					num++;
				}
				WorldId = num;
				World.List.Add(num, this);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "addWorldIdd()出错" + WorldId + "|" + ToString() + " " + ex.Message);
			}
		}

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern SafeFileHandle CreateIoCompletionPort(IntPtr FileHandle, IntPtr ExistingCompletionPort, IntPtr CompletionKey, uint NumberOfConcurrentThreads);

		public void delWorldIdd()
		{
			try
			{
				if (World.List.ContainsKey(WorldId))
				{
					World.List.Remove(WorldId);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "delWorldIdd()出错" + WorldId + "|" + ToString() + " " + ex.Message);
			}
		}

		public void Dispose()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "Dispose()");
			}
			Dispose(flush: true);
		}

		private void HandleReceive(NetState ns)
		{
			if (World.JlMsg == 1)
			{
			}
			try
			{
				if (Buffer != null && Buffer.Length > 0)
				{
					using (new Lock(Buffer, "HandleReceive"))
					{
						int length = Buffer.Length;
						while (true)
						{
							if (length <= 0 || !Running)
							{
								return;
							}
							if (World.JlMsg == 1)
							{
							}
							if (length <= 4)
							{
								return;
							}
							int num = BitConverter.ToInt16(Buffer.GetPacketID(), 0);
							if (num <= 0)
							{
								Buffer.Clear();
								return;
							}
							num += 6;
							if (length < num)
							{
								break;
							}
							byte[] data = new byte[num];
							Buffer.Dequeue(data, 0, num);
							length = Buffer.Length;
							if (170 != data[0] || 85 != data[1])
							{
								Buffer.Clear();
								return;
							}
							if (data[num - 2] != 85 || data[num - 1] != 170)
							{
								Buffer.Clear();
								return;
							}
							if (World.是否加密 != 0)
							{
								if (World.登陆器模式 == 1)
								{
									Decrypta(ref data);
								}
								else if (World.登陆器模式 == 0)
								{
									byte[] array = new byte[num - 6];
									System.Buffer.BlockCopy(data, 4, array, 0, array.Length);
									ClassDllImport.Decrypta(array, array.Length);
									System.Buffer.BlockCopy(array, 0, data, 4, array.Length);
								}
								Player.ManagePacket(data, data.Length);
							}
							else
							{
								byte[] array2 = new byte[data.Length + 1];
								for (int i = 0; i < data.Length; i++)
								{
									if (i >= 4)
									{
										array2[i + 1] = data[i];
									}
									else
									{
										array2[i] = data[i];
									}
								}
								string text = Converter.ToString(data);
								string txtt = Converter.ToString(array2);
								Form1.WriteLine(7, txtt);
								Player.ManagePacket(array2, array2.Length);
							}
						}
						if (170 != Buffer.m_Buffer[0] && 85 != Buffer.m_Buffer[1])
						{
							Buffer.Clear();
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "HandleReceive()出错" + WorldId + "|" + ToString() + " " + ex);
				Dispose(flush: false);
			}
		}

		private void Dispose(bool flush)
		{
			int num = 0;
			try
			{
				if (World.JlMsg == 1)
				{
					Form1.WriteLine(0, "Dispose()");
				}
				if (FLD_Offline)
				{
					FLD_Offline = false;
					Form1.WriteLine(3, "Func Off-Hook: [" + Player.Userid + "] - [" + Player.UserName + "] - OFF");
				}
				num = 1;
				退出 = true;
				if (!World.MDisposed.Contains(this))
				{
					num = 2;
					m_Running = false;
					Form1.WriteLine(3, WorldId + " disconnect - IP: " + ToString());
					num = 3;
					if (m_SendQueue != null)
					{
						if (!m_SendQueue.IsEmpty)
						{
							using (new Lock(m_SendQueue, "Dispose()"))
							{
								m_SendQueue.Clear();
							}
						}
						m_SendQueue.Dispose();
						m_SendQueue = null;
					}
					num = 4;
					if (m_Buffer != null)
					{
						m_Buffer.Dispose();
						m_Buffer = null;
					}
					num = 5;
					if (m_Socket != null)
					{
						try
						{
							m_Socket.Shutdown(SocketShutdown.Both);
						}
						catch (Exception value)
						{
							Console.WriteLine(value);
						}
						try
						{
							m_Socket.Close();
						}
						catch (Exception value2)
						{
							Console.WriteLine(value2);
						}
						m_Socket = null;
					}
					num = 6;
					if (m_RecvBuffer != null)
					{
						m_ReceiveBufferPool.ReleaseBuffer(m_RecvBuffer);
					}
					m_RecvBuffer = null;
					m_OnReceive = null;
					m_OnSend = null;
					m_Running = false;
					BuffPool = null;
					if (自动断开 != null)
					{
						自动断开.Enabled = false;
						自动断开.Close();
						自动断开.Dispose();
					}
					num = 7;
					World.MDisposed.Enqueue(this);
					if (World.Iplist.ContainsKey(WorldId))
					{
						try
						{
							World.Iplist.RemoveSafe(WorldId);
						}
						catch (Exception ex)
						{
							Form1.WriteLine(1, "移除玩家多开列表项出错" + WorldId + "|" + ToString() + " " + ex.Message);
						}
					}
				}
			}
			catch (Exception ex2)
			{
				Form1.WriteLine(1, " Dispose(bool flush)出错" + WorldId + "|" + ToString() + " [" + num + "]" + ex2.Message);
			}
		}

		private void Dispose_(bool flush)
		{
			try
			{
				if (m_Socket != null && !退出)
				{
					if (World.JlMsg == 1)
					{
						Form1.WriteLine(0, "Dispose()");
					}
					退出 = true;
					if (!World.MDisposed.Contains(this))
					{
						m_Running = false;
						Form1.WriteLine(3, "[" + WorldId + "] IP [" + ToString() + "]");
						if (m_SendQueue != null)
						{
							if (!m_SendQueue.IsEmpty)
							{
								using (new Lock(m_SendQueue, "Dispose()"))
								{
									m_SendQueue.Clear();
								}
							}
							m_SendQueue.Dispose();
							m_SendQueue = null;
						}
						if (m_Buffer != null)
						{
							m_Buffer.Dispose();
							m_Buffer = null;
						}
						if (m_Socket != null)
						{
							try
							{
								m_Socket.Shutdown(SocketShutdown.Both);
							}
							catch (Exception ex)
							{
								Exception value = ex;
								Console.WriteLine(value);
							}
							try
							{
								m_Socket.Close();
							}
							catch (Exception value2)
							{
								Console.WriteLine(value2);
							}
							m_Socket = null;
						}
						if (m_RecvBuffer != null)
						{
							m_ReceiveBufferPool.ReleaseBuffer(m_RecvBuffer);
						}
						m_RecvBuffer = null;
						m_OnReceive = null;
						m_OnSend = null;
						m_Running = false;
						BuffPool = null;
						if (自动断开 != null)
						{
							自动断开.Enabled = false;
							自动断开.Close();
							自动断开.Dispose();
						}
						World.MDisposed.Enqueue(this);
						if (World.Iplist.ContainsKey(WorldId))
						{
							try
							{
								Form1.WriteLine(1, "Ngat ket noi tat ca");
								World.Iplist.RemoveSafe(WorldId);
							}
							catch (Exception ex2)
							{
								Form1.WriteLine(1, "移除玩家多开列表项出错" + WorldId + "|" + ToString() + " " + ex2.Message);
							}
						}
					}
				}
			}
			catch (Exception ex2)
			{
				Exception value = ex2;
				Form1.WriteLine(1, " Dispose(bool flush)出错" + WorldId + "|" + ToString() + " " + value.Message);
			}
		}

		private void Decrypta(ref byte[] data)
		{
			byte b = 0;
			byte b2 = 0;
			for (int i = 0; i < data.Length - 6; i++)
			{
				b2 = data[4 + i];
				data[4 + i] = (byte)(data[4 + i] ^ g_cur_key[i % 8] ^ b);
				b = b2;
			}
		}

		private void OnReceive(IAsyncResult A_0)
		{
			if (World.JlMsg == 1)
			{
			}
			Socket socket = (Socket)A_0.AsyncState;
			try
			{
				int num = 0;
				try
				{
					num = socket.EndReceive(A_0);
				}
				catch (ArgumentNullException ex)
				{
					Form1.WriteLine(1, "OnReceive()1出错" + WorldId + "|" + ToString() + " " + ex.Message);
					Dispose(flush: false);
				}
				catch (ArgumentException ex2)
				{
					Form1.WriteLine(1, "OnReceive()2出错" + WorldId + "|" + ToString() + " " + ex2.Message);
					Dispose(flush: false);
				}
				catch (InvalidOperationException)
				{
					Dispose(flush: false);
				}
				catch (SocketException)
				{
					Dispose(flush: false);
				}
				catch (Exception ex5)
				{
					Form1.WriteLine(1, "OnReceive()5出错" + WorldId + "|" + ToString() + " " + ex5.Message);
					Dispose(flush: false);
				}
				if (num > 0 && num < World.SizeDdos)
				{
					World.接收速度 += num;
					byte[] recvBuffer = m_RecvBuffer;
					using (new Lock(m_Buffer, "this.m_Buffer"))
					{
						m_Buffer.Enqueue(recvBuffer, 0, num);
					}
					HandleReceive(this);
					if (!退出)
					{
						m_AsyncState &= ~AsyncState.Pending;
						if ((m_AsyncState & AsyncState.Paused) == (AsyncState)0)
						{
							try
							{
								byte[] array = new byte[Marshal.SizeOf((object)0) * 3];
								BitConverter.GetBytes(1u).CopyTo(array, 0);
								BitConverter.GetBytes(20000u).CopyTo(array, Marshal.SizeOf((object)0));
								BitConverter.GetBytes(20000u).CopyTo(array, Marshal.SizeOf((object)0) * 2);
								InternalBeginReceive(array);
							}
							catch (Exception)
							{
								Dispose(flush: false);
							}
						}
					}
				}
				else
				{
					if (num > World.SizeDdos)
					{
						Form1.WriteLine(0, "Ddos - size: " + num);
					}
					Dispose(flush: false);
				}
			}
			catch (Exception ex7)
			{
				Form1.WriteLine(1, "OnReceive()6出错" + WorldId + "|" + ToString() + " " + ex7);
				Dispose(flush: false);
			}
		}

		private static void ThreadProca(object A_0)
		{
			if (World.JlMsg == 1)
			{
			}
			SafeFileHandle safeFileHandle = (SafeFileHandle)A_0;
			while (true)
			{
				if (World.JlMsg == 1)
				{
				}
				GetQueuedCompletionStatus(safeFileHandle, out uint lpNumberOfBytesTransferred, out IntPtr _, out IntPtr lpOverlapped, uint.MaxValue);
				GCHandle gCHandle;
				if (lpNumberOfBytesTransferred != 0)
				{
					if (lpOverlapped == IntPtr.Zero)
					{
						break;
					}
					gCHandle = GCHandle.FromIntPtr(lpOverlapped);
					IO_Net_DATA iO_Net_DATA = (IO_Net_DATA)gCHandle.Target;
					try
					{
						if (iO_Net_DATA.NetStat.m_Socket == null)
						{
							gCHandle.Free();
						}
						else if (!iO_Net_DATA.NetStat.m_Running)
						{
							gCHandle.Free();
						}
						else if (iO_Net_DATA.NetStat.BuffPool == null)
						{
							gCHandle.Free();
						}
						else
						{
							if (iO_Net_DATA.NetStat.BuffPool.Count > 0)
							{
								int num = 0;
								MemoryStream memoryStream = new MemoryStream();
								while (num < 21 && iO_Net_DATA.NetStat.BuffPool.Count > 0)
								{
									if (World.JlMsg == 1)
									{
									}
									if (iO_Net_DATA.NetStat.m_Socket == null)
									{
										gCHandle.Free();
									}
									else if (!iO_Net_DATA.NetStat.m_Running)
									{
										gCHandle.Free();
									}
									else
									{
										num++;
										byte[] array = (byte[])iO_Net_DATA.NetStat.BuffPool.Dequeue();
										memoryStream.Write(array, 0, array.Length);
									}
								}
								if (num > 0)
								{
									try
									{
										byte[] buffer = memoryStream.GetBuffer();
										iO_Net_DATA.NetStat.Send多包加密(buffer, buffer.Length, num);
									}
									catch (Exception ex)
									{
										Form1.WriteLine(1, "Send()_OnMessage多包2" + iO_Net_DATA.NetStat.WorldId + "|" + ex.Message);
									}
								}
								goto IL_02af;
							}
							gCHandle.Free();
						}
					}
					catch (Exception ex2)
					{
						Form1.WriteLine(1, "Send()_OnMessage多包2_2" + iO_Net_DATA.NetStat.WorldId + "|" + ex2.Message);
						goto IL_02af;
					}
				}
				continue;
				IL_02af:
				gCHandle.Free();
			}
			safeFileHandle.Dispose();
		}

		private void InternalBeginReceive(byte[] A_0)
		{
			try
			{
				if (World.JlMsg == 1)
				{
				}
				m_AsyncState |= AsyncState.Pending;
				m_Socket.IOControl(IOControlCode.KeepAliveValues, A_0, null);
				m_Socket.BeginReceive(m_RecvBuffer, 0, m_RecvBuffer.Length, SocketFlags.None, m_OnReceive, m_Socket);
			}
			catch (Exception)
			{
				Dispose(flush: false);
			}
		}

		private void 自动断开事件(object sender, ElapsedEventArgs e)
		{
			if (!版本验证)
			{
				Form1.WriteLine(1, WorldId + " connect timeout - IP: " + ToString());
				Dispose(flush: false);
			}
			if (自动断开 != null)
			{
				自动断开.Enabled = false;
				自动断开.Close();
				自动断开.Dispose();
			}
		}

		private void ProcessDataReceived(byte[] A_0, int A_1)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "ProcessDataReceived");
			}
			try
			{
				int num = 0;
				if (170 == A_0[0] && 85 == A_0[1])
				{
					byte[] array = new byte[2];
					System.Buffer.BlockCopy(A_0, 2, array, 0, 2);
					int num2 = BitConverter.ToInt16(array, 0);
					while (true)
					{
						if (World.JlMsg == 1)
						{
							Form1.WriteLine(0, "ProcessDataReceived");
						}
						byte[] array2 = new byte[num2 + 6];
						if (num + num2 + 6 > A_1)
						{
							break;
						}
						System.Buffer.BlockCopy(A_0, num, array2, 0, num2 + 6);
						num += num2 + 6;
						if (World.Log == 1)
						{
							string txtt = Converter.ToString(array2);
							Form1.WriteLine(7, txtt);
						}
						if (array2[array2.Length - 2] != 85 || array2[array2.Length - 1] != 170)
						{
							break;
						}
						Player.ManagePacket(array2, array2.Length);
						if (num >= A_1 || A_0[num] != 170 || A_0[num + 1] != 85)
						{
							break;
						}
						System.Buffer.BlockCopy(A_0, num + 2, array, 0, 2);
						num2 = BitConverter.ToInt16(array, 0);
					}
				}
			}
			catch (Exception ex)
			{
				byte[] array3 = new byte[A_1];
				System.Buffer.BlockCopy(A_0, 0, array3, 0, A_1);
				string text = Converter.ToString(array3);
				Form1.WriteLine(1, "ProcessDataReceived()出错" + WorldId + "|" + ToString() + " " + text + "  " + ex.ToString());
				Dispose(flush: false);
			}
		}

		private void Send多包封装发送(byte[] A_0, int A_1, int A_2)
		{
			byte[] array = new byte[A_1 + 17];
			array[0] = 170;
			array[1] = 85;
			System.Buffer.BlockCopy(BitConverter.GetBytes(A_1 + 11), 0, array, 2, 2);
			System.Buffer.BlockCopy(BitConverter.GetBytes(A_2), 0, array, 5, 2);
			System.Buffer.BlockCopy(A_0, 0, array, 7, A_1);
			array[array.Length - 2] = 85;
			array[array.Length - 1] = 170;
			string text = Converter.ToString(array);
			Send(array, array.Length);
		}

		private byte[] SendDuopak(byte[] toSendBuff, int length, out int outlength)
		{
			try
			{
				int num = 10;
				int num2 = length / num;
				while (length - num2 * num > 0 && length - num2 * num < 2)
				{
					num++;
					num2 = length / num;
				}
				if (length % num > 0)
				{
					num2++;
				}
				byte[] array = new byte[length + num2];
				int num3 = 0;
				int num4 = 0;
				int num5 = num;
				do
				{
					if (num3 + num5 >= length)
					{
						num5 = length - num3;
						array[num4] = (byte)(num5 - 1);
						System.Buffer.BlockCopy(toSendBuff, num3, array, num4 + 1, num5);
						num3 += num5;
						num4 += num5 + 1;
					}
					else
					{
						array[num4] = (byte)(num5 - 1);
						System.Buffer.BlockCopy(toSendBuff, num3, array, num4 + 1, num5);
						num3 += num5;
						num4 += num5 + 1;
						num5 = num;
					}
				}
				while (num3 < length);
				outlength = num4;
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "Send()SendDuopak" + WorldId + "|" + ex.Message);
				outlength = length;
				return toSendBuff;
			}
		}

		private int SendDuopak3(byte[] A_0, int A_1, out byte[] A_2)
		{
			A_2 = new byte[A_1 + A_1 / 32 + 1];
			int A_3 = 0;
			int A_4 = 0;
			int i = 6;
			int num = 5;
			int j = 0;
			int num2 = 0;
			int num3 = 0;
			try
			{
				for (; i <= A_1; i++)
				{
					while (num > 1 && i - num < 255)
					{
						for (; j < 255 && num + j < A_1 && i + j < A_1; j++)
						{
							if (A_0[i + j] != A_0[num + j])
							{
								if (num2 >= 3)
								{
									if (A_0[i] == A_0[num - 1] && i - num < 254)
									{
										num3 = 1;
									}
									else
									{
										OneByte(i, num, j, num2, A_0, ref A_4, ref A_3, ref A_2);
										i = A_4;
										num = A_4;
										num3 = 0;
										num2 = 0;
									}
								}
								else
								{
									num2 = 0;
								}
								break;
							}
							num2++;
						}
						if (num2 >= 3 && (A_0[i] != A_0[num - 1] || num3 == 0))
						{
							OneByte(i, num, j, num2, A_0, ref A_4, ref A_3, ref A_2);
							i = A_4;
							num = A_4;
							num3 = 0;
						}
						j = 0;
						num2 = 0;
						num--;
					}
					num = i;
				}
				if (A_4 >= A_1)
				{
					return A_3;
				}
				int num4 = A_1 - A_4;
				if (num4 > 32)
				{
					int outlength = 0;
					byte[] array = new byte[num4];
					System.Buffer.BlockCopy(A_0, A_4, array, 0, array.Length);
					byte[] array2 = SendDuopak(array, array.Length, out outlength);
					if (A_3 == 0)
					{
						A_2 = new byte[array2.Length];
					}
					System.Buffer.BlockCopy(array2, 0, A_2, A_3, outlength);
					A_3 += outlength;
					A_4 += num4;
					return A_3;
				}
				if (num4 > 0)
				{
					A_2[A_3++] = (byte)(A_1 - A_4 - 1);
					System.Buffer.BlockCopy(A_0, A_4, A_2, A_3, A_1 - A_4);
					A_3 += A_1 - A_4;
					A_4 += A_1 - A_4;
				}
			}
			catch (Exception value)
			{
				Console.WriteLine(value);
			}
			return A_3;
		}

		private void OneByte(int A_0, int A_1, int A_2, int A_3, byte[] A_4, ref int A_5, ref int A_6, ref byte[] A_7)
		{
			int num = A_0 - A_5;
			if (num > 32)
			{
				int outlength = 0;
				byte[] array = new byte[num];
				System.Buffer.BlockCopy(A_4, A_5, array, 0, array.Length);
				System.Buffer.BlockCopy(SendDuopak(array, array.Length, out outlength), 0, A_7, A_6, outlength);
				A_6 += outlength;
				A_5 += num;
			}
			else if (num > 0)
			{
				A_7[A_6++] = (byte)(num - 1);
				System.Buffer.BlockCopy(A_4, A_5, A_7, A_6, A_0 - A_5);
				A_6 += A_0 - A_5;
				A_5 += A_0 - A_5;
			}
			int num2 = A_3 - 2;
			if (num2 < 7)
			{
				A_7[A_6++] = (byte)(num2 <<= 5);
				int num3 = A_0 - A_1 - 1;
				A_7[A_6++] = (byte)num3;
			}
			else
			{
				A_7[A_6++] = 224;
				int num4 = A_3 - 2 - 7;
				A_7[A_6++] = (byte)num4;
				int num5 = A_0 - A_1 - 1;
				A_7[A_6++] = (byte)num5;
			}
			A_5 += A_3;
		}

		private void OnSend(IAsyncResult asyncResult)
		{
			if (World.JlMsg == 1)
			{
			}
			Socket socket = (Socket)asyncResult.AsyncState;
			if (m_Socket == null)
			{
				Dispose(flush: false);
			}
			else
			{
				try
				{
					if (m_Socket.Connected && m_Running)
					{
						int num = socket.EndSend(asyncResult);
						World.发送速度 += num;
						if (num <= 0)
						{
							Dispose(flush: false);
						}
						else
						{
							SendQueue.Gram gram;
							using (new Lock(m_SendQueue, "OnSend"))
							{
								gram = m_SendQueue.Dequeue();
							}
							if (gram != null)
							{
								try
								{
									socket.BeginSend(gram.Buffer, 0, gram.Length, SocketFlags.None, m_OnSend, socket);
								}
								catch (Exception)
								{
									Dispose(flush: false);
								}
							}
						}
					}
				}
				catch (Exception)
				{
					Dispose(flush: false);
				}
				finally
				{
				}
			}
		}

		private void Send单包封装发送(byte[] A_0, int A_1)
		{
			byte[] array = new byte[A_1 + 15];
			array[0] = 170;
			array[1] = 85;
			System.Buffer.BlockCopy(BitConverter.GetBytes(A_1 + 9), 0, array, 2, 2);
			System.Buffer.BlockCopy(A_0, 0, array, 5, A_1);
			array[array.Length - 2] = 85;
			array[array.Length - 1] = 170;
			Send(array, array.Length);
		}

		private void Send多包加密(byte[] bytes, int length, int A_2)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "Send多包加密()");
			}
			int num = 0;
			try
			{
				num = 1;
				byte[] A_3;
				int num2 = SendDuopak3(bytes, length, out A_3);
				num = 2;
				byte[] array = new byte[num2 + 16];
				num = 3;
				System.Buffer.BlockCopy(BitConverter.GetBytes(192), 0, array, 0, 2);
				num = 4;
				System.Buffer.BlockCopy(BitConverter.GetBytes(num2 + 4), 0, array, 2, 2);
				num = 5;
				System.Buffer.BlockCopy(BitConverter.GetBytes(num2), 0, array, 4, 2);
				num = 6;
				System.Buffer.BlockCopy(BitConverter.GetBytes(length), 0, array, 6, 2);
				num = 7;
				System.Buffer.BlockCopy(A_3, 0, array, 8, num2);
				num = 8;
				Send多包封装发送(array, array.Length, A_2);
			}
			catch (Exception ex)
			{
				byte[] A_4;
				int num3 = SendDuopak3(bytes, length, out A_4);
				byte[] array2 = new byte[num3 + 16];
				Form1.WriteLine(100, "Send()_Send多包加密" + WorldId + "长度" + length + "错误地方" + num + "outlin" + num3 + "-newBuffer长度-" + array2.Length + "-Buffer长度-" + A_4.Length + "异常" + ex.Message);
			}
		}

		private byte[] SendDuopak2(byte[] A_0, int A_1, out int A_2)
		{
			try
			{
				byte[] array = new byte[A_1 + A_1 / 32 + 1];
				A_2 = 0;
				int num = 0;
				int num2 = 10;
				int num3 = 0;
				bool flag = false;
				for (int i = 0; i < A_0.Length; i++)
				{
					for (int j = num2; j < i; j++)
					{
						if (i - j > 255)
						{
							j = i - 255;
						}
						for (int k = 0; k < A_0.Length - i - 2 && k < A_0.Length - j - 2 && k < 255; k++)
						{
							if (A_0[j + k] != A_0[i + k])
							{
								if (flag)
								{
									if (num3 >= 3)
									{
										if (i > num)
										{
											int num4 = i - num - 1;
											if (num4 > 31)
											{
												int outlength = 0;
												byte[] array2 = new byte[num4 + 1];
												System.Buffer.BlockCopy(A_0, num, array2, 0, array2.Length);
												System.Buffer.BlockCopy(SendDuopak(array2, array2.Length, out outlength), 0, array, A_2, outlength);
												A_2 += outlength;
												num += num4 + 1;
											}
											else if (num4 >= 0)
											{
												array[A_2++] = (byte)num4;
												System.Buffer.BlockCopy(A_0, num, array, A_2, i - num);
												A_2 += i - num;
												num += i - num;
											}
										}
										int num5 = num3 - 2;
										if (num5 < 7)
										{
											array[A_2++] = (byte)(num5 <<= 5);
											int num6 = num - 1 - j;
											array[A_2++] = (byte)num6;
										}
										else
										{
											array[A_2++] = 224;
											int num7 = num3 - 2 - 7;
											array[A_2++] = (byte)num7;
											int num8 = num - j - 1;
											array[A_2++] = (byte)num8;
										}
										num += num3;
										num2 = i / 2;
										if (num2 > 255)
										{
											num2 = i - 255;
										}
										i = num;
										num3 = 0;
									}
									else
									{
										num3 = 0;
									}
								}
								else if (num3 >= 3)
								{
									int num9 = i - num - 1;
									if (num9 > 31)
									{
										int outlength2 = 0;
										byte[] array3 = new byte[num9 + 1];
										System.Buffer.BlockCopy(A_0, num, array3, 0, array3.Length);
										System.Buffer.BlockCopy(SendDuopak(array3, array3.Length, out outlength2), 0, array, A_2, outlength2);
										A_2 += outlength2;
										num += num9 + 1;
									}
									else if (num9 >= 0)
									{
										array[A_2++] = (byte)(i - num - 1);
										System.Buffer.BlockCopy(A_0, num, array, A_2, i - num);
										A_2 += i - num;
										num += i - num;
									}
									int num10 = num3 - 2;
									if (num10 < 7)
									{
										array[A_2++] = (byte)(num10 <<= 5);
										int num11 = num - 1 - j;
										array[A_2++] = (byte)num11;
									}
									else
									{
										array[A_2++] = 224;
										int num12 = num3 - 2 - 7;
										array[A_2++] = (byte)num12;
										int num13 = num - j - 1;
										array[A_2++] = (byte)num13;
									}
									num += num3;
									num2 = i / 2;
									i = num;
									flag = true;
									num3 = 0;
								}
								else
								{
									num3 = 0;
								}
								break;
							}
							num3++;
						}
						if (num3 > 3)
						{
							if (i - num > 0)
							{
								array[A_2++] = (byte)(i - num - 1);
								System.Buffer.BlockCopy(A_0, num, array, A_2, i - num);
								A_2 += i - num;
								num += i - num;
							}
							int num14 = num3 - 2;
							if (num14 < 7)
							{
								array[A_2++] = (byte)(num14 <<= 5);
								int num15 = i - 1 - j;
								array[A_2++] = (byte)num15;
							}
							else
							{
								array[A_2++] = 224;
								int num16 = num3 - 2 - 7;
								array[A_2++] = (byte)num16;
								int num17 = num - j - 1;
								array[A_2++] = (byte)num17;
							}
							num += num3;
							num2 = i;
							i = num;
							num3 = 0;
						}
						else
						{
							num3 = 0;
						}
					}
				}
				if (num <= A_1 - 2)
				{
					array[A_2++] = (byte)(A_1 - num - 1);
					System.Buffer.BlockCopy(A_0, num, array, A_2, A_1 - num);
					A_2 += A_1 - num;
					num += A_1 - num;
				}
				else
				{
					array[A_2++] = 1;
					array[A_2++] = 0;
					array[A_2++] = 0;
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "Send()SendDuopak2" + WorldId + "|" + ex.Message);
				A_2 = A_1;
				return A_0;
			}
		}

		~NetState()
		{
		}

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetQueuedCompletionStatus(SafeFileHandle CompletionPort, out uint lpNumberOfBytesTransferred, out IntPtr lpCompletionKey, out IntPtr lpOverlapped, uint dwMilliseconds);

		public static string GetRegistData(string lj, string name)
		{
			try
			{
				return Registry.LocalMachine.OpenSubKey(lj, writable: true).GetValue(name).ToString();
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

		public void IDout()
		{
			try
			{
				if (World.JlMsg == 1)
				{
				}
				if (Player != null)
				{
					World.Conn.发送("用户登出|" + Player.Userid + "|" + World.服务器id);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "IDout()出错" + WorldId + "|" + ToString() + " " + ex.Message);
			}
		}

		private static void old_acctor_mc()
		{
			m_ReceiveBufferPool = new BufferPool("Receive", 2048, 2048);
		}

		[DllImport("Kernel32", CharSet = CharSet.Auto)]
		private static extern bool PostQueuedCompletionStatus(SafeFileHandle A_0, uint A_1, IntPtr A_2, IntPtr A_3);

		public void Send(byte[] toSendBufff, int len)
		{
			try
			{
				if (World.JlMsg == 1)
				{
				}
				if (m_Socket != null && m_Running && m_Socket.Connected)
				{
					try
					{
						byte[] array;
						if (World.是否加密 == 0)
						{
							array = new byte[toSendBufff.Length - 1];
							for (int i = 0; i < toSendBufff.Length; i++)
							{
								if (i > 4)
								{
									array[i - 1] = toSendBufff[i];
								}
								else if (i < 4)
								{
									array[i] = toSendBufff[i];
								}
							}
							len--;
						}
						else
						{
							array = toSendBufff;
						}
						int num = BitConverter.ToInt16(array, 7);
						if (World.Debug != 0)
						{
							Form1.WriteLine(44, "Sent [" + num.ToString("X4") + " - " + num + "] " + WorldId + " : " + Converter.ToString(array));
						}
						SendQueue.Gram gram;
						using (new Lock(m_SendQueue, "Send"))
						{
							gram = m_SendQueue.Enqueue(array, len);
						}
						if (gram != null)
						{
							try
							{
								m_Socket.BeginSend(gram.Buffer, 0, gram.Length, SocketFlags.None, m_OnSend, m_Socket);
							}
							catch (Exception)
							{
								Dispose(flush: false);
							}
						}
					}
					catch (CapacityExceededException)
					{
						Form1.WriteLine(1, "Send()_数据列队以满" + WorldId + "|" + ToString());
						Dispose(flush: false);
					}
				}
			}
			catch (StackOverflowException)
			{
				Form1.WriteLine(1, "Send()_StackOverflowException出错" + WorldId + "|" + ToString());
				Dispose(flush: false);
			}
			catch (SocketException)
			{
				Form1.WriteLine(1, "Send()_SocketException出错" + WorldId + "|" + ToString());
				Dispose(flush: false);
			}
			catch (Exception)
			{
				Form1.WriteLine(1, "Send()_Exception出错" + WorldId + "|" + ToString());
				Dispose(flush: false);
			}
		}

		public void SendMsg(byte[] toSendBuff, int len)
		{
			try
			{
				if (m_Socket != null)
				{
					SendQueue.Gram gram;
					lock (m_SendQueue)
					{
						gram = m_SendQueue.Enqueue(toSendBuff, len);
					}
					if (gram != null)
					{
						try
						{
							m_Socket.BeginSend(gram.Buffer, 0, gram.Length, SocketFlags.None, m_OnSend, m_Socket);
						}
						catch (Exception)
						{
							Dispose();
						}
					}
				}
			}
			catch (StackOverflowException ex2)
			{
				Form1.WriteLine(1, "Send()_StackOverflowException出错" + WorldId + "|" + ToString() + " " + ex2.Message);
				Dispose();
			}
			catch (SocketException ex3)
			{
				Form1.WriteLine(1, "Send()_SocketException出错" + WorldId + "|" + ToString() + " " + ex3.Message);
				Dispose();
			}
			catch (Exception ex4)
			{
				Form1.WriteLine(1, "Send()_Exception出错" + WorldId + "|" + ToString() + " " + ex4.Message);
				Dispose();
			}
		}

		public void SendPak(PacketData pak, int id, int wordid)
		{
			try
			{
				byte[] array = pak.ToArray2(id, wordid);
				if (array.Length == 46 && id != 27136)
				{
				}
				Send多包加密(array, array.Length, 1);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "Send()_Send多包知道错误" + WorldId + "主循环" + id + "|" + ex.Message);
			}
		}

		public void SendPak(PacketData pak, int id, int wordid, byte byte_4)
		{
			try
			{
				byte[] array = pak.ToPacket(id, wordid, byte_4);
				Send多包(array, array.Length);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "Send()_Send多包知道错误" + WorldId + "主循环" + (string)(object)id + "|" + ex.Message);
			}
		}

		public void SendPak2(PacketData pak, int id, int wordid)
		{
			try
			{
				byte[] array = pak.ToArray2(id, wordid);
				if (array[0] != 170)
				{
					byte[] array2 = new byte[array.Length + 15];
					array2[0] = 170;
					array2[1] = 85;
					System.Buffer.BlockCopy(BitConverter.GetBytes(array.Length + 9), 0, array2, 2, 2);
					System.Buffer.BlockCopy(array, 0, array2, 5, array.Length);
					array2[array2.Length - 2] = 85;
					array2[array2.Length - 1] = 170;
					Send单包(array2, array2.Length);
				}
				else
				{
					Send单包(array, array.Length);
				}
			}
			catch (Exception)
			{
			}
		}

		public void SendTo(byte[] toSendBuff, int len)
		{
			try
			{
				if (World.JlMsg == 1)
				{
				}
				if (m_Socket != null && m_Running && m_Socket.Connected)
				{
					try
					{
						SendQueue.Gram gram;
						using (new Lock(m_SendQueue, "Send"))
						{
							gram = m_SendQueue.Enqueue(toSendBuff, len);
						}
						if (gram != null)
						{
							try
							{
								m_Socket.BeginSend(gram.Buffer, 0, gram.Length, SocketFlags.None, m_OnSend, m_Socket);
							}
							catch (Exception)
							{
								Dispose(flush: false);
							}
						}
					}
					catch (CapacityExceededException)
					{
						Form1.WriteLine(1, "Send()_数据列队以满" + WorldId + "|" + ToString());
						Dispose(flush: false);
					}
				}
			}
			catch (StackOverflowException)
			{
				Dispose(flush: false);
			}
			catch (SocketException)
			{
				Dispose(flush: false);
			}
			catch (Exception)
			{
				Dispose(flush: false);
			}
		}

		public void Send单包(byte[] toSendBuff, int len)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "Send单包()");
			}
			if (m_Socket != null && m_Running && m_Socket.Connected)
			{
				byte[] array = new byte[BitConverter.ToInt16(toSendBuff, 9) + 7];
				System.Buffer.BlockCopy(toSendBuff, 5, array, 0, array.Length);
				Send单包封装发送(array, array.Length);
			}
		}

		public void Send多包(byte[] toSendBuff, int len)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "Send多包()");
			}
			if (m_Socket != null && m_Running)
			{
				int num = 0;
				try
				{
					num = 1;
					byte[] array = new byte[BitConverter.ToInt16(toSendBuff, 9) + 6];
					num = 2;
					System.Buffer.BlockCopy(toSendBuff, 5, array, 0, array.Length);
					Send多包加密(array, array.Length, 1);
				}
				catch (Exception ex)
				{
					string text = Converter.ToString(toSendBuff);
					Form1.WriteLine(1, "Send()_Send多包" + WorldId + "|" + ex.Message + "错误地方" + num + "封包" + text);
				}
			}
		}

		public void Send多包11(byte[] toSendBuff, int len)
		{
			if (m_Socket != null && m_Running && m_Socket.Connected)
			{
				IO_Net_DATA iO_Net_DATA = new IO_Net_DATA();
				GCHandle.Alloc(iO_Net_DATA);
				iO_Net_DATA.NetStat = this;
				try
				{
					byte[] array = new byte[BitConverter.ToInt16(toSendBuff, 9) + 6];
					System.Buffer.BlockCopy(toSendBuff, 5, array, 0, array.Length);
					BuffPool.Enqueue(array);
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "Send()_Send多包" + WorldId + "|" + ex.Message);
				}
			}
		}

		public void Start()
		{
			m_OnReceive = OnReceive;
			m_OnSend = OnSend;
			m_Running = true;
			if (m_Socket == null)
			{
				Dispose(flush: false);
			}
			else
			{
				try
				{
					if ((m_AsyncState & (AsyncState.Paused | AsyncState.Pending)) == (AsyncState)0)
					{
						byte[] array = new byte[Marshal.SizeOf((object)0) * 3];
						BitConverter.GetBytes(1u).CopyTo(array, 0);
						BitConverter.GetBytes(20000u).CopyTo(array, Marshal.SizeOf((object)0));
						BitConverter.GetBytes(20000u).CopyTo(array, Marshal.SizeOf((object)0) * 2);
						m_Socket.UseOnlyOverlappedIO = true;
						InternalBeginReceive(array);
					}
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "Start()出错" + WorldId + "|" + ToString() + " " + ex.Message);
					Dispose(flush: false);
				}
			}
		}

		public override string ToString()
		{
			return m_ToString;
		}

		public static string WTRegedit(string luj, string name, string tovalue)
		{
			try
			{
				Registry.LocalMachine.OpenSubKey(luj, writable: true).SetValue(name, tovalue);
				return "修改成功";
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}

		public void 发送(string msg)
		{
			try
			{
				byte[] bytes = Encoding.GetEncoding(1252).GetBytes(msg);
				SendTo(bytes, bytes.Length);
			}
			catch (Exception)
			{
			}
		}

		public void 离线挂机()
		{
			if (m_Socket != null)
			{
				try
				{
					m_Socket.Shutdown(SocketShutdown.Both);
				}
				catch (Exception value)
				{
					Console.WriteLine(value);
				}
				try
				{
					m_Socket.Close();
				}
				catch (Exception value2)
				{
					Console.WriteLine(value2);
				}
				m_Socket = null;
				退出 = true;
				FLD_Offline = true;
			}
		}
	}
}

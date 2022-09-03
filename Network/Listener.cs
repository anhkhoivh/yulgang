using RxjhServer;
using RxjhServer.RxjhServer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace Network
{
	public class Listener
	{
		private Socket m_Listener;

		private object m_AcceptedSyncRoot;

		private Queue<Socket> m_Accepted = new Queue<Socket>();

		private bool m_Disposed = false;

		public Listener(int port)
		{
			m_AcceptedSyncRoot = ((ICollection)m_Accepted).SyncRoot;
			a(IPAddress.Any, port);
		}

		private void a(IPAddress A_0, int A_1)
		{
			IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
			IPEndPoint localEP = new IPEndPoint(A_0, A_1);
			m_Listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			try
			{
				m_Listener.UseOnlyOverlappedIO = true;
				m_Listener.LingerState.Enabled = false;
				m_Listener.ExclusiveAddressUse = false;
				m_Listener.Bind(localEP);
				m_Listener.Listen(10);
				World.主Socket = true;
				using (SocketAsyncEventArgs socketAsyncEventArgs = new SocketAsyncEventArgs())
				{
					socketAsyncEventArgs.UserToken = this;
					socketAsyncEventArgs.Completed += eval_a;
					m_Listener.AcceptAsync(socketAsyncEventArgs);
				}
				World.游戏服务器端口2 = A_1;
				Form1.WriteLine(1, "开始监听端口 " + A_1 + " IP " + addressList[0].ToString());
				if (World.Conn != null)
				{
					World.Conn.发送("更新服务器端口|" + World.服务器id + "|" + A_1);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "开始监听端口 出错 " + A_1 + " IP " + addressList[0].ToString() + " " + ex.Message);
				Console.WriteLine("Listener bind exception:");
				Console.WriteLine(ex);
				try
				{
					m_Listener.Shutdown(SocketShutdown.Both);
				}
				catch
				{
				}
				try
				{
					m_Listener.Close();
				}
				catch
				{
				}
				int num = new Random(World.GetRandomSeed()).Next(10, 100);
				a(IPAddress.Any, A_1 + num);
			}
		}

		public void Dispose()
		{
			try
			{
				World.主Socket = false;
				Form1.WriteLine(1, "关闭监听端口");
				if (!m_Disposed)
				{
					m_Disposed = true;
					if (m_Listener != null)
					{
						try
						{
							m_Listener.Shutdown(SocketShutdown.Both);
						}
						catch
						{
						}
						try
						{
							m_Listener.Close();
						}
						catch
						{
						}
						m_Listener = null;
					}
				}
			}
			catch
			{
			}
		}

		private static void eval_a(object sender, SocketAsyncEventArgs e)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "AcceptAsyncComplete()");
			}
			Listener listener = e.UserToken as Listener;
			try
			{
				if (World.封ip)
				{
					IPAddress address = ((IPEndPoint)e.AcceptSocket.RemoteEndPoint).Address;
					if (World.BipList.Contains(address))
					{
						if (World.断开连接)
						{
							try
							{
								e.AcceptSocket.Shutdown(SocketShutdown.Both);
							}
							catch
							{
							}
							try
							{
								e.AcceptSocket.Close();
							}
							catch
							{
							}
						}
						if (World.关闭连接)
						{
							try
							{
								listener.Dispose();
							}
							catch
							{
							}
						}
						else
						{
							using (SocketAsyncEventArgs socketAsyncEventArgs = new SocketAsyncEventArgs())
							{
								socketAsyncEventArgs.UserToken = listener;
								socketAsyncEventArgs.Completed += eval_a;
								listener.m_Listener.AcceptAsync(socketAsyncEventArgs);
							}
						}
					}
					else
					{
						DateTime value = DateTime.Now;
						int num = 0;
						foreach (NetState value2 in World.List.Values)
						{
							if (value2.ToString() == address.ToString())
							{
								value = value2.Ljtime;
								num++;
							}
						}
						if (num > World.MaxNumberOfConnectionsToTheGameLoginPorts)
						{
							int num2 = (int)DateTime.Now.Subtract(value).TotalMilliseconds;
							if (num2 < World.游戏登陆端口最大连接时间数)
							{
								Form1.WriteLine(1, "到达IP最大连接数" + address.ToString());
								if (World.加入过滤列表 && !World.BipList.Contains(address))
								{
									World.BipList.Add(address);
								}
								try
								{
									e.AcceptSocket.Shutdown(SocketShutdown.Both);
								}
								catch
								{
								}
								try
								{
									e.AcceptSocket.Close();
								}
								catch
								{
								}
								try
								{
									Queue queue = Queue.Synchronized(new Queue());
									foreach (NetState value3 in World.List.Values)
									{
										if (value3.ToString() == address.ToString())
										{
											queue.Enqueue(value3);
										}
									}
									while (queue.Count > 0)
									{
										if (World.JlMsg == 1)
										{
											Form1.WriteLine(0, "AcceptAsyncComplete");
										}
										((NetState)queue.Dequeue()).Dispose();
									}
								}
								catch
								{
								}
							}
						}
						else if (e.AcceptSocket != null)
						{
							new NetState(e.AcceptSocket).Start();
						}
					}
				}
				else if (e.AcceptSocket != null)
				{
					new NetState(e.AcceptSocket).Start();
				}
			}
			catch (Exception)
			{
			}
			finally
			{
				try
				{
					using (SocketAsyncEventArgs socketAsyncEventArgs2 = new SocketAsyncEventArgs())
					{
						socketAsyncEventArgs2.UserToken = listener;
						socketAsyncEventArgs2.Completed += eval_a;
						listener.m_Listener.AcceptAsync(socketAsyncEventArgs2);
					}
				}
				catch (Exception)
				{
				}
			}
		}
	}
}

using RxjhServer.RxjhServer;

namespace Network
{
    using RxjhServer;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Sockets;

    public class Listener
    {
        private Socket m_Listener;
        private object m_AcceptedSyncRoot;
        private Queue<Socket> m_Accepted = new Queue<Socket>();
        private bool m_Disposed = false;

        public Listener(int port)
        {
            this.m_AcceptedSyncRoot = ((ICollection) this.m_Accepted).SyncRoot;
            this.a(IPAddress.Any, port);
        }

        private void a(IPAddress A_0, int A_1)
        {
            IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            IPEndPoint localEP = new IPEndPoint(A_0, A_1);
            this.m_Listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                this.m_Listener.UseOnlyOverlappedIO = true;
                this.m_Listener.LingerState.Enabled = false;
                this.m_Listener.ExclusiveAddressUse = false;
                this.m_Listener.Bind(localEP);
                this.m_Listener.Listen(10);
                World.主Socket = true;
                using (SocketAsyncEventArgs args = new SocketAsyncEventArgs())
                {
                    args.UserToken = this;
                    args.Completed += new EventHandler<SocketAsyncEventArgs>(Listener.eval_a);
                    this.m_Listener.AcceptAsync(args);
                }
                World.游戏服务器端口2 = A_1;
                Form1.WriteLine(1, string.Concat(new object[] { "开始监听端口 ", A_1, " IP ", addressList[0].ToString() }));
                if (World.Conn != null)
                {
                    World.Conn.发送(string.Concat(new object[] { "更新服务器端口|", World.服务器id, "|", A_1 }));
                }
            }
            catch (Exception exception)
            {
                Form1.WriteLine(1, string.Concat(new object[] { "开始监听端口 出错 ", A_1, " IP ", addressList[0].ToString(), " ", exception.Message }));
                Console.WriteLine("Listener bind exception:");
                Console.WriteLine(exception);
                try
                {
                    this.m_Listener.Shutdown(SocketShutdown.Both);
                }
                catch
                {
                }
                try
                {
                    this.m_Listener.Close();
                }
                catch
                {
                }
                int num = new Random(World.GetRandomSeed()).Next(10, 100);
                this.a(IPAddress.Any, A_1 + num);
            }
        }

        public void Dispose()
        {
            try
            {
                World.主Socket = false;
                Form1.WriteLine(1, "关闭监听端口");
                if (!this.m_Disposed)
                {
                    this.m_Disposed = true;
                    if (this.m_Listener != null)
                    {
                        try
                        {
                            this.m_Listener.Shutdown(SocketShutdown.Both);
                        }
                        catch
                        {
                        }
                        try
                        {
                            this.m_Listener.Close();
                        }
                        catch
                        {
                        }
                        this.m_Listener = null;
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
                Listener userToken = e.UserToken as Listener;
                try
                {
                    if (World.封ip)
                    {
                        IPAddress item = ((IPEndPoint)e.AcceptSocket.RemoteEndPoint).Address;
                        if (World.BipList.Contains(item))
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
                                    userToken.Dispose();
                                    return;
                                }
                                catch
                                {
                                    return;
                                }
                            }
                            using (SocketAsyncEventArgs args = new SocketAsyncEventArgs())
                            {
                                args.UserToken = userToken;
                                args.Completed += new EventHandler<SocketAsyncEventArgs>(Listener.eval_a);
                                userToken.m_Listener.AcceptAsync(args);
                            }
                        }
                        else
                        {
                            DateTime now = DateTime.Now;
                            int num = 0;
                            foreach (NetState state2 in World.List.Values)
                            {
                                if (state2.ToString() == item.ToString())
                                {
                                    now = state2.Ljtime;
                                    num++;
                                }
                            }
                            if (num > World.游戏登陆端口最大连接数)
                            {
                                int totalMilliseconds = (int)DateTime.Now.Subtract(now).TotalMilliseconds;
                                if (totalMilliseconds >= World.游戏登陆端口最大连接时间数)
                                {
                                    return;
                                }
                                Form1.WriteLine(1, "到达IP最大连接数" + item.ToString());
                                if (World.加入过滤列表 && !World.BipList.Contains(item))
                                {
                                    World.BipList.Add(item);
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
                                    System.Collections.Queue queue = System.Collections.Queue.Synchronized(new System.Collections.Queue());
                                    foreach (NetState state3 in World.List.Values)
                                    {
                                        if (state3.ToString() == item.ToString())
                                        {
                                            queue.Enqueue(state3);
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
                                    return;
                                }
                                catch
                                {
                                    return;
                                }
                            }
                            if (e.AcceptSocket != null)
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
                        using (SocketAsyncEventArgs args2 = new SocketAsyncEventArgs())
                        {
                            args2.UserToken = userToken;
                            args2.Completed += new EventHandler<SocketAsyncEventArgs>(Listener.eval_a);
                            userToken.m_Listener.AcceptAsync(args2);
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
        }
    }
}


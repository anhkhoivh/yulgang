using bbg;

namespace bbg
{
    using RxjhServer;
    using System;
    using System.Collections;
    using System.Net;
    using System.Net.Sockets;
    using System.Threading;

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
                MessageeDelegaterE re2;
                MessageeDelegaterE re = this.eval_d;
                do
                {
                    re2 = re;
                    MessageeDelegaterE re3 = (MessageeDelegaterE) Delegate.Combine(re2, value);
                    re = Interlocked.CompareExchange<MessageeDelegaterE>(ref this.eval_d, re3, re2);
                }
                while (re != re2);
            }
            remove
            {
                MessageeDelegaterE re2;
                MessageeDelegaterE re = this.eval_d;
                do
                {
                    re2 = re;
                    MessageeDelegaterE re3 = (MessageeDelegaterE) Delegate.Remove(re2, value);
                    re = Interlocked.CompareExchange<MessageeDelegaterE>(ref this.eval_d, re3, re2);
                }
                while (re != re2);
            }
        }

        static AuthServer()
        {
            old_acctor_mc();
        }

        public AuthServer(string i, int pt)
        {
            this.ip = i;
            this.port = pt;
            this.Start();
        }

        public void CloseServer()
        {
            this.listenSocket.Close();
        }

        public void Dispose()
        {
            while (clients.Count > 0)
            {
                ((SockClienT) clients[0]).Dispose();
            }
            try
            {
                this.listenSocket.Shutdown(SocketShutdown.Both);
            }
            catch
            {
            }
            if (this.listenSocket != null)
            {
                this.listenSocket.Close();
            }
        }

        private void eval_a(object A_0, SockClienT A_1)
        {
            if (this.eval_d != null)
            {
                this.eval_d(A_0, A_1);
            }
        }

        private void eval_b(object A_0, SockClienT A_1)
        {
            this.eval_a(A_0, A_1);
        }

        private static void old_acctor_mc()
        {
            clients = new ArrayList();
        }

        public virtual void OnAccept(IAsyncResult ar)
        {
            try
            {
                Socket sock = this.listenSocket.EndAccept(ar);
                if (sock != null)
                {
                    ClientConnection connection = new ClientConnection(sock, new RemoveClientDelegateE(this.RemoveClient));
                    clients.Add(connection);
                    connection.OnSockMessage += new MessageeDelegaterE(this.eval_b);
                    connection.Start();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("{0}", exception);
            }
            try
            {
                this.listenSocket.BeginAccept(new AsyncCallback(this.OnAccept), this.listenSocket);
            }
            catch
            {
                this.Dispose();
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
            bool flag;
            try
            {
                this.listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                this.listenSocket.Bind(new IPEndPoint(IPAddress.Any, this.port));
                Form1.WriteLine(1, string.Concat(new object[] { "开始监听百宝端口 ", this.port, " IP ", this.ip.ToString() }));
                this.listenSocket.Listen(10);
                this.listenSocket.BeginAccept(new AsyncCallback(this.OnAccept), this.listenSocket);
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Failled to list on port {0}\n{1}", this.port, exception.Message);
                Form1.WriteLine(1, string.Concat(new object[] { "监听百宝端口出错 ", this.port, "   ", exception.Message }));
                this.listenSocket = null;
                flag = false;
            }
            return flag;
        }
    }
}


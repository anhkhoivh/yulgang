using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using HelperTools;
using RxjhServer;

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

        public event MessageeDelegaterE OnSockMessage
        {
            add
            {
                MessageeDelegaterE re2;
                MessageeDelegaterE re = this.eval_e;
                do
                {
                    re2 = re;
                    MessageeDelegaterE re3 = (MessageeDelegaterE) Delegate.Combine(re2, value);
                    re = Interlocked.CompareExchange<MessageeDelegaterE>(ref this.eval_e, re3, re2);
                }
                while (re != re2);
            }
            remove
            {
                MessageeDelegaterE re2;
                MessageeDelegaterE re = this.eval_e;
                do
                {
                    re2 = re;
                    MessageeDelegaterE re3 = (MessageeDelegaterE) Delegate.Remove(re2, value);
                    re = Interlocked.CompareExchange<MessageeDelegaterE>(ref this.eval_e, re3, re2);
                }
                while (re != re2);
            }
        }

        public SockClienT(Socket from, RemoveClientDelegateE rftsl)
        {
            this.removeFromTheServerList = rftsl;
            this.clientSocket = from;
        }

        public void Dispose()
        {
            if (!this.disposed)
            {
                this.disposed = true;
                try
                {
                    if (this.removeFromTheServerList != null)
                    {
                        this.removeFromTheServerList(this);
                    }
                    this.clientSocket.Shutdown(SocketShutdown.Both);
                }
                catch
                {
                }
                if (this.clientSocket != null)
                {
                    this.clientSocket.Close();
                }
                this.clientSocket = null;
            }
        }

        public virtual void OnReceiveData(IAsyncResult ar)
        {
            try
            {
                if (!this.disposed)
                {
                    int length = this.clientSocket.EndReceive(ar);
                    if (length <= 0)
                    {
                        this.Dispose();
                    }
                    else
                    {
                        this.ProcessDataReceived(this.dataReceive, length);
                        this.Dispose();
                    }
                }
            }
            catch (Exception)
            {
                this.Dispose();
            }
        }

        public void OnSended(IAsyncResult ar)
        {
            try
            {
                if (!this.disposed)
                {
                    this.clientSocket.EndSend(ar);
                    this.clientSocket.BeginReceive((ar.AsyncState as SockClienT).dataReceive, 0, (ar.AsyncState as SockClienT).dataReceive.Length, SocketFlags.None, new AsyncCallback(this.OnReceiveData), ar.AsyncState);
                }
            }
            catch
            {
                this.Dispose();
            }
        }

        public void OnSended2(IAsyncResult ar)
        {
            try
            {
                if (!this.disposed)
                {
                    this.clientSocket.EndSend(ar);
                }
            }
            catch (Exception)
            {
                this.Dispose();
            }
        }

        public virtual void ProcessDataReceived(byte[] data, int length)
        {
        }

        public void RaiseMessageEvent(string Msg)
        {
            if (this.eval_e != null)
            {
                this.eval_e(Msg, this);
            }
        }

        public virtual void Send(string str)
        {
            try
            {
                int t = 0;
                if (!this.disposed)
                {
                    byte[] b = new byte[str.Length];
                    Converter.ToBytes(str, b, ref t);
                    this.clientSocket.BeginSend(b, 0, t, SocketFlags.None, new AsyncCallback(this.OnSended2), this);
                }
            }
            catch (Exception)
            {
                this.Dispose();
            }
        }

        public virtual void Send(byte[] toSendBuff, int len)
        {
            try
            {
                if (!this.disposed)
                {
                    byte[] dst = new byte[len + 6];
                    dst[0] = 170;
                    dst[1] = 102;
                    Buffer.BlockCopy(BitConverter.GetBytes(len), 0, dst, 2, 4);
                    Buffer.BlockCopy(toSendBuff, 0, dst, 6, len);
                    this.clientSocket.BeginSend(dst, 0, dst.Length, SocketFlags.None, new AsyncCallback(this.OnSended2), this);
                }
            }
            catch (Exception)
            {
                this.Dispose();
            }
        }

        public virtual void Send(char[] toSendBuff, int len)
        {
            try
            {
                if (!this.disposed)
                {
                    byte[] dst = new byte[len];
                    Buffer.BlockCopy(toSendBuff, 0, dst, 0, len);
                    this.clientSocket.BeginSend(dst, 0, len, SocketFlags.None, new AsyncCallback(this.OnSended2), this);
                }
            }
            catch (Exception)
            {
                this.Dispose();
            }
        }

        public virtual void Send(byte[] toSendBuff, int offset, int len)
        {
            try
            {
                if (!this.disposed)
                {
                    byte[] dst = new byte[len];
                    Buffer.BlockCopy(toSendBuff, offset, dst, 0, len);
                    if (!this.disposed)
                    {
                        this.clientSocket.BeginSend(dst, 0, len, SocketFlags.None, new AsyncCallback(this.OnSended2), this);
                    }
                }
            }
            catch (Exception)
            {
                this.Dispose();
            }
        }

        public virtual void Sendd(string str)
        {
            byte[] bytes = Encoding.Default.GetBytes(str);
            this.Send(bytes, bytes.Length);
        }

        public void Start()
        {
            this.clientSocket.BeginReceive(this.dataReceive, 0, this.dataReceive.Length, SocketFlags.None, new AsyncCallback(this.OnReceiveData), this);
        }

        public bool Disposed
        {
            get
            {
                return this.disposed;
            }
        }

        public IPAddress IP
        {
            get
            {
                try
                {
                    if (this.disposed)
                    {
                        return null;
                    }
                    return ((IPEndPoint) this.clientSocket.RemoteEndPoint).Address;
                }
                catch
                {
                    this.Dispose();
                }
                return null;
            }
        }
    }
}


using RxjhServer.RxjhServer;

namespace Network
{
    using Microsoft.Win32;
    using Microsoft.Win32.SafeHandles;
    using RxjhServer;
    using HelperTools;
    using System;
    using System.Collections;
    using System.IO;
    using System.Net;
    using System.Net.Sockets;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;
    using System.Timers;
    using DbClss;

    public class NetState : IDisposable
    {
        private byte[] Key = new byte[] { 
            4, 59, 194, 124, 236, 235, 63, 139, 52, 131, 91, 36, 67, 248, 106, 32, 
            193, 231, 2, 232, 92, 237, 241, 255, 89, 139, 13, 8, 51, 65, 0, 137
         };
        private byte[] CODE = new byte[65536];
        public int dwStop;
        private const int BufferSize = 1024;
        private Network.NetState.AsyncState m_AsyncState;
        private static BufferPool m_ReceiveBufferPool;
        private SendQueue m_SendQueue;
        private Socket m_Socket;
        private IPAddress m_Address;
        private AsyncCallback m_OnReceive;
        private AsyncCallback m_OnSend;
        private object m_AsyncLock = new object();
        private byte[] m_RecvBuffer;
        private System.Collections.Queue BuffPool = System.Collections.Queue.Synchronized(new System.Collections.Queue());
        private Players _Player;
        private ByteQueue m_Buffer;
        private bool m_Running;
        private bool _FLD_Offline;
        private string m_ToString;
        private ManualResetEvent sendDone = new ManualResetEvent(false);
        public byte[] g_cur_key = new byte[] { 201, 39, 147, 1, 162, 108, 49, 151 };
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

        static NetState()
        {
            old_acctor_mc();
        }

        public NetState(Socket socket)
        {
            this.Ljtime = DateTime.Now;
            this.m_Socket = socket;
            this.m_Running = false;
            this.m_SendQueue = new SendQueue();
            this.m_Buffer = new ByteQueue();
            this.m_RecvBuffer = m_ReceiveBufferPool.eval_c();
            
            try
            {
                this.m_Address = ((IPEndPoint) this.m_Socket.RemoteEndPoint).Address;
                this.m_ToString = this.m_Address.ToString();
            }
            catch
            {
                this.m_Address = IPAddress.None;
                this.m_ToString = "(error)";
            }
            this.WorldId = (int) socket.Handle;
            this.addWorldIdd();
            this.Player = new Players(this);
            Form1.WriteLine(3, this.WorldId + " joined - IP: " + this.ToString());
            this.FLD_Offline = false;
            this.自动断开 = new System.Timers.Timer((double) World.版本验证时间);
            this.自动断开.Elapsed += new ElapsedEventHandler(this.自动断开事件);
            this.自动断开.AutoReset = true;
            this.自动断开.Enabled = true;
        }

        private bool Flush()
        {
            if (World.JlMsg == 1)
            {
                //Form1.WriteLine(0, "ThreadProca");
            }
            if ((this.m_Socket != null) && this.m_SendQueue.IsFlushReady)
            {
                SendQueue.Gram gram;
                lock (this.m_SendQueue)
                {
                    gram = this.m_SendQueue.CheckFlushReady();
                }
                if (gram != null)
                {                    
                    try
                    {
                        this.m_Socket.BeginSend(gram.Buffer, 0, gram.Length, SocketFlags.None, this.m_OnSend, this.m_Socket);                        
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
                for (int i = 300; i < 10000; ++i)
                {
                    if (!World.List.ContainsKey(i))
                    {
                        this.WorldId = i;
                        World.List.Add(i, this);
                        return;
                    }
                }                
            }
            catch (Exception exception)
            {
                Form1.WriteLine(1, string.Concat(new object[] { "addWorldIdd()出错", this.WorldId, "|", this.ToString(), " ", exception.Message }));
            }
        }

        [DllImport("kernel32.dll", CharSet=CharSet.Auto, SetLastError=true)]
        public static extern SafeFileHandle CreateIoCompletionPort(IntPtr FileHandle, IntPtr ExistingCompletionPort, IntPtr CompletionKey, uint NumberOfConcurrentThreads);
        public void delWorldIdd()
        {
            try
            {
                if (World.List.ContainsKey(this.WorldId))
                {
                    World.List.Remove(this.WorldId);
                }
            }
            catch (Exception exception)
            {
                Form1.WriteLine(1, string.Concat(new object[] { "delWorldIdd()出错", this.WorldId, "|", this.ToString(), " ", exception.Message }));
            }
        }

        public void Dispose()
        {
            if (World.JlMsg == 1)
            {
                Form1.WriteLine(0, "Dispose()");
            }
            this.Dispose(true);
        }


        private void HandleReceive(NetState ns)
        {
            if (World.JlMsg == 1)
            {
                //Form1.WriteLine(0, "HandleReceive");
            }
            try
            {
                if ((this.Buffer != null) && (this.Buffer.Length > 0))
                {
                    using (new Lock(this.Buffer, "HandleReceive"))
                    {
                        int length = this.Buffer.Length;
                        while ((length > 0) && this.Running)
                        {
                            if (World.JlMsg == 1)
                            {
                                //Form1.WriteLine(0, "HandleReceive");
                            }
                            if (length > 4)
                            {
                                int size = BitConverter.ToInt16(this.Buffer.GetPacketID(), 0);
                                if (size <= 0)
                                {
                                    this.Buffer.Clear();
                                }
                                else
                                {
                                    size += 6;
                                    if (length >= size)
                                    {
                                        byte[] buffer = new byte[size];
                                        this.Buffer.Dequeue(buffer, 0, size);
                                        length = this.Buffer.Length;

                                        if ((170 == buffer[0]) && (85 == buffer[1]))
                                        {
                                            if ((buffer[size - 2] != 85) || (buffer[size - 1] != 170))
                                            {
                                                this.Buffer.Clear();
                                                return;
                                            }
                                            //World.是否加密 = 0;
                                            
                                            
                                            if (World.是否加密 != 0)
                                            {
                                                if (World.登陆器模式 == 1)
                                                {
                                                    this.Decrypta(ref buffer);
                                                }
                                                else if (World.登陆器模式 == 0)
                                                {
                                                    byte[] dst = new byte[size - 6];
                                                    System.Buffer.BlockCopy(buffer, 4, dst, 0, dst.Length);
                                                    ClassDllImport.Decrypta(dst, dst.Length);
                                                    System.Buffer.BlockCopy(dst, 0, buffer, 4, dst.Length);
                                                }
                                                this.Player.ManagePacket(buffer, buffer.Length);
                                            }
                                            else
                                            {
                                                byte[] buffer2 = new byte[buffer.Length + 1];

                                                for (int ii = 0; ii < buffer.Length; ++ii)
                                                {
                                                    if (ii >= 4)
                                                    {
                                                        buffer2[ii+1] = buffer[ii];
                                                    }
                                                    else
                                                    {
                                                        buffer2[ii] = buffer[ii];
                                                    }
                                                }
                                                string txtt2 = Converter.ToString(buffer);
                                                string txtt = Converter.ToString(buffer2);
                                                Form1.WriteLine(7, txtt);
                                                this.Player.ManagePacket(buffer2, buffer2.Length);
                                            }


                                            continue;
                                        }
                                        this.Buffer.Clear();
                                    }
                                    else if ((170 != this.Buffer.m_Buffer[0]) && (85 != this.Buffer.m_Buffer[1]))
                                    {
                                        this.Buffer.Clear();
                                    }
                                }
                            }
                            return;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Form1.WriteLine(1, string.Concat(new object[] { "HandleReceive()出错", this.WorldId, "|", this.ToString(), " ", exception }));
                this.Dispose(false);
            }
        }

        //fix loi diss
        private void Dispose(bool flush)
        {
            int num = 0;
            try
            {
                if (World.JlMsg == 1)
                {
                    Form1.WriteLine(0, "Dispose()");
                }
                if (this.FLD_Offline)
                {
                    this.FLD_Offline = false;
                    Form1.WriteLine(3, "Func Off-Hook: [" + this.Player.Userid + "] - [" + this.Player.UserName + "] - OFF");
                }
                num = 1;
                this.退出 = true;
                if (!World.MDisposed.Contains(this))
                {
                    num = 2;
                    this.m_Running = false;
                    Form1.WriteLine(3, this.WorldId + " disconnect - IP: " + this.ToString());
                    num = 3;
                    if (this.m_SendQueue != null)
                    {
                        if (!this.m_SendQueue.IsEmpty)
                        {
                            using (new Lock(this.m_SendQueue, "Dispose()"))
                            {
                                this.m_SendQueue.Clear();
                            }
                        }
                        this.m_SendQueue.Dispose();
                        this.m_SendQueue = null;
                    }
                    num = 4;
                    if (this.m_Buffer != null)
                    {
                        this.m_Buffer.Dispose();
                        this.m_Buffer = null;
                    }
                    num = 5;
                    if (this.m_Socket != null)
                    {
                        try
                        {
                            this.m_Socket.Shutdown(SocketShutdown.Both);
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                        }
                        try
                        {
                            this.m_Socket.Close();
                        }
                        catch (Exception exception2)
                        {
                            Console.WriteLine(exception2);
                        }
                        this.m_Socket = null;
                    }
                    num = 6;
                    if (this.m_RecvBuffer != null)
                    {
                        m_ReceiveBufferPool.ReleaseBuffer(this.m_RecvBuffer);
                    }
                    this.m_RecvBuffer = null;
                    this.m_OnReceive = null;
                    this.m_OnSend = null;
                    this.m_Running = false;
                    this.BuffPool = null;
                    if (this.自动断开 != null)
                    {
                        this.自动断开.Enabled = false;
                        this.自动断开.Close();
                        this.自动断开.Dispose();
                    }
                    num = 7;
                    World.MDisposed.Enqueue(this);
                    if (World.Iplist.ContainsKey(this.WorldId))
                    {
                        try
                        {
                            World.Iplist.RemoveSafe(this.WorldId);
                        }
                        catch (Exception exception3)
                        {
                            Form1.WriteLine(1, string.Concat(new object[] { "移除玩家多开列表项出错", this.WorldId, "|", this.ToString(), " ", exception3.Message }));
                        }
                    }
                }
            }
            catch (Exception exception4)
            {
                Form1.WriteLine(1, string.Concat(new object[] { " Dispose(bool flush)出错", this.WorldId, "|", this.ToString(), " [", num, "]", exception4.Message }));
            }
        }

        private void Dispose_(bool flush)
        {
            Exception exception;
            try
            {
                if ((this.m_Socket != null) && !this.退出)
                {
                    if (World.JlMsg == 1)
                    {
                        Form1.WriteLine(0, "Dispose()");
                    }
                    this.退出 = true;
                    if (!World.MDisposed.Contains(this))
                    {
                        this.m_Running = false;
                        Form1.WriteLine(3, string.Concat(new object[] { "[", this.WorldId, "] IP [", this.ToString(), "]" }));
                        if (this.m_SendQueue != null)
                        {
                            if (!this.m_SendQueue.IsEmpty)
                            {
                                using (new Lock(this.m_SendQueue, "Dispose()"))
                                {
                                    this.m_SendQueue.Clear();
                                }
                            }
                            this.m_SendQueue.Dispose();
                            this.m_SendQueue = null;
                        }
                        if (this.m_Buffer != null)
                        {
                            this.m_Buffer.Dispose();
                            this.m_Buffer = null;
                        }
                        if (this.m_Socket != null)
                        {
                            try
                            {
                                this.m_Socket.Shutdown(SocketShutdown.Both);
                            }
                            catch (Exception exception1)
                            {
                                exception = exception1;
                                Console.WriteLine(exception);
                            }
                            try
                            {
                                this.m_Socket.Close();
                            }
                            catch (Exception exception2)
                            {
                                exception = exception2;
                                Console.WriteLine(exception);
                            }
                            this.m_Socket = null;
                        }
                        if (this.m_RecvBuffer != null)
                        {
                            m_ReceiveBufferPool.ReleaseBuffer(this.m_RecvBuffer);
                        }
                        this.m_RecvBuffer = null;
                        this.m_OnReceive = null;
                        this.m_OnSend = null;
                        this.m_Running = false;
                        this.BuffPool = null;
                        if (this.自动断开 != null)
                        {
                            this.自动断开.Enabled = false;
                            this.自动断开.Close();
                            this.自动断开.Dispose();
                        }
                        World.MDisposed.Enqueue(this);
                        if (World.Iplist.ContainsKey(this.WorldId))
                        {
                            try
                            {
                                Form1.WriteLine(1, "Ngat ket noi tat ca");
                                World.Iplist.RemoveSafe(this.WorldId);

                            }
                            catch (Exception exception3)
                            {
                                Form1.WriteLine(1, string.Concat(new object[] { "移除玩家多开列表项出错", this.WorldId, "|", this.ToString(), " ", exception3.Message }));
                            }
                        }
                    }
                }
            }
            catch (Exception exception3)
            {
                exception = exception3;
                Form1.WriteLine(1, string.Concat(new object[] { " Dispose(bool flush)出错", this.WorldId, "|", this.ToString(), " ", exception.Message }));
            }
        }

        private void Decrypta(ref byte[] data)
        {
            byte num = 0;
            byte num2 = 0;
            for (int i = 0; i < (data.Length - 6); ++i)
            {
                num2 = data[4 + i];
                data[4 + i] = (byte) ((data[4 + i] ^ this.g_cur_key[i % 8]) ^ num);
                num = num2;
            }
        }

        private void OnReceive(IAsyncResult A_0)
        {
            if (World.JlMsg == 1)
            {
                //Form1.WriteLine(0, "OnReceive");
            }
            Socket asyncState = (Socket) A_0.AsyncState;
            try
            {
                int size = 0;
                try
                {
                    size = asyncState.EndReceive(A_0);
                }
                catch (ArgumentNullException exception)
                {
                    Form1.WriteLine(1, string.Concat(new object[] { "OnReceive()1出错", this.WorldId, "|", this.ToString(), " ", exception.Message }));
                    this.Dispose(false);
                }
                catch (ArgumentException exception2)
                {
                    Form1.WriteLine(1, string.Concat(new object[] { "OnReceive()2出错", this.WorldId, "|", this.ToString(), " ", exception2.Message }));
                    this.Dispose(false);
                }
                catch (InvalidOperationException)
                {
                    this.Dispose(false);
                }
                catch (SocketException)
                {
                    this.Dispose(false);
                }
                catch (Exception exception3)
                {
                    Form1.WriteLine(1, string.Concat(new object[] { "OnReceive()5出错", this.WorldId, "|", this.ToString(), " ", exception3.Message }));
                    this.Dispose(false);
                }
                if (size > 0 && size < World.SizeDdos)
                {
                    World.接收速度 += size;
                    byte[] recvBuffer = this.m_RecvBuffer;
                    using (new Lock(this.m_Buffer, "this.m_Buffer"))
                    {
                        this.m_Buffer.Enqueue(recvBuffer, 0, size);
                    }
                    this.HandleReceive(this);
                    if (!this.退出)
                    {
                        this.m_AsyncState &= ~Network.NetState.AsyncState.Pending;
                        if ((this.m_AsyncState & Network.NetState.AsyncState.Paused) == 0)
                        {
                            try
                            {
                                byte[] array = new byte[Marshal.SizeOf(0) * 3];
                                BitConverter.GetBytes((uint) 1).CopyTo(array, 0);
                                BitConverter.GetBytes((uint) 20000).CopyTo(array, Marshal.SizeOf(0));
                                BitConverter.GetBytes((uint) 20000).CopyTo(array, (int) (Marshal.SizeOf(0) * 2));
                                this.InternalBeginReceive(array);
                            }
                            catch (Exception)
                            {
                                this.Dispose(false);
                            }
                        }
                    }
                }
                else
                {
                    if (size > World.SizeDdos)
                    {
                        Form1.WriteLine(0, "Ddos - size: " + size);
                    }
                    this.Dispose(false);
                }
            }
            catch (Exception exception4)
            {
                Form1.WriteLine(1, string.Concat(new object[] { "OnReceive()6出错", this.WorldId, "|", this.ToString(), " ", exception4 }));
                this.Dispose(false);
            }
        }

        private static void ThreadProca(object A_0)
        {
            IntPtr ptr;
            uint num2;
            IntPtr ptr2;
            if (World.JlMsg == 1)
            {
                //Form1.WriteLine(0, "ThreadProca()");
            }
            SafeFileHandle completionPort = (SafeFileHandle) A_0;
        Label_0228:
            if (World.JlMsg == 1)
            {
                //Form1.WriteLine(0, "ThreadProca");
            }
            GetQueuedCompletionStatus(completionPort, out num2, out ptr2, out ptr, uint.MaxValue);
            if (num2 > 0)
            {
                if (ptr == IntPtr.Zero)
                {
                    completionPort.Dispose();
                    //Form1.WriteLine(1, "ThreadProca关");
                    return;
                }
                GCHandle handle = GCHandle.FromIntPtr(ptr);
                IO_Net_DATA target = (IO_Net_DATA) handle.Target;
                try
                {
                    if (target.NetStat.m_Socket == null)
                    {
                        handle.Free();
                        goto Label_0228;
                    }
                    if (!target.NetStat.m_Running)
                    {
                        handle.Free();
                        goto Label_0228;
                    }
                    if (target.NetStat.BuffPool == null)
                    {
                        handle.Free();
                        goto Label_0228;
                    }
                    if (target.NetStat.BuffPool.Count <= 0)
                    {
                        handle.Free();
                        goto Label_0228;
                    }
                    int num = 0;
                    MemoryStream stream = new MemoryStream();
                    while (num < 21)
                    {
                        if (target.NetStat.BuffPool.Count <= 0)
                        {
                            break;
                        }
                        if (World.JlMsg == 1)
                        {
                            //Form1.WriteLine(0, "ThreadProca2");
                        }
                        if (target.NetStat.m_Socket == null)
                        {
                            handle.Free();
                        }
                        else
                        {
                            if (!target.NetStat.m_Running)
                            {
                                handle.Free();
                                continue;
                            }
                            num++;
                            byte[] buffer2 = (byte[]) target.NetStat.BuffPool.Dequeue();
                            stream.Write(buffer2, 0, buffer2.Length);
                        }
                    }
                    if (num > 0)
                    {
                        try
                        {
                            byte[] buffer = stream.GetBuffer();
                            target.NetStat.Send多包加密(buffer, buffer.Length, num);
                        }
                        catch (Exception exception)
                        {
                            Form1.WriteLine(1, string.Concat(new object[] { "Send()_OnMessage多包2", target.NetStat.WorldId, "|", exception.Message }));
                        }
                    }
                }
                catch (Exception exception2)
                {
                    Form1.WriteLine(1, string.Concat(new object[] { "Send()_OnMessage多包2_2", target.NetStat.WorldId, "|", exception2.Message }));
                }
                handle.Free();
            }
            goto Label_0228;
        }

        private void InternalBeginReceive(byte[] A_0)
        {
            try
            {
                if (World.JlMsg == 1)
                {
                    //Form1.WriteLine(0, "InternalBeginReceive()");
                }
                this.m_AsyncState |= Network.NetState.AsyncState.Pending;
                this.m_Socket.IOControl(IOControlCode.KeepAliveValues, A_0, null);
                this.m_Socket.BeginReceive(this.m_RecvBuffer, 0, this.m_RecvBuffer.Length, SocketFlags.None, this.m_OnReceive, this.m_Socket);
            }
            catch (Exception)
            {
                this.Dispose(false);
            }
        }

        private void 自动断开事件(object sender, ElapsedEventArgs e)
        {
            if (!this.版本验证)
            {
                Form1.WriteLine(1, this.WorldId + " connect timeout - IP: " + this.ToString());
                this.Dispose(false);
            }
            if (this.自动断开 != null)
            {
                this.自动断开.Enabled = false;
                this.自动断开.Close();
                this.自动断开.Dispose();
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
                byte[] buffer;
                int srcOffset = 0;
                if ((170 != A_0[0]) || (85 != A_0[1]))
                {
                    return;
                }
                byte[] dst = new byte[2];
                System.Buffer.BlockCopy(A_0, 2, dst, 0, 2);
                int num2 = BitConverter.ToInt16(dst, 0);
                goto Label_00ED;
            Label_004A:
                buffer = new byte[num2 + 6];
                if (((srcOffset + num2) + 6) > A_1)
                {
                    return;
                }
                System.Buffer.BlockCopy(A_0, srcOffset, buffer, 0, num2 + 6);
                srcOffset += num2 + 6;
                if (World.Log == 1)
                {
                    string txtt = Converter.ToString(buffer);
                    Form1.WriteLine(7, txtt);
                }
                if ((buffer[buffer.Length - 2] != 85) || (buffer[buffer.Length - 1] != 170))
                {
                    return;
                }
                this.Player.ManagePacket(buffer, buffer.Length);
                if (((srcOffset >= A_1) || (A_0[srcOffset] != 170)) || (A_0[srcOffset + 1] != 85))
                {
                    return;
                }
                System.Buffer.BlockCopy(A_0, srcOffset + 2, dst, 0, 2);
                num2 = BitConverter.ToInt16(dst, 0);
                goto Label_00ED;
            Label_00DD:
                Form1.WriteLine(0, "ProcessDataReceived");
                goto Label_004A;
            Label_00ED:
                if (World.JlMsg != 1)
                {
                    goto Label_004A;
                }
                goto Label_00DD;
            }
            catch (Exception exception)
            {
                byte[] buffer3 = new byte[A_1];
                System.Buffer.BlockCopy(A_0, 0, buffer3, 0, A_1);
                string str2 = Converter.ToString(buffer3);
                Form1.WriteLine(1, string.Concat(new object[] { "ProcessDataReceived()出错", this.WorldId, "|", this.ToString(), " ", str2, "  ", exception.ToString() }));
                this.Dispose(false);
            }
        }

        private void Send多包封装发送(byte[] A_0, int A_1, int A_2)
        {
            byte[] dst = new byte[A_1 + 17];
            dst[0] = 170;
            dst[1] = 85;
            System.Buffer.BlockCopy(BitConverter.GetBytes((int) (A_1 + 11)), 0, dst, 2, 2);
            System.Buffer.BlockCopy(BitConverter.GetBytes(A_2), 0, dst, 5, 2);
            System.Buffer.BlockCopy(A_0, 0, dst, 7, A_1);
            dst[dst.Length - 2] = 85;
            dst[dst.Length - 1] = 170;
            string txtt = Converter.ToString(dst);
            this.Send(dst, dst.Length);

        }

        private byte[] SendDuopak(byte[] toSendBuff, int length, out int outlength)
        {
            try
            {
                int num = 10;
                //int num2 = length / 10;
                int num2 = length / num;
                while (((length - (num2 * num)) > 0) && ((length - (num2 * num)) < 2))
                {
                    num++;
                    num2 = length / num;
                }
                //while ((length - (num2 * num)) > 0)
                //{
                //    if ((length - (num2 * num)) >= 2)
                //    {
                //        break;
                //    }
                //    num++;
                //    num2 = length / num;
                //}
                if ((length % num) > 0)
                {
                    num2++;
                }
                byte[] dst = new byte[length + num2];
                int srcOffset = 0;
                int index = 0;
                int count = num;
                do
                {
                    if ((srcOffset + count) >= length)
                    {
                        count = length - srcOffset;
                        dst[index] = (byte)(count - 1);
                        System.Buffer.BlockCopy(toSendBuff, srcOffset, dst, index + 1, count);
                        srcOffset += count;
                        index += count + 1;
                    }
                    else
                    {
                        dst[index] = (byte)(count - 1);
                        System.Buffer.BlockCopy(toSendBuff, srcOffset, dst, index + 1, count);
                        srcOffset += count;
                        index += count + 1;
                        count = num;
                    }
                }
                while (srcOffset < length);
                outlength = index;
                return dst;
            //    while ((srcOffset + count) < length)
            //    {
            //        dst[index] = (byte) (count - 1);
            //        System.Buffer.BlockCopy(toSendBuff, srcOffset, dst, index + 1, count);
            //        srcOffset += count;
            //        index += count + 1;
            //        count = num;
            //    Label_0068:
            //        if (srcOffset < length)
            //        {
            //            continue;
            //        }
            //        goto Label_00A3;
            //   //Label_006E:
            //        count = length - srcOffset;
            //        dst[index] = (byte) (count - 1);
            //        System.Buffer.BlockCopy(toSendBuff, srcOffset, dst, index + 1, count);
            //        srcOffset += count;
            //        index += count + 1;
            //        goto Label_0068;
            //    }
            //    //goto Label_006E;
            //Label_00A3:
            //    outlength = index;
            //    return dst;
            }
            catch (Exception exception)
            {
                Form1.WriteLine(1, string.Concat(new object[] { "Send()SendDuopak", this.WorldId, "|", exception.Message }));
                outlength = length;
                return toSendBuff;
            }
        }

        private int SendDuopak3(byte[] A_0, int A_1, out byte[] A_2)
        {
            A_2 = new byte[(A_1 + (A_1 / 32)) + 1];
            int num = 0;
            int num2 = 0;
            int index = 6;
            int num4 = 6 - 1;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;
            try
            {
                goto Label_00EC;
            Label_0028:
                if ((index - num4) < 255)
                {
                    goto Label_005F;
                }
                goto Label_00E6;
            Label_0037:
                if (((num4 + num5) >= A_1) || ((index + num5) >= A_1))
                {
                    goto Label_00A9;
                }
                if (A_0[index + num5] != A_0[num4 + num5])
                {
                    goto Label_006A;
                }
                num6++;
                num5++;
            Label_005F:
                if (num5 >= 255)
                {
                    goto Label_00A9;
                }
                goto Label_0037;
            Label_006A:
                if (num6 >= 3)
                {
                    if ((A_0[index] == A_0[num4 - 1]) && ((index - num4) < 254))
                    {
                        num7 = 1;
                    }
                    else
                    {
                        this.OneByte(index, num4, num5, num6, A_0, ref num2, ref num, ref A_2);
                        index = num2;
                        num4 = num2;
                        num7 = 0;
                        num6 = 0;
                    }
                }
                else
                {
                    num6 = 0;
                }
            Label_00A9:
                if ((num6 >= 3) && ((A_0[index] != A_0[num4 - 1]) || (num7 == 0)))
                {
                    this.OneByte(index, num4, num5, num6, A_0, ref num2, ref num, ref A_2);
                    index = num2;
                    num4 = num2;
                    num7 = 0;
                }
                num5 = 0;
                num6 = 0;
                num4--;
            Label_00DF:
                if (num4 > 1)
                {
                    goto Label_0028;
                }
            Label_00E6:
                num4 = index;
                index++;
            Label_00EC:
                if (index <= A_1)
                {
                    goto Label_00DF;
                }
                if (num2 >= A_1)
                {
                    return num;
                }
                int num9 = A_1 - num2;
                if (num9 > 32)
                {
                    int num8 = 0;
                    byte[] dst = new byte[num9];
                    System.Buffer.BlockCopy(A_0, num2, dst, 0, dst.Length);
                    byte[] src = this.SendDuopak(dst, dst.Length, out num8);
                    if (num == 0)
                    {
                        A_2 = new byte[src.Length];
                    }
                    System.Buffer.BlockCopy(src, 0, A_2, num, num8);
                    num += num8;
                    num2 += num9;
                    return num;
                }
                if (num9 > 0)
                {
                    A_2[num++] = (byte) ((A_1 - num2) - 1);
                    System.Buffer.BlockCopy(A_0, num2, A_2, num, A_1 - num2);
                    num += A_1 - num2;
                    num2 += A_1 - num2;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            return num;
        }

        private void OneByte(int A_0, int A_1, int A_2, int A_3, byte[] A_4, ref int A_5, ref int A_6, ref byte[] A_7)
        {
            int num = A_0 - A_5;
            if (num > 32)
            {
                int count = 0;
                byte[] dst = new byte[num];
                System.Buffer.BlockCopy(A_4, A_5, dst, 0, dst.Length);
                System.Buffer.BlockCopy(this.SendDuopak(dst, dst.Length, out count), 0, A_7, A_6, count);
                A_6 += count;
                A_5 += num;
            }
            else if (num > 0)
            {
                A_7[A_6++] = (byte) (num - 1);
                System.Buffer.BlockCopy(A_4, A_5, A_7, A_6, A_0 - A_5);
                A_6 += A_0 - A_5;
                A_5 += A_0 - A_5;
            }
            int num9 = A_3 - 2;
            if (num9 < 7)
            {
                A_7[A_6++] = (byte) (num9 = num9 << 5);
                int num11 = (A_0 - A_1) - 1;
                A_7[A_6++] = (byte) num11;
            }
            else
            {
                A_7[A_6++] = (byte) (7 << 5);
                int num4 = (A_3 - 2) - 7;
                A_7[A_6++] = (byte) num4;
                int num6 = (A_0 - A_1) - 1;
                A_7[A_6++] = (byte) num6;
            }
            A_5 += A_3;
        }

        private void OnSend(IAsyncResult asyncResult)
        {
            if (World.JlMsg == 1)
            {
                //Form1.WriteLine(0, "OnSend");
            }
            Socket asyncState = (Socket)asyncResult.AsyncState;
            if (this.m_Socket == null)
            {
                this.Dispose(false);
            }
            else
            {
                try
                {
                    try
                    {
                        if (this.m_Socket.Connected && this.m_Running)
                        {
                            int num = asyncState.EndSend(asyncResult);
                            World.发送速度 += num;
                            if (num <= 0)
                            {
                                this.Dispose(false);
                            }
                            else
                            {
                                SendQueue.Gram gram;
                                using (new Lock(this.m_SendQueue, "OnSend"))
                                {
                                    gram = this.m_SendQueue.Dequeue();
                                }
                                if (gram != null)
                                {
                                    try
                                    {
                                        asyncState.BeginSend(gram.Buffer, 0, gram.Length, SocketFlags.None, this.m_OnSend, asyncState);
                                    }
                                    catch (Exception)
                                    {
                                        this.Dispose(false);
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        this.Dispose(false);
                    }
                }
                finally
                {
                }
            }
        }

        private void Send单包封装发送(byte[] A_0, int A_1)
        {
            byte[] dst = new byte[A_1 + 15];
            dst[0] = 170;
            dst[1] = 85;
            System.Buffer.BlockCopy(BitConverter.GetBytes((int) (A_1 + 9)), 0, dst, 2, 2);
            System.Buffer.BlockCopy(A_0, 0, dst, 5, A_1);
            dst[dst.Length - 2] = 85;
            dst[dst.Length - 1] = 170;
            this.Send(dst, dst.Length);
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
                byte[] buffer;
                num = 1;
                int num2 = this.SendDuopak3(bytes, length, out buffer);
                num = 2;
                byte[] dst = new byte[num2 + 16];
                num = 3;
                System.Buffer.BlockCopy(BitConverter.GetBytes(192), 0, dst, 0, 2);
                num = 4;
                System.Buffer.BlockCopy(BitConverter.GetBytes((int) (num2 + 4)), 0, dst, 2, 2);
                num = 5;
                System.Buffer.BlockCopy(BitConverter.GetBytes(num2), 0, dst, 4, 2);
                num = 6;
                System.Buffer.BlockCopy(BitConverter.GetBytes(length), 0, dst, 6, 2);
                num = 7;
                System.Buffer.BlockCopy(buffer, 0, dst, 8, num2);
                num = 8;
                this.Send多包封装发送(dst, dst.Length, A_2);
            }
            catch (Exception exception)
            {
                byte[] buffer3;
                int num3 = this.SendDuopak3(bytes, length, out buffer3);
                byte[] buffer4 = new byte[num3 + 16];
                Form1.WriteLine(100, string.Concat(new object[] { "Send()_Send多包加密", this.WorldId, "长度", length, "错误地方", num, "outlin", num3, "-newBuffer长度-", buffer4.Length, "-Buffer长度-", buffer3.Length, "异常", exception.Message }));
            }
        }

        private byte[] SendDuopak2(byte[] A_0, int A_1, out int A_2)
        {
            try
            {
                byte[] dst = new byte[(A_1 + (A_1 / 32)) + 1];
                A_2 = 0;
                int srcOffset = 0;
                int num2 = 10;
                int num3 = 0;
                bool flag = false;
                for (int i = 0; i < A_0.Length; ++i)
                {
                    for (int j = num2; j < i; ++j)
                    {
                        if ((i - j) > 255)
                        {
                            j = i - 255;
                        }
                        int num38 = 0;
                        goto Label_007C;
                    Label_0047:
                        if ((num38 >= ((A_0.Length - j) - 2)) || (num38 >= 255))
                        {
                            goto Label_02F4;
                        }
                        if (A_0[j + num38] != A_0[i + num38])
                        {
                            goto Label_008D;
                        }
                        num3++;
                        num38++;
                    Label_007C:
                        if (num38 >= ((A_0.Length - i) - 2))
                        {
                            goto Label_02F4;
                        }
                        goto Label_0047;
                    Label_008D:
                        if (flag)
                        {
                            if (num3 >= 3)
                            {
                                if (i > srcOffset)
                                {
                                    int num11 = (i - srcOffset) - 1;
                                    if (num11 > 31)
                                    {
                                        int count = 0;
                                        byte[] buffer2 = new byte[num11 + 1];
                                        System.Buffer.BlockCopy(A_0, srcOffset, buffer2, 0, buffer2.Length);
                                        System.Buffer.BlockCopy(this.SendDuopak(buffer2, buffer2.Length, out count), 0, dst, A_2, count);
                                        A_2 += count;
                                        srcOffset += num11 + 1;
                                    }
                                    else if (num11 >= 0)
                                    {
                                        dst[A_2++] = (byte) num11;
                                        System.Buffer.BlockCopy(A_0, srcOffset, dst, A_2, i - srcOffset);
                                        A_2 += i - srcOffset;
                                        srcOffset += i - srcOffset;
                                    }
                                }
                                int num15 = num3 - 2;
                                if (num15 < 7)
                                {
                                    dst[A_2++] = (byte) (num15 = num15 << 5);
                                    int num17 = (srcOffset - 1) - j;
                                    dst[A_2++] = (byte) num17;
                                }
                                else
                                {
                                    dst[A_2++] = (byte) (7 << 5);
                                    int num24 = (num3 - 2) - 7;
                                    dst[A_2++] = (byte) num24;
                                    int num26 = (srcOffset - j) - 1;
                                    dst[A_2++] = (byte) num26;
                                }
                                srcOffset += num3;
                                num2 = i / 2;
                                if (num2 > 255)
                                {
                                    num2 = i - 255;
                                }
                                i = srcOffset;
                                num3 = 0;
                            }
                            else
                            {
                                num3 = 0;
                            }
                        }
                        else if (num3 >= 3)
                        {
                            int num13 = (i - srcOffset) - 1;
                            if (num13 > 31)
                            {
                                int num37 = 0;
                                byte[] buffer4 = new byte[num13 + 1];
                                System.Buffer.BlockCopy(A_0, srcOffset, buffer4, 0, buffer4.Length);
                                System.Buffer.BlockCopy(this.SendDuopak(buffer4, buffer4.Length, out num37), 0, dst, A_2, num37);
                                A_2 += num37;
                                srcOffset += num13 + 1;
                            }
                            else if (num13 >= 0)
                            {
                                dst[A_2++] = (byte) ((i - srcOffset) - 1);
                                System.Buffer.BlockCopy(A_0, srcOffset, dst, A_2, i - srcOffset);
                                A_2 += i - srcOffset;
                                srcOffset += i - srcOffset;
                            }
                            int num33 = num3 - 2;
                            if (num33 < 7)
                            {
                                dst[A_2++] = (byte) (num33 = num33 << 5);
                                int num35 = (srcOffset - 1) - j;
                                dst[A_2++] = (byte) num35;
                            }
                            else
                            {
                                dst[A_2++] = (byte) (7 << 5);
                                int num6 = (num3 - 2) - 7;
                                dst[A_2++] = (byte) num6;
                                int num9 = (srcOffset - j) - 1;
                                dst[A_2++] = (byte) num9;
                            }
                            srcOffset += num3;
                            num2 = i / 2;
                            i = srcOffset;
                            flag = true;
                            num3 = 0;
                        }
                        else
                        {
                            num3 = 0;
                        }
                    Label_02F4:
                        if (num3 > 3)
                        {
                            if ((i - srcOffset) > 0)
                            {
                                dst[A_2++] = (byte) ((i - srcOffset) - 1);
                                System.Buffer.BlockCopy(A_0, srcOffset, dst, A_2, i - srcOffset);
                                A_2 += i - srcOffset;
                                srcOffset += i - srcOffset;
                            }
                            int num19 = num3 - 2;
                            if (num19 < 7)
                            {
                                dst[A_2++] = (byte) (num19 = num19 << 5);
                                int num21 = (i - 1) - j;
                                dst[A_2++] = (byte) num21;
                            }
                            else
                            {
                                dst[A_2++] = (byte) (7 << 5);
                                int num29 = (num3 - 2) - 7;
                                dst[A_2++] = (byte) num29;
                                int num31 = (srcOffset - j) - 1;
                                dst[A_2++] = (byte) num31;
                            }
                            srcOffset += num3;
                            num2 = i;
                            i = srcOffset;
                            num3 = 0;
                        }
                        else
                        {
                            num3 = 0;
                        }
                    }
                }
                if (srcOffset <= (A_1 - 2))
                {
                    dst[A_2++] = (byte) ((A_1 - srcOffset) - 1);
                    System.Buffer.BlockCopy(A_0, srcOffset, dst, A_2, A_1 - srcOffset);
                    A_2 += A_1 - srcOffset;
                    srcOffset += A_1 - srcOffset;
                }
                else
                {
                    dst[A_2++] = 1;
                    dst[A_2++] = 0;
                    dst[A_2++] = 0;
                }
                return dst;
            }
            catch (Exception exception)
            {
                Form1.WriteLine(1, string.Concat(new object[] { "Send()SendDuopak2", this.WorldId, "|", exception.Message }));
                A_2 = A_1;
                return A_0;
            }
        }

        ~NetState()
        {
        }

        [DllImport("kernel32.dll", CharSet=CharSet.Auto, SetLastError=true)]
        public static extern bool GetQueuedCompletionStatus(SafeFileHandle CompletionPort, out uint lpNumberOfBytesTransferred, out IntPtr lpCompletionKey, out IntPtr lpOverlapped, uint dwMilliseconds);
        public static string GetRegistData(string lj, string name)
        {
            try
            {
                return Registry.LocalMachine.OpenSubKey(lj, true).GetValue(name).ToString();
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public void IDout()
        {
            try
            {
                if (World.JlMsg == 1)
                {
                    //Form1.WriteLine(0, "ThreadProca");
                }
                if (this.Player != null)
                {
                    World.Conn.发送(string.Concat(new object[] { "用户登出|", this.Player.Userid, "|", World.服务器id }));
                }
            }
            catch (Exception exception)
            {
                Form1.WriteLine(1, string.Concat(new object[] { "IDout()出错", this.WorldId, "|", this.ToString(), " ", exception.Message }));
            }
        }

        private static void old_acctor_mc()
        {
            m_ReceiveBufferPool = new BufferPool("Receive", 2048, 2048);
        }

        [DllImport("Kernel32", CharSet=CharSet.Auto)]
        private static extern bool PostQueuedCompletionStatus(SafeFileHandle A_0, uint A_1, IntPtr A_2, IntPtr A_3);
        public void Send(byte[] toSendBufff, int len)
        {
            try
            {
                if (World.JlMsg == 1)
                {
                    //Form1.WriteLine(2, "ThreadProca");
                }
                if (((this.m_Socket != null) && this.m_Running) && this.m_Socket.Connected)
                {
                    try
                    {
                        byte[] toSendBuff;
                        if (World.是否加密 == 0)
                        {
                            toSendBuff = new byte[toSendBufff.Length - 1];
                            for (int ii = 0; ii < toSendBufff.Length; ++ii)
                            {
                                if (ii > 4)
                                {
                                    toSendBuff[ii-1] = toSendBufff[ii];
                                }
                                else if (ii < 4)
                                {
                                    toSendBuff[ii] = toSendBufff[ii];
                                }
                            }
                            len--;
                        }
                        else
                        {
                            toSendBuff = toSendBufff;
                        }
                        //string txtt = Converter.ToString(toSendBuff);
                        //Form1.WriteLine(1, "SV -> Client: " + txtt);

                        SendQueue.Gram gram;
                        using (new Lock(this.m_SendQueue, "Send"))
                        {
                            gram = this.m_SendQueue.Enqueue(toSendBuff, len);
                        }
                        if (gram != null)
                        {
                            try
                            {
                                this.m_Socket.BeginSend(gram.Buffer, 0, gram.Length, SocketFlags.None, this.m_OnSend, this.m_Socket);
                            }
                            catch (Exception)
                            {
                                this.Dispose(false);
                            }
                        }
                    }
                    catch (CapacityExceededException)
                    {
                        Form1.WriteLine(1, string.Concat(new object[] { "Send()_数据列队以满", this.WorldId, "|", this.ToString() }));
                        this.Dispose(false);
                    }
                }
            }
            catch (StackOverflowException)
            {
                Form1.WriteLine(1, string.Concat(new object[] { "Send()_StackOverflowException出错", this.WorldId, "|", this.ToString() }));
                this.Dispose(false);
            }
            catch (SocketException)
            {
                Form1.WriteLine(1, string.Concat(new object[] { "Send()_SocketException出错", this.WorldId, "|", this.ToString() }));
                this.Dispose(false);
            }
            catch (Exception)
            {
                Form1.WriteLine(1, string.Concat(new object[] { "Send()_Exception出错", this.WorldId, "|", this.ToString() }));
                this.Dispose(false);
            }
        }

        public void SendMsg(byte[] toSendBuff, int len)
        {
            try
            {
                if (this.m_Socket != null)
                {
                    SendQueue.Gram gram;
                    lock (this.m_SendQueue)
                    {
                        gram = this.m_SendQueue.Enqueue(toSendBuff, len);
                    }
                    if (gram != null)
                    {
                        try
                        {
                            this.m_Socket.BeginSend(gram.Buffer, 0, gram.Length, SocketFlags.None, this.m_OnSend, this.m_Socket);
                        }
                        catch (Exception)
                        {
                            this.Dispose();
                        }
                    }
                }
            }
            catch (StackOverflowException exception2)
            {
                Form1.WriteLine(1, string.Concat(new object[] { "Send()_StackOverflowException出错", this.WorldId, "|", this.ToString(), " ", exception2.Message }));
                this.Dispose();
            }
            catch (SocketException exception3)
            {
                Form1.WriteLine(1, string.Concat(new object[] { "Send()_SocketException出错", this.WorldId, "|", this.ToString(), " ", exception3.Message }));
                this.Dispose();
            }
            catch (Exception exception4)
            {
                Form1.WriteLine(1, string.Concat(new object[] { "Send()_Exception出错", this.WorldId, "|", this.ToString(), " ", exception4.Message }));
                this.Dispose();
            }
        }

        public void SendPak(PacketData pak, int id, int wordid)
        {
            try
            {
                byte[] buffer = pak.ToArray2(id, wordid);
                if ((buffer.Length == 46) && (id != 27136))
                {
                    //Form1.WriteLine(1, "SendPak主循环" + id);
                }
                this.Send多包加密(buffer, buffer.Length, 1);
            }
            catch (Exception exception)
            {
                Form1.WriteLine(1, string.Concat(new object[] { "Send()_Send多包知道错误", this.WorldId, "主循环", id, "|", exception.Message }));
            }
        }

        public void SendPak(PacketData pak, int id, int wordid, byte byte_4)
        {
            try
            {
                byte[] data = pak.ToPacket(id, wordid, byte_4);
                this.Send多包(data, data.Length);
            }
            catch (Exception ex)
            {
                Form1.WriteLine(1, "Send()_Send多包知道错误" + (object)this.WorldId + "主循环" + (string)(object)id + "|" + ex.Message);
            }
        }

        public void SendPak2(PacketData pak, int id, int wordid)
        {
            try
            {
                byte[] toSendBuff = pak.ToArray2(id, wordid);
                if (toSendBuff[0] != 170)
                {
                    byte[] dst = new byte[toSendBuff.Length + 15];
                    dst[0] = 170;
                    dst[1] = 85;
                    System.Buffer.BlockCopy(BitConverter.GetBytes((int)(toSendBuff.Length + 9)), 0, dst, 2, 2);
                    System.Buffer.BlockCopy(toSendBuff, 0, dst, 5, toSendBuff.Length);
                    dst[dst.Length - 2] = 85;
                    dst[dst.Length - 1] = 170;
                    this.Send单包(dst, dst.Length);
                }
                else
                {
                    this.Send单包(toSendBuff, toSendBuff.Length);
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
                    //Form1.WriteLine(0, "ThreadProca");
                }
                if (((this.m_Socket != null) && this.m_Running) && this.m_Socket.Connected)
                {
                    try
                    {
                        SendQueue.Gram gram;
                        using (new Lock(this.m_SendQueue, "Send"))
                        {
                            gram = this.m_SendQueue.Enqueue(toSendBuff, len);
                        }
                        if (gram != null)
                        {
                            try
                            {
                                this.m_Socket.BeginSend(gram.Buffer, 0, gram.Length, SocketFlags.None, this.m_OnSend, this.m_Socket);
                            }
                            catch (Exception)
                            {
                                this.Dispose(false);
                            }
                        }
                    }
                    catch (CapacityExceededException)
                    {
                        Form1.WriteLine(1, string.Concat(new object[] { "Send()_数据列队以满", this.WorldId, "|", this.ToString() }));
                        this.Dispose(false);
                    }
                }
            }
            catch (StackOverflowException)
            {
                this.Dispose(false);
            }
            catch (SocketException)
            {
                this.Dispose(false);
            }
            catch (Exception)
            {
                this.Dispose(false);
            }
        }

        public void Send单包(byte[] toSendBuff, int len)
        {
            if (World.JlMsg == 1)
            {
                Form1.WriteLine(0, "Send单包()");
            }
            if (((this.m_Socket != null) && this.m_Running) && this.m_Socket.Connected)
            {
                byte[] dst = new byte[BitConverter.ToInt16(toSendBuff, 9) + 7];
                System.Buffer.BlockCopy(toSendBuff, 5, dst, 0, dst.Length);
                this.Send单包封装发送(dst, dst.Length);
            }
        }

        public void Send多包(byte[] toSendBuff, int len)
        {
            if (World.JlMsg == 1)
            {
                Form1.WriteLine(0, "Send多包()");
            }
            if ((this.m_Socket != null) && this.m_Running)
            {
                int num = 0;
                try
                {
                    num = 1;
                    byte[] dst = new byte[BitConverter.ToInt16(toSendBuff, 9) + 6];
                    num = 2;
                    System.Buffer.BlockCopy(toSendBuff, 5, dst, 0, dst.Length);
                    this.Send多包加密(dst, dst.Length, 1);
                }
                catch (Exception exception)
                {
                    string str = Converter.ToString(toSendBuff);
                    Form1.WriteLine(1, string.Concat(new object[] { "Send()_Send多包", this.WorldId, "|", exception.Message, "错误地方", num, "封包", str }));
                }
            }
        }

        public void Send多包11(byte[] toSendBuff, int len)
        {
            if (((this.m_Socket != null) && this.m_Running) && this.m_Socket.Connected)
            {
                IO_Net_DATA t_data = new IO_Net_DATA();
                GCHandle.Alloc(t_data);
                t_data.NetStat = this;
                try
                {
                    byte[] dst = new byte[BitConverter.ToInt16(toSendBuff, 9) + 6];
                    System.Buffer.BlockCopy(toSendBuff, 5, dst, 0, dst.Length);
                    this.BuffPool.Enqueue(dst);
                }
                catch (Exception exception)
                {
                    Form1.WriteLine(1, string.Concat(new object[] { "Send()_Send多包", this.WorldId, "|", exception.Message }));
                }
            }
        }

        public void Start()
        {
            this.m_OnReceive = new AsyncCallback(this.OnReceive);
            this.m_OnSend = new AsyncCallback(this.OnSend);
            this.m_Running = true;
            if (this.m_Socket == null)
            {
                this.Dispose(false);
            }
            else
            {
                try
                {
                    if ((this.m_AsyncState & (Network.NetState.AsyncState.Paused | Network.NetState.AsyncState.Pending)) == 0)
                    {
                        byte[] array = new byte[Marshal.SizeOf(0) * 3];
                        BitConverter.GetBytes((uint) 1).CopyTo(array, 0);
                        BitConverter.GetBytes((uint) 20000).CopyTo(array, Marshal.SizeOf(0));
                        BitConverter.GetBytes((uint) 20000).CopyTo(array, (int) (Marshal.SizeOf(0) * 2));
                        this.m_Socket.UseOnlyOverlappedIO = true;
                        this.InternalBeginReceive(array);
                    }
                }
                catch (Exception exception)
                {
                    Form1.WriteLine(1, string.Concat(new object[] { "Start()出错", this.WorldId, "|", this.ToString(), " ", exception.Message }));
                    this.Dispose(false);
                }
            }
        }

        public override string ToString()
        {
            return this.m_ToString;
        }

        public static string WTRegedit(string luj, string name, string tovalue)
        {
            try
            {
                Registry.LocalMachine.OpenSubKey(luj, true).SetValue(name, tovalue);
                return "修改成功";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public void 发送(string msg)
        {
            try
            {
                byte[] bytes = Encoding.Default.GetBytes(msg);
                this.SendTo(bytes, bytes.Length);
            }
            catch (Exception)
            {
            }
        }

        public void 离线挂机()
        {
            if (this.m_Socket != null)
            {
                try
                {
                    this.m_Socket.Shutdown(SocketShutdown.Both);
                }
                catch (Exception exception2)
                {
                    Console.WriteLine(exception2);
                }
                try
                {
                    this.m_Socket.Close();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
                this.m_Socket = null;
                this.退出 = true;
                this.FLD_Offline = true;
            }
        }

        public ByteQueue Buffer
        {
            get
            {
                return this.m_Buffer;
            }
        }

        public bool FLD_Offline
        {
            get
            {
                return this._FLD_Offline;
            }
            set
            {
                this._FLD_Offline = value;
            }
        }

        public Players Player
        {
            get
            {
                return this._Player;
            }
            set
            {
                this._Player = value;
            }
        }

        public bool Running
        {
            get
            {
                return this.m_Running;
            }
        }

        [Flags]
        private enum AsyncState
        {
            Paused = 2,
            Pending = 1
        }

        [StructLayout(LayoutKind.Sequential)]
        public class IO_Net_DATA
        {
            public NetState NetStat;
        }
    }
}


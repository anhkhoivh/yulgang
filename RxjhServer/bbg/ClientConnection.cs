using bbg;
using RxjhServer.RxjhServer;

namespace bbg
{
    using RxjhServer;
    using System;
    using System.Net.Sockets;
    using System.Text;

    public class ClientConnection : SockClienT
    {
        public ClientConnection(Socket sock, RemoveClientDelegateE rcd) : base(sock, rcd)
        {
        }

        public void DataReceived(byte[] data, int length)
        {
            if (World.JlMsg == 1)
            {
                Form1.WriteLine(0, "ProcessDataReceived()");
            }
            try
            {
                byte[] bytes = new byte[length];
                for (int i = 0; i < length; ++i)
                {
                    bytes[i] = data[i];
                }
                string str3 = Encoding.Default.GetString(bytes);
                string str2 = "-1";
                string[] strArray = str3.Split(new char[] { ',' });
                string str = strArray[0];
                if (str != null)
                {
                    if (str == "用户登陆")
                    {
                        if (World.检查玩家(strArray[1]) == null)
                        {
                            str2 = "登陆失败";
                        }
                        else
                        {
                            str2 = "登陆成功";
                        }
                    }
                    else if (str != "查询")
                    {
                        if (!(str == "购买"))
                        {
                            goto Label_01FF;
                        }
                        Players players = World.检查玩家(strArray[1]);
                        if ((int.Parse(strArray[4]) >= 0) && (int.Parse(strArray[3]) >= 1))
                        {
                            if (players == null)
                            {
                                str2 = "-1";
                            }
                            else
                            {
                                百宝阁类 百宝阁类;
                                if (World.百宝阁属性物品类list.TryGetValue(int.Parse(strArray[2]), out 百宝阁类))
                                {
                                    //str2 = players.百宝阁买卖东西(int.Parse(strArray[2]), int.Parse(strArray[3]), int.Parse(strArray[4]), 百宝阁类.MAGIC0, 百宝阁类.MAGIC1, 百宝阁类.MAGIC2, 百宝阁类.MAGIC3, 百宝阁类.MAGIC4, 百宝阁类.中级魂, 百宝阁类.觉醒, 百宝阁类.进化, 百宝阁类.绑定, 百宝阁类.使用天数);
                                    str2 =  "购买错误";
                                }
                            }
                        }
                        else
                        {
                            str2 = "-1";
                            players.Dispose();
                        }
                    }
                    else
                    {
                        Players players2 = World.检查玩家(strArray[1]);
                        if (players2 == null)
                        {
                            str2 = "-1";
                        }
                        else if (strArray[2] == "热血元宝")
                        {
                            players2.查百宝阁元宝数();
                            str2 = players2.FLD_RXPIONT.ToString();
                        }
                        else if (strArray[2] == "赠品元宝")
                        {
                            str2 = "0";
                        }
                        else if (strArray[2] == "空位")
                        {
                            str2 = players2.得到包裹空位数().ToString();
                        }
                    }
                    goto Label_0206;
                }
            Label_01FF:
                str2 = "-1";
            Label_0206:
                this.Sendd(str2);
            }
            catch (Exception)
            {
                base.Dispose();
            }
        }

        public override void ProcessDataReceived(byte[] data, int length)
        {
            int index = 0;
            if ((170 != data[0]) || (102 != data[1]))
            {
                Form1.WriteLine(1, string.Concat(new object[] { "错包：", data[0], " ", data[1] }));
                return;
            }
            byte[] dst = new byte[4];
            Buffer.BlockCopy(data, 2, dst, 0, 4);
            int count = BitConverter.ToInt32(dst, 0);
            if (length < (count + 6))
            {
                return;
            }
            while (true)
            {
                if (World.JlMsg == 1)
                {
                    Form1.WriteLine(0, "ProcessDataReceived");
                }
                byte[] buffer2 = new byte[count];
                Buffer.BlockCopy(data, index + 6, buffer2, 0, count);
                index += count + 6;
                this.DataReceived(buffer2, count);
                if (((index >= length) || (data[index] != 170)) || (data[index + 1] != 102))
                {
                    return;
                }
                Buffer.BlockCopy(data, index + 2, dst, 0, 4);
                count = BitConverter.ToInt16(dst, 0);
            }
        }
    }
}


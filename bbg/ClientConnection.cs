using RxjhServer;
using RxjhServer.RxjhServer;
using System;
using System.Net.Sockets;
using System.Text;

namespace bbg
{
	public class ClientConnection : SockClienT
	{
		public ClientConnection(Socket sock, RemoveClientDelegateE rcd)
			: base(sock, rcd)
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
				byte[] array = new byte[length];
				for (int i = 0; i < length; i++)
				{
					array[i] = data[i];
				}
				string @string = Encoding.Default.GetString(array);
				string str = "-1";
				string[] array2 = @string.Split(',');
				string text = array2[0];
				if (text == null)
				{
					goto IL_0235;
				}
				if (text == "用户登陆")
				{
					str = ((World.检查玩家(array2[1]) != null) ? "登陆成功" : "登陆失败");
				}
				else if (text != "查询")
				{
					if (!(text == "购买"))
					{
						goto IL_0235;
					}
					Players players = World.检查玩家(array2[1]);
					if (int.Parse(array2[4]) >= 0 && int.Parse(array2[3]) >= 1)
					{
						百宝阁类 value;
						if (players == null)
						{
							str = "-1";
						}
						else if (World.百宝阁属性物品类list.TryGetValue(int.Parse(array2[2]), out value))
						{
							str = "购买错误";
						}
					}
					else
					{
						str = "-1";
						players.GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 1", 7);
						players.Dispose();
					}
				}
				else
				{
					Players players2 = World.检查玩家(array2[1]);
					if (players2 == null)
					{
						str = "-1";
					}
					else if (array2[2] == "热血元宝")
					{
						players2.查百宝阁元宝数();
						str = players2.FLD_RXPIONT.ToString();
					}
					else if (array2[2] == "赠品元宝")
					{
						str = "0";
					}
					else if (array2[2] == "空位")
					{
						str = players2.得到包裹空位数().ToString();
					}
				}
				goto IL_023b;
				IL_023b:
				Sendd(str);
				goto end_IL_0020;
				IL_0235:
				str = "-1";
				goto IL_023b;
				end_IL_0020:;
			}
			catch (Exception)
			{
				Dispose();
			}
		}

		public override void ProcessDataReceived(byte[] data, int length)
		{
			int num = 0;
			if (170 != data[0] || 102 != data[1])
			{
				Form1.WriteLine(1, "错包：" + data[0] + " " + data[1]);
				return;
			}
			byte[] array = new byte[4];
			Buffer.BlockCopy(data, 2, array, 0, 4);
			int num2 = BitConverter.ToInt32(array, 0);
			if (length < num2 + 6)
			{
				return;
			}
			while (true)
			{
				bool flag = true;
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
}

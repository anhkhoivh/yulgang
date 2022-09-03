using Network;
using RxjhServer.RxjhServer;
using System;

namespace RxjhServer
{
	public class 收服宠物 : IDisposable
	{
		private double UJy96HYE2;

		private float dMhE6tYEQ;

		private float vnHUmDy45;

		private float float_0;

		private float EQ7qGD62R;

		private float ox7nFtNl8;

		private float PB2yYiD6F;

		private float akU2NCwdc;

		private float QqPhUBrRh;

		private int KHlJng0KL;

		private int int_0;

		private int JFPMtxgSJ;

		private int oprPIXlpH;

		private int int_1;

		private int pqxSpBGQl;

		private int PPk8tjEMe;

		public Players players_0;

		private string cGk1BVYJt;

		static 收服宠物()
		{
			old_acctor_mc();
		}

		private static void old_acctor_mc()
		{
		}

		public 收服宠物()
		{
		}

		public 收服宠物(Players players_1, int int_7)
		{
			players_0 = players_1;
			method_9(players_1.UserSessionID + 30000);
			method_31(100);
			method_33(100);
			method_27(players_1.Player_FLD_Map);
			method_15(players_1.Player_FLD_X);
			method_17(players_1.Player_FLD_Y);
			method_19(players_1.Player_FLD_Z);
			method_1(0f);
			method_3(0f);
			method_11(int_7);
		}

		public void Dispose()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "NpcClass_Dispose");
			}
			try
			{
				players_0 = null;
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "NPC 关闭数据Dispose() 出错：" + arg);
			}
		}

		~收服宠物()
		{
		}

		public float method_0()
		{
			return dMhE6tYEQ;
		}

		public void method_1(float float_8)
		{
			dMhE6tYEQ = float_8;
		}

		public int method_10()
		{
			return JFPMtxgSJ;
		}

		public void method_11(int int_7)
		{
			JFPMtxgSJ = int_7;
		}

		public double method_12()
		{
			return UJy96HYE2;
		}

		public void method_13(double double_1)
		{
			UJy96HYE2 = double_1;
		}

		public float method_14()
		{
			return float_0;
		}

		public void method_15(float float_8)
		{
			float_0 = float_8;
		}

		public float method_16()
		{
			return EQ7qGD62R;
		}

		public void method_17(float float_8)
		{
			EQ7qGD62R = float_8;
		}

		public float method_18()
		{
			return ox7nFtNl8;
		}

		public void method_19(float float_8)
		{
			ox7nFtNl8 = float_8;
		}

		public float method_2()
		{
			return vnHUmDy45;
		}

		public float method_20()
		{
			return PB2yYiD6F;
		}

		public void method_21(float float_8)
		{
			PB2yYiD6F = float_8;
		}

		public float method_22()
		{
			return akU2NCwdc;
		}

		public void method_23(float float_8)
		{
			akU2NCwdc = float_8;
		}

		public float method_24()
		{
			return QqPhUBrRh;
		}

		public void method_25(float float_8)
		{
			QqPhUBrRh = float_8;
		}

		public int method_26()
		{
			return oprPIXlpH;
		}

		public void method_27(int int_7)
		{
			oprPIXlpH = int_7;
		}

		public int method_28()
		{
			return int_1;
		}

		public void method_29(int int_7)
		{
			int_1 = int_7;
		}

		public void method_3(float float_8)
		{
			vnHUmDy45 = float_8;
		}

		public int method_30()
		{
			return pqxSpBGQl;
		}

		public void method_31(int int_7)
		{
			pqxSpBGQl = int_7;
		}

		public int method_32()
		{
			return PPk8tjEMe;
		}

		public void method_33(int int_7)
		{
			PPk8tjEMe = int_7;
		}

		public bool 查找范围玩家(int int_7, Players players_1)
		{
			if (players_1.Player_FLD_Map != method_26())
			{
				return false;
			}
			if (players_0.Player_FLD_Map == 7301)
			{
				int_7 = 1000;
			}
			float num = players_0.Player_FLD_X - method_14();
			float num2 = players_0.Player_FLD_Y - method_16();
			float num3 = (int)Math.Sqrt(num * num + num2 * num2);
			return num3 <= (float)int_7;
		}

		public void method_35(int int_7)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "NpcClass_获取范围玩家发送增加数据包");
			}
			method_27(players_0.Player_FLD_Map);
			try
			{
				foreach (Players value in World.AllConnectedChars.Values)
				{
					if (查找范围玩家(400, value))
					{
						method_37(value);
						if (int_7 == 1)
						{
							method_36(value);
						}
					}
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "获取范围玩家发送地面增加Npc数据包 出错：" + arg);
			}
		}

		public void method_36(Players players_1)
		{
			using (PacketData packetData = new PacketData())
			{
				packetData.WriteInt(1);
				packetData.WriteShort(method_8());
				packetData.WriteShort(method_8());
				packetData.WriteShort(method_10());
				packetData.WriteInt(1);
				packetData.WriteInt(method_32());
				packetData.WriteInt(method_30());
				packetData.WriteFloat(method_14());
				packetData.WriteFloat(method_18());
				packetData.WriteFloat(method_16());
				packetData.WriteInt(1082130432);
				packetData.WriteFloat(method_0());
				packetData.WriteFloat(method_2());
				packetData.WriteFloat(method_14());
				packetData.WriteFloat(method_18());
				packetData.WriteFloat(method_16());
				packetData.WriteInt(0);
				packetData.WriteInt(0);
				packetData.WriteInt(12);
				packetData.WriteInt(0);
				if (players_1.Client != null)
				{
					players_1.Client.SendPak(packetData, 26368, players_1.UserSessionID);
				}
			}
		}

		public void method_37(Players players_1)
		{
			using (PacketData packetData = new PacketData())
			{
				packetData.WriteInt(1);
				packetData.WriteShort(method_8());
				packetData.WriteShort(method_8());
				packetData.WriteShort(method_10());
				packetData.WriteInt(1);
				packetData.WriteInt(-1);
				packetData.WriteInt(-1);
				packetData.WriteFloat(method_14());
				packetData.WriteFloat(method_18());
				packetData.WriteFloat(method_16());
				packetData.WriteInt(1082130432);
				packetData.WriteFloat(method_0());
				packetData.WriteFloat(method_2());
				packetData.WriteFloat(method_14());
				packetData.WriteFloat(method_18());
				packetData.WriteFloat(method_16());
				packetData.WriteInt(0);
				packetData.WriteInt(0);
				packetData.WriteInt(12);
				packetData.WriteInt(0);
				if (players_1.Client != null)
				{
					players_1.Client.SendPak(packetData, 26624, players_1.UserSessionID);
				}
			}
		}

		public int method_4()
		{
			return KHlJng0KL;
		}

		public void method_5(int int_7)
		{
			KHlJng0KL = int_7;
		}

		public string method_6()
		{
			return cGk1BVYJt;
		}

		public void method_7(string string_1)
		{
			cGk1BVYJt = string_1;
		}

		public int method_8()
		{
			return int_0;
		}

		public void method_9(int int_7)
		{
			int_0 = int_7;
		}
	}
}

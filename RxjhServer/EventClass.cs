using DbClss;
using RxjhServer.RxjhServer;
using System;
using System.Data;
using System.Threading;
using System.Timers;
using YulgangServer.RxjhServer.DbClss;

namespace RxjhServer
{
	public class EventClass : IDisposable
	{
		private System.Timers.Timer Time_War_Countdown;

		private System.Timers.Timer Time_War_Start;

		private System.Timers.Timer Time_War_End;

		private System.Timers.Timer Time_War_Add_Boss;

		private System.Timers.Timer e;

		private DateTime eval_g;

		private int eval_h;

		private DateTime kssj;

		private int EventTop_Winer;

		private int EventTop_Loser;

		public EventClass()
		{
			try
			{
				if (World.JlMsg == 1)
				{
					Form1.WriteLine(0, "EventClass-");
				}
				World.EventTop.Clear();
				kssj = DateTime.Now.AddMinutes(5.0);
				World.势力战进程 = 1;
				World.势力战正分数 = 0;
				World.势力战邪分数 = 0;
				Time_War_Countdown = new System.Timers.Timer(10000.0);
				Time_War_Countdown.Elapsed += 时间结束事件1;
				Time_War_Countdown.Enabled = true;
				Time_War_Countdown.AutoReset = true;
				时间结束事件1(null, null);
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "势力战 EventClass 出错：" + arg);
			}
		}

		public void Dispose()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "EventClass-Dispose");
			}
			World.势力战进程 = 0;
			World.势力战时间 = 0;
			World.势力战正分数 = 0;
			World.势力战邪分数 = 0;
			if (Time_War_Countdown != null)
			{
				Time_War_Countdown.Enabled = false;
				Time_War_Countdown.Close();
				Time_War_Countdown.Dispose();
			}
			if (Time_War_Start != null)
			{
				Time_War_Start.Enabled = false;
				Time_War_Start.Close();
				Time_War_Start.Dispose();
			}
			if (Time_War_End != null)
			{
				Time_War_End.Enabled = false;
				Time_War_End.Close();
				Time_War_End.Dispose();
			}
			if (Time_War_Add_Boss != null)
			{
				Time_War_Add_Boss.Enabled = false;
				Time_War_Add_Boss.Close();
				Time_War_Add_Boss.Dispose();
			}
			foreach (Players value in World.AllConnectedChars.Values)
			{
				if (value.Player_FLD_Map == 801)
				{
					value.Move(420f, 1550f, 15f, 101);
				}
			}
			World.势力战正人数 = 0;
			World.势力战邪人数 = 0;
			World.EventClass = null;
			World.DelNpc(801, 15137);
		}

		public void jl(string sl)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "EventClass-jl");
			}
			DataTable dBToDataTable = DBA.GetDBToDataTable($"Select * from [EventTop] where 势力='{sl}' Order By 杀人数 Desc,死亡数 Asc");
			if (dBToDataTable == null || dBToDataTable.Rows.Count <= 0)
			{
				return;
			}
			for (int i = 0; i < dBToDataTable.Rows.Count; i++)
			{
				Players players = World.FindPlayerbyName(dBToDataTable.Rows[i]["人物名"].ToString());
				if (players != null)
				{
					foreach (DropClass item in DropClass.GetJlDrop(i * (100 / dBToDataTable.Rows.Count)))
					{
						if (item != null)
						{
							switch (item.FLD_PID)
							{
							case 800000001:
							{
								int num15 = item.FLD_MAGIC0 = new Random(World.GetRandomSeed()).Next(100010, 100026);
								break;
							}
							case 800000002:
							{
								int num13 = item.FLD_MAGIC0 = new Random(World.GetRandomSeed()).Next(200010, 200021);
								break;
							}
							case 800000013:
							{
								Random random = new Random(World.GetRandomSeed());
								int num10 = random.Next(8, 10);
								string arg = "0000";
								int num11 = 0;
								num11 = random.Next(1, 3);
								string s2 = num10.ToString() + arg + num11;
								item.FLD_MAGIC0 = int.Parse(s2);
								break;
							}
							case 800000023:
							{
								int num9 = item.FLD_MAGIC0 = new Random(World.GetRandomSeed()).Next(700020, 700031);
								break;
							}
							case 800000024:
							{
								int num7 = item.FLD_MAGIC0 = new Random(World.GetRandomSeed()).Next(200018, 200026);
								break;
							}
							case 800000025:
							{
								int num5 = item.FLD_MAGIC0 = new Random(World.GetRandomSeed()).Next(1000005, 1000021);
								break;
							}
							case 800000026:
							{
								int num3 = item.FLD_MAGIC0 = new Random(World.GetRandomSeed()).Next(700015, 700026);
								break;
							}
							case 800000028:
							{
								int num = new Random(World.GetRandomSeed()).Next(1, 7);
								string str = "200";
								string str2 = "000";
								string s = str + num.ToString() + str2;
								item.FLD_MAGIC0 = int.Parse(s);
								break;
							}
							}
							int num16 = players.Find_Package_Empty(players);
							if (num16 != -1)
							{
								byte[] bytes = BitConverter.GetBytes(item.FLD_PID);
								byte[] bytes2 = BitConverter.GetBytes(1);
								byte[] array = new byte[20];
								byte[] bytes3 = BitConverter.GetBytes(RxjhClass.GetDbItmeId());
								Buffer.BlockCopy(BitConverter.GetBytes(item.FLD_MAGIC0), 0, array, 0, 4);
								Buffer.BlockCopy(BitConverter.GetBytes(item.FLD_MAGIC1), 0, array, 4, 4);
								Buffer.BlockCopy(BitConverter.GetBytes(item.FLD_MAGIC2), 0, array, 8, 4);
								Buffer.BlockCopy(BitConverter.GetBytes(item.FLD_MAGIC3), 0, array, 12, 4);
								Buffer.BlockCopy(BitConverter.GetBytes(item.FLD_MAGIC4), 0, array, 16, 4);
								players._Make_Item_Option(bytes3, bytes, num16, bytes2, array);
							}
						}
					}
				}
			}
		}

		public void 时间结束事件1(object sender, ElapsedEventArgs e)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "EventClass_时间结束事件1");
			}
			try
			{
				int num = (int)kssj.Subtract(DateTime.Now).TotalSeconds;
				if (num <= 0)
				{
					World.势力战进程 = 2;
					World.势力战正分数 = 0;
					World.势力战邪分数 = 0;
					num = 0;
				}
				eval_h = num;
				foreach (Players value in World.AllConnectedChars.Values)
				{
					if (value.Player_FLD_Map == 801)
					{
						value.Packet_Time_In_Map_War_Class_All(eval_h);
					}
					else if (value.Player_Job_Level >= 3 && DateTime.Now.Minute >= World.势力战开启分)
					{
						value.发送势力战邀请广播2();
					}
				}
				if (eval_h <= 0)
				{
					Time_War_Countdown.Enabled = false;
					Time_War_Countdown.Close();
					Time_War_Countdown.Dispose();
					World.势力战进程 = 3;
					eval_g = DateTime.Now.AddMinutes(20.0);
					Time_War_Start = new System.Timers.Timer(10000.0);
					Time_War_Start.Elapsed += 时间结束事件2;
					Time_War_Start.Enabled = true;
					Time_War_Start.AutoReset = true;
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "势力战 时间结束事件1 出错：" + arg);
			}
		}

		public void 时间结束事件2(object sender, ElapsedEventArgs e)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "EventClass_时间结束事件2");
			}
			try
			{
				int num = World.势力战时间 = (int)eval_g.Subtract(DateTime.Now).TotalSeconds;
				foreach (Players value2 in World.AllConnectedChars.Values)
				{
					if (value2.Player_FLD_Map == 801)
					{
						value2.发送势力战消息();
						if (World.AFKTLC == 1 && ((num >= 850 && num <= 900) || (num >= 550 && num <= 600) || (num >= 250 && num <= 300)))
						{
							if (World.EventTop.TryGetValue(value2.UserName, out EventTopClass value))
							{
								if (value.杀人数 < 1 && value.死亡数 < 5)
								{
									value2.GameMessage("ÐaÞ quaì thõÌi gian quy ðiònh maÌ baòn vâÞn chýa ðaòt yêu câÌu!", 22);
									if (World.Newversion >= 14 && World.Newversion <= 15)
									{
										value2.Move(500f, 1750f, 15f, 101);
									}
									else
									{
										value2.Move(412f, 1542f, 15f, 101);
									}
								}
							}
							else
							{
								value2.GameMessage("ÐaÞ quaì thõÌi gian quy ðiònh maÌ baòn vâÞn chýa ðaòt yêu câÌu!", 22);
								if (World.Newversion >= 14 && World.Newversion <= 15)
								{
									value2.Move(500f, 1750f, 15f, 101);
								}
								else
								{
									value2.Move(412f, 1542f, 15f, 101);
								}
							}
						}
					}
					else
					{
						value2.发送势力战刷新分数();
					}
					value2.发送势力战刷新分数();
				}
				if (num <= 0)
				{
					Time_War_Start.Enabled = false;
					Time_War_Start.Close();
					Time_War_Start.Dispose();
					World.势力战进程 = 4;
					Time_War_End = new System.Timers.Timer(10000.0);
					Time_War_End.Elapsed += 时间结束事件3;
					Time_War_End.Enabled = true;
					Time_War_End.AutoReset = false;
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "势力战 时间结束事件2 出错：" + arg);
			}
		}

		public void 时间结束事件3(object sender, ElapsedEventArgs e)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "EventClass_时间结束事件3");
			}
			try
			{
				DBA.ExeSqlCommand("DELETE FROM EventTop");
				foreach (EventTopClass value2 in World.EventTop.Values)
				{
					DBA.ExeSqlCommand($"INSERT INTO EventTop (人物名,帮派,势力,等级,杀人数,死亡数)values('{value2.人物名}','{value2.帮派}','{value2.势力}',{value2.等级},{value2.杀人数},{value2.死亡数})");
				}
				if (World.势力战正分数 > World.势力战邪分数)
				{
					EventTop_Winer = 1;
					EventTop_Loser = 2;
					World.发送公告("Kêìt thuìc thêì lýòc chiêìn, chiình phaìi giaÌnh chiêìn thãìng");
				}
				else if (World.势力战正分数 == World.势力战邪分数)
				{
					EventTop_Winer = 3;
					EventTop_Loser = 3;
					World.发送公告("Kêìt thuìc thêì lýòc chiêìn, chinh taÌ hoÌa nhau!");
				}
				else
				{
					EventTop_Winer = 2;
					EventTop_Loser = 1;
					World.发送公告("Kêìt thuìc thêì lýòc chiêìn, taÌ phaìi giaÌnh chiêìn thãìng");
				}
				foreach (Players value3 in World.AllConnectedChars.Values)
				{
					if (value3.Player_FLD_Map == 801)
					{
						value3.Packet_Show_Flag_Win_Class_All(EventTop_Winer);
						if (value3.Player_Zx == EventTop_Winer)
						{
							if (World.势力战奖励类型 == 1 || World.势力战奖励类型 == 4)
							{
								string[] array = World.势力战奖励属性.Split(';');
								string[] array2 = World.升级会员需要属性.Split(',');
								if (int.Parse(array[0]) != 0)
								{
									value3.奖励_追加_生命 += long.Parse(array[0]);
									value3.GameMessage("Sinh mêònh: " + long.Parse(array[0]), 10);
								}
								if (long.Parse(array[1]) != 0 && value3.奖励_追加_攻击 < long.Parse(array2[0]))
								{
									value3.奖励_追加_攻击 += long.Parse(array[1]);
									value3.GameMessage("Tâìn công: " + long.Parse(array[1]), 10);
								}
								if (long.Parse(array[2]) != 0 && value3.奖励_追加_防御 < long.Parse(array2[1]))
								{
									value3.奖励_追加_防御 += long.Parse(array[2]);
									value3.GameMessage("PhoÌng thuÒ: " + long.Parse(array[2]), 10);
								}
								if (int.Parse(array[3]) != 0)
								{
									value3.奖励_追加_回避 += int.Parse(array[3]);
									value3.GameMessage("Neì traình: " + int.Parse(array[3]), 10);
								}
								if (int.Parse(array[4]) != 0)
								{
									value3.奖励_追加_内功 += int.Parse(array[4]);
									value3.GameMessage("Nôòi công: " + int.Parse(array[4]), 10);
								}
								if (int.Parse(array[5]) != 0)
								{
									value3.奖励_追加_命中 += int.Parse(array[5]);
									value3.GameMessage("Chiình xaìc: " + int.Parse(array[5]), 10);
								}
								if (int.Parse(array[6]) != 0)
								{
									value3.查百宝阁元宝数();
									value3.Add_Del_Rxpiont(int.Parse(array[6]), 1);
									value3.GameMessage("Nhâòn ðýõòc " + int.Parse(array[6]) + " @CASH！", 6);
									value3.Save_data_Rxpiont();
								}
								if (int.Parse(array[7]) != 0)
								{
									value3.Player_WuXun += int.Parse(array[7]);
									value3.GameMessage("Nhâòn ðýõòc " + int.Parse(array[7]) + " ðiêÒm voÞ huân", 6);
									value3.UpdatePowersAndStatus();
								}
								if (int.Parse(array[8]) != 0)
								{
									if (World.AllConnectedChars.TryGetValue(value3.UserSessionID, out Players _))
									{
										DateTime now = DateTime.Now;
										now = DateTime.Now.AddDays(int.Parse(array[8]));
										value3.FLD_VIP = 1;
										value3.FLD_VIPTIM = now;
										value3.保存会员数据();
									}
									value3.GameMessage("Chuìc mýÌng, baòn nhâòn ðýõòc " + int.Parse(array[8]) + " ngaÌy VIP!", 10);
								}
								if (World.势力战奖励类型 == 4)
								{
									int num = value3.Find_Package_Empty(value3);
									if (num != -1)
									{
										byte[] bytes = BitConverter.GetBytes(RxjhClass.GetDbItmeId());
										byte[] 物品属性 = new byte[56];
										value3.增加物品(bytes, BitConverter.GetBytes(World.势力战奖励套装), num, BitConverter.GetBytes(2), 物品属性, 绑定: false);
										value3.增加物品(bytes, BitConverter.GetBytes(900000787), num, BitConverter.GetBytes(1), 物品属性, 绑定: true);
										value3.GameMessage("Baòn nhâòn ðýõòc môòt vâòt phâÒm", 7);
									}
									int num2 = value3.Find_Package_Empty(value3);
									if (num2 != -1)
									{
										byte[] bytes = BitConverter.GetBytes(RxjhClass.GetDbItmeId());
										byte[] 物品属性 = new byte[56];
									}
								}
							}
							else
							{
								if (World.势力战奖励类型 == 2)
								{
									int num = value3.Find_Package_Empty(value3);
									if (num != -1)
									{
										byte[] bytes = BitConverter.GetBytes(RxjhClass.GetDbItmeId());
										byte[] 物品属性 = new byte[56];
										value3.增加物品(bytes, BitConverter.GetBytes(World.势力战奖励套装), num, BitConverter.GetBytes(2), 物品属性, 绑定: false);
										value3.增加物品(bytes, BitConverter.GetBytes(900000787), num, BitConverter.GetBytes(1), 物品属性, 绑定: true);
										value3.GameMessage("Baòn nhâòn ðýõòc môòt vâòt phâÒm", 7);
									}
									int num2 = value3.Find_Package_Empty(value3);
									if (num2 != -1)
									{
										byte[] bytes = BitConverter.GetBytes(RxjhClass.GetDbItmeId());
										byte[] 物品属性 = new byte[56];
									}
									continue;
								}
								if (World.势力战奖励类型 == 3)
								{
									string[] array3 = World.势力战奖励物品.Split(';');
									int num3 = value3.Find_Package_Empty(value3);
									if (num3 != -1)
									{
										value3.百宝增加物品带属性(int.Parse(array3[0]), num3, int.Parse(array3[1]), int.Parse(array3[2]), int.Parse(array3[3]), int.Parse(array3[4]), int.Parse(array3[5]), int.Parse(array3[6]), int.Parse(array3[7]), int.Parse(array3[8]), int.Parse(array3[9]), int.Parse(array3[10]), int.Parse(array3[11]));
										value3.GameMessage("Baòn nhâòn ðýõòc môòt vâòt phâÒm", 10);
									}
								}
							}
							int num4 = value3.Find_Package_Empty(value3);
							if (num4 != -1)
							{
								value3.百宝增加物品带属性(1000000207, num4, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
								Random random = new Random();
								int num5 = random.Next(1500, 2500);
								value3.Player_WuXun += num5;
								value3.GameMessage("Baòn nhâòn ðýõòc " + num5 + " ðiêÒm voÞ huân", 10, "TLC");
							}
							else
							{
								value3.GameMessage("Không coÌn chôÞ trôìng!", 10);
							}
						}
						else if (value3.Player_Zx == EventTop_Loser)
						{
							if (World.势力战奖励类型 == 1 || World.势力战奖励类型 == 4)
							{
								string[] array = World.势力战奖励属性.Split(';');
								if (int.Parse(array[6]) != 0)
								{
									value3.查百宝阁元宝数();
									value3.Add_Del_Rxpiont(int.Parse(array[7]) / 2, 1);
									value3.GameMessage("Nhâòn ðýõòc " + int.Parse(array[6]) / 2 + " @CASH！", 6);
									value3.Save_data_Rxpiont();
								}
								if (int.Parse(array[7]) != 0)
								{
									value3.Player_WuXun += int.Parse(array[7]) / 2;
									value3.GameMessage("Nhâòn ðýõòc " + int.Parse(array[7]) / 2 + " ðiêÒm voÞ huân", 6);
									value3.UpdatePowersAndStatus();
								}
								if (World.势力战奖励类型 == 4)
								{
									int num = value3.Find_Package_Empty(value3);
									if (num != -1)
									{
										byte[] bytes = BitConverter.GetBytes(RxjhClass.GetDbItmeId());
										byte[] 物品属性 = new byte[56];
										value3.增加物品(bytes, BitConverter.GetBytes(World.势力战奖励套装), num, BitConverter.GetBytes(2), 物品属性, 绑定: false);
										value3.增加物品(bytes, BitConverter.GetBytes(900000787), num, BitConverter.GetBytes(1), 物品属性, 绑定: true);
										value3.GameMessage("Baòn nhâòn ðýõòc môòt vâòt phâÒm", 7);
									}
									int num2 = value3.Find_Package_Empty(value3);
									if (num2 != -1)
									{
										byte[] bytes = BitConverter.GetBytes(RxjhClass.GetDbItmeId());
										byte[] 物品属性 = new byte[56];
									}
								}
							}
							int num4 = value3.Find_Package_Empty(value3);
							if (num4 != -1)
							{
								value3.百宝增加物品带属性(1000000208, num4, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
								Random random = new Random();
								int num5 = random.Next(500, 1500);
								value3.Player_WuXun += num5;
								value3.GameMessage("Baòn nhâòn ðýõòc " + num5 + " ðiêÒm voÞ huân", 10, "TLC");
							}
							else
							{
								value3.GameMessage("Không coÌn chôÞ trôìng!", 10);
							}
						}
						else
						{
							int num4 = value3.Find_Package_Empty(value3);
							if (num4 != -1)
							{
								value3.百宝增加物品带属性(1000000208, num4, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0);
								Random random = new Random();
								int num5 = random.Next(1000, 1000);
								value3.Player_WuXun += num5;
								value3.GameMessage("Baòn nhâòn ðýõòc " + num5 + " ðiêÒm voÞ huân", 10, "TLC");
							}
							else
							{
								value3.GameMessage("Không coÌn chôÞ trôìng!", 10);
							}
						}
					}
				}
				World.EventTop.Clear();
				World.势力战进程 = 5;
				eval_g = DateTime.Now.AddMinutes(30.0);
				Time_War_End.Enabled = false;
				Time_War_End.Close();
				Time_War_End.Dispose();
				Time_War_Add_Boss = new System.Timers.Timer(6000.0);
				Time_War_Add_Boss.Elapsed += 时间结束事件4;
				Time_War_Add_Boss.Enabled = true;
				Time_War_Add_Boss.AutoReset = true;
				this.e = new System.Timers.Timer(1000.0);
				this.e.Elapsed += 时间结束事件5;
				this.e.Enabled = true;
				this.e.AutoReset = true;
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "势力战 时间结束事件3 出错：" + arg);
			}
		}

		public void 时间结束事件4(object sender, ElapsedEventArgs e)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "EventClass_时间结束事件4");
			}
			try
			{
				int num = World.势力战时间 = (int)eval_g.Subtract(DateTime.Now).TotalSeconds;
				foreach (Players value in World.AllConnectedChars.Values)
				{
					if (value.Player_FLD_Map == 801)
					{
						value.发送势力战消息();
						if (value.Player_Zx != EventTop_Winer && EventTop_Winer != 3)
						{
							value.Move(420f, 1550f, 15f, 101);
						}
					}
				}
				if (num <= 0)
				{
					Time_War_Add_Boss.Enabled = false;
					Time_War_Add_Boss.Close();
					Time_War_Add_Boss.Dispose();
					World.势力战进程 = 6;
					foreach (Players value2 in World.AllConnectedChars.Values)
					{
						if (value2.Player_FLD_Map == 801)
						{
							value2.Move(-220f, 0f, 15f, 801);
						}
					}
					Dispose();
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "势力战 时间结束事件4 出错：" + arg);
			}
		}

		public void 时间结束事件5(object sender, ElapsedEventArgs e)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "EventClass_时间结束事件5");
			}
			try
			{
				this.e.Enabled = false;
				this.e.Close();
				this.e.Dispose();
				foreach (Players value in World.AllConnectedChars.Values)
				{
					if (value.Player_FLD_Map == 801 && (value.Player_Zx == EventTop_Winer || EventTop_Winer == 3))
					{
						value.Move(220f, 0f, 15f, 801);
					}
				}
				Thread.Sleep(1000);
				World.AddNpc(15120, -50f, 50f, 801);
				World.AddNpc(15424, 70f, -50f, 801);
				World.AddNpc(15120, -50f, 70f, 801);
				World.AddNpc(15120, -50f, 50f, 801);
				World.AddNpc(15424, 70f, -50f, 801);
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "势力战 时间结束事件5 出错：" + arg);
			}
		}
	}
}

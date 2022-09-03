using RxjhServer.RxjhServer;
using System;
using System.Collections.Generic;
using System.Timers;

namespace RxjhServer
{
	public class BossClass : IDisposable
	{
		private string[] a = World.野外boss配置.Split(';');

		private System.Timers.Timer eval_b;

		private System.Timers.Timer eval_c;

		private System.Timers.Timer eval_d;

		private DateTime eval_e;

		private static List<int> f;

		static BossClass()
		{
			old_acctor_mc();
		}

		public BossClass()
		{
			f.Clear();
			eval_e = DateTime.Now.AddMinutes(5.0);
			eval_b = new System.Timers.Timer(60000.0);
			eval_b.Elapsed += 发送距离野外BOSS开始时间公告;
			eval_b.Enabled = true;
			eval_b.AutoReset = true;
			发送距离野外BOSS开始时间公告(null, null);
			eval_c = new System.Timers.Timer(300000.0);
			eval_c.Elapsed += 野外BOSS开始;
			eval_c.Enabled = true;
		}

		public void Dispose()
		{
			f.Clear();
			if (eval_b != null)
			{
				eval_b.Enabled = false;
				eval_b.Close();
				eval_b.Dispose();
			}
			if (eval_c != null)
			{
				eval_c.Enabled = false;
				eval_c.Close();
				eval_c.Dispose();
			}
			if (eval_d != null)
			{
				eval_d.Enabled = false;
				eval_d.Close();
				eval_d.Dispose();
			}
			World.野外boss = null;
		}

		private static void old_acctor_mc()
		{
			f = new List<int>();
		}

		public void 发送距离野外BOSS开始时间公告(object sender, ElapsedEventArgs e)
		{
			try
			{
				int num = (int)eval_e.Subtract(DateTime.Now).TotalSeconds;
				if (num != 0)
				{
					foreach (Players value in World.AllConnectedChars.Values)
					{
						value.Packet_Countdown(num);
						value.GameMessage("离BOSS大军入侵泫勃派还剩下" + num / 60 + "分钟.请各位大侠做好迎战准备", 10, "系统广播");
						World.发送公告("离BOSS大军入侵泫勃派还剩下" + num / 60 + "分钟.请各位大侠做好迎战准备");
					}
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "BOSS攻城战 时间结束事件1 出错：" + arg);
			}
		}

		public void 野外BOSS开始(object sender, ElapsedEventArgs e)
		{
			eval_b.Enabled = false;
			eval_b.Close();
			eval_b.Dispose();
			eval_c.Enabled = false;
			eval_c.Close();
			eval_c.Dispose();
			eval_d = new System.Timers.Timer((double)int.Parse(a[6]) * 60000.0);
			eval_d.Elapsed += 野外BOSS战结束;
			eval_d.Enabled = true;
			Random random = new Random(World.GetRandomSeed());
			float num = 1f + (float)int.Parse(a[2]);
			float num2 = 1f + (float)int.Parse(a[3]);
			List<MonSterClss> list = new List<MonSterClss>();
			try
			{
				foreach (Players value in World.AllConnectedChars.Values)
				{
					value.GameMessage("BOSS攻城开始。大家有" + int.Parse(a[6]) + "分钟的时间来清理BOSS", 10, "系统广播");
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "BOSS攻城战 时间结束事件1 出错：" + arg);
			}
			foreach (MonSterClss value2 in World.MonSter.Values)
			{
				if (value2.FLD_BOSS == int.Parse(a[10]))
				{
					list.Add(value2);
				}
			}
			for (int i = 0; i < int.Parse(a[7]); i++)
			{
				int num3 = random.Next(0, 2);
				double num4 = random.Next(0, int.Parse(a[8]));
				double num5 = random.Next(0, int.Parse(a[9]));
				int index = random.Next(0, list.Count);
				int fLD_PID = list[index].FLD_PID;
				float x坐标 = num + (float)num4;
				float y坐标 = num2 + (float)num5;
				float x坐标2 = num - (float)num4;
				float y坐标2 = num2 - (float)num5;
				if (num3 == 0)
				{
					增加怪物BOSS(fLD_PID, x坐标, y坐标, int.Parse(a[1]));
				}
				else
				{
					增加怪物BOSS(fLD_PID, x坐标2, y坐标2, int.Parse(a[1]));
				}
			}
		}

		public void 野外BOSS战结束(object sender, ElapsedEventArgs e)
		{
			eval_d.Enabled = false;
			eval_d.Close();
			eval_d.Dispose();
			int num = 0;
			try
			{
				foreach (int item in f)
				{
					foreach (NpcClass value in MapClass.GetnpcTemplate(int.Parse(a[1])).Values)
					{
						if (value.FldIndex == item)
						{
							num++;
						}
					}
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "计算BOSS攻城的怪物所剩数量出错：" + arg);
			}
			if (num > 0)
			{
				try
				{
					foreach (Players value2 in World.AllConnectedChars.Values)
					{
						value2.系统公告("非常遗憾，怪物们已经占领[" + CoordinateClass.getmapname(int.Parse(a[1])) + "]你们的安全正在受到威胁，请在下一次战斗中务必把可恶的怪物消灭掉");
					}
					Dispose();
				}
				catch (Exception arg2)
				{
					Form1.WriteLine(1, "时间结束事件3 说话 出错：" + arg2);
					Dispose();
				}
			}
			else
			{
				try
				{
					foreach (Players value3 in World.AllConnectedChars.Values)
					{
						value3.系统公告("[" + CoordinateClass.getmapname(int.Parse(a[1])) + "]保卫战中获得胜利");
					}
				}
				catch (Exception arg3)
				{
					Form1.WriteLine(1, "时间结束事件3 说话2 出错：" + arg3);
				}
			}
		}

		public void 增加怪物BOSS(int 怪物PID, float X坐标, float Y坐标, int 地图编号)
		{
			int item = World.AddBossEveNpc(怪物PID, X坐标, Y坐标, 地图编号);
			f.Add(item);
		}
	}
}

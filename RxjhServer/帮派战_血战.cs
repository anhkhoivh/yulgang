using RxjhServer.RxjhServer;
using System;
using System.Timers;
using YulgangServer.RxjhServer.DbClss;

namespace RxjhServer
{
	public class 帮派战_血战
	{
		private System.Timers.Timer b;

		private DateTime d;

		private DateTime e;

		private object eval_a = new object();

		private System.Timers.Timer eval_c;

		public 帮战Class 帮战客方;

		public 帮战Class 帮战主方;

		public int 结束;

		public int 结束2;

		public long 客方分数;

		public long 主方分数;

		public 帮派战_血战(帮战Class 主方, 帮战Class 客方)
		{
			try
			{
				帮战主方 = 主方;
				帮战客方 = 客方;
				结束 = 0;
				using (new Lock(帮战主方.申请人物列表, "帮战客方.申请人物列表"))
				{
					foreach (Players value in 帮战主方.申请人物列表.Values)
					{
						value.GameMessage("Da dang ky War Guild thaÌnh công, Ban co 3 phut de tap trung tai Thi Truong Tien Bac", 8);
						value.GameMessage("mon phai cua ban se dai dien cho mau do", 6);
						value.Packet_Countdown(180);
					}
				}
				using (new Lock(帮战客方.申请人物列表, "帮战客方.申请人物列表"))
				{
					foreach (Players value2 in 帮战客方.申请人物列表.Values)
					{
						value2.GameMessage("Da dang ky War Guild thaÌnh công, Ban co 3 phut de tap trung tai Thi Truong Tien Bac", 8);
						value2.GameMessage("mon phai cua ban se dai dien cho mau xanh bien", 6);
						value2.Packet_Countdown(180);
					}
				}
				d = DateTime.Now.AddMinutes(3.0);
				b = new System.Timers.Timer(180000.0);
				b.Elapsed += 准备记时器结束事件;
				b.Enabled = true;
				b.AutoReset = true;
				准备记时器结束事件(null, null);
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "血帮战 准备记时器结束事件 出错：" + arg);
			}
		}

		public void Dispose()
		{
			if (结束2 != 1)
			{
				try
				{
					string[] array = World.帮战获胜元宝金币数.Split(';');
					string[] array2 = World.帮战平分元宝金币数.Split(';');
					if (主方分数 > 客方分数)
					{
						using (new Lock(帮战主方.申请人物列表, "帮战客方.申请人物列表"))
						{
							foreach (Players value in 帮战主方.申请人物列表.Values)
							{
								if (value.Guild_Level == 6)
								{
									value.查百宝阁元宝数();
									value.Add_Del_Rxpiont(Convert.ToInt32(array[0]), 1);
									value.Player_Money += Convert.ToInt32(array[1]);
									RxjhClass.帮战赌注删除(value.Userid, value.UserName, 帮战主方.申请帮派ID, 1);
									value.Save_data_Rxpiont();
									value.Update_Money_Weight();
								}
								if (结束 == 1)
								{
									value.帮战开始提示(13, 1);
								}
								value.帮战开始提示(12, 3);
								value.帮战开始提示(1, 0);
								value.Move(0f, 0f, 15f, 1201);
							}
						}
						using (new Lock(帮战客方.申请人物列表, "帮战客方.申请人物列表"))
						{
							foreach (Players value2 in 帮战客方.申请人物列表.Values)
							{
								if (value2.Guild_Level == 6)
								{
									RxjhClass.帮战赌注删除(value2.Userid, value2.UserName, 帮战客方.申请帮派ID, -1);
								}
								if (结束 == 1)
								{
									value2.帮战开始提示(13, -1);
								}
								value2.帮战开始提示(12, 3);
								value2.帮战开始提示(1, 0);
								value2.Move(0f, 0f, 15f, 1201);
							}
						}
					}
					else if (客方分数 > 主方分数)
					{
						using (new Lock(帮战主方.申请人物列表, "帮战客方.申请人物列表"))
						{
							foreach (Players value3 in 帮战主方.申请人物列表.Values)
							{
								if (value3.Guild_Level == 6)
								{
									RxjhClass.帮战赌注删除(value3.Userid, value3.UserName, 帮战主方.申请帮派ID, -1);
								}
								if (结束 == 1)
								{
									value3.帮战开始提示(13, -1);
								}
								value3.帮战开始提示(12, 3);
								value3.帮战开始提示(1, 0);
								value3.Move(0f, 0f, 15f, 1201);
							}
						}
						using (new Lock(帮战客方.申请人物列表, "帮战客方.申请人物列表"))
						{
							foreach (Players value4 in 帮战客方.申请人物列表.Values)
							{
								if (value4.Guild_Level == 6)
								{
									value4.查百宝阁元宝数();
									value4.Add_Del_Rxpiont(Convert.ToInt32(array[0]), 1);
									value4.Player_Money += Convert.ToInt32(array[1]);
									RxjhClass.帮战赌注删除(value4.Userid, value4.UserName, 帮战客方.申请帮派ID, 1);
									value4.Save_data_Rxpiont();
									value4.Update_Money_Weight();
								}
								if (结束 == 1)
								{
									value4.帮战开始提示(13, 1);
								}
								value4.帮战开始提示(12, 3);
								value4.帮战开始提示(1, 0);
								value4.Move(0f, 0f, 15f, 1201);
							}
						}
					}
					else if (客方分数 == 主方分数)
					{
						using (new Lock(帮战主方.申请人物列表, "帮战客方.申请人物列表"))
						{
							foreach (Players value5 in 帮战主方.申请人物列表.Values)
							{
								if (value5.Guild_Level == 6)
								{
									value5.查百宝阁元宝数();
									value5.Add_Del_Rxpiont(Convert.ToInt32(array2[0]), 1);
									value5.Player_Money += Convert.ToInt32(array2[1]);
									RxjhClass.帮战赌注删除(value5.Userid, value5.UserName, 帮战主方.申请帮派ID, 0);
									value5.Save_data_Rxpiont();
									value5.Update_Money_Weight();
								}
								if (结束 == 1)
								{
									value5.帮战开始提示(13, 0);
								}
								value5.帮战开始提示(12, 3);
								value5.帮战开始提示(1, 0);
								value5.Move(0f, 0f, 15f, 1201);
							}
						}
						using (new Lock(帮战客方.申请人物列表, "帮战客方.申请人物列表"))
						{
							foreach (Players value6 in 帮战客方.申请人物列表.Values)
							{
								if (value6.Guild_Level == 6)
								{
									value6.查百宝阁元宝数();
									value6.Add_Del_Rxpiont(Convert.ToInt32(array2[0]), 1);
									value6.Player_Money += Convert.ToInt32(array2[1]);
									RxjhClass.帮战赌注删除(value6.Userid, value6.UserName, 帮战客方.申请帮派ID, 0);
									value6.Save_data_Rxpiont();
									value6.Update_Money_Weight();
								}
								if (结束 == 1)
								{
									value6.帮战开始提示(13, 0);
								}
								value6.帮战开始提示(12, 3);
								value6.帮战开始提示(1, 0);
								value6.Move(0f, 0f, 15f, 1201);
							}
						}
					}
					Form1.WriteLine(88, "帮战结束 地图ID:7301 结束ID:" + 结束 + " 主Guild_ID:" + 帮战主方.申请帮派ID + " 主帮派名字:" + 帮战主方.申请帮派名称 + " 帮主:" + 帮战主方.帮主名称 + " 人数:" + 帮战主方.申请人物列表.Count + " 分数:" + 主方分数 + " ---- 客Guild_ID:" + 帮战客方.申请帮派ID + " 客帮派名字:" + 帮战客方.申请帮派名称 + " 帮主:" + 帮战客方.帮主名称 + " 人数:" + 帮战客方.申请人物列表.Count + " 分数:" + 客方分数);
					结束2 = 1;
					if (b != null)
					{
						b.Enabled = false;
						b.Close();
						b.Dispose();
					}
					if (eval_c != null)
					{
						eval_c.Enabled = false;
						eval_c.Close();
						eval_c.Dispose();
					}
					if (帮战主方 != null)
					{
						if (帮战主方.申请人物列表 != null)
						{
							帮战主方.申请人物列表.Clear();
							帮战主方.申请人物列表 = null;
						}
						帮战主方 = null;
					}
					if (帮战客方 != null)
					{
						if (帮战客方.申请人物列表 != null)
						{
							帮战客方.申请人物列表.Clear();
							帮战客方.申请人物列表 = null;
						}
						帮战客方 = null;
					}
					World.血战 = null;
					结束2 = 1;
				}
				catch (Exception arg)
				{
					Form1.WriteLine(1, "血帮战 Dispose() 出错：" + arg);
				}
			}
		}

		public void 开始对战记时器结束事件(object sender, ElapsedEventArgs e)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "开始对战记时器结束事件");
			}
			try
			{
				int num = 0;
				int num2 = 0;
				using (new Lock(帮战主方.申请人物列表, "帮战客方.申请人物列表"))
				{
					foreach (Players value in World.AllConnectedChars.Values)
					{
						if (value.UserName == World.血战.帮战主方.帮主名称)
						{
							主方分数 = value.Player_FLD_HP;
						}
						else if (value.UserName == World.血战.帮战客方.帮主名称)
						{
							客方分数 = value.Player_FLD_HP;
						}
					}
					foreach (Players value2 in 帮战主方.申请人物列表.Values)
					{
						if (value2.关起来 == 1)
						{
							num++;
						}
						value2.帮战更新分数(主方分数, 客方分数);
					}
				}
				using (new Lock(帮战客方.申请人物列表, "帮战客方.申请人物列表"))
				{
					foreach (Players value3 in 帮战客方.申请人物列表.Values)
					{
						if (value3.关起来 == 1)
						{
							num2++;
						}
						value3.帮战更新分数(主方分数, 客方分数);
					}
				}
				int num3 = (int)this.e.Subtract(DateTime.Now).TotalSeconds;
				if (num3 <= 0)
				{
					结束 = 1;
					eval_c.Enabled = false;
					eval_c.Close();
					eval_c.Dispose();
					Dispose();
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "血帮战 开始对战记时器结束事件 出错：" + arg);
			}
		}

		public void 准备记时器结束事件(object sender, ElapsedEventArgs e)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "准备记时器结束事件");
			}
			try
			{
				int num = (int)d.Subtract(DateTime.Now).TotalSeconds;
				if (num <= 0)
				{
					b.Enabled = false;
					b.Close();
					b.Dispose();
					this.e = DateTime.Now.AddMinutes(World.帮战战斗时间);
					eval_c = new System.Timers.Timer(1000.0);
					eval_c.Elapsed += 开始对战记时器结束事件;
					eval_c.Enabled = true;
					eval_c.AutoReset = true;
					using (new Lock(帮战主方.申请人物列表, "帮战客方.申请人物列表"))
					{
						foreach (Players value in 帮战主方.申请人物列表.Values)
						{
							value.GameMessage("Tran War Guild giua [" + 帮战主方.申请帮派名称 + " - RED] vs [" + 帮战客方.申请帮派名称 + " - BLUE] chinh thuc bat dau !!!", 6);
							value.Move(0f, 450f, 15f, 7301);
							value.帮战开始提示(0, World.帮战战斗时间 * 60);
						}
					}
					using (new Lock(帮战客方.申请人物列表, "帮战客方.申请人物列表"))
					{
						foreach (Players value2 in 帮战客方.申请人物列表.Values)
						{
							value2.GameMessage("Tran War Guild giua [" + 帮战客方.申请帮派名称 + " - BLUE] vs [" + 帮战主方.申请帮派名称 + " - RED] chinh thuc bat dau !!!", 6);
							value2.Move(0f, -450f, 15f, 7301);
							value2.帮战开始提示(0, World.帮战战斗时间 * 60);
						}
					}
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "血帮战 准备记时器结束事件 出错：" + arg);
			}
		}
	}
}

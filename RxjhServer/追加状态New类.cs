using RxjhServer.RxjhServer;
using System;
using System.Timers;

namespace RxjhServer
{
	public class 追加状态New类 : IDisposable
	{
		private int b;

		private int c;

		private int eval_a;

		public System.Timers.Timer npcyd;

		public Players Play;

		public DateTime time;

		public int FLD_PID
		{
			get
			{
				return eval_a;
			}
			set
			{
				eval_a = value;
			}
		}

		public int FLD_sj => getsj();

		public int 数量
		{
			get
			{
				return b;
			}
			set
			{
				b = value;
			}
		}

		public int 数量类型
		{
			get
			{
				return c;
			}
			set
			{
				c = value;
			}
		}

		public 追加状态New类(Players Play_, int 物品ID, int 时间, int 数量, int 数量类型)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "追加状态New类-NEW");
			}
			FLD_PID = 物品ID;
			this.数量 = 数量;
			this.数量类型 = 数量类型;
			time = DateTime.Now;
			time = time.AddMilliseconds(时间);
			Play = Play_;
			npcyd = new System.Timers.Timer(时间);
			npcyd.Elapsed += 时间结束事件2;
			npcyd.Enabled = true;
			npcyd.AutoReset = false;
		}

		public void Dispose()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "追加状态New类-Dispose");
			}
			if (npcyd != null)
			{
				npcyd.Enabled = false;
				npcyd.Close();
				npcyd.Dispose();
				npcyd = null;
			}
			Play = null;
		}

		public int getsj()
		{
			return (int)time.Subtract(DateTime.Now).TotalMilliseconds;
		}

		public void 时间结束事件()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "追加状态New类-时间结束事件()");
			}
			if (npcyd != null)
			{
				npcyd.Enabled = false;
				npcyd.Close();
				npcyd.Dispose();
				npcyd = null;
			}
			if (Play == null)
			{
				Dispose();
			}
			else
			{
				try
				{
					switch (FLD_PID)
					{
					case 1:
						if (数量类型 == 2)
						{
							Play.FLD_追加百分比_攻击 -= 0.01 * (double)数量;
						}
						else if (数量类型 == 1)
						{
							Play.FLD_人物_追加_攻击 -= 数量;
						}
						break;
					case 2:
						if (数量类型 == 2)
						{
							Play.FLD_追加百分比_防御 -= 0.01 * (double)数量;
						}
						else if (数量类型 == 1)
						{
							Play.FLD_追加百分比_防御 -= 数量;
						}
						break;
					case 3:
						if (数量类型 == 2)
						{
							Play.FLD_追加百分比_HP上限 -= 0.01 * (double)数量;
						}
						else if (数量类型 == 1)
						{
							Play.FLD_Item_Premium_HP -= 数量;
						}
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						break;
					case 4:
						if (数量类型 == 2)
						{
							Play.FLD_追加百分比_MP上限 -= 0.01 * (double)数量;
						}
						else if (数量类型 == 1)
						{
							Play.FLD_Item_Premium_MP -= 数量;
						}
						if (Play.Player_FLD_MP > Play.Player_MP_Max)
						{
							Play.Player_FLD_MP = Play.Player_MP_Max;
						}
						break;
					case 5:
						if (数量类型 == 2)
						{
							Play.FLD_追加百分比_命中 -= 0.01 * (double)数量;
						}
						else if (数量类型 == 1)
						{
							Play.FLD_人物_追加_命中 -= 数量;
						}
						break;
					case 6:
						if (数量类型 == 2)
						{
							Play.FLD_追加百分比_回避 -= 0.01 * (double)数量;
						}
						else if (数量类型 == 1)
						{
							Play.FLD_人物_追加_回避 -= 数量;
						}
						break;
					case 7:
						if (数量类型 == 2)
						{
							Play.FLD_Item_Skill_Attack_Percentage -= 0.01 * (double)数量;
						}
						break;
					case 8:
						if (数量类型 == 2)
						{
							Play.FLD_Item_Skill_Def_Percentage -= 0.01 * (double)数量;
						}
						else if (数量类型 == 1)
						{
							Play.FLD_人物_追加_回避 += 数量;
						}
						Play.FLD_Item_Skill_Def_Percentage -= 0.01 * (double)数量;
						break;
					case 9:
						if (数量类型 == 2)
						{
							Play.FLD_Item_Premium_Exp -= 0.01 * (double)数量;
						}
						break;
					case 10:
						if (数量类型 == 2)
						{
							Play.Character_Upgrade_Lucky -= 0.01 * (double)数量;
						}
						break;
					case 12:
						if (数量类型 == 2)
						{
							Play.FLD_Item_Premium_Money -= 0.01 * (double)数量;
						}
						break;
					case 13:
						if (数量类型 == 2)
						{
							Play.FLD_Item_Premium_Drop -= 0.01 * (double)数量;
						}
						break;
					case 14:
						Play.Character_Qigong -= 数量;
						break;
					case 15:
						Play.FLD_Item_Premium_Fight_Exp -= 数量;
						break;
					}
					if (Play.追加状态New列表 != null)
					{
						Play.追加状态New列表.Remove(FLD_PID);
					}
					Play.状态效果New(FLD_PID, 0, FLD_sj, 数量, 数量类型);
					Play.Update_Character_Wear_Item();
					Play.UpdatePowersAndStatus();
					Play.Update_HP_MP_SP();
					Play.更新广播人物数据();
					Play.更新人物数据(Play);
					Dispose();
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "追加状态New类 时间结束事件 出错：[" + FLD_PID + "]" + ex);
				}
				finally
				{
					Dispose();
				}
			}
		}

		public void 时间结束事件2(object sender, ElapsedEventArgs e)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "追加状态New类-时间结束事件2");
			}
			时间结束事件();
		}
	}
}

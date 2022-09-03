using RxjhServer.RxjhServer;
using System;
using System.Timers;

namespace RxjhServer
{
	public class Class_Show_Pill : IDisposable
	{
		private int _FLD_PID;

		private int _FLD_RESIDE1;

		public System.Timers.Timer npcyd;

		public Players Play;

		public DateTime time;

		public int FLD_PID
		{
			get
			{
				return _FLD_PID;
			}
			set
			{
				_FLD_PID = value;
			}
		}

		public int FLD_RESIDE1
		{
			get
			{
				return _FLD_RESIDE1;
			}
			set
			{
				_FLD_RESIDE1 = value;
			}
		}

		public double FLD_sj => getsj();

		public Class_Show_Pill(Players Play_, double 时间, int 物品ID, int FLD_RESIDE1)
		{
			if (时间 <= 0.0)
			{
				时间 = 1.0;
			}
			FLD_PID = 物品ID;
			this.FLD_RESIDE1 = FLD_RESIDE1;
			time = DateTime.Now;
			time = time.AddMilliseconds(时间 + 100.0);
			Play = Play_;
			npcyd = new System.Timers.Timer(时间 + 100.0);
			npcyd.Elapsed += 时间结束事件2;
			npcyd.Enabled = true;
			npcyd.AutoReset = false;
		}

		public void Dispose()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "追加状态类-Dispose");
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

		~Class_Show_Pill()
		{
			if (npcyd != null)
			{
				npcyd.Enabled = false;
				npcyd.Close();
				npcyd.Dispose();
				npcyd = null;
			}
		}

		public double getsj()
		{
			return time.Subtract(DateTime.Now).TotalMilliseconds;
		}

		public void EndEvent()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "追加状态类-时间结束事件()");
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
					case 401202:
						Play.FLD_人物_追加_命中 -= 40;
						Play.FLD_人物_追加_回避 += 20;
						Play.UpdatePowersAndStatus();
						break;
					case 401203:
						Play.FLD_人物_追加_命中 += 20;
						Play.FLD_人物_追加_回避 -= 40;
						Play.UpdatePowersAndStatus();
						break;
					case 301201:
						Play.Del_ATT_Percentage(0.02);
						Play.FLD_追加百分比_HP上限 -= 0.02;
						Play.Update_HP_MP_SP();
						Play.UpdatePowersAndStatus();
						break;
					case 201201:
						Play.Del_ATT_Percentage(0.03);
						Play.UpdatePowersAndStatus();
						break;
					case 2001301:
						Play.Del_ATT_Percentage(0.03);
						Play.UpdatePowersAndStatus();
						break;
					case 401301:
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						break;
					case 401302:
						if (World.Newversion >= 12)
						{
							Play.FLD_Item_Skill_Def_Percentage -= 0.1;
							Play.UpdatePowersAndStatus();
						}
						else
						{
							Play.FLD_Item_Skill_Def_Percentage -= 0.1;
						}
						break;
					case 401303:
						Play.弓箭致命一击几率 = 0.0;
						break;
					case 401401:
						Play.FLD_追加百分比_命中 -= 0.05;
						Play.FLD_追加百分比_HP上限 -= 0.02;
						Play.Update_HP_MP_SP();
						break;
					case 501301:
						Play.Show_Pic_Class.RemoveSafe(501301);
						Play.Show_Pic_Class.RemoveSafe(501501);
						Play.FLD_BUFF_DP_ATT = 0.0;
						Play.UpdatePowersAndStatus();
						break;
					case 501302:
						Play.FLD_BUFF_DP_DEF = 0.0;
						Play.UpdatePowersAndStatus();
						break;
					case 501303:
						Play.FLD_BUFF_DP_DEF = 0.0;
						Play.UpdatePowersAndStatus();
						break;
					case 501401:
						Play.FLD_BUFF_DP_CX = 0.0;
						Play.UpdatePowersAndStatus();
						break;
					case 501402:
						Play.FLD_BUFF_DP_NT = 0.0;
						Play.UpdatePowersAndStatus();
						break;
					case 501403:
						Play.FLD_BUFF_DP_HP = 0.0;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Update_HP_MP_SP();
						break;
					case 501501:
						Play.Show_Pic_Class.RemoveSafe(501301);
						Play.Show_Pic_Class.RemoveSafe(501501);
						Play.FLD_BUFF_DP_ATT = 0.0;
						Play.UpdatePowersAndStatus();
						break;
					case 501502:
						Play.FLD_BUFF_DP_DEF = 0.0;
						Play.UpdatePowersAndStatus();
						break;
					case 501601:
						Play.FLD_BUFF_DP_HP = 0.0;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Update_HP_MP_SP();
						break;
					case 501701:
						Play.Player_FLD_HP -= 1000L;
						Play.人物基本最大_HP -= 1000;
						Play.UpdatePowersAndStatus();
						break;
					case 501602:
						Play.FLD_BUFF_DP_CX = 0.0;
						Play.UpdatePowersAndStatus();
						break;
					case 501603:
						Play.FLD_BUFF_DP_NT = 0.0;
						Play.UpdatePowersAndStatus();
						break;
					case 601101:
						Play.行走状态(BitConverter.GetBytes(FLD_PID), 1);
						Play.行走状态id = 1;
						break;
					case 601102:
						Play.行走状态(BitConverter.GetBytes(FLD_PID), 1);
						Play.行走状态id = 1;
						break;
					case 601103:
						Play.行走状态(BitConverter.GetBytes(FLD_PID), 1);
						Play.行走状态id = 1;
						break;
					case 601201:
						Play.dllFLD_装备_追加_防具_强化(1);
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						break;
					case 601202:
						Play.dllFLD_装备_追加_武器_强化(1);
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						break;
					case 801201:
						Play.FLD_攻击速度 = 100;
						Play.UpdatePowersAndStatus();
						Play.更新攻击速度();
						goto default;
					case 801302:
						Play.FLD_TRUDEF_801302 = 0.0;
						Play.FLD_追加百分比_回避 -= 1.0;
						Play.UpdatePowersAndStatus();
						Play.更新攻击速度();
						goto default;
					case 700401:
						Play.行走状态人物灵兽(BitConverter.GetBytes(FLD_PID), 1);
						Play.状态效果人物灵兽(BitConverter.GetBytes(FLD_PID), 0, 0);
						break;
					case 700402:
						Play.行走状态人物灵兽(BitConverter.GetBytes(FLD_PID), 1);
						Play.状态效果人物灵兽(BitConverter.GetBytes(FLD_PID), 0, 0);
						break;
					case 700403:
						Play.行走状态人物灵兽(BitConverter.GetBytes(FLD_PID), 1);
						Play.状态效果人物灵兽(BitConverter.GetBytes(FLD_PID), 0, 0);
						break;
					case 700310:
						Play.FLD_追加百分比_防御_KCDAO115 = 0.0;
						Play.FLD_追加百分比_攻击_KCDAO115 = 0.0;
						Play.UpdatePowersAndStatus();
						break;
					case 700350:
						Play.FLD_追加百分比_防御_DAIPHU115 = 0.0;
						Play.UpdatePowersAndStatus();
						break;
					case 700014:
					case 700343:
						Play.Del_ATT_Percentage_PN(0.0);
						Play.Del_DEF_Percentage_PN(0.0);
						Play.FLD_追加百分比_Shield_PHANNO = 0.0;
						Play.Show_Pic_Class.RemoveSafe(FLD_PID);
						Play.UpdatePowersAndStatus();
						Play.更新人物数据(Play);
						Play.更新广播人物数据();
						break;
					case 700314:
						Play.Show_Pic_Class.RemoveSafe(FLD_PID);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						break;
					case 700604:
						Play.FLD_追加百分比_HP上限 += 0.15;
						Play.Show_Pic_Class.RemoveSafe(FLD_PID);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_HP_MP_SP();
						Play.UpdatePowersAndStatus();
						break;
					case 700313:
						Play.Show_Pic_Class.RemoveSafe(FLD_PID);
						if (Play.Player_Job == 3 || Play.Player_Job == 10)
						{
							Play.Add_ATT_Percentage_PN(0.2 + Play.枪_末日狂舞);
						}
						else if (Play.Player_Job == 7)
						{
							Play.Add_ATT_Percentage_PN(0.15);
						}
						else
						{
							Play.Add_ATT_Percentage_PN(0.2);
						}
						Play.UpdatePowersAndStatus();
						Play.更新人物数据(Play);
						Play.更新广播人物数据();
						break;
					case 700904:
						Play.Bat_Tu = 0;
						Play.UpdatePowersAndStatus();
						Play.更新人物数据(Play);
						Play.更新广播人物数据();
						break;
					case 700603:
						Play.FLD_Item_Premium_HP -= 1000;
						Play.FLD_Item_Premium_MP -= 1000;
						Play.FLD_人物_追加_攻击 -= 100;
						Play.FLD_人物_追加_防御 -= 100;
						Play.UpdatePowersAndStatus();
						Play.Update_HP_MP_SP();
						Play.更新人物数据(Play);
						Play.更新广播人物数据();
						break;
					case 900401:
						Play.Del_ATT_Percentage_PN(0.0);
						Play.Del_DEF_Percentage_PN(0.0);
						Play.Show_Pic_Class.RemoveSafe(FLD_PID);
						Play.UpdatePowersAndStatus();
						Play.更新人物数据(Play);
						Play.更新广播人物数据();
						break;
					case 900402:
						Play.Del_ATT_Percentage_PN(0.0);
						Play.Del_DEF_Percentage_PN(0.0);
						Play.Show_Pic_Class.RemoveSafe(FLD_PID);
						Play.UpdatePowersAndStatus();
						Play.更新人物数据(Play);
						Play.更新广播人物数据();
						break;
					case 900403:
						Play.Del_ATT_Percentage_PN(0.0);
						Play.Del_DEF_Percentage_PN(0.0);
						Play.Show_Pic_Class.RemoveSafe(FLD_PID);
						Play.UpdatePowersAndStatus();
						Play.更新人物数据(Play);
						Play.更新广播人物数据();
						break;
					case 1001101:
						Play.行走状态(BitConverter.GetBytes(FLD_PID), 1);
						Play.行走状态id = 1;
						break;
					case 1001102:
						Play.行走状态(BitConverter.GetBytes(FLD_PID), 1);
						Play.行走状态id = 1;
						break;
					case 1001301:
						Play.Del_ATT_Percentage(0.05);
						Play.UpdatePowersAndStatus();
						break;
					case 1001302:
						Play.Del_ATT_Percentage(0.1);
						Play.UpdatePowersAndStatus();
						break;
					case 1001303:
						Play.Del_ATT_Percentage(0.15);
						Play.UpdatePowersAndStatus();
						break;
					case 1007000005:
						Play.FLD_Item_Premium_HP -= 300;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Update_HP_MP_SP();
						break;
					case 1007000014:
						Play.FLD_Item_Premium_HP -= 700;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Update_HP_MP_SP();
						break;
					case 1007000009:
						Play.FLD_Item_Premium_HP -= 300;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Update_HP_MP_SP();
						break;
					case 1007000018:
						Play.FLD_Item_Premium_HP -= 300;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Update_HP_MP_SP();
						break;
					case 1007000006:
						Play.FLD_Item_Premium_HP -= 500;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Update_HP_MP_SP();
						break;
					case 999000005:
						Play.FLD_Item_Premium_HP -= 300;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Update_HP_MP_SP();
						break;
					case 1007000007:
						Play.FLD_Item_Premium_HP -= 700;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Update_HP_MP_SP();
						break;
					case 1000000835:
						Play.FLD_追加百分比_MP上限 -= 0.05;
						if (Play.Player_FLD_MP > Play.Player_MP_Max)
						{
							Play.Player_FLD_MP = Play.Player_MP_Max;
						}
						Play.Update_HP_MP_SP();
						break;
					case 1000000836:
						Play.FLD_追加百分比_HP上限 -= 0.05;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Update_HP_MP_SP();
						break;
					case 1000000860:
						Play.FLD_追加百分比_MP上限 -= 0.05;
						if (Play.Player_FLD_MP > Play.Player_MP_Max)
						{
							Play.Player_FLD_MP = Play.Player_MP_Max;
						}
						Play.Update_HP_MP_SP();
						break;
					case 1000000861:
						Play.FLD_追加百分比_HP上限 -= 0.05;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Update_HP_MP_SP();
						break;
					case 1000000830:
						Play.FLD_Item_Premium_HP -= 100;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Update_HP_MP_SP();
						break;
					case 1000000831:
						Play.FLD_Item_Premium_HP -= 50;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Update_HP_MP_SP();
						break;
					case 1000000832:
						Play.FLD_Item_Premium_HP -= 100;
						Play.FLD_Item_Premium_MP -= 100;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						if (Play.Player_FLD_MP > Play.Player_MP_Max)
						{
							Play.Player_FLD_MP = Play.Player_MP_Max;
						}
						Play.Update_HP_MP_SP();
						break;
					case 1000000775:
						Play.FLD_人物_追加_防御 -= 20;
						Play.UpdatePowersAndStatus();
						break;
					case 1000000776:
						Play.FLD_Item_Skill_Attack_Percentage -= 0.05;
						Play.FLD_Item_Skill_Def_Percentage -= 0.1;
						Play.UpdatePowersAndStatus();
						break;
					case 1008000016:
						Play.Del_ATT_Percentage(0.1);
						Play.UpdatePowersAndStatus();
						break;
					case 1008000017:
						Play.Del_DEF_Percentage(0.1);
						Play.UpdatePowersAndStatus();
						break;
					case 1008000378:
						Play.Del_DEF_Percentage(0.1);
						Play.UpdatePowersAndStatus();
						break;
					case 999000002:
						Play.Del_DEF_Percentage(0.1);
						Play.UpdatePowersAndStatus();
						break;
					case 1008000372:
						Play.Del_ATT_Percentage(0.1);
						Play.UpdatePowersAndStatus();
						break;
					case 999000001:
						Play.Del_ATT_Percentage(0.05);
						Play.UpdatePowersAndStatus();
						break;
					case 1008000098:
						Play.Del_ATT_Percentage(0.1);
						Play.UpdatePowersAndStatus();
						break;
					case 1008000099:
						Play.Del_DEF_Percentage(0.1);
						Play.UpdatePowersAndStatus();
						break;
					case 1008000104:
						Play.dllFLD_装备_追加_武器_强化(2);
						Play.UpdatePowersAndStatus();
						break;
					case 1008000105:
						if (World.Newversion >= 13)
						{
							Play.dllFLD_装备_追加_武器_强化(2);
						}
						else
						{
							Play.dllFLD_装备_追加_防具_强化(1);
						}
						Play.UpdatePowersAndStatus();
						break;
					case 1008000218:
						Play.FLD_Item_Premium_HP -= 500;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Del_ATT_Percentage(0.1);
						Play.Del_DEF_Percentage(0.1);
						Play.FLD_Item_Premium_Exp -= 0.4;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.FLD_Item_Skill_Def_Percentage -= 0.1;
						Play.UpdatePowersAndStatus();
						Play.Update_HP_MP_SP();
						break;
					case 1008000941:
						Play.FLD_Item_Premium_HP -= 500;
						Play.FLD_Item_Premium_Exp -= 0.3;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.FLD_人物_追加_攻击 -= 50;
						Play.FLD_人物_追加_防御 -= 50;
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.Character_Qigong -= 2;
						Play.Del_DEF_Percentage(0.1);
						Play.Update_HP_MP_SP();
						Play.UpdatePowersAndStatus();
						break;
					case 1008000942:
						Play.FLD_Item_Premium_HP -= 500;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Del_ATT_Percentage(0.1);
						Play.Del_DEF_Percentage(0.1);
						Play.FLD_Item_Premium_Exp -= 0.4;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.FLD_Item_Skill_Def_Percentage -= 0.1;
						Play.UpdatePowersAndStatus();
						Play.Update_HP_MP_SP();
						break;
					case 1000000010:
						Play.FLD_Item_Premium_Exp -= 0.2;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						break;
					case 1008000177:
						Play.dllFLD_装备_追加_防具_强化(1);
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						break;
					case 1008000176:
						Play.dllFLD_装备_追加_武器_强化(2);
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						break;
					case 1000000013:
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.Del_ATT_Percentage(0.1);
						Play.UpdatePowersAndStatus();
						break;
					case 1000000646:
						Play.Del_DEF_Percentage(0.13);
						Play.FLD_Item_Skill_Def_Percentage -= 0.13;
						Play.UpdatePowersAndStatus();
						break;
					case 1008000178:
						Play.Del_ATT_Percentage(0.1);
						Play.UpdatePowersAndStatus();
						break;
					case 1008000179:
						Play.Del_DEF_Percentage(0.1);
						Play.UpdatePowersAndStatus();
						break;
					case 1008000364:
						Play.FLD_Item_Premium_Exp -= 0.2;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						goto default;
					case 1008000349:
						Play.FLD_Item_Premium_Exp -= 1.5;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						goto default;
					case 1008000365:
						Play.FLD_Item_Premium_Exp -= 0.5;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						goto default;
					case 1008000361:
						Play.FLD_Item_Premium_Exp -= 0.5;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						goto default;
					case 1008000427:
						Play.FLD_Item_Premium_HP -= 300;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.FLD_Item_Premium_Exp -= 0.3;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.Del_DEF_Percentage(0.1);
						Play.FLD_Item_Skill_Def_Percentage -= 0.1;
						Play.UpdatePowersAndStatus();
						goto default;
					case 1008000428:
						Play.FLD_Item_Premium_HP -= 500;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.FLD_Item_Premium_Exp -= 0.4;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.Del_DEF_Percentage(0.12);
						Play.FLD_Item_Skill_Def_Percentage -= 0.12;
						Play.UpdatePowersAndStatus();
						goto default;
					case 1008000939:
						Play.FLD_Item_Premium_Exp -= 1.0;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						goto default;
					case 1008000390:
						Play.FLD_Item_Premium_Exp -= 1.0;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						goto default;
					case 1008000391:
						Play.FLD_Item_Premium_Exp -= 0.5;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						goto default;
					case 1008000392:
						Play.FLD_Item_Premium_Exp -= 0.2;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						goto default;
					case 1008000393:
						Play.FLD_Item_Premium_Exp -= 1.0;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						goto default;
					case 1008000394:
						Play.FLD_Item_Premium_Exp -= 0.5;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						goto default;
					case 1008000366:
						Play.FLD_Item_Premium_Exp -= 0.8;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						goto default;
					case 1008000367:
						Play.FLD_Item_Premium_Exp -= 0.8;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						goto default;
					case 1008000106:
						Play.Del_ATT_Percentage(0.1);
						Play.UpdatePowersAndStatus();
						break;
					case 1008000053:
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.UpdatePowersAndStatus();
						break;
					case 999000003:
						Play.FLD_Item_Skill_Attack_Percentage -= 0.05;
						Play.UpdatePowersAndStatus();
						break;
					case 1008000219:
						Play.FLD_Item_Skill_Attack_Percentage -= 0.05;
						Play.UpdatePowersAndStatus();
						break;
					case 1008000054:
						Play.FLD_Item_Skill_Def_Percentage -= 0.1;
						Play.UpdatePowersAndStatus();
						break;
					case 999000004:
						Play.FLD_Item_Skill_Def_Percentage -= 0.1;
						Play.UpdatePowersAndStatus();
						break;
					case 1008000220:
						Play.FLD_Item_Skill_Def_Percentage -= 0.05;
						Play.UpdatePowersAndStatus();
						break;
					case 1008000107:
						Play.Del_DEF_Percentage(0.1);
						Play.UpdatePowersAndStatus();
						break;
					case 1008000946:
						Play.FLD_Item_Premium_Exp -= 0.05;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.FLD_人物_追加_攻击 -= 30;
						Play.FLD_Item_Skill_Attack_Percentage -= 0.03;
						Play.妖花青草 = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008000384:
						Play.FLD_Item_Premium_HP -= 500;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						break;
					case 1008001989:
						Play.FLD_Item_Premium_HP -= 500;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						break;
					case 1008000173:
						Play.FLD_Item_Premium_HP -= 500;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Update_HP_MP_SP();
						break;
					case 1008000143:
						Play.Del_ATT_Percentage(0.03);
						Play.UpdatePowersAndStatus();
						break;
					case 1008000144:
						Play.Del_DEF_Percentage(0.05);
						Play.UpdatePowersAndStatus();
						break;
					case 1000000011:
					case 1008000018:
						Play.dllFLD_装备_追加_武器_强化(2);
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						break;
					case 1000000012:
					case 1008000019:
						Play.dllFLD_装备_追加_防具_强化(1);
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						break;
					case 1000000891:
					case 1000000892:
					case 1000000893:
						Play.flowerEffectHealth = 0;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.flowerEffectExp = 0.0;
						Play.flowerEffectAttack = 0;
						Play.flowerEffectDefense = 0;
						Play.flowerEffectQigong = 0;
						Play.Update_Character_Wear_Item();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.UpdatePowersAndStatus();
						Play.Update_HP_MP_SP();
						break;
					case 1000000408:
						Play.Del_ATT_Percentage(0.1);
						break;
					case 1000000409:
						Play.FLD_Item_Premium_HP -= 500;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						break;
					case 1000000410:
						Play.FLD_Item_Premium_MP -= 500;
						if (Play.Player_FLD_MP > Play.Player_MP_Max)
						{
							Play.Player_FLD_MP = Play.Player_MP_Max;
						}
						break;
					case 1000000411:
						Play.Del_DEF_Percentage(0.1);
						break;
					case 1000000412:
						Play.FLD_Item_Skill_Attack_Percentage -= 0.13;
						break;
					case 1000000413:
						Play.FLD_Item_Skill_Def_Percentage -= 0.13;
						break;
					case 1000000414:
						Play.Character_Qigong -= 2;
						break;
					case 1008000156:
						Play.FLD_Item_Premium_HP -= 300;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Show_Pic_Class.RemoveSafe(1008000156);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_HP_MP_SP();
						break;
					case 1008000183:
						Play.FLD_Item_Premium_HP -= 300;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Del_DEF_Percentage(0.05);
						Play.Show_Pic_Class.RemoveSafe(1008000183);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_HP_MP_SP();
						Play.UpdatePowersAndStatus();
						break;
					case 1008000185:
						Play.FLD_Item_Premium_HP -= 700;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.FLD_Item_Premium_Exp -= 0.4;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.FLD_Item_Premium_Fight_Exp -= 2.0;
						Play.Del_DEF_Percentage(0.1);
						Play.dllFLD_装备_追加_防具_强化(1);
						Play.dllFLD_装备_追加_武器_强化(2);
						Play.Update_HP_MP_SP();
						Play.UpdatePowersAndStatus();
						Play.Update_Character_Wear_Item();
						break;
					case 1008000187:
						Play.FLD_Item_Premium_HP -= 300;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Character_Qigong--;
						Play.Show_Pic_Class.RemoveSafe(1008000187);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_HP_MP_SP();
						Play.UpdatePowersAndStatus();
						break;
					case 1008000188:
						Play.Del_ATT_Percentage(0.15);
						Play.Del_DEF_Percentage(0.15);
						Play.FLD_Item_Premium_HP -= 300;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.FLD_Item_Premium_MP -= 300;
						if (Play.Player_FLD_MP > Play.Player_MP_Max)
						{
							Play.Player_FLD_MP = Play.Player_MP_Max;
						}
						Play.FLD_Item_Premium_Exp -= 0.1;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.Show_Pic_Class.RemoveSafe(1008000188);
						Play.UpdatePowersAndStatus();
						Play.Update_HP_MP_SP();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						break;
					case 1008000388:
						Play.FLD_TLC_Premium_Exp = 0.0;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.Show_Pic_Class.RemoveSafe(1008000388);
						Play.UpdatePowersAndStatus();
						Play.Update_HP_MP_SP();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						break;
					case 1008000389:
						Play.FLD_TLC_Premium_Exp = 0.0;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.Show_Pic_Class.RemoveSafe(1008000389);
						Play.UpdatePowersAndStatus();
						Play.Update_HP_MP_SP();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						break;
					case 999000094:
						Play.FLD_Item_Premium_Exp -= 0.2;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						goto default;
					case 999000095:
						Play.Del_ATT_Percentage(0.15);
						Play.FLD_Item_Skill_Attack_Percentage -= 0.15;
						Play.UpdatePowersAndStatus();
						break;
					case 1008000169:
						Play.FLD_Item_Premium_HP -= 500;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Del_ATT_Percentage(0.11);
						Play.Del_DEF_Percentage(0.13);
						Play.FLD_Item_Skill_Attack_Percentage -= 0.13;
						Play.FLD_Item_Skill_Def_Percentage -= 0.11;
						Play.UpdatePowersAndStatus();
						Play.Update_HP_MP_SP();
						break;
					case 1008000194:
						Play.FLD_Item_Premium_HP -= 1000;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Del_ATT_Percentage(0.15);
						Play.Del_DEF_Percentage(0.15);
						Play.FLD_Item_Premium_Exp -= 0.4;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.FLD_Item_Skill_Def_Percentage -= 0.1;
						Play.UpdatePowersAndStatus();
						Play.Update_HP_MP_SP();
						break;
					case 1008000195:
						Play.FLD_Item_Premium_HP -= 300;
						Play.Character_Qigong -= 2;
						Play.Del_DEF_Percentage(0.1);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_HP_MP_SP();
						Play.UpdatePowersAndStatus();
						break;
					case 1008000163:
						Play.FLD_Item_Premium_HP -= 700;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Del_DEF_Percentage(0.1);
						Play.Del_ATT_Percentage(0.1);
						Play.FLD_Item_Skill_Attack_Percentage -= 0.05;
						Play.FLD_Item_Skill_Def_Percentage -= 0.1;
						Play.dllFLD_装备_追加_武器_强化(2);
						Play.dllFLD_装备_追加_防具_强化(1);
						Play.Show_Pic_Class.RemoveSafe(1008000163);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_HP_MP_SP();
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						break;
					case 1000000137:
						Play.FLD_人物_追加_攻击 -= 10;
						Play.FLD_人物_追加_防御 -= 10;
						Play.Show_Pic_Class.RemoveSafe(1000000137);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_HP_MP_SP();
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						break;
					case 1008000197:
						Play.FLD_Item_Premium_HP -= 700;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Del_DEF_Percentage(0.1);
						Play.Del_ATT_Percentage(0.1);
						Play.FLD_Item_Skill_Attack_Percentage -= 0.05;
						Play.FLD_Item_Skill_Def_Percentage -= 0.1;
						Play.dllFLD_装备_追加_武器_强化(2);
						Play.dllFLD_装备_追加_防具_强化(1);
						Play.Show_Pic_Class.RemoveSafe(1008000197);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_HP_MP_SP();
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						break;
					case 1008000203:
						Play.Character_Qigong--;
						Play.Show_Pic_Class.RemoveSafe(FLD_PID);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_HP_MP_SP();
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						break;
					case 1008000204:
						Play.FLD_Item_Premium_HP -= 500;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Show_Pic_Class.RemoveSafe(FLD_PID);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_HP_MP_SP();
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						break;
					case 1008000205:
						Play.FLD_Item_Premium_MP -= 500;
						if (Play.Player_FLD_MP > Play.Player_MP_Max)
						{
							Play.Player_FLD_MP = Play.Player_MP_Max;
						}
						Play.Show_Pic_Class.RemoveSafe(FLD_PID);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_HP_MP_SP();
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						break;
					case 1008000206:
						Play.Show_Pic_Class.RemoveSafe(FLD_PID);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_HP_MP_SP();
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						break;
					case 1008000207:
						Play.Del_ATT_Percentage(0.05);
						Play.Show_Pic_Class.RemoveSafe(FLD_PID);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_HP_MP_SP();
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						break;
					case 1008000208:
						Play.Del_DEF_Percentage(0.05);
						Play.Show_Pic_Class.RemoveSafe(FLD_PID);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_HP_MP_SP();
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						break;
					case 1008000209:
						Play.FLD_追加百分比_回避 -= 0.05;
						Play.Show_Pic_Class.RemoveSafe(FLD_PID);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_HP_MP_SP();
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						break;
					case 1000000030:
						Play.FLD_Item_Premium_Fight_Exp -= 1.0;
						Play.Show_Pic_Class.RemoveSafe(1000000030);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_HP_MP_SP();
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						break;
					case 1000000866:
						Play.FLD_Item_Premium_Fight_Exp -= 1.0;
						Play.Show_Pic_Class.RemoveSafe(1000000866);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_HP_MP_SP();
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						break;
					case 1008000232:
						Play.FLD_Item_Premium_HP -= 100;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.FLD_Item_Premium_Exp -= 0.2;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.FLD_Item_Premium_Money -= 0.4;
						Play.FLD_Item_Premium_Drop -= 0.2;
						Play.UpdatePowersAndStatus();
						Play.Update_HP_MP_SP();
						break;
					case 1008000239:
						Play.FLD_Item_Premium_Exp -= 1.0;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						break;
					case 1008000351:
						Play.FLD_Item_Premium_Exp -= 0.2;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						goto default;
					case 1008000355:
						Play.FLD_Item_Premium_Exp -= 0.5;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						goto default;
					case 1008000095:
						Play.FLD_Item_Premium_Exp -= 0.2;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						goto default;
					case 1008000096:
						Play.FLD_Item_Premium_Exp -= 0.3;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						goto default;
					case 1008000097:
						Play.FLD_Item_Premium_Exp -= 0.4;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						goto default;
					case 1008000240:
						Play.FLD_Item_Premium_Exp -= 0.05;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.FLD_人物_追加_攻击 -= 30;
						Play.FLD_Item_Skill_Attack_Percentage -= 0.03;
						Play.妖花青草 = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008000241:
						Play.FLD_Item_Premium_Exp -= 0.05;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.FLD_人物_追加_攻击 -= 30;
						Play.FLD_Item_Skill_Attack_Percentage -= 0.03;
						Play.妖花青草 = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008000242:
						Play.FLD_Item_Premium_Exp -= 0.05;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.FLD_人物_追加_攻击 -= 30;
						Play.FLD_Item_Skill_Attack_Percentage -= 0.03;
						Play.妖花青草 = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008000243:
						Play.FLD_Item_Premium_HP -= 300;
						Play.FLD_Item_Premium_Exp -= 0.2;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.Update_HP_MP_SP();
						Play.UpdatePowersAndStatus();
						break;
					case 1008001040:
						Play.Update_HP_MP_SP();
						Play.UpdatePowersAndStatus();
						break;
					case 1008001041:
						Play.Update_HP_MP_SP();
						Play.UpdatePowersAndStatus();
						break;
					case 1008000245:
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.FLD_追加百分比_回避 -= 0.05;
						Play.FLD_Item_Premium_HP -= 100;
						Play.Character_Qigong -= 2;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Show_Pic_Class.RemoveSafe(1008000245);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_HP_MP_SP();
						Play.UpdatePowersAndStatus();
						break;
					case 1008000248:
						Play.FLD_Item_Premium_Exp -= 1.0;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.FLD_Item_Premium_Fight_Exp -= 1.0;
						Play.FLD_Item_Premium_Money -= 1.0;
						Play.FLD_Item_Premium_Drop -= 1.0;
						Play.UpdatePowersAndStatus();
						break;
					case 1008000250:
						Play.FLD_Item_Premium_Exp -= 0.05;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.FLD_人物_追加_攻击 -= 30;
						Play.FLD_Item_Skill_Attack_Percentage -= 0.03;
						Play.妖花青草 = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008001021:
						Play.Character_Qigong -= 3;
						Play.FLD_Item_Premium_Exp -= 0.4;
						Play.Del_ATT_Percentage(0.07);
						Play.FLD_Item_Skill_Attack_Percentage -= 0.12;
						Play.Del_DEF_Percentage(0.12);
						Play.FLD_Item_Premium_HP -= 600;
						Play.FLD_Item_Premium_MP -= 400;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.KimLongChiTheu = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008001026:
						Play.Character_Qigong -= 3;
						Play.FLD_Item_Premium_Exp -= 0.4;
						Play.Del_ATT_Percentage(0.07);
						Play.FLD_Item_Skill_Attack_Percentage -= 0.12;
						Play.Del_DEF_Percentage(0.12);
						Play.FLD_Item_Premium_HP -= 600;
						Play.FLD_Item_Premium_MP -= 400;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.KimLongChiTheu = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008001048:
						Play.Character_Qigong -= 3;
						Play.FLD_Item_Premium_Exp -= 0.4;
						Play.Del_ATT_Percentage(0.07);
						Play.FLD_Item_Skill_Attack_Percentage -= 0.12;
						Play.Del_DEF_Percentage(0.12);
						Play.FLD_Item_Premium_HP -= 600;
						Play.FLD_Item_Premium_MP -= 400;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008001031:
						Play.Character_Qigong -= 3;
						Play.FLD_Item_Premium_Exp -= 0.4;
						Play.Del_ATT_Percentage(0.07);
						Play.FLD_Item_Skill_Attack_Percentage -= 0.12;
						Play.Del_DEF_Percentage(0.12);
						Play.FLD_Item_Premium_HP -= 600;
						Play.FLD_Item_Premium_MP -= 400;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.KimLongChiTheu = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008001022:
						Play.Character_Qigong -= 3;
						Play.FLD_Item_Premium_Exp -= 0.4;
						Play.Del_ATT_Percentage(0.05);
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.Del_DEF_Percentage(0.1);
						Play.FLD_Item_Premium_HP -= 500;
						Play.FLD_Item_Premium_MP -= 300;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.KimLongChiTheu = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008001027:
						Play.Character_Qigong -= 3;
						Play.FLD_Item_Premium_Exp -= 0.4;
						Play.Del_ATT_Percentage(0.05);
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.Del_DEF_Percentage(0.1);
						Play.FLD_Item_Premium_HP -= 500;
						Play.FLD_Item_Premium_MP -= 300;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.KimLongChiTheu = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008001032:
						Play.Character_Qigong -= 3;
						Play.FLD_Item_Premium_Exp -= 0.4;
						Play.Del_ATT_Percentage(0.05);
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.Del_DEF_Percentage(0.1);
						Play.FLD_Item_Premium_HP -= 500;
						Play.FLD_Item_Premium_MP -= 300;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.KimLongChiTheu = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008001023:
						Play.Character_Qigong -= 3;
						Play.FLD_Item_Premium_Exp -= 0.2;
						Play.Del_ATT_Percentage(0.05);
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.Del_DEF_Percentage(0.1);
						Play.FLD_Item_Premium_HP -= 500;
						Play.FLD_Item_Premium_MP -= 300;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.KimLongChiTheu = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008001028:
						Play.Character_Qigong -= 3;
						Play.FLD_Item_Premium_Exp -= 0.2;
						Play.Del_ATT_Percentage(0.05);
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.Del_DEF_Percentage(0.1);
						Play.FLD_Item_Premium_HP -= 500;
						Play.FLD_Item_Premium_MP -= 300;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.KimLongChiTheu = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008001033:
						Play.Character_Qigong -= 3;
						Play.FLD_Item_Premium_Exp -= 0.2;
						Play.Del_ATT_Percentage(0.05);
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.Del_DEF_Percentage(0.1);
						Play.FLD_Item_Premium_HP -= 500;
						Play.FLD_Item_Premium_MP -= 300;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.KimLongChiTheu = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008001024:
						Play.Character_Qigong -= 3;
						Play.FLD_Item_Premium_Exp -= 0.2;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.KimLongChiTheu = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008001029:
						Play.Character_Qigong -= 3;
						Play.FLD_Item_Premium_Exp -= 0.2;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.KimLongChiTheu = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008001034:
						Play.Character_Qigong -= 3;
						Play.FLD_Item_Premium_Exp -= 0.2;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.KimLongChiTheu = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008001025:
						Play.Del_ATT_Percentage(0.05);
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.Del_DEF_Percentage(0.1);
						Play.FLD_Item_Premium_HP -= 500;
						Play.FLD_Item_Premium_MP -= 300;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.KimLongChiTheu = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008001030:
						Play.Del_ATT_Percentage(0.05);
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.Del_DEF_Percentage(0.1);
						Play.FLD_Item_Premium_HP -= 500;
						Play.FLD_Item_Premium_MP -= 300;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.KimLongChiTheu = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008001035:
						Play.Del_ATT_Percentage(0.05);
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.Del_DEF_Percentage(0.1);
						Play.FLD_Item_Premium_HP -= 500;
						Play.FLD_Item_Premium_MP -= 300;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.KimLongChiTheu = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008001111:
						Play.FLD_人物_追加_攻击 -= 50;
						Play.FLD_人物_追加_防御 -= 100;
						Play.FLD_Item_Premium_HP -= 500;
						Play.FLD_Item_Premium_MP -= 500;
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.FLD_Item_Premium_Exp -= 0.4;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.妖花青草 = false;
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008001112:
						Play.FLD_人物_追加_攻击 -= 100;
						Play.FLD_人物_追加_防御 -= 50;
						Play.FLD_Item_Premium_HP -= 800;
						Play.FLD_人物_追加_回避 -= 10;
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.FLD_Pill_Defense_Skill -= 100.0;
						Play.妖花青草 = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008000251:
						Play.FLD_Item_Premium_Exp -= 0.05;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.FLD_人物_追加_攻击 -= 30;
						Play.FLD_Item_Skill_Attack_Percentage -= 0.03;
						Play.妖花青草 = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008000252:
						Play.FLD_Item_Premium_HP -= 100;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.Show_Pic_Class.RemoveSafe(1008000252);
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_HP_MP_SP();
						Play.UpdatePowersAndStatus();
						break;
					case 1008000304:
						Play.FLD_Item_Premium_Exp -= 0.05;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.FLD_人物_追加_攻击 -= 30;
						Play.FLD_人物_追加_防御 -= 30;
						Play.FLD_Item_Skill_Attack_Percentage -= 0.03;
						Play.妖花青草 = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008000305:
						Play.FLD_Item_Premium_Exp -= 0.05;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.FLD_人物_追加_攻击 -= 30;
						Play.FLD_人物_追加_防御 -= 30;
						Play.FLD_Item_Skill_Attack_Percentage -= 0.03;
						Play.妖花青草 = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008000333:
						Play.FLD_Item_Premium_Exp -= 0.05;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.FLD_人物_追加_攻击 -= 30;
						Play.FLD_人物_追加_防御 -= 30;
						Play.FLD_Item_Skill_Attack_Percentage -= 0.03;
						Play.妖花青草 = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008000306:
						Play.FLD_人物_追加_攻击 -= 40;
						Play.FLD_人物_追加_防御 -= 40;
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.妖花青草 = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008000307:
						Play.FLD_Item_Premium_Exp -= 0.1;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.FLD_人物_追加_攻击 -= 40;
						Play.FLD_人物_追加_防御 -= 40;
						Play.FLD_Item_Skill_Attack_Percentage -= 0.05;
						Play.妖花青草 = false;
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008000323:
						Play.FLD_Item_Premium_Exp -= 1.0;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						break;
					case 1008000324:
						Play.FLD_Item_Premium_Exp -= 1.0;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						break;
					case 1008000325:
						Play.FLD_Item_Premium_Exp -= 0.1;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.FLD_人物_追加_攻击 -= 40;
						Play.FLD_人物_追加_防御 -= 40;
						Play.FLD_Item_Skill_Attack_Percentage -= 0.05;
						Play.FLD_Item_Premium_HP -= 300;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.妖花青草 = false;
						Play.Update_HP_MP_SP();
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008000326:
						Play.FLD_人物_追加_攻击 -= 40;
						Play.FLD_人物_追加_防御 -= 40;
						Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
						Play.FLD_Item_Premium_HP -= 300;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.妖花青草 = false;
						Play.Update_HP_MP_SP();
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						Play.Update_Equipment_Effectiveness();
						break;
					case 1008001815:
						Play.FLD_人物_追加_攻击 -= 80;
						Play.FLD_人物_追加_防御 -= 80;
						Play.FLD_Item_Skill_Attack_Percentage -= 0.3;
						Play.FLD_Item_Skill_Def_Percentage -= 0.1;
						Play.FLD_Item_Premium_HP -= 1000;
						if (Play.Player_FLD_HP > Play.Player_HP_Max)
						{
							Play.Player_FLD_HP = Play.Player_HP_Max;
						}
						Play.FLD_Item_Premium_Exp -= 0.5;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.Update_HP_MP_SP();
						Play.UpdatePowersAndStatus();
						break;
					case 1008000362:
						Play.FLD_Item_Premium_Exp -= 1.5;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						break;
					case 1008000363:
						Play.FLD_Item_Premium_Exp -= 1.5;
						if (Play.FLD_Item_Premium_Exp < 0.0)
						{
							Play.FLD_Item_Premium_Exp = 0.0;
						}
						Play.UpdatePowersAndStatus();
						break;
					case 700291:
					case 700662:
						Play.Show_Pic_Class.RemoveSafe(FLD_PID);
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						break;
					case 700344:
						Play.Show_Pic_Class.RemoveSafe(FLD_PID);
						Play.Update_Character_Wear_Item();
						Play.UpdatePowersAndStatus();
						Play.更新广播人物数据();
						Play.更新人物数据(Play);
						break;
					default:
						if (FLD_PID == World.IdItemX2)
						{
							Play.GameMessage("Sýò kiêòn: +" + Play.FLD_Event_Premium_Exp * 100.0 + "% ðiêÒm kinh nghiêòm (kêìt thuìc)", 10);
							Play.FLD_Event_Premium_Exp = 0.0;
							Play.UpdatePowersAndStatus();
							Play.Update_HP_MP_SP();
						}
						else if (FLD_PID == World.IdItemX3)
						{
							Play.GameMessage("Sýò kiêòn: +" + Play.FLD_Event_Premium_Exp * 100.0 + "% ðiêÒm kinh nghiêòm (kêìt thuìc)", 10);
							Play.FLD_Event_Premium_Exp = 0.0;
							Play.UpdatePowersAndStatus();
							Play.Update_HP_MP_SP();
						}
						break;
					case 1008000184:
					case 1008000186:
					case 1008000196:
					case 1008000233:
					case 1008000234:
					case 1008000235:
					case 1008000236:
					case 1008000237:
					case 1008000238:
					case 1008000244:
					case 1008000246:
					case 1008000247:
						break;
					}
					if (Play.Player_FLD_HP > Play.Player_HP_Max)
					{
						Play.Player_FLD_HP = Play.Player_HP_Max;
					}
					if (Play.Show_Pic_Class != null)
					{
						Play.Show_Pic_Class.RemoveSafe(FLD_PID);
					}
					Play.Send_Packet_Show_Pic(BitConverter.GetBytes(FLD_PID), 0, 0);
					Dispose();
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "追加状态类 时间结束事件 出错：[" + FLD_PID + "]" + ex);
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
				Form1.WriteLine(0, "追加状态类-时间结束事件2");
			}
			EndEvent();
		}
	}
}

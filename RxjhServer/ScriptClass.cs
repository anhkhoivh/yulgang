using LuaInterface;
using RxjhServer.RxjhServer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RxjhServer
{
	public class ScriptClass
	{
		public Lua pLuaVM;

		public LuaFunction 打开物品事件;

		public LuaFunction 怪物死亡事件;

		public string 脚本目录 = "script";

		public Dictionary<int, LuaFunction> 任务事件列表 = new Dictionary<int, LuaFunction>();

		public LuaFunction 物品兑换事件;

		public ScriptClass()
		{
			Load_LuaScript_API();
			脚本目录 = Application.StartupPath + "\\Script";
			GetUrlDirectory(脚本目录);
			Form1.WriteLine(2, "Load Script Success");
			注册事件();
		}

		public void AddExpToCharacter(int UserWorldId, long Exp)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.GsAddExpToCharacter(Exp);
				value.SaveDataCharacter();
			}
		}

		public void AddKiToCharacter(int UserWorldId, int Ki)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.GsAddKiToCharacter(Ki);
			}
		}

		public void AddGuildPoint(int UserWorldId, int Point)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.GsAddGuildPoint(Point);
			}
		}

		public int GetRandomFix(int min, int max)
		{
			return World.GetStoneValue_Fix(min, max);
		}

		public int GetRandom(int min, int max)
		{
			return new Random(World.GetRandomSeed()).Next(min, max);
		}

		public int GetQuestItmeNum(int UserWorldId, int ItemID)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				return value.GetQuestItmeNum(ItemID);
			}
			return 0;
		}

		public void AddWuxunToCharacter(int UserWorldId, int Wuxun)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.GsAddWuxunToCharacter(Wuxun);
			}
		}

		public void AddMoneyToCharacter(int UserWorldId, long Money)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.GsAddMoneyToCharacter(Money);
			}
		}

		public Players GetPlayerThis(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				return value;
			}
			return null;
		}

		public void GetUrlDirectory(string url)
		{
			if (!Directory.Exists(url))
			{
				return;
			}
			string[] files = Directory.GetFiles(url);
			int num = 0;
			while (true)
			{
				bool flag = true;
				if (num >= files.Length)
				{
					break;
				}
				string urlFile = files[num];
				try
				{
					SetUrlFile(urlFile);
				}
				catch (Exception value)
				{
					Console.Write(value);
				}
				num++;
			}
			GetUrlDirectoryS(url);
		}

		public void GetUrlDirectoryS(string url)
		{
			string[] directories = Directory.GetDirectories(url);
			foreach (string url2 in directories)
			{
				GetUrlDirectory(url2);
			}
		}

		public ItmeClass GetWorldItme(int 物品ID)
		{
			if (World.Itme.TryGetValue(物品ID, out ItmeClass value))
			{
				return value;
			}
			return null;
		}

		public int Get任务阶段(int UserWorldId, int 任务ID)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				return value.Get任务阶段(任务ID);
			}
			return 0;
		}

		public void SetUrlFile(string Url)
		{
			if (Path.GetExtension(Url) == ".lua")
			{
				try
				{
					pLuaVM.DoFile(Url);
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					Form1.WriteLine(2, "加载Lua脚本出错" + ex.Message);
				}
			}
		}

		public void TEstMsg(object aa)
		{
			Console.WriteLine(aa);
		}

		public void 保存人物的数据(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.SaveDataCharacter();
			}
		}

		public void 初始话已装备物品(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.Initialize_Equip_Item();
			}
		}

		public int 得到包裹空位位置(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				return value.得到包裹空位位置();
			}
			return -1;
		}

		public List<int> 得到包裹空位位置组(int UserWorldId, int 数量)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				return value.得到包裹空位位置组(66);
			}
			return new List<int>();
		}

		public int GetPakItmesx(int UserWorldId, int 物品ID, int 属性1, int 属性2, int 属性3, int 属性4, int 属性5, int 属性6, int 属性7, int 属性8)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				for (int i = 0; i < ((value.装备行囊是否开启 == 0) ? 36 : 66); i++)
				{
					if (BitConverter.ToInt32(value.Item_In_Bag[i].Get_Byte_Item_PID, 0) == 物品ID && value.Item_In_Bag[i].FLD_MAGIC0 == 属性1 && value.Item_In_Bag[i].FLD_MAGIC1 == 属性2 && value.Item_In_Bag[i].FLD_MAGIC2 == 属性3 && value.Item_In_Bag[i].FLD_MAGIC3 == 属性4 && value.Item_In_Bag[i].FLD_MAGIC4 == 属性5 && value.Item_In_Bag[i].FLD_FJ_进化 == 属性6 && value.Item_In_Bag[i].FLD_FJ_觉醒 == 属性7 && value.Item_In_Bag[i].FLD_FJ_中级附魂 == 属性8)
					{
						return i;
					}
				}
			}
			return -1;
		}

		public int 得到包裹物品(int UserWorldId, int 物品ID)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				for (int i = 0; i < ((value.装备行囊是否开启 == 0) ? 36 : 66); i++)
				{
					if (BitConverter.ToInt32(value.Item_In_Bag[i].Get_Byte_Item_PID, 0) == 物品ID)
					{
						return i;
					}
				}
			}
			return -1;
		}

		public int 得到包裹物品数量(int UserWorldId, int 物品ID, int 数量)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				for (int i = 0; i < ((value.装备行囊是否开启 == 0) ? 36 : 66); i++)
				{
					if (BitConverter.ToInt32(value.Item_In_Bag[i].Get_Byte_Item_PID, 0) == 物品ID && BitConverter.ToInt32(value.Item_In_Bag[i].Item_Amount, 0) >= 数量)
					{
						return i;
					}
				}
			}
			return -1;
		}

		public bool 得到任务物品(int UserWorldId, int 物品ID, int 数量)
		{
			Players value;
			return World.AllConnectedChars.TryGetValue(UserWorldId, out value) && value.得到任务物品(物品ID, 数量);
		}

		public bool checkEquipItem(int UserWorldId, long 物品ID)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				物品类[] item_Wear = value.Item_Wear;
				foreach (物品类 物品类 in item_Wear)
				{
					if (物品类.FLD_PID == 物品ID)
					{
						return true;
					}
				}
			}
			return false;
		}

		public int 得到元宝数据(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.查百宝阁元宝数();
				return value.FLD_RXPIONT;
			}
			return 0;
		}

		public void 发送八转技能书(int UserWorldId, int 空位)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value) && World.Newversion < 13)
			{
				value.发送八转技能书(空位);
			}
		}

		public void 发送九转技能书(int UserWorldId, int 空位)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value) && World.Newversion < 13)
			{
				value.发送九转技能书(空位);
			}
		}

		public void 发送六转技能书(int UserWorldId, int 空位)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value) && World.Newversion < 13)
			{
				value.发送六转技能书(空位);
			}
		}

		public void 发送七转技能书(int UserWorldId, int 空位)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value) && World.Newversion < 13)
			{
				value.发送七转技能书(空位);
			}
		}

		public void 更新_HP_MP_HP(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.Update_HP_MP_SP();
			}
		}

		public void 更新金钱和负重(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.Update_Money_Weight();
			}
		}

		public void 更新经验和历练(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.Update_Exp_Marble();
			}
		}

		public void 更新武功和状态(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.UpdatePowersAndStatus();
			}
		}

		public void UpgradeSpecialWeapons(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.UpgradeSpecialWeapons();
			}
		}

		public void 计算人物基本数据(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.计算人物基本数据();
			}
		}

		public bool checkEquipSpecialWeapons(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				return value.checkEquipSpecialWeapons();
			}
			return false;
		}

		public void 人物转职业(int UserWorldId, int 人物正邪, int 转)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.人物转职业(人物正邪, 转);
				value.转生系统();
				value.UpdatePowersAndStatus();
				value.Auto_Learn_Skill();
				value.更新广播人物数据();
			}
		}

		public void 任务提示数据发送(int UserWorldId, int 任务ID, int 操作ID, int 任务阶段ID)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.任务提示数据发送(任务ID, 操作ID, 任务阶段ID);
				value.更新人物数据(value);
				value.更新装备效果to(value, value);
				value.UpdatePowersAndStatus();
			}
		}

		public void 删除物品(int UserWorldId, int 位置, int 数量)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.Send_Packet_Delete_Item(位置, 数量);
			}
		}

		public void 设置会员等级(int UserWorldId, int 等级)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.会员等级 += 等级;
				value.SaveDataCharacter();
			}
		}

		public void 设置人物会员(int UserWorldId, int 会员时间)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				if (value.FLD_VIP == 0)
				{
					DateTime now = DateTime.Now;
					now = DateTime.Now.AddMonths(会员时间);
					value.FLD_VIP = 1;
					value.FLD_VIPTIM = now;
					value.GameMessage("恭喜您获得1个月的VIP！", 9);
					value.GameMessage("你的VIP到期时间是:" + value.FLD_VIPTIM.ToString("hh:mm dd/MM/yyyy"), 9);
				}
				else
				{
					DateTime now2 = DateTime.Now;
					now2 = (value.FLD_VIPTIM = DateTime.Now.AddMonths(会员时间));
					value.GameMessage("续时成功,你的VIP到期时间是:" + value.FLD_VIPTIM.ToString("hh:mm dd/MM/yyyy"), 9);
				}
				value.保存会员数据();
			}
		}

		public void 设置人物属性(int UserWorldId, long 攻击, long 防御, long 生命)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				string[] array = World.升级会员需要属性.Split(',');
				if (value.奖励_追加_攻击 < long.Parse(array[0]))
				{
					value.奖励_追加_攻击 += 攻击;
				}
				if (value.奖励_追加_防御 < long.Parse(array[1]))
				{
					value.奖励_追加_防御 += 防御;
				}
				value.奖励_追加_生命 += 生命;
				value.UpdatePowersAndStatus();
				value.Update_HP_MP_SP();
			}
		}

		public void 设置人物元宝(int UserWorldId, int 元宝数, int 操作类型)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.Add_Del_Rxpiont(元宝数, 操作类型);
				value.Save_data_Rxpiont();
			}
		}

		public void 设置任务数据(int UserWorldId, int 任务ID, int 任务阶段ID)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.设置任务数据(任务ID, 任务阶段ID);
			}
		}

		public void 设置玩家等级(int UserWorldId, int 等级)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.Player_FLD_EXP = 0L;
				value.Player_Level = 等级;
				value.计算人物基本数据();
				value.Update_HP_MP_SP();
				value.Update_Exp_Marble();
				value.Update_Money_Weight();
				value.Update_Character_Wear_Item();
				value.UpdatePowersAndStatus();
			}
		}

		public void 设置玩家善恶(int UserWorldId, int 善恶)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.Player_FLD_SE += 善恶;
			}
		}

		public void 物品使用(int UserWorldId, int 位置, int 数量)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.Item_Use(位置, 数量);
			}
		}

		public void 系统提示(int UserWorldId, string msg, int msgType, string name = "")
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				string msg2 = string.Format(msg, value.UserName);
				value.GameMessage(msg2, msgType, name);
			}
		}

		public void 新学气功(int UserWorldId, int 气功位置)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.新学气功(气功位置);
			}
		}

		public void 学习技能(int UserWorldId, int FLD_武功类型, int FLD_INDEX)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.学习技能(FLD_武功类型, FLD_INDEX);
			}
		}

		public void 学习技能提示(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.学习技能提示();
			}
		}

		public void 学习升天武功书(int UserWorldId, int FLD_武功类型, int FLD_INDEX)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				MartialArts.学习升天武功书(value, FLD_武功类型, FLD_INDEX);
			}
		}

		public void 增加任务物品(int UserWorldId, int 物品ID, int 数量)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.AddItemQuest(物品ID, 数量);
			}
		}

		public void 增加物品Script(int UserWorldId, int 物品ID, int 位置, int 数量)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value) && World.Itme.TryGetValue(物品ID, out ItmeClass value2))
			{
				if (物品ID >= 16900001 && 物品ID <= 36900001)
				{
					value.百宝增加物品带属性(物品ID, 位置, 数量, value2.FLD_MAGIC0, value2.FLD_MAGIC1, value2.FLD_MAGIC2, value2.FLD_MAGIC3, value2.FLD_MAGIC4, 0, 0, 0, 1, 3);
				}
				else if (物品ID >= 1007000001)
				{
					value.百宝增加物品带属性(物品ID, 位置, 数量, value2.FLD_MAGIC0, value2.FLD_MAGIC1, value2.FLD_MAGIC2, value2.FLD_MAGIC3, value2.FLD_MAGIC4, 0, 0, 0, 1, 0);
				}
				else
				{
					value.增加物品Script(物品ID, 位置, 数量);
				}
			}
		}

		public void 增加物品带属性(int UserWorldId, int 物品ID, int 位置, int 数量, int 物品属性0, int 物品属性1, int 物品属性2, int 物品属性3, int 物品属性4, int 初级附魂, int 中级附魂, int 进化, int 绑定)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.增加物品带属性(物品ID, 位置, 数量, 物品属性0, 物品属性1, 物品属性2, 物品属性3, 物品属性4, 初级附魂, 中级附魂, 进化, 绑定);
			}
		}

		public void Addexporll(int UserWorldId, int iditem, long time)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.Addexporll(iditem, time);
			}
		}

		public void 增加物品带属性天数(int UserWorldId, int 物品ID, int 位置, int 数量, int 物品属性0, int 物品属性1, int 物品属性2, int 物品属性3, int 物品属性4, int 初级附魂, int 中级附魂, int 进化, int 绑定, int 天数)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.百宝增加物品带属性(物品ID, 位置, 数量, 物品属性0, 物品属性1, 物品属性2, 物品属性3, 物品属性4, 初级附魂, 中级附魂, 进化, 绑定, 天数);
			}
		}

		public int Get_Player_Level(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				return value.Player_Level;
			}
			return -1;
		}

		public int Get_Player_WuXun(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				return value.Player_WuXun;
			}
			return -1;
		}

		public int Get_Player_Job(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				return value.Player_Job;
			}
			return -1;
		}

		public long Get_Player_Money(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				return value.Player_Money;
			}
			return -1L;
		}

		public int Get_Player_ExpErience(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				return value.Player_ExpErience;
			}
			return -1;
		}

		public int Get_Player_Zx(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				return value.Player_Zx;
			}
			return -1;
		}

		public int Get_Player_Job_Level(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				return value.Player_Job_Level;
			}
			return -1;
		}

		public int Get_Player_Sex(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				return value.Player_Sex;
			}
			return -1;
		}

		public bool Get_DayQuest(int UserWorldId, int idquest, int count = 1, bool showMsg = true)
		{
			int num = 0;
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				string[] array = value.FLD_DayQuest_Array.Split(';');
				for (int i = 0; i < array.Length; i++)
				{
					if (idquest.ToString() == array[i])
					{
						num++;
					}
				}
				if (showMsg)
				{
				}
				if (num >= count)
				{
					return true;
				}
			}
			return false;
		}

		public void Set_DayQuest(int UserWorldId, int idquest, int count = 1)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				for (int i = 0; i < count; i++)
				{
					Players players = value;
					players.FLD_DayQuest_Array = players.FLD_DayQuest_Array + idquest + ";";
				}
			}
		}

		public void Remove_DayQuest(int UserWorldId, int idquest)
		{
			if (!World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				return;
			}
			string text = "";
			string[] array = value.FLD_DayQuest_Array.Split(';');
			for (int i = 0; i < array.Length; i++)
			{
				if (idquest.ToString() != array[i])
				{
					text = text + array[i] + ";";
				}
			}
			value.FLD_DayQuest_Array = text;
		}

		public void Remove_AllDayQuest(int UserWorldId)
		{
			if (World.AllConnectedChars.TryGetValue(UserWorldId, out Players value))
			{
				value.FLD_DayQuest_Array = "";
			}
		}

		public void Load_LuaScript_API()
		{
			try
			{
				pLuaVM = new Lua();
				pLuaVM.RegisterFunction("SendMissionMsg", this, GetType().GetMethod("任务提示数据发送"));
				pLuaVM.RegisterFunction("SendSysMsg", this, GetType().GetMethod("系统提示"));
				pLuaVM.RegisterFunction("SendKongfuMsg", this, GetType().GetMethod("学习技能提示"));
				pLuaVM.RegisterFunction("AddQuest", this, GetType().GetMethod("设置任务数据"));
				pLuaVM.RegisterFunction("AddMission", this, GetType().GetMethod("设置任务数据"));
				pLuaVM.RegisterFunction("AddStKongfu", this, GetType().GetMethod("学习升天武功书"));
				pLuaVM.RegisterFunction("AddQigong", this, GetType().GetMethod("新学气功"));
				pLuaVM.RegisterFunction("AddSkill", this, GetType().GetMethod("学习技能"));
				pLuaVM.RegisterFunction("AddSkillBook6", this, GetType().GetMethod("发送六转技能书"));
				pLuaVM.RegisterFunction("AddSkillBook7", this, GetType().GetMethod("发送七转技能书"));
				pLuaVM.RegisterFunction("AddSkillBook8", this, GetType().GetMethod("发送八转技能书"));
				pLuaVM.RegisterFunction("AddSkillBook9", this, GetType().GetMethod("发送九转技能书"));
				pLuaVM.RegisterFunction("AddItme", this, GetType().GetMethod("增加物品Script"));
				pLuaVM.RegisterFunction("AddItmeProp", this, GetType().GetMethod("增加物品带属性"));
				pLuaVM.RegisterFunction("AddItmePropts", this, GetType().GetMethod("增加物品带属性天数"));
				pLuaVM.RegisterFunction("DelItme", this, GetType().GetMethod("删除物品"));
				pLuaVM.RegisterFunction("AddQuestItme", this, GetType().GetMethod("增加任务物品"));
				pLuaVM.RegisterFunction("GetWorldItme", this, GetType().GetMethod("GetWorldItme"));
				pLuaVM.RegisterFunction("GetPlayer", this, GetType().GetMethod("GetPlayerThis"));
				pLuaVM.RegisterFunction("GetQuestLevel", this, GetType().GetMethod("Get任务阶段"));
				pLuaVM.RegisterFunction("GetPackage", this, GetType().GetMethod("得到包裹空位位置"));
				pLuaVM.RegisterFunction("GetPackages", this, GetType().GetMethod("得到包裹空位位置组"));
				pLuaVM.RegisterFunction("GetPakItme", this, GetType().GetMethod("得到包裹物品"));
				pLuaVM.RegisterFunction("GetPakItmesx", this, GetType().GetMethod("GetPakItmesx"));
				pLuaVM.RegisterFunction("checkEquipItem", this, GetType().GetMethod("checkEquipItem"));
				pLuaVM.RegisterFunction("GetQuestItme", this, GetType().GetMethod("得到任务物品"));
				pLuaVM.RegisterFunction("Hfgzhuanzhi", this, GetType().GetMethod("UpgradeSpecialWeapons"));
				pLuaVM.RegisterFunction("SetPlayerLevel", this, GetType().GetMethod("设置玩家等级"));
				pLuaVM.RegisterFunction("Hfgwuqi", this, GetType().GetMethod("checkEquipSpecialWeapons"));
				pLuaVM.RegisterFunction("SetPlayerTransfer", this, GetType().GetMethod("人物转职业"));
				pLuaVM.RegisterFunction("SetQigong", this, GetType().GetMethod("新学气功"));
				pLuaVM.RegisterFunction("SetPlayerVIP", this, GetType().GetMethod("设置人物会员"));
				pLuaVM.RegisterFunction("SetPlayerRxpiont", this, GetType().GetMethod("设置人物元宝"));
				pLuaVM.RegisterFunction("SetPlayerShuxing", this, GetType().GetMethod("设置人物属性"));
				pLuaVM.RegisterFunction("SetPlayerVipdj", this, GetType().GetMethod("设置会员等级"));
				pLuaVM.RegisterFunction("SetPlayerSE", this, GetType().GetMethod("设置玩家善恶"));
				pLuaVM.RegisterFunction("UpGongFu", this, GetType().GetMethod("更新武功和状态"));
				pLuaVM.RegisterFunction("UpJsjbsj", this, GetType().GetMethod("计算人物基本数据"));
				pLuaVM.RegisterFunction("UpHpMpSp", this, GetType().GetMethod("更新_HP_MP_HP"));
				pLuaVM.RegisterFunction("UpMoney", this, GetType().GetMethod("更新金钱和负重"));
				pLuaVM.RegisterFunction("UpExp", this, GetType().GetMethod("更新经验和历练"));
				pLuaVM.RegisterFunction("UpYzbItme", this, GetType().GetMethod("初始话已装备物品"));
				pLuaVM.RegisterFunction("UpUseItme", this, GetType().GetMethod("物品使用"));
				pLuaVM.RegisterFunction("GetPakItemNum", this, GetType().GetMethod("得到包裹物品数量"));
				pLuaVM.RegisterFunction("GetRxpiont", this, GetType().GetMethod("得到元宝数据"));
				pLuaVM.RegisterFunction("TEstMsg", this, GetType().GetMethod("TEstMsg"));
				pLuaVM.RegisterFunction("AddExpToCharacter", this, GetType().GetMethod("AddExpToCharacter"));
				pLuaVM.RegisterFunction("AddKiToCharacter", this, GetType().GetMethod("AddKiToCharacter"));
				pLuaVM.RegisterFunction("Addmoneygg", this, GetType().GetMethod("AddMoneyToCharacter"));
				pLuaVM.RegisterFunction("AddMoneyToCharacter", this, GetType().GetMethod("AddMoneyToCharacter"));
				pLuaVM.RegisterFunction("AddWuxunToCharacter", this, GetType().GetMethod("AddWuxunToCharacter"));
				pLuaVM.RegisterFunction("AddGuildPoint", this, GetType().GetMethod("AddGuildPoint"));
				pLuaVM.RegisterFunction("GetRandomFix", this, GetType().GetMethod("GetRandomFix"));
				pLuaVM.RegisterFunction("GetRandom", this, GetType().GetMethod("GetRandom"));
				pLuaVM.RegisterFunction("GetQuestItmeNum", this, GetType().GetMethod("GetQuestItmeNum"));
				pLuaVM.RegisterFunction("Get_Player_Level", this, GetType().GetMethod("Get_Player_Level"));
				pLuaVM.RegisterFunction("Get_Player_WuXun", this, GetType().GetMethod("Get_Player_WuXun"));
				pLuaVM.RegisterFunction("Get_Player_Job", this, GetType().GetMethod("Get_Player_Job"));
				pLuaVM.RegisterFunction("Get_Player_Money", this, GetType().GetMethod("Get_Player_Money"));
				pLuaVM.RegisterFunction("Get_Player_ExpErience", this, GetType().GetMethod("Get_Player_ExpErience"));
				pLuaVM.RegisterFunction("Get_Player_Zx", this, GetType().GetMethod("Get_Player_Zx"));
				pLuaVM.RegisterFunction("Get_Player_Job_Level", this, GetType().GetMethod("Get_Player_Job_Level"));
				pLuaVM.RegisterFunction("Get_Player_Sex", this, GetType().GetMethod("Get_Player_Sex"));
				pLuaVM.RegisterFunction("Addexporll", this, GetType().GetMethod("Addexporll"));
				pLuaVM.RegisterFunction("Get_DayQuest", this, GetType().GetMethod("Get_DayQuest"));
				pLuaVM.RegisterFunction("Set_DayQuest", this, GetType().GetMethod("Set_DayQuest"));
			}
			catch (Exception ex)
			{
				Form1.WriteLine(2, "ERROR: Can't Load API Lua Script - " + ex.Message);
			}
		}

		public void 注册事件()
		{
			打开物品事件 = pLuaVM.GetFunction("OpenItmeTrigGer");
			怪物死亡事件 = pLuaVM.GetFunction("DestroyMonster");
			物品兑换事件 = pLuaVM.GetFunction("ExchangeItem");
		}
	}
}

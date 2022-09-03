using RxjhServer.RxjhServer;
using System;
using System.Collections.Generic;

namespace RxjhServer
{
	public class MartialArts : IDisposable
	{
		private int eval_a;

		private int eval_b;

		private int eval_c;

		private int eval_d;

		private int eval_e;

		private int eval_f;

		private int eval_g;

		private int eval_h;

		private int eval_i;

		private int eval_j;

		private int eval_k;

		private int eval_l;

		private int eval_m;

		private int eval_n;

		private int eval_o;

		public int FLD_TYPE;

		public int FLD_每级加等级;

		public int FLD_每级加MP;

		public int FLD_每级加历练;

		public int FLD_每级加危害;

		public int FLD_每级武功点数;

		public List<int> FLD_每级加MP_Array;

		public List<int> FLD_每级加等级_Array;

		public List<int> FLD_每级加历练_Array;

		public List<int> FLD_每级加危害_Array;

		public int FLD_AT
		{
			get
			{
				return eval_j;
			}
			set
			{
				eval_j = value;
			}
		}

		public int FLD_EFFERT
		{
			get
			{
				return eval_l;
			}
			set
			{
				eval_l = value;
			}
		}

		public int FLD_INDEX
		{
			get
			{
				return eval_m;
			}
			set
			{
				eval_m = value;
			}
		}

		public int FLD_JOB
		{
			get
			{
				return eval_e;
			}
			set
			{
				eval_e = value;
			}
		}

		public int FLD_JOBLEVEL
		{
			get
			{
				return eval_f;
			}
			set
			{
				eval_f = value;
			}
		}

		public int FLD_LEVEL
		{
			get
			{
				return eval_g;
			}
			set
			{
				eval_g = value;
			}
		}

		public int FLD_MP
		{
			get
			{
				return eval_h;
			}
			set
			{
				eval_h = value;
			}
		}

		public int FLD_NEEDEXP
		{
			get
			{
				return eval_i;
			}
			set
			{
				eval_i = value;
			}
		}

		public int FLD_PID
		{
			get
			{
				return eval_c;
			}
			set
			{
				eval_c = value;
			}
		}

		public int FLD_SKILL_TIME
		{
			get
			{
				return eval_k;
			}
			set
			{
				eval_k = value;
			}
		}

		public int FLD_ZX
		{
			get
			{
				return eval_d;
			}
			set
			{
				eval_d = value;
			}
		}

		public int FLD_攻击数量
		{
			get
			{
				return eval_n;
			}
			set
			{
				eval_n = value;
			}
		}

		public int FLD_武功类型
		{
			get
			{
				return eval_o;
			}
			set
			{
				eval_o = value;
			}
		}

		public int 武功_等级
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

		public byte[] 武功ID_byte => BitConverter.GetBytes(FLD_PID);

		public int 最高武功_等级
		{
			get
			{
				return eval_b;
			}
			set
			{
				eval_b = value;
			}
		}

		public int 每级加等级(int level)
		{
			if (FLD_每级加等级_Array.Count > 0)
			{
				return FLD_每级加等级_Array[level - 1];
			}
			return FLD_每级加等级 * level;
		}

		public int 每级加MP(int level)
		{
			if (FLD_每级加MP_Array.Count > 0)
			{
				return FLD_每级加MP_Array[level - 1];
			}
			return FLD_每级加MP * level;
		}

		public int 每级加历练(int level)
		{
			if (FLD_每级加历练_Array.Count > 0)
			{
				return FLD_每级加历练_Array[level];
			}
			return FLD_每级加历练 * level;
		}

		public int 每级加危害(int level)
		{
			if (FLD_每级加危害_Array.Count > 0)
			{
				return FLD_每级加危害_Array[level - 1];
			}
			return FLD_每级加危害 * level;
		}

		public MartialArts()
		{
		}

		public MartialArts(int FLD_PID_)
		{
			FLD_PID = FLD_PID_;
			初始化武功(FLD_PID);
		}

		public void Dispose()
		{
		}

		public static bool GetsfeWg(Players Playe, int wgid)
		{
			if (!World.TblKongfu.TryGetValue(wgid, out MartialArts value))
			{
				return false;
			}
			if (value == null)
			{
				return false;
			}
			return Playe.Array_Skill_Book[value.FLD_武功类型, value.FLD_INDEX].FLD_PID == wgid;
		}

		public static MartialArts GetWg(int 人物正邪, int 人物职业, int FLD_武功类型, int FLD_INDEX)
		{
			foreach (MartialArts value in World.TblKongfu.Values)
			{
				if (value.FLD_ZX == 0)
				{
					if (value.FLD_JOB == 人物职业 && value.FLD_INDEX == FLD_INDEX && value.FLD_武功类型 == FLD_武功类型)
					{
						return value;
					}
				}
				else if (value.FLD_ZX == 人物正邪 && value.FLD_JOB == 人物职业 && value.FLD_INDEX == FLD_INDEX && value.FLD_武功类型 == FLD_武功类型)
				{
					return value;
				}
			}
			return null;
		}

		public static MartialArts GetWg2(Players Playe, int FLD_武功类型, int FLD_INDEX)
		{
			foreach (MartialArts value in World.TblKongfu.Values)
			{
				if (value.FLD_JOB == Playe.Player_Job && value.FLD_INDEX == FLD_INDEX && value.FLD_武功类型 == FLD_武功类型)
				{
					return value;
				}
			}
			return null;
		}

		public void 初始化武功(int id)
		{
			if (World.TblKongfu.TryGetValue(id, out MartialArts value))
			{
				FLD_AT = value.FLD_AT;
				FLD_EFFERT = value.FLD_EFFERT;
				FLD_INDEX = value.FLD_INDEX;
				FLD_JOB = value.FLD_JOB;
				FLD_JOBLEVEL = value.FLD_JOBLEVEL;
				FLD_LEVEL = value.FLD_LEVEL;
				FLD_MP = value.FLD_MP;
				FLD_NEEDEXP = value.FLD_NEEDEXP;
				FLD_PID = value.FLD_PID;
				FLD_TYPE = value.FLD_TYPE;
				FLD_ZX = value.FLD_ZX;
				FLD_攻击数量 = value.FLD_攻击数量;
				FLD_武功类型 = value.FLD_武功类型;
				FLD_每级加等级 = value.FLD_每级加等级;
				FLD_每级加MP = value.FLD_每级加MP;
				FLD_每级加历练 = value.FLD_每级加历练;
				FLD_每级加危害 = value.FLD_每级加危害;
				FLD_每级加等级_Array = value.FLD_每级加等级_Array;
				FLD_每级加MP_Array = value.FLD_每级加MP_Array;
				FLD_每级加历练_Array = value.FLD_每级加历练_Array;
				FLD_每级加危害_Array = value.FLD_每级加危害_Array;
				FLD_每级武功点数 = value.FLD_每级武功点数;
				FLD_SKILL_TIME = value.FLD_SKILL_TIME;
				最高武功_等级 = value.最高武功_等级;
			}
		}

		public static void 学习升天武功书(Players Playe, int FLD_武功类型, int FLD_INDEX)
		{
			MartialArts wg = GetWg(Playe.Player_Zx, Playe.Player_Job, FLD_武功类型, FLD_INDEX);
			if (wg != null && Playe.Player_ExpErience >= wg.FLD_NEEDEXP && (wg.FLD_ZX == 0 || Playe.Player_Zx == wg.FLD_ZX) && (wg.FLD_JOB == 0 || Playe.Player_Job == wg.FLD_JOB) && (wg.FLD_JOBLEVEL == 0 || Playe.Player_Job_Level >= wg.FLD_JOBLEVEL) && (wg.FLD_LEVEL == 0 || Playe.Player_Level >= wg.FLD_LEVEL))
			{
				Playe.Array_Skill_Book[wg.FLD_武功类型, wg.FLD_INDEX] = new MartialArts(wg.FLD_PID);
				Playe.Array_Skill_Book[wg.FLD_武功类型, wg.FLD_INDEX].武功_等级 = 1;
			}
		}

		public static void Learn_Book_Skill_Ascension(Players Playe, ItmeClass 物品, int 包位置)
		{
			if (物品.FLD_LEVEL <= Playe.Player_Level && (物品.FLD_ZX == 0 || 物品.FLD_ZX == Playe.Player_Zx) && (物品.FLD_RESIDE1 == 0 || 物品.FLD_RESIDE1 == Playe.Player_Job) && (物品.FLD_JOB_LEVEL == 0 || 物品.FLD_JOB_LEVEL <= Playe.Player_Job_Level) && Playe.Player_Money >= 500000000 && Playe.Player_ExpErience >= 5000000)
			{
				学习升天武功书(Playe, 3, 1);
				学习升天武功书(Playe, 3, 2);
				Playe.Item_Use(包位置, 1);
				Playe.Player_ExpErience -= 5000000;
				Playe.Player_Money -= 500000000L;
				Playe.学习技能提示();
				Playe.UpdatePowersAndStatus();
				Playe.Update_Exp_Marble();
				Playe.Update_Money_Weight();
			}
		}

		public static void 学习升天武功书3(Players Playe, ItmeClass 物品, int 包位置)
		{
			if (物品.FLD_LEVEL <= Playe.Player_Level && (物品.FLD_ZX == 0 || 物品.FLD_ZX == Playe.Player_Zx) && (物品.FLD_RESIDE1 == 0 || 物品.FLD_RESIDE1 == Playe.Player_Job) && (物品.FLD_JOB_LEVEL == 0 || 物品.FLD_JOB_LEVEL <= Playe.Player_Job_Level) && Playe.Player_Money >= 500000000 && Playe.Player_ExpErience >= 5000000)
			{
				学习升天武功书(Playe, 3, 7);
				学习升天武功书(Playe, 3, 8);
				Playe.Item_Use(包位置, 1);
				Playe.Player_ExpErience -= 5000000;
				Playe.Player_Money -= 500000000L;
				Playe.学习技能提示();
				Playe.UpdatePowersAndStatus();
				Playe.Update_Exp_Marble();
				Playe.Update_Money_Weight();
			}
		}

		public static void 学习升天武功书4(Players Playe, ItmeClass 物品, int 包位置)
		{
			if (物品.FLD_LEVEL <= Playe.Player_Level && (物品.FLD_ZX == 0 || 物品.FLD_ZX == Playe.Player_Zx) && (物品.FLD_RESIDE1 == 0 || 物品.FLD_RESIDE1 == Playe.Player_Job) && (物品.FLD_JOB_LEVEL == 0 || 物品.FLD_JOB_LEVEL <= Playe.Player_Job_Level) && Playe.Player_Money >= 500000000 && Playe.Player_ExpErience >= 5000000)
			{
				学习升天武功书(Playe, 3, 10);
				学习升天武功书(Playe, 3, 11);
				Playe.Item_Use(包位置, 1);
				Playe.Player_ExpErience -= 5000000;
				Playe.Player_Money -= 500000000L;
				Playe.学习技能提示();
				Playe.UpdatePowersAndStatus();
				Playe.Update_Exp_Marble();
				Playe.Update_Money_Weight();
			}
		}

		public static void 学习升天武功书5(Players Playe, ItmeClass 物品, int 包位置)
		{
			if (物品.FLD_LEVEL <= Playe.Player_Level && (物品.FLD_ZX == 0 || 物品.FLD_ZX == Playe.Player_Zx) && (物品.FLD_RESIDE1 == 0 || 物品.FLD_RESIDE1 == Playe.Player_Job) && (物品.FLD_JOB_LEVEL == 0 || 物品.FLD_JOB_LEVEL <= Playe.Player_Job_Level) && Playe.Player_Money >= 500000000 && Playe.Player_ExpErience >= 5000000)
			{
				学习升天武功书(Playe, 3, 1);
				学习升天武功书(Playe, 3, 13);
				学习升天武功书(Playe, 3, 14);
				学习升天武功书(Playe, 3, 15);
				Playe.Item_Use(包位置, 1);
				Playe.Player_ExpErience -= 5000000;
				Playe.Player_Money -= 500000000L;
				Playe.学习技能提示();
				Playe.UpdatePowersAndStatus();
				Playe.Update_Exp_Marble();
				Playe.Update_Money_Weight();
			}
		}

		public static void 学习升天武功书6(Players Playe, ItmeClass 物品, int 包位置)
		{
			if (物品.FLD_LEVEL <= Playe.Player_Level && (物品.FLD_ZX == 0 || 物品.FLD_ZX == Playe.Player_Zx) && (物品.FLD_RESIDE1 == 0 || 物品.FLD_RESIDE1 == Playe.Player_Job) && (物品.FLD_JOB_LEVEL == 0 || 物品.FLD_JOB_LEVEL <= Playe.Player_Job_Level) && Playe.Player_Money >= 500000000 && Playe.Player_ExpErience >= 5000000)
			{
				学习升天武功书(Playe, 3, 5);
				Playe.Item_Use(包位置, 1);
				Playe.Player_ExpErience -= 5000000;
				Playe.Player_Money -= 500000000L;
				Playe.学习技能提示();
				Playe.UpdatePowersAndStatus();
				Playe.Update_Exp_Marble();
				Playe.Update_Money_Weight();
			}
		}

		public static void 学习升天武功书7(Players Playe, ItmeClass 物品, int 包位置)
		{
			if (物品.FLD_LEVEL <= Playe.Player_Level && (物品.FLD_ZX == 0 || 物品.FLD_ZX == Playe.Player_Zx) && (物品.FLD_RESIDE1 == 0 || 物品.FLD_RESIDE1 == Playe.Player_Job) && (物品.FLD_JOB_LEVEL == 0 || 物品.FLD_JOB_LEVEL <= Playe.Player_Job_Level) && Playe.Player_Money >= 500000000 && Playe.Player_ExpErience >= 5000000)
			{
				学习升天武功书(Playe, 3, 9);
				Playe.Item_Use(包位置, 1);
				Playe.Player_ExpErience -= 5000000;
				Playe.Player_Money -= 500000000L;
				Playe.学习技能提示();
				Playe.UpdatePowersAndStatus();
				Playe.Update_Exp_Marble();
				Playe.Update_Money_Weight();
			}
		}

		public static void Learn_Book_Skill(Players Playe, int FLD_武功类型, int FLD_INDEX, int 包位置)
		{
			MartialArts wg = GetWg(Playe.Player_Zx, Playe.Player_Job, FLD_武功类型, FLD_INDEX);
			if (wg != null && Playe.Player_ExpErience >= wg.FLD_NEEDEXP && (wg.FLD_ZX == 0 || Playe.Player_Zx == wg.FLD_ZX) && (wg.FLD_JOB == 0 || Playe.Player_Job == wg.FLD_JOB) && (wg.FLD_JOBLEVEL == 0 || Playe.Player_Job_Level >= wg.FLD_JOBLEVEL) && (wg.FLD_LEVEL == 0 || Playe.Player_Level >= wg.FLD_LEVEL))
			{
				Playe.Item_Use(包位置, 1);
				Playe.Array_Skill_Book[wg.FLD_武功类型, wg.FLD_INDEX] = new MartialArts(wg.FLD_PID);
				Playe.Player_ExpErience -= wg.FLD_NEEDEXP;
				Playe.学习技能提示();
				Playe.UpdatePowersAndStatus();
				Playe.Update_Exp_Marble();
			}
		}
	}
}

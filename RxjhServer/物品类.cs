using HelperTools;
using Network;
using RxjhServer.RxjhServer;
using System;

namespace RxjhServer
{
	public class 物品类 : IDisposable
	{
		private bool a_a;

		private int Get_物品位置;

		private Itimesx Itimesx1;

		private int eval_a0;

		private int eval_a1;

		private int eval_a2;

		private int eval_a3;

		private int eval_a4;

		private int eval_a5;

		private int eval_a6;

		private int eval_a7;

		private int eval_a8;

		private int eval_a9;

		private int eval_aa;

		private int eval_ab;

		private int eval_ac;

		private int eval_ad;

		private int eval_ae;

		private int eval_level;

		private int eval_af;

		private int eval_af2;

		private int eval_ag;

		private int eval_ah;

		private int eval_ai;

		private int eval_aj;

		private int eval_ak;

		private int eval_al;

		private int eval_am;

		private int eval_an;

		private int eval_ao;

		private int eval_ap;

		private int eval_aq;

		private int eval_ar;

		private int eval_as;

		private int eval_at;

		private int eval_au;

		private int eval_av;

		private int eval_aw;

		private int eval_ax;

		private int eval_ay;

		private int eval_az;

		private string eval_b_b;

		private int eval_b0;

		private int eval_b1;

		private int eval_b2;

		private int eval_b3;

		private int eval_b4;

		private int eval_b5;

		private int eval_b6;

		private int eval_b7;

		private int eval_b8;

		private int eval_b9;

		private int eval_ba;

		private int Get_物品属性_追加医体血倍增;

		private int Get_物品属性_追加医吸星大法;

		private int Get_物品属性_追加医天佑之气;

		private int eval_be;

		private int eval_bf;

		private int Get_物品属性_追加医洗髓易经;

		private int eval_bh;

		private int Get_物品属性_追加医运气行心;

		private int Get_物品属性_追加医长功攻击;

		private int eval_bk;

		private int eval_bl;

		private int eval_bm;

		private int eval_bn;

		private int eval_bo;

		private int eval_bp;

		private int eval_bq;

		private int eval_br;

		private int eval_bs;

		private int eval_bt;

		private int eval_bu;

		private int eval_bv;

		private int eval_bw;

		private int eval_bx;

		private int eval_by;

		private int eval_bz;

		private int eval_ca;

		private int eval_cb;

		private int eval_cc;

		private int eval_cd;

		private int _item_shield;

		private int _item_shield_recover;

		private int _item_hp_recover;

		private int _item_mp_recover;

		private byte[] eval_d;

		private long eval_i;

		private double _sucmanhcanhan_phantram;

		private long _Item_SucManhCaNhan;

		private long eval_j;

		private long eval_k;

		private int Get_物品属性强类型;

		private int _getItemLevelUpgrade;

		private int Get_物品属性阶段类型;

		private int Get_物品属性阶段数;

		private int eval_p;

		private int eval_q;

		private int eval_r;

		private double eval_s;

		private int eval_t;

		private int eval_u;

		private int eval_v;

		private int _Item_Attack_Skill_Point;

		private int _Item_Defense_Skill_Point;

		private int eval_w;

		private int eval_x;

		private int eval_y;

		private int eval_z;

		private int _Item_Evasion_Per;

		private int _Item_Accuracy_Per;

		private int qigong_11_job1;

		private int qigong_11_job2;

		private int qigong_11_job3;

		private int qigong_11_job4;

		private int qigong_11_job5;

		private int qigong_11_job6;

		private int qigong_11_job7;

		private int qigong_1_job8;

		private int qigong_2_job8;

		private int qigong_3_job8;

		private int qigong_4_job8;

		private int qigong_5_job8;

		private int qigong_6_job8;

		private int qigong_7_job8;

		private int qigong_8_job8;

		private int qigong_9_job8;

		private int qigong_10_job8;

		private int qigong_11_job8;

		private int qigong_1_job9;

		private int qigong_2_job9;

		private int qigong_3_job9;

		private int qigong_4_job9;

		private int qigong_5_job9;

		private int qigong_6_job9;

		private int qigong_7_job9;

		private int qigong_8_job9;

		private int qigong_9_job9;

		private int qigong_10_job9;

		private int qigong_11_job9;

		private int qigong_1_job10;

		private int qigong_2_job10;

		private int qigong_3_job10;

		private int qigong_4_job10;

		private int qigong_5_job10;

		private int qigong_6_job10;

		private int qigong_7_job10;

		private int qigong_8_job10;

		private int qigong_9_job10;

		private int qigong_10_job10;

		private int qigong_11_job10;

		private int qigong_1_job11;

		private int qigong_2_job11;

		private int qigong_3_job11;

		private int qigong_4_job11;

		private int qigong_5_job11;

		private int qigong_6_job11;

		private int qigong_7_job11;

		private int qigong_8_job11;

		private int qigong_9_job11;

		private int qigong_10_job11;

		private int qigong_11_job11;

		private int qigong_1_job12;

		private int qigong_2_job12;

		private int qigong_3_job12;

		private int qigong_4_job12;

		private int qigong_5_job12;

		private int qigong_6_job12;

		private int qigong_7_job12;

		private int qigong_8_job12;

		private int qigong_9_job12;

		private int qigong_10_job12;

		private int qigong_11_job12;

		private Itimesx Itimesx2;

		private Itimesx Itimesx3;

		private Itimesx Itimesx4;

		public bool LockMove;

		public int FLD_FJ_JSSJ
		{
			get
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(Byte_Item, 56, array, 0, 4);
				return BitConverter.ToInt32(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 56, 4);
			}
		}

		public int FLD_FJ_KSSJ
		{
			get
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(Byte_Item, 52, array, 0, 4);
				return BitConverter.ToInt32(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 52, 4);
			}
		}

		public int FLD_FJ_MAGIC0
		{
			get
			{
				byte[] array = new byte[2];
				Buffer.BlockCopy(Byte_Item, 36, array, 0, 2);
				return BitConverter.ToInt16(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 36, 2);
			}
		}

		public int FLD_FJ_MAGIC1
		{
			get
			{
				byte[] array = new byte[2];
				Buffer.BlockCopy(Byte_Item, 38, array, 0, 2);
				return BitConverter.ToInt16(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 38, 2);
			}
		}

		public int FLD_FJ_MAGIC2
		{
			get
			{
				byte[] array = new byte[2];
				Buffer.BlockCopy(Byte_Item, 42, array, 0, 2);
				return BitConverter.ToInt16(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 42, 2);
			}
		}

		public int FLD_FJ_MAGIC3
		{
			get
			{
				byte[] array = new byte[2];
				Buffer.BlockCopy(Byte_Item, 44, array, 0, 2);
				return BitConverter.ToInt16(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 44, 2);
			}
		}

		public int FLD_FJ_MAGIC4
		{
			get
			{
				byte[] array = new byte[2];
				Buffer.BlockCopy(Byte_Item, 46, array, 0, 2);
				return BitConverter.ToInt16(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 46, 2);
			}
		}

		public int FLD_FJ_MAGIC5
		{
			get
			{
				byte[] array = new byte[2];
				Buffer.BlockCopy(Byte_Item, 48, array, 0, 2);
				return BitConverter.ToInt16(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 48, 2);
			}
		}

		public int FLD_FJ_觉醒
		{
			get
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(Byte_Item, 62, array, 0, 4);
				return BitConverter.ToInt32(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 62, 4);
			}
		}

		public int FLD_FJ_进化
		{
			get
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(Byte_Item, 68, array, 0, 2);
				return BitConverter.ToInt32(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 68, 2);
			}
		}

		public int Type_TuLinh
		{
			get
			{
				byte[] array = new byte[2];
				Buffer.BlockCopy(Byte_Item, 71, array, 0, 1);
				return BitConverter.ToInt16(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 71, 1);
			}
		}

		public int FLD_FJ_中级附魂
		{
			get
			{
				try
				{
					byte[] array = new byte[2];
					Buffer.BlockCopy(Byte_Item, 40, array, 0, 2);
					return BitConverter.ToInt16(array, 0);
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "FLD_FJ_中级附魂 Get出错： [" + 得到物品string() + "]" + ex);
					return 0;
				}
			}
			set
			{
				try
				{
					if (value > 0)
					{
						Buffer.BlockCopy(BitConverter.GetBytes(1), 0, Byte_Item, 38, 2);
					}
					else if (value == 0)
					{
						Buffer.BlockCopy(BitConverter.GetBytes(0), 0, Byte_Item, 38, 2);
					}
					Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 40, 2);
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "FLD_FJ_中级附魂 Set出错： [" + 得到物品string() + "]" + ex);
				}
			}
		}

		public int FLD_MAGIC0
		{
			get
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(Byte_Item, 16, array, 0, 4);
				return BitConverter.ToInt32(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 16, 4);
			}
		}

		public int FLD_MAGIC1
		{
			get
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(Byte_Item, 20, array, 0, 4);
				return BitConverter.ToInt32(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 20, 4);
			}
		}

		public int FLD_MAGIC2
		{
			get
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(Byte_Item, 24, array, 0, 4);
				return BitConverter.ToInt32(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 24, 4);
			}
		}

		public int FLD_MAGIC3
		{
			get
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(Byte_Item, 28, array, 0, 4);
				return BitConverter.ToInt32(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 28, 4);
			}
		}

		public int FLD_MAGIC4
		{
			get
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(Byte_Item, 32, array, 0, 4);
				return BitConverter.ToInt32(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 32, 4);
			}
		}

		public int FLD_DAY1
		{
			get
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(Byte_Item, 52, array, 0, 4);
				return BitConverter.ToInt32(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 52, 4);
			}
		}

		public int FLD_DAY2
		{
			get
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(Byte_Item, 56, array, 0, 4);
				return BitConverter.ToInt32(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 56, 4);
			}
		}

		public int FLD_RESIDE1
		{
			get
			{
				return eval_af;
			}
			set
			{
				eval_af = value;
			}
		}

		public int FLD_LEVEL
		{
			get
			{
				return eval_level;
			}
			set
			{
				eval_level = value;
			}
		}

		public int FLD_RESIDE2
		{
			get
			{
				return eval_af2;
			}
			set
			{
				eval_af2 = value;
			}
		}

		public int FLD_持久力
		{
			get
			{
				byte[] array = new byte[2];
				Buffer.BlockCopy(Byte_Item, 60, array, 0, 2);
				return BitConverter.ToInt16(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 60, 2);
			}
		}

		public int FLD_强化类型
		{
			get
			{
				int fLD_MAGIC = FLD_MAGIC0;
				if (fLD_MAGIC > 0)
				{
					string text = fLD_MAGIC.ToString();
					return int.Parse(text.Substring(text.Length - 8, 1));
				}
				return 0;
			}
		}

		public int FLD_强化数量
		{
			get
			{
				int fLD_MAGIC = FLD_MAGIC0;
				if (fLD_MAGIC > 0)
				{
					string text = fLD_MAGIC.ToString();
					return int.Parse(text.Substring(text.Length - 2, 2));
				}
				return 0;
			}
		}

		public int FLD_属性类型
		{
			get
			{
				int fLD_MAGIC = FLD_MAGIC0;
				if (fLD_MAGIC > 0 && fLD_MAGIC > 1000000000)
				{
					string text = fLD_MAGIC.ToString();
					return int.Parse(text.Substring(text.Length - 4, 1));
				}
				return 0;
			}
		}

		public int FLD_属性数量
		{
			get
			{
				int fLD_MAGIC = FLD_MAGIC0;
				if (fLD_MAGIC > 0 && fLD_MAGIC > 1000000000)
				{
					string text = fLD_MAGIC.ToString();
					return int.Parse(text.Substring(text.Length - 3, 1));
				}
				return 0;
			}
		}

		public long FLD_PID
		{
			get
			{
				return BitConverter.ToInt32(Byte_Item, 8);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 8, 4);
			}
		}

		public long Get物品全局ID => BitConverter.ToInt64(Byte_Item, 0);

		public int Get_Int_Item_Count => BitConverter.ToInt32(Byte_Item, 12);

		public Itimesx 属性1
		{
			get
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(Byte_Item, 20, array, 0, 4);
				属性1 = new Itimesx(array);
				return Itimesx1;
			}
			set
			{
				Itimesx1 = value;
			}
		}

		public Itimesx 属性2
		{
			get
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(Byte_Item, 24, array, 0, 4);
				属性2 = new Itimesx(array);
				return Itimesx2;
			}
			set
			{
				Itimesx2 = value;
			}
		}

		public Itimesx 属性3
		{
			get
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(Byte_Item, 28, array, 0, 4);
				属性3 = new Itimesx(array);
				return Itimesx3;
			}
			set
			{
				Itimesx3 = value;
			}
		}

		public Itimesx 属性4
		{
			get
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(Byte_Item, 32, array, 0, 4);
				属性4 = new Itimesx(array);
				return Itimesx4;
			}
			set
			{
				Itimesx4 = value;
			}
		}

		public byte[] Byte_Item
		{
			get
			{
				return eval_d;
			}
			set
			{
				LockMove = false;
				eval_d = value;
			}
		}

		public int 物品_中级附魂_追加_觉醒
		{
			get
			{
				return eval_ac;
			}
			set
			{
				eval_ac = value;
			}
		}

		public byte[] Get_Byte_Item_PID => 得到物品ID();

		public string 物品string
		{
			get
			{
				return 得到物品string();
			}
			set
			{
				eval_b_b = value;
			}
		}

		public bool 物品绑定
		{
			get
			{
				try
				{
					byte[] array = new byte[2];
					Buffer.BlockCopy(Byte_Item, 72, array, 0, 1);
					return BitConverter.ToInt16(array, 0) != 0;
				}
				catch (Exception)
				{
					return false;
				}
			}
			set
			{
				a_a = value;
			}
		}

		public int 物品单个重量 => 得到物品单个重量();

		public long Item_Defense
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

		public long Item_SucManhCaNhan
		{
			get
			{
				return _Item_SucManhCaNhan;
			}
			set
			{
				_Item_SucManhCaNhan = value;
			}
		}

		public double Item_SucManhCaNhan_PhanTram
		{
			get
			{
				return _sucmanhcanhan_phantram;
			}
			set
			{
				_sucmanhcanhan_phantram = value;
			}
		}

		public int Item_Shield
		{
			get
			{
				return _item_shield;
			}
			set
			{
				_item_shield = value;
			}
		}

		public int Item_Shield_Recover
		{
			get
			{
				return _item_shield_recover;
			}
			set
			{
				_item_shield_recover = value;
			}
		}

		public int Item_HP_Recover
		{
			get
			{
				return _item_hp_recover;
			}
			set
			{
				_item_hp_recover = value;
			}
		}

		public int Item_MP_Recover
		{
			get
			{
				return _item_mp_recover;
			}
			set
			{
				_item_mp_recover = value;
			}
		}

		public long Item_Attack_Min
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

		public long Item_Attack_Max
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

		public int 物品类型 => 得到物品类型();

		public byte[] 物品全局ID => 得到全局ID();

		public byte[] Get_Byte_Item_Option => 得到物品属性();

		public int 物品属性_防御力增加
		{
			get
			{
				return eval_q;
			}
			set
			{
				eval_q = value;
			}
		}

		public int 物品属性_攻击力增加
		{
			get
			{
				return eval_p;
			}
			set
			{
				eval_p = value;
			}
		}

		public double 物品属性_行囊负重
		{
			get
			{
				return eval_s;
			}
			set
			{
				eval_s = value;
			}
		}

		public int Item_Evasion
		{
			get
			{
				return eval_v;
			}
			set
			{
				eval_v = value;
			}
		}

		public int Item_Attack_Skill_Point
		{
			get
			{
				return _Item_Attack_Skill_Point;
			}
			set
			{
				_Item_Attack_Skill_Point = value;
			}
		}

		public int Item_Defense_Skill_Point
		{
			get
			{
				return _Item_Defense_Skill_Point;
			}
			set
			{
				_Item_Defense_Skill_Point = value;
			}
		}

		public int 物品属性_获得金钱增加
		{
			get
			{
				return eval_ab;
			}
			set
			{
				eval_ab = value;
			}
		}

		public int 物品属性_经验获得增加
		{
			get
			{
				return eval_ae;
			}
			set
			{
				eval_ae = value;
			}
		}

		public int Item_Accuracy
		{
			get
			{
				return eval_u;
			}
			set
			{
				eval_u = value;
			}
		}

		public int Item_Evasion_Per
		{
			get
			{
				return _Item_Evasion_Per;
			}
			set
			{
				_Item_Evasion_Per = value;
			}
		}

		public int Item_Accuracy_Per
		{
			get
			{
				return _Item_Accuracy_Per;
			}
			set
			{
				_Item_Accuracy_Per = value;
			}
		}

		public int 物品属性_内功力增加
		{
			get
			{
				return eval_t;
			}
			set
			{
				eval_t = value;
			}
		}

		public int Level_Qigong_All
		{
			get
			{
				return eval_x;
			}
			set
			{
				eval_x = value;
			}
		}

		public int 物品属性_升级成功率
		{
			get
			{
				return eval_y;
			}
			set
			{
				eval_y = value;
			}
		}

		public int 物品属性_生命力增加
		{
			get
			{
				return eval_r;
			}
			set
			{
				eval_r = value;
			}
		}

		public int 物品属性_死亡损失经验减少
		{
			get
			{
				return eval_ad;
			}
			set
			{
				eval_ad = value;
			}
		}

		public int Item_Defense_Skill
		{
			get
			{
				return eval_aa;
			}
			set
			{
				eval_aa = value;
			}
		}

		public int Item_Attack_Skill
		{
			get
			{
				return eval_w;
			}
			set
			{
				eval_w = value;
			}
		}

		public int 物品属性_qigong_3_job6
		{
			get
			{
				return eval_av;
			}
			set
			{
				eval_av = value;
			}
		}

		public int 物品属性_qigong_10_job6
		{
			get
			{
				return eval_as;
			}
			set
			{
				eval_as = value;
			}
		}

		public int 物品属性_qigong_0_job6
		{
			get
			{
				return eval_ax;
			}
			set
			{
				eval_ax = value;
			}
		}

		public int 物品属性_qigong_2_job6
		{
			get
			{
				return eval_az;
			}
			set
			{
				eval_az = value;
			}
		}

		public int 物品属性_qigong_9_job6
		{
			get
			{
				return eval_ay;
			}
			set
			{
				eval_ay = value;
			}
		}

		public int 物品属性_qigong_8_job6
		{
			get
			{
				return eval_at;
			}
			set
			{
				eval_at = value;
			}
		}

		public int 物品属性_qigong_1_job6
		{
			get
			{
				return eval_aq;
			}
			set
			{
				eval_aq = value;
			}
		}

		public int 物品属性_qigong_7_job6
		{
			get
			{
				return eval_ar;
			}
			set
			{
				eval_ar = value;
			}
		}

		public int 物品属性_qigong_4_job6
		{
			get
			{
				return eval_au;
			}
			set
			{
				eval_au = value;
			}
		}

		public int 物品属性_qigong_5_job6
		{
			get
			{
				return eval_aw;
			}
			set
			{
				eval_aw = value;
			}
		}

		public int 物品属性_qigong_9_job1
		{
			get
			{
				return eval_ak;
			}
			set
			{
				eval_ak = value;
			}
		}

		public int 物品属性_qigong_7_job1
		{
			get
			{
				return eval_ap;
			}
			set
			{
				eval_ap = value;
			}
		}

		public int 物品属性_qigong_3_job1
		{
			get
			{
				return eval_ai;
			}
			set
			{
				eval_ai = value;
			}
		}

		public int 物品属性_qigong_4_job1
		{
			get
			{
				return eval_al;
			}
			set
			{
				eval_al = value;
			}
		}

		public int 物品属性_qigong_11_job1
		{
			get
			{
				return qigong_11_job1;
			}
			set
			{
				qigong_11_job1 = value;
			}
		}

		public int 物品属性_qigong_11_job2
		{
			get
			{
				return qigong_11_job2;
			}
			set
			{
				qigong_11_job2 = value;
			}
		}

		public int 物品属性_qigong_11_job3
		{
			get
			{
				return qigong_11_job3;
			}
			set
			{
				qigong_11_job3 = value;
			}
		}

		public int 物品属性_qigong_11_job4
		{
			get
			{
				return qigong_11_job4;
			}
			set
			{
				qigong_11_job4 = value;
			}
		}

		public int 物品属性_qigong_11_job5
		{
			get
			{
				return qigong_11_job5;
			}
			set
			{
				qigong_11_job5 = value;
			}
		}

		public int 物品属性_qigong_11_job6
		{
			get
			{
				return qigong_11_job6;
			}
			set
			{
				qigong_11_job6 = value;
			}
		}

		public int 物品属性_qigong_11_job7
		{
			get
			{
				return qigong_11_job7;
			}
			set
			{
				qigong_11_job7 = value;
			}
		}

		public int 物品属性_qigong_0_job8
		{
			get
			{
				return qigong_1_job8;
			}
			set
			{
				qigong_1_job8 = value;
			}
		}

		public int 物品属性_qigong_1_job8
		{
			get
			{
				return qigong_2_job8;
			}
			set
			{
				qigong_2_job8 = value;
			}
		}

		public int 物品属性_qigong_2_job8
		{
			get
			{
				return qigong_3_job8;
			}
			set
			{
				qigong_3_job8 = value;
			}
		}

		public int 物品属性_qigong_3_job8
		{
			get
			{
				return qigong_4_job8;
			}
			set
			{
				qigong_4_job8 = value;
			}
		}

		public int 物品属性_qigong_4_job8
		{
			get
			{
				return qigong_5_job8;
			}
			set
			{
				qigong_5_job8 = value;
			}
		}

		public int 物品属性_qigong_5_job8
		{
			get
			{
				return qigong_6_job8;
			}
			set
			{
				qigong_6_job8 = value;
			}
		}

		public int 物品属性_qigong_7_job8
		{
			get
			{
				return qigong_7_job8;
			}
			set
			{
				qigong_7_job8 = value;
			}
		}

		public int 物品属性_qigong_8_job8
		{
			get
			{
				return qigong_8_job8;
			}
			set
			{
				qigong_8_job8 = value;
			}
		}

		public int 物品属性_qigong_9_job8
		{
			get
			{
				return qigong_9_job8;
			}
			set
			{
				qigong_9_job8 = value;
			}
		}

		public int 物品属性_qigong_10_job8
		{
			get
			{
				return qigong_10_job8;
			}
			set
			{
				qigong_10_job8 = value;
			}
		}

		public int 物品属性_qigong_11_job8
		{
			get
			{
				return qigong_11_job8;
			}
			set
			{
				qigong_11_job8 = value;
			}
		}

		public int 物品属性_qigong_0_job9
		{
			get
			{
				return qigong_1_job9;
			}
			set
			{
				qigong_1_job9 = value;
			}
		}

		public int 物品属性_qigong_1_job9
		{
			get
			{
				return qigong_2_job9;
			}
			set
			{
				qigong_2_job9 = value;
			}
		}

		public int 物品属性_qigong_2_job9
		{
			get
			{
				return qigong_3_job9;
			}
			set
			{
				qigong_3_job9 = value;
			}
		}

		public int 物品属性_qigong_3_job9
		{
			get
			{
				return qigong_4_job9;
			}
			set
			{
				qigong_4_job9 = value;
			}
		}

		public int 物品属性_qigong_4_job9
		{
			get
			{
				return qigong_5_job9;
			}
			set
			{
				qigong_5_job9 = value;
			}
		}

		public int 物品属性_qigong_5_job9
		{
			get
			{
				return qigong_6_job9;
			}
			set
			{
				qigong_6_job9 = value;
			}
		}

		public int 物品属性_qigong_7_job9
		{
			get
			{
				return qigong_7_job9;
			}
			set
			{
				qigong_7_job9 = value;
			}
		}

		public int 物品属性_qigong_8_job9
		{
			get
			{
				return qigong_8_job9;
			}
			set
			{
				qigong_8_job9 = value;
			}
		}

		public int 物品属性_qigong_9_job9
		{
			get
			{
				return qigong_9_job9;
			}
			set
			{
				qigong_9_job9 = value;
			}
		}

		public int 物品属性_qigong_10_job9
		{
			get
			{
				return qigong_10_job9;
			}
			set
			{
				qigong_10_job9 = value;
			}
		}

		public int 物品属性_qigong_11_job9
		{
			get
			{
				return qigong_11_job9;
			}
			set
			{
				qigong_11_job9 = value;
			}
		}

		public int 物品属性_qigong_0_job10
		{
			get
			{
				return qigong_1_job10;
			}
			set
			{
				qigong_1_job10 = value;
			}
		}

		public int 物品属性_qigong_1_job10
		{
			get
			{
				return qigong_2_job10;
			}
			set
			{
				qigong_2_job10 = value;
			}
		}

		public int 物品属性_qigong_2_job10
		{
			get
			{
				return qigong_3_job10;
			}
			set
			{
				qigong_3_job10 = value;
			}
		}

		public int 物品属性_qigong_3_job10
		{
			get
			{
				return qigong_4_job10;
			}
			set
			{
				qigong_4_job10 = value;
			}
		}

		public int 物品属性_qigong_4_job10
		{
			get
			{
				return qigong_5_job10;
			}
			set
			{
				qigong_5_job10 = value;
			}
		}

		public int 物品属性_qigong_5_job10
		{
			get
			{
				return qigong_6_job10;
			}
			set
			{
				qigong_6_job10 = value;
			}
		}

		public int 物品属性_qigong_7_job10
		{
			get
			{
				return qigong_7_job10;
			}
			set
			{
				qigong_7_job10 = value;
			}
		}

		public int 物品属性_qigong_8_job10
		{
			get
			{
				return qigong_8_job10;
			}
			set
			{
				qigong_8_job10 = value;
			}
		}

		public int 物品属性_qigong_9_job10
		{
			get
			{
				return qigong_9_job10;
			}
			set
			{
				qigong_9_job10 = value;
			}
		}

		public int 物品属性_qigong_10_job10
		{
			get
			{
				return qigong_10_job10;
			}
			set
			{
				qigong_10_job10 = value;
			}
		}

		public int 物品属性_qigong_11_job10
		{
			get
			{
				return qigong_11_job10;
			}
			set
			{
				qigong_11_job10 = value;
			}
		}

		public int 物品属性_qigong_0_job11
		{
			get
			{
				return qigong_1_job11;
			}
			set
			{
				qigong_1_job11 = value;
			}
		}

		public int 物品属性_qigong_1_job11
		{
			get
			{
				return qigong_2_job11;
			}
			set
			{
				qigong_2_job11 = value;
			}
		}

		public int 物品属性_qigong_2_job11
		{
			get
			{
				return qigong_3_job11;
			}
			set
			{
				qigong_3_job11 = value;
			}
		}

		public int 物品属性_qigong_3_job11
		{
			get
			{
				return qigong_4_job11;
			}
			set
			{
				qigong_4_job11 = value;
			}
		}

		public int 物品属性_qigong_4_job11
		{
			get
			{
				return qigong_5_job11;
			}
			set
			{
				qigong_5_job11 = value;
			}
		}

		public int 物品属性_qigong_5_job11
		{
			get
			{
				return qigong_6_job11;
			}
			set
			{
				qigong_6_job11 = value;
			}
		}

		public int 物品属性_qigong_7_job11
		{
			get
			{
				return qigong_7_job11;
			}
			set
			{
				qigong_7_job11 = value;
			}
		}

		public int 物品属性_qigong_8_job11
		{
			get
			{
				return qigong_8_job11;
			}
			set
			{
				qigong_8_job11 = value;
			}
		}

		public int 物品属性_qigong_9_job11
		{
			get
			{
				return qigong_9_job11;
			}
			set
			{
				qigong_9_job11 = value;
			}
		}

		public int 物品属性_qigong_10_job11
		{
			get
			{
				return qigong_10_job11;
			}
			set
			{
				qigong_10_job11 = value;
			}
		}

		public int 物品属性_qigong_11_job11
		{
			get
			{
				return qigong_11_job11;
			}
			set
			{
				qigong_11_job11 = value;
			}
		}

		public int 物品属性_qigong_0_job12
		{
			get
			{
				return qigong_1_job12;
			}
			set
			{
				qigong_1_job12 = value;
			}
		}

		public int 物品属性_qigong_1_job12
		{
			get
			{
				return qigong_2_job12;
			}
			set
			{
				qigong_2_job12 = value;
			}
		}

		public int 物品属性_qigong_2_job12
		{
			get
			{
				return qigong_3_job12;
			}
			set
			{
				qigong_3_job12 = value;
			}
		}

		public int 物品属性_qigong_3_job12
		{
			get
			{
				return qigong_4_job12;
			}
			set
			{
				qigong_4_job12 = value;
			}
		}

		public int 物品属性_qigong_4_job12
		{
			get
			{
				return qigong_5_job12;
			}
			set
			{
				qigong_5_job12 = value;
			}
		}

		public int 物品属性_qigong_5_job12
		{
			get
			{
				return qigong_6_job12;
			}
			set
			{
				qigong_6_job12 = value;
			}
		}

		public int 物品属性_qigong_7_job12
		{
			get
			{
				return qigong_7_job12;
			}
			set
			{
				qigong_7_job12 = value;
			}
		}

		public int 物品属性_qigong_8_job12
		{
			get
			{
				return qigong_8_job12;
			}
			set
			{
				qigong_8_job12 = value;
			}
		}

		public int 物品属性_qigong_9_job12
		{
			get
			{
				return qigong_9_job12;
			}
			set
			{
				qigong_9_job12 = value;
			}
		}

		public int 物品属性_qigong_10_job12
		{
			get
			{
				return qigong_10_job12;
			}
			set
			{
				qigong_10_job12 = value;
			}
		}

		public int 物品属性_qigong_11_job12
		{
			get
			{
				return qigong_11_job12;
			}
			set
			{
				qigong_11_job12 = value;
			}
		}

		public int 物品属性_qigong_0_job1
		{
			get
			{
				return eval_ag;
			}
			set
			{
				eval_ag = value;
			}
		}

		public int 物品属性_qigong_2_job1
		{
			get
			{
				return eval_ao;
			}
			set
			{
				eval_ao = value;
			}
		}

		public int 物品属性_qigong_1_job1
		{
			get
			{
				return eval_aj;
			}
			set
			{
				eval_aj = value;
			}
		}

		public int 物品属性_qigong_5_job1
		{
			get
			{
				return eval_ah;
			}
			set
			{
				eval_ah = value;
			}
		}

		public int 物品属性_qigong_10_job1
		{
			get
			{
				return eval_an;
			}
			set
			{
				eval_an = value;
			}
		}

		public int 物品属性_qigong_8_job1
		{
			get
			{
				return eval_am;
			}
			set
			{
				eval_am = value;
			}
		}

		public int 物品属性_qigong_0_job4
		{
			get
			{
				return eval_bs;
			}
			set
			{
				eval_bs = value;
			}
		}

		public int 物品属性_qigong_3_job4
		{
			get
			{
				return eval_bm;
			}
			set
			{
				eval_bm = value;
			}
		}

		public int 物品属性_qigong_4_job4
		{
			get
			{
				return eval_bq;
			}
			set
			{
				eval_bq = value;
			}
		}

		public int 物品属性_qigong_1_job4
		{
			get
			{
				return eval_br;
			}
			set
			{
				eval_br = value;
			}
		}

		public int 物品属性_qigong_8_job4
		{
			get
			{
				return eval_bp;
			}
			set
			{
				eval_bp = value;
			}
		}

		public int 物品属性_qigong_2_job4
		{
			get
			{
				return eval_bk;
			}
			set
			{
				eval_bk = value;
			}
		}

		public int 物品属性_qigong_9_job4
		{
			get
			{
				return eval_bt;
			}
			set
			{
				eval_bt = value;
			}
		}

		public int 物品属性_qigong_10_job4
		{
			get
			{
				return eval_bn;
			}
			set
			{
				eval_bn = value;
			}
		}

		public int 物品属性_qigong_7_job4
		{
			get
			{
				return eval_bl;
			}
			set
			{
				eval_bl = value;
			}
		}

		public int 物品属性_qigong_5_job4
		{
			get
			{
				return eval_bo;
			}
			set
			{
				eval_bo = value;
			}
		}

		public int 物品属性_qigong_1_job2
		{
			get
			{
				return eval_a6;
			}
			set
			{
				eval_a6 = value;
			}
		}

		public int 物品属性_qigong_3_job2
		{
			get
			{
				return eval_a2;
			}
			set
			{
				eval_a2 = value;
			}
		}

		public int 物品属性_qigong_9_job2
		{
			get
			{
				return eval_a0;
			}
			set
			{
				eval_a0 = value;
			}
		}

		public int 物品属性_qigong_5_job2
		{
			get
			{
				return eval_a4;
			}
			set
			{
				eval_a4 = value;
			}
		}

		public int 物品属性_qigong_8_job2
		{
			get
			{
				return eval_a1;
			}
			set
			{
				eval_a1 = value;
			}
		}

		public int 物品属性_qigong_4_job2
		{
			get
			{
				return eval_a5;
			}
			set
			{
				eval_a5 = value;
			}
		}

		public int 物品属性_qigong_2_job2
		{
			get
			{
				return eval_a8;
			}
			set
			{
				eval_a8 = value;
			}
		}

		public int 物品属性_qigong_10_job2
		{
			get
			{
				return eval_a3;
			}
			set
			{
				eval_a3 = value;
			}
		}

		public int 物品属性_qigong_7_job2
		{
			get
			{
				return eval_a7;
			}
			set
			{
				eval_a7 = value;
			}
		}

		public int 物品属性_qigong_0_job2
		{
			get
			{
				return eval_a9;
			}
			set
			{
				eval_a9 = value;
			}
		}

		public int 物品属性_qigong_3_job3
		{
			get
			{
				return eval_bv;
			}
			set
			{
				eval_bv = value;
			}
		}

		public int 物品属性_qigong_5_job3
		{
			get
			{
				return eval_bw;
			}
			set
			{
				eval_bw = value;
			}
		}

		public int 物品属性_qigong_0_job3
		{
			get
			{
				return eval_b3;
			}
			set
			{
				eval_b3 = value;
			}
		}

		public int 物品属性_qigong_4_job3
		{
			get
			{
				return eval_bz;
			}
			set
			{
				eval_bz = value;
			}
		}

		public int 物品属性_qigong_9_job3
		{
			get
			{
				return eval_by;
			}
			set
			{
				eval_by = value;
			}
		}

		public int 物品属性_qigong_2_job3
		{
			get
			{
				return eval_b2;
			}
			set
			{
				eval_b2 = value;
			}
		}

		public int 物品属性_qigong_8_job3
		{
			get
			{
				return eval_bx;
			}
			set
			{
				eval_bx = value;
			}
		}

		public int 物品属性_qigong_7_job3
		{
			get
			{
				return eval_bu;
			}
			set
			{
				eval_bu = value;
			}
		}

		public int 物品属性_qigong_1_job3
		{
			get
			{
				return eval_b1;
			}
			set
			{
				eval_b1 = value;
			}
		}

		public int 物品属性_qigong_10_job3
		{
			get
			{
				return eval_b0;
			}
			set
			{
				eval_b0 = value;
			}
		}

		public int 物品属性_qigong_5_job7
		{
			get
			{
				return eval_cc;
			}
			set
			{
				eval_cc = value;
			}
		}

		public int 物品属性_qigong_4_job7
		{
			get
			{
				return eval_b7;
			}
			set
			{
				eval_b7 = value;
			}
		}

		public int 物品属性_qigong_9_job7
		{
			get
			{
				return eval_cd;
			}
			set
			{
				eval_cd = value;
			}
		}

		public int 物品属性_qigong_8_job7
		{
			get
			{
				return eval_b6;
			}
			set
			{
				eval_b6 = value;
			}
		}

		public int 物品属性_qigong_2_job7
		{
			get
			{
				return eval_b8;
			}
			set
			{
				eval_b8 = value;
			}
		}

		public int 物品属性_qigong_1_job7
		{
			get
			{
				return eval_b9;
			}
			set
			{
				eval_b9 = value;
			}
		}

		public int 物品属性_qigong_3_job7
		{
			get
			{
				return eval_ca;
			}
			set
			{
				eval_ca = value;
			}
		}

		public int 物品属性_qigong_10_job7
		{
			get
			{
				return eval_cb;
			}
			set
			{
				eval_cb = value;
			}
		}

		public int 物品属性_qigong_7_job7
		{
			get
			{
				return eval_b4;
			}
			set
			{
				eval_b4 = value;
			}
		}

		public int 物品属性_qigong_0_job7
		{
			get
			{
				return eval_b5;
			}
			set
			{
				eval_b5 = value;
			}
		}

		public int Item_Attack_Point
		{
			get
			{
				return eval_z;
			}
			set
			{
				eval_z = value;
			}
		}

		public int 物品属性_qigong_10_job5
		{
			get
			{
				return eval_ba;
			}
			set
			{
				eval_ba = value;
			}
		}

		public int 物品属性_qigong_4_job5
		{
			get
			{
				return eval_bf;
			}
			set
			{
				eval_bf = value;
			}
		}

		public int 物品属性_qigong_8_job5
		{
			get
			{
				return eval_bh;
			}
			set
			{
				eval_bh = value;
			}
		}

		public int 物品属性_qigong_1_job5
		{
			get
			{
				return eval_be;
			}
			set
			{
				eval_be = value;
			}
		}

		public int 物品属性_qigong_3_job5
		{
			get
			{
				return Get_物品属性_追加医体血倍增;
			}
			set
			{
				Get_物品属性_追加医体血倍增 = value;
			}
		}

		public int 物品属性_qigong_9_job5
		{
			get
			{
				return Get_物品属性_追加医天佑之气;
			}
			set
			{
				Get_物品属性_追加医天佑之气 = value;
			}
		}

		public int 物品属性_qigong_7_job5
		{
			get
			{
				return Get_物品属性_追加医吸星大法;
			}
			set
			{
				Get_物品属性_追加医吸星大法 = value;
			}
		}

		public int 物品属性_qigong_2_job5
		{
			get
			{
				return Get_物品属性_追加医洗髓易经;
			}
			set
			{
				Get_物品属性_追加医洗髓易经 = value;
			}
		}

		public int 物品属性_qigong_0_job5
		{
			get
			{
				return Get_物品属性_追加医运气行心;
			}
			set
			{
				Get_物品属性_追加医运气行心 = value;
			}
		}

		public int 物品属性_qigong_5_job5
		{
			get
			{
				return Get_物品属性_追加医长功攻击;
			}
			set
			{
				Get_物品属性_追加医长功攻击 = value;
			}
		}

		public int 物品属性阶段类型
		{
			get
			{
				return Get_物品属性阶段类型;
			}
			set
			{
				Get_物品属性阶段类型 = value;
			}
		}

		public int 物品属性阶段数
		{
			get
			{
				return Get_物品属性阶段数;
			}
			set
			{
				Get_物品属性阶段数 = value;
			}
		}

		public int Item_Level_Upgrade
		{
			get
			{
				return _getItemLevelUpgrade;
			}
			set
			{
				_getItemLevelUpgrade = value;
			}
		}

		public int 物品属性强类型
		{
			get
			{
				return Get_物品属性强类型;
			}
			set
			{
				Get_物品属性强类型 = value;
			}
		}

		public byte[] Item_Amount
		{
			get
			{
				return 得到物品数量();
			}
			set
			{
				设置物品数量(value);
			}
		}

		public int Bag
		{
			get
			{
				return Get_物品位置;
			}
			set
			{
				Get_物品位置 = value;
			}
		}

		public int 物品总重量 => 得到物品重量();

		public 物品类()
		{
		}

		public 物品类(byte[] 物品_byte_)
		{
			Byte_Item = 物品_byte_;
		}

		public 物品类(byte[] 物品_byte_, int 位置)
		{
			Byte_Item = 物品_byte_;
			Bag = 位置;
		}

		private void 得到强化_MAGIC0(string MAGIC0, int Cuonghoa_Pill_vk = 0, int Cuonghoa_Pill_tb = 0)
		{
			try
			{
				物品属性阶段类型 = 0;
				物品属性阶段数 = 0;
				物品属性强类型 = 0;
				Item_Level_Upgrade = 0;
				ItmeClass value;
				ItmeClass value2;
				switch (MAGIC0.Length)
				{
				default:
					return;
				case 8:
					物品属性强类型 = int.Parse(MAGIC0.Substring(0, 1));
					Item_Level_Upgrade = int.Parse(MAGIC0.Substring(MAGIC0.Length - 2, 2));
					if (FLD_RESIDE2 == 4)
					{
						Item_Level_Upgrade += Cuonghoa_Pill_vk;
					}
					else if (FLD_RESIDE2 == 1 || FLD_RESIDE2 == 2 || FLD_RESIDE2 == 5)
					{
						Item_Level_Upgrade += Cuonghoa_Pill_tb;
					}
					if (物品属性强类型 != 1)
					{
						break;
					}
					if (FLD_RESIDE2 != 7 && FLD_RESIDE2 != 8 && FLD_RESIDE2 != 10)
					{
						goto IL_0309;
					}
					goto IL_1148;
				case 9:
					物品属性强类型 = int.Parse(MAGIC0.Substring(0, 2));
					Item_Level_Upgrade = int.Parse(MAGIC0.Substring(MAGIC0.Length - 2, 2));
					if (FLD_RESIDE2 == 4)
					{
						Item_Level_Upgrade += Cuonghoa_Pill_vk;
					}
					else if (FLD_RESIDE2 == 1 || FLD_RESIDE2 == 2 || FLD_RESIDE2 == 5)
					{
						Item_Level_Upgrade += Cuonghoa_Pill_tb;
					}
					if (物品属性强类型 != 1)
					{
						break;
					}
					if (FLD_RESIDE2 != 7 && FLD_RESIDE2 != 8 && FLD_RESIDE2 != 10)
					{
						goto IL_0309;
					}
					goto IL_1148;
				case 10:
					{
						物品属性强类型 = int.Parse(MAGIC0.Substring(MAGIC0.Length - 8, 1));
						Item_Level_Upgrade = int.Parse(MAGIC0.Substring(MAGIC0.Length - 2, 2));
						if (FLD_RESIDE2 == 4)
						{
							Item_Level_Upgrade += Cuonghoa_Pill_vk;
						}
						else if (FLD_RESIDE2 == 1 || FLD_RESIDE2 == 2 || FLD_RESIDE2 == 5)
						{
							Item_Level_Upgrade += Cuonghoa_Pill_tb;
						}
						物品属性阶段类型 = int.Parse(MAGIC0.Substring(MAGIC0.Length - 4, 1));
						物品属性阶段数 = int.Parse(MAGIC0.Substring(MAGIC0.Length - 3, 1)) + 1;
						if (物品属性阶段数 > 0 && Item_Level_Upgrade > 5)
						{
							物品属性阶段数 += Item_Level_Upgrade - 5;
						}
						if (物品属性强类型 != 1)
						{
							break;
						}
						goto IL_0309;
					}
					IL_1148:
					if (World.Itme.TryGetValue(BitConverter.ToInt32(Get_Byte_Item_PID, 0), out value))
					{
						if (value.FLD_LEVEL >= 140)
						{
							if (Item_Level_Upgrade < 4)
							{
								Item_Attack_Min += Item_Level_Upgrade * 9;
								Item_Attack_Max += Item_Level_Upgrade * 9;
							}
							else
							{
								Item_Attack_Min += 27L;
								Item_Attack_Max += 27L;
								Item_Attack_Min += (Item_Level_Upgrade - 3) * 16;
								Item_Attack_Max += (Item_Level_Upgrade - 3) * 16;
							}
						}
						else if (value.FLD_LEVEL >= 130)
						{
							if (Item_Level_Upgrade < 4)
							{
								Item_Attack_Min += Item_Level_Upgrade * 7;
								Item_Attack_Max += Item_Level_Upgrade * 7;
							}
							else
							{
								Item_Attack_Min += 21L;
								Item_Attack_Max += 21L;
								Item_Attack_Min += (Item_Level_Upgrade - 3) * 13;
								Item_Attack_Max += (Item_Level_Upgrade - 3) * 13;
							}
						}
						else if (value.FLD_LEVEL >= 120)
						{
							if (Item_Level_Upgrade < 4)
							{
								Item_Attack_Min += Item_Level_Upgrade * 6;
								Item_Attack_Max += Item_Level_Upgrade * 6;
							}
							else
							{
								Item_Attack_Min += 18L;
								Item_Attack_Max += 18L;
								Item_Attack_Min += (Item_Level_Upgrade - 3) * 11;
								Item_Attack_Max += (Item_Level_Upgrade - 3) * 11;
								if (Item_Level_Upgrade > 4)
								{
									Item_Attack_Min++;
									Item_Attack_Max++;
								}
							}
						}
						else if (value.FLD_LEVEL >= 115)
						{
							if (Item_Level_Upgrade < 4)
							{
								Item_Attack_Min += Item_Level_Upgrade * 5;
								Item_Attack_Max += Item_Level_Upgrade * 5;
							}
							else
							{
								Item_Attack_Min += 15L;
								Item_Attack_Max += 15L;
								Item_Attack_Min += (Item_Level_Upgrade - 3) * 9;
								Item_Attack_Max += (Item_Level_Upgrade - 3) * 9;
							}
						}
						else if (value.FLD_LEVEL >= 100)
						{
							if (Item_Level_Upgrade < 4)
							{
								Item_Attack_Min += Item_Level_Upgrade * 4;
								Item_Attack_Max += Item_Level_Upgrade * 4;
							}
							else
							{
								Item_Attack_Min += 12L;
								Item_Attack_Max += 12L;
								Item_Attack_Min += (Item_Level_Upgrade - 3) * 7;
								Item_Attack_Max += (Item_Level_Upgrade - 3) * 7;
							}
						}
						else if (value.FLD_LEVEL >= 80)
						{
							if (Item_Level_Upgrade < 4)
							{
								Item_Attack_Min += Item_Level_Upgrade * 3;
								Item_Attack_Max += Item_Level_Upgrade * 3;
							}
							else
							{
								Item_Attack_Min += 9L;
								Item_Attack_Max += 9L;
								Item_Attack_Min += (Item_Level_Upgrade - 3) * 5;
								Item_Attack_Max += (Item_Level_Upgrade - 3) * 5;
							}
						}
						else if (value.FLD_LEVEL >= 60)
						{
							if (Item_Level_Upgrade < 4)
							{
								Item_Attack_Min += Item_Level_Upgrade * 2;
								Item_Attack_Max += Item_Level_Upgrade * 2;
							}
							else
							{
								Item_Attack_Min += 6L;
								Item_Attack_Max += 6L;
								Item_Attack_Min += (Item_Level_Upgrade - 3) * 3;
								Item_Attack_Max += (Item_Level_Upgrade - 3) * 3;
							}
						}
					}
					return;
					IL_0309:
					if (FLD_RESIDE2 == 4 && World.Itme.TryGetValue(BitConverter.ToInt32(Get_Byte_Item_PID, 0), out value2))
					{
						if (value2.isVKChan() && Item_Level_Upgrade >= 5)
						{
							if (Item_Level_Upgrade == 5)
							{
								Item_Attack_Min += 2L;
								Item_Attack_Max += 2L;
							}
							else if (Item_Level_Upgrade == 6)
							{
								Item_Attack_Min += 8L;
								Item_Attack_Max += 8L;
							}
							else if (Item_Level_Upgrade == 7)
							{
								Item_Attack_Min += 12L;
								Item_Attack_Max += 12L;
							}
							else if (Item_Level_Upgrade == 8)
							{
								Item_Attack_Min += 17L;
								Item_Attack_Max += 17L;
							}
							else if (Item_Level_Upgrade == 9)
							{
								Item_Attack_Min += 22L;
								Item_Attack_Max += 22L;
							}
							else if (Item_Level_Upgrade == 10)
							{
								Item_Attack_Min += 32L;
								Item_Attack_Max += 32L;
							}
							else if (Item_Level_Upgrade == 11)
							{
								Item_Attack_Min += 35L;
								Item_Attack_Max += 35L;
							}
							else if (Item_Level_Upgrade == 12)
							{
								Item_Attack_Min += 45L;
								Item_Attack_Max += 45L;
							}
							else if (Item_Level_Upgrade == 13)
							{
								Level_Qigong_All++;
								Item_Attack_Min += 55L;
								Item_Attack_Max += 55L;
							}
							else
							{
								Level_Qigong_All++;
								Item_Attack_Min += 60L;
								Item_Attack_Max += 60L;
							}
						}
						Item_Attack_Min += Item_Level_Upgrade * 6;
						Item_Attack_Max += Item_Level_Upgrade * 6;
						if (Item_Level_Upgrade > 5)
						{
							if (value2.FLD_LEVEL < 60)
							{
								Item_Attack_Min += (Item_Level_Upgrade - 5) * 2;
								Item_Attack_Max += (Item_Level_Upgrade - 5) * 2;
							}
							else if (Item_Level_Upgrade == 6)
							{
								Item_Attack_Min += 2L;
								Item_Attack_Max += 2L;
							}
							else if (Item_Level_Upgrade == 7)
							{
								Item_Attack_Min += 10L;
								Item_Attack_Max += 10L;
							}
							else if (Item_Level_Upgrade == 8)
							{
								Item_Attack_Min += 24L;
								Item_Attack_Max += 24L;
							}
							else if (Item_Level_Upgrade == 9)
							{
								Item_Attack_Min += 48L;
								Item_Attack_Max += 48L;
							}
							else if (Item_Level_Upgrade == 10)
							{
								Item_Attack_Min += 102L;
								Item_Attack_Max += 102L;
							}
							else if (Item_Level_Upgrade == 11)
							{
								Item_Attack_Min += 111L;
								Item_Attack_Max += 111L;
							}
							else if (Item_Level_Upgrade == 12)
							{
								Item_Attack_Min += 125L;
								Item_Attack_Max += 125L;
							}
							else if (Item_Level_Upgrade == 13)
							{
								Item_Attack_Min += 144L;
								Item_Attack_Max += 144L;
							}
							else if (Item_Level_Upgrade == 14)
							{
								Item_Attack_Min += 168L;
								Item_Attack_Max += 168L;
							}
							else if (Item_Level_Upgrade == 15)
							{
								Item_Attack_Min += 197L;
								Item_Attack_Max += 197L;
							}
							else
							{
								Item_Attack_Min += 313 + (Item_Level_Upgrade - 19) * 29;
								Item_Attack_Max += 313 + (Item_Level_Upgrade - 19) * 29;
							}
						}
						int num = 0;
						int num2 = 0;
						int num3 = 0;
						int num4 = 0;
						if (FLD_MAGIC1 != 0 && FLD_MAGIC1 > 70000000 && FLD_MAGIC1 < 80000000)
						{
							num++;
						}
						if (FLD_MAGIC2 != 0 && FLD_MAGIC2 > 70000000 && FLD_MAGIC2 < 80000000)
						{
							num++;
						}
						if (Item_Level_Upgrade >= 8 && FLD_MAGIC3 != 0 && FLD_MAGIC3 > 70000000 && FLD_MAGIC3 < 80000000)
						{
							num++;
						}
						if (Item_Level_Upgrade >= 8 && FLD_MAGIC4 != 0 && FLD_MAGIC4 > 70000000 && FLD_MAGIC4 < 80000000)
						{
							num++;
						}
						if (FLD_MAGIC1 != 0 && FLD_MAGIC1 > 10000000 && FLD_MAGIC1 < 20000000)
						{
							num3++;
						}
						if (FLD_MAGIC2 != 0 && FLD_MAGIC2 > 10000000 && FLD_MAGIC2 < 20000000)
						{
							num3++;
						}
						if (Item_Level_Upgrade >= 8 && FLD_MAGIC3 != 0 && FLD_MAGIC3 > 10000000 && FLD_MAGIC3 < 20000000)
						{
							num3++;
						}
						if (Item_Level_Upgrade >= 8 && FLD_MAGIC4 != 0 && FLD_MAGIC4 > 10000000 && FLD_MAGIC4 < 20000000)
						{
							num3++;
						}
						if (Item_Level_Upgrade >= 13 && FLD_MAGIC1 != 0 && FLD_MAGIC1 >= 80000002 && FLD_MAGIC1 < 90000000)
						{
							num4++;
						}
						if (Item_Level_Upgrade >= 13 && FLD_MAGIC2 != 0 && FLD_MAGIC2 >= 80000002 && FLD_MAGIC2 < 90000000)
						{
							num4++;
						}
						if (Item_Level_Upgrade >= 13 && FLD_MAGIC3 != 0 && FLD_MAGIC3 >= 80000002 && FLD_MAGIC3 < 90000000)
						{
							num4++;
						}
						if (Item_Level_Upgrade >= 13 && FLD_MAGIC4 != 0 && FLD_MAGIC4 >= 80000002 && FLD_MAGIC4 < 90000000)
						{
							num4++;
						}
						if (Item_Level_Upgrade >= 13 && FLD_MAGIC1 != 0 && FLD_MAGIC1 >= 70000025 && FLD_MAGIC1 < 80000000)
						{
							num2++;
						}
						if (Item_Level_Upgrade >= 13 && FLD_MAGIC2 != 0 && FLD_MAGIC2 >= 70000025 && FLD_MAGIC2 < 80000000)
						{
							num2++;
						}
						if (Item_Level_Upgrade >= 13 && FLD_MAGIC3 != 0 && FLD_MAGIC3 >= 70000025 && FLD_MAGIC3 < 80000000)
						{
							num2++;
						}
						if (Item_Level_Upgrade >= 13 && FLD_MAGIC4 != 0 && FLD_MAGIC4 >= 70000025 && FLD_MAGIC4 < 80000000)
						{
							num2++;
						}
						if (Item_Level_Upgrade == 7 || Item_Level_Upgrade == 8)
						{
							Item_Attack_Skill += num;
							Item_Attack_Min += num3;
							Item_Attack_Max += num3;
						}
						else if (Item_Level_Upgrade == 9)
						{
							Item_Attack_Skill += 2 * num;
							Item_Attack_Min += 2 * num3;
							Item_Attack_Max += 2 * num3;
						}
						else if (Item_Level_Upgrade == 10)
						{
							Level_Qigong_All++;
							Item_Attack_Skill += 3 * num;
							Item_Attack_Min += 3 * num3;
							Item_Attack_Max += 3 * num3;
						}
						else if (Item_Level_Upgrade == 11)
						{
							Level_Qigong_All += 2;
							Item_Attack_Skill += 4 * num;
							Item_Attack_Min += 4 * num3;
							Item_Attack_Max += 4 * num3;
						}
						else if (Item_Level_Upgrade == 12)
						{
							Level_Qigong_All += 3;
							Item_Attack_Skill += 5 * num;
							Item_Attack_Min += 5 * num3;
							Item_Attack_Max += 5 * num3;
						}
						else if (Item_Level_Upgrade == 13)
						{
							Level_Qigong_All += 3 + num4;
							Item_Attack_Skill += 6 * num + 8 * num2;
							Item_Attack_Min += 6 * num3;
							Item_Attack_Max += 6 * num3;
						}
						else if (Item_Level_Upgrade == 14)
						{
							Level_Qigong_All += 3 + num4;
							Item_Attack_Skill += 7 * num + 8 * num2;
							Item_Attack_Min += 7 * num3;
							Item_Attack_Max += 7 * num3;
						}
						else if (Item_Level_Upgrade == 15)
						{
							Level_Qigong_All += 3 + num4;
							Item_Attack_Skill += 7 * num + 8 * num2;
							Item_Attack_Min += 7 * num3;
							Item_Attack_Max += 7 * num3;
						}
						else if (Item_Level_Upgrade == 16)
						{
							Level_Qigong_All += 3 + num4;
							Item_Attack_Skill += 7 * num + 8 * num2;
							Item_Attack_Min += 7 * num3;
							Item_Attack_Max += 7 * num3;
						}
						else if (Item_Level_Upgrade == 17)
						{
							Level_Qigong_All += 3 + num4;
							Item_Attack_Skill += 7 * num + 8 * num2;
							Item_Attack_Min += 7 * num3;
							Item_Attack_Max += 7 * num3;
						}
						else if (Item_Level_Upgrade == 18)
						{
							Level_Qigong_All += 3 + num4;
							Item_Attack_Skill += 7 * num + 8 * num2;
							Item_Attack_Min += 7 * num3;
							Item_Attack_Max += 7 * num3;
						}
						else if (Item_Level_Upgrade >= 19)
						{
							Level_Qigong_All += 3 + num4;
							Item_Attack_Skill += 7 * num + 8 * num2;
							Item_Attack_Min += 7 * num3;
							Item_Attack_Max += 7 * num3;
						}
					}
					return;
				}
				if (物品属性强类型 == 2)
				{
					ItmeClass value5;
					if (FLD_RESIDE2 != 7 && FLD_RESIDE2 != 8 && FLD_RESIDE2 != 10)
					{
						ItmeClass value4;
						if (FLD_RESIDE2 == 1)
						{
							if (World.Itme.TryGetValue(BitConverter.ToInt32(Get_Byte_Item_PID, 0), out ItmeClass value3) && Item_Level_Upgrade != 0)
							{
								int num5 = (value3.FLD_RESIDE1 >= 6) ? (value3.FLD_RESIDE1 + 1) : value3.FLD_RESIDE1;
								if (value3.isAoChan())
								{
									if (Item_Level_Upgrade < 5)
									{
										Item_Defense += 2 * Item_Level_Upgrade / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
									}
									else if (Item_Level_Upgrade == 6)
									{
										Item_Defense += 14 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Defense += 18 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Defense += 22 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Defense += 26 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 5;
									}
									else if (Item_Level_Upgrade == 10)
									{
										Item_Defense += 31 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 10;
									}
									else if (Item_Level_Upgrade == 11)
									{
										Item_Defense += 34 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 10;
									}
									else if (Item_Level_Upgrade == 12)
									{
										Item_Defense += 36 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 10;
									}
									else if (Item_Level_Upgrade == 13)
									{
										Item_Defense += 44 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 10;
									}
									else if (Item_Level_Upgrade == 14)
									{
										Item_Defense += 52 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 10;
									}
									else if (Item_Level_Upgrade == 15)
									{
										Item_Defense += 60 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 10;
									}
									else if (Item_Level_Upgrade == 16)
									{
										Item_Defense += 68 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 10;
									}
									else if (Item_Level_Upgrade >= 17)
									{
										Item_Defense += 76 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 10;
									}
								}
								if (value3.FLD_LEVEL < 35)
								{
									if (Item_Level_Upgrade == 1)
									{
										Item_Shield += 2;
									}
									else if (Item_Level_Upgrade == 2)
									{
										Item_Shield += 4;
									}
									else if (Item_Level_Upgrade == 3)
									{
										Item_Shield += 6;
									}
									else if (Item_Level_Upgrade == 4)
									{
										Item_Shield += 8;
									}
									else if (Item_Level_Upgrade == 5)
									{
										Item_Shield += 10;
									}
									else if (Item_Level_Upgrade == 6)
									{
										Item_Shield += 13;
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Shield += 17;
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Shield += 22;
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Shield += 28;
									}
									else if (Item_Level_Upgrade == 10)
									{
										Item_Shield += 36;
									}
									else if (Item_Level_Upgrade == 11)
									{
										Item_Shield += 46;
									}
									else if (Item_Level_Upgrade >= 12)
									{
										Item_Shield += 58;
									}
								}
								else if (value3.FLD_LEVEL <= 60)
								{
									if (Item_Level_Upgrade == 1)
									{
										Item_Shield += 7;
									}
									else if (Item_Level_Upgrade == 2)
									{
										Item_Shield += 14;
									}
									else if (Item_Level_Upgrade == 3)
									{
										Item_Shield += 21;
									}
									else if (Item_Level_Upgrade == 4)
									{
										Item_Shield += 28;
									}
									else if (Item_Level_Upgrade == 5)
									{
										Item_Shield += 35;
									}
									else if (Item_Level_Upgrade == 6)
									{
										Item_Shield += 45;
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Shield += 57;
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Shield += 72;
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Shield += 89;
									}
									else if (Item_Level_Upgrade == 10)
									{
										Item_Shield += 111;
									}
									else if (Item_Level_Upgrade == 11)
									{
										Item_Shield += 136;
									}
									else if (Item_Level_Upgrade >= 12)
									{
										Item_Shield += 163;
									}
								}
								else if (value3.FLD_LEVEL <= 80)
								{
									if (Item_Level_Upgrade == 1)
									{
										Item_Shield += 15;
									}
									else if (Item_Level_Upgrade == 2)
									{
										Item_Shield += 30;
									}
									else if (Item_Level_Upgrade == 3)
									{
										Item_Shield += 45;
									}
									else if (Item_Level_Upgrade == 4)
									{
										Item_Shield += 60;
									}
									else if (Item_Level_Upgrade == 5)
									{
										Item_Shield += 75;
									}
									else if (Item_Level_Upgrade == 6)
									{
										Item_Shield += 92;
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Shield += 112;
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Shield += 134;
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Shield += 159;
									}
									else if (Item_Level_Upgrade == 10)
									{
										Item_Shield += 189;
									}
									else if (Item_Level_Upgrade == 11)
									{
										Item_Shield += 221;
									}
									else if (Item_Level_Upgrade >= 12)
									{
										Item_Shield += 256;
									}
								}
								else if (value3.FLD_LEVEL <= 100)
								{
									if (Item_Level_Upgrade == 1)
									{
										Item_Shield += 35;
									}
									else if (Item_Level_Upgrade == 2)
									{
										Item_Shield += 70;
									}
									else if (Item_Level_Upgrade == 3)
									{
										Item_Shield += 105;
									}
									else if (Item_Level_Upgrade == 4)
									{
										Item_Shield += 140;
									}
									else if (Item_Level_Upgrade == 5)
									{
										Item_Shield += 175;
									}
									else if (Item_Level_Upgrade == 6)
									{
										Item_Shield += 215;
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Shield += 260;
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Shield += 310;
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Shield += 375;
									}
									else if (Item_Level_Upgrade == 10)
									{
										Item_Shield += 450;
									}
									else if (Item_Level_Upgrade == 11)
									{
										Item_Shield += 530;
									}
									else if (Item_Level_Upgrade >= 12)
									{
										Item_Shield += 615;
									}
								}
								else if (value3.FLD_LEVEL <= 110)
								{
									if (Item_Level_Upgrade == 1)
									{
										Item_Shield += 40;
									}
									else if (Item_Level_Upgrade == 2)
									{
										Item_Shield += 80;
									}
									else if (Item_Level_Upgrade == 3)
									{
										Item_Shield += 120;
									}
									else if (Item_Level_Upgrade == 4)
									{
										Item_Shield += 160;
									}
									else if (Item_Level_Upgrade == 5)
									{
										Item_Shield += 200;
									}
									else if (Item_Level_Upgrade == 6)
									{
										Item_Shield += 245;
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Shield += 295;
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Shield += 350;
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Shield += 420;
									}
									else if (Item_Level_Upgrade == 10)
									{
										Item_Shield += 500;
									}
									else if (Item_Level_Upgrade == 11)
									{
										Item_Shield += 585;
									}
									else if (Item_Level_Upgrade >= 12)
									{
										Item_Shield += 735;
									}
								}
								else if (value3.FLD_LEVEL <= 120)
								{
									if (Item_Level_Upgrade == 1)
									{
										Item_Shield += 50;
									}
									else if (Item_Level_Upgrade == 2)
									{
										Item_Shield += 100;
									}
									else if (Item_Level_Upgrade == 3)
									{
										Item_Shield += 150;
									}
									else if (Item_Level_Upgrade == 4)
									{
										Item_Shield += 200;
									}
									else if (Item_Level_Upgrade == 5)
									{
										Item_Shield += 250;
									}
									else if (Item_Level_Upgrade == 6)
									{
										Item_Shield += 305;
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Shield += 365;
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Shield += 430;
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Shield += 500;
									}
									else if (Item_Level_Upgrade == 10)
									{
										Item_Shield += 650;
									}
									else if (Item_Level_Upgrade == 11)
									{
										Item_Shield += 850;
									}
									else if (Item_Level_Upgrade == 12)
									{
										Item_Shield += 1100;
									}
									else if (Item_Level_Upgrade == 13)
									{
										Item_Shield += 1350;
									}
									else if (Item_Level_Upgrade == 14)
									{
										Item_Shield += 1650;
									}
									else if (Item_Level_Upgrade == 15)
									{
										Item_Shield += 1950;
									}
									else if (Item_Level_Upgrade == 16)
									{
										Item_Shield += 2300;
									}
									else if (Item_Level_Upgrade >= 17)
									{
										Item_Shield += 2300 + 350 * (Item_Level_Upgrade - 16);
									}
								}
								else if (value3.FLD_LEVEL <= 130)
								{
									if (Item_Level_Upgrade == 1)
									{
										Item_Shield += 55;
									}
									else if (Item_Level_Upgrade == 2)
									{
										Item_Shield += 110;
									}
									else if (Item_Level_Upgrade == 3)
									{
										Item_Shield += 165;
									}
									else if (Item_Level_Upgrade == 4)
									{
										Item_Shield += 220;
									}
									else if (Item_Level_Upgrade == 5)
									{
										Item_Shield += 275;
									}
									else if (Item_Level_Upgrade == 6)
									{
										Item_Shield += 340;
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Shield += 415;
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Shield += 515;
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Shield += 655;
									}
									else if (Item_Level_Upgrade == 10)
									{
										Item_Shield += 905;
									}
									else if (Item_Level_Upgrade == 11)
									{
										Item_Shield += 1205;
									}
									else if (Item_Level_Upgrade == 12)
									{
										Item_Shield += 1555;
									}
									else if (Item_Level_Upgrade == 13)
									{
										Item_Shield += 1905;
									}
									else if (Item_Level_Upgrade == 14)
									{
										Item_Shield += 2305;
									}
									else if (Item_Level_Upgrade == 15)
									{
										Item_Shield += 2705;
									}
									else if (Item_Level_Upgrade == 16)
									{
										Item_Shield += 3155;
									}
									else if (Item_Level_Upgrade >= 17)
									{
										Item_Shield += 3155 + 450 * (Item_Level_Upgrade - 16);
									}
								}
								else if (Item_Level_Upgrade == 1)
								{
									Item_Shield += 60;
								}
								else if (Item_Level_Upgrade == 2)
								{
									Item_Shield += 120;
								}
								else if (Item_Level_Upgrade == 3)
								{
									Item_Shield += 180;
								}
								else if (Item_Level_Upgrade == 4)
								{
									Item_Shield += 240;
								}
								else if (Item_Level_Upgrade == 5)
								{
									Item_Shield += 300;
								}
								else if (Item_Level_Upgrade == 6)
								{
									Item_Shield += 375;
								}
								else if (Item_Level_Upgrade == 7)
								{
									Item_Shield += 475;
								}
								else if (Item_Level_Upgrade == 8)
								{
									Item_Shield += 600;
								}
								else if (Item_Level_Upgrade == 9)
								{
									Item_Shield += 775;
								}
								else if (Item_Level_Upgrade == 10)
								{
									Item_Shield += 1075;
								}
								else if (Item_Level_Upgrade == 11)
								{
									Item_Shield += 1425;
								}
								else if (Item_Level_Upgrade == 12)
								{
									Item_Shield += 1875;
								}
								else if (Item_Level_Upgrade == 13)
								{
									Item_Shield += 2325;
								}
								else if (Item_Level_Upgrade == 14)
								{
									Item_Shield += 2825;
								}
								else if (Item_Level_Upgrade == 15)
								{
									Item_Shield += 3325;
								}
								else if (Item_Level_Upgrade == 16)
								{
									Item_Shield += 3875;
								}
								else if (Item_Level_Upgrade >= 17)
								{
									Item_Shield += 3875 + 550 * (Item_Level_Upgrade - 16);
								}
								if (value3.FLD_LEVEL < 60)
								{
									if (Item_Level_Upgrade != 0)
									{
										if (Item_Level_Upgrade == 1)
										{
											Item_Defense += 3 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
										}
										else if (Item_Level_Upgrade == 2)
										{
											Item_Defense += 9 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
										}
										else if (Item_Level_Upgrade == 3)
										{
											Item_Defense += 18 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
										}
										else if (Item_Level_Upgrade == 4)
										{
											Item_Defense += 30 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
										}
										else if (Item_Level_Upgrade == 5)
										{
											Item_Defense += 45 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
										}
										else if (Item_Level_Upgrade == 6)
										{
											Item_Defense += 63 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
											物品属性_生命力增加 += 5;
										}
										else if (Item_Level_Upgrade == 7)
										{
											Item_Defense += 84 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
											物品属性_生命力增加 += 10;
										}
										else if (Item_Level_Upgrade == 8)
										{
											Item_Defense += 108 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
											物品属性_生命力增加 += 15;
										}
										else if (Item_Level_Upgrade == 9)
										{
											Item_Defense += 135 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
											物品属性_生命力增加 += 20;
										}
										else if (Item_Level_Upgrade == 10)
										{
											Item_Defense += 165 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
											物品属性_生命力增加 += 30;
										}
										else if (Item_Level_Upgrade == 11)
										{
											Item_Defense += 200 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
											物品属性_生命力增加 += 40;
										}
										else if (Item_Level_Upgrade == 12)
										{
											Item_Defense += 250 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
											物品属性_生命力增加 += 50;
										}
										else if (Item_Level_Upgrade > 12)
										{
											Item_Defense += (250 + (Item_Level_Upgrade - 12) * 3) / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
											物品属性_生命力增加 += 50 + (Item_Level_Upgrade - 12) * 10;
										}
									}
								}
								else if (Item_Level_Upgrade == 1)
								{
									Item_Defense += 4L / (long)((value3.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade == 2)
								{
									Item_Defense += 12L / (long)((value3.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade == 3)
								{
									Item_Defense += 24L / (long)((value3.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade == 4)
								{
									Item_Defense += 40L / (long)((value3.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade == 5)
								{
									Item_Defense += 60L / (long)((value3.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade == 6)
								{
									物品属性_生命力增加 += 5;
									Item_Defense += 84L / (long)((value3.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade == 7)
								{
									物品属性_生命力增加 += 10;
									Item_Defense += 112L / (long)((value3.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade == 8)
								{
									物品属性_生命力增加 += 15;
									Item_Defense += 144L / (long)((value3.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade == 9)
								{
									物品属性_生命力增加 += 20;
									Item_Defense += 180L / (long)((value3.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade == 10)
								{
									物品属性_生命力增加 += 30;
									Item_Defense += 230L / (long)((value3.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade == 11)
								{
									物品属性_生命力增加 += 40;
									Item_Defense += 265 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade == 12)
								{
									物品属性_生命力增加 += 50;
									Item_Defense += 315 / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade > 12)
								{
									物品属性_生命力增加 += 50 + (Item_Level_Upgrade - 12) * 10;
									物品属性_生命力增加 += 260;
									Item_Defense += (315 + (Item_Level_Upgrade - 12) * 50) / ((value3.FLD_RESIDE1 != 11) ? 1 : 2);
								}
							}
						}
						else if (FLD_RESIDE2 == 6)
						{
							if (World.Itme.TryGetValue(BitConverter.ToInt32(Get_Byte_Item_PID, 0), out value4) && Item_Level_Upgrade != 0)
							{
								if (value4.isGiapChan())
								{
									if (Item_Level_Upgrade == 6)
									{
										物品属性_生命力增加 += 5;
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Defense += 1 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 10;
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Defense += 3 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 15;
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Defense += 6 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 20;
									}
									else if (Item_Level_Upgrade <= 12)
									{
										Item_Defense += 9 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 30;
									}
									else if (Item_Level_Upgrade > 12)
									{
										Item_Defense += 9 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 290;
									}
								}
								if (value4.FLD_LEVEL <= 25)
								{
									if (Item_Level_Upgrade == 1)
									{
										Item_Shield++;
									}
									else if (Item_Level_Upgrade == 2)
									{
										Item_Shield += 2;
									}
									else if (Item_Level_Upgrade == 3)
									{
										Item_Shield += 3;
									}
									else if (Item_Level_Upgrade == 4)
									{
										Item_Shield += 4;
									}
									else if (Item_Level_Upgrade == 5)
									{
										Item_Shield += 5;
									}
									else if (Item_Level_Upgrade == 6)
									{
										Item_Shield += 7;
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Shield += 9;
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Shield += 12;
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Shield += 15;
									}
									else if (Item_Level_Upgrade == 10)
									{
										Item_Shield += 20;
									}
									else if (Item_Level_Upgrade == 11)
									{
										Item_Shield += 28;
									}
									else if (Item_Level_Upgrade >= 12)
									{
										Item_Shield += 36;
									}
								}
								else if (value4.FLD_LEVEL <= 55)
								{
									if (Item_Level_Upgrade == 1)
									{
										Item_Shield += 4;
									}
									else if (Item_Level_Upgrade == 2)
									{
										Item_Shield += 8;
									}
									else if (Item_Level_Upgrade == 3)
									{
										Item_Shield += 12;
									}
									else if (Item_Level_Upgrade == 4)
									{
										Item_Shield += 16;
									}
									else if (Item_Level_Upgrade == 5)
									{
										Item_Shield += 20;
									}
									else if (Item_Level_Upgrade == 6)
									{
										Item_Shield += 25;
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Shield += 32;
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Shield += 37;
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Shield += 43;
									}
									else if (Item_Level_Upgrade == 10)
									{
										Item_Shield += 49;
									}
									else if (Item_Level_Upgrade == 11)
									{
										Item_Shield += 58;
									}
									else if (Item_Level_Upgrade >= 12)
									{
										Item_Shield += 69;
									}
								}
								else if (value4.FLD_LEVEL <= 75)
								{
									if (Item_Level_Upgrade == 1)
									{
										Item_Shield += 4;
									}
									else if (Item_Level_Upgrade == 2)
									{
										Item_Shield += 8;
									}
									else if (Item_Level_Upgrade == 3)
									{
										Item_Shield += 12;
									}
									else if (Item_Level_Upgrade == 4)
									{
										Item_Shield += 16;
									}
									else if (Item_Level_Upgrade == 5)
									{
										Item_Shield += 20;
									}
									else if (Item_Level_Upgrade == 6)
									{
										Item_Shield += 25;
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Shield += 32;
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Shield += 39;
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Shield += 48;
									}
									else if (Item_Level_Upgrade == 10)
									{
										Item_Shield += 60;
									}
									else if (Item_Level_Upgrade == 11)
									{
										Item_Shield += 74;
									}
									else if (Item_Level_Upgrade >= 12)
									{
										Item_Shield += 99;
									}
								}
								else if (value4.FLD_LEVEL <= 95)
								{
									if (Item_Level_Upgrade == 1)
									{
										Item_Shield += 5;
									}
									else if (Item_Level_Upgrade == 2)
									{
										Item_Shield += 10;
									}
									else if (Item_Level_Upgrade == 3)
									{
										Item_Shield += 15;
									}
									else if (Item_Level_Upgrade == 4)
									{
										Item_Shield += 20;
									}
									else if (Item_Level_Upgrade == 5)
									{
										Item_Shield += 25;
									}
									else if (Item_Level_Upgrade == 6)
									{
										Item_Shield += 32;
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Shield += 40;
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Shield += 49;
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Shield += 61;
									}
									else if (Item_Level_Upgrade == 10)
									{
										Item_Shield += 76;
									}
									else if (Item_Level_Upgrade == 11)
									{
										Item_Shield += 93;
									}
									else if (Item_Level_Upgrade >= 12)
									{
										Item_Shield += 123;
									}
								}
								else if (value4.FLD_LEVEL <= 105)
								{
									if (Item_Level_Upgrade == 1)
									{
										Item_Shield += 7;
									}
									else if (Item_Level_Upgrade == 2)
									{
										Item_Shield += 14;
									}
									else if (Item_Level_Upgrade == 3)
									{
										Item_Shield += 21;
									}
									else if (Item_Level_Upgrade == 4)
									{
										Item_Shield += 28;
									}
									else if (Item_Level_Upgrade == 5)
									{
										Item_Shield += 35;
									}
									else if (Item_Level_Upgrade == 6)
									{
										Item_Shield += 44;
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Shield += 55;
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Shield += 68;
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Shield += 85;
									}
									else if (Item_Level_Upgrade == 10)
									{
										Item_Shield += 105;
									}
									else if (Item_Level_Upgrade == 11)
									{
										Item_Shield += 127;
									}
									else if (Item_Level_Upgrade >= 12)
									{
										Item_Shield += 172;
									}
								}
								else if (value4.FLD_LEVEL <= 118)
								{
									if (Item_Level_Upgrade == 1)
									{
										Item_Shield += 9;
									}
									else if (Item_Level_Upgrade == 2)
									{
										Item_Shield += 18;
									}
									else if (Item_Level_Upgrade == 3)
									{
										Item_Shield += 27;
									}
									else if (Item_Level_Upgrade == 4)
									{
										Item_Shield += 36;
									}
									else if (Item_Level_Upgrade == 5)
									{
										Item_Shield += 45;
									}
									else if (Item_Level_Upgrade == 6)
									{
										Item_Shield += 56;
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Shield += 60;
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Shield += 88;
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Shield += 110;
									}
									else if (Item_Level_Upgrade == 10)
									{
										Item_Shield += 140;
									}
									else if (Item_Level_Upgrade == 11)
									{
										Item_Shield += 177;
									}
									else if (Item_Level_Upgrade >= 12)
									{
										Item_Shield += 232;
									}
								}
								else if (value4.FLD_LEVEL <= 125)
								{
									if (Item_Level_Upgrade == 1)
									{
										Item_Shield += 10;
									}
									else if (Item_Level_Upgrade == 2)
									{
										Item_Shield += 20;
									}
									else if (Item_Level_Upgrade == 3)
									{
										Item_Shield += 30;
									}
									else if (Item_Level_Upgrade == 4)
									{
										Item_Shield += 40;
									}
									else if (Item_Level_Upgrade == 5)
									{
										Item_Shield += 50;
									}
									else if (Item_Level_Upgrade == 6)
									{
										Item_Shield += 62;
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Shield += 79;
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Shield += 101;
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Shield += 131;
									}
									else if (Item_Level_Upgrade == 10)
									{
										Item_Shield += 171;
									}
									else if (Item_Level_Upgrade == 11)
									{
										Item_Shield += 221;
									}
									else if (Item_Level_Upgrade == 12)
									{
										Item_Shield += 291;
									}
									else if (Item_Level_Upgrade == 13)
									{
										Item_Shield += 381;
									}
									else if (Item_Level_Upgrade == 14)
									{
										Item_Shield += 496;
									}
									else if (Item_Level_Upgrade == 15)
									{
										Item_Shield += 636;
									}
									else if (Item_Level_Upgrade == 16)
									{
										Item_Shield += 806;
									}
									else if (Item_Level_Upgrade >= 17)
									{
										Item_Shield += 1006;
									}
								}
								else if (value4.FLD_LEVEL <= 135)
								{
									if (Item_Level_Upgrade == 1)
									{
										Item_Shield += 12;
									}
									else if (Item_Level_Upgrade == 2)
									{
										Item_Shield += 24;
									}
									else if (Item_Level_Upgrade == 3)
									{
										Item_Shield += 36;
									}
									else if (Item_Level_Upgrade == 4)
									{
										Item_Shield += 48;
									}
									else if (Item_Level_Upgrade == 5)
									{
										Item_Shield += 60;
									}
									else if (Item_Level_Upgrade == 6)
									{
										Item_Shield += 75;
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Shield += 95;
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Shield += 125;
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Shield += 165;
									}
									else if (Item_Level_Upgrade == 10)
									{
										Item_Shield += 220;
									}
									else if (Item_Level_Upgrade == 11)
									{
										Item_Shield += 290;
									}
									else if (Item_Level_Upgrade == 12)
									{
										Item_Shield += 385;
									}
									else if (Item_Level_Upgrade == 13)
									{
										Item_Shield += 505;
									}
									else if (Item_Level_Upgrade == 14)
									{
										Item_Shield += 655;
									}
									else if (Item_Level_Upgrade == 15)
									{
										Item_Shield += 835;
									}
									else if (Item_Level_Upgrade == 16)
									{
										Item_Shield += 1050;
									}
									else if (Item_Level_Upgrade >= 17)
									{
										Item_Shield += 1300;
									}
								}
								else if (value4.FLD_LEVEL > 135)
								{
									if (Item_Level_Upgrade == 1)
									{
										Item_Shield += 17;
									}
									else if (Item_Level_Upgrade == 2)
									{
										Item_Shield += 34;
									}
									else if (Item_Level_Upgrade == 3)
									{
										Item_Shield += 51;
									}
									else if (Item_Level_Upgrade == 4)
									{
										Item_Shield += 68;
									}
									else if (Item_Level_Upgrade == 5)
									{
										Item_Shield += 85;
									}
									else if (Item_Level_Upgrade == 6)
									{
										Item_Shield += 107;
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Shield += 134;
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Shield += 169;
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Shield += 214;
									}
									else if (Item_Level_Upgrade == 10)
									{
										Item_Shield += 294;
									}
									else if (Item_Level_Upgrade == 11)
									{
										Item_Shield += 394;
									}
									else if (Item_Level_Upgrade == 12)
									{
										Item_Shield += 509;
									}
									else if (Item_Level_Upgrade == 13)
									{
										Item_Shield += 664;
									}
									else if (Item_Level_Upgrade == 14)
									{
										Item_Shield += 849;
									}
									else if (Item_Level_Upgrade == 15)
									{
										Item_Shield += 1069;
									}
									else if (Item_Level_Upgrade == 16)
									{
										Item_Shield += 1329;
									}
									else if (Item_Level_Upgrade >= 17)
									{
										Item_Shield += 1629;
									}
								}
								if (value4.FLD_LEVEL >= 60)
								{
									if (Item_Level_Upgrade == 1)
									{
										Item_Defense += Item_Level_Upgrade * 3 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
									}
									else if (Item_Level_Upgrade == 2)
									{
										Item_Defense += Item_Level_Upgrade * 3 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
									}
									else if (Item_Level_Upgrade == 3)
									{
										Item_Defense += Item_Level_Upgrade * 3 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
									}
									else if (Item_Level_Upgrade == 4)
									{
										Item_Defense += Item_Level_Upgrade * 3 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
									}
									else if (Item_Level_Upgrade == 5)
									{
										Item_Defense += Item_Level_Upgrade * 3 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
									}
									else if (Item_Level_Upgrade == 6)
									{
										Item_Defense += 19 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 40;
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Defense += 23 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 80;
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Defense += 29 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 140;
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Defense += 38 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 200;
									}
									else if (Item_Level_Upgrade == 10)
									{
										Item_Defense += 53 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 300;
									}
									else if (Item_Level_Upgrade == 11)
									{
										Item_Defense += 68 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 300;
									}
									else if (Item_Level_Upgrade == 12)
									{
										Item_Defense += 83 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 300;
									}
									else
									{
										Item_Defense += (98 + (Item_Level_Upgrade - 13) * 20) / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
										物品属性_生命力增加 += 820;
									}
								}
								else if (Item_Level_Upgrade == 1)
								{
									Item_Defense += Item_Level_Upgrade * 3 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade == 2)
								{
									Item_Defense += Item_Level_Upgrade * 3 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade == 3)
								{
									Item_Defense += Item_Level_Upgrade * 3 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade == 4)
								{
									Item_Defense += Item_Level_Upgrade * 3 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade == 5)
								{
									Item_Defense += Item_Level_Upgrade * 3 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade == 6)
								{
									Item_Defense += 19 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
									物品属性_生命力增加 += 30;
								}
								else if (Item_Level_Upgrade == 7)
								{
									Item_Defense += 25 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
									物品属性_生命力增加 += 60;
								}
								else if (Item_Level_Upgrade == 8)
								{
									Item_Defense += 37 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
									物品属性_生命力增加 += 110;
								}
								else if (Item_Level_Upgrade == 9)
								{
									Item_Defense += 40 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
									物品属性_生命力增加 += 160;
								}
								else if (Item_Level_Upgrade == 10)
								{
									Item_Defense += 43 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
									物品属性_生命力增加 += 250;
								}
								else
								{
									Item_Defense += (43 + (Item_Level_Upgrade - 10) * 15) / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
									物品属性_生命力增加 += 250;
								}
							}
						}
						else if (FLD_RESIDE2 == 14)
						{
							if (World.Itme.TryGetValue(BitConverter.ToInt32(Get_Byte_Item_PID, 0), out value4) && Item_Level_Upgrade != 0)
							{
								if (value4.FLD_PID == 900102 || value4.FLD_PID == 900103 || value4.FLD_PID == 900104)
								{
									if (Item_Level_Upgrade < 6)
									{
										Item_Defense += Item_Level_Upgrade * 3;
									}
									else if (Item_Level_Upgrade == 6)
									{
										Item_Defense += 19L;
										物品属性_生命力增加 += 5;
									}
									else if (Item_Level_Upgrade == 7)
									{
										Item_Defense += 23L;
										物品属性_生命力增加 += 10;
									}
									else if (Item_Level_Upgrade == 8)
									{
										Item_Defense += 29L;
										物品属性_生命力增加 += 15;
									}
									else if (Item_Level_Upgrade == 9)
									{
										Item_Defense += 38L;
										物品属性_生命力增加 += 20;
									}
									else if (Item_Level_Upgrade < 13)
									{
										Item_Defense += 53 + (Item_Level_Upgrade - 10) * 6;
										物品属性_生命力增加 += 30 + (Item_Level_Upgrade - 10) * 10;
									}
									else
									{
										Item_Defense += 53 + (Item_Level_Upgrade - 10) * 6;
										物品属性_生命力增加 += 260;
									}
								}
								else if (Item_Level_Upgrade < 6)
								{
									Item_Defense += Item_Level_Upgrade * 4;
								}
								else if (Item_Level_Upgrade == 6)
								{
									Item_Defense += 25L;
									物品属性_生命力增加 += 5;
									Item_SucManhCaNhan_PhanTram += 0.03;
								}
								else if (Item_Level_Upgrade == 7)
								{
									Item_Defense += 30L;
									物品属性_生命力增加 += 10;
									Item_SucManhCaNhan_PhanTram += 0.06;
								}
								else if (Item_Level_Upgrade == 8)
								{
									Item_Defense += 37L;
									物品属性_生命力增加 += 15;
									Item_SucManhCaNhan_PhanTram += 0.09;
								}
								else if (Item_Level_Upgrade == 9)
								{
									Item_Defense += 47L;
									物品属性_生命力增加 += 20;
									Item_SucManhCaNhan_PhanTram += 0.12;
								}
								else if (Item_Level_Upgrade < 13)
								{
									Item_Defense += 63 + (Item_Level_Upgrade - 10) * 7;
									物品属性_生命力增加 += 30 + (Item_Level_Upgrade - 10) * 10;
									Item_SucManhCaNhan_PhanTram += 0.15;
								}
								else
								{
									Item_Defense += 63 + (Item_Level_Upgrade - 10) * 7;
									物品属性_生命力增加 += 260;
								}
							}
						}
						else if (World.Itme.TryGetValue(BitConverter.ToInt32(Get_Byte_Item_PID, 0), out value4) && Item_Level_Upgrade != 0)
						{
							if (value4.isTayChan() || value4.isChanChan())
							{
								if (Item_Level_Upgrade == 7)
								{
									Item_Defense += 2 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade == 8)
								{
									Item_Defense += 5 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade == 9)
								{
									Item_Defense += 8 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
									物品属性_生命力增加 += 5;
								}
								else if (Item_Level_Upgrade >= 10)
								{
									Item_Defense += 11 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
									物品属性_生命力增加 += 10;
								}
							}
							if (value4.FLD_LEVEL <= 25)
							{
								if (Item_Level_Upgrade == 1)
								{
									Item_Shield++;
								}
								else if (Item_Level_Upgrade == 2)
								{
									Item_Shield += 2;
								}
								else if (Item_Level_Upgrade == 3)
								{
									Item_Shield += 3;
								}
								else if (Item_Level_Upgrade == 4)
								{
									Item_Shield += 4;
								}
								else if (Item_Level_Upgrade == 5)
								{
									Item_Shield += 5;
								}
								else if (Item_Level_Upgrade == 6)
								{
									Item_Shield += 7;
								}
								else if (Item_Level_Upgrade == 7)
								{
									Item_Shield += 9;
								}
								else if (Item_Level_Upgrade == 8)
								{
									Item_Shield += 12;
								}
								else if (Item_Level_Upgrade == 9)
								{
									Item_Shield += 15;
								}
								else if (Item_Level_Upgrade == 10)
								{
									Item_Shield += 20;
								}
								else if (Item_Level_Upgrade == 11)
								{
									Item_Shield += 28;
								}
								else if (Item_Level_Upgrade >= 12)
								{
									Item_Shield += 36;
								}
							}
							else if (value4.FLD_LEVEL <= 55)
							{
								if (Item_Level_Upgrade == 1)
								{
									Item_Shield += 4;
								}
								else if (Item_Level_Upgrade == 2)
								{
									Item_Shield += 8;
								}
								else if (Item_Level_Upgrade == 3)
								{
									Item_Shield += 12;
								}
								else if (Item_Level_Upgrade == 4)
								{
									Item_Shield += 16;
								}
								else if (Item_Level_Upgrade == 5)
								{
									Item_Shield += 20;
								}
								else if (Item_Level_Upgrade == 6)
								{
									Item_Shield += 25;
								}
								else if (Item_Level_Upgrade == 7)
								{
									Item_Shield += 32;
								}
								else if (Item_Level_Upgrade == 8)
								{
									Item_Shield += 37;
								}
								else if (Item_Level_Upgrade == 9)
								{
									Item_Shield += 43;
								}
								else if (Item_Level_Upgrade == 10)
								{
									Item_Shield += 49;
								}
								else if (Item_Level_Upgrade == 11)
								{
									Item_Shield += 58;
								}
								else if (Item_Level_Upgrade >= 12)
								{
									Item_Shield += 69;
								}
							}
							else if (value4.FLD_LEVEL <= 75)
							{
								if (Item_Level_Upgrade == 1)
								{
									Item_Shield += 4;
								}
								else if (Item_Level_Upgrade == 2)
								{
									Item_Shield += 8;
								}
								else if (Item_Level_Upgrade == 3)
								{
									Item_Shield += 12;
								}
								else if (Item_Level_Upgrade == 4)
								{
									Item_Shield += 16;
								}
								else if (Item_Level_Upgrade == 5)
								{
									Item_Shield += 20;
								}
								else if (Item_Level_Upgrade == 6)
								{
									Item_Shield += 25;
								}
								else if (Item_Level_Upgrade == 7)
								{
									Item_Shield += 32;
								}
								else if (Item_Level_Upgrade == 8)
								{
									Item_Shield += 39;
								}
								else if (Item_Level_Upgrade == 9)
								{
									Item_Shield += 48;
								}
								else if (Item_Level_Upgrade == 10)
								{
									Item_Shield += 60;
								}
								else if (Item_Level_Upgrade == 11)
								{
									Item_Shield += 74;
								}
								else if (Item_Level_Upgrade >= 12)
								{
									Item_Shield += 99;
								}
							}
							else if (value4.FLD_LEVEL <= 95)
							{
								if (Item_Level_Upgrade == 1)
								{
									Item_Shield += 5;
								}
								else if (Item_Level_Upgrade == 2)
								{
									Item_Shield += 10;
								}
								else if (Item_Level_Upgrade == 3)
								{
									Item_Shield += 15;
								}
								else if (Item_Level_Upgrade == 4)
								{
									Item_Shield += 20;
								}
								else if (Item_Level_Upgrade == 5)
								{
									Item_Shield += 25;
								}
								else if (Item_Level_Upgrade == 6)
								{
									Item_Shield += 32;
								}
								else if (Item_Level_Upgrade == 7)
								{
									Item_Shield += 40;
								}
								else if (Item_Level_Upgrade == 8)
								{
									Item_Shield += 49;
								}
								else if (Item_Level_Upgrade == 9)
								{
									Item_Shield += 61;
								}
								else if (Item_Level_Upgrade == 10)
								{
									Item_Shield += 76;
								}
								else if (Item_Level_Upgrade == 11)
								{
									Item_Shield += 93;
								}
								else if (Item_Level_Upgrade >= 12)
								{
									Item_Shield += 123;
								}
							}
							else if (value4.FLD_LEVEL <= 105)
							{
								if (Item_Level_Upgrade == 1)
								{
									Item_Shield += 7;
								}
								else if (Item_Level_Upgrade == 2)
								{
									Item_Shield += 14;
								}
								else if (Item_Level_Upgrade == 3)
								{
									Item_Shield += 21;
								}
								else if (Item_Level_Upgrade == 4)
								{
									Item_Shield += 28;
								}
								else if (Item_Level_Upgrade == 5)
								{
									Item_Shield += 35;
								}
								else if (Item_Level_Upgrade == 6)
								{
									Item_Shield += 44;
								}
								else if (Item_Level_Upgrade == 7)
								{
									Item_Shield += 55;
								}
								else if (Item_Level_Upgrade == 8)
								{
									Item_Shield += 68;
								}
								else if (Item_Level_Upgrade == 9)
								{
									Item_Shield += 85;
								}
								else if (Item_Level_Upgrade == 10)
								{
									Item_Shield += 105;
								}
								else if (Item_Level_Upgrade == 11)
								{
									Item_Shield += 127;
								}
								else if (Item_Level_Upgrade >= 12)
								{
									Item_Shield += 172;
								}
							}
							else if (value4.FLD_LEVEL <= 118)
							{
								if (Item_Level_Upgrade == 1)
								{
									Item_Shield += 9;
								}
								else if (Item_Level_Upgrade == 2)
								{
									Item_Shield += 18;
								}
								else if (Item_Level_Upgrade == 3)
								{
									Item_Shield += 27;
								}
								else if (Item_Level_Upgrade == 4)
								{
									Item_Shield += 36;
								}
								else if (Item_Level_Upgrade == 5)
								{
									Item_Shield += 45;
								}
								else if (Item_Level_Upgrade == 6)
								{
									Item_Shield += 56;
								}
								else if (Item_Level_Upgrade == 7)
								{
									Item_Shield += 60;
								}
								else if (Item_Level_Upgrade == 8)
								{
									Item_Shield += 88;
								}
								else if (Item_Level_Upgrade == 9)
								{
									Item_Shield += 110;
								}
								else if (Item_Level_Upgrade == 10)
								{
									Item_Shield += 140;
								}
								else if (Item_Level_Upgrade == 11)
								{
									Item_Shield += 177;
								}
								else if (Item_Level_Upgrade >= 12)
								{
									Item_Shield += 232;
								}
							}
							else if (value4.FLD_LEVEL <= 125)
							{
								if (Item_Level_Upgrade == 1)
								{
									Item_Shield += 10;
								}
								else if (Item_Level_Upgrade == 2)
								{
									Item_Shield += 20;
								}
								else if (Item_Level_Upgrade == 3)
								{
									Item_Shield += 30;
								}
								else if (Item_Level_Upgrade == 4)
								{
									Item_Shield += 40;
								}
								else if (Item_Level_Upgrade == 5)
								{
									Item_Shield += 50;
								}
								else if (Item_Level_Upgrade == 6)
								{
									Item_Shield += 62;
								}
								else if (Item_Level_Upgrade == 7)
								{
									Item_Shield += 79;
								}
								else if (Item_Level_Upgrade == 8)
								{
									Item_Shield += 101;
								}
								else if (Item_Level_Upgrade == 9)
								{
									Item_Shield += 131;
								}
								else if (Item_Level_Upgrade == 10)
								{
									Item_Shield += 171;
								}
								else if (Item_Level_Upgrade == 11)
								{
									Item_Shield += 221;
								}
								else if (Item_Level_Upgrade == 12)
								{
									Item_Shield += 291;
								}
								else if (Item_Level_Upgrade == 13)
								{
									Item_Shield += 381;
								}
								else if (Item_Level_Upgrade == 14)
								{
									Item_Shield += 496;
								}
								else if (Item_Level_Upgrade == 15)
								{
									Item_Shield += 636;
								}
								else if (Item_Level_Upgrade == 16)
								{
									Item_Shield += 806;
								}
								else if (Item_Level_Upgrade >= 17)
								{
									Item_Shield += 1006;
								}
							}
							else if (value4.FLD_LEVEL <= 135)
							{
								if (Item_Level_Upgrade == 1)
								{
									Item_Shield += 12;
								}
								else if (Item_Level_Upgrade == 2)
								{
									Item_Shield += 24;
								}
								else if (Item_Level_Upgrade == 3)
								{
									Item_Shield += 36;
								}
								else if (Item_Level_Upgrade == 4)
								{
									Item_Shield += 48;
								}
								else if (Item_Level_Upgrade == 5)
								{
									Item_Shield += 60;
								}
								else if (Item_Level_Upgrade == 6)
								{
									Item_Shield += 75;
								}
								else if (Item_Level_Upgrade == 7)
								{
									Item_Shield += 95;
								}
								else if (Item_Level_Upgrade == 8)
								{
									Item_Shield += 125;
								}
								else if (Item_Level_Upgrade == 9)
								{
									Item_Shield += 165;
								}
								else if (Item_Level_Upgrade == 10)
								{
									Item_Shield += 220;
								}
								else if (Item_Level_Upgrade == 11)
								{
									Item_Shield += 290;
								}
								else if (Item_Level_Upgrade == 12)
								{
									Item_Shield += 385;
								}
								else if (Item_Level_Upgrade == 13)
								{
									Item_Shield += 505;
								}
								else if (Item_Level_Upgrade == 14)
								{
									Item_Shield += 655;
								}
								else if (Item_Level_Upgrade == 15)
								{
									Item_Shield += 835;
								}
								else if (Item_Level_Upgrade == 16)
								{
									Item_Shield += 1050;
								}
								else if (Item_Level_Upgrade >= 17)
								{
									Item_Shield += 1300;
								}
							}
							else if (value4.FLD_LEVEL > 135)
							{
								if (Item_Level_Upgrade == 1)
								{
									Item_Shield += 17;
								}
								else if (Item_Level_Upgrade == 2)
								{
									Item_Shield += 34;
								}
								else if (Item_Level_Upgrade == 3)
								{
									Item_Shield += 51;
								}
								else if (Item_Level_Upgrade == 4)
								{
									Item_Shield += 68;
								}
								else if (Item_Level_Upgrade == 5)
								{
									Item_Shield += 85;
								}
								else if (Item_Level_Upgrade == 6)
								{
									Item_Shield += 107;
								}
								else if (Item_Level_Upgrade == 7)
								{
									Item_Shield += 134;
								}
								else if (Item_Level_Upgrade == 8)
								{
									Item_Shield += 169;
								}
								else if (Item_Level_Upgrade == 9)
								{
									Item_Shield += 214;
								}
								else if (Item_Level_Upgrade == 10)
								{
									Item_Shield += 294;
								}
								else if (Item_Level_Upgrade == 11)
								{
									Item_Shield += 394;
								}
								else if (Item_Level_Upgrade == 12)
								{
									Item_Shield += 509;
								}
								else if (Item_Level_Upgrade == 13)
								{
									Item_Shield += 664;
								}
								else if (Item_Level_Upgrade == 14)
								{
									Item_Shield += 849;
								}
								else if (Item_Level_Upgrade == 15)
								{
									Item_Shield += 1069;
								}
								else if (Item_Level_Upgrade == 16)
								{
									Item_Shield += 1329;
								}
								else if (Item_Level_Upgrade >= 17)
								{
									Item_Shield += 1629;
								}
							}
							if (value4.FLD_LEVEL < 60)
							{
								if (Item_Level_Upgrade < 6)
								{
									Item_Defense += Item_Level_Upgrade * 3 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
								}
								else if (Item_Level_Upgrade == 6)
								{
									Item_Defense += 19 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
									物品属性_生命力增加 += 5;
								}
								else if (Item_Level_Upgrade == 7)
								{
									Item_Defense += 23 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
									物品属性_生命力增加 += 10;
								}
								else if (Item_Level_Upgrade == 8)
								{
									Item_Defense += 28 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
									物品属性_生命力增加 += 15;
								}
								else if (Item_Level_Upgrade == 9)
								{
									Item_Defense += 35 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
									物品属性_生命力增加 += 20;
								}
								else if (Item_Level_Upgrade == 10)
								{
									Item_Defense += 47 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
									物品属性_生命力增加 += 30;
								}
								else if (Item_Level_Upgrade > 10)
								{
									Item_Defense += (47 + (Item_Level_Upgrade - 10) * 15) / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
									物品属性_生命力增加 += 30 + (Item_Level_Upgrade - 10) * 10;
								}
							}
							else if (Item_Level_Upgrade < 6)
							{
								Item_Defense += Item_Level_Upgrade * 3 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
							}
							else if (Item_Level_Upgrade == 6)
							{
								Item_Defense += 19 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
								物品属性_生命力增加 += 5;
							}
							else if (Item_Level_Upgrade == 7)
							{
								Item_Defense += 23 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
								物品属性_生命力增加 += 10;
							}
							else if (Item_Level_Upgrade == 8)
							{
								Item_Defense += 29 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
								物品属性_生命力增加 += 15;
							}
							else if (Item_Level_Upgrade == 9)
							{
								Item_Defense += 38 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
								物品属性_生命力增加 += 20;
							}
							else if (Item_Level_Upgrade == 10)
							{
								Item_Defense += 53 / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
								物品属性_生命力增加 += 30;
							}
							else if (Item_Level_Upgrade == 11)
							{
								Item_Defense += (53 + (Item_Level_Upgrade - 10) * 15) / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
								物品属性_生命力增加 += 30 + (Item_Level_Upgrade - 10) * 10;
							}
							else if (Item_Level_Upgrade == 12)
							{
								Item_Defense += (53 + (Item_Level_Upgrade - 10) * 15) / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
								物品属性_生命力增加 += 30 + (Item_Level_Upgrade - 10) * 10;
							}
							else if (Item_Level_Upgrade == 13)
							{
								Item_Defense += (53 + (Item_Level_Upgrade - 10) * 15) / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
								物品属性_生命力增加 += 30 + (Item_Level_Upgrade - 10) * 10;
								物品属性_生命力增加 += 260;
							}
							else if (Item_Level_Upgrade > 13)
							{
								Item_Defense += (98 + (Item_Level_Upgrade - 13) * 20) / ((value4.FLD_RESIDE1 != 11) ? 1 : 2);
								物品属性_生命力增加 += 30 + (Item_Level_Upgrade - 10) * 10;
								物品属性_生命力增加 += 260;
							}
						}
					}
					else if (World.Itme.TryGetValue(BitConverter.ToInt32(Get_Byte_Item_PID, 0), out value5))
					{
						if (value5.FLD_LEVEL >= 140)
						{
							if (Item_Level_Upgrade < 4)
							{
								Item_Defense += Item_Level_Upgrade * 9;
							}
							else
							{
								Item_Defense += 27L;
								Item_Defense += (Item_Level_Upgrade - 3) * 16;
							}
						}
						else if (value5.FLD_LEVEL >= 130)
						{
							if (Item_Level_Upgrade < 4)
							{
								Item_Defense += Item_Level_Upgrade * 7;
							}
							else
							{
								Item_Defense += 21L;
								Item_Defense += (Item_Level_Upgrade - 3) * 13;
							}
						}
						else if (value5.FLD_LEVEL >= 120)
						{
							if (Item_Level_Upgrade < 4)
							{
								Item_Defense += Item_Level_Upgrade * 6;
							}
							else
							{
								Item_Defense += 18L;
								Item_Defense += (Item_Level_Upgrade - 3) * 11;
								Item_Defense += ((Item_Level_Upgrade > 4) ? 1 : 0);
							}
						}
						else if (value5.FLD_LEVEL >= 115)
						{
							if (Item_Level_Upgrade < 4)
							{
								Item_Defense += Item_Level_Upgrade * 5;
							}
							else
							{
								Item_Defense += 15L;
								Item_Defense += (Item_Level_Upgrade - 3) * 9;
							}
						}
						else if (value5.FLD_LEVEL >= 100)
						{
							if (Item_Level_Upgrade < 4)
							{
								Item_Defense += Item_Level_Upgrade * 4;
							}
							else
							{
								Item_Defense += 12L;
								Item_Defense += (Item_Level_Upgrade - 3) * 7;
							}
						}
						else if (value5.FLD_LEVEL >= 80)
						{
							if (Item_Level_Upgrade < 4)
							{
								Item_Defense += Item_Level_Upgrade * 3;
							}
							else
							{
								Item_Defense += 9L;
								Item_Defense += (Item_Level_Upgrade - 3) * 5;
							}
						}
						else if (value5.FLD_LEVEL >= 60)
						{
							if (Item_Level_Upgrade < 4)
							{
								Item_Defense += Item_Level_Upgrade * 2;
							}
							else
							{
								Item_Defense += 6L;
								Item_Defense += (Item_Level_Upgrade - 3) * 3;
							}
						}
					}
				}
				else if (物品属性强类型 == 3)
				{
					ItmeClass value6 = default(ItmeClass);
					if ((FLD_RESIDE2 == 7 || FLD_RESIDE2 == 8 || FLD_RESIDE2 == 10) && World.Itme.TryGetValue(BitConverter.ToInt32(Get_Byte_Item_PID, 0), out value6))
					{
						if (value6.FLD_LEVEL >= 140)
						{
							物品属性_生命力增加 += Item_Level_Upgrade * 80;
						}
						else if (value6.FLD_LEVEL >= 130)
						{
							物品属性_生命力增加 += Item_Level_Upgrade * 60;
						}
						else if (value6.FLD_LEVEL >= 120)
						{
							物品属性_生命力增加 += Item_Level_Upgrade * 50;
						}
						else if (value6.FLD_LEVEL >= 115)
						{
							物品属性_生命力增加 += Item_Level_Upgrade * 40;
						}
						else if (value6.FLD_LEVEL >= 100)
						{
							物品属性_生命力增加 += Item_Level_Upgrade * 30;
						}
						else if (value6.FLD_LEVEL >= 80)
						{
							物品属性_生命力增加 += Item_Level_Upgrade * 15;
						}
						else if (value6.FLD_LEVEL >= 60)
						{
							物品属性_生命力增加 += Item_Level_Upgrade * 5;
						}
					}
				}
				else if (物品属性强类型 == 4 && FLD_RESIDE2 == 12)
				{
					if (Item_Level_Upgrade > 0)
					{
						Item_Defense += (int)(4.0 + (double)(int)((double)(Item_Level_Upgrade + 1) * 0.5));
						Item_Attack_Min += (int)(4.0 + (double)(int)((double)(Item_Level_Upgrade + 1) * 0.5));
						Item_Attack_Max += (int)(4.0 + (double)(int)((double)(Item_Level_Upgrade + 1) * 0.5));
						if (Item_Level_Upgrade > 1)
						{
							物品属性_生命力增加 += (int)((double)Item_Level_Upgrade * 0.5) * 10;
						}
						if (Item_Level_Upgrade > 4)
						{
							Item_Evasion_Per += (int)((double)(Item_Level_Upgrade - 4) * 0.002);
							Item_Accuracy_Per += (int)((double)(Item_Level_Upgrade - 4) * 0.002);
						}
						物品属性_行囊负重 += (double)Item_Level_Upgrade * 0.01;
						物品属性_获得金钱增加 += 10 + Item_Level_Upgrade;
					}
				}
				else if (物品属性强类型 == 19 && FLD_RESIDE2 == 16 && Item_Level_Upgrade > 0)
				{
					float num6 = 1f;
					float num7 = 1f;
					int num8 = 0;
					long fLD_PID = FLD_PID;
					if (fLD_PID <= 1000001175 && fLD_PID >= 1000001170)
					{
						switch (fLD_PID - 1000001170)
						{
						case 0L:
							if (属性1.属性数量 == 0)
							{
								num6 = 1f;
								num7 = 1f;
							}
							else if (属性1.属性数量 == 1)
							{
								num6 = 1.2f;
								num7 = 1.5f;
							}
							else if (属性1.属性数量 == 2)
							{
								num6 = 1.5f;
								num7 = 2f;
							}
							else if (属性1.属性数量 == 3)
							{
								num6 = 2f;
								num7 = 3f;
							}
							num8 = 10;
							break;
						case 1L:
							if (属性1.属性数量 == 0)
							{
								num6 = 1f;
								num7 = 0.8f;
							}
							else if (属性1.属性数量 == 1)
							{
								num6 = 1.2f;
								num7 = 1.3f;
							}
							else if (属性1.属性数量 == 2)
							{
								num6 = 1.5f;
								num7 = 1.8f;
							}
							else if (属性1.属性数量 == 3)
							{
								num6 = 2f;
								num7 = 2.7f;
							}
							num8 = 8;
							break;
						case 5L:
							if (属性1.属性数量 == 0)
							{
								num6 = 1f;
								num7 = 0.6f;
							}
							else if (属性1.属性数量 == 1)
							{
								num6 = 1.2f;
								num7 = 1.1f;
							}
							else if (属性1.属性数量 == 2)
							{
								num6 = 1.5f;
								num7 = 1.5f;
							}
							else if (属性1.属性数量 == 3)
							{
								num6 = 2f;
								num7 = 2.5f;
							}
							num8 = 1;
							break;
						case 2L:
							if (属性1.属性数量 == 0)
							{
								num6 = 1f;
								num7 = 0.4f;
							}
							else if (属性1.属性数量 == 1)
							{
								num6 = 1.2f;
								num7 = 0.9f;
							}
							else if (属性1.属性数量 == 2)
							{
								num6 = 1.5f;
								num7 = 1.3f;
							}
							else if (属性1.属性数量 == 3)
							{
								num6 = 2f;
								num7 = 2f;
							}
							num8 = 2;
							break;
						case 3L:
							if (属性1.属性数量 == 0)
							{
								num6 = 1f;
								num7 = 0.5f;
							}
							else if (属性1.属性数量 == 1)
							{
								num6 = 1.2f;
								num7 = 0.8f;
							}
							else if (属性1.属性数量 == 2)
							{
								num6 = 1.5f;
								num7 = 1.2f;
							}
							else if (属性1.属性数量 == 3)
							{
								num6 = 2f;
								num7 = 1.8f;
							}
							num8 = 0;
							break;
						case 4L:
							if (属性1.属性数量 == 0)
							{
								num6 = 1f;
								num7 = 0.5f;
							}
							else if (属性1.属性数量 == 1)
							{
								num6 = 1.2f;
								num7 = 0.7f;
							}
							else if (属性1.属性数量 == 2)
							{
								num6 = 1.5f;
								num7 = 1f;
							}
							else if (属性1.属性数量 == 3)
							{
								num6 = 2f;
								num7 = 1.5f;
							}
							num8 = 6;
							break;
						}
					}
					Item_Defense += (int)((4.0 + (double)(int)((double)(Item_Level_Upgrade + 1) * 0.5)) * (double)num6);
					Item_Attack_Min += (int)((4.0 + (double)(int)((double)(Item_Level_Upgrade + 1) * 0.5)) * (double)num6);
					Item_Attack_Max += (int)((4.0 + (double)(int)((double)(Item_Level_Upgrade + 1) * 0.5)) * (double)num6);
					Item_Attack_Skill_Point += (int)((8.0 + (double)(2 * (int)((double)(Item_Level_Upgrade + 1) * 0.5))) * (double)num7);
					Item_Attack_Skill_Point += (int)((8.0 + (double)(2 * (int)((double)(Item_Level_Upgrade + 1) * 0.5))) * (double)num7);
					if (Item_Level_Upgrade > 1)
					{
						物品属性_生命力增加 += num8 + (int)((double)Item_Level_Upgrade * 0.5) * 10;
					}
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "得到强化 出错：" + arg);
			}
		}

		public void Dispose()
		{
		}

		private void Reset_Opt_Item_Qigong()
		{
			Item_Attack_Min = 0L;
			Item_Attack_Max = 0L;
			物品属性_攻击力增加 = 0;
			Item_Defense = 0L;
			Item_SucManhCaNhan_PhanTram = 0.0;
			物品属性_防御力增加 = 0;
			物品属性_生命力增加 = 0;
			物品属性_行囊负重 = 0.0;
			物品属性_内功力增加 = 0;
			Item_Accuracy_Per = 0;
			Item_Evasion_Per = 0;
			Item_Accuracy = 0;
			Item_Evasion = 0;
			Item_Attack_Skill_Point = 0;
			Item_Defense_Skill_Point = 0;
			Item_Attack_Skill = 0;
			Level_Qigong_All = 0;
			物品属性_升级成功率 = 0;
			Item_Attack_Point = 0;
			Item_Defense_Skill = 0;
			物品属性_获得金钱增加 = 0;
			物品属性_死亡损失经验减少 = 0;
			物品属性_经验获得增加 = 0;
			物品_中级附魂_追加_觉醒 = 0;
			FLD_RESIDE2 = 0;
			物品属性_qigong_5_job5 = 0;
			物品属性_qigong_0_job5 = 0;
			物品属性_qigong_2_job5 = 0;
			物品属性_qigong_7_job5 = 0;
			物品属性_qigong_9_job5 = 0;
			物品属性_qigong_3_job5 = 0;
			物品属性_qigong_1_job5 = 0;
			物品属性_qigong_8_job5 = 0;
			物品属性_qigong_4_job5 = 0;
			物品属性_qigong_10_job5 = 0;
			物品属性_qigong_0_job7 = 0;
			物品属性_qigong_7_job7 = 0;
			物品属性_qigong_10_job7 = 0;
			物品属性_qigong_3_job7 = 0;
			物品属性_qigong_1_job7 = 0;
			物品属性_qigong_2_job7 = 0;
			物品属性_qigong_8_job7 = 0;
			物品属性_qigong_9_job7 = 0;
			物品属性_qigong_4_job7 = 0;
			物品属性_qigong_5_job7 = 0;
			物品属性_qigong_10_job3 = 0;
			物品属性_qigong_1_job3 = 0;
			物品属性_qigong_7_job3 = 0;
			物品属性_qigong_8_job3 = 0;
			物品属性_qigong_2_job3 = 0;
			物品属性_qigong_9_job3 = 0;
			物品属性_qigong_4_job3 = 0;
			物品属性_qigong_0_job3 = 0;
			物品属性_qigong_5_job3 = 0;
			物品属性_qigong_3_job3 = 0;
			物品属性_qigong_0_job2 = 0;
			物品属性_qigong_7_job2 = 0;
			物品属性_qigong_10_job2 = 0;
			物品属性_qigong_2_job2 = 0;
			物品属性_qigong_4_job2 = 0;
			物品属性_qigong_8_job2 = 0;
			物品属性_qigong_5_job2 = 0;
			物品属性_qigong_9_job2 = 0;
			物品属性_qigong_3_job2 = 0;
			物品属性_qigong_1_job2 = 0;
			物品属性_qigong_5_job4 = 0;
			物品属性_qigong_7_job4 = 0;
			物品属性_qigong_10_job4 = 0;
			物品属性_qigong_9_job4 = 0;
			物品属性_qigong_2_job4 = 0;
			物品属性_qigong_8_job4 = 0;
			物品属性_qigong_1_job4 = 0;
			物品属性_qigong_4_job4 = 0;
			物品属性_qigong_3_job4 = 0;
			物品属性_qigong_0_job4 = 0;
			物品属性_qigong_8_job1 = 0;
			物品属性_qigong_10_job1 = 0;
			物品属性_qigong_5_job1 = 0;
			物品属性_qigong_1_job1 = 0;
			物品属性_qigong_2_job1 = 0;
			物品属性_qigong_0_job1 = 0;
			物品属性_qigong_11_job1 = 0;
			物品属性_qigong_11_job2 = 0;
			物品属性_qigong_11_job3 = 0;
			物品属性_qigong_11_job4 = 0;
			物品属性_qigong_11_job5 = 0;
			物品属性_qigong_11_job6 = 0;
			物品属性_qigong_11_job7 = 0;
			物品属性_qigong_0_job8 = 0;
			物品属性_qigong_1_job8 = 0;
			物品属性_qigong_2_job8 = 0;
			物品属性_qigong_3_job8 = 0;
			物品属性_qigong_4_job8 = 0;
			物品属性_qigong_5_job8 = 0;
			物品属性_qigong_7_job8 = 0;
			物品属性_qigong_8_job8 = 0;
			物品属性_qigong_9_job8 = 0;
			物品属性_qigong_10_job8 = 0;
			物品属性_qigong_11_job8 = 0;
			物品属性_qigong_0_job9 = 0;
			物品属性_qigong_1_job9 = 0;
			物品属性_qigong_2_job9 = 0;
			物品属性_qigong_3_job9 = 0;
			物品属性_qigong_4_job9 = 0;
			物品属性_qigong_5_job9 = 0;
			物品属性_qigong_7_job9 = 0;
			物品属性_qigong_8_job9 = 0;
			物品属性_qigong_9_job9 = 0;
			物品属性_qigong_10_job9 = 0;
			物品属性_qigong_11_job9 = 0;
			物品属性_qigong_0_job10 = 0;
			物品属性_qigong_1_job10 = 0;
			物品属性_qigong_2_job10 = 0;
			物品属性_qigong_3_job10 = 0;
			物品属性_qigong_4_job10 = 0;
			物品属性_qigong_5_job10 = 0;
			物品属性_qigong_7_job10 = 0;
			物品属性_qigong_8_job10 = 0;
			物品属性_qigong_9_job10 = 0;
			物品属性_qigong_10_job10 = 0;
			物品属性_qigong_11_job10 = 0;
			物品属性_qigong_0_job11 = 0;
			物品属性_qigong_1_job11 = 0;
			物品属性_qigong_2_job11 = 0;
			物品属性_qigong_3_job11 = 0;
			物品属性_qigong_4_job11 = 0;
			物品属性_qigong_5_job11 = 0;
			物品属性_qigong_7_job11 = 0;
			物品属性_qigong_8_job11 = 0;
			物品属性_qigong_9_job11 = 0;
			物品属性_qigong_10_job11 = 0;
			物品属性_qigong_11_job11 = 0;
			物品属性_qigong_0_job12 = 0;
			物品属性_qigong_1_job12 = 0;
			物品属性_qigong_2_job12 = 0;
			物品属性_qigong_3_job12 = 0;
			物品属性_qigong_4_job12 = 0;
			物品属性_qigong_5_job12 = 0;
			物品属性_qigong_7_job12 = 0;
			物品属性_qigong_8_job12 = 0;
			物品属性_qigong_9_job12 = 0;
			物品属性_qigong_10_job12 = 0;
			物品属性_qigong_11_job12 = 0;
			物品属性_qigong_4_job1 = 0;
			物品属性_qigong_3_job1 = 0;
			物品属性_qigong_7_job1 = 0;
			物品属性_qigong_9_job1 = 0;
			物品属性_qigong_5_job6 = 0;
			物品属性_qigong_4_job6 = 0;
			物品属性_qigong_7_job6 = 0;
			物品属性_qigong_1_job6 = 0;
			物品属性_qigong_8_job6 = 0;
			物品属性_qigong_9_job6 = 0;
			物品属性_qigong_2_job6 = 0;
			物品属性_qigong_0_job6 = 0;
			物品属性_qigong_10_job6 = 0;
			物品属性_qigong_3_job6 = 0;
		}

		private void 得到基本属性(string ysqh)
		{
			try
			{
				string text;
				switch (ysqh.Length)
				{
				default:
					return;
				case 8:
					text = ysqh.Substring(0, 1);
					break;
				case 9:
					text = ysqh.Substring(0, 2);
					break;
				}
				int num = 0;
				int num2 = 0;
				石头属性调整类 石头属性调整类 = new 石头属性调整类();
				if (World.属性扩展是否开启 == 0)
				{
					num = ((!(text == "8")) ? int.Parse(ysqh.Substring(ysqh.Length - 3, 3)) : int.Parse(ysqh.Substring(ysqh.Length - 2, 2)));
				}
				else
				{
					num2 = int.Parse(ysqh.Substring(0, 1));
					num = ((num2 != 8) ? (int.Parse(ysqh) - int.Parse(text) * 10000000) : int.Parse(ysqh.Substring(ysqh.Length - 2, 2)));
				}
				switch (int.Parse(text))
				{
				case 14:
					break;
				case 1:
					物品属性_攻击力增加 += num;
					Item_Attack_Min += num;
					Item_Attack_Max += num;
					break;
				case 2:
					物品属性_防御力增加 += num;
					Item_Defense += num;
					break;
				case 3:
					物品属性_生命力增加 += num;
					break;
				case 4:
					物品属性_内功力增加 += num;
					break;
				case 5:
					Item_Accuracy += num;
					break;
				case 6:
					Item_Evasion += num;
					break;
				case 7:
					Item_Attack_Skill += num;
					break;
				case 8:
				{
					string text2 = ysqh.Substring(3, 3);
					switch (text2)
					{
					case "000":
						Level_Qigong_All += num;
						break;
					case "010":
						物品属性_qigong_0_job1 += num;
						break;
					case "011":
						物品属性_qigong_1_job1 += num;
						break;
					case "012":
						物品属性_qigong_2_job1 += num;
						break;
					case "014":
						物品属性_qigong_3_job1 += num;
						break;
					case "019":
						物品属性_qigong_4_job1 += num;
						break;
					case "016":
						物品属性_qigong_5_job1 += num;
						break;
					case "017":
						物品属性_qigong_7_job1 += num;
						物品属性_qigong_8_job8 += num;
						break;
					case "015":
						物品属性_qigong_8_job1 += num;
						break;
					case "018":
						物品属性_qigong_9_job1 += num;
						break;
					case "312":
						物品属性_qigong_10_job1 += num;
						break;
					case "110":
						物品属性_qigong_11_job1 += num;
						break;
					case "020":
						物品属性_qigong_0_job2 += num;
						break;
					case "021":
						物品属性_qigong_1_job2 += num;
						break;
					case "022":
						物品属性_qigong_2_job2 += num;
						break;
					case "023":
						物品属性_qigong_3_job2 += num;
						break;
					case "024":
						物品属性_qigong_4_job2 += num;
						物品属性_qigong_4_job9 += num;
						break;
					case "025":
						物品属性_qigong_4_job9 += num;
						break;
					case "026":
						物品属性_qigong_5_job2 += num;
						物品属性_qigong_7_job9 += num;
						break;
					case "028":
						物品属性_qigong_7_job2 += num;
						break;
					case "027":
						物品属性_qigong_8_job2 += num;
						物品属性_qigong_9_job9 += num;
						break;
					case "120":
						物品属性_qigong_9_job2 += num;
						break;
					case "320":
						物品属性_qigong_10_job2 += num;
						break;
					case "029":
						物品属性_qigong_11_job2 += num;
						break;
					case "030":
						物品属性_qigong_0_job3 += num;
						break;
					case "031":
						物品属性_qigong_1_job3 += num;
						break;
					case "032":
						物品属性_qigong_2_job3 += num;
						break;
					case "034":
						物品属性_qigong_3_job3 += num;
						break;
					case "035":
						物品属性_qigong_4_job3 += num;
						break;
					case "039":
						物品属性_qigong_5_job3 += num;
						break;
					case "038":
						物品属性_qigong_7_job3 += num;
						break;
					case "036":
						物品属性_qigong_8_job3 += num;
						break;
					case "130":
						物品属性_qigong_9_job3 += num;
						break;
					case "332":
						物品属性_qigong_10_job3 += num;
						break;
					case "037":
						物品属性_qigong_11_job3 += num;
						break;
					case "040":
						物品属性_qigong_0_job4 += num;
						break;
					case "041":
						物品属性_qigong_1_job4 += num;
						break;
					case "042":
						物品属性_qigong_2_job4 += num;
						break;
					case "044":
						物品属性_qigong_3_job4 += num;
						break;
					case "045":
						物品属性_qigong_4_job4 += num;
						break;
					case "048":
						物品属性_qigong_5_job4 += num;
						break;
					case "046":
						物品属性_qigong_7_job4 += num;
						物品属性_qigong_3_job6 += num;
						break;
					case "047":
						物品属性_qigong_8_job4 += num;
						break;
					case "043":
						物品属性_qigong_9_job4 += num;
						break;
					case "049":
						物品属性_qigong_10_job4 += num;
						break;
					case "140":
						物品属性_qigong_11_job4 += num;
						break;
					case "050":
						物品属性_qigong_0_job5 += num;
						break;
					case "051":
						物品属性_qigong_1_job5 += num;
						break;
					case "052":
						物品属性_qigong_3_job5 += num;
						break;
					case "053":
						物品属性_qigong_2_job5 += num;
						break;
					case "054":
						物品属性_qigong_4_job5 += num;
						break;
					case "055":
						物品属性_qigong_5_job5 += num;
						break;
					case "057":
						物品属性_qigong_7_job5 += num;
						break;
					case "056":
						物品属性_qigong_8_job5 += num;
						break;
					case "350":
						物品属性_qigong_9_job5 += num;
						break;
					case "351":
						物品属性_qigong_10_job5 += num;
						break;
					case "059":
						物品属性_qigong_11_job5 += num;
						break;
					case "070":
						物品属性_qigong_0_job6 += num;
						break;
					case "071":
						物品属性_qigong_1_job6 += num;
						break;
					case "072":
						物品属性_qigong_2_job6 += num;
						break;
					case "074":
						物品属性_qigong_7_job4 += num;
						物品属性_qigong_3_job6 += num;
						break;
					case "075":
						物品属性_qigong_4_job6 += num;
						break;
					case "372":
						物品属性_qigong_5_job6 += num;
						break;
					case "076":
						物品属性_qigong_7_job6 += num;
						break;
					case "077":
						物品属性_qigong_8_job6 += num;
						break;
					case "078":
						物品属性_qigong_9_job6 += num;
						break;
					case "079":
						物品属性_qigong_10_job6 += num;
						break;
					case "073":
						物品属性_qigong_11_job6 += num;
						break;
					case "080":
						物品属性_qigong_0_job7 += num;
						break;
					case "081":
						物品属性_qigong_1_job7 += num;
						break;
					case "082":
						物品属性_qigong_2_job7 += num;
						break;
					case "083":
						物品属性_qigong_3_job7 += num;
						break;
					case "084":
						物品属性_qigong_4_job7 += num;
						break;
					case "085":
						物品属性_qigong_5_job7 += num;
						break;
					case "086":
						物品属性_qigong_7_job7 += num;
						break;
					case "087":
						物品属性_qigong_8_job7 += num;
						break;
					case "088":
						物品属性_qigong_9_job7 += num;
						break;
					case "089":
						物品属性_qigong_10_job7 += num;
						break;
					case "180":
						物品属性_qigong_11_job7 += num;
						break;
					case "250":
						物品属性_qigong_0_job8 += num;
						break;
					case "251":
						物品属性_qigong_1_job8 += num;
						break;
					case "253":
						物品属性_qigong_2_job8 += num;
						break;
					case "254":
						物品属性_qigong_3_job8 += num;
						break;
					case "252":
						物品属性_qigong_4_job8 += num;
						break;
					case "255":
						物品属性_qigong_5_job8 += num;
						break;
					case "256":
						物品属性_qigong_7_job8 += num;
						break;
					case "257":
						物品属性_qigong_8_job8 += num;
						break;
					case "259":
						物品属性_qigong_9_job8 += num;
						break;
					case "260":
						物品属性_qigong_10_job8 += num;
						break;
					case "258":
						物品属性_qigong_11_job8 += num;
						break;
					case "270":
						物品属性_qigong_0_job9 += num;
						break;
					case "271":
						物品属性_qigong_1_job9 += num;
						break;
					case "272":
						物品属性_qigong_2_job9 += num;
						break;
					case "273":
						物品属性_qigong_3_job9 += num;
						break;
					case "274":
						物品属性_qigong_4_job9 += num;
						break;
					case "275":
						物品属性_qigong_5_job9 += num;
						break;
					case "276":
						物品属性_qigong_7_job9 += num;
						break;
					case "277":
						物品属性_qigong_8_job9 += num;
						break;
					case "278":
						物品属性_qigong_9_job9 += num;
						break;
					case "279":
						物品属性_qigong_10_job9 += num;
						break;
					case "280":
						物品属性_qigong_11_job9 += num;
						break;
					case "550":
						物品属性_qigong_0_job10 += num;
						break;
					case "551":
						物品属性_qigong_1_job10 += num;
						break;
					case "552":
						物品属性_qigong_2_job10 += num;
						break;
					case "553":
						物品属性_qigong_3_job10 += num;
						break;
					case "558":
						物品属性_qigong_4_job10 += num;
						break;
					case "559":
						物品属性_qigong_5_job10 += num;
						break;
					case "556":
						物品属性_qigong_7_job10 += num;
						break;
					case "554":
						物品属性_qigong_8_job10 += num;
						break;
					case "555":
						物品属性_qigong_9_job10 += num;
						break;
					case "557":
						物品属性_qigong_10_job10 += num;
						break;
					case "560":
						物品属性_qigong_11_job10 += num;
						break;
					case "650":
						物品属性_qigong_0_job11 += num;
						break;
					case "651":
						物品属性_qigong_1_job11 += num;
						break;
					case "653":
						物品属性_qigong_2_job11 += num;
						break;
					case "654":
						物品属性_qigong_3_job11 += num;
						break;
					case "656":
						物品属性_qigong_4_job11 += num;
						break;
					case "657":
						物品属性_qigong_5_job11 += num;
						break;
					case "658":
						物品属性_qigong_7_job11 += num;
						break;
					case "659":
						物品属性_qigong_8_job11 += num;
						break;
					case "660":
						物品属性_qigong_9_job11 += num;
						break;
					case "661":
						物品属性_qigong_10_job11 += num;
						break;
					case "318":
						物品属性_qigong_11_job11 += num;
						break;
					case "281":
						物品属性_qigong_0_job12 += num;
						break;
					case "282":
						物品属性_qigong_1_job12 += num;
						break;
					case "283":
						物品属性_qigong_2_job12 += num;
						break;
					case "284":
						物品属性_qigong_3_job12 += num;
						break;
					case "285":
						物品属性_qigong_4_job12 += num;
						break;
					case "287":
						物品属性_qigong_5_job12 += num;
						break;
					case "286":
						物品属性_qigong_7_job12 += num;
						break;
					case "288":
						物品属性_qigong_8_job12 += num;
						break;
					case "289":
						物品属性_qigong_9_job12 += num;
						break;
					case "290":
						物品属性_qigong_10_job12 += num;
						break;
					case "291":
						物品属性_qigong_11_job12 += num;
						break;
					}
					break;
				}
				case 9:
					物品属性_升级成功率 += num;
					break;
				case 10:
					Item_Attack_Point += num;
					break;
				case 11:
					Item_Defense_Skill += num;
					break;
				case 12:
					物品属性_获得金钱增加 += num;
					break;
				case 13:
					物品属性_死亡损失经验减少 += num;
					break;
				case 15:
					物品属性_经验获得增加 += num;
					break;
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "得到基本属性 出错：" + arg);
			}
		}

		public byte[] GetByte()
		{
			PacketData packetData = new PacketData();
			packetData.WriteLong(Get物品全局ID);
			if (物品绑定)
			{
				packetData.WriteLong(FLD_PID + 20000);
			}
			else
			{
				packetData.WriteLong(FLD_PID);
			}
			packetData.WriteInt(Get_Int_Item_Count);
			packetData.WriteInt(FLD_MAGIC0);
			packetData.WriteInt(FLD_MAGIC1);
			packetData.WriteInt(FLD_MAGIC2);
			packetData.WriteInt(FLD_MAGIC3);
			packetData.WriteInt(FLD_MAGIC4);
			packetData.WriteShort(FLD_FJ_MAGIC0);
			packetData.WriteShort(FLD_FJ_MAGIC1);
			packetData.WriteShort(FLD_FJ_中级附魂);
			packetData.WriteShort(FLD_FJ_MAGIC2);
			packetData.WriteShort(FLD_FJ_MAGIC3);
			packetData.WriteShort(FLD_FJ_MAGIC4);
			packetData.WriteShort(FLD_FJ_MAGIC5);
			packetData.WriteShort(0);
			packetData.WriteInt(FLD_FJ_KSSJ);
			packetData.WriteInt(FLD_FJ_JSSJ);
			if (FLD_持久力 != 0)
			{
				packetData.WriteShort(FLD_持久力);
			}
			else
			{
				packetData.WriteShort(0);
			}
			packetData.WriteInt(FLD_FJ_觉醒 + 物品_中级附魂_追加_觉醒);
			packetData.WriteShort(0);
			packetData.WriteShort(FLD_FJ_进化);
			packetData.WriteShort(0);
			packetData.WriteShort(Type_TuLinh);
			packetData.WriteShort(0);
			packetData.WriteInt(0);
			packetData.WriteInt(0);
			packetData.WriteInt(0);
			if (World.Newversion >= 15)
			{
				packetData.WriteInt(0);
			}
			return packetData.ToArray3();
		}

		public byte[] 得到全局ID()
		{
			byte[] array = new byte[8];
			Buffer.BlockCopy(Byte_Item, 0, array, 0, 8);
			return array;
		}

		public byte[] 得到物品ID()
		{
			byte[] array = new byte[4];
			Buffer.BlockCopy(Byte_Item, 8, array, 0, 4);
			return array;
		}

		public string 得到物品string()
		{
			try
			{
				return Converter.ToString(Byte_Item);
			}
			catch
			{
				return "";
			}
		}

		public int 得到物品单个重量()
		{
			try
			{
				if (World.Itme.TryGetValue(BitConverter.ToInt32(Get_Byte_Item_PID, 0), out ItmeClass value))
				{
					return value.FLD_WEIGHT;
				}
				return 0;
			}
			catch
			{
				return 0;
			}
		}

		public void 得到物品基本攻击力()
		{
			try
			{
				if (BitConverter.ToInt32(Get_Byte_Item_PID, 0) != 0)
				{
					ItmeClass itmeClass = World.Itme[BitConverter.ToInt32(Get_Byte_Item_PID, 0)];
					FLD_RESIDE1 = itmeClass.FLD_RESIDE1;
					FLD_RESIDE2 = itmeClass.FLD_RESIDE2;
					FLD_LEVEL = itmeClass.FLD_LEVEL;
					if (itmeClass.FLD_LEVEL != itmeClass.FLD_SHIELD)
					{
						Item_Shield = 0;
						Item_Shield_Recover = itmeClass.FLD_SHIELD;
					}
					else
					{
						Item_Shield = itmeClass.FLD_SHIELD;
						Item_Shield_Recover = 0;
					}
					if (FLD_FJ_进化 == 0)
					{
						Item_Attack_Min = itmeClass.FLD_AT;
						Item_Attack_Max = itmeClass.FLD_AT_Max;
						Item_Defense = itmeClass.FLD_DF;
					}
					else if (FLD_FJ_进化 == 1)
					{
						Item_Attack_Min = itmeClass.FLD_AT + (long)((double)itmeClass.FLD_AT * 0.05);
						Item_Attack_Max = itmeClass.FLD_AT_Max + (long)((double)itmeClass.FLD_AT_Max * 0.05);
						Item_Defense = itmeClass.FLD_DF + (long)((double)itmeClass.FLD_DF * 0.05);
					}
					else if (FLD_FJ_进化 == 2)
					{
						Item_Attack_Min = itmeClass.FLD_AT + (long)((double)itmeClass.FLD_AT * 0.08);
						Item_Attack_Max = itmeClass.FLD_AT_Max + (long)((double)itmeClass.FLD_AT_Max * 0.08);
						Item_Defense = itmeClass.FLD_DF + (long)((double)itmeClass.FLD_DF * 0.08);
					}
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "得到物品基本攻击力 出错：" + arg);
			}
		}

		public int 得到物品类型()
		{
			int key = BitConverter.ToInt32(得到物品ID(), 0);
			ItmeClass itmeClass = World.Itme[key];
			return itmeClass.FLD_SIDE;
		}

		public string Get_Name()
		{
			if (World.Itme.TryGetValue(BitConverter.ToInt32(Get_Byte_Item_PID, 0), out ItmeClass value))
			{
				return value.ItmeNAME;
			}
			return "";
		}

		public byte[] 得到物品属性()
		{
			byte[] array = new byte[56];
			Buffer.BlockCopy(Byte_Item, 16, array, 0, 56);
			return array;
		}

		public void 得到物品属性方法(int Cuonghoa_Pill_vk = 0, int Cuonghoa_Pill_tb = 0, PlayersBes playersBes = null)
		{
			try
			{
				Reset_Opt_Item_Qigong();
				if (BitConverter.ToInt32(Get_Byte_Item_PID, 0) != 0)
				{
					得到物品基本攻击力();
					byte[] array = new byte[4];
					Buffer.BlockCopy(Byte_Item, 16, array, 0, 4);
					得到强化_MAGIC0(BitConverter.ToInt32(array, 0).ToString(), Cuonghoa_Pill_vk, Cuonghoa_Pill_tb);
					for (int i = 0; i < 4; i++)
					{
						byte[] array2 = new byte[4];
						Buffer.BlockCopy(Byte_Item, 20 + i * 4, array2, 0, 4);
						得到基本属性(BitConverter.ToInt32(array2, 0).ToString());
						if (FLD_RESIDE2 == 4)
						{
							if (playersBes.Show_Pic_Class.ContainsKey(700662))
							{
								得到基本属性(BitConverter.ToInt32(array2, 0).ToString());
							}
						}
						else if (FLD_RESIDE2 == 1 && playersBes.Show_Pic_Class.ContainsKey(700291))
						{
							得到基本属性(BitConverter.ToInt32(array2, 0).ToString());
						}
					}
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "得到物品属性方法 出错：" + arg);
			}
		}

		public byte[] 得到物品数量()
		{
			byte[] array = new byte[4];
			Buffer.BlockCopy(Byte_Item, 12, array, 0, 4);
			return array;
		}

		public int 得到物品位置类型()
		{
			byte[] value = 得到物品ID();
			if (World.Itme.TryGetValue(BitConverter.ToInt32(value, 0), out ItmeClass value2))
			{
				return value2.FLD_RESIDE2;
			}
			return 0;
		}

		public int 得到物品重量()
		{
			try
			{
				if (World.Itme.TryGetValue(BitConverter.ToInt32(Get_Byte_Item_PID, 0), out ItmeClass value))
				{
					return value.FLD_WEIGHT * BitConverter.ToInt32(Item_Amount, 0);
				}
				return 0;
			}
			catch
			{
				return 0;
			}
		}

		public void 设置物品数量(byte[] 数量)
		{
			Buffer.BlockCopy(数量, 0, Byte_Item, 12, 4);
		}

		public void Set_FLD_持久力(int int_84)
		{
			Buffer.BlockCopy(BitConverter.GetBytes(int_84), 0, Byte_Item, 60, 2);
		}

		public void method_234(int value)
		{
			Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Byte_Item, 60, 2);
		}
	}
}

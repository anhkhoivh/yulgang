using DbClss;
using Network;
using RxjhServer.RxjhServer;
using System;
using System.Data;
using System.Data.SqlClient;

namespace RxjhServer
{
	public class PetClass : IDisposable
	{
		private object object_2 = new object();

		private NetState client;

		private long e;

		private float eval_a;

		private float eval_b;

		private float eval_c;

		private int eval_d;

		private string eval_g;

		private int eval_i;

		private long eval_j;

		private long eval_l;

		private int eval_m;

		private int eval_n;

		private int eval_o;

		private int eval_p;

		private int _FLD_HP_MAX;

		private int eval_r;

		private int _FLD_MP_MAX;

		private int int_18;

		private int eval_t;

		private int eval_u;

		private int eval_v;

		private int eval_w;

		private int eval_x;

		private int eval_y;

		public int int_20;

		public int int_21;

		public int int_22;

		public int int_23;

		public int int_24;

		public int int_25;

		public int int_26;

		private int f;

		private string h;

		private long k;

		public Players Playe;

		private int z;

		public 物品类[] 宠物以装备;

		public 物品类[] 宠物装备栏;

		public int 全服ID;

		public MartialArts[] 武功;

		public int Bs
		{
			get
			{
				return f;
			}
			set
			{
				f = value;
			}
		}

		public long FLD_EXP
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

		public long FLD_EXP_MAX
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

		public int FLD_HP
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

		public int FLD_HP_MAX
		{
			get
			{
				return _FLD_HP_MAX;
			}
			set
			{
				_FLD_HP_MAX = value;
			}
		}

		public int FLD_JOB
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

		public int FLD_JOB_LEVEL
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

		public int Pet_FLD_LEVEL
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

		public int FLD_MP
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

		public int FLD_SXBL
		{
			get
			{
				return int_18;
			}
			set
			{
				int_18 = value;
			}
		}

		public int FLD_MP_MAX
		{
			get
			{
				return _FLD_MP_MAX;
			}
			set
			{
				_FLD_MP_MAX = value;
			}
		}

		public int FLD_ZCD
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

		public int FLD_防御
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

		public int FLD_负重
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

		public int FLD_负重_MAX
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

		public int FLD_攻击
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

		public int FLD_回避
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

		public int FLD_命中
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

		public long Id
		{
			get
			{
				return e;
			}
			set
			{
				e = value;
			}
		}

		public string Name
		{
			get
			{
				return h;
			}
			set
			{
				h = value;
			}
		}

		public string ZrName
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

		public int FLD_Item_攻击
		{
			get
			{
				return int_20;
			}
			set
			{
				int_20 = value;
			}
		}

		public int Int32_16
		{
			get
			{
				return int_26;
			}
			set
			{
				int_26 = value;
			}
		}

		public int FLD_Item_防御
		{
			get
			{
				return int_21;
			}
			set
			{
				int_21 = value;
			}
		}

		public int FLD_Item_HP
		{
			get
			{
				return int_22;
			}
			set
			{
				int_22 = value;
			}
		}

		public int FLD_Item_MP
		{
			get
			{
				return int_23;
			}
			set
			{
				int_23 = value;
			}
		}

		public int FLD_Item_命中
		{
			get
			{
				return int_24;
			}
			set
			{
				int_24 = value;
			}
		}

		public int FLD_Item_回避
		{
			get
			{
				return int_25;
			}
			set
			{
				int_25 = value;
			}
		}

		public int Ride
		{
			get
			{
				return z;
			}
			set
			{
				z = value;
			}
		}

		public int 人物坐标_MAP
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

		public float 人物坐标_X
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

		public float 人物坐标_Y
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

		public float 人物坐标_Z
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

		public long 最大经验
		{
			get
			{
				return k;
			}
			set
			{
				k = value;
			}
		}

		public PetClass(long id, NetState clien, DataTable table2)
		{
			client = clien;
			e = id;
			ZrName = table2.Rows[0]["ZrName"].ToString();
			Name = table2.Rows[0]["Name"].ToString();
			FLD_ZCD = (int)table2.Rows[0]["FLD_ZCD"];
			FLD_EXP = long.Parse(table2.Rows[0]["FLD_EXP"].ToString());
			Pet_FLD_LEVEL = (int)table2.Rows[0]["FLD_LEVEL"];
			FLD_JOB = (int)table2.Rows[0]["FLD_JOB"];
			FLD_JOB_LEVEL = (int)table2.Rows[0]["FLD_JOB_LEVEL"];
			FLD_HP = (int)table2.Rows[0]["FLD_HP"];
			FLD_HP_MAX = (int)table2.Rows[0]["FLD_HP"];
			FLD_MP = (int)table2.Rows[0]["FLD_MP"];
			FLD_MP_MAX = (int)table2.Rows[0]["FLD_MP"];
			FLD_SXBL = (int)table2.Rows[0]["FLD_SXBL"];
			Bs = (int)table2.Rows[0]["FLD_BS"];
			FLD_EXP_MAX = 100000L;
			FLD_攻击 = 1000;
			FLD_防御 = 1000;
			FLD_命中 = 1000;
			FLD_回避 = 1000;
			FLD_负重 = 0;
			FLD_负重_MAX = 100;
			宠物装备栏 = new 物品类[16];
			宠物以装备 = new 物品类[4];
			武功 = new MartialArts[32];
			byte[] src = (byte[])table2.Rows[0]["FLD_ITEM"];
			int num = 0;
			while (true)
			{
				bool flag = true;
				if (num >= 16)
				{
					break;
				}
				byte[] array = new byte[73];
				try
				{
					Buffer.BlockCopy(src, num * 73, array, 0, 73);
				}
				catch (Exception value)
				{
					Console.WriteLine(value);
				}
				宠物装备栏[num] = new 物品类(array, num);
				eval_t += 宠物装备栏[num].物品总重量;
				num++;
			}
			byte[] src2 = (byte[])table2.Rows[0]["FLD_WEARITEM"];
			int num2 = 0;
			while (true)
			{
				bool flag = true;
				if (num2 >= 4)
				{
					break;
				}
				byte[] array2 = new byte[73];
				try
				{
					Buffer.BlockCopy(src2, num2 * 73, array2, 0, 73);
				}
				catch (Exception value2)
				{
					Console.WriteLine(value2);
				}
				宠物以装备[num2] = new 物品类(array2, num2);
				eval_t += 宠物以装备[num2].物品总重量;
				num2++;
			}
			byte[] src3 = (byte[])table2.Rows[0]["FLD_KONGFU"];
			int num3 = 0;
			while (true)
			{
				bool flag = true;
				if (num3 >= 32)
				{
					break;
				}
				byte[] array3 = new byte[4];
				try
				{
					Buffer.BlockCopy(src3, num3 * 4, array3, 0, 4);
				}
				catch (Exception value3)
				{
					Console.WriteLine(value3);
				}
				武功[num3] = new MartialArts(BitConverter.ToInt32(array3, 0));
				num3++;
			}
			计算基本数据();
		}

		public void Dispose()
		{
			Playe = null;
			client = null;
			Int32_16 = -1;
		}

		~PetClass()
		{
		}

		public byte[] GetFLD_ITEMCodes()
		{
			byte[] array = new byte[1168];
			for (int i = 0; i < 16; i++)
			{
				byte[] src;
				try
				{
					src = 宠物装备栏[i].Byte_Item;
				}
				catch
				{
					src = new byte[73];
				}
				Buffer.BlockCopy(src, 0, array, i * 73, 73);
			}
			return array;
		}

		public byte[] GetFLD_KONGFUCodes()
		{
			byte[] array = new byte[128];
			for (int i = 0; i < 32; i++)
			{
				byte[] src;
				try
				{
					src = 武功[i].武功ID_byte;
				}
				catch
				{
					src = new byte[4];
				}
				Buffer.BlockCopy(src, 0, array, i * 4, 4);
			}
			return array;
		}

		public void method_5(Players player_0)
		{
			using (new Lock(object_2, "计算宠物装备数据"))
			{
				FLD_Item_攻击 = 0;
				FLD_Item_防御 = 0;
				FLD_Item_HP = 0;
				FLD_Item_MP = 0;
				FLD_Item_命中 = 0;
				FLD_Item_回避 = 0;
				for (int i = 0; i < 4; i++)
				{
					宠物以装备[i].得到物品属性方法();
					FLD_Item_攻击 += (int)(宠物以装备[i].Item_Attack_Min + 宠物以装备[i].Item_Attack_Max) / 2;
					FLD_Item_防御 += (int)宠物以装备[i].Item_Defense;
					FLD_Item_HP += 宠物以装备[i].物品属性_生命力增加;
					FLD_Item_MP += 宠物以装备[i].物品属性_内功力增加;
					FLD_Item_命中 += 宠物以装备[i].Item_Accuracy;
					FLD_Item_回避 += 宠物以装备[i].Item_Evasion;
				}
				FLD_Item_攻击 += (int)(player_0.Item_Wear[14].Item_Attack_Min + player_0.Item_Wear[14].Item_Attack_Max) / 2;
				FLD_Item_防御 += (int)player_0.Item_Wear[14].Item_Defense;
				FLD_Item_HP += player_0.Item_Wear[14].物品属性_生命力增加;
				FLD_Item_MP += player_0.Item_Wear[14].物品属性_内功力增加;
				FLD_Item_命中 += player_0.Item_Wear[14].Item_Accuracy;
				FLD_Item_回避 += player_0.Item_Wear[14].Item_Evasion;
			}
			计算基本数据();
		}

		public byte[] GetWEARITEMCodes()
		{
			byte[] array = new byte[292];
			for (int i = 0; i < 4; i++)
			{
				byte[] src;
				try
				{
					src = 宠物以装备[i].Byte_Item;
				}
				catch
				{
					src = new byte[73];
				}
				Buffer.BlockCopy(src, 0, array, i * 73, 73);
			}
			return array;
		}

		public void 保存数据()
		{
			SqlParameter[] prams = new SqlParameter[14]
			{
				SqlDBA.MakeInParam("@id", SqlDbType.VarChar, 20, e.ToString()),
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 20, Name),
				SqlDBA.MakeInParam("@level", SqlDbType.Int, 0, Pet_FLD_LEVEL),
				SqlDBA.MakeInParam("@zcd", SqlDbType.Int, 10, FLD_ZCD),
				SqlDBA.MakeInParam("@job", SqlDbType.Int, 0, FLD_JOB),
				SqlDBA.MakeInParam("@job_level", SqlDbType.Int, 0, FLD_JOB_LEVEL),
				SqlDBA.MakeInParam("@exp", SqlDbType.VarChar, 50, FLD_EXP.ToString()),
				SqlDBA.MakeInParam("@hp", SqlDbType.Int, 0, FLD_HP),
				SqlDBA.MakeInParam("@mp", SqlDbType.Int, 0, FLD_MP),
				SqlDBA.MakeInParam("@strWearitem", SqlDbType.VarBinary, 292, GetWEARITEMCodes()),
				SqlDBA.MakeInParam("@strItem", SqlDbType.VarBinary, 1168, GetFLD_ITEMCodes()),
				SqlDBA.MakeInParam("@strKongfu", SqlDbType.VarBinary, 128, GetFLD_KONGFUCodes()),
				SqlDBA.MakeInParam("@bs", SqlDbType.Int, 0, Bs),
				SqlDBA.MakeInParam("@sxbl", SqlDbType.Int, 0, FLD_SXBL)
			};
			DbPoolClass dbPoolClass = new DbPoolClass();
			dbPoolClass.Conn = DBA.getstrConnection(null);
			dbPoolClass.Prams = prams;
			dbPoolClass.Sql = "XWWL_UPDATE_Cw_DATA";
			World.SqlPool.Enqueue(dbPoolClass);
		}

		public void 计算基本数据()
		{
			if (Pet_FLD_LEVEL > 99)
			{
				Pet_FLD_LEVEL = 99;
			}
			最大经验 = (long)World.Level[Pet_FLD_LEVEL];
			int pet_FLD_LEVEL = Pet_FLD_LEVEL;
			while (FLD_EXP >= 最大经验 && Pet_FLD_LEVEL < 99)
			{
				if (client == null || !client.Running)
				{
					return;
				}
				Pet_FLD_LEVEL++;
				最大经验 = (long)World.Level[Pet_FLD_LEVEL];
			}
			if (Pet_FLD_LEVEL - pet_FLD_LEVEL > 0)
			{
				client.Player.灵兽升级后的提示();
			}
			FLD_负重_MAX = 500 + 20 * Pet_FLD_LEVEL;
			switch (eval_n)
			{
			case 1:
				_FLD_HP_MAX = 133 + Pet_FLD_LEVEL * 12;
				_FLD_MP_MAX = 114 + Pet_FLD_LEVEL * 2;
				FLD_命中 = 8 + Pet_FLD_LEVEL + FLD_Item_命中;
				FLD_回避 = 8 + Pet_FLD_LEVEL + FLD_Item_回避;
				FLD_攻击 = 9 + FLD_Item_攻击;
				FLD_防御 = 16 + FLD_Item_防御;
				for (int j = 2; j <= Pet_FLD_LEVEL; j++)
				{
					if (j % 2 == 0)
					{
						FLD_攻击 += 2;
						FLD_防御 += 2;
					}
					else
					{
						FLD_攻击++;
						FLD_防御++;
					}
				}
				break;
			case 2:
				_FLD_HP_MAX = 133 + Pet_FLD_LEVEL * 12;
				_FLD_MP_MAX = 114 + Pet_FLD_LEVEL * 2;
				FLD_命中 = 8 + Pet_FLD_LEVEL + FLD_Item_命中;
				FLD_回避 = 8 + Pet_FLD_LEVEL + FLD_Item_回避;
				FLD_攻击 = 9 + FLD_Item_攻击;
				FLD_防御 = 16 + FLD_Item_防御;
				for (int k = 2; k <= Pet_FLD_LEVEL; k++)
				{
					if (k % 2 == 0)
					{
						FLD_攻击 += 2;
						FLD_防御 += 2;
					}
					else
					{
						FLD_攻击++;
						FLD_防御++;
					}
				}
				break;
			case 3:
				_FLD_HP_MAX = 133 + Pet_FLD_LEVEL * 12;
				_FLD_MP_MAX = 114 + Pet_FLD_LEVEL * 2;
				FLD_命中 = 8 + Pet_FLD_LEVEL + FLD_Item_命中;
				FLD_回避 = 8 + Pet_FLD_LEVEL + FLD_Item_回避;
				FLD_攻击 = 9 + FLD_Item_攻击;
				FLD_防御 = 16 + FLD_Item_防御;
				for (int l = 2; l <= Pet_FLD_LEVEL; l++)
				{
					if (l % 2 == 0)
					{
						FLD_攻击 += 2;
						FLD_防御 += 2;
					}
					else
					{
						FLD_攻击++;
						FLD_防御++;
					}
				}
				break;
			case 4:
				_FLD_HP_MAX = 133 + Pet_FLD_LEVEL * 12;
				_FLD_MP_MAX = 114 + Pet_FLD_LEVEL * 2;
				FLD_命中 = 8 + Pet_FLD_LEVEL + FLD_Item_命中;
				FLD_回避 = 8 + Pet_FLD_LEVEL + FLD_Item_回避;
				FLD_攻击 = 9 + FLD_Item_攻击;
				FLD_防御 = 16 + FLD_Item_防御;
				for (int i = 2; i <= Pet_FLD_LEVEL; i++)
				{
					if (i % 2 == 0)
					{
						FLD_攻击 += 2;
						FLD_防御 += 2;
					}
					else
					{
						FLD_攻击++;
						FLD_防御++;
					}
				}
				break;
			case 5:
				_FLD_HP_MAX = 133 + Pet_FLD_LEVEL * 12;
				_FLD_MP_MAX = 114 + Pet_FLD_LEVEL * 2;
				FLD_命中 = 8 + Pet_FLD_LEVEL + FLD_Item_命中;
				FLD_回避 = 8 + Pet_FLD_LEVEL + FLD_Item_回避;
				FLD_攻击 = 9 + FLD_Item_攻击;
				FLD_防御 = 16 + FLD_Item_防御;
				for (int i = 2; i <= Pet_FLD_LEVEL; i++)
				{
					if (i % 2 == 0)
					{
						FLD_攻击 += 2;
						FLD_防御 += 2;
					}
					else
					{
						FLD_攻击++;
						FLD_防御++;
					}
				}
				break;
			}
			switch (eval_o)
			{
			case 1:
				FLD_攻击 += 5;
				FLD_防御 += 5;
				_FLD_HP_MAX += 85;
				_FLD_MP_MAX += 50;
				break;
			case 2:
				FLD_攻击 += 15;
				FLD_防御 += 15;
				_FLD_HP_MAX += 200;
				_FLD_MP_MAX += 150;
				break;
			case 3:
				FLD_攻击 += 35;
				FLD_防御 += 35;
				_FLD_HP_MAX += 400;
				_FLD_MP_MAX += 350;
				break;
			}
			FLD_HP = _FLD_HP_MAX + FLD_Item_HP;
			FLD_MP = _FLD_MP_MAX + FLD_Item_MP;
		}
	}
}

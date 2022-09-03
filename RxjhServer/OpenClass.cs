using RxjhServer.RxjhServer;
using System;

namespace RxjhServer
{
	public class OpenClass
	{
		private int eval_a;

		private string eval_b;

		private int eval_c;

		private string eval_d;

		private int eval_e;

		private int eval_f;

		private int eval_g;

		private int eval_h;

		private int eval_i;

		private int eval_j;

		private int eval_k;

		private int eval_l;

		private int eval_n;

		private int eval_o;

		private int eval_p;

		private int m;

		private int _FLD_THONGBAO;

		public int FLD_MAGIC0
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

		public int FLD_MAGIC1
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

		public int FLD_MAGIC2
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

		public int FLD_MAGIC3
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

		public int FLD_MAGIC4
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

		public string FLD_NAME
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

		public string FLD_NAMEX
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

		public int FLD_NUMBER
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

		public int FLD_PIDX
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

		public int FLD_PP
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

		public int FLD_初级附魂
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

		public int FLD_进化
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

		public int FLD_是否绑定
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

		public int FLD_中级附魂
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

		public int 使用天数
		{
			get
			{
				return m;
			}
			set
			{
				m = value;
			}
		}

		public int FLD_THONGBAO
		{
			get
			{
				return _FLD_THONGBAO;
			}
			set
			{
				_FLD_THONGBAO = value;
			}
		}

		public static OpenClass GetOpen(int Pid)
		{
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			foreach (OpenClass item in World.Open)
			{
				if (item.FLD_PID == Pid)
				{
					num += item.FLD_PP;
				}
			}
			num2 = new Random(World.GetRandomSeed()).Next(1, num + 1);
			foreach (OpenClass item2 in World.Open)
			{
				if (item2.FLD_PID == Pid)
				{
					num3 += item2.FLD_PP;
					if (num3 >= num2)
					{
						return item2;
					}
				}
			}
			return null;
		}
	}
}

using RxjhServer.RxjhServer;

namespace RxjhServer
{
	public class MonSterClss
	{
		private string a;

		private int eval_b;

		private int eval_c;

		private int eval_d;

		private double eval_e;

		private double eval_f;

		private int eval_g;

		private int eval_h;

		private int eval_i;

		public double FLD_AT
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

		public int FLD_AUTO
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

		public int FLD_BOSS
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

		public double FLD_DF
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

		public int FLD_PID
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

		public int Level
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

		public string Name
		{
			get
			{
				return a;
			}
			set
			{
				a = value;
			}
		}

		public int Rxjh_Exp
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

		public int Rxjh_HP
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

		public static string getnpcname(int id)
		{
			if (World.MonSter.TryGetValue(id, out MonSterClss value))
			{
				return value.Name;
			}
			return "";
		}
	}
}

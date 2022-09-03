using RxjhServer.RxjhServer;

namespace RxjhServer
{
	public class TransferAttributes
	{
		private int eval_a;

		private int eval_b;

		private int eval_c;

		private int eval_d;

		private int eval_e;

		public int FLD_AT
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

		public int FLD_DF
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

		public int FLD_HP
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

		public int FLD_JOB_LEVEL
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

		public int FLD_MP
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

		public TransferAttributes GetValue(int 转职)
		{
			foreach (TransferAttributes value in World.转职属性数据.Values)
			{
				if (value.FLD_JOB_LEVEL == 转职)
				{
					return value;
				}
			}
			return null;
		}
	}
}

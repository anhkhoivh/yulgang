using RxjhServer.RxjhServer;

namespace RxjhServer
{
	public class 石头属性调整类
	{
		private int eval_a;

		private int eval_b;

		public int FLD_ID
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

		public int FLD_百分比
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

		public int GetValue(int ID)
		{
			foreach (石头属性调整类 value in World.石头属性调整.Values)
			{
				if (value.FLD_ID == ID)
				{
					return value.FLD_百分比;
				}
			}
			return 0;
		}
	}
}

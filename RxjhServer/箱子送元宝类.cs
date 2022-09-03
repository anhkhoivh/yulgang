namespace RxjhServer
{
	public class 箱子送元宝类
	{
		private int b;

		private int eval_a;

		public int ItmeID
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

		public int 元宝
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
	}
}

namespace RxjhServer
{
	public class 公告类
	{
		private int a;

		private string b;

		public string msg
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

		public int type
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
	}
}

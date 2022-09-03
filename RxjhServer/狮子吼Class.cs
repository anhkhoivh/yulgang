namespace RxjhServer
{
	public class 狮子吼Class
	{
		private string d;

		private int eval_a;

		private string eval_b;

		private int eval_c;

		public int FLD_INDEX
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

		public string Txt
		{
			get
			{
				return d;
			}
			set
			{
				d = value;
			}
		}

		public int TxtId
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

		public string UserName
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
	}
}

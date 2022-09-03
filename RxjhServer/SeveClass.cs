namespace RxjhServer
{
	public class SeveClass
	{
		private string eval_a;

		private string eval_b;

		public string ServerDb
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

		public string SqlConnect
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

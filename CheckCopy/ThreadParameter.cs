namespace CheckCopy
{
	public class ThreadParameter
	{
		private int _全局ID;

		private int _类型;

		private string _id;

		private string _name;

		public string id
		{
			get
			{
				return _id;
			}
			set
			{
				_id = value;
			}
		}

		public string name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}

		public int 类型
		{
			get
			{
				return _类型;
			}
			set
			{
				_类型 = value;
			}
		}

		public int 全局ID
		{
			get
			{
				return _全局ID;
			}
			set
			{
				_全局ID = value;
			}
		}

		public ThreadParameter(int 全局ID, string id, string name, int 类型)
		{
		}
	}
}

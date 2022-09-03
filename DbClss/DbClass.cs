namespace DbClss
{
	public class DbClass
	{
		private string _ServerDb;

		private string _SqlConnect;

		public string ServerDb
		{
			get
			{
				return _ServerDb;
			}
			set
			{
				_ServerDb = value;
			}
		}

		public string SqlConnect
		{
			get
			{
				return _SqlConnect;
			}
			set
			{
				_SqlConnect = value;
			}
		}
	}
}

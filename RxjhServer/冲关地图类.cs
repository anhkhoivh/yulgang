namespace RxjhServer
{
	public class 冲关地图类
	{
		private string _地图名;

		private int _ItmeID;

		public int ItmeID
		{
			get
			{
				return _ItmeID;
			}
			set
			{
				_ItmeID = value;
			}
		}

		public string 地图名
		{
			get
			{
				return _地图名;
			}
			set
			{
				_地图名 = value;
			}
		}
	}
}

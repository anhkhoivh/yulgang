using System.Collections.Generic;

namespace RxjhServer
{
	public class 帮战Class
	{
		public string 帮主名称 = "";

		public int 申请帮派ID;

		public string 申请帮派名称 = "";

		public int 申请地图;

		public Dictionary<int, Players> 申请人物列表 = new Dictionary<int, Players>();
	}
}

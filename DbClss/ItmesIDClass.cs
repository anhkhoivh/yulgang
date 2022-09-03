using RxjhServer;
using RxjhServer.RxjhServer;
using System;
using System.Collections.Generic;

namespace DbClss
{
	public class ItmesIDClass
	{
		private long Id;

		private long ItmeId;

		private object AsyncLocksw = new object();

		public ItmesIDClass()
		{
			try
			{
				ItmeId = 0L;
				Id = 0L;
				ItmeId = long.Parse(DBA.GetDBValue_3("EXEC XWWL_GetItemSerial2 1000").ToString());
				Id = ItmeId + 1000;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(100, "全局ID出错" + ex.Message);
				World.Conn.Dispose();
				List<Players> list = new List<Players>();
				foreach (Players value in World.AllConnectedChars.Values)
				{
					list.Add(value);
				}
				foreach (Players item in list)
				{
					try
					{
						if (item.Client != null)
						{
							item.Client.Dispose();
						}
					}
					catch (Exception ex2)
					{
						Form1.WriteLine(1, "保存人物的数据 错误" + ex2.Message);
					}
				}
				list.Clear();
			}
		}

		public long AcquireBuffer()
		{
			using (new Lock(AsyncLocksw, "AcquireBuffer"))
			{
				if (ItmeId < Id)
				{
					return ItmeId++;
				}
				ItmeId = long.Parse(DBA.GetDBValue_3("EXEC XWWL_GetItemSerial2 1000").ToString());
				Id = ItmeId + 1000;
				return ItmeId++;
			}
		}
	}
}

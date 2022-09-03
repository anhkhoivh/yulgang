using RxjhServer.RxjhServer;

namespace DbClss
{
    using RxjhServer;
    using System;
    using System.Collections.Generic;

    public class ItmesIDClass
    {
        private long Id;
        private long ItmeId;
        private object AsyncLocksw = new object();

        public ItmesIDClass()
        {
            try
            {
                this.ItmeId = 0L;
                this.Id = 0L;
                this.ItmeId = long.Parse(DBA.GetDBValue_3("EXEC XWWL_GetItemSerial2 1000").ToString());
                this.Id = this.ItmeId + 1000L;
            }
            catch (Exception exception)
            {
                Form1.WriteLine(100, "全局ID出错" + exception.Message);
                World.Conn.Dispose();
                List<Players> list = new List<Players>();
                foreach (Players players in World.AllConnectedChars.Values)
                {
                    list.Add(players);
                }
                foreach (Players players2 in list)
                {
                    try
                    {
                        if (players2.Client != null)
                        {
                            players2.Client.Dispose();
                        }
                        continue;
                    }
                    catch (Exception exception2)
                    {
                        Form1.WriteLine(1, "保存人物的数据 错误" + exception2.Message);
                        continue;
                    }
                }
                list.Clear();
            }
        }

        public long AcquireBuffer()
        {
            using (new Lock(this.AsyncLocksw, "AcquireBuffer"))
            {
                long num3;
                if (this.ItmeId < this.Id)
                {
                    long num;
                    this.ItmeId = (num = this.ItmeId) + 1L;
                    return num;
                }
                this.ItmeId = long.Parse(DBA.GetDBValue_3("EXEC XWWL_GetItemSerial2 1000").ToString());
                this.Id = this.ItmeId + 1000L;
                this.ItmeId = (num3 = this.ItmeId) + 1L;
                return num3;
            }
        }
    }
}


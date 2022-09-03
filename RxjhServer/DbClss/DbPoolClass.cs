using RxjhServer.RxjhServer;

namespace DbClss
{
    using RxjhServer;
    using System;
    using System.Data.SqlClient;

    public class DbPoolClass
    {
        private string _Conn;
        private SqlParameter[] _Prams;
        private int _Type;
        private string _Sql;

        public static int DbPoolClassRun(string SqlConnection, string procName, SqlParameter[] prams, int Type)
        {
            try
            {
                SqlConnection conn = new SqlConnection(SqlConnection);
                if (Type == 1)
                {
                    if (SqlDBA.RunProcSql(conn, procName, prams) == -1)
                    {
                        if (World.JlMsg == 1)
                        {
                            //Form1.WriteLine(0, procName);
                        }
                        return -1;
                    }
                    return 0;
                }
                if (SqlDBA.RunProc(conn, procName, prams) == -1)
                {
                    if (World.JlMsg == 1)
                    {
                        //Form1.WriteLine(0, procName);
                    }
                    return -1;
                }
                return 0;
            }
            catch (Exception exception)
            {
                Form1.WriteLine(1, "DbPoolClassRun出错" + exception);
                return -1;
            }
        }

        public string Conn
        {
            get
            {
                return this._Conn;
            }
            set
            {
                this._Conn = value;
            }
        }

        public SqlParameter[] Prams
        {
            get
            {
                return this._Prams;
            }
            set
            {
                this._Prams = value;
            }
        }

        public string Sql
        {
            get
            {
                return this._Sql;
            }
            set
            {
                this._Sql = value;
            }
        }

        public int Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this._Type = value;
            }
        }
    }
}


using RxjhServer;
using RxjhServer.RxjhServer;
using System;
using System.Data.SqlClient;

namespace DbClss
{
	public class DbPoolClass
	{
		private string _Conn;

		private SqlParameter[] _Prams;

		private int _Type;

		private string _Sql;

		public string Conn
		{
			get
			{
				return _Conn;
			}
			set
			{
				_Conn = value;
			}
		}

		public SqlParameter[] Prams
		{
			get
			{
				return _Prams;
			}
			set
			{
				_Prams = value;
			}
		}

		public string Sql
		{
			get
			{
				return _Sql;
			}
			set
			{
				_Sql = value;
			}
		}

		public int Type
		{
			get
			{
				return _Type;
			}
			set
			{
				_Type = value;
			}
		}

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
						}
						return -1;
					}
					return 0;
				}
				if (SqlDBA.RunProc(conn, procName, prams) == -1)
				{
					if (World.JlMsg == 1)
					{
					}
					return -1;
				}
				return 0;
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "DbPoolClassRun出错" + arg);
				return -1;
			}
		}
	}
}

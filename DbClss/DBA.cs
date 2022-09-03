using RxjhServer;
using RxjhServer.RxjhServer;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace DbClss
{
	public class DBA
	{
		public static int ExeSqlCommand(string sqlCommand)
		{
			serlog(sqlCommand);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(null)))
			{
				using (SqlCommand sqlCommand2 = new SqlCommand(sqlCommand, sqlConnection))
				{
					int result = -1;
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						return -1;
					}
					try
					{
						result = sqlCommand2.ExecuteNonQuery();
					}
					catch (Exception ex)
					{
						Setlog(sqlCommand, null, ex);
					}
					sqlCommand2.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return result;
				}
			}
		}

		public static int ExeSqlCommand(string sqlCommand, SqlParameter[] prams)
		{
			serlog(sqlCommand, prams);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(null)))
			{
				using (SqlCommand sqlCommand2 = SqlDBA.CreateCommandSql(sqlConnection, sqlCommand, prams))
				{
					int result = -1;
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						return -1;
					}
					try
					{
						result = sqlCommand2.ExecuteNonQuery();
					}
					catch (Exception ex)
					{
						Setlog(sqlCommand, prams, ex);
					}
					sqlCommand2.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return result;
				}
			}
		}

		public static int ExeSqlCommand(string sqlCommand, string server)
		{
			serlog(sqlCommand);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(server)))
			{
				using (SqlCommand sqlCommand2 = new SqlCommand(sqlCommand, sqlConnection))
				{
					int result = -1;
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						return -1;
					}
					try
					{
						result = sqlCommand2.ExecuteNonQuery();
					}
					catch (Exception ex)
					{
						Setlog(sqlCommand, null, ex);
					}
					sqlCommand2.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return result;
				}
			}
		}

		public static int ExeSqlCommand(string sqlCommand, ref Exception exception, string db)
		{
			serlog(sqlCommand);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(null)))
			{
				using (SqlCommand sqlCommand2 = new SqlCommand(sqlCommand, sqlConnection))
				{
					try
					{
						sqlConnection.Open();
					}
					catch (Exception ex)
					{
						Exception ex2 = exception = ex;
						return -1;
					}
					int result = sqlCommand2.ExecuteNonQuery();
					sqlCommand2.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return result;
				}
			}
		}

		public static int ExeSqlCommand(string sqlCommand, SqlParameter[] prams, string server)
		{
			serlog(sqlCommand, prams);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(server)))
			{
				using (SqlCommand sqlCommand2 = SqlDBA.CreateCommandSql(sqlConnection, sqlCommand, prams))
				{
					int result = -1;
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						return -1;
					}
					try
					{
						result = sqlCommand2.ExecuteNonQuery();
					}
					catch (Exception ex)
					{
						Setlog(sqlCommand, prams, ex);
					}
					sqlCommand2.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return result;
				}
			}
		}

		public static DataTable GetDBToDataTable(string sqlCommand)
		{
			serlog(sqlCommand);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(null)))
			{
				using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
				{
					SqlCommand sqlCommand3 = sqlDataAdapter.SelectCommand = new SqlCommand(sqlCommand, sqlConnection);
					using (sqlCommand3)
					{
						try
						{
							sqlConnection.Open();
						}
						catch (Exception ex)
						{
							Form1.WriteLine(100, "DBA数据层_错误" + ex.Message + " " + sqlCommand);
							return null;
						}
						DataTable dataTable = new DataTable();
						try
						{
							sqlDataAdapter.Fill(dataTable);
						}
						catch (Exception ex2)
						{
							Setlog(sqlCommand, null, ex2);
						}
						sqlDataAdapter.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						return dataTable;
					}
				}
			}
		}

		public static DataTable GetDBToDataTable(string sqlCommand, SqlParameter[] prams)
		{
			serlog(sqlCommand, prams);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(null)))
			{
				using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
				{
					SqlCommand sqlCommand3 = sqlDataAdapter.SelectCommand = SqlDBA.CreateCommandSql(sqlConnection, sqlCommand, prams);
					using (sqlCommand3)
					{
						try
						{
							sqlConnection.Open();
						}
						catch (Exception ex)
						{
							Form1.WriteLine(100, "DBA数据层_错误" + ex.Message + " " + sqlCommand);
							return null;
						}
						DataTable dataTable = new DataTable();
						try
						{
							sqlDataAdapter.Fill(dataTable);
						}
						catch (Exception ex2)
						{
							Setlog(sqlCommand, prams, ex2);
						}
						sqlDataAdapter.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						return dataTable;
					}
				}
			}
		}

		public static DataTable GetDBToDataTable(string sqlCommand, string server)
		{
			serlog(sqlCommand);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(server)))
			{
				using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
				{
					SqlCommand sqlCommand3 = sqlDataAdapter.SelectCommand = new SqlCommand(sqlCommand, sqlConnection);
					using (sqlCommand3)
					{
						try
						{
							sqlConnection.Open();
						}
						catch
						{
							return null;
						}
						DataTable dataTable = new DataTable();
						try
						{
							sqlDataAdapter.Fill(dataTable);
						}
						catch (Exception ex)
						{
							Setlog(sqlCommand, null, ex);
						}
						sqlDataAdapter.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						return dataTable;
					}
				}
			}
		}

		public static DataTable GetDBToDataTable(string sqlCommand, SqlParameter[] prams, string server)
		{
			serlog(sqlCommand, prams);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(server)))
			{
				using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
				{
					SqlCommand sqlCommand3 = sqlDataAdapter.SelectCommand = SqlDBA.CreateCommandSql(sqlConnection, sqlCommand, prams);
					using (sqlCommand3)
					{
						try
						{
							sqlConnection.Open();
						}
						catch (Exception ex)
						{
							Form1.WriteLine(100, "DBA数据层_错误" + ex.Message + " " + sqlCommand);
							return null;
						}
						DataTable dataTable = new DataTable();
						try
						{
							sqlDataAdapter.Fill(dataTable);
						}
						catch (Exception ex2)
						{
							Setlog(sqlCommand, prams, ex2);
						}
						sqlDataAdapter.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						return dataTable;
					}
				}
			}
		}

		public static DataRowCollection GetDBValue(string sqlCommand, string db)
		{
			return GetDBToDataTable(sqlCommand).Rows;
		}

		public static ArrayList GetDBValue_1(string sqlCommand, string db)
		{
			serlog(sqlCommand);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(null)))
			{
				using (SqlCommand sqlCommand2 = new SqlCommand(sqlCommand, sqlConnection))
				{
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						return null;
					}
					SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();
					if (!sqlDataReader.HasRows)
					{
						sqlDataReader.Close();
						sqlDataReader.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						return null;
					}
					ArrayList arrayList = new ArrayList();
					if (sqlDataReader.Read())
					{
						for (int i = 0; i < sqlDataReader.FieldCount; i++)
						{
							arrayList.Add(sqlDataReader[i]);
						}
					}
					sqlDataReader.Close();
					sqlDataReader.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return arrayList;
				}
			}
		}

		public static ArrayList GetDBValue_2(string sqlCommand, string db)
		{
			serlog(sqlCommand);
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(null)))
			{
				using (SqlCommand sqlCommand2 = new SqlCommand(sqlCommand, sqlConnection))
				{
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						return null;
					}
					SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();
					if (!sqlDataReader.HasRows)
					{
						sqlDataReader.Close();
						sqlDataReader.Dispose();
						sqlConnection.Close();
						sqlConnection.Dispose();
						return null;
					}
					ArrayList arrayList = new ArrayList();
					while (sqlDataReader.Read())
					{
						arrayList.Add(sqlDataReader[0]);
					}
					sqlDataReader.Close();
					sqlDataReader.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return arrayList;
				}
			}
		}

		public static object GetDBValue_3(string sqlCommand)
		{
			serlog(sqlCommand);
			object result = null;
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(null)))
			{
				using (SqlCommand sqlCommand2 = new SqlCommand(sqlCommand, sqlConnection))
				{
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						return null;
					}
					try
					{
						result = sqlCommand2.ExecuteScalar();
					}
					catch (Exception ex)
					{
						Form1.WriteLine(100, "DBA数据层_错误" + ex.Message + " " + sqlCommand);
					}
					sqlCommand2.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return result;
				}
			}
		}

		public static object GetDBValue_3(string sqlCommand, string db)
		{
			serlog(sqlCommand);
			object result = null;
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(db)))
			{
				using (SqlCommand sqlCommand2 = new SqlCommand(sqlCommand, sqlConnection))
				{
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						return null;
					}
					try
					{
						result = sqlCommand2.ExecuteScalar();
					}
					catch (Exception ex)
					{
						Form1.WriteLine(100, "DBA数据层_错误" + ex.Message + " " + sqlCommand);
					}
					sqlCommand2.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return result;
				}
			}
		}

		public static object GetDBValue_3(string sqlCommand, SqlParameter[] prams)
		{
			serlog(sqlCommand, prams);
			object result = null;
			using (SqlConnection sqlConnection = new SqlConnection(getstrConnection(null)))
			{
				using (SqlCommand sqlCommand2 = SqlDBA.CreateCommandSql(sqlConnection, sqlCommand, prams))
				{
					try
					{
						sqlConnection.Open();
					}
					catch
					{
						return null;
					}
					try
					{
						result = sqlCommand2.ExecuteScalar();
					}
					catch (Exception ex)
					{
						Form1.WriteLine(100, "DBA数据层_错误" + ex.Message + " " + sqlCommand);
					}
					sqlCommand2.Dispose();
					sqlConnection.Close();
					sqlConnection.Dispose();
					return result;
				}
			}
		}

		public static string getstrConnection(string db)
		{
			try
			{
				if (db == null)
				{
					db = "GameServer";
				}
				if (World.Db.TryGetValue(db, out DbClass value))
				{
					return value.SqlConnect;
				}
				return null;
			}
			catch
			{
				return null;
			}
		}

		public static void serlog(string txt)
		{
			string sqlJl = World.SqlJl;
			if (!(sqlJl != ""))
			{
				return;
			}
			string[] array = sqlJl.Split('|');
			for (int i = 0; i < array.Length; i++)
			{
				if (txt.ToLower().IndexOf(array[i].ToLower()) != -1)
				{
					Form1.WriteLine(99, txt);
				}
			}
		}

		public static void serlog(string txt, SqlParameter[] prams)
		{
			string sqlJl = World.SqlJl;
			if (!(sqlJl != ""))
			{
				return;
			}
			string[] array = sqlJl.Split('|');
			for (int i = 0; i < array.Length; i++)
			{
				if (txt.ToLower().IndexOf(array[i].ToLower()) != -1)
				{
					Form1.WriteLine(99, txt);
				}
			}
			for (int j = 0; j < array.Length; j++)
			{
				foreach (SqlParameter sqlParameter in prams)
				{
					if (sqlParameter.SqlValue.ToString().ToLower().IndexOf(array[j].ToLower()) != -1)
					{
						Form1.WriteLine(99, txt + " " + sqlParameter.SqlValue.ToString());
					}
				}
			}
		}

		public static void Setlog(string txt, SqlParameter[] prams, Exception ex)
		{
			Form1.WriteLine(100, "-----------DBA数据层_错误-----------");
			Form1.WriteLine(100, txt);
			if (prams != null)
			{
				foreach (SqlParameter sqlParameter in prams)
				{
					Form1.WriteLine(100, sqlParameter.SqlValue.ToString());
				}
			}
			Form1.WriteLine(100, ex.Message);
		}
	}
}

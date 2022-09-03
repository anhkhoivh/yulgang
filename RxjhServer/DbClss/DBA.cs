using RxjhServer.RxjhServer;

namespace DbClss
{
    using RxjhServer;
    using System;
    using System.Collections;
    using System.Data;
    using System.Data.SqlClient;

    public class DBA
    {
        public static int ExeSqlCommand(string sqlCommand)
        {
            int num2;
            serlog(sqlCommand);
            using (SqlConnection connection = new SqlConnection(getstrConnection(null)))
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    int num = -1;
                    try
                    {
                        connection.Open();
                    }
                    catch
                    {
                        return -1;
                    }
                    try
                    {
                        num = command.ExecuteNonQuery();
                    }
                    catch (Exception exception)
                    {
                        Setlog(sqlCommand, null, exception);
                    }
                    command.Dispose();
                    connection.Close();
                    connection.Dispose();
                    num2 = num;
                }
            }
            return num2;
        }

        public static int ExeSqlCommand(string sqlCommand, SqlParameter[] prams)
        {
            int num2;
            serlog(sqlCommand, prams);
            using (SqlConnection connection = new SqlConnection(getstrConnection(null)))
            {
                using (SqlCommand command = SqlDBA.CreateCommandSql(connection, sqlCommand, prams))
                {
                    int num = -1;
                    try
                    {
                        connection.Open();
                    }
                    catch
                    {
                        return -1;
                    }
                    try
                    {
                        num = command.ExecuteNonQuery();
                    }
                    catch (Exception exception)
                    {
                        Setlog(sqlCommand, prams, exception);
                    }
                    command.Dispose();
                    connection.Close();
                    connection.Dispose();
                    num2 = num;
                }
            }
            return num2;
        }

        public static int ExeSqlCommand(string sqlCommand, string server)
        {
            int num2;
            serlog(sqlCommand);
            using (SqlConnection connection = new SqlConnection(getstrConnection(server)))
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    int num = -1;
                    try
                    {
                        connection.Open();
                    }
                    catch
                    {
                        return -1;
                    }
                    try
                    {
                        num = command.ExecuteNonQuery();
                    }
                    catch (Exception exception)
                    {
                        Setlog(sqlCommand, null, exception);
                    }
                    command.Dispose();
                    connection.Close();
                    connection.Dispose();
                    num2 = num;
                }
            }
            return num2;
        }

        public static int ExeSqlCommand(string sqlCommand, ref Exception exception, string db)
        {
            int num;
            serlog(sqlCommand);
            using (SqlConnection connection = new SqlConnection(getstrConnection(null)))
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception exception2)
                    {
                        exception = exception2;
                        return -1;
                    }
                    int num2 = command.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();
                    connection.Dispose();
                    num = num2;
                }
            }
            return num;
        }

        public static int ExeSqlCommand(string sqlCommand, SqlParameter[] prams, string server)
        {
            int num2;
            serlog(sqlCommand, prams);
            using (SqlConnection connection = new SqlConnection(getstrConnection(server)))
            {
                using (SqlCommand command = SqlDBA.CreateCommandSql(connection, sqlCommand, prams))
                {
                    int num = -1;
                    try
                    {
                        connection.Open();
                    }
                    catch
                    {
                        return -1;
                    }
                    try
                    {
                        num = command.ExecuteNonQuery();
                    }
                    catch (Exception exception)
                    {
                        Setlog(sqlCommand, prams, exception);
                    }
                    command.Dispose();
                    connection.Close();
                    connection.Dispose();
                    num2 = num;
                }
            }
            return num2;
        }

        public static DataTable GetDBToDataTable(string sqlCommand)
        {
            DataTable table;
            serlog(sqlCommand);
            using (SqlConnection connection = new SqlConnection(getstrConnection(null)))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    using (adapter.SelectCommand = new SqlCommand(sqlCommand, connection))
                    {
                        try
                        {
                            connection.Open();
                        }
                        catch (Exception exception)
                        {
                            Form1.WriteLine(100, "DBA数据层_错误" + exception.Message + " " + sqlCommand);
                            return null;
                        }
                        DataTable dataTable = new DataTable();
                        try
                        {
                            adapter.Fill(dataTable);
                        }
                        catch (Exception exception2)
                        {
                            Setlog(sqlCommand, null, exception2);
                        }
                        adapter.Dispose();
                        connection.Close();
                        connection.Dispose();
                        table = dataTable;
                    }
                }
            }
            return table;
        }

        public static DataTable GetDBToDataTable(string sqlCommand, SqlParameter[] prams)
        {
            DataTable table;
            serlog(sqlCommand, prams);
            using (SqlConnection connection = new SqlConnection(getstrConnection(null)))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    using (adapter.SelectCommand = SqlDBA.CreateCommandSql(connection, sqlCommand, prams))
                    {
                        try
                        {
                            connection.Open();
                        }
                        catch (Exception exception)
                        {
                            Form1.WriteLine(100, "DBA数据层_错误" + exception.Message + " " + sqlCommand);
                            return null;
                        }
                        DataTable dataTable = new DataTable();
                        try
                        {
                            adapter.Fill(dataTable);
                        }
                        catch (Exception exception2)
                        {
                            Setlog(sqlCommand, prams, exception2);
                        }
                        adapter.Dispose();
                        connection.Close();
                        connection.Dispose();
                        table = dataTable;
                    }
                }
            }
            return table;
        }

        public static DataTable GetDBToDataTable(string sqlCommand, string server)
        {
            DataTable table;
            serlog(sqlCommand);
            using (SqlConnection connection = new SqlConnection(getstrConnection(server)))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    using (adapter.SelectCommand = new SqlCommand(sqlCommand, connection))
                    {
                        try
                        {
                            connection.Open();
                        }
                        catch
                        {
                            return null;
                        }
                        DataTable dataTable = new DataTable();
                        try
                        {
                            adapter.Fill(dataTable);
                        }
                        catch (Exception exception)
                        {
                            Setlog(sqlCommand, null, exception);
                        }
                        adapter.Dispose();
                        connection.Close();
                        connection.Dispose();
                        table = dataTable;
                    }
                }
            }
            return table;
        }

        public static DataTable GetDBToDataTable(string sqlCommand, SqlParameter[] prams, string server)
        {
            DataTable table;
            serlog(sqlCommand, prams);
            using (SqlConnection connection = new SqlConnection(getstrConnection(server)))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    using (adapter.SelectCommand = SqlDBA.CreateCommandSql(connection, sqlCommand, prams))
                    {
                        try
                        {
                            connection.Open();
                        }
                        catch (Exception exception)
                        {
                            Form1.WriteLine(100, "DBA数据层_错误" + exception.Message + " " + sqlCommand);
                            return null;
                        }
                        DataTable dataTable = new DataTable();
                        try
                        {
                            adapter.Fill(dataTable);
                        }
                        catch (Exception exception2)
                        {
                            Setlog(sqlCommand, prams, exception2);
                        }
                        adapter.Dispose();
                        connection.Close();
                        connection.Dispose();
                        table = dataTable;
                    }
                }
            }
            return table;
        }

        public static DataRowCollection GetDBValue(string sqlCommand, string db)
        {
            return GetDBToDataTable(sqlCommand).Rows;
        }

        public static ArrayList GetDBValue_1(string sqlCommand, string db)
        {
            ArrayList list;
            serlog(sqlCommand);
            using (SqlConnection connection = new SqlConnection(getstrConnection(null)))
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    try
                    {
                        connection.Open();
                    }
                    catch
                    {
                        return null;
                    }
                    SqlDataReader reader = command.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        reader.Dispose();
                        connection.Close();
                        connection.Dispose();
                        return null;
                    }
                    ArrayList list2 = new ArrayList();
                    if (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; ++i)
                        {
                            list2.Add(reader[i]);
                        }
                    }
                    reader.Close();
                    reader.Dispose();
                    connection.Close();
                    connection.Dispose();
                    list = list2;
                }
            }
            return list;
        }

        public static ArrayList GetDBValue_2(string sqlCommand, string db)
        {
            ArrayList list;
            serlog(sqlCommand);
            using (SqlConnection connection = new SqlConnection(getstrConnection(null)))
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    try
                    {
                        connection.Open();
                    }
                    catch
                    {
                        return null;
                    }
                    SqlDataReader reader = command.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        reader.Dispose();
                        connection.Close();
                        connection.Dispose();
                        return null;
                    }
                    ArrayList list2 = new ArrayList();
                    while (reader.Read())
                    {
                        list2.Add(reader[0]);
                    }
                    reader.Close();
                    reader.Dispose();
                    connection.Close();
                    connection.Dispose();
                    list = list2;
                }
            }
            return list;
        }

        public static object GetDBValue_3(string sqlCommand)
        {
            object obj3;
            serlog(sqlCommand);
            object obj2 = null;
            using (SqlConnection connection = new SqlConnection(getstrConnection(null)))
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    try
                    {
                        connection.Open();
                    }
                    catch
                    {
                        return null;
                    }
                    try
                    {
                        obj2 = command.ExecuteScalar();
                    }
                    catch (Exception exception)
                    {
                        Form1.WriteLine(100, "DBA数据层_错误" + exception.Message + " " + sqlCommand);
                    }
                    command.Dispose();
                    connection.Close();
                    connection.Dispose();
                    obj3 = obj2;
                }
            }
            return obj3;
        }

        public static object GetDBValue_3(string sqlCommand, string db)
        {
            object obj3;
            serlog(sqlCommand);
            object obj2 = null;
            using (SqlConnection connection = new SqlConnection(getstrConnection(db)))
            {
                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    try
                    {
                        connection.Open();
                    }
                    catch
                    {
                        return null;
                    }
                    try
                    {
                        obj2 = command.ExecuteScalar();
                    }
                    catch (Exception exception)
                    {
                        Form1.WriteLine(100, "DBA数据层_错误" + exception.Message + " " + sqlCommand);
                    }
                    command.Dispose();
                    connection.Close();
                    connection.Dispose();
                    obj3 = obj2;
                }
            }
            return obj3;
        }

        public static object GetDBValue_3(string sqlCommand, SqlParameter[] prams)
        {
            object obj3;
            serlog(sqlCommand, prams);
            object obj2 = null;
            using (SqlConnection connection = new SqlConnection(getstrConnection(null)))
            {
                using (SqlCommand command = SqlDBA.CreateCommandSql(connection, sqlCommand, prams))
                {
                    try
                    {
                        connection.Open();
                    }
                    catch
                    {
                        return null;
                    }
                    try
                    {
                        obj2 = command.ExecuteScalar();
                    }
                    catch (Exception exception)
                    {
                        Form1.WriteLine(100, "DBA数据层_错误" + exception.Message + " " + sqlCommand);
                    }
                    command.Dispose();
                    connection.Close();
                    connection.Dispose();
                    obj3 = obj2;
                }
            }
            return obj3;
        }

        public static string getstrConnection(string db)
        {
            try
            {
                DbClass class2;
                if (db == null)
                {
                    db = "GameServer";
                }
                if (World.Db.TryGetValue(db, out class2))
                {
                    return class2.SqlConnect;
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
            if (sqlJl != "")
            {
                string[] strArray = sqlJl.Split(new char[] { '|' });
                for (int i = 0; i < strArray.Length; ++i)
                {
                    if (txt.ToLower().IndexOf(strArray[i].ToLower()) != -1)
                    {
                        Form1.WriteLine(99, txt);
                    }
                }
            }
        }

        public static void serlog(string txt, SqlParameter[] prams)
        {
            string sqlJl = World.SqlJl;
            if (sqlJl != "")
            {
                string[] strArray = sqlJl.Split(new char[] { '|' });
                for (int i = 0; i < strArray.Length; ++i)
                {
                    if (txt.ToLower().IndexOf(strArray[i].ToLower()) != -1)
                    {
                        Form1.WriteLine(99, txt);
                    }
                }
                for (int j = 0; j < strArray.Length; ++j)
                {
                    foreach (SqlParameter parameter in prams)
                    {
                        if (parameter.SqlValue.ToString().ToLower().IndexOf(strArray[j].ToLower()) != -1)
                        {
                            Form1.WriteLine(99, txt + " " + parameter.SqlValue.ToString());
                        }
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
                foreach (SqlParameter parameter in prams)
                {
                    Form1.WriteLine(100, parameter.SqlValue.ToString());
                }
            }
            Form1.WriteLine(100, ex.Message);
        }
    }
}


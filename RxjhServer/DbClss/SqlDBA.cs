namespace DbClss
{
    using RxjhServer;
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Runtime.InteropServices;

    public class SqlDBA
    {
        public static SqlCommand CreateCommand(SqlConnection conn, string procName, SqlParameter[] prams)
        {
            SqlCommand command = new SqlCommand(procName, conn);
            command.CommandType = CommandType.StoredProcedure;
            command.CommandTimeout = 180;
            if (prams != null)
            {
                foreach (SqlParameter parameter in prams)
                {
                    command.Parameters.Add(parameter);
                }
            }
            command.Parameters.Add(new SqlParameter("ReturnValue", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, 0, 0, string.Empty, DataRowVersion.Default, null));
            return command;
        }

        public static SqlCommand CreateCommandSql(SqlConnection conn, string procName, SqlParameter[] prams)
        {
            SqlCommand command = new SqlCommand(procName, conn);
            command.CommandType = CommandType.Text;
            command.CommandTimeout = 180;
            if (prams != null)
            {
                foreach (SqlParameter parameter in prams)
                {
                    command.Parameters.Add(parameter);
                }
            }
            command.Parameters.Add(new SqlParameter("ReturnValue", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, 0, 0, string.Empty, DataRowVersion.Default, null));
            return command;
        }

        public static SqlParameter MakeInParam(string ParamName, SqlDbType DbType, int Size, object Value)
        {
            return MakeParam(ParamName, DbType, Size, ParameterDirection.Input, Value);
        }

        public static SqlParameter MakeOutParam(string ParamName, SqlDbType DbType, int Size)
        {
            return MakeParam(ParamName, DbType, Size, ParameterDirection.Output, null);
        }

        public static SqlParameter MakeParam(string ParamName, SqlDbType DbType, int Size, ParameterDirection Direction, object Value)
        {
            SqlParameter parameter;
            if (Size > 0)
            {
                parameter = new SqlParameter(ParamName, DbType, Size);
            }
            else
            {
                parameter = new SqlParameter(ParamName, DbType);
            }
            parameter.Direction = Direction;
            if ((Direction != ParameterDirection.Output) || (Value != null))
            {
                parameter.Value = Value;
            }
            return parameter;
        }

        public static void RunProc(SqlConnection conn, string procName, out SqlDataReader dataReader)
        {
            dataReader = CreateCommand(conn, procName, null).ExecuteReader(CommandBehavior.CloseConnection);
        }

        public static int RunProc(SqlConnection conn, string procName, SqlParameter[] prams)
        {
            try
            {
                conn.Open();
            }
            catch (Exception exception)
            {
                Form1.WriteLine(100, "SqlDBA数据层_错误1" + exception.Message);
                return -1;
            }
            SqlCommand command = CreateCommand(conn, procName, prams);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception exception2)
            {
                Form1.WriteLine(100, "SqlDBA数据层_错误2" + exception2.Message);
                command.Parameters.Clear();
                return -1;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return (int) command.Parameters["ReturnValue"].Value;
        }

        public static void RunProc(SqlConnection conn, string procName, SqlParameter[] prams, out DataSet dataReader)
        {
            SqlCommand selectCommand = CreateCommand(conn, procName, prams);
            using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand))
            {
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                selectCommand.Parameters.Clear();
                conn.Close();
                conn.Dispose();
                dataReader = dataSet;
                adapter.Dispose();
            }
        }

        public static void RunProc(SqlConnection conn, string procName, SqlParameter[] prams, out SqlDataReader dataReader)
        {
            dataReader = CreateCommand(conn, procName, prams).ExecuteReader(CommandBehavior.CloseConnection);
        }

        public static DataTable RunProcc(SqlConnection conn, string procName, SqlParameter[] prams)
        {
            DataTable dataTable = new DataTable();
            SqlCommand selectCommand = CreateCommand(conn, procName, prams);
            using (SqlDataAdapter adapter = new SqlDataAdapter(selectCommand))
            {
                try
                {
                    adapter.Fill(dataTable);
                }
                catch (Exception)
                {
                }
                selectCommand.Parameters.Clear();
                adapter.Dispose();
                conn.Close();
                conn.Dispose();
            }
            return dataTable;
        }

        public static int RunProcSql(SqlConnection conn, string procName, SqlParameter[] prams)
        {
            int num = -1;
            try
            {
                conn.Open();
            }
            catch (Exception exception)
            {
                Form1.WriteLine(100, "SqlDBA数据层_错误3" + exception.Message);
                return num;
            }
            SqlCommand command = CreateCommandSql(conn, procName, prams);
            try
            {
                num = command.ExecuteNonQuery();
            }
            catch (Exception exception2)
            {
                Form1.WriteLine(100, "SqlDBA数据层_错误4" + exception2.Message);
                command.Parameters.Clear();
                return num;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return num;
        }
    }
}


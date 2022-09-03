using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using DbClss;
using HelperTools;
using RxjhServer;
using RxjhServer.RxjhServer;

namespace YulgangServer.RxjhServer.DbClss
{
    public class RxjhClass
    {
        private static ItmesIDClass _itmeId;

        static RxjhClass()
        {
            old_acctor_mc();
        }

        public static int GetCwUserName(string name, string zrname, int type, long id)
        {
            string sqlCommand = string.Format("SELECT Name FROM TBL_XWWL_Cw WHERE Name=@name");
            SqlParameter[] prams = new SqlParameter[] { SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name) };
            DataTable dBToDataTable = DBA.GetDBToDataTable(sqlCommand, prams);
            if (dBToDataTable != null)
            {
                if (dBToDataTable.Rows.Count == 0)
                {
                    dBToDataTable.Dispose();
                    string str2 = string.Format("EXEC XWWL_INT_Cw_DATA @zrname,@name,@id,@type,@zb1,@zb2", new object[] { zrname, name, id, type, Converter.ToString(new byte[292]), Converter.ToString(new byte[1168]) });
                    SqlParameter[] parameterArray4 = new SqlParameter[] { SqlDBA.MakeInParam("@zrname", SqlDbType.VarChar, 30, zrname), SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name), SqlDBA.MakeInParam("@id", SqlDbType.Int, 0, id), SqlDBA.MakeInParam("@type", SqlDbType.Int, 0, type), SqlDBA.MakeInParam("@zb1", SqlDbType.VarBinary, 292, new byte[292]), SqlDBA.MakeInParam("@zb2", SqlDbType.VarBinary, 1168, new byte[1168]) };
                    if (DBA.ExeSqlCommand(str2, parameterArray4) != -1)
                    {
                        return 1;
                    }
                    return -1;
                }
                dBToDataTable.Dispose();
            }
            return -1;
        }

        public static long GetDbItmeId()
        {
            return _itmeId.AcquireBuffer();
        }

        public static int smethod_21(string string0)
        {
            string string_ = string.Format("SELECT FLD_NAME FROM TBL_XWWL_Char WHERE FLD_NAME=@name", new object[0]);
            SqlParameter[] sqlParameter = {
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string0)
			};
            DataTable dataTable = DBA.GetDBToDataTable(string_, sqlParameter);
            int result;
            if (dataTable != null)
            {
                if (dataTable.Rows.Count == 0)
                {
                    dataTable.Dispose();
                    result = 1;
                    return result;
                }
                dataTable.Dispose();
            }
            result = -1;
            return result;
        }
        public static int GetUserName(string name)
        {
            string sqlCommand = string.Format("SELECT FLD_NAME FROM TBL_XWWL_Char WHERE FLD_NAME=@name", new object[0]);
            SqlParameter[] prams = new SqlParameter[] { SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name) };
            DataTable dBToDataTable = DBA.GetDBToDataTable(sqlCommand, prams);
            if (dBToDataTable != null)
            {
                if (dBToDataTable.Rows.Count == 0)
                {
                    dBToDataTable.Dispose();
                    return 1;
                }
                dBToDataTable.Dispose();
            }
            return -1;
        }

        public static DataTable GetUserNameBp(string name)
        {
            string sqlCommand = string.Format("EXEC XWWL_LOAD_Guild @name", new object[0]);
            SqlParameter[] prams = new SqlParameter[] { SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name) };
            DataTable dBToDataTable = DBA.GetDBToDataTable(sqlCommand, prams);
            if (dBToDataTable == null)
            {
                return null;
            }
            if (dBToDataTable.Rows.Count == 0)
            {
                return null;
            }
            return dBToDataTable;
        }

        public static DataTable GetUserPublicWarehouse(string userid)
        {
            string sqlCommand = string.Format("select * from [TBL_XWWL_PublicWarehouse] where FLD_ID=@Userid", new object[0]);
            SqlParameter[] prams = new SqlParameter[] { SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, userid) };
            DataTable dBToDataTable = DBA.GetDBToDataTable(sqlCommand, prams);
            if (dBToDataTable == null)
            {
                return null;
            }
            if (dBToDataTable.Rows.Count != 0)
            {
                return dBToDataTable;
            }
            Converter.ToString1(new byte[60 * (World.Newversion >= 14 ? 76 : 73)]);
            Converter.ToString1(new byte[50]);
            string str2 = string.Format("EXEC XWWL_CREATE_ID_BANK @Userid,@aaa,@ck,@ck1", new object[0]);
            SqlParameter[] parameterArray4 = new SqlParameter[] { SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, userid), SqlDBA.MakeInParam("@aaa", SqlDbType.Int, 0, 0), SqlDBA.MakeInParam("@ck", SqlDbType.VarBinary, 60 * (World.Newversion >= 14 ? 76 : 73), new byte[60 * (World.Newversion >= 14 ? 76 : 73)]), SqlDBA.MakeInParam("@ck1", SqlDbType.VarBinary, 50, new byte[50]) };
            DBA.ExeSqlCommand(str2, parameterArray4);
            string str3 = string.Format("select * from [TBL_XWWL_PublicWarehouse] where FLD_ID='{0}'", userid);
            SqlParameter[] parameterArray6 = new SqlParameter[] { SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, userid) };
            DataTable table2 = DBA.GetDBToDataTable(str3, parameterArray6);
            if (table2 == null)
            {
                return null;
            }
            if (table2.Rows.Count == 0)
            {
                return null;
            }
            return table2;
        }

        public static DataTable GetUserWarehouse(string userid, string username)
        {
            string sqlCommand = string.Format("select * from [TBL_XWWL_Warehouse] where FLD_ID=@Userid and FLD_NAME =@Username", new object[0]);
            SqlParameter[] prams = new SqlParameter[] { SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, userid), SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, username) };
            DataTable dBToDataTable = DBA.GetDBToDataTable(sqlCommand, prams);
            if (dBToDataTable == null)
            {
                return null;
            }
            if (dBToDataTable.Rows.Count != 0)
            {
                return dBToDataTable;
            }
            string str2 = string.Format("EXEC XWWL_CREATE_USER_BANK @Userid,@Username,@aa,@zb", new object[0]);
            SqlParameter[] parameterArray4 = new SqlParameter[] { SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, userid), SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, username), SqlDBA.MakeInParam("@aa", SqlDbType.Int, 0, 0), SqlDBA.MakeInParam("@zb", SqlDbType.VarBinary, 60 * (World.Newversion >= 14 ? 76 : 73), new byte[60 * (World.Newversion >= 14 ? 76 : 73)]) };
            DBA.ExeSqlCommand(str2, parameterArray4);
            string str3 = string.Format("select * from [TBL_XWWL_Warehouse] where FLD_ID=@Userid and FLD_NAME =@Username", new object[0]);
            SqlParameter[] parameterArray6 = new SqlParameter[] { SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, userid), SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, username) };
            DataTable table2 = DBA.GetDBToDataTable(str3, parameterArray6);
            if (table2 == null)
            {
                return null;
            }
            if (table2.Rows.Count == 0)
            {
                return null;
            }
            return table2;
        }

        public static string Md5(string strmm)
        {
            MD5 md = new MD5CryptoServiceProvider();
            return BitConverter.ToString(md.ComputeHash(Encoding.ASCII.GetBytes(strmm))).Replace("-", "").ToLower();
        }

        public static void Msglog(string userid, string username, string tousername, string msg, int msgType)
        {
            DBA.ExeSqlCommand(string.Format("INSERT INTO MsgLog (userid,username,ToUserName,msg,msgType) VALUES ('{0}','{1}','{2}','{3}',{4})", new object[] { userid, username, tousername, msg, msgType }));
        }

        private static void old_acctor_mc()
        {
            _itmeId = new ItmesIDClass();
        }

        public static int SetUserName(string id, string name, int zy, byte[] coue)
        {
            byte[] dst = new byte[(World.Newversion>=14?76:73)];
            byte[] buffer2 = new byte[15 * (World.Newversion >= 14 ? 76 : 73)];
            byte[] buffer3 = new byte[36 * (World.Newversion >= 14 ? 76 : 73)];
            byte[] bytes = BitConverter.GetBytes(GetDbItmeId());
            byte[] src = new byte[4];
            byte[] buffer6;
            buffer6 = BitConverter.GetBytes(1);
            switch (zy)
            {
                case 1:
                    src = BitConverter.GetBytes(100200001);
                    break;

                case 2:
                    src = BitConverter.GetBytes(200200001);
                    break;

                case 3:
                    src = BitConverter.GetBytes(300200001);
                    break;

                case 4:
                    src = BitConverter.GetBytes(400200001);
                    break;

                case 5:
                    src = BitConverter.GetBytes(500200001);
                    break;

                case 6:
                    src = BitConverter.GetBytes(700200001);
                    break;

                case 7:
                    src = BitConverter.GetBytes(800200001);
                    break;

                case 8:
                    src = BitConverter.GetBytes(100204001);
                    break;

                case 9:
                    src = BitConverter.GetBytes(200204001);
                    break;

                case 10:
                    src = BitConverter.GetBytes(900200001);
                    break;

                case 11:
                    src = BitConverter.GetBytes(400204001);
                    break;
            }
            Buffer.BlockCopy(bytes, 0, dst, 0, 4);
            Buffer.BlockCopy(src, 0, dst, 8, 4);
            Buffer.BlockCopy(buffer6, 0, dst, 12, 4);
            Buffer.BlockCopy(dst, 0, buffer3, 0, 73);


            if (World.上线送礼包是否开启 == 1)
            {
                byte[] buffer7 = new byte[(World.Newversion>=14?76:73)];
                byte[] buffer8 = BitConverter.GetBytes(GetDbItmeId());
                byte[] buffer9 = BitConverter.GetBytes(World.上线送礼包套装);
                byte[] buffer10 = (BitConverter.GetBytes(1)); 
                Buffer.BlockCopy(buffer8, 0, buffer7, 0, 4);
                Buffer.BlockCopy(buffer9, 0, buffer7, 8, 4);
                Buffer.BlockCopy(buffer6, 0, buffer7, 12, 4);
                Buffer.BlockCopy(buffer10, 0, buffer7, 72, 1);//lock

                Buffer.BlockCopy(buffer7, 0, buffer3, (World.Newversion >= 14 ? 76 : 73), (World.Newversion >= 14 ? 76 : 73));
            }
            int num3 = 0;
            for (int i = 0; i < 4; ++i)
            {
                string str3 = string.Format("Select FLD_INDEX FROM TBL_XWWL_Char Where FLD_ID=@FLD_ID and FLD_INDEX=@INDEX", new object[0]);
                SqlParameter[] parameterArray6 = new SqlParameter[] { SqlDBA.MakeInParam("@INDEX", SqlDbType.Int, 0, i), SqlDBA.MakeInParam("@FLD_ID", SqlDbType.VarChar, 30, id) };
                DataTable table = DBA.GetDBToDataTable(str3, parameterArray6);
                if (table.Rows.Count == 0)
                {
                    num3 = i;
                    table.Dispose();
                    break;
                }
                table.Dispose();
            }
            string sqlCommand = string.Format("Select FLD_INDEX FROM TBL_XWWL_Char Where FLD_ID=@FLD_ID", new object[0]);
            SqlParameter[] prams = new SqlParameter[] { SqlDBA.MakeInParam("@FLD_ID", SqlDbType.VarChar, 30, id) };
            DataTable dBToDataTable = DBA.GetDBToDataTable(sqlCommand, prams);
            if (dBToDataTable.Rows.Count >= 4)
            {
                dBToDataTable.Dispose();
                return -1;
            }
            dBToDataTable.Dispose();
            string str2 = string.Format("EXEC XWWL_INT_USER_DATA @FLD_ID,@name,@rwid,@zy,@coue,@xrwhex,@xrwhex2", new object[0]);
            SqlParameter[] parameterArray4 = new SqlParameter[] { SqlDBA.MakeInParam("@FLD_ID", SqlDbType.VarChar, 30, id), SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name), SqlDBA.MakeInParam("@rwid", SqlDbType.Int, 0, num3), SqlDBA.MakeInParam("@zy", SqlDbType.Int, 0, zy), SqlDBA.MakeInParam("@coue", SqlDbType.VarBinary, 10, coue), SqlDBA.MakeInParam("@xrwhex", SqlDbType.VarBinary, buffer2.Length, buffer2), SqlDBA.MakeInParam("@xrwhex2", SqlDbType.VarBinary, buffer3.Length, buffer3) };
            if (DBA.ExeSqlCommand(str2, parameterArray4) != -1)
            {
                return 1;
            }
            return -1;
        }

        public static void GhilogPk(string player1, string player2)
        {
            DBA.ExeSqlCommand(string.Format("INSERT INTO LogPK (Nguoigiet,Nguoibigiet) VALUES ('{0}','{1}')", new object[] { player1, player2 }));
        }
        public static void GhiLogDelItem(int maItem, int idItem, int levelItem, Players player)
        {
            DBA.ExeSqlCommand(string.Format("INSERT INTO Log_DeleteItem (MaItem,IDItem,LevelItem,Username) VALUES ('{0}','{1}','{2}','{3}')", new object[] { maItem, idItem, levelItem, player.UserName }));
        }
        public static void 百宝记录(string userId, string userName, double 物品id, string 物品名, int 物品数量, int 元宝数)
        {
            DBA.ExeSqlCommand(string.Format("INSERT INTO 百宝记录 (UserId,UserName,物品ID,物品名,物品数量,元宝数) VALUES ('{0}','{1}','{2}','{3}',{4},{5})", new object[] { userId, userName, 物品id, 物品名, 物品数量, 元宝数 }));
        }

        public static void 帮派赋予职位(int zw, string name)
        {
            string sqlCommand = string.Format("UPDATE TBL_XWWL_GuildMember SET Leve=@zw WHERE Name=@Username", new object[0]);
            SqlParameter[] prams = new SqlParameter[] { SqlDBA.MakeInParam("@zw", SqlDbType.Int, 0, zw), SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, name) };
            DBA.ExeSqlCommand(sqlCommand, prams);
        }

        public static void AddGuildPoint(int point, string name)
        {
            string sqlCommand = string.Format("UPDATE TBL_XWWL_GuildMember SET FLD_GuildPoint=FLD_GuildPoint+@point WHERE Name=@Username", new object[0]);
            SqlParameter[] prams = new SqlParameter[] { SqlDBA.MakeInParam("@point", SqlDbType.Int, 0, point), SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, name) };
            DBA.ExeSqlCommand(sqlCommand, prams);
        }

        public static void 帮战赌注(string userId, string userName, int guildId, int 元宝数)
        {
            DBA.ExeSqlCommand(string.Format("INSERT INTO 帮战赌注 (UserId,UserName,帮派ID,元宝数) VALUES ('{0}','{1}',{2},{3})", new object[] { userId, userName, guildId, 元宝数 }));
        }

        public static DataTable Check_Email_Name(string string0)
        {
            string string_ = string.Format("SELECT * FROM TBL_传书系统 WHERE 接收人物名 =@name", new object[0]);
            SqlParameter[] sqlParameter = new SqlParameter[]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string0)
			};
            DataTable dataTable = DBA.GetDBToDataTable(string_, sqlParameter);
            DataTable result;
            if (dataTable == null)
            {
                result = null;
            }
            else
            {
                if (dataTable.Rows.Count == 0)
                {
                    result = null;
                }
                else
                {
                    result = dataTable;
                }
            }
            return result;
        }
        public static void Update_Email_Read(int id, int num)
        {
            string string_ = string.Format("UPDATE TBL_传书系统 SET 阅读标识=@rd WHERE ID=@id", new object[0]);
            SqlParameter[] sqlParameter = new SqlParameter[]
			{
				SqlDBA.MakeInParam("@rd", SqlDbType.Int, 0, num),
				SqlDBA.MakeInParam("@id", SqlDbType.Int, 30, id)
			};
            DBA.ExeSqlCommand(string_, sqlParameter);
        }
        public static void Delete_Email(int id, string name)
        {
            string string_ = string.Format("DELETE TBL_传书系统 WHERE ID=@id and 接收人物名=@name", new object[0]);
            SqlParameter[] sqlParameter = new SqlParameter[]
			{
				SqlDBA.MakeInParam("@id", SqlDbType.Int, 30, id),
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 50, name)
			};
            DBA.ExeSqlCommand(string_, sqlParameter);
        }
        public static void INSERT_Email(string string0, string string1, int int0, string string2)
        {
            string string3 = string.Format("EXEC INT_CS_DATA_New @fname, @sname, @msg, @npcid", new object[0]);
            SqlParameter[] sqlParameter = new SqlParameter[]
			{
				SqlDBA.MakeInParam("@fname", SqlDbType.VarChar, 30, string0),
				SqlDBA.MakeInParam("@sname", SqlDbType.VarChar, 30, string1),
				SqlDBA.MakeInParam("@msg", SqlDbType.VarChar, 2000, string2),
				SqlDBA.MakeInParam("@npcid", SqlDbType.Int, 0, int0)
			};
            DBA.GetDBValue_3(string3, sqlParameter);
        }
        public static void 帮战赌注删除(string userId, string userName, int guildId, int sl)
        {
            DBA.ExeSqlCommand(string.Format("DELETE FROM 帮战赌注 WHERE UserId = '{0}' and UserName='{1}' and UserName='{2}'", userId, userName, guildId));
            if (sl == 1)
            {
                DBA.ExeSqlCommand(string.Format("UPDATE TBL_XWWL_Guild SET 胜=胜+1 WHERE ID='{0}'", guildId));
                //百宝记录(UserId, UserName, 0.0, "帮战胜利得到", 1, 50);
            }
            else if (sl == -1)
            {
                DBA.ExeSqlCommand(string.Format("UPDATE TBL_XWWL_Guild SET 败=败+1 WHERE ID='{0}'", guildId));
                //百宝记录(UserId, UserName, 0.0, "帮战失败输掉", 1, 50);
            }
            else if (sl == 0)
            {
                DBA.ExeSqlCommand(string.Format("UPDATE TBL_XWWL_Guild SET 平=平+1 WHERE ID='{0}'", guildId));
            }
        }

        public static bool smethod_31(string string0, string string1)
        {
            DataTable dataTable = DBA.GetDBToDataTable(string.Format("select * from [TBL_ACCOUNT] where FLD_ID='{0}'", string0), "rxjhaccount");
            if (dataTable == null)
            {
                string string2 = string.Format("delete [TBL_XWWL_CHAR] WHERE FLD_ID ='{0}' and FLD_NAME='{1}'", string0, string1);
                string string3 = string.Format("delete [TBL_TBL_XWWL_Warehouse] WHERE FLD_ID ='{0}' and FLD_NAME='{1}'", string0, string1);
                if (DBA.ExeSqlCommand(string2, "rxjhgame") != -1)
                {
                    DBA.ExeSqlCommand(string3, "rxjhgame");
                    return true;
                }
            }
            return false;
        }

        public static void 变更门服(int guildId, int 门服字, int 门服颜色)
        {
            DBA.ExeSqlCommand(string.Format("UPDATE TBL_XWWL_Guild SET 门服字={1},门服颜色={2} WHERE ID='{0}'", guildId, 门服字, 门服颜色));
        }

        public static int 创建帮派(string name, string 帮派name, int leve)
        {
            string sqlCommand = string.Format("EXEC XWWL_INT_Guild_DATA_New @name, @bpname,@leve", new object[0]);
            SqlParameter[] prams = new SqlParameter[] { SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name), SqlDBA.MakeInParam("@bpname", SqlDbType.VarChar, 30, 帮派name), SqlDBA.MakeInParam("@leve", SqlDbType.Int, 0, leve) };
            return (int) DBA.GetDBValue_3(sqlCommand, prams);
        }

        public static int 创建帮派确认(string 帮派name)
        {
            string sqlCommand = string.Format("EXEC XWWL_SELECT_Guild_DATA @bpnamea", new object[0]);
            SqlParameter[] prams = new SqlParameter[] { SqlDBA.MakeInParam("@bpnamea", SqlDbType.VarChar, 30, 帮派name) };
            return (int) DBA.GetDBValue_3(sqlCommand, prams);
        }

        public static DataTable 得到帮派人数(string name)
        {
            string sqlCommand = string.Format("SELECT * FROM TBL_XWWL_GuildMember WHERE G_Name =@name", new object[0]);
            SqlParameter[] prams = new SqlParameter[] { SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name) };
            DataTable dBToDataTable = DBA.GetDBToDataTable(sqlCommand, prams);
            if (dBToDataTable == null)
            {
                return null;
            }
            if (dBToDataTable.Rows.Count == 0)
            {
                return null;
            }
            return dBToDataTable;
        }

        public static DataTable 得到帮派数据(string name)
        {
            string sqlCommand = string.Format("SELECT * FROM TBL_XWWL_Guild WHERE G_Name = @name", new object[0]);
            SqlParameter[] prams = new SqlParameter[] { SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name) };
            DataTable dBToDataTable = DBA.GetDBToDataTable(sqlCommand, prams);
            if (dBToDataTable == null)
            {
                return null;
            }
            if (dBToDataTable.Rows.Count == 0)
            {
                return null;
            }
            return dBToDataTable;
        }

        public static byte[] 得到门徽(int id)
        {
            try
            {
                DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TBL_XWWL_Guild WHERE ID = {0}", id));
                if (dBToDataTable.Rows.Count != 0)
                {
                    if (dBToDataTable.Rows[0]["门徽"].GetType().ToString() == "System.DBNull")
                    {
                        return null;
                    }
                    byte[] buffer2 = (byte[]) dBToDataTable.Rows[0]["门徽"];
                    if (buffer2 != null)
                    {
                        return buffer2;
                    }
                }
                return null;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return null;
            }
        }

        public static void 登陆记录(string userId, string userName, string userIp, string 类型, string userMac="", string userIpLan="")
        {
            if (World.登陆记录 == 1)
            {
                string str = string.Format("INSERT INTO 登陆记录 (UserId,UserName,UserIp,类型,UserMac,UserIPLan) VALUES (@UserId,@UserName,@UserIp,@类型,@UserMac,@UserIPLan)", new object[0]);
                SqlParameter[] parameterArray2 = new SqlParameter[] { SqlDBA.MakeInParam("@UserId", SqlDbType.VarChar, 30, userId), SqlDBA.MakeInParam("@UserName", SqlDbType.VarChar, 30, userName), SqlDBA.MakeInParam("@UserIp", SqlDbType.VarChar, 30, userIp), SqlDBA.MakeInParam("@类型", SqlDbType.VarChar, 30, 类型), SqlDBA.MakeInParam("@UserMac", SqlDbType.VarChar, 30, userMac), SqlDBA.MakeInParam("@UserIPLan", SqlDbType.VarChar, 30, userIpLan) };
                DbPoolClass class2 = new DbPoolClass();
                class2.Conn = DBA.getstrConnection(null);
                class2.Prams = parameterArray2;
                class2.Sql = str;
                class2.Type = 1;
                World.SqlPool.Enqueue(class2);
            }
        }

        public static int 加入帮派(string name, string 帮派name, int leve)
        {
            string sqlCommand = string.Format("EXEC XWWL_JR_Guild_DATA_New @name, @bpname,@leve");
            SqlParameter[] prams = new SqlParameter[] { SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name), SqlDBA.MakeInParam("@bpname", SqlDbType.VarChar, 30, 帮派name), SqlDBA.MakeInParam("@leve", SqlDbType.Int, 0, leve) };
            return (int) DBA.GetDBValue_3(sqlCommand, prams);
        }

        public static void 申请门徽(int guildId, byte[] 门徽)
        {
            DBA.ExeSqlCommand(string.Format("UPDATE TBL_XWWL_Guild SET 门徽={1} WHERE ID='{0}'", guildId, Converter.ToString1(门徽)));
        }

        public static int 退出门派(string name)
        {
            string sqlCommand = string.Format("EXEC XWWL_Out_Guild_DATA @name", new object[0]);
            SqlParameter[] prams = new SqlParameter[] { SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name) };
            return (int) DBA.GetDBValue_3(sqlCommand, prams);
        }

        public static void 物品记录(string userId, string userName, string toUserId, string toUserName, double 全局id, int 物品id, string 物品名, int 物品数量, string 物品属性, int 钱数, string 类型)
        {
            if (World.物品记录 == 1)
            {
                if (物品id ==1000000545)
                {
                    foreach (Players play in World.AllConnectedChars.Values)
                    {
                        if (play.UserName == userName)
                        {
                            play.Item_1000000545_Count -= 物品数量;
                        }
                        else if (play.UserName == toUserName)
                        {
                            play.Item_1000000545_Count += 物品数量;
                        }
                    }
                }
                string str = string.Format("INSERT INTO 物品记录 (UserId,UserName,ToUserId,ToUserName,全局ID,物品ID,物品名,物品数量,物品属性,钱数,类型) VALUES (@UserId,@UserName,@ToUserId,@ToUserName,@全局ID,@物品ID,@物品名,@物品数量,@物品属性,@钱数,@类型)", new object[0]);
                SqlParameter[] parameterArray2 = new SqlParameter[] { SqlDBA.MakeInParam("@UserId", SqlDbType.VarChar, 30, userId), SqlDBA.MakeInParam("@UserName", SqlDbType.VarChar, 30, userName), SqlDBA.MakeInParam("@ToUserId", SqlDbType.VarChar, 30, toUserId), SqlDBA.MakeInParam("@ToUserName", SqlDbType.VarChar, 30, toUserName), SqlDBA.MakeInParam("@全局ID", SqlDbType.VarChar, 30, 全局id), SqlDBA.MakeInParam("@物品ID", SqlDbType.VarChar, 30, 物品id), SqlDBA.MakeInParam("@物品名", SqlDbType.VarChar, 30, 物品名), SqlDBA.MakeInParam("@物品数量", SqlDbType.Int, 4, 物品数量), SqlDBA.MakeInParam("@物品属性", SqlDbType.VarChar, 100, 物品属性), SqlDBA.MakeInParam("@钱数", SqlDbType.Int, 4, 钱数), SqlDBA.MakeInParam("@类型", SqlDbType.VarChar, 10, 类型) };
                DbPoolClass class2 = new DbPoolClass();
                class2.Conn = DBA.getstrConnection(null);
                class2.Prams = parameterArray2;
                class2.Sql = str;
                class2.Type = 1;
                World.SqlPool.Enqueue(class2);
            }
        }

        public static int 逐出门派(string name, string 帮派name)
        {
            string sqlCommand = string.Format("EXEC XWWL_OutBz_Guild_DATA @name, @bpname", new object[0]);
            SqlParameter[] prams = new SqlParameter[] { SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name), SqlDBA.MakeInParam("@bpname", SqlDbType.VarChar, 30, 帮派name) };
            return (int) DBA.GetDBValue_3(sqlCommand, prams);
        }
    }
}


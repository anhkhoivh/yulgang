using DbClss;
using HelperTools;
using RxjhServer;
using RxjhServer.RxjhServer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

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
			string sqlCommand = $"SELECT Name FROM TBL_XWWL_Cw WHERE Name=@name";
			SqlParameter[] prams = new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name)
			};
			DataTable dBToDataTable = DBA.GetDBToDataTable(sqlCommand, prams);
			if (dBToDataTable != null)
			{
				if (dBToDataTable.Rows.Count == 0)
				{
					dBToDataTable.Dispose();
					string sqlCommand2 = string.Format("EXEC XWWL_INT_Cw_DATA @zrname,@name,@id,@type,@zb1,@zb2", zrname, name, id, type, Converter.ToString(new byte[292]), Converter.ToString(new byte[1168]));
					SqlParameter[] prams2 = new SqlParameter[6]
					{
						SqlDBA.MakeInParam("@zrname", SqlDbType.VarChar, 30, zrname),
						SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name),
						SqlDBA.MakeInParam("@id", SqlDbType.Int, 0, id),
						SqlDBA.MakeInParam("@type", SqlDbType.Int, 0, type),
						SqlDBA.MakeInParam("@zb1", SqlDbType.VarBinary, 292, new byte[292]),
						SqlDBA.MakeInParam("@zb2", SqlDbType.VarBinary, 1168, new byte[1168])
					};
					if (DBA.ExeSqlCommand(sqlCommand2, prams2) != -1)
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
			string sqlCommand = $"SELECT FLD_NAME FROM TBL_XWWL_Char WHERE FLD_NAME=@name";
			SqlParameter[] prams = new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string0)
			};
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

		public static int GetUserName(string name)
		{
			string sqlCommand = $"SELECT FLD_NAME FROM TBL_XWWL_Char WHERE FLD_NAME=@name";
			SqlParameter[] prams = new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name)
			};
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
			string sqlCommand = $"EXEC XWWL_LOAD_Guild @name";
			SqlParameter[] prams = new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name)
			};
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
			string sqlCommand = $"select * from [TBL_XWWL_PublicWarehouse] where FLD_ID=@Userid";
			SqlParameter[] prams = new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, userid)
			};
			DataTable dBToDataTable = DBA.GetDBToDataTable(sqlCommand, prams);
			if (dBToDataTable == null)
			{
				return null;
			}
			if (dBToDataTable.Rows.Count != 0)
			{
				return dBToDataTable;
			}
			Converter.ToString1(new byte[60 * ((World.Newversion >= 14) ? 76 : 73)]);
			Converter.ToString1(new byte[50]);
			string sqlCommand2 = $"EXEC XWWL_CREATE_ID_BANK @Userid,@aaa,@ck,@ck1";
			SqlParameter[] prams2 = new SqlParameter[4]
			{
				SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, userid),
				SqlDBA.MakeInParam("@aaa", SqlDbType.Int, 0, 0),
				SqlDBA.MakeInParam("@ck", SqlDbType.VarBinary, 60 * ((World.Newversion >= 14) ? 76 : 73), new byte[60 * ((World.Newversion >= 14) ? 76 : 73)]),
				SqlDBA.MakeInParam("@ck1", SqlDbType.VarBinary, 50, new byte[50])
			};
			DBA.ExeSqlCommand(sqlCommand2, prams2);
			string sqlCommand3 = $"select * from [TBL_XWWL_PublicWarehouse] where FLD_ID='{userid}'";
			SqlParameter[] prams3 = new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, userid)
			};
			DataTable dBToDataTable2 = DBA.GetDBToDataTable(sqlCommand3, prams3);
			if (dBToDataTable2 == null)
			{
				return null;
			}
			if (dBToDataTable2.Rows.Count == 0)
			{
				return null;
			}
			return dBToDataTable2;
		}

		public static DataTable GetUserWarehouse(string userid, string username)
		{
			string sqlCommand = $"select * from [TBL_XWWL_Warehouse] where FLD_ID=@Userid and FLD_NAME =@Username";
			SqlParameter[] prams = new SqlParameter[2]
			{
				SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, userid),
				SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, username)
			};
			DataTable dBToDataTable = DBA.GetDBToDataTable(sqlCommand, prams);
			if (dBToDataTable == null)
			{
				return null;
			}
			if (dBToDataTable.Rows.Count != 0)
			{
				return dBToDataTable;
			}
			string sqlCommand2 = $"EXEC XWWL_CREATE_USER_BANK @Userid,@Username,@aa,@zb";
			SqlParameter[] prams2 = new SqlParameter[4]
			{
				SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, userid),
				SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, username),
				SqlDBA.MakeInParam("@aa", SqlDbType.Int, 0, 0),
				SqlDBA.MakeInParam("@zb", SqlDbType.VarBinary, 60 * ((World.Newversion >= 14) ? 76 : 73), new byte[60 * ((World.Newversion >= 14) ? 76 : 73)])
			};
			DBA.ExeSqlCommand(sqlCommand2, prams2);
			string sqlCommand3 = $"select * from [TBL_XWWL_Warehouse] where FLD_ID=@Userid and FLD_NAME =@Username";
			SqlParameter[] prams3 = new SqlParameter[2]
			{
				SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, userid),
				SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, username)
			};
			DataTable dBToDataTable2 = DBA.GetDBToDataTable(sqlCommand3, prams3);
			if (dBToDataTable2 == null)
			{
				return null;
			}
			if (dBToDataTable2.Rows.Count == 0)
			{
				return null;
			}
			return dBToDataTable2;
		}

		public static string Md5(string strmm)
		{
			MD5 mD = new MD5CryptoServiceProvider();
			return BitConverter.ToString(mD.ComputeHash(Encoding.ASCII.GetBytes(strmm))).Replace("-", "").ToLower();
		}

		public static void Msglog(string userid, string username, string tousername, string msg, int msgType)
		{
			DBA.ExeSqlCommand($"INSERT INTO MsgLog (userid,username,ToUserName,msg,msgType) VALUES ('{userid}','{username}','{tousername}','{msg}',{msgType})");
		}

		private static void old_acctor_mc()
		{
			_itmeId = new ItmesIDClass();
		}

		public static int SetUserName(string id, string name, int zy, byte[] coue)
		{
			byte[] array = new byte[16 * ((World.Newversion >= 14) ? 76 : 73)];
			byte[] array2 = new byte[36 * ((World.Newversion >= 14) ? 76 : 73)];
			byte[] array3 = new byte[(World.Newversion >= 14) ? 76 : 73];
			byte[] src = new byte[4];
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
			case 12:
				src = BitConverter.GetBytes(300204001);
				break;
			}
			Buffer.BlockCopy(BitConverter.GetBytes(GetDbItmeId()), 0, array3, 0, 4);
			Buffer.BlockCopy(src, 0, array3, 8, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(1), 0, array3, 12, 4);
			Buffer.BlockCopy(array3, 0, array2, 0, (World.Newversion >= 14) ? 76 : 73);
			if (World.上线送礼包是否开启 == 1)
			{
				byte[] array4 = new byte[(World.Newversion >= 14) ? 76 : 73];
				Buffer.BlockCopy(BitConverter.GetBytes(GetDbItmeId()), 0, array4, 0, 4);
				Buffer.BlockCopy(BitConverter.GetBytes(World.上线送礼包套装), 0, array4, 8, 4);
				Buffer.BlockCopy(BitConverter.GetBytes(1), 0, array4, 12, 4);
				Buffer.BlockCopy(BitConverter.GetBytes(1), 0, array4, 72, 1);
				Buffer.BlockCopy(array4, 0, array2, (World.Newversion >= 14) ? 76 : 73, (World.Newversion >= 14) ? 76 : 73);
			}
			if (zy == 4 || zy == 11)
			{
				byte[] array5 = new byte[(World.Newversion >= 14) ? 76 : 73];
				Buffer.BlockCopy(BitConverter.GetBytes(GetDbItmeId()), 0, array5, 0, 4);
				Buffer.BlockCopy(BitConverter.GetBytes(1000000148), 0, array5, 8, 4);
				Buffer.BlockCopy(BitConverter.GetBytes(1000), 0, array5, 12, 4);
				Buffer.BlockCopy(array5, 0, array2, ((World.Newversion >= 14) ? 76 : 73) * 2, (World.Newversion >= 14) ? 76 : 73);
			}
			int num = 0;
			for (int i = 0; i < 4; i++)
			{
				string sqlCommand = $"Select FLD_INDEX FROM TBL_XWWL_Char Where FLD_ID=@FLD_ID and FLD_INDEX=@INDEX";
				SqlParameter[] prams = new SqlParameter[2]
				{
					SqlDBA.MakeInParam("@INDEX", SqlDbType.Int, 0, i),
					SqlDBA.MakeInParam("@FLD_ID", SqlDbType.VarChar, 30, id)
				};
				DataTable dBToDataTable = DBA.GetDBToDataTable(sqlCommand, prams);
				if (dBToDataTable.Rows.Count == 0)
				{
					num = i;
					dBToDataTable.Dispose();
					break;
				}
				dBToDataTable.Dispose();
			}
			string sqlCommand2 = $"Select FLD_INDEX FROM TBL_XWWL_Char Where FLD_ID=@FLD_ID";
			SqlParameter[] prams2 = new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@FLD_ID", SqlDbType.VarChar, 30, id)
			};
			DataTable dBToDataTable2 = DBA.GetDBToDataTable(sqlCommand2, prams2);
			if (dBToDataTable2.Rows.Count >= 4)
			{
				dBToDataTable2.Dispose();
				return -1;
			}
			dBToDataTable2.Dispose();
			string sqlCommand3 = $"EXEC XWWL_INT_USER_DATA @FLD_ID,@name,@rwid,@zy,@coue,@xrwhex,@xrwhex2";
			SqlParameter[] prams3 = new SqlParameter[7]
			{
				SqlDBA.MakeInParam("@FLD_ID", SqlDbType.VarChar, 30, id),
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name),
				SqlDBA.MakeInParam("@rwid", SqlDbType.Int, 0, num),
				SqlDBA.MakeInParam("@zy", SqlDbType.Int, 0, zy),
				SqlDBA.MakeInParam("@coue", SqlDbType.VarBinary, 10, coue),
				SqlDBA.MakeInParam("@xrwhex", SqlDbType.VarBinary, array.Length, array),
				SqlDBA.MakeInParam("@xrwhex2", SqlDbType.VarBinary, array2.Length, array2)
			};
			if (DBA.ExeSqlCommand(sqlCommand3, prams3) != -1)
			{
				return 1;
			}
			return -1;
		}

		public static void GhilogPk(string player1, string player2)
		{
			DBA.ExeSqlCommand(string.Format("INSERT INTO LogPK (Nguoigiet,Nguoibigiet) VALUES ('{0}','{1}')", new object[2]
			{
				player1,
				player2
			}));
		}

		public static void GhiLogDelItem(int maItem, int idItem, string levelItem, Players player, int TrangThai = 0)
		{
			DBA.ExeSqlCommand($"INSERT INTO Log_DeleteItem (MaItem,IDItem,LevelItem,Username,TrangThai) VALUES ('{maItem}','{idItem}','{levelItem}','{player.UserName}','{TrangThai}')");
		}

		public static void 百宝记录(string userId, string userName, double 物品id, string 物品名, int 物品数量, int 元宝数)
		{
			DBA.ExeSqlCommand($"INSERT INTO 百宝记录 (UserId,UserName,物品ID,物品名,物品数量,元宝数) VALUES ('{userId}','{userName}','{物品id}','{物品名}',{物品数量},{元宝数})");
		}

		public static void 帮派赋予职位(int zw, string name)
		{
			string sqlCommand = $"UPDATE TBL_XWWL_GuildMember SET Leve=@zw WHERE Name=@Username";
			SqlParameter[] prams = new SqlParameter[2]
			{
				SqlDBA.MakeInParam("@zw", SqlDbType.Int, 0, zw),
				SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, name)
			};
			DBA.ExeSqlCommand(sqlCommand, prams);
		}

		public static void AddGuildPoint(int point, string name)
		{
			string sqlCommand = $"UPDATE TBL_XWWL_GuildMember SET FLD_GuildPoint=FLD_GuildPoint+@point WHERE Name=@Username";
			SqlParameter[] prams = new SqlParameter[2]
			{
				SqlDBA.MakeInParam("@point", SqlDbType.Int, 0, point),
				SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, name)
			};
			DBA.ExeSqlCommand(sqlCommand, prams);
		}

		public static void 帮战赌注(string userId, string userName, int guildId, int 元宝数)
		{
			DBA.ExeSqlCommand($"INSERT INTO 帮战赌注 (UserId,UserName,帮派ID,元宝数) VALUES ('{userId}','{userName}',{guildId},{元宝数})");
		}

		public static DataTable Check_Email_Name(string string0)
		{
			string sqlCommand = $"SELECT * FROM TBL_传书系统 WHERE 接收人物名 =@name";
			SqlParameter[] prams = new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, string0)
			};
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

		public static void Update_Email_Read(int id, int num)
		{
			string sqlCommand = $"UPDATE TBL_传书系统 SET 阅读标识=@rd WHERE ID=@id";
			SqlParameter[] prams = new SqlParameter[2]
			{
				SqlDBA.MakeInParam("@rd", SqlDbType.Int, 0, num),
				SqlDBA.MakeInParam("@id", SqlDbType.Int, 30, id)
			};
			DBA.ExeSqlCommand(sqlCommand, prams);
		}

		public static void Delete_Email(int id, string name)
		{
			string sqlCommand = $"DELETE TBL_传书系统 WHERE ID=@id and 接收人物名=@name";
			SqlParameter[] prams = new SqlParameter[2]
			{
				SqlDBA.MakeInParam("@id", SqlDbType.Int, 30, id),
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 50, name)
			};
			DBA.ExeSqlCommand(sqlCommand, prams);
		}

		public static void INSERT_Email(string string0, string string1, int int0, string string2)
		{
			string sqlCommand = $"EXEC INT_CS_DATA_New @fname, @sname, @msg, @npcid";
			SqlParameter[] prams = new SqlParameter[4]
			{
				SqlDBA.MakeInParam("@fname", SqlDbType.VarChar, 30, string0),
				SqlDBA.MakeInParam("@sname", SqlDbType.VarChar, 30, string1),
				SqlDBA.MakeInParam("@msg", SqlDbType.VarChar, 2000, string2),
				SqlDBA.MakeInParam("@npcid", SqlDbType.Int, 0, int0)
			};
			DBA.GetDBValue_3(sqlCommand, prams);
		}

		public static void 帮战赌注删除(string userId, string userName, int guildId, int sl)
		{
			DBA.ExeSqlCommand($"DELETE FROM 帮战赌注 WHERE UserId = '{userId}' and UserName='{userName}' and UserName='{guildId}'");
			switch (sl)
			{
			case 1:
				DBA.ExeSqlCommand($"UPDATE TBL_XWWL_Guild SET 胜=胜+1 WHERE ID='{guildId}'");
				break;
			case -1:
				DBA.ExeSqlCommand($"UPDATE TBL_XWWL_Guild SET 败=败+1 WHERE ID='{guildId}'");
				break;
			case 0:
				DBA.ExeSqlCommand($"UPDATE TBL_XWWL_Guild SET 平=平+1 WHERE ID='{guildId}'");
				break;
			}
		}

		public static bool smethod_31(string string0, string string1)
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"select * from [TBL_ACCOUNT] where FLD_ID='{string0}'", "rxjhaccount");
			if (dBToDataTable == null)
			{
				string sqlCommand = $"delete [TBL_XWWL_CHAR] WHERE FLD_ID ='{string0}' and FLD_NAME='{string1}'";
				string sqlCommand2 = $"delete [TBL_TBL_XWWL_Warehouse] WHERE FLD_ID ='{string0}' and FLD_NAME='{string1}'";
				if (DBA.ExeSqlCommand(sqlCommand, "rxjhgame") != -1)
				{
					DBA.ExeSqlCommand(sqlCommand2, "rxjhgame");
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
			string sqlCommand = $"EXEC XWWL_INT_Guild_DATA_New @name, @bpname,@leve";
			SqlParameter[] prams = new SqlParameter[3]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name),
				SqlDBA.MakeInParam("@bpname", SqlDbType.VarChar, 30, 帮派name),
				SqlDBA.MakeInParam("@leve", SqlDbType.Int, 0, leve)
			};
			return (int)DBA.GetDBValue_3(sqlCommand, prams);
		}

		public static int 创建帮派确认(string 帮派name)
		{
			string sqlCommand = $"EXEC XWWL_SELECT_Guild_DATA @bpnamea";
			SqlParameter[] prams = new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@bpnamea", SqlDbType.VarChar, 30, 帮派name)
			};
			return (int)DBA.GetDBValue_3(sqlCommand, prams);
		}

		public static DataTable 得到帮派人数(string name)
		{
			string text = Config.IniReadValue("rxjhgame", "DataName").Trim().ToString();
			string text2 = Config.IniReadValue("rxjhaccount", "DataName").Trim().ToString();
			string sqlCommand = string.Format("SELECT Acc.FLD_ONLINE, Guild.Name, Guild.Leve, Guild.FLD_LEVEL  FROM ((" + text + ".dbo.TBL_XWWL_GuildMember as Guild inner join " + text + ".dbo.TBL_XWWL_Char as GameChar on Guild.Name = GameChar.FLD_NAME) inner join " + text2 + ".dbo.TBL_ACCOUNT as Acc on Acc.FLD_ID = GameChar.FLD_ID) WHERE G_Name=@name");
			SqlParameter[] prams = new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name)
			};
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
			string sqlCommand = $"SELECT * FROM TBL_XWWL_Guild WHERE G_Name = @name";
			SqlParameter[] prams = new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name)
			};
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
				DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_XWWL_Guild WHERE ID = {id}");
				if (dBToDataTable.Rows.Count != 0)
				{
					if (dBToDataTable.Rows[0]["门徽"].GetType().ToString() == "System.DBNull")
					{
						return null;
					}
					byte[] array = (byte[])dBToDataTable.Rows[0]["门徽"];
					if (array != null)
					{
						return array;
					}
				}
				return null;
			}
			catch (Exception value)
			{
				Console.WriteLine(value);
				return null;
			}
		}

		public static void 登陆记录(string userId, string userName, string userIp, string 类型, string userMac = "", string userIpLan = "")
		{
			if (World.登陆记录 == 1)
			{
				string sql = $"INSERT INTO 登陆记录 (UserId,UserName,UserIp,类型,UserMac,UserIPLan) VALUES (@UserId,@UserName,@UserIp,@类型,@UserMac,@UserIPLan)";
				SqlParameter[] prams = new SqlParameter[6]
				{
					SqlDBA.MakeInParam("@UserId", SqlDbType.VarChar, 30, userId),
					SqlDBA.MakeInParam("@UserName", SqlDbType.VarChar, 30, userName),
					SqlDBA.MakeInParam("@UserIp", SqlDbType.VarChar, 30, userIp),
					SqlDBA.MakeInParam("@类型", SqlDbType.VarChar, 30, 类型),
					SqlDBA.MakeInParam("@UserMac", SqlDbType.VarChar, 30, userMac),
					SqlDBA.MakeInParam("@UserIPLan", SqlDbType.VarChar, 30, userIpLan)
				};
				DbPoolClass dbPoolClass = new DbPoolClass();
				dbPoolClass.Conn = DBA.getstrConnection(null);
				dbPoolClass.Prams = prams;
				dbPoolClass.Sql = sql;
				dbPoolClass.Type = 1;
				World.SqlPool.Enqueue(dbPoolClass);
			}
		}

		public static int 加入帮派(string name, string 帮派name, int leve)
		{
			string sqlCommand = $"EXEC XWWL_JR_Guild_DATA_New @name, @bpname,@leve";
			SqlParameter[] prams = new SqlParameter[3]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name),
				SqlDBA.MakeInParam("@bpname", SqlDbType.VarChar, 30, 帮派name),
				SqlDBA.MakeInParam("@leve", SqlDbType.Int, 0, leve)
			};
			return (int)DBA.GetDBValue_3(sqlCommand, prams);
		}

		public static void 申请门徽(int guildId, byte[] 门徽)
		{
			DBA.ExeSqlCommand(string.Format("UPDATE TBL_XWWL_Guild SET 门徽={1} WHERE ID='{0}'", guildId, Converter.ToString1(门徽)));
		}

		public static int 退出门派(string name)
		{
			string sqlCommand = $"EXEC XWWL_Out_Guild_DATA @name";
			SqlParameter[] prams = new SqlParameter[1]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name)
			};
			return (int)DBA.GetDBValue_3(sqlCommand, prams);
		}

		public static void 物品记录(string userId, string userName, string toUserId, string toUserName, double 全局id, int 物品id, string 物品名, int 物品数量, string 物品属性, long 钱数, string 类型)
		{
			if (World.物品记录 == 1)
			{
				string sql = $"INSERT INTO 物品记录 (UserId,UserName,ToUserId,ToUserName,全局ID,物品ID,物品名,物品数量,物品属性,钱数,类型) VALUES (@UserId,@UserName,@ToUserId,@ToUserName,@全局ID,@物品ID,@物品名,@物品数量,@物品属性,@钱数,@类型)";
				SqlParameter[] prams = new SqlParameter[11]
				{
					SqlDBA.MakeInParam("@UserId", SqlDbType.VarChar, 30, userId),
					SqlDBA.MakeInParam("@UserName", SqlDbType.VarChar, 30, userName),
					SqlDBA.MakeInParam("@ToUserId", SqlDbType.VarChar, 30, toUserId),
					SqlDBA.MakeInParam("@ToUserName", SqlDbType.VarChar, 30, toUserName),
					SqlDBA.MakeInParam("@全局ID", SqlDbType.VarChar, 30, 全局id),
					SqlDBA.MakeInParam("@物品ID", SqlDbType.VarChar, 30, 物品id),
					SqlDBA.MakeInParam("@物品名", SqlDbType.VarChar, 30, 物品名),
					SqlDBA.MakeInParam("@物品数量", SqlDbType.Int, 4, 物品数量),
					SqlDBA.MakeInParam("@物品属性", SqlDbType.VarChar, 100, 物品属性),
					SqlDBA.MakeInParam("@钱数", SqlDbType.BigInt, 4, 钱数),
					SqlDBA.MakeInParam("@类型", SqlDbType.VarChar, 10, 类型)
				};
				DbPoolClass dbPoolClass = new DbPoolClass();
				dbPoolClass.Conn = DBA.getstrConnection(null);
				dbPoolClass.Prams = prams;
				dbPoolClass.Sql = sql;
				dbPoolClass.Type = 1;
				World.SqlPool.Enqueue(dbPoolClass);
			}
		}

		public static int 逐出门派(string name, string 帮派name)
		{
			string sqlCommand = $"EXEC XWWL_OutBz_Guild_DATA @name, @bpname";
			SqlParameter[] prams = new SqlParameter[2]
			{
				SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 30, name),
				SqlDBA.MakeInParam("@bpname", SqlDbType.VarChar, 30, 帮派name)
			};
			return (int)DBA.GetDBValue_3(sqlCommand, prams);
		}
	}
}

using RxjhServer.RxjhServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace RxjhServer
{
	public class TeamClass : IDisposable
	{
		public List<Players> tem = new List<Players>();

		public string 队长;

		public int Slot_Give_Item_Random = 0;

		public int _Slot_Give_Item_Count = 0;

		public int Slot_Give_Item_order = 1;

		public int Check_Slot_In_Party = 1;

		public int Type_Share_ItemDrop = 3;

		public Players 邀请人;

		public System.Timers.Timer 自动显示 = new System.Timers.Timer(500.0);

		public int 组队id;

		public Dictionary<int, Players> List_Party;

		public Players Leader => (from K in World.AllConnectedChars.Values
		where K.UserName == 队长
		select K).FirstOrDefault();

		public TeamClass(Players 队长_)
		{
			自动显示.Elapsed += eval_a;
			自动显示.AutoReset = true;
			队长 = 队长_.UserName;
			List_Party = new Dictionary<int, Players>();
			List_Party.Add(队长_.UserSessionID, 队长_);
		}

		public void Dispose()
		{
			try
			{
				foreach (Players value in List_Party.Values)
				{
					value.解散组队提示();
					value.Party_ID = 0;
					value.bPartyWithCouple = false;
					value.Party_Status = 0;
				}
				List_Party.Clear();
				World.PartyClass.Remove(组队id);
				if (自动显示 != null)
				{
					自动显示.Enabled = false;
					自动显示.Close();
					自动显示.Dispose();
					自动显示 = null;
				}
				邀请人 = null;
				tem = null;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "组队类 Dispose 出错!" + ex.Message);
			}
			finally
			{
				tem = null;
				List_Party = null;
				World.PartyClass.Remove(组队id);
			}
		}

		public void Dispose1()
		{
			if (List_Party != null)
			{
				foreach (Players value in List_Party.Values)
				{
					value.解散组队提示();
					value.Party_ID = 0;
					value.bPartyWithCouple = false;
				}
				List_Party.Clear();
			}
			World.PartyClass.Remove(组队id);
			if (自动显示 != null)
			{
				自动显示.Enabled = false;
				自动显示.Close();
				自动显示.Dispose();
				自动显示 = null;
			}
			邀请人 = null;
			tem = null;
		}

		private void eval_a(object sender, ElapsedEventArgs e)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "TeamClass-自动显示事件");
			}
			try
			{
				if (List_Party.Count <= 1)
				{
					Dispose();
				}
				else
				{
					foreach (Players value in List_Party.Values)
					{
						if (World.AllConnectedChars.ContainsKey(value.UserSessionID))
						{
							value.显示队员();
						}
						else
						{
							tem.Add(value);
						}
					}
					foreach (Players item in tem)
					{
						List_Party.Remove(item.UserSessionID);
					}
					if (tem.Count > 0)
					{
						tem.Clear();
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "组队类 自动显示事件 出错!" + ex.Message);
			}
		}

		~TeamClass()
		{
		}

		public void 加入队员提示(Players 队员)
		{
			try
			{
				if (队员.FLD_Couple_Name != "")
				{
					foreach (Players value in List_Party.Values)
					{
						if (value.UserName == 队员.FLD_Couple_Name)
						{
							队员.bPartyWithCouple = true;
							value.bPartyWithCouple = true;
							break;
						}
					}
				}
				foreach (Players value2 in List_Party.Values)
				{
					if (队员 != value2)
					{
						value2.加入组队提示(队员);
						队员.加入组队提示(value2);
					}
					value2.显示队员();
				}
				if (List_Party.Count >= 2)
				{
					自动显示.Enabled = true;
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "组队类 加入队员提示 出错!" + ex.Message);
			}
		}

		public void 退出(Players 队员)
		{
			try
			{
				List_Party.Remove(队员.UserSessionID);
				if (队员.FLD_Couple_Name != "")
				{
					队员.bPartyWithCouple = false;
					foreach (Players value in List_Party.Values)
					{
						if (value.UserName == 队员.FLD_Couple_Name)
						{
							value.bPartyWithCouple = false;
							break;
						}
					}
				}
				if (List_Party.Count >= 2)
				{
					if (队长 != 队员.UserName)
					{
						foreach (Players value2 in List_Party.Values)
						{
							value2.退出组队提示(队员);
							value2.显示队员();
						}
					}
					else
					{
						bool flag = true;
						foreach (Players value3 in List_Party.Values)
						{
							if (flag)
							{
								队长 = value3.UserName;
								value3.委任队长提示(队员, value3);
								flag = false;
							}
							value3.GameMessage("QuyêÌn trýõÒng tôÒ ðôòi chuyêÒn sang [ " + 队长 + " ]", 8);
							value3.退出组队提示(队员);
							value3.显示队员();
						}
					}
				}
				else
				{
					Dispose();
				}
				队员.本人退出组队提示();
				队员.Party_ID = 0;
				队员.Party_Status = 0;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "组队类 退出 出错!" + ex.Message);
			}
		}

		public void 委任队长(Players 本人, Players 队长类)
		{
			try
			{
				队长 = 队长类.UserName;
				foreach (Players value in List_Party.Values)
				{
					value.委任队长提示(本人, 队长类);
					value.显示队员();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "组队类 委任队长 出错!" + ex.Message);
			}
		}
	}
}

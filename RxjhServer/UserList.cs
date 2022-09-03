using DbClss;
using RxjhServer.RxjhServer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RxjhServer
{
	public class UserList : Form
	{
		private ListView eval_a_a;

		private ColumnHeader eval_b_b;

		private ColumnHeader eval_c_c;

		private ColumnHeader eval_d_d;

		private ColumnHeader eval_e_e;

		private ColumnHeader eval_f_f;

		private ColumnHeader eval_g_g;

		private ColumnHeader eval_h;

		private ColumnHeader eval_i;

		private ContextMenu eval_j;

		private MenuItem eval_k;

		private MenuItem eval_l;

		private MenuItem eval_m;

		private ColumnHeader eval_n;

		private MenuItem eval_o;

		private ColumnHeader eval_p;

		private ColumnHeader eval_q;

		private ColumnHeader eval_r;

		private ColumnHeader eval_s;

		private ColumnHeader eval_t;

		private ColumnHeader eval_u;

		private ColumnHeader eval_v;

		private ColumnHeader eval_w;

		private MenuItem eval_x;

		public UserList()
		{
			InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			eval_a_a = new System.Windows.Forms.ListView();
			eval_b_b = new System.Windows.Forms.ColumnHeader();
			eval_c_c = new System.Windows.Forms.ColumnHeader();
			eval_d_d = new System.Windows.Forms.ColumnHeader();
			eval_e_e = new System.Windows.Forms.ColumnHeader();
			eval_n = new System.Windows.Forms.ColumnHeader();
			eval_f_f = new System.Windows.Forms.ColumnHeader();
			eval_g_g = new System.Windows.Forms.ColumnHeader();
			eval_h = new System.Windows.Forms.ColumnHeader();
			eval_i = new System.Windows.Forms.ColumnHeader();
			eval_p = new System.Windows.Forms.ColumnHeader();
			eval_t = new System.Windows.Forms.ColumnHeader();
			eval_q = new System.Windows.Forms.ColumnHeader();
			eval_u = new System.Windows.Forms.ColumnHeader();
			eval_s = new System.Windows.Forms.ColumnHeader();
			eval_r = new System.Windows.Forms.ColumnHeader();
			eval_v = new System.Windows.Forms.ColumnHeader();
			eval_w = new System.Windows.Forms.ColumnHeader();
			eval_j = new System.Windows.Forms.ContextMenu();
			eval_k = new System.Windows.Forms.MenuItem();
			eval_l = new System.Windows.Forms.MenuItem();
			eval_m = new System.Windows.Forms.MenuItem();
			eval_o = new System.Windows.Forms.MenuItem();
			eval_x = new System.Windows.Forms.MenuItem();
			SuspendLayout();
			eval_a_a.Columns.AddRange(new System.Windows.Forms.ColumnHeader[17]
			{
				eval_b_b,
				eval_c_c,
				eval_d_d,
				eval_e_e,
				eval_n,
				eval_f_f,
				eval_g_g,
				eval_h,
				eval_i,
				eval_p,
				eval_t,
				eval_q,
				eval_u,
				eval_s,
				eval_r,
				eval_v,
				eval_w
			});
			eval_a_a.ContextMenu = eval_j;
			eval_a_a.Dock = System.Windows.Forms.DockStyle.Fill;
			eval_a_a.ForeColor = System.Drawing.SystemColors.WindowText;
			eval_a_a.FullRowSelect = true;
			eval_a_a.GridLines = true;
			eval_a_a.Location = new System.Drawing.Point(0, 0);
			eval_a_a.Name = "eval_a_a";
			eval_a_a.Size = new System.Drawing.Size(819, 406);
			eval_a_a.TabIndex = 0;
			eval_a_a.UseCompatibleStateImageBehavior = false;
			eval_a_a.View = System.Windows.Forms.View.Details;
			eval_a_a.SelectedIndexChanged += new System.EventHandler(eval_a);
			eval_b_b.Text = "序号";
			eval_b_b.Width = 36;
			eval_c_c.Text = "ID";
			eval_c_c.Width = 34;
			eval_d_d.Text = "名字";
			eval_d_d.Width = 78;
			eval_e_e.Text = "等级";
			eval_e_e.Width = 37;
			eval_n.Text = "HP";
			eval_n.Width = 45;
			eval_f_f.Text = "IP";
			eval_f_f.Width = 116;
			eval_g_g.Text = "地图";
			eval_g_g.Width = 41;
			eval_h.Text = "X";
			eval_i.Text = "Y";
			eval_i.Width = 62;
			eval_p.Text = "攻";
			eval_p.Width = 36;
			eval_t.Text = "攻加";
			eval_t.Width = 39;
			eval_q.Text = "防";
			eval_q.Width = 38;
			eval_u.Text = "防加";
			eval_u.Width = 39;
			eval_s.Text = "气";
			eval_s.Width = 34;
			eval_r.Text = "ping";
			eval_r.Width = 37;
			eval_v.Text = "攻强";
			eval_v.Width = 42;
			eval_w.Text = "防强";
			eval_w.Width = 36;
			eval_j.MenuItems.AddRange(new System.Windows.Forms.MenuItem[5]
			{
				eval_k,
				eval_l,
				eval_m,
				eval_o,
				eval_x
			});
			eval_k.Index = 0;
			eval_k.Text = "Kick Char";
			eval_k.Click += new System.EventHandler(eval_f);
			eval_l.Index = 1;
			eval_l.Text = "Kick ID";
			eval_l.Click += new System.EventHandler(eval_e);
			eval_m.Index = 2;
			eval_m.Text = "Ban IP";
			eval_m.Click += new System.EventHandler(eval_d);
			eval_o.Index = 3;
			eval_o.Text = "Ban ID";
			eval_o.Click += new System.EventHandler(eval_c);
			eval_x.Index = 4;
			eval_x.Text = "View more";
			eval_x.Click += new System.EventHandler(eval_b);
			base.ClientSize = new System.Drawing.Size(819, 406);
			base.Controls.Add(eval_a_a);
			base.Name = "UserList";
			Text = "UserList";
			base.Load += new System.EventHandler(UserList_Load);
			ResumeLayout(performLayout: false);
		}

		private void eval_a(object sender, EventArgs e)
		{
		}

		private void eval_b(object sender, EventArgs e)
		{
			if (eval_a_a.SelectedItems.Count > 0)
			{
				string text = eval_a_a.SelectedItems[0].SubItems[2].Text;
				UserIdList userIdList = new UserIdList();
				userIdList.username = text;
				userIdList.ShowDialog();
			}
		}

		private void eval_c(object sender, EventArgs e)
		{
			if (eval_a_a.SelectedItems.Count > 0)
			{
				string text = eval_a_a.SelectedItems[0].SubItems[1].Text;
				DBA.ExeSqlCommand($"UPDATE TBL_ACCOUNT SET FLD_ZT=1 WHERE FLD_ID='{text}'", "rxjhaccount");
			}
		}

		private void eval_d(object sender, EventArgs e)
		{
			if (eval_a_a.SelectedItems.Count > 0)
			{
				string text = eval_a_a.SelectedItems[0].SubItems[5].Text;
				DBA.ExeSqlCommand($" Insert into TBL_BANED values ( '{text}')", "rxjhaccount");
			}
		}

		private void eval_e(object sender, EventArgs e)
		{
			if (eval_a_a.SelectedItems.Count > 0)
			{
				Players players = World.检查玩家(eval_a_a.SelectedItems[0].SubItems[1].Text);
				if (players != null && players.Client != null)
				{
					players.Client.Dispose();
				}
			}
		}

		private void eval_f(object sender, EventArgs e)
		{
			if (eval_a_a.SelectedItems.Count > 0)
			{
				Players players = World.FindPlayerbyName(eval_a_a.SelectedItems[0].SubItems[2].Text);
				if (players != null && players.Client != null)
				{
					players.Client.Dispose();
				}
			}
		}

		private void UserList_Load(object sender, EventArgs e)
		{
			try
			{
				eval_a_a.ListViewItemSorter = new ListViewColumnSorter();
				eval_a_a.ColumnClick += ListViewHelper.ListView_ColumnClick;
				int num = 0;
				List<string> list = new List<string>();
				foreach (Players value in World.AllConnectedChars.Values)
				{
					if (value != null)
					{
						string text = value.Client.ToString();
						if (!list.Contains(text))
						{
							list.Add(text);
						}
						string[] array = new string[17];
						try
						{
							array[0] = value.UserSessionID.ToString();
							array[1] = value.Userid;
							if (value.Client.FLD_Offline)
							{
								num++;
								array[2] = "[OFF]" + value.UserName;
							}
							else
							{
								array[2] = value.UserName;
							}
							array[3] = value.Player_Level.ToString();
							array[4] = value.Player_FLD_HP.ToString();
							if (value.Client != null)
							{
								array[5] = text;
							}
							array[6] = value.Player_FLD_Map.ToString();
							array[7] = value.Player_FLD_X.ToString();
							array[8] = value.Player_FLD_Y.ToString();
							array[9] = value.FLD_人物基本_攻击.ToString();
							array[10] = value.FLD_追加百分比_攻击.ToString();
							array[11] = value.FLD_人物基本_防御.ToString();
							array[12] = value.FLD_追加百分比_防御.ToString();
							array[13] = value.FLD_Item_Level_Pran.ToString();
							array[14] = value.Client.dwStop.ToString();
							array[15] = value.FLD_Item_Plus_VK.ToString();
							array[16] = value.FLD_Item_Plus_TB.ToString();
						}
						catch
						{
							array[0] = value.UserSessionID.ToString();
							array[1] = value.Userid;
							array[2] = value.UserName;
							array[3] = value.Player_Level.ToString();
						}
						eval_a_a.Items.Insert(eval_a_a.Items.Count, new ListViewItem(array));
					}
				}
				Text = "UserList (" + (World.AllConnectedChars.Count - num) + ") (" + list.Count + ")";
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "人物列表出错" + ex.Message);
			}
		}
	}
}

using DbClss;
using Network;
using RxjhServer.RxjhServer;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace RxjhServer
{
	public class BinIP : Form
	{
		private Label ab;

		private Label ad;

		private ColumnHeader eval_aa;

		private NumericUpDown eval_ac;

		private Button eval_b_b;

		private ContextMenuStrip eval_c_c;

		private ToolStripMenuItem eval_d_d;

		private GroupBox eval_e;

		private ListView eval_f;

		private ColumnHeader eval_g;

		private GroupBox eval_h;

		private ListView eval_i;

		private ColumnHeader eval_j;

		private GroupBox eval_k;

		private Label eval_l;

		private NumericUpDown eval_m;

		private Label eval_n;

		private GroupBox eval_o;

		private CheckBox eval_p;

		private CheckBox eval_q;

		private CheckBox eval_r;

		private CheckBox eval_s;

		private GroupBox eval_t;

		private Label eval_u;

		private Label eval_v;

		private NumericUpDown eval_w;

		private CheckBox eval_x;

		private ContextMenuStrip eval_y;

		private IContainer components;

		private ToolStripMenuItem eval_z;

		public BinIP()
		{
			InitializeComponent();
		}

		public void bind()
		{
			eval_i.Items.Clear();
			foreach (IPAddress bip in World.BipList)
			{
				string[] items = new string[1]
				{
					bip.ToString()
				};
				eval_i.Items.Insert(eval_i.Items.Count, new ListViewItem(items));
			}
		}

		public void bind2()
		{
			eval_f.Items.Clear();
			foreach (NetState value in World.List.Values)
			{
				string[] items = new string[2]
				{
					value.WorldId.ToString(),
					value.ToString()
				};
				eval_f.Items.Insert(eval_f.Items.Count, new ListViewItem(items));
			}
		}

		public void bind3()
		{
			eval_p.Checked = World.封ip;
			eval_m.Value = World.MaxNumberOfConnectionsToTheGameLoginPorts;
			eval_w.Value = World.自动连接时间;
			eval_ac.Value = World.游戏登陆端口最大连接时间数;
			eval_x.Checked = World.自动开启连接;
			eval_r.Checked = World.断开连接;
			eval_q.Checked = World.加入过滤列表;
			eval_s.Checked = World.关闭连接;
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			eval_c_c = new System.Windows.Forms.ContextMenuStrip(components);
			eval_d_d = new System.Windows.Forms.ToolStripMenuItem();
			eval_b_b = new System.Windows.Forms.Button();
			eval_e = new System.Windows.Forms.GroupBox();
			eval_f = new System.Windows.Forms.ListView();
			eval_aa = new System.Windows.Forms.ColumnHeader();
			eval_g = new System.Windows.Forms.ColumnHeader();
			eval_y = new System.Windows.Forms.ContextMenuStrip(components);
			eval_z = new System.Windows.Forms.ToolStripMenuItem();
			eval_h = new System.Windows.Forms.GroupBox();
			eval_i = new System.Windows.Forms.ListView();
			eval_j = new System.Windows.Forms.ColumnHeader();
			eval_k = new System.Windows.Forms.GroupBox();
			ab = new System.Windows.Forms.Label();
			eval_ac = new System.Windows.Forms.NumericUpDown();
			ad = new System.Windows.Forms.Label();
			eval_t = new System.Windows.Forms.GroupBox();
			eval_u = new System.Windows.Forms.Label();
			eval_v = new System.Windows.Forms.Label();
			eval_w = new System.Windows.Forms.NumericUpDown();
			eval_x = new System.Windows.Forms.CheckBox();
			eval_o = new System.Windows.Forms.GroupBox();
			eval_s = new System.Windows.Forms.CheckBox();
			eval_q = new System.Windows.Forms.CheckBox();
			eval_r = new System.Windows.Forms.CheckBox();
			eval_p = new System.Windows.Forms.CheckBox();
			eval_l = new System.Windows.Forms.Label();
			eval_m = new System.Windows.Forms.NumericUpDown();
			eval_n = new System.Windows.Forms.Label();
			eval_c_c.SuspendLayout();
			eval_e.SuspendLayout();
			eval_y.SuspendLayout();
			eval_h.SuspendLayout();
			eval_k.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)eval_ac).BeginInit();
			eval_t.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)eval_w).BeginInit();
			eval_o.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)eval_m).BeginInit();
			SuspendLayout();
			eval_c_c.Items.AddRange(new System.Windows.Forms.ToolStripItem[1]
			{
				eval_d_d
			});
			eval_c_c.Name = "contextMenuStrip1";
			eval_c_c.Size = new System.Drawing.Size(95, 26);
			eval_d_d.Name = "eval_d_d";
			eval_d_d.Size = new System.Drawing.Size(94, 22);
			eval_d_d.Text = "删除";
			eval_d_d.Click += new System.EventHandler(eval_b);
			eval_b_b.Location = new System.Drawing.Point(79, 248);
			eval_b_b.Name = "eval_b_b";
			eval_b_b.Size = new System.Drawing.Size(75, 23);
			eval_b_b.TabIndex = 4;
			eval_b_b.Text = "确定";
			eval_b_b.UseVisualStyleBackColor = true;
			eval_b_b.Click += new System.EventHandler(eval_d);
			eval_e.Controls.Add(eval_f);
			eval_e.Location = new System.Drawing.Point(8, 9);
			eval_e.Name = "eval_e";
			eval_e.Size = new System.Drawing.Size(151, 280);
			eval_e.TabIndex = 6;
			eval_e.TabStop = false;
			eval_e.Text = "当前连接";
			eval_f.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2]
			{
				eval_aa,
				eval_g
			});
			eval_f.ContextMenuStrip = eval_y;
			eval_f.Dock = System.Windows.Forms.DockStyle.Fill;
			eval_f.FullRowSelect = true;
			eval_f.GridLines = true;
			eval_f.Location = new System.Drawing.Point(3, 17);
			eval_f.Name = "eval_f";
			eval_f.Size = new System.Drawing.Size(145, 260);
			eval_f.TabIndex = 4;
			eval_f.UseCompatibleStateImageBehavior = false;
			eval_f.View = System.Windows.Forms.View.Details;
			eval_aa.Text = "ID";
			eval_aa.Width = 30;
			eval_g.Text = "IP";
			eval_g.Width = 150;
			eval_y.Items.AddRange(new System.Windows.Forms.ToolStripItem[1]
			{
				eval_z
			});
			eval_y.Name = "contextMenuStrip1";
			eval_y.Size = new System.Drawing.Size(119, 26);
			eval_z.Name = "eval_z";
			eval_z.Size = new System.Drawing.Size(118, 22);
			eval_z.Text = "断开连接";
			eval_z.Click += new System.EventHandler(eval_a);
			eval_h.Controls.Add(eval_i);
			eval_h.Location = new System.Drawing.Point(165, 9);
			eval_h.Name = "eval_h";
			eval_h.Size = new System.Drawing.Size(156, 280);
			eval_h.TabIndex = 7;
			eval_h.TabStop = false;
			eval_h.Text = "过滤列表";
			eval_i.Columns.AddRange(new System.Windows.Forms.ColumnHeader[1]
			{
				eval_j
			});
			eval_i.ContextMenuStrip = eval_c_c;
			eval_i.Dock = System.Windows.Forms.DockStyle.Fill;
			eval_i.FullRowSelect = true;
			eval_i.GridLines = true;
			eval_i.Location = new System.Drawing.Point(3, 17);
			eval_i.Name = "eval_i";
			eval_i.Size = new System.Drawing.Size(150, 260);
			eval_i.TabIndex = 5;
			eval_i.UseCompatibleStateImageBehavior = false;
			eval_i.View = System.Windows.Forms.View.Details;
			eval_j.Text = "IP";
			eval_j.Width = 150;
			eval_k.Controls.Add(ab);
			eval_k.Controls.Add(eval_ac);
			eval_k.Controls.Add(ad);
			eval_k.Controls.Add(eval_t);
			eval_k.Controls.Add(eval_o);
			eval_k.Controls.Add(eval_p);
			eval_k.Controls.Add(eval_b_b);
			eval_k.Controls.Add(eval_l);
			eval_k.Controls.Add(eval_m);
			eval_k.Controls.Add(eval_n);
			eval_k.Location = new System.Drawing.Point(327, 9);
			eval_k.Name = "eval_k";
			eval_k.Size = new System.Drawing.Size(162, 280);
			eval_k.TabIndex = 8;
			eval_k.TabStop = false;
			eval_k.Text = "攻击保护";
			ab.AutoSize = true;
			ab.Location = new System.Drawing.Point(137, 65);
			ab.Name = "ab";
			ab.Size = new System.Drawing.Size(17, 12);
			ab.TabIndex = 18;
			ab.Text = "秒";
			eval_ac.Location = new System.Drawing.Point(65, 61);
			eval_ac.Maximum = new decimal(new int[4]
			{
				60000,
				0,
				0,
				0
			});
			eval_ac.Name = "eval_ac";
			eval_ac.Size = new System.Drawing.Size(60, 21);
			eval_ac.TabIndex = 17;
			eval_ac.Value = new decimal(new int[4]
			{
				10000,
				0,
				0,
				0
			});
			ad.AutoSize = true;
			ad.Location = new System.Drawing.Point(6, 65);
			ad.Name = "ad";
			ad.Size = new System.Drawing.Size(53, 12);
			ad.TabIndex = 16;
			ad.Text = "连接时间";
			eval_t.Controls.Add(eval_u);
			eval_t.Controls.Add(eval_v);
			eval_t.Controls.Add(eval_w);
			eval_t.Controls.Add(eval_x);
			eval_t.Location = new System.Drawing.Point(6, 174);
			eval_t.Name = "eval_t";
			eval_t.Size = new System.Drawing.Size(150, 68);
			eval_t.TabIndex = 15;
			eval_t.TabStop = false;
			eval_t.Text = "关闭连接";
			eval_u.AutoSize = true;
			eval_u.Location = new System.Drawing.Point(108, 41);
			eval_u.Name = "eval_u";
			eval_u.Size = new System.Drawing.Size(17, 12);
			eval_u.TabIndex = 17;
			eval_u.Text = "秒";
			eval_v.AutoSize = true;
			eval_v.Location = new System.Drawing.Point(12, 41);
			eval_v.Name = "eval_v";
			eval_v.Size = new System.Drawing.Size(53, 12);
			eval_v.TabIndex = 16;
			eval_v.Text = "间隔时间";
			eval_w.Location = new System.Drawing.Point(67, 37);
			eval_w.Name = "eval_w";
			eval_w.Size = new System.Drawing.Size(38, 21);
			eval_w.TabIndex = 15;
			eval_w.Value = new decimal(new int[4]
			{
				10,
				0,
				0,
				0
			});
			eval_x.AutoSize = true;
			eval_x.Location = new System.Drawing.Point(12, 17);
			eval_x.Name = "eval_x";
			eval_x.Size = new System.Drawing.Size(96, 16);
			eval_x.TabIndex = 14;
			eval_x.Text = "自动开启连接";
			eval_x.UseVisualStyleBackColor = true;
			eval_o.Controls.Add(eval_s);
			eval_o.Controls.Add(eval_q);
			eval_o.Controls.Add(eval_r);
			eval_o.Location = new System.Drawing.Point(6, 85);
			eval_o.Name = "eval_o";
			eval_o.Size = new System.Drawing.Size(150, 79);
			eval_o.TabIndex = 7;
			eval_o.TabStop = false;
			eval_o.Text = "攻击操作";
			eval_s.AutoSize = true;
			eval_s.Location = new System.Drawing.Point(12, 54);
			eval_s.Name = "eval_s";
			eval_s.Size = new System.Drawing.Size(72, 16);
			eval_s.TabIndex = 14;
			eval_s.Text = "关闭连接";
			eval_s.UseVisualStyleBackColor = true;
			eval_q.AutoSize = true;
			eval_q.Location = new System.Drawing.Point(13, 33);
			eval_q.Name = "eval_q";
			eval_q.Size = new System.Drawing.Size(96, 16);
			eval_q.TabIndex = 13;
			eval_q.Text = "加入过滤列表";
			eval_q.UseVisualStyleBackColor = true;
			eval_r.AutoSize = true;
			eval_r.Location = new System.Drawing.Point(14, 14);
			eval_r.Name = "eval_r";
			eval_r.Size = new System.Drawing.Size(72, 16);
			eval_r.TabIndex = 12;
			eval_r.Text = "断开连接";
			eval_r.UseVisualStyleBackColor = true;
			eval_p.AutoSize = true;
			eval_p.Location = new System.Drawing.Point(11, 17);
			eval_p.Name = "eval_p";
			eval_p.Size = new System.Drawing.Size(96, 16);
			eval_p.TabIndex = 6;
			eval_p.Text = "开启攻击保护";
			eval_p.UseVisualStyleBackColor = true;
			eval_l.AutoSize = true;
			eval_l.Location = new System.Drawing.Point(109, 41);
			eval_l.Name = "eval_l";
			eval_l.Size = new System.Drawing.Size(47, 12);
			eval_l.TabIndex = 2;
			eval_l.Text = "连接/IP";
			eval_m.Location = new System.Drawing.Point(65, 37);
			eval_m.Minimum = new decimal(new int[4]
			{
				2,
				0,
				0,
				0
			});
			eval_m.Name = "eval_m";
			eval_m.Size = new System.Drawing.Size(38, 21);
			eval_m.TabIndex = 1;
			eval_m.Value = new decimal(new int[4]
			{
				5,
				0,
				0,
				0
			});
			eval_n.AutoSize = true;
			eval_n.Location = new System.Drawing.Point(6, 41);
			eval_n.Name = "eval_n";
			eval_n.Size = new System.Drawing.Size(53, 12);
			eval_n.TabIndex = 0;
			eval_n.Text = "连接限制";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(493, 293);
			base.Controls.Add(eval_k);
			base.Controls.Add(eval_h);
			base.Controls.Add(eval_e);
			base.MaximizeBox = false;
			base.Name = "BinIP";
			Text = "防CC设置";
			base.Load += new System.EventHandler(eval_c);
			eval_c_c.ResumeLayout(performLayout: false);
			eval_e.ResumeLayout(performLayout: false);
			eval_y.ResumeLayout(performLayout: false);
			eval_h.ResumeLayout(performLayout: false);
			eval_k.ResumeLayout(performLayout: false);
			eval_k.PerformLayout();
			((System.ComponentModel.ISupportInitialize)eval_ac).EndInit();
			eval_t.ResumeLayout(performLayout: false);
			eval_t.PerformLayout();
			((System.ComponentModel.ISupportInitialize)eval_w).EndInit();
			eval_o.ResumeLayout(performLayout: false);
			eval_o.PerformLayout();
			((System.ComponentModel.ISupportInitialize)eval_m).EndInit();
			ResumeLayout(performLayout: false);
		}

		private void eval_a(object sender, EventArgs e)
		{
			if (eval_f.SelectedItems.Count <= 0)
			{
				return;
			}
			for (int i = 0; i < eval_f.SelectedItems.Count; i++)
			{
				string text = eval_f.SelectedItems[i].SubItems[0].Text;
				if (World.List.TryGetValue(int.Parse(text), out NetState value))
				{
					value.Dispose();
				}
				bind2();
			}
		}

		private void eval_b(object sender, EventArgs e)
		{
			if (eval_i.SelectedItems.Count > 0)
			{
				for (int i = 0; i < eval_i.SelectedItems.Count; i++)
				{
					string text = eval_i.SelectedItems[i].SubItems[0].Text;
					World.BipList.Remove(IPAddress.Parse(text));
					bind();
				}
			}
		}

		private void eval_c(object sender, EventArgs e)
		{
			bind();
			bind2();
			bind3();
		}

		private void eval_d(object sender, EventArgs e)
		{
			World.封ip = eval_p.Checked;
			World.MaxNumberOfConnectionsToTheGameLoginPorts = (int)eval_m.Value;
			World.自动连接时间 = (int)eval_w.Value;
			World.游戏登陆端口最大连接时间数 = (int)eval_ac.Value;
			World.自动开启连接 = eval_x.Checked;
			World.断开连接 = eval_r.Checked;
			World.加入过滤列表 = eval_q.Checked;
			World.关闭连接 = eval_s.Checked;
			Config.IniWriteValue("GameServer", "封IP", eval_p.Checked.ToString());
			Config.IniWriteValue("GameServer", "自动开启连接", eval_x.Checked.ToString());
			Config.IniWriteValue("GameServer", "断开连接", eval_r.Checked.ToString());
			Config.IniWriteValue("GameServer", "加入过滤列表", eval_q.Checked.ToString());
			Config.IniWriteValue("GameServer", "关闭连接", eval_s.Checked.ToString());
			Config.IniWriteValue("GameServer", "MaxNumberOfConnectionsToTheGameLoginPorts", eval_m.Value.ToString());
			Config.IniWriteValue("GameServer", "自动连接时间", eval_w.Value.ToString());
			Config.IniWriteValue("GameServer", "游戏登陆端口最大连接时间数", eval_ac.Value.ToString());
			Close();
		}
	}
}

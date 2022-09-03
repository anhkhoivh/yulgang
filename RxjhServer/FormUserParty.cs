using RxjhServer.RxjhServer;

namespace RxjhServer
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class FormUserParty : Form
    {
        //private IContainer eval_a_a;
        private System.Windows.Forms.ListView eval_b_b;
        private ColumnHeader eval_c;
        private ColumnHeader eval_d;
        private SplitContainer eval_e;
        private ListView eval_f;
        private ColumnHeader eval_g;
        private ColumnHeader eval_h;
        private ColumnHeader eval_i;
        private ColumnHeader eval_j;
        private ColumnHeader eval_k;
        private ColumnHeader eval_l;
        private ColumnHeader eval_m;
        private ColumnHeader eval_n;
        private ColumnHeader eval_o;
        private ColumnHeader eval_p;
        private ColumnHeader eval_q;
        private ColumnHeader eval_r;
        private ColumnHeader eval_s;
        private ColumnHeader eval_t;
        private ColumnHeader eval_u;
        private ColumnHeader eval_v;
        private ColumnHeader eval_w;

        public FormUserParty()
        {
            this.InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            //if (disposing && (this.eval_a_a != null))
            //{
            //    this.eval_a_a.Dispose();
            //}
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.eval_b_b = new System.Windows.Forms.ListView();
            this.eval_c = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_d = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_e = new System.Windows.Forms.SplitContainer();
            this.eval_f = new System.Windows.Forms.ListView();
            this.eval_g = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_h = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_i = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_j = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_k = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_l = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_m = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_n = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_o = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_p = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_q = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_r = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_s = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_t = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_u = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_v = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_w = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.eval_e)).BeginInit();
            this.eval_e.Panel1.SuspendLayout();
            this.eval_e.Panel2.SuspendLayout();
            this.eval_e.SuspendLayout();
            this.SuspendLayout();
            // 
            // eval_b_b
            // 
            this.eval_b_b.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eval_c,
            this.eval_d});
            this.eval_b_b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eval_b_b.ForeColor = System.Drawing.SystemColors.WindowText;
            this.eval_b_b.FullRowSelect = true;
            this.eval_b_b.GridLines = true;
            this.eval_b_b.Location = new System.Drawing.Point(0, 0);
            this.eval_b_b.Name = "eval_b_b";
            this.eval_b_b.Size = new System.Drawing.Size(550, 168);
            this.eval_b_b.TabIndex = 9;
            this.eval_b_b.UseCompatibleStateImageBehavior = false;
            this.eval_b_b.View = System.Windows.Forms.View.Details;
            this.eval_b_b.Click += new System.EventHandler(this.eval_a);
            // 
            // eval_c
            // 
            this.eval_c.Text = "名称";
            this.eval_c.Width = 71;
            // 
            // eval_d
            // 
            this.eval_d.Text = "数据";
            this.eval_d.Width = 90;
            // 
            // eval_e
            // 
            this.eval_e.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eval_e.Location = new System.Drawing.Point(0, 0);
            this.eval_e.Name = "eval_e";
            this.eval_e.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // eval_e.Panel1
            // 
            this.eval_e.Panel1.Controls.Add(this.eval_b_b);
            // 
            // eval_e.Panel2
            // 
            this.eval_e.Panel2.Controls.Add(this.eval_f);
            this.eval_e.Size = new System.Drawing.Size(550, 372);
            this.eval_e.SplitterDistance = 168;
            this.eval_e.TabIndex = 10;
            // 
            // eval_f
            // 
            this.eval_f.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eval_g,
            this.eval_h,
            this.eval_i,
            this.eval_j,
            this.eval_k,
            this.eval_l,
            this.eval_m,
            this.eval_n,
            this.eval_o,
            this.eval_p,
            this.eval_q,
            this.eval_r,
            this.eval_s,
            this.eval_t,
            this.eval_u,
            this.eval_v,
            this.eval_w});
            this.eval_f.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eval_f.ForeColor = System.Drawing.SystemColors.WindowText;
            this.eval_f.FullRowSelect = true;
            this.eval_f.GridLines = true;
            this.eval_f.Location = new System.Drawing.Point(0, 0);
            this.eval_f.Name = "eval_f";
            this.eval_f.Size = new System.Drawing.Size(550, 200);
            this.eval_f.TabIndex = 2;
            this.eval_f.UseCompatibleStateImageBehavior = false;
            this.eval_f.View = System.Windows.Forms.View.Details;
            // 
            // eval_g
            // 
            this.eval_g.Text = "序号";
            this.eval_g.Width = 36;
            // 
            // eval_h
            // 
            this.eval_h.Text = "ID";
            this.eval_h.Width = 66;
            // 
            // eval_i
            // 
            this.eval_i.Text = "名字";
            this.eval_i.Width = 98;
            // 
            // eval_j
            // 
            this.eval_j.Text = "等级";
            this.eval_j.Width = 38;
            // 
            // eval_k
            // 
            this.eval_k.Text = "HP";
            this.eval_k.Width = 47;
            // 
            // eval_l
            // 
            this.eval_l.Text = "IP";
            this.eval_l.Width = 113;
            // 
            // eval_m
            // 
            this.eval_m.Text = "地图";
            this.eval_m.Width = 42;
            // 
            // eval_n
            // 
            this.eval_n.Text = "X";
            this.eval_n.Width = 61;
            // 
            // eval_o
            // 
            this.eval_o.Text = "Y";
            this.eval_o.Width = 61;
            // 
            // eval_p
            // 
            this.eval_p.Text = "攻";
            this.eval_p.Width = 36;
            // 
            // eval_q
            // 
            this.eval_q.Text = "攻加";
            this.eval_q.Width = 41;
            // 
            // eval_r
            // 
            this.eval_r.Text = "防";
            this.eval_r.Width = 37;
            // 
            // eval_s
            // 
            this.eval_s.Text = "防加";
            this.eval_s.Width = 39;
            // 
            // eval_t
            // 
            this.eval_t.Text = "气";
            this.eval_t.Width = 39;
            // 
            // eval_u
            // 
            this.eval_u.Text = "ping";
            this.eval_u.Width = 39;
            // 
            // eval_v
            // 
            this.eval_v.Text = "攻强";
            this.eval_v.Width = 39;
            // 
            // eval_w
            // 
            this.eval_w.Text = "防强";
            this.eval_w.Width = 37;
            // 
            // FormUser组队
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 372);
            this.Controls.Add(this.eval_e);
            this.Name = "FormUserParty";
            this.Text = "组队列表";
            this.Load += new System.EventHandler(this.eval_b);
            this.eval_e.Panel1.ResumeLayout(false);
            this.eval_e.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eval_e)).EndInit();
            this.eval_e.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void eval_a(object sender, EventArgs e)
        {
			TeamClass class2;
            if ((this.eval_b_b.SelectedItems.Count > 0) && World.PartyClass.TryGetValue(int.Parse(this.eval_b_b.SelectedItems[0].SubItems[0].Text), out class2))
            {
                this.eval_f.Items.Clear();
                foreach (Players players in class2.List_Party.Values)
                {
                    string[] items = new string[17];
                    try
                    {
                        items[0] = players.UserSessionID.ToString();
                        items[1] = players.Userid;
                        items[2] = players.UserName;
                        items[3] = players.Player_Level.ToString();
                        items[4] = players.Player_FLD_HP.ToString();
                        if (players.Client != null)
                        {
                            items[5] = players.Client.ToString();
                        }
                        items[6] = players.Player_FLD_Map.ToString();
                        items[7] = players.Player_FLD_X.ToString();
                        items[8] = players.Player_FLD_Y.ToString();
                        items[9] = players.FLD_人物基本_攻击.ToString();
                        items[10] = players.FLD_追加百分比_攻击.ToString();
                        items[11] = players.FLD_人物基本_防御.ToString();
                        items[12] = players.FLD_追加百分比_防御.ToString();
                        items[13] = players.FLD_Item_Level_Pran.ToString();
                        items[14] = players.Client.dwStop.ToString();
                        items[15] = players.FLD_装备_追加_武器_强化.ToString();
                        items[16] = players.FLD_Item_Plus_Coat.ToString();
                    }
                    catch
                    {
                        items[0] = players.UserSessionID.ToString();
                        items[1] = players.Userid;
                        items[2] = players.UserName;
                        items[3] = players.Player_Level.ToString();
                    }
                    this.eval_f.Items.Insert(this.eval_f.Items.Count, new ListViewItem(items));
                }
            }
        }

        private void eval_b(object sender, EventArgs e)
        {
            foreach (TeamClass class2 in World.PartyClass.Values)
            {
                string[] items = new string[2];
                try
                {
                    items[0] = class2.组队id.ToString();
                    items[1] = class2.List_Party.Count.ToString();
                    this.eval_b_b.Items.Insert(this.eval_b_b.Items.Count, new ListViewItem(items));
                    continue;
                }
                catch
                {
                    continue;
                }
            }
        }
    }
}


using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using CheckCopy;
using DbClss;
using RxjhServer;
using RxjhServer.RxjhServer;

namespace RxjhTool
{
    public class CheckCopy : Form
    {
        private DataTable dataTable_0;
        private DataTable dataTable_1;
        private Button eval_a_a;
        //private IContainer eval_b_b;
        private GroupBox eval_c_c;
        private GroupBox eval_d;
        private MenuStrip eval_e;
        private RadioButton eval_f;
        private RadioButton eval_g;
        private RadioButton eval_h;
        private RadioButton eval_i;
        private TextBox eval_j;
        private ToolStripMenuItem eval_k;
        private ToolStripMenuItem eval_p;
        private DataTable m;
        private DataTable n;
        private DataTable q;
        private DataTable r;

        public CheckCopy()
        {
            this.InitializeComponent();
        }

        private void a(object A_0)
        {
            ThreadParameter parameter = (ThreadParameter) A_0;
            string str = "";
            string sqlCommand = string.Format("select FLD_ID,FLD_NAME,FLD_WEARITEM,FLD_ITEM from [TBL_XWWL_Char] where FLD_NAME<>'{0}'", parameter.name);
            string str3 = string.Format("select FLD_ID,FLD_NAME,FLD_ITEM from [TBL_XWWL_Warehouse] where FLD_NAME<>'{0}'", parameter.name);
            string str4 = string.Format("select FLD_ID,FLD_ITEM from [TBL_XWWL_PublicWarehouse] where FLD_ID<>'{0}'", parameter.id);
            switch (parameter.类型)
            {
                case 0:
                    str = "背包";
                    break;

                case 1:
                    str = "已穿装备";
                    break;

                case 2:
                    str = "个人仓库";
                    break;

                case 3:
                    sqlCommand = "select FLD_ID,FLD_NAME,FLD_WEARITEM,FLD_ITEM from [TBL_XWWL_Char]";
                    str3 = "select FLD_ID,FLD_NAME,FLD_ITEM from [TBL_XWWL_Warehouse]";
                    str = "综合仓库";
                    break;
            }
            this.dataTable_1 = DBA.GetDBToDataTable(sqlCommand, "GameServer");
            this.m = DBA.GetDBToDataTable(str3, "GameServer");
            this.r = DBA.GetDBToDataTable(str4, "GameServer");
            if (this.dataTable_1.Rows.Count != 0)
            {
                for (int i = 0; i < this.dataTable_1.Rows.Count; ++i)
                {
                    byte[] src = (byte[]) this.dataTable_1.Rows[i]["FLD_ITEM"];
                    byte[] buffer5 = (byte[]) this.dataTable_1.Rows[i]["FLD_WEARITEM"];
                    this.dataTable_1.Rows[i]["FLD_ID"].ToString();
                    string str7 = this.dataTable_1.Rows[i]["FLD_NAME"].ToString();
                    for (int j = 0; j < 36; ++j)
                    {
                        byte[] dst = new byte[4];
                        Buffer.BlockCopy(src, j * 73, dst, 0, 4);
                        int num5 = BitConverter.ToInt32(dst, 0);
                        if ((num5 != 0) && (num5 == parameter.全局ID))
                        {
                            this.eval_a("发现复制装备,物品全局ID[" + parameter.全局ID.ToString() + "],在人物【" + str7 + "】的背包栏和人物【" + parameter.name + "】的" + str);
                        }
                    }
                    for (int k = 0; k < 15; ++k)
                    {
                        byte[] buffer6 = new byte[4];
                        Buffer.BlockCopy(buffer5, k * 73, buffer6, 0, 4);
                        int num14 = BitConverter.ToInt32(buffer6, 0);
                        if ((num14 != 0) && (num14 == parameter.全局ID))
                        {
                            this.eval_a("发现复制装备,物品全局ID[" + parameter.全局ID.ToString() + "],在人物【" + str7 + "】的已穿装备栏和人物【" + parameter.name + "】的" + str);
                        }
                    }
                }
            }
            this.dataTable_1.Dispose();
            if (this.m.Rows.Count != 0)
            {
                for (int m = 0; m < this.m.Rows.Count; m++)
                {
                    byte[] buffer4 = (byte[]) this.m.Rows[m]["FLD_ITEM"];
                    string str6 = this.m.Rows[m]["FLD_NAME"].ToString();
                    for (int n = 0; n < 60; n++)
                    {
                        byte[] buffer7 = new byte[4];
                        Buffer.BlockCopy(buffer4, n * 73, buffer7, 0, 4);
                        int num15 = BitConverter.ToInt32(buffer7, 0);
                        if ((num15 != 0) && (num15 == parameter.全局ID))
                        {
                            this.eval_a("发现复制装备,物品全局ID[" + parameter.全局ID.ToString() + "],在人物【" + str6 + "】的个人仓库和人物【" + parameter.name + "】的" + str);
                        }
                    }
                }
            }
            this.m.Dispose();
            if (this.r.Rows.Count != 0)
            {
                for (int num6 = 0; num6 < this.r.Rows.Count; num6++)
                {
                    byte[] buffer3 = (byte[]) this.r.Rows[num6]["FLD_ITEM"];
                    string str5 = this.r.Rows[num6]["FLD_ID"].ToString();
                    for (int num7 = 0; num7 < 60; num7++)
                    {
                        byte[] buffer8 = new byte[4];
                        Buffer.BlockCopy(buffer3, num7 * 73, buffer8, 0, 4);
                        int num16 = BitConverter.ToInt32(buffer8, 0);
                        if ((num16 != 0) && (num16 == parameter.全局ID))
                        {
                            this.eval_a("发现复制装备,物品全局ID[" + parameter.全局ID.ToString() + "],在帐号【" + str5 + "】的综合仓库和人物【" + parameter.name + "】的" + str);
                        }
                    }
                }
            }
            this.r.Dispose();
        }

        protected override void Dispose(bool disposing)
        {
            //if (disposing && (this.eval_b_b != null))
            //{
            //    this.eval_b_b.Dispose();
            //}
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.eval_c_c = new GroupBox();
            this.eval_i = new RadioButton();
            this.eval_h = new RadioButton();
            this.eval_g = new RadioButton();
            this.eval_f = new RadioButton();
            this.eval_d = new GroupBox();
            this.eval_j = new TextBox();
            this.eval_a_a = new Button();
            this.eval_e = new MenuStrip();
            this.eval_p = new ToolStripMenuItem();
            this.eval_k = new ToolStripMenuItem();
            this.eval_c_c.SuspendLayout();
            this.eval_d.SuspendLayout();
            this.eval_e.SuspendLayout();
            this.SuspendLayout();
            // 
            // eval_c_c
            // 
            this.eval_c_c.Controls.Add(this.eval_i);
            this.eval_c_c.Controls.Add(this.eval_h);
            this.eval_c_c.Controls.Add(this.eval_g);
            this.eval_c_c.Controls.Add(this.eval_f);
            this.eval_c_c.Location = new Point(33, 27);
            this.eval_c_c.Name = "eval_c_c";
            this.eval_c_c.Size = new Size(496, 62);
            this.eval_c_c.TabIndex = 0;
            this.eval_c_c.TabStop = false;
            this.eval_c_c.Text = "查询类型";
            // 
            // eval_i
            // 
            this.eval_i.AutoSize = true;
            this.eval_i.Location = new Point(91, 30);
            this.eval_i.Name = "eval_i";
            this.eval_i.Size = new Size(71, 16);
            this.eval_i.TabIndex = 5;
            this.eval_i.TabStop = true;
            this.eval_i.Text = "已穿装备";
            this.eval_i.UseVisualStyleBackColor = true;
            // 
            // eval_h
            // 
            this.eval_h.AutoSize = true;
            this.eval_h.Location = new Point(283, 30);
            this.eval_h.Name = "eval_h";
            this.eval_h.Size = new Size(71, 16);
            this.eval_h.TabIndex = 3;
            this.eval_h.TabStop = true;
            this.eval_h.Text = "综合仓库";
            this.eval_h.UseVisualStyleBackColor = true;
            // 
            // eval_g
            // 
            this.eval_g.AutoSize = true;
            this.eval_g.Location = new Point(187, 30);
            this.eval_g.Name = "eval_g";
            this.eval_g.Size = new Size(71, 16);
            this.eval_g.TabIndex = 2;
            this.eval_g.TabStop = true;
            this.eval_g.Text = "个人仓库";
            this.eval_g.UseVisualStyleBackColor = true;
            // 
            // eval_f
            // 
            this.eval_f.AutoSize = true;
            this.eval_f.Location = new Point(19, 30);
            this.eval_f.Name = "eval_f";
            this.eval_f.Size = new Size(47, 16);
            this.eval_f.TabIndex = 1;
            this.eval_f.TabStop = true;
            this.eval_f.Text = "背包";
            this.eval_f.UseVisualStyleBackColor = true;
            // 
            // eval_d
            // 
            this.eval_d.Controls.Add(this.eval_j);
            this.eval_d.Location = new Point(33, 102);
            this.eval_d.Name = "eval_d";
            this.eval_d.Size = new Size(496, 386);
            this.eval_d.TabIndex = 1;
            this.eval_d.TabStop = false;
            this.eval_d.Text = "查询记录";
            // 
            // eval_j
            // 
            this.eval_j.Location = new Point(19, 20);
            this.eval_j.Multiline = true;
            this.eval_j.Name = "eval_j";
            this.eval_j.Size = new Size(458, 352);
            this.eval_j.TabIndex = 0;
            // 
            // eval_a_a
            // 
            this.eval_a_a.Location = new Point(435, 494);
            this.eval_a_a.Name = "eval_a_a";
            this.eval_a_a.Size = new Size(75, 23);
            this.eval_a_a.TabIndex = 4;
            this.eval_a_a.Text = "开始查询";
            this.eval_a_a.UseVisualStyleBackColor = true;
            this.eval_a_a.Click += new EventHandler(this.eval_c);
            // 
            // eval_e
            // 
            this.eval_e.Items.AddRange(new ToolStripItem[] {
            this.eval_p});
            this.eval_e.Location = new Point(0, 0);
            this.eval_e.Name = "eval_e";
            this.eval_e.Size = new Size(567, 25);
            this.eval_e.TabIndex = 5;
            this.eval_e.Text = "menuStrip1";
            // 
            // eval_p
            // 
            this.eval_p.DropDownItems.AddRange(new ToolStripItem[] {
            this.eval_k});
            this.eval_p.Name = "eval_p";
            this.eval_p.Size = new Size(44, 21);
            this.eval_p.Text = "说明";
            // 
            // eval_k
            // 
            this.eval_k.Name = "eval_k";
            this.eval_k.Size = new Size(100, 22);
            this.eval_k.Text = "帮助";
            this.eval_k.Click += new EventHandler(this.eval_a);
            // 
            // CheckCopy
            // 
            this.AutoScaleDimensions = new SizeF(6F, 12F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(567, 529);
            this.Controls.Add(this.eval_a_a);
            this.Controls.Add(this.eval_d);
            this.Controls.Add(this.eval_c_c);
            this.Controls.Add(this.eval_e);
            this.MainMenuStrip = this.eval_e;
            this.Name = "CheckCopy";
            this.Text = "查复制";
            this.FormClosing += new FormClosingEventHandler(this.eval_a);
            this.Load += new EventHandler(this.eval_b);
            this.eval_c_c.ResumeLayout(false);
            this.eval_c_c.PerformLayout();
            this.eval_d.ResumeLayout(false);
            this.eval_d.PerformLayout();
            this.eval_e.ResumeLayout(false);
            this.eval_e.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void eval_a(string A_0)
        {
            if (this.eval_j.InvokeRequired)
            {
                MyInvoke method = new MyInvoke(this.eval_a);
                base.Invoke(method, new object[] { "\r\n" + A_0 });
            }
            else
            {
                this.eval_j.Text = this.eval_j.Text + "\r\n" + A_0;
            }
        }

        private void eval_a(object sender, EventArgs e)
        {
            MessageBox.Show("数据量大的查询时间比较长,必须是停服维护(关闭LoginServer且无玩家登录)才能查询", "帮助");
        }

        private void eval_a(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (this.n != null)
                {
                    this.n = null;
                }
                if (this.dataTable_1 != null)
                {
                    this.dataTable_1 = null;
                }
                if (this.dataTable_0 != null)
                {
                    this.dataTable_0 = null;
                }
                if (this.m != null)
                {
                    this.m = null;
                }
                if (this.q != null)
                {
                    this.q = null;
                }
                if (this.r != null)
                {
                    this.r = null;
                }
            }
            catch
            {
            }
        }

        private void eval_b(object sender, EventArgs e)
        {
            ThreadPool.SetMinThreads(100, 100);
        }

        private void eval_c(object sender, EventArgs e)
        {
            this.n = null;
            this.dataTable_0 = null;
            this.q = null;
            this.dataTable_1 = null;
            this.m = null;
            this.r = null;
            if (World.AllConnectedChars.Count > 0)
            {
                MessageBox.Show("有人物在线不能查询!", "提示");
                return;
            }
            this.eval_a("开始查询....");
            this.eval_a_a.Enabled = false;
            string sqlCommand = string.Format("select FLD_ID,FLD_NAME,FLD_WEARITEM,FLD_ITEM from [TBL_XWWL_Char]", new object[0]);
            string str9 = string.Format("select FLD_ID,FLD_NAME,FLD_ITEM from [TBL_XWWL_Warehouse]", new object[0]);
            string str10 = string.Format("select FLD_ID,FLD_ITEM from [TBL_XWWL_PublicWarehouse]", new object[0]);
            this.n = DBA.GetDBToDataTable(sqlCommand, "GameServer");
            this.dataTable_0 = DBA.GetDBToDataTable(str9, "GameServer");
            this.q = DBA.GetDBToDataTable(str10, "GameServer");
            if (this.eval_f.Checked || this.eval_i.Checked)
            {
                if (this.n.Rows.Count == 0)
                {
                    goto Label_0556;
                }
                if (!this.eval_f.Checked)
                {
                    int num12 = 0;
                Label_0454:
                    if (num12 < this.n.Rows.Count)
                    {
                        byte[] buffer4 = (byte[]) this.n.Rows[num12]["FLD_WEARITEM"];
                        string str4 = this.n.Rows[num12]["FLD_ID"].ToString();
                        string str5 = this.n.Rows[num12]["FLD_NAME"].ToString();
                        int num10 = 0;
                        while (true)
                        {
                            if (num10 < 15)
                            {
                                byte[] dst = new byte[4];
                                Buffer.BlockCopy(buffer4, num10 * 73, dst, 0, 4);
                                int num9 = BitConverter.ToInt32(dst, 0);
                                if (num9 != 0)
                                {
                                    try
                                    {
                                        ThreadParameter state = new ThreadParameter(num9, str4, str5, 1);
                                        ThreadPool.QueueUserWorkItem(new WaitCallback(this.a), state);
                                    }
                                    catch (Exception exception3)
                                    {
                                        this.eval_a("查询已穿装备线程出错" + exception3.ToString());
                                    }
                                }
                            }
                            else
                            {
                                num12++;
                                goto Label_0454;
                            }
                            num10++;
                        }
                    }
                    goto Label_0556;
                }
                int num6 = 0;
            Label_034F:
                if (num6 >= this.n.Rows.Count)
                {
                    goto Label_0556;
                }
                byte[] src = (byte[]) this.n.Rows[num6]["FLD_ITEM"];
                string id = this.n.Rows[num6]["FLD_ID"].ToString();
                string name = this.n.Rows[num6]["FLD_NAME"].ToString();
                int num5 = 0;
                while (true)
                {
                    if (num5 < 36)
                    {
                        byte[] buffer2 = new byte[4];
                        Buffer.BlockCopy(src, num5 * 73, buffer2, 0, 4);
                        int num8 = BitConverter.ToInt32(buffer2, 0);
                        if (num8 != 0)
                        {
                            try
                            {
                                ThreadParameter parameter2 = new ThreadParameter(num8, id, name, 0);
                                ThreadPool.QueueUserWorkItem(new WaitCallback(this.a), parameter2);
                            }
                            catch (Exception exception2)
                            {
                                this.eval_a("查询背包线程出错" + exception2.ToString());
                            }
                        }
                    }
                    else
                    {
                        num6++;
                        goto Label_034F;
                    }
                    num5++;
                }
            }
            if (!this.eval_g.Checked)
            {
                if (this.q.Rows.Count == 0)
                {
                    goto Label_0317;
                }
                int num3 = 0;
            Label_0236:
                if (num3 < this.q.Rows.Count)
                {
                    byte[] buffer = (byte[]) this.q.Rows[num3]["FLD_ITEM"];
                    int num4 = 0;
                    while (true)
                    {
                        if (num4 < 60)
                        {
                            byte[] buffer6 = new byte[4];
                            string str = this.q.Rows[num3]["FLD_ID"].ToString();
                            Buffer.BlockCopy(buffer, num4 * 73, buffer6, 0, 4);
                            int num7 = BitConverter.ToInt32(buffer6, 0);
                            if (num7 != 0)
                            {
                                try
                                {
                                    ThreadParameter parameter = new ThreadParameter(num7, str, "", 3);
                                    ThreadPool.QueueUserWorkItem(new WaitCallback(this.a), parameter);
                                }
                                catch (Exception exception)
                                {
                                    this.eval_a("查询综合仓库线程出错" + exception.ToString());
                                }
                            }
                        }
                        else
                        {
                            num3++;
                            goto Label_0236;
                        }
                        num4++;
                    }
                }
                goto Label_0317;
            }
            if (this.dataTable_0.Rows.Count == 0)
            {
                goto Label_020F;
            }
            int num2 = 0;
        Label_0112:
            if (num2 < this.dataTable_0.Rows.Count)
            {
                byte[] buffer7 = (byte[]) this.dataTable_0.Rows[num2]["FLD_ITEM"];
                int num = 0;
                while (true)
                {
                    if (num < 60)
                    {
                        byte[] buffer8 = new byte[4];
                        string str6 = this.dataTable_0.Rows[num2]["FLD_ID"].ToString();
                        string str7 = this.dataTable_0.Rows[num2]["FLD_NAME"].ToString();
                        Buffer.BlockCopy(buffer7, num * 73, buffer8, 0, 4);
                        int num11 = BitConverter.ToInt32(buffer8, 0);
                        if (num11 != 0)
                        {
                            try
                            {
                                ThreadParameter parameter4 = new ThreadParameter(num11, str6, str7, 2);
                                ThreadPool.QueueUserWorkItem(new WaitCallback(this.a), parameter4);
                            }
                            catch (Exception exception4)
                            {
                                this.eval_a("查询个人仓库线程出错" + exception4.ToString());
                            }
                        }
                    }
                    else
                    {
                        num2++;
                        goto Label_0112;
                    }
                    num++;
                }
            }
        Label_020F:
            this.dataTable_0.Dispose();
            goto Label_0561;
        Label_0317:
            this.q.Dispose();
            goto Label_0561;
        Label_0556:
            this.n.Dispose();
        Label_0561:
            this.eval_a_a.Enabled = true;
        }

        public delegate void MyInvoke(string str);
    }
}


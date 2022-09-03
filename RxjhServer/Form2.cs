using RxjhServer.RxjhServer;

namespace RxjhServer
{
    using DbClss;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;

    public class Form2 : Form
    {
        //private IContainer eval_a_a;
        private System.Windows.Forms.ListView eval_b;
        private ColumnHeader 全局ID;
        private ColumnHeader 物品ID;
        private ColumnHeader 物品名;
        private ColumnHeader 地图;
        private ColumnHeader X;
        private ColumnHeader Y;
        private ColumnHeader 属性0;
        private ColumnHeader 属性1;
        private ColumnHeader 属性2;
        private ColumnHeader 属性3;
        private ColumnHeader 属性4;
        private ColumnHeader 优先;

        public Form2()
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
            this.eval_b = new System.Windows.Forms.ListView();
            this.全局ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.物品ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.物品名 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.地图 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.X = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.属性0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.属性1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.属性2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.属性3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.属性4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.优先 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // eval_b
            // 
            this.eval_b.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.全局ID,
            this.物品ID,
            this.物品名,
            this.地图,
            this.X,
            this.Y,
            this.属性0,
            this.属性1,
            this.属性2,
            this.属性3,
            this.属性4,
            this.优先});
            this.eval_b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eval_b.ForeColor = System.Drawing.SystemColors.WindowText;
            this.eval_b.FullRowSelect = true;
            this.eval_b.GridLines = true;
            this.eval_b.Location = new System.Drawing.Point(0, 0);
            this.eval_b.Name = "eval_b";
            this.eval_b.Size = new System.Drawing.Size(768, 416);
            this.eval_b.TabIndex = 3;
            this.eval_b.UseCompatibleStateImageBehavior = false;
            this.eval_b.View = System.Windows.Forms.View.Details;
            // 
            // 全局ID
            // 
            this.全局ID.Text = "全局ID";
            this.全局ID.Width = 65;
            // 
            // 物品ID
            // 
            this.物品ID.Text = "物品ID";
            this.物品ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.物品ID.Width = 79;
            // 
            // 物品名
            // 
            this.物品名.Text = "物品名";
            this.物品名.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.物品名.Width = 98;
            // 
            // 地图
            // 
            this.地图.Text = "地图";
            this.地图.Width = 42;
            // 
            // X
            // 
            this.X.Text = "X";
            this.X.Width = 61;
            // 
            // Y
            // 
            this.Y.Text = "Y";
            this.Y.Width = 61;
            // 
            // 属性0
            // 
            this.属性0.Text = "属性0";
            this.属性0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 属性1
            // 
            this.属性1.Text = "属性1";
            this.属性1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 属性2
            // 
            this.属性2.Text = "属性2";
            this.属性2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 属性3
            // 
            this.属性3.Text = "属性3";
            this.属性3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 属性4
            // 
            this.属性4.Text = "属性4";
            this.属性4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // 优先
            // 
            this.优先.Text = "优先";
            this.优先.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.优先.Width = 56;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 416);
            this.Controls.Add(this.eval_b);
            this.Name = "Form2";
            this.Text = "地面物品";
            this.Load += new System.EventHandler(this.eval_a);
            this.ResumeLayout(false);

        }

        private void eval_a(object sender, EventArgs e)
        {
            this.eval_b.ListViewItemSorter = new ListViewColumnSorter();
            this.eval_b.ColumnClick += new ColumnClickEventHandler(ListViewHelper.ListView_ColumnClick);
            foreach (GroundItems GroundItems in World.ItmeTeM.Values)
            {
                try
                {
                    string[] items = new string[17];
                    try
                    {
                        items[0] = BitConverter.ToInt64(GroundItems.物品.物品全局ID, 0).ToString();
                        items[1] = BitConverter.ToInt32(GroundItems.物品.Get_Byte_Item_PID, 0).ToString();
                        items[2] = GroundItems.物品.Get_Name();
                        items[3] = GroundItems.Rxjh_Map.ToString();
                        items[4] = GroundItems.Rxjh_X.ToString();
                        items[5] = GroundItems.Rxjh_Y.ToString();
                        items[6] = GroundItems.物品.FLD_MAGIC0.ToString();
                        items[7] = GroundItems.物品.FLD_MAGIC1.ToString();
                        items[8] = GroundItems.物品.FLD_MAGIC2.ToString();
                        items[9] = GroundItems.物品.FLD_MAGIC3.ToString();
                        items[10] = GroundItems.物品.FLD_MAGIC4.ToString();
                        items[11] = GroundItems.物品优先权.UserName;
                    }
                    catch
                    {
                        items[0] = BitConverter.ToInt64(GroundItems.物品.物品全局ID, 0).ToString();
                        items[1] = BitConverter.ToInt32(GroundItems.物品.Get_Byte_Item_PID, 0).ToString();
                        items[2] = GroundItems.物品.Get_Name();
                        items[3] = GroundItems.Rxjh_Map.ToString();
                        items[4] = GroundItems.Rxjh_X.ToString();
                        items[5] = GroundItems.Rxjh_Y.ToString();
                        items[6] = GroundItems.物品.FLD_MAGIC0.ToString();
                        items[7] = GroundItems.物品.FLD_MAGIC1.ToString();
                        items[8] = GroundItems.物品.FLD_MAGIC2.ToString();
                        items[9] = GroundItems.物品.FLD_MAGIC3.ToString();
                        items[10] = GroundItems.物品.FLD_MAGIC4.ToString();
                    }
                    this.eval_b.Items.Insert(this.eval_b.Items.Count, new ListViewItem(items));
                    continue;
                }
                catch
                {
                    continue;
                }
            }
        }

        public static void FlushAll1()
        {
            int num = 0;
            Form1.WriteLine(100, "删除人物数据开始");
            DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_Char", new object[0]));
            if (dBToDataTable != null)
            {
                Form1.WriteLine(100, "共有人物数据" + dBToDataTable.Rows.Count);
                for (int i = 0; i < dBToDataTable.Rows.Count; ++i)
                {
                    num++;
                    Form1.WriteLine(100, string.Concat(new object[] { "删除人物[", dBToDataTable.Rows[i]["FLD_ID"].ToString(), "] [", dBToDataTable.Rows[i]["FLD_NAME"], "]" }));
                    DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_Char WHERE FLD_NAME  ='{0}'", dBToDataTable.Rows[i]["FLD_NAME"].ToString()));
                    DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_warehouse WHERE FLD_NAME  ='{0}'", dBToDataTable.Rows[i]["FLD_NAME"].ToString()));
                    DataTable table2 = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_GuildMember WHERE Name ='{0}'", dBToDataTable.Rows[i]["FLD_NAME"].ToString()));
                    if (table2 != null)
                    {
                        if (table2.Rows.Count > 0)
                        {
                            if (table2.Rows[0]["leve"].ToString() == "6")
                            {
                                Form1.WriteLine(100, "Xóa Guild: " + table2.Rows[0]["G_Name"]);
                                DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_Guild WHERE G_Name  ='{0}'", table2.Rows[0]["G_Name"].ToString()));
                                DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_GuildMember WHERE G_Name  ='{0}'", table2.Rows[0]["G_Name"].ToString()));
                            }
                            else
                            {
                                DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_GuildMember WHERE Name  ='{0}'", dBToDataTable.Rows[i]["FLD_NAME"].ToString()));
                            }
                        }
                        table2.Dispose();
                    }
                }
                dBToDataTable.Dispose();
            }
            Form1.WriteLine(100, "删除人物数据完成" + num);
        }

        public static void FlushAll2()
        {
            int num = 0;
            Form1.WriteLine(100, "删除人物仓库数据开始");
            DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_warehouse", new object[0]));
            if (dBToDataTable != null)
            {
                Form1.WriteLine(100, "共有人物数据" + dBToDataTable.Rows.Count);
                for (int i = 0; i < dBToDataTable.Rows.Count; ++i)
                {
                    DataTable table2 = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_Char where FLD_NAME='{0}'", dBToDataTable.Rows[i]["FLD_NAME"]));
                    if (table2.Rows.Count < 1)
                    {
                        num++;
                        Form1.WriteLine(100, string.Concat(new object[] { "删除人物仓库[", dBToDataTable.Rows[i]["FLD_ID"].ToString(), "] [", dBToDataTable.Rows[i]["FLD_NAME"], "]" }));
                        DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_warehouse WHERE FLD_ID='{0}'and FLD_NAME  ='{1}'", dBToDataTable.Rows[i]["FLD_ID"].ToString(), dBToDataTable.Rows[i]["FLD_NAME"].ToString()));
                    }
                    else if (table2.Rows[0]["FLD_ID"].ToString() != dBToDataTable.Rows[i]["FLD_ID"].ToString())
                    {
                        num++;
                        Form1.WriteLine(100, string.Concat(new object[] { "删除人物仓库[", dBToDataTable.Rows[i]["FLD_ID"].ToString(), "] [", dBToDataTable.Rows[i]["FLD_NAME"], "]" }));
                        DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_warehouse WHERE FLD_ID='{0}'and FLD_NAME  ='{1}'", dBToDataTable.Rows[i]["FLD_ID"].ToString(), dBToDataTable.Rows[i]["FLD_NAME"].ToString()));
                    }
                    table2.Dispose();
                }
                dBToDataTable.Dispose();
            }
            Form1.WriteLine(100, "删除人物仓库数据完成" + num);
        }

        public static void FlushAll3()
        {
            int num = 0;
            Form1.WriteLine(100, "删除宗合仓库开始");
            DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_PublicWarehouse", new object[0]));
            if (dBToDataTable != null)
            {
                Form1.WriteLine(100, "共有宗合仓库数据" + dBToDataTable.Rows.Count);
                for (int i = 0; i < dBToDataTable.Rows.Count; ++i)
                {
                    string.Format("select count(*) from TBL_ACCOUNT where FLD_ID='{0}'", dBToDataTable.Rows[i]["FLD_ID"]);
                    num++;
                    Form1.WriteLine(100, "删除宗合仓库[" + dBToDataTable.Rows[i]["FLD_ID"].ToString() + "]");
                    DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_PublicWarehouse WHERE FLD_ID  ='{0}'", dBToDataTable.Rows[i]["FLD_ID"].ToString()));
                }
                dBToDataTable.Dispose();
            }
            Form1.WriteLine(100, "删除宗合仓库完成" + num);
        }

        public static void FlushAll4()
        {
            int num = 0;
            Form1.WriteLine(100, "删除帮派数据开始");
            DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_Guild", new object[0]));
            if (dBToDataTable != null)
            {
                Form1.WriteLine(100, "共有人物数据" + dBToDataTable.Rows.Count);
                for (int i = 0; i < dBToDataTable.Rows.Count; ++i)
                {
                    DataTable table2 = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_Char where FLD_NAME='{0}'", dBToDataTable.Rows[i]["G_Master"]));
                    if (table2.Rows.Count < 1)
                    {
                        num++;
                        Form1.WriteLine(100, string.Concat(new object[] { "删除帮派[", dBToDataTable.Rows[i]["G_Name"].ToString(), "] [", dBToDataTable.Rows[i]["G_Master"], "]" }));
                        DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_Guild WHERE G_Name  ='{0}'", dBToDataTable.Rows[i]["G_Name"].ToString()));
                        DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_GuildMember WHERE G_Name  ='{0}'", dBToDataTable.Rows[i]["G_Name"].ToString()));
                    }
                    table2.Dispose();
                }
                dBToDataTable.Dispose();
            }
            Form1.WriteLine(100, "删除帮派数据完成" + num);
            FlushAll5();
        }

        public static void FlushAll5()
        {
            int num = 0;
            Form1.WriteLine(100, "删除帮派数据开始");
            DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_GuildMember", new object[0]));
            if (dBToDataTable != null)
            {
                Form1.WriteLine(100, "共有帮派数据" + dBToDataTable.Rows.Count);
                for (int i = 0; i < dBToDataTable.Rows.Count; ++i)
                {
                    DataTable table2 = DBA.GetDBToDataTable(string.Format("select * from TBL_XWWL_Char where FLD_NAME='{0}'", dBToDataTable.Rows[i]["Name"]));
                    if (table2.Rows.Count < 1)
                    {
                        num++;
                        if (dBToDataTable.Rows[0]["leve"].ToString() == "6")
                        {
                            Form1.WriteLine(100, "删除帮派" + dBToDataTable.Rows[i]["G_Name"]);
                            DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_Guild WHERE G_Name  ='{0}'", dBToDataTable.Rows[0]["G_Name"].ToString()));
                            DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_GuildMember WHERE G_Name  ='{0}'", dBToDataTable.Rows[0]["G_Name"].ToString()));
                        }
                        else
                        {
                            Form1.WriteLine(100, string.Concat(new object[] { "删除帮派", dBToDataTable.Rows[i]["G_Name"], "    ", dBToDataTable.Rows[i]["Name"].ToString() }));
                            DBA.ExeSqlCommand(string.Format("DELETE FROM TBL_XWWL_GuildMember WHERE Name  ='{0}'", dBToDataTable.Rows[i]["Name"].ToString()));
                        }
                    }
                    table2.Dispose();
                }
                dBToDataTable.Dispose();
            }
            Form1.WriteLine(100, "删除帮派数据完成" + num);
        }
    }
}


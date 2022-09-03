namespace RxjhTool
{
    using DbClss;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;

    public class YbiForm : Form
    {
        private byte[] a9 = new byte[9216];
        private Label ac;
        private Label ad;
        private Label ae;
        private Label af;
        private Label ag;
        private Label ah;
        private Label ai;
        private byte[] bb = new byte[102400];
        private byte[] bd = new byte[131072];
        private byte[] be = new byte[262144];
        private byte[] bf = new byte[1421312];
        private byte[] bg = new byte[96];
        private byte[] bh = new byte[98304];
        private byte[] bj = new byte[6897664];
        private byte[] bk = new byte[6309568];
        private byte[] bl = new byte[16097280];
        private Button eval_a_a;
        private TextBox eval_a0;
        private TextBox eval_a1;
        private TextBox eval_a2;
        private TextBox eval_a3;
        private TextBox eval_a4;
        private TextBox eval_a5;
        private TextBox eval_a6;
        private TextBox eval_a7;
        private ToolStripMenuItem eval_a8;
        private Label eval_aa;
        private Label eval_ab;
        private ListBox eval_aj;
        private System.Windows.Forms.MenuStrip eval_ak;
        private RadioButton eval_al;
        private RadioButton eval_am;
        private TextBox eval_an;
        private TextBox eval_ao;
        private TextBox eval_ap;
        private TextBox eval_aq;
        private TextBox eval_ar;
        private TextBox eval_as;
        private TextBox eval_at;
        private TextBox eval_au;
        private TextBox eval_av;
        private TextBox eval_aw;
        private TextBox eval_ax;
        private TextBox eval_ay;
        private TextBox eval_az;
        private Button eval_b_b;
        private ToolStripMenuItem eval_ba;
        private ToolStripMenuItem eval_bc;
        private ToolStripMenuItem eval_bi;
        private ToolStripMenuItem eval_bm;
        private byte[] eval_c_c = new byte[256];
        private byte[] eval_d_d = new byte[] { 
            45, 151, 132, 242, 40, 209, 41, 84, 241, 18, 2, 40, 107, 32, 97, 66, 
            245, 236, 31, 82, 34, 68, 59, 35, 87, 63, 98, 111, 242, 163, 36, 210, 
            167, 22, 86, 193, 242, 2, 72, 98, 39, 66, 33, 172, 35, 173, 67, 242, 
            50, 24, 4, 80, 69, 113, 191, 110, 120, 97, 114, 88, 34, 146, 22, 2, 
            120, 98, 215, 40, 82, 223, 232, 179, 66, 20, 177, 166, 110, 49, 175, 38, 
            33, 179, 215, 84, 233, 47, 114, 44, 63, 81, 244, 17, 2, 242, 183, 64, 
            37, 195, 37, 130, 67, 50, 36, 241, 238, 255, 66, 18, 4, 158, 47, 249, 
            100, 33, 246, 49, 114, 8, 116, 130, 35, 25, 222, 207, 35, 39, 56, 54, 
            237, 242, 73, 98, 113, 40, 232, 34, 59, 183, 53, 66, 119, 66, 47, 164, 
            66, 39, 148, 2, 98, 167
         };
        private ComboBox eval_e_e;
        //private IContainer eval_f_f;
        private GroupBox eval_g_g;
        private GroupBox eval_h_h;
        private GroupBox eval_i;
        private Label eval_l;
        private Label eval_m;
        private Label eval_n;
        private Label eval_o;
        private Label eval_p;
        private Label eval_q;
        private Label eval_r;
        private Label eval_s;
        private Label eval_t;
        private Label eval_u;
        private Label eval_v;
        private Label eval_w;
        private Label eval_x;
        private Label eval_y;
        private Label eval_z;
        private static byte[] j;
        private byte[] k = new byte[64];
        public static Dictionary<int, YbiClass> ybidate;

        static YbiForm()
        {
            old_acctor_mc();
        }

        public YbiForm()
        {
            this.InitializeComponent();
            int index = 0;
            do
            {
                this.eval_c_c[index] = (byte) (((((index >> 4) & 1) | ((index >> 2) & 24)) | ((index >> 1) & 64)) | (2 * ((index & 3) | (4 * ((index & 4) | (2 * (index & 248)))))));
                index++;
            }
            while (index < 256);
        }

        private void a()
        {
            ybidate.Clear();
            for (int i = 0; i < 5096; ++i)
            {
                int num3 = 0;
                int num4 = 0;
                int num5 = 0;
                YbiClass class2 = new YbiClass();
                byte[] dst = new byte[848];
                Buffer.BlockCopy(this.bk, i * dst.Length, dst, 0, dst.Length);
                if (BitConverter.ToInt32(dst, 0) == 0)
                {
                    break;
                }
                string item = Encoding.Default.GetString(dst, 8, 64).Replace("\0", "").Replace('\'', ' ');
                if (item == "")
                {
                    item = "未知物品(待命名)";
                }
                string str3 = Encoding.Default.GetString(dst, 156, 256).Replace("\0", "").Replace('\'', ' ');
                switch (str3)
                {
                    case "":
                    case " ":
                        str3 = item;
                        break;
                }
                int num2 = BitConverter.ToInt16(dst, 80);
                this.eval_aj.Items.Add(item);
                int key = BitConverter.ToInt32(dst, 0);
                int num7 = BitConverter.ToInt16(dst, 96);
                class2.FLD_PID = key;
                class2.FLD_Name = item;
                class2.FLD_说明 = str3;
                class2.FLD_ZX = dst[73];
                class2.FLD_RESIDE1 = dst[74];
                if ((class2.FLD_Name.Contains("盒") && !class2.FLD_Name.Contains("江湖小助手礼盒")) && !class2.FLD_Name.Contains("礼券"))
                {
                    class2.FLD_RESIDE2 = 17;
                }
                switch (class2.FLD_RESIDE1)
                {
                    case 11:
                        class2.FLD_RESIDE1 = 6;
                        break;

                    case 12:
                        class2.FLD_RESIDE1 = 7;
                        break;

                    case 13:
                        class2.FLD_RESIDE1 = 8;
                        break;
                }
                class2.FLD_LEVEL = BitConverter.ToInt16(dst, 76);
                class2.FLD_JOB_LEVEL = dst[78];
                class2.FLD_SEX = dst[79];
                class2.FLD_WEIGHT = 0;
                class2.FLD_AT2 = BitConverter.ToInt16(dst, 84);
                class2.FLD_AT1 = BitConverter.ToInt16(dst, 86);
                class2.FLD_DF = BitConverter.ToInt16(dst, 88);
                class2.FLD_CJL = num7;
                class2.FLD_MONEY = BitConverter.ToInt32(dst, 100);
                class2.FLD_EL = BitConverter.ToInt16(dst, 113);
                switch (num2)
                {
                    case 3:
                        num2 = 4;
                        break;

                    case 4:
                        num2 = 5;
                        break;

                    case 5:
                        num2 = 6;
                        break;

                    case 6:
                        num2 = 7;
                        break;

                    case 7:
                        num2 = 8;
                        break;

                    case 8:
                        num2 = 10;
                        break;

                    case 9:
                        num2 = 12;
                        break;

                    case 10:
                        num2 = 16;
                        break;

                    case 11:
                        num2 = 18;
                        break;

                    case 12:
                        num2 = 16;
                        break;

                    case 19:
                        num2 = 16;
                        break;

                    case 21:
                        num2 = 14;
                        break;

                    case 22:
                        num2 = 15;
                        break;
                }
                class2.FLD_RESIDE2 = num2;
                class2.FLD_WX = 0;
                class2.FLD_WXJD = 0;
                if ((key > 900000001) && (key < 1000000000))
                {
                    num3 = 1;
                }
                class2.FLD_QUESTITEM = num3;
                if ((key.ToString().Contains("1008000") || key.ToString().Contains("1690")) || (key.ToString().Contains("2690") || key.ToString().Contains("1007000")))
                {
                    num4 = 6;
                }
                class2.FLD_TYPE = num4;
                if (num7 != 0)
                {
                    string str2 = "2000000";
                    switch (num7.ToString().Length)
                    {
                        case 1:
                            str2 = "200000000";
                            break;

                        case 2:
                            str2 = "20000000";
                            break;

                        case 4:
                            str2 = "200000";
                            break;
                    }
                    num5 = int.Parse(str2 + num7.ToString());
                }
                else
                {
                    num5 = 0;
                }
                class2.FLD_MAGIC1 = num5;
                class2.FLD_SIDE = 0;
                class2.FLD_CJL = 0;
                if (((class2.FLD_Name.Contains("箭") || class2.FLD_Name.Contains("回城")) || class2.FLD_说明.Contains("材料")) && (!class2.FLD_Name.Contains("箭破残阳") && !class2.FLD_Name.Contains("石")))
                {
                    class2.FLD_SIDE = 1;
                }
                if (class2.FLD_Name.Contains("强化石") || class2.FLD_Name.Contains("高级强化石"))
                {
                    class2.FLD_SIDE = 1;
                }
                if ((class2.FLD_Name.Contains("纹龙") || class2.FLD_Name.Contains("绣龙")) || class2.FLD_Name.Contains("金龙"))
                {
                    class2.FLD_CJL = 1000;
                }
                if (((class2.FLD_Name == "玄武") || (class2.FLD_Name == "北天玄武刀")) || class2.FLD_Name.Contains("玄武龙啸"))
                {
                    class2.FLD_CJL = 1000;
                }
                if (((class2.FLD_Name == "青龙") || (class2.FLD_Name == "青天青龙剑")) || class2.FLD_Name.Contains("青龙缠天"))
                {
                    class2.FLD_CJL = 1000;
                }
                if (((class2.FLD_Name == "朱雀") || (class2.FLD_Name == "南天朱雀弓")) || class2.FLD_Name.Contains("朱雀覆火"))
                {
                    class2.FLD_CJL = 1000;
                }
                if (((class2.FLD_Name == "麒麟") || (class2.FLD_Name == "中天麒麟枪")) || class2.FLD_Name.Contains("麒麟踏宇"))
                {
                    class2.FLD_CJL = 1000;
                }
                if (((class2.FLD_Name == "白虎") || (class2.FLD_Name == "西天白虎扇")) || class2.FLD_Name.Contains("虎扇吞日"))
                {
                    class2.FLD_CJL = 1000;
                }
                if (((class2.FLD_Name == "鬼牙") || (class2.FLD_Name == "玄天鬼牙刃")) || class2.FLD_Name.Contains("天兆鬼牙"))
                {
                    class2.FLD_CJL = 1000;
                }
                if (((class2.FLD_Name == "鳳凰") || (class2.FLD_Name == "齐天凤凰琴")) || class2.FLD_Name.Contains("凤凰栾鸣"))
                {
                    class2.FLD_CJL = 1000;
                }
                class2.FLD_MAGIC2 = 0;
                class2.FLD_MAGIC3 = 0;
                class2.FLD_MAGIC4 = 0;
                class2.FLD_MAGIC5 = 0;
                class2.FLD_byte = dst;
                if (!ybidate.ContainsKey(key))
                {
                    ybidate.Add(key, class2);
                }
            }
            this.eval_ab.Text = this.eval_aj.Items.Count.ToString();
        }

        private void c()
        {
            using (FileStream stream = new FileStream("YBi.cfg.bak", FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                BinaryReader tdbReader = new BinaryReader(stream);
                tdbReader.ReadInt32();
                tdbReader.ReadInt32();
                this.读取数据(tdbReader, 848, 4238, ref this.bk);
                this.读取数据(tdbReader, 64, 1, ref this.k);
                this.读取数据(tdbReader, 6736, 1024, ref this.bj);
                this.读取数据(tdbReader, 1388, 1024, ref this.bf);
                this.读取数据(tdbReader, 72, 128, ref this.a9);
                this.读取数据(tdbReader, 64, 2048, ref this.bd);
                this.读取数据(tdbReader, 128, 2048, ref this.be);
                this.读取数据(tdbReader, 7860, 2048, ref this.bl);
                this.读取数据(tdbReader, 16, 6, ref this.bg);
                this.读取数据(tdbReader, 100, 1024, ref this.bb);
                this.读取数据(tdbReader, 96, 1024, ref this.bh);
            }
            this.a();
        }

        protected override void Dispose(bool disposing)
        {
            //if (disposing && (this.eval_f_f != null))
            //{
            //    this.eval_f_f.Dispose();
            //}
            base.Dispose(disposing);
        }

        private YbiClass eval_a(int A_0)
        {
            YbiClass class3;
            using (Dictionary<int, YbiClass>.ValueCollection.Enumerator enumerator = ybidate.Values.GetEnumerator())
            {
                YbiClass current;
                while (enumerator.MoveNext())
                {
                    current = enumerator.Current;
                    if (current.FLD_RESIDE2 == A_0)
                    {
                        goto Label_0031;
                    }
                }
                return null;
            Label_0031:
                class3 = current;
            }
            return class3;
        }

        private YbiClass eval_a(string A_0)
        {
            YbiClass class3;
            using (Dictionary<int, YbiClass>.ValueCollection.Enumerator enumerator = ybidate.Values.GetEnumerator())
            {
                YbiClass current;
                while (enumerator.MoveNext())
                {
                    current = enumerator.Current;
                    if (current.FLD_Name == A_0)
                    {
                        goto Label_0034;
                    }
                }
                return null;
            Label_0034:
                class3 = current;
            }
            return class3;
        }

        private void eval_a(object sender, EventArgs e)
        {
            try
            {
                if (this.eval_aj.Items.Count == 0)
                {
                    MessageBox.Show("请先打开Ybi.cfg文件!", "提示");
                }
                else
                {
                    int num6 = 0;
                    int num2 = 0;
                    foreach (YbiClass class2 in ybidate.Values)
                    {
                        if ((class2.FLD_PID > 900000001) && (class2.FLD_PID < 1000000000))
                        {
                            class2.FLD_QUESTITEM = 1;
                            class2.FLD_SIDE = 1;
                        }
                        if ((!class2.FLD_PID.ToString().Contains("1008000") && !class2.FLD_PID.ToString().Contains("1690")) && (!class2.FLD_PID.ToString().Contains("2690") && !class2.FLD_PID.ToString().Contains("1007000")))
                        {
                            class2.FLD_TYPE = 0;
                        }
                        else
                        {
                            class2.FLD_TYPE = 6;
                        }
                        if (class2.FLD_PID == 111301009)
                        {
                            class2.FLD_CJL = 0;
                        }
                        if (class2.FLD_CJL != 0)
                        {
                            string str = "2000000";
                            switch (class2.FLD_CJL.ToString().Length)
                            {
                                case 1:
                                    str = "200000000";
                                    break;

                                case 2:
                                    str = "20000000";
                                    break;

                                case 4:
                                    str = "200000";
                                    break;
                            }
                            num6 = int.Parse(str + class2.FLD_CJL.ToString());
                        }
                        else
                        {
                            num6 = 0;
                        }
                        class2.FLD_MAGIC1 = num6;
                        DataTable dBToDataTable = DBA.GetDBToDataTable(string.Format("SELECT * FROM TBL_XWWL_ITEM WHERE FLD_PID = {0}", class2.FLD_PID.ToString()), "PublicDb");
                        if (dBToDataTable != null)
                        {
                            if (dBToDataTable.Rows.Count == 0)
                            {
                                DBA.ExeSqlCommand(string.Format("INSERT INTO TBL_XWWL_ITEM (FLD_PID, FLD_NAME, FLD_RESIDE1, FLD_RESIDE2, FLD_SEX, FLD_DF, FLD_AT1, FLD_AT2, FLD_LEVEL, FLD_JOB_LEVEL, FLD_ZX, FLD_MONEY, FLD_WEIGHT,FLD_DES,FLD_WX,FLD_WXJD,FLD_EL,FLD_QUESTITEM,FLD_CJL,FLD_TYPE,FLD_MAGIC1,FLD_MAGIC2,FLD_MAGIC3,FLD_MAGIC4,FLD_MAGIC5,FLD_SIDE,fld_cjl) VALUES ({0}, '{1}', {2}, {3},{4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12},'{13}',{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26})", new object[] { 
                                    class2.FLD_PID, class2.FLD_Name, class2.FLD_RESIDE1, class2.FLD_RESIDE2, class2.FLD_SEX, class2.FLD_DF, class2.FLD_AT1, class2.FLD_AT2, class2.FLD_LEVEL, class2.FLD_JOB_LEVEL, class2.FLD_ZX, class2.FLD_MONEY, class2.FLD_WEIGHT, class2.FLD_说明, class2.FLD_WX, class2.FLD_WXJD, 
                                    class2.FLD_EL, class2.FLD_QUESTITEM, class2.FLD_CJL, class2.FLD_TYPE, class2.FLD_MAGIC1, 0, 0, 0, 0, class2.FLD_SIDE, class2.FLD_CJL
                                 }), "PublicDb");
                                num2++;
                            }
                            dBToDataTable.Clear();
                            dBToDataTable.Dispose();
                        }
                    }
                    MessageBox.Show("完成,共增加新物品" + num2.ToString(), "提示");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "错误");
            }
        }

        private void eval_a(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (ybidate != null)
                {
                    ybidate.Clear();
                }
                this.bk = null;
                this.k = null;
                this.bj = null;
                this.bf = null;
                this.a9 = null;
                this.bd = null;
                this.be = null;
                this.bl = null;
                this.bg = null;
                this.bb = null;
                this.bh = null;
            }
            catch (Exception)
            {
            }
        }

        private void eval_b()
        {
            try
            {
                using (FileStream stream = new FileStream("YBi.cfg1.bak", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    using (FileStream stream2 = new FileStream("YBiNew.cfg", FileMode.Create, FileAccess.Write, FileShare.Read))
                    {
                        BinaryReader reader = new BinaryReader(stream);
                        stream2.Write(BitConverter.GetBytes(reader.ReadInt32()), 0, 4);
                        stream2.Write(BitConverter.GetBytes(reader.ReadInt32()), 0, 4);
                        byte[] buffer = new byte[4];
                        while (reader.Read(buffer, 0, 4) > 0)
                        {
                            stream2.Write(BitConverter.GetBytes(YbiDecrypt(BitConverter.ToUInt32(buffer, 0), 1)), 0, 4);
                        }
                    }
                }
                MessageBox.Show("完成,新的文件为'YBiNew.cfg'", "提示");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "错误");
            }
        }

        private YbiClass eval_b(int A_0)
        {
            YbiClass class3;
            using (Dictionary<int, YbiClass>.ValueCollection.Enumerator enumerator = ybidate.Values.GetEnumerator())
            {
                YbiClass current;
                while (enumerator.MoveNext())
                {
                    current = enumerator.Current;
                    if (current.FLD_PID == A_0)
                    {
                        goto Label_0031;
                    }
                }
                return null;
            Label_0031:
                class3 = current;
            }
            return class3;
        }

        private void eval_b(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Ybi.cfg file|Ybi.cfg";
            dialog.FilterIndex = 1;
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Stream input = dialog.OpenFile();
                if (input != null)
                {
                    BinaryReader reader = new BinaryReader(input);
                    using (FileStream stream2 = new FileStream("YBi.cfg.bak", FileMode.Create, FileAccess.Write, FileShare.Read))
                    {
                        int num = reader.ReadInt32();
                        int num2 = reader.ReadInt32();
                        stream2.Write(BitConverter.GetBytes(num), 0, 4);
                        stream2.Write(BitConverter.GetBytes(num2), 0, 4);
                        byte[] buffer = new byte[4];
                        while (reader.Read(buffer, 0, 4) > 0)
                        {
                            stream2.Write(BitConverter.GetBytes(YbiDecrypt(BitConverter.ToUInt32(buffer, 0), 0)), 0, 4);
                        }
                    }
                    input.Close();
                }
                this.c();
            }
        }

        private void eval_c(object sender, EventArgs e)
        {
            try
            {
                if (this.eval_aj.Items.Count == 0)
                {
                    MessageBox.Show("请先打开Ybi.cfg文件!", "提示");
                }
                else
                {
                    using (FileStream stream2 = new FileStream("YBi.cfg.bak", FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        using (FileStream stream = new FileStream("YBi.cfg1.bak", FileMode.Create, FileAccess.Write, FileShare.Read))
                        {
                            using (BinaryReader reader = new BinaryReader(stream2))
                            {
                                stream.Write(BitConverter.GetBytes(reader.ReadInt32()), 0, 4);
                                stream.Write(BitConverter.GetBytes(reader.ReadInt32()), 0, 4);
                                int num = 8;
                                stream.Seek(8L, SeekOrigin.Begin);
                                foreach (YbiClass class2 in ybidate.Values)
                                {
                                    byte[] dst = class2.FLD_byte;
                                    byte[] bytes = Encoding.Default.GetBytes(class2.FLD_Name + "\0");
                                    byte[] src = Encoding.Default.GetBytes(class2.FLD_说明 + "\0");
                                    Buffer.BlockCopy(BitConverter.GetBytes(class2.FLD_PID), 0, dst, 0, 4);
                                    Buffer.BlockCopy(BitConverter.GetBytes(class2.FLD_JOB_LEVEL), 0, dst, 78, 1);
                                    Buffer.BlockCopy(BitConverter.GetBytes(class2.FLD_ZX), 0, dst, 73, 1);
                                    Buffer.BlockCopy(BitConverter.GetBytes(class2.FLD_RESIDE1), 0, dst, 74, 1);
                                    Buffer.BlockCopy(BitConverter.GetBytes(class2.FLD_LEVEL), 0, dst, 76, 2);
                                    Buffer.BlockCopy(BitConverter.GetBytes(class2.FLD_SEX), 0, dst, 79, 1);
                                    Buffer.BlockCopy(BitConverter.GetBytes(class2.FLD_RESIDE2), 0, dst, 80, 2);
                                    Buffer.BlockCopy(BitConverter.GetBytes(class2.FLD_WEIGHT), 0, dst, 82, 2);
                                    Buffer.BlockCopy(BitConverter.GetBytes(class2.FLD_AT2), 0, dst, 84, 2);
                                    Buffer.BlockCopy(BitConverter.GetBytes(class2.FLD_AT1), 0, dst, 86, 2);
                                    Buffer.BlockCopy(BitConverter.GetBytes(class2.FLD_DF), 0, dst, 88, 2);
                                    Buffer.BlockCopy(BitConverter.GetBytes(class2.FLD_CJL), 0, dst, 96, 2);
                                    Buffer.BlockCopy(BitConverter.GetBytes(class2.FLD_MONEY), 0, dst, 100, 4);
                                    Buffer.BlockCopy(BitConverter.GetBytes(class2.FLD_EL), 0, dst, 113, 2);
                                    Buffer.BlockCopy(bytes, 0, dst, 8, bytes.Length);
                                    Buffer.BlockCopy(src, 0, dst, 116, src.Length);
                                    stream.Write(dst, 0, dst.Length);
                                    num += 848;
                                }
                                stream2.Seek((long) num, SeekOrigin.Begin);
                                byte[] buffer = new byte[4];
                                while (reader.Read(buffer, 0, 4) > 0)
                                {
                                    stream.Write(buffer, 0, buffer.Length);
                                }
                            }
                        }
                    }
                    this.eval_b();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString(), "错误");
            }
        }

        private void InitializeComponent()
        {
            this.eval_ak = new System.Windows.Forms.MenuStrip();
            this.eval_bi = new System.Windows.Forms.ToolStripMenuItem();
            this.eval_ba = new System.Windows.Forms.ToolStripMenuItem();
            this.eval_a8 = new System.Windows.Forms.ToolStripMenuItem();
            this.eval_bc = new System.Windows.Forms.ToolStripMenuItem();
            this.eval_bm = new System.Windows.Forms.ToolStripMenuItem();
            this.eval_aj = new System.Windows.Forms.ListBox();
            this.eval_g_g = new System.Windows.Forms.GroupBox();
            this.eval_h_h = new System.Windows.Forms.GroupBox();
            this.eval_x = new System.Windows.Forms.Label();
            this.eval_a_a = new System.Windows.Forms.Button();
            this.eval_as = new System.Windows.Forms.TextBox();
            this.eval_av = new System.Windows.Forms.TextBox();
            this.eval_aw = new System.Windows.Forms.TextBox();
            this.eval_ax = new System.Windows.Forms.TextBox();
            this.eval_ay = new System.Windows.Forms.TextBox();
            this.eval_az = new System.Windows.Forms.TextBox();
            this.eval_a0 = new System.Windows.Forms.TextBox();
            this.eval_ar = new System.Windows.Forms.TextBox();
            this.eval_aq = new System.Windows.Forms.TextBox();
            this.eval_ap = new System.Windows.Forms.TextBox();
            this.eval_ao = new System.Windows.Forms.TextBox();
            this.eval_a7 = new System.Windows.Forms.TextBox();
            this.eval_a6 = new System.Windows.Forms.TextBox();
            this.eval_a5 = new System.Windows.Forms.TextBox();
            this.eval_a4 = new System.Windows.Forms.TextBox();
            this.eval_a3 = new System.Windows.Forms.TextBox();
            this.eval_a2 = new System.Windows.Forms.TextBox();
            this.eval_a1 = new System.Windows.Forms.TextBox();
            this.eval_au = new System.Windows.Forms.TextBox();
            this.eval_an = new System.Windows.Forms.TextBox();
            this.eval_z = new System.Windows.Forms.Label();
            this.eval_v = new System.Windows.Forms.Label();
            this.eval_u = new System.Windows.Forms.Label();
            this.eval_t = new System.Windows.Forms.Label();
            this.eval_s = new System.Windows.Forms.Label();
            this.eval_r = new System.Windows.Forms.Label();
            this.eval_q = new System.Windows.Forms.Label();
            this.eval_p = new System.Windows.Forms.Label();
            this.eval_o = new System.Windows.Forms.Label();
            this.eval_n = new System.Windows.Forms.Label();
            this.eval_m = new System.Windows.Forms.Label();
            this.ai = new System.Windows.Forms.Label();
            this.ah = new System.Windows.Forms.Label();
            this.ag = new System.Windows.Forms.Label();
            this.af = new System.Windows.Forms.Label();
            this.ae = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.Label();
            this.ac = new System.Windows.Forms.Label();
            this.eval_w = new System.Windows.Forms.Label();
            this.eval_l = new System.Windows.Forms.Label();
            this.eval_aa = new System.Windows.Forms.Label();
            this.eval_ab = new System.Windows.Forms.Label();
            this.eval_at = new System.Windows.Forms.TextBox();
            this.eval_al = new System.Windows.Forms.RadioButton();
            this.eval_am = new System.Windows.Forms.RadioButton();
            this.eval_b_b = new System.Windows.Forms.Button();
            this.eval_i = new System.Windows.Forms.GroupBox();
            this.eval_e_e = new System.Windows.Forms.ComboBox();
            this.eval_y = new System.Windows.Forms.Label();
            this.eval_ak.SuspendLayout();
            this.eval_g_g.SuspendLayout();
            this.eval_h_h.SuspendLayout();
            this.eval_i.SuspendLayout();
            this.SuspendLayout();
            // 
            // eval_ak
            // 
            this.eval_ak.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eval_bi,
            this.eval_bc});
            this.eval_ak.Location = new System.Drawing.Point(0, 0);
            this.eval_ak.Name = "eval_ak";
            this.eval_ak.Size = new System.Drawing.Size(799, 25);
            this.eval_ak.TabIndex = 0;
            this.eval_ak.Text = "menuStrip1";
            // 
            // eval_bi
            // 
            this.eval_bi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eval_ba,
            this.eval_a8});
            this.eval_bi.Name = "eval_bi";
            this.eval_bi.Size = new System.Drawing.Size(44, 21);
            this.eval_bi.Text = "文件";
            // 
            // eval_ba
            // 
            this.eval_ba.Name = "eval_ba";
            this.eval_ba.Size = new System.Drawing.Size(139, 22);
            this.eval_ba.Text = "打开YBi.cfg";
            this.eval_ba.Click += new System.EventHandler(this.eval_b);
            // 
            // eval_a8
            // 
            this.eval_a8.Name = "eval_a8";
            this.eval_a8.Size = new System.Drawing.Size(139, 22);
            this.eval_a8.Text = "保存YBi.cfg";
            this.eval_a8.Click += new System.EventHandler(this.eval_c);
            // 
            // eval_bc
            // 
            this.eval_bc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eval_bm});
            this.eval_bc.Name = "eval_bc";
            this.eval_bc.Size = new System.Drawing.Size(44, 21);
            this.eval_bc.Text = "功能";
            // 
            // eval_bm
            // 
            this.eval_bm.Name = "eval_bm";
            this.eval_bm.Size = new System.Drawing.Size(124, 22);
            this.eval_bm.Text = "物品入库";
            this.eval_bm.Click += new System.EventHandler(this.eval_a);
            // 
            // eval_aj
            // 
            this.eval_aj.FormattingEnabled = true;
            this.eval_aj.ItemHeight = 12;
            this.eval_aj.Location = new System.Drawing.Point(17, 26);
            this.eval_aj.Name = "eval_aj";
            this.eval_aj.Size = new System.Drawing.Size(192, 352);
            this.eval_aj.TabIndex = 1;
            this.eval_aj.SelectedValueChanged += new System.EventHandler(this.eval_e);
            // 
            // eval_g_g
            // 
            this.eval_g_g.Controls.Add(this.eval_aj);
            this.eval_g_g.Location = new System.Drawing.Point(12, 97);
            this.eval_g_g.Name = "eval_g_g";
            this.eval_g_g.Size = new System.Drawing.Size(225, 399);
            this.eval_g_g.TabIndex = 2;
            this.eval_g_g.TabStop = false;
            this.eval_g_g.Text = "物品列表";
            // 
            // eval_h_h
            // 
            this.eval_h_h.Controls.Add(this.eval_x);
            this.eval_h_h.Controls.Add(this.eval_a_a);
            this.eval_h_h.Controls.Add(this.eval_as);
            this.eval_h_h.Controls.Add(this.eval_av);
            this.eval_h_h.Controls.Add(this.eval_aw);
            this.eval_h_h.Controls.Add(this.eval_ax);
            this.eval_h_h.Controls.Add(this.eval_ay);
            this.eval_h_h.Controls.Add(this.eval_az);
            this.eval_h_h.Controls.Add(this.eval_a0);
            this.eval_h_h.Controls.Add(this.eval_ar);
            this.eval_h_h.Controls.Add(this.eval_aq);
            this.eval_h_h.Controls.Add(this.eval_ap);
            this.eval_h_h.Controls.Add(this.eval_ao);
            this.eval_h_h.Controls.Add(this.eval_a7);
            this.eval_h_h.Controls.Add(this.eval_a6);
            this.eval_h_h.Controls.Add(this.eval_a5);
            this.eval_h_h.Controls.Add(this.eval_a4);
            this.eval_h_h.Controls.Add(this.eval_a3);
            this.eval_h_h.Controls.Add(this.eval_a2);
            this.eval_h_h.Controls.Add(this.eval_a1);
            this.eval_h_h.Controls.Add(this.eval_au);
            this.eval_h_h.Controls.Add(this.eval_an);
            this.eval_h_h.Controls.Add(this.eval_z);
            this.eval_h_h.Controls.Add(this.eval_v);
            this.eval_h_h.Controls.Add(this.eval_u);
            this.eval_h_h.Controls.Add(this.eval_t);
            this.eval_h_h.Controls.Add(this.eval_s);
            this.eval_h_h.Controls.Add(this.eval_r);
            this.eval_h_h.Controls.Add(this.eval_q);
            this.eval_h_h.Controls.Add(this.eval_p);
            this.eval_h_h.Controls.Add(this.eval_o);
            this.eval_h_h.Controls.Add(this.eval_n);
            this.eval_h_h.Controls.Add(this.eval_m);
            this.eval_h_h.Controls.Add(this.ai);
            this.eval_h_h.Controls.Add(this.ah);
            this.eval_h_h.Controls.Add(this.ag);
            this.eval_h_h.Controls.Add(this.af);
            this.eval_h_h.Controls.Add(this.ae);
            this.eval_h_h.Controls.Add(this.ad);
            this.eval_h_h.Controls.Add(this.ac);
            this.eval_h_h.Controls.Add(this.eval_w);
            this.eval_h_h.Controls.Add(this.eval_l);
            this.eval_h_h.Location = new System.Drawing.Point(265, 97);
            this.eval_h_h.Name = "eval_h_h";
            this.eval_h_h.Size = new System.Drawing.Size(518, 399);
            this.eval_h_h.TabIndex = 3;
            this.eval_h_h.TabStop = false;
            this.eval_h_h.Text = "物品属性";
            // 
            // eval_x
            // 
            this.eval_x.AutoSize = true;
            this.eval_x.Location = new System.Drawing.Point(274, 215);
            this.eval_x.Name = "eval_x";
            this.eval_x.Size = new System.Drawing.Size(77, 12);
            this.eval_x.TabIndex = 53;
            this.eval_x.Text = "注:120字以内";
            // 
            // eval_a_a
            // 
            this.eval_a_a.Location = new System.Drawing.Point(417, 368);
            this.eval_a_a.Name = "eval_a_a";
            this.eval_a_a.Size = new System.Drawing.Size(75, 23);
            this.eval_a_a.TabIndex = 52;
            this.eval_a_a.Text = "修改";
            this.eval_a_a.UseVisualStyleBackColor = true;
            this.eval_a_a.Click += new System.EventHandler(this.eval_h);
            // 
            // eval_as
            // 
            this.eval_as.Location = new System.Drawing.Point(356, 194);
            this.eval_as.Multiline = true;
            this.eval_as.Name = "eval_as";
            this.eval_as.Size = new System.Drawing.Size(136, 166);
            this.eval_as.TabIndex = 51;
            // 
            // eval_av
            // 
            this.eval_av.Location = new System.Drawing.Point(356, 163);
            this.eval_av.Name = "eval_av";
            this.eval_av.Size = new System.Drawing.Size(136, 21);
            this.eval_av.TabIndex = 44;
            // 
            // eval_aw
            // 
            this.eval_aw.Location = new System.Drawing.Point(356, 135);
            this.eval_aw.Name = "eval_aw";
            this.eval_aw.Size = new System.Drawing.Size(136, 21);
            this.eval_aw.TabIndex = 43;
            // 
            // eval_ax
            // 
            this.eval_ax.Location = new System.Drawing.Point(356, 107);
            this.eval_ax.Name = "eval_ax";
            this.eval_ax.Size = new System.Drawing.Size(136, 21);
            this.eval_ax.TabIndex = 42;
            // 
            // eval_ay
            // 
            this.eval_ay.Location = new System.Drawing.Point(356, 79);
            this.eval_ay.Name = "eval_ay";
            this.eval_ay.Size = new System.Drawing.Size(136, 21);
            this.eval_ay.TabIndex = 41;
            // 
            // eval_az
            // 
            this.eval_az.Location = new System.Drawing.Point(356, 51);
            this.eval_az.Name = "eval_az";
            this.eval_az.Size = new System.Drawing.Size(136, 21);
            this.eval_az.TabIndex = 40;
            // 
            // eval_a0
            // 
            this.eval_a0.Location = new System.Drawing.Point(356, 23);
            this.eval_a0.Name = "eval_a0";
            this.eval_a0.Size = new System.Drawing.Size(136, 21);
            this.eval_a0.TabIndex = 39;
            // 
            // eval_ar
            // 
            this.eval_ar.Location = new System.Drawing.Point(108, 350);
            this.eval_ar.Name = "eval_ar";
            this.eval_ar.Size = new System.Drawing.Size(136, 21);
            this.eval_ar.TabIndex = 38;
            // 
            // eval_aq
            // 
            this.eval_aq.Location = new System.Drawing.Point(108, 323);
            this.eval_aq.Name = "eval_aq";
            this.eval_aq.Size = new System.Drawing.Size(136, 21);
            this.eval_aq.TabIndex = 37;
            // 
            // eval_ap
            // 
            this.eval_ap.Location = new System.Drawing.Point(108, 296);
            this.eval_ap.Name = "eval_ap";
            this.eval_ap.Size = new System.Drawing.Size(136, 21);
            this.eval_ap.TabIndex = 36;
            // 
            // eval_ao
            // 
            this.eval_ao.Location = new System.Drawing.Point(108, 269);
            this.eval_ao.Name = "eval_ao";
            this.eval_ao.Size = new System.Drawing.Size(136, 21);
            this.eval_ao.TabIndex = 35;
            // 
            // eval_a7
            // 
            this.eval_a7.Location = new System.Drawing.Point(108, 242);
            this.eval_a7.Name = "eval_a7";
            this.eval_a7.Size = new System.Drawing.Size(136, 21);
            this.eval_a7.TabIndex = 34;
            // 
            // eval_a6
            // 
            this.eval_a6.Location = new System.Drawing.Point(108, 215);
            this.eval_a6.Name = "eval_a6";
            this.eval_a6.Size = new System.Drawing.Size(136, 21);
            this.eval_a6.TabIndex = 33;
            // 
            // eval_a5
            // 
            this.eval_a5.Location = new System.Drawing.Point(108, 188);
            this.eval_a5.Name = "eval_a5";
            this.eval_a5.Size = new System.Drawing.Size(136, 21);
            this.eval_a5.TabIndex = 32;
            // 
            // eval_a4
            // 
            this.eval_a4.Location = new System.Drawing.Point(108, 161);
            this.eval_a4.Name = "eval_a4";
            this.eval_a4.Size = new System.Drawing.Size(136, 21);
            this.eval_a4.TabIndex = 31;
            // 
            // eval_a3
            // 
            this.eval_a3.Location = new System.Drawing.Point(108, 134);
            this.eval_a3.Name = "eval_a3";
            this.eval_a3.Size = new System.Drawing.Size(136, 21);
            this.eval_a3.TabIndex = 30;
            // 
            // eval_a2
            // 
            this.eval_a2.Location = new System.Drawing.Point(108, 107);
            this.eval_a2.Name = "eval_a2";
            this.eval_a2.Size = new System.Drawing.Size(136, 21);
            this.eval_a2.TabIndex = 29;
            // 
            // eval_a1
            // 
            this.eval_a1.Location = new System.Drawing.Point(108, 80);
            this.eval_a1.Name = "eval_a1";
            this.eval_a1.Size = new System.Drawing.Size(136, 21);
            this.eval_a1.TabIndex = 28;
            // 
            // eval_au
            // 
            this.eval_au.Location = new System.Drawing.Point(108, 53);
            this.eval_au.Name = "eval_au";
            this.eval_au.Size = new System.Drawing.Size(136, 21);
            this.eval_au.TabIndex = 27;
            // 
            // eval_an
            // 
            this.eval_an.Enabled = false;
            this.eval_an.Location = new System.Drawing.Point(108, 26);
            this.eval_an.Name = "eval_an";
            this.eval_an.Size = new System.Drawing.Size(136, 21);
            this.eval_an.TabIndex = 26;
            // 
            // eval_z
            // 
            this.eval_z.AutoSize = true;
            this.eval_z.Location = new System.Drawing.Point(274, 188);
            this.eval_z.Name = "eval_z";
            this.eval_z.Size = new System.Drawing.Size(53, 12);
            this.eval_z.TabIndex = 24;
            this.eval_z.Text = "FLD_DES:";
            // 
            // eval_v
            // 
            this.eval_v.AutoSize = true;
            this.eval_v.Location = new System.Drawing.Point(274, 161);
            this.eval_v.Name = "eval_v";
            this.eval_v.Size = new System.Drawing.Size(59, 12);
            this.eval_v.TabIndex = 18;
            this.eval_v.Text = "FLD_TYPE:";
            // 
            // eval_u
            // 
            this.eval_u.AutoSize = true;
            this.eval_u.Location = new System.Drawing.Point(12, 56);
            this.eval_u.Name = "eval_u";
            this.eval_u.Size = new System.Drawing.Size(89, 12);
            this.eval_u.TabIndex = 17;
            this.eval_u.Text = "FLD_QUESTITEM:";
            // 
            // eval_t
            // 
            this.eval_t.AutoSize = true;
            this.eval_t.Location = new System.Drawing.Point(274, 53);
            this.eval_t.Name = "eval_t";
            this.eval_t.Size = new System.Drawing.Size(59, 12);
            this.eval_t.TabIndex = 16;
            this.eval_t.Text = "FLD_WXJD:";
            // 
            // eval_s
            // 
            this.eval_s.AutoSize = true;
            this.eval_s.Location = new System.Drawing.Point(274, 26);
            this.eval_s.Name = "eval_s";
            this.eval_s.Size = new System.Drawing.Size(47, 12);
            this.eval_s.TabIndex = 15;
            this.eval_s.Text = "FLD_WX:";
            // 
            // eval_r
            // 
            this.eval_r.AutoSize = true;
            this.eval_r.Location = new System.Drawing.Point(274, 80);
            this.eval_r.Name = "eval_r";
            this.eval_r.Size = new System.Drawing.Size(47, 12);
            this.eval_r.TabIndex = 14;
            this.eval_r.Text = "FLD_EL:";
            // 
            // eval_q
            // 
            this.eval_q.AutoSize = true;
            this.eval_q.Location = new System.Drawing.Point(274, 107);
            this.eval_q.Name = "eval_q";
            this.eval_q.Size = new System.Drawing.Size(65, 12);
            this.eval_q.TabIndex = 13;
            this.eval_q.Text = "FLD_MONEY:";
            // 
            // eval_p
            // 
            this.eval_p.AutoSize = true;
            this.eval_p.Location = new System.Drawing.Point(12, 110);
            this.eval_p.Name = "eval_p";
            this.eval_p.Size = new System.Drawing.Size(47, 12);
            this.eval_p.TabIndex = 12;
            this.eval_p.Text = "FLD_CJL:";
            // 
            // eval_o
            // 
            this.eval_o.AutoSize = true;
            this.eval_o.Location = new System.Drawing.Point(12, 218);
            this.eval_o.Name = "eval_o";
            this.eval_o.Size = new System.Drawing.Size(47, 12);
            this.eval_o.TabIndex = 11;
            this.eval_o.Text = "FLD_DF:";
            // 
            // eval_n
            // 
            this.eval_n.AutoSize = true;
            this.eval_n.Location = new System.Drawing.Point(12, 272);
            this.eval_n.Name = "eval_n";
            this.eval_n.Size = new System.Drawing.Size(53, 12);
            this.eval_n.TabIndex = 10;
            this.eval_n.Text = "FLD_AT2:";
            // 
            // eval_m
            // 
            this.eval_m.AutoSize = true;
            this.eval_m.Location = new System.Drawing.Point(12, 245);
            this.eval_m.Name = "eval_m";
            this.eval_m.Size = new System.Drawing.Size(53, 12);
            this.eval_m.TabIndex = 9;
            this.eval_m.Text = "FLD_AT1:";
            // 
            // ai
            // 
            this.ai.AutoSize = true;
            this.ai.Location = new System.Drawing.Point(274, 134);
            this.ai.Name = "ai";
            this.ai.Size = new System.Drawing.Size(71, 12);
            this.ai.TabIndex = 8;
            this.ai.Text = "FLD_WEIGHT:";
            // 
            // ah
            // 
            this.ah.AutoSize = true;
            this.ah.Location = new System.Drawing.Point(12, 164);
            this.ah.Name = "ah";
            this.ah.Size = new System.Drawing.Size(77, 12);
            this.ah.TabIndex = 7;
            this.ah.Text = "FLD_RESIDE2:";
            // 
            // ag
            // 
            this.ag.AutoSize = true;
            this.ag.Location = new System.Drawing.Point(12, 191);
            this.ag.Name = "ag";
            this.ag.Size = new System.Drawing.Size(53, 12);
            this.ag.TabIndex = 6;
            this.ag.Text = "FLD_SEX:";
            // 
            // af
            // 
            this.af.AutoSize = true;
            this.af.Location = new System.Drawing.Point(12, 326);
            this.af.Name = "af";
            this.af.Size = new System.Drawing.Size(89, 12);
            this.af.TabIndex = 5;
            this.af.Text = "FLD_JOB_LEVEL:";
            // 
            // ae
            // 
            this.ae.AutoSize = true;
            this.ae.Location = new System.Drawing.Point(12, 299);
            this.ae.Name = "ae";
            this.ae.Size = new System.Drawing.Size(65, 12);
            this.ae.TabIndex = 4;
            this.ae.Text = "FLD_LEVEL:";
            // 
            // ad
            // 
            this.ad.AutoSize = true;
            this.ad.Location = new System.Drawing.Point(12, 137);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(77, 12);
            this.ad.TabIndex = 3;
            this.ad.Text = "FLD_RESIDE1:";
            // 
            // ac
            // 
            this.ac.AutoSize = true;
            this.ac.Location = new System.Drawing.Point(12, 353);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(47, 12);
            this.ac.TabIndex = 2;
            this.ac.Text = "FLD_ZX:";
            // 
            // eval_w
            // 
            this.eval_w.AutoSize = true;
            this.eval_w.Location = new System.Drawing.Point(12, 83);
            this.eval_w.Name = "eval_w";
            this.eval_w.Size = new System.Drawing.Size(59, 12);
            this.eval_w.TabIndex = 1;
            this.eval_w.Text = "FLD_NAME:";
            // 
            // eval_l
            // 
            this.eval_l.AutoSize = true;
            this.eval_l.Location = new System.Drawing.Point(12, 29);
            this.eval_l.Name = "eval_l";
            this.eval_l.Size = new System.Drawing.Size(53, 12);
            this.eval_l.TabIndex = 0;
            this.eval_l.Text = "FLD_PID:";
            // 
            // eval_aa
            // 
            this.eval_aa.AutoSize = true;
            this.eval_aa.Location = new System.Drawing.Point(27, 502);
            this.eval_aa.Name = "eval_aa";
            this.eval_aa.Size = new System.Drawing.Size(59, 12);
            this.eval_aa.TabIndex = 4;
            this.eval_aa.Text = "物品总数:";
            // 
            // eval_ab
            // 
            this.eval_ab.AutoSize = true;
            this.eval_ab.Location = new System.Drawing.Point(92, 502);
            this.eval_ab.Name = "eval_ab";
            this.eval_ab.Size = new System.Drawing.Size(47, 12);
            this.eval_ab.TabIndex = 5;
            this.eval_ab.Text = "label28";
            // 
            // eval_at
            // 
            this.eval_at.Location = new System.Drawing.Point(267, 17);
            this.eval_at.Name = "eval_at";
            this.eval_at.Size = new System.Drawing.Size(132, 21);
            this.eval_at.TabIndex = 6;
            // 
            // eval_al
            // 
            this.eval_al.AutoSize = true;
            this.eval_al.Location = new System.Drawing.Point(420, 18);
            this.eval_al.Name = "eval_al";
            this.eval_al.Size = new System.Drawing.Size(41, 16);
            this.eval_al.TabIndex = 7;
            this.eval_al.TabStop = true;
            this.eval_al.Text = "PID";
            this.eval_al.UseVisualStyleBackColor = true;
            // 
            // eval_am
            // 
            this.eval_am.AutoSize = true;
            this.eval_am.Location = new System.Drawing.Point(467, 18);
            this.eval_am.Name = "eval_am";
            this.eval_am.Size = new System.Drawing.Size(59, 16);
            this.eval_am.TabIndex = 8;
            this.eval_am.TabStop = true;
            this.eval_am.Text = "物品名";
            this.eval_am.UseVisualStyleBackColor = true;
            // 
            // eval_b_b
            // 
            this.eval_b_b.Location = new System.Drawing.Point(537, 15);
            this.eval_b_b.Name = "eval_b_b";
            this.eval_b_b.Size = new System.Drawing.Size(67, 23);
            this.eval_b_b.TabIndex = 9;
            this.eval_b_b.Text = "确定";
            this.eval_b_b.UseVisualStyleBackColor = true;
            this.eval_b_b.Click += new System.EventHandler(this.eval_g);
            // 
            // eval_i
            // 
            this.eval_i.Controls.Add(this.eval_e_e);
            this.eval_i.Controls.Add(this.eval_y);
            this.eval_i.Controls.Add(this.eval_b_b);
            this.eval_i.Controls.Add(this.eval_at);
            this.eval_i.Controls.Add(this.eval_am);
            this.eval_i.Controls.Add(this.eval_al);
            this.eval_i.Location = new System.Drawing.Point(12, 34);
            this.eval_i.Name = "eval_i";
            this.eval_i.Size = new System.Drawing.Size(771, 48);
            this.eval_i.TabIndex = 10;
            this.eval_i.TabStop = false;
            this.eval_i.Text = "查找";
            // 
            // eval_e_e
            // 
            this.eval_e_e.FormattingEnabled = true;
            this.eval_e_e.Items.AddRange(new object[] {
            "全部",
            "衣服",
            "护手",
            "武器",
            "靴子",
            "内甲",
            "项链",
            "耳环",
            "戒指",
            "披风",
            "灵兽",
            "石头",
            "盒子",
            "符文",
            "任务物品",
            "百宝",
            "其他"});
            this.eval_e_e.Location = new System.Drawing.Point(88, 15);
            this.eval_e_e.Name = "eval_e_e";
            this.eval_e_e.Size = new System.Drawing.Size(121, 20);
            this.eval_e_e.TabIndex = 11;
            this.eval_e_e.SelectedValueChanged += new System.EventHandler(this.eval_f);
            // 
            // eval_y
            // 
            this.eval_y.AutoSize = true;
            this.eval_y.Location = new System.Drawing.Point(15, 20);
            this.eval_y.Name = "eval_y";
            this.eval_y.Size = new System.Drawing.Size(59, 12);
            this.eval_y.TabIndex = 10;
            this.eval_y.Text = "物品类型:";
            // 
            // YbiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 523);
            this.Controls.Add(this.eval_i);
            this.Controls.Add(this.eval_ab);
            this.Controls.Add(this.eval_aa);
            this.Controls.Add(this.eval_h_h);
            this.Controls.Add(this.eval_g_g);
            this.Controls.Add(this.eval_ak);
            this.MainMenuStrip = this.eval_ak;
            this.Name = "YbiForm";
            this.Text = "YBI编辑器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.eval_a);
            this.Load += new System.EventHandler(this.eval_d);
            this.eval_ak.ResumeLayout(false);
            this.eval_ak.PerformLayout();
            this.eval_g_g.ResumeLayout(false);
            this.eval_h_h.ResumeLayout(false);
            this.eval_h_h.PerformLayout();
            this.eval_i.ResumeLayout(false);
            this.eval_i.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void eval_d(object sender, EventArgs e)
        {
            this.eval_ab.Text = "0";
            this.eval_al.Checked = true;
            this.eval_e_e.SelectedText = "全部";
        }

        private void eval_e(object sender, EventArgs e)
        {
            YbiClass class2 = this.eval_a(this.eval_aj.SelectedItem.ToString());
            if (class2 != null)
            {
                this.eval_an.Text = class2.FLD_PID.ToString();
                this.eval_au.Text = class2.FLD_QUESTITEM.ToString();
                this.eval_a1.Text = class2.FLD_Name;
                this.eval_a2.Text = class2.FLD_CJL.ToString();
                this.eval_a3.Text = class2.FLD_RESIDE1.ToString();
                this.eval_a4.Text = class2.FLD_RESIDE2.ToString();
                this.eval_a5.Text = class2.FLD_SEX.ToString();
                this.eval_a6.Text = class2.FLD_DF.ToString();
                this.eval_a7.Text = class2.FLD_AT1.ToString();
                this.eval_ao.Text = class2.FLD_AT2.ToString();
                this.eval_ap.Text = class2.FLD_LEVEL.ToString();
                this.eval_aq.Text = class2.FLD_JOB_LEVEL.ToString();
                this.eval_ar.Text = class2.FLD_ZX.ToString();
                this.eval_as.Text = class2.FLD_说明;
                this.eval_av.Text = class2.FLD_TYPE.ToString();
                this.eval_aw.Text = class2.FLD_WEIGHT.ToString();
                this.eval_ax.Text = class2.FLD_MONEY.ToString();
                this.eval_ay.Text = class2.FLD_EL.ToString();
                this.eval_az.Text = class2.FLD_WXJD.ToString();
                this.eval_a0.Text = class2.FLD_WX.ToString();
            }
        }

        private void eval_f(object sender, EventArgs e)
        {
            int num = 1;
            string key = this.eval_e_e.SelectedItem.ToString();
            if (key != null)
            {
                int num3 = 0;
                //if (eval_f_f.eval_d == null)
                //{
                    Dictionary<string, int> dictionary1 = new Dictionary<string, int>(17);
                    dictionary1.Add("全部", 0);
                    dictionary1.Add("衣服", 1);
                    dictionary1.Add("护手", 2);
                    dictionary1.Add("武器", 3);
                    dictionary1.Add("靴子", 4);
                    dictionary1.Add("内甲", 5);
                    dictionary1.Add("项链", 6);
                    dictionary1.Add("耳环", 7);
                    dictionary1.Add("戒指", 8);
                    dictionary1.Add("披风", 9);
                    dictionary1.Add("灵兽", 10);
                    dictionary1.Add("石头", 11);
                    dictionary1.Add("盒子", 12);
                    dictionary1.Add("符文", 13);
                    dictionary1.Add("任务物品", 14);
                    dictionary1.Add("其他", 15);
                    dictionary1.Add("百宝", 16);
                //    eval_f_f.eval_d = dictionary1;
                //}
                //if (eval_f_f.eval_d.TryGetValue(key, out num3))
                //{
                    switch (num3)
                    {
                        case 0:
                            num = 3000;
                            goto Label_01C8;

                        case 1:
                            num = 1;
                            goto Label_01C8;

                        case 2:
                            num = 2;
                            goto Label_01C8;

                        case 3:
                            num = 4;
                            goto Label_01C8;

                        case 4:
                            num = 5;
                            goto Label_01C8;

                        case 5:
                            num = 6;
                            goto Label_01C8;

                        case 6:
                            num = 7;
                            goto Label_01C8;

                        case 7:
                            num = 8;
                            goto Label_01C8;

                        case 8:
                            num = 10;
                            goto Label_01C8;

                        case 9:
                            num = 12;
                            goto Label_01C8;

                        case 10:
                            num = 15;
                            goto Label_01C8;

                        case 11:
                            num = 16;
                            goto Label_01C8;

                        case 12:
                            num = 17;
                            goto Label_01C8;

                        case 13:
                            num = 18;
                            goto Label_01C8;

                        case 14:
                            num = 1000;
                            goto Label_01C8;

                        case 15:
                            num = 2000;
                            goto Label_01C8;

                        case 16:
                            num = 4000;
                            goto Label_01C8;
                    //}
                }
            }
            num = 3000;
        Label_01C8:
            this.eval_aj.Items.Clear();
            switch (num)
            {
                case 1:
                    foreach (YbiClass class12 in ybidate.Values)
                    {
                        if (class12.FLD_RESIDE2 == num)
                        {
                            this.eval_aj.Items.Add(class12.FLD_Name);
                        }
                    }
                    break;

                case 2:
                    foreach (YbiClass class15 in ybidate.Values)
                    {
                        if (class15.FLD_RESIDE2 == num)
                        {
                            this.eval_aj.Items.Add(class15.FLD_Name);
                        }
                    }
                    break;

                case 4:
                    foreach (YbiClass class10 in ybidate.Values)
                    {
                        if (class10.FLD_RESIDE2 == num)
                        {
                            this.eval_aj.Items.Add(class10.FLD_Name);
                        }
                    }
                    break;

                case 5:
                    foreach (YbiClass class9 in ybidate.Values)
                    {
                        if (class9.FLD_RESIDE2 == num)
                        {
                            this.eval_aj.Items.Add(class9.FLD_Name);
                        }
                    }
                    break;

                case 6:
                    foreach (YbiClass class8 in ybidate.Values)
                    {
                        if (class8.FLD_RESIDE2 == num)
                        {
                            this.eval_aj.Items.Add(class8.FLD_Name);
                        }
                    }
                    break;

                case 7:
                    foreach (YbiClass class2 in ybidate.Values)
                    {
                        if (class2.FLD_RESIDE2 == num)
                        {
                            this.eval_aj.Items.Add(class2.FLD_Name);
                        }
                    }
                    break;

                case 8:
                    foreach (YbiClass class17 in ybidate.Values)
                    {
                        if (class17.FLD_RESIDE2 == num)
                        {
                            this.eval_aj.Items.Add(class17.FLD_Name);
                        }
                    }
                    break;

                case 10:
                    foreach (YbiClass class11 in ybidate.Values)
                    {
                        if (class11.FLD_RESIDE2 == num)
                        {
                            this.eval_aj.Items.Add(class11.FLD_Name);
                        }
                    }
                    break;

                case 12:
                    foreach (YbiClass class16 in ybidate.Values)
                    {
                        if (class16.FLD_RESIDE2 == num)
                        {
                            this.eval_aj.Items.Add(class16.FLD_Name);
                        }
                    }
                    break;

                case 15:
                    foreach (YbiClass class14 in ybidate.Values)
                    {
                        if (class14.FLD_RESIDE2 == num)
                        {
                            this.eval_aj.Items.Add(class14.FLD_Name);
                        }
                    }
                    break;

                case 16:
                    foreach (YbiClass class4 in ybidate.Values)
                    {
                        if (class4.FLD_RESIDE2 == num)
                        {
                            this.eval_aj.Items.Add(class4.FLD_Name);
                        }
                    }
                    break;

                case 17:
                    foreach (YbiClass class6 in ybidate.Values)
                    {
                        if ((((class6.FLD_PID == 1000000001) || (class6.FLD_PID == 1000000251)) || ((class6.FLD_PID == 1000000250) || (class6.FLD_PID == 1000000071))) || ((((class6.FLD_PID == 1000000006) || (class6.FLD_PID == 1000000005)) || ((class6.FLD_PID == 1000000026) || (class6.FLD_PID == 1000000023) || (class6.FLD_PID == 1000000021))) || (((class6.FLD_PID == 1000000008) || (class6.FLD_PID == 1000000002)) || (class6.FLD_PID == 1000000003)) || (class6.FLD_PID == 1000000004)))
                        {
                            this.eval_aj.Items.Add(class6.FLD_Name);
                        }
                    }
                    break;

                case 18:
                    foreach (YbiClass class3 in ybidate.Values)
                    {
                        if (class3.FLD_RESIDE2 == num)
                        {
                            this.eval_aj.Items.Add(class3.FLD_Name);
                        }
                    }
                    break;

                case 1000:
                    foreach (YbiClass class13 in ybidate.Values)
                    {
                        if ((class13.FLD_PID > 900000001) && (class13.FLD_PID < 1000000000))
                        {
                            this.eval_aj.Items.Add(class13.FLD_Name);
                        }
                    }
                    break;

                case 3000:
                    foreach (YbiClass class7 in ybidate.Values)
                    {
                        this.eval_aj.Items.Add(class7.FLD_Name);
                    }
                    break;

                case 4000:
                    foreach (YbiClass class18 in ybidate.Values)
                    {
                        if (class18.FLD_TYPE == 6)
                        {
                            this.eval_aj.Items.Add(class18.FLD_Name);
                        }
                    }
                    break;

                default:
                    foreach (YbiClass class5 in ybidate.Values)
                    {
                        if (((((((class5.FLD_RESIDE2 != 1) && (class5.FLD_RESIDE2 != 2)) && ((class5.FLD_RESIDE2 != 4) && (class5.FLD_RESIDE2 != 5))) && (((class5.FLD_RESIDE2 != 6) && (class5.FLD_RESIDE2 != 7)) && ((class5.FLD_RESIDE2 != 8) && (class5.FLD_RESIDE2 != 10)))) && ((((class5.FLD_RESIDE2 != 12) && (class5.FLD_RESIDE2 != 15)) && ((class5.FLD_RESIDE2 != 16) && (class5.FLD_RESIDE2 != 17))) && (((class5.FLD_RESIDE2 != 18) && (class5.FLD_PID != 1000000001)) && ((class5.FLD_PID != 1000000251) && (class5.FLD_PID != 1000000250))))) && (((((class5.FLD_PID != 1000000071) && (class5.FLD_PID != 1000000006)) && ((class5.FLD_PID != 1000000005) && (class5.FLD_PID != 1000000026))) && (((class5.FLD_PID != 1000000023) && (class5.FLD_PID != 1000000008)) && ((class5.FLD_PID != 1000000003) && (class5.FLD_PID != 1000000002)))) && ((class5.FLD_PID <= 900000001) || (class5.FLD_PID >= 1000000000)))) && (class5.FLD_TYPE != 6))
                        {
                            this.eval_aj.Items.Add(class5.FLD_Name);
                        }
                    }
                    break;
            }
            this.eval_ab.Text = this.eval_aj.Items.Count.ToString();
        }

        private void eval_g(object sender, EventArgs e)
        {
            if (this.eval_aj.Items.Count == 0)
            {
                MessageBox.Show("请先打开Ybi.cfg文件!", "提示");
            }
            else if (this.eval_at.Text == "")
            {
                MessageBox.Show("请先输入要查询的内容!", "提示");
            }
            else if (this.eval_al.Checked)
            {
                try
                {
                    int num19;
                    int num39;
                    if (!int.TryParse(this.eval_at.Text, NumberStyles.Integer, NumberFormatInfo.CurrentInfo, out num19))
                    {
                        MessageBox.Show("请输入正确的物品ID!", "提示");
                    }
                    else
                    {
                        try
                        {
                            if (int.Parse(this.eval_at.Text) <= 0)
                            {
                                MessageBox.Show("必须是正整数");
                                return;
                            }
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("必须是正整数");
                            return;
                        }
                        int num20 = Convert.ToInt32(this.eval_at.Text);
                        YbiClass class3 = this.eval_b(num20);
                        if (class3 == null)
                        {
                            goto Label_0346;
                        }
                        this.eval_an.Text = class3.FLD_PID.ToString();
                        this.eval_au.Text = class3.FLD_QUESTITEM.ToString();
                        this.eval_a1.Text = class3.FLD_Name;
                        this.eval_a2.Text = class3.FLD_CJL.ToString();
                        this.eval_a3.Text = class3.FLD_RESIDE1.ToString();
                        this.eval_a4.Text = class3.FLD_RESIDE2.ToString();
                        this.eval_a5.Text = class3.FLD_SEX.ToString();
                        this.eval_a6.Text = class3.FLD_DF.ToString();
                        this.eval_a7.Text = class3.FLD_AT1.ToString();
                        this.eval_ao.Text = class3.FLD_AT2.ToString();
                        this.eval_ap.Text = class3.FLD_LEVEL.ToString();
                        this.eval_aq.Text = class3.FLD_JOB_LEVEL.ToString();
                        this.eval_ar.Text = class3.FLD_ZX.ToString();
                        this.eval_as.Text = class3.FLD_说明;
                        this.eval_av.Text = class3.FLD_TYPE.ToString();
                        this.eval_aw.Text = class3.FLD_WEIGHT.ToString();
                        this.eval_ax.Text = class3.FLD_MONEY.ToString();
                        this.eval_ay.Text = class3.FLD_EL.ToString();
                        this.eval_az.Text = class3.FLD_WXJD.ToString();
                        this.eval_a0.Text = class3.FLD_WX.ToString();
                        num39 = 0;
                        while (num39 < this.eval_aj.Items.Count)
                        {
                            if (this.eval_aj.Items[num39].Equals(this.eval_a1.Text))
                            {
                                goto Label_0333;
                            }
                            num39++;
                        }
                    }
                    return;
                Label_0333:
                    this.eval_aj.SetSelected(num39, true);
                    return;
                Label_0346:
                    MessageBox.Show("无此物品,请检查PID是否正确！", "提示");
                }
                catch (Exception exception2)
                {
                    MessageBox.Show(exception2.ToString(), "错误");
                }
            }
            else if (this.eval_am.Checked)
            {
                try
                {
                    YbiClass class2 = this.eval_a(this.eval_at.Text);
                    if (class2 != null)
                    {
                        this.eval_an.Text = class2.FLD_PID.ToString();
                        this.eval_au.Text = class2.FLD_QUESTITEM.ToString();
                        this.eval_a1.Text = class2.FLD_Name;
                        this.eval_a2.Text = class2.FLD_CJL.ToString();
                        this.eval_a3.Text = class2.FLD_RESIDE1.ToString();
                        this.eval_a4.Text = class2.FLD_RESIDE2.ToString();
                        this.eval_a5.Text = class2.FLD_SEX.ToString();
                        this.eval_a6.Text = class2.FLD_DF.ToString();
                        this.eval_a7.Text = class2.FLD_AT1.ToString();
                        this.eval_ao.Text = class2.FLD_AT2.ToString();
                        this.eval_ap.Text = class2.FLD_LEVEL.ToString();
                        this.eval_aq.Text = class2.FLD_JOB_LEVEL.ToString();
                        this.eval_ar.Text = class2.FLD_ZX.ToString();
                        this.eval_as.Text = class2.FLD_说明;
                        this.eval_av.Text = class2.FLD_TYPE.ToString();
                        this.eval_aw.Text = class2.FLD_WEIGHT.ToString();
                        this.eval_ax.Text = class2.FLD_MONEY.ToString();
                        this.eval_ay.Text = class2.FLD_EL.ToString();
                        this.eval_az.Text = class2.FLD_WXJD.ToString();
                        this.eval_a0.Text = class2.FLD_WX.ToString();
                    }
                    else
                    {
                        MessageBox.Show("无此物品,请检查物品名是否正确！", "提示");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString(), "错误");
                }
            }
            else
            {
                MessageBox.Show("请选择查询的类型", "提示");
            }
        }

        private void eval_h(object sender, EventArgs e)
        {
            if (this.eval_aj.Items.Count == 0)
            {
                MessageBox.Show("请先打开Ybi.cfg文件!", "提示");
            }
            else if (this.eval_an.Text == "")
            {
                MessageBox.Show("请先选择要修改的物品!", "提示");
            }
            else if (this.eval_as.Text.Length > 120)
            {
                MessageBox.Show("装备说明不能超过120个文字!");
            }
            else if (this.eval_a1.Text.Length > 15)
            {
                MessageBox.Show("装备名称不能超过15个文字!");
            }
            else
            {
                YbiClass class2 = this.eval_b(int.Parse(this.eval_an.Text));
                if (class2 != null)
                {
                    class2.FLD_QUESTITEM = int.Parse(this.eval_au.Text);
                    class2.FLD_Name = this.eval_a1.Text;
                    class2.FLD_CJL = int.Parse(this.eval_a2.Text);
                    class2.FLD_RESIDE1 = int.Parse(this.eval_a3.Text);
                    class2.FLD_RESIDE2 = int.Parse(this.eval_a4.Text);
                    class2.FLD_SEX = int.Parse(this.eval_a5.Text);
                    class2.FLD_DF = int.Parse(this.eval_a6.Text);
                    class2.FLD_AT1 = int.Parse(this.eval_a7.Text);
                    class2.FLD_AT2 = int.Parse(this.eval_ao.Text);
                    class2.FLD_LEVEL = int.Parse(this.eval_ap.Text);
                    class2.FLD_JOB_LEVEL = int.Parse(this.eval_aq.Text);
                    class2.FLD_ZX = int.Parse(this.eval_ar.Text);
                    class2.FLD_说明 = this.eval_as.Text;
                    class2.FLD_TYPE = int.Parse(this.eval_av.Text);
                    class2.FLD_WEIGHT = int.Parse(this.eval_aw.Text);
                    class2.FLD_MONEY = int.Parse(this.eval_ax.Text);
                    class2.FLD_EL = int.Parse(this.eval_ay.Text);
                    class2.FLD_WXJD = int.Parse(this.eval_az.Text);
                    class2.FLD_WX = int.Parse(this.eval_a0.Text);
                    MessageBox.Show("修改成功!");
                }
                else
                {
                    MessageBox.Show("查找物品出错!");
                }
            }
        }

        private static void old_acctor_mc()
        {
            j = new byte[] { 
                18, 29, 7, 25, 15, 31, 22, 27, 9, 26, 3, 13, 19, 14, 20, 11, 
                5, 2, 23, 16, 10, 24, 28, 17, 6, 30, 0, 21, 12, 8, 4, 1, 
                26, 31, 17, 10, 30, 16, 24, 2, 29, 8, 20, 15, 28, 11, 13, 4, 
                19, 23, 0, 12, 14, 27, 6, 18, 21, 3, 9, 7, 22, 1, 25, 5
             };
            ybidate = new Dictionary<int, YbiClass>();
        }

        public static int YbiDecrypt(uint pValue, int inlen)
        {
            int num = 0;
            int num2 = 0;
            for (int i = 0; pValue != 0; ++i)
            {
                int num5 = ((int) pValue) & -2;
                int num4 = ((int) pValue) - num5;
                pValue = pValue >> 1;
                if (num4 > 0)
                {
                    if (inlen == 0)
                    {
                        num2 = j[i];
                    }
                    else
                    {
                        num2 = j[i + 32];
                    }
                    num += num4 << num2;
                }
            }
            return num;
        }

        public void 读取数据(BinaryReader tdbReader, int Size, int Count, ref byte[] 数据)
        {
            for (int i = 0; i < Count; ++i)
            {
                byte[] buffer = new byte[Size];
                tdbReader.Read(buffer, 0, buffer.Length);
                Buffer.BlockCopy(buffer, 0, 数据, i * buffer.Length, buffer.Length);
            }
        }
    }
}


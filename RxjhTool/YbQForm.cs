using RxjhTool;

namespace RxjhTool
{
    using RxjhServer;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Drawing;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;

    public class YbQForm : Form
    {
        private readonly Dictionary<int, RxjhTool.任务类> b = new Dictionary<int, RxjhTool.任务类>();
        private string c = "";
        private string d = "";
        private readonly byte[] eval_a_a = new byte[256];
        //private IContainer eval_e_e;
        private MenuStrip eval_f_f;
        private ToolStripMenuItem eval_g;
        private ToolStripMenuItem eval_h;
        private ToolStripMenuItem eval_i;
        private StatusStrip eval_j;
        private SplitContainer eval_k;
        private ListView eval_l;
        private ColumnHeader eval_m;
        private ColumnHeader eval_n;
        private PropertyGrid eval_o;
        private ToolStripStatusLabel eval_p;
        private ContextMenuStrip eval_q;
        private ToolStripMenuItem eval_r;
        private IContainer components;
        private ToolStripMenuItem eval_s;

        public YbQForm()
        {
            this.InitializeComponent();
            int index = 0;
            do
            {
                this.eval_a_a[index] = (byte) (((((index >> 4) & 1) | ((index >> 2) & 24)) | ((index >> 1) & 64)) | (2 * ((index & 3) | (4 * ((index & 4) | (2 * (index & 248)))))));
                index++;
            }
            while (index < 256);
        }

        private byte[] a(byte[] A_0)
        {
            for (int i = 0; i < A_0.LongLength; ++i)
            {
                int index = 0;
                while (index < this.eval_a_a.Length)
                {
                    if (A_0[i] == this.eval_a_a[index])
                    {
                        goto Label_0028;
                    }
                    index++;
                }
                continue;
            Label_0028:
                A_0[i] = (byte) index;
            }
            return A_0;
        }

        protected override void Dispose(bool disposing)
        {
            //if (disposing && (this.eval_e_e != null))
            //{
            //    this.eval_e_e.Dispose();
            //}
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.eval_f_f = new System.Windows.Forms.MenuStrip();
            this.eval_g = new System.Windows.Forms.ToolStripMenuItem();
            this.eval_h = new System.Windows.Forms.ToolStripMenuItem();
            this.eval_i = new System.Windows.Forms.ToolStripMenuItem();
            this.eval_j = new System.Windows.Forms.StatusStrip();
            this.eval_p = new System.Windows.Forms.ToolStripStatusLabel();
            this.eval_k = new System.Windows.Forms.SplitContainer();
            this.eval_l = new System.Windows.Forms.ListView();
            this.eval_m = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_n = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eval_o = new System.Windows.Forms.PropertyGrid();
            this.eval_q = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eval_r = new System.Windows.Forms.ToolStripMenuItem();
            this.eval_s = new System.Windows.Forms.ToolStripMenuItem();
            this.eval_f_f.SuspendLayout();
            this.eval_j.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eval_k)).BeginInit();
            this.eval_k.Panel1.SuspendLayout();
            this.eval_k.Panel2.SuspendLayout();
            this.eval_k.SuspendLayout();
            this.eval_q.SuspendLayout();
            this.SuspendLayout();
            // 
            // eval_f_f
            // 
            this.eval_f_f.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eval_g});
            this.eval_f_f.Location = new System.Drawing.Point(0, 0);
            this.eval_f_f.Name = "eval_f_f";
            this.eval_f_f.Size = new System.Drawing.Size(705, 25);
            this.eval_f_f.TabIndex = 0;
            this.eval_f_f.Text = "menuStrip1";
            // 
            // eval_g
            // 
            this.eval_g.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eval_h,
            this.eval_i});
            this.eval_g.Name = "eval_g";
            this.eval_g.Size = new System.Drawing.Size(44, 21);
            this.eval_g.Text = "文件";
            // 
            // eval_h
            // 
            this.eval_h.Name = "eval_h";
            this.eval_h.Size = new System.Drawing.Size(144, 22);
            this.eval_h.Text = "打开Ybq.cfg";
            this.eval_h.Click += new System.EventHandler(this.eval_e);
            // 
            // eval_i
            // 
            this.eval_i.Name = "eval_i";
            this.eval_i.Size = new System.Drawing.Size(144, 22);
            this.eval_i.Text = "保存Ybq.cfg";
            this.eval_i.Click += new System.EventHandler(this.eval_d);
            // 
            // eval_j
            // 
            this.eval_j.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eval_p});
            this.eval_j.Location = new System.Drawing.Point(0, 472);
            this.eval_j.Name = "eval_j";
            this.eval_j.Size = new System.Drawing.Size(705, 22);
            this.eval_j.TabIndex = 1;
            this.eval_j.Text = "statusStrip1";
            // 
            // eval_p
            // 
            this.eval_p.Name = "eval_p";
            this.eval_p.Size = new System.Drawing.Size(131, 17);
            this.eval_p.Text = "toolStripStatusLabel1";
            // 
            // eval_k
            // 
            this.eval_k.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eval_k.Location = new System.Drawing.Point(0, 25);
            this.eval_k.Name = "eval_k";
            // 
            // eval_k.Panel1
            // 
            this.eval_k.Panel1.Controls.Add(this.eval_l);
            // 
            // eval_k.Panel2
            // 
            this.eval_k.Panel2.Controls.Add(this.eval_o);
            this.eval_k.Size = new System.Drawing.Size(705, 447);
            this.eval_k.SplitterDistance = 281;
            this.eval_k.TabIndex = 2;
            // 
            // eval_l
            // 
            this.eval_l.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eval_m,
            this.eval_n});
            this.eval_l.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eval_l.FullRowSelect = true;
            this.eval_l.GridLines = true;
            this.eval_l.Location = new System.Drawing.Point(0, 0);
            this.eval_l.Name = "eval_l";
            this.eval_l.Size = new System.Drawing.Size(281, 447);
            this.eval_l.TabIndex = 5;
            this.eval_l.UseCompatibleStateImageBehavior = false;
            this.eval_l.View = System.Windows.Forms.View.Details;
            this.eval_l.SelectedIndexChanged += new System.EventHandler(this.eval_c);
            this.eval_l.MouseClick += new System.Windows.Forms.MouseEventHandler(this.eval_a);
            // 
            // eval_m
            // 
            this.eval_m.Text = "任务ID";
            this.eval_m.Width = 48;
            // 
            // eval_n
            // 
            this.eval_n.Text = "任务名";
            this.eval_n.Width = 140;
            // 
            // eval_o
            // 
            this.eval_o.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eval_o.Location = new System.Drawing.Point(0, 0);
            this.eval_o.Name = "eval_o";
            this.eval_o.Size = new System.Drawing.Size(420, 447);
            this.eval_o.TabIndex = 0;
            // 
            // eval_q
            // 
            this.eval_q.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eval_r,
            this.eval_s});
            this.eval_q.Name = "contextMenuStrip1";
            this.eval_q.Size = new System.Drawing.Size(153, 70);
            // 
            // eval_r
            // 
            this.eval_r.Name = "eval_r";
            this.eval_r.Size = new System.Drawing.Size(152, 22);
            this.eval_r.Text = "删除";
            this.eval_r.Click += new System.EventHandler(this.eval_b);
            // 
            // eval_s
            // 
            this.eval_s.Name = "eval_s";
            this.eval_s.Size = new System.Drawing.Size(152, 22);
            this.eval_s.Text = "生成lua脚本";
            this.eval_s.Click += new System.EventHandler(this.eval_a);
            // 
            // YbQForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 494);
            this.Controls.Add(this.eval_k);
            this.Controls.Add(this.eval_j);
            this.Controls.Add(this.eval_f_f);
            this.MainMenuStrip = this.eval_f_f;
            this.Name = "YbQForm";
            this.Text = "任务修改器";
            this.Load += new System.EventHandler(this.eval_f);
            this.eval_f_f.ResumeLayout(false);
            this.eval_f_f.PerformLayout();
            this.eval_j.ResumeLayout(false);
            this.eval_j.PerformLayout();
            this.eval_k.Panel1.ResumeLayout(false);
            this.eval_k.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eval_k)).EndInit();
            this.eval_k.ResumeLayout(false);
            this.eval_q.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private byte eval_a(byte A_0)
        {
            for (int i = 0; i < this.eval_a_a.Length; ++i)
            {
                if (A_0 == this.eval_a_a[i])
                {
                    A_0 = (byte) i;
                    return A_0;
                }
            }
            return A_0;
        }

        private string eval_a(byte[] A_0, ref int A_1)
        {
            int num = A_1;
            for (int i = num; i < A_0.Length; ++i)
            {
                if ((A_0[i] == 32) || (A_0[i] == 10))
                {
                    byte[] dst = new byte[i - num];
                    Buffer.BlockCopy(A_0, A_1, dst, 0, dst.Length);
                    string str = Encoding.Default.GetString(dst);
                    A_1 += dst.Length + 1;
                    return str;
                }
            }
            return "";
        }

        private void eval_a(FileStream A_0, int A_1)
        {
            byte[] buffer = this.a(Encoding.Default.GetBytes(A_1.ToString()));
            A_0.Write(buffer, 0, buffer.Length);
            A_0.WriteByte(this.eval_a(32));
        }

        private void eval_a(FileStream A_0, string A_1)
        {
            byte[] buffer = this.a(Encoding.Default.GetBytes(A_1));
            this.eval_a(A_0, buffer.Length);
            A_0.Write(buffer, 0, buffer.Length);
            A_0.WriteByte(this.eval_a(32));
        }

        private void eval_a(object sender, EventArgs e)
        {
            int count = this.eval_l.SelectedItems.Count;
            if (count > 0)
            {
                for (int i = count - 1; i >= 0; i--)
                {
                    RxjhTool.任务类 任务类;
                    string text = this.eval_l.SelectedItems[i].SubItems[0].Text;
                    if (this.b.TryGetValue(int.Parse(text), out 任务类))
                    {
                        using (StreamWriter writer = new StreamWriter(new FileStream(Application.StartupPath + @"\Script\MissIon" + 任务类.任务ID.ToString() + ".lua", FileMode.Create, FileAccess.Write, FileShare.Read), Encoding.GetEncoding("gb2312")))
                        {
                            writer.Write("--热血江湖lua脚本生成器v7.0,购买正式版服务端请联系 'Yulgang' \r\n");
                            writer.Write("--[" + 任务类.任务名 + "]阶段数[" + 任务类.任务阶段.Count.ToString() + "]\r\n");
                            writer.Write("function MissIon" + 任务类.任务ID.ToString() + "(UserWorldId,QuestId, CzId, RwJdId)\r\n");
                            writer.Write("  local Player = GetPlayer(UserWorldId)\r\n");
                            writer.Write("  if CzId==1 then\r\n");
                            if ((任务类.任务名.Contains("(正)") || 任务类.任务名.Contains("（正派）")) || 任务类.任务名.Contains("(正派)"))
                            {
                                writer.Write("      if Player.Player_Zx==2 then\r\n");
                                writer.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                writer.Write("      elseif Player.Player_Zx==0 then\r\n");
                                writer.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                writer.Write("      end\r\n");
                            }
                            if ((任务类.任务名.Contains("(邪)") || 任务类.任务名.Contains("（邪派）")) || 任务类.任务名.Contains("(邪派)"))
                            {
                                writer.Write("      if Player.Player_Zx==1 then\r\n");
                                writer.Write("\t\t\tSendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                writer.Write("      elseif Player.Player_Zx==0 then\r\n");
                                writer.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                writer.Write("      end\r\n");
                            }
                            if (任务类.任务名.Contains("/刀)"))
                            {
                                writer.Write("      if Player.Player_Job!=1 then\r\n");
                                writer.Write("         SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                writer.Write("      end\r\n");
                            }
                            if (任务类.任务名.Contains("/剑)"))
                            {
                                writer.Write("      if Player.Player_Job!=2 then\r\n");
                                writer.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                writer.Write("      end\r\n");
                            }
                            if (任务类.任务名.Contains("/枪)"))
                            {
                                writer.Write("      if Player.Player_Job!=3 then\r\n");
                                writer.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                writer.Write("      end\r\n");
                            }
                            if (任务类.任务名.Contains("/弓)"))
                            {
                                writer.Write("      if Player.Player_Job!=4 then\r\n");
                                writer.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                writer.Write("      end\r\n");
                            }
                            if (任务类.任务名.Contains("/医生)"))
                            {
                                writer.Write("      if Player.Player_Job!=5 then\r\n");
                                writer.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                writer.Write("      end\r\n");
                            }
                            if (任务类.任务名.Contains("/刺客)"))
                            {
                                writer.Write("      if Player.Player_Job!=6 then\r\n");
                                writer.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                writer.Write("      end\r\n");
                            }
                            writer.Write("      if Player.Player_Level<" + 任务类.任务等级.ToString() + " then\r\n");
                            writer.Write("          SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                            writer.Write("      else\r\n");
                            writer.Write("          local QuestLevel=GetQuestLevel(UserWorldId,QuestId)\r\n");
                            writer.Write("          if QuestLevel==1 then\r\n");
                            writer.Write("              RwJdId=2\r\n");
                            writer.Write("              AddQuest(UserWorldId,QuestId,RwJdId)\r\n");
                            writer.Write("              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)\r\n");
                            if (任务类.任务阶段.Count == 1)
                            {
                                foreach (任务需要物品类 任务需要物品类 in 任务类.需要物品)
                                {
                                    writer.Write("              local  bool" + 任务需要物品类.物品ID.ToString() + " = GetQuestItme(UserWorldId, " + 任务需要物品类.物品ID.ToString() + ", " + 任务需要物品类.物品数量.ToString() + ")\r\n");
                                    writer.Write("              if bool" + 任务需要物品类.物品ID.ToString() + " then\r\n");
                                    writer.Write("                  AddQuestItme(UserWorldId," + 任务需要物品类.物品ID.ToString() + ",0)\r\n");
                                    writer.Write("              else\r\n");
                                    writer.Write("                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                    writer.Write("              end\r\n");
                                }
                            }
                            else if (任务类.任务阶段.Count > 1)
                            {
                                for (int j = 0; j < (任务类.任务阶段.Count - 1); ++j)
                                {
                                    writer.Write("          elseif QuestLevel==" + ((j + 2)).ToString() + " then\r\n");
                                    foreach (任务需要物品类 任务需要物品类2 in 任务类.任务阶段[j].需要物品)
                                    {
                                        writer.Write("              local  bool" + 任务需要物品类2.物品ID.ToString() + " = GetQuestItme(UserWorldId, " + 任务需要物品类2.物品ID.ToString() + ", " + 任务需要物品类2.物品数量.ToString() + ")\r\n");
                                        writer.Write("              if bool" + 任务需要物品类2.物品ID.ToString() + " then\r\n");
                                        writer.Write("                  AddQuestItme(UserWorldId," + 任务需要物品类2.物品ID.ToString() + ",0)\r\n");
                                        writer.Write("              else\r\n");
                                        writer.Write("                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                        writer.Write("              end\r\n");
                                    }
                                    if ((j + 2) != 任务类.任务阶段.Count)
                                    {
                                        writer.Write("              RwJdId=" + ((j + 3)).ToString() + "\r\n");
                                        writer.Write("              AddQuest(UserWorldId,QuestId,RwJdId)\r\n");
                                        writer.Write("              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)\r\n");
                                    }
                                }
                            }
                            writer.Write("          else\r\n");
                            writer.Write("              SendMissionMsg(UserWorldId,QuestId, 11, RwJdId)\r\n");
                            writer.Write("          end\r\n");
                            writer.Write("      end\r\n");
                            writer.Write("  elseif CzId==2 then\r\n");
                            writer.Write("      RwJdId=1\r\n");
                            writer.Write("      AddQuest(UserWorldId,QuestId,RwJdId)\r\n");
                            writer.Write("      SendMissionMsg(UserWorldId,QuestId, 21, RwJdId)\r\n");
                            writer.Write("  elseif CzId==3 then\r\n");
                            writer.Write("      SendMissionMsg(UserWorldId,QuestId, 31, RwJdId)\r\n");
                            writer.Write("  elseif CzId==5 then\r\n");
                            writer.Write("      local QuestLevel=GetQuestLevel(UserWorldId,QuestId)\r\n");
                            writer.Write("      if QuestLevel==" + 任务类.任务阶段.Count.ToString() + " then\r\n");
                            if (任务类.奖励物品.Count > 0)
                            {
                                foreach (任务奖励物品类 任务奖励物品类 in 任务类.奖励物品)
                                {
                                    writer.Write("              local weiz" + 任务奖励物品类.物品ID.ToString() + "=GetPackage(UserWorldId)\r\n");
                                    writer.Write("              if weiz" + 任务奖励物品类.物品ID.ToString() + "==-1 then\r\n");
                                    writer.Write("                  SendSysMsg(UserWorldId,\"装备栏没有空位了，请清理!\", 9, \"系统提示\")\r\n");
                                    writer.Write("                  SendMissionMsg(UserWorldId,QuestId, 12, RwJdId)\r\n");
                                    writer.Write("                  return \r\n");
                                    writer.Write("              else\r\n");
                                    writer.Write("                  AddItme(UserWorldId," + 任务奖励物品类.物品ID.ToString() + ",weiz" + 任务奖励物品类.物品ID.ToString() + "," + 任务奖励物品类.物品数量.ToString() + ")\r\n");
                                    writer.Write("              end\r\n");
                                }
                            }
                            writer.Write("      end\r\n");
                            writer.Write("      SendMissionMsg(UserWorldId,QuestId, 51, RwJdId)\r\n");
                            writer.Write("  end\r\n");
                            writer.Write("end\r\n");
                        }
                    }
                }
                MessageBox.Show("共生成选中的：" + count.ToString() + "个LUA脚本");
            }
        }

        private void eval_a(object sender, MouseEventArgs e)
        {
            if ((e.Button == MouseButtons.Right) && (this.eval_l.SelectedItems.Count > 0))
            {
                this.eval_q.Show(Control.MousePosition.X, Control.MousePosition.Y);
            }
        }

        private string eval_b(byte[] A_0, ref int A_1)
        {
            try
            {
                byte[] buffer;
                int srcOffset = A_1++;
                int index = srcOffset;
                while (index < A_0.Length)
                {
                    if ((A_0[index] == 32) || (A_0[index] == 10))
                    {
                        goto Label_0032;
                    }
                    index++;
                }
                return "";
            Label_0032:
                buffer = new byte[index - srcOffset];
                Buffer.BlockCopy(A_0, srcOffset, buffer, 0, buffer.Length);
                string s = Encoding.Default.GetString(buffer);
                A_1 += buffer.Length;
                byte[] dst = new byte[int.Parse(s)];
                Buffer.BlockCopy(A_0, A_1, dst, 0, dst.Length);
                string str2 = Encoding.Default.GetString(dst);
                A_1 += dst.Length + 1;
                return str2;
            }
            catch
            {
                return "";
            }
        }

        private void eval_b(object sender, EventArgs e)
        {
            int count = this.eval_l.SelectedItems.Count;
            if (count > 0)
            {
                for (int i = count - 1; i >= 0; i--)
                {
                    int key = Convert.ToInt32(this.eval_l.SelectedItems[i].SubItems[0].Text);
                    this.b.Remove(key);
                    this.eval_l.Items.Remove(this.eval_l.SelectedItems[i]);
                }
            }
        }

        private void eval_c(object sender, EventArgs e)
        {
            if (this.eval_l.SelectedItems.Count > 0)
            {
                RxjhTool.任务类 任务类;
                string text = this.eval_l.SelectedItems[0].SubItems[0].Text;
                if (this.b.TryGetValue(int.Parse(text), out 任务类))
                {
                    CustomPropertyCollection propertys = new CustomPropertyCollection();
                    propertys.Add(new CustomProperty("任务ID1", "任务ID", true, "基本", "任务ID", 任务类));
                    propertys.Add(new CustomProperty("任务名", "任务名", false, "基本", "任务名", 任务类));
                    propertys.Add(new CustomProperty("任务等级", "任务等级", false, "基本", "任务等级", 任务类));
                    propertys.Add(new CustomProperty("任务拒绝提示1", "任务拒绝提示1", false, "基本", "拒绝接受任务后的提示", 任务类, typeof(MultilineStringEditor)));
                    propertys.Add(new CustomProperty("任务拒绝提示2", "任务拒绝提示2", false, "基本", "拒绝接受任务后的提示", 任务类, typeof(MultilineStringEditor)));
                    propertys.Add(new CustomProperty("任务接受提示1", "任务接受提示1", false, "基本", "接受任务后的提示", 任务类, typeof(MultilineStringEditor)));
                    propertys.Add(new CustomProperty("任务接受提示2", "任务接受提示2", false, "基本", "接受任务后的提示", 任务类, typeof(MultilineStringEditor)));
                    propertys.Add(new CustomProperty("NpcID", "NpcID", false, "Npc", "NpcID", 任务类));
                    propertys.Add(new CustomProperty("Npc坐标", "Npc坐标", false, "Npc", "Npc坐标", 任务类, true));
                    propertys.Add(new CustomProperty("奖励物品列表", "奖励物品", false, "奖励物品", "奖励物品", 任务类, typeof(My奖励物品CollectionEditor)));
                    propertys.Add(new CustomProperty("需要物品列表", "需要物品", false, "需要物品", "需要物品", 任务类, typeof(My需要物品CollectionEditor)));
                    propertys.Add(new CustomProperty("不符合内容", "任务欢迎拒绝提示1", false, "任务内容", "打开任务后条件不符合的提示内容", 任务类, typeof(MultilineStringEditor)));
                    propertys.Add(new CustomProperty("符合内容", "任务欢迎接受提示1", false, "任务内容", "打开任务后条件符合的提示内容", 任务类, typeof(MultilineStringEditor)));
                    propertys.Add(new CustomProperty("阶段数量", "任务阶段数量", false, "任务阶段", "任务阶段总数量=阶段列表的数量+1", 任务类));
                    propertys.Add(new CustomProperty("阶段列表", "任务阶段", false, "任务阶段", "任务阶段列表", 任务类, typeof(My任务阶段CollectionEditor)));
                    this.eval_o.SelectedObject = propertys;
                }
            }
        }

        private int eval_c(byte[] A_0, ref int A_1)
        {
            try
            {
                byte[] buffer;
                int srcOffset = A_1++;
                int index = srcOffset;
                while (index < A_0.Length)
                {
                    if ((A_0[index] == 32) || (A_0[index] == 10))
                    {
                        goto Label_002E;
                    }
                    index++;
                }
                return 0;
            Label_002E:
                buffer = new byte[index - srcOffset];
                Buffer.BlockCopy(A_0, srcOffset, buffer, 0, buffer.Length);
                string s = Encoding.Default.GetString(buffer);
                A_1 += buffer.Length;
                return int.Parse(s);
            }
            catch
            {
                return 0;
            }
        }

        private void eval_d(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "cfg files (*.cfg)|*.cfg|All files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(dialog.FileName, FileMode.Create, FileAccess.Write, FileShare.Read))
                    {
                        byte[] bytes = Encoding.Default.GetBytes(this.c);
                        byte[] buffer = Encoding.Default.GetBytes(this.d);
                        byte[] buffer3 = Encoding.Default.GetBytes(this.b.Count.ToString());
                        stream.Write(bytes, 0, bytes.Length);
                        stream.WriteByte(32);
                        stream.Write(buffer, 0, buffer.Length);
                        stream.WriteByte(10);
                        stream.Write(buffer3, 0, buffer3.Length);
                        stream.WriteByte(32);
                        using (Dictionary<int, RxjhTool.任务类>.ValueCollection.Enumerator enumerator = this.b.Values.GetEnumerator())
                        {
                            List<任务阶段类>.Enumerator enumerator2;
                            byte[] buffer4;
                        Label_00CB:
                            if (!enumerator.MoveNext())
                            {
                                return;
                            }
                            RxjhTool.任务类 current = enumerator.Current;
                            this.eval_a(stream, current.任务ID);
                            this.eval_a(stream, current.任务名);
                            this.eval_a(stream, current.任务等级);
                            this.eval_a(stream, current.任务未知1);
                            this.eval_a(stream, current.任务未知2);
                            this.eval_a(stream, current.任务未知3);
                            this.eval_a(stream, current.任务未知4);
                            this.eval_a(stream, current.任务未知5);
                            this.eval_a(stream, current.任务未知6);
                            this.eval_a(stream, current.任务未知7);
                            this.eval_a(stream, current.任务接受提示1);
                            this.eval_a(stream, current.任务拒绝提示1);
                            this.eval_a(stream, current.任务接受提示2);
                            this.eval_a(stream, current.任务拒绝提示2);
                            this.eval_a(stream, current.奖励物品.Count);
                            if (current.奖励物品.Count > 0)
                            {
                                foreach (任务奖励物品类 任务奖励物品类 in current.奖励物品)
                                {
                                    this.eval_a(stream, 任务奖励物品类.物品ID);
                                    this.eval_a(stream, 任务奖励物品类.物品数量);
                                }
                            }
                            if (current.任务阶段数量 <= 0)
                            {
                                goto Label_05B5;
                            }
                            this.eval_a(stream, (int) (current.任务阶段.Count + 1));
                            this.eval_a(stream, current.NpcID);
                            this.eval_a(stream, current.Npc未知1);
                            this.eval_a(stream, current.Npc坐标.地图ID);
                            this.eval_a(stream, current.Npc坐标.坐标X);
                            this.eval_a(stream, current.Npc坐标.坐标Y);
                            this.eval_a(stream, current.需要物品.Count);
                            if (current.需要物品.Count > 0)
                            {
                                foreach (任务需要物品类 任务需要物品类2 in current.需要物品)
                                {
                                    this.eval_a(stream, 任务需要物品类2.物品ID);
                                    this.eval_a(stream, 任务需要物品类2.物品数量);
                                    this.eval_a(stream, 任务需要物品类2.地图ID);
                                    this.eval_a(stream, 任务需要物品类2.坐标X);
                                    this.eval_a(stream, 任务需要物品类2.坐标Y);
                                }
                            }
                            try
                            {
                                if (current.任务欢迎接受提示1.Length > 10)
                                {
                                    while (current.任务欢迎接受提示1.LastIndexOf("\r\n") >= (current.任务欢迎接受提示1.Length - 2))
                                    {
                                        current.任务欢迎接受提示1 = current.任务欢迎接受提示1.Remove(current.任务欢迎接受提示1.Length - 2, 2);
                                    }
                                }
                                if (current.任务欢迎拒绝提示1.Length > 10)
                                {
                                    while (current.任务欢迎拒绝提示1.LastIndexOf("\r\n") >= (current.任务欢迎拒绝提示1.Length - 2))
                                    {
                                        current.任务欢迎拒绝提示1 = current.任务欢迎拒绝提示1.Remove(current.任务欢迎拒绝提示1.Length - 2, 2);
                                    }
                                }
                            }
                            catch (Exception exception)
                            {
                                Form1.WriteLine(1, "保存Ybq.cfg出错-" + exception.Message);
                            }
                            goto Label_05FC;
                        Label_03F4:
                            try
                            {
                                while (enumerator2.MoveNext())
                                {
                                    任务阶段类 任务阶段类 = enumerator2.Current;
                                    this.eval_a(stream, 任务阶段类.任务阶段内容);
                                    this.eval_a(stream, 任务阶段类.NpcID);
                                    this.eval_a(stream, 任务阶段类.Npc未知1);
                                    this.eval_a(stream, 任务阶段类.Npc地图ID);
                                    this.eval_a(stream, 任务阶段类.Npc坐标X);
                                    this.eval_a(stream, 任务阶段类.Npc坐标Y);
                                    this.eval_a(stream, 任务阶段类.需要物品.Count);
                                    if (任务阶段类.需要物品.Count > 0)
                                    {
                                        foreach (任务需要物品类 任务需要物品类 in 任务阶段类.需要物品)
                                        {
                                            this.eval_a(stream, 任务需要物品类.物品ID);
                                            this.eval_a(stream, 任务需要物品类.物品数量);
                                            this.eval_a(stream, 任务需要物品类.地图ID);
                                            this.eval_a(stream, 任务需要物品类.坐标X);
                                            this.eval_a(stream, 任务需要物品类.坐标Y);
                                        }
                                    }
                                    this.eval_a(stream, 任务阶段类.任务条件符合提示1);
                                    this.eval_a(stream, 任务阶段类.任务条件符合提示2);
                                    this.eval_a(stream, 任务阶段类.任务条件符合提示3);
                                    this.eval_a(stream, 任务阶段类.任务条件符合提示4);
                                    this.eval_a(stream, 任务阶段类.任务条件符合提示5);
                                    this.eval_a(stream, 任务阶段类.任务条件不符合提示1);
                                    this.eval_a(stream, 任务阶段类.任务条件不符合提示2);
                                    this.eval_a(stream, 任务阶段类.任务条件不符合提示3);
                                    this.eval_a(stream, 任务阶段类.任务条件不符合提示4);
                                    this.eval_a(stream, 任务阶段类.任务条件不符合提示5);
                                }
                            }
                            finally
                            {
                                enumerator2.Dispose();
                            }
                            this.eval_a(stream, 0);
                            stream.WriteByte(this.eval_a(10));
                            goto Label_00CB;
                        Label_05B5:
                            buffer4 = this.a(Encoding.Default.GetBytes(current.任务阶段.Count.ToString()));
                            stream.Write(buffer4, 0, buffer4.Length);
                            stream.WriteByte(this.eval_a(10));
                            goto Label_00CB;
                        Label_05FC:
                            this.eval_a(stream, current.任务欢迎接受提示1);
                            this.eval_a(stream, current.任务欢迎接受提示2);
                            this.eval_a(stream, current.任务欢迎接受提示3);
                            this.eval_a(stream, current.任务欢迎接受提示4);
                            this.eval_a(stream, current.任务欢迎接受提示5);
                            this.eval_a(stream, current.任务欢迎拒绝提示1);
                            this.eval_a(stream, current.任务欢迎拒绝提示2);
                            this.eval_a(stream, current.任务欢迎拒绝提示3);
                            this.eval_a(stream, current.任务欢迎拒绝提示4);
                            this.eval_a(stream, current.任务欢迎拒绝提示5);
                            enumerator2 = current.任务阶段.GetEnumerator();
                            goto Label_03F4;
                        }
                    }
                }
            }
            catch (Exception exception2)
            {
                Form1.WriteLine(1, "保存Ybq.cfg出错-" + exception2.Message);
            }
        }

        private void eval_e(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Ybq.cfg file|Ybq.cfg";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    this.b.Clear();
                    this.eval_l.Items.Clear();
                    using (FileStream stream = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                    {
                        using (BinaryReader reader = new BinaryReader(stream))
                        {
                            MemoryStream stream2 = new MemoryStream();
                            byte[] buffer = new byte[reader.BaseStream.Length];
                            while (reader.Read(buffer, 0, buffer.Length) > 0)
                            {
                                int num5 = 0;
                                this.c = this.eval_a(buffer, ref num5);
                                this.d = this.eval_a(buffer, ref num5);
                                this.eval_c(buffer, ref num5);
                                for (int i = num5; i < buffer.LongLength; ++i)
                                {
                                    if ((i + 1) >= buffer.LongLength)
                                    {
                                        byte num12 = this.eval_a_a[buffer[i]];
                                        stream2.WriteByte(num12);
                                    }
                                    else if ((buffer[i] == 13) && (buffer[i + 1] == 10))
                                    {
                                        Console.WriteLine(i);
                                    }
                                    else
                                    {
                                        byte num10 = this.eval_a_a[buffer[i]];
                                        stream2.WriteByte(num10);
                                    }
                                }
                            }
                            byte[] buffer2 = stream2.ToArray();
                            int num = 0;
                            while (num < buffer2.Length)
                            {
                                RxjhTool.任务类 任务类 = new RxjhTool.任务类();
                                任务类.任务ID = this.eval_c(buffer2, ref num);
                                任务类.任务名 = this.eval_b(buffer2, ref num);
                                任务类.任务等级 = this.eval_c(buffer2, ref num);
                                任务类.任务未知1 = this.eval_c(buffer2, ref num);
                                任务类.任务未知2 = this.eval_c(buffer2, ref num);
                                任务类.任务未知3 = this.eval_c(buffer2, ref num);
                                任务类.任务未知4 = this.eval_c(buffer2, ref num);
                                任务类.任务未知5 = this.eval_c(buffer2, ref num);
                                任务类.任务未知6 = this.eval_c(buffer2, ref num);
                                任务类.任务未知7 = this.eval_c(buffer2, ref num);
                                任务类.任务接受提示1 = this.eval_b(buffer2, ref num);
                                任务类.任务拒绝提示1 = this.eval_b(buffer2, ref num);
                                任务类.任务接受提示2 = this.eval_b(buffer2, ref num);
                                任务类.任务拒绝提示2 = this.eval_b(buffer2, ref num);
                                int num4 = this.eval_c(buffer2, ref num);
                                for (int j = 0; j < num4; ++j)
                                {
                                    任务奖励物品类 item = new 任务奖励物品类();
                                    item.物品ID = this.eval_c(buffer2, ref num);
                                    item.物品数量 = this.eval_c(buffer2, ref num);
                                    任务类.奖励物品.Add(item);
                                }
                                任务类.任务阶段数量 = this.eval_c(buffer2, ref num);
                                if (任务类.任务阶段数量 > 0)
                                {
                                    任务类.NpcID = this.eval_c(buffer2, ref num);
                                    任务类.Npc未知1 = this.eval_c(buffer2, ref num);
                                    任务类.Npc坐标.地图ID = this.eval_c(buffer2, ref num);
                                    任务类.Npc坐标.坐标X = this.eval_c(buffer2, ref num);
                                    任务类.Npc坐标.坐标Y = this.eval_c(buffer2, ref num);
                                    int num7 = this.eval_c(buffer2, ref num);
                                    for (int k = 0; k < num7; ++k)
                                    {
                                        任务需要物品类 任务需要物品类2 = new 任务需要物品类();
                                        任务需要物品类2.物品ID = this.eval_c(buffer2, ref num);
                                        任务需要物品类2.物品数量 = this.eval_c(buffer2, ref num);
                                        任务需要物品类2.地图ID = this.eval_c(buffer2, ref num);
                                        任务需要物品类2.坐标X = this.eval_c(buffer2, ref num);
                                        任务需要物品类2.坐标Y = this.eval_c(buffer2, ref num);
                                        任务类.需要物品.Add(任务需要物品类2);
                                    }
                                    任务类.任务欢迎接受提示1 = this.eval_b(buffer2, ref num);
                                    任务类.任务欢迎接受提示2 = this.eval_b(buffer2, ref num);
                                    任务类.任务欢迎接受提示3 = this.eval_b(buffer2, ref num);
                                    任务类.任务欢迎接受提示4 = this.eval_b(buffer2, ref num);
                                    任务类.任务欢迎接受提示5 = this.eval_b(buffer2, ref num);
                                    任务类.任务欢迎拒绝提示1 = this.eval_b(buffer2, ref num);
                                    任务类.任务欢迎拒绝提示2 = this.eval_b(buffer2, ref num);
                                    任务类.任务欢迎拒绝提示3 = this.eval_b(buffer2, ref num);
                                    任务类.任务欢迎拒绝提示4 = this.eval_b(buffer2, ref num);
                                    任务类.任务欢迎拒绝提示5 = this.eval_b(buffer2, ref num);
                                    for (int m = 0; m < (任务类.任务阶段数量 - 1); m++)
                                    {
                                        任务阶段类 任务阶段类 = new 任务阶段类();
                                        任务阶段类.任务阶段内容 = this.eval_b(buffer2, ref num);
                                        任务阶段类.NpcID = this.eval_c(buffer2, ref num);
                                        任务阶段类.Npc未知1 = this.eval_c(buffer2, ref num);
                                        任务阶段类.Npc地图ID = this.eval_c(buffer2, ref num);
                                        任务阶段类.Npc坐标X = this.eval_c(buffer2, ref num);
                                        任务阶段类.Npc坐标Y = this.eval_c(buffer2, ref num);
                                        int num11 = this.eval_c(buffer2, ref num);
                                        for (int n = 0; n < num11; n++)
                                        {
                                            任务需要物品类 任务需要物品类 = new 任务需要物品类();
                                            任务需要物品类.物品ID = this.eval_c(buffer2, ref num);
                                            任务需要物品类.物品数量 = this.eval_c(buffer2, ref num);
                                            任务需要物品类.地图ID = this.eval_c(buffer2, ref num);
                                            任务需要物品类.坐标X = this.eval_c(buffer2, ref num);
                                            任务需要物品类.坐标Y = this.eval_c(buffer2, ref num);
                                            任务阶段类.需要物品.Add(任务需要物品类);
                                        }
                                        任务阶段类.任务条件符合提示1 = this.eval_b(buffer2, ref num);
                                        任务阶段类.任务条件符合提示2 = this.eval_b(buffer2, ref num);
                                        任务阶段类.任务条件符合提示3 = this.eval_b(buffer2, ref num);
                                        任务阶段类.任务条件符合提示4 = this.eval_b(buffer2, ref num);
                                        任务阶段类.任务条件符合提示5 = this.eval_b(buffer2, ref num);
                                        任务阶段类.任务条件不符合提示1 = this.eval_b(buffer2, ref num);
                                        任务阶段类.任务条件不符合提示2 = this.eval_b(buffer2, ref num);
                                        任务阶段类.任务条件不符合提示3 = this.eval_b(buffer2, ref num);
                                        任务阶段类.任务条件不符合提示4 = this.eval_b(buffer2, ref num);
                                        任务阶段类.任务条件不符合提示5 = this.eval_b(buffer2, ref num);
                                        任务类.任务阶段.Add(任务阶段类);
                                    }
                                    int num6 = this.eval_c(buffer2, ref num);
                                    if (num6 > 0)
                                    {
                                        Console.WriteLine(num6);
                                    }
                                    num++;
                                }
                                if (!this.b.ContainsKey(任务类.任务ID))
                                {
                                    this.b.Add(任务类.任务ID, 任务类);
                                }
                            }
                            foreach (RxjhTool.任务类 任务类2 in this.b.Values)
                            {
                                string[] items = new string[] { 任务类2.任务ID.ToString(), 任务类2.任务名 };
                                this.eval_l.Items.Insert(this.eval_l.Items.Count, new ListViewItem(items));
                            }
                            this.eval_p.Text = "任务总数:" + this.b.Count;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                Form1.WriteLine(1, "打开Ybq.cfg出错-" + exception.Message);
            }
        }

        private void eval_f(object sender, EventArgs e)
        {
            this.eval_p.Text = "任务总数:" + this.b.Count;
        }
    }
}


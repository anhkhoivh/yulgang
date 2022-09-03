using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using HelperTools;
using LuaInterface;
using Network;
using RxjhTool;
using bbg;
using DbClss;
using RxjhServer.RxjhServer;
using Listener = Network.Listener;
using System.Diagnostics;

namespace RxjhServer
{
    public class Form1 : Form
    {
        private System.Windows.Forms.Timer al;
        private System.Timers.Timer b = new System.Timers.Timer(21000.0);
        private System.Timers.Timer b_TuDongThongBao = new System.Timers.Timer(120000.0);
        private int b1 = 2;
        private static int b2;
        private System.Timers.Timer c_c;
        private static World world;
        private MenuItem eval_a0_a0;
        private MenuItem eval_a1_a1;
        private ToolStripComboBox toolStripComboBox2;
        private MenuItem eval_a3_a3;
        private MenuItem eval_a4_a4;
        private MenuItem eval_a5_a5;
        private MenuItem eval_a6_a6;
        private MenuItem eval_a7_a7;
        private MenuItem eval_a8_a8;
        private MenuItem eval_a9_a9;
        private MenuItem eval_aa_aa;
        private MenuItem eval_ab_ab;
        private MenuItem eval_ac_ac;
        private MenuItem eval_ae_ae;
        private MenuItem eval_af_af;
        private MenuItem Auto_Save;
        private MenuItem eval_ai_ai;
        private MenuItem eval_aj_aj;
        private MenuItem eval_ak_ak;
        private MenuItem eval_am_am;
        private MenuItem eval_an_an;
        private MenuItem eval_ao_ao;
        private ToolStrip eval_ap_ap;
        private ToolStripTextBox eval_aq_aq;
        private ToolStripButton eval_ar_ar;
        private ToolStripTextBox eval_as_as;
        private ToolStripComboBox eval_at_at;
        private ToolStripButton eval_au_au;
        private ToolStripSeparator eval_av_av;
        private ToolStripButton eval_aw_aw;
        private ToolStripSeparator eval_ax_ax;
        private ToolStripButton eval_ay_ay;
        private MenuItem eval_az_az;
        //private IContainer eval_b0;
        private MenuItem eval_ba_ba;
        private MenuItem eval_bb;
        private MenuItem eval_bc;
        private MenuItem eval_bd;
        private MenuItem eval_be;
        private MenuItem eval_bf;
        private MenuItem eval_bg;
        private FlickerFreePanel eval_bh;
        private MenuItem eval_bi;
        private MenuItem eval_bj;
        private MenuItem eval_bk;
        private MenuItem eval_bl;
        private MenuItem eval_bm;
        private MenuItem eval_bn;
        private MenuItem eval_bo;
        private MenuItem eval_bp;
        private MenuItem eval_bq;
        private MenuItem eval_br;
        private MenuItem eval_bs;
        private MenuItem eval_bt;
        private MenuItem eval_bu;
        private MenuItem eval_bv;
        private MenuItem eval_bw;
        private MenuItem eval_bx;
        private MenuItem eval_by;
        private MenuItem eval_bz;
        private MenuItem ReloadGiftCode;
        private MenuItem ReloadDrugs;
        private int eval_d_d;
        private Thread eval_h_h;
        private static Thread timerThread;
        private StatusBar eval_l_l;
        //private StatusBarPanel eval_m_m;
        //private StatusBarPanel eval_n_n;
        private MainMenu eval_o_o;
        private MenuItem eval_p_p;
        private MenuItem eval_q_q;
        private MenuItem eval_r_r;
        private MenuItem eval_s_s;
        private MenuItem eval_t_t;
        private MenuItem eval_u_u;
        private MenuItem eval_v_v;
        private ImageList eval_w_w;
        private MenuItem eval_x_x;
        private MenuItem eval_y_y;
        private MenuItem eval_z_z;
        private static List<TxtClass> f;
        private DateTime g = DateTime.Now;
        private Listener j;
        private StatusBarPanel statusBarPanel1;
        private StatusBarPanel statusBarPanel2;
        private StatusBarPanel statusBarPanel3;
        private StatusBarPanel statusBarPanel4;
        private IContainer components;
        private bool k;

        static Form1()
        {
            old_acctor_mc();
        }

        public Form1()
        {
            Show1.WriteLine(4, "Load Success !!!");
            this.InitializeComponent();
        }

        private void a(object sender, ElapsedEventArgs e)
        {
            if (World.JlMsg == 1)
            {
                WriteLine(0, "Tu dong su tu hong");
            }
            World.Process狮子吼Queue();
        }

        private void TuDongThongBao(object sender, ElapsedEventArgs e)
        {
        }

        private void a(string A_0, int A_1)
        {
            try
            {
                foreach (Players players in World.AllConnectedChars.Values)
                {
                    if (players != null)
                    {
                        if (A_1 == 0)
                        {
                            players.系统公告(A_0);
                        }
                        else
                        {
                            players.系统滚动公告(A_0);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                WriteLine(1, "SetLogs 错误" + exception.Message);
            }
        }

        [STAThread]
        private static void c()
        {
            try
            {
                Application.Run(new Form1());
            }
            catch (Exception exception)
            {
                MessageBox.Show("Main 错误" + exception);
            }
        }

        protected override void Dispose(bool disposing)
        {
            //if (disposing && (this.eval_b0 != null))
            //{
            //    this.eval_b0.Dispose();
            //}
            base.Dispose(disposing);
        }

        
        private void eval_a()
        {
            try
            {
                while (!this.k)
                {
                    Timer.Slice();
                    Thread.Sleep(1000);
                    World.ProcessDisposedQueue();
                    World.ProcessSqlQueue();
                }
            }
            catch (Exception exception)
            {
                WriteLine(1, "FlushAll 错误" + exception.Message);
                if (!this.k)
                {
                    this.eval_h_h = new Thread(new ThreadStart(this.eval_a));
                    this.eval_h_h.Name = "FlushAll";
                    this.eval_h_h.Start();
                }
            }
        }
        
        private void eval_a(object sender, EventArgs e)
        {
            World.Set冲关地图();
        }

        private void eval_a(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (World.AllConnectedChars.Count > 0)
                {
                    foreach (Players players2 in World.AllConnectedChars.Values)
                    {
                        try
                        {
                            players2.SaveDataCharacter();
                            continue;
                        }
                        catch (Exception exception)
                        {
                            WriteLine(1, "保存人物的数据 错误" + exception.Message);
                            continue;
                        }
                    }
                    World.SetGiftCode();
                    World.SetGiftCodeRewards();
                    WriteLine(8, "Save data character success");

                }
                if (World.SqlPool.Count > 0)
                {
                    if (MessageBox.Show("Players Online: " + World.AllConnectedChars.Count, "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
                    {
                        this.k = true;
                        timerThread.Abort();
                        this.eval_h_h.Abort();
                        //ClassDllImport.FreeLib();
                        Application.Exit();
                        Process.GetCurrentProcess().Kill();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    this.k = true;
                    timerThread.Abort();
                    this.eval_h_h.Abort();
                    //ClassDllImport.FreeLib();
                    Application.Exit();
                    Process.GetCurrentProcess().Kill();
                }
            }
            catch
            {
            }
        }

        private void eval_a(object sender, LayoutEventArgs e)
        {
            if (this.eval_bh.Height != 0)
            {
                b2 = this.eval_bh.Height;
            }
        }

        private void eval_a(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics graphics = e.Graphics;
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.PixelOffsetMode = PixelOffsetMode.None;
                string s = string.Concat(new object[] { "连接:", World.List.Count.ToString(), "/", World.最大在线, " 在线:", World.AllConnectedChars.Count, " 主Socket:", World.主Socket.ToString(), " 组队:", World.PartyClass.Count, " 离线队列:", World.MDisposed.Count, " 数据库队列:", World.SqlPool.Count, " 狮子列队:", World.狮子吼List.Count.ToString() });
                graphics.DrawString(s, DefaultFont, Brushes.Yellow, (PointF)new Point(20, 5));
                int num3 = 0;
                foreach (TxtClass class2 in f)
                {
                    switch (class2.type)
                    {
                        case 0:
                            {
                                graphics.DrawString(class2.Txt, DefaultFont, Brushes.Lime, (PointF)new Point(5, num3 += 17));
                                continue;
                            }
                        case 1:
                            {
                                graphics.DrawString(class2.Txt, DefaultFont, Brushes.Red, (PointF)new Point(5, num3 += 17));
                                continue;
                            }
                        case 2:
                            {
                                graphics.DrawString(class2.Txt, DefaultFont, Brushes.Lime, (PointF)new Point(5, num3 += 17));
                                continue;
                            }
                        case 3:
                            {
                                graphics.DrawString(class2.Txt, DefaultFont, Brushes.Green, (PointF)new Point(5, num3 += 17));
                                continue;
                            }
                        case 4:
                            {
                                graphics.DrawString(class2.Txt, DefaultFont, Brushes.Teal, (PointF)new Point(5, num3 += 17));
                                continue;
                            }
                        case 5:
                            {
                                graphics.DrawString(class2.Txt, DefaultFont, Brushes.DodgerBlue, (PointF)new Point(5, num3 += 17));
                                continue;
                            }
                        case 6:
                            {
                                graphics.DrawString(class2.Txt, DefaultFont, Brushes.Blue, (PointF)new Point(5, num3 += 17));
                                continue;
                            }
                    }
                    graphics.DrawString(class2.Txt, DefaultFont, Brushes.Lime, (PointF)new Point(5, num3 += 17));
                }
            }
            catch
            {
            }
        }

        private void eval_a(byte[] A_0, int A_1)
        {
            byte[] dst = new byte[A_1 + 15];
            dst[0] = 170;
            dst[1] = 85;
            Buffer.BlockCopy(BitConverter.GetBytes((int)(A_1 + 9)), 0, dst, 2, 2);
            Buffer.BlockCopy(A_0, 0, dst, 5, A_1);
            dst[dst.Length - 2] = 85;
            dst[dst.Length - 1] = 170;
            Console.WriteLine(Converter.ToString(dst));
        }

        private void eval_a0(object sender, EventArgs e)
        {
            World.SetDrop();
        }

        private void eval_a1(object sender, EventArgs e)
        {
            Queue queue = Queue.Synchronized(new Queue());
            foreach (MapClass class3 in World.Map.Values)
            {
                foreach (NpcClass class4 in class3.npcTemplate.Values)
                {
                    queue.Enqueue(class4);
                }
            }
            while (queue.Count > 0)
            {
                ((NpcClass)queue.Dequeue()).Dispose();
            }
        }

        private void eval_a2(object sender, EventArgs e)
        {
            World.SetDrop();
            World.SetBossDrop();
            World.SetNpcDrop();
            World.SetOpen();
            World.SetKongfu();
            World.SetQuestDrop();
            World.SetItme();
            World.SetShot();
            World.SetMover();
            World.Set公告();
            World.Set移动();
            World.加载百宝阁();
            World.加载转职属性();
            World.加载等级奖励();
            World.加载在线时间奖励();
            World.加载转生次数奖励();
            World.加载物品兑换();
            World.Set石头属性();
            World.Set升天气功();
            World.SetTableOfMedicines();
            World.SetGiftCode();
            World.SetGiftCodeRewards();
        }

        private void eval_a3(object sender, EventArgs e)
        {
            new FormUserParty().ShowDialog();
        }

        private void eval_a4(object sender, EventArgs e)
        {
            new UserList().ShowDialog();
        }

        private void eval_a5(object sender, EventArgs e)
        {
            if (!this.k)
            {
                this.k = true;
                timerThread.Abort();
                this.eval_h_h.Abort();
            }
            else
            {
                
                this.eval_h_h = new Thread(new ThreadStart(this.eval_a));
                this.eval_h_h.Name = "FlushAll";
                this.eval_h_h.Start();
                 
                Timer.TimerThread thread = new Timer.TimerThread();
                timerThread = new Thread(new ThreadStart(thread.TimerMain));
                timerThread.Name = "Timer Thread";
                timerThread.Start();
                 
            }
        }

        private void eval_a6(object sender, EventArgs e)
        {
            string str;
            string str2;
            if (World.JlMsg == 1)
            {
                //WriteLine(0, "timer1_Tick");
            }
            this.eval_bh.Invalidate();
            this.statusBarPanel1.Text = string.Concat(new object[] { "连接:", World.List.Count.ToString(), " 在线:", World.AllConnectedChars.Count });
            this.statusBarPanel2.Text = string.Concat(new object[] { "地图物品:", World.ItmeTeM.Count.ToString(), " 怪物:", MapClass.GetNpcConn() });
            double num5 = World.接收速度;
            double num6 = World.发送速度;
            double num = World.广播发送速度;
            if (num5 >= 1024.0)
            {
                num5 = World.接收速度 / 1024.0;
                str = Math.Round(num5, 0).ToString() + "K";
            }
            else
            {
                str = Math.Round(num5, 0).ToString() + "B";
            }
            if (num6 >= 1024.0)
            {
                num6 = World.发送速度 / 1024.0;
                str2 = Math.Round(num6, 0).ToString() + "K";
            }
            else
            {
                str2 = Math.Round(num6, 0).ToString() + "B";
            }
            if (num >= 1024.0)
            {
                num = World.广播发送速度 / 1024.0;
                string text1 = Math.Round(num, 0).ToString() + "K";
            }
            else
            {
                string text2 = Math.Round(num, 0).ToString() + "B";
            }
            this.statusBarPanel3.Text = "收:" + str + "/s 发:" + str2 + "/s 包:" + Converter.Hexstring.Count.ToString();
            World.接收速度 = 0.0;
            World.发送速度 = 0.0;
            World.广播发送速度 = 0.0;
            TimeSpan span = DateTime.Now.Subtract(this.g);
            this.statusBarPanel4.Text = span.Days.ToString() + "天" + span.Hours.ToString() + "时" + span.Minutes.ToString() + "分" + span.Seconds.ToString() + "秒";
        }

        private void eval_a7(object sender, EventArgs e)
        {
            World.Conn.Dispose();
            List<Players> list = new List<Players>();
            foreach (Players players2 in World.AllConnectedChars.Values)
            {
                list.Add(players2);
            }
            foreach (Players players in list)
            {
                try
                {
                    if (players.Client != null)
                    {
                        players.Client.Dispose();
                    }
                    continue;
                }
                catch (Exception exception)
                {
                    WriteLine(1, "保存人物的数据 错误" + exception.Message);
                    continue;
                }
            }
            list.Clear();
        }

        private void eval_a8(object sender, EventArgs e)
        {
            if (this.j != null)
            {
                this.eval_q_q.Text = "开始主服务";
                this.j.Dispose();
                this.j = null;
            }
            else
            {
                this.eval_q_q.Text = "停止主服务";
                int num = new Random(World.GetRandomSeed()).Next(10, 100);
                this.j = new Network.Listener(World.游戏服务器端口 + num);
            }
        }

        private void eval_a9(object sender, EventArgs e)
        {
            if (World.Conn != null)
            {
                World.Conn.Dispose();
                World.Conn = null;
            }
            World.Conn = new Connect();
            World.Conn.Sestup();
        }

        private void eval_aa(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Form2.FlushAll2));
            thread.Name = "Timer Thread";
            thread.Start();
        }

        private void eval_ab(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Form2.FlushAll1));
            thread.Name = "Timer Thread";
            thread.Start();
        }

        private void eval_ac(object sender, EventArgs e)
        {
            new BinIP().ShowDialog();
        }

        private void eval_ad(object sender, EventArgs e)
        {
            try
            {
                foreach (MapClass class2 in World.Map.Values)
                {
                    foreach (NpcClass class3 in class2.npcTemplate.Values)
                    {
                        class3.Getbl();
                    }
                }
                foreach (TeamClass class4 in World.PartyClass.Values)
                {
                    WriteLine(2, string.Concat(new object[] { "组队:", class4.组队id, " 人物：", class4.List_Party.Count }));
                    foreach (Players players in class4.List_Party.Values)
                    {
                        WriteLine(2, "组队员:" + players.Userid + " 人物：" + players.UserName);
                    }
                }
                using (IEnumerator<Players> enumerator2 = World.AllConnectedChars.Values.GetEnumerator())
                {
                    while (enumerator2.MoveNext())
                    {
                        Players current = enumerator2.Current;
                    }
                }
                foreach (object obj2 in World.Locklist3)
                {
                    WriteLine(2, obj2.ToString());
                }
            }
            catch (Exception exception)
            {
                WriteLine(1, exception.ToString());
            }
            GC.Collect();
        }

        private void eval_ae(object sender, EventArgs e)
        {
            this.复查用户登陆();
        }

        private void eval_af(object sender, EventArgs e)
        {
            try
            {
                foreach (Players players in World.AllConnectedChars.Values)
                {
                    if (players != null)
                    {
                        players.GameMessage(this.eval_as_as.Text, int.Parse(this.eval_at_at.SelectedItem.ToString()), "");
                    }
                }
            }
            catch
            {
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] dst = Converter.hexStringToByte2(this.eval_aq_aq.Text);
                foreach (NetState state in World.List.Values)
                {
                    if (state != null)
                    {
                        if (this.toolStripComboBox2.Text == "正常")
                        {
                            Buffer.BlockCopy(BitConverter.GetBytes(state.WorldId), 0, dst, 5, 2);
                            state.Send单包(dst, dst.Length);
                            this.Send单包(dst, dst.Length);
                        }
                        else
                        {
                            state.Send多包(dst, dst.Length);
                        }
                    }
                }
            }
            catch
            {
            }
            this.b1++;
        }

        private void eval_ah(object sender, EventArgs e)
        {
            World.SetKongfu();
        }

        private void eval_ai(object sender, EventArgs e)
        {
            World.SetKill();
            World.SetJianc();
        }

        private void eval_aj(object sender, EventArgs e)
        {
            World.Set_GSDrop();
        }

        private void eval_ak(object sender, EventArgs e)
        {
            World.SetNpcDrop();
        }

        private void eval_al(object sender, EventArgs e)
        {
            World.SetBossDrop();
        }

        private void eval_am(object sender, EventArgs e)
        {
            World.SetMonSter();
        }

        private void eval_an(object sender, EventArgs e)
        {
            try
            {
                if (this.eval_am_am.Checked)
                {
                    this.eval_am_am.Checked = false;
                    World.AllItmelog = 0;
                }
                else
                {
                    this.eval_am_am.Checked = true;
                    World.AllItmelog = 1;
                }
            }
            catch (Exception exception)
            {
                WriteLine(1, "查物品错误    错误" + exception.Message);
            }
        }

        private void eval_ao(object sender, EventArgs e)
        {
            if (this.eval_ak_ak.Checked)
            {
                this.eval_ak_ak.Checked = false;
                World.AlWorldlog = false;
            }
            else
            {
                this.eval_ak_ak.Checked = true;
                World.AlWorldlog = true;
            }
        }

        private void eval_ap(object sender, EventArgs e)
        {
            if (this.eval_aj_aj.Checked)
            {
                this.eval_aj_aj.Checked = false;
                World.Jllog = 0;
            }
            else
            {
                this.eval_aj_aj.Checked = true;
                World.Jllog = 1;
            }
        }

        private void eval_aq(object sender, EventArgs e)
        {
            if (this.eval_ai_ai.Checked)
            {
                this.eval_ai_ai.Checked = false;
                World.验证服务器log = 0;
            }
            else
            {
                this.eval_ai_ai.Checked = true;
                World.验证服务器log = 1;
            }
        }

        private void Save_Data(object sender, EventArgs e)
        {
            foreach (Players players in World.AllConnectedChars.Values)
            {
                try
                {
                    players.SaveDataCharacter();
                    continue;
                }
                catch (Exception exception)
                {
                    WriteLine(1, "保存人物的数据 错误" + exception.Message);
                    continue;
                }
            }
            //World.SetGiftCode();
            //World.SetGiftCodeRewards();
            WriteLine(8, "Save data character success!!!");
        }

        private void eval_as(object sender, EventArgs e)
        {
            World.SetConfig();
            World.SetstConfig();
            World.SetgjConfig();
            World.Conn.发送(string.Concat(new object[] { "更新服务器配置|", World.服务器id, "|", World.最大在线 }));
            WriteLine(2, "Reload All Config");
        }

        private void eval_at(object sender, EventArgs e)
        {
            if (this.eval_a1_a1.Checked)
            {
                this.eval_a1_a1.Checked = false;
                World.JlMsg = 0;
            }
            else
            {
                this.eval_a1_a1.Checked = true;
                World.JlMsg = 1;
            }
        }

        private void eval_au(object sender, EventArgs e)
        {
            if (this.eval_ae_ae.Checked)
            {
                this.eval_ae_ae.Checked = false;
                World.Log = 0;
            }
            else
            {
                this.eval_ae_ae.Checked = true;
                World.Log = 1;
            }
        }

        private void eval_av(object sender, EventArgs e)
        {
            World.Set公告();
        }

        private void eval_aw(object sender, EventArgs e)
        {
            World.SetMover();
        }

        private void eval_ax(object sender, EventArgs e)
        {
            World.SetShot();
        }

        private void eval_ay(object sender, EventArgs e)
        {
            World.SetItme();
        }

        private void eval_az(object sender, EventArgs e)
        {
            World.SetOpen();
        }

        private static void eval_b()
        {
            try
            {
                LuaFunction function = World.脚本.pLuaVM.GetFunction("OpenItmeTrigGer");
                if (function != null)
                {
                    object[] args = new object[] { 0, 100, 0, 1 };
                    function.Call(args);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void eval_b(object sender, EventArgs e)
        {
            World.Set安全区();
        }

        private void eval_b(object sender, ElapsedEventArgs e)
        {
            if (World.JlMsg == 1)
            {
                //WriteLine(0, "自动连接事件()");
            }
            this.c_c.Interval = World.自动连接时间 * 1000;
            if (!World.主Socket && World.自动开启连接)
            {
                if (this.j != null)
                {
                    this.j.Dispose();
                }
                int num = new Random(World.GetRandomSeed()).Next(10, 100);
                this.j = new Network.Listener(World.游戏服务器端口 + num);
            }
        }

        private void eval_ba(object sender, EventArgs e)
        {
            try
            {
                
                Timer.TimerThread thread = new Timer.TimerThread();
                timerThread = new Thread(new ThreadStart(thread.TimerMain));
                timerThread.Name = "Timer Thread";
                timerThread.Start();
                
                world = new World();
                World.SetConfig();
                World.SetstConfig();
                World.SetgjConfig();
                //Form1.e.SetConfig3();
                //Form1.e.MyCallBack();
                World.SetConfig2();
                if (World.检查数据库配置())
                {
                    World.SetMonSter();
                    World.SetNpc();
                    World.SetDrop();
                    World.Set_GSDrop();
                    World.SetBossDrop();
                    World.SetOpen();
                    World.SetLever();
                    World.SetWxLever();
                    World.SetQuestDrop();
                    World.SetKongfu();
                    World.SetItme();
                    World.SetShot();
                    World.SetMover();
                    World.Set公告();
                    World.Set移动();
                    World.Set安全区();
                    World.SetKill();
                    World.Set箱子送元宝();
                    World.Set冲关地图();
                    World.SetJianc();
                    World.Set升天气功();
                    World.Set制作物品();
                    World.SetScript();
                    World.加载百宝阁();
                    World.加载转职属性();
                    World.加载等级奖励();
                    World.加载在线时间奖励();
                    World.加载物品兑换();
                    World.加载转生次数奖励();
                    World.Set石头属性();
                    World.SetTableOfMedicines();
                    World.SetGiftCode();
                    World.SetGiftCodeRewards();
                    World.SetTz();
                    World.SetTZlist();
                    World.Conn = new Connect();
                    World.Conn.Sestup();
                    World.GjServerConnect = new AtServerConnect();
                    World.GjServerConnect.Sestup();
                    this.j = new Network.Listener(World.游戏服务器端口);
                    new AuthServer(World.百宝阁服务器ip, World.百宝阁服务器端口);
                    this.Text = "Game Server: Yulgang Online" + " -> [ " + World.ServerName + " ]";
                    
                    this.eval_h_h = new Thread(new ThreadStart(this.eval_a));
                    this.eval_h_h.Name = "FlushAll";
                    this.eval_h_h.Start();


                    Timer.DelayCall(TimeSpan.FromMilliseconds(300000.0), TimeSpan.FromMilliseconds(300000.0), new TimerCallback(this.自动公告事件));
                    /*
                    System.Timers.Timer Timer_自动公告事件 = new System.Timers.Timer(300000.0);
                    Timer_自动公告事件.Elapsed += new ElapsedEventHandler(自动公告事件);
                    Timer_自动公告事件.AutoReset = true;
                    Timer_自动公告事件.Enabled = true;
                    */
                    this.b = new System.Timers.Timer(21000.0);
                    this.b.Elapsed += new ElapsedEventHandler(this.a);
                    this.b.AutoReset = true;
                    this.b.Enabled = true;

                    this.c_c = new System.Timers.Timer((double)(World.自动连接时间 * 1000));
                    this.c_c.Elapsed += new ElapsedEventHandler(this.eval_b);
                    this.c_c.AutoReset = true;
                    this.c_c.Enabled = true;

                    //ClassDllImport.LoadLib();
                    eval_b();
                }
            }
            catch (Exception exception)
            {
                WriteLine(1, "Form1_Load 错误" + exception.Message);
            }
        }

        private void Delete_Data(object sender, EventArgs e)
        {
            string sqlCommand = string.Format("DELETE FROM TBL_ACCOUNT", new object[0]);
            string str2 = string.Format("DELETE FROM TBL_XWWL_Char", new object[0]);
            string str3 = string.Format("DELETE FROM EventTop", new object[0]);
            string str4 = string.Format("DELETE FROM TBL_XWWL_Cw", new object[0]);
            string str5 = string.Format("DELETE FROM TBL_XWWL_Guild", new object[0]);
            string str6 = string.Format("DELETE FROM TBL_XWWL_GuildMember", new object[0]);
            string str7 = string.Format("DELETE FROM TBL_XWWL_PublicWarehouse", new object[0]);
            string str8 = string.Format("DELETE FROM TBL_XWWL_Warehouse", new object[0]);
            string str9 = string.Format("DELETE FROM 百宝记录", new object[0]);
            string str10 = string.Format("DELETE FROM 登陆记录", new object[0]);
            string str11 = string.Format("DELETE FROM 物品记录", new object[0]);
            string str12 = string.Format("DELETE FROM 物品记录", new object[0]);
            string str13 = string.Format("DELETE FROM TBL_传书系统", new object[0]);

            DBA.ExeSqlCommand(sqlCommand, "rxjhaccount");
            DBA.ExeSqlCommand(str2, "GameServer");
            DBA.ExeSqlCommand(str3, "GameServer");
            DBA.ExeSqlCommand(str4, "GameServer");
            DBA.ExeSqlCommand(str5, "GameServer");
            DBA.ExeSqlCommand(str6, "GameServer");
            DBA.ExeSqlCommand(str7, "GameServer");
            DBA.ExeSqlCommand(str8, "GameServer");
            DBA.ExeSqlCommand(str9, "GameServer");
            DBA.ExeSqlCommand(str10, "GameServer");
            DBA.ExeSqlCommand(str11, "GameServer");
            DBA.ExeSqlCommand(str12, "GameServer");
            DBA.ExeSqlCommand(str13, "GameServer");
            WriteLine(2, "所有账号数据人物数据都已经清理完成~");
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.eval_l_l = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel3 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel4 = new System.Windows.Forms.StatusBarPanel();
            this.eval_w_w = new System.Windows.Forms.ImageList(this.components);
            this.eval_o_o = new System.Windows.Forms.MainMenu(this.components);
            this.eval_p_p = new System.Windows.Forms.MenuItem();
            this.eval_a8_a8 = new System.Windows.Forms.MenuItem();
            this.eval_r_r = new System.Windows.Forms.MenuItem();
            this.eval_q_q = new System.Windows.Forms.MenuItem();
            this.eval_a5_a5 = new System.Windows.Forms.MenuItem();
            this.Auto_Save = new System.Windows.Forms.MenuItem();
            this.eval_a7_a7 = new System.Windows.Forms.MenuItem();
            this.eval_s_s = new System.Windows.Forms.MenuItem();
            this.eval_t_t = new System.Windows.Forms.MenuItem();
            this.eval_a3_a3 = new System.Windows.Forms.MenuItem();
            this.eval_a9_a9 = new System.Windows.Forms.MenuItem();
            this.eval_ak_ak = new System.Windows.Forms.MenuItem();
            this.eval_ba_ba = new System.Windows.Forms.MenuItem();
            this.eval_aj_aj = new System.Windows.Forms.MenuItem();
            this.eval_ae_ae = new System.Windows.Forms.MenuItem();
            this.eval_ai_ai = new System.Windows.Forms.MenuItem();
            this.eval_am_am = new System.Windows.Forms.MenuItem();
            this.eval_a1_a1 = new System.Windows.Forms.MenuItem();
            this.eval_bf = new System.Windows.Forms.MenuItem();
            this.eval_bt = new System.Windows.Forms.MenuItem();
            this.eval_bw = new System.Windows.Forms.MenuItem();
            this.eval_bx = new System.Windows.Forms.MenuItem();
            this.eval_u_u = new System.Windows.Forms.MenuItem();
            this.eval_v_v = new System.Windows.Forms.MenuItem();
            this.eval_a6_a6 = new System.Windows.Forms.MenuItem();
            this.eval_a4_a4 = new System.Windows.Forms.MenuItem();
            this.eval_bi = new System.Windows.Forms.MenuItem();
            this.eval_an_an = new System.Windows.Forms.MenuItem();
            this.eval_ao_ao = new System.Windows.Forms.MenuItem();
            this.eval_az_az = new System.Windows.Forms.MenuItem();
            this.eval_x_x = new System.Windows.Forms.MenuItem();
            this.eval_a0_a0 = new System.Windows.Forms.MenuItem();
            this.eval_y_y = new System.Windows.Forms.MenuItem();
            this.eval_z_z = new System.Windows.Forms.MenuItem();
            this.eval_aa_aa = new System.Windows.Forms.MenuItem();
            this.eval_ab_ab = new System.Windows.Forms.MenuItem();
            this.eval_ac_ac = new System.Windows.Forms.MenuItem();
            this.eval_af_af = new System.Windows.Forms.MenuItem();
            this.eval_bb = new System.Windows.Forms.MenuItem();
            this.eval_be = new System.Windows.Forms.MenuItem();
            this.eval_bg = new System.Windows.Forms.MenuItem();
            this.eval_bj = new System.Windows.Forms.MenuItem();
            this.eval_bl = new System.Windows.Forms.MenuItem();
            this.eval_bm = new System.Windows.Forms.MenuItem();
            this.eval_bn = new System.Windows.Forms.MenuItem();
            this.eval_bo = new System.Windows.Forms.MenuItem();
            this.eval_bp = new System.Windows.Forms.MenuItem();
            this.eval_bq = new System.Windows.Forms.MenuItem();
            this.eval_bs = new System.Windows.Forms.MenuItem();
            this.eval_bv = new System.Windows.Forms.MenuItem();
            this.eval_by = new System.Windows.Forms.MenuItem();
            this.eval_bz = new System.Windows.Forms.MenuItem();
            this.ReloadDrugs = new System.Windows.Forms.MenuItem();
            this.ReloadGiftCode = new System.Windows.Forms.MenuItem();
            this.eval_bc = new System.Windows.Forms.MenuItem();
            this.eval_bd = new System.Windows.Forms.MenuItem();
            this.eval_bk = new System.Windows.Forms.MenuItem();
            this.eval_bu = new System.Windows.Forms.MenuItem();
            this.eval_br = new System.Windows.Forms.MenuItem();
            this.al = new System.Windows.Forms.Timer(this.components);
            this.eval_ap_ap = new System.Windows.Forms.ToolStrip();
            this.eval_aq_aq = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.eval_ar_ar = new System.Windows.Forms.ToolStripButton();
            this.eval_as_as = new System.Windows.Forms.ToolStripTextBox();
            this.eval_at_at = new System.Windows.Forms.ToolStripComboBox();
            this.eval_au_au = new System.Windows.Forms.ToolStripButton();
            this.eval_av_av = new System.Windows.Forms.ToolStripSeparator();
            this.eval_aw_aw = new System.Windows.Forms.ToolStripButton();
            this.eval_ax_ax = new System.Windows.Forms.ToolStripSeparator();
            this.eval_ay_ay = new System.Windows.Forms.ToolStripButton();
            this.eval_bh = new FlickerFreePanel();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel4)).BeginInit();
            this.eval_ap_ap.SuspendLayout();
            this.SuspendLayout();
            // 
            // eval_l_l
            // 
            this.eval_l_l.Location = new System.Drawing.Point(0, 393);
            this.eval_l_l.Name = "eval_l_l";
            this.eval_l_l.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2,
            this.statusBarPanel3,
            this.statusBarPanel4});
            this.eval_l_l.ShowPanels = true;
            this.eval_l_l.Size = new System.Drawing.Size(581, 20);
            this.eval_l_l.TabIndex = 6;
            this.eval_l_l.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "连接 1000 在线 1000";
            this.statusBarPanel1.Width = 130;
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanel2.Name = "statusBarPanel2";
            this.statusBarPanel2.Width = 160;
            // 
            // statusBarPanel3
            // 
            this.statusBarPanel3.Alignment = System.Windows.Forms.HorizontalAlignment.Right;
            this.statusBarPanel3.Name = "statusBarPanel3";
            this.statusBarPanel3.Width = 180;
            // 
            // statusBarPanel4
            // 
            this.statusBarPanel4.Name = "statusBarPanel4";
            this.statusBarPanel4.Text = "statusBarPanel4";
            this.statusBarPanel4.Width = 120;
            // 
            // eval_w_w
            // 
            this.eval_w_w.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.eval_w_w.ImageSize = new System.Drawing.Size(16, 16);
            this.eval_w_w.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // eval_o_o
            // 
            this.eval_o_o.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.eval_p_p,
            this.eval_s_s,
            this.eval_u_u,
            this.eval_bc,
            this.eval_br});
            // 
            // eval_p_p
            // 
            this.eval_p_p.Index = 0;
            this.eval_p_p.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.eval_a8_a8,
            this.eval_r_r,
            this.eval_q_q,
            this.eval_a5_a5,
            this.Auto_Save,
            this.eval_a7_a7});
            this.eval_p_p.Text = "Service";
            // 
            // eval_a8_a8
            // 
            this.eval_a8_a8.Index = 0;
            this.eval_a8_a8.Text = "开始登陆服务";
            this.eval_a8_a8.Click += new System.EventHandler(this.eval_a9);
            // 
            // eval_r_r
            // 
            this.eval_r_r.Index = 1;
            this.eval_r_r.Text = "停止登陆服务";
            this.eval_r_r.Click += new System.EventHandler(this.eval_a7);
            // 
            // eval_q_q
            // 
            this.eval_q_q.Index = 2;
            this.eval_q_q.Text = "停止主服务";
            this.eval_q_q.Click += new System.EventHandler(this.eval_a8);
            // 
            // eval_a5_a5
            // 
            this.eval_a5_a5.Enabled = false;
            this.eval_a5_a5.Index = 3;
            this.eval_a5_a5.Text = "线程停止";
            this.eval_a5_a5.Click += new System.EventHandler(this.eval_a5);
            // 
            // Auto_Save
            // 
            this.Auto_Save.Index = 4;
            this.Auto_Save.Text = "Save data charater";
            this.Auto_Save.Click += new System.EventHandler(this.Save_Data);
            // 
            // eval_a7_a7
            // 
            this.eval_a7_a7.Index = 5;
            this.eval_a7_a7.Text = "防CC设置";
            this.eval_a7_a7.Click += new System.EventHandler(this.eval_ac);
            // 
            // eval_s_s
            // 
            this.eval_s_s.Index = 1;
            this.eval_s_s.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.eval_t_t,
            this.eval_a3_a3,
            this.eval_a9_a9,
            this.eval_ak_ak,
            this.eval_ba_ba,
            this.eval_aj_aj,
            this.eval_ae_ae,
            this.eval_ai_ai,
            this.eval_am_am,
            this.eval_a1_a1,
            this.eval_bf,
            this.eval_bt,
            this.eval_bw});
            this.eval_s_s.Text = "控制";
            // 
            // eval_t_t
            // 
            this.eval_t_t.Index = 0;
            this.eval_t_t.Text = "用户";
            this.eval_t_t.Click += new System.EventHandler(this.eval_a4);
            // 
            // eval_a3_a3
            // 
            this.eval_a3_a3.Index = 1;
            this.eval_a3_a3.Text = "组队";
            this.eval_a3_a3.Click += new System.EventHandler(this.eval_a3);
            // 
            // eval_a9_a9
            // 
            this.eval_a9_a9.Index = 2;
            this.eval_a9_a9.Text = "地面物品";
            this.eval_a9_a9.Click += new System.EventHandler(this.eval_x);
            // 
            // eval_ak_ak
            // 
            this.eval_ak_ak.Checked = true;
            this.eval_ak_ak.Index = 3;
            this.eval_ak_ak.Text = "显示记录";
            this.eval_ak_ak.Click += new System.EventHandler(this.eval_ao);
            // 
            // eval_ba_ba
            // 
            this.eval_ba_ba.Index = 4;
            this.eval_ba_ba.Text = "显示掉落";
            this.eval_ba_ba.Click += new System.EventHandler(this.eval_w);
            // 
            // eval_aj_aj
            // 
            this.eval_aj_aj.Index = 5;
            this.eval_aj_aj.Text = "记录日志";
            this.eval_aj_aj.Click += new System.EventHandler(this.eval_ap);
            // 
            // eval_ae_ae
            // 
            this.eval_ae_ae.Index = 6;
            this.eval_ae_ae.Text = "记录封包";
            this.eval_ae_ae.Click += new System.EventHandler(this.eval_au);
            // 
            // eval_ai_ai
            // 
            this.eval_ai_ai.Index = 7;
            this.eval_ai_ai.Text = "验证服务器";
            this.eval_ai_ai.Click += new System.EventHandler(this.eval_aq);
            // 
            // eval_am_am
            // 
            this.eval_am_am.Enabled = false;
            this.eval_am_am.Index = 8;
            this.eval_am_am.Text = "查物品";
            this.eval_am_am.Click += new System.EventHandler(this.eval_an);
            // 
            // eval_a1_a1
            // 
            this.eval_a1_a1.Index = 9;
            this.eval_a1_a1.Text = "查SQL";
            this.eval_a1_a1.Click += new System.EventHandler(this.eval_at);
            // 
            // eval_bf
            // 
            this.eval_bf.Index = 10;
            this.eval_bf.Text = "势力战开关";
            this.eval_bf.Click += new System.EventHandler(this.eval_s);
            // 
            // eval_bt
            // 
            this.eval_bt.Enabled = false;
            this.eval_bt.Index = 11;
            this.eval_bt.Text = "BOSS攻城开关(改版中)";
            this.eval_bt.Click += new System.EventHandler(this.eval_f);
            // 
            // eval_bw
            // 
            this.eval_bw.Index = 12;
            this.eval_bw.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.eval_bx});
            this.eval_bw.Text = "Menu Delete Data";
            // 
            // eval_bx
            // 
            this.eval_bx.Index = 0;
            this.eval_bx.Text = "Delete Data ?";
            this.eval_bx.Click += new System.EventHandler(this.Delete_Data);
            // 
            // eval_u_u
            // 
            this.eval_u_u.Index = 2;
            this.eval_u_u.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.eval_v_v,
            this.eval_a6_a6,
            this.eval_a4_a4,
            this.eval_bi,
            this.eval_an_an,
            this.eval_ao_ao,
            this.eval_az_az,
            this.eval_x_x,
            this.eval_a0_a0,
            this.eval_y_y,
            this.eval_z_z,
            this.eval_aa_aa,
            this.eval_ab_ab,
            this.eval_ac_ac,
            this.eval_af_af,
            this.eval_bb,
            this.eval_be,
            this.eval_bg,
            this.eval_bj,
            this.eval_bl,
            this.eval_bm,
            this.eval_bn,
            this.eval_bo,
            this.eval_bp,
            this.eval_bq,
            this.eval_bs,
            this.eval_bv,
            this.eval_by,
            this.eval_bz,
            this.ReloadDrugs,
            this.ReloadGiftCode});
            this.eval_u_u.Text = "Reload";
            // 
            // eval_v_v
            // 
            this.eval_v_v.Index = 0;
            this.eval_v_v.Text = "Reload All";
            this.eval_v_v.Click += new System.EventHandler(this.eval_a2);
            // 
            // eval_a6_a6
            // 
            this.eval_a6_a6.Index = 1;
            this.eval_a6_a6.Text = "Reload spell (TBL_KONGFU)";
            this.eval_a6_a6.Click += new System.EventHandler(this.eval_ah);
            // 
            // eval_a4_a4
            // 
            this.eval_a4_a4.Index = 2;
            this.eval_a4_a4.Text = "Reload Filter(TBL_KILL + 装备检测)";
            this.eval_a4_a4.Click += new System.EventHandler(this.eval_ai);
            // 
            // eval_bi
            // 
            this.eval_bi.Enabled = false;
            this.eval_bi.Index = 3;
            this.eval_bi.Text = "Reload NPC (TBL_NPC)";
            this.eval_bi.Click += new System.EventHandler(this.eval_a1);
            // 
            // eval_an_an
            // 
            this.eval_an_an.Index = 4;
            this.eval_an_an.Text = "Reload Monster (TBL_MONSTER)";
            this.eval_an_an.Click += new System.EventHandler(this.eval_am);
            // 
            // eval_ao_ao
            // 
            this.eval_ao_ao.Index = 5;
            this.eval_ao_ao.Text = "Reload Item Boss Drop (TBL_BOSSDROP)";
            this.eval_ao_ao.Click += new System.EventHandler(this.eval_al);
            // 
            // eval_az_az
            // 
            this.eval_az_az.Index = 6;
            this.eval_az_az.Text = "Reload NPC Drop (TBL_NPC_DROP)";
            this.eval_az_az.Click += new System.EventHandler(this.eval_ak);
            // 
            // eval_x_x
            // 
            this.eval_x_x.Index = 7;
            this.eval_x_x.Text = "Reload Item Drop (TBL_DROP)";
            this.eval_x_x.Click += new System.EventHandler(this.eval_a0);
            // 
            // eval_a0_a0
            // 
            this.eval_a0_a0.Index = 8;
            this.eval_a0_a0.Text = "Reload Item Master Drop (TBL_DROPGS)";
            this.eval_a0_a0.Click += new System.EventHandler(this.eval_aj);
            // 
            // eval_y_y
            // 
            this.eval_y_y.Index = 9;
            this.eval_y_y.Text = "Reload Open Box (TBL_OPEN)";
            this.eval_y_y.Click += new System.EventHandler(this.eval_az);
            // 
            // eval_z_z
            // 
            this.eval_z_z.Index = 10;
            this.eval_z_z.Text = "Reload Item (TBL_ITEM)";
            this.eval_z_z.Click += new System.EventHandler(this.eval_ay);
            // 
            // eval_aa_aa
            // 
            this.eval_aa_aa.Index = 11;
            this.eval_aa_aa.Text = "Reload Sell (TBL_SELL)";
            this.eval_aa_aa.Click += new System.EventHandler(this.eval_ax);
            // 
            // eval_ab_ab
            // 
            this.eval_ab_ab.Index = 12;
            this.eval_ab_ab.Text = "Reload Move (TBL_VOME)";
            this.eval_ab_ab.Click += new System.EventHandler(this.eval_aw);
            // 
            // eval_ac_ac
            // 
            this.eval_ac_ac.Index = 13;
            this.eval_ac_ac.Text = "Reload Announcement (TBL_Gg)";
            this.eval_ac_ac.Click += new System.EventHandler(this.eval_av);
            // 
            // eval_af_af
            // 
            this.eval_af_af.Index = 14;
            this.eval_af_af.Text = "Reload Config";
            this.eval_af_af.Click += new System.EventHandler(this.eval_as);
            // 
            // eval_bb
            // 
            this.eval_bb.Index = 15;
            this.eval_bb.Text = "Reload Script";
            this.eval_bb.Click += new System.EventHandler(this.eval_v);
            // 
            // eval_be
            // 
            this.eval_be.Index = 16;
            this.eval_be.Text = "Reload Production (制作物品列表)";
            this.eval_be.Click += new System.EventHandler(this.eval_t);
            // 
            // eval_bg
            // 
            this.eval_bg.Index = 17;
            this.eval_bg.Text = "Reload Webshop";
            this.eval_bg.Click += new System.EventHandler(this.eval_r);
            // 
            // eval_bj
            // 
            this.eval_bj.Index = 18;
            this.eval_bj.Text = "Reload Map Move (TBL_MAP)";
            this.eval_bj.Click += new System.EventHandler(this.eval_p);
            // 
            // eval_bl
            // 
            this.eval_bl.Index = 19;
            this.eval_bl.Text = "Reload Transfer (自定义转职属性)";
            this.eval_bl.Click += new System.EventHandler(this.eval_n);
            // 
            // eval_bm
            // 
            this.eval_bm.Index = 20;
            this.eval_bm.Text = "重读冲级奖励数据";
            this.eval_bm.Click += new System.EventHandler(this.eval_m);
            // 
            // eval_bn
            // 
            this.eval_bn.Index = 21;
            this.eval_bn.Text = "重读物品兑换数据";
            this.eval_bn.Click += new System.EventHandler(this.eval_l);
            // 
            // eval_bo
            // 
            this.eval_bo.Index = 22;
            this.eval_bo.Text = "重读套装属性数据";
            this.eval_bo.Click += new System.EventHandler(this.eval_k);
            // 
            // eval_bp
            // 
            this.eval_bp.Index = 23;
            this.eval_bp.Text = "重读套装列表数据";
            this.eval_bp.Click += new System.EventHandler(this.eval_j);
            // 
            // eval_bq
            // 
            this.eval_bq.Index = 24;
            this.eval_bq.Text = "重读在线时间奖励数据";
            this.eval_bq.Click += new System.EventHandler(this.eval_i);
            // 
            // eval_bs
            // 
            this.eval_bs.Index = 25;
            this.eval_bs.Text = "重读转生次数奖励数据";
            this.eval_bs.Click += new System.EventHandler(this.eval_g);
            // 
            // eval_bv
            // 
            this.eval_bv.Index = 26;
            this.eval_bv.Text = "重读石头属性数据";
            this.eval_bv.Click += new System.EventHandler(this.eval_d);
            // 
            // eval_by
            // 
            this.eval_by.Index = 27;
            this.eval_by.Text = "重新读取安全区";
            this.eval_by.Click += new System.EventHandler(this.eval_b);
            // 
            // eval_bz
            // 
            this.eval_bz.Index = 28;
            this.eval_bz.Text = "重读天关地图配置";
            this.eval_bz.Click += new System.EventHandler(this.eval_a);
            // 
            // ReloadDrugs
            // 
            this.ReloadDrugs.Index = 29;
            this.ReloadDrugs.Text = "Reload ReloadDrugs (TBL_TableOfMedicines)";
            this.ReloadDrugs.Click += new System.EventHandler(this.ReloadDrugs_Click);
            // 
            // ReloadGiftCode
            // 
            this.ReloadGiftCode.Index = 30;
            this.ReloadGiftCode.Text = "Reload GiftCode (GiftCode + GiftCode_Rewards)";
            this.ReloadGiftCode.Click += new System.EventHandler(this.ReloadGiftCode_Click);
            // 
            // eval_bc
            // 
            this.eval_bc.Enabled = false;
            this.eval_bc.Index = 3;
            this.eval_bc.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.eval_bd,
            this.eval_bk,
            this.eval_bu});
            this.eval_bc.Text = "Tool";
            this.eval_bc.Click += new System.EventHandler(this.eval_q);
            // 
            // eval_bd
            // 
            this.eval_bd.Index = 0;
            this.eval_bd.Text = "任务修改器";
            this.eval_bd.Click += new System.EventHandler(this.eval_u);
            // 
            // eval_bk
            // 
            this.eval_bk.Index = 1;
            this.eval_bk.Text = "YBI修改器(8012+)";
            this.eval_bk.Click += new System.EventHandler(this.eval_o);
            // 
            // eval_bu
            // 
            this.eval_bu.Index = 2;
            this.eval_bu.Text = "查复制物品";
            this.eval_bu.Click += new System.EventHandler(this.eval_e);
            // 
            // eval_br
            // 
            this.eval_br.Index = 4;
            this.eval_br.Text = "Chat In Game";
            this.eval_br.Click += new System.EventHandler(this.eval_h);
            // 
            // al
            // 
            this.al.Enabled = true;
            this.al.Interval = 1000;
            this.al.Tick += new System.EventHandler(this.eval_a6);
            // 
            // eval_ap_ap
            // 
            this.eval_ap_ap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eval_aq_aq,
            this.toolStripComboBox2,
            this.eval_ar_ar,
            this.eval_as_as,
            this.eval_at_at,
            this.eval_au_au,
            this.eval_av_av,
            this.eval_aw_aw,
            this.eval_ax_ax,
            this.eval_ay_ay});
            this.eval_ap_ap.Location = new System.Drawing.Point(0, 0);
            this.eval_ap_ap.Name = "eval_ap_ap";
            this.eval_ap_ap.Size = new System.Drawing.Size(581, 25);
            this.eval_ap_ap.TabIndex = 15;
            this.eval_ap_ap.Text = "toolStrip1";
            // 
            // eval_aq_aq
            // 
            this.eval_aq_aq.Name = "eval_aq_aq";
            this.eval_aq_aq.Size = new System.Drawing.Size(166, 25);
            this.eval_aq_aq.Text = resources.GetString("eval_aq_aq.Text");
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.DropDownWidth = 75;
            this.toolStripComboBox2.IntegralHeight = false;
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "正常",
            "加密"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(75, 25);
            this.toolStripComboBox2.Text = "正常";
            // 
            // eval_ar_ar
            // 
            this.eval_ar_ar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.eval_ar_ar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eval_ar_ar.Name = "eval_ar_ar";
            this.eval_ar_ar.Size = new System.Drawing.Size(35, 22);
            this.eval_ar_ar.Text = "发送";
            this.eval_ar_ar.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // eval_as_as
            // 
            this.eval_as_as.Name = "eval_as_as";
            this.eval_as_as.Size = new System.Drawing.Size(84, 25);
            this.eval_as_as.Text = "空";
            // 
            // eval_at_at
            // 
            this.eval_at_at.Items.AddRange(new object[] {
            "10",
            "9"});
            this.eval_at_at.Name = "eval_at_at";
            this.eval_at_at.Size = new System.Drawing.Size(75, 25);
            this.eval_at_at.Text = "10";
            // 
            // eval_au_au
            // 
            this.eval_au_au.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.eval_au_au.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eval_au_au.Name = "eval_au_au";
            this.eval_au_au.Size = new System.Drawing.Size(35, 22);
            this.eval_au_au.Text = "发送";
            this.eval_au_au.Click += new System.EventHandler(this.eval_af);
            // 
            // eval_av_av
            // 
            this.eval_av_av.Name = "eval_av_av";
            this.eval_av_av.Size = new System.Drawing.Size(6, 25);
            // 
            // eval_aw_aw
            // 
            this.eval_aw_aw.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.eval_aw_aw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eval_aw_aw.Name = "eval_aw_aw";
            this.eval_aw_aw.Size = new System.Drawing.Size(59, 22);
            this.eval_aw_aw.Text = "发送人数";
            this.eval_aw_aw.Click += new System.EventHandler(this.eval_ae);
            // 
            // eval_ax_ax
            // 
            this.eval_ax_ax.Name = "eval_ax_ax";
            this.eval_ax_ax.Size = new System.Drawing.Size(6, 25);
            // 
            // eval_ay_ay
            // 
            this.eval_ay_ay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.eval_ay_ay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eval_ay_ay.Name = "eval_ay_ay";
            this.eval_ay_ay.Size = new System.Drawing.Size(23, 22);
            this.eval_ay_ay.Text = "查";
            this.eval_ay_ay.Click += new System.EventHandler(this.eval_ad);
            // 
            // eval_bh
            // 
            this.eval_bh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eval_bh.BackColor = System.Drawing.Color.Black;
            this.eval_bh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.eval_bh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eval_bh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.eval_bh.Location = new System.Drawing.Point(0, 26);
            this.eval_bh.Name = "eval_bh";
            this.eval_bh.Size = new System.Drawing.Size(581, 375);
            this.eval_bh.TabIndex = 0;
            this.eval_bh.Paint += new System.Windows.Forms.PaintEventHandler(this.eval_a);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(581, 413);
            this.Controls.Add(this.eval_l_l);
            this.Controls.Add(this.eval_bh);
            this.Controls.Add(this.eval_ap_ap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.eval_o_o;
            this.Name = "Form1";
            this.Text = "GameServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.eval_a);
            this.Load += new System.EventHandler(this.eval_ba);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.eval_a);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel4)).EndInit();
            this.eval_ap_ap.ResumeLayout(false);
            this.eval_ap_ap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ReloadDrugs_Click(object sender, EventArgs e)
        {
            World.SetTableOfMedicines();
        }

        private void ReloadGiftCode_Click(object sender, EventArgs e)
        {
            World.SetGiftCode();
            World.SetGiftCodeRewards();
        }

        private void eval_d(object sender, EventArgs e)
        {
            World.Set石头属性();
        }

        private void eval_e(object sender, EventArgs e)
        {
            new RxjhTool.CheckCopy().ShowDialog();
        }

        private void eval_f(object sender, EventArgs e)
        {
            if (World.野外boss == null)
            {
                World.野外boss = new BossClass();
                WriteLine(2, "BOSS攻城开始");
            }
            else
            {
                World.野外boss.Dispose();
                WriteLine(2, "BOSS攻城结束");
            }
        }

        private void eval_g(object sender, EventArgs e)
        {
            World.加载转生次数奖励();
        }

        private void eval_h(object sender, EventArgs e)
        {
            new Show1().ShowDialog();
        }

        private void eval_i(object sender, EventArgs e)
        {
            World.加载在线时间奖励();
        }

        private void eval_j(object sender, EventArgs e)
        {
            World.SetTZlist();
        }

        private void eval_k(object sender, EventArgs e)
        {
            World.SetTz();
        }

        private void eval_l(object sender, EventArgs e)
        {
            World.加载物品兑换();
        }

        private void eval_m(object sender, EventArgs e)
        {
            World.加载等级奖励();
        }

        private void eval_n(object sender, EventArgs e)
        {
            World.加载转职属性();
        }

        private void eval_o(object sender, EventArgs e)
        {
            new YbiForm().ShowDialog();
        }

        private void eval_p(object sender, EventArgs e)
        {
            World.Set移动();
        }

        private void eval_q(object sender, EventArgs e)
        {
        }

        private void eval_r(object sender, EventArgs e)
        {
            World.加载百宝阁();
        }

        private void eval_s(object sender, EventArgs e)
        {
            if (World.EventClass == null)
            {
                World.EventClass = new EventClass();
                foreach (Players players in World.AllConnectedChars.Values)
                {
                    if (players.Player_Job_Level >= 2)
                    {
                        players.Packet_Start_Time_War_Class_All();
                    }
                }
                WriteLine(2, "Bắt đầu thế lực chiên");
            }
            else
            {
                World.EventClass.Dispose();
                WriteLine(2, "Kết thúc thế lực chiến");
            }
        }

        private void eval_t(object sender, EventArgs e)
        {
            World.Set制作物品();
        }

        private void eval_u(object sender, EventArgs e)
        {
            new YbQForm().ShowDialog();
        }

        private void eval_v(object sender, EventArgs e)
        {
            World.SetScript();
        }

        private void eval_w(object sender, EventArgs e)
        {
            if (this.eval_ba_ba.Checked)
            {
                this.eval_ba_ba.Checked = false;
                World.Droplog = false;
            }
            else
            {
                this.eval_ba_ba.Checked = true;
                World.Droplog = true;
            }
        }

        private void eval_x(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void eval_y(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Form2.FlushAll4));
            thread.Name = "Timer Thread";
            thread.Start();
        }

        private void eval_z(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(Form2.FlushAll3));
            thread.Name = "Timer Thread";
            thread.Start();
        }

        private static void old_acctor_mc()
        {
            f = new List<TxtClass>();
            b2 = 300;
        }

        public void Send单包(byte[] toSendBuff, int len)
        {
            byte[] dst = new byte[BitConverter.ToInt16(toSendBuff, 9) + 7];
            Buffer.BlockCopy(toSendBuff, 5, dst, 0, dst.Length);
            this.eval_a(dst, dst.Length);
        }

        public static void WriteLine(int type, string txtt)
        {
            int num = b2 / 18;
            lock (f)
            {
                if (type == 100)
                {
                    logo.FileTxtLog(txtt);
                    logo.BugTxtLog(txtt);
                    f.Add(new TxtClass(type, DateTime.Now.ToString() + " " + txtt));
                    int count = f.Count;
                    if (num <= 0)
                    {
                        num = 20;
                    }
                    if (count > num)
                    {
                        for (int i = 0; i < (count - num); ++i)
                        {
                            f.RemoveAt(0);
                        }
                    }
                }
                else if (World.AlWorldlog)
                {
                    if (World.Jllog == 1)
                    {
                        if (type == 1)
                        {
                            logo.FileTxtLog(txtt);
                        }
                        else if (type == 2)
                        {
                            logo.FileCQTxtLog(txtt);
                        }
                        else if (type == 3)
                        {
                            logo.FileLoninTxtLog(txtt);
                        }
                        else if (type == 4)
                        {
                            logo.FileDropItmeTxtLog(txtt);
                        }
                        else if (type == 5)
                        {
                            logo.FileItmeTxtLog(txtt);
                        }
                        else if (type == 6)
                        {
                            logo.FileBugTxtLog(txtt);
                        }
                        else if (type == 7)
                        {
                            logo.FilePakTxtLog(txtt);
                        }
                        else if (type == 8)
                        {
                            logo.SeveTxtLog(txtt);
                        }
                    }
                    if (type == 99)
                    {
                        logo.FileTxtLog(txtt);
                    }
                    else if (type == 88)
                    {
                        logo.pzTxtLog(txtt);
                    }
                    else if (type == 77)
                    {
                        logo.cfzTxtLog(txtt);
                    }
                    else if (World.JlMsg == 1)
                    {
                        logo.DebugTxtLog(txtt);
                    }
                    f.Add(new TxtClass(type, DateTime.Now.ToString() + " " + txtt));
                    int num4 = f.Count;
                    if (num <= 0)
                    {
                        num = 20;
                    }
                    if (num4 > num)
                    {
                        for (int j = 0; j < (num4 - num); ++j)
                        {
                            f.RemoveAt(0);
                        }
                    }
                }
            }
        }

        public void 复查用户登陆()
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                foreach (NetState state in World.List.Values)
                {
                    builder.Append(state.Player.Userid);
                    builder.Append("-");
                    builder.Append(state.ToString());
                    builder.Append(",");
                }
                if (builder.Length > 0)
                {
                    builder.Remove(builder.Length - 1, 1);
                }
                World.Conn.发送("复查用户登陆|" + builder);
                if (World.AutGc != 0)
                {
                    GC.Collect();
                }
            }
            catch (Exception exception)
            {
                WriteLine(1, "复查用户登陆 错误" + exception.Message);
            }
        }

        public void 加速计数清零()
        {
            List<Players> list = new List<Players>();
            foreach (Players players2 in World.AllConnectedChars.Values)
            {
                list.Add(players2);
            }
            foreach (Players players in list)
            {
                try
                {
                    players.times = 0;
                    continue;
                }
                catch (Exception exception)
                {
                    WriteLine(1, "加速计数清零() 错误" + exception.Message);
                    continue;
                }
            }
            list.Clear();
        }

        public void 自动公告事件()//(object sender, ElapsedEventArgs e)
        {
            try
            {
                if (World.JlMsg == 1)
                {
                    //WriteLine(0, "自动公告事件");
                }
                this.复查用户登陆();
                //Thong bao
                if (World.公告.Count > 0)
                {
                    //公告类 公告类 = World.公告[this.eval_d_d];
                    //this.a(公告类.msg, 公告类.type);
                    //this.eval_d_d++;
                    //if (this.eval_d_d >= World.公告.Count)
                    //{
                    //    this.eval_d_d = 0;
                    //}
                    公告类 公告类 = World.公告[this.eval_d_d];
                    foreach(Players players in World.AllConnectedChars.Values)
                    {
                        //players.GameMessage(公告类.msg, 公告类.type, World.TenMayChu);
                        players.GameMessage(公告类.msg, 8);
                    }
                    this.eval_d_d++;
                    if (this.eval_d_d >= World.公告.Count)
                    {
                        this.eval_d_d = 0;
                    }
                }
                if (World.自动存档 == 1)
                {
                    foreach (Players players in World.AllConnectedChars.Values)
                    {
                        try
                        {
                            players.SaveDataCharacter();
                            continue;
                        }
                        catch (Exception exception)
                        {
                            Form1.WriteLine(1, "Loi luu data member" + exception.Message);
                            continue;
                        }
                    }
                    Form1.WriteLine(8, "Save data character success!!!");
                    this.Auto_Save.PerformClick();
                }
                Show1.TB_Baotri();

                    /*
                    if (World.AllConnectedChars.Count > World.List.Count)
                    {
                        Queue queue = Queue.Synchronized(new Queue());
                        foreach (Players players2 in World.AllConnectedChars.Values)
                        {
                            queue.Enqueue(players2);
                        }
                        while (queue.Count > 0)
                        {
                            Players players = (Players)queue.Dequeue();
                            if (!World.List.ContainsKey(players.UserSessionID) && World.AllConnectedChars.ContainsKey(players.UserSessionID))
                            {
                                World.AllConnectedChars.Remove(players.UserSessionID);
                            }
                        }
                        if (World.AllConnectedChars.Count > World.List.Count)
                        {
                            World.Conn.Dispose();
                            this.eval_r_r.PerformClick();
                            World.自动存档 = 0;
                        }
                    }
                    */
            }
            catch
            {
            }
        }
    }
}


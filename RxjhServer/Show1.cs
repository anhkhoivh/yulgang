using HelperTools;
using RxjhServer.RxjhServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace RxjhServer
{
	public class Show1 : Form
	{
		private System.Windows.Forms.Timer al;

		private static int b2;

		private FlickerFreePanel KhungNen;

		private MainMenu eval_o_o;

		private ImageList eval_w_w;

		private static List<TxtClass> f;

		private DateTime g = DateTime.Now;

		private IContainer components;

		private TextBox TinNhan;

		private TextBox NguoiGui;

		private Button button1;

		private ComboBox comboBox1;

		private Label label1;

		private Label label2;

		private Label label3;

		private TextBox NguoiNhan;

		private CheckBox checkBox1;

		static Show1()
		{
			old_acctor_mc();
		}

		public Show1()
		{
			InitializeComponent();
		}

		private void a(object sender, ElapsedEventArgs e)
		{
		}

		private void a(string A_0, int A_1)
		{
		}

		[STAThread]
		private static void c()
		{
			try
			{
				Application.Run(new Show1());
			}
			catch (Exception arg)
			{
				MessageBox.Show("Main 错误" + arg);
			}
		}

		private void eval_a(object sender, EventArgs e)
		{
		}

		private void eval_a(object sender, FormClosingEventArgs e)
		{
		}

		private void eval_a(object sender, LayoutEventArgs e)
		{
			if (KhungNen.Height != 0)
			{
				b2 = KhungNen.Height;
			}
		}

		private void eval_a(object sender, PaintEventArgs e)
		{
			try
			{
				Graphics graphics = e.Graphics;
				graphics.SmoothingMode = SmoothingMode.AntiAlias;
				graphics.PixelOffsetMode = PixelOffsetMode.None;
				int num = 0;
				foreach (TxtClass item in f)
				{
					switch (item.type)
					{
					case 0:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.White, new Point(5, num += 17));
						break;
					case 1:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.Green, new Point(5, num += 17));
						break;
					case 2:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.Orange, new Point(5, num += 17));
						break;
					case 3:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.Pink, new Point(5, num += 17));
						break;
					case 4:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.Yellow, new Point(5, num += 17));
						break;
					case 5:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.SaddleBrown, new Point(5, num += 17));
						break;
					case 6:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.Red, new Point(5, num += 17));
						break;
					case 7:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.White, new Point(5, num += 17));
						break;
					case 8:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.Yellow, new Point(5, num += 17));
						break;
					case 9:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.RoyalBlue, new Point(5, num += 17));
						break;
					case 10:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.MediumSpringGreen, new Point(5, num += 17));
						break;
					case 11:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.Teal, new Point(5, num += 17));
						break;
					case 12:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.Teal, new Point(5, num += 17));
						break;
					case 13:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.MediumVioletRed, new Point(5, num += 17));
						break;
					case 14:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.Tan, new Point(5, num += 17));
						break;
					default:
						graphics.DrawString(item.Txt, Control.DefaultFont, Brushes.Lime, new Point(5, num += 17));
						break;
					}
				}
			}
			catch
			{
			}
		}

		private void eval_a(byte[] A_0, int A_1)
		{
			byte[] array = new byte[A_1 + 15];
			array[0] = 170;
			array[1] = 85;
			Buffer.BlockCopy(BitConverter.GetBytes(A_1 + 9), 0, array, 2, 2);
			Buffer.BlockCopy(A_0, 0, array, 5, A_1);
			array[array.Length - 2] = 85;
			array[array.Length - 1] = 170;
			Console.WriteLine(Converter.ToString(array));
		}

		private void eval_a6(object sender, EventArgs e)
		{
			KhungNen.Invalidate();
			TimeSpan timeSpan = DateTime.Now.Subtract(g);
		}

		private void eval_a7(object sender, EventArgs e)
		{
		}

		private void eval_a8(object sender, EventArgs e)
		{
		}

		private void eval_a9(object sender, EventArgs e)
		{
		}

		private void eval_aa(object sender, EventArgs e)
		{
			Thread thread = new Thread(Form2.FlushAll2);
			thread.Name = "Timer Thread";
			thread.Start();
		}

		private void eval_ab(object sender, EventArgs e)
		{
			Thread thread = new Thread(Form2.FlushAll1);
			thread.Name = "Timer Thread";
			thread.Start();
		}

		private void eval_ac(object sender, EventArgs e)
		{
			new BinIP().ShowDialog();
		}

		private void eval_ba(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception)
			{
			}
		}

		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			eval_w_w = new System.Windows.Forms.ImageList(components);
			eval_o_o = new System.Windows.Forms.MainMenu(components);
			TinNhan = new System.Windows.Forms.TextBox();
			NguoiGui = new System.Windows.Forms.TextBox();
			button1 = new System.Windows.Forms.Button();
			comboBox1 = new System.Windows.Forms.ComboBox();
			KhungNen = new FlickerFreePanel();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			NguoiNhan = new System.Windows.Forms.TextBox();
			checkBox1 = new System.Windows.Forms.CheckBox();
			al = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			eval_w_w.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			eval_w_w.ImageSize = new System.Drawing.Size(16, 16);
			eval_w_w.TransparentColor = System.Drawing.Color.Transparent;
			al.Enabled = true;
			al.Interval = 1000;
			al.Tick += new System.EventHandler(eval_a6);
			TinNhan.Location = new System.Drawing.Point(1, 280);
			TinNhan.Name = "TinNhan";
			TinNhan.Text = ((RxjhServer.World.TextTbBaotri != "") ? RxjhServer.World.TextTbBaotri : "");
			TinNhan.Size = new System.Drawing.Size(287, 20);
			TinNhan.TabIndex = 0;
			TinNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);
			TinNhan.TextChanged += new System.EventHandler(TinNhan_TextChanged);
			NguoiGui.Location = new System.Drawing.Point(2, 300);
			NguoiGui.Name = "NguoiGui";
			NguoiGui.Size = new System.Drawing.Size(73, 20);
			NguoiGui.TabIndex = 0;
			NguoiGui.Text = "x-GM-x";
			NguoiGui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);
			button1.Location = new System.Drawing.Point(288, 279);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(65, 42);
			button1.TabIndex = 1;
			button1.Enabled = false;
			button1.Text = "Send";
			button1.UseVisualStyleBackColor = true;
			button1.Click += new System.EventHandler(button1_Click);
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[28]
			{
				"0",
				"1",
				"2",
				"3",
				"4",
				"5",
				"6",
				"7",
				"8",
				"9",
				"10",
				"11",
				"12",
				"13",
				"14",
				"15",
				"16",
				"17",
				"18",
				"19",
				"20",
				"21",
				"22",
				"23",
				"24",
				"25",
				"26",
				"204"
			});
			comboBox1.Location = new System.Drawing.Point(224, 299);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new System.Drawing.Size(47, 21);
			comboBox1.TabIndex = 0;
			comboBox1.Text = "0";
			KhungNen.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
			KhungNen.BackColor = System.Drawing.Color.Black;
			KhungNen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			KhungNen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			KhungNen.ForeColor = System.Drawing.SystemColors.ControlText;
			KhungNen.Location = new System.Drawing.Point(0, -13);
			KhungNen.Name = "KhungNen";
			KhungNen.Size = new System.Drawing.Size(365, 292);
			KhungNen.TabIndex = 0;
			KhungNen.Paint += new System.Windows.Forms.PaintEventHandler(eval_a);
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(196, 302);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(31, 13);
			label1.TabIndex = 2;
			label1.Text = "Type";
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(75, 303);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(35, 13);
			label2.TabIndex = 3;
			label2.Text = "Name";
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(105, 303);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(20, 13);
			label3.TabIndex = 4;
			label3.Text = "To";
			NguoiNhan.Location = new System.Drawing.Point(124, 300);
			NguoiNhan.Name = "NguoiNhan";
			NguoiNhan.Size = new System.Drawing.Size(73, 20);
			NguoiNhan.TabIndex = 5;
			checkBox1.AutoSize = true;
			checkBox1.Location = new System.Drawing.Point(272, 304);
			checkBox1.Name = "checkBox1";
			checkBox1.Size = new System.Drawing.Size(15, 14);
			checkBox1.TabIndex = 6;
			checkBox1.UseVisualStyleBackColor = true;
			checkBox1.Checked = ((RxjhServer.World.AutoTbBaotri == 1) ? true : false);
			checkBox1.CheckedChanged += new System.EventHandler(checkBox1_CheckedChanged);
			AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			BackColor = System.Drawing.SystemColors.ControlLightLight;
			BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			base.ClientSize = new System.Drawing.Size(354, 321);
			base.Controls.Add(button1);
			base.Controls.Add(comboBox1);
			base.Controls.Add(NguoiNhan);
			base.Controls.Add(label3);
			base.Controls.Add(label2);
			base.Controls.Add(label1);
			base.Controls.Add(TinNhan);
			base.Controls.Add(NguoiGui);
			base.Controls.Add(KhungNen);
			base.Controls.Add(checkBox1);
			base.MaximizeBox = false;
			base.Menu = eval_o_o;
			base.Name = "Show1";
			Text = "Chat In Game";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(eval_a);
			base.Load += new System.EventHandler(eval_ba);
			base.Layout += new System.Windows.Forms.LayoutEventHandler(eval_a);
			ResumeLayout(performLayout: false);
			PerformLayout();
		}

		private static void old_acctor_mc()
		{
			f = new List<TxtClass>();
			b2 = 300;
		}

		public void Send单包(byte[] toSendBuff, int len)
		{
			byte[] array = new byte[BitConverter.ToInt16(toSendBuff, 9) + 7];
			Buffer.BlockCopy(toSendBuff, 5, array, 0, array.Length);
			eval_a(array, array.Length);
		}

		public static void WriteLine(int type, string txtt)
		{
			int num = b2 / 18;
			lock (f)
			{
				f.Add(new TxtClass(type, $"{DateTime.Now:HH:mm:ss}" + " | " + txtt));
				int count = f.Count;
				if (num <= 0)
				{
					num = 20;
				}
				if (count > num)
				{
					for (int i = 0; i < count - num; i++)
					{
						f.RemoveAt(0);
					}
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				if (NguoiNhan.Text != "")
				{
					WriteLine(int.Parse(comboBox1.SelectedItem.ToString()), NguoiGui.Text + " to " + NguoiNhan.Text + ": " + TinNhan.Text);
				}
				else if (comboBox1.SelectedItem.ToString() != "")
				{
					WriteLine(int.Parse(comboBox1.SelectedItem.ToString()), NguoiGui.Text + ": " + TinNhan.Text);
					WriteLine(int.Parse(comboBox1.SelectedItem.ToString()), NguoiGui.Text + ": " + TinNhan.Text);
				}
				foreach (Players value in World.AllConnectedChars.Values)
				{
					if (NguoiNhan.Text != "")
					{
						if (value.UserName.ToLower() == NguoiNhan.Text.ToLower() && TinNhan.Text.Length <= 100 && !value.ParseCommand(TinNhan.Text))
						{
							value.GameMessage(TinNhan.Text, int.Parse(comboBox1.SelectedItem.ToString()), NguoiGui.Text);
							break;
						}
					}
					else
					{
						value?.GameMessage(TinNhan.Text, int.Parse(comboBox1.SelectedItem.ToString()), NguoiGui.Text);
					}
				}
			}
			catch
			{
			}
		}

		private void CheckKeys(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r' && TinNhan.Text != "")
			{
				button1_Click(sender, e);
			}
		}

		private void TinNhan_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (TinNhan.Text == "")
				{
					button1.Enabled = false;
				}
				else
				{
					button1.Enabled = true;
				}
			}
			catch
			{
			}
		}

		public static void TB_Baotri()
		{
			if (World.JlMsg == 1)
			{
				WriteLine(0, "Tu dong thong bao bao tri !!!");
			}
			if (World.AutoTbBaotri == 1 && World.TextTbBaotri != "")
			{
				foreach (Players value in World.AllConnectedChars.Values)
				{
					value.GameMessage(World.TextTbBaotri, 8);
				}
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				World.TextTbBaotri = TinNhan.Text;
				World.AutoTbBaotri = 1;
			}
			else
			{
				World.AutoTbBaotri = 0;
			}
		}
	}
}

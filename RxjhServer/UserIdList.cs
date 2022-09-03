using RxjhServer.RxjhServer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RxjhServer
{
	public class UserIdList : Form
	{
		private string eval_a_a;

		private PropertyGrid eval_c;

		private ListView eval_d;

		private ColumnHeader eval_e;

		private ColumnHeader eval_f;

		public string username
		{
			get
			{
				return eval_a_a;
			}
			set
			{
				eval_a_a = value;
			}
		}

		public UserIdList()
		{
			InitializeComponent();
		}

		public void additmes(string a, object b)
		{
			string[] array = new string[2];
			try
			{
				array[0] = a;
				array[1] = b.ToString();
				eval_d.Items.Insert(eval_d.Items.Count, new ListViewItem(array));
			}
			catch
			{
			}
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			eval_c = new System.Windows.Forms.PropertyGrid();
			eval_d = new System.Windows.Forms.ListView();
			eval_e = new System.Windows.Forms.ColumnHeader();
			eval_f = new System.Windows.Forms.ColumnHeader();
			SuspendLayout();
			eval_c.Location = new System.Drawing.Point(313, 127);
			eval_c.Margin = new System.Windows.Forms.Padding(2);
			eval_c.Name = "eval_c";
			eval_c.PropertySort = System.Windows.Forms.PropertySort.Categorized;
			eval_c.Size = new System.Drawing.Size(174, 59);
			eval_c.TabIndex = 7;
			eval_d.Columns.AddRange(new System.Windows.Forms.ColumnHeader[2]
			{
				eval_e,
				eval_f
			});
			eval_d.Dock = System.Windows.Forms.DockStyle.Fill;
			eval_d.ForeColor = System.Drawing.SystemColors.WindowText;
			eval_d.FullRowSelect = true;
			eval_d.GridLines = true;
			eval_d.Location = new System.Drawing.Point(0, 0);
			eval_d.Name = "eval_d";
			eval_d.Size = new System.Drawing.Size(302, 408);
			eval_d.TabIndex = 8;
			eval_d.UseCompatibleStateImageBehavior = false;
			eval_d.View = System.Windows.Forms.View.Details;
			eval_e.Text = "名称";
			eval_e.Width = 170;
			eval_f.Text = "数据";
			eval_f.Width = 90;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(302, 408);
			base.Controls.Add(eval_d);
			base.Controls.Add(eval_c);
			base.Name = "UserIdList";
			Text = "用户信息";
			base.Load += new System.EventHandler(eval_a);
			ResumeLayout(performLayout: false);
		}

		private void eval_a(object sender, EventArgs e)
		{
			try
			{
				foreach (Players value in World.AllConnectedChars.Values)
				{
					if (value.UserName == username)
					{
						additmes("UserId", value.Userid);
						additmes("UserName", value.UserName);
						additmes("防御----------", "-------------");
						additmes("FLD_人物基本_防御", value.FLD_人物基本_防御);
						additmes("FLD_防御", value.FLD_Defense);
						additmes("FLD_武勋防御", value.FLD_武勋防御);
						additmes("FLD_装备_追加_防御", value.FLD_Item_Defense);
						additmes("FLD_人物_追加_防御", value.FLD_人物_追加_防御);
						additmes("FLD_人物_气功_防御", value.FLD_人物_气功_防御);
						additmes("FLD_追加百分比_防御", value.FLD_追加百分比_防御);
						additmes("FLD_追加百分比_防御_PHANNO", value.FLD_追加百分比_防御_PHANNO);
						additmes("FLD_追加百分比_防御_DAIPHU115", value.FLD_追加百分比_防御_DAIPHU115);
						additmes("FLD_追加百分比_防御_KCDAO115", value.FLD_追加百分比_防御_KCDAO115);
						additmes("FLD_TRUDEF_801302", value.FLD_TRUDEF_801302);
						additmes("FLD_TRUDEF_NINJA", value.FLD_TRUDEF_NINJA);
						additmes("FLD_TRUDEF_CAMSU", value.FLD_TRUDEF_CAMSU);
						additmes("FLD_TRUDAME_CAMSU", value.FLD_TRUDAME_CAMSU);
						additmes("FLD_人物_武功防御力增加百分比", value.FLD_Item_Skill_Def_Percentage + value.fldItemSkillDefPercentage);
						additmes("FLD_装备_武功防御力增加百分比", value.FLD_Item_Defense_Skill);
						additmes("FLD_人物_气功_武功防御力增加百分比", value.FLD_人物_气功_武功防御力增加百分比);
						additmes("FLD_Pill_Defense_Skill", value.FLD_Pill_Defense_Skill);
						additmes("攻击----------", "-------------");
						additmes("FLD_人物基本_攻击", value.FLD_人物基本_攻击);
						additmes("FLD_攻击", value.FLD_Attack);
						additmes("FLD_武勋攻击", value.FLD_武勋攻击);
						additmes("FLD_装备_追加_攻击", value.FLD_Item_Attack);
						additmes("FLD_人物_追加_攻击", value.FLD_人物_追加_攻击);
						additmes("FLD_人物_气功_攻击", value.FLD_人物_气功_攻击);
						additmes("FLD_追加百分比_攻击", value.FLD_追加百分比_攻击);
						additmes("FLD_追加百分比_攻击_PHANNO", value.FLD_追加百分比_攻击_PHANNO);
						additmes("FLD_追加百分比_攻击_KCDAO115", value.FLD_追加百分比_攻击_KCDAO115);
						additmes("FLD_人物_武功攻击力增加百分比", value.FLD_Item_Skill_Attack_Percentage + value.fldItemSkillAttackPercentage);
						additmes("FLD_装备_武功攻击力增加百分比", value.FLD_Item_Attack_Skill);
						additmes("FLD_人物_气功_武功攻击力增加百分比", value.FLD_人物_气功_武功攻击力增加百分比);
						additmes("其他----------", "-------------");
						additmes("FLD_BUFF_DP_ATT", value.FLD_BUFF_DP_ATT);
						additmes("FLD_BUFF_DP_DEF", value.FLD_BUFF_DP_DEF);
						additmes("FLD_BUFF_DP_HP", value.FLD_BUFF_DP_HP);
						additmes("FLD_BUFF_DP_CX", value.FLD_BUFF_DP_CX);
						additmes("FLD_BUFF_DP_NT", value.FLD_BUFF_DP_NT);
						additmes("FLD_武勋_追加_气功", value.FLD_武勋_追加_气功);
						additmes("FLD_人物_气功_命中", value.FLD_人物_气功_命中);
						additmes("FLD_人物_气功_回避", value.FLD_人物_气功_回避);
						additmes("FLD_人物_追加_命中", value.FLD_人物_追加_命中);
						additmes("FLD_人物_追加_回避", value.FLD_人物_追加_回避);
						additmes("FLD_人物基本_命中", value.FLD_人物基本_命中);
						additmes("FLD_人物基本_回避", value.FLD_人物基本_回避);
						additmes("FLD_体", value.FLD_The_3);
						additmes("FLD_力", value.FLD_Khi_2);
						additmes("FLD_命中", value.FLD_Accuracy);
						additmes("FLD_回避", value.FLD_Evasion);
						additmes("FLD_心", value.FLD_Tam_1);
						additmes("FLD_身", value.FLD_Hon_4);
						additmes("武勋追加_HP", value.武勋追加_HP);
						additmes("武勋追加_MP", value.武勋追加_MP);
						additmes("FLD_装备_追加_HP", value.FLD_Item_HP);
						additmes("FLD_装备_追加_MP", value.FLD_Item_MP);
						additmes("FLD_装备_追加_命中", value.FLD_Item_Accuracy);
						additmes("FLD_装备_追加_回避", value.FLD_Item_Evasion);
						additmes("FLD_装备_追加_武器_强化", value.FLD_Item_Plus_VK);
						additmes("FLD_装备_追加_气功", value.FLD_Item_Level_Pran);
						additmes("FLD_装备_追加_防具_强化", value.FLD_Item_Plus_TB);
						additmes("FLD_追加百分比_HP上限", value.FLD_追加百分比_HP上限);
						additmes("FLD_追加百分比_MP上限", value.FLD_追加百分比_MP上限);
						additmes("FLD_追加百分比_命中", value.FLD_追加百分比_命中);
						additmes("FLD_追加百分比_回避", value.FLD_追加百分比_回避);
						additmes("人物_HP", value.Player_FLD_HP);
						additmes("人物_MP", value.Player_FLD_MP);
						additmes("人物_SP", value.人物_SP);
						additmes("人物_气功_追加_HP", value.人物_气功_追加_HP);
						additmes("人物_气功_追加_MP", value.人物_气功_追加_MP);
						additmes("人物PK模式", value.人物PK模式);
						additmes("Player_WuXun", value.Player_WuXun);
						additmes("Player_FLD_SE", value.Player_FLD_SE);
						additmes("Player_Level", value.Player_Level);
						additmes("Player_FLD_EXP", value.Player_FLD_EXP);
						additmes("Player_FLD_FIGHT_EXP", value.人物最大经验);
						additmes("Player_Money", value.Player_Money);
						additmes("Player_Job", value.Player_Job);
						additmes("Player_Job_Level", value.Player_Job_Level);
						foreach (Class_Show_Pill value2 in value.Show_Pic_Class.Values)
						{
							additmes(value2.FLD_PID.ToString(), value2.npcyd.Interval);
						}
						break;
					}
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "人物列表出错" + arg);
			}
		}
	}
}

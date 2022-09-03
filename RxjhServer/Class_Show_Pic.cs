using System.Threading;
using RxjhServer.RxjhServer;

namespace RxjhServer
{
    using System;
    using System.Timers;

    public class Class_Show_Pill : IDisposable
    {
        private int _FLD_PID;
        private int _FLD_RESIDE1;
        public System.Timers.Timer npcyd;
        public Players Play;
        public DateTime time;

        public Class_Show_Pill(Players Play_, double 时间, int 物品ID, int FLD_RESIDE1)
        {
            this.FLD_PID = 物品ID;
            this.FLD_RESIDE1 = FLD_RESIDE1;
            this.time = DateTime.Now;
            this.time = this.time.AddMilliseconds(时间 + 0);
            this.Play = Play_;
            this.npcyd = new System.Timers.Timer(时间 + 0);
            this.npcyd.Elapsed += new ElapsedEventHandler(this.时间结束事件2);
            this.npcyd.Enabled = true;
            this.npcyd.AutoReset = false;
        }

        public void Dispose()
        {
            if (World.JlMsg == 1)
            {
                Form1.WriteLine(0, "追加状态类-Dispose");
            }
            if (this.npcyd != null)
            {
                this.npcyd.Enabled = false;
                this.npcyd.Close();
                this.npcyd.Dispose();
                this.npcyd = null;
            }
            this.Play = null;
        }

        ~Class_Show_Pill()
        {
            if (this.npcyd != null)
            {
                this.npcyd.Enabled = false;
                this.npcyd.Close();
                this.npcyd.Dispose();
                this.npcyd = null;
            }
        }

        public double getsj()
        {
            return this.time.Subtract(DateTime.Now).TotalMilliseconds;
        }

        public void EndEvent()
        {
            if (World.JlMsg == 1)
            {
                Form1.WriteLine(0, "追加状态类-时间结束事件()");
            }
            if (this.npcyd != null)
            {
                this.npcyd.Enabled = false;
                this.npcyd.Close();
                this.npcyd.Dispose();
                this.npcyd = null;
            }
            if (this.Play == null)
            {
                this.Dispose();
            }
            else
            {
                try
                {
                    switch (this.FLD_PID)
                    {
                        case 401202:
                            this.Play.FLD_人物_追加_命中 -= 40;
                            this.Play.FLD_人物_追加_回避 += 20;
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 401203:
                            this.Play.FLD_人物_追加_命中 += 20;
                            this.Play.FLD_人物_追加_回避 -= 40;
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 301201:
                            this.Play.Del_ATT_Percentage(0.02);
                            this.Play.FLD_追加百分比_HP上限 -= 0.02;
                            this.Play.Update_HP_MP_SP();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 201201:
                            this.Play.Del_ATT_Percentage(0.03);
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 2001301:
                            this.Play.Del_ATT_Percentage(0.03);
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 401301:
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
                            goto Label_23FD;

                        case 401302:
                            if (World.Newversion >= 12)
                            {
                                this.Play.FLD_Pill_Defense_Skill -= 100;
                                this.Play.UpdatePowersAndStatus();
                            }
                            else
                            {
                                this.Play.FLD_Item_Skill_Def_Percentage -= 0.1;
                            }
                            goto Label_23FD;

                        case 401303:
                            this.Play.弓箭致命一击几率 = 0.0;
                            goto Label_23FD;

                        case 401401:
                            this.Play.FLD_追加百分比_命中 -= 0.4;
                            this.Play.FLD_追加百分比_HP上限 -= 0.2;
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;

                        case 501301:
                            //this.Play.Del_ATT_Percentage(0.1);
                            this.Play.Show_Pic_Class.RemoveSafe(501301);
                            this.Play.Show_Pic_Class.RemoveSafe(501501);
                            this.Play.FLD_BUFF_DP_ATT = 0;
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 501302:
                            //this.Play.Del_DEF_Percentage(0.05);
                            this.Play.FLD_BUFF_DP_DEF = 0;
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 501303:
                            //this.Play.Del_DEF_Percentage(0.1);
                            this.Play.FLD_BUFF_DP_DEF = 0;
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 501401:
                            //this.Play.FLD_追加百分比_命中 -= 0.1;
                            this.Play.FLD_BUFF_DP_CX = 0;
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 501402:
                            //this.Play.FLD_追加百分比_回避 -= 0.1;
                            this.Play.FLD_BUFF_DP_NT = 0;
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 501403:
                            //this.Play.FLD_追加百分比_HP上限 -= 0.1;
                            this.Play.FLD_BUFF_DP_HP = 0;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;

                        case 501501:
                            //this.Play.Del_ATT_Percentage(0.1);
                            this.Play.Show_Pic_Class.RemoveSafe(501301);
                            this.Play.Show_Pic_Class.RemoveSafe(501501);
                            this.Play.FLD_BUFF_DP_ATT = 0;
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 501502:
                            //this.Play.Del_DEF_Percentage(0.1);
                            this.Play.FLD_BUFF_DP_DEF = 0;
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 501601:
                            //this.Play.FLD_追加百分比_HP上限 -= 0.1;
                            this.Play.FLD_BUFF_DP_HP = 0;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;

                        case 501701:
                            this.Play.Player_FLD_HP -= 1000;
                            this.Play.人物基本最大_HP -= 1000;
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 501602:
                            //this.Play.FLD_追加百分比_命中 -= 0.1;
                            this.Play.FLD_BUFF_DP_CX = 0;
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 501603:
                            //this.Play.FLD_追加百分比_回避 -= 0.1;
                            this.Play.FLD_BUFF_DP_NT = 0;
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 601101:
                            this.Play.行走状态(BitConverter.GetBytes(this.FLD_PID), 1);
                            this.Play.行走状态id = 1;
                            goto Label_23FD;

                        case 601102:
                            this.Play.行走状态(BitConverter.GetBytes(this.FLD_PID), 1);
                            this.Play.行走状态id = 1;
                            goto Label_23FD;

                        case 601103:
                            this.Play.行走状态(BitConverter.GetBytes(this.FLD_PID), 1);
                            this.Play.行走状态id = 1;
                            goto Label_23FD;

                        case 601201:
                            this.Play.dllFLD_装备_追加_防具_强化(1);
                            this.Play.Update_Character_Wear_Item();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 601202:
                            this.Play.dllFLD_装备_追加_武器_强化(1);
                            this.Play.Update_Character_Wear_Item();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 801201:
                            this.Play.FLD_攻击速度 = 100;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新攻击速度();
                            break;

                        case 801302:
                            this.Play.FLD_TRUDEF_801302 = 0.0;
                            this.Play.FLD_追加百分比_回避--;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新攻击速度();
                            break;

                        case 700401:
                            this.Play.行走状态人物灵兽(BitConverter.GetBytes(this.FLD_PID), 1);
                            this.Play.状态效果人物灵兽(BitConverter.GetBytes(this.FLD_PID), 0, 0);
                            goto Label_23FD;

                        case 700402:
                            this.Play.行走状态人物灵兽(BitConverter.GetBytes(this.FLD_PID), 1);
                            this.Play.状态效果人物灵兽(BitConverter.GetBytes(this.FLD_PID), 0, 0);
                            goto Label_23FD;

                        case 700403:
                            this.Play.行走状态人物灵兽(BitConverter.GetBytes(this.FLD_PID), 1);
                            this.Play.状态效果人物灵兽(BitConverter.GetBytes(this.FLD_PID), 0, 0);
                            goto Label_23FD;

                        //Khi cong thang thien 1: dao khach
                        case 700310:
                            this.Play.FLD_追加百分比_防御_KCDAO115 = 0;
                            this.Play.FLD_追加百分比_攻击_KCDAO115 = 0;
                            //this.Play.Del_ATT_Percentage(0.3);
                            //this.Play.Del_DEF_Percentage(0.1);
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        //case 501203:


                        //Hết tác dụng khí công đại phu thăng thiên 1
                        case 700350:
                            this.Play.FLD_追加百分比_防御_DAIPHU115 = 0;
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 700014:
                            this.Play.Del_ATT_Percentage_PN(0);
                            this.Play.Del_DEF_Percentage_PN(0);
                            this.Play.Show_Pic_Class.RemoveSafe(this.FLD_PID);
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新人物数据(this.Play);
                            this.Play.更新广播人物数据();
                            goto Label_23FD;



                        case 700314:
                            this.Play.Show_Pic_Class.RemoveSafe(this.FLD_PID);
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            goto Label_23FD;
                        case 700344:
                            this.Play.Show_Pic_Class.RemoveSafe(this.FLD_PID);
                            this.Play.Update_Character_Wear_Item();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 700604:
                            this.Play.FLD_追加百分比_HP上限 += 0.15;
                            this.Play.Show_Pic_Class.RemoveSafe(this.FLD_PID);
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_HP_MP_SP();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 700313:

                            this.Play.Show_Pic_Class.RemoveSafe(this.FLD_PID);
                            if (this.Play.Player_Job == 3 || this.Play.Player_Job == 10)
                            {
                                this.Play.Add_ATT_Percentage_PN(0.2 * (1.0 + this.Play.枪_末日狂舞));
                            }
                            else if (this.Play.Player_Job == 7)
                            {
                                this.Play.Add_ATT_Percentage_PN(0.15);
                            }
                            else
                            {
                                this.Play.Add_ATT_Percentage_PN(0.2);
                            }

                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新人物数据(this.Play);
                            this.Play.更新广播人物数据();
                            goto Label_23FD;
                        case 700904:
                            this.Play.Bat_Tu = 0;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新人物数据(this.Play);
                            this.Play.更新广播人物数据();
                            goto Label_23FD;
                        case 700603:
                            this.Play.FLD_Item_Premium_HP -= 1000;
                            this.Play.FLD_Item_Premium_MP -= 1000;
                            this.Play.FLD_人物_追加_攻击 -= 100;
                            this.Play.FLD_人物_追加_防御 -= 100;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.Update_HP_MP_SP();
                            this.Play.更新人物数据(this.Play);
                            this.Play.更新广播人物数据();
                            goto Label_23FD;



                        case 900401:
                            this.Play.Del_ATT_Percentage_PN(0);
                            this.Play.Del_DEF_Percentage_PN(0);
                            this.Play.Show_Pic_Class.RemoveSafe(this.FLD_PID);
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新人物数据(this.Play);
                            this.Play.更新广播人物数据();
                            goto Label_23FD;

                        case 900402:
                            this.Play.Del_ATT_Percentage_PN(0);
                            this.Play.Del_DEF_Percentage_PN(0);
                            this.Play.Show_Pic_Class.RemoveSafe(this.FLD_PID);
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新人物数据(this.Play);
                            this.Play.更新广播人物数据();
                            goto Label_23FD;

                        case 900403:
                            this.Play.Del_ATT_Percentage_PN(0);
                            this.Play.Del_DEF_Percentage_PN(0);
                            this.Play.Show_Pic_Class.RemoveSafe(this.FLD_PID);
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新人物数据(this.Play);
                            this.Play.更新广播人物数据();
                            goto Label_23FD;

                        case 1001101:
                            this.Play.行走状态(BitConverter.GetBytes(this.FLD_PID), 1);
                            this.Play.行走状态id = 1;
                            goto Label_23FD;

                        case 1001102:
                            this.Play.行走状态(BitConverter.GetBytes(this.FLD_PID), 1);
                            this.Play.行走状态id = 1;
                            goto Label_23FD;

                        case 1001301:
                            this.Play.Del_ATT_Percentage(0.05);
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1001302:
                            this.Play.Del_ATT_Percentage(0.1);
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1001303:
                            this.Play.Del_ATT_Percentage(0.15);
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1007000005:
                            this.Play.FLD_Item_Premium_HP -= 300;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;

                        case 1008000173:
                            this.Play.FLD_Item_Premium_HP -= 500;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;

                        case 1007000014:
                            this.Play.FLD_Item_Premium_HP -= 700;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;

                        case 1007000009:
                            this.Play.FLD_Item_Premium_HP -= 300;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;

                        case 1007000018:
                            this.Play.FLD_Item_Premium_HP -= 300;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;

                        case 1007000006:
                            this.Play.FLD_Item_Premium_HP -= 500;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;

                        case 1007000007:
                            this.Play.FLD_Item_Premium_HP -= 700;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;

                        case 1000000835:
                            this.Play.FLD_追加百分比_MP上限 -= 0.05;
                            if (this.Play.Player_FLD_MP > this.Play.Player_MP_Max)
                            {
                                this.Play.Player_FLD_MP = this.Play.Player_MP_Max;
                            }
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;


                        case 1000000836:
                            this.Play.FLD_追加百分比_HP上限 -= 0.05;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;

                        case 1000000860:
                            this.Play.FLD_追加百分比_MP上限 -= 0.05;
                            if (this.Play.Player_FLD_MP > this.Play.Player_MP_Max)
                            {
                                this.Play.Player_FLD_MP = this.Play.Player_MP_Max;
                            }
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;

                        case 1000000861:
                            this.Play.FLD_追加百分比_HP上限 -= 0.05;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;

                        case 1000000830:
                            this.Play.FLD_Item_Premium_HP -= 100;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;

                        case 1000000831:
                            this.Play.FLD_Item_Premium_HP -= 50;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;

                        case 1000000832:
                            this.Play.FLD_Item_Premium_HP -= 100;
                            this.Play.FLD_Item_Premium_MP -= 100;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            if (this.Play.Player_FLD_MP > this.Play.Player_MP_Max)
                            {
                                this.Play.Player_FLD_MP = this.Play.Player_MP_Max;
                            }
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;

                        case 1000000775:
                            this.Play.FLD_人物_追加_防御 -= 20;
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1000000776:
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.05;
                            this.Play.FLD_Item_Skill_Def_Percentage -= 0.1;
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000016:
                            this.Play.Del_ATT_Percentage(0.1);
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000017:
                            this.Play.Del_DEF_Percentage(0.1);
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;
                        case 1008000098:
                            this.Play.Del_ATT_Percentage(0.1);
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000099:
                            this.Play.Del_DEF_Percentage(0.1);
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000104:
                            this.Play.dllFLD_装备_追加_武器_强化(2);
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000105:
                            if (World.Newversion >= 13)
                            {
                                this.Play.dllFLD_装备_追加_武器_强化(2);
                            }
                            else
                            {
                                this.Play.dllFLD_装备_追加_防具_强化(1);
                            }
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000106:
                            this.Play.Del_ATT_Percentage(0.1);
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000107:
                            this.Play.Del_DEF_Percentage(0.1);
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000143:
                            this.Play.Del_ATT_Percentage(0.03);
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000144:
                            this.Play.Del_DEF_Percentage(0.05);
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000018:
                            this.Play.dllFLD_装备_追加_武器_强化(2);
                            this.Play.Update_Character_Wear_Item();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000019:
                            this.Play.dllFLD_装备_追加_防具_强化(1);
                            this.Play.Update_Character_Wear_Item();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000156:
                            this.Play.FLD_Item_Premium_HP -= 300;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Show_Pic_Class.RemoveSafe(1008000156);
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;

                        case 1008000183:
                            this.Play.FLD_Item_Premium_HP -= 300;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Del_DEF_Percentage(0.05);
                            this.Play.Show_Pic_Class.RemoveSafe(1008000183);
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_HP_MP_SP();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000184:
                        case 1008000186:
                        case 1008000196:
                        case 1008000233:
                        case 1008000234:
                        case 1008000235:
                        case 1008000236:
                        case 1008000237:
                        case 1008000238:
                        case 1008000244:
                        case 1008000246:
                        case 1008000247:
                        case 1008000249:
                            goto Label_23FD;

                        case 1008000185:
                            this.Play.FLD_Item_Premium_HP -= 700;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.FLD_Item_Premium_Exp -= 0.4;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.FLD_Item_Premium_Fight_Exp -= 2.0;
                            this.Play.Del_DEF_Percentage(0.1);
                            this.Play.dllFLD_装备_追加_防具_强化(1);
                            this.Play.dllFLD_装备_追加_武器_强化(2);
                            this.Play.Update_HP_MP_SP();
                            this.Play.UpdatePowersAndStatus();
                            this.Play.Update_Character_Wear_Item();
                            goto Label_23FD;

                        case 1008000187:
                            this.Play.FLD_Item_Premium_HP -= 300;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Character_Qigong--;
                            this.Play.Show_Pic_Class.RemoveSafe(1008000187);
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_HP_MP_SP();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000188:
                            this.Play.Del_ATT_Percentage(0.15);
                            this.Play.Del_DEF_Percentage(0.15);
                            this.Play.FLD_Item_Premium_HP -= 300;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.FLD_Item_Premium_MP -= 300;
                            if (this.Play.Player_FLD_MP > this.Play.Player_MP_Max)
                            {
                                this.Play.Player_FLD_MP = this.Play.Player_MP_Max;
                            }
                            this.Play.FLD_Item_Premium_Exp -= 0.1;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.Show_Pic_Class.RemoveSafe(1008000188);
                            this.Play.UpdatePowersAndStatus();
                            this.Play.Update_HP_MP_SP();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            goto Label_23FD;

                        case 1008000388:
                            this.Play.FLD_TLC_Premium_Exp = 0.0;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.Show_Pic_Class.RemoveSafe(1008000388);
                            this.Play.UpdatePowersAndStatus();
                            this.Play.Update_HP_MP_SP();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            goto Label_23FD;

                        case 1008000389:
                            this.Play.FLD_TLC_Premium_Exp = 0.0;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.Show_Pic_Class.RemoveSafe(1008000389);
                            this.Play.UpdatePowersAndStatus();
                            this.Play.Update_HP_MP_SP();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            goto Label_23FD;

                        case 1008000194:
                            this.Play.FLD_Item_Premium_HP -= 1000;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Del_ATT_Percentage(0.15);
                            this.Play.Del_DEF_Percentage(0.15);
                            this.Play.FLD_Item_Premium_Exp -= 0.4;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
                            this.Play.FLD_Item_Skill_Def_Percentage -= 0.1;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;

                        case 1008000195:
                            this.Play.FLD_Item_Premium_HP -= 300;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Character_Qigong--;
                            this.Play.Del_DEF_Percentage(0.05);
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_HP_MP_SP();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000163:
                            this.Play.FLD_Item_Premium_HP -= 700;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Del_DEF_Percentage(0.1);
                            this.Play.Del_ATT_Percentage(0.1);
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.05;
                            this.Play.FLD_Item_Skill_Def_Percentage -= 0.1;
                            this.Play.dllFLD_装备_追加_武器_强化(2);
                            this.Play.dllFLD_装备_追加_防具_强化(1);
                            this.Play.Show_Pic_Class.RemoveSafe(1008000163);
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_HP_MP_SP();
                            this.Play.Update_Character_Wear_Item();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1000000137:

                            this.Play.FLD_人物_追加_攻击 -= 10;
                            this.Play.FLD_人物_追加_防御 -= 10;
                            this.Play.Show_Pic_Class.RemoveSafe(1000000137);
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_HP_MP_SP();
                            this.Play.Update_Character_Wear_Item();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000197:
                            this.Play.FLD_Item_Premium_HP -= 700;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Del_DEF_Percentage(0.1);
                            this.Play.Del_ATT_Percentage(0.1);
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.05;
                            this.Play.FLD_Item_Skill_Def_Percentage -= 0.1;
                            this.Play.dllFLD_装备_追加_武器_强化(2);
                            this.Play.dllFLD_装备_追加_防具_强化(1);
                            this.Play.Show_Pic_Class.RemoveSafe(1008000197);
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_HP_MP_SP();
                            this.Play.Update_Character_Wear_Item();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000203:
                            this.Play.Character_Qigong--;
                            this.Play.Show_Pic_Class.RemoveSafe(this.FLD_PID);
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_HP_MP_SP();
                            this.Play.Update_Character_Wear_Item();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000204:
                            this.Play.FLD_Item_Premium_HP -= 500;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Show_Pic_Class.RemoveSafe(this.FLD_PID);
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_HP_MP_SP();
                            this.Play.Update_Character_Wear_Item();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000205:
                            this.Play.FLD_Item_Premium_MP -= 500;
                            if (this.Play.Player_FLD_MP > this.Play.Player_MP_Max)
                            {
                                this.Play.Player_FLD_MP = this.Play.Player_MP_Max;
                            }
                            this.Play.Show_Pic_Class.RemoveSafe(this.FLD_PID);
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_HP_MP_SP();
                            this.Play.Update_Character_Wear_Item();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000206:
                            this.Play.Character_Upgrade_Lucky -= 0.03;
                            this.Play.Show_Pic_Class.RemoveSafe(this.FLD_PID);
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_HP_MP_SP();
                            this.Play.Update_Character_Wear_Item();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000207:
                            this.Play.Del_ATT_Percentage(0.05);
                            this.Play.Show_Pic_Class.RemoveSafe(this.FLD_PID);
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_HP_MP_SP();
                            this.Play.Update_Character_Wear_Item();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000208:
                            this.Play.Del_DEF_Percentage(0.05);
                            this.Play.Show_Pic_Class.RemoveSafe(this.FLD_PID);
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_HP_MP_SP();
                            this.Play.Update_Character_Wear_Item();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000209:
                            this.Play.FLD_追加百分比_回避 -= 0.05;
                            this.Play.Show_Pic_Class.RemoveSafe(this.FLD_PID);
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_HP_MP_SP();
                            this.Play.Update_Character_Wear_Item();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1000000030:
                        case 1000000866:
                            this.Play.FLD_Item_Premium_Fight_Exp--;
                            this.Play.Show_Pic_Class.RemoveSafe(1000000866);
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_HP_MP_SP();
                            this.Play.Update_Character_Wear_Item();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;


                        case 1008000232:
                            this.Play.FLD_Item_Premium_HP -= 100;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.FLD_Item_Premium_Exp -= 0.2;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.FLD_Item_Premium_Money -= 0.4;
                            this.Play.FLD_Item_Premium_Drop -= 0.2;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.Update_HP_MP_SP();
                            goto Label_23FD;

                        case 1008000239:
                            this.Play.FLD_Item_Premium_Exp--;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 999000249:
                            this.Play.FLD_Event_Premium_Exp = 0.0;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.Update_HP_MP_SP();
                            //this.Play.GameMessage("Ket thuc su kien x2 kinh nghiem. Chuc cac ban choi game vui ve !!!", 8);
                            this.Play.GameMessage("Kêìt thuìc sýò kiêòn kinh nghiêòm: +" + this.Play.FLD_Event_Premium_Exp * 100 + "%", 10);
                            goto Label_23FD;

                        case 1008000351:
                            this.Play.FLD_Item_Premium_Exp -= 0.2;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.UpdatePowersAndStatus();
                            break;

                        case 1008000355:
                            this.Play.FLD_Item_Premium_Exp -= 0.5;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.UpdatePowersAndStatus();
                            break;

                        case 1008000095:
                            this.Play.FLD_Item_Premium_Exp -= 0.2;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.UpdatePowersAndStatus();
                            break;

                        case 1008000096:
                            this.Play.FLD_Item_Premium_Exp -= 0.3;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.UpdatePowersAndStatus();
                            break;

                        case 1008000097:
                            this.Play.FLD_Item_Premium_Exp -= 0.4;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.UpdatePowersAndStatus();
                            break;

                        case 1008000240:
                            this.Play.FLD_Item_Premium_Exp -= 0.05;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.FLD_人物_追加_攻击 -= 30;
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.03;
                            this.Play.妖花青草 = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;

                        case 1008000241:
                            this.Play.FLD_Item_Premium_Exp -= 0.05;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.FLD_人物_追加_攻击 -= 30;
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.03;
                            this.Play.妖花青草 = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;

                        case 1008000242:
                            this.Play.FLD_Item_Premium_Exp -= 0.05;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.FLD_人物_追加_攻击 -= 30;
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.03;
                            this.Play.妖花青草 = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;

                        case 1008000243:
                            this.Play.Del_ATT_Percentage(0.2);
                            this.Play.Del_DEF_Percentage(0.2);
                            this.Play.FLD_Item_Premium_HP -= 200;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.FLD_Item_Premium_Exp -= 0.15;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.05;
                            this.Play.Update_HP_MP_SP();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008001040:
                            this.Play.Update_HP_MP_SP();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008001041:
                            this.Play.Update_HP_MP_SP();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000245:
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
                            this.Play.FLD_追加百分比_回避 -= 0.05;
                            this.Play.FLD_Item_Premium_HP -= 100;
                            this.Play.Character_Qigong -= 2;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Show_Pic_Class.RemoveSafe(1008000245);
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_HP_MP_SP();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000248:
                            this.Play.FLD_Item_Premium_Exp--;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.FLD_Item_Premium_Fight_Exp--;
                            this.Play.FLD_Item_Premium_Money--;
                            this.Play.FLD_Item_Premium_Drop--;
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000250:
                            this.Play.FLD_Item_Premium_Exp -= 0.05;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.FLD_人物_追加_攻击 -= 30;
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.03;
                            this.Play.妖花青草 = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;

                        case 1008001021:
                            this.Play.Character_Qigong -= 3;
                            this.Play.FLD_Item_Premium_Exp -= 0.4;
                            this.Play.Del_ATT_Percentage(0.07);
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.12;
                            this.Play.Del_DEF_Percentage(0.12);
                            this.Play.FLD_Item_Premium_HP -= 600;
                            this.Play.FLD_Item_Premium_MP -= 400;

                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.KimLongChiTheu = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;
                        case 1008001026:
                            this.Play.Character_Qigong -= 3;
                            this.Play.FLD_Item_Premium_Exp -= 0.4;
                            this.Play.Del_ATT_Percentage(0.07);
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.12;
                            this.Play.Del_DEF_Percentage(0.12);
                            this.Play.FLD_Item_Premium_HP -= 600;
                            this.Play.FLD_Item_Premium_MP -= 400;

                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.KimLongChiTheu = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;
                        case 1008001031:
                            this.Play.Character_Qigong -= 3;
                            this.Play.FLD_Item_Premium_Exp -= 0.4;
                            this.Play.Del_ATT_Percentage(0.07);
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.12;
                            this.Play.Del_DEF_Percentage(0.12);
                            this.Play.FLD_Item_Premium_HP -= 600;
                            this.Play.FLD_Item_Premium_MP -= 400;

                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.KimLongChiTheu = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;
                        case 1008001022:
                            this.Play.Character_Qigong -= 3;
                            this.Play.FLD_Item_Premium_Exp -= 0.4;
                            this.Play.Del_ATT_Percentage(0.05);
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
                            this.Play.Del_DEF_Percentage(0.1);
                            this.Play.FLD_Item_Premium_HP -= 500;
                            this.Play.FLD_Item_Premium_MP -= 300;

                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.KimLongChiTheu = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;
                        case 1008001027:
                            this.Play.Character_Qigong -= 3;
                            this.Play.FLD_Item_Premium_Exp -= 0.4;
                            this.Play.Del_ATT_Percentage(0.05);
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
                            this.Play.Del_DEF_Percentage(0.1);
                            this.Play.FLD_Item_Premium_HP -= 500;
                            this.Play.FLD_Item_Premium_MP -= 300;

                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.KimLongChiTheu = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;
                        case 1008001032:
                            this.Play.Character_Qigong -= 3;
                            this.Play.FLD_Item_Premium_Exp -= 0.4;
                            this.Play.Del_ATT_Percentage(0.05);
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
                            this.Play.Del_DEF_Percentage(0.1);
                            this.Play.FLD_Item_Premium_HP -= 500;
                            this.Play.FLD_Item_Premium_MP -= 300;

                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.KimLongChiTheu = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;
                        case 1008001023:
                            this.Play.Character_Qigong -= 3;
                            this.Play.FLD_Item_Premium_Exp -= 0.2;
                            this.Play.Del_ATT_Percentage(0.05);
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
                            this.Play.Del_DEF_Percentage(0.1);
                            this.Play.FLD_Item_Premium_HP -= 500;
                            this.Play.FLD_Item_Premium_MP -= 300;

                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.KimLongChiTheu = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;
                        case 1008001028:
                            this.Play.Character_Qigong -= 3;
                            this.Play.FLD_Item_Premium_Exp -= 0.2;
                            this.Play.Del_ATT_Percentage(0.05);
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
                            this.Play.Del_DEF_Percentage(0.1);
                            this.Play.FLD_Item_Premium_HP -= 500;
                            this.Play.FLD_Item_Premium_MP -= 300;

                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.KimLongChiTheu = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;
                        case 1008001033:
                            this.Play.Character_Qigong -= 3;
                            this.Play.FLD_Item_Premium_Exp -= 0.2;
                            this.Play.Del_ATT_Percentage(0.05);
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
                            this.Play.Del_DEF_Percentage(0.1);
                            this.Play.FLD_Item_Premium_HP -= 500;
                            this.Play.FLD_Item_Premium_MP -= 300;

                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.KimLongChiTheu = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;
                        case 1008001024:
                            this.Play.Character_Qigong -= 3;
                            this.Play.FLD_Item_Premium_Exp -= 0.2;

                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.KimLongChiTheu = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;
                        case 1008001029:
                            this.Play.Character_Qigong -= 3;
                            this.Play.FLD_Item_Premium_Exp -= 0.2;

                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.KimLongChiTheu = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;
                        case 1008001034:
                            this.Play.Character_Qigong -= 3;
                            this.Play.FLD_Item_Premium_Exp -= 0.2;

                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.KimLongChiTheu = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;
                        case 1008001025:
                            this.Play.Del_ATT_Percentage(0.05);
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
                            this.Play.Del_DEF_Percentage(0.1);
                            this.Play.FLD_Item_Premium_HP -= 500;
                            this.Play.FLD_Item_Premium_MP -= 300;

                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.KimLongChiTheu = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;
                        case 1008001030:
                            this.Play.Del_ATT_Percentage(0.05);
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
                            this.Play.Del_DEF_Percentage(0.1);
                            this.Play.FLD_Item_Premium_HP -= 500;
                            this.Play.FLD_Item_Premium_MP -= 300;

                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.KimLongChiTheu = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;
                        case 1008001035:
                            this.Play.Del_ATT_Percentage(0.05);
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
                            this.Play.Del_DEF_Percentage(0.1);
                            this.Play.FLD_Item_Premium_HP -= 500;
                            this.Play.FLD_Item_Premium_MP -= 300;

                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.KimLongChiTheu = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;

                        case 1008001111:
                            this.Play.FLD_人物_追加_攻击 -= 50;
                            this.Play.FLD_人物_追加_防御 -= 100;
                            this.Play.FLD_Item_Premium_HP -= 500;
                            this.Play.FLD_Item_Premium_MP -= 500;
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
                            this.Play.FLD_Item_Premium_Exp -= 0.4;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.妖花青草 = false;
                            this.Play.Update_Character_Wear_Item();
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;

                        case 1008001112:
                            this.Play.FLD_人物_追加_攻击 -= 100;
                            this.Play.FLD_人物_追加_防御 -= 50;
                            this.Play.FLD_Item_Premium_HP -= 800;
                            this.Play.FLD_人物_追加_回避 -= 10;
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.1;
                            this.Play.FLD_Pill_Defense_Skill -= 100;
                            this.Play.妖花青草 = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;

                        case 1008000251:
                            this.Play.FLD_Item_Premium_Exp -= 0.05;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.FLD_人物_追加_攻击 -= 30;
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.03;
                            this.Play.妖花青草 = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;

                        case 1008000252:



                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.2;
                            this.Play.FLD_人物_追加_防御 -= 30;
                            this.Play.FLD_Item_Attack -= 25;
                            this.Play.FLD_Item_Premium_HP -= 300;

                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.Show_Pic_Class.RemoveSafe(1008000252);
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_HP_MP_SP();
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000304:
                            this.Play.FLD_Item_Premium_Exp -= 0.05;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.FLD_人物_追加_攻击 -= 30;
                            this.Play.FLD_人物_追加_防御 -= 30;
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.03;
                            this.Play.妖花青草 = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;

                        case 1008000305:
                            this.Play.FLD_Item_Premium_Exp -= 0.05;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.FLD_人物_追加_攻击 -= 30;
                            this.Play.FLD_人物_追加_防御 -= 30;
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.03;
                            this.Play.妖花青草 = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;

                        case 1008000333:
                            this.Play.FLD_Item_Premium_Exp -= 0.05;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.FLD_人物_追加_攻击 -= 30;
                            this.Play.FLD_人物_追加_防御 -= 30;
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.03;
                            this.Play.妖花青草 = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;

                        case 1008000306:
                            this.Play.FLD_Item_Premium_Exp -= 0.1;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.FLD_人物_追加_攻击 -= 40;
                            this.Play.FLD_人物_追加_防御 -= 40;
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.05;
                            this.Play.妖花青草 = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;

                        case 1008000307:
                            this.Play.FLD_Item_Premium_Exp -= 0.1;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.FLD_人物_追加_攻击 -= 40;
                            this.Play.FLD_人物_追加_防御 -= 40;
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.05;
                            this.Play.妖花青草 = false;
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;

                        case 1008000323:
                            this.Play.FLD_Item_Premium_Exp--;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000324:
                            this.Play.FLD_Item_Premium_Exp--;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000325:
                            this.Play.FLD_Item_Premium_Exp -= 0.1;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.FLD_人物_追加_攻击 -= 40;
                            this.Play.FLD_人物_追加_防御 -= 40;
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.05;
                            this.Play.FLD_Item_Premium_HP -= 300;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.妖花青草 = false;
                            this.Play.Update_HP_MP_SP();
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;

                        case 1008000326:
                            this.Play.FLD_Item_Premium_Exp -= 0.1;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.FLD_人物_追加_攻击 -= 40;
                            this.Play.FLD_人物_追加_防御 -= 40;
                            this.Play.FLD_Item_Skill_Attack_Percentage -= 0.05;
                            this.Play.FLD_Item_Premium_HP -= 300;
                            if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                            {
                                this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                            }
                            this.Play.妖花青草 = false;
                            this.Play.Update_HP_MP_SP();
                            this.Play.UpdatePowersAndStatus();
                            this.Play.更新广播人物数据();
                            this.Play.更新人物数据(this.Play);
                            this.Play.Update_Equipment_Effectiveness();
                            goto Label_23FD;

                        case 1008000362:
                            this.Play.FLD_Item_Premium_Exp -= 1.5;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;

                        case 1008000363:
                            this.Play.FLD_Item_Premium_Exp -= 1.5;
                            if (this.Play.FLD_Item_Premium_Exp < 0.0)
                            {
                                this.Play.FLD_Item_Premium_Exp = 0.0;
                            }
                            this.Play.UpdatePowersAndStatus();
                            goto Label_23FD;
                    }
                Label_23FD:
                    if (this.Play.Player_FLD_HP > this.Play.Player_HP_Max)
                    {
                        this.Play.Player_FLD_HP = this.Play.Player_HP_Max;
                    }
                    if (this.Play.Show_Pic_Class != null)
                    {
                        this.Play.Show_Pic_Class.RemoveSafe(this.FLD_PID);
                    }
                    this.Play.Send_Packet_Show_Pic(BitConverter.GetBytes(this.FLD_PID), 0, 0);
                    this.Dispose();
                }
                catch (Exception exception)
                {
                    Form1.WriteLine(1, string.Concat(new object[] { "追加状态类 时间结束事件 出错：[", this.FLD_PID, "]", exception }));
                }
                finally
                {
                    this.Dispose();
                }
            }
        }

        public void 时间结束事件2(object sender, ElapsedEventArgs e)
        {
            if (World.JlMsg == 1)
            {
                Form1.WriteLine(0, "追加状态类-时间结束事件2");
            }
            this.EndEvent();
        }

        public int FLD_PID
        {
            get
            {
                return this._FLD_PID;
            }
            set
            {
                this._FLD_PID = value;
            }
        }

        public int FLD_RESIDE1
        {
            get
            {
                return this._FLD_RESIDE1;
            }
            set
            {
                this._FLD_RESIDE1 = value;
            }
        }

        public double FLD_sj
        {
            get
            {
                return this.getsj();
            }
        }
    }
}


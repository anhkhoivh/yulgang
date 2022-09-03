namespace RxjhTool
{
    using System;
    using System.Collections.Generic;

    public class 任务类
    {
        private int a;
        private string b = "";
        private int c;
        private string eval_d = "";
        private string eval_e = "";
        private string eval_f = "";
        private string eval_g = "";
        private int eval_i;
        private 坐标类 eval_j = new 坐标类();
        private string eval_l = "";
        private string eval_m = "";
        private int eval_n;
        private List<任务奖励物品类> h = new List<任务奖励物品类>();
        private List<任务需要物品类> k = new List<任务需要物品类>();
        private List<任务阶段类> list_0 = new List<任务阶段类>();
        public int Npc未知1;
        public string 任务欢迎接受提示2 = "";
        public string 任务欢迎接受提示3 = "";
        public string 任务欢迎接受提示4 = "";
        public string 任务欢迎接受提示5 = "";
        public string 任务欢迎拒绝提示2 = "";
        public string 任务欢迎拒绝提示3 = "";
        public string 任务欢迎拒绝提示4 = "";
        public string 任务欢迎拒绝提示5 = "";
        public int 任务未知1;
        public int 任务未知2;
        public int 任务未知3;
        public int 任务未知4;
        public int 任务未知5;
        public int 任务未知6;
        public int 任务未知7;

        public int NpcID
        {
            get
            {
                return this.eval_i;
            }
            set
            {
                this.eval_i = value;
            }
        }

        public 坐标类 Npc坐标
        {
            get
            {
                return this.eval_j;
            }
            set
            {
                this.eval_j = value;
            }
        }

        public List<任务奖励物品类> 奖励物品
        {
            get
            {
                return this.h;
            }
            set
            {
                this.h = value;
            }
        }

        public int 任务ID
        {
            get
            {
                return this.a;
            }
            set
            {
                this.a = value;
            }
        }

        public int 任务等级
        {
            get
            {
                return this.c;
            }
            set
            {
                this.c = value;
            }
        }

        public string 任务欢迎接受提示1
        {
            get
            {
                return this.eval_m;
            }
            set
            {
                this.eval_m = value;
            }
        }

        public string 任务欢迎拒绝提示1
        {
            get
            {
                return this.eval_l;
            }
            set
            {
                this.eval_l = value;
            }
        }

        public List<任务阶段类> 任务阶段
        {
            get
            {
                return this.list_0;
            }
            set
            {
                this.list_0 = value;
            }
        }

        public int 任务阶段数量
        {
            get
            {
                return this.eval_n;
            }
            set
            {
                this.eval_n = value;
            }
        }

        public string 任务接受提示1
        {
            get
            {
                return this.eval_f;
            }
            set
            {
                this.eval_f = value;
            }
        }

        public string 任务接受提示2
        {
            get
            {
                return this.eval_g;
            }
            set
            {
                this.eval_g = value;
            }
        }

        public string 任务拒绝提示1
        {
            get
            {
                return this.eval_d;
            }
            set
            {
                this.eval_d = value;
            }
        }

        public string 任务拒绝提示2
        {
            get
            {
                return this.eval_e;
            }
            set
            {
                this.eval_e = value;
            }
        }

        public string 任务名
        {
            get
            {
                return this.b;
            }
            set
            {
                this.b = value;
            }
        }

        public List<任务需要物品类> 需要物品
        {
            get
            {
                return this.k;
            }
            set
            {
                this.k = value;
            }
        }
    }
}


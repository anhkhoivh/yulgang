using RxjhTool;

namespace RxjhTool
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Drawing.Design;

    public class 任务阶段类
    {
        private string eval_a = "";
        private int eval_b;
        private int eval_c;
        private int eval_d;
        private int eval_e;
        private string eval_g = "";
        private string eval_h = "";
        private List<任务需要物品类> f = new List<任务需要物品类>();
        public int Npc未知1;
        public string 任务条件不符合提示2 = "";
        public string 任务条件不符合提示3 = "";
        public string 任务条件不符合提示4 = "";
        public string 任务条件不符合提示5 = "";
        public string 任务条件符合提示2 = "";
        public string 任务条件符合提示3 = "";
        public string 任务条件符合提示4 = "";
        public string 任务条件符合提示5 = "";

        [Category("基本"), Description("NpcID")]
        public int NpcID
        {
            get
            {
                return this.eval_b;
            }
            set
            {
                this.eval_b = value;
            }
        }

        [Description("地图ID"), Category("基本")]
        public int Npc地图ID
        {
            get
            {
                return this.eval_c;
            }
            set
            {
                this.eval_c = value;
            }
        }

        [Description("坐标X"), Category("基本")]
        public int Npc坐标X
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

        [Category("基本"), Description("坐标Y")]
        public int Npc坐标Y
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

        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor)), Description("当前阶段提示内容"), Category("阶段内容")]
        public string 任务阶段内容
        {
            get
            {
                return this.eval_a;
            }
            set
            {
                this.eval_a = value;
            }
        }

        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor)), Category("提示内容"), Description("坐标Y")]
        public string 任务条件不符合提示1
        {
            get
            {
                return this.eval_h;
            }
            set
            {
                this.eval_h = value;
            }
        }

        [Category("提示内容"), Editor(typeof(MultilineStringEditor), typeof(UITypeEditor)), Description("坐标Y")]
        public string 任务条件符合提示1
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

        [Editor(typeof(My需要物品CollectionEditor), typeof(UITypeEditor)), Category("需要物品"), Description("要完成当前阶段任务需要的物品")]
        public List<任务需要物品类> 需要物品
        {
            get
            {
                return this.f;
            }
            set
            {
                this.f = value;
            }
        }
    }
}


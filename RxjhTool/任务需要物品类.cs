namespace RxjhTool
{
    using System;
    using System.ComponentModel;

    [DefaultProperty("物品ID")]
    public class 任务需要物品类
    {
        private int a;
        private int b;
        private int c;
        private int d;
        private int e;

        [Category("基本"), Description("地图ID")]
        public int 地图ID
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

        [Description("物品ID"), Category("基本")]
        public int 物品ID
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

        [Category("基本"), Description("物品数量")]
        public int 物品数量
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

        [Category("基本"), Description("坐标X")]
        public int 坐标X
        {
            get
            {
                return this.d;
            }
            set
            {
                this.d = value;
            }
        }

        [Description("坐标Y"), Category("基本")]
        public int 坐标Y
        {
            get
            {
                return this.e;
            }
            set
            {
                this.e = value;
            }
        }
    }
}


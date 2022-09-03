namespace RxjhTool
{
    using System;
    using System.ComponentModel;

    [DefaultProperty("物品ID")]
    public class 任务奖励物品类
    {
        private int a;
        private int b;

        [Category("基本"), Description("物品ID")]
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
    }
}


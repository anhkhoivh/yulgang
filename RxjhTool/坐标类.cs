namespace RxjhTool
{
    using System;

    public class 坐标类
    {
        private int _地图ID;
        private int _坐标X;
        private int _坐标Y;

        public int 地图ID
        {
            get
            {
                return this._地图ID;
            }
            set
            {
                this._地图ID = value;
            }
        }

        public int 坐标X
        {
            get
            {
                return this._坐标X;
            }
            set
            {
                this._坐标X = value;
            }
        }

        public int 坐标Y
        {
            get
            {
                return this._坐标Y;
            }
            set
            {
                this._坐标Y = value;
            }
        }
    }
}


namespace CheckCopy
{
    using System;

    public class ThreadParameter
    {
        private int _全局ID;
        private int _类型;
        private string _id;
        private string _name;

        public ThreadParameter(int 全局ID, string id, string name, int 类型)
        {
        }

        public string id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public int 类型
        {
            get
            {
                return this._类型;
            }
            set
            {
                this._类型 = value;
            }
        }

        public int 全局ID
        {
            get
            {
                return this._全局ID;
            }
            set
            {
                this._全局ID = value;
            }
        }
    }
}


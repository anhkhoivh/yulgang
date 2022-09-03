namespace RxjhServer
{
    public class 客户端IP地址
    {
        private string a;
        private string eval_b;
        private string eval_c;
        private string eval_d;

        public 客户端IP地址(string id, string Nip, string Wip, string MAC)
        {
            this.ID = id;
            this.内网IP地址 = Nip;
            this.外网IP地址 = Wip;
            this.MAC地址 = MAC;
        }

        public string ID
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

        public string MAC地址
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

        public string 内网IP地址
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

        public string 外网IP地址
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
    }
}


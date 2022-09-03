namespace DbClss
{
    using System;

    public class DbClass
    {
        private string _ServerDb;
        private string _SqlConnect;

        public string ServerDb
        {
            get
            {
                return this._ServerDb;
            }
            set
            {
                this._ServerDb = value;
            }
        }

        public string SqlConnect
        {
            get
            {
                return this._SqlConnect;
            }
            set
            {
                this._SqlConnect = value;
            }
        }
    }
}


namespace LinqSQL
{
    using System;
    using System.ComponentModel;
    using System.Data.Linq.Mapping;
    using System.Threading;

    [Table(Name="dbo.TBL_XWWL_Pigeons")]
    public class TBL_XWWL_Pigeons : INotifyPropertyChanging, INotifyPropertyChanged
    {
        private string _dateTimeBytes;
        private int _id;
        private string _message;
        private string _receiver;
        private string _sender;
        private int _status;
        private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(string.Empty);

        public event PropertyChangedEventHandler PropertyChanged;

        public event PropertyChangingEventHandler PropertyChanging;

        protected virtual void SendPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected virtual void SendPropertyChanging()
        {
            if (this.PropertyChanging != null)
            {
                this.PropertyChanging(this, emptyChangingEventArgs);
            }
        }

        [Column(Storage="_dateTimeBytes", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
        public string dateTimeBytes
        {
            get
            {
                return this._dateTimeBytes;
            }
            set
            {
                if (this._dateTimeBytes != value)
                {
                    this.SendPropertyChanging();
                    this._dateTimeBytes = value;
                    this.SendPropertyChanged("dateTimeBytes");
                }
            }
        }

        [Column(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
        public int id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (this._id != value)
                {
                    this.SendPropertyChanging();
                    this._id = value;
                    this.SendPropertyChanged("id");
                }
            }
        }

        [Column(Storage="_message", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
        public string message
        {
            get
            {
                return this._message;
            }
            set
            {
                if (this._message != value)
                {
                    this.SendPropertyChanging();
                    this._message = value;
                    this.SendPropertyChanged("message");
                }
            }
        }
        
        [Column(Storage="_receiver", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
        public string receiver
        {
            get
            {
                return this._receiver;
            }
            set
            {
                if (this._receiver != value)
                {
                    this.SendPropertyChanging();
                    this._receiver = value;
                    this.SendPropertyChanged("receiver");
                }
            }
        }

        [Column(Storage="_sender", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
        public string sender
        {
            get
            {
                return this._sender;
            }
            set
            {
                if (this._sender != value)
                {
                    this.SendPropertyChanging();
                    this._sender = value;
                    this.SendPropertyChanged("sender");
                }
            }
        }

        [Column(Storage="_status", DbType="Int NOT NULL")]
        public int status
        {
            get
            {
                return this._status;
            }
            set
            {
                if (this._status != value)
                {
                    this.SendPropertyChanging();
                    this._status = value;
                    this.SendPropertyChanged("status");
                }
            }
        }
    }
}


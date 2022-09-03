namespace LinqSQL
{
    using System;
    using System.Data.Linq.Mapping;

    [Table(Name="dbo.TBL_QUESTDROP")]
    public class TBL_QUESTDROP
    {
        private int _DropRatePercent;
        private int _id;
        private int _QuestID;
        private int _MonsterID;
        private int _MonsterID2;
        private int _QuestDropID;
        private int _QuestDropID2;
        private int _QuestItemMax;
        private int _QuestItemMax2;
        private int _MonsterID3;
        private int _MonsterID4;
        private int _QuestDropID3;
        private int _QuestDropID4;
        private int _QuestItemMax3;
        private int _QuestItemMax4;
        private int _QuestLevel;
        private string _QuestName;

        [Column(Storage="_DropRatePercent", DbType="Int NOT NULL")]
        public int DropRatePercent
        {
            get
            {
                return this._DropRatePercent;
            }
            set
            {
                if (this._DropRatePercent != value)
                {
                    this._DropRatePercent = value;
                }
            }
        }

        [Column(Storage="_id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
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
                    this._id = value;
                }
            }
        }

        [Column(Storage = "_MonsterID", DbType = "Int NOT NULL")]
        public int MonsterID
        {
            get
            {
                return this._MonsterID;
            }
            set
            {
                if (this._MonsterID != value)
                {
                    this._MonsterID = value;
                }
            }
        }

        [Column(Storage = "_MonsterID2", DbType = "Int NOT NULL")]
        public int MonsterID2
        {
            get
            {
                return this._MonsterID2;
            }
            set
            {
                if (this._MonsterID2 != value)
                {
                    this._MonsterID2 = value;
                }
            }
        }
        [Column(Storage = "_MonsterID3", DbType = "Int NOT NULL")]
        public int MonsterID3
        {
            get
            {
                return this._MonsterID3;
            }
            set
            {
                if (this._MonsterID3 != value)
                {
                    this._MonsterID3 = value;
                }
            }
        }

        [Column(Storage = "_MonsterID4", DbType = "Int NOT NULL")]
        public int MonsterID4
        {
            get
            {
                return this._MonsterID4;
            }
            set
            {
                if (this._MonsterID4 != value)
                {
                    this._MonsterID4 = value;
                }
            }
        }

        //[Column(Storage="_MonsterName", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
        //public string MonsterName
        //{
        //    get
        //    {
        //        return this._MonsterName;
        //    }
        //    set
        //    {
        //        if (this._MonsterName != value)
        //        {
        //            this._MonsterName = value;
        //        }
        //    }
        //}

        [Column(Storage = "_QuestDropID", DbType = "Int NOT NULL")]
        public int QuestDropID
        {
            get
            {
                return this._QuestDropID;
            }
            set
            {
                if (this._QuestDropID != value)
                {
                    this._QuestDropID = value;
                }
            }
        }

        [Column(Storage = "_QuestDropID2", DbType = "Int NOT NULL")]
        public int QuestDropID2
        {
            get
            {
                return this._QuestDropID2;
            }
            set
            {
                if (this._QuestDropID2 != value)
                {
                    this._QuestDropID2 = value;
                }
            }
        }

        [Column(Storage = "_QuestDropID3", DbType = "Int NOT NULL")]
        public int QuestDropID3
        {
            get
            {
                return this._QuestDropID3;
            }
            set
            {
                if (this._QuestDropID3 != value)
                {
                    this._QuestDropID3 = value;
                }
            }
        }

        [Column(Storage = "_QuestDropID4", DbType = "Int NOT NULL")]
        public int QuestDropID4
        {
            get
            {
                return this._QuestDropID4;
            }
            set
            {
                if (this._QuestDropID4 != value)
                {
                    this._QuestDropID4 = value;
                }
            }
        }

        [Column(Storage="_QuestID", DbType="Int NOT NULL")]
        public int QuestID
        {
            get
            {
                return this._QuestID;
            }
            set
            {
                if (this._QuestID != value)
                {
                    this._QuestID = value;
                }
            }
        }

        [Column(Storage = "_QuestItemMax", DbType = "Int NOT NULL")]
        public int QuestItemMax
        {
            get
            {
                return this._QuestItemMax;
            }
            set
            {
                if (this._QuestItemMax != value)
                {
                    this._QuestItemMax = value;
                }
            }
        }

        [Column(Storage = "_QuestItemMax2", DbType = "Int NOT NULL")]
        public int QuestItemMax2
        {
            get
            {
                return this._QuestItemMax2;
            }
            set
            {
                if (this._QuestItemMax2 != value)
                {
                    this._QuestItemMax2 = value;
                }
            }
        }
        [Column(Storage = "_QuestItemMax3", DbType = "Int NOT NULL")]
        public int QuestItemMax3
        {
            get
            {
                return this._QuestItemMax3;
            }
            set
            {
                if (this._QuestItemMax3 != value)
                {
                    this._QuestItemMax3 = value;
                }
            }
        }
        [Column(Storage = "_QuestItemMax4", DbType = "Int NOT NULL")]
        public int QuestItemMax4
        {
            get
            {
                return this._QuestItemMax4;
            }
            set
            {
                if (this._QuestItemMax4 != value)
                {
                    this._QuestItemMax4 = value;
                }
            }
        }

        [Column(Storage="_QuestLevel", DbType="Int NOT NULL")]
        public int QuestLevel
        {
            get
            {
                return this._QuestLevel;
            }
            set
            {
                if (this._QuestLevel != value)
                {
                    this._QuestLevel = value;
                }
            }
        }

        [Column(Storage="_QuestName", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
        public string QuestName
        {
            get
            {
                return this._QuestName;
            }
            set
            {
                if (this._QuestName != value)
                {
                    this._QuestName = value;
                }
            }
        }
    }
}


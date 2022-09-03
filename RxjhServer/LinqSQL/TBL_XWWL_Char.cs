namespace LinqSQL
{
    using System;
    using System.ComponentModel;
    using System.Data.Linq;
    using System.Data.Linq.Mapping;
    using System.Threading;

    [Table(Name="dbo.TBL_XWWL_Char")]
    public class TBL_XWWL_Char : INotifyPropertyChanging, INotifyPropertyChanged
    {
        private int _FLD_ADD_AT;
        private int _FLD_ADD_DF;
        private int _FLD_ADD_HB;
        private int _FLD_ADD_HP;
        private int _FLD_ADD_MP;
        private int _FLD_ADD_MZ;
        private Binary _FLD_CTIME;
        private Binary _FLD_CTIMENEW;
        private Binary _FLD_DOORS;
        private string _FLD_EXP;
        private Binary _FLD_FACE;
        private int? _FLD_FIGHT_EXP;
        private int _FLD_GETWX;
        private int? _FLD_GM;
        private int? _FLD_GM_Main;
        private Binary _FLD_HITS;
        private int? _FLD_HP;
        private string _FLD_ID;
        private int _FLD_INDEX;
        private Binary _FLD_ITEM;
        private string _FLD_JL;
        private int _FLD_JOB;
        private int? _FLD_JOB_LEVEL;
        private int? _FLD_JQ;
        private Binary _FLD_KONGFU;
        private Binary _FLD_KONGFU_Sian;
        private int? _FLD_LEVEL;
        private int? _FLD_LUMPID;
        private int? _FLD_MENOW;
        private string _FLD_MONEY;
        private int? _FLD_MP;
        private string _FLD_NAME;
        private Binary _FLD_NAMETYPE;
        private int? _FLD_POINT;
        private Binary _FLD_QITEM;
        private int? _FLD_QlDu;
        private string _FLD_QlNAME;
        private Binary _FLD_QUEST;
        private int? _FLD_SE;
        private Binary _FLD_SKILLS;
        private Binary _FLD_SKILLS_Sian;
        private int? _FLD_SP;
        private Binary _FLD_WEARITEM;
        private int? _FLD_WX;
        private double? _FLD_X;
        private double? _FLD_Y;
        private double? _FLD_Z;
        private int? _FLD_ZBVER;
        private int _FLD_ZS;
        private int? _FLD_ZX;
        private int? _FLD_ZzSl;
        private int? _FLD_ZzType;
        private int? _FLD_升天历练;
        private int? _FLD_升天武功点;
        private int _ID;
        private Binary _在线时间;
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

        [Column(Storage="_FLD_ADD_AT", DbType="Int NOT NULL")]
        public int FLD_ADD_AT
        {
            get
            {
                return this._FLD_ADD_AT;
            }
            set
            {
                if (this._FLD_ADD_AT != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_ADD_AT = value;
                    this.SendPropertyChanged("FLD_ADD_AT");
                }
            }
        }

        [Column(Storage="_FLD_ADD_DF", DbType="Int NOT NULL")]
        public int FLD_ADD_DF
        {
            get
            {
                return this._FLD_ADD_DF;
            }
            set
            {
                if (this._FLD_ADD_DF != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_ADD_DF = value;
                    this.SendPropertyChanged("FLD_ADD_DF");
                }
            }
        }

        [Column(Storage="_FLD_ADD_HB", DbType="Int NOT NULL")]
        public int FLD_ADD_HB
        {
            get
            {
                return this._FLD_ADD_HB;
            }
            set
            {
                if (this._FLD_ADD_HB != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_ADD_HB = value;
                    this.SendPropertyChanged("FLD_ADD_HB");
                }
            }
        }

        [Column(Storage="_FLD_ADD_HP", DbType="Int NOT NULL")]
        public int FLD_ADD_HP
        {
            get
            {
                return this._FLD_ADD_HP;
            }
            set
            {
                if (this._FLD_ADD_HP != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_ADD_HP = value;
                    this.SendPropertyChanged("FLD_ADD_HP");
                }
            }
        }

        [Column(Storage="_FLD_ADD_MP", DbType="Int NOT NULL")]
        public int FLD_ADD_MP
        {
            get
            {
                return this._FLD_ADD_MP;
            }
            set
            {
                if (this._FLD_ADD_MP != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_ADD_MP = value;
                    this.SendPropertyChanged("FLD_ADD_MP");
                }
            }
        }

        [Column(Storage="_FLD_ADD_MZ", DbType="Int NOT NULL")]
        public int FLD_ADD_MZ
        {
            get
            {
                return this._FLD_ADD_MZ;
            }
            set
            {
                if (this._FLD_ADD_MZ != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_ADD_MZ = value;
                    this.SendPropertyChanged("FLD_ADD_MZ");
                }
            }
        }

        [Column(Storage="_FLD_CTIME", DbType="VarBinary(160)", UpdateCheck=UpdateCheck.Never)]
        public Binary FLD_CTIME
        {
            get
            {
                return this._FLD_CTIME;
            }
            set
            {
                if (this._FLD_CTIME != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_CTIME = value;
                    this.SendPropertyChanged("FLD_CTIME");
                }
            }
        }

        [Column(Storage="_FLD_CTIMENEW", DbType="VarBinary(240)", UpdateCheck=UpdateCheck.Never)]
        public Binary FLD_CTIMENEW
        {
            get
            {
                return this._FLD_CTIMENEW;
            }
            set
            {
                if (this._FLD_CTIMENEW != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_CTIMENEW = value;
                    this.SendPropertyChanged("FLD_CTIMENEW");
                }
            }
        }

        [Column(Storage="_FLD_DOORS", DbType="VarBinary(1200)", UpdateCheck=UpdateCheck.Never)]
        public Binary FLD_DOORS
        {
            get
            {
                return this._FLD_DOORS;
            }
            set
            {
                if (this._FLD_DOORS != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_DOORS = value;
                    this.SendPropertyChanged("FLD_DOORS");
                }
            }
        }

        [Column(Storage="_FLD_EXP", DbType="VarChar(50)")]
        public string FLD_EXP
        {
            get
            {
                return this._FLD_EXP;
            }
            set
            {
                if (this._FLD_EXP != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_EXP = value;
                    this.SendPropertyChanged("FLD_EXP");
                }
            }
        }

        [Column(Storage="_FLD_FACE", DbType="VarBinary(10) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
        public Binary FLD_FACE
        {
            get
            {
                return this._FLD_FACE;
            }
            set
            {
                if (this._FLD_FACE != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_FACE = value;
                    this.SendPropertyChanged("FLD_FACE");
                }
            }
        }

        [Column(Storage="_FLD_FIGHT_EXP", DbType="Int")]
        public int? FLD_FIGHT_EXP
        {
            get
            {
                return this._FLD_FIGHT_EXP;
            }
            set
            {
                if (this._FLD_FIGHT_EXP != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_FIGHT_EXP = value;
                    this.SendPropertyChanged("FLD_FIGHT_EXP");
                }
            }
        }

        [Column(Storage="_FLD_GETWX", DbType="Int NOT NULL")]
        public int FLD_GETWX
        {
            get
            {
                return this._FLD_GETWX;
            }
            set
            {
                if (this._FLD_GETWX != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_GETWX = value;
                    this.SendPropertyChanged("FLD_GETWX");
                }
            }
        }

        [Column(Storage="_FLD_GM", DbType="Int")]
        public int? FLD_GM
        {
            get
            {
                return this._FLD_GM;
            }
            set
            {
                if (this._FLD_GM != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_GM = value;
                    this.SendPropertyChanged("FLD_GM");
                }
            }
        }

        [Column(Storage="_FLD_GM_Main", DbType="Int")]
        public int? FLD_GM_Main
        {
            get
            {
                return this._FLD_GM_Main;
            }
            set
            {
                if (this._FLD_GM_Main != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_GM_Main = value;
                    this.SendPropertyChanged("FLD_GM_Main");
                }
            }
        }

        [Column(Storage="_FLD_HITS", DbType="VarBinary(250)", UpdateCheck=UpdateCheck.Never)]
        public Binary FLD_HITS
        {
            get
            {
                return this._FLD_HITS;
            }
            set
            {
                if (this._FLD_HITS != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_HITS = value;
                    this.SendPropertyChanged("FLD_HITS");
                }
            }
        }

        [Column(Storage="_FLD_HP", DbType="Int")]
        public int? FLD_HP
        {
            get
            {
                return this._FLD_HP;
            }
            set
            {
                if (this._FLD_HP != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_HP = value;
                    this.SendPropertyChanged("FLD_HP");
                }
            }
        }

        [Column(Storage="_FLD_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
        public string FLD_ID
        {
            get
            {
                return this._FLD_ID;
            }
            set
            {
                if (this._FLD_ID != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_ID = value;
                    this.SendPropertyChanged("FLD_ID");
                }
            }
        }

        [Column(Storage="_FLD_INDEX", DbType="Int NOT NULL")]
        public int FLD_INDEX
        {
            get
            {
                return this._FLD_INDEX;
            }
            set
            {
                if (this._FLD_INDEX != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_INDEX = value;
                    this.SendPropertyChanged("FLD_INDEX");
                }
            }
        }


        // ??????????????????????????????? 4818 or 5016 => (World.Newversion >= 14 ? 76 : 73) * 66
        [Column(Storage="_FLD_ITEM", DbType="VarBinary(4818)", UpdateCheck=UpdateCheck.Never)]
        public Binary FLD_ITEM
        {
            get
            {
                return this._FLD_ITEM;
            }
            set
            {
                if (this._FLD_ITEM != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_ITEM = value;
                    this.SendPropertyChanged("FLD_ITEM");
                }
            }
        }

        [Column(Storage="_FLD_JL", DbType="VarChar(50)")]
        public string FLD_JL
        {
            get
            {
                return this._FLD_JL;
            }
            set
            {
                if (this._FLD_JL != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_JL = value;
                    this.SendPropertyChanged("FLD_JL");
                }
            }
        }

        [Column(Storage="_FLD_JOB", DbType="Int NOT NULL")]
        public int FLD_JOB
        {
            get
            {
                return this._FLD_JOB;
            }
            set
            {
                if (this._FLD_JOB != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_JOB = value;
                    this.SendPropertyChanged("FLD_JOB");
                }
            }
        }

        [Column(Storage="_FLD_JOB_LEVEL", DbType="Int")]
        public int? FLD_JOB_LEVEL
        {
            get
            {
                return this._FLD_JOB_LEVEL;
            }
            set
            {
                if (this._FLD_JOB_LEVEL != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_JOB_LEVEL = value;
                    this.SendPropertyChanged("FLD_JOB_LEVEL");
                }
            }
        }

        [Column(Storage="_FLD_JQ", DbType="Int")]
        public int? FLD_JQ
        {
            get
            {
                return this._FLD_JQ;
            }
            set
            {
                if (this._FLD_JQ != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_JQ = value;
                    this.SendPropertyChanged("FLD_JQ");
                }
            }
        }

        [Column(Storage="_FLD_KONGFU", DbType="VarBinary(312)", UpdateCheck=UpdateCheck.Never)]
        public Binary FLD_KONGFU
        {
            get
            {
                return this._FLD_KONGFU;
            }
            set
            {
                if (this._FLD_KONGFU != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_KONGFU = value;
                    this.SendPropertyChanged("FLD_KONGFU");
                }
            }
        }

        [Column(Storage="_FLD_KONGFU_Sian", DbType="VarBinary(144)", UpdateCheck=UpdateCheck.Never)]
        public Binary FLD_KONGFU_Sian
        {
            get
            {
                return this._FLD_KONGFU_Sian;
            }
            set
            {
                if (this._FLD_KONGFU_Sian != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_KONGFU_Sian = value;
                    this.SendPropertyChanged("FLD_KONGFU_Sian");
                }
            }
        }

        [Column(Storage="_FLD_LEVEL", DbType="Int")]
        public int? FLD_LEVEL
        {
            get
            {
                return this._FLD_LEVEL;
            }
            set
            {
                if (this._FLD_LEVEL != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_LEVEL = value;
                    this.SendPropertyChanged("FLD_LEVEL");
                }
            }
        }

        [Column(Storage="_FLD_LUMPID", DbType="Int")]
        public int? FLD_LUMPID
        {
            get
            {
                return this._FLD_LUMPID;
            }
            set
            {
                if (this._FLD_LUMPID != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_LUMPID = value;
                    this.SendPropertyChanged("FLD_LUMPID");
                }
            }
        }

        [Column(Storage="_FLD_MENOW", DbType="Int")]
        public int? FLD_MENOW
        {
            get
            {
                return this._FLD_MENOW;
            }
            set
            {
                if (this._FLD_MENOW != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_MENOW = value;
                    this.SendPropertyChanged("FLD_MENOW");
                }
            }
        }

        [Column(Storage="_FLD_MONEY", DbType="VarChar(50)")]
        public string FLD_MONEY
        {
            get
            {
                return this._FLD_MONEY;
            }
            set
            {
                if (this._FLD_MONEY != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_MONEY = value;
                    this.SendPropertyChanged("FLD_MONEY");
                }
            }
        }

        [Column(Storage="_FLD_MP", DbType="Int")]
        public int? FLD_MP
        {
            get
            {
                return this._FLD_MP;
            }
            set
            {
                if (this._FLD_MP != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_MP = value;
                    this.SendPropertyChanged("FLD_MP");
                }
            }
        }

        [Column(Storage="_FLD_NAME", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
        public string FLD_NAME
        {
            get
            {
                return this._FLD_NAME;
            }
            set
            {
                if (this._FLD_NAME != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_NAME = value;
                    this.SendPropertyChanged("FLD_NAME");
                }
            }
        }

        [Column(Storage="_FLD_NAMETYPE", DbType="VarBinary(48)", UpdateCheck=UpdateCheck.Never)]
        public Binary FLD_NAMETYPE
        {
            get
            {
                return this._FLD_NAMETYPE;
            }
            set
            {
                if (this._FLD_NAMETYPE != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_NAMETYPE = value;
                    this.SendPropertyChanged("FLD_NAMETYPE");
                }
            }
        }

        [Column(Storage="_FLD_POINT", DbType="Int")]
        public int? FLD_POINT
        {
            get
            {
                return this._FLD_POINT;
            }
            set
            {
                if (this._FLD_POINT != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_POINT = value;
                    this.SendPropertyChanged("FLD_POINT");
                }
            }
        }

        [Column(Storage="_FLD_QITEM", DbType="VarBinary(300)", UpdateCheck=UpdateCheck.Never)]
        public Binary FLD_QITEM
        {
            get
            {
                return this._FLD_QITEM;
            }
            set
            {
                if (this._FLD_QITEM != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_QITEM = value;
                    this.SendPropertyChanged("FLD_QITEM");
                }
            }
        }

        [Column(Storage="_FLD_QlDu", DbType="Int")]
        public int? FLD_QlDu
        {
            get
            {
                return this._FLD_QlDu;
            }
            set
            {
                if (this._FLD_QlDu != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_QlDu = value;
                    this.SendPropertyChanged("FLD_QlDu");
                }
            }
        }

        [Column(Storage="_FLD_QlNAME", DbType="NVarChar(50)")]
        public string FLD_QlNAME
        {
            get
            {
                return this._FLD_QlNAME;
            }
            set
            {
                if (this._FLD_QlNAME != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_QlNAME = value;
                    this.SendPropertyChanged("FLD_QlNAME");
                }
            }
        }

        [Column(Storage="_FLD_QUEST", DbType="VarBinary(400)", UpdateCheck=UpdateCheck.Never)]
        public Binary FLD_QUEST
        {
            get
            {
                return this._FLD_QUEST;
            }
            set
            {
                if (this._FLD_QUEST != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_QUEST = value;
                    this.SendPropertyChanged("FLD_QUEST");
                }
            }
        }

        [Column(Storage="_FLD_SE", DbType="Int")]
        public int? FLD_SE
        {
            get
            {
                return this._FLD_SE;
            }
            set
            {
                if (this._FLD_SE != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_SE = value;
                    this.SendPropertyChanged("FLD_SE");
                }
            }
        }

        [Column(Storage="_FLD_SKILLS", DbType="VarBinary(100)", UpdateCheck=UpdateCheck.Never)]
        public Binary FLD_SKILLS
        {
            get
            {
                return this._FLD_SKILLS;
            }
            set
            {
                if (this._FLD_SKILLS != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_SKILLS = value;
                    this.SendPropertyChanged("FLD_SKILLS");
                }
            }
        }

        [Column(Storage="_FLD_SKILLS_Sian", DbType="VarBinary(60)", UpdateCheck=UpdateCheck.Never)]
        public Binary FLD_SKILLS_Sian
        {
            get
            {
                return this._FLD_SKILLS_Sian;
            }
            set
            {
                if (this._FLD_SKILLS_Sian != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_SKILLS_Sian = value;
                    this.SendPropertyChanged("FLD_SKILLS_Sian");
                }
            }
        }

        [Column(Storage="_FLD_SP", DbType="Int")]
        public int? FLD_SP
        {
            get
            {
                return this._FLD_SP;
            }
            set
            {
                if (this._FLD_SP != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_SP = value;
                    this.SendPropertyChanged("FLD_SP");
                }
            }
        }

        [Column(Storage="_FLD_WEARITEM", DbType="VarBinary(1095)", UpdateCheck=UpdateCheck.Never)]
        public Binary FLD_WEARITEM
        {
            get
            {
                return this._FLD_WEARITEM;
            }
            set
            {
                if (this._FLD_WEARITEM != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_WEARITEM = value;
                    this.SendPropertyChanged("FLD_WEARITEM");
                }
            }
        }

        [Column(Storage="_FLD_WX", DbType="Int")]
        public int? FLD_WX
        {
            get
            {
                return this._FLD_WX;
            }
            set
            {
                if (this._FLD_WX != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_WX = value;
                    this.SendPropertyChanged("FLD_WX");
                }
            }
        }

        [Column(Storage="_FLD_X", DbType="Float")]
        public double? FLD_X
        {
            get
            {
                return this._FLD_X;
            }
            set
            {
                if (this._FLD_X != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_X = value;
                    this.SendPropertyChanged("FLD_X");
                }
            }
        }

        [Column(Storage="_FLD_Y", DbType="Float")]
        public double? FLD_Y
        {
            get
            {
                return this._FLD_Y;
            }
            set
            {
                if (this._FLD_Y != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_Y = value;
                    this.SendPropertyChanged("FLD_Y");
                }
            }
        }

        [Column(Storage="_FLD_Z", DbType="Float")]
        public double? FLD_Z
        {
            get
            {
                return this._FLD_Z;
            }
            set
            {
                if (this._FLD_Z != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_Z = value;
                    this.SendPropertyChanged("FLD_Z");
                }
            }
        }

        [Column(Storage="_FLD_ZBVER", DbType="Int")]
        public int? FLD_ZBVER
        {
            get
            {
                return this._FLD_ZBVER;
            }
            set
            {
                if (this._FLD_ZBVER != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_ZBVER = value;
                    this.SendPropertyChanged("FLD_ZBVER");
                }
            }
        }

        [Column(Storage="_FLD_ZS", DbType="Int NOT NULL")]
        public int FLD_ZS
        {
            get
            {
                return this._FLD_ZS;
            }
            set
            {
                if (this._FLD_ZS != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_ZS = value;
                    this.SendPropertyChanged("FLD_ZS");
                }
            }
        }

        [Column(Storage="_FLD_ZX", DbType="Int")]
        public int? FLD_ZX
        {
            get
            {
                return this._FLD_ZX;
            }
            set
            {
                if (this._FLD_ZX != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_ZX = value;
                    this.SendPropertyChanged("FLD_ZX");
                }
            }
        }

        [Column(Storage="_FLD_ZzSl", DbType="Int")]
        public int? FLD_ZzSl
        {
            get
            {
                return this._FLD_ZzSl;
            }
            set
            {
                if (this._FLD_ZzSl != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_ZzSl = value;
                    this.SendPropertyChanged("FLD_ZzSl");
                }
            }
        }

        [Column(Storage="_FLD_ZzType", DbType="Int")]
        public int? FLD_ZzType
        {
            get
            {
                return this._FLD_ZzType;
            }
            set
            {
                if (this._FLD_ZzType != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_ZzType = value;
                    this.SendPropertyChanged("FLD_ZzType");
                }
            }
        }

        [Column(Storage="_FLD_升天历练", DbType="Int")]
        public int? FLD_升天历练
        {
            get
            {
                return this._FLD_升天历练;
            }
            set
            {
                if (this._FLD_升天历练 != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_升天历练 = value;
                    this.SendPropertyChanged("FLD_升天历练");
                }
            }
        }

        [Column(Storage="_FLD_升天武功点", DbType="Int")]
        public int? FLD_升天武功点
        {
            get
            {
                return this._FLD_升天武功点;
            }
            set
            {
                if (this._FLD_升天武功点 != value)
                {
                    this.SendPropertyChanging();
                    this._FLD_升天武功点 = value;
                    this.SendPropertyChanged("FLD_升天武功点");
                }
            }
        }

        [Column(Storage="_ID", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                if (this._ID != value)
                {
                    this.SendPropertyChanging();
                    this._ID = value;
                    this.SendPropertyChanged("ID");
                }
            }
        }

        [Column(Storage="_在线时间", DbType="VarBinary(200) NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
        public Binary 在线时间
        {
            get
            {
                return this._在线时间;
            }
            set
            {
                if (this._在线时间 != value)
                {
                    this.SendPropertyChanging();
                    this._在线时间 = value;
                    this.SendPropertyChanged("在线时间");
                }
            }
        }
    }
}


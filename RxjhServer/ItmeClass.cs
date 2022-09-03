using RxjhServer.RxjhServer;

namespace RxjhServer
{
	public class ItmeClass
	{
		private int _FLD_QUESTITEM;

		private int _FLD_CJL;

		private int _FLD_PID;

		private int _FLD_PIDQ;

		private int _FLD_RESIDE1;

		private int _FLD_RESIDE2;

		private int _FLD_SEX;

		private long _FLD_DF;

		private int _FLD_SHIELD;

		private int _FLD_LEVEL;

		private int _FLD_JOB_LEVEL;

		private int _FLD_ZX;

		private long _FLD_AT;

		private long _FLD_AT_Max;

		private int _FLD_MONEY;

		private int _FLD_SIDE;

		private int _FLD_TYPE;

		private int _FLD_WEIGHT;

		private int _FLD_MAGIC0;

		private int _FLD_MAGIC1;

		private int _FLD_MAGIC2;

		private int _FLD_MAGIC3;

		private int _FLD_MAGIC4;

		private int _FLD_XW;

		private int _FLD_XWJD;

		private string _ItmeNAME;

		private int _ThongBao;

		public long FLD_AT
		{
			get
			{
				return _FLD_AT;
			}
			set
			{
				_FLD_AT = value;
			}
		}

		public long FLD_AT_Max
		{
			get
			{
				return _FLD_AT_Max;
			}
			set
			{
				_FLD_AT_Max = value;
			}
		}

		public int FLD_CJL
		{
			get
			{
				return _FLD_CJL;
			}
			set
			{
				_FLD_CJL = value;
			}
		}

		public long FLD_DF
		{
			get
			{
				return _FLD_DF;
			}
			set
			{
				_FLD_DF = value;
			}
		}

		public int FLD_SHIELD
		{
			get
			{
				return _FLD_SHIELD;
			}
			set
			{
				_FLD_SHIELD = value;
			}
		}

		public int FLD_JOB_LEVEL
		{
			get
			{
				return _FLD_JOB_LEVEL;
			}
			set
			{
				_FLD_JOB_LEVEL = value;
			}
		}

		public int FLD_LEVEL
		{
			get
			{
				return _FLD_LEVEL;
			}
			set
			{
				_FLD_LEVEL = value;
			}
		}

		public int FLD_MAGIC0
		{
			get
			{
				return _FLD_MAGIC0;
			}
			set
			{
				_FLD_MAGIC0 = value;
			}
		}

		public int FLD_MAGIC1
		{
			get
			{
				return _FLD_MAGIC1;
			}
			set
			{
				_FLD_MAGIC1 = value;
			}
		}

		public int FLD_MAGIC2
		{
			get
			{
				return _FLD_MAGIC2;
			}
			set
			{
				_FLD_MAGIC2 = value;
			}
		}

		public int FLD_MAGIC3
		{
			get
			{
				return _FLD_MAGIC3;
			}
			set
			{
				_FLD_MAGIC3 = value;
			}
		}

		public int FLD_MAGIC4
		{
			get
			{
				return _FLD_MAGIC4;
			}
			set
			{
				_FLD_MAGIC4 = value;
			}
		}

		public int FLD_MONEY
		{
			get
			{
				return _FLD_MONEY;
			}
			set
			{
				_FLD_MONEY = value;
			}
		}

		public int FLD_PID
		{
			get
			{
				return _FLD_PID;
			}
			set
			{
				_FLD_PID = value;
			}
		}

		public int FLD_PIDQ
		{
			get
			{
				return _FLD_PIDQ;
			}
			set
			{
				_FLD_PIDQ = value;
			}
		}

		public int FLD_QUESTITEM
		{
			get
			{
				return _FLD_QUESTITEM;
			}
			set
			{
				_FLD_QUESTITEM = value;
			}
		}

		public int FLD_RESIDE1
		{
			get
			{
				return _FLD_RESIDE1;
			}
			set
			{
				_FLD_RESIDE1 = value;
			}
		}

		public int FLD_RESIDE2
		{
			get
			{
				return _FLD_RESIDE2;
			}
			set
			{
				_FLD_RESIDE2 = value;
			}
		}

		public int FLD_SEX
		{
			get
			{
				return _FLD_SEX;
			}
			set
			{
				_FLD_SEX = value;
			}
		}

		public int FLD_SIDE
		{
			get
			{
				return _FLD_SIDE;
			}
			set
			{
				_FLD_SIDE = value;
			}
		}

		public int FLD_TYPE
		{
			get
			{
				return _FLD_TYPE;
			}
			set
			{
				_FLD_TYPE = value;
			}
		}

		public int FLD_WEIGHT
		{
			get
			{
				return _FLD_WEIGHT;
			}
			set
			{
				_FLD_WEIGHT = value;
			}
		}

		public int FLD_XW
		{
			get
			{
				return _FLD_XW;
			}
			set
			{
				_FLD_XW = value;
			}
		}

		public int FLD_XWJD
		{
			get
			{
				return _FLD_XWJD;
			}
			set
			{
				_FLD_XWJD = value;
			}
		}

		public int FLD_ZX
		{
			get
			{
				return _FLD_ZX;
			}
			set
			{
				_FLD_ZX = value;
			}
		}

		public string ItmeNAME
		{
			get
			{
				return _ItmeNAME;
			}
			set
			{
				_ItmeNAME = value;
			}
		}

		public int FLD_THONGBAO
		{
			get
			{
				return _ThongBao;
			}
			set
			{
				_ThongBao = value;
			}
		}

		public static ItmeClass GetItme(string name)
		{
			foreach (ItmeClass value in World.Itme.Values)
			{
				if (value.ItmeNAME == name)
				{
					return value;
				}
			}
			return null;
		}

		public static ItmeClass GetItmeBool(int zx, int level, int job, int sex, int type)
		{
			foreach (ItmeClass value in World.Itme.Values)
			{
				if (value.FLD_ZX == zx && value.FLD_LEVEL == level && value.FLD_RESIDE1 == job && value.FLD_SEX == sex && value.FLD_RESIDE2 == type)
				{
					return value;
				}
			}
			return null;
		}

		public static ItmeClass GetItmeID(int id)
		{
			if (World.Itme.TryGetValue(id, out ItmeClass value))
			{
				return value;
			}
			return null;
		}

		public static ItmeClass _GetItmeID(int id)
		{
			if (World.Itme.TryGetValue(id, out ItmeClass value))
			{
				return value;
			}
			return null;
		}

		public static string 得到物品名称(int id)
		{
			if (World.Itme.TryGetValue(id, out ItmeClass value))
			{
				return value.ItmeNAME;
			}
			return "";
		}

		public int getOffsetItemChan()
		{
			switch (FLD_RESIDE1)
			{
			case 1:
				return 1;
			case 2:
				return 2;
			case 3:
				return 3;
			case 4:
				return 4;
			case 5:
				return 5;
			case 6:
				return 7;
			case 7:
				return 8;
			case 8:
				return -1;
			case 9:
				return -2;
			case 10:
				return 9;
			case 11:
				return -4;
			case 12:
				return -3;
			default:
				return 0;
			}
		}

		public bool isVKChan()
		{
			int offsetItemChan = getOffsetItemChan();
			if (offsetItemChan > 0)
			{
				if (FLD_PID == offsetItemChan * 100000000 + 201251 || FLD_PID == offsetItemChan * 100000000 + 201254 || FLD_PID == offsetItemChan * 100000000 + 201262 || FLD_PID == offsetItemChan * 100000000 + 202261 || FLD_PID == offsetItemChan * 100000000 + 202264 || FLD_PID == offsetItemChan * 100000000 + 201272 || FLD_PID == offsetItemChan * 100000000 + 200321 || FLD_PID == offsetItemChan * 100000000 + 200323 || FLD_PID == offsetItemChan * 100000000 + 200326)
				{
					return true;
				}
			}
			else if (offsetItemChan < 0)
			{
				offsetItemChan *= -1;
				if (FLD_PID == offsetItemChan * 100000000 + 204010 || FLD_PID == offsetItemChan * 100000000 + 204022 || FLD_PID == offsetItemChan * 100000000 + 204025 || FLD_PID == offsetItemChan * 100000000 + 204027 || FLD_PID == offsetItemChan * 100000000 + 204032 || FLD_PID == offsetItemChan * 100000000 + 204034 || FLD_PID == offsetItemChan * 100000000 + 200361 || FLD_PID == offsetItemChan * 100000000 + 200363 || FLD_PID == offsetItemChan * 100000000 + 200366)
				{
					return true;
				}
			}
			return false;
		}

		public bool isAoChan()
		{
			int offsetItemChan = getOffsetItemChan();
			if (offsetItemChan > 0)
			{
				if (FLD_PID == offsetItemChan * 100000000 + 10301015 || FLD_PID == offsetItemChan * 100000000 + 10301020 || FLD_PID == offsetItemChan * 100000000 + 10301023 || FLD_PID == offsetItemChan * 100000000 + 10302015 || FLD_PID == offsetItemChan * 100000000 + 10302020 || FLD_PID == offsetItemChan * 100000000 + 10302023 || FLD_PID == offsetItemChan * 100000000 + 20301015 || FLD_PID == offsetItemChan * 100000000 + 20301020 || FLD_PID == offsetItemChan * 100000000 + 20301023 || FLD_PID == offsetItemChan * 100000000 + 20302015 || FLD_PID == offsetItemChan * 100000000 + 20302020 || FLD_PID == offsetItemChan * 100000000 + 20302023 || FLD_PID == offsetItemChan * 100000000 + 303032 || FLD_PID == offsetItemChan * 100000000 + 303034 || FLD_PID == offsetItemChan * 100000000 + 303036)
				{
					return true;
				}
			}
			else if (offsetItemChan < 0)
			{
				offsetItemChan *= -1;
				if (FLD_PID == offsetItemChan * 100000000 + 10304015 || FLD_PID == offsetItemChan * 100000000 + 10304020 || FLD_PID == offsetItemChan * 100000000 + 10304023 || FLD_PID == offsetItemChan * 100000000 + 20304015 || FLD_PID == offsetItemChan * 100000000 + 20304020 || FLD_PID == offsetItemChan * 100000000 + 20304023 || FLD_PID == offsetItemChan * 100000000 + 303072 || FLD_PID == offsetItemChan * 100000000 + 303074 || FLD_PID == offsetItemChan * 100000000 + 303076)
				{
					return true;
				}
			}
			return false;
		}

		public bool isTayChan()
		{
			if (FLD_PID == 501016 || FLD_PID == 501018 || FLD_PID == 501020 || FLD_PID == 501916 || FLD_PID == 502016 || FLD_PID == 502018 || FLD_PID == 502020 || FLD_PID == 502916 || FLD_PID == 506016 || FLD_PID == 506018 || FLD_PID == 507016 || FLD_PID == 507018)
			{
				return true;
			}
			if (FLD_PID == 500116 || FLD_PID == 500118 || FLD_PID == 500120 || FLD_PID == 502116 || FLD_PID == 502118 || FLD_PID == 502120 || FLD_PID == 506016 || FLD_PID == 506018 || FLD_PID == 507016 || FLD_PID == 507018)
			{
				return true;
			}
			int offsetItemChan = getOffsetItemChan();
			if (offsetItemChan > 0)
			{
				if (FLD_PID == offsetItemChan * 100000000 + 503032 || FLD_PID == offsetItemChan * 100000000 + 503034)
				{
					return true;
				}
			}
			else if (offsetItemChan < 0)
			{
				offsetItemChan *= -1;
				if (FLD_PID == offsetItemChan * 100000000 + 503072 || FLD_PID == offsetItemChan * 100000000 + 503074)
				{
					return true;
				}
			}
			return false;
		}

		public bool isChanChan()
		{
			if (FLD_PID == 801017 || FLD_PID == 801019 || FLD_PID == 801021 || FLD_PID == 801917 || FLD_PID == 802017 || FLD_PID == 802019 || FLD_PID == 802021 || FLD_PID == 802917 || FLD_PID == 806017 || FLD_PID == 806019 || FLD_PID == 807017 || FLD_PID == 807019)
			{
				return true;
			}
			if (FLD_PID == 800117 || FLD_PID == 800119 || FLD_PID == 800121 || FLD_PID == 802117 || FLD_PID == 802119 || FLD_PID == 802121 || FLD_PID == 806017 || FLD_PID == 806019 || FLD_PID == 807017 || FLD_PID == 807019)
			{
				return true;
			}
			int offsetItemChan = getOffsetItemChan();
			if (offsetItemChan > 0)
			{
				if (FLD_PID == offsetItemChan * 100000000 + 803032 || FLD_PID == offsetItemChan * 100000000 + 803034 || FLD_PID == offsetItemChan * 100000000 + 803036)
				{
					return true;
				}
			}
			else if (offsetItemChan < 0)
			{
				offsetItemChan *= -1;
				if (FLD_PID == offsetItemChan * 100000000 + 803072 || FLD_PID == offsetItemChan * 100000000 + 803074 || FLD_PID == offsetItemChan * 100000000 + 803076)
				{
					return true;
				}
			}
			return false;
		}

		public bool isGiapChan()
		{
			if (FLD_PID == 501016 || FLD_PID == 501018 || FLD_PID == 501020 || FLD_PID == 501916 || FLD_PID == 502016 || FLD_PID == 502018 || FLD_PID == 502020 || FLD_PID == 502916 || FLD_PID == 506016 || FLD_PID == 506018 || FLD_PID == 507016 || FLD_PID == 507018)
			{
				return true;
			}
			if (FLD_PID == 500116 || FLD_PID == 500118 || FLD_PID == 500120 || FLD_PID == 502116 || FLD_PID == 502118 || FLD_PID == 502120 || FLD_PID == 506016 || FLD_PID == 506018 || FLD_PID == 507016 || FLD_PID == 507018)
			{
				return true;
			}
			int offsetItemChan = getOffsetItemChan();
			if (offsetItemChan > 0)
			{
				if (FLD_PID == offsetItemChan * 100000000 + 403033 || FLD_PID == offsetItemChan * 100000000 + 403035 || FLD_PID == offsetItemChan * 100000000 + 403037)
				{
					return true;
				}
			}
			else if (offsetItemChan < 0)
			{
				offsetItemChan *= -1;
				if (FLD_PID == offsetItemChan * 100000000 + 403073 || FLD_PID == offsetItemChan * 100000000 + 403075 || FLD_PID == offsetItemChan * 100000000 + 403077)
				{
					return true;
				}
			}
			return false;
		}
	}
}

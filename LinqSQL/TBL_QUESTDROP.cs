using System.Data.Linq.Mapping;

namespace LinqSQL
{
	[Table(Name = "dbo.TBL_QUESTDROP")]
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

		private int _QuestLevel;

		private string _QuestName;

		[Column(Storage = "_DropRatePercent", DbType = "Int NOT NULL")]
		public int DropRatePercent
		{
			get
			{
				return _DropRatePercent;
			}
			set
			{
				if (_DropRatePercent != value)
				{
					_DropRatePercent = value;
				}
			}
		}

		[Column(Storage = "_id", AutoSync = AutoSync.Always, DbType = "Int NOT NULL IDENTITY", IsDbGenerated = true)]
		public int id
		{
			get
			{
				return _id;
			}
			set
			{
				if (_id != value)
				{
					_id = value;
				}
			}
		}

		[Column(Storage = "_MonsterID", DbType = "Int NOT NULL")]
		public int MonsterID
		{
			get
			{
				return _MonsterID;
			}
			set
			{
				if (_MonsterID != value)
				{
					_MonsterID = value;
				}
			}
		}

		[Column(Storage = "_MonsterID2", DbType = "Int NOT NULL")]
		public int MonsterID2
		{
			get
			{
				return _MonsterID2;
			}
			set
			{
				if (_MonsterID2 != value)
				{
					_MonsterID2 = value;
				}
			}
		}

		[Column(Storage = "_QuestDropID", DbType = "Int NOT NULL")]
		public int QuestDropID
		{
			get
			{
				return _QuestDropID;
			}
			set
			{
				if (_QuestDropID != value)
				{
					_QuestDropID = value;
				}
			}
		}

		[Column(Storage = "_QuestDropID2", DbType = "Int NOT NULL")]
		public int QuestDropID2
		{
			get
			{
				return _QuestDropID2;
			}
			set
			{
				if (_QuestDropID2 != value)
				{
					_QuestDropID2 = value;
				}
			}
		}

		[Column(Storage = "_QuestID", DbType = "Int NOT NULL")]
		public int QuestID
		{
			get
			{
				return _QuestID;
			}
			set
			{
				if (_QuestID != value)
				{
					_QuestID = value;
				}
			}
		}

		[Column(Storage = "_QuestItemMax", DbType = "Int NOT NULL")]
		public int QuestItemMax
		{
			get
			{
				return _QuestItemMax;
			}
			set
			{
				if (_QuestItemMax != value)
				{
					_QuestItemMax = value;
				}
			}
		}

		[Column(Storage = "_QuestItemMax2", DbType = "Int NOT NULL")]
		public int QuestItemMax2
		{
			get
			{
				return _QuestItemMax2;
			}
			set
			{
				if (_QuestItemMax2 != value)
				{
					_QuestItemMax2 = value;
				}
			}
		}

		[Column(Storage = "_QuestLevel", DbType = "Int NOT NULL")]
		public int QuestLevel
		{
			get
			{
				return _QuestLevel;
			}
			set
			{
				if (_QuestLevel != value)
				{
					_QuestLevel = value;
				}
			}
		}

		[Column(Storage = "_QuestName", DbType = "VarChar(MAX) NOT NULL", CanBeNull = false)]
		public string QuestName
		{
			get
			{
				return _QuestName;
			}
			set
			{
				if (_QuestName != value)
				{
					_QuestName = value;
				}
			}
		}
	}
}

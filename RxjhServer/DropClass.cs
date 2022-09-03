using RxjhServer.RxjhServer;
using System;
using System.Collections.Generic;

namespace RxjhServer
{
	public class DropClass
	{
		public List<DropShuXClass> DropShuX = new List<DropShuXClass>();

		private int _FLD_LEVEL1;

		private int _FLD_LEVEL2;

		private int _FLD_PID;

		private int _FLD_PP;

		private int _FLD_MAGIC0;

		private int _FLD_MAGIC1;

		private int _FLD_MAGIC2;

		private int _FLD_MAGIC3;

		private int _FLD_MAGIC4;

		private string _FLD_NAME;

		public int FLD_MAGICNew0;

		public int FLD_MAGICNew1;

		public int FLD_MAGICNew2;

		public int FLD_MAGICNew3;

		public int FLD_MAGICNew4;

		public int FLD_LEVEL1
		{
			get
			{
				return _FLD_LEVEL1;
			}
			set
			{
				_FLD_LEVEL1 = value;
			}
		}

		public int FLD_LEVEL2
		{
			get
			{
				return _FLD_LEVEL2;
			}
			set
			{
				_FLD_LEVEL2 = value;
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

		public string FLD_NAME
		{
			get
			{
				return _FLD_NAME;
			}
			set
			{
				_FLD_NAME = value;
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

		public int FLD_PP
		{
			get
			{
				return _FLD_PP;
			}
			set
			{
				_FLD_PP = value;
			}
		}

		public static List<DropClass> GetBossDrop(int leve)
		{
			List<DropClass> list = new List<DropClass>();
			List<DropClass> list2 = new List<DropClass>();
			Random random = new Random(World.GetRandomSeed());
			int num = random.Next(0, 8000 * ((World.Newversion < 13) ? 1 : 10));
			foreach (DropClass item in World.BossDrop)
			{
				if (item.FLD_LEVEL1 <= leve && item.FLD_LEVEL2 >= leve && item.FLD_PP + World.暴率 / 6 >= num)
				{
					list.Add(item);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			int num2 = random.Next(25, 25);
			int num3 = 0;
			foreach (DropClass item2 in list)
			{
				if (num3 >= num2)
				{
					break;
				}
				int index = random.Next(0, list.Count);
				list2.Add(list[index]);
				num3++;
			}
			if (list2.Count == 0)
			{
				return null;
			}
			return list2;
		}

		public static DropClass GetDrop(int leve)
		{
			List<DropClass> list = new List<DropClass>();
			Random random = new Random(World.GetRandomSeed());
			int num = random.Next(0, 8000 * ((World.Newversion < 13) ? 1 : 10));
			foreach (DropClass item in World.Drop)
			{
				if (item.FLD_LEVEL1 <= leve && item.FLD_LEVEL2 >= leve && item.FLD_PP + 10 >= num)
				{
					list.Add(item);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			int index = random.Next(0, list.Count);
			return list[index];
		}

		public static List<DropClass> GetGSDrop(int leve, int sl, int maxsl)
		{
			List<DropClass> list = new List<DropClass>();
			List<DropClass> list2 = new List<DropClass>();
			Random random = new Random(World.GetRandomSeed());
			int num = random.Next(0, 8000 * ((World.Newversion < 13) ? 1 : 10));
			foreach (DropClass dropG in World.DropGs)
			{
				if ((World.CuonghoaMatItem == 0 || World.checkSpecialWeapons(dropG.FLD_PID) == 0) && dropG.FLD_LEVEL1 <= leve && dropG.FLD_LEVEL2 >= leve && dropG.FLD_PP >= num)
				{
					list.Add(dropG);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			int num2 = random.Next(20, 20);
			int num3 = 0;
			foreach (DropClass item in list)
			{
				if (num3 >= num2)
				{
					break;
				}
				int index = random.Next(0, list.Count);
				list2.Add(list[index]);
				num3++;
			}
			if (list2.Count == 0)
			{
				return null;
			}
			return list2;
		}

		public static List<DropClass> GetJlDrop(int leve)
		{
			List<DropClass> list = new List<DropClass>();
			List<DropClass> list2 = new List<DropClass>();
			Random random = new Random(World.GetRandomSeed());
			int num = random.Next(0, 100 * ((World.Newversion < 13) ? 1 : 10));
			foreach (DropClass item in World.DropJl)
			{
				if (item.FLD_LEVEL1 <= leve && item.FLD_LEVEL2 >= leve && item.FLD_PP >= num)
				{
					list.Add(item);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			int num2 = 1;
			int num3 = 0;
			foreach (DropClass item2 in list)
			{
				if (num3 >= num2)
				{
					break;
				}
				int index = random.Next(0, list.Count);
				list2.Add(list[index]);
				num3++;
			}
			if (list2.Count == 0)
			{
				return null;
			}
			return list2;
		}

		public static DropClass GetVipDrop(int leve)
		{
			List<DropClass> list = new List<DropClass>();
			Random random = new Random(World.GetRandomSeed());
			int num = random.Next(0, 8000 * ((World.Newversion < 13) ? 1 : 10));
			foreach (DropClass item in World.Drop)
			{
				if (item.FLD_LEVEL1 <= leve && item.FLD_LEVEL2 >= leve && item.FLD_PP + 110 >= num)
				{
					list.Add(item);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			int index = random.Next(0, list.Count);
			return list[index];
		}
	}
}

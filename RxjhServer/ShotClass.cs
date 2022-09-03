using RxjhServer.RxjhServer;
using System.Collections.Generic;

namespace RxjhServer
{
	public class ShotClass
	{
		private int eval_a;

		private int eval_b;

		private int eval_c;

		private int eval_d;

		private int eval_e;

		private int eval_f;

		private int eval_g;

		private int eval_h;

		private int eval_i;

		private int _FLD_DURABILITY;

		public int FLD_CJL
		{
			get
			{
				return eval_i;
			}
			set
			{
				eval_i = value;
			}
		}

		public int FLD_DURABILITY
		{
			get
			{
				return _FLD_DURABILITY;
			}
			set
			{
				_FLD_DURABILITY = value;
			}
		}

		public int FLD_INDEX
		{
			get
			{
				return eval_b;
			}
			set
			{
				eval_b = value;
			}
		}

		public int FLD_MAGIC0
		{
			get
			{
				return eval_d;
			}
			set
			{
				eval_d = value;
			}
		}

		public int FLD_MAGIC1
		{
			get
			{
				return eval_e;
			}
			set
			{
				eval_e = value;
			}
		}

		public int FLD_MAGIC2
		{
			get
			{
				return eval_f;
			}
			set
			{
				eval_f = value;
			}
		}

		public int FLD_MAGIC3
		{
			get
			{
				return eval_g;
			}
			set
			{
				eval_g = value;
			}
		}

		public int FLD_MAGIC4
		{
			get
			{
				return eval_h;
			}
			set
			{
				eval_h = value;
			}
		}

		public int FLD_MAGICZh
		{
			get
			{
				int num = 0;
				if (eval_e != 0)
				{
					num++;
				}
				if (eval_f != 0)
				{
					num++;
				}
				if (eval_g != 0)
				{
					num++;
				}
				if (eval_h != 0)
				{
					num++;
				}
				return num;
			}
		}

		public int FLD_NID
		{
			get
			{
				return eval_a;
			}
			set
			{
				eval_a = value;
			}
		}

		public int FLD_PID
		{
			get
			{
				return eval_c;
			}
			set
			{
				eval_c = value;
			}
		}

		public static List<ShotClass> GetShotList(int id)
		{
			int num = -1;
			ThreadSafeDictionary<int, ShotClass> threadSafeDictionary = new ThreadSafeDictionary<int, ShotClass>();
			List<ShotClass> list = new List<ShotClass>();
			foreach (ShotClass item in World.Shot)
			{
				if (item.FLD_NID == id)
				{
					if (item.FLD_INDEX > num)
					{
						num = item.FLD_INDEX;
					}
					threadSafeDictionary.Add(item.FLD_INDEX, item);
				}
			}
			for (int i = 0; i <= num; i++)
			{
				if (threadSafeDictionary.ContainsKey(i))
				{
					list.Add(threadSafeDictionary[i]);
				}
				else
				{
					list.Add(new ShotClass());
				}
			}
			return list;
		}

		public static ShotClass Getwp(int id)
		{
			foreach (ShotClass item in World.Shot)
			{
				if (item.FLD_PID == id)
				{
					return item;
				}
			}
			return null;
		}
	}
}

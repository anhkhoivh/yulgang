using RxjhServer.RxjhServer;
using System;
using System.Collections.Generic;

namespace RxjhServer
{
	public class NpcDropClass
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

		private string eval_j;

		public int FLD_ITME_PID
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

		public int FLD_LEVEL1
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

		public int FLD_LEVEL2
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

		public int FLD_MAGIC0
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

		public int FLD_MAGIC1
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

		public int FLD_MAGIC2
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

		public int FLD_MAGIC3
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

		public int FLD_MAGIC4
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

		public string FLD_NAME
		{
			get
			{
				return eval_j;
			}
			set
			{
				eval_j = value;
			}
		}

		public int FLD_NPC_PID
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

		public static List<NpcDropClass> GetDrop(int NpcId, int Boss)
		{
			List<NpcDropClass> list = new List<NpcDropClass>();
			Random random = new Random(World.GetRandomSeed());
			foreach (NpcDropClass item in World.NpcDrop)
			{
				if (item.FLD_NPC_PID == NpcId && random.Next(0, item.FLD_LEVEL2 + 1) <= item.FLD_LEVEL1)
				{
					list.Add(item);
				}
			}
			if (list.Count == 0)
			{
				return null;
			}
			return list;
		}
	}
}

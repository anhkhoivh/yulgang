using System;
using System.Collections.Generic;

namespace RxjhServer
{
	public class 攻击类 : IDisposable
	{
		private int a;

		private int b;

		private long c;

		private int d;

		public List<群攻击类> 群攻;

		public int 攻击类型
		{
			get
			{
				return d;
			}
			set
			{
				d = value;
			}
		}

		public long 攻击力
		{
			get
			{
				return c;
			}
			set
			{
				c = value;
			}
		}

		public int 人物ID
		{
			get
			{
				return a;
			}
			set
			{
				a = value;
			}
		}

		public int 武功ID
		{
			get
			{
				return b;
			}
			set
			{
				b = value;
			}
		}

		public 攻击类(int 人物ID_, int 武功ID_, long 攻击力_, int 攻击类型_)
		{
			人物ID = 人物ID_;
			武功ID = 武功ID_;
			攻击力 = 攻击力_;
			攻击类型 = 攻击类型_;
		}

		public 攻击类(int 人物ID_, int 武功ID_, long 攻击力_, int 攻击类型_, int 群攻l)
		{
			人物ID = 人物ID_;
			武功ID = 武功ID_;
			攻击力 = 攻击力_;
			攻击类型 = 攻击类型_;
			if (群攻l == 4)
			{
				群攻 = new List<群攻击类>();
			}
		}

		public void Dispose()
		{
			if (群攻 != null)
			{
				群攻.Clear();
				群攻 = null;
			}
		}
	}
}

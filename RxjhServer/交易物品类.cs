using System;

namespace RxjhServer
{
	public class 交易物品类 : IDisposable
	{
		private int a;

		private 物品类 b;

		public 物品类 物品
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

		public int 物品数量
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

		public void Dispose()
		{
			物品 = null;
		}
	}
}

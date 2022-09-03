using RxjhServer.RxjhServer;
using System;

namespace RxjhServer
{
	public class Itimesx
	{
		private int a;

		private int b;

		private int c;

		private int eval_d;

		public int 气功属性类型
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

		public int 属性类型
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

		public int 属性数量
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

		public int 数量
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

		public Itimesx(byte[] 属性)
		{
			属性阶段(属性);
		}

		public void 属性阶段(byte[] 属性)
		{
			string text = BitConverter.ToInt32(属性, 0).ToString();
			switch (text.Length)
			{
			case 8:
				数量 = 1;
				属性类型 = int.Parse(text.Substring(0, 1));
				if (属性类型 == 8)
				{
					if (int.Parse(text.Substring(3, 1)) == 0)
					{
						气功属性类型 = int.Parse(text.Substring(4, 2));
					}
					else
					{
						气功属性类型 = int.Parse(text.Substring(3, 3));
					}
				}
				if (World.属性扩展是否开启 == 0)
				{
					属性数量 = int.Parse(text.Substring(6, 2));
				}
				else
				{
					属性数量 = int.Parse(text) - int.Parse(text.Substring(0, 1)) * 10000000;
				}
				break;
			case 9:
				数量 = 1;
				属性类型 = int.Parse(text.Substring(0, 2));
				if (World.属性扩展是否开启 == 0)
				{
					属性数量 = int.Parse(text.Substring(7, 2));
				}
				else
				{
					属性数量 = int.Parse(text) - int.Parse(text.Substring(0, 2)) * 10000000;
				}
				break;
			case 10:
				数量 = 1;
				属性类型 = int.Parse(text.Substring(0, 2));
				if (World.属性扩展是否开启 == 0)
				{
					属性数量 = int.Parse(text.Substring(7, 2));
				}
				else
				{
					属性数量 = int.Parse(text) - int.Parse(text.Substring(0, 3)) * 10000000;
				}
				break;
			}
		}
	}
}

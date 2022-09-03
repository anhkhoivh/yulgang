using System;

namespace RxjhServer
{
	public class 个人商店类 : IDisposable
	{
		private byte[] c;

		private bool eval_a;

		private bool eval_b;

		private ThreadSafeDictionary<long, 个人商店物品类> eval_d = new ThreadSafeDictionary<long, 个人商店物品类>();

		public Players 进入人;

		public int 商店类型;

		public bool 个人商店是否开启
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

		public bool 个人商店是否使用中
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

		public byte[] 商店名
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

		public ThreadSafeDictionary<long, 个人商店物品类> 商店物品列表
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

		public void Dispose()
		{
			if (商店物品列表 != null)
			{
				商店物品列表.Clear();
				商店物品列表.Dispose();
				商店物品列表 = null;
			}
			商店名 = null;
			进入人 = null;
		}

		~个人商店类()
		{
		}
	}
}

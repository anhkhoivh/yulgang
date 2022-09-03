using System;

namespace RxjhServer
{
	public class TxtClass : IDisposable
	{
		private string b;

		private int eval_a;

		public string Txt
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

		public int type
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

		public TxtClass(int type, string txtt)
		{
			eval_a = type;
			b = txtt;
		}

		public void Dispose()
		{
			b = null;
		}
	}
}

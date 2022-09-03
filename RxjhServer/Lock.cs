using RxjhServer.RxjhServer;
using System;
using System.Threading;

namespace RxjhServer
{
	public class Lock : IDisposable
	{
		private object a;

		public static int DefaultMillisecondsTimeout;

		public bool IsTimeout => a == null;

		static Lock()
		{
			old_acctor_mc();
		}

		public Lock(object obj)
		{
			eval_a(obj, 1000, A_2: true, "");
		}

		public Lock(object obj, string lei)
		{
			eval_a(obj, 1000, A_2: true, lei);
		}

		public Lock(object obj, int millisecondsTimeout, bool throwTimeoutException, string lei)
		{
			eval_a(obj, millisecondsTimeout, throwTimeoutException, lei);
		}

		public void Dispose()
		{
			if (a != null)
			{
				Monitor.Exit(a);
				a = null;
			}
		}

		private void eval_a(object A_0, int A_1, bool A_2, string A_3)
		{
			if (World.JlMsg == 1)
			{
			}
			if (Monitor.TryEnter(A_0, A_1))
			{
				a = A_0;
			}
			else if (A_2)
			{
				Form1.WriteLine(100, "锁定对象超时:" + A_3 + " " + A_0.GetType());
			}
		}

		private static void old_acctor_mc()
		{
			DefaultMillisecondsTimeout = 1000;
		}
	}
}

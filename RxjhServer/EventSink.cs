using System;
using System.Threading;

namespace RxjhServer
{
	public class EventSink
	{
		private static SocketConnectEventHandler eval_a;

		public static event SocketConnectEventHandler SocketConnect
		{
			add
			{
				SocketConnectEventHandler socketConnectEventHandler = eval_a;
				SocketConnectEventHandler socketConnectEventHandler2;
				do
				{
					socketConnectEventHandler2 = socketConnectEventHandler;
					SocketConnectEventHandler value2 = (SocketConnectEventHandler)Delegate.Combine(socketConnectEventHandler2, value);
					socketConnectEventHandler = Interlocked.CompareExchange(ref eval_a, value2, socketConnectEventHandler2);
				}
				while (socketConnectEventHandler != socketConnectEventHandler2);
			}
			remove
			{
				SocketConnectEventHandler socketConnectEventHandler = eval_a;
				SocketConnectEventHandler socketConnectEventHandler2;
				do
				{
					socketConnectEventHandler2 = socketConnectEventHandler;
					SocketConnectEventHandler value2 = (SocketConnectEventHandler)Delegate.Remove(socketConnectEventHandler2, value);
					socketConnectEventHandler = Interlocked.CompareExchange(ref eval_a, value2, socketConnectEventHandler2);
				}
				while (socketConnectEventHandler != socketConnectEventHandler2);
			}
		}

		public static void InvokeSocketConnect(SocketConnectEventArgs e)
		{
			if (eval_a != null)
			{
				eval_a(e);
			}
		}
	}
}

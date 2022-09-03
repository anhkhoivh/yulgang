using System;
using System.Net.Sockets;

namespace RxjhServer
{
	public class SocketConnectEventArgs : EventArgs
	{
		private Socket eval_a;

		private bool eval_b;

		public bool AllowConnection
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

		public Socket Socket => eval_a;

		public SocketConnectEventArgs(Socket s)
		{
			eval_a = s;
			eval_b = true;
		}
	}
}

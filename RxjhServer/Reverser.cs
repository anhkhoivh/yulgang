using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace RxjhServer
{
	public class Reverser<T> : IComparer<T>
	{
		private Type a_a;

		private ReverserInfo b;

		public Reverser(string className, string name, ReverserInfo.Direction direction)
		{
			try
			{
				a_a = Type.GetType(className, throwOnError: true);
				b.name = name;
				b.direction = direction;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public Reverser(Type type, string name, ReverserInfo.Direction direction)
		{
			a_a = type;
			b.name = name;
			if (direction != 0)
			{
				b.direction = direction;
			}
		}

		public Reverser(T t, string name, ReverserInfo.Direction direction)
		{
			a_a = t.GetType();
			b.name = name;
			b.direction = direction;
		}

		private void a(ref object A_0, ref object A_1)
		{
			object obj = null;
			obj = A_0;
			A_0 = A_1;
			A_1 = obj;
		}

		int IComparer<T>.Compare(T t1, T t2)
		{
			object A_ = a_a.InvokeMember(b.name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty, null, t1, null);
			object A_2 = a_a.InvokeMember(b.name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.GetProperty, null, t2, null);
			if (b.direction != 0)
			{
				a(ref A_, ref A_2);
			}
			return new CaseInsensitiveComparer().Compare(A_, A_2);
		}
	}
}

#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace RxjhServer
{
	public class WUserManager<TUser> where TUser : IWUser<string>, new()
	{
		private static volatile bool eval_a_a;

		private static WUserManager<TUser> eval_b;

		private Dictionary<int, TUser> eval_c;

		private int eval_d;

		public TUser AddUser()
		{
			for (int i = 0; i < eval_d; i++)
			{
				TUser result = eval_c[i];
				using (result.UpdateLock)
				{
					if (result.Invalid)
					{
						using (result.WriteLock)
						{
							result.Reset();
							result.Invalid = false;
							result.Timestamp = DateTime.Now;
							return result;
						}
					}
				}
			}
			return default(TUser);
		}

		private static void eval_a(object A_0)
		{
			try
			{
				while (true)
				{
					Dictionary<int, TUser>.ValueCollection.Enumerator enumerator = eval_b.eval_c.Values.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							TUser current = enumerator.Current;
							using (current.ReadLock)
							{
								if (!current.Invalid)
								{
									using (current.UpdateLock)
									{
										if (DateTime.Now - current.Timestamp > TimeSpan.FromMinutes(3.0))
										{
											using (current.WriteLock)
											{
												current.Invalid = true;
											}
										}
									}
								}
							}
						}
					}
					finally
					{
						enumerator.Dispose();
					}
					Thread.Sleep(TimeSpan.FromMinutes(1.0));
				}
			}
			catch (Exception arg)
			{
				Trace.TraceError(string.Format("user manager clear error:", arg));
			}
		}

		public static WUserManager<TUser> GetInstance()
		{
			if (!eval_a_a)
			{
				throw new ApplicationException("no init");
			}
			return eval_b;
		}

		public TUser GetUser(int index, string credentials)
		{
			if (index >= 0 && index < eval_d)
			{
				if (string.IsNullOrEmpty(credentials))
				{
					return default(TUser);
				}
				TUser result = eval_c[index];
				using (result.UpdateLock)
				{
					if (!result.Authentication(credentials))
					{
						throw new ApplicationException("Authentication failed");
					}
					if (!result.Invalid)
					{
						using (result.WriteLock)
						{
							result.Timestamp = DateTime.Now;
							return result;
						}
					}
				}
			}
			return default(TUser);
		}

		public static void Init(int maxUsers)
		{
			if (eval_a_a)
			{
				throw new ApplicationException("alread inited");
			}
			eval_b = new WUserManager<TUser>();
			eval_b.eval_d = maxUsers;
			eval_b.eval_c = new Dictionary<int, TUser>(maxUsers);
			for (int i = 0; i < maxUsers; i++)
			{
				TUser value = new TUser();
				value.Index = i;
				eval_b.eval_c[i] = value;
			}
			Thread thread = new Thread(eval_a);
			thread.Name = "user manager clearner";
			thread.IsBackground = true;
			thread.Priority = ThreadPriority.Highest;
			thread.Start();
			eval_a_a = true;
		}

		public bool RemoveUser(int index, string credentials)
		{
			if (index < 0 || index >= eval_d)
			{
				return false;
			}
			if (string.IsNullOrEmpty(credentials))
			{
				return false;
			}
			TUser val = eval_c[index];
			if (val == null)
			{
				return false;
			}
			using (val.WriteLock)
			{
				val.Invalid = true;
			}
			return true;
		}
	}
}

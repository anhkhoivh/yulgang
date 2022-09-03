namespace RxjhServer
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Threading;

    public class WUserManager<TUser> where TUser: IWUser<string>, new()
    {
        private static volatile bool eval_a_a;
        private static WUserManager<TUser> eval_b;
        private Dictionary<int, TUser> eval_c;
        private int eval_d;

        public TUser AddUser()
        {
            for (int i = 0; i < this.eval_d; ++i)
            {
                TUser local2 = this.eval_c[i];
                using (local2.UpdateLock)
                {
                    if (local2.Invalid)
                    {
                        using (local2.WriteLock)
                        {
                            local2.Reset();
                            local2.Invalid = false;
                            local2.Timestamp = DateTime.Now;
                            return local2;
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
                Dictionary<int, TUser>.ValueCollection.Enumerator enumerator;
                goto Label_00E6;
            Label_0007:
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
                                    if ((DateTime.Now - current.Timestamp) > TimeSpan.FromMinutes(3.0))
                                    {
                                        using (current.WriteLock)
                                        {
                                            current.Invalid = true;
                                        }
                                    }
                                }
                            }
                            continue;
                        }
                    }
                }
                finally
                {
                    enumerator.Dispose();
                }
                Thread.Sleep(TimeSpan.FromMinutes(1.0));
            Label_00E6:
                enumerator = WUserManager<TUser>.eval_b.eval_c.Values.GetEnumerator();
                goto Label_0007;
            }
            catch (Exception exception)
            {
                Trace.TraceError(string.Format("user manager clear error:", exception));
            }
        }

        public static WUserManager<TUser> GetInstance()
        {
            if (!WUserManager<TUser>.eval_a_a)
            {
                throw new ApplicationException("no init");
            }
            return WUserManager<TUser>.eval_b;
        }

        public TUser GetUser(int index, string credentials)
        {
            if ((index >= 0) && (index < this.eval_d))
            {
                if (string.IsNullOrEmpty(credentials))
                {
                    return default(TUser);
                }
                TUser local = this.eval_c[index];
                using (local.UpdateLock)
                {
                    if (!local.Authentication(credentials))
                    {
                        throw new ApplicationException("Authentication failed");
                    }
                    if (!local.Invalid)
                    {
                        using (local.WriteLock)
                        {
                            local.Timestamp = DateTime.Now;
                            return local;
                        }
                    }
                }
            }
            return default(TUser);
        }

        public static void Init(int maxUsers)
        {
            if (WUserManager<TUser>.eval_a_a)
            {
                throw new ApplicationException("alread inited");
            }
            WUserManager<TUser>.eval_b = new WUserManager<TUser>();
            WUserManager<TUser>.eval_b.eval_d = maxUsers;
            WUserManager<TUser>.eval_b.eval_c = new Dictionary<int, TUser>(maxUsers);
            for (int i = 0; i < maxUsers; ++i)
            {
                TUser local2 = default(TUser);
                TUser local = (local2 == null) ? Activator.CreateInstance<TUser>() : default(TUser);
                local.Index = i;
                WUserManager<TUser>.eval_b.eval_c[i] = local;
            }
            Thread thread = new Thread(new ParameterizedThreadStart(WUserManager<TUser>.eval_a));
            thread.Name = "user manager clearner";
            thread.IsBackground = true;
            thread.Priority = ThreadPriority.Highest;
            thread.Start();
            WUserManager<TUser>.eval_a_a = true;
        }

        public bool RemoveUser(int index, string credentials)
        {
            if ((index < 0) || (index >= this.eval_d))
            {
                return false;
            }
            if (string.IsNullOrEmpty(credentials))
            {
                return false;
            }
            TUser local = this.eval_c[index];
            if (local == null)
            {
                return false;
            }
            using (local.WriteLock)
            {
                local.Invalid = true;
            }
            return true;
        }
    }
}


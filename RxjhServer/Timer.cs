using RxjhServer.RxjhServer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace RxjhServer
{
	public class Timer
	{
		private sealed class eval_a : Timer
		{
			private readonly TimerCallback _evalAa;

			public override bool DefRegCreation => false;

			public eval_a(TimeSpan A_0, TimeSpan A_1, int A_2, TimerCallback A_3)
				: base(A_0, A_1, A_2)
			{
				_evalAa = A_3;
				RegCreation();
			}

			public TimerCallback eval_e()
			{
				return _evalAa;
			}

			protected override void OnTick()
			{
				if (_evalAa != null)
				{
					_evalAa();
				}
			}

			public override string ToString()
			{
				return $"DelayCallTimer[{eval_e(_evalAa)}]";
			}
		}

		private sealed class eval_b : Timer
		{
			private readonly TimerStateCallback _evalC;

			private readonly object eval_d;

			public override bool DefRegCreation => false;

			public eval_b(TimeSpan a0, TimeSpan a1, int a2, TimerStateCallback a3, object a4)
				: base(a0, a1, a2)
			{
				_evalC = a3;
				eval_d = a4;
				RegCreation();
			}

			public TimerStateCallback eval_e()
			{
				return _evalC;
			}

			protected override void OnTick()
			{
				if (_evalC != null)
				{
					_evalC(eval_d);
				}
			}

			public override string ToString()
			{
				return $"DelayStateCall[{eval_e(_evalC)}]";
			}
		}

		public class TimerThread
		{
			private class eval_a_class
			{
				public Timer eval_a_a;

				public int eval_b;

				public bool eval_c;

				private static Queue<eval_a_class> eval_d_d;

				static eval_a_class()
				{
					old_acctor_mc();
				}

				private eval_a_class(Timer A_0, int A_1, bool A_2)
				{
					eval_a_a = A_0;
					eval_b = A_1;
					eval_c = A_2;
				}

				public void a()
				{
				}

				public static eval_a_class eval_d(Timer A_0, int A_1, bool A_2)
				{
					if (eval_d_d.Count > 0)
					{
						eval_a_class eval_a_class = eval_d_d.Dequeue();
						if (eval_a_class == null)
						{
							return new eval_a_class(A_0, A_1, A_2);
						}
						eval_a_class.eval_a_a = A_0;
						eval_a_class.eval_b = A_1;
						eval_a_class.eval_c = A_2;
						return eval_a_class;
					}
					return new eval_a_class(A_0, A_1, A_2);
				}

				private static void old_acctor_mc()
				{
					eval_d_d = new Queue<eval_a_class>();
				}
			}

			private static Queue eval_a_a;

			private static DateTime[] eval_b;

			private static TimeSpan[] eval_c;

			private static List<Timer>[] eval_d;

			static TimerThread()
			{
				old_acctor_mc();
			}

			public static void AddTimer(Timer t)
			{
				Change(t, (int)t.Priority, isAdd: true);
			}

			public static void Change(Timer t, int newIndex, bool isAdd)
			{
				eval_a_a.Enqueue(eval_a_class.eval_d(t, newIndex, isAdd));
			}

			public static void DumpInfo(TextWriter tw)
			{
				for (int i = 0; i < 8; i++)
				{
					tw.WriteLine("Priority: {0}", (TimerPriority)i);
					tw.WriteLine();
					Dictionary<string, List<Timer>> dictionary = new Dictionary<string, List<Timer>>();
					for (int j = 0; j < eval_d[i].Count; j++)
					{
						Timer timer = eval_d[i][j];
						string key = timer.ToString();
						dictionary.TryGetValue(key, out List<Timer> value);
						if (value == null)
						{
							value = (dictionary[key] = new List<Timer>());
						}
						value.Add(timer);
					}
					foreach (KeyValuePair<string, List<Timer>> item in dictionary)
					{
						string key2 = item.Key;
						List<Timer> value2 = item.Value;
						tw.WriteLine("Type: {0}; Count: {1}; Percent: {2}%", key2, value2.Count, (int)(100.0 * ((double)value2.Count / (double)eval_d[i].Count)));
					}
					tw.WriteLine();
					tw.WriteLine();
				}
			}

			private static void eval_a()
			{
				while (eval_a_a.Count > 0)
				{
					if (World.JlMsg == 1)
					{
					}
					eval_a_class eval_a_class = (eval_a_class)eval_a_a.Dequeue();
					Timer timer = eval_a_class.eval_a_a;
					int num = eval_a_class.eval_b;
					if (timer.eval_h != null)
					{
						timer.eval_h.Remove(timer);
					}
					if (eval_a_class.eval_c)
					{
						timer.eval_a_a = DateTime.Now + timer.eval_b_b;
						timer.eval_e_e = 0;
					}
					if (num >= 0)
					{
						timer.eval_h = eval_d[num];
						timer.eval_h.Add(timer);
					}
					else
					{
						timer.eval_h = null;
					}
					eval_a_class.a();
				}
			}

			private static void old_acctor_mc()
			{
				eval_a_a = Queue.Synchronized(new Queue());
				eval_b = new DateTime[8];
				eval_c = new TimeSpan[8]
				{
					TimeSpan.Zero,
					TimeSpan.FromMilliseconds(10.0),
					TimeSpan.FromMilliseconds(25.0),
					TimeSpan.FromMilliseconds(50.0),
					TimeSpan.FromMilliseconds(250.0),
					TimeSpan.FromSeconds(1.0),
					TimeSpan.FromSeconds(5.0),
					TimeSpan.FromMinutes(1.0)
				};
				eval_d = new List<Timer>[8]
				{
					new List<Timer>(),
					new List<Timer>(),
					new List<Timer>(),
					new List<Timer>(),
					new List<Timer>(),
					new List<Timer>(),
					new List<Timer>(),
					new List<Timer>()
				};
			}

			public static void PriorityChange(Timer t, int newPrio)
			{
				Change(t, newPrio, isAdd: false);
			}

			public static void RemoveTimer(Timer t)
			{
				Change(t, -1, isAdd: false);
			}

			public void TimerMain()
			{
				while (true)
				{
					bool flag = true;
					if (World.JlMsg == 1)
					{
					}
					Thread.Sleep(10);
					eval_a();
					for (int i = 0; i < eval_d.Length; i++)
					{
						DateTime now = DateTime.Now;
						if (now < eval_b[i])
						{
							break;
						}
						eval_b[i] = now + eval_c[i];
						for (int j = 0; j < eval_d[i].Count; j++)
						{
							Timer timer = eval_d[i][j];
							if (!timer.eval_m && now > timer.eval_a_a)
							{
								timer.eval_m = true;
								lock (eval_j)
								{
									eval_j.Enqueue(timer);
								}
								if (timer.eval_f != 0 && ++timer.eval_e_e >= timer.eval_f)
								{
									timer.Stop();
								}
								else
								{
									timer.eval_a_a = now + timer.eval_c;
								}
							}
						}
					}
				}
			}
		}

		private DateTime eval_a_a;

		private TimeSpan eval_b_b;

		private TimeSpan eval_c;

		private bool _evalD;

		private int eval_e_e;

		private int eval_f;

		private TimerPriority eval_g;

		private List<Timer> eval_h;

		private static Dictionary<string, TimerProfile> eval_i;

		private static Queue<Timer> eval_j;

		private static int eval_k;

		private static int eval_l;

		private bool eval_m;

		public static int BreakCount
		{
			get
			{
				return eval_k;
			}
			set
			{
				eval_k = value;
			}
		}

		public virtual bool DefRegCreation => true;

		public TimeSpan Delay
		{
			get
			{
				return eval_b_b;
			}
			set
			{
				eval_b_b = value;
			}
		}

		public TimeSpan Interval
		{
			get
			{
				return eval_c;
			}
			set
			{
				eval_c = value;
			}
		}

		public DateTime Next => eval_a_a;

		public TimerPriority Priority
		{
			get
			{
				return eval_g;
			}
			set
			{
				if (eval_g != value)
				{
					eval_g = value;
					if (_evalD)
					{
						TimerThread.PriorityChange(this, (int)eval_g);
					}
				}
			}
		}

		public static Dictionary<string, TimerProfile> Profiles => eval_i;

		public bool Running
		{
			get
			{
				return _evalD;
			}
			set
			{
				if (value)
				{
					Start();
				}
				else
				{
					Stop();
				}
			}
		}

		static Timer()
		{
			old_acctor_mc();
		}

		public Timer(TimeSpan delay)
			: this(delay, TimeSpan.Zero, 1)
		{
		}

		public Timer(TimeSpan delay, TimeSpan interval)
			: this(delay, interval, 0)
		{
		}

		public Timer(TimeSpan delay, TimeSpan interval, int count)
		{
			eval_b_b = delay;
			eval_c = interval;
			eval_f = count;
			if (DefRegCreation)
			{
				RegCreation();
			}
		}

		public static TimerPriority ComputePriority(TimeSpan ts)
		{
			if (ts >= TimeSpan.FromMinutes(1.0))
			{
				return TimerPriority.FiveSeconds;
			}
			if (ts >= TimeSpan.FromSeconds(10.0))
			{
				return TimerPriority.OneSecond;
			}
			if (ts >= TimeSpan.FromSeconds(5.0))
			{
				return TimerPriority.TwoFiftyMS;
			}
			if (ts >= TimeSpan.FromSeconds(2.5))
			{
				return TimerPriority.FiftyMS;
			}
			if (ts >= TimeSpan.FromSeconds(1.0))
			{
				return TimerPriority.TwentyFiveMS;
			}
			if (ts >= TimeSpan.FromSeconds(0.5))
			{
				return TimerPriority.TenMS;
			}
			return TimerPriority.EveryTick;
		}

		public static Timer DelayCall(TimeSpan delay, TimerCallback callback)
		{
			return DelayCall(delay, TimeSpan.Zero, 1, callback);
		}

		public static Timer DelayCall(TimeSpan delay, TimerStateCallback callback, object state)
		{
			return DelayCall(delay, TimeSpan.Zero, 1, callback, state);
		}

		public static Timer DelayCall(TimeSpan delay, TimeSpan interval, TimerCallback callback)
		{
			return DelayCall(delay, interval, 0, callback);
		}

		public static Timer DelayCall(TimeSpan delay, TimeSpan interval, TimerStateCallback callback, object state)
		{
			return DelayCall(delay, interval, 0, callback, state);
		}

		public static Timer DelayCall(TimeSpan delay, TimeSpan interval, int count, TimerCallback callback)
		{
			Timer timer = new eval_a(delay, interval, count, callback);
			if (count == 1)
			{
				timer.Priority = ComputePriority(delay);
			}
			else
			{
				timer.Priority = ComputePriority(interval);
			}
			timer.Start();
			return timer;
		}

		public static Timer DelayCall(TimeSpan delay, TimeSpan interval, int count, TimerStateCallback callback, object state)
		{
			Timer timer = new eval_b(delay, interval, count, callback, state);
			if (count == 1)
			{
				timer.Priority = ComputePriority(delay);
			}
			else
			{
				timer.Priority = ComputePriority(interval);
			}
			timer.Start();
			return timer;
		}

		public static void DumpInfo(TextWriter tw)
		{
			TimerThread.DumpInfo(tw);
		}

		private static string eval_e(Delegate A_0)
		{
			if ((object)A_0 == null)
			{
				return "null";
			}
			return $"{A_0.Method.DeclaringType.FullName}.{A_0.Method.Name}";
		}

		public TimerProfile GetProfile()
		{
			string text = ToString();
			if (text == null)
			{
				text = "null";
			}
			TimerProfile value = null;
			eval_i.TryGetValue(text, out value);
			if (value == null)
			{
				value = (eval_i[text] = new TimerProfile());
			}
			return value;
		}

		private static void old_acctor_mc()
		{
			eval_i = new Dictionary<string, TimerProfile>();
			eval_j = new Queue<Timer>();
			eval_k = 20000;
		}

		protected virtual void OnTick()
		{
		}

		public virtual void RegCreation()
		{
			GetProfile()?.RegCreation();
		}

		public static void Slice()
		{
			lock (eval_j)
			{
				eval_l = eval_j.Count;
				int num = 0;
				Stopwatch stopwatch = null;
				while (num < eval_k && eval_j.Count != 0)
				{
					if (World.JlMsg == 1)
					{
					}
					Timer timer = eval_j.Dequeue();
					TimerProfile profile = timer.GetProfile();
					if (profile != null)
					{
						if (stopwatch == null)
						{
							stopwatch = Stopwatch.StartNew();
						}
						else
						{
							stopwatch.Start();
						}
					}
					timer.OnTick();
					timer.eval_m = false;
					num++;
					if (profile != null)
					{
						profile.RegTicked(stopwatch.Elapsed);
						stopwatch.Reset();
					}
				}
			}
		}

		public void Start()
		{
			if (!_evalD)
			{
				_evalD = true;
				TimerThread.AddTimer(this);
				GetProfile()?.RegStart();
			}
		}

		public void Stop()
		{
			if (_evalD)
			{
				_evalD = false;
				TimerThread.RemoveTimer(this);
				GetProfile()?.RegStopped();
			}
		}

		public override string ToString()
		{
			return GetType().FullName;
		}
	}
}

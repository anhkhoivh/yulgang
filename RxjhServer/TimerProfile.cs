using System;

namespace RxjhServer
{
	public class TimerProfile
	{
		private int eval_a;

		private int eval_b;

		private int eval_c;

		private int eval_d;

		private TimeSpan eval_e;

		private TimeSpan eval_f;

		public void RegCreation()
		{
			eval_a++;
		}

		public void RegStart()
		{
			eval_b++;
		}

		public void RegStopped()
		{
			eval_c++;
		}

		public void RegTicked(TimeSpan procTime)
		{
			eval_d++;
			eval_e += procTime;
			if (procTime > eval_f)
			{
				eval_f = procTime;
			}
		}
	}
}

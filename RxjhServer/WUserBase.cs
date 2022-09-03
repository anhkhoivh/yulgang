using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace RxjhServer
{
	public class WUserBase<TContext> : IWUser<TContext>
	{
		[NonSerialized]
		private ReaderWriterLockSlim eval_a;

		private string eval_b;

		[CompilerGenerated]
		private DateTime eval_c;

		[CompilerGenerated]
		private int eval_d;

		[CompilerGenerated]
		private bool eval_e;

		[CompilerGenerated]
		private TContext eval_f;

		public TContext Context
		{
			get;
			set;
		}

		public string Credentials => eval_b;

		public int Index
		{
			get;
			set;
		}

		public bool Invalid
		{
			get;
			set;
		}

		public IDisposable ReadLock => new ReadOnlyLock(eval_a);

		public DateTime Timestamp
		{
			get;
			set;
		}

		public IDisposable UpdateLock => new ReadLock(eval_a);

		public IDisposable WriteLock => new WriteLock(eval_a);

		public WUserBase()
		{
			eval_a = Locks.GetLockInstance(LockRecursionPolicy.NoRecursion);
			eval_b = string.Empty;
			Index = -1;
			Timestamp = DateTime.MinValue;
			Invalid = true;
		}

		public bool Authentication(string credentials)
		{
			if (string.IsNullOrEmpty(eval_b))
			{
				return false;
			}
			if (string.IsNullOrEmpty(credentials))
			{
				return false;
			}
			if (eval_b != credentials)
			{
				return false;
			}
			return true;
		}

		public virtual void Reset()
		{
			eval_b = Guid.NewGuid().ToString();
			Context = default(TContext);
		}

		public override string ToString()
		{
			return $"{Index}-{Timestamp}";
		}
	}
}

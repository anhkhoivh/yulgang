namespace RxjhServer
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Threading;

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

        public WUserBase()
        {
            this.eval_a = Locks.GetLockInstance(LockRecursionPolicy.NoRecursion);
            this.eval_b = string.Empty;
            this.Index = -1;
            this.Timestamp = DateTime.MinValue;
            this.Invalid = true;
        }

        public bool Authentication(string credentials)
        {
            if (string.IsNullOrEmpty(this.eval_b))
            {
                return false;
            }
            if (string.IsNullOrEmpty(credentials))
            {
                return false;
            }
            if (this.eval_b != credentials)
            {
                return false;
            }
            return true;
        }

        public virtual void Reset()
        {
            this.eval_b = Guid.NewGuid().ToString();
            this.Context = default(TContext);
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}", this.Index, this.Timestamp);
        }

        public TContext Context
        {
            [CompilerGenerated]
            get
            {
                return this.eval_f;
            }
            [CompilerGenerated]
            set
            {
                this.eval_f = value;
            }
        }

        public string Credentials
        {
            get
            {
                return this.eval_b;
            }
        }

        public int Index
        {
            [CompilerGenerated]
            get
            {
                return this.eval_d;
            }
            [CompilerGenerated]
            set
            {
                this.eval_d = value;
            }
        }

        public bool Invalid
        {
            [CompilerGenerated]
            get
            {
                return this.eval_e;
            }
            [CompilerGenerated]
            set
            {
                this.eval_e = value;
            }
        }

        public IDisposable ReadLock
        {
            get
            {
                return new ReadOnlyLock(this.eval_a);
            }
        }

        public DateTime Timestamp
        {
            [CompilerGenerated]
            get
            {
                return this.eval_c;
            }
            [CompilerGenerated]
            set
            {
                this.eval_c = value;
            }
        }

        public IDisposable UpdateLock
        {
            get
            {
                return new ReadLock(this.eval_a);
            }
        }

        public IDisposable WriteLock
        {
            get
            {
                return new WriteLock(this.eval_a);
            }
        }
    }
}


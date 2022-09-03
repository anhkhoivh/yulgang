namespace RxjhServer
{
    using System;

    public interface IWUser<TContext>
    {
        bool Authentication(string credentials);
        void Reset();

        TContext Context { get; set; }

        string Credentials { get; }

        int Index { get; set; }

        bool Invalid { get; set; }

        IDisposable ReadLock { get; }

        DateTime Timestamp { get; set; }

        IDisposable UpdateLock { get; }

        IDisposable WriteLock { get; }
    }
}


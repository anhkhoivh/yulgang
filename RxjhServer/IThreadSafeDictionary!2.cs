namespace RxjhServer
{
    using System;
    using System.Collections.Generic;

    public interface IThreadSafeDictionary<TKey, TValue> : IDisposable, IDictionary<TKey, TValue>
    {
        void MergeSafe(TKey key, TValue newValue);
        void RemoveSafe(TKey key);
    }
}


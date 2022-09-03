using RxjhServer;

namespace RxjhServer
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Threading;

    [Serializable]
    public class ThreadSafeDictionary<TKey, TValue> : IThreadSafeDictionary<TKey, TValue>
    {
        private IDictionary<TKey, TValue> dict;
        [NonSerialized]
        private ReaderWriterLockSlim eval_a;

        public ThreadSafeDictionary()
        {
            this.dict = new Dictionary<TKey, TValue>();
            this.eval_a = Locks.GetLockInstance(LockRecursionPolicy.NoRecursion);
        }

        public virtual void Add(KeyValuePair<TKey, TValue> item)
        {
            using (new WriteLock(this.eval_a))
            {
                this.dict.Add(item);
            }
        }

        public virtual void Add(TKey key, TValue value)
        {
            if (!this.ContainsKey(key))
            {
                using (new WriteLock(this.eval_a))
                {
                    this.dict.Add(key, value);
                }
            }
        }

        public virtual void Clear()
        {
            using (new WriteLock(this.eval_a))
            {
                this.dict.Clear();
            }
        }

        public virtual bool Contains(KeyValuePair<TKey, TValue> item)
        {
            using (new ReadOnlyLock(this.eval_a))
            {
                return this.dict.Contains(item);
            }
        }

        public virtual bool ContainsKey(TKey key)
        {
            using (new ReadOnlyLock(this.eval_a))
            {
                return this.dict.ContainsKey(key);
            }
        }

        public virtual void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            using (new ReadOnlyLock(this.eval_a))
            {
                this.dict.CopyTo(array, arrayIndex);
            }
        }

        public void Dispose()
        {
            if (this.eval_a != null)
            {
                this.eval_a.Dispose();
                this.eval_a = null;
            }
            if (this.dict != null)
            {
                this.dict.Clear();
                this.dict = null;
            }
        }

        public virtual IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            throw new NotSupportedException("Cannot enumerate a threadsafe dictionary.  Instead, enumerate the keys or values collection");
        }

        public void MergeSafe(TKey key, TValue newValue)
        {
            using (new WriteLock(this.eval_a))
            {
                if (this.dict.ContainsKey(key))
                {
                    this.dict.Remove(key);
                }
                this.dict.Add(key, newValue);
            }
        }

        public virtual bool Remove(KeyValuePair<TKey, TValue> item)
        {
            using (new WriteLock(this.eval_a))
            {
                return this.dict.Remove(item);
            }
        }

        public virtual bool Remove(TKey key)
        {
            using (new WriteLock(this.eval_a))
            {
                return this.dict.Remove(key);
            }
        }

        public void RemoveSafe(TKey key)
        {
            using (new ReadLock(this.eval_a))
            {
                if (this.dict.ContainsKey(key))
                {
                    using (new WriteLock(this.eval_a))
                    {
                        this.dict.Remove(key);
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotSupportedException("Cannot enumerate a threadsafe dictionary.  Instead, enumerate the keys or values collection");
        }

        public virtual bool TryGetValue(TKey key, out TValue value)
        {
            using (new ReadOnlyLock(this.eval_a))
            {
                return this.dict.TryGetValue(key, out value);
            }
        }

        public virtual int Count
        {
            get
            {
                using (new ReadOnlyLock(this.eval_a))
                {
                    return this.dict.Count;
                }
            }
        }

        public virtual bool IsReadOnly
        {
            get
            {
                using (new ReadOnlyLock(this.eval_a))
                {
                    return this.dict.IsReadOnly;
                }
            }
        }

        public virtual TValue this[TKey key]
        {
            get
            {
                using (new ReadOnlyLock(this.eval_a))
                {
                    return this.dict[key];
                }
            }
            set
            {
                using (new WriteLock(this.eval_a))
                {
                    this.dict[key] = value;
                }
            }
        }

        public virtual ICollection<TKey> Keys
        {
            get
            {
                using (new ReadOnlyLock(this.eval_a))
                {
                    return new List<TKey>(this.dict.Keys);
                }
            }
        }

        public virtual ICollection<TValue> Values
        {
            get
            {
                using (new ReadOnlyLock(this.eval_a))
                {
                    return new List<TValue>(this.dict.Values);
                }
            }
        }
    }
}


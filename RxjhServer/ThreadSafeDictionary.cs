using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace RxjhServer
{
	[Serializable]
	public class ThreadSafeDictionary<TKey, TValue> : IThreadSafeDictionary<TKey, TValue>, IDisposable, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		private IDictionary<TKey, TValue> dict;

		[NonSerialized]
		private ReaderWriterLockSlim eval_a;

		public virtual int Count
		{
			get
			{
				using (new ReadOnlyLock(eval_a))
				{
					return dict.Count;
				}
			}
		}

		public virtual bool IsReadOnly
		{
			get
			{
				using (new ReadOnlyLock(eval_a))
				{
					return dict.IsReadOnly;
				}
			}
		}

		public virtual TValue this[TKey key]
		{
			get
			{
				using (new ReadOnlyLock(eval_a))
				{
					return dict[key];
				}
			}
			set
			{
				using (new WriteLock(eval_a))
				{
					dict[key] = value;
				}
			}
		}

		public virtual ICollection<TKey> Keys
		{
			get
			{
				using (new ReadOnlyLock(eval_a))
				{
					return new List<TKey>(dict.Keys);
				}
			}
		}

		public virtual ICollection<TValue> Values
		{
			get
			{
				using (new ReadOnlyLock(eval_a))
				{
					return new List<TValue>(dict.Values);
				}
			}
		}

		public ThreadSafeDictionary()
		{
			dict = new Dictionary<TKey, TValue>();
			eval_a = Locks.GetLockInstance(LockRecursionPolicy.NoRecursion);
		}

		public virtual void Add(KeyValuePair<TKey, TValue> item)
		{
			using (new WriteLock(eval_a))
			{
				dict.Add(item);
			}
		}

		public virtual void Add(TKey key, TValue value)
		{
			if (!ContainsKey(key))
			{
				using (new WriteLock(eval_a))
				{
					dict.Add(key, value);
				}
			}
		}

		public virtual void Clear()
		{
			using (new WriteLock(eval_a))
			{
				dict.Clear();
			}
		}

		public virtual bool Contains(KeyValuePair<TKey, TValue> item)
		{
			using (new ReadOnlyLock(eval_a))
			{
				return dict.Contains(item);
			}
		}

		public virtual bool ContainsKey(TKey key)
		{
			using (new ReadOnlyLock(eval_a))
			{
				return dict.ContainsKey(key);
			}
		}

		public virtual void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			using (new ReadOnlyLock(eval_a))
			{
				dict.CopyTo(array, arrayIndex);
			}
		}

		public void Dispose()
		{
			if (eval_a != null)
			{
				eval_a.Dispose();
				eval_a = null;
			}
			if (dict != null)
			{
				dict.Clear();
				dict = null;
			}
		}

		public virtual IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			throw new NotSupportedException("Cannot enumerate a threadsafe dictionary.  Instead, enumerate the keys or values collection");
		}

		public void MergeSafe(TKey key, TValue newValue)
		{
			using (new WriteLock(eval_a))
			{
				if (dict.ContainsKey(key))
				{
					dict.Remove(key);
				}
				dict.Add(key, newValue);
			}
		}

		public virtual bool Remove(KeyValuePair<TKey, TValue> item)
		{
			using (new WriteLock(eval_a))
			{
				return dict.Remove(item);
			}
		}

		public virtual bool Remove(TKey key)
		{
			using (new WriteLock(eval_a))
			{
				return dict.Remove(key);
			}
		}

		public void RemoveSafe(TKey key)
		{
			using (new ReadLock(eval_a))
			{
				if (dict.ContainsKey(key))
				{
					using (new WriteLock(eval_a))
					{
						dict.Remove(key);
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
			using (new ReadOnlyLock(eval_a))
			{
				return dict.TryGetValue(key, out value);
			}
		}
	}
}

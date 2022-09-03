using System;
using System.Collections;
using System.Collections.Generic;

namespace RxjhServer
{
	public interface IThreadSafeDictionary<TKey, TValue> : IDisposable, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		void MergeSafe(TKey key, TValue newValue);

		void RemoveSafe(TKey key);
	}
}

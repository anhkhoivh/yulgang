using System.Collections.Generic;

namespace RxjhServer
{
	public class LRUCacheHelper<K, V>
	{
		private readonly Dictionary<K, V> a;

		private readonly int d;

		private readonly LinkedList<K> eval_b;

		private readonly object eval_c;

		public LRUCacheHelper(int capacity, int max)
		{
			eval_b = new LinkedList<K>();
			eval_c = new object();
			a = new Dictionary<K, V>(capacity);
			d = max;
		}

		public void Add(K key, V value)
		{
			lock (eval_c)
			{
				eval_a();
				eval_b.AddFirst(key);
				a[key] = value;
			}
		}

		public void Delete(K key)
		{
			lock (eval_c)
			{
				a.Remove(key);
				eval_b.Remove(key);
			}
		}

		private void eval_a()
		{
			lock (eval_c)
			{
				int count = a.Count;
				if (count >= d)
				{
					int num = count / 10;
					for (int i = 0; i < num; i++)
					{
						a.Remove(eval_b.Last.Value);
						eval_b.RemoveLast();
					}
				}
			}
		}

		public V Get(K key)
		{
			lock (eval_c)
			{
				a.TryGetValue(key, out V value);
				eval_b.Remove(key);
				eval_b.AddFirst(key);
				return value;
			}
		}
	}
}

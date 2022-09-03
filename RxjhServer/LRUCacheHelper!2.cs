namespace RxjhServer
{
    using System;
    using System.Collections.Generic;

    public class LRUCacheHelper<K, V>
    {
        private readonly Dictionary<K, V> a;
        private readonly int d;
        private readonly LinkedList<K> eval_b;
        private readonly object eval_c;

        public LRUCacheHelper(int capacity, int max)
        {
            this.eval_b = new LinkedList<K>();
            this.eval_c = new object();
            this.a = new Dictionary<K, V>(capacity);
            this.d = max;
        }

        public void Add(K key, V value)
        {
            lock (this.eval_c)
            {
                this.eval_a();
                this.eval_b.AddFirst(key);
                this.a[key] = value;
            }
        }

        public void Delete(K key)
        {
            lock (this.eval_c)
            {
                this.a.Remove(key);
                this.eval_b.Remove(key);
            }
        }

        private void eval_a()
        {
            lock (this.eval_c)
            {
                int count = this.a.Count;
                if (count >= this.d)
                {
                    int num2 = count / 10;
                    for (int i = 0; i < num2; ++i)
                    {
                        this.a.Remove(this.eval_b.Last.Value);
                        this.eval_b.RemoveLast();
                    }
                }
            }
        }

        public V Get(K key)
        {
            lock (this.eval_c)
            {
                V local;
                this.a.TryGetValue(key, out local);
                this.eval_b.Remove(key);
                this.eval_b.AddFirst(key);
                return local;
            }
        }
    }
}


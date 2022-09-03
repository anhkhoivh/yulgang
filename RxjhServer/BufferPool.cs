using System.Collections.Generic;

namespace RxjhServer
{
	internal class BufferPool
	{
		private static List<BufferPool> _mPools;

		private readonly string _mName;

		private readonly int _mInitialCapacity;

		private readonly int _mBufferSize;

		private int _mMisses;

		private readonly Queue<byte[]> _mFreeBuffers;

		static BufferPool()
		{
			old_acctor_mc();
		}

		public BufferPool(string name, int initialCapacity, int bufferSize)
		{
			_mName = name;
			_mInitialCapacity = initialCapacity;
			_mBufferSize = bufferSize;
			_mFreeBuffers = new Queue<byte[]>(initialCapacity);
			for (int i = 0; i < initialCapacity; i++)
			{
				_mFreeBuffers.Enqueue(new byte[bufferSize]);
			}
			lock (_mPools)
			{
				_mPools.Add(this);
			}
		}

		public void Free()
		{
			lock (_mPools)
			{
				_mPools.Remove(this);
			}
		}

		public static List<BufferPool> eval_a()
		{
			return _mPools;
		}

		public static void eval_a(List<BufferPool> A_0)
		{
			_mPools = A_0;
		}

		public void ReleaseBuffer(byte[] A_0)
		{
			if (A_0 != null)
			{
				lock (this)
				{
					_mFreeBuffers.Enqueue(A_0);
				}
			}
		}

		public void eval_a(out string A_0, out int A_1, out int A_2, out int A_3, out int A_4, out int A_5)
		{
			lock (this)
			{
				A_0 = _mName;
				A_1 = _mFreeBuffers.Count;
				A_2 = _mInitialCapacity;
				A_3 = _mInitialCapacity * (1 + _mMisses);
				A_4 = _mBufferSize;
				A_5 = _mMisses;
			}
		}

		public byte[] eval_c()
		{
			lock (this)
			{
				if (_mFreeBuffers.Count <= 0)
				{
					_mMisses++;
					for (int i = 0; i < _mInitialCapacity; i++)
					{
						_mFreeBuffers.Enqueue(new byte[_mBufferSize]);
					}
				}
				return _mFreeBuffers.Dequeue();
			}
		}

		private static void old_acctor_mc()
		{
			_mPools = new List<BufferPool>();
		}
	}
}

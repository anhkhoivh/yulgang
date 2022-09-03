using RxjhServer;
using RxjhServer.RxjhServer;
using System;
using System.Collections.Generic;

namespace Network
{
	public class SendQueue : IDisposable
	{
		public class Gram
		{
			private static Stack<Gram> _pool;

			private byte[] _buffer;

			private int _length;

			public int Available => _buffer.Length - _length;

			public byte[] Buffer => _buffer;

			public bool IsFull => _length <= _buffer.Length;

			public int Length => _length;

			static Gram()
			{
				old_acctor_mc();
			}

			private Gram()
			{
			}

			public static Gram Acquire()
			{
				lock (_pool)
				{
					Gram gram = (_pool.Count <= 0) ? new Gram() : _pool.Pop();
					gram._buffer = AcquireBuffer();
					gram._length = 0;
					return gram;
				}
			}

			private static void old_acctor_mc()
			{
				_pool = new Stack<Gram>();
			}

			public void Release()
			{
				lock (_pool)
				{
					_pool.Push(this);
					ReleaseBuffer(_buffer);
				}
			}

			public int Write(byte[] buffer, int offset, int length)
			{
				int num = Math.Min(length, Available);
				System.Buffer.BlockCopy(buffer, offset, _buffer, _length, num);
				_length += num;
				return num;
			}
		}

		private const int PendingCap = 3072000;

		private static int m_CoalesceBufferSize;

		private static BufferPool m_UnusedBuffers;

		private Queue<Gram> _pending = new Queue<Gram>();

		private Gram _buffered;

		public static int CoalesceBufferSize
		{
			get
			{
				return m_CoalesceBufferSize;
			}
			set
			{
				if (m_CoalesceBufferSize != value)
				{
					if (m_UnusedBuffers != null)
					{
						m_UnusedBuffers.Free();
					}
					m_CoalesceBufferSize = value;
					m_UnusedBuffers = new BufferPool("Coalesced", 2048, m_CoalesceBufferSize);
				}
			}
		}

		public int GetpendingConn => _pending.Count;

		public bool IsEmpty => _pending.Count == 0 && _buffered == null;

		public bool IsFlushReady => _pending.Count == 0 && _buffered != null;

		static SendQueue()
		{
			old_acctor_mc();
		}

		public static byte[] AcquireBuffer()
		{
			return m_UnusedBuffers.eval_c();
		}

		public Gram CheckFlushReady()
		{
			Gram result = null;
			if (_pending.Count == 0 && _buffered != null)
			{
				result = _buffered;
				_pending.Enqueue(_buffered);
				_buffered = null;
			}
			return result;
		}

		public void Clear()
		{
			if (_buffered != null)
			{
				_buffered.Release();
				_buffered = null;
			}
			while (_pending.Count > 0)
			{
				if (World.JlMsg == 1)
				{
					Form1.WriteLine(0, "Clear");
				}
				_pending.Dequeue().Release();
			}
		}

		public Gram Dequeue()
		{
			Gram result = null;
			if (_pending.Count > 0)
			{
				_pending.Dequeue().Release();
				if (_pending.Count > 0)
				{
					result = _pending.Peek();
				}
			}
			return result;
		}

		public void Dispose()
		{
			_pending.Clear();
			_pending = null;
			_buffered = null;
		}

		public Gram Enqueue(byte[] buffer, int length)
		{
			return Enqueue(buffer, 0, length);
		}

		public Gram Enqueue(byte[] buffer, int offset, int length)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0 || offset >= buffer.Length)
			{
				throw new ArgumentOutOfRangeException("offset", offset, "Offset must be greater than or equal to zero and less than the size of the buffer.");
			}
			if (length < 0 || length > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero or greater than the size of the buffer.");
			}
			if (buffer.Length - offset < length)
			{
				throw new ArgumentException("Offset and length do not point to a valid segment within the buffer.");
			}
			int num = _pending.Count * m_CoalesceBufferSize + ((_buffered != null) ? _buffered.Length : 0);
			if (num + length > 3072000)
			{
				throw new CapacityExceededException();
			}
			Gram result = null;
			while (length > 0)
			{
				if (World.JlMsg == 1)
				{
				}
				if (_buffered == null)
				{
					_buffered = Gram.Acquire();
				}
				int num2 = _buffered.Write(buffer, offset, length);
				offset += num2;
				length -= num2;
				if (_buffered.IsFull)
				{
					if (_pending.Count == 0)
					{
						result = _buffered;
					}
					_pending.Enqueue(_buffered);
					_buffered = null;
				}
			}
			return result;
		}

		public int getpendingCount()
		{
			int num = 0;
			foreach (Gram item in _pending)
			{
				num += item.Length;
			}
			return num;
		}

		private static void old_acctor_mc()
		{
			m_CoalesceBufferSize = 1024;
			m_UnusedBuffers = new BufferPool("Coalesced", 2048, m_CoalesceBufferSize);
		}

		public static void ReleaseBuffer(byte[] buffer)
		{
			if (buffer != null && buffer.Length == m_CoalesceBufferSize)
			{
				m_UnusedBuffers.ReleaseBuffer(buffer);
			}
		}
	}
}

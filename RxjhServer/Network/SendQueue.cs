using RxjhServer.RxjhServer;

namespace Network
{
    using RxjhServer;
    using System;
    using System.Collections.Generic;

    public class SendQueue : IDisposable
    {
        private const int PendingCap = 3072000;
        private static int m_CoalesceBufferSize;
        private static BufferPool m_UnusedBuffers;
        private Queue<Gram> _pending = new Queue<Gram>();
        private Gram _buffered;

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
            Gram gram = null;
            if ((this._pending.Count == 0) && (this._buffered != null))
            {
                gram = this._buffered;
                this._pending.Enqueue(this._buffered);
                this._buffered = null;
            }
            return gram;
        }

        public void Clear()
        {
            if (this._buffered != null)
            {
                this._buffered.Release();
                this._buffered = null;
            }
            while (this._pending.Count > 0)
            {
                if (World.JlMsg == 1)
                {
                    Form1.WriteLine(0, "Clear");
                }
                this._pending.Dequeue().Release();
            }
        }

        public Gram Dequeue()
        {
            Gram gram = null;
            if (this._pending.Count > 0)
            {
                this._pending.Dequeue().Release();
                if (this._pending.Count > 0)
                {
                    gram = this._pending.Peek();
                }
            }
            return gram;
        }

        public void Dispose()
        {
            this._pending.Clear();
            this._pending = null;
            this._buffered = null;
        }

        public Gram Enqueue(byte[] buffer, int length)
        {
            return this.Enqueue(buffer, 0, length);
        }

        public Gram Enqueue(byte[] buffer, int offset, int length)
        {
            if (buffer == null)
            {
                throw new ArgumentNullException("buffer");
            }
            if ((offset < 0) || (offset >= buffer.Length))
            {
                throw new ArgumentOutOfRangeException("offset", offset, "Offset must be greater than or equal to zero and less than the size of the buffer.");
            }
            if ((length < 0) || (length > buffer.Length))
            {
                throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero or greater than the size of the buffer.");
            }
            if ((buffer.Length - offset) < length)
            {
                throw new ArgumentException("Offset and length do not point to a valid segment within the buffer.");
            }
            int num2 = (this._pending.Count * m_CoalesceBufferSize) + ((this._buffered == null) ? 0 : this._buffered.Length);
            if ((num2 + length) > 3072000)
            {
                throw new CapacityExceededException();
            }
            Gram gram = null;
            while (length > 0)
            {
                if (World.JlMsg == 1)
                {
                    //Form1.WriteLine(0, "Enqueue");
                }
                if (this._buffered == null)
                {
                    this._buffered = Gram.Acquire();
                }
                int num = this._buffered.Write(buffer, offset, length);
                offset += num;
                length -= num;
                if (this._buffered.IsFull)
                {
                    if (this._pending.Count == 0)
                    {
                        gram = this._buffered;
                    }
                    this._pending.Enqueue(this._buffered);
                    this._buffered = null;
                }
            }
            return gram;
        }

        public int getpendingCount()
        {
            int num = 0;
            foreach (Gram gram in this._pending)
            {
                num += gram.Length;
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
            if ((buffer != null) && (buffer.Length == m_CoalesceBufferSize))
            {
                m_UnusedBuffers.ReleaseBuffer(buffer);
            }
        }

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

        public int GetpendingConn
        {
            get
            {
                return this._pending.Count;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return ((this._pending.Count == 0) && (this._buffered == null));
            }
        }

        public bool IsFlushReady
        {
            get
            {
                return ((this._pending.Count == 0) && (this._buffered != null));
            }
        }

        public class Gram
        {
            private static Stack<SendQueue.Gram> _pool;
            private byte[] _buffer;
            private int _length;

            static Gram()
            {
                old_acctor_mc();
            }

            private Gram()
            {
            }

            public static SendQueue.Gram Acquire()
            {
                lock (_pool)
                {
                    SendQueue.Gram gram;
                    if (_pool.Count > 0)
                    {
                        gram = _pool.Pop();
                    }
                    else
                    {
                        gram = new SendQueue.Gram();
                    }
                    gram._buffer = SendQueue.AcquireBuffer();
                    gram._length = 0;
                    return gram;
                }
            }

            private static void old_acctor_mc()
            {
                _pool = new Stack<SendQueue.Gram>();
            }

            public void Release()
            {
                lock (_pool)
                {
                    _pool.Push(this);
                    SendQueue.ReleaseBuffer(this._buffer);
                }
            }

            public int Write(byte[] buffer, int offset, int length)
            {
                int count = Math.Min(length, this.Available);
                System.Buffer.BlockCopy(buffer, offset, this._buffer, this._length, count);
                this._length += count;
                return count;
            }

            public int Available
            {
                get
                {
                    return (this._buffer.Length - this._length);
                }
            }

            public byte[] Buffer
            {
                get
                {
                    return this._buffer;
                }
            }

            public bool IsFull
            {
                get
                {
                    return (this._length <= this._buffer.Length);
                }
            }

            public int Length
            {
                get
                {
                    return this._length;
                }
            }
        }
    }
}


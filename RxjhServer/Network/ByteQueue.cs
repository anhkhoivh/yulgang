namespace Network
{
    using System;

    public class ByteQueue : IDisposable
    {
        private int m_Head;
        private int m_Tail;
        private int m_Size;
        public byte[] m_Buffer = new byte[2048];

        public void Clear()
        {
            this.m_Head = 0;
            this.m_Tail = 0;
            this.m_Size = 0;
        }

        public int Dequeue(byte[] buffer, int offset, int size)
        {
            if (size > this.m_Size)
            {
                size = this.m_Size;
            }
            if (size == 0)
            {
                return 0;
            }
            if (this.m_Head < this.m_Tail)
            {
                Buffer.BlockCopy(this.m_Buffer, this.m_Head, buffer, offset, size);
            }
            else
            {
                int count = this.m_Buffer.Length - this.m_Head;
                if (count >= size)
                {
                    Buffer.BlockCopy(this.m_Buffer, this.m_Head, buffer, offset, size);
                }
                else
                {
                    Buffer.BlockCopy(this.m_Buffer, this.m_Head, buffer, offset, count);
                    Buffer.BlockCopy(this.m_Buffer, 0, buffer, offset + count, size - count);
                }
            }
            this.m_Head = (this.m_Head + size) % this.m_Buffer.Length;
            this.m_Size -= size;
            if (this.m_Size == 0)
            {
                this.m_Head = 0;
                this.m_Tail = 0;
            }
            return size;
        }

        public void Dispose()
        {
            this.m_Buffer = null;
        }

        public void Enqueue(byte[] buffer, int offset, int size)
        {
            if ((this.m_Size + size) > this.m_Buffer.Length)
            {
                this.eval_a(((this.m_Size + size) + 2047) & -2048);
            }
            if (this.m_Head < this.m_Tail)
            {
                int count = this.m_Buffer.Length - this.m_Tail;
                if (count >= size)
                {
                    Buffer.BlockCopy(buffer, offset, this.m_Buffer, this.m_Tail, size);
                }
                else
                {
                    Buffer.BlockCopy(buffer, offset, this.m_Buffer, this.m_Tail, count);
                    Buffer.BlockCopy(buffer, offset + count, this.m_Buffer, 0, size - count);
                }
            }
            else
            {
                Buffer.BlockCopy(buffer, offset, this.m_Buffer, this.m_Tail, size);
            }
            this.m_Tail = (this.m_Tail + size) % this.m_Buffer.Length;
            this.m_Size += size;
        }

        private void eval_a(int A_0)
        {
            byte[] dst = new byte[A_0];
            if (this.m_Size > 0)
            {
                if (this.m_Head < this.m_Tail)
                {
                    Buffer.BlockCopy(this.m_Buffer, this.m_Head, dst, 0, this.m_Size);
                }
                else
                {
                    Buffer.BlockCopy(this.m_Buffer, this.m_Head, dst, 0, this.m_Buffer.Length - this.m_Head);
                    Buffer.BlockCopy(this.m_Buffer, 0, dst, this.m_Buffer.Length - this.m_Head, this.m_Tail);
                }
            }
            this.m_Head = 0;
            this.m_Tail = this.m_Size;
            this.m_Buffer = dst;
        }

        public byte[] GetPacketID()
        {
            byte[] dst = new byte[2];
            try
            {
                Buffer.BlockCopy(this.m_Buffer, this.m_Head + 2, dst, 0, 2);
                return dst;
            }
            catch (Exception)
            {
                return dst;
            }
        }

        public byte GetPacketIDd()
        {
            if (this.m_Size >= 1)
            {
                return this.m_Buffer[this.m_Head];
            }
            return 255;
        }

        public int GetPacketLength()
        {
            if (this.m_Size >= 3)
            {
                return ((this.m_Buffer[(this.m_Head + 1) % ((int) this.m_Buffer.Length)] << 8) | this.m_Buffer[(this.m_Head + 2) % this.m_Buffer.Length]);
            }
            return 0;
        }

        public int Length
        {
            get
            {
                return this.m_Size;
            }
        }
    }
}


namespace Network
{
    using System;
    using System.IO;

    public class ByteQueueNew : IDisposable
    {
        private byte[] m_Buffer;
        private int _Capacity = 0;
        private int m_Size = 0;
        private int _Index;

        public ByteQueueNew()
        {
            this.m_Buffer = new byte[this._Capacity];
        }

        public byte[] Dequeue(int count)
        {
            byte[] buffer = new byte[count];
            this.Dequeue(buffer, 0, count);
            return buffer;
        }

        public void Dequeue(byte[] buffer)
        {
            this.Dequeue(buffer, 0, buffer.Length);
        }

        public void Dequeue(byte[] buffer, int offset, int count)
        {
            Buffer.BlockCopy(this.m_Buffer, 0, buffer, offset, count);
            this.m_Size -= count;
            int index = count;
            for (int i = 0; i < this.m_Size; ++i)
            {
                this.m_Buffer[i] = this.m_Buffer[index];
                index++;
            }
            this._Index = 0;
        }

        public void Dispose()
        {
            this.m_Buffer = null;
        }

        public void Enqueue(byte[] buffer)
        {
            this.Enqueue(buffer, 0, buffer.Length);
        }

        public void Enqueue(Stream stream, int count)
        {
            byte[] buffer = new byte[count];
            count = stream.Read(buffer, 0, count);
            this.Enqueue(buffer, 0, count);
        }

        public void Enqueue(byte[] buffer, int offset, int count)
        {
            this.eval_a(this.m_Size + count);
            Buffer.BlockCopy(buffer, offset, this.m_Buffer, this.m_Size, count);
            this.m_Size += count;
        }

        private void eval_a(int A_0)
        {
            if (A_0 > this._Capacity)
            {
                byte[] src = this.m_Buffer;
                this._Capacity = (A_0 + 2047) & -2048;
                this.m_Buffer = new byte[this._Capacity];
                Buffer.BlockCopy(src, 0, this.m_Buffer, 0, this.m_Size);
            }
        }

        public byte[] GetPacket()
        {
            if (this.m_Size < 4)
            {
                return null;
            }
            int num = BitConverter.ToInt32(this.m_Buffer, 0);
            if ((num + 4) > this.m_Size)
            {
                return null;
            }
            byte[] buffer = new byte[num + 4];
            this.Dequeue(buffer);
            return buffer;
        }

        public byte[] Peek(int count)
        {
            byte[] buffer = new byte[count];
            this.Peek(buffer, 0, count);
            return buffer;
        }

        public void Peek(byte[] buffer)
        {
            this.Peek(buffer, 0, buffer.Length);
        }

        public void Peek(byte[] buffer, int offset, int count)
        {
            Buffer.BlockCopy(this.m_Buffer, 0, buffer, offset, count);
        }

        public bool ReadBoolean()
        {
            if ((this._Index + 1) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            return BitConverter.ToBoolean(this.m_Buffer, this._Index++);
        }

        public bool ReadBoolean(ref bool var)
        {
            if ((this._Index + 1) > this.m_Size)
            {
                return false;
            }
            var = BitConverter.ToBoolean(this.m_Buffer, this._Index++);
            return true;
        }

        public double ReadDouble()
        {
            if ((this._Index + 8) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            double num = BitConverter.ToDouble(this.m_Buffer, this._Index);
            this._Index += 8;
            return num;
        }

        public bool ReadDouble(ref double var)
        {
            if ((this._Index + 8) > this.m_Size)
            {
                return false;
            }
            var = BitConverter.ToDouble(this.m_Buffer, this._Index);
            this._Index += 8;
            return true;
        }

        public float Readfloat()
        {
            if ((this._Index + 4) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            float num = BitConverter.ToSingle(this.m_Buffer, this._Index);
            this._Index += 4;
            return num;
        }

        public bool Readfloat(ref float var)
        {
            if ((this._Index + 4) > this.m_Size)
            {
                return false;
            }
            var = BitConverter.ToSingle(this.m_Buffer, this._Index);
            this._Index += 4;
            return true;
        }

        public int ReadInt16()
        {
            if ((this._Index + 2) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            int num = BitConverter.ToInt16(this.m_Buffer, this._Index);
            this._Index += 2;
            return num;
        }

        public bool ReadInt16(ref int var)
        {
            if ((this._Index + 2) > this.m_Size)
            {
                return false;
            }
            var = BitConverter.ToInt16(this.m_Buffer, this._Index);
            this._Index += 2;
            return true;
        }

        public int ReadInt32()
        {
            if ((this._Index + 4) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            int num = BitConverter.ToInt32(this.m_Buffer, this._Index);
            this._Index += 4;
            return num;
        }

        public bool ReadInt32(ref int var)
        {
            if ((this._Index + 4) > this.m_Size)
            {
                return false;
            }
            var = BitConverter.ToInt32(this.m_Buffer, this._Index);
            this._Index += 4;
            return true;
        }

        public int ReadInt8()
        {
            if ((this._Index + 1) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            return this.m_Buffer[this._Index++];
        }

        public bool ReadInt8(ref int var)
        {
            if ((this._Index + 1) > this.m_Size)
            {
                return false;
            }
            var = this.m_Buffer[this._Index++];
            return true;
        }

        public bool ReadString(ref byte[] Msg_)
        {
            if ((this._Index + Msg_.Length) > this.m_Size)
            {
                return false;
            }
            Buffer.BlockCopy(this.m_Buffer, this._Index, Msg_, 0, Msg_.Length);
            this._Index += Msg_.Length;
            return true;
        }

        public byte[] ReadStrings()
        {
            byte[] dst = new byte[this.ReadInt8()];
            if ((this._Index + dst.Length) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            Buffer.BlockCopy(this.m_Buffer, this._Index, dst, 0, dst.Length);
            this._Index += dst.Length;
            return dst;
        }

        public bool ReadStrings(ref byte[] var)
        {
            int num = 0;
            if (!this.ReadInt8(ref num))
            {
                return false;
            }
            byte[] dst = new byte[num];
            if ((this._Index + dst.Length) > this.m_Size)
            {
                return false;
            }
            Buffer.BlockCopy(this.m_Buffer, this._Index, dst, 0, dst.Length);
            this._Index += dst.Length;
            return true;
        }

        public byte[] ReadStringS()
        {
            byte[] dst = new byte[this.ReadInt16()];
            if ((this._Index + dst.Length) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            Buffer.BlockCopy(this.m_Buffer, this._Index, dst, 0, dst.Length);
            this._Index += dst.Length;
            return dst;
        }

        public bool ReadStringS(ref byte[] var)
        {
            int num = 0;
            if (!this.ReadInt16(ref num))
            {
                return false;
            }
            byte[] dst = new byte[num];
            if ((this._Index + dst.Length) > this.m_Size)
            {
                return false;
            }
            Buffer.BlockCopy(this.m_Buffer, this._Index, dst, 0, dst.Length);
            this._Index += dst.Length;
            return true;
        }

        public int Capacity
        {
            get
            {
                return this._Capacity;
            }
        }

        public int Index
        {
            get
            {
                return this._Index;
            }
            set
            {
                this._Index = value;
            }
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


namespace Network
{
    using System;
    using System.IO;
    using System.Text;

    public class PacketReaderNew : IDisposable
    {
        private byte[] m_Data;
        private int m_Size;
        private int m_Index;

        public PacketReaderNew(byte[] data, int size, bool fixedSize)
        {
            this.m_Data = data;
            this.m_Size = size;
            this.m_Index = fixedSize ? 0 : 2;
        }

        public void Dispose()
        {
            this.m_Data = null;
        }

        ~PacketReaderNew()
        {
            this.m_Data = null;
        }

        public byte[] ReadAllByteS()
        {
            if (this.m_Size > this.m_Index)
            {
                byte[] dst = new byte[this.m_Size - this.m_Index];
                System.Buffer.BlockCopy(this.m_Data, this.m_Index, dst, 0, dst.Length);
                return dst;
            }
            return null;
        }

        public bool ReadBoolean()
        {
            if ((this.m_Index + 1) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            return BitConverter.ToBoolean(this.m_Data, this.m_Index++);
        }

        public byte[] ReadBytes()
        {
            byte[] dst = new byte[this.ReadInt16()];
            if ((this.m_Index + dst.Length) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            System.Buffer.BlockCopy(this.m_Data, this.m_Index, dst, 0, dst.Length);
            this.m_Index += dst.Length;
            return dst;
        }

        public byte[] ReadByteS()
        {
            byte[] dst = new byte[this.ReadInt16()];
            if ((this.m_Index + dst.Length) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            System.Buffer.BlockCopy(this.m_Data, this.m_Index, dst, 0, dst.Length);
            this.m_Index += dst.Length;
            return dst;
        }

        public double ReadDouble()
        {
            if ((this.m_Index + 8) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            double num = BitConverter.ToDouble(this.m_Data, this.m_Index);
            this.m_Index += 8;
            return num;
        }

        public float Readfloat()
        {
            if ((this.m_Index + 4) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            float num = BitConverter.ToSingle(this.m_Data, this.m_Index);
            this.m_Index += 4;
            return num;
        }

        public int ReadInt16()
        {
            if ((this.m_Index + 2) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            int num = BitConverter.ToInt16(this.m_Data, this.m_Index);
            this.m_Index += 2;
            return num;
        }

        public int ReadInt32()
        {
            if ((this.m_Index + 4) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            int num = BitConverter.ToInt32(this.m_Data, this.m_Index);
            this.m_Index += 4;
            return num;
        }

        public int ReadInt8()
        {
            if ((this.m_Index + 1) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            return this.m_Data[this.m_Index++];
        }

        public int ReadReverseInt32()
        {
            if ((this.m_Index + 4) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            Array.Reverse(this.m_Data, this.m_Index, 4);
            int num = BitConverter.ToInt32(this.m_Data, this.m_Index);
            this.m_Index += 4;
            return num;
        }

        public string ReadStrings()
        {
            byte[] dst = new byte[this.ReadInt8()];
            if ((this.m_Index + dst.Length) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            System.Buffer.BlockCopy(this.m_Data, this.m_Index, dst, 0, dst.Length);
            this.m_Index += dst.Length;
            return Encoding.Default.GetString(dst);
        }

        public string ReadStringS()
        {
            byte[] dst = new byte[this.ReadInt16()];
            if ((this.m_Index + dst.Length) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            System.Buffer.BlockCopy(this.m_Data, this.m_Index, dst, 0, dst.Length);
            this.m_Index += dst.Length;
            return Encoding.Default.GetString(dst);
        }

        public string ReadStringSS()
        {
            byte[] dst = new byte[this.ReadInt32()];
            if ((this.m_Index + dst.Length) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            System.Buffer.BlockCopy(this.m_Data, this.m_Index, dst, 0, dst.Length);
            this.m_Index += dst.Length;
            return Encoding.Default.GetString(dst);
        }

        public int ReadUInt16()
        {
            if ((this.m_Index + 2) > this.m_Size)
            {
                throw new ByteQueueExceeded();
            }
            int num = BitConverter.ToUInt16(this.m_Data, this.m_Index);
            this.m_Index += 2;
            return num;
        }

        public int Seek(int offset, SeekOrigin origin)
        {
            switch (origin)
            {
                case SeekOrigin.Begin:
                    this.m_Index = offset;
                    break;

                case SeekOrigin.Current:
                    this.m_Index += offset;
                    break;

                case SeekOrigin.End:
                    this.m_Index = this.m_Size - offset;
                    break;
            }
            return this.m_Index;
        }

        public byte[] Buffer
        {
            get
            {
                return this.m_Data;
            }
        }

        public int Size
        {
            get
            {
                return this.m_Size;
            }
        }
    }
}


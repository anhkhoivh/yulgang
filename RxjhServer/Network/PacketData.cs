namespace Network
{
    using System;
    using System.IO;
    using System.Text;

    public class PacketData : IDisposable
    {
        private byte[] m_Buffer;
        private int _InfoType;
        private MemoryStream m_Stream;
        private MemoryStream Z_Stream;

        public PacketData()
        {
            this.m_Buffer = new byte[8];
            this.m_Stream = new MemoryStream();
        }

        public PacketData(int Type)
        {
            this.m_Stream = new MemoryStream();
            this.m_Buffer = new byte[8];
            this.WriteShort(Type);
        }

        public void Dispose()
        {
            this.m_Stream = null;
            this.Z_Stream = null;
        }

        public byte[] ToArray2(int aa, int wordid)
        {
            this.Z_Stream = new MemoryStream();
            this.m_Buffer[0] = (byte) wordid;
            this.m_Buffer[1] = (byte) (wordid >> 8);
            this.Z_Stream.Write(this.m_Buffer, 0, 2);
            this.m_Buffer[0] = (byte) (aa >> 8);
            this.m_Buffer[1] = (byte) aa;
            this.Z_Stream.Write(this.m_Buffer, 0, 2);
            this.m_Buffer[0] = (byte) this.m_Stream.Length;
            this.m_Buffer[1] = (byte) (this.m_Stream.Length >> 8);
            this.Z_Stream.Write(this.m_Buffer, 0, 2);
            this.m_Stream.WriteTo(this.Z_Stream);
            return this.Z_Stream.ToArray();
        }

        public byte[] ToArray3()
        {
            return this.m_Stream.ToArray();
        }

        public byte[] ToPacket(int id, int wordid, byte byte_1)
        {
            this.Z_Stream = new MemoryStream();
            this.Z_Stream.WriteByte((byte)170);
            this.Z_Stream.WriteByte((byte)85);
            this.m_Buffer[0] = (byte)((ulong)this.m_Stream.Length + 15UL);
            this.m_Buffer[1] = (byte)(this.m_Stream.Length + 15L >> 8);
            this.Z_Stream.Write(this.m_Buffer, 0, 2);
            this.Z_Stream.WriteByte(byte_1);
            this.m_Buffer[0] = (byte)wordid;
            this.m_Buffer[1] = (byte)(wordid >> 8);
            this.Z_Stream.Write(this.m_Buffer, 0, 2);
            this.m_Buffer[0] = (byte)(id >> 8);
            this.m_Buffer[1] = (byte)id;
            this.Z_Stream.Write(this.m_Buffer, 0, 2);
            this.m_Buffer[0] = (byte)this.m_Stream.Length;
            this.m_Buffer[1] = (byte)(this.m_Stream.Length >> 8);
            this.Z_Stream.Write(this.m_Buffer, 0, 2);
            this.m_Stream.WriteTo((Stream)this.Z_Stream);
            this.Z_Stream.Write(new byte[8], 0, 8);
            this.m_Stream.WriteTo((Stream)this.Z_Stream);
            this.Z_Stream.WriteByte((byte)85);
            this.Z_Stream.WriteByte((byte)170);
            return this.Z_Stream.ToArray();
        }

        public byte[] ToArrayPack()
        {
            this.Z_Stream = new MemoryStream();
            this.m_Stream.ToArray();
            byte[] buffer = new RzConnect.SymmetricMethod().Encrypto(this.m_Stream.ToArray());
            this.Z_Stream.Write(BitConverter.GetBytes(buffer.Length), 0, 4);
            this.Z_Stream.Write(buffer, 0, buffer.Length);
            return this.Z_Stream.ToArray();
        }

        public void WriteByte(int value)
        {
            this.m_Stream.WriteByte((byte) (value & 255));
        }

        public void WriteFloat(float value)
        {
            this.m_Buffer = BitConverter.GetBytes(value);
            this.m_Stream.Write(this.m_Buffer, 0, 4);
        }

        public void WriteByteArray(byte[] value)
        {
            this.m_Stream.Write(value, 0, value.Length);
        }

        public void Write(byte[] buffer, int offset, int size)
        {
            this.m_Stream.Write(buffer, offset, size);
        }

        public void WriteShort(int value)
        {
            this.m_Buffer[0] = (byte) value;
            this.m_Buffer[1] = (byte) (value >> 8);
            this.m_Stream.Write(this.m_Buffer, 0, 2);
        }

        public void WriteInt(int value)
        {
            this.m_Buffer[0] = (byte) value;
            this.m_Buffer[1] = (byte) (value >> 8);
            this.m_Buffer[2] = (byte) (value >> 16);
            this.m_Buffer[3] = (byte) (value >> 24);
            this.m_Stream.Write(this.m_Buffer, 0, 4);
        }

        public void WriteInt(uint value)
        {
            this.m_Buffer[0] = (byte) value;
            this.m_Buffer[1] = (byte) (value >> 8);
            this.m_Buffer[2] = (byte) (value >> 16);
            this.m_Buffer[3] = (byte) (value >> 24);
            this.m_Stream.Write(this.m_Buffer, 0, 4);
        }

        public void WriteLong(long value)
        {
            this.m_Buffer[0] = (byte) value;
            this.m_Buffer[1] = (byte) (value >> 8);
            this.m_Buffer[2] = (byte) (value >> 16);
            this.m_Buffer[3] = (byte) (value >> 24);
            this.m_Buffer[4] = (byte) (value >> 32);
            this.m_Buffer[5] = (byte) (value >> 40);
            this.m_Buffer[6] = (byte) (value >> 48);
            this.m_Buffer[7] = (byte) (value >> 56);
            this.m_Stream.Write(this.m_Buffer, 0, 8);
        }

        public void WriteAsciiFixed(string value)
        {
            if (value == null)
            {
                Console.WriteLine("Network: Attempted to WriteAsciiFixed() with null value");
                value = string.Empty;
            }
            byte[] bytes = Encoding.Default.GetBytes(value);
            this.WriteShort((byte) bytes.Length);
            this.m_Stream.Write(bytes, 0, bytes.Length);
        }

        public void WriteString(string value)
        {
            if (value == null)
            {
                value = string.Empty;
            }
            byte[] bytes = Encoding.Default.GetBytes(value);
            byte[] dst = new byte[15];
            if (bytes.Length <= 15)
            {
                Buffer.BlockCopy(bytes, 0, dst, 0, bytes.Length);
            }
            else
            {
                Buffer.BlockCopy(bytes, 0, dst, 0, 15);
            }
            this.m_Stream.Write(dst, 0, dst.Length);
        }

        public void Writes(string value)
        {
            if (value == null)
            {
                value = string.Empty;
            }
            byte[] bytes = Encoding.Default.GetBytes(value);
            this.WriteByte(bytes.Length);
            this.m_Stream.Write(bytes, 0, bytes.Length);
        }

        public void WriteS(string value)
        {
            if (value == null)
            {
                value = string.Empty;
            }
            byte[] bytes = Encoding.Default.GetBytes(value);
            this.WriteShort(bytes.Length);
            this.m_Stream.Write(bytes, 0, bytes.Length);
        }

        public void WriteSS(string value)
        {
            if (value == null)
            {
                value = string.Empty;
            }
            byte[] bytes = Encoding.Default.GetBytes(value);
            this.WriteInt(bytes.Length);
            this.m_Stream.Write(bytes, 0, bytes.Length);
        }

        public void WriteString(string value, int 数量)
        {
            if (value == null)
            {
                Console.WriteLine("Network: Attempted to WriteAsciiFixed() with null value");
                value = string.Empty;
            }
            byte[] dst = new byte[数量];
            byte[] bytes = Encoding.Default.GetBytes(value);
            Buffer.BlockCopy(bytes, 0, dst, 0, bytes.Length);
            this.m_Stream.Write(dst, 0, dst.Length);
        }

        public int InfoType
        {
            get
            {
                return this._InfoType;
            }
            set
            {
                this._InfoType = value;
            }
        }

        public int Length
        {
            get
            {
                return (int) (this.m_Stream.Length + 6L);
            }
        }
    }
}


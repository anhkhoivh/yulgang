namespace Network
{
    using RxjhServer;
    using System;
    using System.IO;
    using System.Text;

    public class PacketReader
    {
        private byte[] m_Data;
        private int _Size;
        private int m_Index;

        public PacketReader(byte[] data, int size, bool fixedSize)
        {
            this.m_Data = data;
            this._Size = size;
            this.m_Index = fixedSize ? 1 : 3;
        }

        public bool IsSafeChar(int c)
        {
            return ((c >= 32) && (c < 65534));
        }

        public bool ReadBoolean()
        {
            if ((this.m_Index + 1) > this._Size)
            {
                return false;
            }
            return (this.m_Data[this.m_Index++] != 0);
        }

        public byte ReadByte()
        {
            if ((this.m_Index + 1) > this._Size)
            {
                return 0;
            }
            return this.m_Data[this.m_Index++];
        }

        public float Readfloat()
        {
            if ((this.m_Index + 4) > this._Size)
            {
                return 0f;
            }
            float num = BitConverter.ToSingle(this.m_Data, this.m_Index);
            this.m_Index += 4;
            return num;
        }

        public int ReadInt16()
        {
            if ((this.m_Index + 2) > this._Size)
            {
                return 0;
            }
            return (this.m_Data[this.m_Index++] | (this.m_Data[this.m_Index++] << 8));
        }

        public int ReadInt32()
        {
            if ((this.m_Index + 4) > this._Size)
            {
                return 0;
            }
            return (((this.m_Data[this.m_Index++] | (this.m_Data[this.m_Index++] << 8)) | (this.m_Data[this.m_Index++] << 16)) | (this.m_Data[this.m_Index++] << 24));
        }

        public int ReadInt8()
        {
            if ((this.m_Index + 1) > this._Size)
            {
                return 0;
            }
            return this.m_Data[this.m_Index++];
        }

        public sbyte ReadSByte()
        {
            if ((this.m_Index + 1) > this._Size)
            {
                return 0;
            }
            return (sbyte) this.m_Data[this.m_Index++];
        }

        public string ReadString()
        {
            StringBuilder builder = new StringBuilder();
            while (this.m_Index < this._Size)
            {
                int num2 = this.m_Data[this.m_Index++];
                if (num2 == 0)
                {
                    break;
                }
                builder.Append((char) num2);
            }
            return builder.ToString();
        }

        public string ReadString(int fixedLength)
        {
            int num = this.m_Index + fixedLength;
            int num2 = num;
            if (num > this._Size)
            {
                num = this._Size;
            }
            StringBuilder builder = new StringBuilder();
            while (this.m_Index < num)
            {
                int num4 = this.m_Data[this.m_Index++];
                if (num4 == 0)
                {
                    break;
                }
                builder.Append((char) num4);
            }
            this.m_Index = num2;
            return builder.ToString();
        }

        public string ReadStringSafe()
        {
            StringBuilder builder = new StringBuilder();
            while (this.m_Index < this._Size)
            {
                int c = this.m_Data[this.m_Index++];
                if (c == 0)
                {
                    break;
                }
                if (this.IsSafeChar(c))
                {
                    builder.Append((char) c);
                }
            }
            return builder.ToString();
        }

        public string ReadStringSafe(int fixedLength)
        {
            int num = this.m_Index + fixedLength;
            int num2 = num;
            if (num > this._Size)
            {
                num = this._Size;
            }
            StringBuilder builder = new StringBuilder();
            while (this.m_Index < num)
            {
                int c = this.m_Data[this.m_Index++];
                if (c == 0)
                {
                    break;
                }
                if (this.IsSafeChar(c))
                {
                    builder.Append((char) c);
                }
            }
            this.m_Index = num2;
            return builder.ToString();
        }

        public ushort ReadUInt16()
        {
            if ((this.m_Index + 2) > this._Size)
            {
                return 0;
            }
            return (ushort) (this.m_Data[this.m_Index++] | (this.m_Data[this.m_Index++] << 8));
        }

        public uint ReadUInt32()
        {
            if ((this.m_Index + 4) > this._Size)
            {
                return 0;
            }
            return (uint) (((this.m_Data[this.m_Index++] | (this.m_Data[this.m_Index++] << 8)) | (this.m_Data[this.m_Index++] << 16)) | (this.m_Data[this.m_Index++] << 24));
        }

        public string ReadUnicodeString()
        {
            StringBuilder builder = new StringBuilder();
            while ((this.m_Index + 1) < this._Size)
            {
                int num3 = (this.m_Data[this.m_Index++] << 8) | this.m_Data[this.m_Index++];
                if (num3 == 0)
                {
                    break;
                }
                builder.Append((char) num3);
            }
            return builder.ToString();
        }

        public string ReadUnicodeString(int fixedLength)
        {
            int num = this.m_Index + (fixedLength << 1);
            int num2 = num;
            if (num > this._Size)
            {
                num = this._Size;
            }
            StringBuilder builder = new StringBuilder();
            while ((this.m_Index + 1) < num)
            {
                int num5 = (this.m_Data[this.m_Index++] << 8) | this.m_Data[this.m_Index++];
                if (num5 == 0)
                {
                    break;
                }
                builder.Append((char) num5);
            }
            this.m_Index = num2;
            return builder.ToString();
        }

        public string ReadUnicodeStringLE()
        {
            StringBuilder builder = new StringBuilder();
            while ((this.m_Index + 1) < this._Size)
            {
                int num3 = this.m_Data[this.m_Index++] | (this.m_Data[this.m_Index++] << 8);
                if (num3 == 0)
                {
                    break;
                }
                builder.Append((char) num3);
            }
            return builder.ToString();
        }

        public string ReadUnicodeStringLESafe()
        {
            StringBuilder builder = new StringBuilder();
            while ((this.m_Index + 1) < this._Size)
            {
                int c = this.m_Data[this.m_Index++] | (this.m_Data[this.m_Index++] << 8);
                if (c == 0)
                {
                    break;
                }
                if (this.IsSafeChar(c))
                {
                    builder.Append((char) c);
                }
            }
            return builder.ToString();
        }

        public string ReadUnicodeStringLESafe(int fixedLength)
        {
            int num = this.m_Index + (fixedLength << 1);
            int num2 = num;
            if (num > this._Size)
            {
                num = this._Size;
            }
            StringBuilder builder = new StringBuilder();
            while ((this.m_Index + 1) < num)
            {
                int c = this.m_Data[this.m_Index++] | (this.m_Data[this.m_Index++] << 8);
                if (c == 0)
                {
                    break;
                }
                if (this.IsSafeChar(c))
                {
                    builder.Append((char) c);
                }
            }
            this.m_Index = num2;
            return builder.ToString();
        }

        public string ReadUnicodeStringSafe()
        {
            StringBuilder builder = new StringBuilder();
            while ((this.m_Index + 1) < this._Size)
            {
                int c = (this.m_Data[this.m_Index++] << 8) | this.m_Data[this.m_Index++];
                if (c == 0)
                {
                    break;
                }
                if (this.IsSafeChar(c))
                {
                    builder.Append((char) c);
                }
            }
            return builder.ToString();
        }

        public string ReadUnicodeStringSafe(int fixedLength)
        {
            int num = this.m_Index + (fixedLength << 1);
            int num2 = num;
            if (num > this._Size)
            {
                num = this._Size;
            }
            StringBuilder builder = new StringBuilder();
            while ((this.m_Index + 1) < num)
            {
                int c = (this.m_Data[this.m_Index++] << 8) | this.m_Data[this.m_Index++];
                if (c == 0)
                {
                    break;
                }
                if (this.IsSafeChar(c))
                {
                    builder.Append((char) c);
                }
            }
            this.m_Index = num2;
            return builder.ToString();
        }

        public string ReadUTF8String()
        {
            if (this.m_Index >= this._Size)
            {
                return string.Empty;
            }
            int num3 = 0;
            int num = this.m_Index;
            while (num < this._Size)
            {
                if (this.m_Data[num++] == 0)
                {
                    break;
                }
                num3++;
            }
            num = 0;
            byte[] bytes = new byte[num3];
            int num2 = 0;
            while (this.m_Index < this._Size)
            {
                num2 = this.m_Data[this.m_Index++];
                if (num2 == 0)
                {
                    break;
                }
                bytes[num++] = (byte) num2;
            }
            return Utility.UTF8.GetString(bytes);
        }

        public string ReadUTF8StringSafe()
        {
            if (this.m_Index >= this._Size)
            {
                return string.Empty;
            }
            int num4 = 0;
            int num2 = this.m_Index;
            while (num2 < this._Size)
            {
                if (this.m_Data[num2++] == 0)
                {
                    break;
                }
                num4++;
            }
            num2 = 0;
            byte[] bytes = new byte[num4];
            int num6 = 0;
            while (this.m_Index < this._Size)
            {
                num6 = this.m_Data[this.m_Index++];
                if (num6 == 0)
                {
                    break;
                }
                bytes[num2++] = (byte) num6;
            }
            string str = Utility.UTF8.GetString(bytes);
            bool flag = true;
            for (int i = 0; flag; ++i)
            {
                if (i >= str.Length)
                {
                    break;
                }
                flag = this.IsSafeChar(str[i]);
            }
            if (flag)
            {
                return str;
            }
            StringBuilder builder = new StringBuilder(str.Length);
            for (int j = 0; j < str.Length; ++j)
            {
                if (this.IsSafeChar(str[j]))
                {
                    builder.Append(str[j]);
                }
            }
            return builder.ToString();
        }

        public string ReadUTF8StringSafe(int fixedLength)
        {
            if (this.m_Index >= this._Size)
            {
                this.m_Index += fixedLength;
                return string.Empty;
            }
            int num6 = this.m_Index + fixedLength;
            if (num6 > this._Size)
            {
                num6 = this._Size;
            }
            int num3 = 0;
            int num5 = this.m_Index;
            int num = this.m_Index;
            while (num5 < num6)
            {
                if (this.m_Data[num5++] == 0)
                {
                    break;
                }
                num3++;
            }
            num5 = 0;
            byte[] bytes = new byte[num3];
            int num7 = 0;
            while (this.m_Index < num6)
            {
                num7 = this.m_Data[this.m_Index++];
                if (num7 == 0)
                {
                    break;
                }
                bytes[num5++] = (byte) num7;
            }
            string str = Utility.UTF8.GetString(bytes);
            bool flag = true;
            for (int i = 0; flag; ++i)
            {
                if (i >= str.Length)
                {
                    break;
                }
                flag = this.IsSafeChar(str[i]);
            }
            this.m_Index = num + fixedLength;
            if (flag)
            {
                return str;
            }
            StringBuilder builder = new StringBuilder(str.Length);
            for (int j = 0; j < str.Length; ++j)
            {
                if (this.IsSafeChar(str[j]))
                {
                    builder.Append(str[j]);
                }
            }
            return builder.ToString();
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
                    this.m_Index = this._Size - offset;
                    break;
            }
            return this.m_Index;
        }

        public void Trace(NetState state)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Packets.log", true))
                {
                    byte[] buffer = this.m_Data;
                    if (buffer.Length > 0)
                    {
                        writer.WriteLine("Client: {0}: Unhandled 包ID 0x{1:X2}{2:X2} 包长{3} 时间{4}", new object[] { state, buffer[8], buffer[7], buffer.Length, DateTime.Now });
                    }
                    using (MemoryStream stream = new MemoryStream(buffer))
                    {
                        Utility.FormatBuffer(writer, stream, buffer.Length);
                    }
                    writer.WriteLine();
                    writer.WriteLine();
                }
            }
            catch
            {
            }
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
                return this._Size;
            }
        }
    }
}


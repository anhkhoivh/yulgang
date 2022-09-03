using System;
using System.IO;
using System.Text;

namespace Network
{
	public class PacketData : IDisposable
	{
		private byte[] m_Buffer;

		private int _InfoType;

		private MemoryStream m_Stream;

		private MemoryStream Z_Stream;

		public int InfoType
		{
			get
			{
				return _InfoType;
			}
			set
			{
				_InfoType = value;
			}
		}

		public int Length => (int)(m_Stream.Length + 6);

		public PacketData()
		{
			m_Buffer = new byte[8];
			m_Stream = new MemoryStream();
		}

		public PacketData(int Type)
		{
			m_Stream = new MemoryStream();
			m_Buffer = new byte[8];
			WriteShort(Type);
		}

		public void Dispose()
		{
			m_Stream = null;
			Z_Stream = null;
		}

		public byte[] ToArray2(int aa, int wordid)
		{
			Z_Stream = new MemoryStream();
			m_Buffer[0] = (byte)wordid;
			m_Buffer[1] = (byte)(wordid >> 8);
			Z_Stream.Write(m_Buffer, 0, 2);
			m_Buffer[0] = (byte)(aa >> 8);
			m_Buffer[1] = (byte)aa;
			Z_Stream.Write(m_Buffer, 0, 2);
			m_Buffer[0] = (byte)m_Stream.Length;
			m_Buffer[1] = (byte)(m_Stream.Length >> 8);
			Z_Stream.Write(m_Buffer, 0, 2);
			m_Stream.WriteTo(Z_Stream);
			return Z_Stream.ToArray();
		}

		public byte[] ToArray3()
		{
			return m_Stream.ToArray();
		}

		public byte[] ToPacket(int id, int wordid, byte byte_1)
		{
			Z_Stream = new MemoryStream();
			Z_Stream.WriteByte(170);
			Z_Stream.WriteByte(85);
			m_Buffer[0] = (byte)(m_Stream.Length + 15);
			m_Buffer[1] = (byte)(m_Stream.Length + 15 >> 8);
			Z_Stream.Write(m_Buffer, 0, 2);
			Z_Stream.WriteByte(byte_1);
			m_Buffer[0] = (byte)wordid;
			m_Buffer[1] = (byte)(wordid >> 8);
			Z_Stream.Write(m_Buffer, 0, 2);
			m_Buffer[0] = (byte)(id >> 8);
			m_Buffer[1] = (byte)id;
			Z_Stream.Write(m_Buffer, 0, 2);
			m_Buffer[0] = (byte)m_Stream.Length;
			m_Buffer[1] = (byte)(m_Stream.Length >> 8);
			Z_Stream.Write(m_Buffer, 0, 2);
			m_Stream.WriteTo(Z_Stream);
			Z_Stream.Write(new byte[8], 0, 8);
			m_Stream.WriteTo(Z_Stream);
			Z_Stream.WriteByte(85);
			Z_Stream.WriteByte(170);
			return Z_Stream.ToArray();
		}

		public byte[] ToArrayPack()
		{
			Z_Stream = new MemoryStream();
			m_Stream.ToArray();
			byte[] array = new RzConnect.SymmetricMethod().Encrypto(m_Stream.ToArray());
			Z_Stream.Write(BitConverter.GetBytes(array.Length), 0, 4);
			Z_Stream.Write(array, 0, array.Length);
			return Z_Stream.ToArray();
		}

		public void WriteByte(int value, int loop = 1)
		{
			m_Stream.WriteByte((byte)(value & 0xFF));
			if (loop > 1)
			{
				WriteByte(value, loop - 1);
			}
		}

		public void WriteFloat(float value, int loop = 1)
		{
			m_Buffer = BitConverter.GetBytes(value);
			m_Stream.Write(m_Buffer, 0, 4);
			if (loop > 1)
			{
				WriteFloat(value, loop - 1);
			}
		}

		public void WriteByteArray(byte[] value)
		{
			m_Stream.Write(value, 0, value.Length);
		}

		public void Write(byte[] buffer, int offset, int size)
		{
			m_Stream.Write(buffer, offset, size);
		}

		public void WriteShort(int value, int loop = 1)
		{
			m_Buffer[0] = (byte)value;
			m_Buffer[1] = (byte)(value >> 8);
			m_Stream.Write(m_Buffer, 0, 2);
			if (loop > 1)
			{
				WriteShort(value, loop - 1);
			}
		}

		public void WriteInt(int value, int loop = 1)
		{
			m_Buffer[0] = (byte)value;
			m_Buffer[1] = (byte)(value >> 8);
			m_Buffer[2] = (byte)(value >> 16);
			m_Buffer[3] = (byte)(value >> 24);
			m_Stream.Write(m_Buffer, 0, 4);
			if (loop > 1)
			{
				WriteInt(value, loop - 1);
			}
		}

		public void WriteInt(uint value, int loop = 1)
		{
			m_Buffer[0] = (byte)value;
			m_Buffer[1] = (byte)(value >> 8);
			m_Buffer[2] = (byte)(value >> 16);
			m_Buffer[3] = (byte)(value >> 24);
			m_Stream.Write(m_Buffer, 0, 4);
			if (loop > 1)
			{
				WriteInt(value, loop - 1);
			}
		}

		public void WriteLong(long value, int loop = 1)
		{
			m_Buffer[0] = (byte)value;
			m_Buffer[1] = (byte)(value >> 8);
			m_Buffer[2] = (byte)(value >> 16);
			m_Buffer[3] = (byte)(value >> 24);
			m_Buffer[4] = (byte)(value >> 32);
			m_Buffer[5] = (byte)(value >> 40);
			m_Buffer[6] = (byte)(value >> 48);
			m_Buffer[7] = (byte)(value >> 56);
			m_Stream.Write(m_Buffer, 0, 8);
			if (loop > 1)
			{
				WriteLong(value, loop - 1);
			}
		}

		public void WriteAsciiFixed(string value)
		{
			if (value == null)
			{
				Console.WriteLine("Network: Attempted to WriteAsciiFixed() with null value");
				value = string.Empty;
			}
			byte[] bytes = Encoding.GetEncoding(1252).GetBytes(value);
			WriteShort((byte)bytes.Length);
			m_Stream.Write(bytes, 0, bytes.Length);
		}

		public void WriteString(string value)
		{
			if (value == null)
			{
				value = string.Empty;
			}
			byte[] bytes = Encoding.GetEncoding(1252).GetBytes(value);
			byte[] array = new byte[15];
			if (value == null || value == "" || value.Length == 0)
			{
				byte[] src = new byte[1];
				Buffer.BlockCopy(src, 0, array, 0, 1);
			}
			else if (bytes.Length <= 15)
			{
				Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length);
			}
			else
			{
				Buffer.BlockCopy(bytes, 0, array, 0, 15);
			}
			m_Stream.Write(array, 0, array.Length);
		}

		public void Writes(string value)
		{
			if (value == null)
			{
				value = string.Empty;
			}
			byte[] bytes = Encoding.GetEncoding(1252).GetBytes(value);
			WriteByte(bytes.Length);
			m_Stream.Write(bytes, 0, bytes.Length);
		}

		public void WriteS(string value)
		{
			if (value == null)
			{
				value = string.Empty;
			}
			byte[] bytes = Encoding.GetEncoding(1252).GetBytes(value);
			WriteShort(bytes.Length);
			m_Stream.Write(bytes, 0, bytes.Length);
		}

		public void WriteSS(string value)
		{
			if (value == null)
			{
				value = string.Empty;
			}
			byte[] bytes = Encoding.GetEncoding(1252).GetBytes(value);
			WriteInt(bytes.Length);
			m_Stream.Write(bytes, 0, bytes.Length);
		}

		public void WriteString(string value, int 数量)
		{
			if (value == null)
			{
				Console.WriteLine("Network: Attempted to WriteAsciiFixed() with null value");
				value = string.Empty;
			}
			byte[] array = new byte[数量];
			byte[] bytes = Encoding.GetEncoding(1252).GetBytes(value);
			Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length);
			m_Stream.Write(array, 0, array.Length);
		}
	}
}

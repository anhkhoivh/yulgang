using System;
using System.IO;
using System.Text;

namespace Network
{
	public class PacketReaderNew : IDisposable
	{
		private byte[] m_Data;

		private int m_Size;

		private int m_Index;

		public byte[] Buffer => m_Data;

		public int Size => m_Size;

		public PacketReaderNew(byte[] data, int size, bool fixedSize)
		{
			m_Data = data;
			m_Size = size;
			m_Index = ((!fixedSize) ? 2 : 0);
		}

		public void Dispose()
		{
			m_Data = null;
		}

		~PacketReaderNew()
		{
			m_Data = null;
		}

		public byte[] ReadAllByteS()
		{
			if (m_Size > m_Index)
			{
				byte[] array = new byte[m_Size - m_Index];
				System.Buffer.BlockCopy(m_Data, m_Index, array, 0, array.Length);
				return array;
			}
			return null;
		}

		public bool ReadBoolean()
		{
			if (m_Index + 1 > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			return BitConverter.ToBoolean(m_Data, m_Index++);
		}

		public byte[] ReadBytes()
		{
			byte[] array = new byte[ReadInt16()];
			if (m_Index + array.Length > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			System.Buffer.BlockCopy(m_Data, m_Index, array, 0, array.Length);
			m_Index += array.Length;
			return array;
		}

		public byte[] ReadByteS()
		{
			byte[] array = new byte[ReadInt16()];
			if (m_Index + array.Length > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			System.Buffer.BlockCopy(m_Data, m_Index, array, 0, array.Length);
			m_Index += array.Length;
			return array;
		}

		public double ReadDouble()
		{
			if (m_Index + 8 > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			double result = BitConverter.ToDouble(m_Data, m_Index);
			m_Index += 8;
			return result;
		}

		public float Readfloat()
		{
			if (m_Index + 4 > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			float result = BitConverter.ToSingle(m_Data, m_Index);
			m_Index += 4;
			return result;
		}

		public int ReadInt16()
		{
			if (m_Index + 2 > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			int result = BitConverter.ToInt16(m_Data, m_Index);
			m_Index += 2;
			return result;
		}

		public int ReadInt32()
		{
			if (m_Index + 4 > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			int result = BitConverter.ToInt32(m_Data, m_Index);
			m_Index += 4;
			return result;
		}

		public int ReadInt8()
		{
			if (m_Index + 1 > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			return m_Data[m_Index++];
		}

		public int ReadReverseInt32()
		{
			if (m_Index + 4 > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			Array.Reverse(m_Data, m_Index, 4);
			int result = BitConverter.ToInt32(m_Data, m_Index);
			m_Index += 4;
			return result;
		}

		public string ReadStrings()
		{
			byte[] array = new byte[ReadInt8()];
			if (m_Index + array.Length > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			System.Buffer.BlockCopy(m_Data, m_Index, array, 0, array.Length);
			m_Index += array.Length;
			return Encoding.GetEncoding(1252).GetString(array);
		}

		public string ReadStringS()
		{
			byte[] array = new byte[ReadInt16()];
			if (m_Index + array.Length > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			System.Buffer.BlockCopy(m_Data, m_Index, array, 0, array.Length);
			m_Index += array.Length;
			return Encoding.GetEncoding(1252).GetString(array);
		}

		public string ReadStringSS()
		{
			byte[] array = new byte[ReadInt32()];
			if (m_Index + array.Length > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			System.Buffer.BlockCopy(m_Data, m_Index, array, 0, array.Length);
			m_Index += array.Length;
			return Encoding.GetEncoding(1252).GetString(array);
		}

		public int ReadUInt16()
		{
			if (m_Index + 2 > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			int result = BitConverter.ToUInt16(m_Data, m_Index);
			m_Index += 2;
			return result;
		}

		public int Seek(int offset, SeekOrigin origin)
		{
			switch (origin)
			{
			case SeekOrigin.Begin:
				m_Index = offset;
				break;
			case SeekOrigin.Current:
				m_Index += offset;
				break;
			case SeekOrigin.End:
				m_Index = m_Size - offset;
				break;
			}
			return m_Index;
		}
	}
}

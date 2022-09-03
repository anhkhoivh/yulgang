using System;
using System.IO;

namespace Network
{
	public class ByteQueueNew : IDisposable
	{
		private byte[] m_Buffer;

		private int _Capacity = 0;

		private int m_Size = 0;

		private int _Index;

		public int Capacity => _Capacity;

		public int Index
		{
			get
			{
				return _Index;
			}
			set
			{
				_Index = value;
			}
		}

		public int Length => m_Size;

		public ByteQueueNew()
		{
			m_Buffer = new byte[_Capacity];
		}

		public byte[] Dequeue(int count)
		{
			byte[] array = new byte[count];
			Dequeue(array, 0, count);
			return array;
		}

		public void Dequeue(byte[] buffer)
		{
			Dequeue(buffer, 0, buffer.Length);
		}

		public void Dequeue(byte[] buffer, int offset, int count)
		{
			Buffer.BlockCopy(m_Buffer, 0, buffer, offset, count);
			m_Size -= count;
			int num = count;
			for (int i = 0; i < m_Size; i++)
			{
				m_Buffer[i] = m_Buffer[num];
				num++;
			}
			_Index = 0;
		}

		public void Dispose()
		{
			m_Buffer = null;
		}

		public void Enqueue(byte[] buffer)
		{
			Enqueue(buffer, 0, buffer.Length);
		}

		public void Enqueue(Stream stream, int count)
		{
			byte[] buffer = new byte[count];
			count = stream.Read(buffer, 0, count);
			Enqueue(buffer, 0, count);
		}

		public void Enqueue(byte[] buffer, int offset, int count)
		{
			eval_a(m_Size + count);
			Buffer.BlockCopy(buffer, offset, m_Buffer, m_Size, count);
			m_Size += count;
		}

		private void eval_a(int A_0)
		{
			if (A_0 > _Capacity)
			{
				byte[] buffer = m_Buffer;
				_Capacity = ((A_0 + 2047) & -2048);
				m_Buffer = new byte[_Capacity];
				Buffer.BlockCopy(buffer, 0, m_Buffer, 0, m_Size);
			}
		}

		public byte[] GetPacket()
		{
			if (m_Size < 4)
			{
				return null;
			}
			int num = BitConverter.ToInt32(m_Buffer, 0);
			if (num + 4 > m_Size)
			{
				return null;
			}
			byte[] array = new byte[num + 4];
			Dequeue(array);
			return array;
		}

		public byte[] Peek(int count)
		{
			byte[] array = new byte[count];
			Peek(array, 0, count);
			return array;
		}

		public void Peek(byte[] buffer)
		{
			Peek(buffer, 0, buffer.Length);
		}

		public void Peek(byte[] buffer, int offset, int count)
		{
			Buffer.BlockCopy(m_Buffer, 0, buffer, offset, count);
		}

		public bool ReadBoolean()
		{
			if (_Index + 1 > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			return BitConverter.ToBoolean(m_Buffer, _Index++);
		}

		public bool ReadBoolean(ref bool var)
		{
			if (_Index + 1 > m_Size)
			{
				return false;
			}
			var = BitConverter.ToBoolean(m_Buffer, _Index++);
			return true;
		}

		public double ReadDouble()
		{
			if (_Index + 8 > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			double result = BitConverter.ToDouble(m_Buffer, _Index);
			_Index += 8;
			return result;
		}

		public bool ReadDouble(ref double var)
		{
			if (_Index + 8 > m_Size)
			{
				return false;
			}
			var = BitConverter.ToDouble(m_Buffer, _Index);
			_Index += 8;
			return true;
		}

		public float Readfloat()
		{
			if (_Index + 4 > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			float result = BitConverter.ToSingle(m_Buffer, _Index);
			_Index += 4;
			return result;
		}

		public bool Readfloat(ref float var)
		{
			if (_Index + 4 > m_Size)
			{
				return false;
			}
			var = BitConverter.ToSingle(m_Buffer, _Index);
			_Index += 4;
			return true;
		}

		public int ReadInt16()
		{
			if (_Index + 2 > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			int result = BitConverter.ToInt16(m_Buffer, _Index);
			_Index += 2;
			return result;
		}

		public bool ReadInt16(ref int var)
		{
			if (_Index + 2 > m_Size)
			{
				return false;
			}
			var = BitConverter.ToInt16(m_Buffer, _Index);
			_Index += 2;
			return true;
		}

		public int ReadInt32()
		{
			if (_Index + 4 > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			int result = BitConverter.ToInt32(m_Buffer, _Index);
			_Index += 4;
			return result;
		}

		public bool ReadInt32(ref int var)
		{
			if (_Index + 4 > m_Size)
			{
				return false;
			}
			var = BitConverter.ToInt32(m_Buffer, _Index);
			_Index += 4;
			return true;
		}

		public int ReadInt8()
		{
			if (_Index + 1 > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			return m_Buffer[_Index++];
		}

		public bool ReadInt8(ref int var)
		{
			if (_Index + 1 > m_Size)
			{
				return false;
			}
			var = m_Buffer[_Index++];
			return true;
		}

		public bool ReadString(ref byte[] Msg_)
		{
			if (_Index + Msg_.Length > m_Size)
			{
				return false;
			}
			Buffer.BlockCopy(m_Buffer, _Index, Msg_, 0, Msg_.Length);
			_Index += Msg_.Length;
			return true;
		}

		public byte[] ReadStrings()
		{
			byte[] array = new byte[ReadInt8()];
			if (_Index + array.Length > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			Buffer.BlockCopy(m_Buffer, _Index, array, 0, array.Length);
			_Index += array.Length;
			return array;
		}

		public bool ReadStrings(ref byte[] var)
		{
			int var2 = 0;
			if (!ReadInt8(ref var2))
			{
				return false;
			}
			byte[] array = new byte[var2];
			if (_Index + array.Length > m_Size)
			{
				return false;
			}
			Buffer.BlockCopy(m_Buffer, _Index, array, 0, array.Length);
			_Index += array.Length;
			return true;
		}

		public byte[] ReadStringS()
		{
			byte[] array = new byte[ReadInt16()];
			if (_Index + array.Length > m_Size)
			{
				throw new ByteQueueExceeded();
			}
			Buffer.BlockCopy(m_Buffer, _Index, array, 0, array.Length);
			_Index += array.Length;
			return array;
		}

		public bool ReadStringS(ref byte[] var)
		{
			int var2 = 0;
			if (!ReadInt16(ref var2))
			{
				return false;
			}
			byte[] array = new byte[var2];
			if (_Index + array.Length > m_Size)
			{
				return false;
			}
			Buffer.BlockCopy(m_Buffer, _Index, array, 0, array.Length);
			_Index += array.Length;
			return true;
		}
	}
}

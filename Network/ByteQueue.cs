using System;

namespace Network
{
	public class ByteQueue : IDisposable
	{
		private int m_Head;

		private int m_Tail;

		private int m_Size;

		public byte[] m_Buffer = new byte[2048];

		public int Length => m_Size;

		public void Clear()
		{
			m_Head = 0;
			m_Tail = 0;
			m_Size = 0;
		}

		public int Dequeue(byte[] buffer, int offset, int size)
		{
			if (size > m_Size)
			{
				size = m_Size;
			}
			if (size == 0)
			{
				return 0;
			}
			if (m_Head < m_Tail)
			{
				Buffer.BlockCopy(m_Buffer, m_Head, buffer, offset, size);
			}
			else
			{
				int num = m_Buffer.Length - m_Head;
				if (num >= size)
				{
					Buffer.BlockCopy(m_Buffer, m_Head, buffer, offset, size);
				}
				else
				{
					Buffer.BlockCopy(m_Buffer, m_Head, buffer, offset, num);
					Buffer.BlockCopy(m_Buffer, 0, buffer, offset + num, size - num);
				}
			}
			m_Head = (m_Head + size) % m_Buffer.Length;
			m_Size -= size;
			if (m_Size == 0)
			{
				m_Head = 0;
				m_Tail = 0;
			}
			return size;
		}

		public void Dispose()
		{
			m_Buffer = null;
		}

		public void Enqueue(byte[] buffer, int offset, int size)
		{
			if (m_Size + size > m_Buffer.Length)
			{
				eval_a((m_Size + size + 2047) & -2048);
			}
			if (m_Head < m_Tail)
			{
				int num = m_Buffer.Length - m_Tail;
				if (num >= size)
				{
					Buffer.BlockCopy(buffer, offset, m_Buffer, m_Tail, size);
				}
				else
				{
					Buffer.BlockCopy(buffer, offset, m_Buffer, m_Tail, num);
					Buffer.BlockCopy(buffer, offset + num, m_Buffer, 0, size - num);
				}
			}
			else
			{
				Buffer.BlockCopy(buffer, offset, m_Buffer, m_Tail, size);
			}
			m_Tail = (m_Tail + size) % m_Buffer.Length;
			m_Size += size;
		}

		private void eval_a(int A_0)
		{
			byte[] array = new byte[A_0];
			if (m_Size > 0)
			{
				if (m_Head < m_Tail)
				{
					Buffer.BlockCopy(m_Buffer, m_Head, array, 0, m_Size);
				}
				else
				{
					Buffer.BlockCopy(m_Buffer, m_Head, array, 0, m_Buffer.Length - m_Head);
					Buffer.BlockCopy(m_Buffer, 0, array, m_Buffer.Length - m_Head, m_Tail);
				}
			}
			m_Head = 0;
			m_Tail = m_Size;
			m_Buffer = array;
		}

		public byte[] GetPacketID()
		{
			byte[] array = new byte[2];
			try
			{
				Buffer.BlockCopy(m_Buffer, m_Head + 2, array, 0, 2);
				return array;
			}
			catch (Exception)
			{
				return array;
			}
		}

		public byte GetPacketIDd()
		{
			if (m_Size >= 1)
			{
				return m_Buffer[m_Head];
			}
			return byte.MaxValue;
		}

		public int GetPacketLength()
		{
			if (m_Size >= 3)
			{
				return (m_Buffer[(m_Head + 1) % m_Buffer.Length] << 8) | m_Buffer[(m_Head + 2) % m_Buffer.Length];
			}
			return 0;
		}
	}
}

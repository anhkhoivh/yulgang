using RxjhServer;
using System;
using System.IO;
using System.Text;

namespace Network
{
	public class PacketReader
	{
		private byte[] m_Data;

		private int _Size;

		private int m_Index;

		public byte[] Buffer => m_Data;

		public int Size => _Size;

		public PacketReader(byte[] data, int size, bool fixedSize)
		{
			m_Data = data;
			_Size = size;
			m_Index = (fixedSize ? 1 : 3);
		}

		public bool IsSafeChar(int c)
		{
			return c >= 32 && c < 65534;
		}

		public bool ReadBoolean()
		{
			if (m_Index + 1 > _Size)
			{
				return false;
			}
			return m_Data[m_Index++] != 0;
		}

		public byte ReadByte()
		{
			if (m_Index + 1 > _Size)
			{
				return 0;
			}
			return m_Data[m_Index++];
		}

		public float Readfloat()
		{
			if (m_Index + 4 > _Size)
			{
				return 0f;
			}
			float result = BitConverter.ToSingle(m_Data, m_Index);
			m_Index += 4;
			return result;
		}

		public int ReadInt16()
		{
			if (m_Index + 2 > _Size)
			{
				return 0;
			}
			return m_Data[m_Index++] | (m_Data[m_Index++] << 8);
		}

		public int ReadInt32()
		{
			if (m_Index + 4 > _Size)
			{
				return 0;
			}
			return m_Data[m_Index++] | (m_Data[m_Index++] << 8) | (m_Data[m_Index++] << 16) | (m_Data[m_Index++] << 24);
		}

		public int ReadInt8()
		{
			if (m_Index + 1 > _Size)
			{
				return 0;
			}
			return m_Data[m_Index++];
		}

		public sbyte ReadSByte()
		{
			if (m_Index + 1 > _Size)
			{
				return 0;
			}
			return (sbyte)m_Data[m_Index++];
		}

		public string ReadString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			while (m_Index < _Size)
			{
				int num = m_Data[m_Index++];
				if (num == 0)
				{
					break;
				}
				stringBuilder.Append((char)num);
			}
			return stringBuilder.ToString();
		}

		public string ReadString(int fixedLength)
		{
			int num = m_Index + fixedLength;
			int index = num;
			if (num > _Size)
			{
				num = _Size;
			}
			StringBuilder stringBuilder = new StringBuilder();
			while (m_Index < num)
			{
				int num2 = m_Data[m_Index++];
				if (num2 == 0)
				{
					break;
				}
				stringBuilder.Append((char)num2);
			}
			m_Index = index;
			return stringBuilder.ToString();
		}

		public string ReadStringSafe()
		{
			StringBuilder stringBuilder = new StringBuilder();
			while (m_Index < _Size)
			{
				int num = m_Data[m_Index++];
				if (num == 0)
				{
					break;
				}
				if (IsSafeChar(num))
				{
					stringBuilder.Append((char)num);
				}
			}
			return stringBuilder.ToString();
		}

		public string ReadStringSafe(int fixedLength)
		{
			int num = m_Index + fixedLength;
			int index = num;
			if (num > _Size)
			{
				num = _Size;
			}
			StringBuilder stringBuilder = new StringBuilder();
			while (m_Index < num)
			{
				int num2 = m_Data[m_Index++];
				if (num2 == 0)
				{
					break;
				}
				if (IsSafeChar(num2))
				{
					stringBuilder.Append((char)num2);
				}
			}
			m_Index = index;
			return stringBuilder.ToString();
		}

		public ushort ReadUInt16()
		{
			if (m_Index + 2 > _Size)
			{
				return 0;
			}
			return (ushort)(m_Data[m_Index++] | (m_Data[m_Index++] << 8));
		}

		public uint ReadUInt32()
		{
			if (m_Index + 4 > _Size)
			{
				return 0u;
			}
			return (uint)(m_Data[m_Index++] | (m_Data[m_Index++] << 8) | (m_Data[m_Index++] << 16) | (m_Data[m_Index++] << 24));
		}

		public string ReadUnicodeString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			while (m_Index + 1 < _Size)
			{
				int num = (m_Data[m_Index++] << 8) | m_Data[m_Index++];
				if (num == 0)
				{
					break;
				}
				stringBuilder.Append((char)num);
			}
			return stringBuilder.ToString();
		}

		public string ReadUnicodeString(int fixedLength)
		{
			int num = m_Index + (fixedLength << 1);
			int index = num;
			if (num > _Size)
			{
				num = _Size;
			}
			StringBuilder stringBuilder = new StringBuilder();
			while (m_Index + 1 < num)
			{
				int num2 = (m_Data[m_Index++] << 8) | m_Data[m_Index++];
				if (num2 == 0)
				{
					break;
				}
				stringBuilder.Append((char)num2);
			}
			m_Index = index;
			return stringBuilder.ToString();
		}

		public string ReadUnicodeStringLE()
		{
			StringBuilder stringBuilder = new StringBuilder();
			while (m_Index + 1 < _Size)
			{
				int num = m_Data[m_Index++] | (m_Data[m_Index++] << 8);
				if (num == 0)
				{
					break;
				}
				stringBuilder.Append((char)num);
			}
			return stringBuilder.ToString();
		}

		public string ReadUnicodeStringLESafe()
		{
			StringBuilder stringBuilder = new StringBuilder();
			while (m_Index + 1 < _Size)
			{
				int num = m_Data[m_Index++] | (m_Data[m_Index++] << 8);
				if (num == 0)
				{
					break;
				}
				if (IsSafeChar(num))
				{
					stringBuilder.Append((char)num);
				}
			}
			return stringBuilder.ToString();
		}

		public string ReadUnicodeStringLESafe(int fixedLength)
		{
			int num = m_Index + (fixedLength << 1);
			int index = num;
			if (num > _Size)
			{
				num = _Size;
			}
			StringBuilder stringBuilder = new StringBuilder();
			while (m_Index + 1 < num)
			{
				int num2 = m_Data[m_Index++] | (m_Data[m_Index++] << 8);
				if (num2 == 0)
				{
					break;
				}
				if (IsSafeChar(num2))
				{
					stringBuilder.Append((char)num2);
				}
			}
			m_Index = index;
			return stringBuilder.ToString();
		}

		public string ReadUnicodeStringSafe()
		{
			StringBuilder stringBuilder = new StringBuilder();
			while (m_Index + 1 < _Size)
			{
				int num = (m_Data[m_Index++] << 8) | m_Data[m_Index++];
				if (num == 0)
				{
					break;
				}
				if (IsSafeChar(num))
				{
					stringBuilder.Append((char)num);
				}
			}
			return stringBuilder.ToString();
		}

		public string ReadUnicodeStringSafe(int fixedLength)
		{
			int num = m_Index + (fixedLength << 1);
			int index = num;
			if (num > _Size)
			{
				num = _Size;
			}
			StringBuilder stringBuilder = new StringBuilder();
			while (m_Index + 1 < num)
			{
				int num2 = (m_Data[m_Index++] << 8) | m_Data[m_Index++];
				if (num2 == 0)
				{
					break;
				}
				if (IsSafeChar(num2))
				{
					stringBuilder.Append((char)num2);
				}
			}
			m_Index = index;
			return stringBuilder.ToString();
		}

		public string ReadUTF8String()
		{
			if (m_Index >= _Size)
			{
				return string.Empty;
			}
			int num = 0;
			int num2 = m_Index;
			while (num2 < _Size && m_Data[num2++] != 0)
			{
				num++;
			}
			num2 = 0;
			byte[] array = new byte[num];
			int num4 = 0;
			while (m_Index < _Size)
			{
				num4 = m_Data[m_Index++];
				if (num4 == 0)
				{
					break;
				}
				array[num2++] = (byte)num4;
			}
			return Utility.UTF8.GetString(array);
		}

		public string ReadUTF8StringSafe()
		{
			if (m_Index >= _Size)
			{
				return string.Empty;
			}
			int num = 0;
			int num2 = m_Index;
			while (num2 < _Size && m_Data[num2++] != 0)
			{
				num++;
			}
			num2 = 0;
			byte[] array = new byte[num];
			int num4 = 0;
			while (m_Index < _Size)
			{
				num4 = m_Data[m_Index++];
				if (num4 == 0)
				{
					break;
				}
				array[num2++] = (byte)num4;
			}
			string @string = Utility.UTF8.GetString(array);
			bool flag = true;
			int num6 = 0;
			while (flag && num6 < @string.Length)
			{
				flag = IsSafeChar(@string[num6]);
				num6++;
			}
			if (flag)
			{
				return @string;
			}
			StringBuilder stringBuilder = new StringBuilder(@string.Length);
			for (int i = 0; i < @string.Length; i++)
			{
				if (IsSafeChar(@string[i]))
				{
					stringBuilder.Append(@string[i]);
				}
			}
			return stringBuilder.ToString();
		}

		public string ReadUTF8StringSafe(int fixedLength)
		{
			if (m_Index >= _Size)
			{
				m_Index += fixedLength;
				return string.Empty;
			}
			int num = m_Index + fixedLength;
			if (num > _Size)
			{
				num = _Size;
			}
			int num2 = 0;
			int num3 = m_Index;
			int index = m_Index;
			while (num3 < num && m_Data[num3++] != 0)
			{
				num2++;
			}
			num3 = 0;
			byte[] array = new byte[num2];
			int num5 = 0;
			while (m_Index < num)
			{
				num5 = m_Data[m_Index++];
				if (num5 == 0)
				{
					break;
				}
				array[num3++] = (byte)num5;
			}
			string @string = Utility.UTF8.GetString(array);
			bool flag = true;
			int num7 = 0;
			while (flag && num7 < @string.Length)
			{
				flag = IsSafeChar(@string[num7]);
				num7++;
			}
			m_Index = index + fixedLength;
			if (flag)
			{
				return @string;
			}
			StringBuilder stringBuilder = new StringBuilder(@string.Length);
			for (int i = 0; i < @string.Length; i++)
			{
				if (IsSafeChar(@string[i]))
				{
					stringBuilder.Append(@string[i]);
				}
			}
			return stringBuilder.ToString();
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
				m_Index = _Size - offset;
				break;
			}
			return m_Index;
		}

		public void Trace(NetState state)
		{
			try
			{
				using (StreamWriter streamWriter = new StreamWriter("Packets.log", append: true))
				{
					byte[] data = m_Data;
					if (data.Length > 0)
					{
						streamWriter.WriteLine("Client: {0}: Unhandled 包ID 0x{1:X2}{2:X2} 包长{3} 时间{4}", state, data[8], data[7], data.Length, DateTime.Now);
					}
					using (MemoryStream input = new MemoryStream(data))
					{
						Utility.FormatBuffer(streamWriter, input, data.Length);
					}
					streamWriter.WriteLine();
					streamWriter.WriteLine();
				}
			}
			catch
			{
			}
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HelperTools
{
	public class Converter
	{
		public static Dictionary<string, byte[]> Hexstring;

		static Converter()
		{
			old_acctor_mc();
		}

		private static byte eval_a(char A_0)
		{
			string text = "0123456789ABCDEF";
			return (byte)text.IndexOf(A_0);
		}

		public static int getitmeid(string Item)
		{
			string str = Item.Substring(4, 2);
			string str2 = Item.Substring(2, 2);
			string str3 = Item.Substring(0, 2);
			return int.Parse(str + str2 + str3, NumberStyles.HexNumber);
		}

		public static int getItmeid(string Item)
		{
			string str = Item.Substring(6, 2);
			string str2 = Item.Substring(4, 2);
			string str3 = Item.Substring(2, 2);
			string str4 = Item.Substring(0, 2);
			return int.Parse(str + str2 + str3 + str4, NumberStyles.HexNumber);
		}

		public static byte[] hexStringToByte(string hex)
		{
			string key = (hex.Length > 40) ? hex.Remove(40, hex.Length - 40) : hex;
			if (!Hexstring.TryGetValue(key, out byte[] value))
			{
				value = hexStringToByte2(hex);
				Hexstring.Add(key, value);
			}
			byte[] array = new byte[value.Length];
			value.CopyTo(array, 0);
			return array;
		}

		public static byte[] hexStringToByte2(string hex)
		{
			try
			{
				int num = hex.Length / 2;
				byte[] array = new byte[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
				}
				return array;
			}
			catch (Exception)
			{
				return new byte[hex.Length];
			}
		}

		private static void old_acctor_mc()
		{
			Hexstring = new Dictionary<string, byte[]>();
		}

		public static ulong ReadGuidToUlong(byte[] d, int offset)
		{
			byte b = d[offset++];
			byte[] array = new byte[8];
			for (int i = 0; i < 8; i++)
			{
				if ((byte)((b >> i) & 1) != 0)
				{
					array[i] = d[offset++];
				}
				else
				{
					array[i] = 0;
				}
			}
			return BitConverter.ToUInt64(array, 0);
		}

		public static byte ToByte(byte[] d, ref int offset)
		{
			return d[offset++];
		}

		public static void ToBytes(byte a, byte[] b, ref int t)
		{
			b[t++] = a;
		}

		public static void ToBytes(BitArray a, byte[] b, ref int t)
		{
			a.CopyTo(b, t);
			t += a.Length / 8;
		}

		public static void ToBytes(double a, byte[] b, ref int t)
		{
			byte[] bytes = BitConverter.GetBytes(a);
			Buffer.BlockCopy(bytes, 0, b, t, bytes.Length);
			t += bytes.Length;
		}

		public static void ToBytes(short a, byte[] b, ref int t)
		{
			b[t++] = (byte)(a & 0xFF);
			b[t++] = (byte)((a >> 8) & 0xFF);
		}

		public static void ToBytes(int a, byte[] b, ref int t)
		{
			b[t++] = (byte)(a & 0xFF);
			b[t++] = (byte)((a >> 8) & 0xFF);
			b[t++] = (byte)((a >> 16) & 0xFF);
			b[t++] = (byte)((a >> 24) & 0xFF);
		}

		public static void ToBytes(long a, byte[] b, ref int t)
		{
			ToBytes((ulong)a, b, ref t);
		}

		public static void ToBytes(object a, byte[] b, ref int t)
		{
			if (a is int)
			{
				ToBytes((int)a, b, ref t);
			}
			if (a is uint)
			{
				ToBytes((uint)a, b, ref t);
			}
			else if (a is ulong)
			{
				ToBytes((ulong)a, b, ref t);
			}
			else if (a is long)
			{
				ToBytes((long)a, b, ref t);
			}
			else if (a is ushort)
			{
				ToBytes((ushort)a, b, ref t);
			}
			else if (a is short)
			{
				ToBytes((short)a, b, ref t);
			}
			else if (a is byte)
			{
				ToBytes((byte)a, b, ref t);
			}
			else if (a is string)
			{
				ToBytes((string)a, b, ref t);
			}
		}

		public static void ToBytes(float a, byte[] b, ref int t)
		{
			byte[] bytes = BitConverter.GetBytes(a);
			Buffer.BlockCopy(bytes, 0, b, t, bytes.Length);
			t += bytes.Length;
		}

		public static void ToBytes(string a, byte[] b, ref int t)
		{
			char[] array = a.ToCharArray();
			foreach (char c in array)
			{
				b[t++] = (byte)c;
			}
		}

		public static void ToBytes(ushort a, byte[] b, ref int t)
		{
			b[t++] = (byte)(a & 0xFF);
			b[t++] = (byte)((a >> 8) & 0xFF);
		}

		public static void ToBytes(uint a, byte[] b, ref int t)
		{
			b[t++] = (byte)(a & 0xFF);
			b[t++] = (byte)((a >> 8) & 0xFF);
			b[t++] = (byte)((a >> 16) & 0xFF);
			b[t++] = (byte)((a >> 24) & 0xFF);
		}

		public static void ToBytes(ulong a, byte[] b, ref int t)
		{
			b[t++] = (byte)(a & 0xFF);
			b[t++] = (byte)((a >> 8) & 0xFF);
			b[t++] = (byte)((a >> 16) & 0xFF);
			b[t++] = (byte)((a >> 24) & 0xFF);
			b[t++] = (byte)((a >> 32) & 0xFF);
			b[t++] = (byte)((a >> 40) & 0xFF);
			b[t++] = (byte)((a >> 48) & 0xFF);
			b[t++] = (byte)((a >> 56) & 0xFF);
		}

		public static void ToBytes(BitArray a, byte[] b, ref int t, int len)
		{
			a.CopyTo(b, t);
			t += len;
		}

		public static double ToDouble(byte[] d, ref int offset)
		{
			double result = BitConverter.ToDouble(d, offset);
			offset += 8;
			return result;
		}

		public static float ToFloat(byte[] d, ref int offset)
		{
			float result = BitConverter.ToSingle(d, offset);
			offset += 4;
			return result;
		}

		public static void ToGuidMark(ulong a, byte[] b, ref int t)
		{
			byte b2 = 0;
			byte[] array = new byte[8];
			int num = 0;
			for (int i = 0; i < 8; i++)
			{
				if (((a >> 8 * i) & 0xFF) != 0)
				{
					b2 = (byte)(b2 + (byte)Math.Pow(2.0, i));
					array[num] = (byte)((a >> 8 * i) & 0xFF);
					num++;
				}
			}
			b[t++] = b2;
			Buffer.BlockCopy(array, 0, b, t, num);
			t += num;
		}

		public static short ToInt16(byte[] d, ref int offset)
		{
			short result = BitConverter.ToInt16(d, offset);
			offset += 2;
			return result;
		}

		public static int ToInt32(byte[] d, ref int offset)
		{
			int result = BitConverter.ToInt32(d, offset);
			offset += 4;
			return result;
		}

		public static long ToInt64(byte[] d, ref int offset)
		{
			long result = BitConverter.ToInt64(d, offset);
			offset += 8;
			return result;
		}

		public static string ToString(byte[] bytes)
		{
			StringBuilder stringBuilder = new StringBuilder(bytes.Length * 2);
			for (int i = 0; i < bytes.Length; i++)
			{
				byte b = bytes[i];
				stringBuilder.Append(b.ToString("X2"));
			}
			return stringBuilder.ToString();
		}

		public static string ToString1(byte[] bytes)
		{
			StringBuilder stringBuilder = new StringBuilder(bytes.Length * 2);
			for (int i = 0; i < bytes.Length; i++)
			{
				byte b = bytes[i];
				stringBuilder.Append(b.ToString("X2"));
			}
			return "0x" + stringBuilder.ToString();
		}

		public static string ToString2(byte[] bytes)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte value in bytes)
			{
				stringBuilder.Append(Convert.ToString((short)value, 16).PadLeft(2, '0').ToUpper());
			}
			return stringBuilder.ToString();
		}

		public static ushort ToUInt16(byte[] d, ref int offset)
		{
			ushort result = BitConverter.ToUInt16(d, offset);
			offset += 2;
			return result;
		}

		public static uint ToUInt32(byte[] d, ref int offset)
		{
			uint result = BitConverter.ToUInt32(d, offset);
			offset += 4;
			return result;
		}

		public static ulong ToUInt64(byte[] d, ref int offset)
		{
			ulong result = BitConverter.ToUInt64(d, offset);
			offset += 8;
			return result;
		}
	}
}

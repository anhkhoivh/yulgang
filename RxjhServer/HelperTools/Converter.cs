namespace HelperTools
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text;

    public class Converter
    {
        public static Dictionary<string, byte[]> Hexstring;

        static Converter()
        {
            old_acctor_mc();
        }

        private static byte eval_a(char A_0)
        {
            string str = "0123456789ABCDEF";
            return (byte) str.IndexOf(A_0);
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
            string str;
            byte[] buffer;
            if (hex.Length <= 40)
            {
                str = hex;
            }
            else
            {
                str = hex.Remove(40, hex.Length - 40);
            }
            if (!Hexstring.TryGetValue(str, out buffer))
            {
                buffer = hexStringToByte2(hex);
                Hexstring.Add(str, buffer);
            }
            byte[] array = new byte[buffer.Length];
            buffer.CopyTo(array, 0);
            return array;
        }

        public static byte[] hexStringToByte2(string hex)
        {
            try
            {
                int num = hex.Length / 2;
                byte[] buffer = new byte[num];
                for (int i = 0; i < num; ++i)
                {
                    buffer[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
                }
                return buffer;
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
            byte num = d[offset++];
            byte[] buffer = new byte[8];
            for (int i = 0; i < 8; ++i)
            {
                if (((byte) ((num >> i) & 1)) != 0)
                {
                    buffer[i] = d[offset++];
                }
                else
                {
                    buffer[i] = 0;
                }
            }
            return BitConverter.ToUInt64(buffer, 0);
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
            b[t++] = (byte) (a & 255);
            b[t++] = (byte) ((a >> 8) & 255);
        }

        public static void ToBytes(int a, byte[] b, ref int t)
        {
            b[t++] = (byte) (a & 255);
            b[t++] = (byte) ((a >> 8) & 255);
            b[t++] = (byte) ((a >> 16) & 255);
            b[t++] = (byte) ((a >> 24) & 255);
        }

        public static void ToBytes(long a, byte[] b, ref int t)
        {
            ToBytes((ulong) a, b, ref t);
        }

        public static void ToBytes(object a, byte[] b, ref int t)
        {
            if (a is int)
            {
                ToBytes((int) a, b, ref t);
            }
            if (a is uint)
            {
                ToBytes((uint) a, b, ref t);
            }
            else if (a is ulong)
            {
                ToBytes((ulong) a, b, ref t);
            }
            else if (a is long)
            {
                ToBytes((long) a, b, ref t);
            }
            else if (a is ushort)
            {
                ToBytes((ushort) a, b, ref t);
            }
            else if (a is short)
            {
                ToBytes((short) a, b, ref t);
            }
            else if (a is byte)
            {
                ToBytes((byte) a, b, ref t);
            }
            else if (a is string)
            {
                ToBytes((string) a, b, ref t);
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
            foreach (char ch in a.ToCharArray())
            {
                b[t++] = (byte) ch;
            }
        }

        public static void ToBytes(ushort a, byte[] b, ref int t)
        {
            b[t++] = (byte) (a & 255);
            b[t++] = (byte) ((a >> 8) & 255);
        }

        public static void ToBytes(uint a, byte[] b, ref int t)
        {
            b[t++] = (byte) (a & 255);
            b[t++] = (byte) ((a >> 8) & 255);
            b[t++] = (byte) ((a >> 16) & 255);
            b[t++] = (byte) ((a >> 24) & 255);
        }

        public static void ToBytes(ulong a, byte[] b, ref int t)
        {
            b[t++] = (byte) (a & ((ulong) 255L));
            b[t++] = (byte) ((a >> 8) & ((ulong) 255L));
            b[t++] = (byte) ((a >> 16) & ((ulong) 255L));
            b[t++] = (byte) ((a >> 24) & ((ulong) 255L));
            b[t++] = (byte) ((a >> 32) & ((ulong) 255L));
            b[t++] = (byte) ((a >> 40) & ((ulong) 255L));
            b[t++] = (byte) ((a >> 48) & ((ulong) 255L));
            b[t++] = (byte) ((a >> 56) & ((ulong) 255L));
        }

        public static void ToBytes(BitArray a, byte[] b, ref int t, int len)
        {
            a.CopyTo(b, t);
            t += len;
        }

        public static double ToDouble(byte[] d, ref int offset)
        {
            double num = BitConverter.ToDouble(d, offset);
            offset += 8;
            return num;
        }

        public static float ToFloat(byte[] d, ref int offset)
        {
            float num = BitConverter.ToSingle(d, offset);
            offset += 4;
            return num;
        }

        public static void ToGuidMark(ulong a, byte[] b, ref int t)
        {
            byte num = 0;
            byte[] src = new byte[8];
            int index = 0;
            for (int i = 0; i < 8; ++i)
            {
                if (((a >> (8 * i)) & ((ulong) 255L)) != 0L)
                {
                    num = (byte) (num + ((byte) Math.Pow(2.0, (double) i)));
                    src[index] = (byte) ((a >> (8 * i)) & ((ulong) 255L));
                    index++;
                }
            }
            b[t++] = num;
            Buffer.BlockCopy(src, 0, b, t, index);
            t += index;
        }

        public static short ToInt16(byte[] d, ref int offset)
        {
            short num = BitConverter.ToInt16(d, offset);
            offset += 2;
            return num;
        }

        public static int ToInt32(byte[] d, ref int offset)
        {
            int num = BitConverter.ToInt32(d, offset);
            offset += 4;
            return num;
        }

        public static long ToInt64(byte[] d, ref int offset)
        {
            long num = BitConverter.ToInt64(d, offset);
            offset += 8;
            return num;
        }

        public static string ToString(byte[] bytes)
        {
            StringBuilder builder = new StringBuilder(bytes.Length * 2);
            foreach (byte num2 in bytes)
            {
                builder.Append(num2.ToString("X2"));
            }
            return builder.ToString();
        }

        public static string ToString1(byte[] bytes)
        {
            StringBuilder builder = new StringBuilder(bytes.Length * 2);
            foreach (byte num2 in bytes)
            {
                builder.Append(num2.ToString("X2"));
            }
            return ("0x" + builder.ToString());
        }

        public static string ToString2(byte[] bytes)
        {
            StringBuilder builder = new StringBuilder();
            foreach (byte num2 in bytes)
            {
                builder.Append(Convert.ToString((short) num2, 16).PadLeft(2, '0').ToUpper());
            }
            return builder.ToString();
        }

        public static ushort ToUInt16(byte[] d, ref int offset)
        {
            ushort num = BitConverter.ToUInt16(d, offset);
            offset += 2;
            return num;
        }

        public static uint ToUInt32(byte[] d, ref int offset)
        {
            uint num = BitConverter.ToUInt32(d, offset);
            offset += 4;
            return num;
        }

        public static ulong ToUInt64(byte[] d, ref int offset)
        {
            ulong num = BitConverter.ToUInt64(d, offset);
            offset += 8;
            return num;
        }
    }
}


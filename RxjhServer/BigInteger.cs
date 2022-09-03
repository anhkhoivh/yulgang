using RxjhServer.RxjhServer;
using System;

namespace RxjhServer
{
	public class BigInteger
	{
		private const int eval_a_a = 70;

		private uint[] b;

		public int dataLength;

		public static readonly int[] primesBelow2000;

		public BigInteger()
		{
			b = new uint[70];
			dataLength = 1;
		}

		public BigInteger(BigInteger bi)
		{
			b = new uint[70];
			dataLength = bi.dataLength;
			for (int i = 0; i < dataLength; i++)
			{
				b[i] = bi.b[i];
			}
		}

		public BigInteger(long value)
		{
			b = new uint[70];
			long num = value;
			dataLength = 0;
			while (value != 0 && dataLength < 70)
			{
				b[dataLength] = (uint)(value & uint.MaxValue);
				value >>= 32;
				dataLength++;
			}
			if (num > 0)
			{
				if (value != 0 || ((int)b[69] & int.MinValue) != 0)
				{
					throw new ArithmeticException("Positive overflow in constructor.");
				}
			}
			else if (num < 0 && (value != -1 || ((int)b[dataLength - 1] & int.MinValue) == 0))
			{
				throw new ArithmeticException("Negative underflow in constructor.");
			}
			if (dataLength == 0)
			{
				dataLength = 1;
			}
		}

		public BigInteger(ulong value)
		{
			b = new uint[70];
			dataLength = 0;
			while (value != 0 && dataLength < 70)
			{
				b[dataLength] = (uint)(value & uint.MaxValue);
				value >>= 32;
				dataLength++;
			}
			if (value != 0 || ((int)b[69] & int.MinValue) != 0)
			{
				throw new ArithmeticException("Positive overflow in constructor.");
			}
			if (dataLength == 0)
			{
				dataLength = 1;
			}
		}

		public BigInteger(byte[] inData)
		{
			dataLength = inData.Length >> 2;
			int num = inData.Length & 3;
			if (num != 0)
			{
				dataLength++;
			}
			if (dataLength > 70)
			{
				throw new ArithmeticException("Byte overflow in constructor.");
			}
			b = new uint[70];
			int num2 = inData.Length - 1;
			int num3 = 0;
			while (num2 >= 3)
			{
				b[num3] = (uint)((inData[num2 - 3] << 24) + (inData[num2 - 2] << 16) + (inData[num2 - 1] << 8) + inData[num2]);
				num2 -= 4;
				num3++;
			}
			switch (num)
			{
			case 1:
				b[dataLength - 1] = inData[0];
				break;
			case 2:
				b[dataLength - 1] = (uint)((inData[0] << 8) + inData[1]);
				break;
			case 3:
				b[dataLength - 1] = (uint)((inData[0] << 16) + (inData[1] << 8) + inData[2]);
				break;
			}
			while (dataLength > 1 && b[dataLength - 1] == 0)
			{
				dataLength--;
			}
		}

		public BigInteger(uint[] inData)
		{
			dataLength = inData.Length;
			if (dataLength > 70)
			{
				throw new ArithmeticException("Byte overflow in constructor.");
			}
			b = new uint[70];
			int num = dataLength - 1;
			int num2 = 0;
			while (num >= 0)
			{
				b[num2] = inData[num];
				num--;
				num2++;
			}
			while (dataLength > 1 && b[dataLength - 1] == 0)
			{
				dataLength--;
			}
		}

		public BigInteger(byte[] inData, int inLen)
		{
			dataLength = inLen >> 2;
			int num = inLen & 3;
			if (num != 0)
			{
				dataLength++;
			}
			if (dataLength > 70 || inLen > inData.Length)
			{
				throw new ArithmeticException("Byte overflow in constructor.");
			}
			b = new uint[70];
			int num2 = inLen - 1;
			int num3 = 0;
			while (num2 >= 3)
			{
				b[num3] = (uint)((inData[num2 - 3] << 24) + (inData[num2 - 2] << 16) + (inData[num2 - 1] << 8) + inData[num2]);
				num2 -= 4;
				num3++;
			}
			switch (num)
			{
			case 1:
				b[dataLength - 1] = inData[0];
				break;
			case 2:
				b[dataLength - 1] = (uint)((inData[0] << 8) + inData[1]);
				break;
			case 3:
				b[dataLength - 1] = (uint)((inData[0] << 16) + (inData[1] << 8) + inData[2]);
				break;
			}
			if (dataLength == 0)
			{
				dataLength = 1;
			}
			while (dataLength > 1 && b[dataLength - 1] == 0)
			{
				dataLength--;
			}
		}

		public BigInteger(string value, int radix)
		{
			BigInteger bi = new BigInteger(1L);
			BigInteger bigInteger = new BigInteger();
			value = value.ToUpper().Trim();
			int num = 0;
			if (value[0] == '-')
			{
				num = 1;
			}
			for (int num2 = value.Length - 1; num2 >= num; num2--)
			{
				int num3 = value[num2];
				num3 = ((num3 >= 48 && num3 <= 57) ? (num3 - 48) : ((num3 < 65 || num3 > 90) ? 9999999 : (num3 - 65 + 10)));
				if (num3 >= radix)
				{
					throw new ArithmeticException("Invalid string in constructor.");
				}
				if (value[0] == '-')
				{
					num3 = -num3;
				}
				bigInteger += bi * num3;
				if (num2 - 1 >= num)
				{
					bi *= radix;
				}
			}
			if (value[0] == '-')
			{
				if (((int)bigInteger.b[69] & int.MinValue) == 0)
				{
					throw new ArithmeticException("Negative underflow in constructor.");
				}
			}
			else if (((int)bigInteger.b[69] & int.MinValue) != 0)
			{
				throw new ArithmeticException("Positive overflow in constructor.");
			}
			b = new uint[70];
			for (int i = 0; i < bigInteger.dataLength; i++)
			{
				b[i] = bigInteger.b[i];
			}
			dataLength = bigInteger.dataLength;
		}

		public BigInteger abs()
		{
			if (((int)b[69] & int.MinValue) != 0)
			{
				return -this;
			}
			return new BigInteger(this);
		}

		public int bitCount()
		{
			while (dataLength > 1 && b[dataLength - 1] == 0)
			{
				dataLength--;
			}
			uint num = b[dataLength - 1];
			uint num2 = 2147483648u;
			int num3 = 32;
			while (num3 > 0 && (num & num2) == 0)
			{
				num3--;
				num2 >>= 1;
			}
			return num3 + (dataLength - 1 << 5);
		}

		public override bool Equals(object obj)
		{
			BigInteger bigInteger = (BigInteger)obj;
			if (dataLength != bigInteger.dataLength)
			{
				return false;
			}
			for (int i = 0; i < dataLength; i++)
			{
				if (b[i] != bigInteger.b[i])
				{
					return false;
				}
			}
			return true;
		}

		private bool eval_a(BigInteger A_0)
		{
			long num = 5L;
			long num2 = -1L;
			long num3 = 0L;
			for (bool flag = false; !flag; num3++)
			{
				int num4;
				switch (Jacobi(num, A_0))
				{
				case -1:
					flag = true;
					continue;
				case 0:
					num4 = ((!(Math.Abs(num) < A_0)) ? 1 : 0);
					break;
				default:
					num4 = 1;
					break;
				}
				if (num4 == 0)
				{
					return false;
				}
				if (num3 == 20)
				{
					BigInteger bigInteger = A_0.sqrt();
					if (bigInteger * bigInteger == A_0)
					{
						return false;
					}
				}
				num = (Math.Abs(num) + 2) * num2;
				num2 = -num2;
			}
			long num5 = 1 - num >> 2;
			BigInteger bigInteger2 = A_0 + 1;
			int num6 = 0;
			for (int i = 0; i < bigInteger2.dataLength; i++)
			{
				uint num7 = 1u;
				for (int j = 0; j < 32; j++)
				{
					if ((bigInteger2.b[i] & num7) == 0)
					{
						num7 <<= 1;
						num6++;
						continue;
					}
					i = bigInteger2.dataLength;
					break;
				}
			}
			BigInteger a_ = bigInteger2 >> num6;
			BigInteger bigInteger3 = new BigInteger();
			int num8 = A_0.dataLength << 1;
			bigInteger3.b[num8] = 1u;
			bigInteger3.dataLength = num8 + 1;
			bigInteger3 /= A_0;
			BigInteger[] array = eval_a(1, num5, a_, A_0, bigInteger3, 0);
			bool flag2 = false;
			if ((array[0].dataLength == 1 && array[0].b[0] == 0) || (array[1].dataLength == 1 && array[1].b[0] == 0))
			{
				flag2 = true;
			}
			for (int k = 1; k < num6; k++)
			{
				if (!flag2)
				{
					array[1] = A_0.eval_a(array[1] * array[1], A_0, bigInteger3);
					array[1] = (array[1] - (array[2] << 1)) % A_0;
					if (array[1].dataLength == 1 && array[1].b[0] == 0)
					{
						flag2 = true;
					}
				}
				array[2] = A_0.eval_a(array[2] * array[2], A_0, bigInteger3);
			}
			if (flag2)
			{
				BigInteger bigInteger4 = A_0.gcd(num5);
				if (bigInteger4.dataLength != 1 || bigInteger4.b[0] != 1)
				{
					return flag2;
				}
				if (((int)array[2].b[69] & int.MinValue) != 0)
				{
					BigInteger[] array2;
					(array2 = array)[2] = array2[2] + A_0;
				}
				BigInteger bigInteger5 = num5 * Jacobi(num5, A_0) % A_0;
				if (((int)bigInteger5.b[69] & int.MinValue) != 0)
				{
					bigInteger5 += A_0;
				}
				if (array[2] != bigInteger5)
				{
					flag2 = false;
				}
			}
			return flag2;
		}

		private static int eval_a(uint[] A_0, int A_1)
		{
			int num = 32;
			int num2 = 0;
			int num3 = A_0.Length;
			while (num3 > 1 && A_0[num3 - 1] == 0)
			{
				num3--;
			}
			for (int num4 = A_1; num4 > 0; num4 -= num)
			{
				if (num4 < num)
				{
					num = num4;
					num2 = 32 - num;
				}
				ulong num5 = 0uL;
				for (int num6 = num3 - 1; num6 >= 0; num6--)
				{
					ulong num7 = A_0[num6] >> num;
					num7 |= num5;
					num5 = A_0[num6] << num2;
					A_0[num6] = (uint)num7;
				}
			}
			while (num3 > 1)
			{
				if (A_0[num3 - 1] != 0)
				{
					return num3;
				}
				num3--;
			}
			return num3;
		}

		private BigInteger eval_a(BigInteger A_0, BigInteger A_1, BigInteger A_2)
		{
			int num = A_1.dataLength;
			int num2 = num + 1;
			int num3 = num - 1;
			BigInteger bigInteger = new BigInteger();
			int num4 = num3;
			int num5 = 0;
			while (num4 < A_0.dataLength)
			{
				bigInteger.b[num5] = A_0.b[num4];
				num4++;
				num5++;
			}
			bigInteger.dataLength = A_0.dataLength - num3;
			if (bigInteger.dataLength <= 0)
			{
				bigInteger.dataLength = 1;
			}
			BigInteger bigInteger2 = bigInteger * A_2;
			BigInteger bigInteger3 = new BigInteger();
			int num6 = num2;
			int num7 = 0;
			while (num6 < bigInteger2.dataLength)
			{
				bigInteger3.b[num7] = bigInteger2.b[num6];
				num6++;
				num7++;
			}
			bigInteger3.dataLength = bigInteger2.dataLength - num2;
			if (bigInteger3.dataLength <= 0)
			{
				bigInteger3.dataLength = 1;
			}
			BigInteger bigInteger4 = new BigInteger();
			int num8 = (A_0.dataLength > num2) ? num2 : A_0.dataLength;
			for (int i = 0; i < num8; i++)
			{
				bigInteger4.b[i] = A_0.b[i];
			}
			bigInteger4.dataLength = num8;
			BigInteger bigInteger5 = new BigInteger();
			for (int j = 0; j < bigInteger3.dataLength; j++)
			{
				if (bigInteger3.b[j] != 0)
				{
					ulong num9 = 0uL;
					int num10 = j;
					int num11 = 0;
					while (num11 < A_1.dataLength && num10 < num2)
					{
						ulong num12 = bigInteger3.b[j] * A_1.b[num11] + bigInteger5.b[num10] + num9;
						bigInteger5.b[num10] = (uint)(num12 & uint.MaxValue);
						num9 = num12 >> 32;
						num11++;
						num10++;
					}
					if (num10 < num2)
					{
						bigInteger5.b[num10] = (uint)num9;
					}
				}
			}
			bigInteger5.dataLength = num2;
			while (bigInteger5.dataLength > 1 && bigInteger5.b[bigInteger5.dataLength - 1] == 0)
			{
				bigInteger5.dataLength--;
			}
			bigInteger4 -= bigInteger5;
			if (((int)bigInteger4.b[69] & int.MinValue) != 0)
			{
				BigInteger bigInteger6 = new BigInteger();
				bigInteger6.b[num2] = 1u;
				bigInteger6.dataLength = num2 + 1;
				bigInteger4 += bigInteger6;
			}
			while (bigInteger4 >= A_1)
			{
				bigInteger4 -= A_1;
			}
			return bigInteger4;
		}

		private static void eval_a(BigInteger A_0, BigInteger A_1, BigInteger A_2, BigInteger A_3)
		{
			uint[] array = new uint[70];
			int num = 0;
			for (int i = 0; i < 70; i++)
			{
				A_3.b[i] = A_0.b[i];
			}
			A_3.dataLength = A_0.dataLength;
			while (A_3.dataLength > 1 && A_3.b[A_3.dataLength - 1] == 0)
			{
				A_3.dataLength--;
			}
			ulong num2 = A_1.b[0];
			int num3 = A_3.dataLength - 1;
			ulong num4 = A_3.b[num3];
			if (num4 >= num2)
			{
				ulong num5 = num4 / num2;
				array[num++] = (uint)num5;
				A_3.b[num3] = (uint)(num4 % num2);
			}
			num3--;
			while (num3 >= 0)
			{
				num4 = A_3.b[num3 + 1] + A_3.b[num3];
				ulong num7 = num4 / num2;
				array[num++] = (uint)num7;
				A_3.b[num3 + 1] = 0u;
				A_3.b[num3--] = (uint)(num4 % num2);
			}
			A_2.dataLength = num;
			int j = 0;
			int num10 = A_2.dataLength - 1;
			while (num10 >= 0)
			{
				A_2.b[j] = array[num10];
				num10--;
				j++;
			}
			for (; j < 70; j++)
			{
				A_2.b[j] = 0u;
			}
			while (A_2.dataLength > 1 && A_2.b[A_2.dataLength - 1] == 0)
			{
				A_2.dataLength--;
			}
			if (A_2.dataLength == 0)
			{
				A_2.dataLength = 1;
			}
			while (A_3.dataLength > 1 && A_3.b[A_3.dataLength - 1] == 0)
			{
				A_3.dataLength--;
			}
		}

		private static BigInteger[] eval_a(BigInteger A_0, BigInteger A_1, BigInteger A_2, BigInteger A_3, BigInteger A_4, int A_5)
		{
			BigInteger[] array = new BigInteger[3];
			if ((A_2.b[0] & 1) == 0)
			{
				throw new ArgumentException("Argument k must be odd.");
			}
			int num = A_2.bitCount();
			uint num2 = (uint)(1 << (num & 0x1F) - 1);
			BigInteger bigInteger = 2 % A_3;
			BigInteger bigInteger2 = 1 % A_3;
			BigInteger bigInteger3 = A_0 % A_3;
			BigInteger bi = bigInteger2;
			bool flag = true;
			for (int num3 = A_2.dataLength - 1; num3 >= 0; num3--)
			{
				while (num2 != 0 && (num3 != 0 || num2 != 1))
				{
					if ((A_2.b[num3] & num2) != 0)
					{
						bi = bi * bigInteger3 % A_3;
						bigInteger = (bigInteger * bigInteger3 - A_0 * bigInteger2) % A_3;
						bigInteger3 = (A_3.eval_a(bigInteger3 * bigInteger3, A_3, A_4) - (bigInteger2 * A_1 << 1)) % A_3;
						if (flag)
						{
							flag = false;
						}
						else
						{
							bigInteger2 = A_3.eval_a(bigInteger2 * bigInteger2, A_3, A_4);
						}
						bigInteger2 = bigInteger2 * A_1 % A_3;
					}
					else
					{
						bi = (bi * bigInteger - bigInteger2) % A_3;
						bigInteger3 = (bigInteger * bigInteger3 - A_0 * bigInteger2) % A_3;
						bigInteger = (A_3.eval_a(bigInteger * bigInteger, A_3, A_4) - (bigInteger2 << 1)) % A_3;
						if (flag)
						{
							bigInteger2 = A_1 % A_3;
							flag = false;
						}
						else
						{
							bigInteger2 = A_3.eval_a(bigInteger2 * bigInteger2, A_3, A_4);
						}
					}
					num2 >>= 1;
				}
				num2 = 2147483648u;
			}
			bi = (bi * bigInteger - bigInteger2) % A_3;
			bigInteger = (bigInteger * bigInteger3 - A_0 * bigInteger2) % A_3;
			if (flag)
			{
				flag = false;
			}
			else
			{
				bigInteger2 = A_3.eval_a(bigInteger2 * bigInteger2, A_3, A_4);
			}
			bigInteger2 = bigInteger2 * A_1 % A_3;
			for (int i = 0; i < A_5; i++)
			{
				bi = bi * bigInteger % A_3;
				bigInteger = (bigInteger * bigInteger - (bigInteger2 << 1)) % A_3;
				if (flag)
				{
					bigInteger2 = A_1 % A_3;
					flag = false;
				}
				else
				{
					bigInteger2 = A_3.eval_a(bigInteger2 * bigInteger2, A_3, A_4);
				}
			}
			array[0] = bi;
			array[1] = bigInteger;
			array[2] = bigInteger2;
			return array;
		}

		private static int eval_b(uint[] A_0, int A_1)
		{
			int num = 32;
			int num2 = A_0.Length;
			while (num2 > 1 && A_0[num2 - 1] == 0)
			{
				num2--;
			}
			for (int num3 = A_1; num3 > 0; num3 -= num)
			{
				if (num3 < num)
				{
					num = num3;
				}
				ulong num4 = 0uL;
				for (int i = 0; i < num2; i++)
				{
					ulong num5 = A_0[i] << num;
					num5 |= num4;
					A_0[i] = (uint)(num5 & uint.MaxValue);
					num4 = num5 >> 32;
				}
				if (num4 != 0 && num2 + 1 <= A_0.Length)
				{
					A_0[num2] = (uint)num4;
					num2++;
				}
			}
			return num2;
		}

		private static void eval_b(BigInteger A_0, BigInteger A_1, BigInteger A_2, BigInteger A_3)
		{
			uint[] array = new uint[70];
			int num = A_0.dataLength + 1;
			uint[] array2 = new uint[num];
			uint num2 = 2147483648u;
			uint num3 = A_1.b[A_1.dataLength - 1];
			int num4 = 0;
			int num5 = 0;
			while (num2 != 0 && (num3 & num2) == 0)
			{
				num4++;
				num2 >>= 1;
			}
			for (int i = 0; i < A_0.dataLength; i++)
			{
				array2[i] = A_0.b[i];
			}
			eval_b(array2, num4);
			A_1 <<= num4;
			int num6 = num - A_1.dataLength;
			int num7 = num - 1;
			ulong num8 = A_1.b[A_1.dataLength - 1];
			ulong num9 = A_1.b[A_1.dataLength - 2];
			int num10 = A_1.dataLength + 1;
			uint[] array3 = new uint[num10];
			while (num6 > 0)
			{
				ulong num11 = array2[num7] + array2[num7 - 1];
				ulong num12 = num11 / num8;
				ulong num13 = num11 % num8;
				bool flag = false;
				while (!flag)
				{
					flag = true;
					if (num12 == 4294967296L || num12 * num9 > (num13 << 32) + array2[num7 - 2])
					{
						num12--;
						num13 += num8;
						if (num13 < 4294967296L)
						{
							flag = false;
						}
					}
				}
				for (int j = 0; j < num10; j++)
				{
					array3[j] = array2[num7 - j];
				}
				BigInteger bigInteger = new BigInteger(array3);
				BigInteger bigInteger2 = A_1 * num12;
				while (bigInteger2 > bigInteger)
				{
					num12--;
					bigInteger2 -= A_1;
				}
				BigInteger bigInteger3 = bigInteger - bigInteger2;
				for (int k = 0; k < num10; k++)
				{
					array2[num7 - k] = bigInteger3.b[A_1.dataLength - k];
				}
				array[num5++] = (uint)num12;
				num7--;
				num6--;
			}
			A_2.dataLength = num5;
			int l = 0;
			int num15 = A_2.dataLength - 1;
			while (num15 >= 0)
			{
				A_2.b[l] = array[num15];
				num15--;
				l++;
			}
			for (; l < 70; l++)
			{
				A_2.b[l] = 0u;
			}
			while (A_2.dataLength > 1 && A_2.b[A_2.dataLength - 1] == 0)
			{
				A_2.dataLength--;
			}
			if (A_2.dataLength == 0)
			{
				A_2.dataLength = 1;
			}
			A_3.dataLength = eval_a(array2, num4);
			for (l = 0; l < A_3.dataLength; l++)
			{
				A_3.b[l] = array2[l];
			}
			for (; l < 70; l++)
			{
				A_3.b[l] = 0u;
			}
		}

		public bool FermatLittleTest(int confidence)
		{
			BigInteger bigInteger = (((int)b[69] & int.MinValue) == 0) ? this : (-this);
			if (bigInteger.dataLength == 1)
			{
				if (bigInteger.b[0] == 0 || bigInteger.b[0] == 1)
				{
					return false;
				}
				if (bigInteger.b[0] == 2 || bigInteger.b[0] == 3)
				{
					return true;
				}
			}
			if ((bigInteger.b[0] & 1) == 0)
			{
				return false;
			}
			int num = bigInteger.bitCount();
			BigInteger bigInteger2 = new BigInteger();
			BigInteger exp = bigInteger - new BigInteger(1L);
			Random random = new Random(World.GetRandomSeed());
			for (int i = 0; i < confidence; i++)
			{
				bool flag = false;
				while (!flag)
				{
					for (int num2 = 0; num2 < 2; num2 = (int)(random.NextDouble() * (double)num))
					{
					}
					int num3 = bigInteger2.dataLength;
					if (num3 > 1 || (num3 == 1 && bigInteger2.b[0] != 1))
					{
						flag = true;
					}
				}
				BigInteger bigInteger3 = bigInteger2.gcd(bigInteger);
				if (bigInteger3.dataLength == 1 && bigInteger3.b[0] != 1)
				{
					return false;
				}
				BigInteger bigInteger4 = bigInteger2.modPow(exp, bigInteger);
				int num4 = bigInteger4.dataLength;
				if (num4 > 1 || (num4 == 1 && bigInteger4.b[0] != 1))
				{
					return false;
				}
			}
			return true;
		}

		public BigInteger gcd(BigInteger bi)
		{
			BigInteger bigInteger = (((int)b[69] & int.MinValue) == 0) ? this : (-this);
			BigInteger bigInteger2 = (((int)bi.b[69] & int.MinValue) == 0) ? bi : (-bi);
			BigInteger bigInteger3 = bigInteger2;
			while (bigInteger.dataLength > 1 || (bigInteger.dataLength == 1 && bigInteger.b[0] != 0))
			{
				bigInteger3 = bigInteger;
				bigInteger = bigInteger2 % bigInteger;
				bigInteger2 = bigInteger3;
			}
			return bigInteger3;
		}

		public BigInteger genCoPrime(int bits, Random rand)
		{
			bool flag = false;
			BigInteger bigInteger = new BigInteger();
			while (!flag)
			{
				BigInteger bigInteger2 = bigInteger.gcd(this);
				if (bigInteger2.dataLength == 1 && bigInteger2.b[0] == 1)
				{
					flag = true;
				}
			}
			return bigInteger;
		}

		public static BigInteger genPseudoPrime(int bits, int confidence, Random rand)
		{
			BigInteger bigInteger = new BigInteger();
			bool flag = false;
			while (!flag)
			{
				bigInteger.b[0] |= 1u;
				flag = bigInteger.isProbablePrime(confidence);
			}
			return bigInteger;
		}

		public byte[] getBytes()
		{
			int num = bitCount();
			int num2 = num >> 3;
			if ((num & 7) != 0)
			{
				num2++;
			}
			byte[] array = new byte[num2];
			int num3 = 0;
			uint num4 = b[dataLength - 1];
			uint num5 = (num4 >> 24) & 0xFF;
			if (num5 != 0)
			{
				array[num3++] = (byte)num5;
			}
			num5 = ((num4 >> 16) & 0xFF);
			if (num5 != 0)
			{
				array[num3++] = (byte)num5;
			}
			num5 = ((num4 >> 8) & 0xFF);
			if (num5 != 0)
			{
				array[num3++] = (byte)num5;
			}
			num5 = (num4 & 0xFF);
			if (num5 != 0)
			{
				array[num3++] = (byte)num5;
			}
			int num10 = dataLength - 2;
			while (num10 >= 0)
			{
				num4 = b[num10];
				array[num3 + 3] = (byte)(num4 & 0xFF);
				num4 >>= 8;
				array[num3 + 2] = (byte)(num4 & 0xFF);
				num4 >>= 8;
				array[num3 + 1] = (byte)(num4 & 0xFF);
				num4 >>= 8;
				array[num3] = (byte)(num4 & 0xFF);
				num10--;
				num3 += 4;
			}
			return array;
		}

		public override int GetHashCode()
		{
			return ToString().GetHashCode();
		}

		public int IntValue()
		{
			return (int)b[0];
		}

		public bool isProbablePrime(int confidence)
		{
			BigInteger bigInteger = (((int)b[69] & int.MinValue) == 0) ? this : (-this);
			for (int i = 0; i < primesBelow2000.Length; i++)
			{
				BigInteger bigInteger2 = primesBelow2000[i];
				if (bigInteger2 >= bigInteger)
				{
					break;
				}
				BigInteger bigInteger3 = bigInteger % bigInteger2;
				if (bigInteger3.IntValue() == 0)
				{
					return false;
				}
			}
			return bigInteger.RabinMillerTest(confidence);
		}

		public static int Jacobi(BigInteger a, BigInteger b)
		{
			if ((b.b[0] & 1) == 0)
			{
				throw new ArgumentException("Jacobi defined only for odd integers.");
			}
			if (a >= b)
			{
				a %= b;
			}
			if (a.dataLength == 1 && a.b[0] == 0)
			{
				return 0;
			}
			if (a.dataLength == 1 && a.b[0] == 1)
			{
				return 1;
			}
			if (a < 0)
			{
				if (((b - 1).b[0] & 2) == 0)
				{
					return Jacobi(-a, b);
				}
				return -Jacobi(-a, b);
			}
			int num = 0;
			for (int i = 0; i < a.dataLength; i++)
			{
				uint num2 = 1u;
				for (int j = 0; j < 32; j++)
				{
					if ((a.b[i] & num2) == 0)
					{
						num2 <<= 1;
						num++;
						continue;
					}
					i = a.dataLength;
					break;
				}
			}
			BigInteger bigInteger = a >> num;
			int num3 = 1;
			if ((num & 1) != 0 && ((b.b[0] & 7) == 3 || (b.b[0] & 7) == 5))
			{
				num3 = -1;
			}
			if ((b.b[0] & 3) == 3 && (bigInteger.b[0] & 3) == 3)
			{
				num3 = -num3;
			}
			if (bigInteger.dataLength == 1 && bigInteger.b[0] == 1)
			{
				return num3;
			}
			return num3 * Jacobi(b % bigInteger, bigInteger);
		}

		public long LongValue()
		{
			long num = 0L;
			num = b[0];
			try
			{
				num |= b[1];
			}
			catch (Exception)
			{
				if (((int)b[0] & int.MinValue) != 0)
				{
					num = b[0];
				}
			}
			return num;
		}

		public static BigInteger[] LucasSequence(BigInteger P, BigInteger Q, BigInteger k, BigInteger n)
		{
			if (k.dataLength == 1 && k.b[0] == 0)
			{
				return new BigInteger[3]
				{
					0,
					2 % n,
					1 % n
				};
			}
			BigInteger bigInteger = new BigInteger();
			int num = n.dataLength << 1;
			bigInteger.b[num] = 1u;
			bigInteger.dataLength = num + 1;
			bigInteger /= n;
			int num2 = 0;
			for (int i = 0; i < k.dataLength; i++)
			{
				uint num3 = 1u;
				for (int j = 0; j < 32; j++)
				{
					if ((k.b[i] & num3) == 0)
					{
						num3 <<= 1;
						num2++;
						continue;
					}
					i = k.dataLength;
					break;
				}
			}
			BigInteger a_ = k >> num2;
			return eval_a(P, Q, a_, n, bigInteger, num2);
		}

		public bool LucasStrongTest()
		{
			BigInteger bigInteger = (((int)b[69] & int.MinValue) == 0) ? this : (-this);
			if (bigInteger.dataLength == 1)
			{
				if (bigInteger.b[0] == 0 || bigInteger.b[0] == 1)
				{
					return false;
				}
				if (bigInteger.b[0] == 2 || bigInteger.b[0] == 3)
				{
					return true;
				}
			}
			if ((bigInteger.b[0] & 1) == 0)
			{
				return false;
			}
			return eval_a(bigInteger);
		}

		public BigInteger max(BigInteger bi)
		{
			if (this > bi)
			{
				return new BigInteger(this);
			}
			return new BigInteger(bi);
		}

		public BigInteger min(BigInteger bi)
		{
			if (this < bi)
			{
				return new BigInteger(this);
			}
			return new BigInteger(bi);
		}

		public BigInteger modInverse(BigInteger modulus)
		{
			BigInteger[] array = new BigInteger[2]
			{
				0,
				1
			};
			BigInteger[] array2 = new BigInteger[2];
			BigInteger[] array3 = new BigInteger[2]
			{
				0,
				0
			};
			int num = 0;
			BigInteger a_ = modulus;
			BigInteger bigInteger = this;
			while (bigInteger.dataLength > 1 || (bigInteger.dataLength == 1 && bigInteger.b[0] != 0))
			{
				BigInteger bigInteger2 = new BigInteger();
				BigInteger bigInteger3 = new BigInteger();
				if (num > 1)
				{
					BigInteger bigInteger4 = (array[0] - array[1] * array2[0]) % modulus;
					array[0] = array[1];
					array[1] = bigInteger4;
				}
				if (bigInteger.dataLength == 1)
				{
					eval_a(a_, bigInteger, bigInteger2, bigInteger3);
				}
				else
				{
					eval_b(a_, bigInteger, bigInteger2, bigInteger3);
				}
				array2[0] = array2[1];
				array3[0] = array3[1];
				array2[1] = bigInteger2;
				array3[1] = bigInteger3;
				a_ = bigInteger;
				bigInteger = bigInteger3;
				num++;
			}
			if (array3[0].dataLength > 1 || (array3[0].dataLength == 1 && array3[0].b[0] != 1))
			{
				throw new ArithmeticException("No inverse!");
			}
			BigInteger bigInteger5 = (array[0] - array[1] * array2[0]) % modulus;
			if (((int)bigInteger5.b[69] & int.MinValue) != 0)
			{
				bigInteger5 += modulus;
			}
			return bigInteger5;
		}

		public BigInteger modPow(BigInteger exp, BigInteger n)
		{
			if (((int)exp.b[69] & int.MinValue) != 0)
			{
				throw new ArithmeticException("Positive exponents only.");
			}
			BigInteger bigInteger = 1;
			bool flag = false;
			BigInteger bigInteger2;
			if (((int)b[69] & int.MinValue) != 0)
			{
				bigInteger2 = -this % n;
				flag = true;
			}
			else
			{
				bigInteger2 = this % n;
			}
			if (((int)n.b[69] & int.MinValue) != 0)
			{
				n = -n;
			}
			BigInteger bigInteger3 = new BigInteger();
			int num = n.dataLength << 1;
			bigInteger3.b[num] = 1u;
			bigInteger3.dataLength = num + 1;
			bigInteger3 /= n;
			int num2 = exp.bitCount();
			int num3 = 0;
			for (int i = 0; i < exp.dataLength; i++)
			{
				uint num4 = 1u;
				for (int j = 0; j < 32; j++)
				{
					if ((exp.b[i] & num4) != 0)
					{
						bigInteger = eval_a(bigInteger * bigInteger2, n, bigInteger3);
					}
					num4 <<= 1;
					bigInteger2 = eval_a(bigInteger2 * bigInteger2, n, bigInteger3);
					if (bigInteger2.dataLength == 1 && bigInteger2.b[0] == 1)
					{
						if (flag && (exp.b[0] & 1) != 0)
						{
							return -bigInteger;
						}
						return bigInteger;
					}
					num3++;
					if (num3 == num2)
					{
						break;
					}
				}
			}
			if (flag && (exp.b[0] & 1) != 0)
			{
				return -bigInteger;
			}
			return bigInteger;
		}

		public static void MulDivTest(int rounds)
		{
			Random random = new Random(World.GetRandomSeed());
			byte[] array = new byte[64];
			byte[] array2 = new byte[64];
			int num = 0;
			BigInteger bigInteger;
			BigInteger bigInteger2;
			BigInteger bigInteger3;
			BigInteger bigInteger4;
			BigInteger bigInteger5;
			while (true)
			{
				if (num >= rounds)
				{
					return;
				}
				int num2;
				for (num2 = 0; num2 == 0; num2 = (int)(random.NextDouble() * 65.0))
				{
				}
				int num3;
				for (num3 = 0; num3 == 0; num3 = (int)(random.NextDouble() * 65.0))
				{
				}
				bool flag = false;
				while (!flag)
				{
					for (int i = 0; i < 64; i++)
					{
						if (i < num2)
						{
							array[i] = (byte)(random.NextDouble() * 256.0);
						}
						else
						{
							array[i] = 0;
						}
						if (array[i] != 0)
						{
							flag = true;
						}
					}
				}
				flag = false;
				while (!flag)
				{
					for (int j = 0; j < 64; j++)
					{
						if (j < num3)
						{
							array2[j] = (byte)(random.NextDouble() * 256.0);
						}
						else
						{
							array2[j] = 0;
						}
						if (array2[j] != 0)
						{
							flag = true;
						}
					}
				}
				while (array[0] == 0)
				{
					array[0] = (byte)(random.NextDouble() * 256.0);
				}
				while (array2[0] == 0)
				{
					array2[0] = (byte)(random.NextDouble() * 256.0);
				}
				Console.WriteLine(num);
				bigInteger = new BigInteger(array, num2);
				bigInteger2 = new BigInteger(array2, num3);
				bigInteger3 = bigInteger / bigInteger2;
				bigInteger4 = bigInteger % bigInteger2;
				bigInteger5 = bigInteger3 * bigInteger2 + bigInteger4;
				if (bigInteger5 != bigInteger)
				{
					break;
				}
				num++;
			}
			Console.WriteLine("Error at " + num);
			Console.WriteLine(bigInteger + "\n");
			Console.WriteLine(bigInteger2 + "\n");
			Console.WriteLine(bigInteger3 + "\n");
			Console.WriteLine(bigInteger4 + "\n");
			Console.WriteLine(bigInteger5 + "\n");
		}

		public static BigInteger operator +(BigInteger bi1, BigInteger bi2)
		{
			BigInteger bigInteger = new BigInteger();
			bigInteger.dataLength = ((bi1.dataLength > bi2.dataLength) ? bi1.dataLength : bi2.dataLength);
			long num = 0L;
			for (int i = 0; i < bigInteger.dataLength; i++)
			{
				long num2 = bi1.b[i] + bi2.b[i] + num;
				num = num2 >> 32;
				bigInteger.b[i] = (uint)(num2 & uint.MaxValue);
			}
			if (num != 0 && bigInteger.dataLength < 70)
			{
				bigInteger.b[bigInteger.dataLength] = (uint)num;
				bigInteger.dataLength++;
			}
			while (bigInteger.dataLength > 1 && bigInteger.b[bigInteger.dataLength - 1] == 0)
			{
				bigInteger.dataLength--;
			}
			int num3 = 69;
			if (((int)bi1.b[69] & int.MinValue) == ((int)bi2.b[69] & int.MinValue) && ((int)bigInteger.b[num3] & int.MinValue) != ((int)bi1.b[num3] & int.MinValue))
			{
				throw new ArithmeticException();
			}
			return bigInteger;
		}

		public static BigInteger operator &(BigInteger bi1, BigInteger bi2)
		{
			BigInteger bigInteger = new BigInteger();
			int num = (bi1.dataLength > bi2.dataLength) ? bi1.dataLength : bi2.dataLength;
			for (int i = 0; i < num; i++)
			{
				bigInteger.b[i] = (bi1.b[i] & bi2.b[i]);
			}
			bigInteger.dataLength = 70;
			while (bigInteger.dataLength > 1)
			{
				if (bigInteger.b[bigInteger.dataLength - 1] != 0)
				{
					return bigInteger;
				}
				bigInteger.dataLength--;
			}
			return bigInteger;
		}

		public static BigInteger operator |(BigInteger bi1, BigInteger bi2)
		{
			BigInteger bigInteger = new BigInteger();
			int num = (bi1.dataLength > bi2.dataLength) ? bi1.dataLength : bi2.dataLength;
			for (int i = 0; i < num; i++)
			{
				bigInteger.b[i] = (bi1.b[i] | bi2.b[i]);
			}
			bigInteger.dataLength = 70;
			while (bigInteger.dataLength > 1)
			{
				if (bigInteger.b[bigInteger.dataLength - 1] != 0)
				{
					return bigInteger;
				}
				bigInteger.dataLength--;
			}
			return bigInteger;
		}

		public static BigInteger operator --(BigInteger bi1)
		{
			BigInteger bigInteger = new BigInteger(bi1);
			bool flag = true;
			int num = 0;
			while (flag && num < 70)
			{
				long num2 = bigInteger.b[num];
				num2--;
				bigInteger.b[num] = (uint)(num2 & uint.MaxValue);
				if (num2 >= 0)
				{
					flag = false;
				}
				num++;
			}
			if (num > bigInteger.dataLength)
			{
				bigInteger.dataLength = num;
			}
			while (bigInteger.dataLength > 1 && bigInteger.b[bigInteger.dataLength - 1] == 0)
			{
				bigInteger.dataLength--;
			}
			int num3 = 69;
			if (((int)bi1.b[69] & int.MinValue) != 0 && ((int)bigInteger.b[num3] & int.MinValue) != ((int)bi1.b[num3] & int.MinValue))
			{
				throw new ArithmeticException("Underflow in --.");
			}
			return bigInteger;
		}

		public static BigInteger operator /(BigInteger bi1, BigInteger bi2)
		{
			BigInteger bigInteger = new BigInteger();
			BigInteger a_ = new BigInteger();
			int num = 69;
			bool flag = false;
			bool flag2 = false;
			if (((int)bi1.b[69] & int.MinValue) != 0)
			{
				bi1 = -bi1;
				flag2 = true;
			}
			if (((int)bi2.b[num] & int.MinValue) != 0)
			{
				bi2 = -bi2;
				flag = true;
			}
			if (bi1 >= bi2)
			{
				if (bi2.dataLength == 1)
				{
					eval_a(bi1, bi2, bigInteger, a_);
				}
				else
				{
					eval_b(bi1, bi2, bigInteger, a_);
				}
				if (flag2 != flag)
				{
					return -bigInteger;
				}
			}
			return bigInteger;
		}

		public static bool operator ==(BigInteger bi1, BigInteger bi2)
		{
			return bi1.Equals(bi2);
		}

		public static BigInteger operator ^(BigInteger bi1, BigInteger bi2)
		{
			BigInteger bigInteger = new BigInteger();
			int num = (bi1.dataLength > bi2.dataLength) ? bi1.dataLength : bi2.dataLength;
			for (int i = 0; i < num; i++)
			{
				bigInteger.b[i] = (bi1.b[i] ^ bi2.b[i]);
			}
			bigInteger.dataLength = 70;
			while (bigInteger.dataLength > 1)
			{
				if (bigInteger.b[bigInteger.dataLength - 1] != 0)
				{
					return bigInteger;
				}
				bigInteger.dataLength--;
			}
			return bigInteger;
		}

		public static bool operator >(BigInteger bi1, BigInteger bi2)
		{
			int num = 69;
			if (((int)bi1.b[69] & int.MinValue) != 0 && ((int)bi2.b[num] & int.MinValue) == 0)
			{
				return false;
			}
			if (((int)bi1.b[num] & int.MinValue) == 0 && ((int)bi2.b[num] & int.MinValue) != 0)
			{
				return true;
			}
			int num2 = (bi1.dataLength > bi2.dataLength) ? bi1.dataLength : bi2.dataLength;
			num = num2 - 1;
			while (num >= 0 && bi1.b[num] == bi2.b[num])
			{
				num--;
			}
			if (num < 0)
			{
				return false;
			}
			return bi1.b[num] > bi2.b[num];
		}

		public static bool operator >=(BigInteger bi1, BigInteger bi2)
		{
			if (!(bi1 == bi2))
			{
				return bi1 > bi2;
			}
			return true;
		}

		public static implicit operator BigInteger(int value)
		{
			return new BigInteger(value);
		}

		public static implicit operator BigInteger(long value)
		{
			return new BigInteger(value);
		}

		public static implicit operator BigInteger(uint value)
		{
			return new BigInteger((ulong)value);
		}

		public static implicit operator BigInteger(ulong value)
		{
			return new BigInteger(value);
		}

		public static BigInteger operator ++(BigInteger bi1)
		{
			BigInteger bigInteger = new BigInteger(bi1);
			long num = 1L;
			int num2 = 0;
			while (num != 0 && num2 < 70)
			{
				long num3 = bigInteger.b[num2];
				num3++;
				bigInteger.b[num2] = (uint)(num3 & uint.MaxValue);
				num = num3 >> 32;
				num2++;
			}
			if (num2 <= bigInteger.dataLength)
			{
				while (bigInteger.dataLength > 1 && bigInteger.b[bigInteger.dataLength - 1] == 0)
				{
					bigInteger.dataLength--;
				}
			}
			else
			{
				bigInteger.dataLength = num2;
			}
			int num4 = 69;
			if (((int)bi1.b[69] & int.MinValue) == 0 && ((int)bigInteger.b[num4] & int.MinValue) != ((int)bi1.b[num4] & int.MinValue))
			{
				throw new ArithmeticException("Overflow in ++.");
			}
			return bigInteger;
		}

		public static bool operator !=(BigInteger bi1, BigInteger bi2)
		{
			return !bi1.Equals(bi2);
		}

		public static BigInteger operator <<(BigInteger bi1, int shiftVal)
		{
			BigInteger bigInteger = new BigInteger(bi1);
			bigInteger.dataLength = eval_b(bigInteger.b, shiftVal);
			return bigInteger;
		}

		public static bool operator <(BigInteger bi1, BigInteger bi2)
		{
			int num = 69;
			if (((int)bi1.b[69] & int.MinValue) != 0 && ((int)bi2.b[num] & int.MinValue) == 0)
			{
				return true;
			}
			if (((int)bi1.b[num] & int.MinValue) == 0 && ((int)bi2.b[num] & int.MinValue) != 0)
			{
				return false;
			}
			int num2 = (bi1.dataLength > bi2.dataLength) ? bi1.dataLength : bi2.dataLength;
			num = num2 - 1;
			while (num >= 0 && bi1.b[num] == bi2.b[num])
			{
				num--;
			}
			if (num < 0)
			{
				return false;
			}
			return bi1.b[num] < bi2.b[num];
		}

		public static bool operator <=(BigInteger bi1, BigInteger bi2)
		{
			if (!(bi1 == bi2))
			{
				return bi1 < bi2;
			}
			return true;
		}

		public static BigInteger operator %(BigInteger bi1, BigInteger bi2)
		{
			BigInteger a_ = new BigInteger();
			BigInteger bigInteger = new BigInteger(bi1);
			int num = 69;
			bool flag = false;
			if (((int)bi1.b[69] & int.MinValue) != 0)
			{
				bi1 = -bi1;
				flag = true;
			}
			if (((int)bi2.b[num] & int.MinValue) != 0)
			{
				bi2 = -bi2;
			}
			if (bi1 >= bi2)
			{
				if (bi2.dataLength == 1)
				{
					eval_a(bi1, bi2, a_, bigInteger);
				}
				else
				{
					eval_b(bi1, bi2, a_, bigInteger);
				}
				if (flag)
				{
					return -bigInteger;
				}
			}
			return bigInteger;
		}

		public static BigInteger operator *(BigInteger bi1, BigInteger bi2)
		{
			int num = 69;
			bool flag = false;
			bool flag2 = false;
			try
			{
				if (((int)bi1.b[num] & int.MinValue) != 0)
				{
					flag = true;
					bi1 = -bi1;
				}
				if (((int)bi2.b[num] & int.MinValue) != 0)
				{
					flag2 = true;
					bi2 = -bi2;
				}
			}
			catch (Exception)
			{
			}
			BigInteger bigInteger = new BigInteger();
			try
			{
				for (int i = 0; i < bi1.dataLength; i++)
				{
					if (bi1.b[i] != 0)
					{
						ulong num2 = 0uL;
						int num3 = 0;
						int num4 = i;
						while (num3 < bi2.dataLength)
						{
							ulong num5 = bi1.b[i] * bi2.b[num3] + bigInteger.b[num4] + num2;
							bigInteger.b[num4] = (uint)(num5 & uint.MaxValue);
							num2 = num5 >> 32;
							num3++;
							num4++;
						}
						if (num2 != 0)
						{
							bigInteger.b[i + bi2.dataLength] = (uint)num2;
						}
					}
				}
			}
			catch (Exception)
			{
				throw new ArithmeticException("Multiplication overflow.");
			}
			bigInteger.dataLength = bi1.dataLength + bi2.dataLength;
			if (bigInteger.dataLength > 70)
			{
				bigInteger.dataLength = 70;
			}
			while (bigInteger.dataLength > 1 && bigInteger.b[bigInteger.dataLength - 1] == 0)
			{
				bigInteger.dataLength--;
			}
			if (((int)bigInteger.b[num] & int.MinValue) == 0)
			{
				if (flag != flag2)
				{
					return -bigInteger;
				}
				return bigInteger;
			}
			if (flag != flag2 && bigInteger.b[num] == 2147483648u)
			{
				if (bigInteger.dataLength == 1)
				{
					return bigInteger;
				}
				bool flag3 = true;
				for (int j = 0; j < bigInteger.dataLength - 1; j++)
				{
					if (!flag3)
					{
						break;
					}
					if (bigInteger.b[j] != 0)
					{
						flag3 = false;
					}
				}
				if (flag3)
				{
					return bigInteger;
				}
			}
			throw new ArithmeticException("Multiplication overflow.");
		}

		public static BigInteger operator ~(BigInteger bi1)
		{
			BigInteger bigInteger = new BigInteger(bi1);
			for (int i = 0; i < 70; i++)
			{
				bigInteger.b[i] = ~bi1.b[i];
			}
			bigInteger.dataLength = 70;
			while (bigInteger.dataLength > 1)
			{
				if (bigInteger.b[bigInteger.dataLength - 1] != 0)
				{
					return bigInteger;
				}
				bigInteger.dataLength--;
			}
			return bigInteger;
		}

		public static BigInteger operator >>(BigInteger bi1, int shiftVal)
		{
			BigInteger bigInteger = new BigInteger(bi1);
			bigInteger.dataLength = eval_a(bigInteger.b, shiftVal);
			if (((int)bi1.b[69] & int.MinValue) != 0)
			{
				for (int num = 69; num >= bigInteger.dataLength; num--)
				{
					bigInteger.b[num] = uint.MaxValue;
				}
				uint num2 = 2147483648u;
				for (int i = 0; i < 32; i++)
				{
					if ((bigInteger.b[bigInteger.dataLength - 1] & num2) != 0)
					{
						break;
					}
					bigInteger.b[bigInteger.dataLength - 1] |= num2;
					num2 >>= 1;
				}
				bigInteger.dataLength = 70;
			}
			return bigInteger;
		}

		public static BigInteger operator -(BigInteger bi1, BigInteger bi2)
		{
			BigInteger bigInteger = new BigInteger();
			bigInteger.dataLength = ((bi1.dataLength > bi2.dataLength) ? bi1.dataLength : bi2.dataLength);
			long num = 0L;
			for (int i = 0; i < bigInteger.dataLength; i++)
			{
				long num2 = bi1.b[i] - bi2.b[i] - num;
				bigInteger.b[i] = (uint)(num2 & uint.MaxValue);
				num = ((num2 >= 0) ? 0 : 1);
			}
			if (num != 0)
			{
				for (int j = bigInteger.dataLength; j < 70; j++)
				{
					bigInteger.b[j] = uint.MaxValue;
				}
				bigInteger.dataLength = 70;
			}
			while (bigInteger.dataLength > 1 && bigInteger.b[bigInteger.dataLength - 1] == 0)
			{
				bigInteger.dataLength--;
			}
			int num3 = 69;
			if (((int)bi1.b[69] & int.MinValue) != ((int)bi2.b[69] & int.MinValue) && ((int)bigInteger.b[num3] & int.MinValue) != ((int)bi1.b[num3] & int.MinValue))
			{
				throw new ArithmeticException();
			}
			return bigInteger;
		}

		public static BigInteger operator -(BigInteger bi1)
		{
			if (bi1.dataLength == 1 && bi1.b[0] == 0)
			{
				return new BigInteger();
			}
			BigInteger bigInteger = new BigInteger(bi1);
			for (int i = 0; i < 70; i++)
			{
				bigInteger.b[i] = ~bi1.b[i];
			}
			long num = 1L;
			int num2 = 0;
			while (num != 0 && num2 < 70)
			{
				long num3 = bigInteger.b[num2];
				num3++;
				bigInteger.b[num2] = (uint)(num3 & uint.MaxValue);
				num = num3 >> 32;
				num2++;
			}
			if (((int)bi1.b[69] & int.MinValue) == ((int)bigInteger.b[69] & int.MinValue))
			{
				throw new ArithmeticException("Overflow in negation.\n");
			}
			bigInteger.dataLength = 70;
			while (bigInteger.dataLength > 1)
			{
				if (bigInteger.b[bigInteger.dataLength - 1] != 0)
				{
					return bigInteger;
				}
				bigInteger.dataLength--;
			}
			return bigInteger;
		}

		public bool RabinMillerTest(int confidence)
		{
			BigInteger bigInteger = (((int)b[69] & int.MinValue) == 0) ? this : (-this);
			if (bigInteger.dataLength == 1)
			{
				if (bigInteger.b[0] == 0 || bigInteger.b[0] == 1)
				{
					return false;
				}
				if (bigInteger.b[0] == 2 || bigInteger.b[0] == 3)
				{
					return true;
				}
			}
			if ((bigInteger.b[0] & 1) == 0)
			{
				return false;
			}
			BigInteger bigInteger2 = bigInteger - new BigInteger(1L);
			int num = 0;
			for (int i = 0; i < bigInteger2.dataLength; i++)
			{
				uint num2 = 1u;
				for (int j = 0; j < 32; j++)
				{
					if ((bigInteger2.b[i] & num2) == 0)
					{
						num2 <<= 1;
						num++;
						continue;
					}
					i = bigInteger2.dataLength;
					break;
				}
			}
			BigInteger exp = bigInteger2 >> num;
			int num3 = bigInteger.bitCount();
			BigInteger bigInteger3 = new BigInteger();
			Random random = new Random(World.GetRandomSeed());
			for (int k = 0; k < confidence; k++)
			{
				bool flag = false;
				while (!flag)
				{
					for (int num4 = 0; num4 < 2; num4 = (int)(random.NextDouble() * (double)num3))
					{
					}
					int num5 = bigInteger3.dataLength;
					if (num5 > 1 || (num5 == 1 && bigInteger3.b[0] != 1))
					{
						flag = true;
					}
				}
				BigInteger bigInteger4 = bigInteger3.gcd(bigInteger);
				if (bigInteger4.dataLength == 1 && bigInteger4.b[0] != 1)
				{
					return false;
				}
				BigInteger bigInteger5 = bigInteger3.modPow(exp, bigInteger);
				bool flag2 = false;
				if (bigInteger5.dataLength == 1 && bigInteger5.b[0] == 1)
				{
					flag2 = true;
				}
				int num6 = 0;
				while (!flag2 && num6 < num)
				{
					if (!(bigInteger5 == bigInteger2))
					{
						bigInteger5 = bigInteger5 * bigInteger5 % bigInteger;
						num6++;
						continue;
					}
					flag2 = true;
					break;
				}
				if (!flag2)
				{
					return false;
				}
			}
			return true;
		}

		public static void RSATest(int rounds)
		{
			Random random = new Random(1);
			byte[] array = new byte[64];
			BigInteger bigInteger = new BigInteger("a932b948feed4fb2b692609bd22164fc9edb59fae7880cc1eaff7b3c9626b7e5b241c27a974833b2622ebe09beb451917663d47232488f23a117fc97720f1e7", 16);
			BigInteger bigInteger2 = new BigInteger("4adf2f7a89da93248509347d2ae506d683dd3a16357e859a980c4f77a4e2f7a01fae289f13a851df6e9db5adaa60bfd2b162bbbe31f7c8f828261a6839311929d2cef4f864dde65e556ce43c89bbbf9f1ac5511315847ce9cc8dc92470a747b8792d6a83b0092d2e5ebaf852c85cacf34278efa99160f2f8aa7ee7214de07b7", 16);
			BigInteger bigInteger3 = new BigInteger("e8e77781f36a7b3188d711c2190b560f205a52391b3479cdb99fa010745cbeba5f2adc08e1de6bf38398a0487c4a73610d94ec36f17f3f46ad75e17bc1adfec99839589f45f95ccc94cb2a5c500b477eb3323d8cfab0c8458c96f0147a45d27e45a4d11d54d77684f65d48f15fafcc1ba208e71e921b9bd9017c16a5231af7f", 16);
			Console.WriteLine("e =\n" + bigInteger.ToString(10));
			Console.WriteLine("\nd =\n" + bigInteger2.ToString(10));
			Console.WriteLine("\nn =\n" + bigInteger3.ToString(10) + "\n");
			int num = 0;
			BigInteger bigInteger4;
			while (true)
			{
				if (num >= rounds)
				{
					return;
				}
				int num2;
				for (num2 = 0; num2 == 0; num2 = (int)(random.NextDouble() * 65.0))
				{
				}
				bool flag = false;
				while (!flag)
				{
					for (int i = 0; i < 64; i++)
					{
						if (i < num2)
						{
							array[i] = (byte)(random.NextDouble() * 256.0);
						}
						else
						{
							array[i] = 0;
						}
						if (array[i] != 0)
						{
							flag = true;
						}
					}
				}
				while (array[0] == 0)
				{
					array[0] = (byte)(random.NextDouble() * 256.0);
				}
				Console.Write("Round = " + num);
				bigInteger4 = new BigInteger(array, num2);
				if (bigInteger4.modPow(bigInteger, bigInteger3).modPow(bigInteger2, bigInteger3) != bigInteger4)
				{
					break;
				}
				Console.WriteLine(" <PASSED>.");
				num++;
			}
			Console.WriteLine("\nError at round " + num);
			Console.WriteLine(bigInteger4 + "\n");
		}

		public static void RSATest2(int rounds)
		{
			Random random = new Random(World.GetRandomSeed());
			byte[] array = new byte[64];
			byte[] inData = new byte[64]
			{
				133,
				132,
				100,
				253,
				112,
				106,
				159,
				240,
				148,
				12,
				62,
				44,
				116,
				52,
				5,
				201,
				85,
				179,
				133,
				50,
				152,
				113,
				249,
				65,
				33,
				95,
				2,
				158,
				234,
				86,
				141,
				140,
				68,
				204,
				238,
				238,
				61,
				44,
				157,
				44,
				18,
				65,
				30,
				241,
				197,
				50,
				195,
				170,
				49,
				74,
				82,
				216,
				232,
				175,
				66,
				244,
				114,
				161,
				42,
				13,
				151,
				177,
				49,
				179
			};
			byte[] inData2 = new byte[64]
			{
				153,
				152,
				202,
				184,
				94,
				215,
				229,
				220,
				40,
				92,
				111,
				14,
				21,
				9,
				89,
				110,
				132,
				243,
				129,
				205,
				222,
				66,
				220,
				147,
				194,
				122,
				98,
				172,
				108,
				175,
				222,
				116,
				227,
				203,
				96,
				32,
				56,
				156,
				33,
				195,
				220,
				200,
				162,
				77,
				198,
				42,
				53,
				127,
				243,
				169,
				232,
				29,
				123,
				44,
				120,
				250,
				184,
				2,
				85,
				128,
				155,
				194,
				165,
				203
			};
			BigInteger bi = new BigInteger(inData);
			BigInteger bigInteger = new BigInteger(inData2);
			BigInteger bigInteger2 = (bi - 1) * (bigInteger - 1);
			BigInteger bigInteger3 = bi * bigInteger;
			int num = 0;
			BigInteger bigInteger6;
			while (true)
			{
				if (num >= rounds)
				{
					return;
				}
				BigInteger bigInteger4 = bigInteger2.genCoPrime(512, random);
				BigInteger bigInteger5 = bigInteger4.modInverse(bigInteger2);
				Console.WriteLine("\ne =\n" + bigInteger4.ToString(10));
				Console.WriteLine("\nd =\n" + bigInteger5.ToString(10));
				Console.WriteLine("\nn =\n" + bigInteger3.ToString(10) + "\n");
				int num2;
				for (num2 = 0; num2 == 0; num2 = (int)(random.NextDouble() * 65.0))
				{
				}
				bool flag = false;
				while (!flag)
				{
					for (int i = 0; i < 64; i++)
					{
						if (i < num2)
						{
							array[i] = (byte)(random.NextDouble() * 256.0);
						}
						else
						{
							array[i] = 0;
						}
						if (array[i] != 0)
						{
							flag = true;
						}
					}
				}
				while (array[0] == 0)
				{
					array[0] = (byte)(random.NextDouble() * 256.0);
				}
				Console.Write("Round = " + num);
				bigInteger6 = new BigInteger(array, num2);
				if (bigInteger6.modPow(bigInteger4, bigInteger3).modPow(bigInteger5, bigInteger3) != bigInteger6)
				{
					break;
				}
				Console.WriteLine(" <PASSED>.");
				num++;
			}
			Console.WriteLine("\nError at round " + num);
			Console.WriteLine(bigInteger6 + "\n");
		}

		public void setBit(uint bitNum)
		{
			uint num = bitNum >> 5;
			byte b = (byte)(bitNum & 0x1F);
			uint num2 = (uint)(1 << (int)b);
			this.b[num] |= num2;
			if (num >= dataLength)
			{
				dataLength = (int)(num + 1);
			}
		}

		public bool SolovayStrassenTest(int confidence)
		{
			BigInteger bigInteger = (((int)b[69] & int.MinValue) == 0) ? this : (-this);
			if (bigInteger.dataLength == 1)
			{
				if (bigInteger.b[0] == 0 || bigInteger.b[0] == 1)
				{
					return false;
				}
				if (bigInteger.b[0] == 2 || bigInteger.b[0] == 3)
				{
					return true;
				}
			}
			if ((bigInteger.b[0] & 1) == 0)
			{
				return false;
			}
			int num = bigInteger.bitCount();
			BigInteger bigInteger2 = new BigInteger();
			BigInteger bigInteger3 = bigInteger - 1;
			BigInteger exp = bigInteger3 >> 1;
			Random random = new Random(World.GetRandomSeed());
			for (int i = 0; i < confidence; i++)
			{
				bool flag = false;
				while (!flag)
				{
					for (int num2 = 0; num2 < 2; num2 = (int)(random.NextDouble() * (double)num))
					{
					}
					int num3 = bigInteger2.dataLength;
					if (num3 > 1 || (num3 == 1 && bigInteger2.b[0] != 1))
					{
						flag = true;
					}
				}
				BigInteger bigInteger4 = bigInteger2.gcd(bigInteger);
				if (bigInteger4.dataLength == 1 && bigInteger4.b[0] != 1)
				{
					return false;
				}
				BigInteger bi = bigInteger2.modPow(exp, bigInteger);
				if (bi == bigInteger3)
				{
					bi = -1;
				}
				BigInteger bi2 = Jacobi(bigInteger2, bigInteger);
				if (bi != bi2)
				{
					return false;
				}
			}
			return true;
		}

		public BigInteger sqrt()
		{
			uint num = (uint)bitCount();
			num = (((num & 1) == 0) ? (num >> 1) : ((num >> 1) + 1));
			uint num2 = num >> 5;
			byte b = (byte)(num & 0x1F);
			BigInteger bigInteger = new BigInteger();
			uint num3;
			if (b == 0)
			{
				num3 = 2147483648u;
			}
			else
			{
				num3 = (uint)(1 << (int)b);
				num2++;
			}
			bigInteger.dataLength = (int)num2;
			for (int num4 = (int)(num2 - 1); num4 >= 0; num4--)
			{
				while (num3 != 0)
				{
					bigInteger.b[num4] ^= num3;
					if (bigInteger * bigInteger > this)
					{
						bigInteger.b[num4] ^= num3;
					}
					num3 >>= 1;
				}
				num3 = 2147483648u;
			}
			return bigInteger;
		}

		public static void SqrtTest(int rounds)
		{
			Random random = new Random(World.GetRandomSeed());
			int num = 0;
			BigInteger bigInteger;
			while (true)
			{
				if (num < rounds)
				{
					for (int num2 = 0; num2 == 0; num2 = (int)(random.NextDouble() * 1024.0))
					{
					}
					Console.Write("Round = " + num);
					bigInteger = new BigInteger();
					BigInteger bi = bigInteger.sqrt();
					BigInteger bi2 = (bi + 1) * (bi + 1);
					if (bi2 <= bigInteger)
					{
						break;
					}
					Console.WriteLine(" <PASSED>.");
					num++;
					continue;
				}
				return;
			}
			Console.WriteLine("\nError at round " + num);
			Console.WriteLine(bigInteger + "\n");
		}

		public string ToHexString()
		{
			string text = b[dataLength - 1].ToString("X");
			for (int num = dataLength - 2; num >= 0; num--)
			{
				text += b[num].ToString("X8");
			}
			return text;
		}

		public override string ToString()
		{
			return ToString(10);
		}

		public string ToString(int radix)
		{
			if (radix < 2 || radix > 36)
			{
				throw new ArgumentException("Radix must be >= 2 and <= 36");
			}
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			string text2 = "";
			BigInteger bigInteger = this;
			bool flag = false;
			if (((int)bigInteger.b[69] & int.MinValue) != 0)
			{
				flag = true;
				try
				{
					bigInteger = -bigInteger;
				}
				catch (Exception)
				{
				}
			}
			BigInteger bigInteger2 = new BigInteger();
			BigInteger bigInteger3 = new BigInteger();
			BigInteger a_ = new BigInteger(radix);
			if (bigInteger.dataLength != 1 || bigInteger.b[0] != 0)
			{
				while (bigInteger.dataLength > 1 || (bigInteger.dataLength == 1 && bigInteger.b[0] != 0))
				{
					eval_a(bigInteger, a_, bigInteger2, bigInteger3);
					text2 = ((bigInteger3.b[0] >= 10) ? (text[(int)(bigInteger3.b[0] - 10)] + text2) : (bigInteger3.b[0] + text2));
					bigInteger = bigInteger2;
				}
				if (flag)
				{
					text2 = "-" + text2;
				}
				return text2;
			}
			return "0";
		}

		public void unsetBit(uint bitNum)
		{
			uint num = bitNum >> 5;
			if (num < dataLength)
			{
				byte b = (byte)(bitNum & 0x1F);
				uint num2 = (uint)(1 << (int)b);
				uint num3 = (uint)(-1 ^ (int)num2);
				this.b[num] &= num3;
				if (dataLength > 1 && this.b[dataLength - 1] == 0)
				{
					dataLength--;
				}
			}
		}
	}
}

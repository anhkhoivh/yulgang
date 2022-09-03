using System;
using System.Text;

namespace RxjhServer
{
	public class RC6
	{
		private const int b = 20;

		private const int c = 4;

		private const int eval_a_a = 32;

		public Encoding Enc_default;

		private string eval_d;

		private int eval_e;

		private uint[] eval_f;

		private uint[] eval_g;

		public string m_sCryptedText;

		public int IV
		{
			get
			{
				return eval_e;
			}
			set
			{
				eval_e = value;
			}
		}

		public string KEY
		{
			get
			{
				return eval_d;
			}
			set
			{
				eval_d = value;
			}
		}

		public RC6()
		{
			Enc_default = Encoding.Unicode;
			IV = 16;
			eval_f = new uint[8 * eval_e];
		}

		public RC6(int iv)
		{
			Enc_default = Encoding.Unicode;
			IV = iv;
			eval_f = new uint[8 * eval_e];
		}

		public int _IV()
		{
			if (eval_e < 16)
			{
				eval_e = 16;
			}
			if (eval_e > 32)
			{
				eval_e = 32;
			}
			return eval_e;
		}

		public string Decrypt(string str, string prssword)
		{
			str = ((str.Length % 32 != 0) ? str.PadRight(str.Length + (32 - str.Length % 32), '\0') : str);
			KEY = prssword;
			eval_a();
			uint num2;
			uint num;
			uint num3;
			uint num4 = num3 = (num2 = (num = 0u));
			uint num5 = 0u;
			byte[] bytes = Enc_default.GetBytes(str);
			byte[] array = new byte[bytes.Length];
			for (int i = 0; i < 4; i++)
			{
				num4 = (uint)((int)num4 + ((bytes[2 * i] & 0xFF) << 8 * i));
				num3 = (uint)((int)num3 + ((bytes[2 * i + 8] & 0xFF) << 8 * i));
				num2 = (uint)((int)num2 + ((bytes[2 * i + 16] & 0xFF) << 8 * i));
				num = (uint)((int)num + ((bytes[2 * i + 24] & 0xFF) << 8 * i));
			}
			num2 -= eval_f[43];
			num4 -= eval_f[42];
			for (int j = 1; j <= eval_e; j++)
			{
				num5 = num;
				num = num2;
				num2 = num3;
				num3 = num4;
				num4 = num5;
			}
			num -= eval_f[1];
			num3 -= eval_f[0];
			for (int k = 0; k < 4; k++)
			{
				array[2 * k] = (byte)((num4 >> 8 * k) & 0xFF);
				array[2 * k + 8] = (byte)((num3 >> 8 * k) & 0xFF);
				array[2 * k + 16] = (byte)((num2 >> 8 * k) & 0xFF);
				array[2 * k + 24] = (byte)((num >> 8 * k) & 0xFF);
			}
			char[] array2 = new char[Enc_default.GetCharCount(array, 0, array.Length)];
			Enc_default.GetChars(array, 0, array.Length, array2, 0);
			m_sCryptedText = new string(array2, 0, array2.Length);
			Enc_default.GetBytes(m_sCryptedText);
			return m_sCryptedText;
		}

		public string Encrypt(string str, string prssword)
		{
			str = ((str.Length % 32 != 0) ? str.PadRight(str.Length + (32 - str.Length % 32), '\0') : str);
			KEY = prssword;
			eval_a();
			uint num3;
			uint num;
			uint num2;
			uint num4 = num3 = (num2 = (num = 0u));
			uint num5 = 0u;
			byte[] bytes = Encoding.Unicode.GetBytes(str);
			char[] chars = new char[Encoding.ASCII.GetCharCount(bytes, 0, bytes.Length)];
			Encoding.ASCII.GetChars(bytes, 0, bytes.Length, chars, 0);
			byte[] array = new byte[bytes.Length];
			for (int i = 0; i < 4; i++)
			{
				num4 = (uint)((int)num4 + ((bytes[2 * i] & 0xFF) << 8 * i));
				num3 = (uint)((int)num3 + ((bytes[2 * i + 8] & 0xFF) << 8 * i));
				num2 = (uint)((int)num2 + ((bytes[2 * i + 16] & 0xFF) << 8 * i));
				num = (uint)((int)num + ((bytes[2 * i + 24] & 0xFF) << 8 * i));
			}
			num3 += eval_f[0];
			num += eval_f[1];
			for (int j = 1; j <= eval_e; j++)
			{
				num5 = num4;
				num4 = num3;
				num3 = num2;
				num2 = num;
				num = num5;
			}
			uint[] array2 = new uint[4];
			num4 += eval_f[42];
			num2 += eval_f[43];
			array2[0] = num4;
			array2[1] = num3;
			array2[2] = num2;
			array2[3] = num;
			for (int k = 0; k < 4; k++)
			{
				array[2 * k] = (byte)((array2[0] >> 8 * k) & 0xFF);
				array[2 * k + 8] = (byte)((array2[1] >> 8 * k) & 0xFF);
				array[2 * k + 16] = (byte)((array2[2] >> 8 * k) & 0xFF);
				array[2 * k + 24] = (byte)((array2[3] >> 8 * k) & 0xFF);
			}
			char[] array3 = new char[array.Length];
			Encoding.Unicode.GetChars(array, 0, array.Length, array3, 0);
			m_sCryptedText = new string(array3, 0, array3.Length);
			Enc_default.GetBytes(m_sCryptedText);
			return m_sCryptedText;
		}

		private void eval_a()
		{
			uint num = 3084996963u;
			uint num2 = 2654435769u;
			uint num3;
			uint num4 = num3 = 0u;
			int num5;
			int num6 = num5 = 0;
			char[] array = eval_b();
			eval_g = new uint[eval_e / 4];
			for (num5 = 0; num5 < eval_e; num5++)
			{
				uint num7 = (uint)((array[num5] & 0xFF) << 8 * (num5 % 4));
				eval_g[num5 / 4] += num7;
			}
			eval_f[0] = num;
			for (num5 = 1; num5 < 2 * eval_e + 4; num5++)
			{
				eval_f[num5] = eval_f[num5 - 1] + num2;
			}
			int num8 = 3 * Math.Max(eval_g.Length, 2 * eval_e + 4);
			num5 = 0;
			num6 = 0;
			while (num8 > 0)
			{
				eval_f[num6] = (byte)num4;
				num3 += num4;
				num6 = (num6 + 1) % (2 * eval_e + 4);
				num5 = (num5 + 1) % eval_g.Length;
				num8--;
			}
		}

		private char[] eval_b()
		{
			string text = eval_d;
			text = ((text.Length % eval_e != 0) ? text.PadRight(text.Length + (eval_e - text.Length % eval_e), '\0') : text);
			byte[] array = Encoding.Convert(Encoding.Unicode, Encoding.ASCII, Encoding.Unicode.GetBytes(text));
			char[] array2 = new char[Encoding.ASCII.GetCharCount(array, 0, array.Length)];
			Encoding.ASCII.GetChars(array, 0, array.Length, array2, 0);
			return array2;
		}
	}
}

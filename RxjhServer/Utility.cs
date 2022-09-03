using System.IO;
using System.Text;

namespace RxjhServer
{
	public static class Utility
	{
		private static Encoding eval_a;

		public static Encoding UTF8
		{
			get
			{
				if (eval_a == null)
				{
					eval_a = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: false);
				}
				return eval_a;
			}
		}

		public static void FormatBuffer(TextWriter output, Stream input, int length)
		{
			output.WriteLine("        0  1  2  3  4  5  6  7   8  9  A  B  C  D  E  F");
			output.WriteLine("       -- -- -- -- -- -- -- --  -- -- -- -- -- -- -- --");
			int num = 0;
			int num2 = length >> 4;
			int num3 = length & 0xF;
			int num4 = 0;
			while (num4 < num2)
			{
				StringBuilder stringBuilder = new StringBuilder(49);
				StringBuilder stringBuilder2 = new StringBuilder(16);
				for (int i = 0; i < 16; i++)
				{
					int num5 = input.ReadByte();
					stringBuilder.Append(num5.ToString("X2"));
					if (i != 7)
					{
						stringBuilder.Append(' ');
					}
					else
					{
						stringBuilder.Append("  ");
					}
					if (num5 >= 32 && num5 < 128)
					{
						stringBuilder2.Append((char)num5);
					}
					else
					{
						stringBuilder2.Append('.');
					}
				}
				output.Write(num.ToString("X4"));
				output.Write("   ");
				output.Write(stringBuilder.ToString());
				output.Write("  ");
				output.WriteLine(stringBuilder2.ToString());
				num4++;
				num += 16;
			}
			if (num3 == 0)
			{
				return;
			}
			StringBuilder stringBuilder3 = new StringBuilder(49);
			StringBuilder stringBuilder4 = new StringBuilder(num3);
			for (int j = 0; j < 16; j++)
			{
				if (j < num3)
				{
					int num6 = input.ReadByte();
					stringBuilder3.Append(num6.ToString("X2"));
					if (j != 7)
					{
						stringBuilder3.Append(' ');
					}
					else
					{
						stringBuilder3.Append("  ");
					}
					if (num6 >= 32 && num6 < 128)
					{
						stringBuilder4.Append((char)num6);
					}
					else
					{
						stringBuilder4.Append('.');
					}
				}
				else
				{
					stringBuilder3.Append("   ");
				}
			}
			output.Write(num.ToString("X4"));
			output.Write("   ");
			output.Write(stringBuilder3.ToString());
			output.Write("  ");
			output.WriteLine(stringBuilder4.ToString());
		}
	}
}

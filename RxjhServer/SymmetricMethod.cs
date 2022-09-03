using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace RxjhServer
{
	public class SymmetricMethod
	{
		private SymmetricAlgorithm eval_a_a = new RijndaelManaged();

		public string Key;

		public string Decrypto(string Source)
		{
			try
			{
				byte[] array = Convert.FromBase64String(Source);
				MemoryStream stream = new MemoryStream(array, 0, array.Length);
				string text = "";
				int length = Source.Length;
				text = "";
				int num = Convert.ToInt32(Source.ToCharArray(0, 1)[0]) % 10;
				for (int i = 2; i < length; i += 2)
				{
					int num2 = Convert.ToInt32(Source.ToCharArray(i, 1)[0]);
					string str = (Convert.ToInt32(Source.ToCharArray(i - 1, 1)[0]) % 2 != 0) ? ((char)(ushort)(num2 - (i - 1) / 2 - num)).ToString() : ((char)(ushort)(num2 + (i - 1) / 2 + num)).ToString();
					text += str;
				}
				eval_a_a.Key = eval_a();
				eval_a_a.IV = eval_b();
				ICryptoTransform transform = eval_a_a.CreateDecryptor();
				CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
				StreamReader streamReader = new StreamReader(stream2);
				return streamReader.ReadToEnd();
			}
			catch
			{
				return "";
			}
		}

		public string Encrypto(string Source)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(Source);
			MemoryStream memoryStream = new MemoryStream();
			eval_a_a.Key = eval_a();
			eval_a_a.IV = eval_b();
			ICryptoTransform transform = eval_a_a.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			memoryStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		private byte[] eval_a()
		{
			string text = Key;
			eval_a_a.GenerateKey();
			int num = eval_a_a.Key.Length;
			if (text.Length > num)
			{
				text = text.Substring(text.Length - num, num);
			}
			else if (text.Length < num)
			{
				text = text.PadRight(num, ' ');
			}
			return Encoding.ASCII.GetBytes(text);
		}

		private byte[] eval_b()
		{
			string text = eval_c();
			eval_a_a.GenerateIV();
			int num = eval_a_a.IV.Length;
			if (text.Length > num)
			{
				text = text.Substring(text.Length - num, num);
			}
			else if (text.Length < num)
			{
				text = text.PadRight(num, ' ');
			}
			return Encoding.ASCII.GetBytes(text);
		}

		internal string eval_c()
		{
			byte[] bytes = new byte[128]
			{
				69,
				0,
				52,
				0,
				103,
				0,
				104,
				0,
				106,
				0,
				42,
				0,
				71,
				0,
				104,
				0,
				103,
				0,
				55,
				0,
				33,
				0,
				114,
				0,
				78,
				0,
				73,
				0,
				102,
				0,
				98,
				0,
				38,
				0,
				57,
				0,
				53,
				0,
				71,
				0,
				85,
				0,
				89,
				0,
				56,
				0,
				54,
				0,
				71,
				0,
				102,
				0,
				103,
				0,
				104,
				0,
				85,
				0,
				98,
				0,
				35,
				0,
				101,
				0,
				114,
				0,
				53,
				0,
				55,
				0,
				72,
				0,
				66,
				0,
				104,
				0,
				40,
				0,
				117,
				0,
				37,
				0,
				103,
				0,
				54,
				0,
				72,
				0,
				74,
				0,
				40,
				0,
				36,
				0,
				106,
				0,
				104,
				0,
				87,
				0,
				107,
				0,
				55,
				0,
				38,
				0,
				33,
				0,
				104,
				0,
				103,
				0,
				52,
				0,
				117,
				0,
				105,
				0,
				37,
				0,
				36,
				0,
				104,
				0,
				106,
				0,
				107,
				0
			};
			return Encoding.Unicode.GetString(bytes);
		}

		internal string eval_d()
		{
			return "sx465sdga@3sda465f2YU^()3423DSAfa65hy4w6@#%&#256416526546y64362g564u8jas$#^@gvdey73q";
		}
	}
}

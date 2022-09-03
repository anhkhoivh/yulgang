using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RxjhServer
{
	public class ClassRSA
	{
		private string eval_a_a = "<RSAKeyValue><Modulus>kvycp4oTqsSqG+7fAqRdG4gCmZD5KJ2ESGyQDLj+4TGnPWq+m9ZPm4Hbk0/hMTA2XWoItP0/SB30Kc37AdY7w/hkHu4oTtrdOtXElMTNN+VQMkaucX366m+v6yKhK0CABVIsvYeVBjKAU/Wk+HJd821um0tlfkMEBCNAApLBJdk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

		public string DecryptByPublicKey(string inputString)
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(1024);
			rSACryptoServiceProvider.FromXmlString(eval_a_a);
			RSAParameters rSAParameters = rSACryptoServiceProvider.ExportParameters(includePrivateParameters: false);
			byte[] modulus = rSAParameters.Modulus;
			byte[] exponent = rSAParameters.Exponent;
			BigInteger a_ = new BigInteger(modulus);
			BigInteger a_2 = new BigInteger(exponent);
			int num = 172;
			int num2 = inputString.Length / 172;
			ArrayList arrayList = new ArrayList();
			for (int i = 0; i < num2; i++)
			{
				byte[] array = Convert.FromBase64String(inputString.Substring(num * i, num));
				Array.Reverse(array);
				arrayList.AddRange(eval_a(array, a_2, a_));
			}
			return Encoding.UTF8.GetString(arrayList.ToArray(Type.GetType("System.Byte")) as byte[]);
		}

		public string EncryptByPublicKey(string dataStr)
		{
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(1024);
			rSACryptoServiceProvider.FromXmlString(eval_a_a);
			RSAParameters rSAParameters = rSACryptoServiceProvider.ExportParameters(includePrivateParameters: false);
			byte[] modulus = rSAParameters.Modulus;
			byte[] exponent = rSAParameters.Exponent;
			BigInteger a_ = new BigInteger(modulus);
			BigInteger a_2 = new BigInteger(exponent);
			byte[] bytes = Encoding.UTF8.GetBytes(dataStr);
			int num = 86;
			int num2 = bytes.Length;
			int num3 = num2 / 86;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i <= num3; i++)
			{
				byte[] array = new byte[(num2 - num * i > num) ? num : (num2 - num * i)];
				Buffer.BlockCopy(bytes, num * i, array, 0, array.Length);
				byte[] array2 = eval_b(array, a_2, a_);
				Array.Reverse(array2);
				stringBuilder.Append(Convert.ToBase64String(array2));
			}
			return stringBuilder.ToString();
		}

		private byte[] eval_a(byte[] A_0, BigInteger A_1, BigInteger A_2)
		{
			int num = A_0.Length;
			int num2 = 0;
			int num3 = 0;
			num2 = ((num % 128 != 0) ? (num / 128 + 1) : (num / 128));
			List<byte> list = new List<byte>();
			for (int i = 0; i < num2; i++)
			{
				num3 = ((num < 128) ? num : 128);
				byte[] array = new byte[num3];
				Array.Copy(A_0, i * 128, array, 0, num3);
				BigInteger bigInteger = new BigInteger(array);
				byte[] bytes = bigInteger.modPow(A_1, A_2).getBytes();
				Encoding.UTF8.GetString(bytes);
				list.AddRange(bytes);
				num -= num3;
			}
			return list.ToArray();
		}

		private byte[] eval_b(byte[] A_0, BigInteger A_1, BigInteger A_2)
		{
			int num = A_0.Length;
			int num2 = 0;
			int num3 = 0;
			num2 = ((num % 120 != 0) ? (num / 120 + 1) : (num / 120));
			List<byte> list = new List<byte>();
			for (int i = 0; i < num2; i++)
			{
				num3 = ((num < 120) ? num : 120);
				byte[] array = new byte[num3];
				Array.Copy(A_0, i * 120, array, 0, num3);
				Encoding.UTF8.GetString(array);
				BigInteger bigInteger = new BigInteger(array);
				string text = bigInteger.modPow(A_1, A_2).ToHexString();
				if (text.Length < 256)
				{
					while (text.Length != 256)
					{
						text = "0" + text;
					}
				}
				byte[] array2 = new byte[128];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = Convert.ToByte(text.Substring(j * 2, 2), 16);
				}
				list.AddRange(array2);
				num -= num3;
			}
			return list.ToArray();
		}
	}
}

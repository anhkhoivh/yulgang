using System;
using System.Runtime.InteropServices;

namespace RxjhServer
{
	public class ClassDllImport
	{
		public delegate int Decrypt(byte[] lpBuffer, int nDataLength);

		private static IntPtr eval_a_a;

		public static void Decrypta(byte[] lpBuffer, int nDataLength)
		{
			try
			{
				int num = ((Decrypt)eval_a(eval_a_a, "Decrypt", typeof(Decrypt)))(lpBuffer, nDataLength);
			}
			catch (Exception)
			{
				Form1.WriteLine(1, "rxjhDeBuf.dll版本错误");
			}
		}

		private static Delegate eval_a(IntPtr A_0, string A_1, Type A_2)
		{
			int procAddress = GetProcAddress(eval_a_a, A_1);
			if (procAddress == 0)
			{
				return null;
			}
			return Marshal.GetDelegateForFunctionPointer(new IntPtr(procAddress), A_2);
		}

		public static void FreeLib()
		{
			FreeLibrary(eval_a_a);
		}

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern bool FreeLibrary(IntPtr hModule);

		[DllImport("kernel32.dll", SetLastError = true)]
		public static extern int GetProcAddress(IntPtr hModule, string lpProcName);

		public static void LoadLib()
		{
			string lpFileName = "rxjhDeBuf.dll";
			eval_a_a = LoadLibrary(lpFileName);
			if (eval_a_a.ToInt32() == 0)
			{
				Form1.WriteLine(1, "Load rxjhDeBuf.dll UnSucceess");
			}
			else
			{
				Form1.WriteLine(2, "Load rxjhDeBuf.dll succeess");
			}
		}

		[DllImport("Kernel32.dll")]
		public static extern IntPtr LoadLibrary(string lpFileName);
	}
}

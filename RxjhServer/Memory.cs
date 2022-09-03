using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace RxjhServer
{
	public class Memory
	{
		private static readonly Version eval_a = new Version(1, 0);

		public static int SetProcessMemoryToMin()
		{
			return SetProcessMemoryToMin(Process.GetCurrentProcess().Handle);
		}

		public static int SetProcessMemoryToMin(IntPtr SetProcess)
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				return SetProcessWorkingSetSize(SetProcess, -1, -1);
			}
			return -1;
		}

		[DllImport("kernel32.dll")]
		private static extern int SetProcessWorkingSetSize(IntPtr A_0, int A_1, int A_2);
	}
}

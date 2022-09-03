using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Windows.Forms;
using YulgangServer;

namespace RxjhServer
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			if (File.Exists("Loginserver.exe") && Process.GetProcessesByName("Loginserver").Length == 0)
			{
				Process.Start("Loginserver.exe");
			}
			if (File.Exists("Loginserver.exe") && Process.GetProcessesByName("Loginserver").Length == 0)
			{
				Process.Start("Loginserver.exe");
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			Application.Run(new Form1());
		}

		private static void KillForm()
		{
			Application.Exit();
			Process.GetCurrentProcess().Kill();
		}

		private static string Get_Key_dQHuy()
		{
			string input = Encryption_Key.GetMd5Hash(HardwareInfo.GetAccountName()) + Encryption_Key.GetCRC32(HardwareInfo.GetProcessorId()) + Encryption_Key.Base64Encode(HardwareInfo.GetComputerName()) + Encryption_Key.GetMd5Hash(HardwareInfo.GetMACAddress()) + Encryption_Key.Base64Encode(HardwareInfo.GetHDDSerialNo());
			input = Encryption_Key.GetCRC32(input);
			input = Encryption_Key.GetMd5Hash(input);
			input = Encryption_Key.Base64Encode(input);
			input = Encryption_Key.Decrypta(input);
			return Encryption_Key.Base64Encode(input);
		}

		private static DateTime GetNistTime()
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");
			WebResponse response = httpWebRequest.GetResponse();
			string s = response.Headers["date"];
			return DateTime.ParseExact(s, "ddd, dd MMM yyyy HH:mm:ss 'GMT'", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal);
		}
	}
}

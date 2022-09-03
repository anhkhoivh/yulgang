using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using YulgangServer;

namespace RxjhServer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {

            if (File.Exists("Loginserver.exe"))
            {
                if (Process.GetProcessesByName("Loginserver").Length == 0)
                {
                    Process.Start("Loginserver.exe");
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        static void KillForm()
        {
            Application.Exit();
            Process.GetCurrentProcess().Kill();
        }

        static DateTime GetNistTime()
        {
            var myHttpWebRequest = (HttpWebRequest)WebRequest.Create("http://www.microsoft.com");
            var response = myHttpWebRequest.GetResponse();
            string todaysDates = response.Headers["date"];
            DateTime dateTime = DateTime.ParseExact(todaysDates, "ddd, dd MMM yyyy HH:mm:ss 'GMT'", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal);
            return dateTime;
        }
    }
}

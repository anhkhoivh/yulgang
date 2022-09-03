namespace DbClss
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Windows.Forms;

    public class Config
    {
        private static string _Path;
        private static string _Pathqg;
        private static string _Pathgj;
        private static string _config;

        static Config()
        {
            old_acctor_mc();
        }

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string A_0, string A_1, string A_2, StringBuilder A_3, int A_4, string A_5);
        public static string IniReadValue(string Section, string Key)
        {
            StringBuilder builder = new StringBuilder(1024);
            GetPrivateProfileString(Section, Key, "", builder, 1024, _Path);
            return builder.ToString();
        }

        public static string IniReadValuee(string Section, string Key)
        {
            StringBuilder builder = new StringBuilder(1024);
            GetPrivateProfileString(Section, Key, "", builder, 1024, _Pathqg);
            return builder.ToString();
        }

        public static string IniReadValugj(string Section, string Key)
        {
            StringBuilder builder = new StringBuilder(1024);
            GetPrivateProfileString(Section, Key, "", builder, 1024, _Pathgj);
            return builder.ToString();
        }

        public static string IniReadValust(string Section, string Key)
        {
            StringBuilder builder = new StringBuilder(1024);
            GetPrivateProfileString(Section, Key, "", builder, 1024, _Pathgj);
            return builder.ToString();
        }

        public static void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, _Path);
        }

        private static void old_acctor_mc()
        {
            _Path = Application.StartupPath + @"\GameConfiguration.ini";
            _Pathgj = Application.StartupPath + @"\StoneConfiguration.ini";
            _config = Application.StartupPath + @"\HookConfiguration.ini";
        }

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string A_0, string A_1, string A_2, string A_3);

        public static string Path
        {
            set
            {
                _Path = value;
            }
        }

        public static string Pathgj
        {
            set
            {
                _Pathgj = value;
            }
        }

        public static string Pathqg
        {
            set
            {
                _Pathqg = value;
            }
        }

        public static string Pathst
        {
            set
            {
                _Pathgj = value;
            }
        }
    }
}


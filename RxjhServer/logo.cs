using System;
using System.IO;

namespace RxjhServer
{
	public class logo
	{
		public static void DEBUG_BUFFER(string DebugTxt)
		{
			try
			{
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("DEBUG_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(string.Concat(new object[2]
					{
						DebugTxt,
						"\r\n"
					}));
				}
			}
			catch
			{
			}
		}

		public static void cfzTxtLog(string ErrTxt)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("logs\\非法物品日志_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + ErrTxt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void logcuonghoatrangsuc(string Txt)
		{
			try
			{
				if (!Directory.Exists("lichsu"))
				{
					Directory.CreateDirectory("lichsu");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("lichsu\\CH_TrangSuc.txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + Txt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void logcuonghoaaochoang(string Txt)
		{
			try
			{
				if (!Directory.Exists("lichsu"))
				{
					Directory.CreateDirectory("lichsu");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("lichsu\\CH_AoChoang.txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + Txt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void logdungpill(string Txt)
		{
			try
			{
				if (!Directory.Exists("lichsu"))
				{
					Directory.CreateDirectory("lichsu");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("lichsu\\Use_Pill.txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + Txt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void logcuonghoaitem(string Txt)
		{
			try
			{
				if (!Directory.Exists("lichsu"))
				{
					Directory.CreateDirectory("lichsu");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("lichsu\\CH_ITEM.txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + Txt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void logxoanhanvat(string Txt)
		{
			try
			{
				if (!Directory.Exists("lichsu"))
				{
					Directory.CreateDirectory("lichsu");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("lichsu\\XoaNhanVat.txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + Txt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void logaddcash(string Txt)
		{
			try
			{
				if (!Directory.Exists("lichsu"))
				{
					Directory.CreateDirectory("lichsu");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("lichsu\\logaddcash.txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + Txt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void lognhanexp(string Txt)
		{
			try
			{
				if (!Directory.Exists("lichsu"))
				{
					Directory.CreateDirectory("lichsu");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("lichsu\\ExpQuest.txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + Txt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void lognhannhiemvu(string Txt)
		{
			try
			{
				if (!Directory.Exists("lichsu"))
				{
					Directory.CreateDirectory("lichsu");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("lichsu\\LogQuest.txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + Txt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void logchedo(string Txt)
		{
			try
			{
				if (!Directory.Exists("lichsu"))
				{
					Directory.CreateDirectory("lichsu");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("lichsu\\CHEDO.txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + Txt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void logbugaptrung(string Txt)
		{
			try
			{
				if (!Directory.Exists("lichsu"))
				{
					Directory.CreateDirectory("lichsu");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("lichsu\\BUGAPTRUNG.txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + Txt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void logxoaitem(string Txt)
		{
			try
			{
				if (!Directory.Exists("lichsu"))
				{
					Directory.CreateDirectory("lichsu");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("lichsu\\XOAITEM.txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + Txt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void loghopthanhitem(string Txt)
		{
			try
			{
				if (!Directory.Exists("lichsu"))
				{
					Directory.CreateDirectory("lichsu");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("lichsu\\HT_ITEM.txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + Txt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void logpkdrop(string Txt)
		{
			try
			{
				if (!Directory.Exists("lichsu"))
				{
					Directory.CreateDirectory("lichsu");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("lichsu\\PK_DROP.txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + Txt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void gmtools(string Txt, int Type)
		{
			try
			{
				if (Type != 321)
				{
					if (!Directory.Exists("log_GM"))
					{
						Directory.CreateDirectory("log_GM");
					}
					using (StreamWriter streamWriter = new StreamWriter(new FileStream("log_GM\\GM_TOOLS_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
					{
						streamWriter.Write(DateTime.Now + " " + Txt + "\r\n");
					}
				}
			}
			catch
			{
			}
		}

		public static void commandhelp(string Txt)
		{
			try
			{
				if (!Directory.Exists("log_Command"))
				{
					Directory.CreateDirectory("log_Command");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("log_Command\\CommandHelp_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + Txt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void commanddelitem(string Txt)
		{
			try
			{
				if (!Directory.Exists("log_Command"))
				{
					Directory.CreateDirectory("log_Command");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("log_Command\\CommandDelItem_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + Txt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void logchat(string Txt)
		{
			try
			{
				if (!Directory.Exists("log_Chat"))
				{
					Directory.CreateDirectory("log_Chat");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("log_Chat\\Chat_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " - " + Txt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void logdrop(string Txt)
		{
			try
			{
				if (!Directory.Exists("log_Drop"))
				{
					Directory.CreateDirectory("log_Drop");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("log_Drop\\Drop_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " - " + Txt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void DebugTxtLog(string ErrTxt)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("logs\\DEBUG_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + ErrTxt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void FileBugTxtLog(string ErrTxt)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("logs\\BugLog_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + ErrTxt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void FileCQTxtLog(string ErrTxt)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("logs\\CQLog_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + ErrTxt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void FileDropItmeTxtLog(string ErrTxt)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("logs\\DropItme_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + ErrTxt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void FileItmeTxtLog(string ErrTxt)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("logs\\ItmeLog_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + ErrTxt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void FileLoninTxtLog(string ErrTxt)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("logs\\登陆日志_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + ErrTxt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void FilePakTxtLog(string ErrTxt)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("logs\\封包_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + ErrTxt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void FileTxtLog(string ErrTxt)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("logs\\错误日志_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + ErrTxt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void BugTxtLog(string ErrTxt)
		{
			try
			{
				if (!Directory.Exists("lichsu"))
				{
					Directory.CreateDirectory("lichsu");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("lichsu\\BUG_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + ErrTxt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void MsGLog(string MsG)
		{
		}

		public static void pzTxtLog(string ErrTxt)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("logs\\帮战日志_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + ErrTxt + "\r\n");
				}
			}
			catch
			{
			}
		}

		public static void SeveTxtLog(string ErrTxt)
		{
			try
			{
				if (!Directory.Exists("logs"))
				{
					Directory.CreateDirectory("logs");
				}
				using (StreamWriter streamWriter = new StreamWriter(new FileStream("logs\\存档_" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read)))
				{
					streamWriter.Write(DateTime.Now + " " + ErrTxt + "\r\n");
				}
			}
			catch
			{
			}
		}
	}
}

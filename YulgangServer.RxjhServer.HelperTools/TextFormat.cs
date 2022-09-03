using System;

namespace YulgangServer.RxjhServer.HelperTools
{
	public class TextFormat
	{
		private string _startChars = "đ|á|à|ả|ã|ạ|ă|ắ|ằ|ẳ|ẵ|ặ|â|ấ|ầ|ẩ|ẫ|ậ|é|è|ẻ|ẽ|ẹ|ê|ế|ề|ể|ễ|ệ|í|ì|ỉ|ĩ|ị|ó|ò|ỏ|õ|ọ|ô|ố|ồ|ổ|ỗ|ộ|ơ|ớ|ờ|ở|ỡ|ợ|ý|ỳ|ỷ|ỹ|ỵ|ú|ù|ủ|ũ|ụ|ư|ứ|ừ|ử|ữ|ự";

		private string _endChars = "ð|aì|aÌ|aÒ|aÞ|aò|ã|ãì|ãÌ|ãÒ|ãÞ|ãò|â|âì|âÌ|âÒ|âÞ|âò|eì|eÌ|eÒ|eÞ|eò|ê|êì|êÌ|êÒ|êÞ|êò|iì|iÌ|iÒ|iÞ|iò|oì|oÌ|oÒ|oÞ|oò|ô|ôì|ôÌ|ôÒ|ôÞ|ôò|õ|õì|õÌ|õÒ|õÞ|õò|yì|yÌ|yÒ|yÞ|yò|uì|uÌ|uÒ|uÞ|uò|ý|ýì|ýÌ|ýÒ|ýÞ|ýò";

		private static string[] startKeys;

		private static string[] endKeys;

		public TextFormat()
		{
			startKeys = _startChars.Split('|');
			endKeys = _endChars.Split('|');
		}

		public static string Convert(string input)
		{
			int length = input.Length;
			string[] array = new string[length];
			for (int i = 0; i < length; i++)
			{
				array[i] = input[i].ToString();
			}
			for (int i = 0; i < length; i++)
			{
				try
				{
					int num = Array.IndexOf(startKeys, array[i]);
					array[i] = array[i].Replace(startKeys[num], endKeys[num]);
				}
				catch
				{
				}
			}
			return string.Join("", array);
		}
	}
}

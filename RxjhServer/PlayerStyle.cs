using System;

namespace RxjhServer
{
	public class PlayerStyle
	{
		public byte[] PlayerStyle_byte;

		public short Hair_Color
		{
			get
			{
				return BitConverter.ToInt16(PlayerStyle_byte, 1);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, PlayerStyle_byte, 1, 2);
			}
		}

		public byte Hair_Style
		{
			get
			{
				return PlayerStyle_byte[3];
			}
			set
			{
				PlayerStyle_byte[3] = value;
			}
		}

		public byte Face
		{
			get
			{
				return PlayerStyle_byte[0];
			}
			set
			{
				PlayerStyle_byte[0] = value;
			}
		}

		public byte Sound
		{
			get
			{
				return PlayerStyle_byte[4];
			}
			set
			{
				PlayerStyle_byte[4] = value;
			}
		}

		public byte Sex
		{
			get
			{
				return PlayerStyle_byte[5];
			}
			set
			{
				PlayerStyle_byte[5] = value;
			}
		}

		public PlayerStyle(byte[] bytes)
		{
			PlayerStyle_byte = bytes;
		}
	}
}

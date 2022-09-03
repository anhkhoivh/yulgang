using System;

namespace RxjhServer
{
	public class 任务物品类
	{
		public byte[] 物品_byte;

		public int PID
		{
			get
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(物品_byte, 0, array, 0, 4);
				return BitConverter.ToInt32(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, 物品_byte, 0, 4);
			}
		}

		public int Item_Amount
		{
			get
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(物品_byte, 4, array, 0, 4);
				return BitConverter.ToInt32(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, 物品_byte, 4, 4);
			}
		}

		public 任务物品类(byte[] 物品_byte_)
		{
			物品_byte = 物品_byte_;
		}
	}
}

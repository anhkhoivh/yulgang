using System;

namespace RxjhServer
{
	public class 任务类
	{
		private byte[] eval_a;

		public byte[] 任务_byte
		{
			get
			{
				return eval_a;
			}
			set
			{
				eval_a = value;
			}
		}

		public int 任务ID
		{
			get
			{
				byte[] array = new byte[2];
				Buffer.BlockCopy(eval_a, 0, array, 0, 2);
				return BitConverter.ToInt16(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, eval_a, 0, 2);
			}
		}

		public int 任务阶段ID
		{
			get
			{
				byte[] array = new byte[2];
				Buffer.BlockCopy(eval_a, 2, array, 0, 2);
				return BitConverter.ToInt16(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, eval_a, 2, 2);
			}
		}

		public 任务类()
		{
			任务_byte = new byte[4];
		}

		public 任务类(byte[] 任务_byte_)
		{
			任务_byte = 任务_byte_;
		}
	}
}

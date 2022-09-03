using RxjhServer.RxjhServer;
using System;

namespace RxjhServer
{
	public class HcItimesClass
	{
		private int a;

		private byte[] b;

		private byte[] c;

		private int _Upgrade_Type;

		private int _Upgrade_Level;

		private int eval_l;

		private int f;

		private int g;

		private Itimesx _属性1;

		private Itimesx _属性2;

		private Itimesx _属性3;

		private Itimesx _属性4;

		public int FLD_FJ_觉醒
		{
			get
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(Get_Byte_Item, 62, array, 0, 4);
				return BitConverter.ToInt32(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Get_Byte_Item, 62, 4);
			}
		}

		public int FLD_TuLinh
		{
			get
			{
				byte[] array = new byte[2];
				Buffer.BlockCopy(Get_Byte_Item, 71, array, 0, 1);
				return BitConverter.ToInt16(array, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Get_Byte_Item, 71, 1);
			}
		}

		public int FLD_FJ_中级附魂
		{
			get
			{
				byte[] array = new byte[2];
				Buffer.BlockCopy(Get_Byte_Item, 40, array, 0, 2);
				return BitConverter.ToInt16(array, 0);
			}
			set
			{
				if (value > 0)
				{
					Buffer.BlockCopy(BitConverter.GetBytes(1), 0, Get_Byte_Item, 38, 2);
				}
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Get_Byte_Item, 40, 2);
			}
		}

		public int 阶段类型
		{
			get
			{
				return f;
			}
			set
			{
				f = value;
			}
		}

		public int 阶段数量
		{
			get
			{
				return g;
			}
			set
			{
				g = value;
			}
		}

		public int 气功属性类型
		{
			get
			{
				return eval_l;
			}
			set
			{
				eval_l = value;
			}
		}

		public int Upgrade_Type
		{
			get
			{
				return _Upgrade_Type;
			}
			set
			{
				_Upgrade_Type = value;
			}
		}

		public int Upgrade_Level
		{
			get
			{
				return _Upgrade_Level;
			}
			set
			{
				_Upgrade_Level = value;
			}
		}

		public Itimesx 属性1
		{
			get
			{
				return _属性1;
			}
			set
			{
				_属性1 = value;
			}
		}

		public Itimesx 属性2
		{
			get
			{
				return _属性2;
			}
			set
			{
				_属性2 = value;
			}
		}

		public Itimesx 属性3
		{
			get
			{
				return _属性3;
			}
			set
			{
				_属性3 = value;
			}
		}

		public Itimesx 属性4
		{
			get
			{
				return _属性4;
			}
			set
			{
				_属性4 = value;
			}
		}

		public int index
		{
			get
			{
				return a;
			}
			set
			{
				a = value;
			}
		}

		public byte[] Get_Byte_Item
		{
			get
			{
				return b;
			}
			set
			{
				b = value;
			}
		}

		public byte[] Item_ID
		{
			get
			{
				return 得到物品Id();
			}
			set
			{
				c = value;
			}
		}

		public byte[] 物品全局ID => 得到全局ID();

		public byte[] Item_Opt => 得到物品属性();

		public byte[] Item_Count
		{
			get
			{
				return 得到物品数量();
			}
			set
			{
				设置物品数量(value);
			}
		}

		public byte[] 得到全局ID()
		{
			byte[] array = new byte[8];
			try
			{
				Buffer.BlockCopy(Get_Byte_Item, 0, array, 0, 8);
			}
			catch
			{
			}
			return array;
		}

		public void 得到属性()
		{
			try
			{
				byte[] array = new byte[4];
				byte[] array2 = new byte[4];
				byte[] array3 = new byte[4];
				byte[] array4 = new byte[4];
				Buffer.BlockCopy(Get_Byte_Item, 20, array, 0, 4);
				Buffer.BlockCopy(Get_Byte_Item, 24, array2, 0, 4);
				Buffer.BlockCopy(Get_Byte_Item, 28, array3, 0, 4);
				Buffer.BlockCopy(Get_Byte_Item, 32, array4, 0, 4);
				属性1 = new Itimesx(array);
				属性2 = new Itimesx(array2);
				属性3 = new Itimesx(array3);
				属性4 = new Itimesx(array4);
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "合成 得到属性 出错：" + arg);
			}
		}

		public byte[] 得到物品Id()
		{
			byte[] array = new byte[4];
			try
			{
				Buffer.BlockCopy(Get_Byte_Item, 8, array, 0, 4);
			}
			catch
			{
			}
			return array;
		}

		public byte[] 得到物品属性()
		{
			byte[] array = new byte[56];
			try
			{
				Buffer.BlockCopy(Get_Byte_Item, 16, array, 0, 56);
			}
			catch
			{
			}
			return array;
		}

		public byte[] 得到物品数量()
		{
			byte[] array = new byte[4];
			try
			{
				Buffer.BlockCopy(Get_Byte_Item, 12, array, 0, 4);
			}
			catch
			{
			}
			return array;
		}

		public void 强化属性阶段()
		{
			try
			{
				byte[] array = new byte[4];
				Buffer.BlockCopy(Get_Byte_Item, 16, array, 0, 4);
				string text = BitConverter.ToInt32(array, 0).ToString();
				switch (text.Length)
				{
				case 1:
					阶段数量 = int.Parse(text.Substring(0, 1));
					break;
				case 2:
					阶段数量 = int.Parse(text.Substring(0, 2));
					break;
				case 3:
				case 4:
				case 5:
				case 9:
					Upgrade_Type = int.Parse(text.Substring(0, 2));
					Upgrade_Level = int.Parse(text.Substring(text.Length - 2, 2));
					break;
				case 6:
					阶段类型 = int.Parse(text.Substring(0, 1));
					if (阶段类型 == 8)
					{
						if (int.Parse(text.Substring(1, 1)) == 0)
						{
							气功属性类型 = int.Parse(text.Substring(2, 2));
						}
						else
						{
							气功属性类型 = int.Parse(text.Substring(1, 3));
						}
					}
					if (World.属性扩展是否开启 != 0)
					{
						阶段数量 = int.Parse(text) - int.Parse(text.Substring(0, 1)) * 100000;
					}
					else
					{
						阶段数量 = int.Parse(text.Substring(4, 2));
					}
					break;
				case 7:
					阶段类型 = int.Parse(text.Substring(0, 1));
					if (阶段类型 == 2)
					{
						阶段类型 = int.Parse(text.Substring(3, 1));
					}
					else
					{
						阶段类型 = int.Parse(text.Substring(0, 2));
						if (World.属性扩展是否开启 != 0)
						{
							阶段数量 = int.Parse(text) - int.Parse(text.Substring(0, 2)) * 100000;
						}
						else
						{
							阶段数量 = int.Parse(text.Substring(5, 2));
						}
					}
					break;
				case 8:
					Upgrade_Type = int.Parse(text.Substring(0, 1));
					Upgrade_Level = int.Parse(text.Substring(text.Length - 2, 2));
					break;
				case 10:
					阶段类型 = int.Parse(text.Substring(6, 1));
					阶段数量 = int.Parse(text.Substring(7, 1)) + 1;
					Upgrade_Type = int.Parse(text.Substring(2, 1));
					Upgrade_Level = int.Parse(text.Substring(text.Length - 2, 2));
					break;
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "合成 强化属性阶段 出错：" + arg);
			}
		}

		public void 设置阶段属性()
		{
			try
			{
				string s = "00000000";
				string s2 = "0000000000";
				if (Upgrade_Level != 0)
				{
					s = ((Upgrade_Level < 10) ? (Upgrade_Type + "000000" + Upgrade_Level) : (Upgrade_Type + "00000" + Upgrade_Level));
				}
				if (阶段数量 != 0)
				{
					阶段数量--;
					s2 = "100000" + 阶段类型 + 阶段数量 + "00";
				}
				int value = int.Parse(s) + int.Parse(s2);
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, Get_Byte_Item, 16, 4);
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "合成 设置阶段属性 出错：" + arg);
			}
		}

		public void 设置属性()
		{
			try
			{
				string s = "00000000";
				string s2 = "00000000";
				string s3 = "00000000";
				string s4 = "00000000";
				if (World.属性扩展是否开启 == 0)
				{
					if (属性1.属性数量 != 0)
					{
						s = ((属性1.属性数量 >= 10) ? ((属性1.属性类型 != 8 || 属性1.气功属性类型 == 0) ? (属性1.属性类型 + "00000" + 属性1.属性数量) : ((属性1.气功属性类型 <= 99) ? (属性1.属性类型 + "000" + 属性1.气功属性类型 + 属性1.属性数量) : (属性1.属性类型 + "00" + 属性1.气功属性类型 + 属性1.属性数量))) : ((属性1.属性类型 != 8 || 属性1.气功属性类型 == 0) ? (属性1.属性类型 + "000000" + 属性1.属性数量) : ((属性1.气功属性类型 <= 99) ? (属性1.属性类型 + "000" + 属性1.气功属性类型 + "0" + 属性1.属性数量) : (属性1.属性类型 + "00" + 属性1.气功属性类型 + "0" + 属性1.属性数量))));
					}
					if (属性2.属性数量 != 0)
					{
						s2 = ((属性2.属性数量 >= 10) ? ((属性2.属性类型 != 8 || 属性2.气功属性类型 == 0) ? (属性2.属性类型 + "00000" + 属性2.属性数量) : ((属性1.气功属性类型 <= 99) ? (属性2.属性类型 + "000" + 属性2.气功属性类型 + 属性2.属性数量) : (属性2.属性类型 + "00" + 属性2.气功属性类型 + 属性2.属性数量))) : ((属性2.属性类型 != 8 || 属性2.气功属性类型 == 0) ? (属性2.属性类型 + "000000" + 属性2.属性数量) : ((属性1.气功属性类型 <= 99) ? (属性2.属性类型 + "000" + 属性2.气功属性类型 + "0" + 属性2.属性数量) : (属性2.属性类型 + "00" + 属性2.气功属性类型 + "0" + 属性2.属性数量))));
					}
					if (属性3.属性数量 != 0)
					{
						s3 = ((属性3.属性数量 >= 10) ? ((属性3.属性类型 != 8 || 属性3.气功属性类型 == 0) ? (属性3.属性类型 + "00000" + 属性3.属性数量) : ((属性1.气功属性类型 <= 99) ? (属性3.属性类型 + "000" + 属性3.气功属性类型 + 属性3.属性数量) : (属性3.属性类型 + "00" + 属性3.气功属性类型 + 属性3.属性数量))) : ((属性3.属性类型 != 8 || 属性3.气功属性类型 == 0) ? (属性3.属性类型 + "000000" + 属性3.属性数量) : ((属性1.气功属性类型 <= 99) ? (属性3.属性类型 + "000" + 属性3.气功属性类型 + "0" + 属性3.属性数量) : (属性3.属性类型 + "00" + 属性3.气功属性类型 + "0" + 属性3.属性数量))));
					}
					if (属性4.属性数量 != 0)
					{
						s4 = ((属性4.属性数量 >= 10) ? ((属性4.属性类型 != 8 || 属性4.气功属性类型 == 0) ? (属性4.属性类型 + "00000" + 属性4.属性数量) : ((属性1.气功属性类型 <= 99) ? (属性4.属性类型 + "000" + 属性4.气功属性类型 + 属性4.属性数量) : (属性4.属性类型 + "00" + 属性4.气功属性类型 + 属性4.属性数量))) : ((属性4.属性类型 != 8 || 属性4.气功属性类型 == 0) ? (属性4.属性类型 + "000000" + 属性4.属性数量) : ((属性1.气功属性类型 <= 99) ? (属性4.属性类型 + "000" + 属性4.气功属性类型 + "0" + 属性4.属性数量) : (属性4.属性类型 + "00" + 属性4.气功属性类型 + "0" + 属性4.属性数量))));
					}
				}
				else
				{
					if (属性1.属性数量 != 0)
					{
						switch (属性1.属性数量.ToString().Length)
						{
						case 1:
							s = 属性1.属性类型 + "000000" + 属性1.属性数量;
							break;
						case 2:
							s = 属性1.属性类型 + "00000" + 属性1.属性数量;
							break;
						case 3:
							s = 属性1.属性类型 + "0000" + 属性1.属性数量;
							break;
						case 4:
							s = 属性1.属性类型 + "000" + 属性1.属性数量;
							break;
						case 5:
							s = 属性1.属性类型 + "00" + 属性1.属性数量;
							break;
						}
					}
					if (属性2.属性数量 != 0)
					{
						switch (属性2.属性数量.ToString().Length)
						{
						case 1:
							s2 = 属性2.属性类型 + "000000" + 属性2.属性数量;
							break;
						case 2:
							s2 = 属性2.属性类型 + "00000" + 属性2.属性数量;
							break;
						case 3:
							s2 = 属性2.属性类型 + "0000" + 属性2.属性数量;
							break;
						case 4:
							s2 = 属性2.属性类型 + "000" + 属性2.属性数量;
							break;
						case 5:
							s2 = 属性2.属性类型 + "00" + 属性2.属性数量;
							break;
						}
					}
					if (属性3.属性数量 != 0)
					{
						switch (属性3.属性数量.ToString().Length)
						{
						case 1:
							s3 = 属性3.属性类型 + "000000" + 属性3.属性数量;
							break;
						case 2:
							s3 = 属性3.属性类型 + "00000" + 属性3.属性数量;
							break;
						case 3:
							s3 = 属性3.属性类型 + "0000" + 属性3.属性数量;
							break;
						case 4:
							s3 = 属性3.属性类型 + "000" + 属性3.属性数量;
							break;
						case 5:
							s3 = 属性3.属性类型 + "00" + 属性3.属性数量;
							break;
						}
					}
					if (属性4.属性数量 != 0)
					{
						switch (属性4.属性数量.ToString().Length)
						{
						case 1:
							s4 = 属性4.属性类型 + "000000" + 属性4.属性数量;
							break;
						case 2:
							s4 = 属性4.属性类型 + "00000" + 属性4.属性数量;
							break;
						case 3:
							s4 = 属性4.属性类型 + "0000" + 属性4.属性数量;
							break;
						case 4:
							s4 = 属性4.属性类型 + "000" + 属性4.属性数量;
							break;
						case 5:
							s4 = 属性4.属性类型 + "00" + 属性4.属性数量;
							break;
						}
					}
				}
				byte[] bytes = BitConverter.GetBytes(int.Parse(s));
				byte[] bytes2 = BitConverter.GetBytes(int.Parse(s2));
				byte[] bytes3 = BitConverter.GetBytes(int.Parse(s3));
				byte[] bytes4 = BitConverter.GetBytes(int.Parse(s4));
				Buffer.BlockCopy(bytes, 0, Get_Byte_Item, 20, 4);
				Buffer.BlockCopy(bytes2, 0, Get_Byte_Item, 24, 4);
				Buffer.BlockCopy(bytes3, 0, Get_Byte_Item, 28, 4);
				Buffer.BlockCopy(bytes4, 0, Get_Byte_Item, 32, 4);
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "合成 设置属性 出错：" + arg);
			}
		}

		public int method_35()
		{
			byte[] array = new byte[4];
			Buffer.BlockCopy(Get_Byte_Item, 60, array, 0, 2);
			return BitConverter.ToInt16(array, 0);
		}

		public void 设置物品数量(byte[] 数量)
		{
			Buffer.BlockCopy(数量, 0, Get_Byte_Item, 12, 4);
		}

		public void method_3(byte[] byte_2)
		{
			b = byte_2;
		}

		public void method_1(int int_5)
		{
			a = int_5;
		}
	}
}

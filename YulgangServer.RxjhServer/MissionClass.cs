using HelperTools;
using RxjhServer;
using System;
using YulgangServer.RxjhServer.DbClss;

namespace YulgangServer.RxjhServer
{
	public class MissionClass : IDisposable
	{
		private Players _player;

		public MissionClass(Players playr)
		{
			_player = playr;
		}

		public void Dispose()
		{
			_player = null;
		}

		public void 任务(byte[] data, int length)
		{
			_player.PacketVerify(data, length);
			int num = BitConverter.ToUInt16(data, 11);
			int num2 = BitConverter.ToUInt16(data, 13);
			int 任务阶段id = BitConverter.ToInt16(data, 15);
			switch (num)
			{
			case 11:
				任务11(num, num2, 任务阶段id);
				return;
			case 12:
				任务12(num, num2, 任务阶段id);
				return;
			case 18:
				任务18(num, num2, 任务阶段id);
				return;
			case 45:
				任务45(num, num2, 任务阶段id);
				return;
			case 46:
				任务46(num, num2, 任务阶段id);
				return;
			case 73:
				任务73(num, num2, 任务阶段id);
				return;
			case 74:
				任务74(num, num2, 任务阶段id);
				return;
			case 300:
				任务300(num, num2, 任务阶段id);
				return;
			case 301:
				任务301(num, num2, 任务阶段id);
				return;
			case 178:
				任务178(num, num2, 任务阶段id);
				return;
			case 9202:
				任务9202(num, num2, 任务阶段id);
				return;
			case 9998:
				任务9998(num, num2, 任务阶段id);
				return;
			}
			switch (num2)
			{
			case 2:
			case 4:
				break;
			case 1:
				任务提示(num, 11, 任务阶段id);
				break;
			case 3:
				任务提示(num, 31, 任务阶段id);
				break;
			case 5:
				任务提示(num, 51, 任务阶段id);
				break;
			}
		}

		public void 任务11(int 任务id, int 操作id, int 任务阶段id)
		{
			if (操作id == 1)
			{
				if (_player.Player_Level >= 35 && _player.Player_Qigong_point <= 0)
				{
					任务提示(任务id, 11, 任务阶段id);
				}
				else
				{
					任务提示(任务id, 10, 任务阶段id);
				}
			}
			if (操作id == 2)
			{
				if (_player.Player_Job_Level >= 2)
				{
					return;
				}
				if (_player.Player_Level >= 35 && _player.Player_Qigong_point <= 0)
				{
					_player.人物转职业(1, 2);
					任务提示(任务id, 21, 1);
					设置任务(任务id, 1);
					if (BitConverter.ToInt16(_player.气功[6].气功_byte, 0) == 255)
					{
						_player.气功[6] = new 气功类(new byte[2]);
					}
					_player.UpdatePowersAndStatus();
					_player.Initialize_Equip_Item();
					_player.Update_Money_Weight();
				}
				else
				{
					任务提示(任务id, 10, 任务阶段id);
				}
			}
			if (操作id == 3)
			{
				任务提示(任务id, 31, 任务阶段id);
			}
		}

		public void 任务12(int 任务id, int 操作id, int 任务阶段id)
		{
			if (操作id == 1)
			{
				if (_player.Player_Level >= 35 && _player.Player_Qigong_point <= 0)
				{
					任务提示(任务id, 11, 任务阶段id);
				}
				else
				{
					任务提示(任务id, 10, 任务阶段id);
				}
			}
			if (操作id == 2)
			{
				if (_player.Player_Job_Level >= 2)
				{
					return;
				}
				if (_player.Player_Level >= 35 && _player.Player_Qigong_point <= 0)
				{
					_player.人物转职业(2, 2);
					任务提示(任务id, 21, 1);
					设置任务(任务id, 1);
					if (BitConverter.ToInt16(_player.气功[6].气功_byte, 0) == 255)
					{
						_player.气功[6] = new 气功类(new byte[2]);
					}
					_player.UpdatePowersAndStatus();
					_player.Initialize_Equip_Item();
					_player.Update_Money_Weight();
				}
				else
				{
					任务提示(任务id, 10, 任务阶段id);
				}
			}
			if (操作id == 3)
			{
				任务提示(任务id, 31, 任务阶段id);
			}
		}

		public void 任务178(int 任务id, int 操作id, int 任务阶段id)
		{
			if (操作id == 1)
			{
				任务提示(任务id, (_player.Player_Level < 100) ? 10 : 11, 任务阶段id);
			}
			if (操作id == 2)
			{
				if (_player.Player_Job_Level >= 5)
				{
					return;
				}
				if (_player.Player_Level < 100)
				{
					任务提示(任务id, 10, 任务阶段id);
				}
				else
				{
					_player.人物转职业(_player.Player_Zx, 5);
					任务提示(任务id, 21, 1);
					设置任务(任务id, 1);
					if (BitConverter.ToInt16(_player.气功[10].气功_byte, 0) == 255)
					{
						_player.气功[10] = new 气功类(new byte[2]);
					}
					_player.学习技能(0, 25);
					_player.学习技能(0, 26);
					_player.学习技能(0, 27);
					_player.UpdatePowersAndStatus();
					_player.Update_Exp_Marble();
					_player.Update_Money_Weight();
				}
			}
			if (操作id == 3)
			{
				任务提示(任务id, 31, 任务阶段id);
			}
		}

		public void 任务18(int 任务id, int 操作id, int 任务阶段id)
		{
			if (操作id == 1)
			{
				if (_player.Player_Level >= 10 && _player.Player_Qigong_point <= 0)
				{
					任务提示(任务id, 11, 任务阶段id);
				}
				else
				{
					任务提示(任务id, 10, 任务阶段id);
				}
			}
			if (操作id == 2)
			{
				if (_player.Player_Job_Level >= 1)
				{
					return;
				}
				if (_player.Player_Level >= 10 && _player.Player_Qigong_point <= 0)
				{
					_player.人物转职业(0, 1);
					任务提示(任务id, 21, 1);
					设置任务(任务id, 1);
					if (BitConverter.ToInt16(_player.气功[5].气功_byte, 0) == 255)
					{
						_player.气功[5] = new 气功类(new byte[2]);
					}
					_player.UpdatePowersAndStatus();
					_player.Update_Money_Weight();
				}
				else
				{
					任务提示(任务id, 10, 任务阶段id);
				}
			}
			if (操作id == 3)
			{
				任务提示(任务id, 31, 任务阶段id);
			}
		}

		public void 任务300(int 任务id, int 操作id, int 任务阶段id)
		{
			if (操作id == 1)
			{
				if (_player.Player_Level >= 115 && _player.Player_WuXun >= 2000 && _player.Player_Money >= 1000000000)
				{
					任务提示(任务id, 11, 任务阶段id);
				}
				else
				{
					任务提示(任务id, 10, 任务阶段id);
				}
			}
			if (操作id == 2)
			{
				if (_player.Player_Job_Level >= 6)
				{
					return;
				}
				if (_player.Player_Level < 115 || _player.Player_WuXun < 2000 || _player.Player_Money < 1000000000)
				{
					任务提示(任务id, 10, 任务阶段id);
				}
				else
				{
					int num = _player.Find_Package_Empty(_player);
					if (num == -1)
					{
						_player.GameMessage("ÐaÞ hêìt chôÞ trôìng, vui loÌng quay laòi sau");
						任务提示(任务id, 31, 任务阶段id);
					}
					else
					{
						_player.人物转职业(_player.Player_Zx, 6);
						任务提示(任务id, 21, 1);
						设置任务(任务id, 1);
						byte[] bytes = BitConverter.GetBytes(RxjhClass.GetDbItmeId());
						int value = 0;
						switch (_player.Player_Job)
						{
						case 1:
							value = ((_player.Player_Zx == 1) ? 1000000336 : 1000000342);
							break;
						case 2:
							value = ((_player.Player_Zx == 1) ? 1000000337 : 1000000343);
							break;
						case 3:
							value = ((_player.Player_Zx == 1) ? 1000000338 : 1000000344);
							break;
						case 4:
							value = ((_player.Player_Zx == 1) ? 1000000339 : 1000000345);
							break;
						case 5:
							value = ((_player.Player_Zx == 1) ? 1000000340 : 1000000346);
							break;
						case 6:
							value = ((_player.Player_Zx == 1) ? 1000000341 : 1000000347);
							break;
						}
						_player.增加物品2(bytes, BitConverter.GetBytes(value), num, BitConverter.GetBytes(1), new byte[56]);
						_player.UpdatePowersAndStatus();
						_player.Update_Exp_Marble();
						_player.Initialize_Equip_Item();
						_player.Update_Money_Weight();
					}
				}
			}
			if (操作id == 3)
			{
				任务提示(任务id, 31, 任务阶段id);
			}
		}

		public void 任务301(int 任务id, int 操作id, int 任务阶段id)
		{
			if (操作id == 1)
			{
				if (_player.Player_Level >= 120 && _player.Player_Money >= 1000000000)
				{
					任务提示(任务id, 11, 任务阶段id);
				}
				else
				{
					任务提示(任务id, 10, 任务阶段id);
				}
			}
			if (操作id == 2)
			{
				if (_player.Player_Job_Level >= 7)
				{
					return;
				}
				if (_player.Player_Level < 120 || _player.Player_Money < 1000000000)
				{
					任务提示(任务id, 10, 任务阶段id);
				}
				else
				{
					int num = _player.Find_Package_Empty(_player);
					if (num == -1)
					{
						_player.GameMessage("ÐaÞ hêìt chôÞ trôìng, vui loÌng quay laòi sau");
						任务提示(任务id, 31, 任务阶段id);
					}
					else
					{
						_player.人物转职业(_player.Player_Zx, 7);
						任务提示(任务id, 21, 1);
						设置任务(任务id, 1);
						byte[] bytes = BitConverter.GetBytes(RxjhClass.GetDbItmeId());
						int value = 0;
						switch (_player.Player_Job)
						{
						case 1:
							value = ((_player.Player_Zx == 1) ? 1000000388 : 1000000394);
							break;
						case 2:
							value = ((_player.Player_Zx == 1) ? 1000000389 : 1000000395);
							break;
						case 3:
							value = ((_player.Player_Zx == 1) ? 1000000390 : 1000000396);
							break;
						case 4:
							value = ((_player.Player_Zx == 1) ? 1000000391 : 1000000397);
							break;
						case 5:
							value = ((_player.Player_Zx == 1) ? 1000000392 : 1000000398);
							break;
						case 6:
							value = ((_player.Player_Zx == 1) ? 1000000393 : 1000000399);
							break;
						}
						_player.增加物品2(bytes, BitConverter.GetBytes(value), num, BitConverter.GetBytes(1), new byte[56]);
						_player.UpdatePowersAndStatus();
						_player.Update_Exp_Marble();
						_player.Initialize_Equip_Item();
						_player.Update_Money_Weight();
					}
				}
			}
			if (操作id == 3)
			{
				任务提示(任务id, 31, 任务阶段id);
			}
		}

		public void 任务45(int 任务id, int 操作id, int 任务阶段id)
		{
			if (操作id == 1)
			{
				if (_player.Player_Level >= 60 && _player.Player_Qigong_point <= 0)
				{
					任务提示(任务id, 11, 任务阶段id);
				}
				else
				{
					任务提示(任务id, 10, 任务阶段id);
				}
			}
			if (操作id == 2)
			{
				if (_player.Player_Job_Level >= 3)
				{
					return;
				}
				if (_player.Player_Level >= 60 && _player.Player_Qigong_point <= 0)
				{
					_player.人物转职业(_player.Player_Zx, 3);
					任务提示(任务id, 21, 1);
					设置任务(任务id, 1);
					if (BitConverter.ToInt16(_player.气功[7].气功_byte, 0) == 255)
					{
						_player.气功[7] = new 气功类(new byte[2]);
					}
					_player.UpdatePowersAndStatus();
					_player.Update_Money_Weight();
				}
				else
				{
					任务提示(任务id, 10, 任务阶段id);
				}
			}
			if (操作id == 3)
			{
				任务提示(任务id, 31, 任务阶段id);
			}
		}

		public void 任务46(int 任务id, int 操作id, int 任务阶段id)
		{
			if (操作id == 1)
			{
				if (_player.Player_Level >= 60 && _player.Player_Qigong_point <= 0)
				{
					任务提示(任务id, 11, 任务阶段id);
				}
				else
				{
					任务提示(任务id, 10, 任务阶段id);
				}
			}
			if (操作id == 2)
			{
				if (_player.Player_Job_Level >= 3)
				{
					return;
				}
				if (_player.Player_Level >= 60 && _player.Player_Qigong_point <= 0)
				{
					_player.人物转职业(_player.Player_Zx, 3);
					任务提示(任务id, 21, 1);
					设置任务(任务id, 1);
					if (BitConverter.ToInt16(_player.气功[7].气功_byte, 0) == 255)
					{
						_player.气功[7] = new 气功类(new byte[2]);
					}
					_player.UpdatePowersAndStatus();
					_player.Update_Money_Weight();
				}
				else
				{
					任务提示(任务id, 10, 任务阶段id);
				}
			}
			if (操作id == 3)
			{
				任务提示(任务id, 31, 任务阶段id);
			}
		}

		public void 任务73(int 任务id, int 操作id, int 任务阶段id)
		{
			if (操作id == 1)
			{
				if (_player.Player_Level >= 80 && _player.Player_Qigong_point <= 0)
				{
					任务提示(任务id, 11, 任务阶段id);
				}
				else
				{
					任务提示(任务id, 10, 任务阶段id);
				}
			}
			if (操作id == 2)
			{
				if (_player.Player_Job_Level >= 4)
				{
					return;
				}
				if (_player.Player_Level >= 80 && _player.Player_Qigong_point <= 0)
				{
					_player.人物转职业(_player.Player_Zx, 4);
					任务提示(任务id, 21, 1);
					设置任务(任务id, 1);
					if (BitConverter.ToInt16(_player.气功[8].气功_byte, 0) == 255)
					{
						_player.气功[8] = new 气功类(new byte[2]);
					}
					if (BitConverter.ToInt16(_player.气功[9].气功_byte, 0) == 255)
					{
						_player.气功[9] = new 气功类(new byte[2]);
					}
					_player.UpdatePowersAndStatus();
					_player.Update_Money_Weight();
				}
				else
				{
					任务提示(任务id, 10, 任务阶段id);
				}
			}
			if (操作id == 3)
			{
				任务提示(任务id, 31, 任务阶段id);
			}
		}

		public void 任务74(int 任务id, int 操作id, int 任务阶段id)
		{
			if (操作id == 1)
			{
				if (_player.Player_Level >= 80 && _player.Player_Qigong_point <= 0)
				{
					任务提示(任务id, 11, 任务阶段id);
				}
				else
				{
					任务提示(任务id, 10, 任务阶段id);
				}
			}
			if (操作id == 2)
			{
				if (_player.Player_Job_Level >= 4)
				{
					return;
				}
				if (_player.Player_Level >= 80 && _player.Player_Qigong_point <= 0)
				{
					_player.人物转职业(_player.Player_Zx, 4);
					任务提示(任务id, 21, 1);
					设置任务(任务id, 1);
					if (BitConverter.ToInt16(_player.气功[8].气功_byte, 0) == 255)
					{
						_player.气功[8] = new 气功类(new byte[2]);
					}
					if (BitConverter.ToInt16(_player.气功[9].气功_byte, 0) == 255)
					{
						_player.气功[9] = new 气功类(new byte[2]);
					}
					_player.UpdatePowersAndStatus();
					_player.Update_Money_Weight();
				}
				else
				{
					任务提示(任务id, 10, 任务阶段id);
				}
			}
			if (操作id == 3)
			{
				任务提示(任务id, 31, 任务阶段id);
			}
		}

		public void 任务9202(int 任务id, int 操作id, int 任务阶段id)
		{
			if (任务阶段id == 0)
			{
				switch (操作id)
				{
				case 1:
					任务提示(任务id, 11, 任务阶段id);
					break;
				case 2:
					任务提示(任务id, 21, 任务阶段id);
					设置任务(任务id, 1);
					break;
				case 3:
					任务提示(任务id, 31, 任务阶段id);
					break;
				}
				return;
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			for (int i = 0; i < ((_player.装备行囊是否开启 == 0) ? 36 : 66); i++)
			{
				if (BitConverter.ToInt32(_player.Item_In_Bag[i].Get_Byte_Item_PID, 0) == 1000000161)
				{
					num = 1;
				}
				else if (BitConverter.ToInt32(_player.Item_In_Bag[i].Get_Byte_Item_PID, 0) == 1000000162)
				{
					num2 = 1;
				}
				else if (BitConverter.ToInt32(_player.Item_In_Bag[i].Get_Byte_Item_PID, 0) == 1000000163)
				{
					num3 = 1;
				}
				else if (BitConverter.ToInt32(_player.Item_In_Bag[i].Get_Byte_Item_PID, 0) == 1000000164)
				{
					num4 = 1;
				}
				else if (BitConverter.ToInt32(_player.Item_In_Bag[i].Get_Byte_Item_PID, 0) == 1000000199)
				{
					num5 = 1;
				}
			}
			if (num == 0 || num2 == 0 || num3 == 0 || num4 == 0 || num5 == 0)
			{
				任务提示(任务id, 12, 任务阶段id);
				return;
			}
			for (int j = 0; j < ((_player.装备行囊是否开启 == 0) ? 36 : 66); j++)
			{
				if (BitConverter.ToInt32(_player.Item_In_Bag[j].Get_Byte_Item_PID, 0) == 1000000161)
				{
					_player.Send_Packet_Delete_Item(j, 1);
				}
				else if (BitConverter.ToInt32(_player.Item_In_Bag[j].Get_Byte_Item_PID, 0) == 1000000162)
				{
					_player.Send_Packet_Delete_Item(j, 1);
				}
				else if (BitConverter.ToInt32(_player.Item_In_Bag[j].Get_Byte_Item_PID, 0) == 1000000163)
				{
					_player.Send_Packet_Delete_Item(j, 1);
				}
				else if (BitConverter.ToInt32(_player.Item_In_Bag[j].Get_Byte_Item_PID, 0) == 1000000164)
				{
					_player.Send_Packet_Delete_Item(j, 1);
				}
				else if (BitConverter.ToInt32(_player.Item_In_Bag[j].Get_Byte_Item_PID, 0) == 1000000199)
				{
					_player.Send_Packet_Delete_Item(j, 1);
				}
			}
			int 位置 = _player.Find_Package_Empty(_player);
			byte[] bytes = BitConverter.GetBytes(RxjhClass.GetDbItmeId());
			_player._Make_Item_Option(bytes, BitConverter.GetBytes(1000000365), 位置, BitConverter.GetBytes(1), new byte[56]);
			任务提示(任务id, 11, 2);
			设置任务(任务id, 3);
		}

		public void 任务9998(int 任务id, int 操作id, int 任务阶段id)
		{
			if (任务阶段id == 0)
			{
				switch (操作id)
				{
				case 1:
					任务提示(任务id, 11, 任务阶段id);
					break;
				case 2:
					任务提示(任务id, 21, 任务阶段id);
					设置任务(任务id, 1);
					break;
				case 3:
					任务提示(任务id, 31, 任务阶段id);
					break;
				case 5:
					任务提示(任务id, 51, 任务阶段id);
					break;
				}
			}
			else
			{
				int num = _player.Find_Package_Empty(_player);
				if (num != -1)
				{
					byte[] bytes = BitConverter.GetBytes(RxjhClass.GetDbItmeId());
					_player.增加物品2(bytes, BitConverter.GetBytes(1700101), num, BitConverter.GetBytes(1), new byte[56]);
					任务提示(任务id, 11, 2);
					设置任务(任务id, 2);
				}
				else
				{
					任务提示(任务id, 10, 任务阶段id);
				}
			}
		}

		public void 任务提示(int 任务id, int 操作id, int 任务阶段id)
		{
			byte[] array = Converter.hexStringToByte("AA55150001000084000600120033000000000000000000000055AA");
			Buffer.BlockCopy(BitConverter.GetBytes(任务id), 0, array, 11, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(操作id), 0, array, 13, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(任务阶段id), 0, array, 15, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(_player.UserSessionID), 0, array, 5, 2);
			if (_player.Client != null)
			{
				_player.Client.Send(array, array.Length);
			}
		}

		public void 设置任务(int 任务id, int 任务阶段id)
		{
			if (_player.任务.TryGetValue(任务id, out 任务类 value))
			{
				value.任务阶段ID = 任务阶段id;
				return;
			}
			任务类 任务类 = new 任务类();
			任务类.任务ID = 任务id;
			任务类.任务阶段ID = 任务阶段id;
			value = 任务类;
			if (!_player.任务.ContainsKey(任务id))
			{
				_player.任务.Add(任务id, value);
			}
		}
	}
}

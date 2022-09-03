using RxjhServer.RxjhServer;
using System;
using System.Collections;
using System.Timers;

namespace RxjhServer
{
	public class GroundItems : IDisposable
	{
		private System.Timers.Timer c;

		private DateTime d;

		private 物品类 e;

		private object eval_a;

		private object eval_b;

		private byte[] eval_f;

		private float eval_g;

		private float eval_h;

		private float eval_i;

		private int eval_j;

		private Players eval_k;

		public long id;

		private int int_0;

		public ThreadSafeDictionary<int, Players> PlayList;

		public bool bDropByNPC = false;

		public int Rxjh_Map
		{
			get
			{
				return eval_j;
			}
			set
			{
				eval_j = value;
			}
		}

		public float Rxjh_X
		{
			get
			{
				return eval_g;
			}
			set
			{
				eval_g = value;
			}
		}

		public float Rxjh_Y
		{
			get
			{
				return eval_h;
			}
			set
			{
				eval_h = value;
			}
		}

		public float Rxjh_Z
		{
			get
			{
				return eval_i;
			}
			set
			{
				eval_i = value;
			}
		}

		public DateTime time
		{
			get
			{
				return d;
			}
			set
			{
				d = value;
			}
		}

		public 物品类 物品
		{
			get
			{
				return e;
			}
			set
			{
				e = value;
			}
		}

		public byte[] 物品_byte
		{
			get
			{
				return eval_f;
			}
			set
			{
				eval_f = value;
			}
		}

		public int 物品来源
		{
			get
			{
				return int_0;
			}
			set
			{
				int_0 = value;
			}
		}

		public Players 物品优先权
		{
			get
			{
				return eval_k;
			}
			set
			{
				eval_k = value;
			}
		}

		public GroundItems()
		{
			eval_a = new object();
			eval_b = new object();
			PlayList = new ThreadSafeDictionary<int, Players>();
		}

		public GroundItems(byte[] 物品_byte_, float x, float y, float z, int map, int 物品来源)
		{
			eval_a = new object();
			eval_b = new object();
			if (c != null)
			{
				Form1.WriteLine(1, "GroundItems-NEW1");
			}
			PlayList = new ThreadSafeDictionary<int, Players>();
			time = DateTime.Now;
			物品 = new 物品类(物品_byte_);
			物品_byte = 物品_byte_;
			id = BitConverter.ToInt64(物品.得到全局ID(), 0);
			Rxjh_X = x;
			Rxjh_Y = y;
			Rxjh_Z = z;
			Rxjh_Map = map;
			this.物品来源 = 物品来源;
			c = new System.Timers.Timer(120000.0);
			c.Elapsed += npcydtheout2;
			c.Enabled = true;
			c.AutoReset = false;
		}

		public GroundItems(byte[] 物品_byte_, float x, float y, float z, int map, Players name, int 物品来源)
		{
			eval_a = new object();
			eval_b = new object();
			if (c != null)
			{
				Form1.WriteLine(0, "GroundItems-NEW1");
			}
			PlayList = new ThreadSafeDictionary<int, Players>();
			if (map != 801)
			{
				物品优先权 = name;
			}
			else
			{
				物品优先权 = null;
			}
			time = DateTime.Now;
			物品 = new 物品类(物品_byte_);
			物品_byte = 物品_byte_;
			id = BitConverter.ToInt64(物品.得到全局ID(), 0);
			Random random = new Random(World.GetRandomSeed());
			Rxjh_X = x + (float)random.Next(-5, 5);
			Rxjh_Y = y + (float)random.Next(-5, 5);
			Rxjh_Z = z;
			Rxjh_Map = map;
			this.物品来源 = 物品来源;
			c = new System.Timers.Timer(120000.0);
			c.Elapsed += npcydtheout2;
			c.Enabled = true;
			c.AutoReset = false;
		}

		public void Dispose()
		{
			try
			{
				if (c != null)
				{
					c.Enabled = false;
					c.Close();
					c.Dispose();
					c = null;
				}
				if (PlayList != null)
				{
					PlayList.Clear();
					PlayList.Dispose();
				}
				PlayList = null;
				物品 = null;
				物品优先权 = null;
				eval_a = null;
				eval_b = null;
			}
			catch (Exception)
			{
			}
		}

		~GroundItems()
		{
		}

		public static GroundItems GetItme(long id)
		{
			if (World.ItmeTeM.TryGetValue(id, out GroundItems value))
			{
				return value;
			}
			return null;
		}

		public void npcydtheout()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "npcydtheout");
			}
			try
			{
				if (c != null)
				{
					c.Enabled = false;
					c.Close();
					c.Dispose();
					c = null;
				}
				World.ItmeTeM.Remove(id);
				获取范围玩家发送地面消失物品数据包();
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "物品消失 出错npcydtheout ：" + BitConverter.ToInt32(物品.得到全局ID(), 0).ToString() + " [" + 物品.Get_Name() + "]" + ex);
			}
			finally
			{
				World.ItmeTeM.Remove(id);
				Dispose();
			}
		}

		public void npcydtheout2(object sender, ElapsedEventArgs e)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "npcydtheout2");
			}
			try
			{
				if (World.Newversion >= 14)
				{
					Players players = World.FindPlayerbyName(物品优先权.UserName);
					ItmeClass value;
					if (players != null && 查找范围玩家(50, players) && players.Tu_Dong_Nhat_Item != 0)
					{
						if ((double)(物品.物品总重量 + players.人物负重) >= (double)(players.人物负重总 * 2) * players.弓_升天二气功_千钧压驼 * (1.0 + players.Item_Wear[11].物品属性_行囊负重))
						{
							players.Tip_Pickup_Item(2, id);
						}
						else
						{
							int num = players.Find_Package_Empty(players);
							if (num == -1)
							{
								players.Tip_Pickup_Item(7, id);
							}
							else if (World.Itme.TryGetValue(BitConverter.ToInt32(物品.Get_Byte_Item_PID, 0), out value))
							{
								byte[] amount = 物品.Item_Amount;
								if (value.FLD_SIDE != 0)
								{
									物品类 物品类 = players.得到人物物品类型(物品.FLD_PID, 物品.FLD_MAGIC0);
									if (物品类 != null)
									{
										num = 物品类.Bag;
										amount = BitConverter.GetBytes(BitConverter.ToInt32(物品.Item_Amount, 0) + BitConverter.ToInt32(物品类.Item_Amount, 0));
									}
								}
								players.捡得到物品(num, amount, 物品.物品全局ID, 物品.Get_Byte_Item_PID, 物品.Get_Byte_Item_Option);
								players.Update_Item_In_Bag();
								players.Update_Money_Weight();
								players.动作表情(100);
							}
						}
					}
					else if (string.IsNullOrEmpty(物品优先权.UserName))
					{
						foreach (Players value2 in PlayList.Values)
						{
							if (查找范围玩家(50, value2) && players.Tu_Dong_Nhat_Item != 0)
							{
								if ((double)(物品.物品总重量 + value2.人物负重) >= (double)(value2.人物负重总 * 2) * value2.弓_升天二气功_千钧压驼 * (1.0 + value2.Item_Wear[11].物品属性_行囊负重))
								{
									value2.Tip_Pickup_Item(2, id);
								}
								else
								{
									int num = value2.Find_Package_Empty(value2);
									if (num == -1)
									{
										value2.Tip_Pickup_Item(7, id);
									}
									else if (World.Itme.TryGetValue(BitConverter.ToInt32(物品.Get_Byte_Item_PID, 0), out value))
									{
										byte[] amount = 物品.Item_Amount;
										if (value.FLD_SIDE != 0)
										{
											物品类 物品类 = value2.得到人物物品类型(物品.FLD_PID, 物品.FLD_MAGIC0);
											if (物品类 != null)
											{
												num = 物品类.Bag;
												amount = BitConverter.GetBytes(BitConverter.ToInt32(物品.Item_Amount, 0) + BitConverter.ToInt32(物品类.Item_Amount, 0));
											}
										}
										value2.捡得到物品(num, amount, 物品.物品全局ID, 物品.Get_Byte_Item_PID, 物品.Get_Byte_Item_Option);
										value2.Update_Item_In_Bag();
										value2.Update_Money_Weight();
										value2.动作表情(100);
									}
								}
							}
						}
					}
				}
				if (c != null)
				{
					c.Enabled = false;
					c.Close();
					c.Dispose();
					c = null;
				}
				World.ItmeTeM.Remove(id);
				获取范围玩家发送地面消失物品数据包();
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "物品消失 出错npcydtheout2 ：" + BitConverter.ToInt64(物品.得到全局ID(), 0).ToString() + " [" + 物品.Get_Name() + "]" + ex);
			}
			finally
			{
				World.ItmeTeM.Remove(id);
				Dispose();
			}
		}

		public bool 查找范围玩家(int far_, Players Playe)
		{
			if (Playe.Player_FLD_Map != Rxjh_Map)
			{
				return false;
			}
			float num = Playe.Player_FLD_X - Rxjh_X;
			float num2 = Playe.Player_FLD_Y - Rxjh_Y;
			float num3 = (int)Math.Sqrt(num * num + num2 * num2);
			return num3 <= (float)far_;
		}

		public void 获取范围玩家发送地面消失物品数据包()
		{
			try
			{
				if (PlayList != null)
				{
					try
					{
						Queue queue = Queue.Synchronized(new Queue());
						foreach (Players value in PlayList.Values)
						{
							queue.Enqueue(value);
						}
						while (queue.Count > 0)
						{
							if (World.JlMsg == 1)
							{
								Form1.WriteLine(0, "获取范围玩家发送地面消失物品数据包");
							}
							((Players)queue.Dequeue()).获取复查范围地面物品();
						}
					}
					catch (Exception arg)
					{
						Form1.WriteLine(1, "获取范围玩家发送地面消失物品数据包1 出错：" + arg);
					}
					if (PlayList != null)
					{
						PlayList.Clear();
					}
				}
			}
			catch (Exception arg2)
			{
				Form1.WriteLine(1, "获取范围玩家发送地面消失物品数据包3 出错：" + arg2);
			}
		}

		public void 获取范围玩家发送地面增加物品数据包()
		{
			try
			{
				Queue queue = Queue.Synchronized(new Queue());
				foreach (Players value in World.AllConnectedChars.Values)
				{
					if (查找范围玩家(400, value))
					{
						queue.Enqueue(value);
					}
				}
				while (queue.Count > 0)
				{
					if (World.JlMsg == 1)
					{
						Form1.WriteLine(0, "获取范围玩家发送地面增加物品数据包");
					}
					((Players)queue.Dequeue()).获取复查范围地面物品();
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "获取范围玩家发送地面增加物品数据包 出错：" + arg);
			}
		}
	}
}

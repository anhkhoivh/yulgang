using HelperTools;
using LinqSQL;
using Network;
using RxjhServer.RxjhServer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using YulgangServer.RxjhServer;
using YulgangServer.RxjhServer.DbClss;

namespace RxjhServer
{
	public class NpcClass : IDisposable
	{
		private int _level;

		private bool _npc死亡;

		private bool _一次性怪;

		private readonly Random _evalAA = new Random(World.GetRandomSeed());

		private long _maxRxjhHp;

		private long _rxjhHp;

		private double _fldDf;

		private int _fldAuto;

		private int _fldBoss;

		private int _fldNewtime;

		private object _evalBB = new object();

		private object _evalCC = new object();

		private ThreadSafeDictionary<int, Players> _playList = new ThreadSafeDictionary<int, Players>();

		private Dictionary<int, NpcClass> _npcList = new Dictionary<int, NpcClass>();

		private readonly List<PlayGjClass> _playerWid = new List<PlayGjClass>();

		private object _evalI = new object();

		private object _evalJ = new object();

		private readonly Random _evalK = new Random(World.GetRandomSeed());

		private float _fldFace1;

		private float _fldFace2;

		private int _isNpc;

		private int _fldIndex;

		private int _fldPid;

		private double _fldAt;

		private float _rxjhX;

		private float _rxjhY;

		private float _rxjhZ;

		private float _rxjhCsX;

		private float _rxjhCsY;

		private float _rxjhCsZ;

		private int _rxjhMap;

		private int _rxjhExp;

		private readonly ArrayList _tem = new ArrayList();

		private static PlayGjClass _g;

		public static Random Ran;

		public Reverser<PlayGjClass> Reverser = new Reverser<PlayGjClass>(_g.GetType(), "Gjsl", ReverserInfo.Direction.DESC);

		private string _name;

		public ThreadSafeDictionary<int, 异常状态类> 异常状态;

		public System.Timers.Timer 自动复活;

		public System.Timers.Timer timer_3;

		public int FLD_TRUDAME_NPC_CAMSU = 0;

		public int FLD_TRUDEF_NPC_CAMSU = 0;

		public int FLD_TRUDEF_NPC_NINJA = 0;

		public bool enableNpcMove = true;

		public DateTime timeNpcMove = DateTime.Now;

		public int delayNpcMove = 0;

		public bool enableNpcAttack = false;

		public DateTime timeNpcAttack = DateTime.Now;

		public int delayNpcAttack = 0;

		public DateTime timeNpcDisable = DateTime.Now;

		public int delayNpcDisable = new Random(World.GetRandomSeed()).Next(int.Parse(World.DelayDisableNpc[0]), int.Parse(World.DelayDisableNpc[1]));

		public DateTime timeNpcDie = DateTime.Now;

		private int int_110;

		public double FldAt
		{
			get
			{
				return _fldAt;
			}
			set
			{
				_fldAt = value;
			}
		}

		public int FldAuto
		{
			get
			{
				return _fldAuto;
			}
			set
			{
				_fldAuto = value;
			}
		}

		public int FldBoss
		{
			get
			{
				return _fldBoss;
			}
			set
			{
				_fldBoss = value;
			}
		}

		public double FldDf
		{
			get
			{
				return _fldDf;
			}
			set
			{
				_fldDf = value;
			}
		}

		public float FldFace1
		{
			get
			{
				return _fldFace1;
			}
			set
			{
				_fldFace1 = value;
			}
		}

		public float FldFace2
		{
			get
			{
				return _fldFace2;
			}
			set
			{
				_fldFace2 = value;
			}
		}

		public int FldIndex
		{
			get
			{
				return _fldIndex;
			}
			set
			{
				_fldIndex = value;
			}
		}

		public int FldNewtime
		{
			get
			{
				return _fldNewtime;
			}
			set
			{
				_fldNewtime = value;
			}
		}

		public int FldPid
		{
			get
			{
				return _fldPid;
			}
			set
			{
				_fldPid = value;
			}
		}

		public int IsNpc
		{
			get
			{
				return _isNpc;
			}
			set
			{
				_isNpc = value;
			}
		}

		public int Level
		{
			get
			{
				return _level;
			}
			set
			{
				_level = value;
			}
		}

		public long MaxRxjhHp
		{
			get
			{
				return _maxRxjhHp;
			}
			set
			{
				_maxRxjhHp = value;
			}
		}

		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}

		public bool Npc死亡
		{
			get
			{
				return _npc死亡;
			}
			set
			{
				_npc死亡 = value;
			}
		}

		public int PlayerWid
		{
			get
			{
				if (_playerWid.Count <= 0)
				{
					return 0;
				}
				try
				{
					_playerWid.Sort(Reverser);
					return _playerWid[0].PlayID;
				}
				catch (Exception)
				{
					return 0;
				}
			}
		}

		public float RxjhCsX
		{
			get
			{
				return _rxjhCsX;
			}
			set
			{
				_rxjhCsX = value;
			}
		}

		public float RxjhCsY
		{
			get
			{
				return _rxjhCsY;
			}
			set
			{
				_rxjhCsY = value;
			}
		}

		public float RxjhCsZ
		{
			get
			{
				return _rxjhCsZ;
			}
			set
			{
				_rxjhCsZ = value;
			}
		}

		public int RxjhExp
		{
			get
			{
				return _rxjhExp;
			}
			set
			{
				_rxjhExp = value;
			}
		}

		public long RxjhHp
		{
			get
			{
				return _rxjhHp;
			}
			set
			{
				_rxjhHp = value;
			}
		}

		public int RxjhMap
		{
			get
			{
				return _rxjhMap;
			}
			set
			{
				_rxjhMap = value;
			}
		}

		public float RxjhX
		{
			get
			{
				return _rxjhX;
			}
			set
			{
				_rxjhX = value;
			}
		}

		public float RxjhY
		{
			get
			{
				return _rxjhY;
			}
			set
			{
				_rxjhY = value;
			}
		}

		public float RxjhZ
		{
			get
			{
				return _rxjhZ;
			}
			set
			{
				_rxjhZ = value;
			}
		}

		public bool 一次性怪
		{
			get
			{
				return _一次性怪;
			}
			set
			{
				_一次性怪 = value;
			}
		}

		static NpcClass()
		{
			old_acctor_mc();
		}

		public NpcClass()
		{
			异常状态 = new ThreadSafeDictionary<int, 异常状态类>();
		}

		public void Boss暴物品(Players yxqname)
		{
			try
			{
				if (RxjhExp > 0)
				{
					foreach (DropClass item in DropClass.GetBossDrop(Level))
					{
						if (item == null)
						{
							continue;
						}
						int fLD_PID = item.FLD_PID;
						if (fLD_PID <= 800000028)
						{
							switch (fLD_PID)
							{
							case 800000013:
								break;
							case 800000028:
								goto IL_0128;
							case 800000023:
								goto IL_016b;
							case 800000024:
								goto IL_0248;
							case 800000025:
								goto IL_032a;
							case 800000026:
								goto IL_040c;
							case 800000011:
								goto IL_04ee;
							case 800000012:
								goto IL_05d0;
							case 800000001:
								goto IL_06b2;
							case 800000002:
								goto IL_0794;
							default:
								goto IL_0a05;
							}
							if (item.FLD_MAGIC0 == 0)
							{
								item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 4);
								item.FLD_PID = World.GetStonepid(item.FLD_PID);
							}
						}
						else
						{
							switch (fLD_PID)
							{
							case 800000046:
								break;
							default:
								goto IL_08c3;
							case 800000047:
								goto IL_0c6d;
							}
							if (item.FLD_MAGIC0 == 0)
							{
								item.FLD_MAGIC0 = _evalAA.Next(1, 23);
							}
						}
						goto IL_0d38;
						IL_0128:
						if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 4);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d38;
						IL_09c6:
						item.FLD_MAGIC0 = _evalAA.Next(1001, 3000);
						item.FLD_MAGIC1 = _evalAA.Next(2000, 2500);
						goto IL_0d38;
						IL_0989:
						item.FLD_MAGIC0 = _evalAA.Next(1001, 3000);
						item.FLD_MAGIC1 = _evalAA.Next(400, 700);
						goto IL_0d38;
						IL_0c6d:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC = 0;
							int num = _evalAA.Next(1, 101);
							foreach (DropShuXClass item2 in item.DropShuX)
							{
								if (num <= item2.Max)
								{
									fLD_MAGIC = _evalAA.Next(item2.ShuXMin, item2.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = _evalAA.Next(23, 52);
						}
						goto IL_0d38;
						IL_0d38:
						掉出物品(item, null);
						continue;
						IL_0a05:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC2 = 0;
							int num2 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item3 in item.DropShuX)
							{
								if (num2 <= item3.Max)
								{
									fLD_MAGIC2 = _evalAA.Next(item3.ShuXMin, item3.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC2;
						}
						goto IL_0d38;
						IL_094f:
						item.FLD_MAGIC0 = _evalAA.Next(1001, 3000);
						item.FLD_MAGIC1 = _evalAA.Next(100, 151);
						goto IL_0d38;
						IL_016b:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC3 = 0;
							int num3 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item4 in item.DropShuX)
							{
								if (num3 <= item4.Max)
								{
									fLD_MAGIC3 = _evalAA.Next(item4.ShuXMin, item4.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC3;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 4);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d38;
						IL_08c3:
						switch (fLD_PID)
						{
						case 1000000321:
							break;
						case 1000000323:
							goto IL_094f;
						case 1000000325:
							goto IL_0989;
						case 1000000327:
							goto IL_09c6;
						default:
							goto IL_0a05;
						case 800000061:
							goto IL_0aa9;
						case 800000062:
							goto IL_0b8b;
						}
						item.FLD_MAGIC0 = _evalAA.Next(1001, 3000);
						item.FLD_MAGIC1 = _evalAA.Next(10, 51);
						goto IL_0d38;
						IL_0b8b:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC4 = 0;
							int num4 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item5 in item.DropShuX)
							{
								if (num4 <= item5.Max)
								{
									fLD_MAGIC4 = _evalAA.Next(item5.ShuXMin, item5.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC4;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 4);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d38;
						IL_0794:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC5 = 0;
							int num5 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item6 in item.DropShuX)
							{
								if (num5 <= item6.Max)
								{
									fLD_MAGIC5 = _evalAA.Next(item6.ShuXMin, item6.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC5;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 4);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d38;
						IL_040c:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC6 = 0;
							int num6 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item7 in item.DropShuX)
							{
								if (num6 <= item7.Max)
								{
									fLD_MAGIC6 = _evalAA.Next(item7.ShuXMin, item7.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC6;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 4);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d38;
						IL_05d0:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC7 = 0;
							int num7 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item8 in item.DropShuX)
							{
								if (num7 <= item8.Max)
								{
									fLD_MAGIC7 = _evalAA.Next(item8.ShuXMin, item8.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC7;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 4);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d38;
						IL_04ee:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC8 = 0;
							int num8 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item9 in item.DropShuX)
							{
								if (num8 <= item9.Max)
								{
									fLD_MAGIC8 = _evalAA.Next(item9.ShuXMin, item9.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC8;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 4);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d38;
						IL_0aa9:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC9 = 0;
							int num9 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item10 in item.DropShuX)
							{
								if (num9 <= item10.Max)
								{
									fLD_MAGIC9 = _evalAA.Next(item10.ShuXMin, item10.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC9;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 4);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d38;
						IL_032a:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC10 = 0;
							int num10 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item11 in item.DropShuX)
							{
								if (num10 <= item11.Max)
								{
									fLD_MAGIC10 = _evalAA.Next(item11.ShuXMin, item11.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC10;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 4);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d38;
						IL_0248:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC11 = 0;
							int num11 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item12 in item.DropShuX)
							{
								if (num11 <= item12.Max)
								{
									fLD_MAGIC11 = _evalAA.Next(item12.ShuXMin, item12.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC11;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 4);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d38;
						IL_06b2:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC12 = 0;
							int num12 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item13 in item.DropShuX)
							{
								if (num12 <= item13.Max)
								{
									fLD_MAGIC12 = _evalAA.Next(item13.ShuXMin, item13.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC12;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 4);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d38;
					}
				}
			}
			catch (Exception)
			{
			}
		}

		public bool Contains(Players payer)
		{
			return _playList.ContainsKey(payer.UserSessionID);
		}

		public void Dispose()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "NpcClass_Dispose");
			}
			try
			{
				MapClass.delnpc(RxjhMap, FldIndex);
				enableNpcAttack = false;
				enableNpcMove = false;
				if (自动复活 != null)
				{
					自动复活.Enabled = false;
					自动复活.Close();
					自动复活.Dispose();
					自动复活 = null;
				}
				Play_null();
				获取范围玩家发送消失数据包();
				_npcList.Clear();
				_tem.Clear();
				if (_playList != null)
				{
					_playList.Dispose();
					_playList = null;
				}
				if (_npcList != null)
				{
					_npcList = null;
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "NPC 关闭数据Dispose() 出错：" + arg);
			}
		}

		public void 广播npc死亡数据()
		{
			using (PacketData pak = new PacketData())
			{
				发送当前范围广播数据(pak, 34816, FldIndex);
			}
		}

		private void 更新npc死亡数据(Players playe)
		{
			using (PacketData pak = new PacketData())
			{
				if (playe.Client != null)
				{
					playe.Client.SendPak(pak, 34816, FldIndex);
				}
			}
		}

		public void NPC_Attack()
		{
			if (World.JlMsg == 1)
			{
			}
			try
			{
				timeNpcAttack = DateTime.Now;
				if (IsNpc != 0)
				{
					enableNpcAttack = false;
				}
				else if (RxjhHp < 0)
				{
					enableNpcAttack = false;
				}
				else if (200 < (int)Math.Sqrt((RxjhX - RxjhCsX) * (RxjhX - RxjhCsX) + (RxjhY - RxjhCsY) * (RxjhY - RxjhCsY)))
				{
					Play_null();
					enableNpcAttack = false;
					enableNpcMove = true;
					发送移动数据(RxjhCsX, RxjhCsY, 100, 2, RxjhX, RxjhY);
					RxjhX = RxjhCsX;
					RxjhY = RxjhCsY;
					RxjhZ = RxjhCsZ;
				}
				else if (FldAt > 0.0)
				{
					int num = (int)FldAt - FLD_TRUDAME_NPC_CAMSU;
					Random random = new Random(World.GetRandomSeed());
					Random random2 = new Random(World.GetRandomSeed());
					delayNpcAttack = random.Next(1500, 2500);
					num = random.Next(num - 15, num + 15);
					if (World.AllConnectedChars.TryGetValue(PlayerWid, out Players value) && !value.PlayerIsDead)
					{
						if (random2.Next(0, 10000) < value.FLD_人物基本_回避 || value.Bat_Tu > 0)
						{
							num = 0;
						}
						if (value.Player_FLD_HP <= 0 || value.PlayerIsDead)
						{
							enableNpcAttack = false;
							enableNpcMove = true;
							发送移动数据(RxjhCsX, RxjhCsY, 100, 1, RxjhX, RxjhY);
							RxjhX = RxjhCsX;
							RxjhY = RxjhCsY;
							RxjhZ = RxjhCsZ;
						}
						else
						{
							value.giamDoBenTrangBi();
							if (value.TrungCapEffect_DiTinh != 0)
							{
								double num2 = random.Next(0, 100);
								if (DateTime.Now.Subtract(value.time_KIDiTinh).TotalSeconds < 3.0)
								{
									value.Show_Qigong_Effect(PlayerWid, 405);
									num = 0;
								}
								else if (num2 <= (double)value.TrungCapEffect_DiTinh)
								{
									value.time_KIDiTinh = DateTime.Now;
									value.Show_Qigong_Effect(PlayerWid, 405);
									num = 0;
								}
							}
							if (value.Player_Job == 12 && value.KhiCong_JOB12_11 != 0.0 && (double)random.Next(0, 100) < value.KhiCong_JOB12_11 && !value.Show_Pic_Class.ContainsKey(700291))
							{
								value.Show_Qigong_Effect(value.UserSessionID, 1010);
								value.Show_Pic_Class.Add(700291, new Class_Show_Pill(value, 3000.0, 700291, 0));
								value.Send_Packet_Show_Pic(BitConverter.GetBytes(700291), 1, 3000);
								value.Update_Character_Wear_Item();
								value.UpdatePowersAndStatus();
							}
							double num3 = value.FLD_人物基本_防御 + value.FLD_斗神_追加_防御;
							bool flag = false;
							if (value.枪_转攻为守 != 0.0 && (double)random.Next(0, 100) < value.枪_转攻为守)
							{
								value.Show_Qigong_Effect(FldIndex, 130);
								num3 += FldAt * 20.0 / 100.0;
							}
							if (value.Item_Wear[0].FLD_PID != 0 && value.Item_Wear[0].物品属性阶段类型 == 1 && !value.Show_Pic_Class.ContainsKey(700344))
							{
								num -= (int)((double)num * ((double)value.Item_Wear[0].物品属性阶段数 * 0.01));
							}
							num = ((!((double)num <= num3)) ? (num - (int)num3) : random2.Next(1, 4));
							if (查找范围玩家(15, value))
							{
								int num4 = random2.Next(0, 100);
								double num5 = 1.0 + (double)random2.Next(50, 150) / 100.0;
								if (value.Player_Job == 2 || value.Player_Job == 9)
								{
									if (World.Newversion <= 15 && value.剑_怒海狂澜 != 0.0 && random2.NextDouble() * 100.0 < value.剑_怒海狂澜 && !value.Show_Pic_Class.ContainsKey(700014))
									{
										value.Show_Qigong_Effect(value.UserSessionID, 28);
										value.KCPhanNo = 1;
									}
									double num6 = num;
									int num7 = random2.Next(0, 100);
									if (value.剑_护身罡气 != 0.0 && (double)num7 <= value.剑_护身罡气)
									{
										num = (int)(num6 * 0.5);
										value.Show_Qigong_Effect(value.UserSessionID, 25);
									}
									if (value.KC_HoiLieuThanPhap != 0.0)
									{
										double num8 = random.NextDouble() * 100.0;
										if (num8 <= value.KC_HoiLieuThanPhap)
										{
											num = 0;
										}
									}
								}
								if (FldBoss == 0 && value.KhiCong_JOB5_150_2 != 0.0 && random.NextDouble() * 100.0 < value.KhiCong_JOB5_150_2)
								{
									num = 0;
								}
								if (value.KhiCong_JOB10_150_2 != 0.0 && random.NextDouble() * 100.0 < value.KhiCong_JOB10_150_2)
								{
									num = 0;
								}
								if (value.bFlag_KC150_JOB6 && value.KhiCong_JOB6_150_2 != 0.0)
								{
									value.bFlag_KC150_JOB6 = false;
									num = (int)((double)num * (1.0 - value.KhiCong_JOB6_150_2));
								}
								if (value.Player_Job == 10 && value.Qigong_job10_8 != 0.0 && (double)random.Next(0, 100) <= value.Qigong_job10_8)
								{
									num = (int)((double)num * (1.0 - value.Qigong_job10_8 / 100.0));
									value.Show_Qigong_Effect(value.UserSessionID, 554);
								}
								if (value.Player_Job == 6 && value.刺_三花聚顶 != 0.0 && (double)random.Next(0, 100) <= value.刺_三花聚顶)
								{
									value.刺_连消带打数量 = (double)num * value.刺_连消带打;
									num = 0;
								}
								if (value.Qigong_HBQ6 != 0.0 && value.Player_Job == 8)
								{
									double num8 = random.NextDouble() * 100.0;
									if (num8 <= value.Qigong_HBQ6)
									{
										num -= (int)((double)num * value.Qigong_HBQ6 / 100.0);
									}
								}
								if (value.Player_Job == 8 && value.韩飞官_升天一气功 != 0.0 && (double)random.Next(0, 100) <= value.韩飞官_升天一气功)
								{
									value.Show_Qigong_Effect(value.UserSessionID, 600);
									value.刺_连消带打数量 = num;
									num = 0;
								}
								if (value.TrungCapEffect_HoThe != 0)
								{
									double num9 = random.Next(0, 100);
									if (num9 <= (double)value.TrungCapEffect_HoThe)
									{
										value.Show_Qigong_Effect(PlayerWid, 406);
										value.Player_FLD_MP -= num;
										num = 0;
										value.Update_HP_MP_SP();
									}
								}
								if (value.TrungCapEffect_HonNguyen != 0)
								{
									double num10 = random.Next(0, 100);
									if (num10 <= (double)value.TrungCapEffect_HonNguyen)
									{
										value.Show_Qigong_Effect(PlayerWid, 407);
										num /= 2;
									}
								}
								if (value.会员等级 != 0)
								{
									发送攻击数据(0, 28, value.UserSessionID);
								}
								else if (FldPid == 15492 || FldPid == 15491 || FldPid == 15122 || FldPid == 15494 || FldPid == 15493 || FldPid == 15121)
								{
									num = (int)(value.Player_HP_Max / 10);
									发送攻击数据(num, 28, value.UserSessionID);
									value.Ravage_HP(num, PK: false);
								}
								else if (num4 < 10)
								{
									发送攻击数据((int)((double)num * num5), 29, value.UserSessionID);
									value.Ravage_HP((int)((double)num * num5), PK: false);
								}
								else
								{
									发送攻击数据(num, 28, value.UserSessionID);
									value.Ravage_HP(num, PK: false);
								}
								if (value.剑_升天三气功_火凤临朝 != 0.0 && (value.Player_Job == 2 || value.Player_Job == 9))
								{
									double num11 = random.Next(0, 100);
									if (num11 <= value.剑_升天三气功_火凤临朝 && value.Player_FLD_HP <= 0)
									{
										value.Player_FLD_HP = 10L;
										value.Show_Qigong_Effect(value.UserSessionID, 322);
									}
								}
								if (value.剑_升天三气功_火凤临朝 != 0.0 && value.Player_Job == 8)
								{
									double num11 = random.Next(0, 100);
									if (num11 <= value.剑_升天三气功_火凤临朝 && value.Player_FLD_HP <= 0)
									{
										value.Player_FLD_HP = 10L;
										value.Show_Qigong_Effect(value.UserSessionID, 322);
									}
								}
								if (value.Player_Job == 3 || value.Player_Job == 10)
								{
									if (value.枪_狂神降世 != 0.0)
									{
										value.人物_SP += (int)((double)(value.Player_Level * 10) * value.枪_狂神降世);
									}
									if ((double)num <= num3)
									{
										value.人物_SP++;
									}
									else
									{
										value.人物_SP += 2;
									}
									if (value.Item_Wear[0].FLD_PID != 0 && value.Item_Wear[0].物品属性阶段类型 == 2 && !value.Show_Pic_Class.ContainsKey(700344))
									{
										if (value.Show_Pic_Class.ContainsKey(700291))
										{
											value.人物_SP += value.Item_Wear[0].物品属性阶段数 * 2 * 2;
										}
										else
										{
											value.人物_SP += value.Item_Wear[0].物品属性阶段数 * 2;
										}
									}
									if (value.Item_Wear[3].FLD_PID != 0 && value.Item_Wear[3].物品属性阶段类型 == 2 && !value.Show_Pic_Class.ContainsKey(700344))
									{
										if (value.Show_Pic_Class.ContainsKey(700662))
										{
											if ((double)random.Next(0, 100) <= (double)value.Item_Wear[3].物品属性阶段数 * 0.005 * 2.0)
											{
												value.人物_SP = value.人物最大_SP;
											}
											value.Show_Qigong_Effect(value.UserSessionID, 1011);
										}
										else if ((double)random.Next(0, 100) <= (double)value.Item_Wear[3].物品属性阶段数 * 0.005)
										{
											value.人物_SP = value.人物最大_SP;
										}
										value.人物_SP++;
									}
								}
								else if (value.Player_Job == 6)
								{
									if (value.刺_荆轲之怒 != 0.0)
									{
										value.人物_SP += (int)(3.0 + (double)(value.Player_Level / 2) * value.刺_荆轲之怒);
									}
									else if ((double)num <= num3)
									{
										value.人物_SP++;
									}
									else
									{
										value.人物_SP += 2;
									}
									if (value.Item_Wear[0].FLD_PID != 0 && value.Item_Wear[0].物品属性阶段类型 == 2 && !value.Show_Pic_Class.ContainsKey(700344))
									{
										if (value.Show_Pic_Class.ContainsKey(700291))
										{
											value.人物_SP += value.Item_Wear[0].物品属性阶段数 * 2 * 2;
										}
										else
										{
											value.人物_SP += value.Item_Wear[0].物品属性阶段数 * 2;
										}
									}
									if (value.Item_Wear[3].FLD_PID != 0 && value.Item_Wear[3].物品属性阶段类型 == 2 && !value.Show_Pic_Class.ContainsKey(700344))
									{
										if (value.Show_Pic_Class.ContainsKey(700662))
										{
											if ((double)random.Next(0, 100) <= (double)value.Item_Wear[3].物品属性阶段数 * 0.005 * 2.0 && value.Show_Pic_Class.ContainsKey(700662))
											{
												value.人物_SP = value.人物最大_SP;
											}
										}
										else if ((double)random.Next(0, 100) <= (double)value.Item_Wear[3].物品属性阶段数 * 0.005)
										{
											value.人物_SP = value.人物最大_SP;
										}
										value.人物_SP++;
									}
								}
								else if (value.Player_Job != 5)
								{
									if ((double)num <= num3)
									{
										value.人物_SP++;
									}
									else
									{
										value.人物_SP += 2;
									}
									if (value.Item_Wear[0].FLD_PID != 0 && value.Item_Wear[0].物品属性阶段类型 == 2 && !value.Show_Pic_Class.ContainsKey(700344))
									{
										if (value.Show_Pic_Class.ContainsKey(700291))
										{
											value.人物_SP += value.Item_Wear[0].物品属性阶段数 * 2 * 2;
										}
										else
										{
											value.人物_SP += value.Item_Wear[0].物品属性阶段数 * 2;
										}
									}
									if (value.Item_Wear[3].FLD_PID != 0 && value.Item_Wear[3].物品属性阶段类型 == 2 && !value.Show_Pic_Class.ContainsKey(700344))
									{
										if (value.Show_Pic_Class.ContainsKey(700662))
										{
											if ((double)random.Next(0, 100) <= (double)value.Item_Wear[3].物品属性阶段数 * 0.005 * 2.0)
											{
												value.人物_SP = value.人物最大_SP;
											}
										}
										else if ((double)random.Next(0, 100) <= (double)value.Item_Wear[3].物品属性阶段数 * 0.005)
										{
											value.人物_SP = value.人物最大_SP;
										}
										value.人物_SP++;
									}
								}
								else if (value.Player_Job == 5 && value.KhiCongTTChung_PhanNo != 0.0 && (double)random2.Next(0, 150) <= value.KhiCongTTChung_PhanNo)
								{
									value.人物_SP = value.人物最大_SP + 1;
									value.Update_HP_MP_SP();
								}
								try
								{
									if (value.Player_Job == 7 && value.琴师_升天二气功_三潭映月 != 0.0 && random2.NextDouble() * 100.0 <= value.琴师_升天二气功_三潭映月 + 10.5)
									{
										value.Show_Qigong_Effect(value.UserSessionID, 391);
										发送反伤攻击数据(num, 0);
										RxjhHp -= num;
										if (RxjhHp <= 0)
										{
											NPC_Die(value.UserSessionID);
										}
										num = 0;
									}
									if ((value.Player_Job == 1 || value.Player_Job == 8) && value.反伤几率 != 0.0 && (double)random2.Next(0, 100) <= value.反伤几率 + value.刀_升天二气功_穷途末路)
									{
										if ((value.Player_Job == 1 || value.Player_Job == 8) && value.刀_升天二气功_穷途末路 != 0.0 && (double)random2.Next(0, 100) <= value.刀_升天二气功_穷途末路)
										{
											value.Show_Qigong_Effect(value.UserSessionID, 19);
											发送反伤攻击数据(num * 2, 0);
											RxjhHp -= num * 2;
										}
										else
										{
											发送反伤攻击数据(num, value.UserSessionID);
											RxjhHp -= num;
										}
										if (RxjhHp <= 0)
										{
											NPC_Die(value.UserSessionID);
										}
										num = 0;
									}
									if (value.KhiCong_JOB11_10 != 0.0 && value.怒气_JOB11 < 3 && random2.Next(0, 100) < 40)
									{
										value.怒气_JOB11++;
										value.Show_Qigong_Effect(value.UserSessionID, 809);
									}
									if (value.KhiCong_JOB11_8 != 0.0 && (double)random2.Next(0, 100) < value.KhiCong_JOB11_8 && value.Player_Shield * 2 < value.Player_Shield_Max)
									{
										value.Show_Qigong_Effect(value.UserSessionID, 801);
										value.Player_Shield += value.Player_Shield_Max / 2;
									}
									TeamClass value2;
									if (value.KhiCong_HongNguyetCuongPhong != 0.0 && random2.NextDouble() * 125.0 < (double)(int)value.KhiCong_HongNguyetCuongPhong)
									{
										if (value.Party_ID != 0)
										{
											if (World.PartyClass.TryGetValue(value.Party_ID, out value2))
											{
												foreach (Players value5 in value2.List_Party.Values)
												{
													if (value.Check_Radius_Player(700, value5) && value5.Show_Pic_Class.ContainsKey(700014) && !value5.Show_Pic_Class.ContainsKey(700313) && value5.FLD_追加百分比_攻击_PHANNO != 0.0 && value5.Player_Zx == value.Player_Zx)
													{
														value5.Show_Qigong_Effect(value.UserSessionID, 313);
														value5.Show_Pic_Class.Add(700313, new Class_Show_Pill(value5, 3000.0, 700313, 0));
														value5.Send_Packet_Show_Pic(BitConverter.GetBytes(700313), 1, 3000);
														if (value5.Player_Job == 3 || value5.Player_Job == 10)
														{
															value5.Add_ATT_Percentage_PN(0.2 + value5.枪_末日狂舞);
														}
														else if (value5.Player_Job == 7)
														{
															value5.Add_ATT_Percentage_PN(0.15);
														}
														else
														{
															value5.Add_ATT_Percentage_PN(0.2);
														}
														value5.UpdatePowersAndStatus();
														value5.Update_HP_MP_SP();
													}
												}
											}
										}
										else if (value.Show_Pic_Class.ContainsKey(700014) && !value.Show_Pic_Class.ContainsKey(700313) && value.FLD_追加百分比_攻击_PHANNO != 0.0)
										{
											value.Show_Qigong_Effect(value.UserSessionID, 313);
											value.Show_Pic_Class.Add(700313, new Class_Show_Pill(value, 3000.0, 700313, 0));
											value.Send_Packet_Show_Pic(BitConverter.GetBytes(700313), 1, 3000);
											if (value.Player_Job == 3 || value.Player_Job == 10)
											{
												value.Add_ATT_Percentage_PN(0.2 + value.枪_末日狂舞);
											}
											else if (value.Player_Job == 7)
											{
												value.Add_ATT_Percentage_PN(0.15);
											}
											else
											{
												value.Add_ATT_Percentage_PN(0.2);
											}
											value.UpdatePowersAndStatus();
											value.Update_HP_MP_SP();
										}
									}
									if (value.KhiCong_ManNguyetCuongPhong != 0.0 && random2.NextDouble() * 200.0 < value.KhiCong_ManNguyetCuongPhong)
									{
										if (value.Party_ID != 0)
										{
											if (World.PartyClass.TryGetValue(value.Party_ID, out value2))
											{
												foreach (Players value6 in value2.List_Party.Values)
												{
													if (value.Check_Radius_Player(700, value6) && !value6.Show_Pic_Class.ContainsKey(700014) && !value6.Show_Pic_Class.ContainsKey(700343) && value6.Player_Zx == value.Player_Zx)
													{
														value6.Show_Qigong_Effect(value.UserSessionID, 343);
														value6.Show_Pic_Class.Add(700343, new Class_Show_Pill(value6, 3000.0, 700343, 0));
														value6.Send_Packet_Show_Pic(BitConverter.GetBytes(700343), 1, 3000);
														if (value6.Player_Job == 3 || value6.Player_Job == 10)
														{
															value6.Add_ATT_Percentage_PN(0.2 + value6.枪_末日狂舞);
															value6.Add_DEF_Percentage_PN(0.2 + value6.枪_末日狂舞);
														}
														else
														{
															value6.Add_ATT_Percentage_PN(0.2);
															value6.Add_DEF_Percentage_PN(0.2);
															if (value6.Player_Job == 11)
															{
																value6.FLD_追加百分比_Shield_PHANNO = 0.2;
															}
														}
														value6.UpdatePowersAndStatus();
														value6.Update_HP_MP_SP();
													}
												}
											}
										}
										else if (!value.Show_Pic_Class.ContainsKey(700014) && !value.Show_Pic_Class.ContainsKey(700343))
										{
											value.Show_Qigong_Effect(value.UserSessionID, 343);
											value.Show_Pic_Class.Add(700343, new Class_Show_Pill(value, 3000.0, 700343, 0));
											value.Send_Packet_Show_Pic(BitConverter.GetBytes(700343), 1, 3000);
											if (value.Player_Job == 3 || value.Player_Job == 10)
											{
												value.Add_ATT_Percentage_PN(0.2 + value.枪_末日狂舞);
												value.Add_DEF_Percentage_PN(0.2 + value.枪_末日狂舞);
											}
											else
											{
												value.Add_ATT_Percentage_PN(0.2);
												value.Add_DEF_Percentage_PN(0.2);
												if (value.Player_Job == 11)
												{
													value.FLD_追加百分比_Shield_PHANNO = 0.2;
												}
											}
											value.UpdatePowersAndStatus();
											value.Update_HP_MP_SP();
										}
									}
									if (value.KhiCong_TruongHongQuanThien != 0.0 && random2.NextDouble() * 200.0 < value.KhiCong_TruongHongQuanThien)
									{
										if (value.Party_ID != 0)
										{
											if (World.PartyClass.TryGetValue(value.Party_ID, out value2))
											{
												foreach (Players value7 in value2.List_Party.Values)
												{
													if (value.Check_Radius_Player(70, value7) && !value7.Show_Pic_Class.ContainsKey(700603) && value7.Player_Zx == value.Player_Zx)
													{
														value7.Show_Qigong_Effect(value.UserSessionID, 603);
														value7.Show_Pic_Class.Add(700603, new Class_Show_Pill(value7, 3000.0, 700603, 1));
														value7.Send_Packet_Show_Pic(BitConverter.GetBytes(700603), 1, 3000);
														value7.FLD_Item_Premium_HP += 1000;
														value7.FLD_Item_Premium_MP += 1000;
														value7.FLD_人物_追加_攻击 += 100;
														value7.FLD_人物_追加_防御 += 100;
														value7.更新人物数据(value7);
														value7.更新广播人物数据();
													}
												}
											}
										}
										else if (!value.Show_Pic_Class.ContainsKey(700603))
										{
											value.Show_Qigong_Effect(value.UserSessionID, 603);
											value.Show_Pic_Class.Add(700603, new Class_Show_Pill(value, 3000.0, 700603, 0));
											value.Send_Packet_Show_Pic(BitConverter.GetBytes(700603), 1, 3000);
											value.FLD_Item_Premium_HP += 1000;
											value.FLD_Item_Premium_MP += 1000;
											value.FLD_人物_追加_攻击 += 100;
											value.FLD_人物_追加_防御 += 100;
											value.更新人物数据(value);
											value.更新广播人物数据();
										}
									}
									if (value.KhiCong_HongMinhBienGia != 0.0 && random2.NextDouble() * 200.0 < value.KhiCong_HongMinhBienGia)
									{
										foreach (Players value8 in value.PlayList.Values)
										{
											if (value.Check_Radius_Player(70, value8) && !value8.Show_Pic_Class.ContainsKey(700604) && (value.Party_ID == 0 || (value.Party_ID != 0 && value8.Party_ID != value.Party_ID)))
											{
												value8.Show_Qigong_Effect(value.UserSessionID, 604);
												value8.Show_Pic_Class.Add(700604, new Class_Show_Pill(value8, 3000.0, 700604, 0));
												value8.Send_Packet_Show_Pic(BitConverter.GetBytes(700604), 1, 3000);
												value8.FLD_追加百分比_HP上限 -= 0.15;
												if (value8.Player_FLD_HP > value8.Player_HP_Max)
												{
													value8.Player_FLD_HP = value8.Player_HP_Max;
												}
												value8.更新人物数据(value8);
												value8.更新广播人物数据();
												value8.Update_HP_MP_SP();
											}
										}
									}
									if (value.Player_Job == 9 && value.KC_DHL_TT1 != 0.0 && random2.NextDouble() * 100.0 <= value.KC_DHL_TT1 + value.KhiCong_JOB9_150_2 && !value.Show_Pic_Class.ContainsKey(700700))
									{
										Class_Show_Pill value3 = new Class_Show_Pill(value, 10000.0, 700700, 0);
										value.Show_Pic_Class.Add(700700, value3);
										value.Send_Packet_Show_Pic(BitConverter.GetBytes(700700), 1, 10000);
										value.Show_Qigong_Effect(value.UserSessionID, 700);
									}
									if (value.Show_Pic_Class.ContainsKey(700700))
									{
										num = (int)((double)num * (1.0 - value.KC_DHL_TT1 / 100.0));
									}
									if (RxjhHp <= 0)
									{
										NPC_Die(value.UserSessionID);
										double num12 = 获得钱();
										double num13 = 获得经验();
										double num14 = 获得历练();
										if (value.FLD_VIP == 1)
										{
											num13 += num13 * World.VipEXPMultiplierPercentage;
											num14 += num14 * World.VipExperienceMultiplierPercentage;
										}
										if (value.Party_ID != 0 && value.Party_Status == 1)
										{
											if (World.PartyClass.TryGetValue(value.Party_ID, out TeamClass value4))
											{
												double num15 = num13 * (1.0 + (double)value4.List_Party.Count * 0.5) / (double)value4.List_Party.Count;
												double num16 = num14 * (1.0 + (double)value4.List_Party.Count * 0.5) / (double)value4.List_Party.Count;
												double num17 = num12 * (1.0 + (double)value4.List_Party.Count * 0.5) / (double)value4.List_Party.Count;
												foreach (Players value9 in value4.List_Party.Values)
												{
													if (查找范围玩家(700, value9) && value9.Player_Level - Level < World.获得经验等级差 && Level - value9.Player_Level < World.获得经验等级差)
													{
														value9.Player_FLD_EXP += (long)(num15 * (1.0 + value9.人物_追加_经验百分比));
														value9.Player_ExpErience += (int)(num16 * (1.0 + value9.FLD_Premium_Fight_Exp));
														value9.Player_Money += (uint)(num17 * (1.0 + value9.FLD_Item_Premium_Money + value9.FLD_Wear_Item_Money));
														value9.得到钱的提示((uint)(num17 * (1.0 + value9.FLD_Item_Premium_Money + value9.FLD_Wear_Item_Money)));
														value9.计算人物基本数据3();
														value9.Update_HP_MP_SP();
														value9.UpdatePowersAndStatus();
														value9.Update_Exp_Marble();
														value9.Update_Item_In_Bag();
														value9.Update_Money_Weight();
													}
												}
											}
										}
										else if (value.Player_Level - Level < World.获得经验等级差 && Level - value.Player_Level < World.获得经验等级差)
										{
											value.Player_FLD_EXP += (long)(num13 * (value.人物_追加_经验百分比 + 1.0));
											value.Player_ExpErience += (int)(num14 * (value.FLD_Premium_Fight_Exp + 1.0));
											value.Player_Money += (uint)(num12 * (1.0 + value.FLD_Item_Premium_Money + value.FLD_Wear_Item_Money));
											value.得到钱的提示((uint)(num12 * (1.0 + value.FLD_Item_Premium_Money + value.FLD_Wear_Item_Money)));
											value.计算人物基本数据3();
											value.Update_HP_MP_SP();
											value.UpdatePowersAndStatus();
											value.Update_Exp_Marble();
											value.Update_Item_In_Bag();
											value.Update_Money_Weight();
										}
										flag = true;
									}
								}
								catch (Exception arg)
								{
									Form1.WriteLine(1, "自动攻击事件 刀反伤 出错：" + arg);
								}
								if (value.Player_FLD_HP <= 0 || value.PlayerIsDead)
								{
									enableNpcAttack = false;
									enableNpcMove = true;
									发送移动数据(RxjhCsX, RxjhCsY, 100, 1, RxjhX, RxjhY);
									RxjhX = RxjhCsX;
									RxjhY = RxjhCsY;
									RxjhZ = RxjhCsZ;
									value.Player_FLD_HP = 0L;
									string str = CoordinateClass.getmapname(RxjhMap);
									value.GameMessage("Baòn výÌa biò chêìt bõÒi NPC: " + Name + " - MAP: " + str, 7);
									int num18 = -1;
									for (int i = 0; i < value.Item_Wear.Count(); i++)
									{
										if (value.Item_Wear[i].FLD_PID == 700004)
										{
											num18 = i;
										}
									}
									if (value.Show_Pic_Class.ContainsKey(1008000142))
									{
										value.Player_Die();
										value.Show_Pic_Class[1008000142].EndEvent();
									}
									else if (num18 != -1)
									{
										value.Player_Die();
										value.Item_Wear[num18].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
										value.Update_Equipment_Effectiveness();
									}
									else if (value.公有药品.ContainsKey(1008000312))
									{
										value.Player_Die();
									}
									else
									{
										value.Player_Die(1);
										if (World.死亡经验掉落是否开启 == 1)
										{
											double num19 = (double)(value.Player_FLD_EXP - Convert.ToInt64(World.Level[value.Player_Level - 1])) * World.死亡掉落经验调整 * 0.5;
											double num20 = (double)(value.Player_FLD_EXP - Convert.ToInt64(World.Level[value.Player_Level - 1])) * World.死亡掉落经验调整;
											if (value.公有药品.ContainsKey(1008000027))
											{
												value.Player_FLD_EXP -= (long)num19;
											}
											else
											{
												value.Player_FLD_EXP -= (long)num20;
											}
											if (value.Player_FLD_EXP < 1)
											{
												value.Player_FLD_EXP = 1L;
											}
											value.UpdatePowersAndStatus();
											value.Update_Exp_Marble();
											value.Update_Item_In_Bag();
											value.Update_Money_Weight();
										}
									}
									value.Update_HP_MP_SP();
									Play_null();
								}
								else
								{
									value.Update_HP_MP_SP();
								}
								if (flag)
								{
									NPC_Die(value.UserSessionID);
								}
							}
							else if (查找范围玩家(300, value))
							{
								发送移动数据(value.Player_FLD_X, value.Player_FLD_Y, 15, 2);
							}
							else
							{
								Play_null();
								enableNpcAttack = false;
								enableNpcMove = true;
								发送移动数据(RxjhCsX, RxjhCsY, 100, 1, RxjhX, RxjhY);
								RxjhX = RxjhCsX;
								RxjhY = RxjhCsY;
								RxjhZ = RxjhCsZ;
							}
						}
					}
					else if (World.gclass11_3.TryGetValue(PlayerWid, out value))
					{
						if (value.Pet != null)
						{
							int_110 = value.UserSessionID;
							double num12 = value.Pet.FLD_防御;
							int num21 = (!((double)num > num12)) ? 1 : (num - (int)num12);
							if (method_34(15, value.Pet))
							{
								if (value.Pet != null)
								{
									if (value.Pet.FLD_HP >= 0)
									{
										发送攻击数据(num21, 28, value.UserSessionID);
										value.Pet.FLD_HP -= num21;
										value.Pet.人物坐标_X -= 0f;
										value.Pet.人物坐标_Y -= 0f;
										value.更新灵兽HP_MP_SP();
									}
									if (value.Pet.FLD_HP < 0)
									{
										value.Pet.FLD_HP = 0;
										value.Pet.FLD_ZCD -= 100;
										value.宠物动作(5);
										value.更新灵兽HP_MP_SP();
										value.Int32_671 = 0;
										value.Int32_672 = 0;
										value.Int32_673 = 0;
										value.Int32_674 = 0;
										value.UpdatePowersAndStatus();
										value.Update_HP_MP_SP();
										value.Item_Wear[14].LockMove = false;
										value.攻击列表.Clear();
										value.GameMessage("灵兽辅助效果消失,人物经验加成正常！", 9, "灵兽死亡");
										timer_3 = new System.Timers.Timer(2000.0);
										timer_3.Elapsed += timer_3_Elapsed;
										timer_3.Enabled = true;
										发送移动数据(RxjhCsX, RxjhCsY, 100, 1, RxjhX, RxjhY);
										RxjhX = RxjhCsX;
										RxjhY = RxjhCsY;
										RxjhZ = RxjhCsZ;
									}
								}
								else
								{
									Play_null();
									发送移动数据(RxjhCsX, RxjhCsY, 100, 1, RxjhX, RxjhY);
									RxjhX = RxjhCsX;
									RxjhY = RxjhCsY;
									RxjhZ = RxjhCsZ;
								}
							}
							else if (method_34(85, value.Pet))
							{
								int num22 = new Random(World.GetRandomSeed()).Next(0, 2);
								double num23 = random2.NextDouble() * 5.0;
								double num3 = random2.NextDouble() * 5.0;
								if (num22 == 0)
								{
									发送移动数据(value.Pet.人物坐标_X + (float)num23, value.Pet.人物坐标_Y + (float)num3, 12, 2);
								}
								else
								{
									发送移动数据(value.Pet.人物坐标_X - (float)num23, value.Pet.人物坐标_Y - (float)num3, 12, 2);
								}
							}
							else
							{
								Play_null();
								发送移动数据(RxjhCsX, RxjhCsY, 100, 1, RxjhX, RxjhY);
								RxjhX = RxjhCsX;
								RxjhY = RxjhCsY;
								RxjhZ = RxjhCsZ;
							}
						}
						else
						{
							Play_null();
							发送移动数据(RxjhCsX, RxjhCsY, 100, 1, RxjhX, RxjhY);
							RxjhX = RxjhCsX;
							RxjhY = RxjhCsY;
							RxjhZ = RxjhCsZ;
						}
					}
					else
					{
						Play_null();
						enableNpcAttack = false;
						enableNpcMove = true;
						发送移动数据(RxjhCsX, RxjhCsY, 100, 2, RxjhX, RxjhY);
						RxjhX = RxjhCsX;
						RxjhY = RxjhCsY;
						RxjhZ = RxjhCsZ;
					}
				}
			}
			catch (Exception arg2)
			{
				Play_null();
				enableNpcAttack = false;
				enableNpcMove = true;
				发送移动数据(RxjhCsX, RxjhCsY, 100, 2, RxjhX, RxjhY);
				RxjhX = RxjhCsX;
				RxjhY = RxjhCsY;
				RxjhZ = RxjhCsZ;
				Form1.WriteLine(1, "自动攻击事件 出错：" + arg2);
			}
		}

		private void 自动攻击事件(object sender, ElapsedEventArgs e)
		{
		}

		public bool method_34(int int_11, PetClass petClass)
		{
			if (petClass.人物坐标_MAP != RxjhMap)
			{
				return false;
			}
			float num = petClass.人物坐标_X - RxjhX;
			float num2 = petClass.人物坐标_Y - RxjhY;
			return (double)(int)Math.Sqrt((double)num * (double)num + (double)num2 * (double)num2) <= (double)int_11;
		}

		private void timer_3_Elapsed(object sender, ElapsedEventArgs e)
		{
			timer_3.Enabled = false;
			timer_3.Close();
			timer_3.Dispose();
			if (World.gclass11_3.TryGetValue(int_110, out Players value))
			{
				Play_null();
				value.Pet.保存数据();
				value.解除召唤(value, value);
				value.召唤提示(1, 1);
				if (World.int_1140 != 1)
				{
					World.gclass11_3.Remove(int_110);
				}
				value.Pet.宠物装备栏 = null;
				value.Pet.宠物以装备 = null;
				value.Pet.武功 = null;
				value.Pet = null;
			}
		}

		private void 更新npc复活数据()
		{
			try
			{
				Npc死亡 = false;
				if (自动复活 != null)
				{
					自动复活.Enabled = false;
					自动复活.Close();
					自动复活.Dispose();
					自动复活 = null;
				}
				RxjhHp = MaxRxjhHp;
				if (_fldPid != 15900 && _fldPid != 15349 && _fldPid != 15350 && _fldPid != 15121 && _fldPid != 15122)
				{
					Random random = new Random((int)DateTime.Now.Ticks);
					int num = random.Next(0, 4);
					double num2 = random.NextDouble() * 50.0;
					double num3 = random.NextDouble() * 50.0;
					switch (num)
					{
					case 0:
						RxjhX = RxjhCsX + (float)num2;
						RxjhY = RxjhCsY + (float)num3;
						break;
					case 1:
						RxjhX = RxjhCsX + (float)num2;
						RxjhY = RxjhCsY - (float)num3;
						break;
					case 2:
						RxjhX = RxjhCsX - (float)num2;
						RxjhY = RxjhCsY + (float)num3;
						break;
					default:
						RxjhX = RxjhCsX - (float)num2;
						RxjhY = RxjhCsY - (float)num3;
						break;
					}
				}
				else
				{
					RxjhX = RxjhCsX;
					RxjhY = RxjhCsY;
				}
				RxjhZ = RxjhCsZ;
				if (FldBoss == 1)
				{
					string text = CoordinateClass.getmapname(RxjhMap);
					foreach (Players value in World.AllConnectedChars.Values)
					{
						value.GameMessage("Boss výÌa xuâìt hiêòn taòi baÒn ðôÌ: " + text + " - toòa ðôò: (" + (int)RxjhX + "," + (int)RxjhY + ")", 8);
					}
				}
				using (PacketData packetData = new PacketData())
				{
					packetData.WriteInt(1);
					packetData.WriteShort(FldIndex);
					packetData.WriteShort(FldIndex);
					packetData.WriteShort(FldPid);
					packetData.WriteInt(1);
					packetData.WriteInt((int)RxjhHp);
					packetData.WriteInt((int)MaxRxjhHp);
					packetData.WriteFloat(RxjhX);
					packetData.WriteFloat(RxjhZ);
					packetData.WriteFloat(RxjhY);
					packetData.WriteInt(0);
					packetData.WriteFloat(FldFace1);
					packetData.WriteFloat(FldFace2);
					packetData.WriteFloat(RxjhX);
					packetData.WriteFloat(RxjhZ);
					packetData.WriteFloat(RxjhY);
					packetData.WriteInt(0);
					packetData.WriteInt(0);
					packetData.WriteInt(12);
					packetData.WriteInt(0);
					if (World.Newversion >= 16)
					{
						packetData.WriteInt(0);
					}
					if (World.Newversion >= 17)
					{
						packetData.WriteInt(uint.MaxValue);
					}
					发送当前范围广播数据(packetData, 31488, FldIndex);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "更新NPC复活数据 出错" + FldPid + "|" + Name + " " + ex.Message);
			}
		}

		private void 自动复活事件(object sender, ElapsedEventArgs e)
		{
			if (World.JlMsg == 1)
			{
			}
			try
			{
				if (IsNpc == 1)
				{
					自动复活.Enabled = false;
				}
				else
				{
					enableNpcMove = true;
					if (Npc死亡)
					{
						更新npc复活数据();
					}
				}
			}
			catch (Exception arg)
			{
				if (自动复活 != null)
				{
					自动复活.Enabled = false;
					自动复活.Close();
					自动复活.Dispose();
					自动复活 = null;
				}
				Form1.WriteLine(1, "自动复活事件1 出错：" + arg);
			}
			finally
			{
				if (自动复活 != null)
				{
					自动复活.Enabled = false;
					自动复活.Close();
					自动复活.Dispose();
					自动复活 = null;
				}
			}
		}

		public bool method_351()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "NpcClass_获取范围宠物");
			}
			try
			{
				foreach (Players value in World.gclass11_3.Values)
				{
					if (Level >= value.Pet.Pet_FLD_LEVEL - 30 && value.Pet.FLD_HP > 0 && method_34(80, value.Pet))
					{
						Play_Add(value, 1L);
						return true;
					}
				}
			}
			catch
			{
				return false;
			}
			return false;
		}

		public bool CheckPlaylist()
		{
			if (_npcList != null && _playList.Count > 0)
			{
				return true;
			}
			return false;
		}

		public void NPC_Move()
		{
			if (World.JlMsg == 1)
			{
			}
			try
			{
				timeNpcMove = DateTime.Now;
				if (IsNpc != 0 && FldPid != 3 && FldPid != 5)
				{
					enableNpcMove = false;
				}
				else
				{
					Play_null();
					if (_npcList != null && _npcList.Count > 0)
					{
						_npcList.Clear();
					}
					if ((_playList == null || _playList.Count >= 1) && !Npc死亡)
					{
						if (enableNpcMove)
						{
							delayNpcMove = new Random(World.GetRandomSeed()).Next(7500, 20000);
							if (FldAuto == 1 && 获取范围玩家())
							{
								enableNpcMove = false;
								enableNpcAttack = true;
							}
							else
							{
								int num = 1;
								if (FldPid > 9999 && new Random(World.GetRandomSeed()).Next(1, 100) > 50)
								{
									num = 2;
								}
								发送移动数据(RxjhCsX, RxjhCsY, (num == 1) ? 50 : 150, num);
							}
						}
						else
						{
							foreach (Players value in _playList.Values)
							{
								if (value.Client != null)
								{
									if (!World.AllConnectedChars.ContainsKey(value.Client.WorldId))
									{
										_tem.Add(value);
									}
								}
								else
								{
									_tem.Add(value);
								}
							}
							foreach (Players item in _tem)
							{
								Form1.WriteLine(2, "NPC广播数据 删除卡号人物：[" + item.Userid + "] [" + item.UserName + "]");
								if (item.Client != null)
								{
									item.Client.Dispose();
									item.GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 70", 7);
								}
								_playList.Remove(item.UserSessionID);
							}
							_tem.Clear();
						}
					}
					else
					{
						delayNpcMove = 20000;
					}
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "NPC Move ERROR:" + arg);
			}
		}

		~NpcClass()
		{
		}

		public void Getbl()
		{
			if (_playList.Count > 0)
			{
				Form1.WriteLine(2, _name + " 人物：" + _playList.Count);
			}
			if (_npcList.Count > 0)
			{
				Form1.WriteLine(2, _name + " NPC：" + _npcList.Count);
			}
			if (_playerWid.Count > 0)
			{
				Form1.WriteLine(2, _name + " 攻击：" + _playerWid.Count);
			}
		}

		public void Gs暴物品(int sl, int maxsl, Players yxqname)
		{
			try
			{
				if (RxjhExp > 0)
				{
					foreach (DropClass item in DropClass.GetGSDrop(Level, sl, maxsl))
					{
						if (item == null)
						{
							continue;
						}
						int fLD_PID = item.FLD_PID;
						if (fLD_PID <= 800000028)
						{
							switch (fLD_PID)
							{
							case 800000013:
								break;
							case 800000028:
								goto IL_012a;
							case 800000023:
								goto IL_016d;
							case 800000024:
								goto IL_024a;
							case 800000025:
								goto IL_032c;
							case 800000026:
								goto IL_040e;
							case 800000011:
								goto IL_04f0;
							case 800000012:
								goto IL_05d2;
							case 800000001:
								goto IL_06b4;
							case 800000002:
								goto IL_0796;
							default:
								goto IL_0a07;
							}
							if (item.FLD_MAGIC0 == 0)
							{
								item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 7);
								item.FLD_PID = World.GetStonepid(item.FLD_PID);
							}
						}
						else
						{
							switch (fLD_PID)
							{
							case 800000046:
								break;
							default:
								goto IL_08c5;
							case 800000047:
								goto IL_0c6f;
							}
							if (item.FLD_MAGIC0 == 0)
							{
								item.FLD_MAGIC0 = _evalAA.Next(1, 23);
							}
						}
						goto IL_0d3a;
						IL_012a:
						if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 7);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d3a;
						IL_09c8:
						item.FLD_MAGIC0 = _evalAA.Next(1001, 3000);
						item.FLD_MAGIC1 = _evalAA.Next(2000, 2500);
						goto IL_0d3a;
						IL_098b:
						item.FLD_MAGIC0 = _evalAA.Next(1001, 3000);
						item.FLD_MAGIC1 = _evalAA.Next(400, 700);
						goto IL_0d3a;
						IL_0c6f:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC = 0;
							int num = _evalAA.Next(1, 101);
							foreach (DropShuXClass item2 in item.DropShuX)
							{
								if (num <= item2.Max)
								{
									fLD_MAGIC = _evalAA.Next(item2.ShuXMin, item2.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = _evalAA.Next(23, 52);
						}
						goto IL_0d3a;
						IL_0d3a:
						掉出物品(item, yxqname);
						continue;
						IL_0a07:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC2 = 0;
							int num2 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item3 in item.DropShuX)
							{
								if (num2 <= item3.Max)
								{
									fLD_MAGIC2 = _evalAA.Next(item3.ShuXMin, item3.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC2;
						}
						goto IL_0d3a;
						IL_0951:
						item.FLD_MAGIC0 = _evalAA.Next(1001, 3000);
						item.FLD_MAGIC1 = _evalAA.Next(100, 151);
						goto IL_0d3a;
						IL_016d:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC3 = 0;
							int num3 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item4 in item.DropShuX)
							{
								if (num3 <= item4.Max)
								{
									fLD_MAGIC3 = _evalAA.Next(item4.ShuXMin, item4.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC3;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 7);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d3a;
						IL_08c5:
						switch (fLD_PID)
						{
						case 1000000321:
							break;
						case 1000000323:
							goto IL_0951;
						case 1000000325:
							goto IL_098b;
						case 1000000327:
							goto IL_09c8;
						default:
							goto IL_0a07;
						case 800000061:
							goto IL_0aab;
						case 800000062:
							goto IL_0b8d;
						}
						item.FLD_MAGIC0 = _evalAA.Next(1001, 3000);
						item.FLD_MAGIC1 = _evalAA.Next(10, 51);
						goto IL_0d3a;
						IL_0b8d:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC4 = 0;
							int num4 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item5 in item.DropShuX)
							{
								if (num4 <= item5.Max)
								{
									fLD_MAGIC4 = _evalAA.Next(item5.ShuXMin, item5.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC4;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 7);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d3a;
						IL_0796:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC5 = 0;
							int num5 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item6 in item.DropShuX)
							{
								if (num5 <= item6.Max)
								{
									fLD_MAGIC5 = _evalAA.Next(item6.ShuXMin, item6.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC5;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 7);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d3a;
						IL_040e:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC6 = 0;
							int num6 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item7 in item.DropShuX)
							{
								if (num6 <= item7.Max)
								{
									fLD_MAGIC6 = _evalAA.Next(item7.ShuXMin, item7.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC6;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 7);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d3a;
						IL_05d2:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC7 = 0;
							int num7 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item8 in item.DropShuX)
							{
								if (num7 <= item8.Max)
								{
									fLD_MAGIC7 = _evalAA.Next(item8.ShuXMin, item8.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC7;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 7);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d3a;
						IL_04f0:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC8 = 0;
							int num8 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item9 in item.DropShuX)
							{
								if (num8 <= item9.Max)
								{
									fLD_MAGIC8 = _evalAA.Next(item9.ShuXMin, item9.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC8;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 7);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d3a;
						IL_0aab:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC9 = 0;
							int num9 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item10 in item.DropShuX)
							{
								if (num9 <= item10.Max)
								{
									fLD_MAGIC9 = _evalAA.Next(item10.ShuXMin, item10.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC9;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 7);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d3a;
						IL_032c:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC10 = 0;
							int num10 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item11 in item.DropShuX)
							{
								if (num10 <= item11.Max)
								{
									fLD_MAGIC10 = _evalAA.Next(item11.ShuXMin, item11.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC10;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 7);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d3a;
						IL_024a:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC11 = 0;
							int num11 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item12 in item.DropShuX)
							{
								if (num11 <= item12.Max)
								{
									fLD_MAGIC11 = _evalAA.Next(item12.ShuXMin, item12.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC11;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 7);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d3a;
						IL_06b4:
						if (item.FLD_MAGIC0 == 10)
						{
							int fLD_MAGIC12 = 0;
							int num12 = _evalAA.Next(1, 101);
							foreach (DropShuXClass item13 in item.DropShuX)
							{
								if (num12 <= item13.Max)
								{
									fLD_MAGIC12 = _evalAA.Next(item13.ShuXMin, item13.ShuXMax);
									break;
								}
							}
							item.FLD_MAGIC0 = fLD_MAGIC12;
						}
						else if (item.FLD_MAGIC0 == 0)
						{
							item.FLD_MAGIC0 = World.GetStoneValue(item.FLD_PID, 7);
							item.FLD_PID = World.GetStonepid(item.FLD_PID);
						}
						goto IL_0d3a;
					}
				}
			}
			catch (Exception)
			{
			}
		}

		public void New暴物品(List<NpcDropClass> bossdrop, Players yxqname)
		{
			try
			{
				foreach (NpcDropClass item in bossdrop)
				{
					if (item != null)
					{
						int fLD_ITME_PID = item.FLD_ITME_PID;
						if (fLD_ITME_PID <= 800000013)
						{
							switch (fLD_ITME_PID)
							{
							case 800000001:
								if (item.FLD_MAGIC0 == 0)
								{
									int num4 = item.FLD_MAGIC0 = _evalAA.Next(100010, 100026);
								}
								break;
							case 800000002:
								if (item.FLD_MAGIC0 == 0)
								{
									int num6 = item.FLD_MAGIC0 = _evalAA.Next(200010, 200021);
								}
								break;
							case 800000013:
								if (item.FLD_MAGIC0 == 0)
								{
									int num = _evalAA.Next(8, 10);
									string arg = "0000";
									int num2 = 0;
									num2 = _evalAA.Next(1, 3);
									string s = num.ToString() + arg + num2;
									item.FLD_MAGIC0 = int.Parse(s);
								}
								break;
							}
						}
						else
						{
							switch (fLD_ITME_PID)
							{
							case 800000023:
								if (item.FLD_MAGIC0 == 0)
								{
									int num13 = item.FLD_MAGIC0 = _evalAA.Next(700018, 700031);
								}
								break;
							case 800000024:
								if (item.FLD_MAGIC0 == 0)
								{
									int num17 = item.FLD_MAGIC0 = _evalAA.Next(200018, 200026);
								}
								break;
							case 800000025:
								if (item.FLD_MAGIC0 == 0)
								{
									int num19 = item.FLD_MAGIC0 = _evalAA.Next(1000005, 1000021);
								}
								break;
							case 800000026:
								if (item.FLD_MAGIC0 == 0)
								{
									int num15 = item.FLD_MAGIC0 = _evalAA.Next(700015, 700026);
								}
								break;
							case 800000028:
								if (item.FLD_MAGIC0 == 0)
								{
									int num11 = _evalAA.Next(1, 7);
									string str = "200";
									string str2 = "000";
									string s2 = str + num11.ToString() + str2;
									item.FLD_MAGIC0 = int.Parse(s2);
								}
								break;
							default:
								switch (fLD_ITME_PID)
								{
								case 800000046:
									if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = _evalAA.Next(1, 23);
									}
									break;
								case 800000047:
									if (item.FLD_MAGIC0 == 0)
									{
										item.FLD_MAGIC0 = _evalAA.Next(23, 52);
									}
									break;
								case 800000061:
									if (item.FLD_MAGIC0 == 0)
									{
										int num10 = item.FLD_MAGIC0 = _evalAA.Next(700020, 700036);
									}
									break;
								case 800000062:
									if (item.FLD_MAGIC0 == 0)
									{
										int num8 = item.FLD_MAGIC0 = _evalAA.Next(200029, 200033);
									}
									break;
								}
								break;
							case 800000027:
								break;
							}
						}
					}
				}
			}
			catch (Exception arg2)
			{
				Form1.WriteLine(1, "New暴物品 出错：" + arg2);
			}
		}

		private static void old_acctor_mc()
		{
			_g = new PlayGjClass();
			Ran = new Random(World.GetRandomSeed());
		}

		public void Play_Add(Players payer, long HP = 1L)
		{
			foreach (PlayGjClass item in _playerWid)
			{
				if (item.PlayID == payer.UserSessionID)
				{
					item.Gjsl += HP;
					return;
				}
			}
			PlayGjClass playGjClass = new PlayGjClass();
			playGjClass.Gjsl = 1L;
			playGjClass.PlayID = payer.UserSessionID;
			_playerWid.Add(playGjClass);
		}

		public void Play_null()
		{
			if (_playerWid.Count > 0)
			{
				_playerWid.Clear();
			}
		}

		public void PlayList_Add(Players payer)
		{
			try
			{
				if (_playList != null && !_playList.ContainsKey(payer.UserSessionID))
				{
					_playList.Add(payer.UserSessionID, payer);
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(100, "PlayList_Add 出错：" + arg);
			}
		}

		public void PlayList_Remove(Players payer)
		{
			try
			{
				if (_playList != null && _playList.ContainsKey(payer.UserSessionID))
				{
					_playList.Remove(payer.UserSessionID);
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(100, "PlayList_Remove 出错：" + arg);
			}
		}

		public void CheckQuestDrop(Players players, double per = 1.0)
		{
			foreach (TBL_QUESTDROP value in World.TblQuestDrop.Values)
			{
				if (value.MonsterID == FldPid)
				{
					int num = new Random(World.GetRandomSeed()).Next(0, (int)(8000.0 * per));
					if (players.GM模式 != 0 && players.任务.ContainsKey(value.QuestID) && players.Get任务阶段(value.QuestID) != 255)
					{
					}
					if (players.Get任务阶段(value.QuestID) == value.QuestLevel && !players.得到任务物品(value.QuestDropID, value.QuestItemMax) && (num <= value.DropRatePercent || value.QuestItemMax == 1))
					{
						players.AddItemQuest(value.QuestDropID, 1);
					}
				}
				if (value.MonsterID2 == FldPid)
				{
					int num = new Random(World.GetRandomSeed()).Next(0, (int)(8000.0 * per));
					if (players.GM模式 != 0 && players.Get任务阶段(value.QuestID) != 255)
					{
					}
					if (players.Get任务阶段(value.QuestID) == value.QuestLevel && !players.得到任务物品(value.QuestDropID2, value.QuestItemMax2) && (num <= value.DropRatePercent || value.QuestItemMax2 == 1))
					{
						players.AddItemQuest(value.QuestDropID2, 1);
					}
				}
				if (value.MonsterID == 6999 && players.Player_Level - Level < World.获得经验等级差)
				{
					int num = new Random(World.GetRandomSeed()).Next(0, (int)(8000.0 * per));
					if (players.GM模式 != 0 && players.Get任务阶段(value.QuestID) != 255)
					{
					}
					if (players.Get任务阶段(value.QuestID) == value.QuestLevel && !players.得到任务物品(value.QuestDropID, value.QuestItemMax) && num <= value.DropRatePercent)
					{
						players.AddItemQuest(value.QuestDropID, 1);
					}
				}
				if (value.MonsterID == 6998 && players.Player_Level - Level < World.获得经验等级差 && players.Player_FLD_Map == 25100)
				{
					int num = new Random(World.GetRandomSeed()).Next(0, (int)(8000.0 * per));
					if (World.Debug == 1 && players.Get任务阶段(value.QuestID) != 255)
					{
					}
					if (players.Get任务阶段(value.QuestID) == value.QuestLevel && !players.得到任务物品(value.QuestDropID, value.QuestItemMax) && num <= value.DropRatePercent)
					{
						players.AddItemQuest(value.QuestDropID, 1);
					}
				}
				if (value.MonsterID == 6997 && players.Player_Level - Level < World.获得经验等级差 && players.Player_FLD_Map == 5001)
				{
					int num = new Random(World.GetRandomSeed()).Next(0, (int)(8000.0 * per));
					if (World.Debug == 1 && players.Get任务阶段(value.QuestID) != 255)
					{
					}
					if (players.Get任务阶段(value.QuestID) == value.QuestLevel && !players.得到任务物品(value.QuestDropID, value.QuestItemMax) && num <= value.DropRatePercent)
					{
						players.AddItemQuest(value.QuestDropID, 1);
					}
				}
				if (value.MonsterID == 6996 && players.Player_Level - Level < World.获得经验等级差 && players.Player_FLD_Map == 6001)
				{
					int num = new Random(World.GetRandomSeed()).Next(0, (int)(8000.0 * per));
					if (World.Debug == 1 && players.Get任务阶段(value.QuestID) != 255)
					{
					}
					if (players.Get任务阶段(value.QuestID) == value.QuestLevel && !players.得到任务物品(value.QuestDropID, value.QuestItemMax) && num <= value.DropRatePercent)
					{
						players.AddItemQuest(value.QuestDropID, 1);
					}
				}
			}
		}

		public void DropQuest(int userWorldId)
		{
			Players players = World.FindPlayerbyID(userWorldId);
			if (players != null)
			{
				TeamClass value = default(TeamClass);
				if (players.Party_ID != 0 && World.PartyClass.TryGetValue(players.Party_ID, out value))
				{
					foreach (Players value2 in value.List_Party.Values)
					{
						if (players.Check_Radius_Player(300, value2))
						{
							if (value.List_Party.Count >= 2 && value.List_Party.Count <= 8)
							{
								CheckQuestDrop(value2, value.List_Party.Count / 2);
							}
							else
							{
								CheckQuestDrop(value2);
							}
						}
					}
				}
				else
				{
					CheckQuestDrop(players);
				}
			}
		}

		public void 暴物品(Players yxqname)
		{
			try
			{
				if (RxjhMap == 801)
				{
					yxqname = null;
				}
				if (FldBoss == 0)
				{
					暴物品2(yxqname);
				}
				else if (FldBoss == 1)
				{
					Boss暴物品(yxqname);
				}
				else if (FldBoss == 2)
				{
					Gs暴物品(1, 3, yxqname);
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "暴物品 出错：" + arg);
			}
		}

		public void 暴物品2(Players yxqname)
		{
			try
			{
				DropClass dropClass;
				int fLD_PID;
				if (RxjhExp > 0)
				{
					int num = _evalAA.Next(1, 8000 * ((World.Newversion < 13) ? 1 : 10));
					int num2 = World.暴率;
					if (yxqname != null)
					{
						if (yxqname.FLD_Item_Premium_Drop > 0.0)
						{
							num2 += (int)((double)num2 * yxqname.FLD_Item_Premium_Drop);
						}
						if (yxqname.Player_Job == 5 && yxqname.医_天佑之气 > 0.0)
						{
							num2 += (int)((double)num2 * yxqname.医_天佑之气);
						}
						if (World.PartyClass.TryGetValue(yxqname.Party_ID, out TeamClass value))
						{
							foreach (Players value3 in value.List_Party.Values)
							{
								if (value3.Player_Job == 5 && value3.医_天佑之气 > 0.0 && yxqname.UserSessionID != value3.UserSessionID)
								{
									num2 += (int)((double)num2 * value3.医_天佑之气);
								}
							}
						}
					}
					if (num <= num2)
					{
						dropClass = ((!World.AllConnectedChars.TryGetValue(PlayerWid, out Players value2)) ? DropClass.GetDrop(Level) : ((value2.FLD_VIP != 1) ? DropClass.GetDrop(Level) : DropClass.GetVipDrop(Level)));
						if (dropClass != null)
						{
							fLD_PID = dropClass.FLD_PID;
							if (fLD_PID <= 800000028)
							{
								switch (fLD_PID)
								{
								case 800000013:
									break;
								case 800000028:
									goto IL_02b4;
								case 800000023:
									goto IL_02f7;
								case 800000024:
									goto IL_03d9;
								case 800000025:
									goto IL_04bb;
								case 800000026:
									goto IL_059d;
								case 800000011:
									goto IL_067f;
								case 800000012:
									goto IL_0761;
								case 800000001:
									goto IL_0843;
								case 800000002:
									goto IL_0925;
								default:
									goto IL_0b98;
								}
								if (dropClass.FLD_MAGIC0 == 0)
								{
									dropClass.FLD_MAGIC0 = World.GetStoneValue(dropClass.FLD_PID, 3);
									dropClass.FLD_PID = World.GetStonepid(dropClass.FLD_PID);
								}
							}
							else
							{
								switch (fLD_PID)
								{
								case 800000046:
									break;
								default:
									goto IL_0a55;
								case 800000047:
									goto IL_0e00;
								}
								if (dropClass.FLD_MAGIC0 == 0)
								{
									dropClass.FLD_MAGIC0 = _evalAA.Next(1, 23);
								}
							}
							goto IL_0ecb;
						}
					}
				}
				goto end_IL_0001;
				IL_03d9:
				if (dropClass.FLD_MAGIC0 == 10)
				{
					int fLD_MAGIC = 0;
					int num3 = _evalAA.Next(1, 101);
					foreach (DropShuXClass item in dropClass.DropShuX)
					{
						if (num3 <= item.Max)
						{
							fLD_MAGIC = _evalAA.Next(item.ShuXMin, item.ShuXMax);
							break;
						}
					}
					dropClass.FLD_MAGIC0 = fLD_MAGIC;
				}
				else if (dropClass.FLD_MAGIC0 == 0)
				{
					dropClass.FLD_MAGIC0 = World.GetStoneValue(dropClass.FLD_PID, 3);
					dropClass.FLD_PID = World.GetStonepid(dropClass.FLD_PID);
				}
				goto IL_0ecb;
				IL_0761:
				if (dropClass.FLD_MAGIC0 == 10)
				{
					int fLD_MAGIC2 = 0;
					int num4 = _evalAA.Next(1, 101);
					foreach (DropShuXClass item2 in dropClass.DropShuX)
					{
						if (num4 <= item2.Max)
						{
							fLD_MAGIC2 = _evalAA.Next(item2.ShuXMin, item2.ShuXMax);
							break;
						}
					}
					dropClass.FLD_MAGIC0 = fLD_MAGIC2;
				}
				else if (dropClass.FLD_MAGIC0 == 0)
				{
					dropClass.FLD_MAGIC0 = World.GetStoneValue(dropClass.FLD_PID, 3);
					dropClass.FLD_PID = World.GetStonepid(dropClass.FLD_PID);
				}
				goto IL_0ecb;
				IL_02b4:
				if (dropClass.FLD_MAGIC0 == 0)
				{
					dropClass.FLD_MAGIC0 = World.GetStoneValue(dropClass.FLD_PID, 3);
					dropClass.FLD_PID = World.GetStonepid(dropClass.FLD_PID);
				}
				goto IL_0ecb;
				IL_0925:
				if (dropClass.FLD_MAGIC0 == 10)
				{
					int fLD_MAGIC3 = 0;
					int num5 = _evalAA.Next(1, 101);
					foreach (DropShuXClass item3 in dropClass.DropShuX)
					{
						if (num5 <= item3.Max)
						{
							fLD_MAGIC3 = _evalAA.Next(item3.ShuXMin, item3.ShuXMax);
							break;
						}
					}
					dropClass.FLD_MAGIC0 = fLD_MAGIC3;
				}
				else if (dropClass.FLD_MAGIC0 == 0)
				{
					dropClass.FLD_MAGIC0 = World.GetStoneValue(dropClass.FLD_PID, 3);
					dropClass.FLD_PID = World.GetStonepid(dropClass.FLD_PID);
				}
				goto IL_0ecb;
				IL_0b59:
				dropClass.FLD_MAGIC0 = _evalAA.Next(1001, 3000);
				dropClass.FLD_MAGIC1 = _evalAA.Next(2000, 2500);
				goto IL_0ecb;
				IL_0ae2:
				dropClass.FLD_MAGIC0 = _evalAA.Next(1001, 3000);
				dropClass.FLD_MAGIC1 = _evalAA.Next(100, 151);
				goto IL_0ecb;
				IL_0b1c:
				dropClass.FLD_MAGIC0 = _evalAA.Next(1001, 3000);
				dropClass.FLD_MAGIC1 = _evalAA.Next(400, 700);
				goto IL_0ecb;
				IL_0d1e:
				if (dropClass.FLD_MAGIC0 == 10)
				{
					int fLD_MAGIC4 = 0;
					int num6 = _evalAA.Next(1, 101);
					foreach (DropShuXClass item4 in dropClass.DropShuX)
					{
						if (num6 <= item4.Max)
						{
							fLD_MAGIC4 = _evalAA.Next(item4.ShuXMin, item4.ShuXMax);
							break;
						}
					}
					dropClass.FLD_MAGIC0 = fLD_MAGIC4;
				}
				else if (dropClass.FLD_MAGIC0 == 0)
				{
					dropClass.FLD_MAGIC0 = World.GetStoneValue(dropClass.FLD_PID, 3);
					dropClass.FLD_PID = World.GetStonepid(dropClass.FLD_PID);
				}
				goto IL_0ecb;
				IL_02f7:
				if (dropClass.FLD_MAGIC0 == 10)
				{
					int fLD_MAGIC5 = 0;
					int num7 = _evalAA.Next(1, 101);
					foreach (DropShuXClass item5 in dropClass.DropShuX)
					{
						if (num7 <= item5.Max)
						{
							fLD_MAGIC5 = _evalAA.Next(item5.ShuXMin, item5.ShuXMax);
							break;
						}
					}
					dropClass.FLD_MAGIC0 = fLD_MAGIC5;
				}
				else if (dropClass.FLD_MAGIC0 == 0)
				{
					dropClass.FLD_MAGIC0 = World.GetStoneValue(dropClass.FLD_PID, 3);
					dropClass.FLD_PID = World.GetStonepid(dropClass.FLD_PID);
				}
				goto IL_0ecb;
				IL_0b98:
				if (dropClass.FLD_MAGIC0 == 10)
				{
					int fLD_MAGIC6 = 0;
					int num8 = _evalAA.Next(1, 101);
					foreach (DropShuXClass item6 in dropClass.DropShuX)
					{
						if (num8 <= item6.Max)
						{
							fLD_MAGIC6 = _evalAA.Next(item6.ShuXMin, item6.ShuXMax);
							break;
						}
					}
					dropClass.FLD_MAGIC0 = fLD_MAGIC6;
				}
				goto IL_0ecb;
				IL_0ecb:
				掉出物品(dropClass, yxqname);
				goto end_IL_0001;
				IL_059d:
				if (dropClass.FLD_MAGIC0 == 10)
				{
					int fLD_MAGIC7 = 0;
					int num9 = _evalAA.Next(1, 101);
					foreach (DropShuXClass item7 in dropClass.DropShuX)
					{
						if (num9 <= item7.Max)
						{
							fLD_MAGIC7 = _evalAA.Next(item7.ShuXMin, item7.ShuXMax);
							break;
						}
					}
					dropClass.FLD_MAGIC0 = fLD_MAGIC7;
				}
				else if (dropClass.FLD_MAGIC0 == 0)
				{
					dropClass.FLD_MAGIC0 = World.GetStoneValue(dropClass.FLD_PID, 3);
					dropClass.FLD_PID = World.GetStonepid(dropClass.FLD_PID);
				}
				goto IL_0ecb;
				IL_0843:
				if (dropClass.FLD_MAGIC0 == 10)
				{
					int fLD_MAGIC8 = 0;
					int num10 = _evalAA.Next(1, 101);
					foreach (DropShuXClass item8 in dropClass.DropShuX)
					{
						if (num10 <= item8.Max)
						{
							fLD_MAGIC8 = _evalAA.Next(item8.ShuXMin, item8.ShuXMax);
							break;
						}
					}
					dropClass.FLD_MAGIC0 = fLD_MAGIC8;
				}
				else if (dropClass.FLD_MAGIC0 == 0)
				{
					dropClass.FLD_MAGIC0 = World.GetStoneValue(dropClass.FLD_PID, 3);
					dropClass.FLD_PID = World.GetStonepid(dropClass.FLD_PID);
				}
				goto IL_0ecb;
				IL_0a55:
				switch (fLD_PID)
				{
				case 1000000321:
					break;
				case 1000000323:
					goto IL_0ae2;
				case 1000000325:
					goto IL_0b1c;
				case 1000000327:
					goto IL_0b59;
				default:
					goto IL_0b98;
				case 800000061:
					goto IL_0c3c;
				case 800000062:
					goto IL_0d1e;
				}
				dropClass.FLD_MAGIC0 = _evalAA.Next(1001, 3000);
				dropClass.FLD_MAGIC1 = _evalAA.Next(10, 51);
				goto IL_0ecb;
				IL_0c3c:
				if (dropClass.FLD_MAGIC0 == 10)
				{
					int fLD_MAGIC9 = 0;
					int num11 = _evalAA.Next(1, 101);
					foreach (DropShuXClass item9 in dropClass.DropShuX)
					{
						if (num11 <= item9.Max)
						{
							fLD_MAGIC9 = _evalAA.Next(item9.ShuXMin, item9.ShuXMax);
							break;
						}
					}
					dropClass.FLD_MAGIC0 = fLD_MAGIC9;
				}
				else if (dropClass.FLD_MAGIC0 == 0)
				{
					dropClass.FLD_MAGIC0 = World.GetStoneValue(dropClass.FLD_PID, 3);
					dropClass.FLD_PID = World.GetStonepid(dropClass.FLD_PID);
				}
				goto IL_0ecb;
				IL_067f:
				if (dropClass.FLD_MAGIC0 == 10)
				{
					int fLD_MAGIC10 = 0;
					int num12 = _evalAA.Next(1, 101);
					foreach (DropShuXClass item10 in dropClass.DropShuX)
					{
						if (num12 <= item10.Max)
						{
							fLD_MAGIC10 = _evalAA.Next(item10.ShuXMin, item10.ShuXMax);
							break;
						}
					}
					dropClass.FLD_MAGIC0 = fLD_MAGIC10;
				}
				else if (dropClass.FLD_MAGIC0 == 0)
				{
					dropClass.FLD_MAGIC0 = World.GetStoneValue(dropClass.FLD_PID, 3);
					dropClass.FLD_PID = World.GetStonepid(dropClass.FLD_PID);
				}
				goto IL_0ecb;
				IL_04bb:
				if (dropClass.FLD_MAGIC0 == 10)
				{
					int fLD_MAGIC11 = 0;
					int num13 = _evalAA.Next(1, 101);
					foreach (DropShuXClass item11 in dropClass.DropShuX)
					{
						if (num13 <= item11.Max)
						{
							fLD_MAGIC11 = _evalAA.Next(item11.ShuXMin, item11.ShuXMax);
							break;
						}
					}
					dropClass.FLD_MAGIC0 = fLD_MAGIC11;
				}
				else if (dropClass.FLD_MAGIC0 == 0)
				{
					dropClass.FLD_MAGIC0 = World.GetStoneValue(dropClass.FLD_PID, 3);
					dropClass.FLD_PID = World.GetStonepid(dropClass.FLD_PID);
				}
				goto IL_0ecb;
				IL_0e00:
				if (dropClass.FLD_MAGIC0 == 10)
				{
					int fLD_MAGIC12 = 0;
					int num14 = _evalAA.Next(1, 101);
					foreach (DropShuXClass item12 in dropClass.DropShuX)
					{
						if (num14 <= item12.Max)
						{
							fLD_MAGIC12 = _evalAA.Next(item12.ShuXMin, item12.ShuXMax);
							break;
						}
					}
					dropClass.FLD_MAGIC0 = fLD_MAGIC12;
				}
				else if (dropClass.FLD_MAGIC0 == 0)
				{
					dropClass.FLD_MAGIC0 = _evalAA.Next(23, 52);
				}
				goto IL_0ecb;
				end_IL_0001:;
			}
			catch (Exception)
			{
			}
		}

		public bool 查找范围Npc(int far, NpcClass npc)
		{
			if (npc.RxjhMap != RxjhMap)
			{
				return false;
			}
			float num = npc.RxjhX - RxjhX;
			float num2 = npc.RxjhY - RxjhY;
			float num3 = (int)Math.Sqrt(num * num + num2 * num2);
			return num3 <= (float)far;
		}

		public bool 查找范围玩家(int far, Players playe)
		{
			if (playe.Player_FLD_Map != RxjhMap)
			{
				return false;
			}
			if (playe.Player_FLD_Map == 7301)
			{
				far = 1000;
			}
			float num = playe.Player_FLD_X - RxjhX;
			float num2 = playe.Player_FLD_Y - RxjhY;
			float num3 = (int)Math.Sqrt(num * num + num2 * num2);
			return num3 <= (float)far;
		}

		public bool 查找范围玩家(int far, PetClass playe)
		{
			if (playe.人物坐标_MAP != RxjhMap)
			{
				return false;
			}
			float num = playe.人物坐标_X - RxjhX;
			float num2 = playe.人物坐标_Y - RxjhY;
			float num3 = (int)Math.Sqrt(num * num + num2 * num2);
			return num3 <= (float)far;
		}

		public byte[] 掉出物品(DropClass drop, Players yxqname, int typeDrop = 0)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "NpcClass_掉出物品");
			}
			try
			{
				long dbItmeId = RxjhClass.GetDbItmeId();
				byte[] array = new byte[(World.Newversion >= 14) ? 76 : 73];
				byte[] bytes = BitConverter.GetBytes(dbItmeId);
				byte[] array2 = new byte[20];
				if (World.Itme.TryGetValue(drop.FLD_PID, out ItmeClass value))
				{
					if (value.FLD_QUESTITEM != 1)
					{
						try
						{
							if (yxqname != null)
							{
								logo.logdrop("[" + yxqname.Userid + "] [" + yxqname.UserName + "] : " + dbItmeId + " - " + drop.FLD_NAME + " - " + drop.FLD_PID + " - " + drop.FLD_MAGIC0 + " - " + drop.FLD_MAGIC1 + " - " + drop.FLD_MAGIC2 + " - " + drop.FLD_MAGIC3 + " - " + drop.FLD_MAGIC4 + " - ");
							}
							else
							{
								logo.logdrop("[NULL : " + dbItmeId + " - " + drop.FLD_NAME + " - " + drop.FLD_PID + " - " + drop.FLD_MAGIC0 + " - " + drop.FLD_MAGIC1 + " - " + drop.FLD_MAGIC2 + " - " + drop.FLD_MAGIC3 + " - " + drop.FLD_MAGIC4 + " - ");
							}
							if (World.Droplog)
							{
								Form1.WriteLine(4, "物品掉落--物品名:" + drop.FLD_NAME + " 属性1[" + drop.FLD_MAGIC0 + "]属性2[" + drop.FLD_MAGIC1 + "]属性3[" + drop.FLD_MAGIC2 + "]属性4[" + drop.FLD_MAGIC3 + "]属性5[" + drop.FLD_MAGIC4 + "]");
							}
							Buffer.BlockCopy(BitConverter.GetBytes(drop.FLD_MAGIC0), 0, array2, 0, 4);
							Buffer.BlockCopy(BitConverter.GetBytes(drop.FLD_MAGIC1), 0, array2, 4, 4);
							Buffer.BlockCopy(BitConverter.GetBytes(drop.FLD_MAGIC2), 0, array2, 8, 4);
							Buffer.BlockCopy(BitConverter.GetBytes(drop.FLD_MAGIC3), 0, array2, 12, 4);
							Buffer.BlockCopy(BitConverter.GetBytes(drop.FLD_MAGIC4), 0, array2, 16, 4);
							Buffer.BlockCopy(bytes, 0, array, 0, 4);
							Buffer.BlockCopy(array2, 0, array, 16, 20);
							Buffer.BlockCopy(BitConverter.GetBytes(drop.FLD_PID), 0, array, 8, 4);
							Buffer.BlockCopy(BitConverter.GetBytes(1), 0, array, 12, 4);
							if (value.FLD_CJL != 0)
							{
								Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_CJL), 0, array, 60, 2);
							}
						}
						catch (Exception ex)
						{
							Form1.WriteLine(1, "掉出物品1 出错 " + FldPid + "|" + Name + " " + ex.Message);
							return null;
						}
						GroundItems GroundItems;
						try
						{
							if (FldBoss == 0)
							{
								GroundItems = new GroundItems(array, RxjhX, RxjhY, RxjhZ, RxjhMap, yxqname, 0);
							}
							else
							{
								int num = _evalAA.Next(0, 2);
								double num2 = _evalAA.NextDouble() * 25.0;
								double num3 = _evalAA.NextDouble() * 25.0;
								GroundItems = ((num != 0) ? new GroundItems(array, RxjhX - (float)num2, RxjhY - (float)num3, RxjhZ, RxjhMap, yxqname, 0) : new GroundItems(array, RxjhX + (float)num2, RxjhY + (float)num3, RxjhZ, RxjhMap, yxqname, 0));
							}
							if (GroundItems == null)
							{
								Form1.WriteLine(1, "掉出物品2 出错 " + FldPid + "|" + Name);
								return null;
							}
							if (!World.ItmeTeM.ContainsKey(dbItmeId))
							{
								GroundItems.bDropByNPC = true;
								World.ItmeTeM.Add(dbItmeId, GroundItems);
							}
						}
						catch (Exception ex2)
						{
							Form1.WriteLine(1, "掉出物品3 出错 " + FldPid + "|" + Name + " " + ex2.Message);
							return null;
						}
						try
						{
							if (World.ItmeTeM.ContainsKey(dbItmeId))
							{
								GroundItems.获取范围玩家发送地面增加物品数据包();
							}
							return array;
						}
						catch (Exception ex3)
						{
							Form1.WriteLine(1, "掉出物品4 出错 " + FldPid + "|" + Name + " " + ex3.Message);
							return null;
						}
					}
					if (yxqname != null)
					{
						int num4 = yxqname.Find_Package_Empty(yxqname);
						if (num4 != -1)
						{
							yxqname._Make_Item_Option(bytes, BitConverter.GetBytes(drop.FLD_PID), num4, BitConverter.GetBytes(1), new byte[56]);
						}
					}
					return null;
				}
				return null;
			}
			catch (Exception ex4)
			{
				Form1.WriteLine(1, "掉出物品5 出错 " + FldPid + "|" + Name + " " + ex4.Message);
				return null;
			}
			finally
			{
				drop.FLD_MAGIC0 = drop.FLD_MAGICNew0;
				drop.FLD_MAGIC1 = drop.FLD_MAGICNew1;
				drop.FLD_MAGIC2 = drop.FLD_MAGICNew2;
				drop.FLD_MAGIC3 = drop.FLD_MAGICNew3;
				drop.FLD_MAGIC4 = drop.FLD_MAGICNew4;
			}
		}

		public void 发送采药数据()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "NpcClass_发送采药数据");
			}
			if (IsNpc == 2)
			{
				if (自动复活 != null)
				{
					自动复活.Interval = new Random(World.GetRandomSeed()).Next(60000, int.Parse(World.DelayDisableNpc[0]));
					自动复活.Enabled = true;
				}
				else
				{
					自动复活 = new System.Timers.Timer(new Random(World.GetRandomSeed()).Next(60000, int.Parse(World.DelayDisableNpc[0])));
					自动复活.Elapsed += 自动复活事件;
					自动复活.Enabled = true;
				}
				Play_null();
				广播npc死亡数据();
			}
		}

		public void 发送当前范围广播数据(PacketData pak, int id, int wordid)
		{
			try
			{
				if (_playList != null)
				{
					Queue queue = Queue.Synchronized(new Queue());
					foreach (Players value in _playList.Values)
					{
						queue.Enqueue(value);
					}
					while (queue.Count > 0)
					{
						if (World.JlMsg == 1)
						{
							Form1.WriteLine(0, "发送当前范围广播数据");
						}
						Players players = (Players)queue.Dequeue();
						if (players.Client != null)
						{
							if (players.Client.Running)
							{
								players.Client.SendPak(pak, id, wordid);
							}
							else
							{
								_playList.Remove(players.UserSessionID);
								if (players.Client != null)
								{
									players.Client.Dispose();
									players.GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 71", 7);
								}
							}
						}
						else
						{
							_playList.Remove(players.UserSessionID);
							if (players.Client != null)
							{
								players.Client.Dispose();
								players.GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 72", 7);
							}
						}
					}
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "NPC广播数据 出错3：" + arg);
			}
		}

		public void 发送反伤攻击数据(int 攻击力, int 人物id)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "NpcClass_发送反伤攻击数据");
			}
			string hex = "AA551C0000A42789000C002C0100000F0000000100000000000000000000000055AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(FldIndex), 0, array, 5, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(人物id), 0, array, 11, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(攻击力), 0, array, 19, 2);
			广播数据(array, array.Length);
		}

		public void 发送攻击数据(int 攻击力, int 攻击类型, int 人物全服id)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "NpcClass_发送攻击数据");
			}
			try
			{
				Players players = World.FindPlayerbyID(人物全服id);
				if (players != null)
				{
					int num = 0;
					if (players.Player_Job == 11)
					{
						long val = (long)((double)攻击力 * (5.0 + 2.0 * players.KhiCong_JOB11_0) / 100.0);
						val = Math.Min(val, players.Player_Shield);
						num = (int)val;
					}
					using (PacketData packetData = new PacketData())
					{
						packetData.WriteShort(人物全服id);
						if (World.Newversion >= 11)
						{
							packetData.WriteShort(1);
							packetData.WriteShort(1);
						}
						packetData.WriteShort(0);
						packetData.WriteInt(攻击力 - num);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						if (World.Newversion >= 15)
						{
							packetData.WriteInt(num);
							packetData.WriteInt(0);
							packetData.WriteInt(0);
							packetData.WriteInt(0);
							packetData.WriteInt(0);
						}
						packetData.WriteInt(0);
						packetData.WriteInt(攻击类型);
						packetData.WriteFloat(RxjhX);
						packetData.WriteFloat(RxjhZ);
						packetData.WriteFloat(RxjhY);
						packetData.WriteByte(0);
						packetData.WriteByte(1);
						packetData.WriteShort(0);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						发送当前范围广播数据(packetData, 3072, FldIndex);
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "发送攻击数据 出错" + FldPid + "|" + Name + " " + ex);
			}
		}

		public bool CheckKhoangCach00(int far, float x, float y)
		{
			int num = (int)Math.Sqrt(x * x + y * y);
			return num <= far;
		}

		public void NPC_Die(int userWorldId = 0)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "NpcClass_发送死亡数据");
			}
			if (World.怪物死亡触发器 == 1 && userWorldId != 0)
			{
				try
				{
					DropQuest(userWorldId);
				}
				catch (Exception ex)
				{
					Form1.WriteLine(2, "DROPQUEST ERROR -- " + userWorldId + " --" + ex.Message);
				}
			}
			try
			{
				异常状态列表();
				if (IsNpc != 1 && !Npc死亡)
				{
					if (World.AllConnectedChars.TryGetValue(PlayerWid, out Players value))
					{
						int num = value.Player_Level - Level;
						if (num < World.获得经验等级差 || FldBoss != 0)
						{
							暴物品(value);
						}
					}
					else
					{
						暴物品(null);
					}
					if (FldBoss == 1)
					{
						foreach (Players value2 in World.AllConnectedChars.Values)
						{
							value2.GameMessage(value.UserName + " ÐaÞ giêìt Boss " + Name, 8);
						}
					}
					else if (FldBoss == 2)
					{
						foreach (Players value3 in World.AllConnectedChars.Values)
						{
							value3.GameMessage(value.UserName + " ÐaÞ giêìt Boss " + Name, 8);
						}
					}
					Npc死亡 = true;
					if (FldPid == 15733 && World.血战 != null)
					{
						if (World.血战.帮战主方.申请人物列表.ContainsKey(userWorldId))
						{
							foreach (Players value4 in World.血战.帮战主方.申请人物列表.Values)
							{
								if (value4.UserName == World.血战.帮战主方.帮主名称)
								{
									if (CheckKhoangCach00(80, value4.Player_FLD_X, value4.Player_FLD_Y))
									{
										value4.Player_FLD_HP += 25000L;
										value4.Update_HP_MP_SP();
									}
									break;
								}
							}
						}
						else if (World.血战.帮战客方.申请人物列表.ContainsKey(userWorldId))
						{
							foreach (Players value5 in World.血战.帮战客方.申请人物列表.Values)
							{
								if (value5.UserName == World.血战.帮战客方.帮主名称)
								{
									if (CheckKhoangCach00(80, value5.Player_FLD_X, value5.Player_FLD_Y))
									{
										value5.Player_FLD_HP += 25000L;
										value5.Update_HP_MP_SP();
									}
									break;
								}
							}
						}
					}
					else if (FldPid == 15734 && World.血战 != null)
					{
						if (World.血战.帮战主方.申请人物列表.ContainsKey(userWorldId))
						{
							foreach (Players value6 in World.血战.帮战主方.申请人物列表.Values)
							{
								if (value6.UserName == World.血战.帮战主方.帮主名称)
								{
									value6.Player_FLD_HP -= 50000L;
									if (value6.Player_FLD_HP < 0)
									{
										value6.Player_FLD_HP = 0L;
										value6.Player_Die();
									}
									value6.Update_HP_MP_SP();
									break;
								}
							}
						}
						else if (World.血战.帮战客方.申请人物列表.ContainsKey(userWorldId))
						{
							foreach (Players value7 in World.血战.帮战客方.申请人物列表.Values)
							{
								if (value7.UserName == World.血战.帮战客方.帮主名称)
								{
									value7.Player_FLD_HP -= 50000L;
									if (value7.Player_FLD_HP < 0)
									{
										value7.Player_FLD_HP = 0L;
										value7.Player_Die();
									}
									value7.Update_HP_MP_SP();
									break;
								}
							}
						}
					}
					if (_一次性怪)
					{
						Play_null();
						广播npc死亡数据();
					}
					else
					{
						enableNpcAttack = false;
						enableNpcMove = true;
						if (World.势力战进程 == 3 && (FldPid == 15491 || FldPid == 15492 || FldPid == 15493 || FldPid == 15494 || FldPid == 15121 || FldPid == 15122))
						{
							if (FldPid == 15491 || FldPid == 15121)
							{
								World.势力战邪分数 += 500;
								value.GameMessage("BOSS TLC chiình phaìi ðaÞ chêìt", 8);
							}
							if (FldPid == 15493 || FldPid == 15122)
							{
								World.势力战正分数 += 500;
								value.GameMessage("BOSS TLC taÌ phaìi ðaÞ chêìt", 8);
							}
						}
						if (自动复活 != null)
						{
							自动复活.Interval = FldNewtime * 1000;
							自动复活.Enabled = true;
						}
						else
						{
							自动复活 = new System.Timers.Timer(FldNewtime * 1000);
							自动复活.Elapsed += 自动复活事件;
							自动复活.Enabled = true;
						}
						Play_null();
						广播npc死亡数据();
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "NPC_Die 出错" + FldPid + "|" + Name + " " + ex.Message);
			}
		}

		public void 发送移动数据(float x, float y, int sl, int Type_Move, float oldx = -99999f, float oldy = -99999f)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "NpcClass_发送移动数据");
			}
			try
			{
				using (PacketData packetData = new PacketData())
				{
					float value = RxjhX;
					float value2 = RxjhY;
					if (oldx != -99999f && oldy != -99999f)
					{
						value = oldx;
						value2 = oldy;
					}
					Random random = new Random(World.GetRandomSeed());
					int num = random.Next(0, 4);
					double num2 = random.NextDouble() * (double)sl;
					double num3 = random.NextDouble() * (double)sl;
					switch (num)
					{
					case 0:
						RxjhX = x + (float)num2;
						RxjhY = y + (float)num3;
						break;
					case 1:
						RxjhX = x - (float)num2;
						RxjhY = y + (float)num3;
						break;
					case 2:
						RxjhX = x + (float)num2;
						RxjhY = y - (float)num3;
						break;
					default:
						RxjhX = x - (float)num2;
						RxjhY = y - (float)num3;
						break;
					}
					packetData.WriteFloat(RxjhX);
					packetData.WriteFloat(RxjhY);
					packetData.WriteFloat(RxjhZ);
					packetData.WriteInt(-1);
					packetData.WriteInt(Type_Move);
					packetData.WriteFloat((float)num2);
					packetData.WriteInt((int)RxjhHp);
					if (World.Newversion >= 15)
					{
						packetData.WriteFloat(value);
						packetData.WriteFloat(RxjhZ);
						packetData.WriteFloat(value2);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
					}
					发送当前范围广播数据(packetData, 29696, FldIndex);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "发送移动数据 出错" + FldPid + "|" + Name + " " + ex.Message);
			}
		}

		public void 更新NPC删除数据(Players playe)
		{
			using (PacketData packetData = new PacketData())
			{
				packetData.WriteInt(1);
				packetData.WriteShort(FldIndex);
				packetData.WriteShort(FldIndex);
				packetData.WriteShort(FldPid);
				packetData.WriteInt(1);
				packetData.WriteInt((int)RxjhHp);
				packetData.WriteInt((int)MaxRxjhHp);
				packetData.WriteFloat(RxjhX);
				packetData.WriteFloat(RxjhZ);
				packetData.WriteFloat(RxjhY);
				packetData.WriteInt(1082130432);
				packetData.WriteFloat(FldFace1);
				packetData.WriteFloat(FldFace2);
				packetData.WriteFloat(RxjhX);
				packetData.WriteFloat(RxjhZ);
				packetData.WriteFloat(RxjhY);
				packetData.WriteInt(0);
				packetData.WriteInt(0);
				packetData.WriteInt(12);
				packetData.WriteInt(0);
				if (World.Newversion >= 16)
				{
					packetData.WriteInt(0);
				}
				if (World.Newversion >= 17)
				{
					packetData.WriteInt(uint.MaxValue);
				}
				if (playe.Client != null)
				{
					playe.Client.SendPak(packetData, 26624, playe.UserSessionID);
				}
			}
		}

		public static void 更新NPC删除数据(Dictionary<int, NpcClass> npcList, Players playe)
		{
			if (npcList != null && npcList.Count > 0)
			{
				using (PacketData packetData = new PacketData())
				{
					packetData.WriteInt(npcList.Count);
					foreach (NpcClass value in npcList.Values)
					{
						packetData.WriteShort(value.FldIndex);
						packetData.WriteShort(value.FldIndex);
						packetData.WriteShort(value.FldPid);
						packetData.WriteInt(1);
						packetData.WriteInt((int)value.RxjhHp);
						packetData.WriteInt((int)value.MaxRxjhHp);
						packetData.WriteFloat(value.RxjhX);
						packetData.WriteFloat(value.RxjhZ);
						packetData.WriteFloat(value.RxjhY);
						packetData.WriteInt(1082130432);
						packetData.WriteFloat(value.FldFace1);
						packetData.WriteFloat(value.FldFace2);
						packetData.WriteFloat(value.RxjhX);
						packetData.WriteFloat(value.RxjhZ);
						packetData.WriteFloat(value.RxjhY);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(12);
						packetData.WriteInt(0);
						if (World.Newversion >= 16)
						{
							packetData.WriteInt(0);
						}
						if (World.Newversion >= 17)
						{
							packetData.WriteInt(uint.MaxValue);
						}
					}
					if (playe.Client != null)
					{
						playe.Client.SendPak(packetData, 26624, playe.UserSessionID);
					}
				}
			}
		}

		public static void 更新npc数据(Dictionary<int, NpcClass> npcList, Players playe)
		{
			if (npcList != null && npcList.Count > 0)
			{
				using (PacketData packetData = new PacketData())
				{
					packetData.WriteInt(npcList.Count);
					foreach (NpcClass value in npcList.Values)
					{
						packetData.WriteShort(value.FldIndex);
						packetData.WriteShort(value.FldIndex);
						packetData.WriteShort(value.FldPid);
						packetData.WriteInt(1);
						packetData.WriteInt((int)value.RxjhHp);
						packetData.WriteInt((int)value.MaxRxjhHp);
						packetData.WriteFloat(value.RxjhX);
						packetData.WriteFloat(value.RxjhZ);
						packetData.WriteFloat(value.RxjhY);
						packetData.WriteInt(1082130432);
						packetData.WriteFloat(value.FldFace1);
						packetData.WriteFloat(value.FldFace2);
						packetData.WriteFloat(value.RxjhX);
						packetData.WriteFloat(value.RxjhZ);
						packetData.WriteFloat(value.RxjhY);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(0);
						packetData.WriteInt(1310720);
						if (World.Newversion >= 16)
						{
							packetData.WriteInt(0);
						}
						if (World.Newversion >= 17)
						{
							packetData.WriteInt(uint.MaxValue);
						}
						if (value.Npc死亡)
						{
							value.更新NPC删除数据(playe);
							value.更新npc死亡数据(playe);
						}
					}
					if (playe.Client != null)
					{
						playe.Client.SendPak(packetData, 26368, playe.UserSessionID);
					}
				}
			}
		}

		public void 广播数据(byte[] data, int length)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "NpcClass_广播数据2");
			}
			try
			{
				Queue queue = Queue.Synchronized(new Queue());
				foreach (Players value in _playList.Values)
				{
					queue.Enqueue(value);
				}
				while (queue.Count > 0)
				{
					if (World.JlMsg == 1)
					{
						Form1.WriteLine(0, "广播数据2");
					}
					Players current = (Players)queue.Dequeue();
					if (current.Client != null)
					{
						if (current.Client.Running)
						{
							current.Client.Send(data, length);
						}
						else
						{
							current.Client.Dispose();
							current.GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 73", 7);
							_playList.Remove(current.UserSessionID);
						}
					}
					if (!World.AllConnectedChars.ContainsKey(current.Client.WorldId))
					{
						Form1.WriteLine(2, "NPC 广播数据 删除卡号人物：[" + current.Userid + "] [" + current.UserName + "]");
						if (current.Client != null)
						{
							current.Client.Dispose();
							current.GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 75", 7);
						}
						_playList.Remove(current.UserSessionID);
					}
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "NPC广播数据2 出错2：" + arg);
			}
		}

		public long 获得经验()
		{
			int num = 0;
			num = ((World.AlphaTest == 0 || World.经验倍数 >= 100) ? (RxjhExp * World.经验倍数) : (RxjhExp * World.经验倍数 * 3000));
			if (num > 1 && World.PkSwitch == 0 && !World.isMapPK(_rxjhMap))
			{
				num = (int)((double)num * 0.9);
			}
			if (RxjhExp < 0 || num < 0)
			{
				return 0L;
			}
			if (RxjhExp > 0 && num <= 0)
			{
				return 1L;
			}
			int num2 = num / 3;
			return _evalK.Next(num - num2, num + num2);
		}

		public int 获得历练()
		{
			int num = 0;
			if (World.AlphaTest != 0 && World.历练倍数 < 100)
			{
				num = RxjhExp * World.历练倍数 * 500;
			}
			else
			{
				int minValue = (int)Math.Pow(Level, 1.23);
				int maxValue = (int)Math.Pow(Level, 1.33);
				int num2 = new Random((int)DateTime.Now.Ticks).Next(minValue, maxValue);
				num = num2 * World.历练倍数;
			}
			int num3 = num / 3;
			return _evalK.Next(num - num3, num + num3);
		}

		public int 获得钱()
		{
			int num = 0;
			if (World.AlphaTest != 0 && World.钱倍数 < 10)
			{
				num = RxjhExp * World.钱倍数 * 50;
			}
			else
			{
				int minValue = (int)Math.Pow(Level, 1.13);
				int maxValue = (int)Math.Pow(Level, 1.23);
				int num2 = new Random((int)DateTime.Now.Ticks).Next(minValue, maxValue);
				num = num2 * World.钱倍数;
			}
			int num3 = num / 3;
			return _evalK.Next(num - num3, num + num3);
		}

		public int 获得升天历练()
		{
			int num = 0;
			num = ((World.AlphaTest == 0 || !(World.升天历练倍数 < 4.0)) ? ((int)((double)RxjhExp * World.升天历练倍数)) : ((int)((double)RxjhExp * World.升天历练倍数 * 5.0)));
			int num2 = num / 3;
			return _evalK.Next(num - num2, num + num2);
		}

		public bool 获取范围玩家()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "NpcClass_获取范围玩家");
			}
			try
			{
				foreach (Players value in World.AllConnectedChars.Values)
				{
					if ((Level >= value.Player_Level - 20 && value.GM模式 == 0 && value.Player_FLD_HP > 0 && value.Player_FLD_Map != 801 && 查找范围玩家(75, value)) || ((_fldPid == 15494 || _fldPid == 15493 || _fldPid == 15121) && value.Player_Zx != 2) || ((_fldPid == 15492 || _fldPid == 15491 || _fldPid == 15122) && value.Player_Zx != 1))
					{
						Play_Add(value, 1L);
						return true;
					}
				}
			}
			catch (Exception)
			{
				return false;
			}
			return false;
		}

		public void 获取范围玩家发送消失数据包()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "NpcClass_获取范围玩家发送消失数据包");
			}
			try
			{
				Queue queue = Queue.Synchronized(new Queue());
				try
				{
					foreach (Players value in _playList.Values)
					{
						queue.Enqueue(value);
					}
				}
				catch (Exception arg)
				{
					Form1.WriteLine(1, "NPC 获取范围玩家发送消失数据包1 出错：" + arg);
				}
				while (queue.Count > 0)
				{
					if (World.JlMsg == 1)
					{
						Form1.WriteLine(0, "获取范围玩家发送消失数据包");
					}
					Players players = (Players)queue.Dequeue();
					try
					{
						players.获取复查范围Npc();
					}
					catch (Exception arg2)
					{
						Form1.WriteLine(1, "NPC 获取范围玩家发送消失数据包2 出错：" + arg2);
					}
				}
				_playList.Clear();
			}
			catch (Exception arg3)
			{
				Form1.WriteLine(1, "NPC 获取范围玩家发送消失数据包3 出错：" + arg3);
			}
		}

		public void 获取范围玩家发送增加数据包()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "NpcClass_获取范围玩家发送增加数据包");
			}
			try
			{
				foreach (Players value in World.AllConnectedChars.Values)
				{
					if (查找范围玩家(300, value))
					{
						value.获取复查范围Npc();
					}
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "获取范围玩家发送地面增加Npc数据包 出错：" + arg);
			}
		}

		public void 群攻查找范围Npc()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "NpcClass_群攻查找范围Npc");
			}
			try
			{
				_npcList.Clear();
				int num = 0;
				foreach (NpcClass value in MapClass.GetnpcTemplate(RxjhMap).Values)
				{
					if (!value.Npc死亡 && value.IsNpc == 0 && 查找范围Npc(50, value))
					{
						_npcList.Add(value.FldIndex, value);
						if (num > 4)
						{
							break;
						}
						num++;
					}
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "群攻查找范围Npc 出错：" + arg);
			}
		}

		public List<NpcClass> 群攻查找范围Npc2(int 数量, int KC = 25)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "NpcClass_群攻查找范围Npc2");
			}
			try
			{
				List<NpcClass> list = new List<NpcClass>();
				int num = 1;
				foreach (NpcClass value in MapClass.GetnpcTemplate(RxjhMap).Values)
				{
					if (num >= 数量)
					{
						break;
					}
					if (!value.Npc死亡 && value.IsNpc == 0 && 查找范围Npc(KC, value) && value._fldIndex != _fldIndex)
					{
						list.Add(value);
						num++;
					}
				}
				return list;
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "群攻查找范围Npc 出错：" + arg);
				return null;
			}
		}

		public void 异常状态列表()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "NpcClass_异常状态列表");
			}
			Queue queue = Queue.Synchronized(new Queue());
			try
			{
				foreach (异常状态类 value in 异常状态.Values)
				{
					queue.Enqueue(value);
				}
				while (queue.Count > 0)
				{
					if (World.JlMsg == 1)
					{
						Form1.WriteLine(0, "异常状态列表NPC");
					}
					异常状态类 异常状态类 = (异常状态类)queue.Dequeue();
					异常状态类.EndEvent();
					if (异常状态 != null)
					{
						异常状态.Remove(异常状态类.FldPid);
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "NPC异常状态列表出错![" + FldIndex + "]-[" + Name + "]" + ex.Message);
			}
			finally
			{
				queue = null;
			}
		}
	}
}

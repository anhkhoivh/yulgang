using HelperTools;
using RxjhServer;
using RxjhServer.RxjhServer;
using System;
using System.Timers;

namespace YulgangServer.RxjhServer
{
	public class 异常状态类 : IDisposable
	{
		private int _evalA;

		public NpcClass Npc;

		public int NpcPlayId;

		public System.Timers.Timer Npcyd;

		public Players Play;

		public DateTime Time;

		public System.Timers.Timer Yczt;

		public double Ycztsl;

		public int FldPid
		{
			get
			{
				return _evalA;
			}
			set
			{
				_evalA = value;
			}
		}

		public 异常状态类(Players play, int 时间, int 异常id, int 异常数量)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "异常状态类-NEW");
			}
			FldPid = 异常id;
			Time = DateTime.Now;
			Time = Time.AddMilliseconds((double)时间 + 0.0);
			Play = play;
			Npcyd = new System.Timers.Timer((double)时间 + 0.0);
			Npcyd.Elapsed += 时间结束事件1;
			Npcyd.Enabled = true;
			Npcyd.AutoReset = false;
			状态效果(FldPid, 1, 异常数量, (时间 + 1000) / 1000);
		}

		public 异常状态类(NpcClass play, int npcPlayId, int 时间, int 异常id, int 异常数量)
		{
			NpcPlayId = npcPlayId;
			FldPid = 异常id;
			Time = DateTime.Now;
			Time = Time.AddMilliseconds((double)时间 + 1000.0);
			Npc = play;
			Npcyd = new System.Timers.Timer((double)时间 + 1000.0);
			Npcyd.Elapsed += 时间结束事件1;
			Npcyd.Enabled = true;
			Npcyd.AutoReset = false;
			状态效果(FldPid, 1, 异常数量, 时间 / 1000);
		}

		public void Dispose()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "异常状态类-Dispose");
			}
			if (Npcyd != null)
			{
				Npcyd.Enabled = false;
				Npcyd.Close();
				Npcyd.Dispose();
				Npcyd = null;
			}
			if (Yczt != null)
			{
				Yczt.Enabled = false;
				Yczt.Close();
				Yczt.Dispose();
				Yczt = null;
			}
			Play = null;
			Npc = null;
		}

		public void DecreaseMP_3s_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "yczt_Elapsed");
			}
			if (Play != null)
			{
				Play.Player_FLD_MP -= (int)Ycztsl;
				if ((long)Play.Player_FLD_MP < 0L)
				{
					Play.Player_FLD_MP = 0;
				}
				try
				{
					Play.Update_HP_MP_SP();
				}
				catch
				{
				}
			}
			else
			{
				if (Npc == null)
				{
					return;
				}
				Npc.RxjhHp -= (int)Ycztsl;
				if (Npc.RxjhHp <= 0)
				{
					Npc.NPC_Die(NpcPlayId);
					if (Yczt != null)
					{
						Yczt.Enabled = false;
						Yczt.Close();
						Yczt.Dispose();
						Yczt = null;
					}
				}
			}
		}

		public void yczt_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "yczt_Elapsed");
			}
			if (Play != null)
			{
				Play.Ravage_HP((int)Ycztsl);
				if (Play.Player_Job == 2 || Play.Player_Job == 9)
				{
					double num = new Random(World.GetRandomSeed()).Next(0, 120);
					if (num <= Play.剑_升天三气功_火凤临朝 && Play.Player_FLD_HP <= 0)
					{
						Play.Player_FLD_HP = 10L;
						Play.Show_Qigong_Effect(Play.UserSessionID, 322);
					}
				}
				if (Play.Player_Job == 8)
				{
					double num = new Random(World.GetRandomSeed()).Next(0, 120);
					if (num <= Play.剑_升天三气功_火凤临朝 && Play.Player_FLD_HP <= 0)
					{
						Play.Player_FLD_HP = 10L;
						Play.Show_Qigong_Effect(Play.UserSessionID, 322);
					}
				}
				if (Play.Player_FLD_HP <= 0)
				{
					Play.Player_Die();
					if (Yczt != null)
					{
						Yczt.Enabled = false;
						Yczt.Close();
						Yczt.Dispose();
						Yczt = null;
					}
				}
				try
				{
					Play.Update_HP_MP_SP();
				}
				catch
				{
				}
			}
			else
			{
				if (Npc == null)
				{
					return;
				}
				Npc.RxjhHp -= (int)Ycztsl;
				if (Npc.RxjhHp <= 0)
				{
					Npc.NPC_Die(NpcPlayId);
					if (Yczt != null)
					{
						Yczt.Enabled = false;
						Yczt.Close();
						Yczt.Dispose();
						Yczt = null;
					}
				}
			}
		}

		public void EndEvent()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "异常状态类-时间结束事件");
			}
			try
			{
				if (Npcyd != null)
				{
					Npcyd.Enabled = false;
					Npcyd.Close();
					Npcyd.Dispose();
					Npcyd = null;
				}
				if (Npc != null)
				{
					switch (FldPid)
					{
					case 1:
						Npc.FLD_TRUDAME_NPC_CAMSU = 0;
						break;
					case 2:
						Npc.FLD_TRUDEF_NPC_CAMSU = 0;
						break;
					case 22:
						Npc.FLD_TRUDAME_NPC_CAMSU = 0;
						break;
					case 25:
						Npc.FLD_TRUDEF_NPC_CAMSU = 0;
						break;
					case 9:
						Npc.FLD_TRUDEF_NPC_NINJA = 0;
						break;
					}
					if (Npc.异常状态 != null)
					{
						Npc.异常状态.Remove(FldPid);
					}
					状态效果(FldPid, 0, 0, 0);
					Dispose();
				}
				else if (Play != null)
				{
					switch (FldPid)
					{
					case 1:
						Play.UpdatePowersAndStatus();
						break;
					case 2:
						Play.UpdatePowersAndStatus();
						break;
					case 22:
						Play.FLD_TRUDAME_CAMSU = 0.0;
						Play.UpdatePowersAndStatus();
						break;
					case 25:
						Play.FLD_TRUDEF_CAMSU = 0.0;
						Play.UpdatePowersAndStatus();
						break;
					case 20:
						Play.FLD_TANGDEF_CAMSU = 0.0;
						Play.UpdatePowersAndStatus();
						break;
					case 9:
						Play.FLD_TRUDEF_NINJA = 0.0;
						Play.UpdatePowersAndStatus();
						break;
					case 15:
						Play.FLD_追加百分比_MP上限 += 0.1;
						Play.UpdatePowersAndStatus();
						break;
					}
					if (Play.异常状态 != null)
					{
						Play.异常状态.Remove(FldPid);
					}
					状态效果(FldPid, 0, 0, 0);
					Dispose();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "异常状态类 时间结束事件 出错：[" + FldPid + "]" + ex);
			}
			finally
			{
				Dispose();
			}
		}

		public void 时间结束事件1(object sender, ElapsedEventArgs e)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "时间结束事件1");
			}
			EndEvent();
		}

		public void DecreaseHP_1s(double ycztsll)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "异常状态类-DecreaseHP_1s");
			}
			Ycztsl = ycztsll;
			Yczt = new System.Timers.Timer(1000.0);
			Yczt.Elapsed += yczt_Elapsed;
			Yczt.Enabled = true;
			Yczt.AutoReset = true;
		}

		public void DecreaseHP_3s(double ycztsll)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "异常状态类-DecreaseHP_3s");
			}
			Ycztsl = ycztsll;
			Yczt = new System.Timers.Timer(3000.0);
			Yczt.Elapsed += yczt_Elapsed;
			Yczt.Enabled = true;
			Yczt.AutoReset = true;
		}

		public void DecreaseMP_3s(double ycztsll)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "异常状态类-DecreaseMP_3s");
			}
			Ycztsl = ycztsll;
			Yczt = new System.Timers.Timer(3000.0);
			Yczt.Elapsed += DecreaseMP_3s_Elapsed;
			Yczt.Enabled = true;
			Yczt.AutoReset = true;
		}

		public void 状态效果(int 异常id, int 开关, int 异常数量, int 时间)
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "异常状态类-状态效果");
			}
			string hex = "AA554700003527401538008C0300002C0100000900000001000000000000006016A2496016A2492600000014000000000000008C030000E80300000900000001000000000000000000000055AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(异常id), 0, array, 19, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(异常id), 0, array, 59, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(开关), 0, array, 23, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(开关), 0, array, 63, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(时间), 0, array, 39, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(异常数量), 0, array, 43, 4);
			if (Play != null)
			{
				Buffer.BlockCopy(BitConverter.GetBytes(Play.UserSessionID), 0, array, 15, 2);
				Buffer.BlockCopy(BitConverter.GetBytes(Play.UserSessionID), 0, array, 5, 2);
				if (Play.Client != null)
				{
					Play.Client.Send多包(array, array.Length);
				}
				Play.发送当前范围广播数据多包(array, array.Length);
			}
			else if (Npc != null)
			{
				Buffer.BlockCopy(BitConverter.GetBytes(Npc.FldIndex), 0, array, 15, 2);
				Buffer.BlockCopy(BitConverter.GetBytes(Npc.FldIndex), 0, array, 5, 2);
				Npc.广播数据(array, array.Length);
			}
		}
	}
}

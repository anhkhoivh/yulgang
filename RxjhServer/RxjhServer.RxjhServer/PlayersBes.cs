using DbClss;
using HelperTools;
using Network;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Timers;
using YulgangServer.RxjhServer;
using YulgangServer.RxjhServer.DbClss;

namespace RxjhServer.RxjhServer
{
	public class PlayersBes : 气功属性
	{
		public double _FLD_人物_追加_合成成功率百分比;

		public double _FLD_装备_追加_经验百分比;

		public double _ExpExporll;

		private int _FLD_斗神_追加_防御;

		private int _FLD_斗神_追加_攻击;

		private int _FLD_斗神_追加_气功;

		public double _KiExporll;

		public bool _Player死亡;

		public int _KyNangManhNhat_MP;

		private int _人物_MP;

		private int _人物_SP;

		private int _Player_Zx;

		private int _playerLevel;

		public Dictionary<int, string> allChars;

		private int _Player_WuXun;

		private int _人物善恶;

		private int _Player_Job;

		private int _Player_Sex;

		private int _人物负重;

		private int _人物负重总;

		private int _转生次数;

		private int _会员等级;

		private int _FLD_VoHoang;

		private int _playerShield;

		private int _playerBasicShield;

		private int _fldItemShield;

		private int _fldItemShield_Recover;

		private int _FLD_Item_HP_Recover;

		private int _FLD_Item_MP_Recover;

		private int _FLD_MetMoi;

		private int _FLD_心;

		private int _FLD_体;

		private int _FLD_力;

		private int _FLD_身;

		private int int_196;

		private int int_197;

		private int int_198;

		private int int_199;

		private string QfYxTU9X3;

		private int _FLD_师徒_武功ID1_1;

		private int _FLD_师徒_武功ID1_2;

		private int _FLD_师徒_武功ID1_3;

		private string _FLD_DayQuest_Array;

		private string XwDHJf2ag;

		private string JDVis2ID6;

		private string gifcaaiuT;

		private string atbX1XeoP = string.Empty;

		public ConfigClass Config;

		public byte[] cacheDataConfig;

		private byte[] _总在线时间;

		private int _每日武勋;

		private object eval_a_a = new object();

		private long _个人仓库钱数;

		private int _弓群攻技能ID;

		private long _综合仓库钱数;

		private int _FLD_RXPIONT;

		private int int_1196;

		private int int_1197;

		private int int_1198;

		private int int_1199;

		private int int_1200;

		private int _FLD_RXPIONTX;

		private int _Rxjh_WX;

		private int _FLD_VIP;

		private int _FLD_SVIP;

		private int _装备行囊是否开启;

		private DateTime _FLD_VIPTIM;

		private int _FLD_攻击速度;

		private int _Player_HP_Guild;

		private int _Player_MP_Guild;

		private int _武勋追加_HP;

		private int _人物追加最大_HP;

		private int _人物基本最大_MP;

		private int _武勋追加_MP;

		private int _fldItemPremiumMp;

		private int _人物_气功_追加_MP;

		private int _人物最大_SP;

		private int _Player_Qigong_point;

		private int _人物武勋阶段;

		private int _playerJobLevel;

		private byte[] _nameType;

		private float _人物坐标_X;

		private float _人物坐标_Y;

		private float _人物坐标_Z;

		private int _人物坐标_地图;

		private int _人物PK模式;

		private object eval_b_b = new object();

		private long _奖励_追加_防御;

		private int _奖励_追加_命中;

		private int _FLD_人物_气功_攻击;

		private int _FLD_人物_气功_命中;

		private int _FLD_人物_气功_防御;

		private int _FLD_Qigong_Defense_Skill;

		private int _FLD_人物_气功_回避;

		private double _fldItemSkillDefPercentage;

		private double _fldItemSkillAttackPercentage;

		private double _FLD_人物_武功攻击力增加百分比;

		private double _FLD_人物_武功防御力增加百分比;

		private int _FLD_制作类型;

		private int _FLD_制作等级;

		private int _FLD_制作熟练度;

		private string _FLD_Couple_Name;

		private string _FLD_Couple_Name_Unknow;

		private int _FLD_Couple_Exp;

		private int _FLD_Couple_ExpMax;

		private int _FLD_Couple_Level;

		private double _FLD_BUFF_DP_ATT = 0.0;

		private double _FLD_BUFF_DP_DEF = 0.0;

		private double _FLD_BUFF_DP_HP = 0.0;

		private double _FLD_BUFF_DP_CX = 0.0;

		private double _FLD_BUFF_DP_NT = 0.0;

		private double _FLD_Item_AoChoang_ChinhXac = 0.0;

		private double _FLD_Item_AoChoang_NeTranh = 0.0;

		private double _FLD_追加百分比_攻击;

		private double _FLD_追加百分比_攻击_KCDAO115;

		private double _FLD_追加百分比_攻击_PHANNO;

		private double _FLD_追加百分比_防御;

		private double _FLD_追加百分比_防御_KCDAO115;

		private double _FLD_追加百分比_防御_PHANNO;

		private double _FLD_追加百分比_Shield_PHANNO;

		private double _FLD_追加百分比_防御_DAIPHU115;

		private double _FLD_TRUDEF_NINJA = 0.0;

		private double _FLD_TANGHP_DP = 0.0;

		private double _FLD_TRUDEF_801302 = 0.0;

		private double _FLD_TRUDEF_CAMSU = 0.0;

		private double _FLD_TANGDEF_CAMSU = 0.0;

		private double _FLD_TRUDAME_CAMSU = 0.0;

		private double _FLD_追加百分比_命中;

		private double _FLD_追加百分比_回避;

		private double _FLD_追加百分比_HP上限;

		private double _FLD_追加百分比_MP上限;

		private int _FLD_攻击;

		private int _FLD_武勋攻击;

		private int _FLD_命中;

		private int _FLD_防御;

		private int _FLD_武勋防御;

		private int _FLD_回避;

		private int _FLD_装备_追加_追伤;

		private int _奖励_追加_内功;

		private long _奖励_追加_生命;

		private int _奖励_追加_回避;

		private long _奖励_追加_攻击;

		private object eval_c = new object();

		private double _FLD_装备_追加_剑客连环飞舞;

		private double _FLD_装备_追加_剑客必杀一击;

		private double _FLD_装备_追加_剑客狂风万破;

		private double _FLD_装备_追加_剑客护身罡气;

		private double _FLD_装备_追加_剑客移花接木;

		private double _FLD_装备_追加_剑客回柳身法;

		private double _FLD_装备_追加_剑客冲冠一怒;

		private double _FLD_装备_追加_剑客怒海狂澜;

		private double _FLD_装备_追加_枪客金钟罩气;

		private double _FLD_装备_追加_枪客运气疗伤;

		private double _FLD_人物_气功_武功攻击力增加百分比;

		private double _FLD_人物_气功_武功防御力增加百分比;

		private int _FLD_人物_追加_攻击;

		private int _FLD_人物_追加_防御;

		private int _FLD_人物_追加_命中;

		private int _FLD_人物_追加_回避;

		private int _FLD_人物_追加_气功;

		private int _FLD_武勋_追加_气功;

		private double _FLD_人物_追加_经验百分比;

		private double _FLD_Event_Premium_Exp;

		private double _FLD_TLC_Premium_Exp;

		private double _FLD_人物_追加_金钱百分比;

		private double _FLD_人物_追加_历练百分比;

		private double _FLD_人物_追加_物品掉落概率百分比;

		private double _FLD_装备_追加_合成成功率百分比;

		private double _FLD_装备_追加_获得游戏币百分比;

		private double _FLD_装备_追加_刀客力劈华山;

		private double _FLD_装备_追加_qigong_11_job1;

		private double _FLD_装备_追加_qigong_11_job2;

		private double _FLD_装备_追加_qigong_11_job3;

		private double _FLD_装备_追加_qigong_11_job4;

		private double _FLD_装备_追加_qigong_11_job5;

		private double _FLD_装备_追加_qigong_11_job6;

		private double _FLD_装备_追加_qigong_11_job7;

		private double _FLD_装备_追加_qigong_0_job8;

		private double _FLD_装备_追加_qigong_1_job8;

		private double _FLD_装备_追加_qigong_2_job8;

		private double _FLD_装备_追加_qigong_3_job8;

		private double _FLD_装备_追加_qigong_4_job8;

		private double _FLD_装备_追加_qigong_5_job8;

		private double _FLD_装备_追加_qigong_7_job8;

		private double _FLD_装备_追加_qigong_8_job8;

		private double _FLD_装备_追加_qigong_9_job8;

		private double _FLD_装备_追加_qigong_10_job8;

		private double _FLD_装备_追加_qigong_11_job8;

		private double _FLD_装备_追加_qigong_0_job9;

		private double _FLD_装备_追加_qigong_1_job9;

		private double _FLD_装备_追加_qigong_2_job9;

		private double _FLD_装备_追加_qigong_3_job9;

		private double _FLD_装备_追加_qigong_4_job9;

		private double _FLD_装备_追加_qigong_5_job9;

		private double _FLD_装备_追加_qigong_7_job9;

		private double _FLD_装备_追加_qigong_8_job9;

		private double _FLD_装备_追加_qigong_9_job9;

		private double _FLD_装备_追加_qigong_10_job9;

		private double _FLD_装备_追加_qigong_11_job9;

		private double _FLD_装备_追加_qigong_0_job10;

		private double _FLD_装备_追加_qigong_1_job10;

		private double _FLD_装备_追加_qigong_2_job10;

		private double _FLD_装备_追加_qigong_3_job10;

		private double _FLD_装备_追加_qigong_4_job10;

		private double _FLD_装备_追加_qigong_5_job10;

		private double _FLD_装备_追加_qigong_7_job10;

		private double _FLD_装备_追加_qigong_8_job10;

		private double _FLD_装备_追加_qigong_9_job10;

		private double _FLD_装备_追加_qigong_10_job10;

		private double _FLD_装备_追加_qigong_11_job10;

		private double _FLD_装备_追加_qigong_0_job11;

		private double _FLD_装备_追加_qigong_1_job11;

		private double _FLD_装备_追加_qigong_2_job11;

		private double _FLD_装备_追加_qigong_3_job11;

		private double _FLD_装备_追加_qigong_4_job11;

		private double _FLD_装备_追加_qigong_5_job11;

		private double _FLD_装备_追加_qigong_7_job11;

		private double _FLD_装备_追加_qigong_8_job11;

		private double _FLD_装备_追加_qigong_9_job11;

		private double _FLD_装备_追加_qigong_10_job11;

		private double _FLD_装备_追加_qigong_11_job11;

		private double _FLD_装备_追加_qigong_0_job12;

		private double _FLD_装备_追加_qigong_1_job12;

		private double _FLD_装备_追加_qigong_2_job12;

		private double _FLD_装备_追加_qigong_3_job12;

		private double _FLD_装备_追加_qigong_4_job12;

		private double _FLD_装备_追加_qigong_5_job12;

		private double _FLD_装备_追加_qigong_7_job12;

		private double _FLD_装备_追加_qigong_8_job12;

		private double _FLD_装备_追加_qigong_9_job12;

		private double _FLD_装备_追加_qigong_10_job12;

		private double _FLD_装备_追加_qigong_11_job12;

		private double _FLD_装备_追加_刀客摄魂一击;

		private double _FLD_装备_追加_刀客连环飞舞;

		private double _FLD_装备_追加_刀客必杀一击;

		private double _FLD_装备_追加_刀客狂风万破;

		private double _FLD_装备_追加_刀客四两千斤;

		private double _FLD_装备_追加_刀客真武绝击;

		private double _FLD_装备_追加_刀客稳如泰山;

		private double _FLD_装备_追加_刀客霸气破甲;

		private double _FLD_装备_追加_刀客暗影绝杀;

		private double _FLD_装备_追加_剑客长虹贯日;

		private double _FLD_装备_追加_剑客百变神行;

		private NetState _Client;

		private double _FLD_装备_追加_医体血倍增;

		private double _FLD_装备_追加_医天佑之气;

		private double _FLD_装备_追加_刺客荆轲之怒;

		private double _FLD_装备_追加_刺客三花聚顶;

		private double _FLD_装备_追加_刺客连环飞舞;

		private double _FLD_装备_追加_刺客必杀一击;

		private double _FLD_装备_追加_刺客心神凝聚;

		private double _FLD_装备_追加_刺客致命绝手;

		private double _FLD_装备_追加_刺客先发制人;

		private double _FLD_装备_追加_刺客千株万手;

		private double _FLD_装备_追加_枪客连环飞舞;

		private double _FLD_装备_追加_枪客必杀一击;

		private double _FLD_装备_追加_枪客狂风万破;

		private double _FLD_装备_追加_枪客横练太保;

		private double _FLD_装备_追加_枪客乾坤挪移;

		private double _FLD_装备_追加_枪客灵甲护身;

		private double _FLD_装备_追加_枪客转守为攻;

		private double _FLD_装备_追加_枪客狂神降世;

		private double _FLD_装备_追加_弓百步穿杨;

		private double _FLD_装备_追加_弓猎鹰之眼;

		private double _FLD_装备_追加_弓凝神聚气;

		private double _FLD_装备_追加_弓必杀一击;

		private double _FLD_装备_追加_弓狂风万破;

		private double _FLD_装备_追加_弓正本培元;

		private double _FLD_装备_追加_弓心神凝聚;

		private double _FLD_装备_追加_弓流星三矢;

		private double _FLD_装备_追加_弓无明暗矢;

		private double _FLD_装备_追加_弓锐利之箭;

		private double _FLD_装备_追加_医运气行心;

		private double _FLD_装备_追加_医太极心法;

		private double _FLD_装备_追加_医洗髓易经;

		private double _FLD_装备_追加_医妙手回春;

		private double _FLD_装备_追加_医长功攻击;

		private double _FLD_装备_追加_医吸星大法;

		private double _FLD_装备_追加_医神农仙术;

		private double _FLD_装备_追加_医九天真气;

		private int _FLD_装备_追加_HP;

		private long _HP_GuildWar;

		private int _FLD_装备_追加_MP;

		private double _FLD_装备_追加_刺客剑刃乱舞;

		private double _FLD_装备_追加_刺客连消带打;

		private double _FLD_装备_追加_琴师岳阳三醉;

		private double _FLD_装备_追加_琴师战马奔腾;

		private double _FLD_装备_追加_琴师秋江夜泊;

		private double _FLD_装备_追加_琴师清心普善;

		private double _FLD_装备_追加_琴师阳关三叠;

		private double _FLD_装备_追加_琴师汉宫秋月;

		private double _FLD_装备_追加_琴师高山流水;

		private double _FLD_装备_追加_琴师梅花三弄;

		private double _FLD_装备_追加_琴师阳明春晓;

		private double _FLD_装备_追加_琴师鸾凤和鸣;

		private int _FLD_装备_追加_力;

		private int _FLD_装备_追加_身;

		private int _FLD_装备_追加_觉醒;

		private int _FLD_装备_追加_心;

		private int _FLD_装备_追加_体;

		private double _FLD_Item_Attack_Point;

		private double _FLD_Item_Attack_Skill_Point;

		private double _FLD_Item_Defense_Skill_Point;

		private double _FLD_装备_武功攻击力增加百分比;

		private double _FLD_装备_武功防御力增加百分比;

		private double _fldPillDefenseSkill;

		private long _FLD_装备_追加_攻击;

		private long _FLD_装备_追加_防御;

		private long _FLD_SucManhCaNhan;

		private double _FLD_SucManhCaNhan_PhanTram;

		private int _FLD_装备_追加_武器_强化;

		private int _FLD_装备_追加_防具_强化;

		private int _FLD_装备_追加_命中;

		private int _FLD_装备_追加_回避;

		private int _FLD_装备_追加_气功;

		private int _KyNangManhNhat_UyLuc;

		private string _Userid = string.Empty;

		private string _UserName = string.Empty;

		private int _上河调计数;

		private int _下河调计数;

		private int _玉连环计数;

		private int _帮派人物等级;

		private int _Level_Of_Guild;

		private int _帮派门服字;

		private int _帮派门服颜色;

		private long _人物最大经验;

		private long _人物_HP;

		private int _人物_气功_追加_HP;

		private int _人物基本最大_HP;

		private int _人物位置;

		public int GM模式;

		public int TLC模式;

		private int _人物轻功;

		private int _帮派Id;

		public PlayerStyle Player_Style;

		public ThreadSafeDictionary<int, NpcClass> NpcList;

		public DateTime PKhmtime;

		public DateTime PKhmtimee;

		public DateTime PKhmtimelx;

		public DateTime PKhmtimezl;

		public DateTime PKhmtimsj;

		private byte[] _帮派门徽;

		public float Speed = 127f;

		private string _帮派名字 = string.Empty;

		private int _Player_ExpErience;

		public List<Players> tem = new List<Players>();

		private long _人物经验;

		private long _Player_Money;

		public int 爆毒状态;

		public int int_25 = 0;

		public int int_123 = 0;

		public System.Timers.Timer 查坐标 = new System.Timers.Timer(6000.0);

		public Dictionary<int, EmailClass> 传书列表;

		public double 刺_连消带打数量;

		public bool 存档时间;

		public bool 打开仓库中;

		public bool 打开个人商店;

		public bool 打开交易;

		public bool 打开商店中;

		public List<int> 得到门徽ID = new List<int>();

		public ThreadSafeDictionary<double, 地面物品类> 地面物品列表;

		public bool bPartyWithCouple;

		public 物品类[] 个人仓库;

		public 个人商店类 PlayerShop;

		public 物品类[] 公共仓库;

		public Dictionary<int, 公有药品类> 公有药品;

		public List<攻击类> 攻击列表;

		public int 关起来;

		public int 行走状态id = 1;

		public double 剑_升天二气功_天地同寿数量;

		public 交易类 交易;

		public bool 进店中;

		public int 进店中ID;

		public List<int> 快捷栏 = new List<int>();

		public List<int> disable_Skill_List = new List<int>();

		public Dictionary<int, PetClass> 灵兽;

		public 气功类[] 气功;

		public int 潜行模式;

		public PetClass Pet;

		public Dictionary<int, 任务类> 任务;

		public 任务物品类[] Quest_Item;

		public int 升天历练当前获得数;

		public int 升天历练数;

		public SortedDictionary<int, 升天气功类> 升天气功;

		public int 升天武功点数;

		public int 天地同寿回避次数;

		public Hashtable 土灵符坐标;

		public bool 退出中;

		public byte[] 五色神丹;

		public List<武功类> SkillCombo;

		public int SkillCombo_Index_Start = 0;

		public int SkillCombo_Index_Stop = 0;

		public 武功类[,] Array_Skill_Book = new 武功类[4, 35];

		public 坐标Class 新坐标;

		public bool 妖花青草;

		public bool KimLongChiTheu;

		public ThreadSafeDictionary<int, 异常状态类> 异常状态;

		public int Player_Invisible;

		public List<int> 玉连环 = new List<int>();

		public int TrungCapEffect_PhanNo;

		public int TrungCapEffect_PhucThu;

		public int TrungCapEffect_HoThe;

		public int TrungCapEffect_HonNguyen;

		public int TrungCapEffect_KyDuyen;

		public int TrungCapEffect_HapHon;

		public int TrungCapEffect_DiTinh;

		public 物品类[] gclass32_0;

		public 物品类[] gclass32_1;

		public 物品类[] Item_In_Bag;

		public 物品类[] Item_Wear;

		public 物品类[] Item_NTC;

		public 物品类[] Item_Coat;

		public int 装备数据版本;

		public ThreadSafeDictionary<int, 追加状态New类> 追加状态New列表;

		public ThreadSafeDictionary<int, Class_Show_Pill> Show_Pic_Class;

		public ThreadSafeDictionary<int, 时间药品> list_时间药品;

		public byte[] 追加状态物品;

		public int 综合仓库装备数据版本;

		public int Party_ID;

		public int Party_Status;

		public double coupleEffectExp = 0.0;

		public double coupleEffectAttack = 0.0;

		public double coupleEffectDefense = 0.0;

		public double coupleEffectEvasion = 0.0;

		public double coupleEffectAccuracy = 0.0;

		public double coupleEffectSkillDefense = 0.0;

		public double coupleEffectHealth = 0.0;

		public double coupleEffectChi = 0.0;

		public double flowerEffectExp = 0.0;

		public int flowerEffectHealth = 0;

		public int flowerEffectAttack = 0;

		public int flowerEffectDefense = 0;

		public int flowerEffectQigong = 0;

		public NetState Client
		{
			get
			{
				if (World.JlMsg == 1)
				{
				}
				return _Client;
			}
			set
			{
				_Client = value;
			}
		}

		public int FLD_RXPIONT
		{
			get
			{
				return _FLD_RXPIONT;
			}
			set
			{
				_FLD_RXPIONT = value;
			}
		}

		public int Int32_1196
		{
			get
			{
				return int_1196;
			}
			set
			{
				int_1196 = value;
			}
		}

		public int Int32_1197
		{
			get
			{
				return int_1197;
			}
			set
			{
				int_1197 = value;
			}
		}

		public int Int32_1198
		{
			get
			{
				return int_1198;
			}
			set
			{
				int_1198 = value;
			}
		}

		public int Int32_1199
		{
			get
			{
				return int_1199;
			}
			set
			{
				int_1199 = value;
			}
		}

		public int Int32_1200
		{
			get
			{
				return int_1200;
			}
			set
			{
				int_1200 = value;
			}
		}

		public int FLD_RXPIONTX
		{
			get
			{
				return _FLD_RXPIONTX;
			}
			set
			{
				_FLD_RXPIONTX = value;
			}
		}

		public int FLD_VIP
		{
			get
			{
				return _FLD_VIP;
			}
			set
			{
				_FLD_VIP = value;
			}
		}

		public int FLD_SVIP
		{
			get
			{
				return _FLD_SVIP;
			}
			set
			{
				_FLD_SVIP = value;
			}
		}

		public DateTime FLD_VIPTIM
		{
			get
			{
				return _FLD_VIPTIM;
			}
			set
			{
				_FLD_VIPTIM = value;
			}
		}

		public int FLD_Defense
		{
			get
			{
				return _FLD_防御;
			}
			set
			{
				_FLD_防御 = value;
			}
		}

		public int FLD_Attack
		{
			get
			{
				return _FLD_攻击;
			}
			set
			{
				_FLD_攻击 = value;
			}
		}

		public int FLD_攻击速度
		{
			get
			{
				return _FLD_攻击速度;
			}
			set
			{
				_FLD_攻击速度 = value;
			}
		}

		public int FLD_Evasion
		{
			get
			{
				return _FLD_回避;
			}
			set
			{
				_FLD_回避 = value;
			}
		}

		public int FLD_Khi_2
		{
			get
			{
				return _FLD_力;
			}
			set
			{
				_FLD_力 = value;
			}
		}

		public int FLD_Accuracy
		{
			get
			{
				return _FLD_命中;
			}
			set
			{
				_FLD_命中 = value;
			}
		}

		public string FLD_Couple_Name
		{
			get
			{
				return _FLD_Couple_Name;
			}
			set
			{
				_FLD_Couple_Name = value;
			}
		}

		public string FLD_Couple_Name_Unknow
		{
			get
			{
				return _FLD_Couple_Name_Unknow;
			}
			set
			{
				_FLD_Couple_Name_Unknow = value;
			}
		}

		public int FLD_Couple_Exp
		{
			get
			{
				return _FLD_Couple_Exp;
			}
			set
			{
				_FLD_Couple_Exp = value;
			}
		}

		public int FLD_Couple_ExpMax
		{
			get
			{
				return _FLD_Couple_ExpMax;
			}
			set
			{
				_FLD_Couple_ExpMax = value;
			}
		}

		public int FLD_Couple_Level
		{
			get
			{
				return _FLD_Couple_Level;
			}
			set
			{
				_FLD_Couple_Level = value;
			}
		}

		public int FLD_人物_气功_防御
		{
			get
			{
				return _FLD_人物_气功_防御;
			}
			set
			{
				_FLD_人物_气功_防御 = value;
			}
		}

		public int FLD_Qigong_Defense_Skill
		{
			get
			{
				return _FLD_Qigong_Defense_Skill;
			}
			set
			{
				_FLD_Qigong_Defense_Skill = value;
			}
		}

		public int FLD_人物_气功_攻击
		{
			get
			{
				return _FLD_人物_气功_攻击;
			}
			set
			{
				_FLD_人物_气功_攻击 = value;
			}
		}

		public int FLD_人物_气功_回避
		{
			get
			{
				return _FLD_人物_气功_回避;
			}
			set
			{
				_FLD_人物_气功_回避 = value;
			}
		}

		public int FLD_人物_气功_命中
		{
			get
			{
				return _FLD_人物_气功_命中;
			}
			set
			{
				_FLD_人物_气功_命中 = value;
			}
		}

		public double FLD_人物_气功_武功防御力增加百分比
		{
			get
			{
				return _FLD_人物_气功_武功防御力增加百分比;
			}
			set
			{
				_FLD_人物_气功_武功防御力增加百分比 = value;
			}
		}

		public double FLD_人物_气功_武功攻击力增加百分比
		{
			get
			{
				return _FLD_人物_气功_武功攻击力增加百分比;
			}
			set
			{
				_FLD_人物_气功_武功攻击力增加百分比 = value;
			}
		}

		public double fldItemSkillDefPercentage
		{
			get
			{
				if (人物PK模式 != 0 && (Config.武勋开关 == 1 || Config.武勋开关 == 2 || Config.武勋开关 == 99) && 人物武勋阶段 == 8)
				{
					return 0.05;
				}
				return 0.0;
			}
		}

		public double fldItemSkillAttackPercentage
		{
			get
			{
				if (人物PK模式 != 0 && (Config.武勋开关 == 1 || Config.武勋开关 == 2 || Config.武勋开关 == 99) && 人物武勋阶段 == 8)
				{
					return 0.2;
				}
				return 0.0;
			}
		}

		public double FLD_Item_Skill_Def_Percentage
		{
			get
			{
				return _FLD_人物_武功防御力增加百分比;
			}
			set
			{
				_FLD_人物_武功防御力增加百分比 = value;
			}
		}

		public double FLD_Item_Skill_Attack_Percentage
		{
			get
			{
				return _FLD_人物_武功攻击力增加百分比;
			}
			set
			{
				_FLD_人物_武功攻击力增加百分比 = value;
			}
		}

		public int FLD_人物_追加_防御
		{
			get
			{
				return _FLD_人物_追加_防御;
			}
			set
			{
				_FLD_人物_追加_防御 = value;
			}
		}

		public int FLD_人物_追加_攻击
		{
			get
			{
				return _FLD_人物_追加_攻击;
			}
			set
			{
				_FLD_人物_追加_攻击 = value;
			}
		}

		public double Character_Upgrade_Lucky
		{
			get
			{
				return _FLD_人物_追加_合成成功率百分比;
			}
			set
			{
				_FLD_人物_追加_合成成功率百分比 = value;
			}
		}

		public int FLD_人物_追加_回避
		{
			get
			{
				return _FLD_人物_追加_回避;
			}
			set
			{
				_FLD_人物_追加_回避 = value;
			}
		}

		public double FLD_Item_Premium_Money
		{
			get
			{
				return _FLD_人物_追加_金钱百分比;
			}
			set
			{
				_FLD_人物_追加_金钱百分比 = value;
			}
		}

		public double FLD_Event_Premium_Exp
		{
			get
			{
				return _FLD_Event_Premium_Exp;
			}
			set
			{
				_FLD_Event_Premium_Exp = value;
			}
		}

		public double FLD_TLC_Premium_Exp
		{
			get
			{
				return _FLD_TLC_Premium_Exp;
			}
			set
			{
				_FLD_TLC_Premium_Exp = value;
			}
		}

		public double FLD_Item_Premium_Exp
		{
			get
			{
				if (_FLD_人物_追加_经验百分比 > World.FIX_PILL_EXP)
				{
					return World.FIX_PILL_EXP;
				}
				if (_FLD_人物_追加_经验百分比 > 0.0)
				{
					return _FLD_人物_追加_经验百分比;
				}
				return 0.0;
			}
			set
			{
				_FLD_人物_追加_经验百分比 = value;
			}
		}

		public double FLD_Premium_Fight_Exp => FLD_Item_Premium_Fight_Exp + KiExporll;

		public double FLD_Item_Premium_Fight_Exp
		{
			get
			{
				return _FLD_人物_追加_历练百分比;
			}
			set
			{
				_FLD_人物_追加_历练百分比 = value;
			}
		}

		public double KiExporll
		{
			get
			{
				if (_KiExporll < 0.0)
				{
					_KiExporll = 0.0;
				}
				return _KiExporll;
			}
			set
			{
				_KiExporll = value;
			}
		}

		public int FLD_人物_追加_命中
		{
			get
			{
				return _FLD_人物_追加_命中;
			}
			set
			{
				_FLD_人物_追加_命中 = value;
			}
		}

		public int Character_Qigong
		{
			get
			{
				return _FLD_人物_追加_气功;
			}
			set
			{
				_FLD_人物_追加_气功 = value;
			}
		}

		public double FLD_Item_Premium_Drop
		{
			get
			{
				return _FLD_人物_追加_物品掉落概率百分比;
			}
			set
			{
				_FLD_人物_追加_物品掉落概率百分比 = value;
			}
		}

		public long FLD_人物基本_防御 => (long)(((double)(FLD_Defense + FLD_装备_追加_the + FLD_Item_Defense + FLD_SucManhCaNhan) + FLD_TANGDEF_CAMSU + (double)FLD_人物_追加_防御 + (double)(int)base.KhiCong_JOB11_150_2 + (double)FLD_人物_气功_防御) * (1.0 + FLD_SucManhCaNhan_PhanTram + FLD_追加百分比_防御 + coupleEffectDefense + FLD_BUFF_DP_DEF + FLD_追加百分比_防御_KCDAO115 + FLD_追加百分比_防御_PHANNO + FLD_追加百分比_防御_DAIPHU115 - FLD_TRUDEF_801302 - FLD_TRUDEF_NINJA - FLD_TRUDEF_CAMSU) + (double)奖励_追加_防御 + (double)FLD_武勋防御 + (double)flowerEffectDefense);

		public long FLD_人物基本_攻击 => (long)(((double)(FLD_Attack + FLD_装备_追加_khi) * (1.0 + base.KhiCong_JOB11_4) + (double)FLD_Item_Attack + (double)FLD_SucManhCaNhan + (double)FLD_人物_追加_攻击 + (double)FLD_人物_气功_攻击) * (1.0 + FLD_SucManhCaNhan_PhanTram + FLD_追加百分比_攻击 + coupleEffectAttack + FLD_BUFF_DP_ATT + FLD_追加百分比_攻击_KCDAO115 + FLD_追加百分比_攻击_PHANNO - FLD_TRUDAME_CAMSU) + (double)奖励_追加_攻击 + (double)FLD_武勋攻击 + (double)flowerEffectAttack);

		public int FLD_人物基本_回避 => (int)((double)(FLD_Evasion + FLD_装备_追加_hon + FLD_Item_Evasion + FLD_人物_追加_回避 + FLD_人物_气功_回避) * (1.0 + FLD_追加百分比_回避 + coupleEffectEvasion + FLD_BUFF_DP_NT + FLD_Item_AoChoang_NeTranh)) + 奖励_追加_回避;

		public int FLD_人物基本_命中 => (int)((double)(FLD_Accuracy + FLD_装备_追加_hon + FLD_Item_Accuracy + FLD_人物_追加_命中 + FLD_人物_气功_命中) * (1.0 + FLD_追加百分比_命中 + coupleEffectAccuracy + FLD_BUFF_DP_CX + FLD_Item_AoChoang_ChinhXac)) + 奖励_追加_命中;

		public int FLD_Hon_4
		{
			get
			{
				return _FLD_身;
			}
			set
			{
				_FLD_身 = value;
			}
		}

		public int FLD_The_3
		{
			get
			{
				return _FLD_体;
			}
			set
			{
				_FLD_体 = value;
			}
		}

		public int Int32_671
		{
			get
			{
				return int_196;
			}
			set
			{
				int_196 = value;
			}
		}

		public int Int32_672
		{
			get
			{
				return int_197;
			}
			set
			{
				int_197 = value;
			}
		}

		public int Int32_673
		{
			get
			{
				return int_198;
			}
			set
			{
				int_198 = value;
			}
		}

		public int Int32_674
		{
			get
			{
				return int_199;
			}
			set
			{
				int_199 = value;
			}
		}

		public string FLD_Teacher
		{
			get
			{
				return QfYxTU9X3;
			}
			set
			{
				QfYxTU9X3 = value;
			}
		}

		public int FLD_师徒_武功ID1_1
		{
			get
			{
				return _FLD_师徒_武功ID1_1;
			}
			set
			{
				_FLD_师徒_武功ID1_1 = value;
			}
		}

		public int FLD_师徒_武功ID1_2
		{
			get
			{
				return _FLD_师徒_武功ID1_2;
			}
			set
			{
				_FLD_师徒_武功ID1_2 = value;
			}
		}

		public int FLD_师徒_武功ID1_3
		{
			get
			{
				return _FLD_师徒_武功ID1_3;
			}
			set
			{
				_FLD_师徒_武功ID1_3 = value;
			}
		}

		public string FLD_DayQuest_Array
		{
			get
			{
				return _FLD_DayQuest_Array;
			}
			set
			{
				_FLD_DayQuest_Array = value;
			}
		}

		public string FLD_Student1
		{
			get
			{
				return XwDHJf2ag;
			}
			set
			{
				XwDHJf2ag = value;
			}
		}

		public string FLD_Student2
		{
			get
			{
				return JDVis2ID6;
			}
			set
			{
				JDVis2ID6 = value;
			}
		}

		public string FLD_Student3
		{
			get
			{
				return gifcaaiuT;
			}
			set
			{
				gifcaaiuT = value;
			}
		}

		public string Teacher_Student_Temporary
		{
			get
			{
				return atbX1XeoP;
			}
			set
			{
				atbX1XeoP = value;
			}
		}

		public int FLD_武勋_追加_气功
		{
			get
			{
				return _FLD_武勋_追加_气功;
			}
			set
			{
				_FLD_武勋_追加_气功 = value;
			}
		}

		public int FLD_武勋防御
		{
			get
			{
				return _FLD_武勋防御;
			}
			set
			{
				_FLD_武勋防御 = value;
			}
		}

		public int FLD_武勋攻击
		{
			get
			{
				return _FLD_武勋攻击;
			}
			set
			{
				_FLD_武勋攻击 = value;
			}
		}

		public int FLD_Tam_1
		{
			get
			{
				return _FLD_心;
			}
			set
			{
				_FLD_心 = value;
			}
		}

		public int FLD_制作等级
		{
			get
			{
				return _FLD_制作等级;
			}
			set
			{
				_FLD_制作等级 = value;
			}
		}

		public int Craft_Type
		{
			get
			{
				return _FLD_制作类型;
			}
			set
			{
				_FLD_制作类型 = value;
			}
		}

		public int Craft_Level
		{
			get
			{
				return _FLD_制作熟练度;
			}
			set
			{
				if (value >= 600)
				{
					_FLD_制作熟练度 = 600;
				}
				else
				{
					_FLD_制作熟练度 = value;
				}
			}
		}

		public double FLD_Item_Defense_Skill
		{
			get
			{
				return _FLD_装备_武功防御力增加百分比;
			}
			set
			{
				_FLD_装备_武功防御力增加百分比 = value;
			}
		}

		public double FLD_Pill_Defense_Skill
		{
			get
			{
				return _fldPillDefenseSkill;
			}
			set
			{
				_fldPillDefenseSkill = value;
			}
		}

		public double FLD_Item_Attack_Skill
		{
			get
			{
				return _FLD_装备_武功攻击力增加百分比;
			}
			set
			{
				_FLD_装备_武功攻击力增加百分比 = value;
			}
		}

		public double FLD_Item_Attack_Point
		{
			get
			{
				return _FLD_Item_Attack_Point;
			}
			set
			{
				_FLD_Item_Attack_Point = value;
			}
		}

		public double FLD_Item_Attack_Skill_Point
		{
			get
			{
				return _FLD_Item_Attack_Skill_Point;
			}
			set
			{
				_FLD_Item_Attack_Skill_Point = value;
			}
		}

		public double FLD_Item_Defense_Skill_Point
		{
			get
			{
				return _FLD_Item_Defense_Skill_Point;
			}
			set
			{
				_FLD_Item_Defense_Skill_Point = value;
			}
		}

		public int FLD_Item_HP
		{
			get
			{
				return _FLD_装备_追加_HP;
			}
			set
			{
				_FLD_装备_追加_HP = value;
			}
		}

		public long HP_GuildWar
		{
			get
			{
				return _HP_GuildWar;
			}
			set
			{
				_HP_GuildWar = value;
			}
		}

		public int FLD_Item_MP
		{
			get
			{
				return _FLD_装备_追加_MP;
			}
			set
			{
				_FLD_装备_追加_MP = value;
			}
		}

		public double FLD_装备_追加_qigong_3_job6
		{
			get
			{
				return _FLD_装备_追加_刺客必杀一击;
			}
			set
			{
				_FLD_装备_追加_刺客必杀一击 = value;
			}
		}

		public double FLD_装备_追加_qigong_10_job6
		{
			get
			{
				return _FLD_装备_追加_刺客剑刃乱舞;
			}
			set
			{
				_FLD_装备_追加_刺客剑刃乱舞 = value;
			}
		}

		public double FLD_装备_追加_qigong_0_job6
		{
			get
			{
				return _FLD_装备_追加_刺客荆轲之怒;
			}
			set
			{
				_FLD_装备_追加_刺客荆轲之怒 = value;
			}
		}

		public double FLD_装备_追加_qigong_2_job6
		{
			get
			{
				return _FLD_装备_追加_刺客连环飞舞;
			}
			set
			{
				_FLD_装备_追加_刺客连环飞舞 = value;
			}
		}

		public double FLD_装备_追加_qigong_9_job6
		{
			get
			{
				return _FLD_装备_追加_刺客连消带打;
			}
			set
			{
				_FLD_装备_追加_刺客连消带打 = value;
			}
		}

		public double FLD_装备_追加_qigong_8_job6
		{
			get
			{
				return _FLD_装备_追加_刺客千株万手;
			}
			set
			{
				_FLD_装备_追加_刺客千株万手 = value;
			}
		}

		public double FLD_装备_追加_qigong_1_job6
		{
			get
			{
				return _FLD_装备_追加_刺客三花聚顶;
			}
			set
			{
				_FLD_装备_追加_刺客三花聚顶 = value;
			}
		}

		public double FLD_装备_追加_qigong_7_job6
		{
			get
			{
				return _FLD_装备_追加_刺客先发制人;
			}
			set
			{
				_FLD_装备_追加_刺客先发制人 = value;
			}
		}

		public double FLD_装备_追加_qigong_4_job6
		{
			get
			{
				return _FLD_装备_追加_刺客心神凝聚;
			}
			set
			{
				_FLD_装备_追加_刺客心神凝聚 = value;
			}
		}

		public double FLD_装备_追加_qigong_5_job6
		{
			get
			{
				return _FLD_装备_追加_刺客致命绝手;
			}
			set
			{
				_FLD_装备_追加_刺客致命绝手 = value;
			}
		}

		public double FLD_装备_追加_qigong_9_job1
		{
			get
			{
				return _FLD_装备_追加_刀客暗影绝杀;
			}
			set
			{
				_FLD_装备_追加_刀客暗影绝杀 = value;
			}
		}

		public double FLD_装备_追加_qigong_7_job1
		{
			get
			{
				return _FLD_装备_追加_刀客霸气破甲;
			}
			set
			{
				_FLD_装备_追加_刀客霸气破甲 = value;
			}
		}

		public double FLD_装备_追加_qigong_3_job1
		{
			get
			{
				return _FLD_装备_追加_刀客必杀一击;
			}
			set
			{
				_FLD_装备_追加_刀客必杀一击 = value;
			}
		}

		public double FLD_装备_追加_qigong_4_job1
		{
			get
			{
				return _FLD_装备_追加_刀客狂风万破;
			}
			set
			{
				_FLD_装备_追加_刀客狂风万破 = value;
			}
		}

		public double FLD_装备_追加_qigong_0_job1
		{
			get
			{
				return _FLD_装备_追加_刀客力劈华山;
			}
			set
			{
				_FLD_装备_追加_刀客力劈华山 = value;
			}
		}

		public double FLD_装备_追加_qigong_11_job1
		{
			get
			{
				return _FLD_装备_追加_qigong_11_job1;
			}
			set
			{
				_FLD_装备_追加_qigong_11_job1 = value;
			}
		}

		public double FLD_装备_追加_qigong_11_job2
		{
			get
			{
				return _FLD_装备_追加_qigong_11_job2;
			}
			set
			{
				_FLD_装备_追加_qigong_11_job2 = value;
			}
		}

		public double FLD_装备_追加_qigong_11_job3
		{
			get
			{
				return _FLD_装备_追加_qigong_11_job3;
			}
			set
			{
				_FLD_装备_追加_qigong_11_job3 = value;
			}
		}

		public double FLD_装备_追加_qigong_11_job4
		{
			get
			{
				return _FLD_装备_追加_qigong_11_job4;
			}
			set
			{
				_FLD_装备_追加_qigong_11_job4 = value;
			}
		}

		public double FLD_装备_追加_qigong_11_job5
		{
			get
			{
				return _FLD_装备_追加_qigong_11_job5;
			}
			set
			{
				_FLD_装备_追加_qigong_11_job5 = value;
			}
		}

		public double FLD_装备_追加_qigong_11_job6
		{
			get
			{
				return _FLD_装备_追加_qigong_11_job6;
			}
			set
			{
				_FLD_装备_追加_qigong_11_job6 = value;
			}
		}

		public double FLD_装备_追加_qigong_11_job7
		{
			get
			{
				return _FLD_装备_追加_qigong_11_job7;
			}
			set
			{
				_FLD_装备_追加_qigong_11_job7 = value;
			}
		}

		public double FLD_装备_追加_qigong_0_job8
		{
			get
			{
				return _FLD_装备_追加_qigong_0_job8;
			}
			set
			{
				_FLD_装备_追加_qigong_0_job8 = value;
			}
		}

		public double FLD_装备_追加_qigong_1_job8
		{
			get
			{
				return _FLD_装备_追加_qigong_1_job8;
			}
			set
			{
				_FLD_装备_追加_qigong_1_job8 = value;
			}
		}

		public double FLD_装备_追加_qigong_2_job8
		{
			get
			{
				return _FLD_装备_追加_qigong_2_job8;
			}
			set
			{
				_FLD_装备_追加_qigong_2_job8 = value;
			}
		}

		public double FLD_装备_追加_qigong_3_job8
		{
			get
			{
				return _FLD_装备_追加_qigong_3_job8;
			}
			set
			{
				_FLD_装备_追加_qigong_3_job8 = value;
			}
		}

		public double FLD_装备_追加_qigong_4_job8
		{
			get
			{
				return _FLD_装备_追加_qigong_4_job8;
			}
			set
			{
				_FLD_装备_追加_qigong_4_job8 = value;
			}
		}

		public double FLD_装备_追加_qigong_5_job8
		{
			get
			{
				return _FLD_装备_追加_qigong_5_job8;
			}
			set
			{
				_FLD_装备_追加_qigong_5_job8 = value;
			}
		}

		public double FLD_装备_追加_qigong_7_job8
		{
			get
			{
				return _FLD_装备_追加_qigong_7_job8;
			}
			set
			{
				_FLD_装备_追加_qigong_7_job8 = value;
			}
		}

		public double FLD_装备_追加_qigong_8_job8
		{
			get
			{
				return _FLD_装备_追加_qigong_8_job8;
			}
			set
			{
				_FLD_装备_追加_qigong_8_job8 = value;
			}
		}

		public double FLD_装备_追加_qigong_9_job8
		{
			get
			{
				return _FLD_装备_追加_qigong_9_job8;
			}
			set
			{
				_FLD_装备_追加_qigong_9_job8 = value;
			}
		}

		public double FLD_装备_追加_qigong_10_job8
		{
			get
			{
				return _FLD_装备_追加_qigong_10_job8;
			}
			set
			{
				_FLD_装备_追加_qigong_10_job8 = value;
			}
		}

		public double FLD_装备_追加_qigong_11_job8
		{
			get
			{
				return _FLD_装备_追加_qigong_11_job8;
			}
			set
			{
				_FLD_装备_追加_qigong_11_job8 = value;
			}
		}

		public double FLD_装备_追加_qigong_0_job9
		{
			get
			{
				return _FLD_装备_追加_qigong_0_job9;
			}
			set
			{
				_FLD_装备_追加_qigong_0_job9 = value;
			}
		}

		public double FLD_装备_追加_qigong_1_job9
		{
			get
			{
				return _FLD_装备_追加_qigong_1_job9;
			}
			set
			{
				_FLD_装备_追加_qigong_1_job9 = value;
			}
		}

		public double FLD_装备_追加_qigong_2_job9
		{
			get
			{
				return _FLD_装备_追加_qigong_2_job9;
			}
			set
			{
				_FLD_装备_追加_qigong_2_job9 = value;
			}
		}

		public double FLD_装备_追加_qigong_3_job9
		{
			get
			{
				return _FLD_装备_追加_qigong_3_job9;
			}
			set
			{
				_FLD_装备_追加_qigong_3_job9 = value;
			}
		}

		public double FLD_装备_追加_qigong_4_job9
		{
			get
			{
				return _FLD_装备_追加_qigong_4_job9;
			}
			set
			{
				_FLD_装备_追加_qigong_4_job9 = value;
			}
		}

		public double FLD_装备_追加_qigong_5_job9
		{
			get
			{
				return _FLD_装备_追加_qigong_5_job9;
			}
			set
			{
				_FLD_装备_追加_qigong_5_job9 = value;
			}
		}

		public double FLD_装备_追加_qigong_7_job9
		{
			get
			{
				return _FLD_装备_追加_qigong_7_job9;
			}
			set
			{
				_FLD_装备_追加_qigong_7_job9 = value;
			}
		}

		public double FLD_装备_追加_qigong_8_job9
		{
			get
			{
				return _FLD_装备_追加_qigong_8_job9;
			}
			set
			{
				_FLD_装备_追加_qigong_8_job9 = value;
			}
		}

		public double FLD_装备_追加_qigong_9_job9
		{
			get
			{
				return _FLD_装备_追加_qigong_9_job9;
			}
			set
			{
				_FLD_装备_追加_qigong_9_job9 = value;
			}
		}

		public double FLD_装备_追加_qigong_10_job9
		{
			get
			{
				return _FLD_装备_追加_qigong_10_job9;
			}
			set
			{
				_FLD_装备_追加_qigong_10_job9 = value;
			}
		}

		public double FLD_装备_追加_qigong_11_job9
		{
			get
			{
				return _FLD_装备_追加_qigong_11_job9;
			}
			set
			{
				_FLD_装备_追加_qigong_11_job9 = value;
			}
		}

		public double FLD_装备_追加_qigong_0_job10
		{
			get
			{
				return _FLD_装备_追加_qigong_0_job10;
			}
			set
			{
				_FLD_装备_追加_qigong_0_job10 = value;
			}
		}

		public double FLD_装备_追加_qigong_1_job10
		{
			get
			{
				return _FLD_装备_追加_qigong_1_job10;
			}
			set
			{
				_FLD_装备_追加_qigong_1_job10 = value;
			}
		}

		public double FLD_装备_追加_qigong_2_job10
		{
			get
			{
				return _FLD_装备_追加_qigong_2_job10;
			}
			set
			{
				_FLD_装备_追加_qigong_2_job10 = value;
			}
		}

		public double FLD_装备_追加_qigong_3_job10
		{
			get
			{
				return _FLD_装备_追加_qigong_3_job10;
			}
			set
			{
				_FLD_装备_追加_qigong_3_job10 = value;
			}
		}

		public double FLD_装备_追加_qigong_4_job10
		{
			get
			{
				return _FLD_装备_追加_qigong_4_job10;
			}
			set
			{
				_FLD_装备_追加_qigong_4_job10 = value;
			}
		}

		public double FLD_装备_追加_qigong_5_job10
		{
			get
			{
				return _FLD_装备_追加_qigong_5_job10;
			}
			set
			{
				_FLD_装备_追加_qigong_5_job10 = value;
			}
		}

		public double FLD_装备_追加_qigong_7_job10
		{
			get
			{
				return _FLD_装备_追加_qigong_7_job10;
			}
			set
			{
				_FLD_装备_追加_qigong_7_job10 = value;
			}
		}

		public double FLD_装备_追加_qigong_8_job10
		{
			get
			{
				return _FLD_装备_追加_qigong_8_job10;
			}
			set
			{
				_FLD_装备_追加_qigong_8_job10 = value;
			}
		}

		public double FLD_装备_追加_qigong_9_job10
		{
			get
			{
				return _FLD_装备_追加_qigong_9_job10;
			}
			set
			{
				_FLD_装备_追加_qigong_9_job10 = value;
			}
		}

		public double FLD_装备_追加_qigong_10_job10
		{
			get
			{
				return _FLD_装备_追加_qigong_10_job10;
			}
			set
			{
				_FLD_装备_追加_qigong_10_job10 = value;
			}
		}

		public double FLD_装备_追加_qigong_11_job10
		{
			get
			{
				return _FLD_装备_追加_qigong_11_job10;
			}
			set
			{
				_FLD_装备_追加_qigong_11_job10 = value;
			}
		}

		public double FLD_装备_追加_qigong_0_job11
		{
			get
			{
				return _FLD_装备_追加_qigong_0_job11;
			}
			set
			{
				_FLD_装备_追加_qigong_0_job11 = value;
			}
		}

		public double FLD_装备_追加_qigong_1_job11
		{
			get
			{
				return _FLD_装备_追加_qigong_1_job11;
			}
			set
			{
				_FLD_装备_追加_qigong_1_job11 = value;
			}
		}

		public double FLD_装备_追加_qigong_2_job11
		{
			get
			{
				return _FLD_装备_追加_qigong_2_job11;
			}
			set
			{
				_FLD_装备_追加_qigong_2_job11 = value;
			}
		}

		public double FLD_装备_追加_qigong_3_job11
		{
			get
			{
				return _FLD_装备_追加_qigong_3_job11;
			}
			set
			{
				_FLD_装备_追加_qigong_3_job11 = value;
			}
		}

		public double FLD_装备_追加_qigong_4_job11
		{
			get
			{
				return _FLD_装备_追加_qigong_4_job11;
			}
			set
			{
				_FLD_装备_追加_qigong_4_job11 = value;
			}
		}

		public double FLD_装备_追加_qigong_5_job11
		{
			get
			{
				return _FLD_装备_追加_qigong_5_job11;
			}
			set
			{
				_FLD_装备_追加_qigong_5_job11 = value;
			}
		}

		public double FLD_装备_追加_qigong_7_job11
		{
			get
			{
				return _FLD_装备_追加_qigong_7_job11;
			}
			set
			{
				_FLD_装备_追加_qigong_7_job11 = value;
			}
		}

		public double FLD_装备_追加_qigong_8_job11
		{
			get
			{
				return _FLD_装备_追加_qigong_8_job11;
			}
			set
			{
				_FLD_装备_追加_qigong_8_job11 = value;
			}
		}

		public double FLD_装备_追加_qigong_9_job11
		{
			get
			{
				return _FLD_装备_追加_qigong_9_job11;
			}
			set
			{
				_FLD_装备_追加_qigong_9_job11 = value;
			}
		}

		public double FLD_装备_追加_qigong_10_job11
		{
			get
			{
				return _FLD_装备_追加_qigong_10_job11;
			}
			set
			{
				_FLD_装备_追加_qigong_10_job11 = value;
			}
		}

		public double FLD_装备_追加_qigong_11_job11
		{
			get
			{
				return _FLD_装备_追加_qigong_11_job11;
			}
			set
			{
				_FLD_装备_追加_qigong_11_job11 = value;
			}
		}

		public double FLD_装备_追加_qigong_0_job12
		{
			get
			{
				return _FLD_装备_追加_qigong_0_job12;
			}
			set
			{
				_FLD_装备_追加_qigong_0_job12 = value;
			}
		}

		public double FLD_装备_追加_qigong_1_job12
		{
			get
			{
				return _FLD_装备_追加_qigong_1_job12;
			}
			set
			{
				_FLD_装备_追加_qigong_1_job12 = value;
			}
		}

		public double FLD_装备_追加_qigong_2_job12
		{
			get
			{
				return _FLD_装备_追加_qigong_2_job12;
			}
			set
			{
				_FLD_装备_追加_qigong_2_job12 = value;
			}
		}

		public double FLD_装备_追加_qigong_3_job12
		{
			get
			{
				return _FLD_装备_追加_qigong_3_job12;
			}
			set
			{
				_FLD_装备_追加_qigong_3_job12 = value;
			}
		}

		public double FLD_装备_追加_qigong_4_job12
		{
			get
			{
				return _FLD_装备_追加_qigong_4_job12;
			}
			set
			{
				_FLD_装备_追加_qigong_4_job12 = value;
			}
		}

		public double FLD_装备_追加_qigong_5_job12
		{
			get
			{
				return _FLD_装备_追加_qigong_5_job12;
			}
			set
			{
				_FLD_装备_追加_qigong_5_job12 = value;
			}
		}

		public double FLD_装备_追加_qigong_7_job12
		{
			get
			{
				return _FLD_装备_追加_qigong_7_job12;
			}
			set
			{
				_FLD_装备_追加_qigong_7_job12 = value;
			}
		}

		public double FLD_装备_追加_qigong_8_job12
		{
			get
			{
				return _FLD_装备_追加_qigong_8_job12;
			}
			set
			{
				_FLD_装备_追加_qigong_8_job12 = value;
			}
		}

		public double FLD_装备_追加_qigong_9_job12
		{
			get
			{
				return _FLD_装备_追加_qigong_9_job12;
			}
			set
			{
				_FLD_装备_追加_qigong_9_job12 = value;
			}
		}

		public double FLD_装备_追加_qigong_10_job12
		{
			get
			{
				return _FLD_装备_追加_qigong_10_job12;
			}
			set
			{
				_FLD_装备_追加_qigong_10_job12 = value;
			}
		}

		public double FLD_装备_追加_qigong_11_job12
		{
			get
			{
				return _FLD_装备_追加_qigong_11_job12;
			}
			set
			{
				_FLD_装备_追加_qigong_11_job12 = value;
			}
		}

		public double FLD_装备_追加_qigong_2_job1
		{
			get
			{
				return _FLD_装备_追加_刀客连环飞舞;
			}
			set
			{
				_FLD_装备_追加_刀客连环飞舞 = value;
			}
		}

		public double FLD_装备_追加_qigong_1_job1
		{
			get
			{
				return _FLD_装备_追加_刀客摄魂一击;
			}
			set
			{
				_FLD_装备_追加_刀客摄魂一击 = value;
			}
		}

		public double FLD_装备_追加_qigong_5_job1
		{
			get
			{
				return _FLD_装备_追加_刀客四两千斤;
			}
			set
			{
				_FLD_装备_追加_刀客四两千斤 = value;
			}
		}

		public double FLD_装备_追加_qigong_10_job1
		{
			get
			{
				return _FLD_装备_追加_刀客稳如泰山;
			}
			set
			{
				_FLD_装备_追加_刀客稳如泰山 = value;
			}
		}

		public double FLD_装备_追加_qigong_8_job1
		{
			get
			{
				return _FLD_装备_追加_刀客真武绝击;
			}
			set
			{
				_FLD_装备_追加_刀客真武绝击 = value;
			}
		}

		public int FLD_Item_Plus_TB
		{
			get
			{
				if (_FLD_装备_追加_防具_强化 < 0)
				{
					_FLD_装备_追加_防具_强化 = 0;
				}
				return _FLD_装备_追加_防具_强化;
			}
			set
			{
				_FLD_装备_追加_防具_强化 = value;
			}
		}

		public long FLD_Item_Defense
		{
			get
			{
				return _FLD_装备_追加_防御;
			}
			set
			{
				_FLD_装备_追加_防御 = value;
			}
		}

		public long FLD_SucManhCaNhan
		{
			get
			{
				return _FLD_SucManhCaNhan;
			}
			set
			{
				_FLD_SucManhCaNhan = value;
			}
		}

		public double FLD_SucManhCaNhan_PhanTram
		{
			get
			{
				return _FLD_SucManhCaNhan_PhanTram;
			}
			set
			{
				_FLD_SucManhCaNhan_PhanTram = value;
			}
		}

		public double FLD_装备_追加_qigong_0_job4
		{
			get
			{
				return _FLD_装备_追加_弓百步穿杨;
			}
			set
			{
				_FLD_装备_追加_弓百步穿杨 = value;
			}
		}

		public double FLD_装备_追加_qigong_3_job4
		{
			get
			{
				return _FLD_装备_追加_弓必杀一击;
			}
			set
			{
				_FLD_装备_追加_弓必杀一击 = value;
			}
		}

		public double FLD_装备_追加_qigong_4_job4
		{
			get
			{
				return _FLD_装备_追加_弓狂风万破;
			}
			set
			{
				_FLD_装备_追加_弓狂风万破 = value;
			}
		}

		public double FLD_装备_追加_qigong_1_job4
		{
			get
			{
				return _FLD_装备_追加_弓猎鹰之眼;
			}
			set
			{
				_FLD_装备_追加_弓猎鹰之眼 = value;
			}
		}

		public double FLD_装备_追加_qigong_8_job4
		{
			get
			{
				return _FLD_装备_追加_弓流星三矢;
			}
			set
			{
				_FLD_装备_追加_弓流星三矢 = value;
			}
		}

		public double FLD_装备_追加_qigong_2_job4
		{
			get
			{
				return _FLD_装备_追加_弓凝神聚气;
			}
			set
			{
				_FLD_装备_追加_弓凝神聚气 = value;
			}
		}

		public double FLD_装备_追加_qigong_9_job4
		{
			get
			{
				return _FLD_装备_追加_弓锐利之箭;
			}
			set
			{
				_FLD_装备_追加_弓锐利之箭 = value;
			}
		}

		public double FLD_装备_追加_qigong_10_job4
		{
			get
			{
				return _FLD_装备_追加_弓无明暗矢;
			}
			set
			{
				_FLD_装备_追加_弓无明暗矢 = value;
			}
		}

		public double FLD_装备_追加_qigong_7_job4
		{
			get
			{
				return _FLD_装备_追加_弓心神凝聚;
			}
			set
			{
				_FLD_装备_追加_弓心神凝聚 = value;
			}
		}

		public double FLD_装备_追加_qigong_5_job4
		{
			get
			{
				return _FLD_装备_追加_弓正本培元;
			}
			set
			{
				_FLD_装备_追加_弓正本培元 = value;
			}
		}

		public long FLD_Item_Attack
		{
			get
			{
				return _FLD_装备_追加_攻击;
			}
			set
			{
				_FLD_装备_追加_攻击 = value;
			}
		}

		public double Item_Upgrade_Lucky_Add
		{
			get
			{
				return _FLD_装备_追加_合成成功率百分比;
			}
			set
			{
				_FLD_装备_追加_合成成功率百分比 = value;
			}
		}

		public int FLD_Item_Evasion
		{
			get
			{
				return _FLD_装备_追加_回避;
			}
			set
			{
				_FLD_装备_追加_回避 = value;
			}
		}

		public double FLD_Wear_Item_Money
		{
			get
			{
				return _FLD_装备_追加_获得游戏币百分比;
			}
			set
			{
				_FLD_装备_追加_获得游戏币百分比 = value;
			}
		}

		public double FLD_装备_追加_qigong_1_job2
		{
			get
			{
				return _FLD_装备_追加_剑客百变神行;
			}
			set
			{
				_FLD_装备_追加_剑客百变神行 = value;
			}
		}

		public double FLD_装备_追加_qigong_3_job2
		{
			get
			{
				return _FLD_装备_追加_剑客必杀一击;
			}
			set
			{
				_FLD_装备_追加_剑客必杀一击 = value;
			}
		}

		public double FLD_装备_追加_qigong_10_job2
		{
			get
			{
				return _FLD_装备_追加_剑客冲冠一怒;
			}
			set
			{
				_FLD_装备_追加_剑客冲冠一怒 = value;
			}
		}

		public double FLD_装备_追加_qigong_5_job2
		{
			get
			{
				return _FLD_装备_追加_剑客护身罡气;
			}
			set
			{
				_FLD_装备_追加_剑客护身罡气 = value;
			}
		}

		public double FLD_装备_追加_qigong_8_job2
		{
			get
			{
				return _FLD_装备_追加_剑客回柳身法;
			}
			set
			{
				_FLD_装备_追加_剑客回柳身法 = value;
			}
		}

		public double FLD_装备_追加_qigong_4_job2
		{
			get
			{
				return _FLD_装备_追加_剑客狂风万破;
			}
			set
			{
				_FLD_装备_追加_剑客狂风万破 = value;
			}
		}

		public double FLD_装备_追加_qigong_2_job2
		{
			get
			{
				return _FLD_装备_追加_剑客连环飞舞;
			}
			set
			{
				_FLD_装备_追加_剑客连环飞舞 = value;
			}
		}

		public double FLD_装备_追加_qigong_9_job2
		{
			get
			{
				return _FLD_装备_追加_剑客怒海狂澜;
			}
			set
			{
				_FLD_装备_追加_剑客怒海狂澜 = value;
			}
		}

		public double FLD_装备_追加_qigong_7_job2
		{
			get
			{
				return _FLD_装备_追加_剑客移花接木;
			}
			set
			{
				_FLD_装备_追加_剑客移花接木 = value;
			}
		}

		public double FLD_装备_追加_qigong_0_job2
		{
			get
			{
				return _FLD_装备_追加_剑客长虹贯日;
			}
			set
			{
				_FLD_装备_追加_剑客长虹贯日 = value;
			}
		}

		public int FLD_装备_追加_觉醒
		{
			get
			{
				return _FLD_装备_追加_觉醒;
			}
			set
			{
				_FLD_装备_追加_觉醒 = value;
			}
		}

		public double FLD_Item_Exp
		{
			get
			{
				return _FLD_装备_追加_经验百分比;
			}
			set
			{
				_FLD_装备_追加_经验百分比 = value;
			}
		}

		public double ExpExporll
		{
			get
			{
				if (_ExpExporll < 0.0)
				{
					_ExpExporll = 0.0;
				}
				return _ExpExporll;
			}
			set
			{
				_ExpExporll = value;
			}
		}

		public int FLD_斗神_追加_防御
		{
			get
			{
				return _FLD_斗神_追加_防御;
			}
			set
			{
				_FLD_斗神_追加_防御 = value;
			}
		}

		public int FLD_斗神_追加_攻击
		{
			get
			{
				return _FLD_斗神_追加_攻击;
			}
			set
			{
				_FLD_斗神_追加_攻击 = value;
			}
		}

		public int FLD_斗神_追加_气功
		{
			get
			{
				return _FLD_斗神_追加_气功;
			}
			set
			{
				_FLD_斗神_追加_气功 = value;
			}
		}

		public int FLD_装备_追加_khi
		{
			get
			{
				return _FLD_装备_追加_力;
			}
			set
			{
				_FLD_装备_追加_力 = value;
			}
		}

		public int FLD_Item_Accuracy
		{
			get
			{
				return _FLD_装备_追加_命中;
			}
			set
			{
				_FLD_装备_追加_命中 = value;
			}
		}

		public int FLD_Item_Level_Pran
		{
			get
			{
				return _FLD_装备_追加_气功;
			}
			set
			{
				_FLD_装备_追加_气功 = value;
			}
		}

		public double FLD_装备_追加_qigong_3_job3
		{
			get
			{
				return _FLD_装备_追加_枪客必杀一击;
			}
			set
			{
				_FLD_装备_追加_枪客必杀一击 = value;
			}
		}

		public double FLD_装备_追加_qigong_5_job3
		{
			get
			{
				return _FLD_装备_追加_枪客横练太保;
			}
			set
			{
				_FLD_装备_追加_枪客横练太保 = value;
			}
		}

		public double FLD_装备_追加_qigong_0_job3
		{
			get
			{
				return _FLD_装备_追加_枪客金钟罩气;
			}
			set
			{
				_FLD_装备_追加_枪客金钟罩气 = value;
			}
		}

		public double FLD_装备_追加_qigong_4_job3
		{
			get
			{
				return _FLD_装备_追加_枪客狂风万破;
			}
			set
			{
				_FLD_装备_追加_枪客狂风万破 = value;
			}
		}

		public double FLD_装备_追加_qigong_9_job3
		{
			get
			{
				return _FLD_装备_追加_枪客狂神降世;
			}
			set
			{
				_FLD_装备_追加_枪客狂神降世 = value;
			}
		}

		public double FLD_装备_追加_qigong_2_job3
		{
			get
			{
				return _FLD_装备_追加_枪客连环飞舞;
			}
			set
			{
				_FLD_装备_追加_枪客连环飞舞 = value;
			}
		}

		public double FLD_装备_追加_qigong_8_job3
		{
			get
			{
				return _FLD_装备_追加_枪客灵甲护身;
			}
			set
			{
				_FLD_装备_追加_枪客灵甲护身 = value;
			}
		}

		public double FLD_装备_追加_qigong_7_job3
		{
			get
			{
				return _FLD_装备_追加_枪客乾坤挪移;
			}
			set
			{
				_FLD_装备_追加_枪客乾坤挪移 = value;
			}
		}

		public double FLD_装备_追加_qigong_1_job3
		{
			get
			{
				return _FLD_装备_追加_枪客运气疗伤;
			}
			set
			{
				_FLD_装备_追加_枪客运气疗伤 = value;
			}
		}

		public double FLD_装备_追加_qigong_10_job3
		{
			get
			{
				return _FLD_装备_追加_枪客转守为攻;
			}
			set
			{
				_FLD_装备_追加_枪客转守为攻 = value;
			}
		}

		public double FLD_装备_追加_qigong_5_job7
		{
			get
			{
				return _FLD_装备_追加_琴师高山流水;
			}
			set
			{
				_FLD_装备_追加_琴师高山流水 = value;
			}
		}

		public double FLD_装备_追加_qigong_4_job7
		{
			get
			{
				return _FLD_装备_追加_琴师汉宫秋月;
			}
			set
			{
				_FLD_装备_追加_琴师汉宫秋月 = value;
			}
		}

		public double FLD_装备_追加_qigong_9_job7
		{
			get
			{
				return _FLD_装备_追加_琴师鸾凤和鸣;
			}
			set
			{
				_FLD_装备_追加_琴师鸾凤和鸣 = value;
			}
		}

		public double FLD_装备_追加_qigong_8_job7
		{
			get
			{
				return _FLD_装备_追加_琴师梅花三弄;
			}
			set
			{
				_FLD_装备_追加_琴师梅花三弄 = value;
			}
		}

		public double FLD_装备_追加_qigong_2_job7
		{
			get
			{
				return _FLD_装备_追加_琴师清心普善;
			}
			set
			{
				_FLD_装备_追加_琴师清心普善 = value;
			}
		}

		public double FLD_装备_追加_qigong_1_job7
		{
			get
			{
				return _FLD_装备_追加_琴师秋江夜泊;
			}
			set
			{
				_FLD_装备_追加_琴师秋江夜泊 = value;
			}
		}

		public double FLD_装备_追加_qigong_3_job7
		{
			get
			{
				return _FLD_装备_追加_琴师阳关三叠;
			}
			set
			{
				_FLD_装备_追加_琴师阳关三叠 = value;
			}
		}

		public double FLD_装备_追加_qigong_10_job7
		{
			get
			{
				return _FLD_装备_追加_琴师阳明春晓;
			}
			set
			{
				_FLD_装备_追加_琴师阳明春晓 = value;
			}
		}

		public double FLD_装备_追加_qigong_7_job7
		{
			get
			{
				return _FLD_装备_追加_琴师岳阳三醉;
			}
			set
			{
				_FLD_装备_追加_琴师岳阳三醉 = value;
			}
		}

		public double FLD_装备_追加_qigong_0_job7
		{
			get
			{
				return _FLD_装备_追加_琴师战马奔腾;
			}
			set
			{
				_FLD_装备_追加_琴师战马奔腾 = value;
			}
		}

		public int FLD_装备_追加_hon
		{
			get
			{
				return _FLD_装备_追加_身;
			}
			set
			{
				_FLD_装备_追加_身 = value;
			}
		}

		public int FLD_装备_追加_the
		{
			get
			{
				return _FLD_装备_追加_体;
			}
			set
			{
				_FLD_装备_追加_体 = value;
			}
		}

		public int FLD_Item_Plus_VK
		{
			get
			{
				if (_FLD_装备_追加_武器_强化 < 0)
				{
					_FLD_装备_追加_武器_强化 = 0;
				}
				return _FLD_装备_追加_武器_强化;
			}
			set
			{
				_FLD_装备_追加_武器_强化 = value;
			}
		}

		public int FLD_装备_追加_tam
		{
			get
			{
				return _FLD_装备_追加_心;
			}
			set
			{
				_FLD_装备_追加_心 = value;
			}
		}

		public double FLD_装备_追加_qigong_10_job5
		{
			get
			{
				return _FLD_装备_追加_医九天真气;
			}
			set
			{
				_FLD_装备_追加_医九天真气 = value;
			}
		}

		public double FLD_装备_追加_qigong_4_job5
		{
			get
			{
				return _FLD_装备_追加_医妙手回春;
			}
			set
			{
				_FLD_装备_追加_医妙手回春 = value;
			}
		}

		public double FLD_装备_追加_qigong_8_job5
		{
			get
			{
				return _FLD_装备_追加_医神农仙术;
			}
			set
			{
				_FLD_装备_追加_医神农仙术 = value;
			}
		}

		public double FLD_装备_追加_qigong_1_job5
		{
			get
			{
				return _FLD_装备_追加_医太极心法;
			}
			set
			{
				_FLD_装备_追加_医太极心法 = value;
			}
		}

		public double FLD_装备_追加_qigong_2_job5
		{
			get
			{
				return _FLD_装备_追加_医体血倍增;
			}
			set
			{
				_FLD_装备_追加_医体血倍增 = value;
			}
		}

		public double FLD_装备_追加_qigong_9_job5
		{
			get
			{
				return _FLD_装备_追加_医天佑之气;
			}
			set
			{
				_FLD_装备_追加_医天佑之气 = value;
			}
		}

		public double FLD_装备_追加_qigong_7_job5
		{
			get
			{
				return _FLD_装备_追加_医吸星大法;
			}
			set
			{
				_FLD_装备_追加_医吸星大法 = value;
			}
		}

		public double FLD_装备_追加_qigong_3_job5
		{
			get
			{
				return _FLD_装备_追加_医洗髓易经;
			}
			set
			{
				_FLD_装备_追加_医洗髓易经 = value;
			}
		}

		public double FLD_装备_追加_qigong_0_job5
		{
			get
			{
				return _FLD_装备_追加_医运气行心;
			}
			set
			{
				_FLD_装备_追加_医运气行心 = value;
			}
		}

		public double FLD_装备_追加_qigong_5_job5
		{
			get
			{
				return _FLD_装备_追加_医长功攻击;
			}
			set
			{
				_FLD_装备_追加_医长功攻击 = value;
			}
		}

		public int FLD_装备_追加_追伤
		{
			get
			{
				return _FLD_装备_追加_追伤;
			}
			set
			{
				_FLD_装备_追加_追伤 = value;
			}
		}

		public double FLD_追加百分比_HP上限
		{
			get
			{
				return _FLD_追加百分比_HP上限;
			}
			set
			{
				_FLD_追加百分比_HP上限 = value;
			}
		}

		public double FLD_追加百分比_MP上限
		{
			get
			{
				return _FLD_追加百分比_MP上限;
			}
			set
			{
				_FLD_追加百分比_MP上限 = value;
			}
		}

		public double FLD_TRUDEF_801302
		{
			get
			{
				return _FLD_TRUDEF_801302;
			}
			set
			{
				_FLD_TRUDEF_801302 = value;
			}
		}

		public double FLD_TRUDEF_NINJA
		{
			get
			{
				return _FLD_TRUDEF_NINJA;
			}
			set
			{
				_FLD_TRUDEF_NINJA = value;
			}
		}

		public double FLD_TANGHP_DP
		{
			get
			{
				return _FLD_TANGHP_DP;
			}
			set
			{
				_FLD_TANGHP_DP = value;
			}
		}

		public double FLD_TRUDEF_CAMSU
		{
			get
			{
				return _FLD_TRUDEF_CAMSU;
			}
			set
			{
				_FLD_TRUDEF_CAMSU = value;
			}
		}

		public double FLD_TANGDEF_CAMSU
		{
			get
			{
				return _FLD_TANGDEF_CAMSU;
			}
			set
			{
				_FLD_TANGDEF_CAMSU = value;
			}
		}

		public double FLD_TRUDAME_CAMSU
		{
			get
			{
				return _FLD_TRUDAME_CAMSU;
			}
			set
			{
				_FLD_TRUDAME_CAMSU = value;
			}
		}

		public double FLD_追加百分比_防御
		{
			get
			{
				if (_FLD_追加百分比_防御 < 0.0)
				{
					_FLD_追加百分比_防御 = 0.0;
				}
				return _FLD_追加百分比_防御;
			}
			set
			{
				_FLD_追加百分比_防御 = value;
			}
		}

		public double FLD_追加百分比_防御_KCDAO115
		{
			get
			{
				if (_FLD_追加百分比_防御_KCDAO115 < 0.0)
				{
					_FLD_追加百分比_防御_KCDAO115 = 0.0;
				}
				return _FLD_追加百分比_防御_KCDAO115;
			}
			set
			{
				_FLD_追加百分比_防御_KCDAO115 = value;
			}
		}

		public double FLD_追加百分比_防御_PHANNO
		{
			get
			{
				if (_FLD_追加百分比_防御_PHANNO < 0.0)
				{
					_FLD_追加百分比_防御_PHANNO = 0.0;
				}
				return _FLD_追加百分比_防御_PHANNO;
			}
			set
			{
				_FLD_追加百分比_防御_PHANNO = value;
			}
		}

		public double FLD_追加百分比_Shield_PHANNO
		{
			get
			{
				if (_FLD_追加百分比_Shield_PHANNO < 0.0)
				{
					_FLD_追加百分比_Shield_PHANNO = 0.0;
				}
				return _FLD_追加百分比_Shield_PHANNO;
			}
			set
			{
				_FLD_追加百分比_Shield_PHANNO = value;
			}
		}

		public double FLD_追加百分比_防御_DAIPHU115
		{
			get
			{
				if (_FLD_追加百分比_防御_DAIPHU115 < 0.0)
				{
					_FLD_追加百分比_防御_DAIPHU115 = 0.0;
				}
				return _FLD_追加百分比_防御_DAIPHU115;
			}
			set
			{
				_FLD_追加百分比_防御_DAIPHU115 = value;
			}
		}

		public double FLD_追加百分比_攻击
		{
			get
			{
				if (_FLD_追加百分比_攻击 < 0.0)
				{
					_FLD_追加百分比_攻击 = 0.0;
				}
				return _FLD_追加百分比_攻击;
			}
			set
			{
				_FLD_追加百分比_攻击 = value;
			}
		}

		public double FLD_BUFF_DP_ATT
		{
			get
			{
				if (_FLD_BUFF_DP_ATT < 0.0)
				{
					_FLD_BUFF_DP_ATT = 0.0;
				}
				return _FLD_BUFF_DP_ATT;
			}
			set
			{
				_FLD_BUFF_DP_ATT = value;
			}
		}

		public double FLD_BUFF_DP_DEF
		{
			get
			{
				if (_FLD_BUFF_DP_DEF < 0.0)
				{
					_FLD_BUFF_DP_DEF = 0.0;
				}
				return _FLD_BUFF_DP_DEF;
			}
			set
			{
				_FLD_BUFF_DP_DEF = value;
			}
		}

		public double FLD_BUFF_DP_HP
		{
			get
			{
				if (_FLD_BUFF_DP_HP < 0.0)
				{
					_FLD_BUFF_DP_HP = 0.0;
				}
				return _FLD_BUFF_DP_HP;
			}
			set
			{
				_FLD_BUFF_DP_HP = value;
			}
		}

		public double FLD_BUFF_DP_CX
		{
			get
			{
				if (_FLD_BUFF_DP_CX < 0.0)
				{
					_FLD_BUFF_DP_CX = 0.0;
				}
				return _FLD_BUFF_DP_CX;
			}
			set
			{
				_FLD_BUFF_DP_CX = value;
			}
		}

		public double FLD_Item_AoChoang_ChinhXac
		{
			get
			{
				if (_FLD_Item_AoChoang_ChinhXac < 0.0)
				{
					_FLD_Item_AoChoang_ChinhXac = 0.0;
				}
				return _FLD_Item_AoChoang_ChinhXac;
			}
			set
			{
				_FLD_Item_AoChoang_ChinhXac = value;
			}
		}

		public double FLD_Item_AoChoang_NeTranh
		{
			get
			{
				if (_FLD_Item_AoChoang_NeTranh < 0.0)
				{
					_FLD_Item_AoChoang_NeTranh = 0.0;
				}
				return _FLD_Item_AoChoang_NeTranh;
			}
			set
			{
				_FLD_Item_AoChoang_NeTranh = value;
			}
		}

		public double FLD_BUFF_DP_NT
		{
			get
			{
				if (_FLD_BUFF_DP_NT < 0.0)
				{
					_FLD_BUFF_DP_NT = 0.0;
				}
				return _FLD_BUFF_DP_NT;
			}
			set
			{
				_FLD_BUFF_DP_NT = value;
			}
		}

		public double FLD_追加百分比_攻击_KCDAO115
		{
			get
			{
				if (_FLD_追加百分比_攻击_KCDAO115 < 0.0)
				{
					_FLD_追加百分比_攻击_KCDAO115 = 0.0;
				}
				return _FLD_追加百分比_攻击_KCDAO115;
			}
			set
			{
				_FLD_追加百分比_攻击_KCDAO115 = value;
			}
		}

		public double FLD_追加百分比_攻击_PHANNO
		{
			get
			{
				if (_FLD_追加百分比_攻击_PHANNO < 0.0)
				{
					_FLD_追加百分比_攻击_PHANNO = 0.0;
				}
				return _FLD_追加百分比_攻击_PHANNO;
			}
			set
			{
				_FLD_追加百分比_攻击_PHANNO = value;
			}
		}

		public double FLD_追加百分比_回避
		{
			get
			{
				return _FLD_追加百分比_回避;
			}
			set
			{
				_FLD_追加百分比_回避 = value;
			}
		}

		public double FLD_追加百分比_命中
		{
			get
			{
				return _FLD_追加百分比_命中;
			}
			set
			{
				_FLD_追加百分比_命中 = value;
			}
		}

		public int Player_ExpErience
		{
			get
			{
				return _Player_ExpErience;
			}
			set
			{
				_Player_ExpErience = value;
			}
		}

		public int Player_Job
		{
			get
			{
				return _Player_Job;
			}
			set
			{
				_Player_Job = value;
			}
		}

		public int Player_Job_Level
		{
			get
			{
				return _playerJobLevel;
			}
			set
			{
				_playerJobLevel = value;
			}
		}

		public int Player_Level
		{
			get
			{
				return _playerLevel;
			}
			set
			{
				_playerLevel = value;
			}
		}

		public long Player_Money
		{
			get
			{
				return _Player_Money;
			}
			set
			{
				if (value < 0)
				{
					_Player_Money = 0L;
				}
				else
				{
					_Player_Money = value;
				}
			}
		}

		public int Player_Qigong_point
		{
			get
			{
				return _Player_Qigong_point;
			}
			set
			{
				_Player_Qigong_point = value;
			}
		}

		public int Player_Sex
		{
			get
			{
				return _Player_Sex;
			}
			set
			{
				_Player_Sex = value;
			}
		}

		public int Player_WuXun
		{
			get
			{
				return _Player_WuXun;
			}
			set
			{
				_Player_WuXun = value;
			}
		}

		public int Player_Zx
		{
			get
			{
				return _Player_Zx;
			}
			set
			{
				_Player_Zx = value;
			}
		}

		public bool PlayerIsDead
		{
			get
			{
				if (Player_FLD_HP <= 0)
				{
					_Player死亡 = false;
				}
				return _Player死亡;
			}
			set
			{
				_Player死亡 = value;
			}
		}

		public int Rxjh_WX
		{
			get
			{
				return _Rxjh_WX;
			}
			set
			{
				_Rxjh_WX = value;
			}
		}

		public string Userid
		{
			get
			{
				return _Userid;
			}
			set
			{
				_Userid = value;
			}
		}

		public string UserName
		{
			get
			{
				return _UserName;
			}
			set
			{
				_UserName = value;
			}
		}

		public int Guild_ID
		{
			get
			{
				return _帮派Id;
			}
			set
			{
				_帮派Id = value;
			}
		}

		public int Guild_Style_Color
		{
			get
			{
				return _帮派门服颜色;
			}
			set
			{
				_帮派门服颜色 = value;
			}
		}

		public int Guild_Style
		{
			get
			{
				return _帮派门服字;
			}
			set
			{
				_帮派门服字 = value;
			}
		}

		public byte[] Guild_Icon
		{
			get
			{
				return _帮派门徽;
			}
			set
			{
				_帮派门徽 = value;
			}
		}

		public string Guild_Name
		{
			get
			{
				return _帮派名字;
			}
			set
			{
				_帮派名字 = value;
			}
		}

		public int Guild_Level
		{
			get
			{
				return _帮派人物等级;
			}
			set
			{
				_帮派人物等级 = value;
			}
		}

		public int Level_Of_Guild
		{
			get
			{
				return _Level_Of_Guild;
			}
			set
			{
				_Level_Of_Guild = value;
			}
		}

		public int KyNangKetHon_UyLuc
		{
			get
			{
				if (bPartyWithCouple)
				{
					return (int)((double)KyNangManhNhat_UyLuc * 1.1);
				}
				return KyNangManhNhat_UyLuc;
			}
		}

		public int KyNangManhNhat_UyLuc
		{
			get
			{
				return _KyNangManhNhat_UyLuc;
			}
			set
			{
				_KyNangManhNhat_UyLuc = value;
			}
		}

		public int KyNangKetHon_MP
		{
			get
			{
				if (bPartyWithCouple)
				{
					return (int)((double)KyNangManhNhat_MP * 1.1);
				}
				return KyNangManhNhat_MP;
			}
		}

		public int KyNangManhNhat_MP
		{
			get
			{
				return _KyNangManhNhat_MP;
			}
			set
			{
				_KyNangManhNhat_MP = value;
			}
		}

		public long 个人仓库钱数
		{
			get
			{
				return _个人仓库钱数;
			}
			set
			{
				_个人仓库钱数 = value;
			}
		}

		public int 弓群攻技能ID
		{
			get
			{
				return _弓群攻技能ID;
			}
			set
			{
				_弓群攻技能ID = value;
			}
		}

		public int 会员等级
		{
			get
			{
				return _会员等级;
			}
			set
			{
				_会员等级 = value;
			}
		}

		public int FLD_VoHoang
		{
			get
			{
				return _FLD_VoHoang;
			}
			set
			{
				_FLD_VoHoang = value;
			}
		}

		public int Player_Shield
		{
			get
			{
				if (_playerShield > Player_Shield_Max)
				{
					_playerShield = Player_Shield_Max;
				}
				return _playerShield;
			}
			set
			{
				if (value < 0)
				{
					value = 0;
				}
				_playerShield = value;
			}
		}

		public int Player_Basic_Shield
		{
			get
			{
				return _playerBasicShield;
			}
			set
			{
				_playerBasicShield = value;
			}
		}

		public int FLD_Item_Shield
		{
			get
			{
				return _fldItemShield;
			}
			set
			{
				_fldItemShield = value;
			}
		}

		public int FLD_Item_Shield_Recover
		{
			get
			{
				return _fldItemShield_Recover;
			}
			set
			{
				_fldItemShield_Recover = value;
			}
		}

		public int FLD_Item_HP_Recover
		{
			get
			{
				return _FLD_Item_HP_Recover;
			}
			set
			{
				_FLD_Item_HP_Recover = value;
			}
		}

		public int FLD_Item_MP_Recover
		{
			get
			{
				return _FLD_Item_MP_Recover;
			}
			set
			{
				_FLD_Item_MP_Recover = value;
			}
		}

		public int Player_Shield_Max
		{
			get
			{
				if (Player_Job != 11)
				{
					return 0;
				}
				return (int)((double)(Player_Basic_Shield + FLD_Item_Shield) * (1.0 + FLD_追加百分比_Shield_PHANNO));
			}
		}

		public int FLD_MetMoi
		{
			get
			{
				return _FLD_MetMoi;
			}
			set
			{
				_FLD_MetMoi = value;
			}
		}

		public long 奖励_追加_防御
		{
			get
			{
				return _奖励_追加_防御;
			}
			set
			{
				_奖励_追加_防御 = value;
			}
		}

		public long 奖励_追加_攻击
		{
			get
			{
				return _奖励_追加_攻击;
			}
			set
			{
				_奖励_追加_攻击 = value;
			}
		}

		public int 奖励_追加_回避
		{
			get
			{
				return _奖励_追加_回避;
			}
			set
			{
				_奖励_追加_回避 = value;
			}
		}

		public int 奖励_追加_命中
		{
			get
			{
				return _奖励_追加_命中;
			}
			set
			{
				_奖励_追加_命中 = value;
			}
		}

		public int 奖励_追加_内功
		{
			get
			{
				return _奖励_追加_内功;
			}
			set
			{
				_奖励_追加_内功 = value;
			}
		}

		public long 奖励_追加_生命
		{
			get
			{
				return _奖励_追加_生命;
			}
			set
			{
				_奖励_追加_生命 = value;
			}
		}

		public long Player_FLD_HP
		{
			get
			{
				return _人物_HP;
			}
			set
			{
				if (value < 0)
				{
					value = 0L;
				}
				_人物_HP = value;
			}
		}

		public int Player_FLD_MP
		{
			get
			{
				return _人物_MP;
			}
			set
			{
				if (value < 0)
				{
					value = 0;
				}
				_人物_MP = value;
			}
		}

		public int 人物_SP
		{
			get
			{
				return _人物_SP;
			}
			set
			{
				_人物_SP = value;
			}
		}

		public int 人物_气功_追加_HP
		{
			get
			{
				return _人物_气功_追加_HP;
			}
			set
			{
				_人物_气功_追加_HP = value;
			}
		}

		public int 人物_气功_追加_MP
		{
			get
			{
				return _人物_气功_追加_MP;
			}
			set
			{
				_人物_气功_追加_MP = value;
			}
		}

		public double 人物_追加_经验百分比 => FLD_Item_Exp + ExpExporll + FLD_Item_Premium_Exp + FLD_Event_Premium_Exp + FLD_TLC_Premium_Exp + coupleEffectExp + flowerEffectExp;

		public int 人物PK模式
		{
			get
			{
				return _人物PK模式;
			}
			set
			{
				_人物PK模式 = value;
			}
		}

		public int 人物负重
		{
			get
			{
				return _人物负重;
			}
			set
			{
				_人物负重 = value;
			}
		}

		public int 人物负重总
		{
			get
			{
				return _人物负重总;
			}
			set
			{
				_人物负重总 = value;
			}
		}

		public int 人物基本最大_HP
		{
			get
			{
				return _人物基本最大_HP;
			}
			set
			{
				_人物基本最大_HP = value;
			}
		}

		public int 人物基本最大_MP
		{
			get
			{
				return _人物基本最大_MP;
			}
			set
			{
				_人物基本最大_MP = value;
			}
		}

		public long Player_FLD_EXP
		{
			get
			{
				return _人物经验;
			}
			set
			{
				_人物经验 = value;
			}
		}

		public int Pet_ID => UserSessionID * 2 + 40000;

		public byte[] NameType
		{
			get
			{
				return _nameType;
			}
			set
			{
				_nameType = value;
			}
		}

		public int 人物轻功
		{
			get
			{
				return _人物轻功;
			}
			set
			{
				_人物轻功 = value;
			}
		}

		public int UserSessionID => Client.WorldId;

		public int Player_FLD_SE
		{
			get
			{
				return _人物善恶;
			}
			set
			{
				if (_人物善恶 + value > 0)
				{
					_人物善恶 = 0;
				}
				else if (_人物善恶 - value < -30000)
				{
					_人物善恶 = -30000;
				}
				else
				{
					_人物善恶 = value;
				}
			}
		}

		public int 人物位置
		{
			get
			{
				return _人物位置;
			}
			set
			{
				_人物位置 = value;
			}
		}

		public int 人物武勋阶段
		{
			get
			{
				return _人物武勋阶段;
			}
			set
			{
				_人物武勋阶段 = value;
			}
		}

		public int FLD_Item_Premium_HP
		{
			get
			{
				return _人物追加最大_HP;
			}
			set
			{
				_人物追加最大_HP = value;
			}
		}

		public int FLD_Item_Premium_MP
		{
			get
			{
				return _fldItemPremiumMp;
			}
			set
			{
				_fldItemPremiumMp = value;
			}
		}

		public long Player_HP_Max => (long)(base.KCV17_KC7 * (double)FLD_Defense + (double)HP_GuildWar + (double)(int)((double)(人物基本最大_HP + FLD_装备_追加_the + FLD_Item_HP + 人物_气功_追加_HP + FLD_Item_Premium_HP + 奖励_追加_生命 + 武勋追加_HP + Player_HP_Guild + flowerEffectHealth) * (1.0 + FLD_追加百分比_HP上限 + coupleEffectHealth + FLD_BUFF_DP_HP)));

		public int Player_MP_Max => (int)((double)(人物基本最大_MP + FLD_装备_追加_tam + FLD_Item_MP + 人物_气功_追加_MP + FLD_Item_Premium_MP + 奖励_追加_内功 + 武勋追加_MP + Player_MP_Guild) * (1.0 + FLD_追加百分比_MP上限 + coupleEffectChi));

		public int 人物最大_SP
		{
			get
			{
				return _人物最大_SP;
			}
			set
			{
				_人物最大_SP = value;
			}
		}

		public long 人物最大经验
		{
			get
			{
				return _人物最大经验;
			}
			set
			{
				_人物最大经验 = value;
			}
		}

		public float Player_FLD_X
		{
			get
			{
				return _人物坐标_X;
			}
			set
			{
				_人物坐标_X = value;
			}
		}

		public float Player_FLD_Y
		{
			get
			{
				return _人物坐标_Y;
			}
			set
			{
				_人物坐标_Y = value;
			}
		}

		public float Player_FLD_Z
		{
			get
			{
				return _人物坐标_Z;
			}
			set
			{
				_人物坐标_Z = value;
			}
		}

		public int Player_FLD_Map
		{
			get
			{
				return _人物坐标_地图;
			}
			set
			{
				_人物坐标_地图 = value;
			}
		}

		public int 上河调计数
		{
			get
			{
				return _上河调计数;
			}
			set
			{
				_上河调计数 = value;
			}
		}

		public int Player_HP_Guild
		{
			get
			{
				return _Player_HP_Guild;
			}
			set
			{
				_Player_HP_Guild = value;
			}
		}

		public int Player_MP_Guild
		{
			get
			{
				return _Player_MP_Guild;
			}
			set
			{
				_Player_MP_Guild = value;
			}
		}

		public int 武勋追加_HP
		{
			get
			{
				return _武勋追加_HP;
			}
			set
			{
				_武勋追加_HP = value;
			}
		}

		public int 武勋追加_MP
		{
			get
			{
				return _武勋追加_MP;
			}
			set
			{
				_武勋追加_MP = value;
			}
		}

		public int 下河调计数
		{
			get
			{
				return _下河调计数;
			}
			set
			{
				_下河调计数 = value;
			}
		}

		public int 玉连环计数
		{
			get
			{
				return _玉连环计数;
			}
			set
			{
				_玉连环计数 = value;
			}
		}

		public int 转生次数
		{
			get
			{
				return _转生次数;
			}
			set
			{
				_转生次数 = value;
			}
		}

		public int 装备行囊是否开启
		{
			get
			{
				return _装备行囊是否开启;
			}
			set
			{
				_装备行囊是否开启 = value;
			}
		}

		public long 综合仓库钱数
		{
			get
			{
				return _综合仓库钱数;
			}
			set
			{
				_综合仓库钱数 = value;
			}
		}

		public int 总在线时间
		{
			get
			{
				return BitConverter.ToInt32(_总在线时间, 0);
			}
			set
			{
				Buffer.BlockCopy(BitConverter.GetBytes(value), 0, _总在线时间, 0, 4);
			}
		}

		public int 每日武勋
		{
			get
			{
				return _每日武勋;
			}
			set
			{
				_每日武勋 = value;
			}
		}

		public PlayersBes(NetState client)
		{
			玉连环 = new List<int>();
			KyNangManhNhat_MP = 0;
			KyNangManhNhat_UyLuc = 0;
			潜行模式 = 0;
			装备数据版本 = 1;
			综合仓库装备数据版本 = 1;
			PKhmtimelx = DateTime.Now;
			PKhmtime = DateTime.Now;
			PKhmtimezl = DateTime.Now;
			PKhmtimee = DateTime.Now;
			PKhmtimsj = DateTime.Now;
			Config = new ConfigClass();
			交易 = new 交易类();
			Client = client;
			妖花青草 = false;
			KimLongChiTheu = false;
			NpcList = new ThreadSafeDictionary<int, NpcClass>();
			地面物品列表 = new ThreadSafeDictionary<double, 地面物品类>();
			公有药品 = new Dictionary<int, 公有药品类>();
			list_时间药品 = new ThreadSafeDictionary<int, 时间药品>();
			Show_Pic_Class = new ThreadSafeDictionary<int, Class_Show_Pill>();
			追加状态New列表 = new ThreadSafeDictionary<int, 追加状态New类>();
			异常状态 = new ThreadSafeDictionary<int, 异常状态类>();
			土灵符坐标 = new Hashtable();
			攻击列表 = new List<攻击类>();
			SkillCombo = new List<武功类>();
			传书列表 = new Dictionary<int, EmailClass>();
			Array_Skill_Book = new 武功类[4, 35];
			Item_In_Bag = new 物品类[66];
			Item_Wear = new 物品类[16];
			Item_NTC = new 物品类[6];
			Item_Coat = new 物品类[60];
			气功 = new 气功类[15];
			任务 = new Dictionary<int, 任务类>();
			个人仓库 = new 物品类[60];
			公共仓库 = new 物品类[60];
			Quest_Item = new 任务物品类[36];
			升天气功 = new SortedDictionary<int, 升天气功类>();
			FLD_Item_Premium_HP = 0;
			FLD_Item_Premium_MP = 0;
			人物基本最大_HP = 0;
			FLD_Item_HP = 0;
			HP_GuildWar = 0L;
			人物_气功_追加_HP = 0;
			人物基本最大_MP = 0;
			FLD_Item_MP = 0;
			人物_气功_追加_MP = 0;
			FLD_攻击速度 = 100;
			灵兽 = new Dictionary<int, PetClass>();
			爆毒状态 = 0;
			天地同寿回避次数 = 0;
			刺_连消带打数量 = 0.0;
			升天武功点数 = 0;
			_总在线时间 = new byte[200];
			每日武勋 = 0;
			会员等级 = 0;
			FLD_VoHoang = 0;
			Party_Status = 0;
			装备行囊是否开启 = 0;
			Player_Invisible = 0;
			int_25 = 0;
			int_123 = 0;
			Player_Shield = 0;
			Player_Basic_Shield = 0;
			FLD_Item_Shield = 0;
			FLD_Item_Shield_Recover = 0;
			FLD_Item_HP_Recover = 0;
			FLD_Item_MP_Recover = 0;
		}

		public void addFLD_装备_追加_防具_强化(int i)
		{
			using (new Lock(eval_c, "addFLD_装备_追加_防具_强化"))
			{
				FLD_Item_Plus_TB += i;
			}
		}

		public void addFLD_装备_追加_武器_强化(int i)
		{
			using (new Lock(eval_c, "addFLD_装备_追加_武器_强化"))
			{
				FLD_Item_Plus_VK += i;
			}
		}

		public void Add_DEF_Percentage(double i)
		{
			using (new Lock(eval_c, "addFLD_追加百分比_防御"))
			{
				FLD_追加百分比_防御 += i;
			}
		}

		public void Add_ATT_Percentage(double i)
		{
			using (new Lock(eval_c, "addFLD_追加百分比_攻击"))
			{
				FLD_追加百分比_攻击 += i;
			}
		}

		public void Clear()
		{
			int_25 = 0;
			int_123 = 0;
			弓群攻技能ID = 0;
			装备行囊是否开启 = 0;
			玉连环 = new List<int>();
			装备数据版本 = 1;
			综合仓库装备数据版本 = 1;
			PKhmtime = DateTime.Now;
			PKhmtimelx = DateTime.Now;
			PKhmtimezl = DateTime.Now;
			PKhmtimee = DateTime.Now;
			PKhmtimsj = DateTime.Now;
			退出中 = false;
			存档时间 = false;
			妖花青草 = false;
			KimLongChiTheu = false;
			灵兽.Clear();
			升天气功.Clear();
			Array_Skill_Book = new 武功类[4, 35];
			KyNangManhNhat_UyLuc = 0;
			KyNangManhNhat_MP = 0;
			公有药品 = new Dictionary<int, 公有药品类>();
			任务 = new Dictionary<int, 任务类>();
			FLD_Item_Premium_HP = 0;
			FLD_Item_Premium_MP = 0;
			人物基本最大_HP = 0;
			FLD_Item_HP = 0;
			人物_气功_追加_HP = 0;
			人物基本最大_MP = 0;
			FLD_Item_MP = 0;
			人物_气功_追加_MP = 0;
			Guild_Icon = null;
			Guild_Level = 0;
			Level_Of_Guild = 0;
			Guild_Name = string.Empty;
			Guild_ID = 0;
			FLD_TRUDEF_801302 = 0.0;
			FLD_TRUDEF_CAMSU = 0.0;
			FLD_TRUDEF_NINJA = 0.0;
			FLD_TRUDAME_CAMSU = 0.0;
			FLD_追加百分比_攻击 = 0.0;
			FLD_追加百分比_防御 = 0.0;
			FLD_追加百分比_命中 = 0.0;
			FLD_追加百分比_回避 = 0.0;
			FLD_追加百分比_HP上限 = 0.0;
			FLD_追加百分比_MP上限 = 0.0;
			FLD_Item_Skill_Attack_Percentage = 0.0;
			FLD_Item_Skill_Def_Percentage = 0.0;
			FLD_人物_追加_攻击 = 0;
			FLD_人物_追加_防御 = 0;
			FLD_人物_追加_命中 = 0;
			FLD_人物_追加_回避 = 0;
			Character_Qigong = 0;
			Character_Upgrade_Lucky = 0.0;
			FLD_Item_Premium_Exp = 0.0;
			FLD_Item_Premium_Fight_Exp = 0.0;
			FLD_Item_Premium_Money = 0.0;
			FLD_Item_Premium_Drop = 0.0;
			FLD_装备_追加_qigong_0_job6 = 0.0;
			FLD_装备_追加_qigong_9_job6 = 0.0;
			FLD_装备_追加_qigong_9_job1 = 0.0;
			FLD_装备_追加_qigong_0_job1 = 0.0;
			FLD_装备_追加_qigong_0_job4 = 0.0;
			FLD_装备_追加_qigong_9_job4 = 0.0;
			FLD_装备_追加_qigong_9_job3 = 0.0;
			FLD_装备_追加_qigong_9_job2 = 0.0;
			FLD_装备_追加_qigong_0_job2 = 0.0;
			FLD_装备_追加_qigong_0_job3 = 0.0;
			FLD_装备_追加_qigong_9_job7 = 0.0;
			FLD_装备_追加_qigong_7_job7 = 0.0;
			FLD_装备_追加_qigong_2_job5 = 0.0;
			FLD_装备_追加_qigong_9_job5 = 0.0;
			FLD_装备_追加_qigong_1_job1 = 0.0;
			FLD_装备_追加_qigong_2_job1 = 0.0;
			FLD_装备_追加_qigong_3_job1 = 0.0;
			FLD_装备_追加_qigong_4_job1 = 0.0;
			FLD_装备_追加_qigong_5_job1 = 0.0;
			FLD_装备_追加_qigong_8_job1 = 0.0;
			FLD_装备_追加_qigong_10_job1 = 0.0;
			FLD_装备_追加_qigong_11_job1 = 0.0;
			FLD_装备_追加_qigong_11_job2 = 0.0;
			FLD_装备_追加_qigong_11_job3 = 0.0;
			FLD_装备_追加_qigong_11_job4 = 0.0;
			FLD_装备_追加_qigong_11_job5 = 0.0;
			FLD_装备_追加_qigong_11_job6 = 0.0;
			FLD_装备_追加_qigong_11_job7 = 0.0;
			FLD_装备_追加_qigong_0_job8 = 0.0;
			FLD_装备_追加_qigong_1_job8 = 0.0;
			FLD_装备_追加_qigong_2_job8 = 0.0;
			FLD_装备_追加_qigong_3_job8 = 0.0;
			FLD_装备_追加_qigong_4_job8 = 0.0;
			FLD_装备_追加_qigong_5_job8 = 0.0;
			FLD_装备_追加_qigong_7_job8 = 0.0;
			FLD_装备_追加_qigong_8_job8 = 0.0;
			FLD_装备_追加_qigong_9_job8 = 0.0;
			FLD_装备_追加_qigong_10_job9 = 0.0;
			FLD_装备_追加_qigong_11_job9 = 0.0;
			FLD_装备_追加_qigong_0_job9 = 0.0;
			FLD_装备_追加_qigong_1_job9 = 0.0;
			FLD_装备_追加_qigong_2_job9 = 0.0;
			FLD_装备_追加_qigong_3_job9 = 0.0;
			FLD_装备_追加_qigong_4_job9 = 0.0;
			FLD_装备_追加_qigong_5_job9 = 0.0;
			FLD_装备_追加_qigong_7_job9 = 0.0;
			FLD_装备_追加_qigong_8_job9 = 0.0;
			FLD_装备_追加_qigong_9_job9 = 0.0;
			FLD_装备_追加_qigong_10_job9 = 0.0;
			FLD_装备_追加_qigong_11_job9 = 0.0;
			FLD_装备_追加_qigong_0_job10 = 0.0;
			FLD_装备_追加_qigong_1_job10 = 0.0;
			FLD_装备_追加_qigong_2_job10 = 0.0;
			FLD_装备_追加_qigong_3_job10 = 0.0;
			FLD_装备_追加_qigong_4_job10 = 0.0;
			FLD_装备_追加_qigong_5_job10 = 0.0;
			FLD_装备_追加_qigong_7_job10 = 0.0;
			FLD_装备_追加_qigong_8_job10 = 0.0;
			FLD_装备_追加_qigong_9_job10 = 0.0;
			FLD_装备_追加_qigong_10_job10 = 0.0;
			FLD_装备_追加_qigong_11_job10 = 0.0;
			FLD_装备_追加_qigong_0_job11 = 0.0;
			FLD_装备_追加_qigong_1_job11 = 0.0;
			FLD_装备_追加_qigong_2_job11 = 0.0;
			FLD_装备_追加_qigong_3_job11 = 0.0;
			FLD_装备_追加_qigong_4_job11 = 0.0;
			FLD_装备_追加_qigong_5_job11 = 0.0;
			FLD_装备_追加_qigong_7_job11 = 0.0;
			FLD_装备_追加_qigong_8_job11 = 0.0;
			FLD_装备_追加_qigong_9_job11 = 0.0;
			FLD_装备_追加_qigong_10_job11 = 0.0;
			FLD_装备_追加_qigong_11_job11 = 0.0;
			FLD_装备_追加_qigong_0_job12 = 0.0;
			FLD_装备_追加_qigong_1_job12 = 0.0;
			FLD_装备_追加_qigong_2_job12 = 0.0;
			FLD_装备_追加_qigong_3_job12 = 0.0;
			FLD_装备_追加_qigong_4_job12 = 0.0;
			FLD_装备_追加_qigong_5_job12 = 0.0;
			FLD_装备_追加_qigong_7_job12 = 0.0;
			FLD_装备_追加_qigong_8_job12 = 0.0;
			FLD_装备_追加_qigong_9_job12 = 0.0;
			FLD_装备_追加_qigong_10_job12 = 0.0;
			FLD_装备_追加_qigong_11_job12 = 0.0;
			base.KhiCong_NhatKiemPhaThien = 0.0;
			base.KC9_Cung = 0.0;
			FLD_装备_追加_qigong_7_job1 = 0.0;
			FLD_装备_追加_qigong_1_job2 = 0.0;
			FLD_装备_追加_qigong_2_job2 = 0.0;
			FLD_装备_追加_qigong_3_job2 = 0.0;
			FLD_装备_追加_qigong_4_job2 = 0.0;
			FLD_装备_追加_qigong_5_job2 = 0.0;
			FLD_装备_追加_qigong_7_job2 = 0.0;
			FLD_装备_追加_qigong_8_job2 = 0.0;
			FLD_装备_追加_qigong_10_job2 = 0.0;
			FLD_装备_追加_qigong_1_job3 = 0.0;
			FLD_装备_追加_qigong_2_job3 = 0.0;
			FLD_装备_追加_qigong_3_job3 = 0.0;
			FLD_装备_追加_qigong_4_job3 = 0.0;
			FLD_装备_追加_qigong_5_job3 = 0.0;
			FLD_装备_追加_qigong_7_job3 = 0.0;
			FLD_装备_追加_qigong_8_job3 = 0.0;
			FLD_装备_追加_qigong_10_job3 = 0.0;
			FLD_装备_追加_qigong_1_job4 = 0.0;
			FLD_装备_追加_qigong_2_job4 = 0.0;
			FLD_装备_追加_qigong_3_job4 = 0.0;
			FLD_装备_追加_qigong_4_job4 = 0.0;
			FLD_装备_追加_qigong_5_job4 = 0.0;
			FLD_装备_追加_qigong_7_job4 = 0.0;
			FLD_装备_追加_qigong_8_job4 = 0.0;
			FLD_装备_追加_qigong_10_job4 = 0.0;
			FLD_装备_追加_qigong_0_job5 = 0.0;
			FLD_装备_追加_qigong_1_job5 = 0.0;
			FLD_装备_追加_qigong_3_job5 = 0.0;
			FLD_装备_追加_qigong_4_job5 = 0.0;
			FLD_装备_追加_qigong_5_job5 = 0.0;
			FLD_装备_追加_qigong_7_job5 = 0.0;
			FLD_装备_追加_qigong_8_job5 = 0.0;
			FLD_装备_追加_qigong_10_job5 = 0.0;
			FLD_装备_追加_qigong_1_job6 = 0.0;
			FLD_装备_追加_qigong_2_job6 = 0.0;
			FLD_装备_追加_qigong_3_job6 = 0.0;
			FLD_装备_追加_qigong_4_job6 = 0.0;
			FLD_装备_追加_qigong_5_job6 = 0.0;
			FLD_装备_追加_qigong_7_job6 = 0.0;
			FLD_装备_追加_qigong_8_job6 = 0.0;
			FLD_装备_追加_qigong_10_job6 = 0.0;
			FLD_装备_追加_qigong_0_job7 = 0.0;
			FLD_装备_追加_qigong_1_job7 = 0.0;
			FLD_装备_追加_qigong_2_job7 = 0.0;
			FLD_装备_追加_qigong_3_job7 = 0.0;
			FLD_装备_追加_qigong_4_job7 = 0.0;
			FLD_装备_追加_qigong_5_job7 = 0.0;
			FLD_装备_追加_qigong_8_job7 = 0.0;
			FLD_装备_追加_qigong_10_job7 = 0.0;
			Item_Upgrade_Lucky_Add = 0.0;
			FLD_Wear_Item_Money = 0.0;
			FLD_Item_Attack_Skill = 0.0;
			FLD_Item_Attack_Point = 0.0;
			FLD_Item_Defense_Skill = 0.0;
			FLD_Pill_Defense_Skill = 0.0;
			FLD_Item_Attack = 0L;
			FLD_Item_Defense = 0L;
			FLD_Item_Shield = 0;
			FLD_Item_Shield_Recover = 0;
			FLD_Item_HP_Recover = 0;
			FLD_Item_MP_Recover = 0;
			FLD_Item_Accuracy = 0;
			FLD_Item_Evasion = 0;
			FLD_Item_Level_Pran = 0;
			FLD_Item_Plus_TB = 0;
			FLD_Item_Plus_VK = 0;
			FLD_Item_Exp = 0.0;
			ExpExporll = 0.0;
			KiExporll = 0.0;
			FLD_装备_追加_tam = 0;
			FLD_装备_追加_the = 0;
			FLD_装备_追加_khi = 0;
			FLD_装备_追加_hon = 0;
			FLD_装备_追加_觉醒 = 0;
			base.升天一气功_正本培源 = 0.0;
			base.QiGong_PhanNo = 0.0;
			base.QiGong_BUFF_Dragon = 0.0;
			base.KhiCongTTChung_DameMin = 0.0;
			base.KhiCongTTChung_DameMax = 0.0;
			base.KhiCongTTChung_PhanNo = 0.0;
			base.升天一气功_运气行心 = 0.0;
			base.升天一气功_运气疗伤 = 0.0;
			base.升天一气功_金钟罡气 = 0.0;
			base.弓_升天二气功_千钧压驼 = 1.0;
			base.最少攻击 = 0.0;
			base.连打几率 = 10.0;
			base.致命一击几率 = ((World.Newversion >= 13) ? 0.0 : 10.0);
			base.弓_凝神聚气 = 0.0;
			base.弓箭致命一击几率 = 0.0;
			base.反伤几率 = 0.0;
			base.破甲几率 = 0.0;
			base.武功致命几率 = 0.0;
			base.KCV17_KC7 = 0.0;
			base.刀_暗影绝杀 = 0.0;
			base.韩飞官_天魔狂血 = 0.0;
			base.刀_群攻威力 = 0.0;
			base.Qigong_HBQ6 = 0.0;
			base.刀_升天一气功_遁出逆境 = 0.0;
			base.刀_升天三气功_梵音破镜 = 0.0;
			base.刀_升天三气功_梵音破镜_Plus = 0.0;
			base.KC_QuyenVuong_1 = 0.0;
			base.KC_QuyenVuong_2 = 0.0;
			base.KC_QuyenVuong_3 = 0.0;
			base.剑_护身罡气 = 0.0;
			base.剑_移花接木 = 0.0;
			base.KC_HoiLieuThanPhap = 0.0;
			base.剑_怒海狂澜 = 0.0;
			base.剑_冲冠一怒 = 0.0;
			base.剑_无坚不摧 = 0.0;
			base.剑_升天一气功_乘胜追击 = 0.0;
			base.剑_升天三气功_火凤临朝 = 0.0;
			base.枪_运气疗伤 = 0.0;
			base.枪_灵甲护身 = 0.0;
			base.枪_乾坤挪移 = 0.0;
			base.枪_狂神降世 = 0.0;
			base.枪_转攻为守 = 0.0;
			base.枪_末日狂舞 = 0.0;
			base.KCThuong_TT1_DiemVuongPheNguyet = 0.0;
			base.KCThuong_TT2_SinhTuHuuMenh = 0.0;
			base.枪_升天三气功_怒意之吼 = 0.0;
			base.KCTT_Thuong_130_NoHuyetXungThien_Plus = 0.0;
			base.弓_锐利之箭 = 0.0;
			base.弓_流星三矢 = 10.0;
			base.弓_无明暗矢 = 0.0;
			base.弓_致命绝杀 = 0.0;
			base.弓_心神凝聚 = 10.0;
			base.弓_升天一气功_绝影射魂 = 0.0;
			base.弓_升天三气功_天外三矢 = 0.0;
			base.医_运气疗心 = 0.0;
			base.医_recovery = 0.0;
			base.医_Shutdown = 0.0;
			base.医_长攻击力 = 0.0;
			base.医_吸星大法 = 0.0;
			base.医_太极心法 = 0.0;
			base.医_万物回春 = 0.0;
			base.医_九天真气 = 0.0;
			base.医_天佑之气 = 0.0;
			base.医_升天一气功_狂意护体 = 0.0;
			base.韩飞官_升天一气功 = 0.0;
			base.HBQ_KCTT3_GiamThoiGian = 0.0;
			base.医_升天二气功_无中生有 = 0.0;
			base.医_升天三气功_明镜止水 = 0.0;
			base.KhiCong_HongMinhBienGia = 0.0;
			base.KhiCong_HongNguyetCuongPhong = 0.0;
			base.KhiCong_HuyenToChanMach = 0.0;
			base.KhiCong_LietNhatDiemDiem = 0.0;
			base.KhiCong_ManNguyetCuongPhong = 0.0;
			base.KhiCong_ThanhXaXuatDong = 0.0;
			base.KhiCong_TruongHongQuanThien = 0.0;
			base.KhiCong_VongMaiThiemHoa = 0.0;
			base.KhiCong_JOB11_0 = 0.0;
			base.KhiCong_JOB11_1 = 10.0;
			base.KhiCong_JOB11_4 = 0.0;
			base.KhiCong_JOB11_5 = 0.0;
			base.KhiCong_JOB11_6 = 0.0;
			base.KhiCong_JOB11_7 = 0.0;
			base.KhiCong_JOB11_8 = 0.0;
			base.KhiCong_JOB11_9 = 0.0;
			base.KhiCong_JOB11_10 = 0.0;
			base.KhiCong_JOB11_11 = 0.0;
			base.KhiCong_JOB11_TT1 = 0.0;
			base.KhiCong_JOB11_TT2 = 0.0;
			base.KhiCong_JOB11_TT3 = 0.0;
			base.KhiCong_JOB11_6 = 0.0;
			base.KhiCong_JOB11_10 = 0.0;
			base.KhiCong_JOB11_11 = 0.0;
			base.KhiCong_JOB12_TT1 = 0.0;
			base.KhiCong_JOB12_TT2 = 0.0;
			base.KhiCong_JOB12_TT3 = 0.0;
			base.刺_荆轲之怒 = 0.0;
			base.刺_三花聚顶 = 0.0;
			base.刺_连环飞舞 = 10.0;
			base.刺_必杀一击 = ((World.Newversion >= 13) ? 0.0 : 10.0);
			base.刺_心神凝聚 = 10.0;
			base.刺_致手绝命 = 0.0;
			base.刺_先发制人 = 0.0;
			base.刺_千蛛万手 = 0.0;
			base.刺_连消带打 = 0.0;
			base.刺_剑刃乱舞 = 0.0;
			base.刺_无情打击 = 0.0;
			base.Ninja_KC_130_x2damexanh = 0.0;
			base.KCDHL_HHDP_1 = 0.0;
			base.KCDHL_HHDP_2 = 0.0;
			base.KCTT_140_CHUNG_1 = 0.0;
			base.KCTT_140_CHUNG_2 = 0.0;
			base.KCTT_140_HBQ_1 = 0.0;
			base.KCTT_140_HBQ_2 = 0.0;
			base.KCTT_140_DHL_1 = 0.0;
			base.KCTT_140_DHL_2 = 0.0;
			base.刺_升天二气功_顺水推舟 = 0.0;
			base.刺_升天一气功_夜魔缠身 = 0.0;
			base.刺_升天三气功_以怒还怒 = 0.0;
			base.琴师_高山流水 = 0.0;
			base.琴师_汉宫秋月 = 0.0;
			base.琴师_鸾凤和鸣 = 0.0;
			base.琴师_梅花三弄 = 0.0;
			base.琴师_清心普善 = 0.0;
			base.琴师_秋江夜泊 = 0.0;
			base.琴师_潇湘雨夜 = 0.0;
			base.琴师_阳关三叠 = 0.0;
			base.琴师_阳明春晓 = 0.0;
			base.琴师_岳阳三醉 = 0.0;
			base.琴师_战马奔腾 = 0.0;
			base.琴师_三和弦_发动概率 = 0.0;
			base.琴师_升天一气功_飞花点翠 = 0.0;
			base.琴师_升天二气功_三潭映月 = 0.0;
			base.琴师_升天三气功_子夜秋歌 = 0.0;
			天地同寿回避次数 = 0;
			FLD_攻击速度 = 100;
			潜行模式 = 0;
			爆毒状态 = 0;
			Player_Invisible = 0;
			刺_连消带打数量 = 0.0;
			关起来 = 0;
			升天武功点数 = 0;
			升天历练数 = 0;
			升天历练当前获得数 = 0;
			上河调计数 = 0;
			下河调计数 = 0;
			玉连环计数 = 0;
			Player_HP_Guild = 0;
			Player_MP_Guild = 0;
			武勋追加_HP = 0;
			武勋追加_MP = 0;
			FLD_武勋攻击 = 0;
			FLD_武勋防御 = 0;
			FLD_武勋_追加_气功 = 0;
			奖励_追加_生命 = 0L;
			奖励_追加_攻击 = 0L;
			奖励_追加_回避 = 0;
			奖励_追加_命中 = 0;
			奖励_追加_内功 = 0;
			奖励_追加_防御 = 0L;
			转生次数 = 0;
		}

		public void dllFLD_装备_追加_防具_强化(int i)
		{
			using (new Lock(eval_c, "dllFLD_装备_追加_防具_强化"))
			{
				FLD_Item_Plus_TB -= i;
			}
		}

		public void dllFLD_装备_追加_武器_强化(int i)
		{
			using (new Lock(eval_c, "dllFLD_装备_追加_武器_强化"))
			{
				FLD_Item_Plus_VK -= i;
			}
		}

		public void Del_DEF_Percentage(double i)
		{
			using (new Lock(eval_c, "dllFLD_追加百分比_防御"))
			{
				FLD_追加百分比_防御 -= i;
			}
		}

		public void Del_ATT_Percentage(double i)
		{
			using (new Lock(eval_c, "dllFLD_追加百分比_攻击"))
			{
				FLD_追加百分比_攻击 -= i;
			}
		}

		public void Del_DEF_Percentage_PN(double i)
		{
			FLD_追加百分比_防御_PHANNO = 0.0;
		}

		public void Del_ATT_Percentage_PN(double i)
		{
			FLD_追加百分比_攻击_PHANNO = 0.0;
		}

		public void Add_DEF_Percentage_PN(double i)
		{
			FLD_追加百分比_防御_PHANNO = i;
		}

		public void Add_ATT_Percentage_PN(double i)
		{
			FLD_追加百分比_攻击_PHANNO = i;
		}

		private void 转职属性(int value)
		{
			if (value != 0)
			{
				TransferAttributes value2 = new TransferAttributes().GetValue(value);
				FLD_Attack += value2.FLD_AT;
				FLD_Defense += value2.FLD_DF;
				人物基本最大_HP += value2.FLD_HP;
				人物基本最大_MP += value2.FLD_MP;
			}
		}

		private int GetQigongID(int index)
		{
			if (index >= 12)
			{
				return 0;
			}
			if (World.Newversion >= 13)
			{
				if (Player_Job == 1)
				{
					switch (index)
					{
					case 0:
						return 10;
					case 1:
						return 11;
					case 2:
						return 12;
					case 3:
						return 14;
					case 4:
						return 19;
					case 5:
						return 16;
					case 6:
						return 180 + Player_Job;
					case 7:
						return 17;
					case 8:
						return 15;
					case 9:
						return 18;
					case 10:
						return 312;
					case 11:
						return 110;
					}
				}
				else if (Player_Job == 2)
				{
					switch (index)
					{
					case 0:
						return 20;
					case 1:
						return 21;
					case 2:
						return 22;
					case 3:
						return 23;
					case 4:
						return 24;
					case 5:
						return 26;
					case 6:
						return 180 + Player_Job;
					case 7:
						return 28;
					case 8:
						return 27;
					case 9:
						return 120;
					case 10:
						return 320;
					case 11:
						return 29;
					}
				}
				else if (Player_Job == 3)
				{
					switch (index)
					{
					case 0:
						return 30;
					case 1:
						return 31;
					case 2:
						return 32;
					case 3:
						return 34;
					case 4:
						return 35;
					case 5:
						return 39;
					case 6:
						return 180 + Player_Job;
					case 7:
						return 38;
					case 8:
						return 36;
					case 9:
						return 130;
					case 10:
						return 332;
					case 11:
						return 37;
					}
				}
				else if (Player_Job == 4)
				{
					switch (index)
					{
					case 0:
						return 40;
					case 1:
						return 41;
					case 2:
						return 42;
					case 3:
						return 44;
					case 4:
						return 45;
					case 5:
						return 48;
					case 6:
						return 180 + Player_Job;
					case 7:
						return 46;
					case 8:
						return 47;
					case 9:
						return 43;
					case 10:
						return 49;
					case 11:
						return 140;
					}
				}
				else if (Player_Job == 5)
				{
					switch (index)
					{
					case 0:
						return 50;
					case 1:
						return 51;
					case 2:
						return 52;
					case 3:
						return 53;
					case 4:
						return 54;
					case 5:
						return 55;
					case 6:
						return 180 + Player_Job;
					case 7:
						return 57;
					case 8:
						return 56;
					case 9:
						return 350;
					case 10:
						return 351;
					case 11:
						return 59;
					}
				}
				else if (Player_Job == 6)
				{
					switch (index)
					{
					case 0:
						return 70;
					case 1:
						return 71;
					case 2:
						return 72;
					case 3:
						return 74;
					case 4:
						return 75;
					case 5:
						return 372;
					case 6:
						return 180 + Player_Job;
					case 7:
						return 76;
					case 8:
						return 77;
					case 9:
						return 78;
					case 10:
						return 79;
					case 11:
						return 73;
					}
				}
				else if (Player_Job == 7)
				{
					switch (index)
					{
					case 0:
						return 80;
					case 1:
						return 81;
					case 2:
						return 82;
					case 3:
						return 83;
					case 4:
						return 84;
					case 5:
						return 85;
					case 6:
						return 180 + Player_Job;
					case 7:
						return 86;
					case 8:
						return 87;
					case 9:
						return 88;
					case 10:
						return 89;
					case 11:
						return 180;
					}
				}
				else if (Player_Job == 8)
				{
					switch (index)
					{
					case 0:
						return 250;
					case 1:
						return 251;
					case 2:
						return 253;
					case 3:
						return 254;
					case 4:
						return 252;
					case 5:
						return 255;
					case 6:
						return 180 + Player_Job;
					case 7:
						return 256;
					case 8:
						return 257;
					case 9:
						return 259;
					case 10:
						return 260;
					case 11:
						return 258;
					}
				}
				else if (Player_Job == 9)
				{
					switch (index)
					{
					case 0:
						return 270;
					case 1:
						return 271;
					case 2:
						return 272;
					case 3:
						return 273;
					case 4:
						return 274;
					case 5:
						return 275;
					case 6:
						return 180 + Player_Job;
					case 7:
						return 276;
					case 8:
						return 277;
					case 9:
						return 278;
					case 10:
						return 279;
					case 11:
						return 280;
					}
				}
				else if (Player_Job == 10)
				{
					switch (index)
					{
					case 0:
						return 550;
					case 1:
						return 551;
					case 2:
						return 552;
					case 3:
						return 553;
					case 4:
						return 558;
					case 5:
						return 559;
					case 6:
						return 180 + Player_Job;
					case 7:
						return 556;
					case 8:
						return 554;
					case 9:
						return 555;
					case 10:
						return 557;
					case 11:
						return 560;
					}
				}
				else if (Player_Job == 11)
				{
					switch (index)
					{
					case 0:
						return 650;
					case 1:
						return 651;
					case 2:
						return 653;
					case 3:
						return 654;
					case 4:
						return 656;
					case 5:
						return 657;
					case 6:
						return 180 + Player_Job;
					case 7:
						return 658;
					case 8:
						return 659;
					case 9:
						return 660;
					case 10:
						return 661;
					case 11:
						return 318;
					}
				}
				else if (Player_Job == 12)
				{
					switch (index)
					{
					case 0:
						return 281;
					case 1:
						return 282;
					case 2:
						return 283;
					case 3:
						return 284;
					case 4:
						return 285;
					case 5:
						return 287;
					case 6:
						return 180 + Player_Job;
					case 7:
						return 286;
					case 8:
						return 288;
					case 9:
						return 289;
					case 10:
						return 290;
					case 11:
						return 291;
					}
				}
				return 0;
			}
			if (Player_Job == 10)
			{
				return 550 + index;
			}
			if (Player_Job == 9)
			{
				return 270 + index;
			}
			if (index >= 10)
			{
				if (Player_Job == 8)
				{
					return Player_Job * 10 + 170 + 10;
				}
				if (Player_Job == 7)
				{
					return Player_Job * 10 + 100 + 10;
				}
				if (Player_Job == 6)
				{
					return Player_Job * 10 + 100 + 10;
				}
				return Player_Job * 10 + 100;
			}
			if (Player_Job == 8)
			{
				if (index == 6)
				{
					return 16;
				}
				return index + 10 * Player_Job + 170;
			}
			if (Player_Job == 7)
			{
				return index + 10 * Player_Job + 10;
			}
			if (Player_Job == 6)
			{
				return index + 10 * Player_Job + 10;
			}
			return index + 10 * Player_Job;
		}

		~PlayersBes()
		{
		}

		public byte[] Get_在线时间()
		{
			return _总在线时间;
		}

		public byte[] GetFLD_ITEMCodesbyte()
		{
			byte[] array = new byte[((World.Newversion >= 14) ? 76 : 73) * 66];
			try
			{
				for (int i = 0; i < 66; i++)
				{
					try
					{
						Buffer.BlockCopy(Item_In_Bag[i].Byte_Item, 0, array, i * ((World.Newversion >= 14) ? 76 : 73), (World.Newversion >= 14) ? 76 : 73);
					}
					catch
					{
						byte[] src = new byte[(World.Newversion >= 14) ? 76 : 73];
						Buffer.BlockCopy(src, 0, array, i * ((World.Newversion >= 14) ? 76 : 73), (World.Newversion >= 14) ? 76 : 73);
					}
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_GetFLD_ITEMCodesbyte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return array;
		}

		public byte[] GetFLD_NTCITEMCodesbyte()
		{
			byte[] array = new byte[((World.Newversion >= 14) ? 76 : 73) * 6];
			try
			{
				for (int i = 0; i < 6; i++)
				{
					try
					{
						Buffer.BlockCopy(Item_NTC[i].Byte_Item, 0, array, i * ((World.Newversion >= 14) ? 76 : 73), (World.Newversion >= 14) ? 76 : 73);
					}
					catch
					{
						byte[] src = new byte[(World.Newversion >= 14) ? 76 : 73];
						Buffer.BlockCopy(src, 0, array, i * ((World.Newversion >= 14) ? 76 : 73), (World.Newversion >= 14) ? 76 : 73);
					}
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_GetFLD_NTCITEMCodesbyte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return array;
		}

		public byte[] GetFLD_COATITEMCodesbyte()
		{
			byte[] array = new byte[((World.Newversion >= 14) ? 76 : 73) * 60];
			try
			{
				for (int i = 0; i < 60; i++)
				{
					try
					{
						Buffer.BlockCopy(Item_Coat[i].Byte_Item, 0, array, i * ((World.Newversion >= 14) ? 76 : 73), (World.Newversion >= 14) ? 76 : 73);
					}
					catch
					{
						byte[] src = new byte[(World.Newversion >= 14) ? 76 : 73];
						Buffer.BlockCopy(src, 0, array, i * ((World.Newversion >= 14) ? 76 : 73), (World.Newversion >= 14) ? 76 : 73);
					}
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_GetFLD_COATITEMCodesbyte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return array;
		}

		public byte[] GetFLD_KONGFUCodesbyte()
		{
			PacketData packetData = new PacketData();
			try
			{
				for (int i = 0; i < 3; i++)
				{
					for (int j = 0; j < 32; j++)
					{
						if (Array_Skill_Book[i, j] != null)
						{
							packetData.WriteInt(Array_Skill_Book[i, j].FLD_PID);
							packetData.WriteShort(Array_Skill_Book[i, j].武功_等级);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_GetFLD_KONGFUCodesbyte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return packetData.ToArray3();
		}

		public byte[] GetQuestITEMCodesbyte()
		{
			byte[] array = new byte[288];
			try
			{
				for (int i = 0; i < 36; i++)
				{
					try
					{
						Buffer.BlockCopy(Quest_Item[i].物品_byte, 0, array, i * 8, 8);
					}
					catch
					{
						byte[] src = new byte[8];
						Buffer.BlockCopy(src, 0, array, i * 8, 8);
					}
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错GetQuestITEMCodesbyte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return array;
		}

		public byte[] GetWEARITEMCodesbyte()
		{
			byte[] array = new byte[16 * ((World.Newversion >= 14) ? 76 : 73)];
			try
			{
				for (int i = 0; i < 16; i++)
				{
					try
					{
						Buffer.BlockCopy(Item_Wear[i].Byte_Item, 0, array, i * ((World.Newversion >= 14) ? 76 : 73), (World.Newversion >= 14) ? 76 : 73);
					}
					catch
					{
						byte[] src = new byte[(World.Newversion >= 14) ? 76 : 73];
						Buffer.BlockCopy(src, 0, array, i * ((World.Newversion >= 14) ? 76 : 73), (World.Newversion >= 14) ? 76 : 73);
					}
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_GetWEARITEMCodesbyte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return array;
		}

		public byte[] GetWgCodesbyte()
		{
			byte[] array = new byte[20];
			try
			{
				for (int i = 0; i < 12; i++)
				{
					byte[] src;
					try
					{
						src = 气功[i].气功_byte;
					}
					catch
					{
						src = new byte[2];
					}
					Buffer.BlockCopy(src, 0, array, i, 1);
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_GetWgCodesbyte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return array;
		}

		public byte[] Get个人仓库byte()
		{
			byte[] array = new byte[60 * ((World.Newversion >= 14) ? 76 : 73)];
			try
			{
				for (int i = 0; i < 60; i++)
				{
					try
					{
						Buffer.BlockCopy(个人仓库[i].Byte_Item, 0, array, i * ((World.Newversion >= 14) ? 76 : 73), (World.Newversion >= 14) ? 76 : 73);
					}
					catch
					{
						byte[] src = new byte[(World.Newversion >= 14) ? 76 : 73];
						Buffer.BlockCopy(src, 0, array, i * ((World.Newversion >= 14) ? 76 : 73), (World.Newversion >= 14) ? 76 : 73);
					}
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get个人仓库byte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return array;
		}

		public byte[] Get个人药品byte()
		{
			int num = 0;
			byte[] array = new byte[320];
			try
			{
				foreach (Class_Show_Pill value in Show_Pic_Class.Values)
				{
					if (value.FLD_RESIDE1 == 1)
					{
						Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_PID), 0, array, num * 8, 4);
						Buffer.BlockCopy(BitConverter.GetBytes((int)value.FLD_sj), 0, array, num * 8 + 4, 4);
						num++;
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get个人药品byte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return array;
		}

		public byte[] Get个人药品Newbyte()
		{
			int num = 0;
			byte[] array = new byte[320];
			try
			{
				foreach (追加状态New类 value in 追加状态New列表.Values)
				{
					Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_PID), 0, array, num * 16, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_sj), 0, array, num * 16 + 4, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(value.数量), 0, array, num * 16 + 8, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(value.数量类型), 0, array, num * 16 + 12, 4);
					num++;
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get个人药品Newbyte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return array;
		}

		public byte[] Get时间药品Newbyte()
		{
			int num = 0;
			byte[] array = new byte[320];
			try
			{
				foreach (时间药品 value in list_时间药品.Values)
				{
					Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_PID), 0, array, num * 8, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(value.FLD_sj), 0, array, num * 8 + 4, 4);
					num++;
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get时间药品byte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return array;
		}

		public byte[] Get任务byte()
		{
			PacketData packetData = new PacketData();
			try
			{
				foreach (任务类 value in 任务.Values)
				{
					packetData.WriteShort(value.任务ID);
					packetData.WriteShort(value.任务阶段ID);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get任务byte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return packetData.ToArray3();
		}

		public byte[] Get升天气功Codesbyte()
		{
			PacketData packetData = new PacketData();
			try
			{
				foreach (升天气功类 value in 升天气功.Values)
				{
					packetData.WriteShort(value.气功ID);
					packetData.WriteShort(value.气功量);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get升天气功odesbyte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return packetData.ToArray3();
		}

		public byte[] Get升天武功Codesbyte()
		{
			PacketData packetData = new PacketData();
			try
			{
				for (int i = 0; i < 32; i++)
				{
					if (Array_Skill_Book[3, i] != null && !disable_Skill_List.Contains(Array_Skill_Book[3, i].FLD_PID))
					{
						packetData.WriteInt(Array_Skill_Book[3, i].FLD_PID);
						if (!disable_Skill_List.Contains(Array_Skill_Book[3, i].FLD_PID))
						{
							packetData.WriteInt(Array_Skill_Book[3, i].武功_等级);
						}
						else
						{
							packetData.WriteInt(0);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get升天武功Codesbyte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return packetData.ToArray3();
		}

		public byte[] Get土灵符byte()
		{
			byte[] array = new byte[990];
			try
			{
				foreach (DictionaryEntry item in 土灵符坐标)
				{
					坐标Class 坐标Class = (坐标Class)item.Value;
					int num = (int)item.Key;
					if (num >= 10)
					{
						Buffer.BlockCopy(Encoding.GetEncoding(1252).GetBytes(坐标Class.Rxjh_Name), 0, array, (num - 10) * 32, Encoding.GetEncoding(1252).GetBytes(坐标Class.Rxjh_Name).Length);
						Buffer.BlockCopy(BitConverter.GetBytes(坐标Class.Rxjh_Map), 0, array, (num - 10) * 32 + 15, 4);
						Buffer.BlockCopy(BitConverter.GetBytes(坐标Class.Rxjh_X), 0, array, (num - 10) * 32 + 19, 4);
						Buffer.BlockCopy(BitConverter.GetBytes(坐标Class.Rxjh_Y), 0, array, (num - 10) * 32 + 23, 4);
						Buffer.BlockCopy(BitConverter.GetBytes(坐标Class.Rxjh_Z), 0, array, (num - 10) * 32 + 27, 4);
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get土灵符byte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return array;
		}

		public byte[] Get综合仓库byte()
		{
			byte[] array = new byte[60 * ((World.Newversion >= 14) ? 76 : 73)];
			try
			{
				for (int i = 0; i < 60; i++)
				{
					try
					{
						Buffer.BlockCopy(公共仓库[i].Byte_Item, 0, array, i * ((World.Newversion >= 14) ? 76 : 73), (World.Newversion >= 14) ? 76 : 73);
					}
					catch
					{
						byte[] src = new byte[(World.Newversion >= 14) ? 76 : 73];
						Buffer.BlockCopy(src, 0, array, i * ((World.Newversion >= 14) ? 76 : 73), (World.Newversion >= 14) ? 76 : 73);
					}
				}
				return array;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get综合仓库byte[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
			return array;
		}

		public byte[] Get综合仓库品byte()
		{
			byte[] array = new byte[16];
			try
			{
				int num = 0;
				foreach (公有药品类 value in 公有药品.Values)
				{
					Buffer.BlockCopy(BitConverter.GetBytes(value.药品ID), 0, array, num * 8, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(value.时间), 0, array, num * 8 + 4, 4);
					num++;
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错_Get综合仓库品byte[" + Userid + "]-[" + UserName + "][" + 公有药品.Count + "]" + ex.Message);
			}
			return array;
		}

		public void sjts()
		{
			string hex = "AA552F00010F2713222000020001000A000000010000000E00000001000000010000000000000000000000000000000000604C55AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 帮派传送符提示(int id)
		{
			string hex = "AA55230001D001121614000106000078DC143C010000000100000009943577000000000000A65455AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(id), 0, array, 19, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 保存个人仓库存储过程()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "PlayersBes_保存个人仓库存储过程()");
			}
			try
			{
				SqlParameter[] prams = new SqlParameter[4]
				{
					SqlDBA.MakeInParam("@id", SqlDbType.VarChar, 20, Userid),
					SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 20, UserName),
					SqlDBA.MakeInParam("@money", SqlDbType.VarChar, 0, 个人仓库钱数),
					SqlDBA.MakeInParam("@strItem", SqlDbType.VarBinary, 60 * ((World.Newversion >= 14) ? 76 : 73), Get个人仓库byte())
				};
				DbPoolClass dbPoolClass = new DbPoolClass();
				dbPoolClass.Conn = DBA.getstrConnection(null);
				dbPoolClass.Prams = prams;
				dbPoolClass.Sql = "XWWL_UPDATE_USER_Warehouse";
				World.SqlPool.Enqueue(dbPoolClass);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存个人仓库数据出错[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
		}

		public void 保存会员数据()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("UPDATE TBL_ACCOUNT SET FLD_VIP={1},FLD_VIPTIM='{2}' WHERE FLD_ID='{0}'", Userid, 1, FLD_VIPTIM);
			if (DBA.ExeSqlCommand(stringBuilder.ToString(), "rxjhaccount") == -1)
			{
				Form1.WriteLine(1, "保存ID 会员 数据出错[" + Userid + "]-[" + UserName + "]");
			}
		}

		public void SaveDataCharacter()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "PlayersBes_保存人物的数据()");
			}
			try
			{
				if (UserName != "")
				{
					if (Pet != null)
					{
						Pet.保存数据();
					}
					保存人物数据存储过程();
					保存个人仓库存储过程();
					保存综合仓库存储过程();
					if (Guild_ID != 0)
					{
						StringBuilder stringBuilder = new StringBuilder();
						stringBuilder.AppendFormat("UPDATE TBL_XWWL_GuildMember SET FLD_LEVEL = @zw WHERE Name = @Username");
						SqlParameter[] prams = new SqlParameter[2]
						{
							SqlDBA.MakeInParam("@zw", SqlDbType.Int, 0, Player_Level),
							SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, UserName)
						};
						if (DBA.ExeSqlCommand(stringBuilder.ToString(), prams) == -1)
						{
							Form1.WriteLine(3, "保存人物帮派等级数据出错[" + Userid + "]-[" + UserName + "]");
						}
					}
					存档时间 = true;
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存的数据出错[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
		}

		public void 保存人物数据存储过程()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "PlayersBes_保存人物数据存储过程()");
			}
			try
			{
				SqlParameter[] prams = new SqlParameter[74]
				{
					SqlDBA.MakeInParam("@id", SqlDbType.VarChar, 20, Userid),
					SqlDBA.MakeInParam("@name", SqlDbType.VarChar, 20, UserName),
					SqlDBA.MakeInParam("@level", SqlDbType.Int, 0, Player_Level),
					SqlDBA.MakeInParam("@strFace", SqlDbType.VarBinary, 10, Player_Style.PlayerStyle_byte),
					SqlDBA.MakeInParam("@job", SqlDbType.Int, 0, Player_Job),
					SqlDBA.MakeInParam("@exp", SqlDbType.VarChar, 50, Player_FLD_EXP),
					SqlDBA.MakeInParam("@zx", SqlDbType.Int, 0, Player_Zx),
					SqlDBA.MakeInParam("@job_level", SqlDbType.Int, 0, Player_Job_Level),
					SqlDBA.MakeInParam("@x", SqlDbType.Float, 0, Player_FLD_X),
					SqlDBA.MakeInParam("@y", SqlDbType.Float, 0, Player_FLD_Y),
					SqlDBA.MakeInParam("@z", SqlDbType.Float, 0, Player_FLD_Z),
					SqlDBA.MakeInParam("@menow", SqlDbType.Int, 0, Player_FLD_Map),
					SqlDBA.MakeInParam("@money", SqlDbType.VarChar, 50, Player_Money),
					SqlDBA.MakeInParam("@hp", SqlDbType.Int, 0, Player_FLD_HP),
					SqlDBA.MakeInParam("@mp", SqlDbType.Int, 0, Player_FLD_MP),
					SqlDBA.MakeInParam("@sp", SqlDbType.Int, 0, 人物_SP),
					SqlDBA.MakeInParam("@wx", SqlDbType.Int, 0, Player_WuXun),
					SqlDBA.MakeInParam("@se", SqlDbType.Int, 0, Player_FLD_SE),
					SqlDBA.MakeInParam("@point", SqlDbType.VarChar, 0, Player_Qigong_point),
					SqlDBA.MakeInParam("@strSkills", SqlDbType.VarBinary, 20, GetWgCodesbyte()),
					SqlDBA.MakeInParam("@strWearitem", SqlDbType.VarBinary, ((World.Newversion >= 14) ? 76 : 73) * 16, GetWEARITEMCodesbyte()),
					SqlDBA.MakeInParam("@strItem", SqlDbType.VarBinary, ((World.Newversion >= 14) ? 76 : 73) * 66, GetFLD_ITEMCodesbyte()),
					SqlDBA.MakeInParam("@strQuestItem", SqlDbType.VarBinary, 300, GetQuestITEMCodesbyte()),
					SqlDBA.MakeInParam("@strNTCItem", SqlDbType.VarBinary, ((World.Newversion >= 14) ? 76 : 73) * 6, GetFLD_NTCITEMCodesbyte()),
					SqlDBA.MakeInParam("@strCoatItem", SqlDbType.VarBinary, ((World.Newversion >= 14) ? 76 : 73) * 60, GetFLD_COATITEMCodesbyte()),
					SqlDBA.MakeInParam("@strKongfu", SqlDbType.VarBinary, 624, GetFLD_KONGFUCodesbyte()),
					SqlDBA.MakeInParam("@strCtime", SqlDbType.VarBinary, 320, Get个人药品byte()),
					SqlDBA.MakeInParam("@strDoors", SqlDbType.VarBinary, 1200, Get土灵符byte()),
					SqlDBA.MakeInParam("@strQuest", SqlDbType.VarBinary, 1200, Get任务byte()),
					SqlDBA.MakeInParam("@fight_exp", SqlDbType.Int, 0, Player_ExpErience),
					SqlDBA.MakeInParam("@rwqg", SqlDbType.Int, 0, 人物轻功),
					SqlDBA.MakeInParam("@NameType", SqlDbType.VarBinary, 48, NameType),
					SqlDBA.MakeInParam("@zbver", SqlDbType.Int, 0, 装备数据版本),
					SqlDBA.MakeInParam("@zzlx", SqlDbType.Int, 0, Craft_Type),
					SqlDBA.MakeInParam("@zzsld", SqlDbType.Int, 0, Craft_Level),
					SqlDBA.MakeInParam("@strStime", SqlDbType.VarBinary, 320, Get时间药品Newbyte()),
					SqlDBA.MakeInParam("@strCtimeNew", SqlDbType.VarBinary, 320, Get个人药品Newbyte()),
					SqlDBA.MakeInParam("@qlname", SqlDbType.VarChar, 20, FLD_Couple_Name),
					SqlDBA.MakeInParam("@qljzname", SqlDbType.VarChar, 0, FLD_Couple_Name_Unknow),
					SqlDBA.MakeInParam("@qlaqd", SqlDbType.Int, 0, FLD_Couple_Exp),
					SqlDBA.MakeInParam("@qlaqdmax", SqlDbType.Int, 0, FLD_Couple_ExpMax),
					SqlDBA.MakeInParam("@qlrank", SqlDbType.Int, 0, FLD_Couple_Level),
					SqlDBA.MakeInParam("@strStSkills", SqlDbType.VarBinary, 64, Get升天气功Codesbyte()),
					SqlDBA.MakeInParam("@strStKongfu", SqlDbType.VarBinary, 144, Get升天武功Codesbyte()),
					SqlDBA.MakeInParam("@stlilian", SqlDbType.Int, 0, 升天历练数),
					SqlDBA.MakeInParam("@stwugongdian", SqlDbType.Int, 0, 升天武功点数),
					SqlDBA.MakeInParam("@addhp", SqlDbType.Int, 0, 奖励_追加_生命),
					SqlDBA.MakeInParam("@addat", SqlDbType.Int, 0, 奖励_追加_攻击),
					SqlDBA.MakeInParam("@adddf", SqlDbType.Int, 0, 奖励_追加_防御),
					SqlDBA.MakeInParam("@addhb", SqlDbType.Int, 0, 奖励_追加_回避),
					SqlDBA.MakeInParam("@addmp", SqlDbType.Int, 0, 奖励_追加_内功),
					SqlDBA.MakeInParam("@addmz", SqlDbType.Int, 0, 奖励_追加_命中),
					SqlDBA.MakeInParam("@zs", SqlDbType.Int, 0, 转生次数),
					SqlDBA.MakeInParam("@getvipdj", SqlDbType.Int, 0, 会员等级),
					SqlDBA.MakeInParam("@在线时间", SqlDbType.VarBinary, 200, Get_在线时间()),
					SqlDBA.MakeInParam("@getwx", SqlDbType.Int, 0, 每日武勋),
					SqlDBA.MakeInParam("@FLD_七彩", SqlDbType.Int, 0, FLD_MetMoi),
					SqlDBA.MakeInParam("@vipat", SqlDbType.Int, 0, 0),
					SqlDBA.MakeInParam("@vipdf", SqlDbType.Int, 0, 0),
					SqlDBA.MakeInParam("@viphp", SqlDbType.Int, 0, 0),
					SqlDBA.MakeInParam("@viplevel", SqlDbType.Int, 0, 0),
					SqlDBA.MakeInParam("@zscs", SqlDbType.Int, 0, 转生次数),
					SqlDBA.MakeInParam("@sjjl", SqlDbType.Int, 0, 0),
					SqlDBA.MakeInParam("@zxsj", SqlDbType.Float, 0, 0),
					SqlDBA.MakeInParam("@zxdj", SqlDbType.Float, 0, 0),
					SqlDBA.MakeInParam("@rwdj", SqlDbType.Float, 0, 0),
					SqlDBA.MakeInParam("@stsf", SqlDbType.VarChar, 0, FLD_Teacher),
					SqlDBA.MakeInParam("@sttd1", SqlDbType.VarChar, 0, FLD_Student1),
					SqlDBA.MakeInParam("@sttd2", SqlDbType.VarChar, 0, FLD_Student2),
					SqlDBA.MakeInParam("@sttd3", SqlDbType.VarChar, 0, FLD_Student3),
					SqlDBA.MakeInParam("@stwg1_1", SqlDbType.Int, 0, FLD_师徒_武功ID1_1),
					SqlDBA.MakeInParam("@stwg1_2", SqlDbType.Int, 0, FLD_师徒_武功ID1_2),
					SqlDBA.MakeInParam("@stwg1_3", SqlDbType.Int, 0, FLD_师徒_武功ID1_3),
					SqlDBA.MakeInParam("@dayquest", SqlDbType.VarChar, 1200, FLD_DayQuest_Array)
				};
				DbPoolClass dbPoolClass = new DbPoolClass();
				dbPoolClass.Conn = DBA.getstrConnection(null);
				dbPoolClass.Prams = prams;
				dbPoolClass.Sql = "XWWL_UPDATE_USER_DATA_NEW";
				World.SqlPool.Enqueue(dbPoolClass);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存人物数据出错[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
		}

		public void Save_data_Rxpiont()
		{
			try
			{
				SqlParameter[] prams = new SqlParameter[3]
				{
					SqlDBA.MakeInParam("@id", SqlDbType.VarChar, 20, Userid),
					SqlDBA.MakeInParam("@rxpiont", SqlDbType.Int, 0, FLD_RXPIONT),
					SqlDBA.MakeInParam("@rxpiontx", SqlDbType.Int, 0, FLD_RXPIONTX)
				};
				DbPoolClass dbPoolClass = new DbPoolClass();
				dbPoolClass.Conn = DBA.getstrConnection("rxjhaccount");
				dbPoolClass.Prams = prams;
				dbPoolClass.Sql = "XWWL_UPDATE_RXOIONT";
				World.SqlPool.Enqueue(dbPoolClass);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存ID 元宝 数据出错[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
		}

		public void 保存综合仓库存储过程()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "PlayersBes_保存综合仓库存储过程()");
			}
			try
			{
				SqlParameter[] prams = new SqlParameter[5]
				{
					SqlDBA.MakeInParam("@id", SqlDbType.VarChar, 20, Userid),
					SqlDBA.MakeInParam("@money", SqlDbType.VarChar, 0, 综合仓库钱数),
					SqlDBA.MakeInParam("@strItem", SqlDbType.VarBinary, 60 * ((World.Newversion >= 14) ? 76 : 73), Get综合仓库byte()),
					SqlDBA.MakeInParam("@strItime", SqlDbType.VarBinary, 50, Get综合仓库品byte()),
					SqlDBA.MakeInParam("@zbver", SqlDbType.Int, 0, 综合仓库装备数据版本)
				};
				DbPoolClass dbPoolClass = new DbPoolClass();
				dbPoolClass.Conn = DBA.getstrConnection(null);
				dbPoolClass.Prams = prams;
				dbPoolClass.Sql = "XWWL_UPDATE_ID_Warehouse";
				World.SqlPool.Enqueue(dbPoolClass);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "保存个人仓库数据出错[" + Userid + "]-[" + UserName + "]" + ex.Message);
			}
		}

		public void 初始话气功()
		{
			PacketData packetData = new PacketData();
			packetData.WriteShort(100);
			packetData.WriteShort(15213);
			packetData.WriteInt(0);
			packetData.WriteShort(60);
			packetData.WriteShort(3700);
			packetData.WriteShort(0);
			for (int i = 0; i < 15; i++)
			{
				if (i < 12)
				{
					int 气功ID = 气功[i].气功ID;
					packetData.WriteShort(气功ID);
					if (气功[i].气功ID != 0)
					{
						if (气功[i].气功量 != 0)
						{
							int num = 气功[i].气功量 + FLD_Item_Level_Pran + Character_Qigong + FLD_武勋_追加_气功 + flowerEffectQigong + FLD_斗神_追加_气功;
							if (num != 0 && num > World.最大气功数)
							{
								num = World.最大气功数;
							}
							packetData.WriteShort(num);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					else
					{
						packetData.WriteShort(0);
					}
				}
				else
				{
					packetData.WriteInt(0);
				}
			}
			packetData.WriteShort(0);
			packetData.WriteShort(65520);
			packetData.WriteShort(7);
			packetData.WriteInt(0);
			if (Client != null)
			{
				Client.SendPak(packetData, 27648, UserSessionID);
			}
		}

		public void Initialize_Equip_Item()
		{
			if (World.Newversion >= 13)
			{
				try
				{
					PacketData packetData = new PacketData();
					packetData.WriteInt(1);
					packetData.WriteInt(UserSessionID);
					packetData.WriteString(UserName);
					packetData.WriteByte(0);
					if (Guild_ID != 0)
					{
						packetData.WriteInt(Guild_ID);
						packetData.WriteString(Guild_Name);
						packetData.WriteByte(0);
						packetData.WriteByte(Guild_Level);
						if (Guild_Icon != null)
						{
							packetData.WriteByte(World.Server_Group_ID);
						}
						else
						{
							packetData.WriteByte(0);
						}
					}
					else
					{
						packetData.WriteInt(0);
						packetData.WriteString("");
						packetData.WriteByte(0);
						packetData.WriteByte(0);
						packetData.WriteByte(0);
					}
					packetData.WriteShort(Player_Zx);
					packetData.WriteShort(Player_Level);
					packetData.WriteShort(Player_Job_Level);
					packetData.WriteShort(Player_Job);
					packetData.WriteShort(Player_Style.Hair_Color);
					packetData.WriteShort(Player_Style.Hair_Style);
					packetData.WriteShort(Player_Style.Sex);
					packetData.WriteFloat(Player_FLD_X);
					packetData.WriteFloat(Player_FLD_Z);
					packetData.WriteFloat(Player_FLD_Y);
					packetData.WriteInt(Player_FLD_Map);
					packetData.WriteInt(0);
					packetData.WriteInt(0);
					packetData.WriteInt(0);
					packetData.Write(NameType, 0, 48);
					packetData.WriteInt(0);
					for (int i = 0; i < 30; i++)
					{
						if (i < 15)
						{
							if (BitConverter.ToInt32(Item_Wear[i].Item_Amount, 0) == 0)
							{
								Item_Wear[i].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
							}
							else
							{
								检查物品系统("装备栏以穿装备", ref Item_Wear[i]);
							}
							if (Item_Wear[i].FLD_FJ_中级附魂 <= 22 && Item_Wear[i].FLD_FJ_中级附魂 >= 21 && Item_Wear[i].FLD_FJ_觉醒 > 0)
							{
								Item_Wear[i].物品_中级附魂_追加_觉醒 = Item_Wear[i].FLD_FJ_中级附魂 - 20;
							}
							packetData.Write(Item_Wear[i].GetByte(), 0, World.单个物品大小);
						}
						else
						{
							packetData.Write(new byte[World.单个物品大小], 0, World.单个物品大小);
						}
					}
					packetData.Write(Item_Wear[15].GetByte(), 0, World.单个物品大小);
					packetData.Write(new byte[World.单个物品大小], 0, World.单个物品大小);
					if (Client != null)
					{
						Client.SendPak(packetData, 40960, UserSessionID);
					}
				}
				catch (Exception ex)
				{
					Form1.WriteLine(1, "初始话已装备物品出错[" + Userid + "]-[" + UserName + "]" + ex.Message);
				}
			}
			else
			{
				try
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append("AA55E70A002C01A000D80A010000006F05000000000000000000000000000000000000000000000000000000000000000000000000000000C302004700030003010200010001010000884100007041000018C2B10400000100F5A302000100000000000000000000000000FFFFFFFFFFFFFFFF0100000000000000FFFFFFFFFFFFFFFF0200000000000000FFFFFFFFFFFFFFFF942D50652865CD0F37D57E1200000000010000008B0ACC3CA0778E069E778E069A778E06A6778E060000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000008283783E82C8CC0F18F707000000000001000000032D3101A8778E06A8778E06A8778E06A8778E060000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001025011F224CCD0F18F707000000000001000000032D3101A8778E06A6778E06A8778E06A6778E06000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000841D8A6D9021D00F4806E51100000000010000008479333C991D2C04991D2C04991D2C04991D2C04000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000C869E17D2766CC0FF98A0C000000000001000000042D3101A8778E06A8778E06A8778E06A8778E060000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000009803682D1323D00FA6680600000000000100000000000000A8778E0600000000A8778E060000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000010000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
					byte[] array = Converter.hexStringToByte(stringBuilder.ToString());
					byte[] bytes = Encoding.GetEncoding(1252).GetBytes(UserName);
					Buffer.BlockCopy(bytes, 0, array, 19, bytes.Length);
					Buffer.BlockCopy(BitConverter.GetBytes(Player_FLD_X), 0, array, 71, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(Player_FLD_Z), 0, array, 75, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(Player_FLD_Y), 0, array, 79, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(Player_FLD_Map), 0, array, 83, 2);
					Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
					Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 15, 2);
					Buffer.BlockCopy(BitConverter.GetBytes(Player_Zx), 0, array, 57, 1);
					Buffer.BlockCopy(BitConverter.GetBytes(Player_Level), 0, array, 59, 1);
					Buffer.BlockCopy(BitConverter.GetBytes(Player_Job_Level), 0, array, 61, 1);
					Buffer.BlockCopy(BitConverter.GetBytes(Player_Job), 0, array, 63, 1);
					if (Guild_ID != 0)
					{
						byte[] bytes2 = BitConverter.GetBytes(Guild_ID);
						Buffer.BlockCopy(bytes2, 0, array, 35, bytes2.Length);
						byte[] bytes3 = Encoding.GetEncoding(1252).GetBytes(Guild_Name);
						Buffer.BlockCopy(bytes3, 0, array, 39, bytes3.Length);
						Buffer.BlockCopy(BitConverter.GetBytes(Guild_Level), 0, array, 54, 1);
						if (Guild_Icon != null)
						{
							Buffer.BlockCopy(BitConverter.GetBytes(World.Server_Group_ID), 0, array, 55, 1);
						}
					}
					Buffer.BlockCopy(BitConverter.GetBytes(Player_Style.Hair_Color), 0, array, 65, 2);
					Buffer.BlockCopy(BitConverter.GetBytes(Player_Style.Hair_Style), 0, array, 67, 2);
					Buffer.BlockCopy(BitConverter.GetBytes(Player_Style.Sex), 0, array, 70, 1);
					Buffer.BlockCopy(NameType, 0, array, 99, 48);
					for (int i = 0; i < 16; i++)
					{
						if (BitConverter.ToInt32(Item_Wear[i].Item_Amount, 0) == 0)
						{
							Item_Wear[i].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
						}
						else
						{
							检查物品系统("装备栏以穿装备", ref Item_Wear[i]);
						}
						if (Item_Wear[i].FLD_FJ_中级附魂 <= 22 && Item_Wear[i].FLD_FJ_中级附魂 >= 21 && Item_Wear[i].FLD_FJ_觉醒 > 0)
						{
							Item_Wear[i].物品_中级附魂_追加_觉醒 = Item_Wear[i].FLD_FJ_中级附魂 - 20;
						}
						Buffer.BlockCopy(Item_Wear[i].GetByte(), 0, array, 147 + i * World.单个物品大小, World.单个物品大小);
					}
					Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
					if (Client != null)
					{
						Client.Send多包(array, array.Length);
					}
				}
				catch (Exception ex2)
				{
					Form1.WriteLine(1, "初始话已装备物品出错[" + Userid + "]-[" + UserName + "]" + ex2.Message);
				}
			}
		}

		public void UpdateCoatBag()
		{
			for (int i = 0; i < 60; i++)
			{
				DateTime dateTime = new DateTime(1970, 1, 1, 7, 0, 0);
				if (Item_Coat[i].FLD_DAY1 != 0 && Item_Coat[i].FLD_DAY2 != 0 && DateTime.Now.Subtract(dateTime.AddSeconds(Item_Coat[i].FLD_DAY2)).TotalSeconds >= 0.0)
				{
					Item_Coat[i].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
				}
			}
			PacketData packetData = new PacketData();
			packetData.WriteInt(169);
			packetData.WriteInt(0);
			packetData.WriteInt(0);
			for (int i = 0; i < 60; i++)
			{
				packetData.Write(Item_Coat[i].GetByte(), 0, World.单个物品大小);
			}
			if (Client != null)
			{
				Client.SendPak(packetData, 28928, UserSessionID);
			}
		}

		public void UpdateNTCBag()
		{
			for (int i = 0; i < 6; i++)
			{
				DateTime dateTime = new DateTime(1970, 1, 1, 7, 0, 0);
				if (Item_NTC[i].FLD_DAY1 != 0 && Item_NTC[i].FLD_DAY2 != 0 && DateTime.Now.Subtract(dateTime.AddSeconds(Item_NTC[i].FLD_DAY2)).TotalSeconds >= 0.0)
				{
					Item_NTC[i].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
				}
			}
			PacketData packetData = new PacketData();
			packetData.WriteInt(171);
			for (int i = 0; i < 6; i++)
			{
				packetData.Write(Item_NTC[i].GetByte(), 0, World.单个物品大小);
			}
			if (Client != null)
			{
				Client.SendPak(packetData, 28928, UserSessionID);
			}
			int num = 0;
			for (int i = 0; i < 6; i++)
			{
				if (World.isNTCItem(Item_NTC[i].FLD_PID))
				{
					UseNgungThanChau(i, 1);
					num++;
					if (num >= 3)
					{
						break;
					}
				}
			}
		}

		public void UseNgungThanChau(int index, int type = 0)
		{
			PacketData packetData = new PacketData();
			packetData.WriteInt(type);
			packetData.WriteInt(index);
			packetData.WriteLong(Item_NTC[index].FLD_PID);
			packetData.WriteInt(Item_NTC[index].FLD_MAGIC1);
			packetData.WriteInt(Item_NTC[index].FLD_MAGIC0);
			if (Client != null)
			{
				Client.SendPak(packetData, 57368, UserSessionID);
			}
		}

		public void Update_Item_In_Bag()
		{
			for (int i = 0; i < 66; i++)
			{
				DateTime dateTime = new DateTime(1970, 1, 1, 7, 0, 0);
				if (Item_In_Bag[i].FLD_DAY1 != 0 && Item_In_Bag[i].FLD_DAY2 != 0 && DateTime.Now.Subtract(dateTime.AddSeconds(Item_In_Bag[i].FLD_DAY2)).TotalSeconds >= 0.0)
				{
					Item_In_Bag[i].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
				}
			}
			PacketData packetData = new PacketData();
			packetData.WriteInt(257);
			if (装备行囊是否开启 == 1)
			{
				packetData.WriteInt(2);
			}
			else
			{
				packetData.WriteInt(0);
			}
			for (int i = 0; i < 66; i++)
			{
				if (BitConverter.ToInt32(Item_In_Bag[i].Item_Amount, 0) <= 0)
				{
					Item_In_Bag[i].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
				}
				else
				{
					检查物品系统("装备栏包裹", ref Item_In_Bag[i]);
				}
				if (Item_In_Bag[i].FLD_FJ_中级附魂 <= 22 && Item_In_Bag[i].FLD_FJ_中级附魂 >= 21 && Item_In_Bag[i].FLD_FJ_觉醒 > 0)
				{
					Item_In_Bag[i].物品_中级附魂_追加_觉醒 = Item_In_Bag[i].FLD_FJ_中级附魂 - 20;
				}
				packetData.Write(Item_In_Bag[i].GetByte(), 0, World.单个物品大小);
			}
			if (Client != null)
			{
				Client.SendPak(packetData, 28928, UserSessionID);
			}
		}

		public int Find_Package_Empty(Players Playe)
		{
			for (int i = 0; i < ((Playe.装备行囊是否开启 == 0) ? 36 : 66); i++)
			{
				if (BitConverter.ToInt32(Playe.Item_In_Bag[i].Get_Byte_Item_PID, 0) == 0)
				{
					return i;
				}
			}
			return -1;
		}

		public int 得到包裹空位数()
		{
			int num = 0;
			for (int i = 0; i < ((装备行囊是否开启 == 0) ? 36 : 66); i++)
			{
				if (BitConverter.ToInt32(Item_In_Bag[i].Get_Byte_Item_PID, 0) == 0)
				{
					num++;
				}
			}
			return num;
		}

		public int 得到包裹空位位置()
		{
			for (int i = 0; i < ((装备行囊是否开启 == 0) ? 36 : 66); i++)
			{
				if (BitConverter.ToInt32(Item_In_Bag[i].Get_Byte_Item_PID, 0) == 0)
				{
					return i;
				}
			}
			return -1;
		}

		public List<int> 得到包裹空位位置组(int 数量)
		{
			int num = 0;
			List<int> list = new List<int>();
			for (int i = 0; i < ((装备行囊是否开启 == 0) ? 36 : 66); i++)
			{
				if (BitConverter.ToInt32(Item_In_Bag[i].Get_Byte_Item_PID, 0) == 0)
				{
					num++;
					list.Add(i);
					if (num >= 数量)
					{
						return list;
					}
				}
			}
			return list;
		}

		public PacketData 得到更新人物数据(Players Play)
		{
			PacketData packetData = new PacketData();
			try
			{
				if (Play == null)
				{
					return null;
				}
				if (Play.Client == null)
				{
					return null;
				}
				packetData.WriteInt(1);
				packetData.WriteInt(Play.UserSessionID);
				if (Play.GM模式 == 8)
				{
					packetData.WriteString(" ");
				}
				else
				{
					packetData.WriteString(Play.UserName);
				}
				packetData.WriteByte(0);
				packetData.WriteInt(Play.Guild_ID);
				if (Play.GM模式 == 8)
				{
					packetData.WriteString(" ");
				}
				else
				{
					packetData.WriteString(Play.Guild_Name);
				}
				packetData.WriteByte(Play.Guild_Level);
				if (Play.Guild_Icon != null && Play.GM模式 != 8)
				{
					packetData.WriteShort(World.Server_Group_ID);
				}
				else
				{
					packetData.WriteShort(0);
				}
				packetData.WriteByte(Play.Player_Zx);
				packetData.WriteByte(Play.Player_Level);
				packetData.WriteByte(Play.Player_Job_Level);
				packetData.WriteByte(Play.Player_Job);
				packetData.WriteShort(0);
				packetData.WriteShort(Play.Player_Style.Hair_Color);
				packetData.WriteShort(Play.Player_Style.Hair_Style);
				if (World.Newversion >= 13)
				{
					packetData.WriteShort(0);
					packetData.WriteByte(0);
					packetData.WriteByte(Play.Player_Style.Sex);
				}
				else
				{
					packetData.WriteByte(0);
					packetData.WriteByte(Play.Player_Style.Sex);
					packetData.WriteShort(0);
				}
				packetData.WriteFloat(Play.Player_FLD_X);
				packetData.WriteFloat(Play.Player_FLD_Z);
				packetData.WriteFloat(Play.Player_FLD_Y);
				packetData.WriteInt(Play.Player_FLD_Map);
				packetData.WriteInt(BitConverter.ToInt32(Play.Item_Wear[0].Get_Byte_Item_PID, 0));
				packetData.WriteInt(0);
				packetData.WriteInt(BitConverter.ToInt32(Play.Item_Wear[1].Get_Byte_Item_PID, 0));
				packetData.WriteInt(0);
				packetData.WriteInt(BitConverter.ToInt32(Play.Item_Wear[2].Get_Byte_Item_PID, 0));
				packetData.WriteInt(0);
				if (World.是否启动披风强化 == 1)
				{
					packetData.WriteInt(BitConverter.ToInt32(Play.Item_Wear[4].Get_Byte_Item_PID, 0));
					packetData.WriteInt(0);
				}
				packetData.WriteInt(BitConverter.ToInt32(Play.Item_Wear[3].Get_Byte_Item_PID, 0));
				packetData.WriteInt(0);
				if (World.Newversion >= 14)
				{
					packetData.WriteInt(BitConverter.ToInt32(Play.Item_Wear[5].Get_Byte_Item_PID, 0));
					packetData.WriteInt(0);
					packetData.WriteInt(BitConverter.ToInt32(Play.Item_Wear[9].Get_Byte_Item_PID, 0));
					packetData.WriteInt(0);
					if (World.是否启动披风强化 == 1)
					{
						packetData.WriteInt(BitConverter.ToInt32(Play.Item_Wear[10].Get_Byte_Item_PID, 0));
						packetData.WriteInt(0);
					}
					packetData.WriteInt(Play.Item_Wear[3].FLD_强化数量);
				}
				else if (World.Newversion == 13)
				{
					packetData.WriteInt(BitConverter.ToInt32(Play.Item_Wear[5].Get_Byte_Item_PID, 0));
					packetData.WriteInt(0);
					packetData.WriteInt(0);
					packetData.WriteInt(0);
					if (World.是否启动披风强化 == 1)
					{
						packetData.WriteInt(0);
						packetData.WriteInt(0);
					}
					packetData.WriteInt(Play.Item_Wear[3].FLD_强化数量);
				}
				else
				{
					packetData.WriteInt(Play.Item_Wear[3].FLD_强化数量);
					if (World.是否启动披风强化 == 1)
					{
						packetData.WriteInt(BitConverter.ToInt32(Play.Item_Wear[3].Get_Byte_Item_PID, 0));
						packetData.WriteInt(0);
					}
				}
				packetData.WriteInt(BitConverter.ToInt32(Play.Item_Wear[11].Get_Byte_Item_PID, 0));
				packetData.WriteInt(0);
				int num = ConfigClass.GetConfig(Play.Config);
				if (Play.Show_Pic_Class != null && Play.Show_Pic_Class.ContainsKey(700014))
				{
					num += 8;
				}
				else if (Play.Config.原著衣服 == 0)
				{
					num -= 64;
				}
				packetData.WriteByte(num);
				if (Play.Player_Job == 7)
				{
					if (Play.Show_Pic_Class == null)
					{
						if (Play.Config.武勋开关 == 90 && (Play.list_时间药品.ContainsKey(1008001478) || Play.list_时间药品.ContainsKey(1008001479)))
						{
							packetData.WriteByte(8);
						}
						else if (Play.Config.武勋开关 != 0)
						{
							packetData.WriteByte(1);
						}
						else
						{
							packetData.WriteByte(0);
						}
					}
					else if (Play.Show_Pic_Class.ContainsKey(900401))
					{
						packetData.WriteByte(18);
					}
					else if (Play.Show_Pic_Class.ContainsKey(900402))
					{
						packetData.WriteByte(34);
					}
					else if (Play.Show_Pic_Class.ContainsKey(900403))
					{
						packetData.WriteByte(66);
					}
					else if (Play.Config.武勋开关 == 90 && (Play.list_时间药品.ContainsKey(1008001478) || Play.list_时间药品.ContainsKey(1008001479)))
					{
						packetData.WriteByte(8);
					}
					else if (Play.Config.武勋开关 == 0)
					{
						packetData.WriteByte(0);
					}
					else
					{
						packetData.WriteByte(1);
					}
				}
				else if (Play.Config.武勋开关 == 90 && (Play.list_时间药品.ContainsKey(1008001478) || Play.list_时间药品.ContainsKey(1008001479)))
				{
					packetData.WriteByte(8);
				}
				else if (Play.Config.武勋开关 != 0)
				{
					packetData.WriteByte(1);
				}
				else
				{
					packetData.WriteByte(0);
				}
				packetData.WriteShort(0);
				packetData.WriteFloat(Play.Player_FLD_X);
				packetData.WriteFloat(Play.Player_FLD_Z);
				packetData.WriteFloat(Play.Player_FLD_Y);
				packetData.WriteInt(0);
				packetData.WriteInt(0);
				if (Play.Pet != null)
				{
					if (Play.Pet.Ride == 1)
					{
						packetData.WriteInt(3);
					}
					else
					{
						packetData.WriteInt(0);
					}
				}
				else
				{
					packetData.WriteInt(255);
				}
				packetData.WriteInt(0);
				packetData.WriteInt(BitConverter.ToInt32(Play.Item_Wear[13].Get_Byte_Item_PID, 0));
				packetData.WriteInt(0);
				packetData.WriteShort(Play.Guild_Style);
				packetData.WriteShort(Play.Guild_Style_Color);
				packetData.WriteInt(Play.Player_WuXun);
				if (Play.Player_FLD_Map == 801 || Play.GM模式 != 0)
				{
					packetData.WriteInt(0);
				}
				else
				{
					packetData.WriteInt(Play.Player_FLD_SE);
				}
				packetData.WriteShort(0);
				if (Play.人物PK模式 != 0 && Play.Player_FLD_Map != 801 && Play.GM模式 != 8)
				{
					packetData.WriteShort(Play.人物PK模式);
				}
				else
				{
					packetData.WriteShort(0);
				}
				if (Play.Show_Pic_Class != null)
				{
					if (Play.Show_Pic_Class.ContainsKey(1008000183))
					{
						packetData.WriteInt(2);
					}
					else if (Play.Show_Pic_Class.ContainsKey(1008000156))
					{
						packetData.WriteInt(1);
					}
					else if (Play.Show_Pic_Class.ContainsKey(1008000195))
					{
						packetData.WriteInt(4);
					}
					else if (Play.Show_Pic_Class.ContainsKey(1008000187))
					{
						packetData.WriteInt(3);
					}
					else
					{
						packetData.WriteInt(0);
					}
				}
				else
				{
					packetData.WriteInt(0);
				}
				packetData.WriteInt(Play.潜行模式);
				if (Play.Show_Pic_Class != null)
				{
					if (Play.Show_Pic_Class.ContainsKey(1008000188))
					{
						packetData.WriteInt(1);
					}
					else if (Play.Show_Pic_Class.ContainsKey(1008000252))
					{
						packetData.WriteInt(20);
					}
					else if (Play.Show_Pic_Class.ContainsKey(1008000245))
					{
						packetData.WriteInt(8);
					}
					else if (Play.Show_Pic_Class.ContainsKey(1008000232))
					{
						packetData.WriteInt(2);
					}
					else
					{
						packetData.WriteInt(0);
					}
				}
				else
				{
					packetData.WriteInt(0);
				}
				packetData.Write(Play.NameType, 0, 48);
				packetData.WriteInt(0);
				if (Play.Config.蔬菜武器开关 == 1)
				{
					if (Play.Show_Pic_Class != null)
					{
						if (!Play.Show_Pic_Class.ContainsKey(1008000240) && !Play.Show_Pic_Class.ContainsKey(1008000241) && !Play.Show_Pic_Class.ContainsKey(1008000242))
						{
							if (!Play.Show_Pic_Class.ContainsKey(1008000250) && !Play.Show_Pic_Class.ContainsKey(1008000251))
							{
								if (!Play.Show_Pic_Class.ContainsKey(1008000304) && !Play.Show_Pic_Class.ContainsKey(1008000305))
								{
									if (!Play.Show_Pic_Class.ContainsKey(1008000306) && !Play.Show_Pic_Class.ContainsKey(1008000307))
									{
										if (!Play.Show_Pic_Class.ContainsKey(1008000325) && !Play.Show_Pic_Class.ContainsKey(1008000326))
										{
											if (!Play.Show_Pic_Class.ContainsKey(1008001111) && !Play.Show_Pic_Class.ContainsKey(1008001112) && !Play.Show_Pic_Class.ContainsKey(1008001113) && !Play.Show_Pic_Class.ContainsKey(1008001114))
											{
												packetData.WriteInt(0);
											}
											else
											{
												packetData.WriteInt(5);
											}
										}
										else
										{
											packetData.WriteInt(4);
										}
									}
									else
									{
										packetData.WriteInt(3);
									}
								}
								else
								{
									packetData.WriteInt(3);
								}
							}
							else
							{
								packetData.WriteInt(2);
							}
						}
						else
						{
							packetData.WriteInt(1);
						}
					}
					else
					{
						packetData.WriteInt(0);
					}
				}
				else
				{
					packetData.WriteInt(0);
				}
				if (World.情侣开关 == 1)
				{
					if (Play.FLD_Couple_Name != "")
					{
						if (Play.GM模式 != 8)
						{
							packetData.WriteByte(1);
							packetData.WriteString(Play.FLD_Couple_Name);
							packetData.WriteByte(Play.FLD_Couple_Level);
						}
						else
						{
							packetData.WriteByte(0);
							packetData.WriteString("");
							packetData.WriteByte(0);
						}
					}
					else
					{
						packetData.WriteByte(0);
						packetData.WriteString("");
						packetData.WriteByte(0);
					}
				}
				else
				{
					packetData.WriteByte(0);
					packetData.WriteString("");
					packetData.WriteByte(0);
				}
				packetData.WriteByte(0);
				packetData.WriteByte(0);
				packetData.WriteByte(0);
				packetData.WriteByte(0);
				packetData.WriteByte(Play.Item_Wear[3].FLD_FJ_进化);
				packetData.WriteByte(Play.Item_Wear[3].FLD_属性类型);
				packetData.WriteByte(Play.Item_Wear[3].FLD_属性数量);
				if (Play.Bat_Tu > 0 || (Play.Guild_Name == Guild_Name && Play.Player_FLD_Map == 801 && Player_FLD_Map == 801))
				{
					packetData.WriteShort(1);
				}
				else
				{
					packetData.WriteShort(0);
				}
				packetData.WriteShort(Play.Player_Style.Sex);
				if (Config.武勋开关 != 0)
				{
					packetData.WriteInt(Play.人物武勋阶段);
				}
				else
				{
					packetData.WriteInt(0);
				}
				if (Play.GM模式 == 1)
				{
					packetData.WriteShort(100);
					packetData.WriteShort(6);
				}
				if (Play.TLC模式 == 1)
				{
					packetData.WriteShort(101);
					packetData.WriteShort(11);
				}
				if (Play.TLC模式 == 2)
				{
					packetData.WriteShort(102);
					packetData.WriteShort(11);
				}
				if (Play.TLC模式 == 3)
				{
					packetData.WriteShort(103);
					packetData.WriteShort(11);
				}
				if (Play.TLC模式 == 4)
				{
					packetData.WriteShort(104);
					packetData.WriteShort(11);
				}
				if (Play.TLC模式 == 5)
				{
					packetData.WriteShort(105);
					packetData.WriteShort(11);
				}
				if (Play.TLC模式 == 6)
				{
					packetData.WriteShort(100);
					packetData.WriteShort(11);
				}
				if (Play.list_时间药品.ContainsKey(1008001300))
				{
					packetData.WriteShort(201);
					packetData.WriteShort(1);
				}
				else if (Play.list_时间药品.ContainsKey(1008001301))
				{
					packetData.WriteShort(202);
					packetData.WriteShort(2);
				}
				else if (Play.Player_FLD_Map != 801)
				{
					if (Play.int_25 != 0 && Play.int_123 == 0)
					{
						if (Play.int_25 == 141)
						{
							packetData.WriteShort(Play.int_25);
							packetData.WriteShort(11);
						}
						else
						{
							packetData.WriteShort(Play.int_25);
							packetData.WriteShort(2);
						}
					}
					else if (Play.int_25 == 0 && Play.int_123 != 0)
					{
						if (Play.int_123 == 241)
						{
							packetData.WriteShort(Play.int_123);
							packetData.WriteShort(1);
						}
						else
						{
							packetData.WriteShort(Play.int_123);
							packetData.WriteShort(2);
						}
					}
					else if (Play.int_25 != 0 && Play.int_123 != 0)
					{
						if (Play.int_123 == 241)
						{
							packetData.WriteShort(Play.int_123);
							packetData.WriteShort(1);
						}
						else
						{
							packetData.WriteShort(Play.int_123);
							packetData.WriteShort(2);
						}
					}
					else
					{
						packetData.WriteShort(0);
						packetData.WriteShort(0);
					}
				}
				else
				{
					packetData.WriteShort(0);
					packetData.WriteShort(0);
				}
				packetData.WriteShort(0);
				if (Play.Pet != null)
				{
					packetData.WriteShort(1);
					packetData.WriteShort(Play.Pet_ID);
					if (Play.GM模式 == 8)
					{
						packetData.WriteString("    ");
					}
					else
					{
						packetData.WriteString(Play.Pet.Name);
					}
					packetData.WriteInt(0);
					packetData.WriteByte(0);
					packetData.WriteByte(Play.Pet.Pet_FLD_LEVEL);
					packetData.WriteByte(Play.Pet.FLD_JOB_LEVEL);
					packetData.WriteShort(Play.Pet.FLD_JOB);
					packetData.WriteShort(Play.Pet.Bs);
					if (Play.Pet.FLD_JOB_LEVEL == 1)
					{
						packetData.WriteInt(Play.Pet.武功[1].FLD_PID);
						packetData.WriteInt(Play.Pet.武功[1].FLD_INDEX);
					}
					else if (Play.Pet.FLD_JOB_LEVEL == 2)
					{
						packetData.WriteInt(Play.Pet.武功[2].FLD_PID);
						packetData.WriteInt(Play.Pet.武功[2].FLD_INDEX);
					}
					else if (Play.Pet.FLD_JOB_LEVEL == 3)
					{
						packetData.WriteInt(Play.Pet.武功[3].FLD_PID);
						packetData.WriteInt(Play.Pet.武功[3].FLD_INDEX);
					}
					else
					{
						packetData.WriteInt(0);
						packetData.WriteInt(0);
					}
					for (int i = 0; i < 4; i++)
					{
						packetData.WriteInt((int)Play.Pet.宠物以装备[i].FLD_PID);
					}
					packetData.WriteInt(0);
				}
				else
				{
					packetData.WriteShort(0);
					for (int j = 0; j < 14; j++)
					{
						packetData.WriteInt(0);
					}
				}
				packetData.WriteInt(-1);
				packetData.WriteInt(0);
				int value = 0;
				if (Show_Pic_Class.ContainsKey(700344))
				{
					value = 1;
					if (Show_Pic_Class.ContainsKey(700314))
					{
						value = 3;
						if (Show_Pic_Class.ContainsKey(700604))
						{
							value = 7;
						}
					}
					else if (Show_Pic_Class.ContainsKey(700604))
					{
						value = 5;
					}
				}
				else if (Show_Pic_Class.ContainsKey(700314))
				{
					value = 2;
					if (Show_Pic_Class.ContainsKey(700604))
					{
						value = 6;
					}
				}
				else if (Show_Pic_Class.ContainsKey(700604))
				{
					value = 4;
				}
				packetData.WriteByte(value);
				packetData.WriteInt(0, 14);
				return packetData;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "得到更新人物数据 出错" + Client.WorldId + "|" + Client.ToString() + " " + Converter.ToString(packetData.ToArray3()) + " " + ex);
				return null;
			}
		}

		public void 得到钱的提示(uint 数量)
		{
			string hex = "AA55430000EA010D0034000100000000000000000000000094357700000000A701000000000000000000000000000000000000000000000000000000000000000000000000000055AA";
			byte[] array = Converter.hexStringToByte(hex);
			byte[] bytes = BitConverter.GetBytes(数量);
			Buffer.BlockCopy(bytes, 0, array, 31, bytes.Length);
			Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public 物品类 得到人物公共仓库类型(int id, int 仓库类型, int magic = 0)
		{
			if (World.isStone(id))
			{
				if (仓库类型 == 3)
				{
					物品类[] array = 个人仓库;
					foreach (物品类 物品类 in array)
					{
						if (BitConverter.ToInt32(物品类.Get_Byte_Item_PID, 0) == id && 物品类.FLD_MAGIC0 == magic)
						{
							return 物品类;
						}
					}
				}
				else
				{
					物品类[] array = 公共仓库;
					foreach (物品类 物品类2 in array)
					{
						if (BitConverter.ToInt32(物品类2.Get_Byte_Item_PID, 0) == id && 物品类2.FLD_MAGIC0 == magic)
						{
							return 物品类2;
						}
					}
				}
			}
			else if (仓库类型 == 3)
			{
				物品类[] array = 个人仓库;
				foreach (物品类 物品类 in array)
				{
					if (BitConverter.ToInt32(物品类.Get_Byte_Item_PID, 0) == id)
					{
						return 物品类;
					}
				}
			}
			else
			{
				物品类[] array = 公共仓库;
				foreach (物品类 物品类2 in array)
				{
					if (BitConverter.ToInt32(物品类2.Get_Byte_Item_PID, 0) == id)
					{
						return 物品类2;
					}
				}
			}
			return null;
		}

		public Players Select_Character_ID(int 人物ID)
		{
			if (World.AllConnectedChars.TryGetValue(人物ID, out Players value))
			{
				return value;
			}
			return null;
		}

		public void UpdateRankCouple()
		{
			if (FLD_Couple_Exp < 0 || FLD_Couple_Exp > 35000)
			{
				return;
			}
			int valueRankCouple = World.getValueRankCouple(FLD_Couple_Level);
			int valueRankCouple2 = World.getValueRankCouple(FLD_Couple_Level + 1);
			if (FLD_Couple_Exp < valueRankCouple2)
			{
				FLD_Couple_Level++;
				if (FLD_Couple_Level > 10)
				{
					FLD_Couple_Level = 10;
				}
				Client.Player.更新人物数据(Client.Player);
				更新广播人物数据();
			}
			else if (FLD_Couple_Exp > valueRankCouple)
			{
				FLD_Couple_Level--;
				if (FLD_Couple_Level < 1)
				{
					FLD_Couple_Level = 1;
				}
				Client.Player.更新人物数据(Client.Player);
				更新广播人物数据();
			}
			更新情侣系统(2, FLD_Couple_Name, FLD_Couple_Name_Unknow);
			GameMessage("Level Couple: " + FLD_Couple_Level + " | Exp Couple: " + FLD_Couple_Exp + " | Daily: " + FLD_Couple_ExpMax);
		}

		public Players Find_Player(string 人物名)
		{
			try
			{
				foreach (Players value in World.AllConnectedChars.Values)
				{
					if (value.UserName.ToLower() == 人物名.ToLower())
					{
						return value;
					}
				}
				return null;
			}
			catch
			{
				return null;
			}
		}

		public Players Find_PlayerSessionID(int UserSessionID)
		{
			try
			{
				foreach (Players value in World.AllConnectedChars.Values)
				{
					if (value.UserSessionID == UserSessionID)
					{
						return value;
					}
				}
				return null;
			}
			catch
			{
				return null;
			}
		}

		public 物品类 得到人物物品类型(long id, int magic = 0)
		{
			if (World.isStone(id))
			{
				物品类[] item_In_Bag = Item_In_Bag;
				foreach (物品类 物品类 in item_In_Bag)
				{
					if (物品类.FLD_PID == id && 物品类.FLD_MAGIC0 == magic)
					{
						return 物品类;
					}
				}
			}
			else
			{
				物品类[] item_In_Bag = Item_In_Bag;
				foreach (物品类 物品类 in item_In_Bag)
				{
					if (物品类.FLD_PID == id)
					{
						return 物品类;
					}
				}
			}
			return null;
		}

		public 物品类 得到人物物品物品全局ID(Players Playe, long 物品全局ID)
		{
			物品类[] item_In_Bag = Playe.Item_In_Bag;
			foreach (物品类 物品类 in item_In_Bag)
			{
				if (物品类.Get物品全局ID == 物品全局ID)
				{
					return 物品类;
				}
			}
			return null;
		}

		public void 地面物品消失(long 全局ID)
		{
			try
			{
				PacketData packetData = new PacketData();
				packetData.WriteLong(全局ID);
				if (Client != null)
				{
					Client.SendPak(packetData, 29440, UserSessionID);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "地面物品消失数据 出错" + Client.WorldId + "|" + Client.ToString() + " " + ex);
			}
		}

		public void 地面物品增加(Dictionary<long, 地面物品类> Itmes)
		{
			try
			{
				if (Itmes != null && Itmes.Count > 0)
				{
					using (PacketData packetData = new PacketData())
					{
						packetData.WriteInt(Itmes.Count);
						foreach (地面物品类 value in Itmes.Values)
						{
							packetData.Write(value.物品_byte, 0, 12);
							packetData.WriteInt(0);
							packetData.Write(value.物品_byte, 12, 4);
							packetData.WriteFloat(value.Rxjh_X);
							packetData.WriteFloat(value.Rxjh_Z);
							packetData.WriteFloat(value.Rxjh_Y);
							packetData.Write(value.物品_byte, 16, 56);
						}
						if (Client != null)
						{
							Client.SendPak(packetData, 29184, UserSessionID);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "地面物品增加数据 出错" + Client.WorldId + "|" + Client.ToString() + " " + ex);
			}
		}

		public void 读帮派数据()
		{
			if (World.JlMsg == 1)
			{
				Form1.WriteLine(0, "PlayersBes_读帮派数据()");
			}
			DataTable userNameBp = RxjhClass.GetUserNameBp(UserName);
			if (userNameBp != null)
			{
				Guild_ID = (int)userNameBp.Rows[0]["Id"];
				Guild_Name = userNameBp.Rows[0]["G_Name"].ToString();
				Guild_Level = (int)userNameBp.Rows[0]["leve"];
				Guild_Style = (int)userNameBp.Rows[0]["门服字"];
				Guild_Style_Color = (int)userNameBp.Rows[0]["门服颜色"];
				try
				{
					if (userNameBp.Rows[0]["Mh"] != DBNull.Value)
					{
						Guild_Icon = (byte[])userNameBp.Rows[0]["Mh"];
					}
				}
				catch (Exception)
				{
				}
				userNameBp.Dispose();
			}
			else
			{
				Guild_ID = 0;
				Guild_Name = string.Empty;
				Guild_Level = 0;
				Guild_Icon = null;
			}
		}

		public void 读出灵兽数据(long id)
		{
			try
			{
				DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_XWWL_Cw WHERE ItmeId ={id}");
				if (dBToDataTable.Rows.Count > 0)
				{
					Pet = new PetClass(id, Client, dBToDataTable);
					Pet.全服ID = Pet_ID;
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "读出灵兽数据出错 [" + Userid + "][" + UserName + "][" + id + "] " + ex.Message);
			}
		}

		public void 读出人物数据()
		{
			try
			{
				if (World.JlMsg == 1)
				{
					Form1.WriteLine(0, "PlayersBes_读出人物数据()");
				}
				Clear();
				string sqlCommand = $"select * from [TBL_XWWL_Char] where FLD_ID=@Userid and FLD_NAME =@Username";
				SqlParameter[] prams = new SqlParameter[2]
				{
					SqlDBA.MakeInParam("@Userid", SqlDbType.VarChar, 30, Userid),
					SqlDBA.MakeInParam("@Username", SqlDbType.VarChar, 30, UserName)
				};
				DataTable dBToDataTable = DBA.GetDBToDataTable(sqlCommand, prams);
				if (dBToDataTable.Rows.Count == 0 && Client != null)
				{
					GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 7", 7);
					Client.Dispose();
				}
				GM模式 = (int)dBToDataTable.Rows[0]["FLD_J9"];
				TLC模式 = (int)dBToDataTable.Rows[0]["FLD_TLC"];
				人物位置 = (int)dBToDataTable.Rows[0]["FLD_INDEX"];
				_Player_ExpErience = (int)dBToDataTable.Rows[0]["FLD_FIGHT_EXP"];
				_人物经验 = long.Parse(dBToDataTable.Rows[0]["FLD_EXP"].ToString());
				try
				{
					_Player_Money = long.Parse(dBToDataTable.Rows[0]["FLD_MONEY"].ToString());
				}
				catch
				{
					_Player_Money = 0L;
				}
				_Player_Qigong_point = (int)dBToDataTable.Rows[0]["FLD_POINT"];
				_Player_Zx = (int)dBToDataTable.Rows[0]["FLD_ZX"];
				_playerLevel = (int)dBToDataTable.Rows[0]["FLD_LEVEL"];
				_Player_Job = (int)dBToDataTable.Rows[0]["FLD_JOB"];
				_playerJobLevel = (int)dBToDataTable.Rows[0]["FLD_JOB_LEVEL"];
				Player_Style = new PlayerStyle((byte[])dBToDataTable.Rows[0]["FLD_FACE"]);
				_nameType = (byte[])dBToDataTable.Rows[0]["FLD_NAMETYPE"];
				_Player_Sex = Player_Style.Sex;
				_人物_HP = (int)dBToDataTable.Rows[0]["FLD_HP"];
				_人物_MP = (int)dBToDataTable.Rows[0]["FLD_MP"];
				_人物_SP = (int)dBToDataTable.Rows[0]["FLD_SP"];
				Craft_Type = (int)dBToDataTable.Rows[0]["FLD_ZzType"];
				Craft_Level = (int)dBToDataTable.Rows[0]["FLD_ZzSl"];
				_人物坐标_X = float.Parse(dBToDataTable.Rows[0]["FLD_X"].ToString());
				_人物坐标_Y = float.Parse(dBToDataTable.Rows[0]["FLD_Y"].ToString());
				_人物坐标_Z = float.Parse(dBToDataTable.Rows[0]["FLD_Z"].ToString());
				装备数据版本 = (int)dBToDataTable.Rows[0]["FLD_ZBVER"];
				_人物坐标_地图 = (int)dBToDataTable.Rows[0]["FLD_MENOW"];
				if ((_Player_Sex < 1 || _Player_Sex > 2) && Client != null)
				{
					GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 6", 7);
					Client.Dispose();
				}
				新坐标 = new 坐标Class(Player_FLD_X, Player_FLD_Y, Player_FLD_Z, Player_FLD_Map);
				Player_WuXun = (int)dBToDataTable.Rows[0]["FLD_WX"];
				Player_FLD_SE = (int)dBToDataTable.Rows[0]["FLD_SE"];
				人物轻功 = (int)dBToDataTable.Rows[0]["FLD_JQ"];
				FLD_Couple_Name = dBToDataTable.Rows[0]["FLD_QlNAME"].ToString();
				FLD_Couple_Name_Unknow = dBToDataTable.Rows[0]["FLD_QlJZNAME"].ToString();
				FLD_Couple_Exp = (int)dBToDataTable.Rows[0]["FLD_QlDu"];
				FLD_Couple_ExpMax = (int)dBToDataTable.Rows[0]["FLD_QlDuMax"];
				FLD_Couple_Level = (int)dBToDataTable.Rows[0]["FLD_QlRank"];
				FLD_Teacher = dBToDataTable.Rows[0]["FLD_师傅"].ToString();
				FLD_Student1 = dBToDataTable.Rows[0]["FLD_徒弟1"].ToString();
				FLD_Student2 = dBToDataTable.Rows[0]["FLD_徒弟2"].ToString();
				FLD_Student3 = dBToDataTable.Rows[0]["FLD_徒弟3"].ToString();
				if (FLD_Student1 != "")
				{
					string sqlCommand2 = $"select FLD_师徒武功1_1, FLD_师徒武功1_2, FLD_师徒武功1_3 from [TBL_XWWL_Char] where FLD_NAME =@studentName";
					SqlParameter[] prams2 = new SqlParameter[1]
					{
						SqlDBA.MakeInParam("@studentName", SqlDbType.VarChar, 30, FLD_Student1)
					};
					DataTable dBToDataTable2 = DBA.GetDBToDataTable(sqlCommand2, prams2);
					if (dBToDataTable2.Rows.Count > 0)
					{
						int item = (int)dBToDataTable2.Rows[0]["FLD_师徒武功1_1"];
						int item2 = (int)dBToDataTable2.Rows[0]["FLD_师徒武功1_2"];
						int item3 = (int)dBToDataTable2.Rows[0]["FLD_师徒武功1_3"];
						if (!disable_Skill_List.Contains(item))
						{
							disable_Skill_List.Add(item);
						}
						if (!disable_Skill_List.Contains(item2))
						{
							disable_Skill_List.Add(item2);
						}
						if (!disable_Skill_List.Contains(item3))
						{
							disable_Skill_List.Add(item3);
						}
					}
				}
				if (FLD_Student2 != "")
				{
					string sqlCommand2 = $"select FLD_师徒武功1_1, FLD_师徒武功1_2, FLD_师徒武功1_3 from [TBL_XWWL_Char] where FLD_NAME =@studentName";
					SqlParameter[] prams2 = new SqlParameter[1]
					{
						SqlDBA.MakeInParam("@studentName", SqlDbType.VarChar, 30, FLD_Student2)
					};
					DataTable dBToDataTable2 = DBA.GetDBToDataTable(sqlCommand2, prams2);
					if (dBToDataTable2.Rows.Count > 0)
					{
						int item = (int)dBToDataTable2.Rows[0]["FLD_师徒武功1_1"];
						int item2 = (int)dBToDataTable2.Rows[0]["FLD_师徒武功1_2"];
						int item3 = (int)dBToDataTable2.Rows[0]["FLD_师徒武功1_3"];
						if (!disable_Skill_List.Contains(item))
						{
							disable_Skill_List.Add(item);
						}
						if (!disable_Skill_List.Contains(item2))
						{
							disable_Skill_List.Add(item2);
						}
						if (!disable_Skill_List.Contains(item3))
						{
							disable_Skill_List.Add(item3);
						}
					}
				}
				if (FLD_Student3 != "")
				{
					string sqlCommand2 = $"select FLD_师徒武功1_1, FLD_师徒武功1_2, FLD_师徒武功1_3 from [TBL_XWWL_Char] where FLD_NAME =@studentName";
					SqlParameter[] prams2 = new SqlParameter[1]
					{
						SqlDBA.MakeInParam("@studentName", SqlDbType.VarChar, 30, FLD_Student3)
					};
					DataTable dBToDataTable2 = DBA.GetDBToDataTable(sqlCommand2, prams2);
					if (dBToDataTable2.Rows.Count > 0)
					{
						int item = (int)dBToDataTable2.Rows[0]["FLD_师徒武功1_1"];
						int item2 = (int)dBToDataTable2.Rows[0]["FLD_师徒武功1_2"];
						int item3 = (int)dBToDataTable2.Rows[0]["FLD_师徒武功1_3"];
						if (!disable_Skill_List.Contains(item))
						{
							disable_Skill_List.Add(item);
						}
						if (!disable_Skill_List.Contains(item2))
						{
							disable_Skill_List.Add(item2);
						}
						if (!disable_Skill_List.Contains(item3))
						{
							disable_Skill_List.Add(item3);
						}
					}
				}
				FLD_师徒_武功ID1_1 = (int)dBToDataTable.Rows[0]["FLD_师徒武功1_1"];
				FLD_师徒_武功ID1_2 = (int)dBToDataTable.Rows[0]["FLD_师徒武功1_2"];
				FLD_师徒_武功ID1_3 = (int)dBToDataTable.Rows[0]["FLD_师徒武功1_3"];
				FLD_DayQuest_Array = (string)dBToDataTable.Rows[0]["FLD_DayQuest"];
				升天武功点数 = (int)dBToDataTable.Rows[0]["FLD_升天武功点"];
				升天历练数 = (int)dBToDataTable.Rows[0]["FLD_升天历练"];
				if (Player_ExpErience < 0)
				{
					Player_ExpErience = 0;
				}
				if (Player_Qigong_point < 0)
				{
					Player_Qigong_point = 0;
				}
				try
				{
					if (dBToDataTable.Rows[0]["在线时间"] != DBNull.Value)
					{
						byte[] array = (byte[])dBToDataTable.Rows[0]["在线时间"];
						Buffer.BlockCopy(array, 0, _总在线时间, 0, array.Length);
					}
					奖励_追加_生命 = (int)dBToDataTable.Rows[0]["FLD_ADD_HP"];
					奖励_追加_攻击 = long.Parse(dBToDataTable.Rows[0]["FLD_ADD_AT"].ToString());
					奖励_追加_防御 = long.Parse(dBToDataTable.Rows[0]["FLD_ADD_DF"].ToString());
					奖励_追加_回避 = (int)dBToDataTable.Rows[0]["FLD_ADD_HB"];
					奖励_追加_内功 = (int)dBToDataTable.Rows[0]["FLD_ADD_MP"];
					奖励_追加_命中 = (int)dBToDataTable.Rows[0]["FLD_ADD_MZ"];
					转生次数 = (int)dBToDataTable.Rows[0]["FLD_TAISINH"];
					会员等级 = (int)dBToDataTable.Rows[0]["FLD_VIPDJ"];
					FLD_MetMoi = (int)dBToDataTable.Rows[0]["FLD_七彩"];
					每日武勋 = (int)dBToDataTable.Rows[0]["FLD_GETWX"];
				}
				catch
				{
				}
				int num = 0;
				if (dBToDataTable.Rows[0]["FLD_升天气功"] != DBNull.Value)
				{
					byte[] array2 = (byte[])dBToDataTable.Rows[0]["FLD_升天气功"];
					if (Player_Job_Level >= 6)
					{
						for (int i = 0; i < 15; i++)
						{
							byte[] array3 = new byte[4];
							try
							{
								if (array2.Length >= i * 4 + 4)
								{
									Buffer.BlockCopy(array2, i * 4, array3, 0, 4);
									升天气功类 升天气功类 = new 升天气功类(array3);
									if (World.升天气功List.TryGetValue(升天气功类.气功ID, out 升天气功总类 value))
									{
										switch (Player_Job)
										{
										case 1:
											if (value.人物职业1 == 1 && !升天气功.ContainsKey(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num += 升天气功类.气功量;
											}
											break;
										case 2:
											if (value.人物职业2 == 1 && !升天气功.ContainsKey(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num += 升天气功类.气功量;
											}
											break;
										case 3:
											if (value.人物职业3 == 1 && !升天气功.ContainsKey(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num += 升天气功类.气功量;
											}
											break;
										case 4:
											if (value.人物职业4 == 1 && !升天气功.ContainsKey(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num += 升天气功类.气功量;
											}
											break;
										case 5:
											if (value.人物职业5 == 1 && !升天气功.ContainsKey(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num += 升天气功类.气功量;
											}
											break;
										case 6:
											if (value.人物职业6 == 1 && !升天气功.ContainsKey(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num += 升天气功类.气功量;
											}
											break;
										case 7:
											if (value.人物职业7 == 1 && !升天气功.ContainsKey(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num += 升天气功类.气功量;
											}
											break;
										case 8:
											if (value.人物职业8 == 1 && !升天气功.ContainsKey(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num += 升天气功类.气功量;
											}
											break;
										case 9:
											if (value.人物职业9 == 1 && !升天气功.ContainsKey(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num += 升天气功类.气功量;
											}
											break;
										case 10:
											if (value.人物职业10 == 1 && !升天气功.ContainsKey(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num += 升天气功类.气功量;
											}
											break;
										case 11:
											if (value.人物职业11 == 1 && !升天气功.ContainsKey(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num += 升天气功类.气功量;
											}
											break;
										case 12:
											if (value.人物职业12 == 1 && !升天气功.ContainsKey(升天气功类.气功ID))
											{
												升天气功.Add(升天气功类.气功ID, 升天气功类);
												num += 升天气功类.气功量;
											}
											break;
										}
									}
									continue;
								}
							}
							catch (Exception)
							{
								continue;
							}
							break;
						}
					}
				}
				byte[] array4 = new byte[20];
				byte[] array5 = (byte[])dBToDataTable.Rows[0]["FLD_SKILLS"];
				Buffer.BlockCopy(array5, 0, array4, 0, array5.Length);
				for (int j = 0; j < 15; j++)
				{
					byte[] array6 = new byte[2];
					if (array4.Length > j + 1)
					{
						Buffer.BlockCopy(array4, j, array6, 0, 1);
					}
					气功[j] = new 气功类(array6);
					bool flag = false;
					switch (j)
					{
					case 6:
						if (Player_Job_Level >= 1 && Player_Level >= 10)
						{
							flag = true;
						}
						break;
					case 7:
						if (Player_Job_Level >= 2 && Player_Level >= 35)
						{
							flag = true;
						}
						break;
					case 8:
						if (Player_Job_Level >= 3 && Player_Level >= 60)
						{
							flag = true;
						}
						break;
					case 9:
						if (Player_Job_Level >= 4 && Player_Level >= 80)
						{
							flag = true;
						}
						break;
					case 10:
						if (Player_Job_Level >= 4 && Player_Level >= 90)
						{
							flag = true;
						}
						break;
					case 11:
						if (Player_Job_Level >= 5 && Player_Level >= 100)
						{
							flag = true;
						}
						break;
					default:
						flag = true;
						break;
					}
					if (flag && j < 12)
					{
						气功[j].气功ID = GetQigongID(j);
						if (气功[j].气功量 >= 255)
						{
							气功[j].气功量 = 0;
						}
					}
				}
				int num2 = 0;
				int num3 = 0;
				for (int k = 0; k < 12; k++)
				{
					byte[] 气功_byte = 气功[k].气功_byte;
					int num4 = BitConverter.ToInt16(气功_byte, 0);
					if (气功_byte[0] != byte.MaxValue)
					{
						num2 += num4;
					}
				}
				if (Player_Level > 109)
				{
					num3 = 182;
					int num5 = Player_Level - 109;
					num3 = 182 + num5 * 3;
				}
				else if (Player_Level > 34)
				{
					num3 = 34;
					int num5 = Player_Level - 35;
					num3 = 34 + num5 * 2;
				}
				else
				{
					num3 = Player_Level - 1;
				}
				if (num2 + Player_Qigong_point + num != num3)
				{
					if (num2 + num > num3 - Player_Qigong_point)
					{
						Player_Qigong_point = num3;
						for (int l = 0; l < 12; l++)
						{
							if (BitConverter.ToInt16(气功[l].气功_byte, 0) != 255)
							{
								气功[l].气功_byte = new byte[2];
							}
						}
						foreach (升天气功类 value7 in 升天气功.Values)
						{
							value7.气功量 = 0;
						}
					}
					else
					{
						Player_Qigong_point = num3 - num2 - num;
					}
				}
				byte[] array7 = (byte[])dBToDataTable.Rows[0]["FLD_KONGFU"];
				int num6 = 0;
				while (true)
				{
					bool flag2 = true;
					if (num6 < 78)
					{
						byte[] array8 = new byte[4];
						byte[] array9 = new byte[2];
						try
						{
							if (array7.Length >= num6 * 6 + 4)
							{
								Buffer.BlockCopy(array7, num6 * 6, array8, 0, 4);
								Buffer.BlockCopy(array7, num6 * 6 + 4, array9, 0, 2);
								int num7 = BitConverter.ToInt32(array8, 0);
								int num8 = BitConverter.ToInt16(array9, 0);
								if (num7 != 0)
								{
									武功类 武功类 = new 武功类(num7);
									if ((武功类.FLD_JOB == 0 || Player_Job == 武功类.FLD_JOB) && (武功类.FLD_ZX == 0 || Player_Zx == 武功类.FLD_ZX) && Player_Job_Level >= 武功类.FLD_JOBLEVEL && Player_Level >= 武功类.FLD_LEVEL)
									{
										Array_Skill_Book[武功类.FLD_武功类型, 武功类.FLD_INDEX] = 武功类;
										if (num8 != 0)
										{
											if (num8 > 武功类.最高武功_等级)
											{
												num8 = 武功类.最高武功_等级;
											}
											武功类.武功_等级 = num8;
										}
									}
								}
								goto IL_1698;
							}
						}
						catch (Exception arg)
						{
							Console.WriteLine("读出武功出错 " + arg);
							goto IL_1698;
						}
					}
					break;
					IL_1698:
					num6++;
				}
				Auto_Learn_Skill();
				if (dBToDataTable.Rows[0]["FLD_升天武功"] != DBNull.Value)
				{
					byte[] array10 = (byte[])dBToDataTable.Rows[0]["FLD_升天武功"];
					for (int m = 0; m < 18 && array10.Length >= m * 8 + 8; m++)
					{
						int fLD_PID_ = BitConverter.ToInt32(array10, m * 8);
						int 武功_等级 = BitConverter.ToInt32(array10, m * 8 + 4);
						武功类 武功类2 = new 武功类(fLD_PID_);
						武功类2.武功_等级 = 武功_等级;
						if (武功类2.武功_等级 > 武功类2.最高武功_等级)
						{
							武功类2.武功_等级 = 武功类2.最高武功_等级;
						}
						if ((武功类2.FLD_JOB == 0 || Player_Job == 武功类2.FLD_JOB) && (武功类2.FLD_ZX == 0 || Player_Zx == 武功类2.FLD_ZX) && Player_Job_Level >= 武功类2.FLD_JOBLEVEL && Player_Level >= 武功类2.FLD_LEVEL)
						{
							Array_Skill_Book[武功类2.FLD_武功类型, 武功类2.FLD_INDEX] = 武功类2;
						}
					}
				}
				byte[] array11 = (byte[])dBToDataTable.Rows[0]["FLD_QITEM"];
				int num9 = 0;
				while (true)
				{
					bool flag2 = true;
					if (num9 >= 36)
					{
						break;
					}
					byte[] array12 = new byte[8];
					if (array11.Length >= num9 * 8 + 8)
					{
						try
						{
							Buffer.BlockCopy(array11, num9 * 8, array12, 0, 8);
						}
						catch (Exception arg2)
						{
							Console.WriteLine(num9 + " " + arg2);
						}
					}
					Quest_Item[num9] = new 任务物品类(array12);
					num9++;
				}
				byte[] array13 = (byte[])dBToDataTable.Rows[0]["FLD_ITEM"];
				for (int n = 0; n < 66; n++)
				{
					byte[] array14 = new byte[(World.Newversion >= 14) ? 76 : 73];
					if (array13.Length >= n * ((World.Newversion >= 14) ? 76 : 73) + ((World.Newversion >= 14) ? 76 : 73))
					{
						try
						{
							Buffer.BlockCopy(array13, n * ((World.Newversion >= 14) ? 76 : 73), array14, 0, (World.Newversion >= 14) ? 76 : 73);
						}
						catch (Exception arg3)
						{
							Console.WriteLine(n + " " + arg3);
						}
						Item_In_Bag[n] = new 物品类(array14, n);
						byte[] array15 = new byte[4];
						Buffer.BlockCopy(Item_In_Bag[n].Byte_Item, 56, array15, 0, 4);
						int num10 = BitConverter.ToInt32(array15, 0);
						if (num10 > 0)
						{
							DateTime dateTime = new DateTime(1970, 1, 1, 7, 0, 0);
							if (DateTime.Now.Subtract(dateTime.AddSeconds(num10)).TotalSeconds >= 0.0)
							{
								GameMessage("背包有物品过期[" + Item_In_Bag[n].Get_Name() + "],系统已删除！", 9);
								Item_In_Bag[n].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
							}
						}
						if (World.AllItmelog == 1)
						{
							try
							{
								if (Item_In_Bag[n].得到物品位置类型() != 1 && Item_In_Bag[n].得到物品位置类型() != 2 && Item_In_Bag[n].得到物品位置类型() != 5 && Item_In_Bag[n].得到物品位置类型() != 6)
								{
									if (Item_In_Bag[n].得到物品位置类型() != 4 && Item_In_Bag[n].得到物品位置类型() == 12 && (Item_In_Bag[n].属性1.属性类型 == 7 || Item_In_Bag[n].属性2.属性类型 == 7 || Item_In_Bag[n].属性3.属性类型 == 7 || Item_In_Bag[n].属性4.属性类型 == 7))
									{
										Form1.WriteLine(6, "发现WG防物品 装备栏以穿装备 [" + Userid + "]-[" + UserName + "] 位置[" + n + "] 编号[" + BitConverter.ToInt32(Item_In_Bag[n].物品全局ID, 0) + "] 物品名称[" + Item_In_Bag[n].Get_Name() + "] 物品数量[" + BitConverter.ToInt32(Item_In_Bag[n].Item_Amount, 0) + "] 属性:[" + Item_Wear[n].FLD_MAGIC0 + "," + Item_Wear[n].FLD_MAGIC1 + "," + Item_Wear[n].FLD_MAGIC2 + "," + Item_Wear[n].FLD_MAGIC3 + "," + Item_Wear[n].FLD_MAGIC4 + "]");
										Item_In_Bag[n].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
									}
								}
								else if (Item_In_Bag[n].属性1.属性类型 == 7 || Item_In_Bag[n].属性2.属性类型 == 7 || Item_In_Bag[n].属性3.属性类型 == 7 || Item_In_Bag[n].属性4.属性类型 == 7)
								{
									Form1.WriteLine(6, "发现WG防物品 装备栏以穿装备 [" + Userid + "]-[" + UserName + "] 位置[" + n + "] 编号[" + BitConverter.ToInt32(Item_In_Bag[n].物品全局ID, 0) + "] 物品名称[" + Item_In_Bag[n].Get_Name() + "] 物品数量[" + BitConverter.ToInt32(Item_In_Bag[n].Item_Amount, 0) + "] 属性:[" + Item_Wear[n].FLD_MAGIC0 + "," + Item_Wear[n].FLD_MAGIC1 + "," + Item_Wear[n].FLD_MAGIC2 + "," + Item_Wear[n].FLD_MAGIC3 + "," + Item_Wear[n].FLD_MAGIC4 + "]");
									Item_In_Bag[n].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
								}
							}
							catch (Exception ex2)
							{
								Form1.WriteLine(1, "查物品错误    装备栏包裹 错误 [" + Userid + "]-[" + UserName + "] 位置[" + n + "] 编号[" + BitConverter.ToInt32(Item_In_Bag[n].物品全局ID, 0) + "] 物品名称[" + Item_In_Bag[n].Get_Name() + "] 物品数量[" + BitConverter.ToInt32(Item_In_Bag[n].Item_Amount, 0) + "] 属性:[" + Item_Wear[n].FLD_MAGIC0 + "," + Item_Wear[n].FLD_MAGIC1 + "," + Item_Wear[n].FLD_MAGIC2 + "," + Item_Wear[n].FLD_MAGIC3 + "," + Item_Wear[n].FLD_MAGIC4 + "]" + ex2);
							}
						}
					}
					else
					{
						Item_In_Bag[n] = new 物品类(array14, n);
					}
				}
				byte[] array16 = (byte[])dBToDataTable.Rows[0]["FLD_NTCITEM"];
				for (int n = 0; n < 6; n++)
				{
					byte[] array14 = new byte[(World.Newversion >= 14) ? 76 : 73];
					if (array16.Length >= n * ((World.Newversion >= 14) ? 76 : 73) + ((World.Newversion >= 14) ? 76 : 73))
					{
						try
						{
							Buffer.BlockCopy(array16, n * ((World.Newversion >= 14) ? 76 : 73), array14, 0, (World.Newversion >= 14) ? 76 : 73);
						}
						catch (Exception arg3)
						{
							Console.WriteLine(n + " " + arg3);
						}
						Item_NTC[n] = new 物品类(array14, n);
						byte[] array15 = new byte[4];
						Buffer.BlockCopy(Item_NTC[n].Byte_Item, 56, array15, 0, 4);
						int num10 = BitConverter.ToInt32(array15, 0);
						if (num10 > 0)
						{
							DateTime dateTime = new DateTime(1970, 1, 1, 7, 0, 0);
							if (DateTime.Now.Subtract(dateTime.AddSeconds(num10)).TotalSeconds >= 0.0)
							{
								GameMessage("背包有物品过期[" + Item_NTC[n].Get_Name() + "],系统已删除！", 9);
								Item_NTC[n].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
							}
						}
					}
					else
					{
						Item_NTC[n] = new 物品类(array14, n);
					}
				}
				byte[] array17 = (byte[])dBToDataTable.Rows[0]["FLD_COATITEM"];
				for (int n = 0; n < 60; n++)
				{
					byte[] array14 = new byte[(World.Newversion >= 14) ? 76 : 73];
					if (array17.Length >= n * ((World.Newversion >= 14) ? 76 : 73) + ((World.Newversion >= 14) ? 76 : 73))
					{
						try
						{
							Buffer.BlockCopy(array17, n * ((World.Newversion >= 14) ? 76 : 73), array14, 0, (World.Newversion >= 14) ? 76 : 73);
						}
						catch (Exception arg3)
						{
							Console.WriteLine(n + " " + arg3);
						}
						Item_Coat[n] = new 物品类(array14, n);
						byte[] array15 = new byte[4];
						Buffer.BlockCopy(Item_Coat[n].Byte_Item, 56, array15, 0, 4);
						int num10 = BitConverter.ToInt32(array15, 0);
						if (num10 > 0)
						{
							DateTime dateTime = new DateTime(1970, 1, 1, 7, 0, 0);
							if (DateTime.Now.Subtract(dateTime.AddSeconds(num10)).TotalSeconds >= 0.0)
							{
								GameMessage("背包有物品过期[" + Item_Coat[n].Get_Name() + "],系统已删除！", 9);
								Item_Coat[n].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
							}
						}
					}
					else
					{
						Item_Coat[n] = new 物品类(array14, n);
					}
				}
				byte[] array18 = (byte[])dBToDataTable.Rows[0]["FLD_WEARITEM"];
				for (int n = 0; n < 16; n++)
				{
					byte[] array14 = new byte[(World.Newversion >= 14) ? 76 : 73];
					if (array18.Length >= n * ((World.Newversion >= 14) ? 76 : 73) + ((World.Newversion >= 14) ? 76 : 73))
					{
						try
						{
							Buffer.BlockCopy(array18, n * ((World.Newversion >= 14) ? 76 : 73), array14, 0, (World.Newversion >= 14) ? 76 : 73);
						}
						catch (Exception arg3)
						{
							Console.WriteLine(n + " " + arg3);
						}
						Item_Wear[n] = new 物品类(array14, n);
						byte[] array15 = new byte[4];
						Buffer.BlockCopy(Item_Wear[n].Byte_Item, 56, array15, 0, 4);
						int num10 = BitConverter.ToInt32(array15, 0);
						if (num10 > 0)
						{
							DateTime dateTime = new DateTime(1970, 1, 1, 7, 0, 0);
							if (DateTime.Now.Subtract(dateTime.AddSeconds(num10)).TotalSeconds >= 0.0)
							{
								GameMessage("已穿装备栏有物品过期[" + Item_Wear[n].Get_Name() + "],系统已删除！", 9);
								Item_Wear[n].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
							}
						}
						if (World.AllItmelog == 1)
						{
							try
							{
								if (Item_Wear[n].得到物品位置类型() != 1 && Item_Wear[n].得到物品位置类型() != 2 && Item_Wear[n].得到物品位置类型() != 5 && Item_Wear[n].得到物品位置类型() != 6)
								{
									if (Item_Wear[n].得到物品位置类型() != 4 && Item_Wear[n].得到物品位置类型() == 12 && (Item_Wear[n].属性1.属性类型 == 7 || Item_Wear[n].属性2.属性类型 == 7 || Item_Wear[n].属性3.属性类型 == 7 || Item_Wear[n].属性4.属性类型 == 7))
									{
										Form1.WriteLine(6, "发现WG防物品 装备栏以穿装备 [" + Userid + "]-[" + UserName + "] 位置[" + n + "] 编号[" + BitConverter.ToInt32(Item_Wear[n].物品全局ID, 0) + "] 物品名称[" + Item_Wear[n].Get_Name() + "] 物品数量[" + BitConverter.ToInt32(Item_Wear[n].Item_Amount, 0) + "] 属性:[" + Item_Wear[n].FLD_MAGIC0 + "," + Item_Wear[n].FLD_MAGIC1 + "," + Item_Wear[n].FLD_MAGIC2 + "," + Item_Wear[n].FLD_MAGIC3 + "," + Item_Wear[n].FLD_MAGIC4 + "]");
										Item_Wear[n].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
									}
								}
								else if (Item_Wear[n].属性1.属性类型 == 7 || Item_Wear[n].属性2.属性类型 == 7 || Item_Wear[n].属性3.属性类型 == 7 || Item_Wear[n].属性4.属性类型 == 7)
								{
									Form1.WriteLine(6, "发现WG防物品 装备栏以穿装备 [" + Userid + "]-[" + UserName + "] 位置[" + n + "] 编号[" + BitConverter.ToInt32(Item_Wear[n].物品全局ID, 0) + "] 物品名称[" + Item_Wear[n].Get_Name() + "] 物品数量[" + BitConverter.ToInt32(Item_Wear[n].Item_Amount, 0) + "] 属性:[" + Item_Wear[n].FLD_MAGIC0 + "," + Item_Wear[n].FLD_MAGIC1 + "," + Item_Wear[n].FLD_MAGIC2 + "," + Item_Wear[n].FLD_MAGIC3 + "," + Item_Wear[n].FLD_MAGIC4 + "]");
									Item_Wear[n].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
								}
							}
							catch (Exception ex2)
							{
								Form1.WriteLine(1, "查物品错误    装备栏包裹 错误 [" + Userid + "]-[" + UserName + "] 位置[" + n + "] 编号[" + BitConverter.ToInt32(Item_Wear[n].物品全局ID, 0) + "] 物品名称[" + Item_Wear[n].Get_Name() + "] 物品数量[" + BitConverter.ToInt32(Item_Wear[n].Item_Amount, 0) + "] 属性:[" + Item_Wear[n].FLD_MAGIC0 + "," + Item_Wear[n].FLD_MAGIC1 + "," + Item_Wear[n].FLD_MAGIC2 + "," + Item_Wear[n].FLD_MAGIC3 + "," + Item_Wear[n].FLD_MAGIC4 + "]" + ex2);
							}
						}
					}
					else
					{
						Item_Wear[n] = new 物品类(array14, n);
					}
				}
				byte[] array19 = (byte[])dBToDataTable.Rows[0]["FLD_QUEST"];
				for (int num11 = 0; num11 * 4 + 4 <= array19.Length; num11++)
				{
					byte[] array20 = new byte[4];
					try
					{
						Buffer.BlockCopy(array19, num11 * 4, array20, 0, 4);
						任务类 任务类 = new 任务类(array20);
						if (任务类.任务ID != 0 && !任务.ContainsKey(任务类.任务ID))
						{
							任务.Add(任务类.任务ID, 任务类);
						}
					}
					catch (Exception value2)
					{
						Console.WriteLine(value2);
					}
				}
				DataTable userWarehouse = RxjhClass.GetUserWarehouse(Userid, UserName);
				if (userWarehouse == null && Client != null)
				{
					GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 5", 7);
					Client.Dispose();
				}
				byte[] array21 = (byte[])userWarehouse.Rows[0]["FLD_ITEM"];
				try
				{
					个人仓库钱数 = long.Parse(userWarehouse.Rows[0]["FLD_MONEY"].ToString());
				}
				catch
				{
					个人仓库钱数 = 0L;
				}
				for (int n = 0; n < 60; n++)
				{
					byte[] array14 = new byte[(World.Newversion >= 14) ? 76 : 73];
					if (array21.Length >= n * ((World.Newversion >= 14) ? 76 : 73) + ((World.Newversion >= 14) ? 76 : 73))
					{
						try
						{
							Buffer.BlockCopy(array21, n * ((World.Newversion >= 14) ? 76 : 73), array14, 0, (World.Newversion >= 14) ? 76 : 73);
						}
						catch (Exception arg3)
						{
							Console.WriteLine(n + " " + arg3);
						}
						个人仓库[n] = new 物品类(array14, n);
						byte[] array15 = new byte[4];
						Buffer.BlockCopy(个人仓库[n].Byte_Item, 56, array15, 0, 4);
						int num10 = BitConverter.ToInt32(array15, 0);
						if (num10 > 0)
						{
							DateTime dateTime = new DateTime(1970, 1, 1, 7, 0, 0);
							if (DateTime.Now.Subtract(dateTime.AddSeconds(num10)).TotalSeconds >= 0.0)
							{
								GameMessage("个人仓库有物品过期[" + 个人仓库[n].Get_Name() + "],系统已删除！", 9);
								个人仓库[n].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
							}
						}
						if (World.AllItmelog == 1)
						{
							try
							{
								if (个人仓库[n].得到物品位置类型() != 1 && 个人仓库[n].得到物品位置类型() != 2 && 个人仓库[n].得到物品位置类型() != 5 && 个人仓库[n].得到物品位置类型() != 6)
								{
									if (个人仓库[n].得到物品位置类型() != 4 && 个人仓库[n].得到物品位置类型() == 12 && (个人仓库[n].属性1.属性类型 == 7 || 个人仓库[n].属性2.属性类型 == 7 || 个人仓库[n].属性3.属性类型 == 7 || 个人仓库[n].属性4.属性类型 == 7))
									{
										Form1.WriteLine(6, "发现WG防物品 个人仓库 [" + Userid + "]-[" + UserName + "] 位置[" + n + "] 编号[" + BitConverter.ToInt32(个人仓库[n].物品全局ID, 0) + "] 物品名称[" + 个人仓库[n].Get_Name() + "] 物品数量[" + BitConverter.ToInt32(个人仓库[n].Item_Amount, 0) + "] 属性:[" + 个人仓库[n].FLD_MAGIC0 + "," + 个人仓库[n].FLD_MAGIC1 + "," + 个人仓库[n].FLD_MAGIC2 + "," + 个人仓库[n].FLD_MAGIC3 + "," + 个人仓库[n].FLD_MAGIC4 + "]");
										个人仓库[n].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
									}
								}
								else if (个人仓库[n].属性1.属性类型 == 7 || 个人仓库[n].属性2.属性类型 == 7 || 个人仓库[n].属性3.属性类型 == 7 || 个人仓库[n].属性4.属性类型 == 7)
								{
									Form1.WriteLine(6, "发现WG防物品 个人仓库 [" + Userid + "]-[" + UserName + "] 位置[" + n + "] 编号[" + BitConverter.ToInt32(个人仓库[n].物品全局ID, 0) + "] 物品名称[" + 个人仓库[n].Get_Name() + "] 物品数量[" + BitConverter.ToInt32(个人仓库[n].Item_Amount, 0) + "] 属性:[" + 个人仓库[n].FLD_MAGIC0 + "," + 个人仓库[n].FLD_MAGIC1 + "," + 个人仓库[n].FLD_MAGIC2 + "," + 个人仓库[n].FLD_MAGIC3 + "," + 个人仓库[n].FLD_MAGIC4 + "]");
									个人仓库[n].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
								}
							}
							catch (Exception ex3)
							{
								Form1.WriteLine(1, "查物品错误    个人仓库 错误  [" + Userid + "]-[" + UserName + "] 位置[" + n + "] 编号[" + BitConverter.ToInt32(个人仓库[n].物品全局ID, 0) + "] 物品名称[" + 个人仓库[n].Get_Name() + "] 物品数量[" + BitConverter.ToInt32(个人仓库[n].Item_Amount, 0) + "] 属性:[" + 个人仓库[n].FLD_MAGIC0 + "," + 个人仓库[n].FLD_MAGIC1 + "," + 个人仓库[n].FLD_MAGIC2 + "," + 个人仓库[n].FLD_MAGIC3 + "," + 个人仓库[n].FLD_MAGIC4 + "]" + ex3);
							}
						}
					}
				}
				userWarehouse.Dispose();
				DataTable userPublicWarehouse = RxjhClass.GetUserPublicWarehouse(Userid);
				if (userPublicWarehouse == null && Client != null)
				{
					GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 4", 7);
					Client.Dispose();
				}
				byte[] array22 = (byte[])userPublicWarehouse.Rows[0]["FLD_ITEM"];
				综合仓库装备数据版本 = (int)userPublicWarehouse.Rows[0]["FLD_ZBVER"];
				try
				{
					综合仓库钱数 = long.Parse(userPublicWarehouse.Rows[0]["FLD_MONEY"].ToString());
				}
				catch
				{
					综合仓库钱数 = 0L;
				}
				int num12 = 0;
				while (true)
				{
					传书列表.Clear();
					DataTable dataTable = RxjhClass.Check_Email_Name(UserName);
					if (dataTable != null)
					{
						for (int num13 = 0; num13 < dataTable.Rows.Count; num13++)
						{
							EmailClass emailClass = new EmailClass();
							emailClass.method_1((int)dataTable.Rows[num13]["ID"]);
							emailClass.method_11((int)dataTable.Rows[num13]["发送NPC"]);
							emailClass.method_3(dataTable.Rows[num13]["发送人物名"].ToString());
							emailClass.method_5("[ID: " + dataTable.Rows[num13]["ID"].ToString() + "] - " + dataTable.Rows[num13]["传书内容"].ToString());
							emailClass.method_7(DateTime.Parse(dataTable.Rows[num13]["传书时间"].ToString()));
							emailClass.Set_Read_Email((int)dataTable.Rows[num13]["阅读标识"]);
							传书列表.Add(emailClass.method_0(), emailClass);
						}
						Update_Email();
						Send_New_Email();
						dataTable.Dispose();
					}
					if (num12 >= 60)
					{
						break;
					}
					byte[] array23 = new byte[(World.Newversion >= 14) ? 76 : 73];
					if (array22.Length >= num12 * ((World.Newversion >= 14) ? 76 : 73) + ((World.Newversion >= 14) ? 76 : 73))
					{
						try
						{
							Buffer.BlockCopy(array22, num12 * ((World.Newversion >= 14) ? 76 : 73), array23, 0, (World.Newversion >= 14) ? 76 : 73);
						}
						catch (Exception value3)
						{
							Console.WriteLine(value3);
						}
					}
					公共仓库[num12] = new 物品类(array23, num12);
					byte[] array24 = new byte[4];
					Buffer.BlockCopy(公共仓库[num12].Byte_Item, 56, array24, 0, 4);
					int num14 = BitConverter.ToInt32(array24, 0);
					if (num14 > 0)
					{
						DateTime dateTime = new DateTime(1970, 1, 1, 7, 0, 0);
						if (DateTime.Now.Subtract(dateTime.AddSeconds(num14)).TotalSeconds >= 0.0)
						{
							GameMessage("公共仓库有物品过期[" + 公共仓库[num12].Get_Name() + "],系统已删除！", 9);
							公共仓库[num12].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
						}
					}
					if (World.AllItmelog == 1)
					{
						try
						{
							if (公共仓库[num12].得到物品位置类型() != 1 && 公共仓库[num12].得到物品位置类型() != 2 && 公共仓库[num12].得到物品位置类型() != 5 && 公共仓库[num12].得到物品位置类型() != 6)
							{
								if (公共仓库[num12].得到物品位置类型() != 4 && 公共仓库[num12].得到物品位置类型() == 12 && (公共仓库[num12].属性1.属性类型 == 7 || 公共仓库[num12].属性2.属性类型 == 7 || 公共仓库[num12].属性3.属性类型 == 7 || 公共仓库[num12].属性4.属性类型 == 7))
								{
									Form1.WriteLine(6, "发现WG防物品 公共仓库 [" + Userid + "]-[" + UserName + "] 位置[" + num12 + "] 编号[" + BitConverter.ToInt32(公共仓库[num12].物品全局ID, 0) + "] 物品名称[" + 公共仓库[num12].Get_Name() + "] 物品数量[" + BitConverter.ToInt32(公共仓库[num12].Item_Amount, 0) + "] 属性:[" + 公共仓库[num12].FLD_MAGIC0 + "," + 公共仓库[num12].FLD_MAGIC1 + "," + 公共仓库[num12].FLD_MAGIC2 + "," + 公共仓库[num12].FLD_MAGIC3 + "," + 公共仓库[num12].FLD_MAGIC4 + "]");
									公共仓库[num12].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
								}
							}
							else if (公共仓库[num12].属性1.属性类型 == 7 || 公共仓库[num12].属性2.属性类型 == 7 || 公共仓库[num12].属性3.属性类型 == 7 || 公共仓库[num12].属性4.属性类型 == 7)
							{
								Form1.WriteLine(6, "发现WG防物品 公共仓库 [" + Userid + "]-[" + UserName + "] 位置[" + num12 + "] 编号[" + BitConverter.ToInt32(公共仓库[num12].物品全局ID, 0) + "] 物品名称[" + 公共仓库[num12].Get_Name() + "] 物品数量[" + BitConverter.ToInt32(公共仓库[num12].Item_Amount, 0) + "] 属性:[" + 公共仓库[num12].FLD_MAGIC0 + "," + 公共仓库[num12].FLD_MAGIC1 + "," + 公共仓库[num12].FLD_MAGIC2 + "," + 公共仓库[num12].FLD_MAGIC3 + "," + 公共仓库[num12].FLD_MAGIC4 + "]");
								公共仓库[num12].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
							}
						}
						catch (Exception ex4)
						{
							Form1.WriteLine(1, "查物品错误    个人仓库 错误 [" + Userid + "]-[" + UserName + "] 位置[" + num12 + "] 编号[" + BitConverter.ToInt32(公共仓库[num12].物品全局ID, 0) + "] 物品名称[" + 公共仓库[num12].Get_Name() + "] 物品数量[" + BitConverter.ToInt32(公共仓库[num12].Item_Amount, 0) + "] 属性:[" + 公共仓库[num12].FLD_MAGIC0 + "," + 公共仓库[num12].FLD_MAGIC1 + "," + 公共仓库[num12].FLD_MAGIC2 + "," + 公共仓库[num12].FLD_MAGIC3 + "," + 公共仓库[num12].FLD_MAGIC4 + "]" + ex4);
						}
					}
					num12++;
				}
				userPublicWarehouse.Dispose();
				byte[] array25 = (byte[])dBToDataTable.Rows[0]["FLD_STIME"];
				if (array25 != null && array25.Length > 1)
				{
					for (int k = 0; k < 40; k++)
					{
						try
						{
							byte[] array26 = new byte[4];
							byte[] array27 = new byte[4];
							Buffer.BlockCopy(array25, k * 8, array26, 0, 4);
							Buffer.BlockCopy(array25, k * 8 + 4, array27, 0, 4);
							if (BitConverter.ToInt32(array26, 0) > 0)
							{
								if (!list_时间药品.ContainsKey(BitConverter.ToInt32(array26, 0)))
								{
									时间药品 时间药品 = new 时间药品();
									时间药品.FLD_PID = BitConverter.ToInt32(array26, 0);
									时间药品.FLD_sj = BitConverter.ToInt32(array27, 0);
									list_时间药品.Add(时间药品.FLD_PID, 时间药品);
								}
								continue;
							}
						}
						catch (Exception value4)
						{
							Console.WriteLine(value4);
							continue;
						}
						break;
					}
				}
				if (!dBToDataTable.Rows[0]["FLD_CTIME"].Equals(null))
				{
					五色神丹 = (byte[])dBToDataTable.Rows[0]["FLD_CTIME"];
				}
				if (!dBToDataTable.Rows[0]["FLD_CTIMENEW"].Equals(null))
				{
					追加状态物品 = (byte[])dBToDataTable.Rows[0]["FLD_CTIMENEW"];
				}
				byte[] src = (byte[])userPublicWarehouse.Rows[0]["FLD_ITIME"];
				byte[] array28 = new byte[16];
				Buffer.BlockCopy(src, 0, array28, 0, 16);
				int num15 = 0;
				while (true)
				{
					bool flag2 = true;
					if (num15 < 2)
					{
						try
						{
							byte[] array29 = new byte[4];
							byte[] array30 = new byte[4];
							Buffer.BlockCopy(array28, num15 * 8, array29, 0, 4);
							Buffer.BlockCopy(array28, num15 * 8 + 4, array30, 0, 4);
							DateTime t = new DateTime(1970, 1, 1, 7, 0, 0).AddSeconds(BitConverter.ToInt32(array30, 0));
							if (!(t < DateTime.Now) && BitConverter.ToInt32(array29, 0) > 0)
							{
								if (!公有药品.ContainsKey(BitConverter.ToInt32(array29, 0)))
								{
									公有药品类 公有药品类 = new 公有药品类();
									公有药品类.药品ID = BitConverter.ToInt32(array29, 0);
									公有药品类.时间 = BitConverter.ToInt32(array30, 0);
									公有药品.Add(公有药品类.药品ID, 公有药品类);
								}
								goto IL_4232;
							}
						}
						catch (Exception value5)
						{
							Console.WriteLine(value5);
							goto IL_4232;
						}
					}
					break;
					IL_4232:
					num15++;
				}
				byte[] array31 = null;
				if (dBToDataTable.Rows[0]["FLD_DOORS"] != null)
				{
					array31 = (byte[])dBToDataTable.Rows[0]["FLD_DOORS"];
				}
				土灵符坐标.Clear();
				if (array31.Length >= 128)
				{
					for (int num16 = 0; num16 < 30; num16++)
					{
						try
						{
							byte[] array32 = new byte[4];
							byte[] array33 = new byte[4];
							byte[] array34 = new byte[4];
							byte[] array35 = new byte[4];
							byte[] array36 = new byte[14];
							Buffer.BlockCopy(array31, num16 * 32 + 15, array35, 0, 4);
							Buffer.BlockCopy(array31, num16 * 32 + 19, array32, 0, 4);
							Buffer.BlockCopy(array31, num16 * 32 + 23, array33, 0, 4);
							Buffer.BlockCopy(array31, num16 * 32 + 27, array34, 0, 4);
							Buffer.BlockCopy(array31, num16 * 32, array36, 0, 14);
							string @string = Encoding.GetEncoding(1252).GetString(array36);
							if (BitConverter.ToSingle(array32, 0) != 0f || BitConverter.ToSingle(array33, 0) != 0f || BitConverter.ToInt32(array35, 0) != 0)
							{
								坐标Class 坐标Class = new 坐标Class(BitConverter.ToSingle(array32, 0), BitConverter.ToSingle(array33, 0), BitConverter.ToSingle(array34, 0), BitConverter.ToInt32(array35, 0));
								坐标Class.Rxjh_Name = @string;
								if (土灵符坐标.ContainsKey(10 + num16))
								{
									土灵符坐标.Remove(10 + num16);
								}
								土灵符坐标.Add(10 + num16, 坐标Class);
							}
						}
						catch (Exception)
						{
						}
					}
				}
				DataTable userNameBp = RxjhClass.GetUserNameBp(UserName);
				if (userNameBp != null)
				{
					Guild_ID = (int)userNameBp.Rows[0]["Id"];
					Guild_Name = userNameBp.Rows[0]["G_Name"].ToString();
					Guild_Level = (int)userNameBp.Rows[0]["leve"];
					Guild_Style = (int)userNameBp.Rows[0]["门服字"];
					Guild_Style_Color = (int)userNameBp.Rows[0]["门服颜色"];
					try
					{
						if (userNameBp.Rows[0]["Mh"] != DBNull.Value)
						{
							Guild_Icon = (byte[])userNameBp.Rows[0]["Mh"];
						}
					}
					catch (Exception value6)
					{
						Console.WriteLine(value6);
					}
					userNameBp.Dispose();
				}
				计算人物基本数据();
				dBToDataTable.Dispose();
				装备数据版本 = 1;
				综合仓库装备数据版本 = 1;
			}
			catch (Exception ex6)
			{
				Form1.WriteLine(2, "读出人物数据出错 " + Userid + "  " + ex6.Message);
				GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 3", 7);
				Client.Dispose();
			}
		}

		public void Auto_Learn_Skill()
		{
			if (Player_Job_Level >= 5 && Player_Job != 8 && Player_Job != 9)
			{
				if (Array_Skill_Book[0, 25] == null)
				{
					Client.Player.学习技能(0, 25);
				}
				if (Array_Skill_Book[0, 26] == null)
				{
					Client.Player.学习技能(0, 26);
				}
				if (Array_Skill_Book[0, 27] == null)
				{
					Client.Player.学习技能(0, 27);
				}
			}
			if (Player_Job_Level >= 6 && Player_Job != 8 && Player_Job != 9 && Player_Job != 11)
			{
				if (Array_Skill_Book[3, 1] == null)
				{
					Client.Player.学习技能(3, 1);
				}
				if (Array_Skill_Book[3, 2] == null)
				{
					Client.Player.学习技能(3, 2);
				}
			}
			if (Player_Job_Level >= 7 && Player_Job != 8 && Player_Job != 9 && Player_Job != 11)
			{
				if (Array_Skill_Book[3, 4] == null)
				{
					Client.Player.学习技能(3, 4);
				}
				if (Array_Skill_Book[3, 5] == null)
				{
					Client.Player.学习技能(3, 5);
				}
			}
			if (Player_Job_Level >= 8 && Player_Job != 8 && Player_Job != 9 && Player_Job != 11)
			{
				if (Array_Skill_Book[3, 7] == null)
				{
					Client.Player.学习技能(3, 7);
				}
				if (Array_Skill_Book[3, 8] == null)
				{
					Client.Player.学习技能(3, 8);
				}
			}
			if (Player_Job_Level >= 9 && Player_Job != 8 && Player_Job != 9 && Player_Job != 11)
			{
				if (Array_Skill_Book[3, 10] == null)
				{
					Client.Player.学习技能(3, 10);
				}
				if (Array_Skill_Book[3, 11] == null)
				{
					Client.Player.学习技能(3, 11);
				}
			}
			if (Player_Job_Level >= 10 && Player_Job != 8 && Player_Job != 9 && Player_Job != 11)
			{
				if (Array_Skill_Book[3, 13] == null)
				{
					Client.Player.学习技能(3, 13);
				}
				if (Array_Skill_Book[3, 14] == null)
				{
					Client.Player.学习技能(3, 14);
				}
			}
			if (Player_Job == 10)
			{
				if (Array_Skill_Book[0, 1] == null)
				{
					Client.Player.学习技能(0, 1);
				}
				if (Array_Skill_Book[0, 2] == null)
				{
					Client.Player.学习技能(0, 2);
				}
			}
			if (Player_Job == 11 || Player_Job == 12)
			{
				if (Player_Job_Level >= 6)
				{
					if (Array_Skill_Book[3, 1] == null)
					{
						Client.Player.学习技能(3, 1);
					}
					if (Array_Skill_Book[3, 2] == null)
					{
						Client.Player.学习技能(3, 2);
					}
					if (Array_Skill_Book[3, 3] == null)
					{
						Client.Player.学习技能(3, 3);
					}
				}
				if (Player_Job_Level >= 7)
				{
					if (Array_Skill_Book[3, 5] == null)
					{
						Client.Player.学习技能(3, 5);
					}
					if (Array_Skill_Book[3, 6] == null)
					{
						Client.Player.学习技能(3, 6);
					}
					if (Array_Skill_Book[3, 7] == null)
					{
						Client.Player.学习技能(3, 7);
					}
				}
				if (Player_Job_Level >= 8)
				{
					if (Array_Skill_Book[3, 9] == null)
					{
						Client.Player.学习技能(3, 9);
					}
					if (Array_Skill_Book[3, 10] == null)
					{
						Client.Player.学习技能(3, 10);
					}
					if (Array_Skill_Book[3, 11] == null)
					{
						Client.Player.学习技能(3, 11);
					}
				}
				if (Player_Job_Level >= 9)
				{
					if (Array_Skill_Book[3, 13] == null)
					{
						Client.Player.学习技能(3, 13);
					}
					if (Array_Skill_Book[3, 14] == null)
					{
						Client.Player.学习技能(3, 14);
					}
					if (Array_Skill_Book[3, 15] == null)
					{
						Client.Player.学习技能(3, 15);
					}
				}
				if (Player_Job_Level >= 10)
				{
					if (Array_Skill_Book[3, 17] == null)
					{
						Client.Player.学习技能(3, 17);
					}
					if (Array_Skill_Book[3, 18] == null)
					{
						Client.Player.学习技能(3, 18);
					}
					if (Array_Skill_Book[3, 19] == null)
					{
						Client.Player.学习技能(3, 19);
					}
				}
			}
			if (Player_Job == 8)
			{
				if (Array_Skill_Book[3, 1] == null && Player_Job_Level >= 6)
				{
					Client.Player.学习技能(3, 1, 1);
				}
				if (Array_Skill_Book[3, 5] == null && Player_Job_Level >= 7)
				{
					Client.Player.学习技能(3, 5, 1);
				}
				if (Array_Skill_Book[3, 9] == null && Player_Job_Level >= 8)
				{
					Client.Player.学习技能(3, 9, 1);
				}
				if (Array_Skill_Book[3, 13] == null && Player_Job_Level >= 9)
				{
					Client.Player.学习技能(3, 13, 1);
				}
				if (Array_Skill_Book[3, 17] == null && Player_Job_Level >= 10)
				{
					Client.Player.学习技能(3, 17, 1);
				}
				if (World.Newversion >= 17)
				{
					if (Array_Skill_Book[3, 22] == null && Player_Job_Level >= 6)
					{
						Client.Player.学习技能(3, 22, 1);
					}
					if (Array_Skill_Book[3, 23] == null && Player_Job_Level >= 6)
					{
						Client.Player.学习技能(3, 23, 1);
					}
					if (Array_Skill_Book[3, 24] == null && Player_Job_Level >= 6)
					{
						Client.Player.学习技能(3, 24, 1);
					}
				}
				else
				{
					if (Array_Skill_Book[3, 17] == null && Player_Job_Level >= 6)
					{
						Client.Player.学习技能(3, 17, 1);
					}
					if (Array_Skill_Book[3, 18] == null && Player_Job_Level >= 6)
					{
						Client.Player.学习技能(3, 18, 1);
					}
					if (Array_Skill_Book[3, 19] == null && Player_Job_Level >= 6)
					{
						Client.Player.学习技能(3, 19, 1);
					}
				}
				if (Array_Skill_Book[0, 22] == null && Player_Job_Level >= 6)
				{
					Client.Player.学习技能(0, 22, 1);
				}
				if (Array_Skill_Book[0, 23] == null && Player_Job_Level >= 7)
				{
					Client.Player.学习技能(0, 23, 1);
				}
				if (Array_Skill_Book[0, 24] == null && Player_Job_Level >= 8)
				{
					Client.Player.学习技能(0, 24, 1);
				}
				if (Array_Skill_Book[0, 25] == null && Player_Job_Level >= 7)
				{
					Client.Player.学习技能(0, 25, 1);
				}
				if (Array_Skill_Book[0, 26] == null && Player_Job_Level >= 8)
				{
					Client.Player.学习技能(0, 26, 1);
				}
				if (Array_Skill_Book[0, 27] == null && Player_Job_Level >= 9)
				{
					Client.Player.学习技能(0, 27, 1);
				}
				if (Array_Skill_Book[0, 28] == null && Player_Job_Level >= 9)
				{
					Client.Player.学习技能(0, 28, 1);
				}
				if (Array_Skill_Book[0, 17] == null && Player_Level >= 60)
				{
					Client.Player.学习技能(0, 17, 1);
				}
				if (Array_Skill_Book[0, 21] == null && Player_Level >= 100)
				{
					Client.Player.学习技能(0, 21, 1);
				}
			}
			if (Player_Job == 9)
			{
				if (Array_Skill_Book[3, 13] == null && Player_Job_Level >= 6)
				{
					Client.Player.学习技能(3, 13, 1);
				}
				if (Array_Skill_Book[3, 14] == null && Player_Job_Level >= 6)
				{
					Client.Player.学习技能(3, 14, 1);
				}
				if (Array_Skill_Book[3, 15] == null && Player_Job_Level >= 6)
				{
					Client.Player.学习技能(3, 15, 1);
				}
				if (Array_Skill_Book[3, 16] == null && Player_Job_Level >= 8)
				{
					Client.Player.学习技能(3, 16, 1);
				}
				if (Array_Skill_Book[3, 17] == null && Player_Job_Level >= 8)
				{
					Client.Player.学习技能(3, 17, 1);
				}
				if (Array_Skill_Book[3, 18] == null && Player_Job_Level >= 9)
				{
					Client.Player.学习技能(3, 18, 1);
				}
				if (Array_Skill_Book[3, 19] == null && Player_Job_Level >= 9)
				{
					Client.Player.学习技能(3, 19, 1);
				}
				if (Array_Skill_Book[3, 20] == null && Player_Job_Level >= 10)
				{
					Client.Player.学习技能(3, 20, 1);
				}
				if (Array_Skill_Book[3, 21] == null && Player_Job_Level >= 10)
				{
					Client.Player.学习技能(3, 21, 1);
				}
				if (Player_Level >= 25 && Array_Skill_Book[2, 0] == null && Array_Skill_Book[2, 1] == null && Array_Skill_Book[2, 2] == null)
				{
					Client.Player.学习技能(2, 0);
					Client.Player.学习技能(2, 1);
					Client.Player.学习技能(2, 2);
				}
				if (Player_Level >= 70 && Array_Skill_Book[2, 3] == null && Array_Skill_Book[2, 4] == null && Array_Skill_Book[2, 5] == null && Array_Skill_Book[2, 6] == null)
				{
					Client.Player.学习技能(2, 3);
					Client.Player.学习技能(2, 4);
					Client.Player.学习技能(2, 5);
					Client.Player.学习技能(2, 6);
				}
				if (Player_Level >= 100 && Array_Skill_Book[2, 7] == null && Array_Skill_Book[2, 8] == null && Array_Skill_Book[2, 9] == null && Array_Skill_Book[2, 10] == null && Array_Skill_Book[2, 11] == null)
				{
					Client.Player.学习技能(2, 7);
					Client.Player.学习技能(2, 8);
					Client.Player.学习技能(2, 9);
					Client.Player.学习技能(2, 10);
					Client.Player.学习技能(2, 11);
				}
			}
			if (Array_Skill_Book[1, 2] != null)
			{
				人物轻功 = 2;
			}
			else if (Array_Skill_Book[1, 1] != null)
			{
				人物轻功 = 1;
			}
		}

		public virtual void SendRangeOfPackets(byte[] data, int length)
		{
		}

		public virtual void SendRangeOfPackets(PacketData pak, int id, int wordid)
		{
		}

		public void 发送弓使用群攻技能数据(int 武功PID, int id)
		{
			PacketData packetData = new PacketData();
			packetData.WriteInt(武功PID);
			packetData.WriteByte(id);
			if (Client != null)
			{
				Client.SendPak(packetData, 15616, UserSessionID);
			}
		}

		public void 发送门徽(Players ToPlay, Players Play)
		{
			string hex = "AA551903010A00EB000A034200000001000100FF00FFFF00FF0000FF0000FFFF00FFFF00FFFF00FFFF00FFFF00FFFF00FFFFFF80FF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFF00FF0000FF0000FF0000FFFF00FFFF00FFFF00FFFF00FFFF00FFFFFF80FF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFF00FF0000FFFF00FF0000FFFF00FF0000FFFF00FFFF00FFFFFF80FF00FFFFFF80FFFF80FFFF80FF00FFFFFF80FF00FFFF00FF0000FFFF00FF0000FFFF00FF0000FFFF00FFFF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFFFF80FFFF80FF00FFFF00FF0000FFFF00FF0000FF0000FF0000FFFF00FFFF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFFFF80FFFF80FF00FFFF00FF0000FFFF00FFFF00FF0000FF0000FF0000FFFFFF80FFFF80FFFF80FFFF80FFFF80FFFF80FFFF80FF00FFFF00FFFF00FF0000FFFF00FFFF00FF0000FFFF00FF0000FFFFFF80FFFF80FF0000FFFF80FFFF80FFFF80FFFF80FF0000FF00FFFF0000FF0000FF0000FF0000FF0000FF0000FFFF80FFFF80FF0000FF0000FFFF80FFFF80FFFF80FF00FFFF00FFFF00FFFF00FFFF0000FF0000FF0000FF0000FFFF80FF0000FFFF80FF0000FF0000FFFF80FFFF80FFFF80FF0000FF0000FF0000FF0000FF0000FF0000FF0000FFFF80FF0000FF0000FFFF80FF0000FF0000FFFF80FFFF80FF0000FF0000FF0000FF00FFFF00FF0000FFFF00FFFFFF80FF00FFFF00FF0000FFFFFF80FF00FFFFFF80FFFF80FF0000FF0000FF00FFFF00FFFF0000FF0000FFFF80FFFF80FF0000FF0000FF0000FF0000FFFF80FFFF80FF0000FF0000FF0000FF0000FF0000FF0000FF00FFFF00FF0000FFFF00FFFF00FFFF00FFFF00FFFF00FFFFFF80FF00FFFF0000FF0000FF0000FF0000FF0000FF00FFFF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FFFF80FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF00FFFF00FFFF00FFFF00FFFF00FFFF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF00000000000000000000BC6F55AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(Play.Guild_Icon, 0, array, 19, Play.Guild_Icon.Length);
			Buffer.BlockCopy(BitConverter.GetBytes(ToPlay.UserSessionID), 0, array, 5, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(Play.Guild_ID), 0, array, 11, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(World.Server_Group_ID), 0, array, 17, 2);
			ToPlay.Client.Send(array, array.Length);
		}

		public void 发送门徽2(byte[] _门徽, int id)
		{
			string hex = "AA551903010A00EB000A036A42020001000100FF00FFFF00FF0000FF0000FFFF00FFFF00FFFF00FFFF00FFFF00FFFF00FFFFFF80FF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFF00FF0000FF0000FF0000FFFF00FFFF00FFFF00FFFF00FFFF00FFFFFF80FF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFF00FF0000FFFF00FF0000FFFF00FF0000FFFF00FFFF00FFFFFF80FF00FFFFFF80FFFF80FFFF80FF00FFFFFF80FF00FFFF00FF0000FFFF00FF0000FFFF00FF0000FFFF00FFFF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFFFF80FFFF80FF00FFFF00FF0000FFFF00FF0000FF0000FF0000FFFF00FFFF00FFFFFF80FFFF80FFFF80FFFF80FF00FFFFFF80FFFF80FF00FFFF00FF0000FFFF00FFFF00FF0000FF0000FF0000FFFFFF80FFFF80FFFF80FFFF80FFFF80FFFF80FFFF80FF00FFFF00FFFF00FF0000FFFF00FFFF00FF0000FFFF00FF0000FFFFFF80FFFF80FF0000FFFF80FFFF80FFFF80FFFF80FF0000FF00FFFF0000FF0000FF0000FF0000FF0000FF0000FFFF80FFFF80FF0000FF0000FFFF80FFFF80FFFF80FF00FFFF00FFFF00FFFF00FFFF0000FF0000FF0000FF0000FFFF80FF0000FFFF80FF0000FF0000FFFF80FFFF80FFFF80FF0000FF0000FF0000FF0000FF0000FF0000FF0000FFFF80FF0000FF0000FFFF80FF0000FF0000FFFF80FFFF80FF0000FF0000FF0000FF00FFFF00FF0000FFFF00FFFFFF80FF00FFFF00FF0000FFFFFF80FF00FFFFFF80FFFF80FF0000FF0000FF00FFFF00FFFF0000FF0000FFFF80FFFF80FF0000FF0000FF0000FF0000FFFF80FFFF80FF0000FF0000FF0000FF0000FF0000FF0000FF00FFFF00FF0000FFFF00FFFF00FFFF00FFFF00FFFF00FFFFFF80FF00FFFF0000FF0000FF0000FF0000FF0000FF00FFFF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FFFF80FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF00FFFF00FFFF00FFFF00FFFF00FFFF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF0000FF00000000000000000000BC6F55AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(_门徽, 0, array, 19, _门徽.Length);
			Buffer.BlockCopy(BitConverter.GetBytes(id), 0, array, 11, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(World.Server_Group_ID), 0, array, 17, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
			Client.Send(array, array.Length);
		}

		public void 发送任务物品列表()
		{
			try
			{
				using (PacketData packetData = new PacketData())
				{
					packetData.WriteInt(36);
					for (int i = 0; i < 36; i++)
					{
						if (Quest_Item[i].Item_Amount <= 0)
						{
							Quest_Item[i].物品_byte = new byte[8];
						}
						packetData.WriteLong(0L);
						packetData.WriteLong(Quest_Item[i].PID);
						packetData.WriteInt(Quest_Item[i].Item_Amount);
					}
					if (Client != null)
					{
						Client.SendPak(packetData, 33024, UserSessionID);
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "发送任务物品列表出错![" + Userid + "]-[" + UserName + "]" + ex);
			}
		}

		public void 发送势力战关闭消息()
		{
			try
			{
				string hex = "AA551C0001A205BA000D0006132700000000000000000000000000000000AC4155AA";
				byte[] array = Converter.hexStringToByte(hex);
				Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void Packet_Show_Flag_Win_Class_All(int Flag_Win)
		{
			try
			{
				string hex = "AA551B0001B902BA000C00041127031200000018000000000000000000822255AA";
				byte[] array = Converter.hexStringToByte(hex);
				switch (Flag_Win)
				{
				case 1:
					if (Player_Zx == 1)
					{
						Buffer.BlockCopy(BitConverter.GetBytes(1), 0, array, 14, 1);
					}
					else
					{
						Buffer.BlockCopy(BitConverter.GetBytes(2), 0, array, 14, 1);
					}
					break;
				case 2:
					if (Player_Zx == 1)
					{
						Buffer.BlockCopy(BitConverter.GetBytes(2), 0, array, 14, 1);
					}
					else
					{
						Buffer.BlockCopy(BitConverter.GetBytes(1), 0, array, 14, 1);
					}
					break;
				case 3:
					Buffer.BlockCopy(BitConverter.GetBytes(3), 0, array, 14, 1);
					break;
				}
				Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
				Buffer.BlockCopy(BitConverter.GetBytes(World.势力战进程), 0, array, 11, 1);
				Buffer.BlockCopy(BitConverter.GetBytes(World.势力战正分数), 0, array, 15, 4);
				Buffer.BlockCopy(BitConverter.GetBytes(World.势力战邪分数), 0, array, 19, 4);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void Packet_Countdown(int kssjint)
		{
			try
			{
				string hex = "AA552F00010F2713222000090001000B000000010000000C0000002101000000000000000000000000000000000000000002EE55AA";
				byte[] array = Converter.hexStringToByte(hex);
				Buffer.BlockCopy(BitConverter.GetBytes(kssjint - 1), 0, array, 27, 2);
				Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "发送势力战开始倒计时出错" + ex.Message);
			}
		}

		public void Packet_Time_In_Map_War_Class_All(int kssjint)
		{
			try
			{
				string hex = "AA551C0001A205BA000D00020000100E0000000000000000000000000000AC4155AA";
				byte[] array = Converter.hexStringToByte(hex);
				Buffer.BlockCopy(BitConverter.GetBytes(kssjint), 0, array, 14, 2);
				Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
				Buffer.BlockCopy(BitConverter.GetBytes(World.势力战进程), 0, array, 11, 1);
				Buffer.BlockCopy(BitConverter.GetBytes(World.势力战正分数), 0, array, 16, 4);
				Buffer.BlockCopy(BitConverter.GetBytes(World.势力战邪分数), 0, array, 20, 4);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void 发送势力战刷新分数()
		{
			string hex = "AA552F00010F271322200001000100060000000200000003000000EE010000E2010000FB040000CD030000000000000000E65D55AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(World.势力战正分数), 0, array, 27, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(World.势力战邪分数), 0, array, 31, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(World.势力战正人数), 0, array, 35, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(World.势力战邪人数), 0, array, 39, 4);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 发送势力战消息()
		{
			try
			{
				string hex = "AA551C0001A205BA000D000303271806FFFF0000FFFF000000000000000059DF55AA";
				byte[] array = Converter.hexStringToByte(hex);
				Buffer.BlockCopy(BitConverter.GetBytes(World.势力战进程), 0, array, 11, 1);
				Buffer.BlockCopy(BitConverter.GetBytes(World.势力战时间), 0, array, 14, 2);
				Buffer.BlockCopy(BitConverter.GetBytes(World.势力战正分数), 0, array, 16, 4);
				Buffer.BlockCopy(BitConverter.GetBytes(World.势力战邪分数), 0, array, 20, 4);
				Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void 发送势力战消息1()
		{
			try
			{
				string hex = "AA551E00015400B7000F000212270300000064000000640002000000000000008E1B55AA";
				byte[] array = Converter.hexStringToByte(hex);
				Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void 发送势力战消息2()
		{
			try
			{
				string hex = "AA551C0001A205BA000D000303271806FFFF0000FFFF000000000000000059DF55AA";
				byte[] array = Converter.hexStringToByte(hex);
				Buffer.BlockCopy(BitConverter.GetBytes(2), 0, array, 11, 1);
				Buffer.BlockCopy(BitConverter.GetBytes(World.势力战时间), 0, array, 14, 2);
				Buffer.BlockCopy(BitConverter.GetBytes(World.势力战正分数), 0, array, 16, 4);
				Buffer.BlockCopy(BitConverter.GetBytes(World.势力战邪分数), 0, array, 20, 4);
				Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void Packet_Start_Time_War_Class_All()
		{
			string hex = "AA552F00010F2713222000010001000B00000001000000020000000500000005000000340E000000000000000000000000BD8455AA";
			byte[] dst = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(2), 0, dst, 23, 1);
			if (Client != null)
			{
			}
			if (World.Newversion >= 17)
			{
				switch (World.getTypeWar801())
				{
				case 0:
					GameMessage("Thêì lýòc chiêìn tôÒng ðang diêÞn ra, nhâìn \"!thamgiatlc\" ðêÒ tham gia!", 8);
					break;
				case 1:
					GameMessage("Thêì lýòc chiêìn thãng chýìc ðang diêÞn ra, nhâìn \"!thamgiatlc\" ðêÒ tham gia!", 8);
					break;
				case 2:
					GameMessage("Thêì lýòc chiêìn thãng thiên ðang diêÞn ra, nhâìn \"!thamgiatlc\" ðêÒ tham gia!", 8);
					break;
				}
			}
		}

		public void 发送势力战邀请广播2()
		{
			string hex = "AA552F00010F2713222000010001000B00000001000000030000000500000005000000620F000000000000000000000000BD8455AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(World.势力战正人数), 0, array, 35, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(World.势力战邪人数), 0, array, 39, 4);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 分解物品提示(int id)
		{
			PacketData packetData = new PacketData();
			packetData.WriteInt(id);
			if (Client != null)
			{
				Client.SendPak(packetData, 12567, UserSessionID);
			}
		}

		public void 更换装备位置(int fromType, int fromIndex, int toType, int toIndex, byte[] itmeid, int sl)
		{
			try
			{
				string text = "AA55007A00F8011B007400010000000103000F010000003950BC402BEAFC0C96CE9A3B000000000100000000000000000F00130000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA";
				PacketData packetData = new PacketData();
				packetData.WriteInt(1);
				packetData.WriteByte(fromType);
				packetData.WriteByte(fromIndex);
				packetData.WriteByte(toType);
				packetData.WriteByte(toIndex);
				packetData.WriteInt(sl);
				byte[] array = new byte[16];
				Buffer.BlockCopy(itmeid, 0, array, 0, 16);
				packetData.WriteByteArray(array);
				packetData.WriteLong(1L);
				packetData.WriteByte(toType);
				packetData.WriteByte(toIndex);
				PacketData packetData2 = packetData;
				byte[] value = new byte[6];
				packetData2.WriteByteArray(value);
				byte[] array2 = new byte[20];
				Buffer.BlockCopy(itmeid, 16, array2, 0, 20);
				packetData.WriteByteArray(array2);
				packetData.WriteInt(0, 13);
				if (Client != null)
				{
					Client.SendPak(packetData, 6912, UserSessionID);
				}
			}
			catch
			{
			}
		}

		public void 更新个人商店数据(Players Play)
		{
			if (!Play.PlayerShop.个人商店是否开启)
			{
				return;
			}
			PacketData packetData = new PacketData();
			packetData.WriteInt(1);
			packetData.WriteInt(Play.UserSessionID);
			packetData.WriteInt(Play.UserSessionID);
			packetData.WriteShort((byte)Play.PlayerShop.商店名.Length);
			packetData.Write(Play.PlayerShop.商店名, 0, Play.PlayerShop.商店名.Length);
			if (Client != null)
			{
				if (Play.PlayerShop.商店类型 == 1)
				{
					Client.SendPak(packetData, 51712, UserSessionID);
				}
				else if (Play.PlayerShop.商店类型 == 2)
				{
					Client.SendPak(packetData, 2588, UserSessionID);
				}
			}
		}

		public void 更新攻击速度()
		{
			string hex = "AA551B0000B20206200C00060000008801580064000000000000000000000055AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
			if (GM模式 == 0)
			{
				Buffer.BlockCopy(BitConverter.GetBytes(FLD_攻击速度), 0, array, 19, 4);
			}
			else
			{
				Buffer.BlockCopy(BitConverter.GetBytes((FLD_攻击速度 == 0) ? GM模式 : FLD_攻击速度), 0, array, 19, 4);
			}
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
			SendRangeOfPackets(array, array.Length);
		}

		public void 更新广播人物数据()
		{
			try
			{
				PacketData packetData = 得到更新人物数据(Client.Player);
				if (packetData != null)
				{
					if (Client != null)
					{
						Client.SendPak(packetData, 34560, UserSessionID);
					}
					SendRangeOfPackets(packetData, 25600, UserSessionID);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "更新广播人物数据 出错" + Client.WorldId + "|" + Client.ToString() + " " + ex);
			}
		}

		public void Update_Money_Weight()
		{
			_人物负重 = 0;
			for (int i = 0; i < ((装备行囊是否开启 == 1) ? 66 : 36); i++)
			{
				_人物负重 += Item_In_Bag[i].物品总重量;
			}
			for (int i = 0; i < 16; i++)
			{
				_人物负重 += Item_Wear[i].物品总重量;
			}
			PacketData packetData = new PacketData();
			packetData.WriteLong(Player_Money);
			packetData.WriteInt(人物负重);
			if (Player_Job == 4 && base.弓_升天二气功_千钧压驼 != 0.0)
			{
				packetData.WriteInt((int)((double)(人物负重总 * 2) * base.弓_升天二气功_千钧压驼 * (1.0 + Item_Wear[11].物品属性_行囊负重)));
			}
			else
			{
				packetData.WriteInt((int)((double)(人物负重总 * 2) * (1.0 + Item_Wear[11].物品属性_行囊负重)));
			}
			packetData.WriteInt(0);
			packetData.WriteInt(0);
			packetData.WriteInt(0);
			packetData.WriteInt(0);
			packetData.WriteInt(0);
			if (Client != null)
			{
				Client.SendPak(packetData, 31744, UserSessionID);
			}
		}

		public void Update_Exp_Marble()
		{
			double num = Convert.ToInt64(World.Level[Player_Level]) - Convert.ToInt64(World.Level[Player_Level - 1]);
			double num2 = Player_FLD_EXP - Convert.ToInt64(World.Level[Player_Level - 1]);
			if (num2 < 1.0)
			{
				Player_FLD_EXP = Convert.ToInt64(World.Level[Player_Level - 1]);
				num2 = 0.0;
			}
			PacketData packetData = new PacketData();
			packetData.WriteLong((long)num2);
			packetData.WriteLong((long)num);
			packetData.WriteInt(1);
			packetData.WriteInt(Player_ExpErience);
			packetData.WriteShort(Craft_Type);
			packetData.WriteShort(FLD_制作等级);
			packetData.WriteInt(Craft_Level);
			if (Player_Job_Level >= 6)
			{
				升天历练数 += 升天历练当前获得数;
				if (升天历练数 >= 50000000)
				{
					int num3 = 得到包裹空位位置();
					if (num3 != -1)
					{
						升天历练数 -= 50000000;
						byte[] bytes = BitConverter.GetBytes(RxjhClass.GetDbItmeId());
						byte[] 物品属性 = new byte[56];
						增加物品3(bytes, BitConverter.GetBytes(1000000714), num3, BitConverter.GetBytes(1), 物品属性);
					}
					else
					{
						GameMessage("Tuìi ðôÌ ðaÞ ðâÌy !!", 9);
					}
				}
				packetData.WriteInt(升天历练数);
				packetData.WriteInt(升天历练当前获得数);
			}
			else
			{
				packetData.WriteInt(0);
				packetData.WriteInt(0);
			}
			if (World.Newversion >= 10)
			{
				packetData.WriteLong(0L);
			}
			packetData.WriteInt(0);
			packetData.WriteInt(0);
			packetData.WriteInt(0);
			packetData.WriteInt(0);
			升天历练当前获得数 = 0;
			if (Client != null)
			{
				Client.SendPak(packetData, 27136, UserSessionID);
			}
		}

		public void 更新气功()
		{
			using (new Lock(eval_c, "更新气功"))
			{
				base.KhiCongTTChung_DameMin = 0.0;
				base.KhiCongTTChung_DameMax = 0.0;
				人物_气功_追加_HP = 0;
				人物_气功_追加_MP = 0;
				FLD_人物_气功_攻击 = 0;
				FLD_Qigong_Defense_Skill = 0;
				FLD_人物_气功_防御 = 0;
				FLD_人物_气功_命中 = 0;
				FLD_人物_气功_回避 = 0;
				FLD_人物_气功_武功攻击力增加百分比 = 0.0;
				FLD_人物_气功_武功防御力增加百分比 = 0.0;
				if (World.气功是否有效 == 1)
				{
					for (int i = 0; i < 12; i++)
					{
						if (气功[i].气功量 >= 0 && 气功[i].气功ID != 0)
						{
							int num = 气功[i].气功量 + FLD_Item_Level_Pran + Character_Qigong + FLD_武勋_追加_气功 + flowerEffectQigong + FLD_斗神_追加_气功;
							if (num != 0 && num > World.最大气功数)
							{
								num = World.最大气功数;
							}
							double num2 = num + (int)getNumberQigongItem(Player_Job, i);
							num2 *= World.气功百分比;
							if (World.最大气功数 != 0 && num2 > (double)World.最大气功数)
							{
								num2 = World.最大气功数;
							}
							if (num2 < 0.0)
							{
								num2 = 0.0;
							}
							switch (Player_Job)
							{
							case 1:
								switch (i)
								{
								case 0:
									Item_Wear[3].Item_Attack_Min = (int)((double)Item_Wear[3].Item_Attack_Min * (1.0 + 0.01 * num2));
									break;
								case 1:
									FLD_人物_气功_命中 = (int)((double)FLD_Accuracy * (0.1 + 0.01 * num2));
									break;
								case 2:
									base.连打几率 = 10.0 + num2;
									break;
								case 3:
									base.QiGong_PhanNo = num2;
									break;
								case 4:
									FLD_人物_气功_防御 = (int)((double)FLD_人物基本_防御 * (0.003 * num2));
									人物_气功_追加_HP = (int)(2.0 * num2);
									break;
								case 5:
									base.破甲几率 = 5.0 + num2;
									break;
								case 6:
									base.KCV17_KC7 = num2 * 0.005;
									break;
								case 7:
									base.武功致命几率 = num2;
									break;
								case 8:
									base.反伤几率 = 10.0 + num2;
									break;
								case 9:
									base.刀_暗影绝杀 = 5.0 + 0.5 * num2;
									break;
								case 10:
									base.刀_升天三气功_梵音破镜 = num2 * 0.5;
									break;
								case 11:
									base.刀_群攻威力 = 0.1 * num2;
									break;
								}
								break;
							case 2:
								switch (i)
								{
								case 0:
									Item_Wear[3].Item_Attack_Max = (int)((double)Item_Wear[3].Item_Attack_Max * (1.0 + 0.01 * num2));
									break;
								case 1:
									FLD_人物_气功_回避 = (int)((double)FLD_Evasion * (1.0 + num2 * 0.01));
									break;
								case 2:
									base.连打几率 = 10.0 + num2;
									break;
								case 3:
									base.KhiCong_NhatKiemPhaThien = 0.003 * num2;
									break;
								case 4:
									base.QiGong_PhanNo = num2;
									break;
								case 5:
									base.剑_移花接木 = 0.4 * num2;
									break;
								case 6:
									base.KCV17_KC7 = num2 * 0.005;
									break;
								case 7:
									base.剑_怒海狂澜 = 5.0 + 0.5 * num2;
									break;
								case 8:
									FLD_人物_气功_武功攻击力增加百分比 = 0.6 * num2;
									base.KC_HoiLieuThanPhap = num2;
									break;
								case 9:
									base.剑_无坚不摧 = 0.2 * num2;
									break;
								case 10:
									base.剑_升天一气功_乘胜追击 = num2 * 0.5;
									break;
								case 11:
									base.剑_冲冠一怒 = 5.0 + num2;
									break;
								}
								break;
							case 3:
								switch (i)
								{
								case 0:
									FLD_人物_气功_防御 = (int)num2;
									break;
								case 1:
									base.枪_运气疗伤 = 0.01 * num2 + 0.1;
									break;
								case 2:
									base.连打几率 = 10.0 + num2;
									break;
								case 3:
									base.QiGong_PhanNo = num2;
									break;
								case 4:
									人物_气功_追加_HP = (int)(8.0 * num2);
									break;
								case 5:
									base.枪_转攻为守 = 5.0 + 0.5 * num2;
									break;
								case 6:
									base.KCV17_KC7 = num2 * 0.005;
									break;
								case 7:
									base.枪_狂神降世 = 0.001 * num2;
									break;
								case 8:
									FLD_人物_气功_武功攻击力增加百分比 = 1.5 * num2;
									break;
								case 9:
									base.枪_末日狂舞 = num2 * 0.01;
									break;
								case 10:
									base.枪_升天三气功_怒意之吼 = num2;
									break;
								case 11:
									FLD_Qigong_Defense_Skill = (int)(num2 * 3.0);
									break;
								}
								break;
							case 4:
								switch (i)
								{
								case 0:
									FLD_人物_气功_命中 = (int)((double)FLD_人物基本_命中 * (0.02 * num2));
									break;
								case 1:
									Item_Wear[3].Item_Attack_Max = (int)((double)Item_Wear[3].Item_Attack_Max * (1.0 + 0.005 * num2));
									break;
								case 2:
									Item_Wear[3].Item_Attack_Min = (int)((double)Item_Wear[3].Item_Attack_Min * (1.0 + 0.01 * num2));
									break;
								case 3:
									base.QiGong_PhanNo = num2;
									break;
								case 4:
									人物_气功_追加_HP = (int)(8.0 * num2);
									break;
								case 5:
									base.弓_锐利之箭 = num2;
									FLD_人物_气功_攻击 = (int)num2;
									break;
								case 6:
									base.KCV17_KC7 = num2 * 0.005;
									break;
								case 7:
									base.弓_心神凝聚 = num2 + 10.0 + base.弓箭致命一击几率;
									break;
								case 8:
									base.弓_流星三矢 = 10.0 + num2;
									break;
								case 9:
									base.KC9_Cung = 15.0 * num2;
									break;
								case 10:
									base.弓_无明暗矢 = num2;
									break;
								case 11:
									base.弓_致命绝杀 = 10.0 + num2;
									break;
								}
								break;
							case 5:
								switch (i)
								{
								case 0:
									base.医_运气疗心 = 0.04 * num2;
									break;
								case 2:
									人物_气功_追加_HP = (int)((double)人物基本最大_HP * (0.01 * num2));
									break;
								case 3:
									人物_气功_追加_MP = (int)((double)人物基本最大_MP * (0.01 * num2));
									break;
								case 4:
									base.医_recovery = 10.0 + num2 * 2.0;
									break;
								case 5:
									FLD_人物_气功_武功攻击力增加百分比 = num2;
									base.医_长攻击力 = 0.02 * num2;
									break;
								case 6:
									base.KCV17_KC7 = num2 * 0.005;
									break;
								case 7:
									base.武功致命几率 = num2;
									break;
								case 8:
									base.医_吸星大法 = 15.0 * num2;
									break;
								case 9:
									base.医_升天一气功_狂意护体 = num2;
									break;
								case 10:
									base.医_升天二气功_无中生有 = num2;
									break;
								case 11:
									base.医_九天真气 = num2;
									break;
								}
								break;
							case 6:
								switch (i)
								{
								case 0:
									Item_Wear[3].Item_Attack_Min = (int)((double)Item_Wear[3].Item_Attack_Min * (1.0 + 0.01 * num2));
									base.刺_荆轲之怒 = num2 * 0.01;
									break;
								case 1:
									base.刺_三花聚顶 = 10.0 + num2;
									break;
								case 2:
									base.刺_连环飞舞 = 10.0 + num2;
									break;
								case 3:
									base.刺_心神凝聚 = 10.0 + num2;
									break;
								case 4:
									base.刺_致手绝命 = 0.012 * num2;
									break;
								case 5:
									base.刺_升天三气功_以怒还怒 = num2;
									break;
								case 6:
									base.KCV17_KC7 = num2 * 0.005;
									break;
								case 7:
									base.刺_先发制人 = num2 * 0.005;
									break;
								case 8:
									base.刺_千蛛万手 = num2;
									break;
								case 9:
									base.刺_连消带打 = num2 * 0.01;
									break;
								case 10:
									base.刺_剑刃乱舞 = num2 * 3.0;
									break;
								case 11:
									base.Ninja_KC_130_x2damexanh = 0.1 * num2;
									break;
								}
								break;
							case 7:
								switch (i)
								{
								case 0:
									Item_Wear[3].Item_Attack_Max = (int)((double)Item_Wear[3].Item_Attack_Max * (1.0 + 0.005 * num2));
									break;
								case 1:
									人物_气功_追加_HP = (int)(16.0 * num2);
									break;
								case 2:
									人物_气功_追加_MP = (int)((double)人物基本最大_MP * (0.01 * num2));
									break;
								case 3:
									FLD_人物_气功_防御 = (int)num2 * 5;
									FLD_Qigong_Defense_Skill = (int)(num2 * 5.0);
									break;
								case 4:
									FLD_人物_气功_武功攻击力增加百分比 = 0.5 * num2;
									break;
								case 5:
									base.琴师_高山流水 = num2;
									break;
								case 6:
									base.KCV17_KC7 = num2 * 0.005;
									break;
								case 7:
									base.琴师_岳阳三醉 = num2;
									break;
								case 8:
									base.琴师_梅花三弄 = num2 * 0.002;
									break;
								case 9:
									base.琴师_鸾凤和鸣 = num2 * 0.2;
									break;
								case 10:
									base.琴师_阳明春晓 = num2;
									break;
								case 11:
									base.琴师_潇湘雨夜 = num2;
									break;
								}
								break;
							case 8:
								switch (i)
								{
								case 0:
									Item_Wear[3].Item_Attack_Min = (int)((double)Item_Wear[3].Item_Attack_Min * (1.0 + 0.01 * num2));
									break;
								case 1:
									FLD_人物_气功_命中 = (int)((double)FLD_Accuracy * (0.1 + 0.01 * num2));
									break;
								case 2:
									FLD_人物_气功_回避 = (int)((double)FLD_Evasion * (1.0 + num2 * 0.01));
									break;
								case 3:
									base.QiGong_PhanNo = num2;
									break;
								case 4:
									base.韩飞官_天魔狂血 = num2;
									break;
								case 5:
									base.Qigong_HBQ6 = 0.5 * num2;
									break;
								case 6:
									base.KCV17_KC7 = num2 * 0.005;
									break;
								case 7:
									base.破甲几率 = 5.0 + num2;
									break;
								case 8:
									base.武功致命几率 = num2;
									break;
								case 9:
									base.QiGong_BUFF_Dragon = num2;
									break;
								case 10:
									base.刀_群攻威力 = 0.1 * num2;
									break;
								case 11:
									base.刀_暗影绝杀 = 5.0 + 0.5 * num2;
									break;
								}
								break;
							case 9:
								switch (i)
								{
								case 0:
									Item_Wear[3].Item_Attack_Max = (int)((double)Item_Wear[3].Item_Attack_Max * (1.0 + 0.01 * num2));
									break;
								case 1:
									FLD_人物_气功_回避 = (int)((double)FLD_Evasion * (1.0 + num2 * 0.01));
									break;
								case 2:
									base.连打几率 = 10.0 + num2 * 0.2;
									break;
								case 3:
									base.KCDHL_HHDP_1 = num2;
									break;
								case 4:
									base.QiGong_PhanNo = num2;
									break;
								case 5:
									base.剑_护身罡气 = 10.0 + num2;
									break;
								case 6:
									base.KCV17_KC7 = num2 * 0.005;
									break;
								case 7:
									base.剑_移花接木 = 0.4 * num2;
									break;
								case 8:
									base.KCDHL_HHDP_2 = 5.0 + num2 * 0.4;
									break;
								case 9:
									FLD_人物_气功_武功攻击力增加百分比 = 0.6 * num2;
									base.KC_HoiLieuThanPhap = num2;
									break;
								case 10:
									base.剑_怒海狂澜 = 5.0 + 0.5 * num2;
									break;
								case 11:
									base.剑_冲冠一怒 = 5.0 + num2;
									break;
								}
								break;
							case 10:
								switch (i)
								{
								case 0:
									base.枪_狂神降世 = 0.001 * num2;
									break;
								case 1:
									base.枪_运气疗伤 = 0.01 * num2 + 0.1;
									break;
								case 2:
									Item_Wear[3].Item_Attack_Min = (int)((double)Item_Wear[3].Item_Attack_Min * (1.0 + 0.01 * num2));
									break;
								case 3:
									base.QiGong_PhanNo = num2;
									break;
								case 4:
									FLD_Qigong_Defense_Skill = (int)(num2 * 3.0);
									break;
								case 5:
									base.Qigong_job10_6 = 0.1 + num2 * 0.005;
									break;
								case 6:
									base.KCV17_KC7 = num2 * 0.005;
									break;
								case 7:
									base.Qigong_job10_7 = num2 * 0.006;
									break;
								case 8:
									base.Qigong_job10_8 = 10.0 + num2;
									break;
								case 9:
									base.枪_转攻为守 = 5.0 + 0.5 * num2;
									break;
								case 10:
									base.Qigong_job10_10 = 5.0 + num2 * 0.6;
									break;
								case 11:
									base.枪_末日狂舞 = num2 * 0.005;
									break;
								}
								break;
							case 11:
								switch (i)
								{
								case 0:
									base.KhiCong_JOB11_0 = num2;
									break;
								case 1:
									base.KhiCong_JOB11_1 = 10.0 + num2 * 2.0;
									break;
								case 2:
									FLD_人物_气功_回避 = (int)((double)FLD_Evasion * (1.0 + num2 * 0.01));
									break;
								case 3:
									base.QiGong_PhanNo = num2;
									break;
								case 4:
									base.KhiCong_JOB11_4 = num2 * 0.01;
									break;
								case 5:
									base.KhiCong_JOB11_5 = num2;
									break;
								case 6:
									base.KCV17_KC7 = num2 * 0.005;
									break;
								case 7:
									base.KhiCong_JOB11_7 = num2 * 2.5;
									break;
								case 8:
									base.KhiCong_JOB11_8 = num2;
									break;
								case 9:
									base.KhiCong_JOB11_9 = num2;
									break;
								case 10:
									base.KhiCong_JOB11_10 = num2 * 0.03;
									break;
								case 11:
									base.KhiCong_JOB11_11 = num2 * 0.5;
									break;
								}
								break;
							case 12:
								switch (i)
								{
								case 0:
									FLD_人物_气功_防御 = (int)num2;
									break;
								case 1:
									base.枪_运气疗伤 = 0.01 * num2 + 0.1;
									break;
								case 2:
									base.连打几率 = 10.0 + num2;
									break;
								case 3:
									人物_气功_追加_HP = (int)(8.0 * num2);
									break;
								case 4:
									base.QiGong_PhanNo = num2;
									break;
								case 5:
									base.武功致命几率 = num2;
									break;
								case 6:
									base.KCV17_KC7 = num2 * 0.005;
									break;
								case 7:
									base.KhiCong_JOB12_6 = num2 * 0.8;
									if (Player_Job_Level >= 6)
									{
										base.KhiCong_JOB12_6 += 50.0;
									}
									else if (Player_Job_Level == 5)
									{
										base.KhiCong_JOB12_6 += 30.0;
									}
									else if (Player_Job_Level == 4)
									{
										base.KhiCong_JOB12_6 += 15.0;
									}
									else if (Player_Job_Level == 3)
									{
										base.KhiCong_JOB12_6 += 5.0;
									}
									break;
								case 8:
									FLD_人物_气功_武功攻击力增加百分比 = 1.5 * num2;
									break;
								case 9:
									base.枪_转攻为守 = 0.5 * num2;
									break;
								case 10:
									base.KhiCong_JOB12_10 = 10.0 + num2;
									break;
								case 11:
									base.KhiCong_JOB12_11 = num2;
									break;
								}
								break;
							}
						}
					}
					foreach (升天气功类 value in 升天气功.Values)
					{
						double num3;
						if (value.气功ID != 0 && value.气功量 >= 0)
						{
							num3 = value.气功量 + FLD_Item_Level_Pran + Character_Qigong + FLD_武勋_追加_气功 + flowerEffectQigong + FLD_斗神_追加_气功;
							num3 *= World.气功百分比;
							if (World.最大气功数 != 0 && num3 > (double)World.最大气功数)
							{
								num3 = World.最大气功数;
							}
							if (num3 < 0.0)
							{
								num3 = 0.0;
							}
							if (World.Newversion >= 13)
							{
								if (value.气功ID >= 380 && value.气功ID <= 387)
								{
									switch (value.气功ID)
									{
									case 380:
										base.KhiCongTTChung_DameMin = num3 * 6.0;
										break;
									case 381:
										base.KhiCongTTChung_DameMax = num3 * 6.0;
										break;
									case 382:
										FLD_人物_气功_防御 += (int)((double)FLD_Defense * (0.01 * num3));
										break;
									case 383:
										base.升天一气功_运气行心 = 0.04 * num3;
										break;
									case 384:
										人物_气功_追加_HP += (int)(8.0 * num3);
										break;
									case 385:
										base.升天一气功_运气疗伤 = 0.1 + 0.01 * num3;
										break;
									case 386:
										FLD_人物_气功_回避 += (int)((double)FLD_Evasion * (1.0 + num3 * 0.01));
										break;
									case 387:
										base.KhiCongTTChung_PhanNo = num3;
										break;
									}
								}
								else
								{
									switch (Player_Job)
									{
									case 1:
										break;
									case 2:
										goto IL_1792;
									case 3:
										goto IL_1847;
									case 4:
										goto IL_1916;
									case 5:
										goto IL_19be;
									case 6:
										goto IL_1ab0;
									case 7:
										goto IL_1b82;
									case 8:
										goto IL_1c2a;
									case 9:
										goto IL_1d07;
									case 10:
										goto IL_1dca;
									case 11:
										goto IL_1ebb;
									case 12:
										goto IL_1fbd;
									default:
										continue;
									}
									switch (value.气功ID)
									{
									case 310:
										base.刀_升天一气功_遁出逆境 = num3 * 0.5;
										break;
									case 311:
										base.刀_升天二气功_穷途末路 = num3 * 0.5;
										break;
									case 13:
										base.刀_升天三气功_梵音破镜_Plus = num3 * 0.005;
										break;
									case 313:
										base.KhiCong_HongNguyetCuongPhong = num3;
										break;
									case 314:
										base.KhiCong_ThanhXaXuatDong = num3;
										break;
									case 667:
										base.KhiCong_150_TriTan = 2.2 + num3 * 0.8;
										break;
									case 679:
										base.KhiCong_JOB1_150_2 = num3 * 0.2;
										break;
									}
								}
							}
							else
							{
								switch (Player_Job)
								{
								case 1:
									break;
								case 2:
									goto IL_2194;
								case 3:
									goto IL_220a;
								case 4:
									goto IL_2284;
								case 5:
									goto IL_22f6;
								case 6:
									goto IL_237e;
								case 7:
									goto IL_2408;
								case 8:
									goto IL_248b;
								case 9:
									goto IL_24f4;
								case 10:
									goto IL_256f;
								default:
									continue;
								}
								switch (value.气功ID)
								{
								case 310:
									base.刀_升天一气功_遁出逆境 = num3 * 0.5;
									break;
								case 311:
									base.刀_升天二气功_穷途末路 = num3 * 0.5;
									break;
								case 381:
									FLD_人物_气功_攻击 = (int)num3;
									break;
								case 382:
									FLD_人物_气功_防御 = (int)((double)FLD_Defense * (0.01 * num3));
									break;
								case 383:
									base.升天一气功_运气行心 = 0.04 * num3;
									break;
								case 384:
									人物_气功_追加_HP = (int)(8.0 * num3);
									break;
								case 385:
									base.升天一气功_运气疗伤 = 0.1 + 0.01 * num3;
									break;
								case 386:
									FLD_人物_气功_回避 = (int)num3;
									break;
								case 312:
									base.刀_升天三气功_梵音破镜 = num3 * 0.5;
									break;
								}
							}
						}
						continue;
						IL_2906:
						base.弓_升天二气功_千钧压驼 = 1.0 + num3 * 0.01;
						FLD_人物_气功_防御 = (int)num3 * 5;
						Update_Money_Weight();
						continue;
						IL_28ee:
						base.弓_升天一气功_绝影射魂 = num3 * 0.5;
						continue;
						IL_220a:
						switch (value.气功ID)
						{
						case 380:
							break;
						case 381:
							goto IL_27c8;
						case 383:
							goto IL_2802;
						case 384:
							goto IL_281a;
						case 386:
							goto IL_2833;
						case 330:
							goto IL_2842;
						case 331:
							goto IL_2850;
						case 332:
							base.枪_升天三气功_怒意之吼 = num3;
							continue;
						default:
							continue;
						}
						goto IL_278e;
						IL_2842:
						base.KCThuong_TT1_DiemVuongPheNguyet = num3;
						continue;
						IL_2833:
						FLD_人物_气功_回避 = (int)num3;
						continue;
						IL_2850:
						base.KCThuong_TT2_SinhTuHuuMenh = num3;
						continue;
						IL_2802:
						base.升天一气功_运气行心 = 0.04 * num3;
						continue;
						IL_281a:
						人物_气功_追加_HP = (int)(8.0 * num3);
						continue;
						IL_278e:
						Item_Wear[3].Item_Attack_Min = (int)((double)Item_Wear[3].Item_Attack_Min * (1.0 + 0.01 * num3));
						continue;
						IL_27c8:
						Item_Wear[3].Item_Attack_Max = (int)((double)Item_Wear[3].Item_Attack_Max * (1.0 + 0.01 * num3));
						continue;
						IL_2194:
						switch (value.气功ID)
						{
						case 380:
							break;
						case 382:
							goto IL_26ac;
						case 383:
							goto IL_26cd;
						case 384:
							goto IL_26e5;
						case 385:
							goto IL_26fe;
						case 320:
							base.剑_升天一气功_乘胜追击 = num3 * 0.5;
							continue;
						case 321:
							goto IL_2768;
						case 322:
							goto IL_2780;
						default:
							continue;
						}
						goto IL_2672;
						IL_26fe:
						base.升天一气功_运气疗伤 = 0.1 + 0.01 * num3;
						continue;
						IL_26e5:
						人物_气功_追加_HP = (int)(8.0 * num3);
						continue;
						IL_2768:
						base.剑_升天二气功_天地同寿 = num3 * 0.005;
						continue;
						IL_26cd:
						base.升天一气功_运气行心 = 0.04 * num3;
						continue;
						IL_26ac:
						FLD_人物_气功_防御 = (int)((double)FLD_Defense * (0.01 * num3));
						continue;
						IL_1fbd:
						switch (value.气功ID)
						{
						case 662:
							base.KhiCong_JOB12_TT1 = num3;
							break;
						case 663:
							base.KhiCong_JOB12_TT2 = 10.0 + num3 * 0.5;
							break;
						case 664:
							base.KhiCong_JOB12_TT3 = 10.0 + num3 * 0.5;
							break;
						case 665:
							base.KhiCong_ThanhXaXuatDong = num3;
							break;
						case 666:
							base.KhiCong_HongNguyetCuongPhong = num3;
							break;
						case 678:
							base.KhiCong_150_TriTan = 2.2 + num3 * 0.8;
							break;
						case 690:
							base.KhiCong_JOB12_150_2 = num3 * 0.1;
							break;
						}
						continue;
						IL_1ebb:
						switch (value.气功ID)
						{
						case 316:
							base.KhiCong_JOB11_TT1 = num3 * 2.0;
							break;
						case 325:
							base.KhiCong_JOB11_TT2 = num3 * 0.4;
							break;
						case 315:
							base.KhiCong_JOB11_TT3 = num3 * 0.5;
							break;
						case 327:
							base.KhiCong_ManNguyetCuongPhong = num3;
							break;
						case 326:
							base.KhiCong_LietNhatDiemDiem = num3;
							break;
						case 677:
							base.KhiCong_150_TriTan = 2.2 + num3 * 0.8;
							break;
						case 689:
							base.KhiCong_JOB11_150_2 = num3 * 2.0;
							break;
						}
						continue;
						IL_1dca:
						switch (value.气功ID)
						{
						case 562:
							base.KC_QuyenVuong_1 = 10.0 + num3 * 0.5;
							break;
						case 561:
							base.KC_QuyenVuong_2 = num3 * 0.3;
							break;
						case 563:
							base.KC_QuyenVuong_3 = num3 * 0.005;
							break;
						case 564:
							base.KhiCong_HongNguyetCuongPhong = num3;
							break;
						case 565:
							base.KhiCong_ThanhXaXuatDong = num3;
							break;
						case 676:
							base.KhiCong_150_TriTan = 2.2 + num3 * 0.8;
							break;
						case 688:
							base.KhiCong_JOB10_150_2 = num3 * 0.7;
							break;
						}
						continue;
						IL_1d07:
						switch (value.气功ID)
						{
						case 701:
							base.KhiCong_TruongHongQuanThien = num3;
							continue;
						case 702:
							base.KhiCong_HongMinhBienGia = num3;
							continue;
						case 675:
							base.KhiCong_150_TriTan = 2.2 + num3 * 0.8;
							continue;
						case 687:
							base.KhiCong_JOB9_150_2 = num3 * 0.3;
							continue;
						case 700:
							break;
						case 321:
							goto IL_2768;
						case 322:
							goto IL_2780;
						default:
							continue;
						}
						goto IL_2750;
						IL_1c2a:
						switch (value.气功ID)
						{
						case 600:
							base.韩飞官_升天一气功 = 0.7 * num3;
							break;
						case 601:
							base.剑_升天三气功_火凤临朝 = num3 * 0.3;
							break;
						case 602:
							base.HBQ_KCTT3_GiamThoiGian = num3 * 0.02;
							break;
						case 603:
							base.KhiCong_TruongHongQuanThien = num3;
							break;
						case 604:
							base.KhiCong_HongMinhBienGia = num3;
							break;
						case 674:
							base.KhiCong_150_TriTan = 2.2 + num3 * 0.8;
							break;
						case 686:
							base.KhiCong_JOB8_150_2 = num3;
							break;
						}
						continue;
						IL_1b82:
						switch (value.气功ID)
						{
						case 393:
							base.KhiCong_HongNguyetCuongPhong = num3;
							continue;
						case 394:
							base.KhiCong_HuyenToChanMach = num3;
							continue;
						case 673:
							base.KhiCong_150_TriTan = 2.2 + num3 * 0.8;
							continue;
						case 685:
							base.KhiCong_JOB7_150_2 = num3 * 0.5;
							continue;
						case 390:
							break;
						case 391:
							goto IL_2bf7;
						case 392:
							goto IL_2c05;
						default:
							continue;
						}
						goto IL_2be9;
						IL_1ab0:
						switch (value.气功ID)
						{
						case 170:
							base.刺_无情打击 = 10.0 + num3;
							continue;
						case 373:
							base.KhiCong_ManNguyetCuongPhong = num3;
							continue;
						case 374:
							base.KhiCong_LietNhatDiemDiem = num3;
							continue;
						case 672:
							base.KhiCong_150_TriTan = 2.2 + num3 * 0.8;
							continue;
						case 684:
							base.KhiCong_JOB6_150_2 = num3 * 0.01;
							continue;
						case 370:
							break;
						case 371:
							goto IL_2a57;
						default:
							continue;
						}
						goto IL_2a49;
						IL_19be:
						switch (value.气功ID)
						{
						case 58:
							FLD_人物_气功_武功防御力增加百分比 = 0.005 * num3;
							break;
						case 150:
							base.医_万物回春 = num3;
							break;
						case 352:
							base.医_升天三气功_明镜止水 = num3 * 2.0;
							break;
						case 353:
							base.KhiCong_ManNguyetCuongPhong = num3;
							break;
						case 354:
							base.KhiCong_VongMaiThiemHoa = num3;
							break;
						case 671:
							base.KhiCong_150_TriTan = 2.2 + num3 * 0.8;
							break;
						case 683:
							base.KhiCong_JOB5_150_2 = num3 * 0.2;
							break;
						}
						continue;
						IL_1916:
						switch (value.气功ID)
						{
						case 343:
							base.KhiCong_ManNguyetCuongPhong = num3;
							continue;
						case 344:
							base.KhiCong_LietNhatDiemDiem = num3;
							continue;
						case 670:
							base.KhiCong_150_TriTan = 2.2 + num3 * 0.8;
							continue;
						case 682:
							base.KhiCong_JOB4_150_2 = num3 * 0.5;
							continue;
						case 340:
							break;
						case 341:
							goto IL_2906;
						case 342:
							goto IL_293b;
						default:
							continue;
						}
						goto IL_28ee;
						IL_1847:
						switch (value.气功ID)
						{
						case 33:
							base.KCTT_Thuong_130_NoHuyetXungThien_Plus = num3 * 0.01;
							continue;
						case 333:
							base.KhiCong_HongNguyetCuongPhong = num3;
							continue;
						case 334:
							base.KhiCong_ThanhXaXuatDong = num3;
							continue;
						case 669:
							base.KhiCong_150_TriTan = 2.2 + num3 * 0.8;
							continue;
						case 681:
							base.KhiCong_JOB3_150_2 = num3 * 0.3;
							continue;
						case 330:
							break;
						case 331:
							goto IL_2850;
						default:
							continue;
						}
						goto IL_2842;
						IL_1792:
						switch (value.气功ID)
						{
						case 323:
							base.KhiCong_HongNguyetCuongPhong = num3;
							continue;
						case 324:
							base.KhiCong_ThanhXaXuatDong = num3;
							continue;
						case 668:
							base.KhiCong_150_TriTan = 2.2 + num3 * 0.8;
							continue;
						case 680:
							base.KhiCong_JOB2_150_2 = num3 * 0.6;
							continue;
						case 25:
							base.剑_护身罡气 = 10.0 + num3;
							continue;
						case 321:
							break;
						case 322:
							goto IL_2780;
						default:
							continue;
						}
						goto IL_2768;
						IL_2672:
						Item_Wear[3].Item_Attack_Min = (int)((double)Item_Wear[3].Item_Attack_Min * (1.0 + 0.01 * num3));
						continue;
						IL_2780:
						base.剑_升天三气功_火凤临朝 = num3;
						continue;
						IL_256f:
						switch (value.气功ID)
						{
						case 380:
							break;
						case 381:
							goto IL_27c8;
						case 383:
							goto IL_2802;
						case 384:
							goto IL_281a;
						case 386:
							goto IL_2833;
						default:
							continue;
						}
						goto IL_278e;
						IL_24f4:
						switch (value.气功ID)
						{
						case 380:
							break;
						case 382:
							goto IL_26ac;
						case 383:
							goto IL_26cd;
						case 384:
							goto IL_26e5;
						case 385:
							goto IL_26fe;
						case 700:
							goto IL_2750;
						case 321:
							goto IL_2768;
						case 322:
							goto IL_2780;
						default:
							continue;
						}
						goto IL_2672;
						IL_2750:
						base.KC_DHL_TT1 = num3 * 0.5;
						continue;
						IL_248b:
						switch (value.气功ID)
						{
						case 601:
							break;
						case 381:
							FLD_人物_气功_攻击 = (int)num3;
							continue;
						case 382:
							FLD_人物_气功_防御 = (int)((double)FLD_Defense * (0.01 * num3));
							continue;
						case 383:
							base.升天一气功_运气行心 = 0.04 * num3;
							continue;
						case 384:
							人物_气功_追加_HP = (int)(8.0 * num3);
							continue;
						case 385:
							base.升天一气功_运气疗伤 = 0.1 + 0.01 * num3;
							continue;
						case 600:
							base.韩飞官_升天一气功 = 0.5 * num3;
							continue;
						default:
							continue;
						}
						goto IL_2780;
						IL_2408:
						switch (value.气功ID)
						{
						case 380:
							Item_Wear[3].Item_Attack_Min = (int)((double)Item_Wear[3].Item_Attack_Min * (1.0 + 0.01 * num3));
							continue;
						case 381:
							FLD_人物_气功_攻击 = (int)num3;
							continue;
						case 382:
							FLD_人物_气功_防御 = (int)((double)FLD_Defense * (0.01 * num3));
							continue;
						case 383:
							base.升天一气功_运气行心 = 0.02 * num3;
							continue;
						case 384:
							人物_气功_追加_HP = (int)(8.0 * num3);
							continue;
						case 385:
							base.升天一气功_运气疗伤 = 0.01 * num3;
							continue;
						case 386:
							FLD_人物_气功_回避 = (int)num3;
							continue;
						case 390:
							break;
						case 391:
							goto IL_2bf7;
						case 392:
							goto IL_2c05;
						default:
							continue;
						}
						goto IL_2be9;
						IL_2c05:
						base.琴师_升天三气功_子夜秋歌 = num3;
						continue;
						IL_2bf7:
						base.琴师_升天二气功_三潭映月 = num3;
						continue;
						IL_2be9:
						base.琴师_升天一气功_飞花点翠 = num3;
						continue;
						IL_237e:
						switch (value.气功ID)
						{
						case 370:
							break;
						case 371:
							goto IL_2a57;
						case 372:
							base.刺_升天三气功_以怒还怒 = num3;
							continue;
						case 380:
							Item_Wear[3].Item_Attack_Min = (int)((double)Item_Wear[3].Item_Attack_Min * (1.0 + 0.01 * num3));
							continue;
						case 381:
							FLD_人物_气功_攻击 = (int)num3;
							continue;
						case 382:
							base.升天一气功_金钟罡气 = num3;
							continue;
						case 383:
							base.升天一气功_运气行心 = 0.04 * num3;
							continue;
						case 384:
							人物_气功_追加_HP = (int)(8.0 * num3);
							continue;
						case 385:
							base.升天一气功_运气疗伤 = 0.1 + 0.01 * num3;
							continue;
						default:
							continue;
						}
						goto IL_2a49;
						IL_2a57:
						base.刺_升天二气功_顺水推舟 = num3 * 0.2;
						continue;
						IL_2a49:
						base.刺_升天一气功_夜魔缠身 = num3;
						continue;
						IL_22f6:
						switch (value.气功ID)
						{
						case 380:
							Item_Wear[3].Item_Attack_Min = (int)((double)Item_Wear[3].Item_Attack_Min * (1.0 + 0.01 * num3));
							break;
						case 381:
							FLD_人物_气功_攻击 = (int)num3;
							break;
						case 382:
							FLD_人物_气功_防御 = (int)((double)FLD_Defense * (0.01 * num3));
							break;
						case 384:
							人物_气功_追加_HP = (int)(8.0 * num3);
							break;
						case 385:
							base.升天一气功_运气疗伤 = 0.1 + 0.01 * num3;
							break;
						case 386:
							FLD_人物_气功_回避 = (int)num3;
							break;
						case 387:
							base.KhiCongTTChung_PhanNo = num3;
							break;
						case 350:
							base.医_升天一气功_狂意护体 = num3;
							break;
						case 351:
							base.医_升天二气功_无中生有 = num3;
							break;
						case 352:
							base.医_升天三气功_明镜止水 = num3 * 2.0;
							break;
						}
						continue;
						IL_2284:
						switch (value.气功ID)
						{
						case 381:
							base.KhiCongTTChung_DameMax = num3;
							continue;
						case 382:
							FLD_人物_气功_防御 = (int)((double)FLD_Defense * (0.01 * num3));
							continue;
						case 383:
							base.升天一气功_运气行心 = 0.04 * num3;
							continue;
						case 384:
							人物_气功_追加_HP = (int)(8.0 * num3);
							continue;
						case 385:
							base.升天一气功_运气疗伤 = 0.1 + 0.01 * num3;
							continue;
						case 340:
							break;
						case 341:
							goto IL_2906;
						case 342:
							goto IL_293b;
						default:
							continue;
						}
						goto IL_28ee;
						IL_293b:
						base.弓_升天三气功_天外三矢 = num3 * 0.5;
					}
				}
			}
			UpdatePowersAndStatus();
		}

		public void 更新情侣系统_old(int 对方是否在线, string 对方名字)
		{
			string hex = "AA558F0000A6007C17800001000000714C7E0000000000C4687E0000000000BDD600000000000000000000000000B7709C000000000000AC89014D00000000AC89014D040000002330000002D0A9B77406000000000000A59D0300CB1C0A4D000000000100000049204C6F716520596F752E000000000000000000000000000000000000000000001F86A3000000000000568055AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(对方是否在线), 0, array, 11, 2);
			byte[] bytes = Encoding.GetEncoding(1252).GetBytes(对方名字);
			Buffer.BlockCopy(bytes, 0, array, 31, bytes.Length);
			Buffer.BlockCopy(BitConverter.GetBytes(FLD_Couple_Level), 0, array, 67, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(FLD_Couple_Exp), 0, array, 71, 4);
			DateTime value = new DateTime(1970, 1, 1, 7, 0, 0);
			Buffer.BlockCopy(BitConverter.GetBytes((int)DateTime.Now.AddDays(0.0).Subtract(value).TotalSeconds), 0, array, 91, 4);
			byte[] bytes2 = Encoding.GetEncoding(1252).GetBytes("执子之手.与子偕老");
			Buffer.BlockCopy(bytes2, 0, array, 103, bytes2.Length);
			Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
			if (Client != null)
			{
				Client.Send多包(array, array.Length);
			}
		}

		public void 更新情侣系统(int 对方是否在线, string 对方名字, string string_12 = "")
		{
			byte[] array = Converter.hexStringToByte("AA558F0000A6007C17800001000000714C7E0000000000C4687E0000000000BDD600000000000000000000000000B7709C000000000000AC89014D00000000AC89014D040000002330000002D0A9B77406000000000000A59D0300CB1C0A4D00000000010000000000000000000000000000000000000000000000000000000000000000000000001F86A3000000000000568055AA");
			Buffer.BlockCopy(BitConverter.GetBytes(对方是否在线), 0, array, 11, 2);
			byte[] bytes = Encoding.GetEncoding(1252).GetBytes(对方名字);
			Buffer.BlockCopy(bytes, 0, array, 31, bytes.Length);
			Buffer.BlockCopy(BitConverter.GetBytes(FLD_Couple_Level), 0, array, 67, 4);
			Buffer.BlockCopy(BitConverter.GetBytes(FLD_Couple_Exp), 0, array, 71, 4);
			Buffer.BlockCopy(BitConverter.GetBytes((int)DateTime.Now.AddDays(0.0).Subtract(new DateTime(1970, 1, 1, 8, 0, 0)).TotalSeconds), 0, array, 91, 4);
			if (string_12.Length >= 16 && string_12.Length <= 32)
			{
				byte[] bytes2 = Encoding.Default.GetBytes(string_12);
				Buffer.BlockCopy(bytes2, 0, array, 103, bytes2.Length);
			}
			else
			{
				byte[] bytes2 = Encoding.Default.GetBytes("I Love You");
				Buffer.BlockCopy(bytes2, 0, array, 103, bytes2.Length);
			}
			Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
			if (Client != null)
			{
				Client.Send多包(array, array.Length);
			}
		}

		public void Event_x2(Players Play)
		{
			if (!Play.Show_Pic_Class.ContainsKey(World.IdItemX2))
			{
				int num = ((23 - DateTime.Now.Hour) * 3600 + (59 - DateTime.Now.Minute) * 60 + (59 - DateTime.Now.Second + 5)) * 1000;
				Class_Show_Pill value = new Class_Show_Pill(Play, num, World.IdItemX2, 0);
				Play.Show_Pic_Class.Add(World.IdItemX2, value);
				Play.Send_Packet_Show_Pic(BitConverter.GetBytes(World.IdItemX2), 1, num);
				Play.FLD_Event_Premium_Exp = 1.0;
				Play.UpdatePowersAndStatus();
				Play.Update_HP_MP_SP();
				Play.GameMessage("Sýò kiêòn: +" + FLD_Event_Premium_Exp * 100.0 + "% ðiêÒm kinh nghiêòm", 10);
			}
		}

		public void Event_x3(Players Play)
		{
			if (!Play.Show_Pic_Class.ContainsKey(World.IdItemX3))
			{
				int num = ((23 - DateTime.Now.Hour) * 3600 + (59 - DateTime.Now.Minute) * 60 + (59 - DateTime.Now.Second + 5)) * 1000;
				Class_Show_Pill value = new Class_Show_Pill(Play, num, World.IdItemX3, 0);
				Play.Show_Pic_Class.Add(World.IdItemX3, value);
				Play.Send_Packet_Show_Pic(BitConverter.GetBytes(World.IdItemX3), 1, num);
				Play.FLD_Event_Premium_Exp = 1.0;
				Play.UpdatePowersAndStatus();
				Play.Update_HP_MP_SP();
				Play.GameMessage("Sýò kiêòn: +" + FLD_Event_Premium_Exp * 100.0 + "% ðiêÒm kinh nghiêòm", 10);
			}
		}

		public int method_712(string NameCharacter, int Type)
		{
			return 0;
		}

		public void 更新人物数据(Players Play)
		{
			try
			{
				if (Play.Client != null)
				{
					PacketData packetData = 得到更新人物数据(Play);
					if (packetData != null && Client != null)
					{
						Client.SendPak(packetData, 25600, Play.UserSessionID);
					}
					if (packetData.Length < 224)
					{
						string text = Converter.ToString(packetData.ToArray3());
						Console.WriteLine(packetData.Length + " " + text);
						Form1.WriteLine(100, "更新人物数据" + packetData.Length + " " + text);
					}
					if (Play.PlayerShop != null)
					{
						更新个人商店数据(Play);
					}
					if (Play.Pet != null)
					{
						更新显示灵兽数据(Play);
						Play.更新灵兽HP_MP_SP();
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "更新人物数据 出错" + Client.WorldId + "|" + Client.ToString() + " " + ex);
			}
		}

		public double getNumberQigongItem(int job, int i)
		{
			switch (job)
			{
			case 1:
				switch (i)
				{
				case 0:
					return FLD_装备_追加_qigong_0_job1;
				case 1:
					return FLD_装备_追加_qigong_1_job1;
				case 2:
					return FLD_装备_追加_qigong_2_job1;
				case 3:
					return FLD_装备_追加_qigong_3_job1;
				case 4:
					return FLD_装备_追加_qigong_4_job1;
				case 5:
					return FLD_装备_追加_qigong_5_job1;
				case 6:
					return 0.0;
				case 7:
					return FLD_装备_追加_qigong_7_job1;
				case 8:
					return FLD_装备_追加_qigong_8_job1;
				case 9:
					return FLD_装备_追加_qigong_9_job1;
				case 10:
					return FLD_装备_追加_qigong_10_job1;
				case 11:
					return FLD_装备_追加_qigong_11_job1;
				default:
					return 0.0;
				}
			case 2:
				switch (i)
				{
				case 0:
					return FLD_装备_追加_qigong_0_job2;
				case 1:
					return FLD_装备_追加_qigong_1_job2;
				case 2:
					return FLD_装备_追加_qigong_2_job2;
				case 3:
					return FLD_装备_追加_qigong_3_job2;
				case 4:
					return FLD_装备_追加_qigong_4_job2;
				case 5:
					return FLD_装备_追加_qigong_5_job2;
				case 6:
					return 0.0;
				case 7:
					return FLD_装备_追加_qigong_7_job2;
				case 8:
					return FLD_装备_追加_qigong_8_job2;
				case 9:
					return FLD_装备_追加_qigong_9_job2;
				case 10:
					return FLD_装备_追加_qigong_10_job2;
				case 11:
					return FLD_装备_追加_qigong_11_job2;
				default:
					return 0.0;
				}
			case 3:
				switch (i)
				{
				case 0:
					return FLD_装备_追加_qigong_0_job3;
				case 1:
					return FLD_装备_追加_qigong_1_job3;
				case 2:
					return FLD_装备_追加_qigong_2_job3;
				case 3:
					return FLD_装备_追加_qigong_3_job3;
				case 4:
					return FLD_装备_追加_qigong_4_job3;
				case 5:
					return FLD_装备_追加_qigong_5_job3;
				case 6:
					return 0.0;
				case 7:
					return FLD_装备_追加_qigong_7_job3;
				case 8:
					return FLD_装备_追加_qigong_8_job3;
				case 9:
					return FLD_装备_追加_qigong_9_job3;
				case 10:
					return FLD_装备_追加_qigong_10_job3;
				case 11:
					return FLD_装备_追加_qigong_11_job3;
				default:
					return 0.0;
				}
			case 4:
				switch (i)
				{
				case 0:
					return FLD_装备_追加_qigong_0_job4;
				case 1:
					return FLD_装备_追加_qigong_1_job4;
				case 2:
					return FLD_装备_追加_qigong_2_job4;
				case 3:
					return FLD_装备_追加_qigong_3_job4;
				case 4:
					return FLD_装备_追加_qigong_4_job4;
				case 5:
					return FLD_装备_追加_qigong_5_job4;
				case 6:
					return 0.0;
				case 7:
					return FLD_装备_追加_qigong_7_job4;
				case 8:
					return FLD_装备_追加_qigong_8_job4;
				case 9:
					return FLD_装备_追加_qigong_9_job4;
				case 10:
					return FLD_装备_追加_qigong_10_job4;
				case 11:
					return FLD_装备_追加_qigong_11_job4;
				default:
					return 0.0;
				}
			case 5:
				switch (i)
				{
				case 0:
					return FLD_装备_追加_qigong_0_job5;
				case 1:
					return FLD_装备_追加_qigong_1_job5;
				case 2:
					return FLD_装备_追加_qigong_2_job5;
				case 3:
					return FLD_装备_追加_qigong_3_job5;
				case 4:
					return FLD_装备_追加_qigong_4_job5;
				case 5:
					return FLD_装备_追加_qigong_5_job5;
				case 6:
					return 0.0;
				case 7:
					return FLD_装备_追加_qigong_7_job5;
				case 8:
					return FLD_装备_追加_qigong_8_job5;
				case 9:
					return FLD_装备_追加_qigong_9_job5;
				case 10:
					return FLD_装备_追加_qigong_10_job5;
				case 11:
					return FLD_装备_追加_qigong_11_job5;
				default:
					return 0.0;
				}
			case 6:
				switch (i)
				{
				case 0:
					return FLD_装备_追加_qigong_0_job6;
				case 1:
					return FLD_装备_追加_qigong_1_job6;
				case 2:
					return FLD_装备_追加_qigong_2_job6;
				case 3:
					return FLD_装备_追加_qigong_3_job6;
				case 4:
					return FLD_装备_追加_qigong_4_job6;
				case 5:
					return FLD_装备_追加_qigong_5_job6;
				case 6:
					return 0.0;
				case 7:
					return FLD_装备_追加_qigong_7_job6;
				case 8:
					return FLD_装备_追加_qigong_8_job6;
				case 9:
					return FLD_装备_追加_qigong_9_job6;
				case 10:
					return FLD_装备_追加_qigong_10_job6;
				case 11:
					return FLD_装备_追加_qigong_11_job6;
				default:
					return 0.0;
				}
			case 7:
				switch (i)
				{
				case 0:
					return FLD_装备_追加_qigong_0_job7;
				case 1:
					return FLD_装备_追加_qigong_1_job7;
				case 2:
					return FLD_装备_追加_qigong_2_job7;
				case 3:
					return FLD_装备_追加_qigong_3_job7;
				case 4:
					return FLD_装备_追加_qigong_4_job7;
				case 5:
					return FLD_装备_追加_qigong_5_job7;
				case 6:
					return 0.0;
				case 7:
					return FLD_装备_追加_qigong_7_job7;
				case 8:
					return FLD_装备_追加_qigong_8_job7;
				case 9:
					return FLD_装备_追加_qigong_9_job7;
				case 10:
					return FLD_装备_追加_qigong_10_job7;
				case 11:
					return FLD_装备_追加_qigong_11_job7;
				default:
					return 0.0;
				}
			case 8:
				switch (i)
				{
				case 0:
					return FLD_装备_追加_qigong_0_job8;
				case 1:
					return FLD_装备_追加_qigong_1_job8;
				case 2:
					return FLD_装备_追加_qigong_2_job8;
				case 3:
					return FLD_装备_追加_qigong_3_job8;
				case 4:
					return FLD_装备_追加_qigong_4_job8;
				case 5:
					return FLD_装备_追加_qigong_5_job8;
				case 6:
					return 0.0;
				case 7:
					return FLD_装备_追加_qigong_7_job8;
				case 8:
					return FLD_装备_追加_qigong_8_job8;
				case 9:
					return FLD_装备_追加_qigong_9_job8;
				case 10:
					return FLD_装备_追加_qigong_10_job8;
				case 11:
					return FLD_装备_追加_qigong_11_job8;
				default:
					return 0.0;
				}
			case 9:
				switch (i)
				{
				case 0:
					return FLD_装备_追加_qigong_0_job9;
				case 1:
					return FLD_装备_追加_qigong_1_job9;
				case 2:
					return FLD_装备_追加_qigong_2_job9;
				case 3:
					return FLD_装备_追加_qigong_3_job9;
				case 4:
					return FLD_装备_追加_qigong_4_job9;
				case 5:
					return FLD_装备_追加_qigong_5_job9;
				case 6:
					return 0.0;
				case 7:
					return FLD_装备_追加_qigong_7_job9;
				case 8:
					return FLD_装备_追加_qigong_8_job9;
				case 9:
					return FLD_装备_追加_qigong_9_job9;
				case 10:
					return FLD_装备_追加_qigong_10_job9;
				case 11:
					return FLD_装备_追加_qigong_11_job9;
				default:
					return 0.0;
				}
			case 10:
				switch (i)
				{
				case 0:
					return FLD_装备_追加_qigong_0_job10;
				case 1:
					return FLD_装备_追加_qigong_1_job10;
				case 2:
					return FLD_装备_追加_qigong_2_job10;
				case 3:
					return FLD_装备_追加_qigong_3_job10;
				case 4:
					return FLD_装备_追加_qigong_4_job10;
				case 5:
					return FLD_装备_追加_qigong_5_job10;
				case 6:
					return 0.0;
				case 7:
					return FLD_装备_追加_qigong_7_job10;
				case 8:
					return FLD_装备_追加_qigong_8_job10;
				case 9:
					return FLD_装备_追加_qigong_9_job10;
				case 10:
					return FLD_装备_追加_qigong_10_job10;
				case 11:
					return FLD_装备_追加_qigong_11_job10;
				default:
					return 0.0;
				}
			case 11:
				switch (i)
				{
				case 0:
					return FLD_装备_追加_qigong_0_job11;
				case 1:
					return FLD_装备_追加_qigong_1_job11;
				case 2:
					return FLD_装备_追加_qigong_2_job11;
				case 3:
					return FLD_装备_追加_qigong_3_job11;
				case 4:
					return FLD_装备_追加_qigong_4_job11;
				case 5:
					return FLD_装备_追加_qigong_5_job11;
				case 6:
					return 0.0;
				case 7:
					return FLD_装备_追加_qigong_7_job11;
				case 8:
					return FLD_装备_追加_qigong_8_job11;
				case 9:
					return FLD_装备_追加_qigong_9_job11;
				case 10:
					return FLD_装备_追加_qigong_10_job11;
				case 11:
					return FLD_装备_追加_qigong_11_job11;
				default:
					return 0.0;
				}
			case 12:
				switch (i)
				{
				case 0:
					return FLD_装备_追加_qigong_0_job12;
				case 1:
					return FLD_装备_追加_qigong_1_job12;
				case 2:
					return FLD_装备_追加_qigong_2_job12;
				case 3:
					return FLD_装备_追加_qigong_3_job12;
				case 4:
					return FLD_装备_追加_qigong_4_job12;
				case 5:
					return FLD_装备_追加_qigong_5_job12;
				case 6:
					return 0.0;
				case 7:
					return FLD_装备_追加_qigong_7_job12;
				case 8:
					return FLD_装备_追加_qigong_8_job12;
				case 9:
					return FLD_装备_追加_qigong_9_job12;
				case 10:
					return FLD_装备_追加_qigong_10_job12;
				case 11:
					return FLD_装备_追加_qigong_11_job12;
				default:
					return 0.0;
				}
			default:
				return 0.0;
			}
		}

		public void UpdatePowersAndStatus()
		{
			bool flag = false;
			if ((Player_Zx == 1 && list_时间药品.ContainsKey(1008001042)) || (Player_Zx == 2 && list_时间药品.ContainsKey(1008001043)))
			{
				flag = true;
			}
			if ((double)Player_WuXun > World.Wxlever[7] - 50000.0 && (World.ThuPhiVoHuan8 == 0 || flag))
			{
				人物武勋阶段 = 8;
			}
			else if ((double)Player_WuXun > World.Wxlever[6])
			{
				人物武勋阶段 = 7;
			}
			else if ((double)Player_WuXun > World.Wxlever[5])
			{
				人物武勋阶段 = 6;
			}
			else if ((double)Player_WuXun > World.Wxlever[4])
			{
				人物武勋阶段 = 5;
			}
			else if ((double)Player_WuXun > World.Wxlever[3])
			{
				人物武勋阶段 = 4;
			}
			else if ((double)Player_WuXun > World.Wxlever[2])
			{
				人物武勋阶段 = 3;
			}
			else if ((double)Player_WuXun > World.Wxlever[1])
			{
				人物武勋阶段 = 2;
			}
			else if ((double)Player_WuXun > World.Wxlever[0])
			{
				人物武勋阶段 = 1;
			}
			try
			{
				PacketData packetData = new PacketData();
				packetData.WriteShort(Player_Level);
				packetData.WriteShort(FLD_Tam_1 + FLD_装备_追加_tam);
				packetData.WriteShort(FLD_Khi_2 + FLD_装备_追加_khi);
				packetData.WriteShort(FLD_The_3 + FLD_装备_追加_the);
				packetData.WriteShort(FLD_Hon_4 + FLD_装备_追加_hon);
				packetData.WriteShort(0);
				packetData.WriteShort((int)FLD_人物基本_攻击);
				packetData.WriteShort((int)FLD_人物基本_防御);
				packetData.WriteShort(FLD_人物基本_命中);
				packetData.WriteShort(FLD_人物基本_回避);
				packetData.WriteShort(Player_Qigong_point);
				for (int i = 0; i < 12; i++)
				{
					int 气功ID = 气功[i].气功ID;
					packetData.WriteShort(气功ID);
					if (气功[i].气功ID == 0)
					{
						packetData.WriteShort(0);
					}
					else if (气功[i].气功量 == 0)
					{
						packetData.WriteShort(0);
					}
					else
					{
						int num = 气功[i].气功量 + FLD_Item_Level_Pran + Character_Qigong + FLD_武勋_追加_气功 + flowerEffectQigong + FLD_斗神_追加_气功;
						if (num != 0 && num > World.最大气功数)
						{
							num = World.最大气功数;
						}
						packetData.WriteShort(num + (int)getNumberQigongItem(Player_Job, i));
					}
				}
				packetData.WriteShort(0);
				packetData.WriteShort(0);
				packetData.WriteShort(0);
				packetData.WriteShort(0);
				packetData.WriteShort(0);
				packetData.WriteShort(0);
				packetData.WriteShort(0);
				if (Player_Job == 8)
				{
					for (int j = 0; j < 12; j++)
					{
						if (Array_Skill_Book[0, j] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, j].FLD_PID))
						{
							packetData.WriteInt(Array_Skill_Book[0, j].FLD_PID);
						}
						else
						{
							packetData.WriteInt(0);
						}
					}
					for (int k = 11; k < 17; k++)
					{
						if (Array_Skill_Book[0, k] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, k].FLD_PID))
						{
							packetData.WriteInt(Array_Skill_Book[0, k].FLD_PID);
						}
						else
						{
							packetData.WriteInt(0);
						}
					}
					for (int l = 16; l < 18; l++)
					{
						if (Array_Skill_Book[0, l] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, l].FLD_PID))
						{
							packetData.WriteInt(Array_Skill_Book[0, l].FLD_PID);
						}
						else
						{
							packetData.WriteInt(0);
						}
					}
					for (int m = 17; m < 21; m++)
					{
						if (Array_Skill_Book[0, m] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, m].FLD_PID))
						{
							packetData.WriteInt(Array_Skill_Book[0, m].FLD_PID);
						}
						else
						{
							packetData.WriteInt(0);
						}
					}
					for (int n = 20; n < 22; n++)
					{
						if (Array_Skill_Book[0, n] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, n].FLD_PID))
						{
							packetData.WriteInt(Array_Skill_Book[0, n].FLD_PID);
						}
						else
						{
							packetData.WriteInt(0);
						}
					}
					for (int num2 = 28; num2 < 32; num2++)
					{
						if (Array_Skill_Book[0, num2] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num2].FLD_PID))
						{
							packetData.WriteInt(Array_Skill_Book[0, num2].FLD_PID);
						}
						else
						{
							packetData.WriteInt(0);
						}
					}
					for (int num3 = 0; num3 < 11; num3++)
					{
						if (Array_Skill_Book[1, num3] != null && !disable_Skill_List.Contains(Array_Skill_Book[1, num3].FLD_PID))
						{
							packetData.WriteInt(Array_Skill_Book[1, num3].FLD_PID);
						}
						else
						{
							packetData.WriteInt(0);
						}
					}
					for (int num4 = 21; num4 < 29; num4++)
					{
						if (Array_Skill_Book[0, num4] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num4].FLD_PID))
						{
							packetData.WriteInt(Array_Skill_Book[0, num4].FLD_PID);
						}
						else
						{
							packetData.WriteInt(0);
						}
					}
					for (int num4 = 33; num4 < 35; num4++)
					{
						if (Array_Skill_Book[0, num4] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num4].FLD_PID))
						{
							packetData.WriteInt(Array_Skill_Book[0, num4].FLD_PID);
						}
						else
						{
							packetData.WriteInt(0);
						}
					}
					for (int num5 = 0; num5 < 25; num5++)
					{
						packetData.WriteInt(0);
					}
					for (int num6 = 0; num6 < 12; num6++)
					{
						if (Array_Skill_Book[0, num6] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num6].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[0, num6].武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int num7 = 11; num7 < 17; num7++)
					{
						if (Array_Skill_Book[0, num7] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num7].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[0, num7].武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int num8 = 16; num8 < 18; num8++)
					{
						if (Array_Skill_Book[0, num8] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num8].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[0, num8].武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int num9 = 17; num9 < 21; num9++)
					{
						if (Array_Skill_Book[0, num9] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num9].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[0, num9].武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int num10 = 20; num10 < 22; num10++)
					{
						if (Array_Skill_Book[0, num10] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num10].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[0, num10].武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int num11 = 28; num11 < 32; num11++)
					{
						packetData.WriteShort(0);
					}
					for (int num12 = 0; num12 < 11; num12++)
					{
						packetData.WriteShort(0);
					}
					for (int num13 = 21; num13 < 29; num13++)
					{
						if (Array_Skill_Book[0, num13] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num13].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[0, num13].武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int num13 = 33; num13 < 35; num13++)
					{
						if (Array_Skill_Book[0, num13] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num13].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[0, num13].武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int num14 = 0; num14 < 25; num14++)
					{
						packetData.WriteShort(0);
					}
					for (int num15 = 0; num15 < 12; num15++)
					{
						if (Array_Skill_Book[0, num15] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num15].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[0, num15].最高武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int num16 = 11; num16 < 17; num16++)
					{
						if (Array_Skill_Book[0, num16] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num16].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[0, num16].最高武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int num17 = 16; num17 < 18; num17++)
					{
						if (Array_Skill_Book[0, num17] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num17].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[0, num17].最高武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int num18 = 17; num18 < 21; num18++)
					{
						if (Array_Skill_Book[0, num18] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num18].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[0, num18].最高武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int num19 = 20; num19 < 22; num19++)
					{
						if (Array_Skill_Book[0, num19] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num19].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[0, num19].最高武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int num20 = 28; num20 < 32; num20++)
					{
						packetData.WriteShort(0);
					}
					for (int num21 = 0; num21 < 11; num21++)
					{
						packetData.WriteShort(0);
					}
					for (int num22 = 21; num22 < 29; num22++)
					{
						if (Array_Skill_Book[0, num22] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num22].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[0, num22].最高武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int num22 = 33; num22 < 35; num22++)
					{
						if (Array_Skill_Book[0, num22] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num22].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[0, num22].最高武功_等级);
						}
						else
						{
							packetData.WriteShort(1);
						}
					}
					packetData.WriteShort(0);
					for (int num23 = 4; num23 < 18; num23++)
					{
						if (Array_Skill_Book[2, num23] != null && !disable_Skill_List.Contains(Array_Skill_Book[2, num23].FLD_PID))
						{
							packetData.WriteInt(Array_Skill_Book[2, num23].FLD_PID);
						}
						else
						{
							packetData.WriteInt(0);
						}
					}
				}
				else if (Player_Job == 9)
				{
					for (int num6 = 0; num6 < 32; num6++)
					{
						if (Array_Skill_Book[0, num6] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num6].FLD_PID))
						{
							packetData.WriteInt(Array_Skill_Book[0, num6].FLD_PID);
						}
						else
						{
							packetData.WriteInt(0);
						}
					}
					for (int num7 = 0; num7 < 28; num7++)
					{
						if (Array_Skill_Book[1, num7] != null && !disable_Skill_List.Contains(Array_Skill_Book[1, num7].FLD_PID))
						{
							packetData.WriteInt(Array_Skill_Book[1, num7].FLD_PID);
						}
						else
						{
							packetData.WriteInt(0);
						}
					}
					packetData.WriteInt(0);
					for (int num24 = 0; num24 < 15; num24++)
					{
						if (Array_Skill_Book[2, num24] != null && !disable_Skill_List.Contains(Array_Skill_Book[2, num24].FLD_PID))
						{
							packetData.WriteInt(Array_Skill_Book[2, num24].FLD_PID);
						}
						else
						{
							packetData.WriteInt(0);
						}
					}
					for (int num8 = 0; num8 < 32; num8++)
					{
						if (Array_Skill_Book[0, num8] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num8].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[0, num8].武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int num9 = 0; num9 < 28; num9++)
					{
						if (Array_Skill_Book[1, num9] != null && !disable_Skill_List.Contains(Array_Skill_Book[1, num9].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[1, num9].武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					packetData.WriteShort(0);
					for (int num25 = 0; num25 < 15; num25++)
					{
						if (Array_Skill_Book[2, num25] != null && !disable_Skill_List.Contains(Array_Skill_Book[2, num25].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[2, num25].武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int num19 = 0; num19 < 32; num19++)
					{
						if (Array_Skill_Book[0, num19] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num19].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[0, num19].最高武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int k = 0; k < 28; k++)
					{
						if (Array_Skill_Book[1, k] != null && !disable_Skill_List.Contains(Array_Skill_Book[1, k].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[1, k].最高武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					packetData.WriteShort(0);
					for (int num26 = 0; num26 < 15; num26++)
					{
						if (Array_Skill_Book[2, num26] != null && !disable_Skill_List.Contains(Array_Skill_Book[2, num26].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[2, num26].最高武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					if (Array_Skill_Book[2, 16] != null && !disable_Skill_List.Contains(Array_Skill_Book[2, 16].FLD_PID))
					{
						packetData.WriteInt(Array_Skill_Book[2, 16].FLD_PID);
					}
					else
					{
						packetData.WriteInt(0);
					}
					if (Array_Skill_Book[2, 17] != null && !disable_Skill_List.Contains(Array_Skill_Book[2, 17].FLD_PID))
					{
						packetData.WriteInt(Array_Skill_Book[2, 17].FLD_PID);
					}
					else
					{
						packetData.WriteInt(1);
					}
				}
				else
				{
					for (int num6 = 0; num6 < 32; num6++)
					{
						if (Array_Skill_Book[0, num6] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num6].FLD_PID))
						{
							packetData.WriteInt(Array_Skill_Book[0, num6].FLD_PID);
						}
						else
						{
							packetData.WriteInt(0);
						}
					}
					for (int num7 = 0; num7 < 28; num7++)
					{
						if (Array_Skill_Book[1, num7] != null && !disable_Skill_List.Contains(Array_Skill_Book[1, num7].FLD_PID))
						{
							packetData.WriteInt(Array_Skill_Book[1, num7].FLD_PID);
						}
						else
						{
							packetData.WriteInt(0);
						}
					}
					for (int num24 = 0; num24 < 16; num24++)
					{
						if (Array_Skill_Book[2, num24] != null && !disable_Skill_List.Contains(Array_Skill_Book[2, num24].FLD_PID))
						{
							packetData.WriteInt(Array_Skill_Book[2, num24].FLD_PID);
						}
						else
						{
							packetData.WriteInt(0);
						}
					}
					for (int num8 = 0; num8 < 32; num8++)
					{
						if (Array_Skill_Book[0, num8] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num8].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[0, num8].武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int num9 = 0; num9 < 28; num9++)
					{
						if (Array_Skill_Book[1, num9] != null && !disable_Skill_List.Contains(Array_Skill_Book[1, num9].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[1, num9].武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int num25 = 0; num25 < 16; num25++)
					{
						if (Array_Skill_Book[2, num25] != null && !disable_Skill_List.Contains(Array_Skill_Book[2, num25].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[2, num25].武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int num19 = 0; num19 < 32; num19++)
					{
						if (Array_Skill_Book[0, num19] != null && !disable_Skill_List.Contains(Array_Skill_Book[0, num19].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[0, num19].最高武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int k = 0; k < 28; k++)
					{
						if (Array_Skill_Book[1, k] != null && !disable_Skill_List.Contains(Array_Skill_Book[1, k].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[1, k].最高武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					for (int num26 = 0; num26 < 16; num26++)
					{
						if (Array_Skill_Book[2, num26] != null && !disable_Skill_List.Contains(Array_Skill_Book[2, num26].FLD_PID))
						{
							packetData.WriteShort(Array_Skill_Book[2, num26].最高武功_等级);
						}
						else
						{
							packetData.WriteShort(0);
						}
					}
					if (Array_Skill_Book[2, 16] != null && !disable_Skill_List.Contains(Array_Skill_Book[2, 16].FLD_PID))
					{
						packetData.WriteInt(Array_Skill_Book[2, 16].FLD_PID);
					}
					else
					{
						packetData.WriteInt(0);
					}
					if (Array_Skill_Book[2, 17] != null && !disable_Skill_List.Contains(Array_Skill_Book[2, 17].FLD_PID))
					{
						packetData.WriteInt(Array_Skill_Book[2, 17].FLD_PID);
					}
					else
					{
						packetData.WriteInt(1);
					}
				}
				packetData.WriteInt((int)(((double)(FLD_Qigong_Defense_Skill + FLD_装备_追加_tam + (int)(base.KCV17_KC7 * (double)FLD_Defense)) + FLD_Pill_Defense_Skill + FLD_Item_Defense_Skill * 100.000000001) * (1.0 + FLD_Item_Skill_Def_Percentage + fldItemSkillDefPercentage + FLD_人物_气功_武功防御力增加百分比 + coupleEffectSkillDefense) * 1.0));
				packetData.WriteInt(Player_WuXun);
				packetData.WriteInt(Player_FLD_SE);
				packetData.WriteInt(1);
				packetData.WriteInt(FLD_攻击速度);
				packetData.WriteShort(1);
				foreach (升天气功类 value in 升天气功.Values)
				{
					packetData.WriteShort(value.气功ID);
					if (value.气功量 != 0)
					{
						int num = value.气功量 + FLD_Item_Level_Pran + Character_Qigong + FLD_武勋_追加_气功 + flowerEffectQigong + FLD_斗神_追加_气功;
						if (num != 0 && num > World.最大气功数)
						{
							num = World.最大气功数;
						}
						packetData.WriteShort(num);
					}
					else
					{
						packetData.WriteShort(0);
					}
				}
				for (int num27 = 0; num27 < 15 - 升天气功.Count; num27++)
				{
					packetData.WriteShort(0);
					packetData.WriteShort(0);
				}
				packetData.WriteShort(0);
				for (int num28 = 0; num28 < ((World.Newversion < 12) ? 18 : ((World.Newversion >= 17) ? 25 : 21)); num28++)
				{
					if (Array_Skill_Book[3, num28] != null)
					{
						packetData.WriteInt(Array_Skill_Book[3, num28].FLD_PID);
						if (!disable_Skill_List.Contains(Array_Skill_Book[3, num28].FLD_PID))
						{
							packetData.WriteInt(Array_Skill_Book[3, num28].武功_等级);
						}
						else
						{
							packetData.WriteInt(0);
						}
					}
					else
					{
						packetData.WriteInt(0);
						packetData.WriteInt(0);
					}
				}
				if (World.Newversion >= 15)
				{
					packetData.WriteInt(0, 6);
				}
				if (World.Newversion >= 12)
				{
					packetData.WriteInt(升天武功点数);
					for (int num29 = 0; num29 < 15; num29++)
					{
						if (num29 < 12)
						{
							if (气功[num29].气功ID != 0)
							{
								packetData.WriteByte(气功[num29].气功量);
							}
							else
							{
								packetData.WriteByte(0);
							}
						}
						else
						{
							packetData.WriteByte(0);
						}
					}
					foreach (升天气功类 value2 in 升天气功.Values)
					{
						packetData.WriteByte((byte)value2.气功量);
					}
					for (int num30 = 0; num30 < 15 - 升天气功.Count; num30++)
					{
						packetData.WriteByte(0);
					}
					packetData.WriteShort(0);
				}
				else
				{
					packetData.WriteInt(升天武功点数);
					for (int num29 = 0; num29 < 15; num29++)
					{
						if (num29 < 12)
						{
							if (气功[num29].气功ID != 0)
							{
								packetData.WriteByte((byte)气功[num29].气功量);
							}
							else
							{
								packetData.WriteByte(0);
							}
						}
						else
						{
							packetData.WriteByte(0);
						}
					}
					foreach (升天气功类 value3 in 升天气功.Values)
					{
						packetData.WriteByte((byte)value3.气功量);
					}
					for (int num30 = 0; num30 < 15 - 升天气功.Count; num30++)
					{
						packetData.WriteByte(0);
					}
					packetData.WriteShort(0);
				}
				packetData.WriteInt(FLD_MetMoi + 1);
				if (World.Newversion >= 17)
				{
					packetData.WriteInt(200);
				}
				packetData.WriteInt((int)((FLD_Item_Attack_Skill * 100.000000001 + FLD_人物_气功_武功攻击力增加百分比) * ((1.0 + FLD_Item_Skill_Attack_Percentage + fldItemSkillAttackPercentage) * 1.0)));
				packetData.WriteInt(Player_WuXun);
				packetData.WriteShort(每日武勋);
				packetData.WriteShort(每日武勋);
				packetData.WriteShort(2000);
				packetData.WriteShort(FLD_斗神_追加_攻击);
				packetData.WriteShort(FLD_斗神_追加_防御);
				packetData.WriteShort(1111);
				packetData.WriteShort(2222);
				packetData.WriteShort(3333);
				packetData.WriteLong(0L);
				packetData.WriteLong(0L);
				if (Client != null)
				{
					Client.SendPak(packetData, 27392, UserSessionID);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
				Form1.WriteLine(1, "更新武功和状态出错[" + Userid + "]-[" + UserName + "] " + ex.Message);
			}
		}

		public void 更新显示灵兽数据(Players thisPlay)
		{
			if (World.Newversion < 11)
			{
				try
				{
					string hex = "AA556800019E9E64005800010000009E9E0000BDDCBDDC000000000000000000000000000000003203040000000000FA590544000070417F86C64465000000E69EA42770920F24000000008425A627000100009CBBFF43D322BDC370F9CD440000000000000000000000000055AA";
					byte[] array = Converter.hexStringToByte(hex);
					Buffer.BlockCopy(BitConverter.GetBytes(thisPlay.Pet_ID), 0, array, 5, 2);
					Buffer.BlockCopy(BitConverter.GetBytes(thisPlay.Pet_ID), 0, array, 15, 2);
					byte[] bytes = Encoding.GetEncoding(1252).GetBytes(thisPlay.Pet.Name);
					Buffer.BlockCopy(bytes, 0, array, 19, bytes.Length);
					Buffer.BlockCopy(BitConverter.GetBytes(thisPlay.Pet.Pet_FLD_LEVEL), 0, array, 39, 1);
					Buffer.BlockCopy(BitConverter.GetBytes(thisPlay.Pet.FLD_JOB_LEVEL), 0, array, 40, 1);
					Buffer.BlockCopy(BitConverter.GetBytes(thisPlay.Pet.FLD_JOB), 0, array, 41, 1);
					Buffer.BlockCopy(BitConverter.GetBytes(thisPlay.Pet.Bs), 0, array, 43, 1);
					Buffer.BlockCopy(BitConverter.GetBytes(thisPlay.Pet.人物坐标_X), 0, array, 47, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(thisPlay.Pet.人物坐标_Z), 0, array, 51, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(thisPlay.Pet.人物坐标_Y), 0, array, 55, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(thisPlay.Pet.人物坐标_MAP), 0, array, 59, 2);
					Buffer.BlockCopy(BitConverter.GetBytes(thisPlay.Pet.人物坐标_X), 0, array, 83, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(thisPlay.Pet.人物坐标_Y), 0, array, 91, 4);
					int num = 0;
					while (true)
					{
						bool flag = true;
						if (num >= 4)
						{
							break;
						}
						try
						{
							byte[] get_Byte_Item_PID = thisPlay.Pet.宠物以装备[num].Get_Byte_Item_PID;
						}
						catch
						{
						}
						num++;
					}
					if (Client != null)
					{
						Client.Send多包(array, array.Length);
					}
				}
				catch
				{
				}
			}
		}

		public void 更新制作系统()
		{
			List<int> list = clsItemCraft.Get制作物品类列表(Craft_Type, FLD_制作等级);
			if (list != null && list.Count > 0)
			{
				PacketData packetData = new PacketData();
				packetData.WriteShort(list.Count);
				foreach (int item in list)
				{
					packetData.WriteLong(item);
					packetData.WriteInt(10000);
					packetData.WriteShort(0);
					packetData.WriteShort(0);
					packetData.WriteInt(1);
				}
				if (Client != null)
				{
					Client.SendPak(packetData, 13079, UserSessionID);
				}
			}
		}

		public void 购买物品提示(int id)
		{
			string hex = "AA55170000000093000800050000000E00000000000000000000055AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(id), 0, array, 15, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 烟花()
		{
			string hex = "AA551300000A007F000400CD99053C000000000000000055AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
			SendRangeOfPackets(array, array.Length);
		}

		public void 计算人物基本数据()
		{
			int 人物最高等级 = World.人物最高等级;
			if (Player_Level > 人物最高等级)
			{
				Player_Level = 人物最高等级;
			}
			人物最大经验 = (long)World.Level[Player_Level];
			int player_Level = Player_Level;
			while (Player_FLD_EXP >= 人物最大经验 && Player_Level < World.人物最高等级)
			{
				if (Client == null || !Client.Running)
				{
					return;
				}
				Player_Level++;
				Player_FLD_HP = Player_HP_Max;
				人物最大经验 = (long)World.Level[Player_Level];
				if (World.是否开启等级奖励 == 1)
				{
					foreach (等级奖励类 value in World.等级奖励数据.Values)
					{
						if (Player_Level == value.级别)
						{
							Players players = World.FindPlayerbyID(UserSessionID);
							if (转生次数 >= World.转生次数领奖控制)
							{
								GameMessage(World.转生次数领奖控制 + "次转生后不能领取等级奖励", 20, "友情提示");
							}
							else
							{
								players?.冲级奖励();
							}
						}
					}
				}
			}
			if (Player_Level - player_Level > 0)
			{
				升级后的提示(1);
				int num = Player_Level - player_Level;
				if (num > 0)
				{
					for (int i = 0; i < num; i++)
					{
						if (Player_Level < 35)
						{
							Player_Qigong_point++;
						}
						else if (Player_Level < 109)
						{
							Player_Qigong_point += 2;
						}
						else
						{
							Player_Qigong_point += 3;
						}
					}
				}
			}
			人物最大_SP = 100 + Player_Level * 5;
			_人物负重总 = 500 + 50 * Player_Level;
			人物基本最大_HP = 0;
			人物基本最大_MP = 0;
			FLD_Tam_1 = 0;
			FLD_Hon_4 = 0;
			FLD_Accuracy = 0;
			FLD_Evasion = 0;
			FLD_Khi_2 = 0;
			FLD_The_3 = 0;
			FLD_Attack = 0;
			FLD_Defense = 0;
			switch (Player_Job)
			{
			case 1:
				FLD_Tam_1 = 7 + Player_Level;
				FLD_Khi_2 = 8;
				FLD_The_3 = 15;
				FLD_Hon_4 = 8 + Player_Level;
				人物基本最大_HP = 133 + Player_Level * 12;
				人物基本最大_MP = 114 + Player_Level * 2;
				FLD_Accuracy = (int)(2.75 + (double)Player_Level * 0.24);
				FLD_Evasion = (int)(4.0 + (double)Player_Level * 0.5);
				FLD_Attack = 8 + Player_Level * 2;
				FLD_Defense = 15;
				for (int l = 2; l <= Player_Level; l++)
				{
					if (l % 2 == 0)
					{
						FLD_Khi_2 += 2;
						FLD_The_3 += 2;
						FLD_Defense += 2;
					}
					else
					{
						FLD_Khi_2++;
						FLD_The_3++;
						FLD_Defense++;
					}
				}
				break;
			case 2:
				FLD_Tam_1 = 9;
				FLD_Khi_2 = 9 + Player_Level * 2;
				FLD_The_3 = 10 + Player_Level;
				FLD_Hon_4 = 7 + Player_Level * 2;
				人物基本最大_HP = 124 + Player_Level * 9;
				人物基本最大_MP = 115 + Player_Level * 3;
				FLD_Accuracy = (int)(1.51 + (double)Player_Level * 0.75);
				FLD_Evasion = (int)(3.0 + (double)Player_Level * 1.1);
				FLD_Attack = 9 + Player_Level * 2;
				FLD_Defense = 10 + Player_Level;
				for (int k = 2; k <= Player_Level; k++)
				{
					if (k % 2 == 0)
					{
						FLD_Tam_1++;
					}
					else
					{
						FLD_Tam_1 += 2;
					}
				}
				break;
			case 3:
				FLD_Tam_1 = 8 + Player_Level;
				FLD_Khi_2 = 10 + Player_Level * 3;
				FLD_The_3 = 10 + Player_Level;
				FLD_Hon_4 = 6 + Player_Level;
				人物基本最大_HP = 126 + Player_Level * 7;
				人物基本最大_MP = 116 + Player_Level * 2;
				FLD_Accuracy = (int)(2.0 + (double)Player_Level * 0.3);
				FLD_Evasion = (int)(3.0 + (double)Player_Level * 0.5);
				FLD_Attack = 10 + Player_Level * 3;
				FLD_Defense = 10 + Player_Level;
				break;
			case 4:
				FLD_Tam_1 = 7 + Player_Level * 2;
				FLD_Khi_2 = 11;
				FLD_The_3 = 8 + Player_Level;
				FLD_Hon_4 = 8 + Player_Level * 3;
				人物基本最大_HP = 127 + Player_Level * 6;
				人物基本最大_MP = 114 + Player_Level * 4;
				FLD_Accuracy = (int)(2.4 + (double)Player_Level * 0.9);
				FLD_Evasion = (int)(4.0 + (double)Player_Level * 1.5);
				FLD_Attack = 11;
				FLD_Defense = 8 + Player_Level;
				for (int j = 2; j <= Player_Level; j++)
				{
					if (j % 2 == 0)
					{
						FLD_Khi_2 += 2;
						FLD_Attack += 2;
					}
					else
					{
						FLD_Khi_2 += 3;
						FLD_Attack += 3;
					}
				}
				break;
			case 5:
				FLD_Tam_1 = 18;
				FLD_Khi_2 = 5 + Player_Level * 2;
				FLD_The_3 = 7 + Player_Level;
				FLD_Hon_4 = 6 + Player_Level;
				人物基本最大_HP = 117 + Player_Level * 7;
				人物基本最大_MP = 129 + Player_Level * 7;
				FLD_Accuracy = (int)(2.0 + (double)Player_Level * 0.3);
				FLD_Evasion = (int)(3.0 + (double)Player_Level * 0.5);
				FLD_Attack = 5 + Player_Level * 2;
				FLD_Defense = 7 + Player_Level;
				for (int j = 2; j <= Player_Level; j++)
				{
					if (j % 2 == 0)
					{
						FLD_Tam_1 += 3;
					}
					else
					{
						FLD_Tam_1 += 2;
					}
				}
				break;
			case 6:
				FLD_Tam_1 = 5 + Player_Level * 2;
				FLD_Khi_2 = 8 + Player_Level * 2;
				FLD_The_3 = 8 + Player_Level;
				FLD_Hon_4 = 14;
				人物基本最大_HP = 124 + Player_Level * 9;
				人物基本最大_MP = 110 + Player_Level * 4;
				FLD_Accuracy = 3 + Player_Level;
				FLD_Evasion = 4 + Player_Level * 2;
				FLD_Attack = 8 + Player_Level * 2;
				FLD_Defense = 8 + Player_Level;
				for (int m = 2; m <= Player_Level; m++)
				{
					if (m % 2 == 0)
					{
						FLD_Hon_4 += 3;
					}
					else
					{
						FLD_Hon_4 += 4;
					}
				}
				break;
			case 7:
				FLD_Tam_1 = 14 + Player_Level * 4;
				FLD_Khi_2 = 7 + Player_Level * 2;
				FLD_The_3 = 5 + Player_Level;
				FLD_Hon_4 = 6 + Player_Level;
				人物基本最大_HP = 112 + Player_Level * 6;
				人物基本最大_MP = 128 + Player_Level * 8;
				FLD_Accuracy = (int)(2.04 + (double)Player_Level * 0.24);
				FLD_Evasion = (int)(3.0 + (double)Player_Level * 0.5);
				FLD_Attack = 7 + Player_Level * 2;
				FLD_Defense = 5 + Player_Level;
				break;
			case 8:
			case 12:
				FLD_Tam_1 = 7 + Player_Level;
				FLD_Khi_2 = 8;
				FLD_The_3 = 15;
				FLD_Hon_4 = 8 + Player_Level;
				人物基本最大_HP = 133 + Player_Level * 12;
				人物基本最大_MP = 114 + Player_Level * 2;
				FLD_Accuracy = (int)(2.75 + (double)Player_Level * 0.24);
				FLD_Evasion = (int)(4.0 + (double)Player_Level * 0.5);
				FLD_Attack = 8 + Player_Level * 2;
				FLD_Defense = 15;
				for (int l = 2; l <= Player_Level; l++)
				{
					if (l % 2 == 0)
					{
						FLD_Khi_2 += 2;
						FLD_The_3 += 2;
						FLD_Defense += 2;
					}
					else
					{
						FLD_Khi_2++;
						FLD_The_3++;
						FLD_Defense++;
					}
				}
				break;
			case 9:
				FLD_Tam_1 = 9;
				FLD_Khi_2 = 9 + Player_Level * 2;
				FLD_The_3 = 10 + Player_Level;
				FLD_Hon_4 = 7 + Player_Level * 2;
				人物基本最大_HP = 124 + Player_Level * 9;
				人物基本最大_MP = 115 + Player_Level * 3;
				FLD_Accuracy = (int)(1.51 + (double)Player_Level * 0.75);
				FLD_Evasion = (int)(3.0 + (double)Player_Level * 1.1);
				FLD_Attack = 9 + Player_Level * 2;
				FLD_Defense = 10 + Player_Level;
				for (int k = 2; k <= Player_Level; k++)
				{
					if (k % 2 == 0)
					{
						FLD_Tam_1++;
					}
					else
					{
						FLD_Tam_1 += 2;
					}
				}
				break;
			case 10:
				FLD_Tam_1 = 6 + Player_Level;
				FLD_Khi_2 = 6 + Player_Level * 3;
				FLD_The_3 = 15 + Player_Level;
				FLD_Hon_4 = 7 + Player_Level;
				人物基本最大_HP = 126 + Player_Level * 7;
				人物基本最大_MP = 116 + Player_Level * 2;
				FLD_Accuracy = (int)(2.0 + (double)Player_Level * 0.3);
				FLD_Evasion = (int)(3.0 + (double)Player_Level * 0.5);
				FLD_Attack = 10 + Player_Level * 3;
				FLD_Defense = 10 + Player_Level;
				break;
			case 11:
				FLD_Tam_1 = 8 + Player_Level * 2;
				FLD_Khi_2 = 12;
				FLD_The_3 = 7 + Player_Level;
				FLD_Hon_4 = 7 + Player_Level * 3;
				Player_Basic_Shield = 15 * Player_Level;
				人物基本最大_HP = 127 + Player_Level * 6;
				人物基本最大_MP = 114 + Player_Level * 4;
				FLD_Accuracy = (int)(2.4 + (double)Player_Level * 0.9);
				FLD_Evasion = (int)(4.0 + (double)Player_Level * 1.5);
				FLD_Attack = 12;
				FLD_Defense = 11 + Player_Level;
				for (int j = 2; j <= Player_Level; j++)
				{
					if (j % 2 == 0)
					{
						FLD_Khi_2 += 2;
						FLD_Attack += 2;
					}
					else
					{
						FLD_Khi_2 += 3;
						FLD_Attack += 3;
					}
				}
				break;
			}
			转职属性(Player_Job_Level);
			Update_Character_Wear_Item();
			计算人物制作等级();
			烟花();
		}

		public void 计算人物基本数据3()
		{
			int player_Level = Player_Level;
			int num = Player_Level;
			long player_FLD_EXP = Player_FLD_EXP;
			long num2 = 人物最大经验;
			人物最大经验 = (long)World.Level[Player_Level];
			int num3 = 0;
			while (true)
			{
				bool flag = true;
				if (player_FLD_EXP < num2 || Player_Level >= World.人物最高等级)
				{
					break;
				}
				if (num3 > 270 || !Client.Running)
				{
					return;
				}
				num++;
				num2 = (long)World.Level[num];
				num3++;
			}
			if (num - player_Level > 0)
			{
				计算人物基本数据();
			}
		}

		public void Send_New_Email()
		{
			foreach (EmailClass value in 传书列表.Values)
			{
				if (value.method_8() == 0)
				{
					string hex = "AA551000010000B200010002000000000000F1A755AA";
					byte[] array = Converter.hexStringToByte(hex);
					Client.Send(array, array.Length);
				}
			}
		}

		public void Update_Email()
		{
			try
			{
				if (传书列表 != null)
				{
					string hex = "AA55D201010000B20023020000";
					string hex2 = "00000000000000000055AA";
					byte[] array = Converter.hexStringToByte(hex);
					byte[] array2 = Converter.hexStringToByte(hex2);
					byte[] array3 = new byte[array.Length + array2.Length + 传书列表.Count * ((World.Newversion >= 15) ? 36 : 32)];
					Buffer.BlockCopy(array, 0, array3, 0, array.Length);
					Buffer.BlockCopy(array2, 0, array3, array3.Length - array2.Length, array2.Length);
					Buffer.BlockCopy(BitConverter.GetBytes(传书列表.Count * ((World.Newversion >= 15) ? 36 : 32) + 18), 0, array3, 2, 2);
					Buffer.BlockCopy(BitConverter.GetBytes(传书列表.Count * ((World.Newversion >= 15) ? 36 : 32) + 3), 0, array3, 9, 2);
					Buffer.BlockCopy(BitConverter.GetBytes(传书列表.Count), 0, array3, 12, 2);
					int num = 0;
					foreach (EmailClass value in 传书列表.Values)
					{
						byte[] array4 = new byte[(World.Newversion >= 15) ? 36 : 32];
						Buffer.BlockCopy(BitConverter.GetBytes(value.method_0()), 0, array4, 0, 4);
						Buffer.BlockCopy(BitConverter.GetBytes(value.method_10()), 0, array4, 4, 1);
						byte[] bytes = Encoding.GetEncoding(1252).GetBytes(value.method_2());
						Buffer.BlockCopy(bytes, 0, array4, 5, bytes.Length);
						Buffer.BlockCopy(BitConverter.GetBytes(value.method_6().Day), 0, array4, 25, 1);
						Buffer.BlockCopy(BitConverter.GetBytes(value.method_6().Month), 0, array4, 26, 1);
						Buffer.BlockCopy(BitConverter.GetBytes(value.method_6().Year - 2000), 0, array4, 27, 1);
						Buffer.BlockCopy(BitConverter.GetBytes(value.method_6().Hour), 0, array4, 28, 1);
						Buffer.BlockCopy(BitConverter.GetBytes(value.method_6().Minute), 0, array4, 29, 1);
						Buffer.BlockCopy(BitConverter.GetBytes(value.method_8()), 0, array4, 30, 2);
						Buffer.BlockCopy(array4, 0, array3, num * ((World.Newversion >= 15) ? 36 : 32) + 14, array4.Length);
						num++;
					}
					Client.Send(array3, array3.Length);
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "查看传书出错()出错" + UserSessionID + "| " + ex.Message);
			}
		}

		public void 计算人物基本数据3_()
		{
			int player_Level = Player_Level;
			int num = Player_Level;
			long player_FLD_EXP = Player_FLD_EXP;
			long num2 = 人物最大经验;
			人物最大经验 = (long)World.Level[Player_Level];
			int num3 = 0;
			while (player_FLD_EXP >= num2 && Player_Level < World.人物最高等级)
			{
				if (num3 > 270 || !Client.Running)
				{
					return;
				}
				num++;
				num2 = (long)World.Level[num];
				num3++;
			}
			if (num - player_Level > 0)
			{
				计算人物基本数据();
			}
		}

		public void 计算人物数据()
		{
		}

		public void 计算人物制作等级()
		{
			int fLD_制作等级 = FLD_制作等级;
			if (Craft_Level >= 800)
			{
				FLD_制作等级 = 8;
			}
			else if (Craft_Level >= 750)
			{
				FLD_制作等级 = 7;
			}
			else if (Craft_Level >= 700)
			{
				FLD_制作等级 = 6;
			}
			else if (Craft_Level >= 650)
			{
				FLD_制作等级 = 5;
			}
			else if (Craft_Level >= 600)
			{
				FLD_制作等级 = 4;
			}
			else if (Craft_Level >= 300)
			{
				FLD_制作等级 = 3;
			}
			else if (Craft_Level >= 100)
			{
				FLD_制作等级 = 2;
			}
			else
			{
				FLD_制作等级 = 1;
			}
			if (FLD_制作等级 > fLD_制作等级)
			{
				更新制作系统();
			}
		}

		public void Update_Item_Wuxun_Effect(int numSetDragonX, int levelSetDragonX)
		{
			if (levelSetDragonX == 100)
			{
				switch (numSetDragonX)
				{
				case 2:
					FLD_Evasion += 5;
					break;
				case 3:
					FLD_Evasion += 5;
					FLD_Evasion += 10;
					break;
				case 4:
					FLD_Evasion += 5;
					FLD_Evasion += 10;
					FLD_Evasion += 3;
					break;
				case 5:
					FLD_Evasion += 5;
					FLD_Evasion += 10;
					FLD_Evasion += 3;
					FLD_Evasion += 2;
					break;
				}
			}
			else
			{
				if (numSetDragonX < 2)
				{
					return;
				}
				switch (Player_Job)
				{
				case 1:
				case 8:
					switch (numSetDragonX)
					{
					case 2:
						FLD_SucManhCaNhan += 5L;
						break;
					case 3:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						break;
					case 4:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						FLD_Item_Defense += 20 + 10 * levelSetDragonX;
						FLD_Item_Attack_Skill += 0.1;
						break;
					case 5:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						FLD_Item_Defense += 20 + 10 * levelSetDragonX;
						FLD_Item_Attack_Skill += 0.1;
						FLD_Item_HP_Recover += 50 + 50 * levelSetDragonX;
						break;
					case 6:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						FLD_SucManhCaNhan += 13L;
						FLD_Item_Defense += 20 + 10 * levelSetDragonX;
						FLD_Item_Attack_Skill += 0.1;
						FLD_Item_HP_Recover += 50 + 50 * levelSetDragonX;
						FLD_Item_Attack += 50L;
						break;
					}
					break;
				case 2:
				case 3:
				case 9:
				case 10:
				case 12:
					switch (numSetDragonX)
					{
					case 2:
						FLD_SucManhCaNhan += 5L;
						break;
					case 3:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						break;
					case 4:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						FLD_Item_Defense += 20 + 10 * levelSetDragonX;
						FLD_Item_Attack_Skill += 0.1;
						break;
					case 5:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						FLD_Item_Defense += 20 + 10 * levelSetDragonX;
						FLD_Item_HP_Recover += 50 + 50 * levelSetDragonX;
						FLD_Item_Attack_Skill += 0.1;
						break;
					case 6:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						FLD_SucManhCaNhan += 13L;
						FLD_Item_Defense += 20 + 10 * levelSetDragonX;
						FLD_Item_HP_Recover += 50 + 50 * levelSetDragonX;
						FLD_Item_Attack_Skill += 0.1;
						FLD_Item_Defense += 50L;
						break;
					}
					break;
				case 4:
				case 6:
				case 11:
					switch (numSetDragonX)
					{
					case 2:
						FLD_SucManhCaNhan += 5L;
						break;
					case 3:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						break;
					case 4:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						FLD_Item_Defense += 20 + 10 * levelSetDragonX;
						FLD_Item_Attack += 20L;
						break;
					case 5:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						FLD_Item_Defense += 20 + 10 * levelSetDragonX;
						FLD_Item_HP_Recover += 50 + 50 * levelSetDragonX;
						FLD_Item_Attack += 20L;
						break;
					case 6:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						FLD_SucManhCaNhan += 13L;
						FLD_Item_Defense += 20 + 10 * levelSetDragonX;
						FLD_Item_HP_Recover += 50 + 50 * levelSetDragonX;
						FLD_Item_Attack += 20L;
						FLD_Item_Attack_Skill += 0.2;
						break;
					}
					break;
				case 5:
					switch (numSetDragonX)
					{
					case 2:
						FLD_SucManhCaNhan += 5L;
						break;
					case 3:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						break;
					case 4:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						FLD_Item_Defense += 20 + 10 * levelSetDragonX;
						FLD_Item_HP_Recover += 50 * levelSetDragonX;
						FLD_Item_Attack_Skill += 0.1;
						break;
					case 5:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						FLD_Item_Defense += 20 + 10 * levelSetDragonX;
						FLD_Item_HP_Recover += 50 * levelSetDragonX;
						FLD_Item_Attack_Skill += 0.1;
						FLD_Item_MP_Recover += 1000;
						break;
					case 6:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						FLD_SucManhCaNhan += 13L;
						FLD_Item_Defense += 20 + 10 * levelSetDragonX;
						FLD_Item_HP_Recover += 50 * levelSetDragonX;
						FLD_Item_Attack_Skill += 0.1;
						FLD_Item_MP_Recover += 1000;
						FLD_Item_Attack += 50L;
						break;
					}
					break;
				case 7:
					switch (numSetDragonX)
					{
					case 2:
						FLD_SucManhCaNhan += 5L;
						break;
					case 3:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						break;
					case 4:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						FLD_Item_Defense += 20 + 10 * levelSetDragonX;
						FLD_Item_HP_Recover += 50 * levelSetDragonX;
						FLD_Item_Attack_Skill += 0.1;
						break;
					case 5:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						FLD_Item_Defense += 20 + 10 * levelSetDragonX;
						FLD_Item_HP_Recover += 50 * levelSetDragonX;
						FLD_Item_Attack_Skill += 0.1;
						FLD_Item_MP_Recover += 1000;
						break;
					case 6:
						FLD_SucManhCaNhan += 5L;
						FLD_SucManhCaNhan += 7L;
						FLD_SucManhCaNhan += 13L;
						FLD_Item_Defense += 20 + 10 * levelSetDragonX;
						FLD_Item_HP_Recover += 50 * levelSetDragonX;
						FLD_Item_Attack_Skill += 0.1;
						FLD_Item_MP_Recover += 1000;
						FLD_Item_Defense += 50L;
						break;
					}
					break;
				}
			}
		}

		public void Update_Character_Wear_Item()
		{
			using (new Lock(eval_c, "Update_Character_Wear_Item"))
			{
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				int num6 = 0;
				int num7 = 0;
				int num8 = 0;
				int num9 = 0;
				int num10 = 0;
				FLD_装备_追加_qigong_9_job1 = 0.0;
				FLD_装备_追加_qigong_0_job1 = 0.0;
				FLD_装备_追加_qigong_7_job1 = 0.0;
				FLD_装备_追加_qigong_3_job1 = 0.0;
				FLD_装备_追加_qigong_4_job1 = 0.0;
				FLD_装备_追加_qigong_2_job1 = 0.0;
				FLD_装备_追加_qigong_1_job1 = 0.0;
				FLD_装备_追加_qigong_5_job1 = 0.0;
				FLD_装备_追加_qigong_10_job1 = 0.0;
				FLD_装备_追加_qigong_8_job1 = 0.0;
				FLD_装备_追加_qigong_9_job2 = 0.0;
				FLD_装备_追加_qigong_0_job2 = 0.0;
				FLD_装备_追加_qigong_1_job2 = 0.0;
				FLD_装备_追加_qigong_2_job2 = 0.0;
				FLD_装备_追加_qigong_3_job2 = 0.0;
				FLD_装备_追加_qigong_4_job2 = 0.0;
				FLD_装备_追加_qigong_5_job2 = 0.0;
				FLD_装备_追加_qigong_7_job2 = 0.0;
				FLD_装备_追加_qigong_8_job2 = 0.0;
				FLD_装备_追加_qigong_10_job2 = 0.0;
				FLD_装备_追加_qigong_9_job3 = 0.0;
				FLD_装备_追加_qigong_0_job3 = 0.0;
				FLD_装备_追加_qigong_1_job3 = 0.0;
				FLD_装备_追加_qigong_2_job3 = 0.0;
				FLD_装备_追加_qigong_3_job3 = 0.0;
				FLD_装备_追加_qigong_4_job3 = 0.0;
				FLD_装备_追加_qigong_5_job3 = 0.0;
				FLD_装备_追加_qigong_7_job3 = 0.0;
				FLD_装备_追加_qigong_8_job3 = 0.0;
				FLD_装备_追加_qigong_10_job3 = 0.0;
				FLD_装备_追加_qigong_0_job4 = 0.0;
				FLD_装备_追加_qigong_9_job4 = 0.0;
				FLD_装备_追加_qigong_1_job4 = 0.0;
				FLD_装备_追加_qigong_2_job4 = 0.0;
				FLD_装备_追加_qigong_3_job4 = 0.0;
				FLD_装备_追加_qigong_4_job4 = 0.0;
				FLD_装备_追加_qigong_5_job4 = 0.0;
				FLD_装备_追加_qigong_7_job4 = 0.0;
				FLD_装备_追加_qigong_8_job4 = 0.0;
				FLD_装备_追加_qigong_10_job4 = 0.0;
				FLD_装备_追加_qigong_2_job5 = 0.0;
				FLD_装备_追加_qigong_9_job5 = 0.0;
				FLD_装备_追加_qigong_0_job5 = 0.0;
				FLD_装备_追加_qigong_1_job5 = 0.0;
				FLD_装备_追加_qigong_3_job5 = 0.0;
				FLD_装备_追加_qigong_4_job5 = 0.0;
				FLD_装备_追加_qigong_5_job5 = 0.0;
				FLD_装备_追加_qigong_7_job5 = 0.0;
				FLD_装备_追加_qigong_8_job5 = 0.0;
				FLD_装备_追加_qigong_10_job5 = 0.0;
				FLD_装备_追加_qigong_0_job6 = 0.0;
				FLD_装备_追加_qigong_9_job6 = 0.0;
				FLD_装备_追加_qigong_1_job6 = 0.0;
				FLD_装备_追加_qigong_2_job6 = 0.0;
				FLD_装备_追加_qigong_3_job6 = 0.0;
				FLD_装备_追加_qigong_4_job6 = 0.0;
				FLD_装备_追加_qigong_5_job6 = 0.0;
				FLD_装备_追加_qigong_7_job6 = 0.0;
				FLD_装备_追加_qigong_8_job6 = 0.0;
				FLD_装备_追加_qigong_10_job6 = 0.0;
				FLD_装备_追加_qigong_9_job7 = 0.0;
				FLD_装备_追加_qigong_7_job7 = 0.0;
				FLD_装备_追加_qigong_0_job7 = 0.0;
				FLD_装备_追加_qigong_1_job7 = 0.0;
				FLD_装备_追加_qigong_2_job7 = 0.0;
				FLD_装备_追加_qigong_3_job7 = 0.0;
				FLD_装备_追加_qigong_4_job7 = 0.0;
				FLD_装备_追加_qigong_5_job7 = 0.0;
				FLD_装备_追加_qigong_8_job7 = 0.0;
				FLD_装备_追加_qigong_10_job7 = 0.0;
				Item_Upgrade_Lucky_Add = 0.0;
				FLD_装备_追加_qigong_11_job1 = 0.0;
				FLD_装备_追加_qigong_11_job2 = 0.0;
				FLD_装备_追加_qigong_11_job3 = 0.0;
				FLD_装备_追加_qigong_11_job4 = 0.0;
				FLD_装备_追加_qigong_11_job5 = 0.0;
				FLD_装备_追加_qigong_11_job6 = 0.0;
				FLD_装备_追加_qigong_11_job7 = 0.0;
				FLD_装备_追加_qigong_0_job8 = 0.0;
				FLD_装备_追加_qigong_1_job8 = 0.0;
				FLD_装备_追加_qigong_2_job8 = 0.0;
				FLD_装备_追加_qigong_3_job8 = 0.0;
				FLD_装备_追加_qigong_4_job8 = 0.0;
				FLD_装备_追加_qigong_5_job8 = 0.0;
				FLD_装备_追加_qigong_7_job8 = 0.0;
				FLD_装备_追加_qigong_8_job8 = 0.0;
				FLD_装备_追加_qigong_9_job8 = 0.0;
				FLD_装备_追加_qigong_10_job8 = 0.0;
				FLD_装备_追加_qigong_11_job8 = 0.0;
				FLD_装备_追加_qigong_0_job9 = 0.0;
				FLD_装备_追加_qigong_1_job9 = 0.0;
				FLD_装备_追加_qigong_2_job9 = 0.0;
				FLD_装备_追加_qigong_3_job9 = 0.0;
				FLD_装备_追加_qigong_4_job9 = 0.0;
				FLD_装备_追加_qigong_5_job9 = 0.0;
				FLD_装备_追加_qigong_7_job9 = 0.0;
				FLD_装备_追加_qigong_8_job9 = 0.0;
				FLD_装备_追加_qigong_9_job9 = 0.0;
				FLD_装备_追加_qigong_10_job9 = 0.0;
				FLD_装备_追加_qigong_11_job9 = 0.0;
				FLD_装备_追加_qigong_0_job10 = 0.0;
				FLD_装备_追加_qigong_1_job10 = 0.0;
				FLD_装备_追加_qigong_2_job10 = 0.0;
				FLD_装备_追加_qigong_3_job10 = 0.0;
				FLD_装备_追加_qigong_4_job10 = 0.0;
				FLD_装备_追加_qigong_5_job10 = 0.0;
				FLD_装备_追加_qigong_7_job10 = 0.0;
				FLD_装备_追加_qigong_8_job10 = 0.0;
				FLD_装备_追加_qigong_9_job10 = 0.0;
				FLD_装备_追加_qigong_10_job10 = 0.0;
				FLD_装备_追加_qigong_11_job10 = 0.0;
				FLD_装备_追加_qigong_0_job11 = 0.0;
				FLD_装备_追加_qigong_1_job11 = 0.0;
				FLD_装备_追加_qigong_2_job11 = 0.0;
				FLD_装备_追加_qigong_3_job11 = 0.0;
				FLD_装备_追加_qigong_4_job11 = 0.0;
				FLD_装备_追加_qigong_5_job11 = 0.0;
				FLD_装备_追加_qigong_7_job11 = 0.0;
				FLD_装备_追加_qigong_8_job11 = 0.0;
				FLD_装备_追加_qigong_9_job11 = 0.0;
				FLD_装备_追加_qigong_10_job11 = 0.0;
				FLD_装备_追加_qigong_11_job11 = 0.0;
				FLD_装备_追加_qigong_0_job12 = 0.0;
				FLD_装备_追加_qigong_1_job12 = 0.0;
				FLD_装备_追加_qigong_2_job12 = 0.0;
				FLD_装备_追加_qigong_3_job12 = 0.0;
				FLD_装备_追加_qigong_4_job12 = 0.0;
				FLD_装备_追加_qigong_5_job12 = 0.0;
				FLD_装备_追加_qigong_7_job12 = 0.0;
				FLD_装备_追加_qigong_8_job12 = 0.0;
				FLD_装备_追加_qigong_9_job12 = 0.0;
				FLD_装备_追加_qigong_10_job12 = 0.0;
				FLD_装备_追加_qigong_11_job12 = 0.0;
				FLD_Wear_Item_Money = 0.0;
				FLD_Item_Attack_Point = 0.0;
				FLD_Item_Attack_Skill = 0.0;
				FLD_Item_Attack_Skill_Point = 0.0;
				FLD_Item_Defense_Skill_Point = 0.0;
				FLD_Item_Defense_Skill = 0.0;
				FLD_Item_Attack = 0L;
				FLD_Item_Defense = 0L;
				FLD_SucManhCaNhan = 0L;
				FLD_SucManhCaNhan_PhanTram = 0.0;
				FLD_Item_Shield = 0;
				FLD_Item_Shield_Recover = 0;
				FLD_Item_HP_Recover = 0;
				FLD_Item_MP_Recover = 0;
				FLD_Item_Accuracy = 0;
				FLD_Item_Evasion = 0;
				FLD_Item_Level_Pran = 0;
				FLD_Item_Exp = 0.0;
				TrungCapEffect_PhucThu = 0;
				TrungCapEffect_HapHon = 0;
				TrungCapEffect_KyDuyen = 0;
				TrungCapEffect_PhanNo = 0;
				TrungCapEffect_DiTinh = 0;
				TrungCapEffect_HoThe = 0;
				TrungCapEffect_HonNguyen = 0;
				FLD_装备_追加_tam = 0;
				FLD_装备_追加_the = 0;
				FLD_装备_追加_khi = 0;
				FLD_装备_追加_hon = 0;
				FLD_装备_追加_觉醒 = 0;
				FLD_Item_HP = 0;
				FLD_Item_MP = 0;
				ItmeClass value;
				for (int i = 0; i < 16; i++)
				{
					if (Item_Wear[i] != null && Item_Wear[i].FLD_PID != 0 && World.Itme.TryGetValue(BitConverter.ToInt32(Item_Wear[i].Get_Byte_Item_PID, 0), out value))
					{
						if (value.FLD_LEVEL > Player_Level || (Item_Wear[i].FLD_持久力 <= 0 && value.FLD_CJL != 0) || value.FLD_XWJD > 人物武勋阶段)
						{
							GameMessage("Trang biò: " + value.ItmeNAME + " ðang biò hoÒng ");
						}
						else
						{
							if (value.FLD_RESIDE2 == 14)
							{
								if (Item_Wear[i].FLD_PID == 900102 && Level_Of_Guild < 4)
								{
									GameMessage("Bang hôòi chýa ðaòt câìp 4");
									continue;
								}
								if (Item_Wear[i].FLD_PID == 900103 && Level_Of_Guild < 5)
								{
									GameMessage("Bang hôòi chýa ðaòt câìp 5");
									continue;
								}
								if (Item_Wear[i].FLD_PID == 900104 && Level_Of_Guild < 6)
								{
									GameMessage("Bang hôòi chýa ðaòt câìp 6");
									continue;
								}
								if (Item_Wear[i].FLD_PID >= 900109 && Item_Wear[i].FLD_PID <= 900112 && Level_Of_Guild < 7)
								{
									GameMessage("Bang hôòi chýa ðaòt câìp 7");
									continue;
								}
								if (Item_Wear[i].FLD_PID >= 900105 && Item_Wear[i].FLD_PID <= 900108 && (Level_Of_Guild < 7 || Guild_Level < 5))
								{
									GameMessage("Bang hôòi chýa ðaòt câìp 7 hoãòc baòn không phaÒi bang chuÒ");
									continue;
								}
							}
							Item_Wear[i].得到物品属性方法(FLD_Item_Plus_VK, FLD_Item_Plus_TB, this);
							FLD_Item_Level_Pran += Item_Wear[i].Level_Qigong_All;
							if (Item_Wear[i].FLD_RESIDE2 == 12 || Item_Wear[i].FLD_RESIDE2 == 14)
							{
								switch (Player_Job)
								{
								case 1:
									FLD_装备_追加_qigong_0_job1 += Item_Wear[i].物品属性_qigong_0_job1;
									FLD_装备_追加_qigong_1_job1 += Item_Wear[i].物品属性_qigong_1_job1;
									FLD_装备_追加_qigong_2_job1 += Item_Wear[i].物品属性_qigong_2_job1;
									FLD_装备_追加_qigong_3_job1 += Item_Wear[i].物品属性_qigong_3_job1;
									FLD_装备_追加_qigong_4_job1 += Item_Wear[i].物品属性_qigong_4_job1;
									FLD_装备_追加_qigong_5_job1 += Item_Wear[i].物品属性_qigong_5_job1;
									FLD_装备_追加_qigong_7_job1 += Item_Wear[i].物品属性_qigong_7_job1;
									FLD_装备_追加_qigong_8_job1 += Item_Wear[i].物品属性_qigong_8_job1;
									FLD_装备_追加_qigong_9_job1 += Item_Wear[i].物品属性_qigong_9_job1;
									FLD_装备_追加_qigong_10_job1 += Item_Wear[i].物品属性_qigong_10_job1;
									FLD_装备_追加_qigong_11_job1 += Item_Wear[i].物品属性_qigong_11_job1;
									break;
								case 2:
									FLD_装备_追加_qigong_0_job2 += Item_Wear[i].物品属性_qigong_0_job2;
									FLD_装备_追加_qigong_1_job2 += Item_Wear[i].物品属性_qigong_1_job2;
									FLD_装备_追加_qigong_2_job2 += Item_Wear[i].物品属性_qigong_2_job2;
									FLD_装备_追加_qigong_3_job2 += Item_Wear[i].物品属性_qigong_3_job2;
									FLD_装备_追加_qigong_4_job2 += Item_Wear[i].物品属性_qigong_4_job2;
									FLD_装备_追加_qigong_5_job2 += Item_Wear[i].物品属性_qigong_5_job2;
									FLD_装备_追加_qigong_7_job2 += Item_Wear[i].物品属性_qigong_7_job2;
									FLD_装备_追加_qigong_8_job2 += Item_Wear[i].物品属性_qigong_8_job2;
									FLD_装备_追加_qigong_10_job2 += Item_Wear[i].物品属性_qigong_9_job2;
									FLD_装备_追加_qigong_9_job2 += Item_Wear[i].物品属性_qigong_10_job2;
									FLD_装备_追加_qigong_11_job2 += Item_Wear[i].物品属性_qigong_11_job2;
									break;
								case 3:
									FLD_装备_追加_qigong_0_job3 += Item_Wear[i].物品属性_qigong_0_job3;
									FLD_装备_追加_qigong_1_job3 += Item_Wear[i].物品属性_qigong_1_job3;
									FLD_装备_追加_qigong_2_job3 += Item_Wear[i].物品属性_qigong_2_job3;
									FLD_装备_追加_qigong_3_job3 += Item_Wear[i].物品属性_qigong_3_job3;
									FLD_装备_追加_qigong_4_job3 += Item_Wear[i].物品属性_qigong_4_job3;
									FLD_装备_追加_qigong_5_job3 += Item_Wear[i].物品属性_qigong_5_job3;
									FLD_装备_追加_qigong_7_job3 += Item_Wear[i].物品属性_qigong_7_job3;
									FLD_装备_追加_qigong_8_job3 += Item_Wear[i].物品属性_qigong_8_job3;
									FLD_装备_追加_qigong_9_job3 += Item_Wear[i].物品属性_qigong_9_job3;
									FLD_装备_追加_qigong_10_job3 += Item_Wear[i].物品属性_qigong_10_job3;
									FLD_装备_追加_qigong_11_job3 += Item_Wear[i].物品属性_qigong_11_job3;
									break;
								case 4:
									FLD_装备_追加_qigong_0_job4 += Item_Wear[i].物品属性_qigong_0_job4;
									FLD_装备_追加_qigong_1_job4 += Item_Wear[i].物品属性_qigong_1_job4;
									FLD_装备_追加_qigong_2_job4 += Item_Wear[i].物品属性_qigong_2_job4;
									FLD_装备_追加_qigong_3_job4 += Item_Wear[i].物品属性_qigong_3_job4;
									FLD_装备_追加_qigong_4_job4 += Item_Wear[i].物品属性_qigong_4_job4;
									FLD_装备_追加_qigong_5_job4 += Item_Wear[i].物品属性_qigong_5_job4;
									FLD_装备_追加_qigong_7_job4 += Item_Wear[i].物品属性_qigong_7_job4;
									FLD_装备_追加_qigong_8_job4 += Item_Wear[i].物品属性_qigong_8_job4;
									FLD_装备_追加_qigong_9_job4 += Item_Wear[i].物品属性_qigong_9_job4;
									FLD_装备_追加_qigong_10_job4 += Item_Wear[i].物品属性_qigong_10_job4;
									FLD_装备_追加_qigong_11_job4 += Item_Wear[i].物品属性_qigong_11_job4;
									break;
								case 5:
									FLD_装备_追加_qigong_0_job5 += Item_Wear[i].物品属性_qigong_0_job5;
									FLD_装备_追加_qigong_1_job5 += Item_Wear[i].物品属性_qigong_1_job5;
									FLD_装备_追加_qigong_3_job5 += Item_Wear[i].物品属性_qigong_2_job5;
									FLD_装备_追加_qigong_2_job5 += Item_Wear[i].物品属性_qigong_3_job5;
									FLD_装备_追加_qigong_4_job5 += Item_Wear[i].物品属性_qigong_4_job5;
									FLD_装备_追加_qigong_5_job5 += Item_Wear[i].物品属性_qigong_5_job5;
									FLD_装备_追加_qigong_7_job5 += Item_Wear[i].物品属性_qigong_7_job5;
									FLD_装备_追加_qigong_8_job5 += Item_Wear[i].物品属性_qigong_8_job5;
									FLD_装备_追加_qigong_9_job5 += Item_Wear[i].物品属性_qigong_9_job5;
									FLD_装备_追加_qigong_10_job5 += Item_Wear[i].物品属性_qigong_10_job5;
									FLD_装备_追加_qigong_11_job5 += Item_Wear[i].物品属性_qigong_11_job5;
									break;
								case 6:
									FLD_装备_追加_qigong_0_job6 += Item_Wear[i].物品属性_qigong_0_job6;
									FLD_装备_追加_qigong_1_job6 += Item_Wear[i].物品属性_qigong_1_job6;
									FLD_装备_追加_qigong_2_job6 += Item_Wear[i].物品属性_qigong_2_job6;
									FLD_装备_追加_qigong_3_job6 += Item_Wear[i].物品属性_qigong_3_job6;
									FLD_装备_追加_qigong_4_job6 += Item_Wear[i].物品属性_qigong_4_job6;
									FLD_装备_追加_qigong_5_job6 += Item_Wear[i].物品属性_qigong_5_job6;
									FLD_装备_追加_qigong_7_job6 += Item_Wear[i].物品属性_qigong_7_job6;
									FLD_装备_追加_qigong_8_job6 += Item_Wear[i].物品属性_qigong_8_job6;
									FLD_装备_追加_qigong_9_job6 += Item_Wear[i].物品属性_qigong_9_job6;
									FLD_装备_追加_qigong_10_job6 += Item_Wear[i].物品属性_qigong_10_job6;
									FLD_装备_追加_qigong_11_job6 += Item_Wear[i].物品属性_qigong_11_job6;
									break;
								case 7:
									FLD_装备_追加_qigong_0_job7 += Item_Wear[i].物品属性_qigong_0_job7;
									FLD_装备_追加_qigong_1_job7 += Item_Wear[i].物品属性_qigong_1_job7;
									FLD_装备_追加_qigong_2_job7 += Item_Wear[i].物品属性_qigong_2_job7;
									FLD_装备_追加_qigong_3_job7 += Item_Wear[i].物品属性_qigong_3_job7;
									FLD_装备_追加_qigong_4_job7 += Item_Wear[i].物品属性_qigong_4_job7;
									FLD_装备_追加_qigong_5_job7 += Item_Wear[i].物品属性_qigong_5_job7;
									FLD_装备_追加_qigong_7_job7 += Item_Wear[i].物品属性_qigong_7_job7;
									FLD_装备_追加_qigong_8_job7 += Item_Wear[i].物品属性_qigong_8_job7;
									FLD_装备_追加_qigong_9_job7 += Item_Wear[i].物品属性_qigong_9_job7;
									FLD_装备_追加_qigong_10_job7 += Item_Wear[i].物品属性_qigong_10_job7;
									FLD_装备_追加_qigong_11_job7 += Item_Wear[i].物品属性_qigong_11_job7;
									break;
								case 8:
									FLD_装备_追加_qigong_0_job8 += Item_Wear[i].物品属性_qigong_0_job8;
									FLD_装备_追加_qigong_1_job8 += Item_Wear[i].物品属性_qigong_1_job8;
									FLD_装备_追加_qigong_2_job8 += Item_Wear[i].物品属性_qigong_2_job8;
									FLD_装备_追加_qigong_3_job8 += Item_Wear[i].物品属性_qigong_3_job8;
									FLD_装备_追加_qigong_4_job8 += Item_Wear[i].物品属性_qigong_4_job8;
									FLD_装备_追加_qigong_5_job8 += Item_Wear[i].物品属性_qigong_5_job8;
									FLD_装备_追加_qigong_7_job8 += Item_Wear[i].物品属性_qigong_7_job8;
									FLD_装备_追加_qigong_8_job8 += Item_Wear[i].物品属性_qigong_8_job8;
									FLD_装备_追加_qigong_9_job8 += Item_Wear[i].物品属性_qigong_9_job8;
									FLD_装备_追加_qigong_10_job8 += Item_Wear[i].物品属性_qigong_10_job8;
									FLD_装备_追加_qigong_11_job8 += Item_Wear[i].物品属性_qigong_11_job8;
									break;
								case 9:
									FLD_装备_追加_qigong_0_job9 += Item_Wear[i].物品属性_qigong_0_job9;
									FLD_装备_追加_qigong_1_job9 += Item_Wear[i].物品属性_qigong_1_job9;
									FLD_装备_追加_qigong_2_job9 += Item_Wear[i].物品属性_qigong_2_job9;
									FLD_装备_追加_qigong_3_job9 += Item_Wear[i].物品属性_qigong_3_job9;
									FLD_装备_追加_qigong_4_job9 += Item_Wear[i].物品属性_qigong_4_job9;
									FLD_装备_追加_qigong_5_job9 += Item_Wear[i].物品属性_qigong_5_job9;
									FLD_装备_追加_qigong_7_job9 += Item_Wear[i].物品属性_qigong_7_job9;
									FLD_装备_追加_qigong_8_job9 += Item_Wear[i].物品属性_qigong_8_job9;
									FLD_装备_追加_qigong_9_job9 += Item_Wear[i].物品属性_qigong_9_job9;
									FLD_装备_追加_qigong_10_job9 += Item_Wear[i].物品属性_qigong_10_job9;
									FLD_装备_追加_qigong_11_job9 += Item_Wear[i].物品属性_qigong_11_job9;
									break;
								case 10:
									FLD_装备_追加_qigong_0_job10 += Item_Wear[i].物品属性_qigong_0_job10;
									FLD_装备_追加_qigong_1_job10 += Item_Wear[i].物品属性_qigong_1_job10;
									FLD_装备_追加_qigong_2_job10 += Item_Wear[i].物品属性_qigong_2_job10;
									FLD_装备_追加_qigong_3_job10 += Item_Wear[i].物品属性_qigong_3_job10;
									FLD_装备_追加_qigong_4_job10 += Item_Wear[i].物品属性_qigong_4_job10;
									FLD_装备_追加_qigong_5_job10 += Item_Wear[i].物品属性_qigong_5_job10;
									FLD_装备_追加_qigong_7_job10 += Item_Wear[i].物品属性_qigong_7_job10;
									FLD_装备_追加_qigong_8_job10 += Item_Wear[i].物品属性_qigong_8_job10;
									FLD_装备_追加_qigong_9_job10 += Item_Wear[i].物品属性_qigong_9_job10;
									FLD_装备_追加_qigong_10_job10 += Item_Wear[i].物品属性_qigong_10_job10;
									FLD_装备_追加_qigong_11_job10 += Item_Wear[i].物品属性_qigong_11_job10;
									break;
								case 11:
									FLD_装备_追加_qigong_0_job11 += Item_Wear[i].物品属性_qigong_0_job11;
									FLD_装备_追加_qigong_1_job11 += Item_Wear[i].物品属性_qigong_1_job11;
									FLD_装备_追加_qigong_2_job11 += Item_Wear[i].物品属性_qigong_2_job11;
									FLD_装备_追加_qigong_3_job11 += Item_Wear[i].物品属性_qigong_3_job11;
									FLD_装备_追加_qigong_4_job11 += Item_Wear[i].物品属性_qigong_4_job11;
									FLD_装备_追加_qigong_5_job11 += Item_Wear[i].物品属性_qigong_5_job11;
									FLD_装备_追加_qigong_7_job11 += Item_Wear[i].物品属性_qigong_7_job11;
									FLD_装备_追加_qigong_8_job11 += Item_Wear[i].物品属性_qigong_8_job11;
									FLD_装备_追加_qigong_9_job11 += Item_Wear[i].物品属性_qigong_9_job11;
									FLD_装备_追加_qigong_10_job11 += Item_Wear[i].物品属性_qigong_10_job11;
									FLD_装备_追加_qigong_11_job11 += Item_Wear[i].物品属性_qigong_11_job11;
									break;
								case 12:
									FLD_装备_追加_qigong_0_job12 += Item_Wear[i].物品属性_qigong_0_job12;
									FLD_装备_追加_qigong_1_job12 += Item_Wear[i].物品属性_qigong_1_job12;
									FLD_装备_追加_qigong_2_job12 += Item_Wear[i].物品属性_qigong_2_job12;
									FLD_装备_追加_qigong_3_job12 += Item_Wear[i].物品属性_qigong_3_job12;
									FLD_装备_追加_qigong_4_job12 += Item_Wear[i].物品属性_qigong_4_job12;
									FLD_装备_追加_qigong_5_job12 += Item_Wear[i].物品属性_qigong_5_job12;
									FLD_装备_追加_qigong_7_job12 += Item_Wear[i].物品属性_qigong_7_job12;
									FLD_装备_追加_qigong_8_job12 += Item_Wear[i].物品属性_qigong_8_job12;
									FLD_装备_追加_qigong_9_job12 += Item_Wear[i].物品属性_qigong_9_job12;
									FLD_装备_追加_qigong_10_job12 += Item_Wear[i].物品属性_qigong_10_job12;
									FLD_装备_追加_qigong_11_job12 += Item_Wear[i].物品属性_qigong_11_job12;
									break;
								}
							}
						}
					}
				}
				更新气功();
				for (int i = 0; i < 16; i++)
				{
					if (Item_Wear[i] != null && Item_Wear[i].FLD_PID != 0 && World.Itme.TryGetValue(BitConverter.ToInt32(Item_Wear[i].Get_Byte_Item_PID, 0), out value) && value.FLD_LEVEL <= Player_Level && (Item_Wear[i].FLD_持久力 > 0 || value.FLD_CJL == 0))
					{
						if (World.Newversion >= 16 && Player_Job == 11 && value.FLD_SHIELD == 0 && (value.FLD_RESIDE2 == 2 || value.FLD_RESIDE2 == 5 || value.FLD_RESIDE2 == 6 || value.FLD_RESIDE2 == 7 || value.FLD_RESIDE2 == 8 || value.FLD_RESIDE2 == 10))
						{
							GameMessage("Vâòt phâÒm: " + value.ItmeNAME + " không daÌnh cho Diêòu Yêìn");
						}
						else
						{
							double num11 = Item_Wear[i].Item_Attack_Skill;
							double num12 = Item_Wear[i].Item_Defense_Skill;
							if (Player_Job == 11 && i == 3 && base.KhiCong_JOB11_7 != 0.0)
							{
								num11 += base.KhiCong_JOB11_7;
							}
							FLD_Item_Attack_Skill += num11 / (double)World.武功攻击力控制;
							FLD_Item_Defense_Skill += num12 / (double)World.武功防御力控制;
							FLD_Item_HP += Item_Wear[i].物品属性_生命力增加;
							FLD_Item_MP += Item_Wear[i].物品属性_内功力增加;
							Item_Upgrade_Lucky_Add += (double)Item_Wear[i].物品属性_升级成功率 / 100.0;
							FLD_Wear_Item_Money += (double)Item_Wear[i].物品属性_获得金钱增加 / 100.0;
							FLD_Item_Exp += (double)Item_Wear[i].物品属性_经验获得增加 / 100.0;
							if (i == 3 && Item_Wear[i].FLD_PID != 0)
							{
								FLD_Item_Attack += (Item_Wear[i].Item_Attack_Min + (long)base.KhiCongTTChung_DameMin + Item_Wear[i].Item_Attack_Max + (long)base.KhiCongTTChung_DameMax) / 2;
							}
							else
							{
								FLD_Item_Attack += (Item_Wear[i].Item_Attack_Min + Item_Wear[i].Item_Attack_Max) / 2;
							}
							FLD_Item_Defense += Item_Wear[i].Item_Defense;
							FLD_SucManhCaNhan += Item_Wear[i].Item_SucManhCaNhan;
							FLD_SucManhCaNhan_PhanTram += Item_Wear[i].Item_SucManhCaNhan_PhanTram;
							FLD_Item_Shield += Item_Wear[i].Item_Shield;
							FLD_Item_Shield_Recover += Item_Wear[i].Item_Shield_Recover;
							FLD_Item_HP_Recover += Item_Wear[i].Item_HP_Recover;
							FLD_Item_MP_Recover += Item_Wear[i].Item_MP_Recover;
							FLD_Item_Accuracy += Item_Wear[i].Item_Accuracy;
							FLD_Item_Evasion += Item_Wear[i].Item_Evasion;
							FLD_Item_AoChoang_ChinhXac += Item_Wear[i].Item_Accuracy_Per;
							FLD_Item_AoChoang_NeTranh += Item_Wear[i].Item_Evasion_Per;
							FLD_Item_Attack_Point += Item_Wear[i].Item_Attack_Point;
							FLD_Item_Attack_Skill_Point += Item_Wear[i].Item_Attack_Skill_Point;
							FLD_Item_Defense_Skill_Point += Item_Wear[i].Item_Defense_Skill_Point;
							if (Item_Wear[i].FLD_FJ_中级附魂 <= 22 && Item_Wear[i].FLD_FJ_中级附魂 >= 21)
							{
								if (Item_Wear[i].FLD_FJ_觉醒 > 0)
								{
									FLD_装备_追加_觉醒 = Item_Wear[i].FLD_FJ_中级附魂 - 20;
								}
							}
							else if (Item_Wear[i].FLD_FJ_中级附魂 <= 20 && Item_Wear[i].FLD_FJ_中级附魂 >= 16)
							{
								FLD_装备_追加_hon += (int)((double)(Item_Wear[i].FLD_FJ_中级附魂 - 15) / 100.0 * (double)FLD_Hon_4);
							}
							else if (Item_Wear[i].FLD_FJ_中级附魂 <= 15 && Item_Wear[i].FLD_FJ_中级附魂 >= 11)
							{
								FLD_装备_追加_khi += (int)((double)(Item_Wear[i].FLD_FJ_中级附魂 - 10) / 100.0 * (double)FLD_Khi_2);
							}
							else if (Item_Wear[i].FLD_FJ_中级附魂 <= 10 && Item_Wear[i].FLD_FJ_中级附魂 >= 6)
							{
								FLD_装备_追加_the += (int)((double)(Item_Wear[i].FLD_FJ_中级附魂 - 5) / 100.0 * (double)FLD_The_3);
							}
							else if (Item_Wear[i].FLD_FJ_中级附魂 <= 5 && Item_Wear[i].FLD_FJ_中级附魂 >= 1)
							{
								FLD_装备_追加_tam += (int)((double)Item_Wear[i].FLD_FJ_中级附魂 / 100.0 * (double)FLD_Tam_1);
							}
							if (Set_Susan(Item_Wear[i].FLD_PID, Item_Wear[i].FLD_RESIDE2))
							{
								num++;
							}
							if (Set_Dragon_1(Item_Wear[i].FLD_PID, Item_Wear[i].FLD_RESIDE2))
							{
								num2++;
							}
							if (Set_Dragon_2(Item_Wear[i].FLD_PID, Item_Wear[i].FLD_RESIDE2))
							{
								num3++;
							}
							if (Set_Dragon_3(Item_Wear[i].FLD_PID, Item_Wear[i].FLD_RESIDE2))
							{
								num4++;
							}
							if (Set_Dragon_4(Item_Wear[i].FLD_PID, Item_Wear[i].FLD_RESIDE2))
							{
								num5++;
							}
							if (Set_Dragon_5(Item_Wear[i].FLD_PID, Item_Wear[i].FLD_RESIDE2))
							{
								num6++;
							}
							if (Set_Dragon_6(Item_Wear[i].FLD_PID, Item_Wear[i].FLD_RESIDE2))
							{
								num7++;
							}
							if (Set_Dragon_7(Item_Wear[i].FLD_PID, Item_Wear[i].FLD_RESIDE2))
							{
								num8++;
							}
							if (Set_Dragon_8(Item_Wear[i].FLD_PID, Item_Wear[i].FLD_RESIDE2))
							{
								num9++;
							}
							if (Set_Dragon2_1(Item_Wear[i].FLD_PID, Item_Wear[i].FLD_RESIDE2))
							{
								num10++;
							}
							if (Item_Wear[i].FLD_RESIDE2 == 1 || Item_Wear[i].FLD_RESIDE2 == 2 || Item_Wear[i].FLD_RESIDE2 == 4 || Item_Wear[i].FLD_RESIDE2 == 5 || Item_Wear[i].FLD_RESIDE2 == 6)
							{
								if (Item_Wear[i].FLD_PID != 0 && Item_Wear[i].FLD_RESIDE2 == 1 && !Show_Pic_Class.ContainsKey(700344))
								{
									switch (Item_Wear[i].物品属性阶段类型)
									{
									case 3:
										FLD_Item_Evasion += (int)((double)FLD_Evasion * ((double)Item_Wear[i].物品属性阶段数 * 0.01));
										break;
									case 4:
										FLD_Item_Defense_Skill += (double)Item_Wear[i].物品属性阶段数 * 0.005;
										break;
									case 5:
										FLD_Item_Defense += Item_Wear[i].物品属性阶段数 * 3;
										break;
									}
								}
								if (Item_Wear[i].FLD_PID != 0 && Item_Wear[i].FLD_RESIDE2 == 4 && !Show_Pic_Class.ContainsKey(700344))
								{
									switch (Item_Wear[i].物品属性阶段类型)
									{
									case 3:
										FLD_Item_Accuracy += (int)((double)FLD_Accuracy * ((double)Item_Wear[i].物品属性阶段数 * 0.01));
										break;
									case 4:
										FLD_Item_Attack_Skill += (double)Item_Wear[i].物品属性阶段数 * 0.005;
										break;
									case 6:
										FLD_Item_Attack += Item_Wear[i].物品属性阶段数 * 3;
										break;
									}
								}
								if (FLD_装备_追加_觉醒 >= 0)
								{
									FLD_Item_Defense += (Item_Wear[i].FLD_FJ_觉醒 + FLD_装备_追加_觉醒) * World.衣服附魂增加属性数量;
								}
							}
							if (Item_Wear[i].FLD_RESIDE2 == 4)
							{
								if (Item_Wear[i].FLD_PID != 0 && Item_Wear[i].物品属性阶段类型 == 6 && !Show_Pic_Class.ContainsKey(700344))
								{
									Item_Wear[i].Item_Attack_Min += Item_Wear[i].物品属性阶段数 * 3;
									Item_Wear[i].Item_Attack_Max += Item_Wear[i].物品属性阶段数 * 3;
								}
								if (Item_Wear[i].FLD_PID == 101200001 || Item_Wear[i].FLD_PID == 201200001 || Item_Wear[i].FLD_PID == 301200001 || Item_Wear[i].FLD_PID == 401200001 || Item_Wear[i].FLD_PID == 501200001 || Item_Wear[i].FLD_PID == 701200001 || Item_Wear[i].FLD_PID == 801200001)
								{
									FLD_Item_Level_Pran += 3;
									FLD_Item_Exp += 0.5;
								}
								FLD_Item_Accuracy += 50;
								if (FLD_装备_追加_觉醒 >= 0)
								{
									FLD_Item_Attack += (Item_Wear[i].FLD_FJ_觉醒 + FLD_装备_追加_觉醒) * World.武器附魂增加属性数量;
								}
							}
							if (Item_Wear[i].FLD_RESIDE2 == 7)
							{
								FLD_Item_Defense += Item_Wear[i].FLD_强化数量 * World.项链加工一阶段增加防御;
							}
							if (Item_Wear[i].FLD_RESIDE2 == 8)
							{
								FLD_Item_HP += Item_Wear[i].FLD_强化数量 * World.耳环加工一阶段增加生命;
							}
							if (Item_Wear[i].FLD_RESIDE2 == 10)
							{
								FLD_Item_Attack += Item_Wear[i].FLD_强化数量 * World.戒指加工一阶段增加攻击;
							}
							if (Item_Wear[i].FLD_FJ_中级附魂 <= 51 && Item_Wear[i].FLD_FJ_中级附魂 >= 47)
							{
								TrungCapEffect_HonNguyen = Item_Wear[i].FLD_FJ_中级附魂 - 46;
							}
							else if (Item_Wear[i].FLD_FJ_中级附魂 <= 46 && Item_Wear[i].FLD_FJ_中级附魂 >= 42)
							{
								TrungCapEffect_HoThe = Item_Wear[i].FLD_FJ_中级附魂 - 41;
							}
							else if (Item_Wear[i].FLD_FJ_中级附魂 <= 41 && Item_Wear[i].FLD_FJ_中级附魂 >= 37)
							{
								TrungCapEffect_DiTinh = Item_Wear[i].FLD_FJ_中级附魂 - 36;
							}
							else if (Item_Wear[i].FLD_FJ_中级附魂 <= 36 && Item_Wear[i].FLD_FJ_中级附魂 >= 34)
							{
								TrungCapEffect_PhanNo = Item_Wear[i].FLD_FJ_中级附魂 - 33;
							}
							else if (Item_Wear[i].FLD_FJ_中级附魂 <= 33 && Item_Wear[i].FLD_FJ_中级附魂 >= 31)
							{
								TrungCapEffect_KyDuyen = Item_Wear[i].FLD_FJ_中级附魂 - 30;
							}
							else if (Item_Wear[i].FLD_FJ_中级附魂 <= 30 && Item_Wear[i].FLD_FJ_中级附魂 >= 28)
							{
								TrungCapEffect_HapHon = Item_Wear[i].FLD_FJ_中级附魂 - 27;
							}
							else if (Item_Wear[i].FLD_FJ_中级附魂 <= 27 && Item_Wear[i].FLD_FJ_中级附魂 >= 23)
							{
								TrungCapEffect_PhucThu = Item_Wear[i].FLD_FJ_中级附魂 - 22;
							}
						}
					}
				}
				if (num >= 2)
				{
					switch (Player_Job)
					{
					case 1:
					case 8:
						switch (num)
						{
						case 2:
							FLD_Item_Defense += 20L;
							break;
						case 3:
							FLD_Item_Defense += 20L;
							FLD_装备_追加_qigong_0_job1 += 2.0;
							break;
						case 4:
							FLD_Item_Defense += 20L;
							FLD_装备_追加_qigong_0_job1 += 2.0;
							FLD_Item_Level_Pran++;
							break;
						case 5:
							FLD_Item_Defense += 20L;
							FLD_装备_追加_qigong_0_job1 += 2.0;
							FLD_Item_Level_Pran++;
							FLD_装备_追加_qigong_9_job1 += 2.0;
							break;
						}
						break;
					case 2:
						switch (num)
						{
						case 2:
							FLD_Item_Defense += 10L;
							FLD_Item_Evasion += 20;
							break;
						case 3:
							FLD_Item_Defense += 10L;
							FLD_Item_Evasion += 20;
							FLD_装备_追加_qigong_0_job2 += 2.0;
							break;
						case 4:
							FLD_Item_Defense += 10L;
							FLD_Item_Evasion += 20;
							FLD_装备_追加_qigong_0_job2 += 2.0;
							FLD_Item_Level_Pran++;
							break;
						case 5:
							FLD_Item_Defense += 10L;
							FLD_Item_Evasion += 20;
							FLD_装备_追加_qigong_0_job2 += 2.0;
							FLD_Item_Level_Pran++;
							FLD_装备_追加_qigong_9_job2 += 2.0;
							break;
						}
						break;
					case 3:
						switch (num)
						{
						case 2:
							FLD_Item_Attack += 10L;
							FLD_Item_Defense += 20L;
							break;
						case 3:
							FLD_Item_Attack += 10L;
							FLD_Item_Defense += 20L;
							FLD_装备_追加_qigong_0_job3 += 2.0;
							break;
						case 4:
							FLD_Item_Attack += 10L;
							FLD_Item_Defense += 20L;
							FLD_装备_追加_qigong_0_job3 += 2.0;
							FLD_Item_Level_Pran++;
							break;
						case 5:
							FLD_Item_Attack += 10L;
							FLD_Item_Defense += 20L;
							FLD_装备_追加_qigong_0_job3 += 2.0;
							FLD_Item_Level_Pran++;
							FLD_装备_追加_qigong_9_job3 += 2.0;
							break;
						}
						break;
					case 4:
						switch (num)
						{
						case 2:
							FLD_Item_Defense += 10L;
							FLD_Item_Accuracy += 20;
							break;
						case 3:
							FLD_Item_Defense += 10L;
							FLD_Item_Accuracy += 20;
							FLD_装备_追加_qigong_0_job4 += 2.0;
							break;
						case 4:
							FLD_Item_Defense += 10L;
							FLD_Item_Accuracy += 20;
							FLD_装备_追加_qigong_0_job4 += 2.0;
							FLD_Item_Level_Pran++;
							break;
						case 5:
							FLD_Item_Defense += 10L;
							FLD_Item_Accuracy += 20;
							FLD_装备_追加_qigong_0_job4 += 2.0;
							FLD_Item_Level_Pran++;
							FLD_装备_追加_qigong_9_job4 += 2.0;
							break;
						}
						break;
					case 5:
						switch (num)
						{
						case 2:
							FLD_Item_HP += 100;
							FLD_Item_Defense += 10L;
							break;
						case 3:
							FLD_Item_HP += 100;
							FLD_Item_Defense += 10L;
							FLD_装备_追加_qigong_2_job5 += 2.0;
							break;
						case 4:
							FLD_Item_HP += 100;
							FLD_Item_Defense += 10L;
							FLD_装备_追加_qigong_2_job5 += 2.0;
							FLD_Item_Level_Pran++;
							break;
						case 5:
							FLD_Item_HP += 100;
							FLD_Item_Defense += 10L;
							FLD_装备_追加_qigong_2_job5 += 2.0;
							FLD_Item_Level_Pran++;
							FLD_装备_追加_qigong_9_job5 += 2.0;
							break;
						}
						break;
					case 6:
						switch (num)
						{
						case 2:
							FLD_Item_Attack += 10L;
							FLD_Item_Evasion += 20;
							break;
						case 3:
							FLD_Item_Attack += 10L;
							FLD_Item_Evasion += 20;
							FLD_装备_追加_qigong_0_job6 += 2.0;
							break;
						case 4:
							FLD_Item_Attack += 10L;
							FLD_Item_Evasion += 20;
							FLD_装备_追加_qigong_0_job6 += 2.0;
							FLD_Item_Level_Pran++;
							break;
						case 5:
							FLD_Item_Attack += 10L;
							FLD_Item_Evasion += 20;
							FLD_装备_追加_qigong_0_job6 += 2.0;
							FLD_Item_Level_Pran++;
							FLD_装备_追加_qigong_9_job6 += 2.0;
							break;
						}
						break;
					case 7:
						switch (num)
						{
						case 2:
							FLD_Item_Attack += 10L;
							FLD_Item_MP += 200;
							break;
						case 3:
							FLD_Item_Attack += 10L;
							FLD_Item_MP += 200;
							FLD_装备_追加_qigong_7_job7 += 2.0;
							break;
						case 4:
							FLD_Item_Attack += 10L;
							FLD_Item_MP += 200;
							FLD_装备_追加_qigong_7_job7 += 2.0;
							FLD_Item_Level_Pran++;
							break;
						case 5:
							FLD_Item_Attack += 10L;
							FLD_Item_MP += 200;
							FLD_装备_追加_qigong_7_job7 += 2.0;
							FLD_Item_Level_Pran++;
							FLD_装备_追加_qigong_9_job7 += 2.0;
							break;
						}
						break;
					}
				}
				if (num2 >= 2)
				{
					Update_Item_Wuxun_Effect(num2, 0);
				}
				if (num3 >= 2)
				{
					Update_Item_Wuxun_Effect(num3, 1);
				}
				if (num4 >= 2)
				{
					Update_Item_Wuxun_Effect(num4, 2);
				}
				if (num5 >= 2)
				{
					Update_Item_Wuxun_Effect(num5, 2);
				}
				if (num6 >= 2)
				{
					Update_Item_Wuxun_Effect(num6, 3);
				}
				if (num7 >= 2)
				{
					Update_Item_Wuxun_Effect(num7, 3);
				}
				if (num8 >= 2)
				{
					Update_Item_Wuxun_Effect(num8, 4);
				}
				if (num9 >= 2)
				{
					Update_Item_Wuxun_Effect(num9, 4);
				}
				if (num10 >= 2)
				{
					Update_Item_Wuxun_Effect(num9, 100);
				}
				if (Item_Wear[11].FLD_PID != 0 && list_时间药品.ContainsKey(1008001050))
				{
					if (FLD_SVIP < 1999999)
					{
						FLD_Item_Defense += 30L;
						FLD_Item_Attack += 30L;
						FLD_Item_Attack_Skill += FLD_Item_Attack_Skill * 0.10000000149011612;
						FLD_Item_Defense_Skill += FLD_Item_Defense_Skill * 0.10000000149011612;
						FLD_Item_HP += 300;
						FLD_Item_MP += 300;
						FLD_Item_Level_Pran += 2;
						FLD_Item_Exp += 0.1;
						FLD_Wear_Item_Money += 0.1;
						Item_Upgrade_Lucky_Add += 0.01;
					}
					else if (FLD_SVIP >= 2000000 && FLD_SVIP < 4999999)
					{
						FLD_Item_Defense += 40L;
						FLD_Item_Attack += 40L;
						FLD_Item_Attack_Skill += FLD_Item_Attack_Skill * 0.11999999731779099;
						FLD_Item_Defense_Skill += FLD_Item_Defense_Skill * 0.11999999731779099;
						FLD_Item_HP += 500;
						FLD_Item_MP += 300;
						FLD_Item_Level_Pran += 3;
						FLD_Item_Exp += 0.12;
						FLD_Wear_Item_Money += 0.15;
						Item_Upgrade_Lucky_Add += 0.02;
					}
					else if (FLD_SVIP >= 5000000 && FLD_SVIP < 9999999)
					{
						FLD_Item_Defense += 50L;
						FLD_Item_Attack += 50L;
						FLD_Item_Attack_Skill += FLD_Item_Attack_Skill * 0.14000000059604645;
						FLD_Item_Defense_Skill += FLD_Item_Defense_Skill * 0.14000000059604645;
						FLD_Item_HP += 600;
						FLD_Item_MP += 300;
						FLD_Item_Level_Pran += 3;
						FLD_Item_Exp += 0.14;
						FLD_Wear_Item_Money += 0.2;
						Item_Upgrade_Lucky_Add += 0.03;
					}
					else if (FLD_SVIP >= 10000000 && FLD_SVIP < 19999999)
					{
						FLD_Item_Defense += 60L;
						FLD_Item_Attack += 60L;
						FLD_Item_Attack_Skill += FLD_Item_Attack_Skill * 0.15999999642372131;
						FLD_Item_Defense_Skill += FLD_Item_Defense_Skill * 0.15999999642372131;
						FLD_Item_HP += 700;
						FLD_Item_MP += 300;
						FLD_Item_Level_Pran += 3;
						FLD_Item_Exp += 0.17;
						FLD_Wear_Item_Money += 0.25;
						Item_Upgrade_Lucky_Add += 0.04;
					}
					else if (FLD_SVIP >= 20000000 && FLD_SVIP < 49999999)
					{
						FLD_Item_Defense += 70L;
						FLD_Item_Attack += 70L;
						FLD_Item_Attack_Skill += FLD_Item_Attack_Skill * 0.20000000298023224;
						FLD_Item_Defense_Skill += FLD_Item_Defense_Skill * 0.20000000298023224;
						FLD_Item_HP += 800;
						FLD_Item_MP += 500;
						FLD_Item_Level_Pran += 3;
						FLD_Item_Exp += 0.2;
						FLD_Wear_Item_Money += 0.3;
						Item_Upgrade_Lucky_Add += 0.05;
					}
					else if (FLD_SVIP >= 50000000 && FLD_SVIP < 99999999)
					{
						FLD_Item_Defense += 100L;
						FLD_Item_Attack += 100L;
						FLD_Item_Attack_Skill += FLD_Item_Attack_Skill * 0.25;
						FLD_Item_Defense_Skill += FLD_Item_Defense_Skill * 0.25;
						FLD_Item_HP += 1300;
						FLD_Item_MP += 1000;
						FLD_Item_Level_Pran += 4;
						FLD_Item_Exp += 0.25;
						FLD_Wear_Item_Money += 0.4;
						Item_Upgrade_Lucky_Add += 0.07;
					}
					else if (FLD_SVIP >= 100000000)
					{
						FLD_Item_Defense += 150L;
						FLD_Item_Attack += 150L;
						FLD_Item_Attack_Skill += FLD_Item_Attack_Skill * 0.30000001192092896;
						FLD_Item_Defense_Skill += FLD_Item_Defense_Skill * 0.30000001192092896;
						FLD_Item_HP += 1800;
						FLD_Item_MP += 1000;
						FLD_Item_Level_Pran += 4;
						FLD_Item_Exp += 0.3;
						FLD_Wear_Item_Money += 0.5;
						Item_Upgrade_Lucky_Add += 0.1;
					}
				}
				if (Item_Wear[13].FLD_PID == 900102 && list_时间药品.ContainsKey(1008001049))
				{
					FLD_Item_Attack_Skill += FLD_Item_Attack_Skill * 0.1;
					FLD_Item_Attack += 50L;
				}
				else if (Item_Wear[13].FLD_PID == 900103 && list_时间药品.ContainsKey(1008001049))
				{
					FLD_Item_Attack_Skill += FLD_Item_Attack_Skill * 0.12;
					FLD_Item_Attack += 70L;
				}
				else if (Item_Wear[13].FLD_PID == 900104 && list_时间药品.ContainsKey(1008001049))
				{
					FLD_Item_Attack_Skill += FLD_Item_Attack_Skill * 0.15;
					FLD_Item_Attack += 100L;
				}
				else if ((Item_Wear[13].FLD_PID == 900109 && list_时间药品.ContainsKey(1008001049)) || (Item_Wear[13].FLD_PID == 900110 && list_时间药品.ContainsKey(1008001049)) || (Item_Wear[13].FLD_PID == 900111 && list_时间药品.ContainsKey(1008001049)) || (Item_Wear[13].FLD_PID == 900112 && list_时间药品.ContainsKey(1008001049)))
				{
					FLD_Item_Attack_Skill += FLD_Item_Attack_Skill * 0.17;
					FLD_Item_Attack += 150L;
				}
				else if ((Item_Wear[13].FLD_PID == 900105 && list_时间药品.ContainsKey(1008001049)) || (Item_Wear[13].FLD_PID == 900106 && list_时间药品.ContainsKey(1008001049)) || (Item_Wear[13].FLD_PID == 900107 && list_时间药品.ContainsKey(1008001049)) || (Item_Wear[13].FLD_PID == 900108 && list_时间药品.ContainsKey(1008001049)))
				{
					FLD_Item_Attack_Skill += FLD_Item_Attack_Skill * 0.2;
					FLD_Item_Attack += 180L;
				}
			}
		}

		public void 记算夫妻武功攻击力数据()
		{
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			for (int i = 0; i < 35; i++)
			{
				if (Array_Skill_Book[3, i] != null && Array_Skill_Book[3, i].FLD_SKILL_TIME < 4000)
				{
					int num = Array_Skill_Book[3, i].FLD_AT + Array_Skill_Book[3, i].每级加危害(Array_Skill_Book[3, i].武功_等级 - 1) / 1;
					if (num > 0)
					{
						list.Add(num);
						list2.Add(Array_Skill_Book[3, i].FLD_MP + Array_Skill_Book[3, i].每级加MP(Array_Skill_Book[3, i].武功_等级 - 1));
					}
				}
			}
			for (int j = 0; j < 35; j++)
			{
				if (Array_Skill_Book[0, j] != null && Array_Skill_Book[0, j].FLD_SKILL_TIME < 4000 && Array_Skill_Book[0, j].FLD_PID != 2000402)
				{
					int num = Array_Skill_Book[0, j].FLD_AT + Array_Skill_Book[0, j].每级加危害(Array_Skill_Book[0, j].武功_等级 - 1) / 1;
					if (num > 0)
					{
						list.Add(num);
						list2.Add(Array_Skill_Book[0, j].FLD_MP + Array_Skill_Book[0, j].每级加MP(Array_Skill_Book[0, j].武功_等级 - 1));
					}
				}
			}
			int[] array = list.ToArray();
			int[] array2 = list2.ToArray();
			Array.Sort(array, array2);
			if (array.Length > 0)
			{
				KyNangManhNhat_UyLuc = array[array.Length - 1];
				KyNangManhNhat_MP = array2[array2.Length - 1];
			}
		}

		public void Recovery_MP(int sl, bool DPBUFF = false, bool ItemShopNPC = false)
		{
			if (异常状态 != null && 异常状态.ContainsKey(3))
			{
				sl -= (int)((double)sl * 0.2);
			}
			if (Player_Job == 5)
			{
				double num = sl;
				sl = (int)(num * (1.0 + base.医_运气疗心 + base.升天一气功_运气行心));
			}
			if (Player_Job != 5 && Player_Job_Level >= 6)
			{
				double num2 = sl;
				sl = (int)(num2 * (1.0 + base.升天一气功_运气行心));
			}
			if (Player_FLD_MP + sl < Player_MP_Max)
			{
				Player_FLD_MP += sl;
			}
			else
			{
				Player_FLD_MP = Player_MP_Max;
			}
		}

		public void Recovery_HP(int sl, bool DPBUFF = false, bool ItemShopNPC = false)
		{
			if (Show_Pic_Class.ContainsKey(700667))
			{
				return;
			}
			if (!DPBUFF)
			{
				if (异常状态 != null && 异常状态.ContainsKey(3))
				{
					sl -= (int)((double)sl * 0.2);
				}
				sl = (int)((double)sl * (1.0 + base.枪_运气疗伤 + base.升天一气功_运气疗伤));
			}
			if (ItemShopNPC)
			{
				Players players = World.FindPlayerbyName(FLD_Couple_Name);
				if (players != null)
				{
					int num = (int)((double)sl * (0.0175 * (double)(10 - players.FLD_Couple_Level)));
					if (players.Player_FLD_HP + num < players.Player_HP_Max)
					{
						players.Player_FLD_HP += num;
					}
					else
					{
						players.Player_FLD_HP = players.Player_HP_Max;
					}
					players.Update_HP_MP_SP();
					players.GameMessage("Nhâòn ðýõòc " + num + " lýõòng HP hôÌi phuòc týÌ cãòp ðôi");
				}
			}
			if (Player_FLD_HP + sl < Player_HP_Max)
			{
				Player_FLD_HP += sl;
			}
			else
			{
				Player_FLD_HP = Player_HP_Max;
			}
		}

		public void Ravage_HP(long sl, bool PK = true)
		{
			if (Player_Job == 11)
			{
				long val = (long)((double)sl * (5.0 + (double)(PK ? 1 : 2) * base.KhiCong_JOB11_0) / 100.0);
				val = Math.Min(val, Player_Shield);
				sl -= val;
				Player_Shield -= (int)val;
				if (GM模式 != 8)
				{
					Player_FLD_HP -= sl;
				}
			}
			else if (GM模式 != 8)
			{
				Player_FLD_HP -= sl;
			}
		}

		public void Tip_Pickup_Item(int id, long 物品全局ID)
		{
			string hex = "AA551B000000000D000C00030000006843030000000000000000000000000055AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(id), 0, array, 11, 1);
			Buffer.BlockCopy(BitConverter.GetBytes(物品全局ID), 0, array, 15, 8);
			Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public bool 检查物品系统(Itimesx 属性)
		{
			if (属性.属性类型 != 0)
			{
				if (属性.属性类型 == 1)
				{
					if (World.物品最高攻击值 != 0 && 属性.属性数量 >= World.物品最高攻击值)
					{
						return true;
					}
				}
				else if (属性.属性类型 == 2)
				{
					if (World.物品最高防御值 != 0 && 属性.属性数量 >= World.物品最高防御值)
					{
						return true;
					}
				}
				else if (属性.属性类型 == 3)
				{
					if (World.物品最高生命值 != 0 && 属性.属性数量 >= World.物品最高生命值)
					{
						return true;
					}
				}
				else if (属性.属性类型 == 4)
				{
					if (World.物品最高内功值 != 0 && 属性.属性数量 >= World.物品最高内功值)
					{
						return true;
					}
				}
				else if (属性.属性类型 == 5)
				{
					if (World.物品最高命中值 != 0 && 属性.属性数量 >= World.物品最高命中值)
					{
						return true;
					}
				}
				else if (属性.属性类型 == 6)
				{
					if (World.物品最高回避值 != 0 && 属性.属性数量 >= World.物品最高回避值)
					{
						return true;
					}
				}
				else if (属性.属性类型 == 7)
				{
					if (World.物品最高武功值 != 0 && 属性.属性数量 >= World.物品最高武功值)
					{
						return true;
					}
				}
				else if (属性.属性类型 == 8)
				{
					if (World.物品最高气功值 != 0 && 属性.属性数量 >= World.物品最高气功值)
					{
						return true;
					}
				}
				else if (属性.属性类型 == 9 && World.物品最高合成值 != 0 && 属性.属性数量 >= World.物品最高合成值)
				{
					return true;
				}
			}
			return false;
		}

		public void 检查物品系统(string 位置, ref 物品类 物品)
		{
			if (World.查非法物品 == 1)
			{
				if (World.查绑定非法物品 || !物品.物品绑定)
				{
					if (物品.属性1.属性类型 != 0 && 检查物品系统(物品.属性1))
					{
						Form1.WriteLine(77, "非法物品 " + 位置 + " [" + Userid + "]-[" + UserName + "] 位置[" + 物品.Bag + "] 编号[" + BitConverter.ToInt32(物品.物品全局ID, 0) + "] 物品名称[" + 物品.Get_Name() + "] 物品数量[" + BitConverter.ToInt32(物品.Item_Amount, 0) + "] 属性:[" + 物品.FLD_MAGIC0 + "," + 物品.FLD_MAGIC1 + "," + 物品.FLD_MAGIC2 + "," + 物品.FLD_MAGIC3 + "," + 物品.FLD_MAGIC4 + "]");
						if (World.查非法物品操作 == 1)
						{
							物品.Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
						}
						else if (World.查非法物品操作 == 2)
						{
							DBA.ExeSqlCommand($"UPDATE TBL_ACCOUNT SET FLD_ZT=1 WHERE FLD_ID='{Userid}'", "rxjhaccount");
							if (Client != null)
							{
								GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 14", 7);
								Client.Dispose();
							}
						}
					}
					else if (物品.属性2.属性类型 != 0 && 检查物品系统(物品.属性2))
					{
						Form1.WriteLine(77, "非法物品 " + 位置 + " [" + Userid + "]-[" + UserName + "] 位置[" + 物品.Bag + "] 编号[" + BitConverter.ToInt32(物品.物品全局ID, 0) + "] 物品名称[" + 物品.Get_Name() + "] 物品数量[" + BitConverter.ToInt32(物品.Item_Amount, 0) + "] 属性:[" + 物品.FLD_MAGIC0 + "," + 物品.FLD_MAGIC1 + "," + 物品.FLD_MAGIC2 + "," + 物品.FLD_MAGIC3 + "," + 物品.FLD_MAGIC4 + "]");
						if (World.查非法物品操作 == 1)
						{
							物品.Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
						}
						else if (World.查非法物品操作 == 2)
						{
							DBA.ExeSqlCommand($"UPDATE TBL_ACCOUNT SET FLD_ZT=1 WHERE FLD_ID='{Userid}'", "rxjhaccount");
							if (Client != null)
							{
								GameMessage("Bao cho admin ma so nay: Disconnect: 13", 7);
								Client.Dispose();
							}
						}
					}
					else if (物品.属性3.属性类型 != 0 && 检查物品系统(物品.属性3))
					{
						Form1.WriteLine(77, "非法物品 " + 位置 + " [" + Userid + "]-[" + UserName + "] 位置[" + 物品.Bag + "] 编号[" + BitConverter.ToInt32(物品.物品全局ID, 0) + "] 物品名称[" + 物品.Get_Name() + "] 物品数量[" + BitConverter.ToInt32(物品.Item_Amount, 0) + "] 属性:[" + 物品.FLD_MAGIC0 + "," + 物品.FLD_MAGIC1 + "," + 物品.FLD_MAGIC2 + "," + 物品.FLD_MAGIC3 + "," + 物品.FLD_MAGIC4 + "]");
						if (World.查非法物品操作 == 1)
						{
							物品.Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
						}
						else if (World.查非法物品操作 == 2)
						{
							DBA.ExeSqlCommand($"UPDATE TBL_ACCOUNT SET FLD_ZT=1 WHERE FLD_ID='{Userid}'", "rxjhaccount");
							if (Client != null)
							{
								GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 10", 7);
								Client.Dispose();
							}
						}
					}
					else if (物品.属性4.属性类型 != 0 && 检查物品系统(物品.属性4))
					{
						Form1.WriteLine(77, "非法物品 " + 位置 + " [" + Userid + "]-[" + UserName + "] 位置[" + 物品.Bag + "] 编号[" + BitConverter.ToInt32(物品.物品全局ID, 0) + "] 物品名称[" + 物品.Get_Name() + "] 物品数量[" + BitConverter.ToInt32(物品.Item_Amount, 0) + "] 属性:[" + 物品.FLD_MAGIC0 + "," + 物品.FLD_MAGIC1 + "," + 物品.FLD_MAGIC2 + "," + 物品.FLD_MAGIC3 + "," + 物品.FLD_MAGIC4 + "]");
						if (World.查非法物品操作 == 1)
						{
							物品.Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
						}
						else if (World.查非法物品操作 == 2)
						{
							DBA.ExeSqlCommand($"UPDATE TBL_ACCOUNT SET FLD_ZT=1 WHERE FLD_ID='{Userid}'", "rxjhaccount");
							if (Client != null)
							{
								GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 12", 7);
								Client.Dispose();
							}
						}
					}
				}
			}
			else if (World.查非法物品 == 2)
			{
				物品.得到物品属性方法(FLD_Item_Plus_VK, FLD_Item_Plus_TB, this);
				if (World.装备检测list.TryGetValue(物品.FLD_RESIDE2, out 装备检测类 value) && 检查物品系统2(物品, value))
				{
					string sqlCommand = $"SELECT count(*) FROM Itme_Log WHERE ItmeId={BitConverter.ToInt32(物品.物品全局ID, 0)}";
					int num = 0;
					try
					{
						num = (int)DBA.GetDBValue_3(sqlCommand, "WebDb");
					}
					catch (Exception)
					{
						num = -1;
					}
					if (num == 0)
					{
						Form1.WriteLine(77, "非法物品 " + 位置 + " [" + Userid + "]-[" + UserName + "] 位置[" + 物品.Bag + "] 编号[" + BitConverter.ToInt32(物品.物品全局ID, 0) + "] 物品名称[" + 物品.Get_Name() + "] 物品数量[" + BitConverter.ToInt32(物品.Item_Amount, 0) + "] 属性:[" + 物品.FLD_MAGIC0 + "," + 物品.FLD_MAGIC1 + "," + 物品.FLD_MAGIC2 + "," + 物品.FLD_MAGIC3 + "," + 物品.FLD_MAGIC4 + "] 绑定[" + 物品.物品绑定.ToString() + "] 魂[" + 物品.FLD_FJ_觉醒.ToString() + "] 进化[" + 物品.FLD_FJ_进化.ToString() + "]");
						if (World.查非法物品操作 == 1)
						{
							物品.Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
						}
						else if (World.查非法物品操作 == 2)
						{
							DBA.ExeSqlCommand($"UPDATE TBL_ACCOUNT SET FLD_ZT=1 WHERE FLD_ID='{Userid}'", "rxjhaccount");
							if (Client != null)
							{
								GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 11", 7);
								Client.Dispose();
							}
						}
					}
				}
			}
			if (World.Itme.TryGetValue((int)物品.FLD_PID, out ItmeClass value2))
			{
				if (value2.FLD_RESIDE2 == 4)
				{
					int num2 = 0;
					if ((物品.FLD_MAGIC1 > 20000000 && 物品.FLD_MAGIC1 < 30000000) || (物品.FLD_MAGIC1 > 110000000 && 物品.FLD_MAGIC1 < 120000000))
					{
						num2 = 1;
					}
					if ((物品.FLD_MAGIC2 > 20000000 && 物品.FLD_MAGIC2 < 30000000) || (物品.FLD_MAGIC2 > 110000000 && 物品.FLD_MAGIC2 < 120000000))
					{
						num2 = 1;
					}
					if ((物品.FLD_MAGIC3 > 20000000 && 物品.FLD_MAGIC3 < 30000000) || (物品.FLD_MAGIC3 > 110000000 && 物品.FLD_MAGIC3 < 120000000))
					{
						num2 = 1;
					}
					if ((物品.FLD_MAGIC4 > 20000000 && 物品.FLD_MAGIC4 < 30000000) || (物品.FLD_MAGIC4 > 110000000 && 物品.FLD_MAGIC4 < 120000000))
					{
						num2 = 1;
					}
					if (num2 != 0)
					{
						GameMessage("Phaìt hiêòn vâòt phâÒm không hõòp lêò: " + 物品.FLD_PID, 10);
						物品.Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
					}
				}
				else if (value2.FLD_RESIDE2 == 1 || value2.FLD_RESIDE2 == 2 || value2.FLD_RESIDE2 == 5 || value2.FLD_RESIDE2 == 6)
				{
					int num2 = 0;
					if ((物品.FLD_MAGIC1 > 10000000 && 物品.FLD_MAGIC1 < 20000000) || (物品.FLD_MAGIC1 > 70000000 && 物品.FLD_MAGIC1 < 80000000) || (物品.FLD_MAGIC1 > 100000000 && 物品.FLD_MAGIC1 < 110000000))
					{
						num2 = 1;
					}
					if ((物品.FLD_MAGIC2 > 10000000 && 物品.FLD_MAGIC2 < 20000000) || (物品.FLD_MAGIC2 > 70000000 && 物品.FLD_MAGIC2 < 80000000) || (物品.FLD_MAGIC2 > 100000000 && 物品.FLD_MAGIC2 < 110000000))
					{
						num2 = 1;
					}
					if ((物品.FLD_MAGIC3 > 10000000 && 物品.FLD_MAGIC3 < 20000000) || (物品.FLD_MAGIC3 > 70000000 && 物品.FLD_MAGIC3 < 80000000) || (物品.FLD_MAGIC3 > 100000000 && 物品.FLD_MAGIC3 < 110000000))
					{
						num2 = 1;
					}
					if ((物品.FLD_MAGIC4 > 10000000 && 物品.FLD_MAGIC4 < 20000000) || (物品.FLD_MAGIC4 > 70000000 && 物品.FLD_MAGIC4 < 80000000) || (物品.FLD_MAGIC4 > 100000000 && 物品.FLD_MAGIC4 < 110000000))
					{
						num2 = 1;
					}
					if (num2 != 0)
					{
						GameMessage("Phaìt hiêòn vâòt phâÒm không hõòp lêò: " + 物品.FLD_PID, 10);
						物品.Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
					}
				}
				else if ((value2.FLD_RESIDE2 == 7 || value2.FLD_RESIDE2 == 8 || value2.FLD_RESIDE2 == 10) && ((value2.FLD_PID >= 1 && value2.FLD_PID <= 125) || (value2.FLD_PID >= 100001 && value2.FLD_PID <= 100126) || (value2.FLD_PID >= 700001 && value2.FLD_PID <= 700130)))
				{
					if (物品.FLD_MAGIC1 != value2.FLD_MAGIC1 && value2.FLD_MAGIC1 != 0)
					{
						物品.FLD_MAGIC1 = value2.FLD_MAGIC1;
					}
					if (物品.FLD_MAGIC2 != value2.FLD_MAGIC2 && value2.FLD_MAGIC2 != 0)
					{
						物品.FLD_MAGIC2 = value2.FLD_MAGIC2;
					}
					if (物品.FLD_MAGIC3 != value2.FLD_MAGIC3 && value2.FLD_MAGIC3 != 0)
					{
						物品.FLD_MAGIC3 = value2.FLD_MAGIC3;
					}
					if (物品.FLD_MAGIC4 != value2.FLD_MAGIC4 && value2.FLD_MAGIC4 != 0)
					{
						物品.FLD_MAGIC4 = value2.FLD_MAGIC4;
					}
				}
				if (value2.FLD_CJL != 0)
				{
					string text = 物品.FLD_PID.ToString();
					if (text.Contains("00200320") || text.Contains("00200322") || text.Contains("00200325") || text.Contains("00200360") || text.Contains("00200362") || text.Contains("00200365") || text.Contains("00303031") || text.Contains("00303033") || text.Contains("00303035") || text.Contains("00303071") || text.Contains("00303073") || text.Contains("00303075") || text.Contains("00803031") || text.Contains("00803033") || text.Contains("00803035") || text.Contains("00803071") || text.Contains("00803073") || text.Contains("00803075") || text.Contains("00503031") || text.Contains("00503033") || text.Contains("00503035") || text.Contains("00503071") || text.Contains("00503073") || text.Contains("00503075") || text.Contains("00403032") || text.Contains("00403034") || text.Contains("00403036") || text.Contains("00403072") || text.Contains("00403074") || text.Contains("00403076"))
					{
						物品.FLD_PID++;
					}
				}
			}
			if (物品.FLD_PID == 1000000416)
			{
				物品.FLD_PID = 1000000415L;
			}
			if (物品.FLD_PID == 800000013 && 物品.FLD_MAGIC0 > 80000000 && 物品.FLD_MAGIC0 < 80000099)
			{
				物品.FLD_MAGIC0 = 0;
			}
		}

		public bool 检查物品系统2(物品类 物品, 装备检测类 var)
		{
			return (var.物品最高攻击值 != 0 && 物品.物品属性_攻击力增加 >= var.物品最高攻击值) || (var.物品最高防御值 != 0 && 物品.物品属性_防御力增加 + 物品.Item_Defense >= var.物品最高防御值) || (var.物品最高生命值 != 0 && 物品.物品属性_生命力增加 >= var.物品最高生命值) || (var.物品最高内功值 != 0 && 物品.物品属性_内功力增加 >= var.物品最高内功值) || (var.物品最高命中值 != 0 && 物品.Item_Accuracy >= var.物品最高命中值) || (var.物品最高回避值 != 0 && 物品.Item_Evasion >= var.物品最高回避值) || (var.物品最高武功值 != 0 && 物品.Item_Attack_Skill >= var.物品最高武功值) || (var.物品最高气功值 != 0 && 物品.Level_Qigong_All >= var.物品最高气功值);
		}

		public void Add_Del_Rxpiont(int 元宝, int 类型)
		{
			if (World.元宝检测 == 1 && FLD_RXPIONT < 0)
			{
				Form1.WriteLine(100, "元宝数据异常[" + Userid + "]-[" + UserName + "] [" + FLD_RXPIONT + "]");
				DBA.ExeSqlCommand($"UPDATE TBL_ACCOUNT SET FLD_ZT=1 WHERE FLD_ID='{Userid}'", "rxjhaccount");
				FLD_RXPIONT = 0;
				Save_data_Rxpiont();
				Form1.WriteLine(100, "非法修改元宝封号[" + Userid + "][" + UserName + "]");
				系统公告("因为[" + UserName + "]违反了游戏规则,账号永久封停,请大家引以为鉴");
				GameMessage("因为您违反了游戏规则,元宝数据异常,账号永久封停,如有疑问请联系管理", 9);
				if (Client != null)
				{
					GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 9", 7);
					Client.Dispose();
				}
			}
			else if (World.元宝检测 == 2 && FLD_RXPIONT < 0)
			{
				Form1.WriteLine(100, "元宝数据异常[" + Userid + "]-[" + UserName + "] [" + FLD_RXPIONT + "]");
				FLD_RXPIONT = 0;
				Form1.WriteLine(100, "元宝数据清零[" + Userid + "]-[" + UserName + "] [" + FLD_RXPIONT + "]");
				Save_data_Rxpiont();
				系统公告("因为[" + UserName + "]违反了游戏规则,元宝数据异常,元宝全部清零,请大家引以为鉴");
				GameMessage("因为您违反了游戏规则,元宝数据异常,元宝全部清零,如有疑问请联系管理", 9);
				if (Client != null)
				{
					GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 8", 7);
					Client.Dispose();
				}
			}
			else if (类型 == 0)
			{
				FLD_RXPIONT -= 元宝;
				FLD_RXPIONTX -= 元宝;
				GameMessage("Baòn biò -" + 元宝 + " @CASH", 7);
				Save_data_Rxpiont();
			}
			else
			{
				FLD_RXPIONT += 元宝;
				FLD_RXPIONTX += 元宝;
				GameMessage("Baòn ðýõòc +" + 元宝 + " @CASH", 7);
				Save_data_Rxpiont();
			}
		}

		public void Add_Del_Rxpiont1(int 元宝, int 类型)
		{
			if (World.元宝检测 == 1 && FLD_RXPIONT < 0)
			{
				Form1.WriteLine(100, "元宝数据异常[" + Userid + "]-[" + UserName + "] [" + FLD_RXPIONT + "]");
				DBA.ExeSqlCommand($"UPDATE TBL_ACCOUNT SET FLD_ZT=1 WHERE FLD_ID='{Userid}'", "rxjhaccount");
				FLD_RXPIONT = 0;
				Save_data_Rxpiont();
				Form1.WriteLine(100, "非法修改元宝封号[" + Userid + "][" + UserName + "]");
				系统公告("因为[" + UserName + "]违反了游戏规则,账号永久封停,请大家引以为鉴");
				GameMessage("因为您违反了游戏规则,元宝数据异常,账号永久封停,如有疑问请联系管理", 9);
				if (Client != null)
				{
					GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 9", 7);
					Client.Dispose();
				}
			}
			else if (World.元宝检测 == 2 && FLD_RXPIONT < 0)
			{
				Form1.WriteLine(100, "元宝数据异常[" + Userid + "]-[" + UserName + "] [" + FLD_RXPIONT + "]");
				FLD_RXPIONT = 0;
				Form1.WriteLine(100, "元宝数据清零[" + Userid + "]-[" + UserName + "] [" + FLD_RXPIONT + "]");
				Save_data_Rxpiont();
				系统公告("因为[" + UserName + "]违反了游戏规则,元宝数据异常,元宝全部清零,请大家引以为鉴");
				GameMessage("因为您违反了游戏规则,元宝数据异常,元宝全部清零,如有疑问请联系管理", 9);
				if (Client != null)
				{
					GameMessage("Baìo cho admin maÞ sôì naÌy: Disconnect: 8", 7);
					Client.Dispose();
				}
			}
			else if (类型 == 0)
			{
				FLD_RXPIONT -= 元宝;
				FLD_RXPIONTX -= 元宝;
				Save_data_Rxpiont();
			}
			else
			{
				FLD_RXPIONT += 元宝;
				FLD_RXPIONTX += 元宝;
				Save_data_Rxpiont();
			}
		}

		public void Update_Quest_Complete()
		{
			try
			{
				int num = 15;
				byte[] array = Converter.hexStringToByte("AA55E307000B008B00D407E80300000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
				foreach (任务类 value in 任务.Values)
				{
					if (value.任务阶段ID == 255)
					{
						Buffer.BlockCopy(BitConverter.GetBytes(value.任务ID), 0, array, num, 2);
						num += 2;
					}
				}
				if (Player_Job == 7)
				{
					Buffer.BlockCopy(BitConverter.GetBytes(9957), 0, array, num + 2, 2);
					Buffer.BlockCopy(BitConverter.GetBytes(9937), 0, array, num + 4, 2);
					Buffer.BlockCopy(BitConverter.GetBytes(9945), 0, array, num + 6, 2);
				}
				Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void 解除召唤(Players TOPlaye, Players Playe)
		{
			string hex = "AA55170001549C6300080001000000549C0001000000000000A37B55AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(Playe.Pet.全服ID), 0, array, 15, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(TOPlaye.UserSessionID), 0, array, 5, 2);
			if (TOPlaye.Client != null)
			{
				TOPlaye.Client.Send多包(array, array.Length);
			}
			SendRangeOfPackets(array, array.Length);
		}

		public void 解除召唤2(Players TOPlaye, Players Playe)
		{
			string hex = "AA55170001549C6300080001000000549C0001000000000000A37B55AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(Playe.Pet.全服ID), 0, array, 15, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(TOPlaye.UserSessionID), 0, array, 5, 2);
			if (TOPlaye.Client != null)
			{
				TOPlaye.Client.Send多包(array, array.Length);
			}
		}

		public void 离开当前地图(Players Playe, Players ToPlaye)
		{
			try
			{
				string hex = "AA551700000300630008000100000003000001000000000000000055AA";
				byte[] array = Converter.hexStringToByte(hex);
				Buffer.BlockCopy(BitConverter.GetBytes(ToPlaye.UserSessionID), 0, array, 15, 2);
				Buffer.BlockCopy(BitConverter.GetBytes(Playe.UserSessionID), 0, array, 5, 2);
				if (Playe.Client != null)
				{
					Playe.Client.Send多包(array, array.Length);
				}
				if (ToPlaye.Pet != null)
				{
					解除召唤2(Playe, ToPlaye);
				}
			}
			catch
			{
			}
		}

		public void 魔法不足提示()
		{
			string hex = "AA5517000000003D0008000E2C090002000000000000000000000055AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public bool Set_Dragon_2_old(long pid, int reside2)
		{
			switch (reside2)
			{
			case 1:
				if (pid != 100303030 && pid != 200303030 && pid != 300303030 && pid != 400303030 && pid != 500303030 && pid != 700303030)
				{
					return pid == 800303030;
				}
				return true;
			case 2:
				if (pid != 100503030 && pid != 200503030 && pid != 300503030 && pid != 400503030 && pid != 500503030 && pid != 700503030)
				{
					return pid == 800503030;
				}
				return true;
			case 4:
				if (pid != 100200310 && pid != 200200310 && pid != 310200310 && pid != 400200310 && pid != 500200310 && pid != 700200310)
				{
					return pid == 800200310;
				}
				return true;
			case 5:
				if (pid != 100803030 && pid != 200803030 && pid != 300803030 && pid != 400803030 && pid != 500803030 && pid != 700803030)
				{
					return pid == 800803030;
				}
				return true;
			default:
				return false;
			case 6:
				if (pid != 100403031 && pid != 200403031 && pid != 300403031 && pid != 400403031 && pid != 500403031 && pid != 700403031)
				{
					return pid == 800403031;
				}
				return true;
			}
		}

		public bool Set_Dragon_3_old(long pid, int reside2)
		{
			switch (reside2)
			{
			case 1:
			{
				int num3;
				switch (pid)
				{
				default:
					num3 = ((pid == 700303031) ? 1 : 0);
					break;
				case 500303031L:
					num3 = 1;
					break;
				case 100303031L:
				case 200303031L:
				case 300303031L:
				case 400303031L:
					num3 = 1;
					break;
				}
				if (num3 == 0)
				{
					return pid == 800303031;
				}
				return true;
			}
			case 2:
			{
				int num4;
				switch (pid)
				{
				default:
					num4 = ((pid == 700503031) ? 1 : 0);
					break;
				case 500503031L:
					num4 = 1;
					break;
				case 100503031L:
				case 200503031L:
				case 300503031L:
				case 400503031L:
					num4 = 1;
					break;
				}
				if (num4 == 0)
				{
					return pid == 800503031;
				}
				return true;
			}
			case 4:
			{
				int num2;
				switch (pid)
				{
				default:
					num2 = ((pid == 700200320) ? 1 : 0);
					break;
				case 500200320L:
					num2 = 1;
					break;
				case 100200320L:
				case 200200320L:
				case 310200320L:
				case 400200320L:
					num2 = 1;
					break;
				}
				if (num2 == 0)
				{
					return pid == 800200320;
				}
				return true;
			}
			case 5:
			{
				int num5;
				switch (pid)
				{
				default:
					num5 = ((pid == 700803031) ? 1 : 0);
					break;
				case 500803031L:
					num5 = 1;
					break;
				case 100803031L:
				case 200803031L:
				case 300803031L:
				case 400803031L:
					num5 = 1;
					break;
				}
				if (num5 == 0)
				{
					return pid == 800803031;
				}
				return true;
			}
			default:
				return false;
			case 6:
			{
				int num;
				switch (pid)
				{
				default:
					num = ((pid == 700403032) ? 1 : 0);
					break;
				case 500403032L:
					num = 1;
					break;
				case 100403032L:
				case 200403032L:
				case 300403032L:
				case 400403032L:
					num = 1;
					break;
				}
				if (num == 0)
				{
					return pid == 800403032;
				}
				return true;
			}
			}
		}

		public bool Set_Dragon_1_old(long pid, int reside2)
		{
			switch (reside2)
			{
			case 1:
			{
				int num3;
				switch (pid)
				{
				default:
					num3 = ((pid == 700303029) ? 1 : 0);
					break;
				case 500303029L:
					num3 = 1;
					break;
				case 100303029L:
				case 200303029L:
				case 300303029L:
				case 400303029L:
					num3 = 1;
					break;
				}
				if (num3 == 0)
				{
					return pid == 800303029;
				}
				return true;
			}
			case 2:
			{
				int num4;
				switch (pid)
				{
				default:
					num4 = ((pid == 700503029) ? 1 : 0);
					break;
				case 500503029L:
					num4 = 1;
					break;
				case 100503029L:
				case 200503029L:
				case 300503029L:
				case 400503029L:
					num4 = 1;
					break;
				}
				if (num4 == 0)
				{
					return pid == 800503029;
				}
				return true;
			}
			case 4:
			{
				int num2;
				switch (pid)
				{
				default:
					num2 = ((pid == 700200300) ? 1 : 0);
					break;
				case 500200300L:
					num2 = 1;
					break;
				case 100200300L:
				case 200200300L:
				case 300200300L:
				case 400200300L:
					num2 = 1;
					break;
				}
				if (num2 == 0)
				{
					return pid == 800200300;
				}
				return true;
			}
			case 5:
			{
				int num5;
				switch (pid)
				{
				default:
					num5 = ((pid == 700803029) ? 1 : 0);
					break;
				case 500803029L:
					num5 = 1;
					break;
				case 100803029L:
				case 200803029L:
				case 300803029L:
				case 400803029L:
					num5 = 1;
					break;
				}
				if (num5 == 0)
				{
					return pid == 800803029;
				}
				return true;
			}
			default:
				return false;
			case 6:
			{
				int num;
				switch (pid)
				{
				default:
					num = ((pid == 700403030) ? 1 : 0);
					break;
				case 500403030L:
					num = 1;
					break;
				case 100403030L:
				case 200403030L:
				case 300403030L:
				case 400403030L:
					num = 1;
					break;
				}
				if (num == 0)
				{
					return pid == 800403030;
				}
				return true;
			}
			}
		}

		public bool Set_Susan_old(long pid, int reside2)
		{
			switch (reside2)
			{
			case 1:
				switch (pid)
				{
				case 115302001L:
					return true;
				case 125301001L:
					return true;
				case 125302001L:
					return true;
				case 215301001L:
					return true;
				case 215302001L:
					return true;
				case 225301001L:
					return true;
				case 225302001L:
					return true;
				case 315301001L:
					return true;
				case 315302001L:
					return true;
				case 325301001L:
					return true;
				case 325302001L:
					return true;
				case 415301001L:
					return true;
				case 415302001L:
					return true;
				case 425301001L:
					return true;
				case 425302001L:
					return true;
				case 515301001L:
					return true;
				case 515302001L:
					return true;
				case 525301001L:
					return true;
				case 525302001L:
					return true;
				case 715301001L:
					return true;
				case 715302001L:
					return true;
				case 725301001L:
					return true;
				case 725302001L:
					return true;
				case 815301001L:
					return true;
				case 815302001L:
					return true;
				default:
					return pid == 825302001;
				case 115301001L:
				case 825301001L:
					return true;
				}
			case 2:
				switch (pid)
				{
				case 725501001L:
					return true;
				case 715502001L:
					return true;
				case 715501001L:
					return true;
				case 525502001L:
					return true;
				case 525501001L:
					return true;
				case 515502001L:
					return true;
				case 515501001L:
					return true;
				case 425502001L:
					return true;
				case 425501001L:
					return true;
				case 415502001L:
					return true;
				case 415501001L:
					return true;
				case 325502001L:
					return true;
				case 325501001L:
					return true;
				case 315502001L:
					return true;
				case 315501001L:
					return true;
				case 225502001L:
					return true;
				case 225501001L:
					return true;
				case 215502001L:
					return true;
				case 215501001L:
					return true;
				case 125502001L:
					return true;
				case 125501001L:
					return true;
				case 115502001L:
					return true;
				case 115501001L:
					return true;
				case 815501001L:
					return true;
				case 815502001L:
					return true;
				default:
					return pid == 825502001;
				case 725502001L:
				case 825501001L:
					return true;
				}
			case 5:
				switch (pid)
				{
				case 115802001L:
					return true;
				case 125801001L:
					return true;
				case 125802001L:
					return true;
				case 215801001L:
					return true;
				case 215802001L:
					return true;
				case 225801001L:
					return true;
				case 225802001L:
					return true;
				case 315801001L:
					return true;
				case 315802001L:
					return true;
				case 325801001L:
					return true;
				case 325802001L:
					return true;
				case 415801001L:
					return true;
				case 415802001L:
					return true;
				case 425801001L:
					return true;
				case 425802001L:
					return true;
				case 515801001L:
					return true;
				case 515802001L:
					return true;
				case 525801001L:
					return true;
				case 525802001L:
					return true;
				case 715801001L:
					return true;
				case 715802001L:
					return true;
				case 725801001L:
					return true;
				case 725802001L:
					return true;
				case 815801001L:
					return true;
				case 815802001L:
					return true;
				default:
					return pid == 825802001;
				case 115801001L:
				case 825801001L:
					return true;
				}
			default:
				return false;
			case 6:
				switch (pid)
				{
				case 115402001L:
					return true;
				case 125401001L:
					return true;
				case 125402001L:
					return true;
				case 215401001L:
					return true;
				case 215402001L:
					return true;
				case 225401001L:
					return true;
				case 225402001L:
					return true;
				case 315401001L:
					return true;
				case 315402001L:
					return true;
				case 325401001L:
					return true;
				case 325402001L:
					return true;
				case 415401001L:
					return true;
				case 415402001L:
					return true;
				case 425401001L:
					return true;
				case 425402001L:
					return true;
				case 515401001L:
					return true;
				case 515402001L:
					return true;
				case 525401001L:
					return true;
				case 525402001L:
					return true;
				case 715401001L:
					return true;
				case 715402001L:
					return true;
				case 725401001L:
					return true;
				case 725402001L:
					return true;
				case 815401001L:
					return true;
				case 815402001L:
					return true;
				default:
					return pid == 825402001;
				case 115401001L:
				case 825401001L:
					return true;
				}
			}
		}

		public bool Set_Susan(long pid, int reside2)
		{
			switch (reside2)
			{
			case 1:
			{
				int num3;
				switch (pid)
				{
				default:
					num3 = ((pid == 825301001) ? 1 : 0);
					break;
				case 815301001L:
				case 815302001L:
					num3 = 1;
					break;
				case 515301001L:
				case 515302001L:
				case 525301001L:
				case 525302001L:
				case 715301001L:
				case 715302001L:
				case 725301001L:
				case 725302001L:
					num3 = 1;
					break;
				case 115301001L:
				case 115302001L:
				case 125301001L:
				case 125302001L:
				case 215301001L:
				case 215302001L:
				case 225301001L:
				case 225302001L:
				case 315301001L:
				case 315302001L:
				case 325301001L:
				case 325302001L:
				case 415301001L:
				case 415302001L:
				case 425301001L:
				case 425302001L:
					num3 = 1;
					break;
				}
				if (num3 == 0)
				{
					return pid == 825302001;
				}
				return true;
			}
			case 2:
			{
				int num4;
				switch (pid)
				{
				default:
					num4 = ((pid == 825501001) ? 1 : 0);
					break;
				case 815501001L:
				case 815502001L:
					num4 = 1;
					break;
				case 115501001L:
				case 115502001L:
				case 125501001L:
				case 125502001L:
				case 215501001L:
				case 215502001L:
				case 225501001L:
				case 225502001L:
					num4 = 1;
					break;
				case 315501001L:
				case 315502001L:
				case 325501001L:
				case 325502001L:
				case 415501001L:
				case 415502001L:
				case 425501001L:
				case 425502001L:
				case 515501001L:
				case 515502001L:
				case 525501001L:
				case 525502001L:
				case 715501001L:
				case 715502001L:
				case 725501001L:
				case 725502001L:
					num4 = 1;
					break;
				}
				if (num4 == 0)
				{
					return pid == 825502001;
				}
				return true;
			}
			case 5:
			{
				int num2;
				switch (pid)
				{
				default:
					num2 = ((pid == 825801001) ? 1 : 0);
					break;
				case 815801001L:
				case 815802001L:
					num2 = 1;
					break;
				case 515801001L:
				case 515802001L:
				case 525801001L:
				case 525802001L:
				case 715801001L:
				case 715802001L:
				case 725801001L:
				case 725802001L:
					num2 = 1;
					break;
				case 115801001L:
				case 115802001L:
				case 125801001L:
				case 125802001L:
				case 215801001L:
				case 215802001L:
				case 225801001L:
				case 225802001L:
				case 315801001L:
				case 315802001L:
				case 325801001L:
				case 325802001L:
				case 415801001L:
				case 415802001L:
				case 425801001L:
				case 425802001L:
					num2 = 1;
					break;
				}
				if (num2 == 0)
				{
					return pid == 825802001;
				}
				return true;
			}
			default:
				return false;
			case 6:
			{
				int num;
				switch (pid)
				{
				default:
					num = ((pid == 825401001) ? 1 : 0);
					break;
				case 815401001L:
				case 815402001L:
					num = 1;
					break;
				case 515401001L:
				case 515402001L:
				case 525401001L:
				case 525402001L:
				case 715401001L:
				case 715402001L:
				case 725401001L:
				case 725402001L:
					num = 1;
					break;
				case 115401001L:
				case 115402001L:
				case 125401001L:
				case 125402001L:
				case 215401001L:
				case 215402001L:
				case 225401001L:
				case 225402001L:
				case 315401001L:
				case 315402001L:
				case 325401001L:
				case 325402001L:
				case 415401001L:
				case 415402001L:
				case 425401001L:
				case 425402001L:
					num = 1;
					break;
				}
				if (num == 0)
				{
					return pid == 825402001;
				}
				return true;
			}
			}
		}

		public bool Set_Dragon_1(long pid, int reside2)
		{
			if (reside2 == 1)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("303029"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("303069"))
				{
					return true;
				}
			}
			if (reside2 == 2)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("503029"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("503069"))
				{
					return true;
				}
			}
			if (reside2 == 4)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("200300"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("200340"))
				{
					return true;
				}
			}
			if (reside2 == 5)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("803029"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("803069"))
				{
					return true;
				}
			}
			if (reside2 == 6)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					return pid.ToString().Contains("403030");
				}
				if (pid.ToString().Contains("403070"))
				{
					return true;
				}
			}
			return false;
		}

		public bool Set_Dragon_2(long pid, int reside2)
		{
			if (reside2 == 1)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("303030"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("303070"))
				{
					return true;
				}
			}
			if (reside2 == 2)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("503030"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("503070"))
				{
					return true;
				}
			}
			if (reside2 == 4)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("200310"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("200350"))
				{
					return true;
				}
			}
			if (reside2 == 5)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("803030"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("803070"))
				{
					return true;
				}
			}
			if (reside2 == 6)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					return pid.ToString().Contains("403071");
				}
				if (pid.ToString().Contains("403031"))
				{
					return true;
				}
			}
			return false;
		}

		public bool Set_Dragon_3(long pid, int reside2)
		{
			if (reside2 == 1)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("303031"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("303071"))
				{
					return true;
				}
			}
			if (reside2 == 2)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("503071"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("503031"))
				{
					return true;
				}
			}
			if (reside2 == 4)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("200320"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("200360"))
				{
					return true;
				}
			}
			if (reside2 == 5)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("803031"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("803071"))
				{
					return true;
				}
			}
			if (reside2 == 6)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					return pid.ToString().Contains("403032");
				}
				if (pid.ToString().Contains("403072"))
				{
					return true;
				}
			}
			return false;
		}

		public bool Set_Dragon_4(long pid, int reside2)
		{
			if (reside2 == 1)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("303032"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("303072"))
				{
					return true;
				}
			}
			if (reside2 == 2)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("503032"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("503072"))
				{
					return true;
				}
			}
			if (reside2 == 4)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("200321"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("200361"))
				{
					return true;
				}
			}
			if (reside2 == 5)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("803032"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("803072"))
				{
					return true;
				}
			}
			if (reside2 == 6)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					return pid.ToString().Contains("403033");
				}
				if (pid.ToString().Contains("403073"))
				{
					return true;
				}
			}
			return false;
		}

		public bool Set_Dragon_5(long pid, int reside2)
		{
			if (reside2 == 1)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("303033"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("303073"))
				{
					return true;
				}
			}
			if (reside2 == 2)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("503033"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("503073"))
				{
					return true;
				}
			}
			if (reside2 == 4)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("200322"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("200362"))
				{
					return true;
				}
			}
			if (reside2 == 5)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("803033"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("803073"))
				{
					return true;
				}
			}
			if (reside2 == 6)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					return pid.ToString().Contains("403034");
				}
				if (pid.ToString().Contains("403074"))
				{
					return true;
				}
			}
			return false;
		}

		public bool Set_Dragon_6(long pid, int reside2)
		{
			if (reside2 == 1)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("303034"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("303074"))
				{
					return true;
				}
			}
			if (reside2 == 2)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("503034"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("503074"))
				{
					return true;
				}
			}
			if (reside2 == 4)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("200323"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("200363"))
				{
					return true;
				}
			}
			if (reside2 == 5)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("803034"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("803074"))
				{
					return true;
				}
			}
			if (reside2 == 6)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					return pid.ToString().Contains("403035");
				}
				if (pid.ToString().Contains("403075"))
				{
					return true;
				}
			}
			return false;
		}

		public bool Set_Dragon_7(long pid, int reside2)
		{
			if (reside2 == 1)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("303035"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("303075"))
				{
					return true;
				}
			}
			if (reside2 == 2)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("503035"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("503075"))
				{
					return true;
				}
			}
			if (reside2 == 4)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("200325"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("200365"))
				{
					return true;
				}
			}
			if (reside2 == 5)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("803035"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("803075"))
				{
					return true;
				}
			}
			if (reside2 == 6)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					return pid.ToString().Contains("403036");
				}
				if (pid.ToString().Contains("403076"))
				{
					return true;
				}
			}
			return false;
		}

		public bool Set_Dragon_8(long pid, int reside2)
		{
			if (reside2 == 1)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("303036"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("303076"))
				{
					return true;
				}
			}
			if (reside2 == 2)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("503036"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("503076"))
				{
					return true;
				}
			}
			if (reside2 == 4)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("200326"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("200366"))
				{
					return true;
				}
			}
			if (reside2 == 5)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					if (pid.ToString().Contains("803036"))
					{
						return true;
					}
				}
				else if (pid.ToString().Contains("803076"))
				{
					return true;
				}
			}
			if (reside2 == 6)
			{
				if (Player_Job != 8 && Player_Job != 9 && Player_Job != 11 && Player_Job != 12)
				{
					return pid.ToString().Contains("403037");
				}
				if (pid.ToString().Contains("403077"))
				{
					return true;
				}
			}
			return false;
		}

		public bool Set_Dragon2_1(long pid, int reside2)
		{
			return pid == 17 || pid == 117 || pid == 100022 || pid == 100120 || pid == 100122 || pid == 700023 || pid == 700123;
		}

		public void 气功Clear()
		{
			for (int i = 0; i < 12; i++)
			{
				气功[i] = new 气功类(new byte[4]);
			}
		}

		public void 强化合成公告(int pid, string name, int level, int zx)
		{
			try
			{
				ItmeClass itmeClass = new ItmeClass();
				itmeClass = ItmeClass.GetItmeID(pid);
				if (itmeClass == null || itmeClass.FLD_LEVEL >= 10)
				{
					string hex = "AA555F0001150300505000010000000200000000000000090000007117000016A50700000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000020000000000000064FE55AA";
					byte[] array = Converter.hexStringToByte(hex);
					Buffer.BlockCopy(BitConverter.GetBytes(level), 0, array, 23, 1);
					Buffer.BlockCopy(BitConverter.GetBytes(pid), 0, array, 31, 4);
					byte[] bytes = Encoding.GetEncoding(1252).GetBytes(name);
					Buffer.BlockCopy(bytes, 0, array, 39, bytes.Length);
					Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
					Buffer.BlockCopy(BitConverter.GetBytes(zx), 0, array, 89, 1);
					if (Client != null)
					{
						Client.Send(array, array.Length);
					}
				}
			}
			catch
			{
			}
		}

		public void 任务Clear()
		{
			任务 = new Dictionary<int, 任务类>();
		}

		public void 商店提示(int id)
		{
			string hex = "AA55160001CB04CF000700010C3C0400000100000000000015F555AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(id), 0, array, 12, 1);
			Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 升级后的提示(int 提示类型)
		{
			string hex = "AA551100000000770002000701000000000000000055AA";
			byte[] array = Converter.hexStringToByte(hex);
			byte[] bytes = BitConverter.GetBytes(Player_Level);
			byte[] bytes2 = BitConverter.GetBytes(提示类型);
			Buffer.BlockCopy(bytes, 0, array, 11, bytes.Length);
			Buffer.BlockCopy(bytes2, 0, array, 12, bytes2.Length);
			Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
			SendRangeOfPackets(array, array.Length);
		}

		public void 势力战英雄复活提示(int IDD)
		{
			string hex = "AA552F00010F2713222000080001000100000001000000360E0000000000000000000000000000000000000000000000007D5C55AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(IDD), 0, array, 23, 1);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void Write_Name_Teacher()
		{
			string hex = "AA55570001FF034A1048000F000000000000000000000000000000010A0100000000204E0000020000000000000000000000003230313330353136323100000000000000000000000000000000000000000000000000000000EA2A55AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
			byte[] bytes = Encoding.GetEncoding(1252).GetBytes(FLD_Teacher);
			Buffer.BlockCopy(bytes, 0, array, 12, bytes.Length);
			Players players = World.FindPlayerbyName(FLD_Teacher);
			if (players != null)
			{
				Buffer.BlockCopy(BitConverter.GetBytes(1), 0, array, 27, 1);
			}
			else
			{
				Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 27, 1);
			}
			Buffer.BlockCopy(BitConverter.GetBytes(4), 0, array, 29, 1);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void Write_Student(int index, string Student)
		{
			string hex = "AA55570001D5034B104800000F323000000000000000000000000000010A0400000000000000000000000000000000000000003230313330353136323100000000000000000000000000000000000000000000000000000000E92A55AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(index), 0, array, 11, 1);
			byte[] bytes = Encoding.GetEncoding(1252).GetBytes(Student);
			Buffer.BlockCopy(bytes, 0, array, 13, bytes.Length);
			Players players = World.FindPlayerbyName(Student);
			if (players != null)
			{
				Buffer.BlockCopy(BitConverter.GetBytes(1), 0, array, 28, 1);
				Buffer.BlockCopy(BitConverter.GetBytes(players.Player_Level), 0, array, 29, 1);
				Buffer.BlockCopy(BitConverter.GetBytes(4), 0, array, 30, 1);
				Buffer.BlockCopy(BitConverter.GetBytes(players._FLD_师徒_武功ID1_1), 0, array, 39, 4);
				Buffer.BlockCopy(BitConverter.GetBytes(players._FLD_师徒_武功ID1_2), 0, array, 43, 4);
				Buffer.BlockCopy(BitConverter.GetBytes(players._FLD_师徒_武功ID1_3), 0, array, 47, 4);
			}
			else
			{
				string sqlCommand = $"select * from [TBL_XWWL_Char] where FLD_NAME=@Student";
				SqlParameter[] prams = new SqlParameter[1]
				{
					SqlDBA.MakeInParam("@Student", SqlDbType.VarChar, 30, Student)
				};
				DataTable dBToDataTable = DBA.GetDBToDataTable(sqlCommand, prams);
				if (dBToDataTable != null)
				{
					Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 28, 1);
					Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 29, 1);
					Buffer.BlockCopy(BitConverter.GetBytes(4), 0, array, 30, 1);
					Buffer.BlockCopy(BitConverter.GetBytes((int)dBToDataTable.Rows[0]["FLD_师徒武功1_1"]), 0, array, 39, 4);
					Buffer.BlockCopy(BitConverter.GetBytes((int)dBToDataTable.Rows[0]["FLD_师徒武功1_2"]), 0, array, 43, 4);
					Buffer.BlockCopy(BitConverter.GetBytes((int)dBToDataTable.Rows[0]["FLD_师徒武功1_3"]), 0, array, 47, 4);
				}
				else
				{
					switch (index)
					{
					case 0:
						FLD_Student1 = "";
						break;
					case 1:
						FLD_Student2 = "";
						break;
					case 2:
						FLD_Student3 = "";
						break;
					}
					Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 28, 1);
					Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 29, 1);
					Buffer.BlockCopy(BitConverter.GetBytes(4), 0, array, 30, 1);
					Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 39, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 43, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 47, 4);
				}
			}
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void Item_Use(int index, int Count_Use, int Amount = 0)
		{
			if (index != -1 && index < Item_In_Bag.Length)
			{
				string hex = "AA552C00002C013B001C000105000065CA9A3B000000000100000009000000000000000000000000000000000000000055AA";
				Converter.hexStringToByte(hex);
				BitConverter.GetBytes(index);
				if (Item_In_Bag[index].Get_Int_Item_Count <= Count_Use)
				{
					Item_In_Bag[index].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
				}
				else
				{
					Item_In_Bag[index].Item_Amount = BitConverter.GetBytes(Item_In_Bag[index].Get_Int_Item_Count - Count_Use);
				}
				PacketData packetData = new PacketData();
				packetData.WriteByte(1);
				packetData.WriteShort(index);
				packetData.WriteByte(0);
				packetData.WriteLong(Item_In_Bag[index].FLD_PID);
				if (Amount != 0)
				{
					packetData.WriteInt(Amount);
				}
				else if (Count_Use == 0)
				{
					packetData.WriteInt(Item_In_Bag[index].Get_Int_Item_Count);
				}
				else
				{
					packetData.WriteInt(Count_Use);
				}
				packetData.WriteInt(Item_In_Bag[index].Get_Int_Item_Count);
				if (Item_In_Bag[index].FLD_PID == 1700101)
				{
					packetData.WriteInt(111);
				}
				else
				{
					packetData.WriteInt(0);
				}
				packetData.WriteInt(0);
				if (Client != null)
				{
					Client.SendPak(packetData, 15104, UserSessionID);
				}
				if (Count_Use > 0)
				{
					Item_Effects(Item_In_Bag[index].FLD_PID);
				}
				if (Item_In_Bag[index].FLD_PID >= 1007000007 && Item_In_Bag[index].FLD_PID < 2000000000)
				{
					string txt = "[ " + UserName + " ] - [ " + Item_In_Bag[index].FLD_PID + " ] - [ " + BitConverter.ToInt32(Item_In_Bag[index].物品全局ID, 0) + " ]";
					logo.logdungpill(txt);
					SaveDataCharacter();
				}
			}
		}

		public void 物品使用戒指(int 位置, int 数量, int 使用提示)
		{
			PacketData packetData = new PacketData();
			packetData.WriteByte(1);
			packetData.WriteShort(位置);
			packetData.WriteByte(0);
			packetData.WriteInt(BitConverter.ToInt32(Item_In_Bag[位置].Get_Byte_Item_PID, 0));
			packetData.WriteInt(0);
			packetData.WriteShort(使用提示);
			packetData.WriteShort(0);
			packetData.WriteInt(数量);
			if (Client != null)
			{
				Client.SendPak(packetData, 15104, UserSessionID);
			}
		}

		public void Item_Effects(long 物品id)
		{
			PacketData packetData = new PacketData();
			packetData.WriteLong(物品id);
			if (Client != null)
			{
				Client.SendPak(packetData, 32512, UserSessionID);
			}
			SendRangeOfPackets(packetData, 32512, UserSessionID);
		}

		public void 物品使用千年雪参(int 位置, int 数量)
		{
			try
			{
				if (异常状态 != null && 异常状态.ContainsKey(3))
				{
					数量 *= 2;
				}
				string hex = "AA552C00002C013B001C000105000065CA9A3B000000000100000009000000000000000000000000000000000000000055AA";
				byte[] array = Converter.hexStringToByte(hex);
				byte[] array2 = new byte[4];
				Buffer.BlockCopy(Item_In_Bag[位置].Byte_Item, 20, array2, 0, 4);
				int num = BitConverter.ToInt32(array2, 0) - 2010000000 - 数量;
				Buffer.BlockCopy(BitConverter.GetBytes(位置), 0, array, 12, 2);
				Buffer.BlockCopy(Item_In_Bag[位置].Get_Byte_Item_PID, 0, array, 15, 4);
				if (num <= 0)
				{
					if (BitConverter.ToInt32(Item_In_Bag[位置].Item_Amount, 0) <= 1)
					{
						Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 27, 4);
						Buffer.BlockCopy(BitConverter.GetBytes(2010000000), 0, array, 31, 4);
						Item_In_Bag[位置].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
					}
					else
					{
						int value = BitConverter.ToInt32(Item_In_Bag[位置].Item_Amount, 0) - 1;
						Item_In_Bag[位置].Item_Amount = BitConverter.GetBytes(value);
						Buffer.BlockCopy(BitConverter.GetBytes(2010600000), 0, Item_In_Bag[位置].Byte_Item, 20, 4);
						Buffer.BlockCopy(Item_In_Bag[位置].Item_Amount, 0, array, 27, 4);
						Buffer.BlockCopy(BitConverter.GetBytes(2010600000), 0, array, 31, 4);
					}
				}
				else
				{
					Buffer.BlockCopy(BitConverter.GetBytes(num + 2010000000), 0, Item_In_Bag[位置].Byte_Item, 20, 4);
					Buffer.BlockCopy(Item_In_Bag[位置].Item_Amount, 0, array, 27, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(num + 2010000000), 0, array, 31, 4);
				}
				Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void 物品使用无双千年雪参(int 位置, int 数量)
		{
			try
			{
				if (异常状态 != null && 异常状态.ContainsKey(3))
				{
					数量 *= 2;
				}
				string hex = "AA552C00002C013B001C000105000065CA9A3B000000000100000009000000000000000000000000000000000000000055AA";
				byte[] array = Converter.hexStringToByte(hex);
				byte[] array2 = new byte[4];
				Buffer.BlockCopy(Item_In_Bag[位置].Byte_Item, 20, array2, 0, 4);
				double num2;
				if (Item_In_Bag[位置].FLD_PID == 1008000077)
				{
					double num = BitConverter.ToInt32(array2, 0) - 1110000000;
					num2 = num - (double)(数量 * 100 / Player_HP_Max);
				}
				else
				{
					double num = BitConverter.ToInt32(array2, 0) - 1110000000;
					num2 = num - (double)(数量 * 100 / Player_HP_Max);
				}
				int num3 = (int)num2;
				Buffer.BlockCopy(BitConverter.GetBytes(位置), 0, array, 12, 2);
				Buffer.BlockCopy(Item_In_Bag[位置].Get_Byte_Item_PID, 0, array, 15, 4);
				if (num3 <= 0)
				{
					if (BitConverter.ToInt32(Item_In_Bag[位置].Item_Amount, 0) <= 1)
					{
						Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 27, 4);
						Buffer.BlockCopy(BitConverter.GetBytes(1110000000), 0, array, 31, 4);
						Item_In_Bag[位置].Byte_Item = new byte[(World.Newversion >= 14) ? 76 : 73];
					}
					else
					{
						int value = BitConverter.ToInt32(Item_In_Bag[位置].Item_Amount, 0) - 1;
						Item_In_Bag[位置].Item_Amount = BitConverter.GetBytes(value);
						Buffer.BlockCopy(BitConverter.GetBytes(1110100000), 0, Item_In_Bag[位置].Byte_Item, 20, 4);
						Buffer.BlockCopy(Item_In_Bag[位置].Item_Amount, 0, array, 27, 4);
						Buffer.BlockCopy(BitConverter.GetBytes(1110100000), 0, array, 31, 4);
					}
				}
				else
				{
					Buffer.BlockCopy(BitConverter.GetBytes(num3 + 1110000000), 0, Item_In_Bag[位置].Byte_Item, 20, 4);
					Buffer.BlockCopy(Item_In_Bag[位置].Item_Amount, 0, array, 27, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(num3 + 1110000000), 0, array, 31, 4);
				}
				Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
			catch
			{
			}
		}

		public void 系统公告(string msg)
		{
			if (World.Newversion >= 16)
			{
				GameMessage(msg, 8);
				return;
			}
			if (World.文本兑换.TryGetValue(msg, out 文本兑换类 value))
			{
				msg = value.英文;
			}
			string hex = "AA55A600000F2766009700082020202020302020202020203130202020202020304DB1BE000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA";
			byte[] array = Converter.hexStringToByte(hex);
			byte[] bytes = Encoding.GetEncoding(1252).GetBytes(msg);
			Buffer.BlockCopy(bytes, 0, array, 35, bytes.Length);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public void 系统滚动公告(string msg)
		{
			if (World.Newversion < 16)
			{
				if (World.文本兑换.TryGetValue(msg, out 文本兑换类 value))
				{
					msg = value.英文;
				}
				string hex = "AA55A60000F203660097000820202020203120202020202031202020202020302080312E320000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA";
				byte[] array = Converter.hexStringToByte(hex);
				byte[] bytes = Encoding.GetEncoding(1252).GetBytes(msg);
				Buffer.BlockCopy(bytes, 0, array, 35, bytes.Length);
				if (Client != null)
				{
					Client.Send(array, array.Length);
				}
			}
		}

		public void GameMessage(string msg, int msgType = 50, string name = "")
		{
			msg = msg.Substring(0, Math.Min(msg.Length, 120));
			if (World.文本兑换.TryGetValue(msg, out 文本兑换类 value))
			{
				msg = value.英文;
			}
			if (World.文本兑换.TryGetValue(name, out 文本兑换类 value2))
			{
				name = value2.英文;
			}
			PacketData packetData = new PacketData();
			if (World.Newversion >= 16)
			{
				packetData.WriteShort(msgType);
			}
			else
			{
				packetData.WriteByte(msgType);
			}
			packetData.WriteString(name);
			packetData.WriteLong(0L);
			packetData.WriteString(msg, msg.Length);
			packetData.WriteLong(0L);
			packetData.WriteLong(0L);
			packetData.WriteLong(0L);
			packetData.WriteLong(0L);
			packetData.WriteLong(0L);
			packetData.WriteLong(0L);
			if (Client != null)
			{
				Client.SendPak(packetData, 26112, (UserName == name) ? UserSessionID : 0);
			}
		}

		private bool Check_Radius_Player(int far_, Players Playe)
		{
			if (Playe.Player_FLD_Map != Player_FLD_Map)
			{
				return false;
			}
			float num = Playe.Player_FLD_X - Player_FLD_X;
			float num2 = Playe.Player_FLD_Y - Player_FLD_Y;
			float num3 = (int)Math.Sqrt(num * num + num2 * num2);
			return num3 <= (float)far_;
		}

		public void 新吃药提示()
		{
			PacketData packetData = new PacketData();
			packetData.WriteInt(1025);
			packetData.WriteLong(1008000093L);
			packetData.WriteInt(3);
			packetData.WriteInt(1);
			packetData.WriteInt(2000000012);
			packetData.WriteInt(0);
			if (Client != null)
			{
				Client.SendPak(packetData, 15104, UserSessionID);
			}
		}

		public void 增加物品3(byte[] 物品全局ID, byte[] 物品ID, int 位置, byte[] 数量, byte[] 物品属性)
		{
			try
			{
				if (World.Itme.TryGetValue(BitConverter.ToInt32(物品ID, 0), out ItmeClass value))
				{
					string hex = "AA556B0001940223005C00010000008716E567818320060208AF2F000000000100000000000000010F020F00020000470D030000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000C3E755AA";
					byte[] array = Converter.hexStringToByte(hex);
					byte[] array2 = new byte[(World.Newversion >= 14) ? 76 : 73];
					if (value.FLD_SIDE != 0)
					{
						byte[] array3 = new byte[4];
						Buffer.BlockCopy(物品属性, 0, array3, 0, 4);
						物品类 物品类 = 得到人物物品类型(BitConverter.ToInt32(物品ID, 0), BitConverter.ToInt32(array3, 0));
						if (物品类 != null)
						{
							位置 = 物品类.Bag;
							物品全局ID = 物品类.物品全局ID;
							数量 = BitConverter.GetBytes(BitConverter.ToInt32(物品类.Item_Amount, 0) + BitConverter.ToInt32(数量, 0));
						}
						else
						{
							物品全局ID = BitConverter.GetBytes(RxjhClass.GetDbItmeId());
						}
					}
					else
					{
						数量 = BitConverter.GetBytes(1);
					}
					Buffer.BlockCopy(物品全局ID, 0, array2, 0, 8);
					Buffer.BlockCopy(物品ID, 0, array2, 8, 4);
					Buffer.BlockCopy(数量, 0, array2, 12, 4);
					Buffer.BlockCopy(物品属性, 0, array2, 16, 物品属性.Length);
					Buffer.BlockCopy(BitConverter.GetBytes(位置), 0, array, 40, 2);
					Buffer.BlockCopy(array2, 0, array, 15, 12);
					Buffer.BlockCopy(array2, 12, array, 31, 4);
					Buffer.BlockCopy(array2, 16, array, 47, 物品属性.Length);
					Item_In_Bag[位置].Byte_Item = array2;
					Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
					if (Client != null)
					{
						Client.Send(array, array.Length);
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "增加物品出错2 [" + Userid + "][" + UserName + "] 位置[" + 位置 + "] 数量[" + BitConverter.ToInt32(数量, 0) + "]" + ex.Message);
			}
		}

		public void 组队传送符提示(int id)
		{
			string hex = "AA55230001D001121614000106000078DC143C010000000100000009943577000000000000A65455AA";
			byte[] array = Converter.hexStringToByte(hex);
			Buffer.BlockCopy(BitConverter.GetBytes(id), 0, array, 19, 2);
			Buffer.BlockCopy(BitConverter.GetBytes(UserSessionID), 0, array, 5, 2);
			if (Client != null)
			{
				Client.Send(array, array.Length);
			}
		}

		public double[] getRateCuongHoa(double MinRate, double MaxRate, HcItimesClass BuaMayMan = null)
		{
			double[] array = new double[2]
			{
				MinRate,
				MaxRate
			};
			double num = (MaxRate - MinRate) / 100.0;
			if (FLD_VIP == 1)
			{
				array[0] += 100.0 * World.Vip合成率;
				array[1] += 100.0 * World.Vip合成率;
			}
			if (World.合成率 != 0.0)
			{
				array[0] += 100.0 * World.合成率;
				array[1] += 100.0 * World.合成率;
			}
			if (公有药品.ContainsKey(1008000312))
			{
				array[0] *= 1.05;
				array[1] *= 1.05;
			}
			if (BuaMayMan != null)
			{
				int num2 = BitConverter.ToInt32(BuaMayMan.Item_ID, 0);
				int num3 = World.checkLuckyItem(num2);
				array[0] += (double)num3 * num;
				array[1] += (double)num3 * num;
				GameMessage("BuÌa may mãìn: " + num3 + "%", 24);
			}
			return array;
		}
	}
}

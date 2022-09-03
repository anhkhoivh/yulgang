using DbClss;
using HelperTools;
using LinqSQL;
using Network;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace RxjhServer.RxjhServer
{
	public class World
	{
		public static int debugValue;

		public static int SizeDdos;

		public static ThreadSafeDictionary<int, Players> AllConnectedChars;

		public static ThreadSafeDictionary<int, Players> gclass11_3;

		public static int AllItmelog;

		public static bool AlWorldlog;

		public static int int_12580;

		public static int int_1140;

		public static string int_12581;

		public static int AtPort;

		public static int AutGc;

		public static List<IPAddress> BipList;

		public static List<DropClass> BossDrop;

		public static string Boss怪暴冰魄寒玉石防御;

		public static int Boss怪暴冰魄寒玉石类型设置;

		public static string Boss怪暴冰魄寒玉石武功防御;

		public static string Boss怪暴寒玉石;

		public static string Boss怪暴混元金刚石;

		public static string Boss怪暴金刚石;

		public static string Boss怪暴凝霜寒玉石防御;

		public static int Boss怪暴凝霜寒玉石类型设置;

		public static string Boss怪暴凝霜寒玉石武功防御;

		public static string Boss怪暴乾坤金刚石;

		public static string Boss怪暴热血石;

		public static string Boss怪暴神秘金刚石武功;

		public static string Boss怪暴神秘金刚石追伤;

		public static int Boss怪暴属性石;

		public static Connect Conn;

		public static Dictionary<string, DbClass> Db;

		public static List<DropClass> Drop;

		public static List<DropClass> DropGs;

		public static List<DropClass> DropJl;

		public static bool Droplog;

		public static EventClass EventClass;

		public static Dictionary<string, EventTopClass> EventTop;

		public static AtServerConnect GjServerConnect;

		public static ThreadSafeDictionary<int, 客户端IP地址> Iplist;

		public static Dictionary<int, ItmeClass> Itme;

		public static List<制作药品表> list制作药品表;

		public static ThreadSafeDictionary<long, 地面物品类> ItmeTeM;

		public static int Jllog;

		public static int JlMsg;

		public static List<KillClass> Kill;

		public static List<GiftcodeClass> GiftCode;

		public static List<GiftCodeRewardsClass> GiftCodeRewards;

		public static Dictionary<int, double> Level;

		public static ThreadSafeDictionary<int, NetState> List;

		public static double Locklist;

		public static double Locklist2;

		public static List<object> Locklist3;

		public static int Log;

		public static Queue MDisposed;

		public static Dictionary<int, MapClass> Map;

		public static Dictionary<int, MonSterClss> MonSter;

		public static List<MoveClass> Mover;

		public static List<NpcDropClass> NpcDrop;

		public static List<OpenClass> Open;

		public static int Pk等级差;

		public static int Pk掉等级;

		public static int Pk掉元宝;

		public static int Pk掉元宝系统回收量;

		public static int Pk掉装备;

		public static int Pk掉装备几率;

		public static int Pk掉装备善恶;

		public static int Pk开关;

		public static string[] Pk系统限制地图;

		public static bool Process;

		public static int Script;

		public static string ServerRegTime;

		public static double ServerVer;

		public static double ServerVerD;

		public static List<ShotClass> Shot;

		public static string SqlJl;

		public static Queue SqlPool;

		public static Dictionary<int, 武功类> TblKongfu;

		public static Dictionary<int, TBL_QUESTDROP> TblQuestDrop;

		public static int Tf;

		public static int Ver;

		public static string Vip地图;

		public static string Config_Reward_Online_Vip;

		public static double Vip合成率;

		public static double Vip经验倍数百分比;

		public static double Vip历练倍数百分比;

		public static int Vip上线公告;

		public static string Vip上线公告内容;

		public static int 七彩上线签名;

		public static string 七彩上线签名内容;

		public static int Vip线;

		public static Dictionary<int, double> Wxlever;

		public static Dictionary<int, 组队Class> PartyClass;

		public static int W组队Id;

		public static List<坐标Class> 安全区;

		public static float 安全区x坐标;

		public static float 安全区y坐标;

		public static int 安全区地图;

		public static int 安全区开关;

		public static string 百宝阁冰魄寒玉石防御;

		public static int 百宝阁冰魄寒玉石类型设置;

		public static string 百宝阁冰魄寒玉石武功防御;

		public static string 百宝阁初级奇玉石;

		public static string 百宝阁地址;

		public static string 百宝阁服务器ip;

		public static int 百宝阁服务器端口;

		public static string 百宝阁高级奇玉石;

		public static string 百宝阁寒玉石;

		public static string 百宝阁混元金刚石;

		public static string 百宝阁金刚石;

		public static string 百宝阁凝霜寒玉石防御;

		public static int 百宝阁凝霜寒玉石类型设置;

		public static string 百宝阁凝霜寒玉石武功防御;

		public static string 百宝阁乾坤金刚石;

		public static string 百宝阁热血石;

		public static string 百宝阁神秘金刚石武功;

		public static string 百宝阁神秘金刚石追伤;

		public static int 百宝阁属性石;

		public static Dictionary<int, 百宝阁类> 百宝阁属性物品类list;

		public static Dictionary<int, 百宝阁类> 百宝阁属性物品类list2;

		public static string 百宝阁中级奇玉石;

		public static int 版本切换;

		public static int 版本验证时间;

		public static Dictionary<int, 帮战Class> 帮战list;

		public static string 帮战获胜元宝金币数;

		public static int 帮战开关;

		public static string 帮战平分元宝金币数;

		public static string 帮战人数控制;

		public static int 帮战战斗时间;

		public static int 暴率;

		public static int 背包扩充开关;

		public static bool 查绑定非法物品;

		public static int 查非法物品;

		public static int 查非法物品操作;

		public static string 查看信息命令;

		public static int 查看装备开关;

		public static string 查时间命令;

		public static string 冲关地图;

		public static Dictionary<string, 冲关地图类> 冲关地图list;

		public static int 宠物攻击力倍数;

		public static string 创建门派所需物品id;

		public static int 创建门派需要等级;

		public static int 创建门派需要金钱;

		public static int 单个物品大小;

		public static int 登陆记录;

		public static int 登陆器模式;

		public static Dictionary<int, 等级奖励类> 等级奖励数据;

		public static string 地图锁定;

		public static string 短信充值是否开启;

		public static string 短信服务器webid;

		public static string 短信通道号码;

		public static string 短信业务号码;

		public static bool 断开连接;

		public static int 耳环加工一阶段增加生命;

		public static string 发公告;

		public static double 发送速度;

		public static int 发言等级;

		public static int 分解消耗的数量;

		public static bool 封ip;

		public static int 封包封号;

		public static int Debug;

		public static int Fixbugngoc130;

		public static double ExpParty;

		public static string 封号;

		public static int 服务器id;

		public static string ServerName;

		public static int Server_Group_ID;

		public static double 附魂合成率增加;

		public static string 附魂命令;

		public static int 复古模式是否启用;

		public static string 复制物品;

		public static string 高手怪暴冰魄寒玉石防御;

		public static int 高手怪暴冰魄寒玉石类型设置;

		public static string 高手怪暴冰魄寒玉石武功防御;

		public static string 高手怪暴寒玉石;

		public static string 高手怪暴混元金刚石;

		public static string 高手怪暴金刚石;

		public static string 高手怪暴凝霜寒玉石防御;

		public static int 高手怪暴凝霜寒玉石类型设置;

		public static string 高手怪暴凝霜寒玉石武功防御;

		public static string 高手怪暴乾坤金刚石;

		public static string 高手怪暴热血石;

		public static string 高手怪暴神秘金刚石武功;

		public static string 高手怪暴神秘金刚石追伤;

		public static int 高手怪暴属性石;

		public static Dictionary<int, 公告类> 公告;

		public static int 攻击距离;

		public static int 攻击确认模式;

		public static string Config_Reward_Online;

		public static int Time_Reward_Online;

		public static int Enable_Reward_Online;

		public static int Level_Reward_Online;

		public static int 怪物死亡触发器;

		public static bool 关闭连接;

		public static double 广播发送速度;

		public static string 过滤文字替换;

		public static double 合成率;

		public static string 合成率控制;

		public static int 获得经验等级差;

		public static int 记录保存天数;

		public static bool 加入过滤列表;

		public static int 加锁元宝数;

		public static string 监狱地图;

		public static int 江湖快报强化阶段;

		public static string 奖励冰魄寒玉石防御;

		public static int 奖励冰魄寒玉石类型设置;

		public static string 奖励冰魄寒玉石武功防御;

		public static string 奖励寒玉石;

		public static string 奖励混元金刚石;

		public static string 奖励金刚石;

		public static string 奖励凝霜寒玉石防御;

		public static int 奖励凝霜寒玉石类型设置;

		public static string 奖励凝霜寒玉石武功防御;

		public static string 奖励乾坤金刚石;

		public static string 奖励热血石;

		public static string 奖励神秘金刚石武功;

		public static string 奖励神秘金刚石追伤;

		public static int 奖励属性石;

		public static ScriptClass 脚本;

		public static double 接收速度;

		public static int 解锁元宝数;

		public static int 戒指加工一阶段增加攻击;

		public static string 进入公告;

		public static string 禁制pk地图;

		public static int 经验倍数;

		public static string 卡号自救命令;

		public static string 开始势力战;

		public static string 开箱冰魄寒玉石防御;

		public static int 开箱冰魄寒玉石类型设置;

		public static string 开箱冰魄寒玉石武功防御;

		public static string 开箱寒玉石;

		public static string 开箱混元金刚石;

		public static string 开箱金刚石;

		public static string 开箱凝霜寒玉石防御;

		public static int 开箱凝霜寒玉石类型设置;

		public static string 开箱凝霜寒玉石武功防御;

		public static string 开箱乾坤金刚石;

		public static string 开箱乾坤金刚石攻击;

		public static int 开箱乾坤金刚石类型设置;

		public static string 开箱乾坤金刚石武功;

		public static string 开箱热血石;

		public static int 开箱属性石;

		public static string 开箱子送元宝;

		public static int 乐师上线等级;

		public static string 离婚命令;

		public static string Config_Reward_Func_Offline_Vip;

		public static int Level_Func_Offline;

		public static int Map_Func_Offline;

		public static string Config_Reward_Func_Offline;

		public static int Time_Reward_Func_Offline;

		public static int Reward_Func_Offline;

		public static int Level_Reward_Func_Offline;

		public static string Command_Func_Offline;

		public static string Func_Offline_ItemID;

		public static int 历练倍数;

		public static int 每次消耗的数量;

		public static int 每次再造消耗设置;

		public static int 门甲组合消耗的数量;

		public static int 门甲组合消耗类型;

		public static int 披风分解消耗类型;

		public static double 披风强化一阶段概率;

		public static double 披风强化二阶段概率;

		public static double 披风强化三阶段概率;

		public static double 披风强化四阶段概率;

		public static double 披风强化五阶段概率;

		public static double 披风强化六阶段概率;

		public static double 披风强化七阶段概率;

		public static double 披风强化八阶段概率;

		public static int 披风强化消耗类型;

		public static string 披风强化总概率;

		public static int 披风组合消耗类型;

		public static string 普通怪暴冰魄寒玉石防御;

		public static int 普通怪暴冰魄寒玉石类型设置;

		public static string 普通怪暴冰魄寒玉石武功防御;

		public static string 普通怪暴寒玉石;

		public static string 普通怪暴混元金刚石;

		public static string 普通怪暴金刚石;

		public static string 普通怪暴凝霜寒玉石防御;

		public static int 普通怪暴凝霜寒玉石类型设置;

		public static string 普通怪暴凝霜寒玉石武功防御;

		public static string 普通怪暴乾坤金刚石;

		public static string 普通怪暴热血石;

		public static string 普通怪暴神秘金刚石武功;

		public static string 普通怪暴神秘金刚石追伤;

		public static int 普通怪暴属性石;

		public static int 启动职业气功热血石;

		public static double 气功百分比;

		public static int 气功是否有效;

		public static int 钱倍数;

		public static int 强化消耗的数量;

		public static string 清理绑定背包命令;

		public static string 清理背包命令;

		public static int 情侣开关;

		public static string 求婚命令;

		public static string 取消帮战元宝金币数;

		public static int 人物最高等级;

		public static string 删背包物品;

		public static string 商店冰魄寒玉石防御;

		public static int 商店冰魄寒玉石类型设置;

		public static string 商店冰魄寒玉石武功防御;

		public static string 商店寒玉石;

		public static string 商店混元金刚石;

		public static string 商店金刚石;

		public static string 商店凝霜寒玉石防御;

		public static int 商店凝霜寒玉石类型设置;

		public static string 商店凝霜寒玉石武功防御;

		public static string 商店乾坤金刚石;

		public static string 商店热血石;

		public static string 商店神秘金刚石武功;

		public static string 商店神秘金刚石追伤;

		public static int 商店属性石;

		public static int 上线属性提示开关;

		public static int 上线送礼包是否开启;

		public static int 上线送礼包套装;

		public static string 申请帮战元宝金币数;

		public static string 升级会员命令;

		public static string 升级会员需要属性;

		public static int 升天技能等级加成;

		public static double 升天历练倍数;

		public static Dictionary<int, 升天气功总类> 升天气功List;

		public static int 狮子吼id;

		public static Queue 狮子吼List;

		public static int 狮子吼最大数;

		public static Dictionary<int, 石头属性调整类> 石头属性调整;

		public static int 时间系统开关;

		public static Dictionary<int, 时间药类> 时间药;

		public static int 时间药开关;

		public static int 世界时间;

		public static string 势力战回城坐标;

		public static int 势力战奖励类型;

		public static string 势力战奖励属性;

		public static int 势力战奖励套装;

		public static string 势力战奖励物品;

		public static int 势力战进程;

		public static int 势力战开启分;

		public static int 势力战开启秒;

		public static int 势力战开启小时;

		public static int 势力战时间;

		public static int 势力战是否开启;

		public static int 势力战邪分数;

		public static int 势力战邪人数;

		public static int 势力战正分数;

		public static int 势力战正人数;

		public static int 是否加密;

		public static int 是否加密2;

		public static int 是否开启等级奖励;

		public static int 是否开启狂歌模式;

		public static int Enable_Func_Offline;

		public static int 是否开启龙行模式;

		public static int 是否开启武勋系统;

		public static int 是否开启新元宝商店;

		public static int 是否开启元宝商店;

		public static int 是否启用跑卡技能;

		public static int Enable_Online_Bonus;

		public static int 是否开启转生次数奖励;

		public static int 是否启动披风强化;

		public static int 是否启用会员升级;

		public static int 是否启用异常出血;

		public static int 手工附魂最高阶段;

		public static int 属性扩展是否开启;

		public static int Time_Use_Item;

		public static string 刷怪;

		public static string 刷历练;

		public static string 刷钱;

		public static string 刷武勋;

		public static double 死亡掉落经验调整;

		public static string 死亡回城地图坐标;

		public static string 死亡减少武勋数量;

		public static int 死亡经验掉落是否开启;

		public static List<套装属性类> 套装;

		public static int 套装发送开启;

		public static Dictionary<int, 套装列表类> 套装列表;

		public static string 踢人;

		public static double 天佑之气百分比;

		public static double FixDamage;

		public static int 外挂pk时间;

		public static Dictionary<string, 文本兑换类> 文本兑换;

		public static double FIX_ULPT;

		public static double FIX_PILL_EXP;

		public static int 武功防御力控制;

		public static int 武功攻击力控制;

		public static int 武器附魂增加属性数量;

		public static int 武勋保护等级;

		public static string[] 武勋阶段1;

		public static string[] 武勋阶段2;

		public static string[] 武勋阶段3;

		public static string[] 武勋阶段4;

		public static string[] 武勋阶段5;

		public static string[] 武勋阶段6;

		public static string[] 武勋阶段7;

		public static string[] 武勋阶段8;

		public static int 物品兑换lua脚本是否开启;

		public static Dictionary<int, 物品兑换类> 物品兑换数据;

		public static int 物品记录;

		public static List<检查物品类> 物品检查;

		public static string 物品锁定;

		public static int 物品最高防御值;

		public static int 物品最高攻击值;

		public static int 物品最高合成值;

		public static int 物品最高回避值;

		public static int 物品最高命中值;

		public static int 物品最高内功值;

		public static int 物品最高气功值;

		public static int 物品最高生命值;

		public static int 物品最高武功值;

		public static int 吸魂机率;

		public static int 吸魂开关;

		public static string 吸魂随机数量;

		public static string 系统回收量;

		public static int 限制转生次数;

		public static Dictionary<int, 箱子送元宝类> 箱子送元宝;

		public static int 项链加工一阶段增加防御;

		public static string 新手上线奖励;

		public static int 新手上线奖励是否开启;

		public static string 信任连接ip;

		public static string 刑满释放公告;

		public static 帮派战_血战 血战;

		public static int 验证服务器log;

		public static string 药品a;

		public static string 药品b;

		public static string 药品c;

		public static string 药品d;

		public static string 药品e;

		public static string 药品f;

		public static string 药品g;

		public static string 药品h;

		public static BossClass 野外boss;

		public static string 野外boss配置;

		public static int 衣服附魂增加属性数量;

		public static int 医生回气疗伤加血量;

		public static int 医生聚气疗伤加血量;

		public static int 医生运气疗伤加血量;

		public static List<坐标Class> Map_Move;

		public static string 移动传送;

		public static string 移动命令;

		public static string Setgm;

		public static string 隐身;

		public static int 游戏登陆端口最大连接时间数;

		public static int 游戏登陆端口最大连接数;

		public static int 游戏服务器端口;

		public static int 游戏服务器端口2;

		public static int 元宝合成;

		public static int IdItemX2;

		public static int IdItemX3;

		public static int 元宝检测;

		public static int 允许多开数量;

		public static int VersionClient;

		public static int Newversion;

		public static int 戒指刻字需要金币;

		public static int ThuPhiVoHuan8;

		public static int CreateNewJob;

		public static int AlphaTest;

		public static int CuonghoaMatItem;

		public static int Open_Auto_GiftCode;

		public static int Sudocungphai;

		public static int FIXLAG;

		public static int AFKTLC;

		public static int Eventx2;

		public static int Eventx3;

		public static int AoChoangThang;

		public static int 允许物品出售最大元宝数量;

		public static string 再造寒玉石防御;

		public static string 再造寒玉石回避;

		public static string 再造寒玉石内功;

		public static string 再造寒玉石生命;

		public static string 再造寒玉石武防;

		public static string 再造金刚石攻击;

		public static string 再造金刚石命中;

		public static string 再造金刚石生命;

		public static string 再造金刚石武功;

		public static string 再造金刚石追伤;

		public static Dictionary<int, 在线时间奖励类> 在线时间奖励数据;

		public static string[] 增加防御药品;

		public static string[] 增加攻击药品;

		public static string[] 增加生命药品;

		public static string[] Config_Auto_GiftCode;

		public static string 帐号验证服务器ip;

		public static int 帐号验证服务器端口;

		public static Dictionary<int, clsItemCraft> 制作物品列表;

		public static bool 主Socket;

		public static int 转生次数领奖控制;

		public static Dictionary<int, 转生次数类> 转生次数数据;

		public static int 转生公告;

		public static string 转生公告内容;

		public static int 转生回落等级;

		public static string 转生获得属性;

		public static int 转生奖励类型;

		public static int 转生奖励数量;

		public static int 转生奖励套装;

		public static string 转生奖励物品;

		public static int 转生降落几转;

		public static string 转生命令;

		public static int 转生需要等级;

		public static int 转生需要几转;

		public static Dictionary<int, TransferAttributes> 转职属性数据;

		public static int 装备加解锁开关;

		public static Dictionary<int, 装备检测类> 装备检测list;

		public static int 装备最大数;

		public static string 追加状态;

		public static string 追踪;

		public static int 自动存档;

		public static bool 自动开启连接;

		public static int 自动连接时间;

		public static int 组队级别限制;

		public static int 组合消耗的数量;

		public static int 最大气功数;

		public static long 最大钱数;

		public static int 最大在线;

		public static int 坐牢恢复善恶值;

		public static string 坐牢回城坐标;

		public static string 坐牢杀人公告;

		public static int 坐牢善恶;

		public static int 坐牢善恶恢复间隔;

		public static int 坐牢系统是否开启;

		public static int EventX2ExpStatus;

		public static int EventX3ExpStatus;

		public static int AutoTbBaotri;

		public static string TextTbBaotri;

		public static int Numv13;

		public static string[] DelayDisableNpc;

		public static string[] DamageComBoQuyenSu;

		static World()
		{
			debugValue = 800;
			SizeDdos = 6900;
			old_acctor_mc();
		}

		public World()
		{
			System.Timers.Timer timer = new System.Timers.Timer(1000.0);
			timer.Elapsed += WorldEventTimer;
			timer.AutoReset = true;
			timer.Enabled = true;
			System.Timers.Timer timer2 = new System.Timers.Timer(500.0);
			timer2.Elapsed += WorldNpcEventTimer;
			timer2.AutoReset = true;
			timer2.Enabled = true;
			System.Timers.Timer timer3 = new System.Timers.Timer(5000.0);
			timer3.Elapsed += WorldEventTimer5Sec;
			timer3.AutoReset = true;
			timer3.Enabled = true;
			System.Timers.Timer timer4 = new System.Timers.Timer(60000.0);
			timer4.Elapsed += WorldEventTimer1minute;
			timer4.AutoReset = true;
			timer4.Enabled = true;
		}

		private void WorldEventTimer5Sec(object sender, ElapsedEventArgs e)
		{
			foreach (Players value2 in AllConnectedChars.Values)
			{
				if (!value2.异常状态.ContainsKey(20))
				{
					value2.FLD_TANGDEF_CAMSU = 0.0;
					value2.UpdatePowersAndStatus();
					value2.Update_HP_MP_SP();
				}
				if (!value2.异常状态.ContainsKey(22))
				{
					value2.FLD_TRUDAME_CAMSU = 0.0;
					value2.UpdatePowersAndStatus();
					value2.Update_HP_MP_SP();
				}
				if (!value2.异常状态.ContainsKey(25))
				{
					value2.FLD_TRUDEF_CAMSU = 0.0;
					value2.UpdatePowersAndStatus();
					value2.Update_HP_MP_SP();
				}
				if (!value2.异常状态.ContainsKey(9))
				{
					value2.FLD_TRUDEF_NINJA = 0.0;
					value2.UpdatePowersAndStatus();
					value2.Update_HP_MP_SP();
				}
				if (!value2.Show_Pic_Class.ContainsKey(801302))
				{
					value2.FLD_TRUDEF_801302 = 0.0;
					value2.UpdatePowersAndStatus();
					value2.Update_HP_MP_SP();
				}
				int num = 0;
				if (value2.bPartyWithCouple && value2.Party_ID != 0 && value2.FLD_Couple_Level <= 4)
				{
					if (PartyClass.TryGetValue(value2.Party_ID, out 组队Class value))
					{
						if (value.List_Party.Count == 2)
						{
							if (value2.coupleEffectExp != 0.1)
							{
								num = 1;
							}
						}
						else if (value.List_Party.Count > 2 && value.List_Party.Count <= 8)
						{
							if (value2.coupleEffectExp != 0.05)
							{
								num = 2;
							}
						}
						else
						{
							num = 3;
						}
					}
				}
				else if (value2.coupleEffectExp != 0.0)
				{
					num = 3;
				}
				switch (num)
				{
				case 1:
					value2.coupleEffectExp = 0.1;
					value2.coupleEffectAttack = 0.03;
					value2.coupleEffectDefense = 0.03;
					value2.coupleEffectEvasion = 0.03;
					value2.coupleEffectAccuracy = 0.03;
					value2.coupleEffectSkillDefense = 0.03;
					value2.coupleEffectHealth = 0.03;
					value2.coupleEffectChi = 0.03;
					value2.GameMessage("ChiÒ sôì côòng thêm cuÒa cãòp ðôi ðýõòc 100%!", 7);
					value2.UpdatePowersAndStatus();
					value2.Update_HP_MP_SP();
					break;
				case 2:
					value2.coupleEffectExp = 0.05;
					value2.coupleEffectAttack = 0.015;
					value2.coupleEffectDefense = 0.015;
					value2.coupleEffectEvasion = 0.015;
					value2.coupleEffectAccuracy = 0.015;
					value2.coupleEffectSkillDefense = 0.015;
					value2.coupleEffectHealth = 0.015;
					value2.coupleEffectChi = 0.015;
					value2.GameMessage("ChiÒ sôì côòng thêm cuÒa cãòp ðôi giaÒm 50%!", 7);
					value2.UpdatePowersAndStatus();
					value2.Update_HP_MP_SP();
					break;
				case 3:
					value2.coupleEffectExp = 0.0;
					value2.coupleEffectAttack = 0.0;
					value2.coupleEffectDefense = 0.0;
					value2.coupleEffectEvasion = 0.0;
					value2.coupleEffectAccuracy = 0.0;
					value2.coupleEffectSkillDefense = 0.0;
					value2.coupleEffectHealth = 0.0;
					value2.coupleEffectChi = 0.0;
					value2.GameMessage("ChiÒ sôì côòng thêm cuÒa cãòp ðôi ðaÞ mâìt!", 7);
					value2.UpdatePowersAndStatus();
					value2.Update_HP_MP_SP();
					break;
				}
			}
		}

		private void WorldEventTimer1minute(object sender, ElapsedEventArgs e)
		{
			if (服务器id == 2 && (DateTime.Now.DayOfWeek == DayOfWeek.Friday || DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday))
			{
				if (DateTime.Now.Hour == 20 && DateTime.Now.Minute == 0)
				{
					List<NpcClass> list = new List<NpcClass>();
					foreach (MapClass value in Map.Values)
					{
						if (value.MapID == 101)
						{
							foreach (NpcClass value2 in value.npcTemplate.Values)
							{
								if (value2.FldPid == 15900)
								{
									list.Add(value2);
								}
							}
						}
					}
					Random random = new Random();
					switch (random.Next(1, 3))
					{
					case 1:
						AddNpc(15983, 1924f, 78f, 5001);
						AddNpc(15983, 1200f, -900f, 5001);
						break;
					case 2:
						AddNpc(15983, 2000f, -1300f, 5001);
						AddNpc(15983, -180f, -1700f, 5001);
						break;
					default:
						AddNpc(15983, 700f, -1000f, 5001);
						AddNpc(15983, -750f, -1900f, 5001);
						break;
					}
					foreach (Players value3 in AllConnectedChars.Values)
					{
						value3.GameMessage("BOSS thâÌn thuì xuâìt hiêòn taòi Bãìc HaÒi", 8);
					}
				}
				else if (DateTime.Now.Hour == 19 && DateTime.Now.Minute == 55)
				{
					foreach (Players value4 in AllConnectedChars.Values)
					{
						value4.GameMessage("Sau 5 phuìt nýÞa seÞ xuâìt hiêòn BOSS", 8);
						value4.Packet_Countdown(300);
					}
				}
			}
			if (服务器id == 2 && (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday || DateTime.Now.DayOfWeek == DayOfWeek.Wednesday || DateTime.Now.DayOfWeek == DayOfWeek.Thursday))
			{
				List<NpcClass> list = new List<NpcClass>();
				foreach (MapClass value5 in Map.Values)
				{
					if (value5.MapID == 101)
					{
						foreach (NpcClass value6 in value5.npcTemplate.Values)
						{
							if (value6.FldPid == 15900)
							{
								list.Add(value6);
							}
						}
					}
				}
				if (DateTime.Now.Hour == 19 && DateTime.Now.Minute == 35)
				{
					foreach (Players value7 in AllConnectedChars.Values)
					{
						value7.GameMessage("Sau 15 phuìt xuâìt hiêòn BOSS ðõòt 2 ", 8);
						value7.Packet_Countdown(900);
					}
					AddNpc(15213, 160f, 706f, 101);
					AddNpc(15213, -1050f, 200f, 101);
					AddNpc(15213, 948f, -1870f, 101);
					AddNpc(15213, 990f, -966f, 101);
					AddNpc(15213, -661f, 1771f, 101);
					AddNpc(15213, -1778f, 1950f, 101);
					AddNpc(15214, 800f, -1000f, 5001);
					AddNpc(15214, -500f, -1950f, 5001);
					AddNpc(15214, -1840f, -1345f, 5001);
					AddNpc(15214, -642f, 873f, 5001);
					AddNpc(15214, -310f, 2036f, 5001);
				}
				else if (DateTime.Now.Hour == 19 && DateTime.Now.Minute == 50)
				{
					foreach (Players value8 in AllConnectedChars.Values)
					{
						value8.GameMessage("Sau 15 phuìt xuâìt hiêòn BOSS ðõòt 3 ", 8);
						value8.Packet_Countdown(900);
					}
					AddNpc(15214, -2155f, 208f, 101);
					AddNpc(15214, -1683f, -607f, 101);
					AddNpc(15214, -1430f, -1574f, 101);
					AddNpc(15214, -226f, -446f, 101);
					AddNpc(15214, 1639f, 695f, 101);
					AddNpc(15214, 1695f, 1496f, 101);
					AddNpc(15136, -1820f, 424f, 5001);
					AddNpc(15136, -184f, -437f, 5001);
					AddNpc(15136, -439f, -1067f, 5001);
					AddNpc(15136, -61f, -1578f, 5001);
					AddNpc(15136, -805f, -1973f, 5001);
				}
				else if (DateTime.Now.Hour == 20 && DateTime.Now.Minute == 5)
				{
					AddNpc(15136, 2190f, 1779f, 101);
					AddNpc(15136, 1496f, 2162f, 101);
					AddNpc(15136, -216f, 2092f, 101);
					AddNpc(15136, -500f, 1390f, 101);
					AddNpc(15136, 24f, 502f, 101);
					AddNpc(15136, -147f, 29f, 101);
					AddNpc(15215, 2054f, -1300f, 5001);
					AddNpc(15215, 1287f, -846f, 5001);
					AddNpc(15215, 867f, 72f, 5001);
					AddNpc(15215, -199f, 1641f, 5001);
					AddNpc(15215, -1813f, 918f, 5001);
				}
				if (DateTime.Now.Hour == 19 && DateTime.Now.Minute == 30)
				{
					foreach (Players value9 in AllConnectedChars.Values)
					{
						value9.GameMessage("Sau 5 phuìt Boss ThuÒ ThaÌnh xuâìt hiêòn", 8);
						value9.Packet_Countdown(300);
					}
				}
			}
			List<string> list2 = new List<string>();
			foreach (Players value10 in AllConnectedChars.Values)
			{
				if (时间系统开关 != 0)
				{
					value10.服务器时间();
				}
				value10.set时间物品();
				if (value10.FLD_Couple_Exp > 0 && value10.FLD_Couple_Exp <= 35000 && !value10.Show_Pic_Class.ContainsKey(1000000891) && !value10.Show_Pic_Class.ContainsKey(1000000892) && !value10.Show_Pic_Class.ContainsKey(1000000893))
				{
					Players players = value10.Find_Player(value10.FLD_Couple_Name);
					if (players != null && !list2.Contains(value10.UserName) && !list2.Contains(players.UserName))
					{
						list2.Add(value10.UserName);
						list2.Add(players.UserName);
						if (value10.FLD_Couple_Level > 4)
						{
							value10.FLD_Couple_Exp--;
							players.FLD_Couple_Exp = value10.FLD_Couple_Exp;
							value10.GameMessage("GiaÒm 1 ðiêÒm cãòp ðôi. Tãòng hoa ðêÒ không biò giaÒm khi online cuÌng ngýõÌi yêu!");
							players.GameMessage("GiaÒm 1 ðiêÒm cãòp ðôi. Tãòng hoa ðêÒ không biò giaÒm khi online cuÌng ngýõÌi yêu!");
							value10.UpdateRankCouple();
							players.UpdateRankCouple();
						}
						else if (DateTime.Now.Minute % 10 == 0)
						{
							value10.FLD_Couple_Exp--;
							players.FLD_Couple_Exp = value10.FLD_Couple_Exp;
							value10.GameMessage("GiaÒm 1 ðiêÒm cãòp ðôi. Tãòng hoa ðêÒ không biò giaÒm khi online cuÌng ngýõÌi yêu!");
							players.GameMessage("GiaÒm 1 ðiêÒm cãòp ðôi. Tãòng hoa ðêÒ không biò giaÒm khi online cuÌng ngýõÌi yêu!");
							value10.UpdateRankCouple();
							players.UpdateRankCouple();
						}
					}
				}
				if (EventX2ExpStatus == 1 || (value10.Player_Sex == 2 && DateTime.Now.Day == 8 && DateTime.Now.Month == 3))
				{
					value10.Event_x2(value10);
				}
				if (EventX3ExpStatus == 1 || (value10.Player_Sex == 2 && DateTime.Now.Day == 8 && DateTime.Now.Month == 3))
				{
					value10.Event_x3(value10);
				}
				if (value10.Player_FLD_Map == 801 && 势力战进程 == 3)
				{
					if ((int)DateTime.Now.Subtract(value10.time_AFK).TotalMilliseconds > 100000)
					{
						value10.GameMessage("Phaìt hiêòn nhân vâòt AFK trong TLC!", 7);
						value10.Move(418f, 1518f, 15f, 101);
						EventTop.Remove(value10.UserName);
					}
					else if ((int)DateTime.Now.Subtract(value10.time_AFK).TotalMilliseconds > 70000)
					{
						value10.GameMessage("Baòn sãìp biò ðaì ra khoÒi TLC viÌ AFK! (3)", 7);
					}
					else if ((int)DateTime.Now.Subtract(value10.time_AFK).TotalMilliseconds > 30000)
					{
						value10.GameMessage("Baòn sãìp biò ðaì ra khoÒi TLC viÌ AFK! (2)", 7);
					}
					else if ((int)DateTime.Now.Subtract(value10.time_AFK).TotalMilliseconds > 30000)
					{
						value10.GameMessage("Baòn sãìp biò ðaì ra khoÒi TLC viÌ AFK! (1)", 7);
					}
				}
			}
		}

		private void WorldNpcEventTimer(object sender, ElapsedEventArgs e)
		{
			try
			{
				foreach (MapClass value in Map.Values)
				{
					foreach (NpcClass value2 in value.npcTemplate.Values)
					{
						if (value2.CheckPlaylist() && !value2.Npc死亡)
						{
							if (value2.enableNpcMove && DateTime.Now.Subtract(value2.timeNpcMove).TotalMilliseconds > (double)value2.delayNpcMove && value2.FldPid != 15900)
							{
								value2.NPC_Move();
							}
							else if (value2.enableNpcAttack && DateTime.Now.Subtract(value2.timeNpcAttack).TotalMilliseconds > (double)value2.delayNpcAttack && value2.FldPid != 15900 && !value2.异常状态.ContainsKey(700314))
							{
								value2.NPC_Attack();
							}
						}
						else if (!value2.Npc死亡 && (value2.RxjhHp < 0 || value2.RxjhHp > value2.MaxRxjhHp))
						{
							value2.NPC_Die();
						}
					}
				}
			}
			catch
			{
			}
		}

		public void GameMessage(string msg, int msgType = 50, string name = "")
		{
			msg = msg.Substring(0, Math.Min(msg.Length, 120));
			if (文本兑换.TryGetValue(msg, out 文本兑换类 value))
			{
				msg = value.英文;
			}
			if (文本兑换.TryGetValue(name, out 文本兑换类 value2))
			{
				name = value2.英文;
			}
			PacketData packetData = new PacketData();
			if (Newversion >= 16)
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
		}

		private void WorldEventTimer(object sender, ElapsedEventArgs e)
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable("SELECT account,GhiChu, SUM(Cash) AS Cash FROM TBL_ADDCASH GROUP BY account,GhiChu", "rxjhaccount");
			if (dBToDataTable != null)
			{
				ThreadSafeDictionary<string, int> threadSafeDictionary = new ThreadSafeDictionary<string, int>();
				string str = "";
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					string text = dBToDataTable.Rows[i]["account"].ToString();
					int value = (int)dBToDataTable.Rows[i]["Cash"];
					str = dBToDataTable.Rows[i]["GhiChu"].ToString();
					threadSafeDictionary.Add(text.ToLower(), value);
				}
				foreach (Players value2 in AllConnectedChars.Values)
				{
					int value = 0;
					if (threadSafeDictionary.TryGetValue(value2.Userid.ToLower(), out value))
					{
						int fLD_RXPIONT = value2.FLD_RXPIONT;
						logo.logaddcash("REQUEST! : " + value2.Userid + " - " + value + " @CASH");
						DBA.ExeSqlCommand($"DELETE TBL_ADDCASH WHERE account='{value2.Userid}'", "rxjhaccount");
						value2.GameMessage("Baòn ðang sõÒ hýÞu: " + value2.FLD_RXPIONT + " @CASH", 7);
						value2.Add_Del_Rxpiont(value, 1);
						value2.GameMessage(value2.UserName + "@ Naòp TheÒ Qua: " + str + " ThaÌnh Công", 8);
						value2.GameMessage("Baòn ðang sõÒ hýÞu: " + value2.FLD_RXPIONT + " @CASH", 7);
						logo.logaddcash("=> SUCCESS! : " + value2.Userid + " - " + value + " @CASH (" + fLD_RXPIONT + " + " + value + " = " + value2.FLD_RXPIONT + ")");
						value2.Save_data_Rxpiont();
						value2.SaveDataCharacter();
					}
				}
				threadSafeDictionary.Clear();
			}
			DataTable dBToDataTable2 = DBA.GetDBToDataTable("SELECT account,GhiChu, SUM(Cash) AS Cash FROM TBL_TRUCASH GROUP BY account,GhiChu", "rxjhaccount");
			if (dBToDataTable2 != null)
			{
				ThreadSafeDictionary<string, int> threadSafeDictionary = new ThreadSafeDictionary<string, int>();
				string str = "";
				for (int i = 0; i < dBToDataTable2.Rows.Count; i++)
				{
					string text = dBToDataTable2.Rows[i]["account"].ToString();
					int value = (int)dBToDataTable2.Rows[i]["Cash"];
					str = dBToDataTable2.Rows[i]["GhiChu"].ToString();
					threadSafeDictionary.Add(text.ToLower(), value);
				}
				foreach (Players value3 in AllConnectedChars.Values)
				{
					int value = 0;
					if (threadSafeDictionary.TryGetValue(value3.Userid.ToLower(), out value))
					{
						int fLD_RXPIONT = value3.FLD_RXPIONT;
						DBA.ExeSqlCommand($"DELETE TBL_TRUCASH WHERE account='{value3.Userid}'", "rxjhaccount");
						value3.Add_Del_Rxpiont1(value, 1);
						value3.Save_data_Rxpiont();
						value3.SaveDataCharacter();
					}
				}
				threadSafeDictionary.Clear();
			}
			DataTable dBToDataTable3 = DBA.GetDBToDataTable("SELECT * FROM ADDITEM", "baibao");
			if (dBToDataTable3 != null)
			{
				for (int i = 0; i < dBToDataTable3.Rows.Count; i++)
				{
					int num = (int)dBToDataTable3.Rows[i]["id"];
					string text = dBToDataTable3.Rows[i]["FLD_ID"].ToString();
					int 物品ID = (int)dBToDataTable3.Rows[i]["FLD_PID"];
					int 物品属性 = (int)dBToDataTable3.Rows[i]["FLD_MAGIC1"];
					int 物品属性2 = (int)dBToDataTable3.Rows[i]["FLD_MAGIC2"];
					int 物品属性3 = (int)dBToDataTable3.Rows[i]["FLD_MAGIC3"];
					int 物品属性4 = (int)dBToDataTable3.Rows[i]["FLD_MAGIC4"];
					int 物品属性5 = (int)dBToDataTable3.Rows[i]["FLD_MAGIC5"];
					int 初级附魂 = (int)dBToDataTable3.Rows[i]["FLD_初级附魂"];
					int 进化 = (int)dBToDataTable3.Rows[i]["FLD_进化"];
					int 中级附魂 = (int)dBToDataTable3.Rows[i]["FLD_中级附魂"];
					int 绑定 = (int)dBToDataTable3.Rows[i]["FLD_是否绑定"];
					int 使用天数 = (int)dBToDataTable3.Rows[i]["FLD_DAYS"];
					bool flag = false;
					foreach (Players value4 in AllConnectedChars.Values)
					{
						if (value4.Userid.ToLower() == text)
						{
							int num2 = value4.Find_Package_Empty(value4);
							if (num2 == -1)
							{
								value4.GameMessage("Không coÌn chôÞ trôìng !", 7);
							}
							else
							{
								string text2 = value4.百宝增加物品带属性(物品ID, num2, 1, 物品属性, 物品属性2, 物品属性3, 物品属性4, 物品属性5, 初级附魂, 中级附魂, 进化, 绑定, 使用天数);
								value4.Save_data_Rxpiont();
								value4.Update_Item_In_Bag();
								flag = true;
							}
							break;
						}
					}
					if (flag)
					{
						DBA.ExeSqlCommand($"DELETE ADDITEM WHERE id='{num}'", "baibao");
					}
				}
			}
			if (势力战是否开启 == 1 && getTypeWar801() != -1 && DateTime.Now.Hour == 势力战开启小时 && DateTime.Now.Minute == 势力战开启分 && DateTime.Now.Second == 势力战开启秒)
			{
				if (EventClass != null)
				{
					EventClass.Dispose();
				}
				EventClass = new EventClass();
				foreach (Players value5 in AllConnectedChars.Values)
				{
					if (value5.Player_Job_Level >= 2)
					{
						value5.Packet_Start_Time_War_Class_All();
					}
				}
			}
			if (DateTime.Now.Hour == 0 && DateTime.Now.Minute == 0 && DateTime.Now.Second >= 0 && DateTime.Now.Second <= 3)
			{
				DBA.ExeSqlCommand("UPDATE TBL_XWWL_Char SET FLD_GETWX=0, FLD_QlDuMax=0, FLD_DayQuest=''");
				foreach (Players value6 in AllConnectedChars.Values)
				{
					value6.每日武勋 = 0;
					value6.FLD_DayQuest_Array = "";
					value6.FLD_Couple_ExpMax = 0;
					value6.Update_Character_Wear_Item();
					value6.Initialize_Equip_Item();
					value6.UpdatePowersAndStatus();
				}
				UpdateGuildPoint();
				if (物品记录 == 1)
				{
					DBA.ExeSqlCommand("DELETE FROM 物品记录 WHERE  DateDiff(dd,时间,getdate())>" + 记录保存天数);
				}
				if (登陆记录 == 1)
				{
					DBA.ExeSqlCommand("DELETE FROM 登陆记录 WHERE  DateDiff(dd,时间,getdate())>" + 记录保存天数);
				}
				DBA.ExeSqlCommand("DELETE FROM LogPK WHERE  DateDiff(dd,Thoigian,getdate())> 30");
				DBA.ExeSqlCommand("DELETE FROM Log_DeleteItem WHERE  DateDiff(dd,Thoigian,getdate())> 30");
				DBA.ExeSqlCommand("DELETE FROM TBL_传书系统 WHERE  DateDiff(dd,传书时间,getdate()) > 7");
			}
			if (EventX3ExpStatus == 0 && Eventx2 != 0)
			{
				EventX3ExpStatus = 1;
				foreach (Players value7 in AllConnectedChars.Values)
				{
					value7.Event_x3(value7);
				}
			}
			else if (DateTime.Now.Hour == 23 && DateTime.Now.Minute == 55 && DateTime.Now.Second == 0)
			{
				if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
				{
					foreach (Players value8 in AllConnectedChars.Values)
					{
						value8.GameMessage("Sau 5 phuìt nýÞa seÞ bãìt ðâÌu nhân ðôi kinh nghiêòm.", 8, ServerName);
						value8.Packet_Countdown(300);
					}
				}
			}
			else if (EventX3ExpStatus == 1 && Eventx2 == 0 && DateTime.Now.DayOfWeek != DayOfWeek.Saturday)
			{
				EventX3ExpStatus = 0;
				foreach (Players value9 in AllConnectedChars.Values)
				{
					if (value9.Show_Pic_Class.ContainsKey(IdItemX3))
					{
						value9.Show_Pic_Class[IdItemX3].EndEvent();
					}
				}
			}
			else if (EventX3ExpStatus == 0 && DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
			{
				EventX3ExpStatus = 1;
				foreach (Players value10 in AllConnectedChars.Values)
				{
					value10.Event_x3(value10);
				}
			}
			if (EventX2ExpStatus == 0 && Eventx2 != 0)
			{
				EventX2ExpStatus = 1;
				foreach (Players value11 in AllConnectedChars.Values)
				{
					value11.Event_x2(value11);
				}
			}
			else if (DateTime.Now.Hour == 23 && DateTime.Now.Minute == 55 && DateTime.Now.Second == 0)
			{
				if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
				{
					foreach (Players value12 in AllConnectedChars.Values)
					{
						value12.GameMessage("Sau 5 phuìt nýÞa seÞ kêìt thuìc nhân ðôi kinh nghiêòm.", 8, ServerName);
						value12.Packet_Countdown(300);
					}
				}
			}
			else if (EventX2ExpStatus == 1 && Eventx2 == 0 && DateTime.Now.DayOfWeek != 0)
			{
				EventX2ExpStatus = 0;
				foreach (Players value13 in AllConnectedChars.Values)
				{
					if (value13.Show_Pic_Class.ContainsKey(IdItemX2))
					{
						value13.Show_Pic_Class[IdItemX2].EndEvent();
					}
				}
			}
			else if (EventX2ExpStatus == 0 && DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
			{
				EventX2ExpStatus = 1;
				foreach (Players value14 in AllConnectedChars.Values)
				{
					value14.Event_x2(value14);
				}
			}
			if (Open_Auto_GiftCode == 0)
			{
				return;
			}
			int num3 = 0;
			string[] array;
			while (true)
			{
				if (num3 < Config_Auto_GiftCode.Length)
				{
					array = Config_Auto_GiftCode[num3].Split(',');
					if (int.Parse(array[0]) == DateTime.Now.Hour + 1 && DateTime.Now.Minute == 55 && DateTime.Now.Second == 0 && array.Length == 4)
					{
						foreach (Players value15 in AllConnectedChars.Values)
						{
							value15.Packet_Countdown(300);
							value15.GameMessage("SýÒ duòng lêònh: \"!giftcode [CODE]\" ðêÒ nhâòp giftcode", 22);
							value15.GameMessage("Sau 5 phuìt nýÞa seÞ phaìt giftcode! SýÒ duòng lêònh: \"!giftcode [CODE]\" ðêÒ nhâòp giftcode", 8);
							value15.GameMessage("Viì duò: \"!giftcode ABcDe512Fgh\" ðêÒ nhâòp giftcode [ABcDe512Fgh]", 22);
						}
					}
					if (int.Parse(array[0]) == DateTime.Now.Hour && DateTime.Now.Minute == 0 && DateTime.Now.Second == 0 && array.Length == 4)
					{
						break;
					}
					num3++;
					continue;
				}
				return;
			}
			string text3 = "";
			for (int j = 0; j < int.Parse(array[1]); j++)
			{
				GiftcodeClass giftcodeClass = new GiftcodeClass();
				giftcodeClass.Type = new Random(GetRandomSeed()).Next(int.Parse(array[2]), int.Parse(array[3]));
				giftcodeClass.GiftCode = Get_RandomGiftCode();
				GiftCode.Add(giftcodeClass);
				DBA.ExeSqlCommand(string.Format("INSERT INTO GiftCode(GiftCode,Type)VALUES ('{0}','{1}')", new object[2]
				{
					giftcodeClass.GiftCode,
					giftcodeClass.Type
				}), "PublicDb");
				text3 = text3 + " [" + giftcodeClass.GiftCode + "] ";
			}
			foreach (Players value16 in AllConnectedChars.Values)
			{
				value16.GameMessage("SýÒ duòng lêònh: \"!giftcode [CODE]\" ðêÒ nhâòp giftcode", 22);
				value16.GameMessage("Viì duò: \"!giftcode ABcDe512Fgh\" ðêÒ nhâòp giftcode [ABcDe512Fgh]", 22);
				value16.GameMessage(text3, 8);
				value16.GameMessage(text3, 22);
				value16.GameMessage(text3, 7);
				value16.GameMessage(text3, 0);
			}
		}

		public static int AddBossEveNpc(int npcid, float x, float y, int mapp)
		{
			try
			{
				if (!MonSter.TryGetValue(npcid, out MonSterClss value))
				{
					return 0;
				}
				NpcClass npcClass = new NpcClass();
				npcClass.FldPid = value.FLD_PID;
				npcClass.Name = value.Name;
				npcClass.Level = value.Level;
				npcClass.RxjhExp = value.Rxjh_Exp;
				npcClass.RxjhX = x;
				npcClass.RxjhY = y;
				npcClass.RxjhZ = 15f;
				npcClass.RxjhCsX = x;
				npcClass.RxjhCsY = y;
				npcClass.RxjhCsZ = 15f;
				npcClass.RxjhMap = mapp;
				npcClass.IsNpc = 0;
				npcClass.FldFace1 = 0f;
				npcClass.FldFace2 = 0f;
				npcClass.MaxRxjhHp = value.Rxjh_HP;
				npcClass.RxjhHp = value.Rxjh_HP;
				npcClass.FldAt = value.FLD_AT;
				npcClass.FldDf = value.FLD_DF;
				npcClass.FldAuto = value.FLD_AUTO;
				npcClass.FldBoss = value.FLD_BOSS;
				npcClass.一次性怪 = true;
				NpcClass npcClass2 = npcClass;
				if (Map.TryGetValue(npcClass2.RxjhMap, out MapClass value2))
				{
					value2.add(npcClass2);
				}
				else
				{
					value2 = new MapClass();
					value2.MapID = npcClass2.RxjhMap;
					value2.add(npcClass2);
					Map.Add(value2.MapID, value2);
				}
				npcClass2.获取范围玩家发送增加数据包();
				Thread.Sleep(100);
				return npcClass2.FldIndex;
			}
			catch (Exception ex)
			{
				Form1.WriteLine(2, "增加BOSS攻城怪 [" + npcid + "]出错：" + ex);
				return 0;
			}
		}

		public static void AddNpc(int npcid, float x, float y, int mapp)
		{
			try
			{
				if (!MonSter.TryGetValue(npcid, out MonSterClss value))
				{
					MonSterClss monSterClss = new MonSterClss();
					monSterClss.FLD_PID = npcid;
					monSterClss.Name = "unk";
					monSterClss.Level = 1;
					monSterClss.Rxjh_Exp = 1;
					monSterClss.Rxjh_HP = 100000;
					monSterClss.FLD_AT = 100.0;
					monSterClss.FLD_DF = 100.0;
					monSterClss.FLD_AUTO = 0;
					monSterClss.FLD_BOSS = 0;
					value = monSterClss;
				}
				NpcClass npcClass = new NpcClass();
				npcClass.FldPid = value.FLD_PID;
				npcClass.Name = value.Name;
				npcClass.Level = value.Level;
				npcClass.RxjhExp = value.Rxjh_Exp;
				npcClass.RxjhX = x;
				npcClass.RxjhY = y;
				npcClass.RxjhZ = 15f;
				npcClass.RxjhCsX = x;
				npcClass.RxjhCsY = y;
				npcClass.RxjhCsZ = 15f;
				npcClass.RxjhMap = mapp;
				npcClass.IsNpc = 0;
				npcClass.FldFace1 = 0f;
				npcClass.FldFace2 = 0f;
				npcClass.MaxRxjhHp = value.Rxjh_HP;
				npcClass.RxjhHp = value.Rxjh_HP;
				npcClass.FldAt = value.FLD_AT;
				npcClass.FldDf = value.FLD_DF;
				npcClass.FldAuto = value.FLD_AUTO;
				npcClass.FldBoss = value.FLD_BOSS;
				npcClass.一次性怪 = true;
				NpcClass npcClass2 = npcClass;
				if (Map.TryGetValue(npcClass2.RxjhMap, out MapClass value2))
				{
					value2.add(npcClass2);
				}
				else
				{
					value2 = new MapClass();
					value2.MapID = npcClass2.RxjhMap;
					value2.add(npcClass2);
					Map.Add(value2.MapID, value2);
				}
				npcClass2.获取范围玩家发送增加数据包();
			}
			catch (Exception ex)
			{
				Form1.WriteLine(2, "增加怪 [" + npcid + "]出错：" + ex);
			}
		}

		public static void AddNpc(int npcid, float x, float y, int mapp, int fldFace1, int fldFace2, bool 一次性怪, int fldNewtime)
		{
			try
			{
				if (MonSter.TryGetValue(npcid, out MonSterClss value))
				{
					NpcClass npcClass = new NpcClass();
					npcClass.FldPid = value.FLD_PID;
					npcClass.Name = value.Name;
					npcClass.Level = value.Level;
					npcClass.RxjhExp = value.Rxjh_Exp;
					npcClass.RxjhX = x;
					npcClass.RxjhY = y;
					npcClass.RxjhZ = 15f;
					npcClass.RxjhCsX = x;
					npcClass.RxjhCsY = y;
					npcClass.RxjhCsZ = 15f;
					npcClass.RxjhMap = mapp;
					npcClass.IsNpc = 0;
					npcClass.FldFace1 = fldFace1;
					npcClass.FldFace2 = fldFace2;
					npcClass.MaxRxjhHp = value.Rxjh_HP;
					npcClass.RxjhHp = value.Rxjh_HP;
					npcClass.FldAt = value.FLD_AT;
					npcClass.FldDf = value.FLD_DF;
					npcClass.FldAuto = value.FLD_AUTO;
					npcClass.FldBoss = value.FLD_BOSS;
					npcClass.一次性怪 = 一次性怪;
					npcClass.FldNewtime = fldNewtime;
					if (Map.TryGetValue(npcClass.RxjhMap, out MapClass value2))
					{
						value2.add(npcClass);
					}
					else
					{
						MapClass mapClass = new MapClass();
						mapClass.MapID = npcClass.RxjhMap;
						mapClass.add(npcClass);
						Map.Add(mapClass.MapID, mapClass);
					}
					npcClass.获取范围玩家发送增加数据包();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(2, "增加怪 [" + npcid + "]出错：" + ex);
			}
		}

		public static int Add组队(组队Class 队)
		{
			W组队Id++;
			PartyClass.Add(W组队Id, 队);
			return W组队Id;
		}

		public static void DelNpc(int mapp, int npcid)
		{
			try
			{
				List<NpcClass> list = (from class3 in MapClass.GetnpcTemplate(mapp).Values
				where class3.FldPid == npcid
				select class3).ToList();
				foreach (NpcClass item in list)
				{
					item.Dispose();
				}
				list.Clear();
			}
			catch (Exception ex)
			{
				Form1.WriteLine(2, "删除怪 [" + npcid + "]出错：" + ex);
			}
		}

		public static string Get_RandomGiftCode()
		{
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
			string text2;
			while (true)
			{
				IL_0007:
				text2 = "";
				for (int i = 0; i < 10; i++)
				{
					text2 += text[new Random(GetRandomSeed()).Next(0, text.Length)];
				}
				foreach (GiftcodeClass item in GiftCode)
				{
					if (item.GiftCode == text2)
					{
						goto IL_0007;
					}
				}
				break;
			}
			return text2;
		}

		public static void UpdateGuildPoint()
		{
			int num = 0;
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_XWWL_Guild");
			for (int i = 0; i < dBToDataTable.Rows.Count; i++)
			{
				DataTable dBToDataTable2 = DBA.GetDBToDataTable(string.Format("SELECT * FROM TBL_XWWL_GuildMember where G_Name='{0}'", dBToDataTable.Rows[i]["G_Name"]));
				for (int j = 0; j < dBToDataTable2.Rows.Count; j++)
				{
					num += (int)dBToDataTable2.Rows[j]["FLD_GuildPoint"];
				}
				int num2 = (num < 4000) ? ((num < 3000) ? ((num < 1500) ? ((num < 1000) ? ((num < 500) ? ((num < 200) ? 1 : 2) : 3) : 4) : 5) : 6) : 7;
				DBA.GetDBToDataTable(string.Format("UPDATE TBL_XWWL_Guild SET 门派武勋={0},Leve={1} WHERE G_Name='{2}'", num, num2, dBToDataTable.Rows[i]["G_Name"]));
				num = 0;
			}
			foreach (Players value in AllConnectedChars.Values)
			{
				value.CapnhatdiemthuongGuild();
			}
		}

		public static int GetRandomSeed()
		{
			byte[] array = new byte[4];
			new RNGCryptoServiceProvider().GetBytes(array);
			return BitConverter.ToInt32(array, 0);
		}

		public static int GetStonepid(int pid)
		{
			switch (pid)
			{
			case 800000023:
				return 800000023;
			case 800000024:
				return 800000024;
			case 800000025:
			case 800000026:
				return 800000001;
			case 800000027:
				return 800000028;
			case 800000061:
				return 800000061;
			case 800000062:
				return 800000062;
			case 800000001:
			case 800000011:
				return 800000001;
			case 800000002:
			case 800000012:
				return 800000002;
			case 800000013:
				return 800000013;
			case 800000032:
				return 800000032;
			case 800000033:
				return 800000033;
			case 800000036:
				return 800000036;
			case 800000037:
				return 800000037;
			default:
				return 0;
			}
		}

		public static int GetStoneValue_NewVersion(int pid, int type)
		{
			switch (pid)
			{
			case 800000025:
				return 1000000 + GetStoneValue_Fix(10, 21);
			case 800000026:
				return 700000 + GetStoneValue_Fix(10, 26, 1f, new int[10]
				{
					384,
					256,
					170,
					113,
					75,
					50,
					33,
					22,
					15,
					10
				});
			case 800000011:
				return 100000 + GetStoneValue_Fix(1, 16);
			case 800000001:
			{
				int[] array = new int[5]
				{
					3,
					4,
					5,
					8,
					10
				};
				int num = new Random(GetRandomSeed()).Next(0, array.Length);
				int num2 = array[num];
				int num3 = new Random(GetRandomSeed()).Next(0, 100);
				if (num3 < 20)
				{
					num2 = 1;
				}
				else if (num3 < 80)
				{
					num2 = 7;
				}
				int num9;
				switch (num2)
				{
				case 1:
					return num2 * 100000 + GetStoneValue_Fix(1, 16);
				default:
					num9 = ((num2 != 4) ? 1 : 0);
					break;
				case 3:
					num9 = 0;
					break;
				}
				if (num9 == 0)
				{
					return num2 * 100000 + 5 * GetStoneValue_Fix(1, 11);
				}
				switch (num2)
				{
				case 5:
					return num2 * 100000 + GetStoneValue_Fix(1, 11);
				case 7:
					return num2 * 100000 + GetStoneValue_Fix(1, 26, 1f, new int[10]
					{
						1539,
						879,
						502,
						287,
						164,
						93,
						53,
						30,
						17,
						10
					});
				case 8:
				{
					int num7 = 1;
					if (new Random(GetRandomSeed()).Next(1, 500) < 20)
					{
						num7 = 2;
					}
					return num2 * 100000 + num7;
				}
				case 10:
					return num2 * 100000 + GetStoneValue_Fix(1, 21);
				}
				break;
			}
			case 800000002:
			{
				int[] array = new int[3]
				{
					3,
					4,
					6
				};
				int num = new Random(GetRandomSeed()).Next(0, array.Length);
				int num2 = array[num];
				int num3 = new Random(GetRandomSeed()).Next(0, 100);
				if (num3 < 20)
				{
					num2 = 2;
				}
				else if (num3 < 80)
				{
					num2 = 11;
				}
				int num10;
				switch (num2)
				{
				case 2:
					return num2 * 100000 + GetStoneValue_Fix(1, 9, 1f, new int[10]
					{
						1539,
						879,
						502,
						287,
						164,
						93,
						53,
						30,
						17,
						10
					});
				default:
					num10 = ((num2 != 4) ? 1 : 0);
					break;
				case 3:
					num10 = 0;
					break;
				}
				if (num10 == 0)
				{
					return num2 * 100000 + 5 * GetStoneValue_Fix(1, 11);
				}
				switch (num2)
				{
				case 6:
					return num2 * 100000 + GetStoneValue_Fix(1, 11);
				case 11:
					return num2 * 100000 + GetStoneValue_Fix(15, 41, 1f, new int[10]
					{
						1000,
						700,
						500,
						300,
						200,
						150,
						100,
						70,
						30,
						10
					});
				}
				break;
			}
			case 800000012:
				return 200000 + GetStoneValue_Fix(3, 9);
			case 800000023:
			{
				int[] array = new int[2]
				{
					5,
					8
				};
				int num = new Random(GetRandomSeed()).Next(0, array.Length);
				int num2 = array[num];
				int num3 = new Random(GetRandomSeed()).Next(0, 100);
				if (num3 < 20)
				{
					num2 = 1;
				}
				else if (num3 < 80)
				{
					num2 = 7;
				}
				switch (num2)
				{
				case 1:
					return num2 * 100000 + GetStoneValue_Fix(5, 21);
				case 5:
					return num2 * 100000 + GetStoneValue_Fix(1, 16);
				case 8:
				{
					int num7 = 1;
					if (new Random(GetRandomSeed()).Next(1, 500) < 20)
					{
						num7 = 2;
					}
					return num2 * 100000 + num7;
				}
				case 7:
					return num2 * 100000 + GetStoneValue_Fix(10, 31, 1f, new int[10]
					{
						1539,
						879,
						502,
						287,
						164,
						93,
						53,
						30,
						17,
						10
					});
				}
				break;
			}
			case 800000024:
			{
				int[] array = new int[1]
				{
					6
				};
				int num = new Random(GetRandomSeed()).Next(0, array.Length);
				int num2 = array[num];
				int num3 = new Random(GetRandomSeed()).Next(0, 100);
				if (num3 < 20)
				{
					num2 = 2;
				}
				else if (num3 < 80)
				{
					num2 = 11;
				}
				switch (num2)
				{
				case 2:
					return num2 * 100000 + GetStoneValue_Fix(1, 11, 1f, new int[10]
					{
						1539,
						879,
						502,
						287,
						164,
						93,
						53,
						30,
						17,
						10
					});
				case 6:
					return num2 * 100000 + GetStoneValue_Fix(1, 26);
				case 11:
					return num2 * 100000 + GetStoneValue_Fix(30, 81, 1f, new int[10]
					{
						1000,
						700,
						500,
						300,
						200,
						150,
						100,
						70,
						30,
						10
					});
				}
				break;
			}
			case 800000032:
			case 800000036:
			{
				int[] array = new int[3]
				{
					3,
					4,
					6
				};
				int num = new Random(GetRandomSeed()).Next(0, array.Length);
				int num2 = array[num];
				int num3 = new Random(GetRandomSeed()).Next(0, 100);
				if (num3 < 20)
				{
					num2 = 2;
				}
				else if (num3 < 80)
				{
					num2 = 11;
				}
				int num8;
				switch (num2)
				{
				case 2:
					return num2 * 100000 + GetStoneValue_Fix(1, 9, 1f, new int[10]
					{
						1539,
						879,
						502,
						287,
						164,
						93,
						53,
						30,
						17,
						10
					});
				default:
					num8 = ((num2 != 4) ? 1 : 0);
					break;
				case 3:
					num8 = 0;
					break;
				}
				if (num8 == 0)
				{
					return num2 * 100000 + 5 * GetStoneValue_Fix(1, 11);
				}
				switch (num2)
				{
				case 6:
					return num2 * 100000 + GetStoneValue_Fix(1, 11);
				case 11:
					return num2 * 100000 + GetStoneValue_Fix(15, 41, 1f, new int[10]
					{
						1000,
						700,
						500,
						300,
						200,
						150,
						100,
						70,
						30,
						10
					});
				}
				break;
			}
			case 800000033:
			case 800000037:
			{
				int[] array = new int[1]
				{
					6
				};
				int num = new Random(GetRandomSeed()).Next(0, array.Length);
				int num2 = array[num];
				int num3 = new Random(GetRandomSeed()).Next(0, 100);
				if (num3 < 20)
				{
					num2 = 2;
				}
				else if (num3 < 80)
				{
					num2 = 11;
				}
				switch (num2)
				{
				case 2:
					return num2 * 100000 + GetStoneValue_Fix(1, 11, 1f, new int[10]
					{
						1539,
						879,
						502,
						287,
						164,
						93,
						53,
						30,
						17,
						10
					});
				case 6:
					return num2 * 100000 + GetStoneValue_Fix(1, 16);
				case 11:
					return num2 * 100000 + GetStoneValue_Fix(30, 81, 1f, new int[10]
					{
						1000,
						700,
						500,
						300,
						200,
						150,
						100,
						70,
						30,
						10
					});
				}
				break;
			}
			case 800000061:
			{
				int[] array = new int[2]
				{
					5,
					8
				};
				int num = new Random(GetRandomSeed()).Next(0, array.Length);
				int num2 = array[num];
				int num3 = new Random(GetRandomSeed()).Next(0, 100);
				if (num3 < 20)
				{
					num2 = 1;
				}
				else if (num3 < 80)
				{
					num2 = 7;
				}
				switch (num2)
				{
				case 1:
					return num2 * 100000 + GetStoneValue_Fix(10, 26, 1f, new int[10]
					{
						1539,
						879,
						502,
						287,
						164,
						93,
						53,
						30,
						17,
						10
					});
				case 5:
					return num2 * 100000 + GetStoneValue_Fix(10, 21);
				case 8:
				{
					int num7 = 1;
					if (new Random(GetRandomSeed()).Next(1, 500) < 20)
					{
						num7 = 2;
					}
					return num2 * 100000 + num7;
				}
				case 7:
					return num2 * 100000 + GetStoneValue_Fix(10, 36, 1f, new int[10]
					{
						1539,
						879,
						502,
						287,
						164,
						93,
						53,
						30,
						17,
						10
					});
				}
				break;
			}
			case 800000062:
			{
				int[] array = new int[1]
				{
					6
				};
				int num = new Random(GetRandomSeed()).Next(0, array.Length);
				int num2 = array[num];
				int num3 = new Random(GetRandomSeed()).Next(0, 100);
				if (num3 < 20)
				{
					num2 = 2;
				}
				else if (num3 < 80)
				{
					num2 = 11;
				}
				switch (num2)
				{
				case 2:
					return num2 * 100000 + GetStoneValue_Fix(5, 16, 1f, new int[10]
					{
						1539,
						879,
						502,
						287,
						164,
						93,
						53,
						30,
						17,
						10
					});
				case 6:
					return num2 * 100000 + GetStoneValue_Fix(8, 31);
				case 11:
					return num2 * 100000 + GetStoneValue_Fix(40, 101, 1f, new int[10]
					{
						1000,
						700,
						500,
						300,
						200,
						150,
						100,
						70,
						30,
						10
					});
				}
				break;
			}
			case 800000013:
			{
				int[] array = new int[2]
				{
					12,
					13
				};
				int num = new Random(GetRandomSeed()).Next(0, array.Length);
				int num2 = array[num];
				int num3 = new Random(GetRandomSeed()).Next(0, 110);
				if (num3 < 90)
				{
					num2 = 8;
				}
				else if (num3 < 100)
				{
					num2 = 9;
				}
				switch (num2)
				{
				case 8:
				{
					int num4 = new Random(GetRandomSeed()).Next((Newversion < 13) ? ((CreateNewJob == 0) ? 22 : 0) : ((Newversion < 15) ? (-11) : ((Newversion >= 16) ? (-33) : (-22))), 150 - ((Newversion >= 13) ? 51 : ((CreateNewJob != 0) ? 5 : 15)));
					string text3 = "000";
					if (num4 >= -33 && num4 < -22)
					{
						text3 = new Random(GetRandomSeed()).Next(281, 292).ToString();
					}
					else if (num4 >= -22 && num4 < -11)
					{
						switch (new Random(GetRandomSeed()).Next(0, 11))
						{
						case 0:
							text3 = "650";
							break;
						case 1:
							text3 = "651";
							break;
						case 2:
							text3 = "653";
							break;
						case 3:
							text3 = "654";
							break;
						case 4:
							text3 = "656";
							break;
						case 5:
							text3 = "657";
							break;
						case 6:
							text3 = "658";
							break;
						case 7:
							text3 = "659";
							break;
						case 8:
							text3 = "660";
							break;
						case 9:
							text3 = "661";
							break;
						default:
							text3 = "318";
							break;
						}
					}
					else if (num4 >= -11 && num4 < 0)
					{
						text3 = new Random(GetRandomSeed()).Next(550, 561).ToString();
					}
					else if (num4 >= 0 && num4 < 11)
					{
						text3 = new Random(GetRandomSeed()).Next(250, 261).ToString();
					}
					else if (num4 >= 11 && num4 < 22)
					{
						text3 = new Random(GetRandomSeed()).Next(270, 281).ToString();
						if (text3 == "274")
						{
							text3 = "024";
						}
						else if (text3 == "275")
						{
							text3 = "025";
						}
						else if (text3 == "276")
						{
							text3 = "026";
						}
					}
					else if (num4 >= 22 && num4 < 72)
					{
						text3 = "0" + new Random(GetRandomSeed()).Next(10, 60).ToString();
					}
					else if (num4 >= 72 && num4 < 92)
					{
						text3 = "0" + new Random(GetRandomSeed()).Next(70, 90).ToString();
					}
					else if (num4 >= 92 && num4 < 99)
					{
						int num5 = new Random(GetRandomSeed()).Next(1, 8);
						if (num5 == 6)
						{
							num5 = 8;
						}
						text3 = "1" + num5 + "0";
					}
					else
					{
						int num5 = new Random(GetRandomSeed()).Next(1, (Newversion >= 13) ? 11 : ((CreateNewJob != 0) ? 10 : 8));
						int num6 = new Random(GetRandomSeed()).Next(0, (Newversion >= 13) ? 5 : 3);
						if (num5 < 8)
						{
							if (num5 == 6)
							{
								num5 = 9;
							}
							text3 = "3" + num5 + num6;
						}
						else
						{
							switch (num5)
							{
							case 8:
								text3 = "60" + num6;
								break;
							case 9:
								text3 = ((num6 < 2) ? ("32" + new Random(GetRandomSeed()).Next(1, 3)) : ("70" + new Random(GetRandomSeed()).Next(0, 3)));
								break;
							case 10:
								text3 = "56" + num6;
								break;
							}
						}
					}
					if (Newversion >= 13)
					{
						if (text3 == "013")
						{
							text3 = "312";
						}
						else if (text3 == "025")
						{
							text3 = "320";
						}
						else if (text3 == "033")
						{
							text3 = "332";
						}
						else if (text3 == "058")
						{
							text3 = "350";
						}
						else if (text3 == "150")
						{
							text3 = "351";
						}
						else if (text3 == "170")
						{
							text3 = "372";
						}
						else if (text3 == "170")
						{
							text3 = "372";
						}
					}
					string text = "1";
					string text2 = "0";
					if (text.Length == 1)
					{
						text2 = num2.ToString() + text3 + "0" + text;
					}
					else if (text.Length == 2)
					{
						text2 = num2.ToString() + text3 + text;
					}
					if (text2.Length == 6)
					{
						return int.Parse(text2);
					}
					break;
				}
				case 9:
				{
					string text = (GetStoneValue_Fix(1, 0, 1f, new int[1]
					{
						10
					}) * 5).ToString();
					string text2 = "0";
					if (text.Length == 1)
					{
						text2 = num2.ToString() + "0000" + text;
					}
					else if (text.Length == 2)
					{
						text2 = num2.ToString() + "000" + text;
					}
					if (text2.Length == 6)
					{
						return int.Parse(text2);
					}
					break;
				}
				case 12:
				{
					string text = (GetStoneValue_Fix(1, 0, 1f, new int[1]
					{
						10
					}) * 5).ToString();
					string text2 = "0";
					if (text.Length == 1)
					{
						text2 = num2.ToString() + "0000" + text;
					}
					else if (text.Length == 2)
					{
						text2 = num2.ToString() + "000" + text;
					}
					if (text2.Length == 7)
					{
						return int.Parse(text2);
					}
					break;
				}
				case 13:
				{
					string text = (GetStoneValue_Fix(1, 0, 1f, new int[1]
					{
						10
					}) * 5).ToString();
					string text2 = "0";
					if (text.Length == 1)
					{
						text2 = num2.ToString() + "0000" + text;
					}
					else if (text.Length == 2)
					{
						text2 = num2.ToString() + "000" + text;
					}
					if (text2.Length == 7)
					{
						return int.Parse(text2);
					}
					break;
				}
				}
				return 0;
			}
			}
			return 0;
		}

		public static int GetStoneValue(int pid, int type)
		{
			if (Newversion >= 16 && pid != 800000027 && pid != 800000028)
			{
				return GetStoneValue_NewVersion(pid, type);
			}
			int num = 0;
			Random random = new Random(GetRandomSeed());
			if (pid > 800000013)
			{
				switch (pid)
				{
				case 800000023:
				{
					string[] array49 = null;
					switch (type)
					{
					case 1:
						array49 = 商店混元金刚石.Split(';');
						break;
					case 2:
						array49 = 百宝阁混元金刚石.Split(';');
						break;
					case 3:
						array49 = 普通怪暴混元金刚石.Split(';');
						break;
					case 4:
						array49 = Boss怪暴混元金刚石.Split(';');
						break;
					case 5:
						array49 = 奖励混元金刚石.Split(';');
						break;
					case 6:
						array49 = 开箱混元金刚石.Split(';');
						break;
					case 7:
						array49 = 高手怪暴混元金刚石.Split(';');
						break;
					}
					return GetStoneValue_Fix(Convert.ToInt32(array49[0]), Convert.ToInt32(array49[1]));
				}
				case 800000024:
					switch (type)
					{
					case 7:
						switch (高手怪暴冰魄寒玉石类型设置)
						{
						case 0:
						{
							if (random.Next(1, 100) <= 50)
							{
								string[] array3 = 高手怪暴冰魄寒玉石防御.Split(';');
								return GetStoneValue_Fix(Convert.ToInt32(array3[0]), Convert.ToInt32(array3[1]));
							}
							string[] array43 = 高手怪暴冰魄寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array43[0]), Convert.ToInt32(array43[1]));
						}
						case 1:
						{
							string[] array42 = 高手怪暴冰魄寒玉石防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array42[0]), Convert.ToInt32(array42[1]));
						}
						case 2:
						{
							string[] array41 = 高手怪暴冰魄寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array41[0]), Convert.ToInt32(array41[1]));
						}
						}
						break;
					case 6:
						switch (开箱冰魄寒玉石类型设置)
						{
						case 0:
						{
							if (random.Next(1, 100) <= 50)
							{
								string[] array3 = 开箱冰魄寒玉石防御.Split(';');
								return GetStoneValue_Fix(Convert.ToInt32(array3[0]), Convert.ToInt32(array3[1]));
							}
							string[] array40 = 开箱冰魄寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array40[0]), Convert.ToInt32(array40[1]));
						}
						case 1:
						{
							string[] array39 = 开箱冰魄寒玉石防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array39[0]), Convert.ToInt32(array39[1]));
						}
						case 2:
						{
							string[] array38 = 开箱冰魄寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array38[0]), Convert.ToInt32(array38[1]));
						}
						}
						break;
					case 5:
						switch (奖励冰魄寒玉石类型设置)
						{
						case 0:
						{
							if (random.Next(1, 100) <= 50)
							{
								string[] array3 = 奖励冰魄寒玉石防御.Split(';');
								return GetStoneValue_Fix(Convert.ToInt32(array3[0]), Convert.ToInt32(array3[1]));
							}
							string[] array37 = 奖励冰魄寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array37[0]), Convert.ToInt32(array37[1]));
						}
						case 1:
						{
							string[] array36 = 奖励冰魄寒玉石防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array36[0]), Convert.ToInt32(array36[1]));
						}
						case 2:
						{
							string[] array35 = 奖励冰魄寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array35[0]), Convert.ToInt32(array35[1]));
						}
						}
						break;
					case 4:
						switch (Boss怪暴冰魄寒玉石类型设置)
						{
						case 0:
						{
							if (random.Next(1, 100) <= 50)
							{
								string[] array3 = Boss怪暴冰魄寒玉石防御.Split(';');
								return GetStoneValue_Fix(Convert.ToInt32(array3[0]), Convert.ToInt32(array3[1]));
							}
							string[] array34 = Boss怪暴冰魄寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array34[0]), Convert.ToInt32(array34[1]));
						}
						case 1:
						{
							string[] array33 = Boss怪暴冰魄寒玉石防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array33[0]), Convert.ToInt32(array33[1]));
						}
						case 2:
						{
							string[] array32 = Boss怪暴冰魄寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array32[0]), Convert.ToInt32(array32[1]));
						}
						}
						break;
					case 3:
						switch (普通怪暴冰魄寒玉石类型设置)
						{
						case 0:
						{
							if (random.Next(1, 100) <= 50)
							{
								string[] array3 = 普通怪暴冰魄寒玉石防御.Split(';');
								return GetStoneValue_Fix(Convert.ToInt32(array3[0]), Convert.ToInt32(array3[1]));
							}
							string[] array31 = 普通怪暴冰魄寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array31[0]), Convert.ToInt32(array31[1]));
						}
						case 1:
						{
							string[] array30 = 普通怪暴冰魄寒玉石防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array30[0]), Convert.ToInt32(array30[1]));
						}
						case 2:
						{
							string[] array29 = 普通怪暴冰魄寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array29[0]), Convert.ToInt32(array29[1]));
						}
						}
						break;
					case 2:
						switch (百宝阁冰魄寒玉石类型设置)
						{
						case 0:
						{
							if (random.Next(1, 100) <= 50)
							{
								string[] array3 = 百宝阁冰魄寒玉石防御.Split(';');
								return GetStoneValue_Fix(Convert.ToInt32(array3[0]), Convert.ToInt32(array3[1]));
							}
							string[] array28 = 百宝阁冰魄寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array28[0]), Convert.ToInt32(array28[1]));
						}
						case 1:
						{
							string[] array27 = 百宝阁冰魄寒玉石防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array27[0]), Convert.ToInt32(array27[1]));
						}
						case 2:
						{
							string[] array26 = 百宝阁冰魄寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array26[0]), Convert.ToInt32(array26[1]));
						}
						}
						break;
					case 1:
						switch (商店冰魄寒玉石类型设置)
						{
						case 0:
						{
							if (random.Next(1, 100) > 50)
							{
								string[] array3 = 商店冰魄寒玉石武功防御.Split(';');
								return GetStoneValue_Fix(Convert.ToInt32(array3[0]), Convert.ToInt32(array3[1]));
							}
							string[] array25 = 商店冰魄寒玉石防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array25[0]), Convert.ToInt32(array25[1]));
						}
						case 1:
						{
							string[] array24 = 商店冰魄寒玉石防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array24[0]), Convert.ToInt32(array24[1]));
						}
						case 2:
						{
							string[] array23 = 商店冰魄寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array23[0]), Convert.ToInt32(array23[1]));
						}
						}
						break;
					}
					return 0;
				case 800000025:
				{
					string[] array48 = null;
					switch (type)
					{
					case 1:
						array48 = 商店神秘金刚石追伤.Split(';');
						break;
					case 2:
						array48 = 百宝阁神秘金刚石追伤.Split(';');
						break;
					case 3:
						array48 = 普通怪暴神秘金刚石追伤.Split(';');
						break;
					case 4:
						array48 = Boss怪暴神秘金刚石追伤.Split(';');
						break;
					case 5:
						array48 = 奖励神秘金刚石追伤.Split(';');
						break;
					case 7:
						array48 = 高手怪暴神秘金刚石追伤.Split(';');
						break;
					}
					return GetStoneValue_Fix(Convert.ToInt32(array48[0]), Convert.ToInt32(array48[1]));
				}
				case 800000026:
				{
					string[] array50 = null;
					switch (type)
					{
					case 1:
						array50 = 商店神秘金刚石武功.Split(';');
						break;
					case 2:
						array50 = 百宝阁神秘金刚石武功.Split(';');
						break;
					case 3:
						array50 = 普通怪暴神秘金刚石武功.Split(';');
						break;
					case 4:
						array50 = Boss怪暴神秘金刚石武功.Split(';');
						break;
					case 5:
						array50 = 奖励神秘金刚石武功.Split(';');
						break;
					case 7:
						array50 = 高手怪暴神秘金刚石武功.Split(';');
						break;
					}
					return GetStoneValue_Fix(Convert.ToInt32(array50[0]), Convert.ToInt32(array50[1]));
				}
				case 800000027:
				case 800000028:
				{
					int num2 = 0;
					switch (type)
					{
					case 1:
						switch (商店属性石)
						{
						case 0:
							num2 = new Random(GetRandomSeed()).Next(1, 7);
							break;
						case 1:
							num2 = 1;
							break;
						case 2:
							num2 = 2;
							break;
						case 3:
							num2 = 3;
							break;
						case 4:
							num2 = 4;
							break;
						case 5:
							num2 = 5;
							break;
						case 6:
							num2 = 6;
							break;
						case 7:
							num2 = 7;
							break;
						default:
							num2 = new Random(GetRandomSeed()).Next(1, 7);
							break;
						}
						break;
					case 2:
						switch (百宝阁属性石)
						{
						case 0:
							num2 = new Random(GetRandomSeed()).Next(1, 7);
							break;
						case 1:
							num2 = 1;
							break;
						case 2:
							num2 = 2;
							break;
						case 3:
							num2 = 3;
							break;
						case 4:
							num2 = 4;
							break;
						case 5:
							num2 = 5;
							break;
						case 6:
							num2 = 6;
							break;
						case 7:
							num2 = 7;
							break;
						default:
							num2 = new Random(GetRandomSeed()).Next(1, 7);
							break;
						}
						break;
					case 3:
						switch (普通怪暴属性石)
						{
						case 0:
							num2 = new Random(GetRandomSeed()).Next(1, 7);
							break;
						case 1:
							num2 = 1;
							break;
						case 2:
							num2 = 2;
							break;
						case 3:
							num2 = 3;
							break;
						case 4:
							num2 = 4;
							break;
						case 5:
							num2 = 5;
							break;
						case 6:
							num2 = 6;
							break;
						case 7:
							num2 = 7;
							break;
						default:
							num2 = new Random(GetRandomSeed()).Next(1, 7);
							break;
						}
						break;
					case 4:
						switch (Boss怪暴属性石)
						{
						case 0:
							num2 = new Random(GetRandomSeed()).Next(1, 7);
							break;
						case 1:
							num2 = 1;
							break;
						case 2:
							num2 = 2;
							break;
						case 3:
							num2 = 3;
							break;
						case 4:
							num2 = 4;
							break;
						case 5:
							num2 = 5;
							break;
						case 6:
							num2 = 6;
							break;
						case 7:
							num2 = 7;
							break;
						default:
							num2 = new Random(GetRandomSeed()).Next(1, 7);
							break;
						}
						break;
					case 5:
						switch (奖励属性石)
						{
						case 0:
							num2 = new Random(GetRandomSeed()).Next(1, 7);
							break;
						case 1:
							num2 = 1;
							break;
						case 2:
							num2 = 2;
							break;
						case 3:
							num2 = 3;
							break;
						case 4:
							num2 = 4;
							break;
						case 5:
							num2 = 5;
							break;
						case 6:
							num2 = 6;
							break;
						case 7:
							num2 = 7;
							break;
						default:
							num2 = new Random(GetRandomSeed()).Next(1, 7);
							break;
						}
						break;
					case 6:
						switch (开箱属性石)
						{
						case 0:
							num2 = new Random(GetRandomSeed()).Next(1, 7);
							break;
						case 1:
							num2 = 1;
							break;
						case 2:
							num2 = 2;
							break;
						case 3:
							num2 = 3;
							break;
						case 4:
							num2 = 4;
							break;
						case 5:
							num2 = 5;
							break;
						case 6:
							num2 = 6;
							break;
						case 7:
							num2 = 7;
							break;
						default:
							num2 = new Random(GetRandomSeed()).Next(1, 7);
							break;
						}
						break;
					case 7:
						switch (高手怪暴属性石)
						{
						case 0:
							num2 = new Random(GetRandomSeed()).Next(1, 7);
							break;
						case 1:
							num2 = 1;
							break;
						case 2:
							num2 = 2;
							break;
						case 3:
							num2 = 3;
							break;
						case 4:
							num2 = 4;
							break;
						case 5:
							num2 = 5;
							break;
						case 6:
							num2 = 6;
							break;
						case 7:
							num2 = 7;
							break;
						default:
							num2 = new Random(GetRandomSeed()).Next(1, 7);
							break;
						}
						break;
					}
					return int.Parse("200" + num2.ToString() + "000");
				}
				case 800000061:
				{
					string[] array44 = null;
					switch (type)
					{
					case 1:
						array44 = 商店乾坤金刚石.Split(';');
						break;
					case 2:
						array44 = 百宝阁乾坤金刚石.Split(';');
						break;
					case 3:
						array44 = 普通怪暴乾坤金刚石.Split(';');
						break;
					case 4:
						array44 = Boss怪暴乾坤金刚石.Split(';');
						break;
					case 5:
						array44 = 奖励乾坤金刚石.Split(';');
						break;
					case 6:
						switch (开箱乾坤金刚石类型设置)
						{
						case 0:
						{
							if (random.Next(1, 100) <= 50)
							{
								string[] array3 = 开箱乾坤金刚石武功.Split(';');
								return GetStoneValue_Fix(Convert.ToInt32(array3[0]), Convert.ToInt32(array3[1]));
							}
							string[] array47 = 开箱乾坤金刚石攻击.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array47[0]), Convert.ToInt32(array47[1]));
						}
						case 1:
						{
							string[] array46 = 开箱乾坤金刚石攻击.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array46[0]), Convert.ToInt32(array46[1]));
						}
						case 2:
						{
							string[] array45 = 开箱乾坤金刚石武功.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array45[0]), Convert.ToInt32(array45[1]));
						}
						}
						break;
					case 7:
						array44 = 高手怪暴乾坤金刚石.Split(';');
						break;
					}
					return GetStoneValue_Fix(Convert.ToInt32(array44[0]), Convert.ToInt32(array44[1]));
				}
				case 800000062:
					switch (type)
					{
					case 7:
						switch (高手怪暴凝霜寒玉石类型设置)
						{
						case 0:
						{
							if (random.Next(1, 100) <= 50)
							{
								string[] array3 = 高手怪暴凝霜寒玉石防御.Split(';');
								return GetStoneValue_Fix(Convert.ToInt32(array3[0]), Convert.ToInt32(array3[1]));
							}
							string[] array22 = 高手怪暴凝霜寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array22[0]), Convert.ToInt32(array22[1]));
						}
						case 1:
						{
							string[] array21 = 高手怪暴凝霜寒玉石防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array21[0]), Convert.ToInt32(array21[1]));
						}
						case 2:
						{
							string[] array20 = 高手怪暴凝霜寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array20[0]), Convert.ToInt32(array20[1]));
						}
						}
						break;
					case 6:
						switch (开箱凝霜寒玉石类型设置)
						{
						case 0:
						{
							if (random.Next(1, 100) <= 50)
							{
								string[] array3 = 开箱凝霜寒玉石防御.Split(';');
								return GetStoneValue_Fix(Convert.ToInt32(array3[0]), Convert.ToInt32(array3[1]));
							}
							string[] array19 = 开箱凝霜寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array19[0]), Convert.ToInt32(array19[1]));
						}
						case 1:
						{
							string[] array18 = 开箱凝霜寒玉石防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array18[0]), Convert.ToInt32(array18[1]));
						}
						case 2:
						{
							string[] array17 = 开箱凝霜寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array17[0]), Convert.ToInt32(array17[1]));
						}
						}
						break;
					case 5:
						switch (奖励凝霜寒玉石类型设置)
						{
						case 0:
						{
							if (random.Next(1, 100) <= 50)
							{
								string[] array3 = 奖励凝霜寒玉石防御.Split(';');
								return GetStoneValue_Fix(Convert.ToInt32(array3[0]), Convert.ToInt32(array3[1]));
							}
							string[] array16 = 奖励凝霜寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array16[0]), Convert.ToInt32(array16[1]));
						}
						case 1:
						{
							string[] array15 = 奖励凝霜寒玉石防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array15[0]), Convert.ToInt32(array15[1]));
						}
						case 2:
						{
							string[] array14 = 奖励凝霜寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array14[0]), Convert.ToInt32(array14[1]));
						}
						}
						break;
					case 4:
						switch (Boss怪暴凝霜寒玉石类型设置)
						{
						case 0:
						{
							if (random.Next(1, 100) <= 50)
							{
								string[] array3 = Boss怪暴凝霜寒玉石防御.Split(';');
								return GetStoneValue_Fix(Convert.ToInt32(array3[0]), Convert.ToInt32(array3[1]));
							}
							string[] array13 = Boss怪暴凝霜寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array13[0]), Convert.ToInt32(array13[1]));
						}
						case 1:
						{
							string[] array12 = Boss怪暴凝霜寒玉石防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array12[0]), Convert.ToInt32(array12[1]));
						}
						case 2:
						{
							string[] array11 = Boss怪暴凝霜寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array11[0]), Convert.ToInt32(array11[1]));
						}
						}
						break;
					case 3:
						switch (普通怪暴凝霜寒玉石类型设置)
						{
						case 0:
						{
							if (random.Next(1, 100) <= 50)
							{
								string[] array3 = 普通怪暴凝霜寒玉石防御.Split(';');
								return GetStoneValue_Fix(Convert.ToInt32(array3[0]), Convert.ToInt32(array3[1]));
							}
							string[] array10 = 普通怪暴凝霜寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array10[0]), Convert.ToInt32(array10[1]));
						}
						case 1:
						{
							string[] array9 = 普通怪暴凝霜寒玉石防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array9[0]), Convert.ToInt32(array9[1]));
						}
						case 2:
						{
							string[] array8 = 普通怪暴凝霜寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array8[0]), Convert.ToInt32(array8[1]));
						}
						}
						break;
					case 2:
						switch (百宝阁凝霜寒玉石类型设置)
						{
						case 0:
						{
							if (random.Next(1, 100) <= 50)
							{
								string[] array3 = 百宝阁凝霜寒玉石防御.Split(';');
								return GetStoneValue_Fix(Convert.ToInt32(array3[0]), Convert.ToInt32(array3[1]));
							}
							string[] array7 = 百宝阁凝霜寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array7[0]), Convert.ToInt32(array7[1]));
						}
						case 1:
						{
							string[] array6 = 百宝阁凝霜寒玉石防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array6[0]), Convert.ToInt32(array6[1]));
						}
						case 2:
						{
							string[] array5 = 百宝阁凝霜寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array5[0]), Convert.ToInt32(array5[1]));
						}
						}
						break;
					case 1:
						switch (商店凝霜寒玉石类型设置)
						{
						case 0:
						{
							if (random.Next(1, 100) > 50)
							{
								string[] array3 = 商店凝霜寒玉石武功防御.Split(';');
								return GetStoneValue_Fix(Convert.ToInt32(array3[0]), Convert.ToInt32(array3[1]));
							}
							string[] array4 = 商店凝霜寒玉石防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array4[0]), Convert.ToInt32(array4[1]));
						}
						case 1:
						{
							string[] array2 = 商店凝霜寒玉石防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array2[0]), Convert.ToInt32(array2[1]));
						}
						case 2:
						{
							string[] array = 商店凝霜寒玉石武功防御.Split(';');
							return GetStoneValue_Fix(Convert.ToInt32(array[0]), Convert.ToInt32(array[1]));
						}
						}
						break;
					}
					return 0;
				default:
					return 0;
				}
			}
			switch (pid)
			{
			case 800000001:
			case 800000011:
			{
				string[] array53 = null;
				switch (type)
				{
				case 1:
					array53 = 商店金刚石.Split(';');
					break;
				case 2:
					array53 = 百宝阁金刚石.Split(';');
					break;
				case 3:
					array53 = 普通怪暴金刚石.Split(';');
					break;
				case 4:
					array53 = Boss怪暴金刚石.Split(';');
					break;
				case 5:
					array53 = 奖励金刚石.Split(';');
					break;
				case 6:
					array53 = 开箱金刚石.Split(';');
					break;
				case 7:
					array53 = 高手怪暴金刚石.Split(';');
					break;
				}
				return GetStoneValue_Fix(Convert.ToInt32(array53[0]), Convert.ToInt32(array53[1]));
			}
			case 800000002:
			case 800000012:
			{
				string[] array52 = null;
				switch (type)
				{
				case 1:
					array52 = 商店寒玉石.Split(';');
					break;
				case 2:
					array52 = 百宝阁寒玉石.Split(';');
					break;
				case 3:
					array52 = 普通怪暴寒玉石.Split(';');
					break;
				case 4:
					array52 = Boss怪暴寒玉石.Split(';');
					break;
				case 5:
					array52 = 奖励寒玉石.Split(';');
					break;
				case 6:
					array52 = 开箱寒玉石.Split(';');
					break;
				case 7:
					array52 = 高手怪暴寒玉石.Split(';');
					break;
				}
				return GetStoneValue_Fix(Convert.ToInt32(array52[0]), Convert.ToInt32(array52[1]));
			}
			case 800000013:
			{
				string text = "0000";
				string[] array51 = null;
				switch (type)
				{
				case 1:
					array51 = 商店热血石.Split(';');
					break;
				case 2:
					array51 = 百宝阁热血石.Split(';');
					break;
				case 3:
					array51 = 普通怪暴热血石.Split(';');
					break;
				case 4:
					array51 = Boss怪暴热血石.Split(';');
					break;
				case 5:
					array51 = 奖励热血石.Split(';');
					break;
				case 6:
					array51 = 开箱热血石.Split(';');
					break;
				case 7:
					array51 = 高手怪暴热血石.Split(';');
					break;
				}
				int num3;
				if (array51 != null && array51[0] == "Q")
				{
					num3 = 8;
					num = GetStoneValue_Fix(Convert.ToInt32(array51[1]), Convert.ToInt32(array51[2]));
				}
				else if (array51 != null && array51[0] == "M")
				{
					if (random.Next(1, 100) > 50)
					{
						num3 = 8;
						num = GetStoneValue_Fix(Convert.ToInt32(array51[1]), Convert.ToInt32(array51[2]));
					}
					else
					{
						num3 = 9;
						num = GetStoneValue_Fix(Convert.ToInt32(array51[1]), Convert.ToInt32(array51[2]));
					}
				}
				else
				{
					if (array51 != null)
					{
						num = GetStoneValue_Fix(Convert.ToInt32(array51[1]), Convert.ToInt32(array51[2]));
					}
					int num4 = random.Next((Newversion < 13) ? ((CreateNewJob == 0) ? 22 : 0) : ((Newversion < 15) ? (-11) : ((Newversion >= 16) ? (-33) : (-22))), 150 - ((Newversion >= 13) ? 51 : ((CreateNewJob != 0) ? 5 : 15)));
					if (num4 >= -33 && num4 < -22)
					{
						num3 = 8;
						text = random.Next(281, 292) + "0";
					}
					else if (num4 >= -22 && num4 < -11)
					{
						num3 = 8;
						switch (random.Next(0, 11))
						{
						case 0:
							text = "6500";
							break;
						case 1:
							text = "6510";
							break;
						case 2:
							text = "6530";
							break;
						case 3:
							text = "6540";
							break;
						case 4:
							text = "6560";
							break;
						case 5:
							text = "6570";
							break;
						case 6:
							text = "6580";
							break;
						case 7:
							text = "6590";
							break;
						case 8:
							text = "6600";
							break;
						case 9:
							text = "6610";
							break;
						default:
							text = "3180";
							break;
						}
					}
					else if (num4 >= -11 && num4 < 0)
					{
						num3 = 8;
						text = random.Next(550, 561) + "0";
					}
					else if (num4 >= 0 && num4 < 11)
					{
						num3 = 8;
						text = random.Next(250, 261) + "0";
					}
					else if (num4 >= 11 && num4 < 22)
					{
						num3 = 8;
						text = random.Next(270, 281) + "0";
						if (text == "2740")
						{
							text = "0240";
						}
						else if (text == "2750")
						{
							text = "0250";
						}
						else if (text == "2760")
						{
							text = "0260";
						}
					}
					else if (num4 >= 22 && num4 < 72)
					{
						num3 = 8;
						text = "0" + random.Next(10, 60) + "0";
					}
					else if (num4 >= 72 && num4 < 92)
					{
						num3 = 8;
						text = "0" + random.Next(70, 90) + "0";
					}
					else if (num4 >= 92 && num4 < 99)
					{
						num3 = 8;
						int num5 = random.Next(1, 8);
						if (num5 == 6)
						{
							num5 = 8;
						}
						text = "1" + num5 + "00";
					}
					else
					{
						num3 = 8;
						int num5 = random.Next(1, (Newversion >= 13) ? 11 : ((CreateNewJob != 0) ? 10 : 8));
						int num6 = random.Next(0, (Newversion >= 13) ? 5 : 3);
						if (num5 < 8)
						{
							if (num5 == 6)
							{
								num5 = 9;
							}
							text = "3" + num5 + num6 + "0";
						}
						else
						{
							switch (num5)
							{
							case 8:
								text = "60" + num6 + "0";
								break;
							case 9:
								text = ((num6 < 2) ? ("32" + random.Next(1, 3) + "0") : ("70" + random.Next(0, 3) + "0"));
								break;
							case 10:
								text = "56" + num6 + "0";
								break;
							}
						}
					}
				}
				if (Newversion >= 13)
				{
					if (text == "0130")
					{
						text = "3120";
					}
					else if (text == "0250")
					{
						text = "3200";
					}
					else if (text == "0330")
					{
						text = "3320";
					}
					else if (text == "0580")
					{
						text = "3500";
					}
					else if (text == "1500")
					{
						text = "3510";
					}
					else if (text == "1700")
					{
						text = "3720";
					}
					else if (text == "1700")
					{
						text = "3720";
					}
				}
				string text2 = "";
				text2 = ((num3 != 12 && num3 != 13) ? (num3.ToString() + text + num) : (num3.ToString() + "0000" + num));
				if (array51 == null)
				{
					text2 = "0";
				}
				else if (text2[0] == '8' && (text2.Length != 6 || num > 5 || num >= Convert.ToInt32(array51[2])))
				{
					text2 = "0";
				}
				return int.Parse(text2);
			}
			default:
				return 0;
			}
		}

		public static int GetStoneValue_Fix_OldVersion(int input_min, int input_max)
		{
			try
			{
				Random random = new Random(GetRandomSeed());
				int num = Math.Min(input_min, input_max);
				int num2 = Math.Max(input_min, input_max);
				if (num2 <= num + 1)
				{
					return num;
				}
				int[] array = new int[5]
				{
					2,
					4,
					6,
					8,
					10
				};
				double num3 = num2 - num;
				double[] array2 = new double[6];
				int num4 = 0;
				array2[num4] = num3 * 2.5 / 10.0;
				for (int i = 1; i < 5; i++)
				{
					array2[i] = array2[i - 1] + num3 * 2.5 / 10.0;
				}
				int num5 = random.Next(0, 11);
				int j;
				for (j = 0; num5 >= array[j]; j++)
				{
				}
				if (j != 0)
				{
					j--;
				}
				int num6 = random.Next(0, (int)array2[j] + 1);
				if (num + num6 >= num2)
				{
					return GetStoneValue_Fix_OldVersion(num, num2);
				}
				return num + num6;
			}
			catch
			{
				return Math.Min(input_min, input_max);
			}
		}

		public static int GetStoneValue_Fix_NewVersion(int min, int max, float lucky = 1f, int[] table = null)
		{
			try
			{
				table = (table ?? new int[10]
				{
					100,
					90,
					80,
					70,
					60,
					50,
					40,
					30,
					20,
					10
				});
				int num = min;
				float num2 = (float)(max - min) * 1f / (float)table.Length;
				int num3 = 0;
				for (int i = 0; i < table.Length; i++)
				{
					num3 += table[i];
				}
				num3 = (int)((float)new Random(GetRandomSeed()).Next(0, num3) * lucky);
				int num4 = 0;
				for (int i = 0; i < table.Length; i++)
				{
					num4 += table[i];
					if (num3 < num4)
					{
						num = min + (int)(num2 * (float)i + (float)new Random(GetRandomSeed()).Next(0, (int)(num2 + 1f)));
						break;
					}
				}
				if (num < min)
				{
					num = min;
				}
				if (num >= max)
				{
					num = max - 1;
				}
				return num;
			}
			catch
			{
				return Math.Min(min, max);
			}
		}

		public static int GetStoneValue_Fix(int value1, int value2, float lucky = 1f, int[] table = null)
		{
			if (table == null)
			{
				return GetStoneValue_Fix_OldVersion(value1, value2);
			}
			return GetStoneValue_Fix_NewVersion(value1, value2, lucky, table);
		}

		private static void old_acctor_mc()
		{
			人物最高等级 = 255;
			安全区地图 = 101;
			安全区x坐标 = 412f;
			安全区y坐标 = 1512f;
			ServerVer = 5.0;
			ServerVerD = 0.0;
			ServerRegTime = "";
			Droplog = false;
			AllItmelog = 0;
			AlWorldlog = true;
			Process = false;
			百宝阁属性物品类list = new Dictionary<int, 百宝阁类>();
			百宝阁属性物品类list2 = new Dictionary<int, 百宝阁类>();
			装备检测list = new Dictionary<int, 装备检测类>();
			冲关地图list = new Dictionary<string, 冲关地图类>();
			箱子送元宝 = new Dictionary<int, 箱子送元宝类>();
			石头属性调整 = new Dictionary<int, 石头属性调整类>();
			List = new ThreadSafeDictionary<int, NetState>();
			EventTop = new Dictionary<string, EventTopClass>();
			AllConnectedChars = new ThreadSafeDictionary<int, Players>();
			gclass11_3 = new ThreadSafeDictionary<int, Players>();
			升天气功List = new Dictionary<int, 升天气功总类>();
			Db = new Dictionary<string, DbClass>();
			Iplist = new ThreadSafeDictionary<int, 客户端IP地址>();
			MDisposed = Queue.Synchronized(new Queue());
			SqlPool = Queue.Synchronized(new Queue());
			Map = new Dictionary<int, MapClass>();
			转职属性数据 = new Dictionary<int, TransferAttributes>();
			等级奖励数据 = new Dictionary<int, 等级奖励类>();
			在线时间奖励数据 = new Dictionary<int, 在线时间奖励类>();
			转生次数数据 = new Dictionary<int, 转生次数类>();
			物品兑换数据 = new Dictionary<int, 物品兑换类>();
			帮战list = new Dictionary<int, 帮战Class>();
			时间药 = new Dictionary<int, 时间药类>();
			DropJl = new List<DropClass>();
			Script = 0;
			情侣开关 = 0;
			单个物品大小 = 88;
			升天技能等级加成 = 3;
			外挂pk时间 = 0;
			AutGc = 0;
			Locklist = 0.0;
			Locklist2 = 0.0;
			Locklist3 = new List<object>();
			游戏登陆端口最大连接数 = 20;
			游戏登陆端口最大连接时间数 = 1000;
			查非法物品 = 0;
			查非法物品操作 = 3;
			查绑定非法物品 = false;
			物品最高攻击值 = 0;
			物品最高防御值 = 0;
			物品最高生命值 = 0;
			物品最高内功值 = 0;
			物品最高命中值 = 0;
			物品最高回避值 = 0;
			物品最高武功值 = 0;
			物品最高气功值 = 0;
			物品最高合成值 = 0;
			上线属性提示开关 = 0;
			套装发送开启 = 0;
			发言等级 = 0;
			物品记录 = 0;
			登陆记录 = 0;
			记录保存天数 = 30;
			封ip = true;
			BipList = new List<IPAddress>();
			自动连接时间 = 10;
			版本验证时间 = 3000;
			主Socket = false;
			自动开启连接 = true;
			断开连接 = true;
			加入过滤列表 = true;
			关闭连接 = true;
			世界时间 = 0;
			时间系统开关 = 1;
			W组队Id = 1;
			Ver = 3;
			Tf = 0;
			JlMsg = 0;
			是否启用跑卡技能 = 0;
			Time_Use_Item = 500;
			势力战进程 = 0;
			势力战时间 = 0;
			势力战正分数 = 0;
			势力战邪分数 = 0;
			势力战正人数 = 0;
			势力战邪人数 = 0;
			势力战是否开启 = 0;
			势力战开启小时 = 0;
			势力战开启分 = 0;
			势力战开启秒 = 0;
			是否启用异常出血 = 0;
			怪物死亡触发器 = 0;
			AtPort = 55980;
			短信充值是否开启 = "0";
			短信服务器webid = "0";
			短信业务号码 = "0";
			短信通道号码 = "0";
			创建门派需要等级 = 60;
			创建门派需要金钱 = 10000000;
			创建门派所需物品id = "";
			Func_Offline_ItemID = "";
			加锁元宝数 = 0;
			解锁元宝数 = 0;
			元宝合成 = 0;
			IdItemX2 = 1000000921;
			IdItemX3 = 1000000921;
			气功百分比 = 1.0;
			天佑之气百分比 = 1.0;
			FixDamage = 1.0;
			最大气功数 = 60;
			医生回气疗伤加血量 = 110;
			医生运气疗伤加血量 = 160;
			医生聚气疗伤加血量 = 180;
			最大钱数 = 10000000000L;
			是否开启新元宝商店 = 0;
			允许物品出售最大元宝数量 = 100000;
			发送速度 = 0.0;
			广播发送速度 = 0.0;
			接收速度 = 0.0;
			Vip经验倍数百分比 = 0.3;
			Vip历练倍数百分比 = 0.3;
			经验倍数 = 100;
			吸魂机率 = 70;
			吸魂开关 = 0;
			吸魂随机数量 = "1;3";
			组队级别限制 = 0;
			钱倍数 = 580;
			历练倍数 = 80;
			升天历练倍数 = 80.0;
			暴率 = 800;
			戒指刻字需要金币 = 10000000;
			合成率控制 = "0;100";
			合成率 = 0.0;
			Vip合成率 = 0.0;
			附魂合成率增加 = 0.0;
			百宝阁地址 = "http://bbg.xwwl.net/login.aspx?server=1";
			百宝阁服务器ip = "127.0.0.1";
			百宝阁服务器端口 = 9001;
			int_12580 = 2;
			int_1140 = 1;
			int_12581 = "5;25";
			披风强化总概率 = "20;180";
			披风强化一阶段概率 = 1.1;
			披风强化二阶段概率 = 1.1;
			披风强化三阶段概率 = 1.1;
			披风强化四阶段概率 = 1.1;
			披风强化五阶段概率 = 1.1;
			披风强化六阶段概率 = 1.1;
			披风强化七阶段概率 = 1.1;
			披风强化八阶段概率 = 1.1;
			帐号验证服务器ip = "127.0.0.1";
			帐号验证服务器端口 = 55970;
			游戏服务器端口 = 13001;
			游戏服务器端口2 = 13001;
			版本切换 = 0;
			气功是否有效 = 1;
			是否启动披风强化 = 0;
			Vip线 = 0;
			安全区开关 = 1;
			最大在线 = 100;
			Server_Group_ID = 1;
			服务器id = 0;
			ServerName = "Hiêòp Khaìch";
			进入公告 = "Hiêòp Khaìch Giang HôÌ";
			开箱子送元宝 = "";
			过滤文字替换 = "Hiêòp Khaìch Giang HôÌ";
			转生命令 = "!taisinh";
			求婚命令 = "!求婚";
			离婚命令 = "!离婚";
			查时间命令 = "!在线时间";
			附魂命令 = "!附魂";
			清理背包命令 = "!清理背包";
			卡号自救命令 = "!卡号自救";
			清理绑定背包命令 = "!清理绑定背包";
			查看信息命令 = "!信息";
			升级会员命令 = "!升级会员";
			Setgm = "!qweqweqq";
			移动命令 = "!move";
			Enable_Func_Offline = 0;
			Map_Func_Offline = 101;
			Level_Func_Offline = 100;
			Command_Func_Offline = "!离线挂机";
			狮子吼id = 0;
			狮子吼List = Queue.Synchronized(new Queue());
			狮子吼最大数 = 100;
			是否加密 = 1;
			是否加密2 = 0;
			背包扩充开关 = 0;
			武功防御力控制 = 100;
			武功攻击力控制 = 100;
			攻击距离 = 100;
			Pk等级差 = 15;
			是否开启武勋系统 = 0;
			死亡经验掉落是否开启 = 0;
			死亡掉落经验调整 = 0.013;
			武勋保护等级 = 80;
			死亡减少武勋数量 = "0;0;0;0;0;0";
			系统回收量 = "0;0;0;0;0;0";
			封包封号 = 0;
			Debug = 0;
			Fixbugngoc130 = 1;
			ExpParty = 0.1;
			Pk开关 = 0;
			启动职业气功热血石 = 0;
			Vip上线公告 = 0;
			Vip上线公告内容 = "尊贵的VIP玩家{0}上线了！大家欢迎！";
			七彩上线签名 = 0;
			七彩上线签名内容 = "尊贵的七彩个性签名VIP玩家【{0}】呼啦啦的牛B上线了！大家欢迎！!!";
			坐牢杀人公告 = "{0}杀人啦！";
			刑满释放公告 = "{0}刑满释放了！";
			信任连接ip = "";
			允许多开数量 = 2;
			VersionClient = 0;
			FIXLAG = 0;
			AFKTLC = 0;
			Eventx2 = 0;
			Eventx3 = 0;
			AoChoangThang = 6996;
			Sudocungphai = 0;
			Newversion = 9;
			ThuPhiVoHuan8 = 0;
			CreateNewJob = 0;
			AlphaTest = 0;
			CuonghoaMatItem = 0;
			Open_Auto_GiftCode = 0;
			DelayDisableNpc = new string[2]
			{
				"300000",
				"900000"
			};
			DamageComBoQuyenSu = new string[6]
			{
				"0.2",
				"0.4",
				"0.6",
				"0.8",
				"1.0",
				"1.2"
			};
			Config_Auto_GiftCode = new string[1]
			{
				""
			};
			Vip地图 = "";
			冲关地图 = "";
			SqlJl = "";
			元宝检测 = 0;
			装备最大数 = 36;
			自动存档 = 1;
			攻击确认模式 = 0;
			FIX_ULPT = 0.0;
			FIX_PILL_EXP = 5.0;
			宠物攻击力倍数 = 2;
			物品兑换lua脚本是否开启 = 0;
			EventX2ExpStatus = 0;
			EventX3ExpStatus = 0;
			TextTbBaotri = "";
			Numv13 = 0;
			文本兑换 = new Dictionary<string, 文本兑换类>();
			制作物品列表 = new Dictionary<int, clsItemCraft>();
			try
			{
				套装列表 = new Dictionary<int, 套装列表类>();
				套装 = new List<套装属性类>();
				Kill = new List<KillClass>();
				GiftCode = new List<GiftcodeClass>();
				GiftCodeRewards = new List<GiftCodeRewardsClass>();
				PartyClass = new Dictionary<int, 组队Class>();
				石头属性调整 = new Dictionary<int, 石头属性调整类>();
				公告 = new Dictionary<int, 公告类>();
				Level = new Dictionary<int, double>();
				Wxlever = new Dictionary<int, double>();
				Itme = new Dictionary<int, ItmeClass>();
				等级奖励数据 = new Dictionary<int, 等级奖励类>();
				在线时间奖励数据 = new Dictionary<int, 在线时间奖励类>();
				转生次数数据 = new Dictionary<int, 转生次数类>();
				物品兑换数据 = new Dictionary<int, 物品兑换类>();
				转职属性数据 = new Dictionary<int, TransferAttributes>();
				ItmeTeM = new ThreadSafeDictionary<long, 地面物品类>();
				TblKongfu = new Dictionary<int, 武功类>();
				TblQuestDrop = new Dictionary<int, TBL_QUESTDROP>();
				MonSter = new Dictionary<int, MonSterClss>();
				物品检查 = new List<检查物品类>();
				BossDrop = new List<DropClass>();
				NpcDrop = new List<NpcDropClass>();
				Drop = new List<DropClass>();
				list制作药品表 = new List<制作药品表>();
				DropGs = new List<DropClass>();
				Open = new List<OpenClass>();
				Shot = new List<ShotClass>();
				Mover = new List<MoveClass>();
				Map_Move = new List<坐标Class>();
				安全区 = new List<坐标Class>();
			}
			catch (Exception arg)
			{
				Form1.WriteLine(100, "系统错误:World" + arg);
				Environment.Exit(0);
			}
		}

		public static void ProcessDisposedQueue()
		{
			int num = 0;
			try
			{
				int num2 = 0;
				while (num2 < 200 && MDisposed.Count > 0)
				{
					if (JlMsg == 1)
					{
						Form1.WriteLine(0, "ProcessDisposedQueue");
					}
					num2++;
					NetState netState = (NetState)MDisposed.Dequeue();
					try
					{
						num = 1;
						if (netState != null)
						{
							Form1.WriteLine(3, "Logout[" + netState.WorldId + "]-[" + netState.ToString() + "]");
							num = 2;
							if (netState.在线)
							{
								netState.IDout();
							}
							num = 3;
							if (netState.Player != null)
							{
								num = 4;
								netState.Player.Logout();
								num = 5;
								netState.Player.Dispose();
							}
							num = 6;
							if (AllConnectedChars.ContainsKey(netState.WorldId))
							{
								num = 7;
								AllConnectedChars.Remove(netState.WorldId);
							}
							num = 8;
							netState.Player = null;
							num = 9;
							netState.delWorldIdd();
							num = 10;
						}
						else
						{
							Form1.WriteLine(1, "ns is null");
						}
					}
					catch (Exception ex)
					{
						Form1.WriteLine(1, "ProcessDisposedQueue()出错 " + num + "  " + ex.Message);
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "ProcessDisposedQueue()出错2 " + num + " 数据队列:" + (string)(object)MDisposed.Count + "  " + ex.Message);
			}
		}

		public static void ProcessSqlQueue()
		{
			try
			{
				while (SqlPool.Count > 0)
				{
					if (JlMsg == 1)
					{
						Form1.WriteLine(0, "ProcessSqlQueue");
					}
					DbPoolClass dbPoolClass = (DbPoolClass)SqlPool.Dequeue();
					try
					{
						if (DbPoolClass.DbPoolClassRun(dbPoolClass.Conn, dbPoolClass.Sql, dbPoolClass.Prams, dbPoolClass.Type) == -1)
						{
							SqlPool.Enqueue(dbPoolClass);
							Form1.WriteLine(1, "ProcessSqlQueue()2 数据库连接出错 " + SqlPool.Count);
							Thread.Sleep(100);
						}
					}
					catch (Exception arg)
					{
						Form1.WriteLine(1, "ProcessSqlQueue()1出错 " + arg);
						Thread.Sleep(100);
					}
				}
			}
			catch (Exception arg)
			{
				Form1.WriteLine(1, "ProcessSqlQueue()出错 " + arg);
			}
		}

		public static void Process狮子吼Queue()
		{
			if (狮子吼List.Count > 0)
			{
				if (JlMsg == 1)
				{
					Form1.WriteLine(0, "Process狮子吼Queue()");
				}
				狮子吼Class 狮子吼Class = (狮子吼Class)狮子吼List.Dequeue();
				发送狮子吼消息广播数据(狮子吼Class.FLD_INDEX, 狮子吼Class.UserName, 狮子吼Class.TxtId, 狮子吼Class.Txt);
			}
		}

		public static string PWord(string sSource, int iFlag)
		{
			if (sSource == null)
			{
				return null;
			}
			if (sSource.Equals(""))
			{
				return "";
			}
			string text = "";
			if (iFlag == 2)
			{
				int length = sSource.Length;
				text = "";
				int num = Convert.ToInt32(sSource.ToCharArray(0, 1)[0]) % 10;
				for (int i = 2; i < length; i += 2)
				{
					int num2 = Convert.ToInt32(sSource.ToCharArray(i, 1)[0]);
					string str = (Convert.ToInt32(sSource.ToCharArray(i - 1, 1)[0]) % 2 != 0) ? ((char)(ushort)(num2 - (i - 1) / 2 - num)).ToString() : ((char)(ushort)(num2 + (i - 1) / 2 + num)).ToString();
					text += str;
				}
			}
			return text;
		}

		public static void SerNpc(int npcid, float x, float y, int mapp, int isNpc = 0)
		{
			try
			{
				SetMonSter();
				if (MonSter.TryGetValue(npcid, out MonSterClss value))
				{
					NpcClass npcClass = new NpcClass();
					npcClass.FldPid = value.FLD_PID;
					npcClass.Name = value.Name;
					npcClass.Level = value.Level;
					npcClass.RxjhExp = value.Rxjh_Exp;
					npcClass.RxjhX = x;
					npcClass.RxjhY = y;
					npcClass.RxjhZ = 15f;
					npcClass.RxjhCsX = x;
					npcClass.RxjhCsY = y;
					npcClass.RxjhCsZ = 15f;
					npcClass.RxjhMap = mapp;
					npcClass.IsNpc = isNpc;
					npcClass.FldFace1 = 0f;
					npcClass.FldFace2 = 0f;
					npcClass.MaxRxjhHp = value.Rxjh_HP;
					npcClass.RxjhHp = value.Rxjh_HP;
					npcClass.FldAt = value.FLD_AT;
					npcClass.FldDf = value.FLD_DF;
					npcClass.FldAuto = value.FLD_AUTO;
					npcClass.FldBoss = value.FLD_BOSS;
					if (Map.TryGetValue(npcClass.RxjhMap, out MapClass value2))
					{
						value2.add(npcClass);
					}
					else
					{
						MapClass mapClass = new MapClass();
						mapClass.MapID = npcClass.RxjhMap;
						mapClass.add(npcClass);
						Map.Add(mapClass.MapID, mapClass);
					}
					npcClass.获取范围玩家发送增加数据包();
					DBA.ExeSqlCommand($"INSERT INTO TBL_XWWL_NPC(FLD_PID,FLD_X,FLD_Y,FLD_Z,FLD_FACE0,FLD_FACE,FLD_MID,FLD_NAME,FLD_HP,FLD_AT,FLD_DF,FLD_NPC,FLD_NEWTIME,FLD_LEVEL,FLD_EXP,FLD_AUTO,FLD_BOSS)VALUES ('{npcClass.FldPid}','{x}','{y}','{15}','{0}','{0}','{npcClass.RxjhMap}','{npcClass.Name}','{npcClass.MaxRxjhHp}','{npcClass.FldAt}','{npcClass.FldDf}','{npcClass.IsNpc}','{10000}','{npcClass.Level}','{npcClass.RxjhExp}','{npcClass.FldAuto}','{npcClass.FldBoss}')", "PublicDb");
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(2, "增加怪 [" + npcid + "]出错：" + ex);
			}
		}

		public static void Set_GSDrop()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_XWWL_DROP_GS ORDER BY FLD_LEVEL1, FLD_LEVEL2", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载高手怪掉落物品完成----没有物品数据");
			}
			else
			{
				DropGs.Clear();
				int num = 0;
				while (true)
				{
					bool flag = true;
					if (num < dBToDataTable.Rows.Count)
					{
						DropClass dropClass = new DropClass();
						try
						{
							dropClass.FLD_LEVEL1 = (int)dBToDataTable.Rows[num]["FLD_LEVEL1"];
							dropClass.FLD_LEVEL2 = (int)dBToDataTable.Rows[num]["FLD_LEVEL2"];
							dropClass.FLD_PID = (int)dBToDataTable.Rows[num]["FLD_PID"];
							dropClass.FLD_PP = (int)dBToDataTable.Rows[num]["FLD_PP"];
							dropClass.FLD_NAME = dBToDataTable.Rows[num]["FLD_NAME"].ToString();
							dropClass.FLD_MAGIC0 = (int)dBToDataTable.Rows[num]["FLD_MAGIC0"];
							dropClass.FLD_MAGIC1 = (int)dBToDataTable.Rows[num]["FLD_MAGIC1"];
							dropClass.FLD_MAGIC2 = (int)dBToDataTable.Rows[num]["FLD_MAGIC2"];
							dropClass.FLD_MAGIC3 = (int)dBToDataTable.Rows[num]["FLD_MAGIC3"];
							dropClass.FLD_MAGIC4 = (int)dBToDataTable.Rows[num]["FLD_MAGIC4"];
							dropClass.FLD_MAGICNew0 = (int)dBToDataTable.Rows[num]["FLD_MAGIC0"];
							dropClass.FLD_MAGICNew1 = (int)dBToDataTable.Rows[num]["FLD_MAGIC1"];
							dropClass.FLD_MAGICNew2 = (int)dBToDataTable.Rows[num]["FLD_MAGIC2"];
							dropClass.FLD_MAGICNew3 = (int)dBToDataTable.Rows[num]["FLD_MAGIC3"];
							dropClass.FLD_MAGICNew4 = (int)dBToDataTable.Rows[num]["FLD_MAGIC4"];
							DropGs.Add(dropClass);
						}
						catch (Exception ex)
						{
							Form1.WriteLine(1, "加载掉落物品 错误" + dropClass.FLD_NAME + "  " + ex.Message);
						}
						num++;
						continue;
					}
					break;
				}
				Form1.WriteLine(2, "加载高手怪落物品 " + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void SetBossDrop()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_XWWL_BossDROP ORDER BY FLD_LEVEL1, FLD_LEVEL2", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载BOSS掉落物品完成----没有物品数据");
			}
			else
			{
				BossDrop.Clear();
				int num = 0;
				while (true)
				{
					bool flag = true;
					if (num < dBToDataTable.Rows.Count)
					{
						DropClass dropClass = new DropClass();
						try
						{
							dropClass.FLD_LEVEL1 = (int)dBToDataTable.Rows[num]["FLD_LEVEL1"];
							dropClass.FLD_LEVEL2 = (int)dBToDataTable.Rows[num]["FLD_LEVEL2"];
							dropClass.FLD_PID = (int)dBToDataTable.Rows[num]["FLD_PID"];
							dropClass.FLD_PP = (int)dBToDataTable.Rows[num]["FLD_PP"];
							dropClass.FLD_NAME = dBToDataTable.Rows[num]["FLD_NAME"].ToString();
							dropClass.FLD_MAGIC0 = (int)dBToDataTable.Rows[num]["FLD_MAGIC0"];
							dropClass.FLD_MAGIC1 = (int)dBToDataTable.Rows[num]["FLD_MAGIC1"];
							dropClass.FLD_MAGIC2 = (int)dBToDataTable.Rows[num]["FLD_MAGIC2"];
							dropClass.FLD_MAGIC3 = (int)dBToDataTable.Rows[num]["FLD_MAGIC3"];
							dropClass.FLD_MAGIC4 = (int)dBToDataTable.Rows[num]["FLD_MAGIC4"];
							dropClass.FLD_MAGICNew0 = (int)dBToDataTable.Rows[num]["FLD_MAGIC0"];
							dropClass.FLD_MAGICNew1 = (int)dBToDataTable.Rows[num]["FLD_MAGIC1"];
							dropClass.FLD_MAGICNew2 = (int)dBToDataTable.Rows[num]["FLD_MAGIC2"];
							dropClass.FLD_MAGICNew3 = (int)dBToDataTable.Rows[num]["FLD_MAGIC3"];
							dropClass.FLD_MAGICNew4 = (int)dBToDataTable.Rows[num]["FLD_MAGIC4"];
							BossDrop.Add(dropClass);
						}
						catch (Exception ex)
						{
							Form1.WriteLine(1, "加载BOSS掉落物品 错误" + dropClass.FLD_NAME + "  " + ex.Message);
						}
						num++;
						continue;
					}
					break;
				}
				Form1.WriteLine(2, "加载BOSS掉落物品 " + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void SetConfig()
		{
			try
			{
				Config.Path = Application.StartupPath + "\\GameConfiguration.ini";
				游戏登陆端口最大连接数 = ((Config.IniReadValue("GameServer", "游戏登陆端口最大连接数") == "") ? 游戏登陆端口最大连接数 : int.Parse(Config.IniReadValue("GameServer", "游戏登陆端口最大连接数")));
				游戏登陆端口最大连接时间数 = ((Config.IniReadValue("GameServer", "游戏登陆端口最大连接时间数") == "") ? 游戏登陆端口最大连接时间数 : int.Parse(Config.IniReadValue("GameServer", "游戏登陆端口最大连接时间数")));
				自动连接时间 = ((Config.IniReadValue("GameServer", "自动连接时间") == "") ? 自动连接时间 : int.Parse(Config.IniReadValue("GameServer", "自动连接时间")));
				封ip = (Config.IniReadValue("GameServer", "封IP").Trim().ToLower() == "true");
				AtPort = ((Config.IniReadValue("GameServer", "AtPort").Trim() == "") ? AtPort : int.Parse(Config.IniReadValue("GameServer", "AtPort").Trim()));
				自动开启连接 = (Config.IniReadValue("GameServer", "自动开启连接").Trim().ToLower() == "true");
				断开连接 = (Config.IniReadValue("GameServer", "断开连接").Trim().ToLower() == "true");
				加入过滤列表 = (Config.IniReadValue("GameServer", "加入过滤列表").Trim().ToLower() == "true");
				关闭连接 = (Config.IniReadValue("GameServer", "关闭连接").Trim().ToLower() == "true");
				经验倍数 = ((Config.IniReadValue("GameServer", "经验倍数").Trim() == "") ? 经验倍数 : int.Parse(Config.IniReadValue("GameServer", "经验倍数").Trim()));
				Vip经验倍数百分比 = ((Config.IniReadValue("GameServer", "VIP经验倍数百分比") == "") ? Vip经验倍数百分比 : double.Parse(Config.IniReadValue("GameServer", "VIP经验倍数百分比")));
				Vip历练倍数百分比 = ((Config.IniReadValue("GameServer", "VIP历练倍数百分比") == "") ? Vip历练倍数百分比 : double.Parse(Config.IniReadValue("GameServer", "VIP历练倍数百分比")));
				钱倍数 = ((Config.IniReadValue("GameServer", "钱倍数").Trim() == "") ? 钱倍数 : int.Parse(Config.IniReadValue("GameServer", "钱倍数").Trim()));
				吸魂开关 = ((Config.IniReadValue("GameServer", "吸魂开关").Trim() == "") ? 吸魂机率 : int.Parse(Config.IniReadValue("GameServer", "吸魂开关").Trim()));
				吸魂随机数量 = Config.IniReadValue("GameServer", "吸魂随机数量").Trim();
				吸魂机率 = ((Config.IniReadValue("GameServer", "吸魂机率").Trim() == "") ? 吸魂机率 : int.Parse(Config.IniReadValue("GameServer", "吸魂机率").Trim()));
				组队级别限制 = ((Config.IniReadValue("GameServer", "组队级别限制").Trim() == "") ? 组队级别限制 : int.Parse(Config.IniReadValue("GameServer", "组队级别限制").Trim()));
				历练倍数 = ((Config.IniReadValue("GameServer", "历练倍数").Trim() == "") ? 历练倍数 : int.Parse(Config.IniReadValue("GameServer", "历练倍数").Trim()));
				升天历练倍数 = ((Config.IniReadValue("GameServer", "升天历练倍数").Trim() == "") ? 升天历练倍数 : double.Parse(Config.IniReadValue("GameServer", "升天历练倍数").Trim()));
				FixDamage = ((Config.IniReadValue("GameServer", "FixDamage").Trim() == "") ? FixDamage : double.Parse(Config.IniReadValue("GameServer", "FixDamage").Trim()));
				暴率 = ((Config.IniReadValue("GameServer", "暴率").Trim() == "") ? 暴率 : int.Parse(Config.IniReadValue("GameServer", "暴率").Trim()));
				最大在线 = ((Config.IniReadValue("GameServer", "最大在线").Trim() == "") ? 最大在线 : int.Parse(Config.IniReadValue("GameServer", "最大在线").Trim()));
				Server_Group_ID = ((Config.IniReadValue("GameServer", "服务器组ID").Trim() == "") ? Server_Group_ID : int.Parse(Config.IniReadValue("GameServer", "服务器组ID").Trim()));
				服务器id = ((Config.IniReadValue("GameServer", "服务器ID").Trim() == "") ? 服务器id : int.Parse(Config.IniReadValue("GameServer", "服务器ID").Trim()));
				游戏服务器端口 = ((Config.IniReadValue("GameServer", "游戏服务器端口").Trim() == "") ? 游戏服务器端口 : int.Parse(Config.IniReadValue("GameServer", "游戏服务器端口").Trim()));
				版本切换 = ((Config.IniReadValue("GameServer", "版本切换").Trim() == "") ? 版本切换 : int.Parse(Config.IniReadValue("GameServer", "版本切换").Trim()));
				百宝阁服务器端口 = ((Config.IniReadValue("GameServer", "百宝阁服务器端口").Trim() == "") ? 百宝阁服务器端口 : int.Parse(Config.IniReadValue("GameServer", "百宝阁服务器端口").Trim()));
				帐号验证服务器端口 = ((Config.IniReadValue("GameServer", "帐号验证服务器端口").Trim() == "") ? 帐号验证服务器端口 : int.Parse(Config.IniReadValue("GameServer", "帐号验证服务器端口").Trim()));
				帐号验证服务器ip = Config.IniReadValue("GameServer", "帐号验证服务器IP").Trim();
				百宝阁地址 = Config.IniReadValue("GameServer", "百宝阁地址").Trim();
				ServerName = Config.IniReadValue("GameServer", "服务器名").Trim();
				过滤文字替换 = Config.IniReadValue("GameServer", "过滤文字替换").Trim();
				Vip线 = ((!(Config.IniReadValue("GameServer", "vip线").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "vip线").Trim()) : 0);
				Pk开关 = int.Parse(Config.IniReadValue("GameServer", "PK开关").Trim());
				Pk掉装备 = int.Parse(Config.IniReadValue("GameServer", "PK掉装备").Trim());
				Pk掉装备善恶 = int.Parse(Config.IniReadValue("GameServer", "PK掉装备善恶").Trim());
				Pk掉装备几率 = int.Parse(Config.IniReadValue("GameServer", "PK掉装备几率").Trim());
				江湖快报强化阶段 = int.Parse(Config.IniReadValue("GameServer", "江湖快报强化阶段").Trim());
				发言等级 = ((!(Config.IniReadValue("GameServer", "发言等级").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "发言等级").Trim()) : 0);
				手工附魂最高阶段 = int.Parse(Config.IniReadValue("GameServer", "手工附魂最高阶段").Trim());
				势力战是否开启 = int.Parse(Config.IniReadValue("GameServer", "势力战是否开启").Trim());
				势力战开启小时 = int.Parse(Config.IniReadValue("GameServer", "势力战开启小时").Trim());
				势力战开启分 = int.Parse(Config.IniReadValue("GameServer", "势力战开启分").Trim());
				势力战开启秒 = int.Parse(Config.IniReadValue("GameServer", "势力战开启秒").Trim());
				短信充值是否开启 = Config.IniReadValue("GameServer", "短信充值是否开启").Trim();
				短信服务器webid = Config.IniReadValue("GameServer", "短信服务器WEBID").Trim();
				短信业务号码 = Config.IniReadValue("GameServer", "短信业务号码").Trim();
				短信通道号码 = Config.IniReadValue("GameServer", "短信通道号码").Trim();
				AutGc = ((Config.IniReadValue("GameServer", "AutGC").Trim() == "") ? AutGc : int.Parse(Config.IniReadValue("GameServer", "AutGC").Trim()));
				封包封号 = ((!(Config.IniReadValue("GameServer", "封包封号").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "封包封号").Trim()) : 0);
				Debug = ((!(Config.IniReadValue("GameServer", "DEBUG").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "DEBUG").Trim()) : 0);
				Fixbugngoc130 = ((Config.IniReadValue("GameServer", "FIXBUGNGOC130").Trim() == "") ? Fixbugngoc130 : int.Parse(Config.IniReadValue("GameServer", "FIXBUGNGOC130").Trim()));
				Script = ((Config.IniReadValue("GameServer", "Script").Trim() == "") ? Script : int.Parse(Config.IniReadValue("GameServer", "Script").Trim()));
				狮子吼最大数 = ((Config.IniReadValue("GameServer", "狮子吼最大数") == "") ? 50 : int.Parse(Config.IniReadValue("GameServer", "狮子吼最大数")));
				合成率控制 = Config.IniReadValue("GameServer", "合成率控制").Trim();
				ExpParty = ((Config.IniReadValue("GameServer", "Exp_Party") == "") ? ExpParty : double.Parse(Config.IniReadValue("GameServer", "Exp_Party")));
				合成率 = ((Config.IniReadValue("GameServer", "合成率") == "") ? 合成率 : double.Parse(Config.IniReadValue("GameServer", "合成率")));
				元宝合成 = ((Config.IniReadValue("GameServer", "元宝合成").Trim() == "") ? 元宝合成 : int.Parse(Config.IniReadValue("GameServer", "元宝合成").Trim()));
				加锁元宝数 = ((Config.IniReadValue("GameServer", "加锁元宝数").Trim() == "") ? 加锁元宝数 : int.Parse(Config.IniReadValue("GameServer", "加锁元宝数").Trim()));
				解锁元宝数 = ((Config.IniReadValue("GameServer", "解锁元宝数").Trim() == "") ? 解锁元宝数 : int.Parse(Config.IniReadValue("GameServer", "解锁元宝数").Trim()));
				是否加密 = ((Config.IniReadValue("GameServer", "是否加密").Trim() == "") ? 是否加密 : int.Parse(Config.IniReadValue("GameServer", "是否加密").Trim()));
				版本验证时间 = ((Config.IniReadValue("GameServer", "版本验证时间").Trim() == "") ? 版本验证时间 : int.Parse(Config.IniReadValue("GameServer", "版本验证时间").Trim()));
				开箱子送元宝 = Config.IniReadValue("GameServer", "开箱子送元宝").Trim();
				Vip上线公告 = ((Config.IniReadValue("GameServer", "Vip上线公告").Trim() == "") ? Vip上线公告 : int.Parse(Config.IniReadValue("GameServer", "Vip上线公告").Trim()));
				IdItemX3 = ((Config.IniReadValue("GameServer", "IDItemX2").Trim() == "") ? IdItemX3 : int.Parse(Config.IniReadValue("GameServer", "IDItemX3").Trim()));
				IdItemX2 = ((Config.IniReadValue("GameServer", "IDItemX2").Trim() == "") ? IdItemX2 : int.Parse(Config.IniReadValue("GameServer", "IDItemX2").Trim()));
				七彩上线签名 = ((Config.IniReadValue("GameServer", "七彩上线签名").Trim() == "") ? 七彩上线签名 : int.Parse(Config.IniReadValue("GameServer", "七彩上线签名").Trim()));
				创建门派需要等级 = ((Config.IniReadValue("GameServer", "创建门派需要等级").Trim() == "") ? 创建门派需要等级 : int.Parse(Config.IniReadValue("GameServer", "创建门派需要等级").Trim()));
				创建门派需要金钱 = ((Config.IniReadValue("GameServer", "创建门派需要金钱").Trim() == "") ? 创建门派需要金钱 : int.Parse(Config.IniReadValue("GameServer", "创建门派需要金钱").Trim()));
				创建门派所需物品id = Config.IniReadValue("GameServer", "创建门派所需物品ID").Trim();
				安全区开关 = ((Config.IniReadValue("GameServer", "安全区开关").Trim() == "") ? 安全区开关 : int.Parse(Config.IniReadValue("GameServer", "安全区开关").Trim()));
				Vip上线公告内容 = ((Config.IniReadValue("GameServer", "Vip上线公告内容").Trim() == "") ? Vip上线公告内容 : Config.IniReadValue("GameServer", "Vip上线公告内容").Trim());
				七彩上线签名内容 = ((Config.IniReadValue("GameServer", "七彩上线签名内容").Trim() == "") ? 七彩上线签名内容 : Config.IniReadValue("GameServer", "七彩上线签名内容").Trim());
				Vip地图 = Config.IniReadValue("GameServer", "VIP地图").Trim();
				背包扩充开关 = ((Config.IniReadValue("GameServer", "背包扩充开关").Trim() == "") ? 背包扩充开关 : int.Parse(Config.IniReadValue("GameServer", "背包扩充开关").Trim()));
				冲关地图 = Config.IniReadValue("GameServer", "冲关地图").Trim();
				Vip合成率 = ((Config.IniReadValue("GameServer", "VIP合成率") == "") ? Vip合成率 : double.Parse(Config.IniReadValue("GameServer", "VIP合成率")));
				附魂合成率增加 = ((Config.IniReadValue("GameServer", "附魂合成率增加") == "") ? 附魂合成率增加 : double.Parse(Config.IniReadValue("GameServer", "附魂合成率增加")));
				是否开启转生次数奖励 = int.Parse(Config.IniReadValue("GameServer", "是否开启转生次数奖励").Trim());
				限制转生次数 = int.Parse(Config.IniReadValue("GameServer", "限制转生次数").Trim());
				转生需要几转 = int.Parse(Config.IniReadValue("GameServer", "转生需要几转").Trim());
				转生降落几转 = int.Parse(Config.IniReadValue("GameServer", "转生降落几转").Trim());
				转生需要等级 = int.Parse(Config.IniReadValue("GameServer", "转生需要等级").Trim());
				转生回落等级 = int.Parse(Config.IniReadValue("GameServer", "转生回落等级").Trim());
				转生奖励类型 = int.Parse(Config.IniReadValue("GameServer", "转生奖励类型").Trim());
				转生奖励数量 = int.Parse(Config.IniReadValue("GameServer", "转生奖励数量").Trim());
				转生获得属性 = Config.IniReadValue("GameServer", "转生获得属性").Trim();
				转生奖励物品 = Config.IniReadValue("GameServer", "转生奖励物品").Trim();
				转生奖励套装 = int.Parse(Config.IniReadValue("GameServer", "转生奖励套装").Trim());
				转生公告 = int.Parse(Config.IniReadValue("GameServer", "转生公告").Trim());
				转生公告内容 = Config.IniReadValue("GameServer", "转生公告内容").Trim();
				死亡经验掉落是否开启 = int.Parse(Config.IniReadValue("GameServer", "死亡经验掉落是否开启").Trim());
				是否开启武勋系统 = int.Parse(Config.IniReadValue("GameServer", "是否开启武勋系统").Trim());
				Time_Use_Item = ((Config.IniReadValue("GameServer", "Time_Use_Item").Trim() == "") ? Time_Use_Item : int.Parse(Config.IniReadValue("GameServer", "Time_Use_Item").Trim()));
				死亡掉落经验调整 = ((Config.IniReadValue("GameServer", "死亡掉落经验调整").Trim() == "") ? 死亡掉落经验调整 : double.Parse(Config.IniReadValue("GameServer", "死亡掉落经验调整").Trim()));
				是否启用异常出血 = int.Parse(Config.IniReadValue("GameServer", "是否启用异常出血").Trim());
				Pk等级差 = int.Parse(Config.IniReadValue("GameServer", "PK等级差").Trim());
				攻击距离 = int.Parse(Config.IniReadValue("GameServer", "攻击距离").Trim());
				戒指刻字需要金币 = ((Config.IniReadValue("GameServer", "戒指刻字需要金币").Trim() == "") ? 戒指刻字需要金币 : int.Parse(Config.IniReadValue("GameServer", "戒指刻字需要金币").Trim()));
				武勋保护等级 = int.Parse(Config.IniReadValue("GameServer", "武勋保护等级").Trim());
				死亡减少武勋数量 = Config.IniReadValue("GameServer", "死亡减少武勋数量").Trim();
				系统回收量 = Config.IniReadValue("GameServer", "系统回收数量").Trim();
				武勋阶段1 = Config.IniReadValue("GameServer", "武勋阶段1").Trim().Split(';');
				武勋阶段2 = Config.IniReadValue("GameServer", "武勋阶段2").Trim().Split(';');
				武勋阶段3 = Config.IniReadValue("GameServer", "武勋阶段3").Trim().Split(';');
				武勋阶段4 = Config.IniReadValue("GameServer", "武勋阶段4").Trim().Split(';');
				武勋阶段5 = Config.IniReadValue("GameServer", "武勋阶段5").Trim().Split(';');
				武勋阶段6 = Config.IniReadValue("GameServer", "武勋阶段6").Trim().Split(';');
				武勋阶段7 = Config.IniReadValue("GameServer", "武勋阶段7").Trim().Split(';');
				武勋阶段8 = Config.IniReadValue("GameServer", "武勋阶段8").Trim().Split(';');
				增加防御药品 = Config.IniReadValue("GameServer", "增加防御药品").Trim().Split(';');
				增加攻击药品 = Config.IniReadValue("GameServer", "增加攻击药品").Trim().Split(';');
				增加生命药品 = Config.IniReadValue("GameServer", "增加生命药品").Trim().Split(';');
				属性扩展是否开启 = int.Parse(Config.IniReadValue("GameServer", "属性扩展是否开启").Trim());
				转生次数领奖控制 = int.Parse(Config.IniReadValue("GameServer", "转生次数领奖控制").Trim());
				是否开启等级奖励 = int.Parse(Config.IniReadValue("GameServer", "是否开启等级奖励").Trim());
				查非法物品 = ((Config.IniReadValue("GameServer", "查非法物品").Trim() == "") ? 查非法物品 : int.Parse(Config.IniReadValue("GameServer", "查非法物品").Trim()));
				查绑定非法物品 = ((Config.IniReadValue("GameServer", "查绑定非法物品").Trim() == "") ? 查绑定非法物品 : (Config.IniReadValue("GameServer", "查绑定非法物品").Trim() == "1"));
				查非法物品操作 = ((Config.IniReadValue("GameServer", "查非法物品操作").Trim() == "") ? 查非法物品操作 : int.Parse(Config.IniReadValue("GameServer", "查非法物品操作").Trim()));
				物品最高攻击值 = ((Config.IniReadValue("GameServer", "物品最高攻击值").Trim() == "") ? 物品最高攻击值 : int.Parse(Config.IniReadValue("GameServer", "物品最高攻击值").Trim()));
				物品最高防御值 = ((Config.IniReadValue("GameServer", "物品最高防御值").Trim() == "") ? 物品最高防御值 : int.Parse(Config.IniReadValue("GameServer", "物品最高防御值").Trim()));
				物品最高生命值 = ((Config.IniReadValue("GameServer", "物品最高生命值").Trim() == "") ? 物品最高生命值 : int.Parse(Config.IniReadValue("GameServer", "物品最高生命值").Trim()));
				物品最高内功值 = ((Config.IniReadValue("GameServer", "物品最高内功值").Trim() == "") ? 物品最高内功值 : int.Parse(Config.IniReadValue("GameServer", "物品最高内功值").Trim()));
				物品最高命中值 = ((Config.IniReadValue("GameServer", "物品最高命中值").Trim() == "") ? 物品最高命中值 : int.Parse(Config.IniReadValue("GameServer", "物品最高命中值").Trim()));
				物品最高回避值 = ((Config.IniReadValue("GameServer", "物品最高回避值").Trim() == "") ? 物品最高回避值 : int.Parse(Config.IniReadValue("GameServer", "物品最高回避值").Trim()));
				物品最高武功值 = ((Config.IniReadValue("GameServer", "物品最高武功值").Trim() == "") ? 物品最高武功值 : int.Parse(Config.IniReadValue("GameServer", "物品最高武功值").Trim()));
				物品最高气功值 = ((Config.IniReadValue("GameServer", "物品最高气功值").Trim() == "") ? 物品最高气功值 : int.Parse(Config.IniReadValue("GameServer", "物品最高气功值").Trim()));
				物品最高合成值 = ((Config.IniReadValue("GameServer", "物品最高合成值").Trim() == "") ? 物品最高合成值 : int.Parse(Config.IniReadValue("GameServer", "物品最高合成值").Trim()));
				势力战奖励类型 = int.Parse(Config.IniReadValue("GameServer", "势力战奖励类型").Trim());
				势力战奖励属性 = Config.IniReadValue("GameServer", "势力战奖励属性").Trim();
				势力战奖励物品 = Config.IniReadValue("GameServer", "势力战奖励物品").Trim();
				势力战奖励套装 = int.Parse(Config.IniReadValue("GameServer", "势力战奖励套装").Trim());
				上线送礼包是否开启 = int.Parse(Config.IniReadValue("GameServer", "上线送礼包是否开启").Trim());
				上线送礼包套装 = int.Parse(Config.IniReadValue("GameServer", "上线送礼包套装").Trim());
				新手上线奖励是否开启 = int.Parse(Config.IniReadValue("GameServer", "新手上线奖励是否开启").Trim());
				新手上线奖励 = Config.IniReadValue("GameServer", "新手上线奖励").Trim();
				是否启用会员升级 = int.Parse(Config.IniReadValue("GameServer", "是否启用会员升级").Trim());
				武器附魂增加属性数量 = int.Parse(Config.IniReadValue("GameServer", "武器附魂增加属性数量").Trim());
				衣服附魂增加属性数量 = int.Parse(Config.IniReadValue("GameServer", "衣服附魂增加属性数量").Trim());
				耳环加工一阶段增加生命 = int.Parse(Config.IniReadValue("GameServer", "耳环加工一阶段增加生命").Trim());
				项链加工一阶段增加防御 = int.Parse(Config.IniReadValue("GameServer", "项链加工一阶段增加防御").Trim());
				戒指加工一阶段增加攻击 = int.Parse(Config.IniReadValue("GameServer", "戒指加工一阶段增加攻击").Trim());
				SqlJl = ((Config.IniReadValue("GameServer", "SqlJl").Trim() == "") ? SqlJl : Config.IniReadValue("GameServer", "SqlJl").Trim());
				自动存档 = ((Config.IniReadValue("GameServer", "自动存档").Trim() == "") ? 自动存档 : int.Parse(Config.IniReadValue("GameServer", "自动存档").Trim()));
				物品记录 = ((Config.IniReadValue("GameServer", "物品记录").Trim() == "") ? 物品记录 : int.Parse(Config.IniReadValue("GameServer", "物品记录").Trim()));
				登陆记录 = ((Config.IniReadValue("GameServer", "登陆记录").Trim() == "") ? 登陆记录 : int.Parse(Config.IniReadValue("GameServer", "登陆记录").Trim()));
				记录保存天数 = ((Config.IniReadValue("GameServer", "记录保存天数").Trim() == "") ? 记录保存天数 : int.Parse(Config.IniReadValue("GameServer", "记录保存天数").Trim()));
				元宝检测 = ((Config.IniReadValue("GameServer", "元宝检测").Trim() == "") ? 元宝检测 : int.Parse(Config.IniReadValue("GameServer", "元宝检测").Trim()));
				情侣开关 = ((!(Config.IniReadValue("GameServer", "情侣开关").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "情侣开关").Trim()) : 0);
				外挂pk时间 = ((!(Config.IniReadValue("GameServer", "外挂PK开关").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "外挂PK开关").Trim()) : 0);
				升天技能等级加成 = ((Config.IniReadValue("GameServer", "升天技能等级加成").Trim() == "") ? 1 : int.Parse(Config.IniReadValue("GameServer", "升天技能等级加成").Trim()));
				登陆器模式 = int.Parse(Config.IniReadValue("GameServer", "登陆器模式").Trim());
				攻击确认模式 = ((Config.IniReadValue("GameServer", "攻击确认模式").Trim() == "") ? 攻击确认模式 : int.Parse(Config.IniReadValue("GameServer", "攻击确认模式").Trim()));
				是否开启元宝商店 = int.Parse(Config.IniReadValue("GameServer", "是否开启元宝商店").Trim());
				查看装备开关 = int.Parse(Config.IniReadValue("GameServer", "查看装备开关").Trim());
				FIX_ULPT = ((Config.IniReadValue("GameServer", "FIX_ULPT").Trim() == "") ? FIX_ULPT : double.Parse(Config.IniReadValue("GameServer", "FIX_ULPT").Trim()));
				FIX_PILL_EXP = ((Config.IniReadValue("GameServer", "FIX_PILL_EXP").Trim() == "") ? FIX_PILL_EXP : double.Parse(Config.IniReadValue("GameServer", "FIX_PILL_EXP").Trim()));
				武功攻击力控制 = int.Parse(Config.IniReadValue("GameServer", "武功攻击力控制").Trim());
				武功防御力控制 = int.Parse(Config.IniReadValue("GameServer", "武功防御力控制").Trim());
				Setgm = Config.IniReadValue("GameServer", "SETGM").Trim();
				移动命令 = Config.IniReadValue("GameServer", "移动命令").Trim();
				查看信息命令 = Config.IniReadValue("GameServer", "查看信息命令").Trim();
				升级会员命令 = Config.IniReadValue("GameServer", "升级会员命令").Trim();
				求婚命令 = Config.IniReadValue("GameServer", "求婚命令").Trim();
				转生命令 = Config.IniReadValue("GameServer", "转生命令").Trim();
				清理背包命令 = Config.IniReadValue("GameServer", "清理背包命令").Trim();
				清理绑定背包命令 = Config.IniReadValue("GameServer", "清理绑定背包命令").Trim();
				附魂命令 = Config.IniReadValue("GameServer", "附魂命令").Trim();
				离婚命令 = Config.IniReadValue("GameServer", "离婚命令").Trim();
				查时间命令 = Config.IniReadValue("GameServer", "查时间命令").Trim();
				卡号自救命令 = Config.IniReadValue("GameServer", "卡号自救命令").Trim();
				发公告 = Config.IniReadValue("GameServer", "发公告").Trim();
				移动传送 = Config.IniReadValue("GameServer", "移动传送").Trim();
				复制物品 = Config.IniReadValue("GameServer", "复制物品").Trim();
				追加状态 = Config.IniReadValue("GameServer", "追加状态").Trim();
				开始势力战 = Config.IniReadValue("GameServer", "开始势力战").Trim();
				刷钱 = Config.IniReadValue("GameServer", "刷钱").Trim();
				刷武勋 = Config.IniReadValue("GameServer", "刷武勋").Trim();
				刷历练 = Config.IniReadValue("GameServer", "刷历练").Trim();
				删背包物品 = Config.IniReadValue("GameServer", "删背包物品").Trim();
				隐身 = Config.IniReadValue("GameServer", "隐身").Trim();
				刷怪 = Config.IniReadValue("GameServer", "刷怪").Trim();
				踢人 = Config.IniReadValue("GameServer", "踢人").Trim();
				封号 = Config.IniReadValue("GameServer", "封号").Trim();
				追踪 = Config.IniReadValue("GameServer", "追踪").Trim();
				装备加解锁开关 = int.Parse(Config.IniReadValue("GameServer", "装备加解锁开关").Trim());
				是否开启龙行模式 = int.Parse(Config.IniReadValue("GameServer", "是否开启龙行模式").Trim());
				是否开启狂歌模式 = int.Parse(Config.IniReadValue("GameServer", "是否开启狂歌模式").Trim());
				复古模式是否启用 = int.Parse(Config.IniReadValue("GameServer", "复古模式是否启用").Trim());
				获得经验等级差 = ((!(Config.IniReadValue("GameServer", "获得经验等级差").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "获得经验等级差").Trim()) : 0);
				帮战开关 = int.Parse(Config.IniReadValue("GameServer", "帮战开关").Trim());
				帮战战斗时间 = int.Parse(Config.IniReadValue("GameServer", "帮战战斗时间").Trim());
				帮战获胜元宝金币数 = Config.IniReadValue("GameServer", "帮战获胜元宝金币数").Trim();
				帮战平分元宝金币数 = Config.IniReadValue("GameServer", "帮战平分元宝金币数").Trim();
				取消帮战元宝金币数 = Config.IniReadValue("GameServer", "取消帮战元宝金币数").Trim();
				申请帮战元宝金币数 = Config.IniReadValue("GameServer", "申请帮战元宝金币数").Trim();
				帮战人数控制 = Config.IniReadValue("GameServer", "帮战人数控制").Trim();
				宠物攻击力倍数 = int.Parse(Config.IniReadValue("GameServer", "宠物攻击力倍数").Trim());
				野外boss配置 = Config.IniReadValue("GameServer", "野外BOSS配置").Trim();
				升级会员需要属性 = Config.IniReadValue("GameServer", "升级会员需要属性").Trim();
				物品锁定 = Config.IniReadValue("GameServer", "物品锁定").Trim();
				地图锁定 = Config.IniReadValue("GameServer", "地图锁定").Trim();
				怪物死亡触发器 = ((Config.IniReadValue("GameServer", "怪物死亡触发器").Trim() == "") ? 怪物死亡触发器 : int.Parse(Config.IniReadValue("GameServer", "怪物死亡触发器").Trim()));
				时间药开关 = int.Parse(Config.IniReadValue("GameServer", "时间药开关").Trim());
				药品a = Config.IniReadValue("GameServer", "药品A").Trim();
				药品b = Config.IniReadValue("GameServer", "药品B").Trim();
				药品c = Config.IniReadValue("GameServer", "药品C").Trim();
				药品d = Config.IniReadValue("GameServer", "药品D").Trim();
				药品e = Config.IniReadValue("GameServer", "药品E").Trim();
				药品f = Config.IniReadValue("GameServer", "药品F").Trim();
				药品g = Config.IniReadValue("GameServer", "药品G").Trim();
				药品h = Config.IniReadValue("GameServer", "药品H").Trim();
				string[] array = (药品a + "|" + 药品b + "|" + 药品c + "|" + 药品d + "|" + 药品e + "|" + 药品f + "|" + 药品g + "|" + 药品h).Split('|');
				时间药.Clear();
				for (int i = 0; i < array.Length; i++)
				{
					string[] array2 = array[i].Split(',');
					if (array2.Length > 1)
					{
						时间药.Add(int.Parse(array2[0]), new 时间药类
						{
							_PID = int.Parse(array2[0]),
							_BufType = int.Parse(array2[1]),
							_BufTime = int.Parse(array2[2]),
							_BufSide = int.Parse(array2[3]),
							_BufMax = int.Parse(array2[4])
						});
					}
				}
				人物最高等级 = int.Parse(Config.IniReadValue("GameServer", "人物最高等级").Trim());
				物品兑换lua脚本是否开启 = int.Parse(Config.IniReadValue("GameServer", "物品兑换LUA脚本是否开启").Trim());
				套装发送开启 = int.Parse(Config.IniReadValue("GameServer", "套装发送开启").Trim());
				上线属性提示开关 = int.Parse(Config.IniReadValue("GameServer", "上线属性提示开关").Trim());
				乐师上线等级 = int.Parse(Config.IniReadValue("GameServer", "乐师上线等级").Trim());
				安全区地图 = int.Parse(Config.IniReadValue("GameServer", "安全区地图").Trim());
				安全区x坐标 = float.Parse(Config.IniReadValue("GameServer", "安全区X坐标").Trim());
				安全区y坐标 = float.Parse(Config.IniReadValue("GameServer", "安全区Y坐标").Trim());
				Pk系统限制地图 = Config.IniReadValue("GameServer", "PK系统限制地图").Trim().Split(';');
				Pk掉等级 = int.Parse(Config.IniReadValue("GameServer", "PK掉等级").Trim());
				Pk掉元宝 = int.Parse(Config.IniReadValue("GameServer", "PK掉元宝").Trim());
				Pk掉元宝系统回收量 = int.Parse(Config.IniReadValue("GameServer", "PK掉元宝系统回收量").Trim());
				时间系统开关 = int.Parse(Config.IniReadValue("GameServer", "时间系统开关").Trim());
				禁制pk地图 = Config.IniReadValue("GameServer", "禁制PK地图").Trim();
				披风强化消耗类型 = ((!(Config.IniReadValue("GameServer", "披风强化消耗类型").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "披风强化消耗类型").Trim()) : 0);
				强化消耗的数量 = ((!(Config.IniReadValue("GameServer", "强化消耗的数量").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "强化消耗的数量").Trim()) : 0);
				披风分解消耗类型 = ((!(Config.IniReadValue("GameServer", "披风分解消耗类型").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "披风分解消耗类型").Trim()) : 0);
				分解消耗的数量 = ((!(Config.IniReadValue("GameServer", "分解消耗的数量").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "分解消耗的数量").Trim()) : 0);
				披风组合消耗类型 = ((!(Config.IniReadValue("GameServer", "披风组合消耗类型").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "披风组合消耗类型").Trim()) : 0);
				组合消耗的数量 = ((!(Config.IniReadValue("GameServer", "组合消耗的数量").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "组合消耗的数量").Trim()) : 0);
				是否启动披风强化 = ((Config.IniReadValue("GameServer", "是否启动披风强化").Trim() == "") ? 是否启动披风强化 : int.Parse(Config.IniReadValue("GameServer", "是否启动披风强化").Trim()));
				披风强化总概率 = Config.IniReadValue("GameServer", "披风强化总概率").Trim();
				披风强化一阶段概率 = ((Config.IniReadValue("GameServer", "披风强化一阶段概率") == "") ? 披风强化一阶段概率 : double.Parse(Config.IniReadValue("GameServer", "披风强化一阶段概率")));
				披风强化二阶段概率 = ((Config.IniReadValue("GameServer", "披风强化二阶段概率") == "") ? 披风强化二阶段概率 : double.Parse(Config.IniReadValue("GameServer", "披风强化二阶段概率")));
				披风强化三阶段概率 = ((Config.IniReadValue("GameServer", "披风强化三阶段概率") == "") ? 披风强化三阶段概率 : double.Parse(Config.IniReadValue("GameServer", "披风强化三阶段概率")));
				披风强化四阶段概率 = ((Config.IniReadValue("GameServer", "披风强化四阶段概率") == "") ? 披风强化四阶段概率 : double.Parse(Config.IniReadValue("GameServer", "披风强化四阶段概率")));
				披风强化五阶段概率 = ((Config.IniReadValue("GameServer", "披风强化五阶段概率") == "") ? 披风强化五阶段概率 : double.Parse(Config.IniReadValue("GameServer", "披风强化五阶段概率")));
				披风强化六阶段概率 = ((Config.IniReadValue("GameServer", "披风强化六阶段概率") == "") ? 披风强化六阶段概率 : double.Parse(Config.IniReadValue("GameServer", "披风强化六阶段概率")));
				披风强化七阶段概率 = ((Config.IniReadValue("GameServer", "披风强化七阶段概率") == "") ? 披风强化七阶段概率 : double.Parse(Config.IniReadValue("GameServer", "披风强化七阶段概率")));
				披风强化八阶段概率 = ((Config.IniReadValue("GameServer", "披风强化八阶段概率") == "") ? 披风强化八阶段概率 : double.Parse(Config.IniReadValue("GameServer", "披风强化八阶段概率")));
				是否开启新元宝商店 = ((Config.IniReadValue("GameServer", "是否开启新元宝商店").Trim() == "") ? 是否开启新元宝商店 : int.Parse(Config.IniReadValue("GameServer", "是否开启新元宝商店").Trim()));
				允许物品出售最大元宝数量 = ((Config.IniReadValue("GameServer", "允许物品出售最大元宝数量").Trim() == "") ? 允许物品出售最大元宝数量 : int.Parse(Config.IniReadValue("GameServer", "允许物品出售最大元宝数量").Trim()));
				门甲组合消耗类型 = ((!(Config.IniReadValue("GameServer", "门甲组合消耗类型").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "门甲组合消耗类型").Trim()) : 0);
				门甲组合消耗的数量 = ((!(Config.IniReadValue("GameServer", "门甲组合消耗的数量").Trim() == "")) ? int.Parse(Config.IniReadValue("GameServer", "门甲组合消耗的数量").Trim()) : 0);
				坐牢系统是否开启 = int.Parse(Config.IniReadValue("GameServer", "坐牢系统是否开启").Trim());
				监狱地图 = Config.IniReadValue("GameServer", "监狱地图").Trim();
				坐牢善恶 = int.Parse(Config.IniReadValue("GameServer", "坐牢善恶").Trim());
				坐牢善恶恢复间隔 = int.Parse(Config.IniReadValue("GameServer", "坐牢善恶恢复间隔").Trim());
				坐牢恢复善恶值 = int.Parse(Config.IniReadValue("GameServer", "坐牢恢复善恶值").Trim());
				死亡回城地图坐标 = Config.IniReadValue("GameServer", "死亡回城地图坐标").Trim();
				势力战回城坐标 = Config.IniReadValue("GameServer", "势力战回城坐标").Trim();
				坐牢回城坐标 = Config.IniReadValue("GameServer", "坐牢回城坐标").Trim();
				刑满释放公告 = ((Config.IniReadValue("GameServer", "刑满释放公告").Trim() == "") ? 刑满释放公告 : Config.IniReadValue("GameServer", "刑满释放公告").Trim());
				坐牢杀人公告 = ((Config.IniReadValue("GameServer", "坐牢杀人公告").Trim() == "") ? 坐牢杀人公告 : Config.IniReadValue("GameServer", "坐牢杀人公告").Trim());
				信任连接ip = Config.IniReadValue("GameServer", "信任连接IP").Trim();
				VersionClient = ((Config.IniReadValue("GameServer", "VersionClient").Trim() == "") ? VersionClient : int.Parse(Config.IniReadValue("GameServer", "VersionClient").Trim()));
				允许多开数量 = ((Config.IniReadValue("GameServer", "允许多开数量").Trim() == "") ? 允许多开数量 : int.Parse(Config.IniReadValue("GameServer", "允许多开数量").Trim()));
				Newversion = ((Config.IniReadValue("GameServer", "NEWVERSION").Trim() == "") ? Newversion : int.Parse(Config.IniReadValue("GameServer", "NEWVERSION").Trim()));
				SizeDdos = ((Config.IniReadValue("GameServer", "SizeDdos").Trim() == "") ? SizeDdos : int.Parse(Config.IniReadValue("GameServer", "SizeDdos").Trim()));
				ThuPhiVoHuan8 = ((Config.IniReadValue("GameServer", "ThuPhiVoHuan8").Trim() == "") ? ThuPhiVoHuan8 : int.Parse(Config.IniReadValue("GameServer", "ThuPhiVoHuan8").Trim()));
				CreateNewJob = ((Config.IniReadValue("GameServer", "Create_NEWJob").Trim() == "") ? CreateNewJob : int.Parse(Config.IniReadValue("GameServer", "Create_NEWJob").Trim()));
				AlphaTest = ((Config.IniReadValue("GameServer", "AlphaTest").Trim() == "") ? AlphaTest : int.Parse(Config.IniReadValue("GameServer", "AlphaTest").Trim()));
				CuonghoaMatItem = ((Config.IniReadValue("GameServer", "CUONGHOA_MAT_ITEM").Trim() == "") ? CuonghoaMatItem : int.Parse(Config.IniReadValue("GameServer", "CUONGHOA_MAT_ITEM").Trim()));
				Sudocungphai = ((Config.IniReadValue("GameServer", "SUDOCUNGPHAI").Trim() == "") ? Sudocungphai : int.Parse(Config.IniReadValue("GameServer", "SUDOCUNGPHAI").Trim()));
				FIXLAG = ((Config.IniReadValue("GameServer", "FIXLAG").Trim() == "") ? FIXLAG : int.Parse(Config.IniReadValue("GameServer", "FIXLAG").Trim()));
				AFKTLC = ((Config.IniReadValue("GameServer", "AFKTLC").Trim() == "") ? AFKTLC : int.Parse(Config.IniReadValue("GameServer", "AFKTLC").Trim()));
				Eventx2 = ((Config.IniReadValue("GameServer", "Eventx2").Trim() == "") ? Eventx2 : int.Parse(Config.IniReadValue("GameServer", "Eventx2").Trim()));
				Eventx3 = ((Config.IniReadValue("GameServer", "Eventx3").Trim() == "") ? Eventx3 : int.Parse(Config.IniReadValue("GameServer", "Eventx3").Trim()));
				AoChoangThang = ((Config.IniReadValue("GameServer", "AoChoangThang").Trim() == "") ? AoChoangThang : int.Parse(Config.IniReadValue("GameServer", "AoChoangThang").Trim()));
				Open_Auto_GiftCode = ((Config.IniReadValue("GameServer", "Open_Auto_GiftCode").Trim() == "") ? Open_Auto_GiftCode : int.Parse(Config.IniReadValue("GameServer", "Open_Auto_GiftCode").Trim()));
				Config_Auto_GiftCode = Config.IniReadValue("GameServer", "Config_Auto_GiftCode").Trim().Split(';');
				DelayDisableNpc = ((Config.IniReadValue("GameServer", "DelayDisableNpc").Trim() == "") ? DelayDisableNpc : Config.IniReadValue("GameServer", "DelayDisableNpc").Trim().Split(';'));
				DamageComBoQuyenSu = ((Config.IniReadValue("GameServer", "DamageComBoQuyenSu").Trim() == "") ? DamageComBoQuyenSu : Config.IniReadValue("GameServer", "DamageComBoQuyenSu").Trim().Split(';'));
				Translation();
			}
			catch (Exception ex)
			{
				Form1.WriteLine(100, "配置文件 GameConfiguration.ini 配置错误,请比对更新文件:" + ex.Message);
				Environment.Exit(0);
			}
		}

		public static void SetConfig2()
		{
			DbClass dbClass = new DbClass();
			dbClass.ServerDb = "rxjhaccount";
			dbClass.SqlConnect = string.Format("Data Source={0};uid={1};pwd={2};database={3};Packet Size=4096;Pooling=true;Max Pool Size=512;Min Pool Size=1", Config.IniReadValue("rxjhaccount", "Server").Trim(), Config.IniReadValue("rxjhaccount", "UserName").Trim(), Config.IniReadValue("rxjhaccount", "PassWord").Trim(), Config.IniReadValue("rxjhaccount", "DataName").Trim());
			DbClass value = dbClass;
			Db.Add("rxjhaccount", value);
			DbClass dbClass2 = new DbClass();
			dbClass2.ServerDb = "baibao";
			dbClass2.SqlConnect = string.Format("Data Source={0};uid={1};pwd={2};database={3};Packet Size=4096;Pooling=true;Max Pool Size=512;Min Pool Size=1", Config.IniReadValue("baibao", "Server").Trim(), Config.IniReadValue("baibao", "UserName").Trim(), Config.IniReadValue("baibao", "PassWord").Trim(), Config.IniReadValue("baibao", "DataName").Trim());
			DbClass value2 = dbClass2;
			Db.Add("baibao", value2);
			DbClass dbClass3 = new DbClass();
			dbClass3.ServerDb = "GameServer";
			dbClass3.SqlConnect = string.Format("Data Source={0};uid={1};pwd={2};database={3};Packet Size=4096;Pooling=true;Max Pool Size=512;Min Pool Size=1", Config.IniReadValue("GameServer", "Server").Trim(), Config.IniReadValue("GameServer", "UserName").Trim(), Config.IniReadValue("GameServer", "PassWord").Trim(), Config.IniReadValue("GameServer", "DataName").Trim());
			DbClass value3 = dbClass3;
			Db.Add("GameServer", value3);
			DbClass dbClass4 = new DbClass();
			dbClass4.ServerDb = "PublicDb";
			dbClass4.SqlConnect = string.Format("Data Source={0};uid={1};pwd={2};database={3};Packet Size=4096;Pooling=true;Max Pool Size=512;Min Pool Size=1", Config.IniReadValue("PublicDb", "Server").Trim(), Config.IniReadValue("PublicDb", "UserName").Trim(), Config.IniReadValue("PublicDb", "PassWord").Trim(), Config.IniReadValue("PublicDb", "DataName").Trim());
			DbClass value4 = dbClass4;
			Db.Add("PublicDb", value4);
			if (查非法物品 == 2)
			{
				DbClass dbClass5 = new DbClass();
				dbClass5.ServerDb = "WebDb";
				dbClass5.SqlConnect = string.Format("Data Source={0};uid={1};pwd={2};database={3};Packet Size=4096;Pooling=true;Max Pool Size=512;Min Pool Size=1", Config.IniReadValue("WebDb", "Server").Trim(), Config.IniReadValue("WebDb", "UserName").Trim(), Config.IniReadValue("WebDb", "PassWord").Trim(), Config.IniReadValue("WebDb", "DataName").Trim());
				DbClass value5 = dbClass5;
				Db.Add("WebDb", value5);
			}
		}

		public static void SetDrop()
		{
			try
			{
				DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_XWWL_DROP ORDER BY FLD_LEVEL1, FLD_LEVEL2", "PublicDb");
				if (dBToDataTable != null)
				{
					if (dBToDataTable.Rows.Count == 0)
					{
						Form1.WriteLine(1, "加载掉落物品完成----没有物品数据");
					}
					else
					{
						Drop.Clear();
						int num = 0;
						while (true)
						{
							bool flag = true;
							if (num >= dBToDataTable.Rows.Count)
							{
								break;
							}
							DropClass dropClass = new DropClass();
							try
							{
								dropClass.FLD_LEVEL1 = (int)dBToDataTable.Rows[num]["FLD_LEVEL1"];
								dropClass.FLD_LEVEL2 = (int)dBToDataTable.Rows[num]["FLD_LEVEL2"];
								dropClass.FLD_PID = (int)dBToDataTable.Rows[num]["FLD_PID"];
								dropClass.FLD_PP = (int)dBToDataTable.Rows[num]["FLD_PP"];
								dropClass.FLD_NAME = dBToDataTable.Rows[num]["FLD_NAME"].ToString();
								dropClass.FLD_MAGIC0 = (int)dBToDataTable.Rows[num]["FLD_MAGIC0"];
								dropClass.FLD_MAGIC1 = (int)dBToDataTable.Rows[num]["FLD_MAGIC1"];
								dropClass.FLD_MAGIC2 = (int)dBToDataTable.Rows[num]["FLD_MAGIC2"];
								dropClass.FLD_MAGIC3 = (int)dBToDataTable.Rows[num]["FLD_MAGIC3"];
								dropClass.FLD_MAGIC4 = (int)dBToDataTable.Rows[num]["FLD_MAGIC4"];
								dropClass.FLD_MAGICNew0 = (int)dBToDataTable.Rows[num]["FLD_MAGIC0"];
								dropClass.FLD_MAGICNew1 = (int)dBToDataTable.Rows[num]["FLD_MAGIC1"];
								dropClass.FLD_MAGICNew2 = (int)dBToDataTable.Rows[num]["FLD_MAGIC2"];
								dropClass.FLD_MAGICNew3 = (int)dBToDataTable.Rows[num]["FLD_MAGIC3"];
								dropClass.FLD_MAGICNew4 = (int)dBToDataTable.Rows[num]["FLD_MAGIC4"];
								Drop.Add(dropClass);
							}
							catch (Exception ex)
							{
								Form1.WriteLine(1, "加载掉落物品 错误" + dropClass.FLD_NAME + "  " + ex.Message);
							}
							num++;
						}
						Form1.WriteLine(2, "加载掉落物品 " + dBToDataTable.Rows.Count);
					}
					dBToDataTable.Dispose();
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "加载掉落物品 错误" + ex.Message);
			}
		}

		public static void SetgjConfig()
		{
			try
			{
				Config.Pathgj = Application.StartupPath + "\\HookConfiguration.ini";
				Enable_Online_Bonus = int.Parse(Config.IniReadValugj("HookConfiguration", "Enable_Online_Bonus").Trim());
				Enable_Reward_Online = int.Parse(Config.IniReadValugj("HookConfiguration", "Enable_Reward_Online").Trim());
				Time_Reward_Online = int.Parse(Config.IniReadValugj("HookConfiguration", "Time_Reward_Online").Trim());
				Level_Reward_Online = int.Parse(Config.IniReadValugj("HookConfiguration", "Level_Reward_Online").Trim());
				Config_Reward_Online = Config.IniReadValugj("HookConfiguration", "Config_Reward_Online").Trim();
				Config_Reward_Online_Vip = Config.IniReadValugj("HookConfiguration", "Config_Reward_Online_Vip").Trim();
				Command_Func_Offline = Config.IniReadValugj("HookConfiguration", "Command_Func_Offline").Trim();
				Reward_Func_Offline = int.Parse(Config.IniReadValugj("HookConfiguration", "Reward_Func_Offline").Trim());
				Time_Reward_Func_Offline = int.Parse(Config.IniReadValugj("HookConfiguration", "Time_Reward_Func_Offline").Trim());
				Level_Reward_Func_Offline = int.Parse(Config.IniReadValugj("HookConfiguration", "Level_Reward_Func_Offline").Trim());
				Config_Reward_Func_Offline = Config.IniReadValugj("HookConfiguration", "Config_Reward_Func_Offline").Trim();
				Config_Reward_Func_Offline_Vip = Config.IniReadValugj("HookConfiguration", "Config_Reward_Func_Offline_Vip").Trim();
				Func_Offline_ItemID = Config.IniReadValugj("HookConfiguration", "Func_Offline_ItemID").Trim();
				Enable_Func_Offline = ((Config.IniReadValugj("HookConfiguration", "Enable_Func_Offline").Trim() == "") ? Enable_Func_Offline : int.Parse(Config.IniReadValugj("HookConfiguration", "Enable_Func_Offline").Trim()));
				Map_Func_Offline = ((Config.IniReadValugj("HookConfiguration", "Map_Func_Offline").Trim() == "") ? Map_Func_Offline : int.Parse(Config.IniReadValugj("HookConfiguration", "Map_Func_Offline").Trim()));
				Level_Func_Offline = ((Config.IniReadValugj("HookConfiguration", "Map_Func_Offline").Trim() == "") ? Level_Func_Offline : int.Parse(Config.IniReadValugj("HookConfiguration", "Level_Func_Offline").Trim()));
			}
			catch (Exception ex)
			{
				Form1.WriteLine(100, "配置文件 挂机配置.ini 配置错误:" + ex.Message);
				Form1.WriteLine(100, "7");
				Environment.Exit(0);
			}
		}

		public static void Set制作药品表()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_制作药品表", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "TBL_制作药品表 is null");
			}
			else
			{
				list制作药品表.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					制作药品表 制作药品表 = new 制作药品表();
					制作药品表.FLD_ZZWPID = (int)dBToDataTable.Rows[i]["FLD_ZZWPID"];
					制作药品表.FLD_NAME = dBToDataTable.Rows[i]["FLD_NAME"].ToString();
					制作药品表.FLD_XHWPID1 = (int)dBToDataTable.Rows[i]["FLD_XHWPID1"];
					制作药品表.FLD_XHWPNUM1 = (int)dBToDataTable.Rows[i]["FLD_XHWPNUM1"];
					制作药品表.FLD_XHWPID2 = (int)dBToDataTable.Rows[i]["FLD_XHWPID2"];
					制作药品表.FLD_XHWPNUM2 = (int)dBToDataTable.Rows[i]["FLD_XHWPNUM2"];
					制作药品表.FLD_XHWPID3 = (int)dBToDataTable.Rows[i]["FLD_XHWPID3"];
					制作药品表.FLD_XHWPNUM3 = (int)dBToDataTable.Rows[i]["FLD_XHWPNUM3"];
					制作药品表.FLD_XHWPID4 = (int)dBToDataTable.Rows[i]["FLD_XHWPID4"];
					制作药品表.FLD_XHWPNUM4 = (int)dBToDataTable.Rows[i]["FLD_XHWPNUM4"];
					list制作药品表.Add(制作药品表);
				}
				Form1.WriteLine(2, "TBL_制作药品表 loaded: " + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void SetItme()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_XWWL_ITEM", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载物品出错----没有物品数据");
			}
			else
			{
				Itme.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					ItmeClass itmeClass = new ItmeClass();
					itmeClass.FLD_AT = long.Parse(dBToDataTable.Rows[i]["FLD_AT1"].ToString());
					itmeClass.FLD_AT_Max = long.Parse(dBToDataTable.Rows[i]["FLD_AT2"].ToString());
					itmeClass.FLD_DF = long.Parse(dBToDataTable.Rows[i]["FLD_DF"].ToString());
					itmeClass.FLD_SHIELD = (int)dBToDataTable.Rows[i]["FLD_SHIELD"];
					itmeClass.FLD_RESIDE1 = (int)dBToDataTable.Rows[i]["FLD_RESIDE1"];
					itmeClass.FLD_RESIDE2 = (int)dBToDataTable.Rows[i]["FLD_RESIDE2"];
					itmeClass.FLD_JOB_LEVEL = (int)dBToDataTable.Rows[i]["FLD_JOB_LEVEL"];
					itmeClass.FLD_LEVEL = (int)dBToDataTable.Rows[i]["FLD_LEVEL"];
					itmeClass.FLD_MONEY = (int)dBToDataTable.Rows[i]["FLD_MONEY"];
					itmeClass.FLD_PID = int.Parse(dBToDataTable.Rows[i]["FLD_PID"].ToString());
					itmeClass.FLD_SEX = (int)dBToDataTable.Rows[i]["FLD_SEX"];
					itmeClass.FLD_WEIGHT = (int)dBToDataTable.Rows[i]["FLD_WEIGHT"];
					itmeClass.FLD_ZX = (int)dBToDataTable.Rows[i]["FLD_ZX"];
					itmeClass.FLD_SIDE = (int)dBToDataTable.Rows[i]["FLD_SIDE"];
					itmeClass.FLD_MAGIC0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"];
					itmeClass.FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"];
					itmeClass.FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"];
					itmeClass.FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"];
					itmeClass.FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC5"];
					itmeClass.FLD_XW = (int)dBToDataTable.Rows[i]["FLD_WX"];
					itmeClass.FLD_XWJD = (int)dBToDataTable.Rows[i]["FLD_WXJD"];
					itmeClass.FLD_TYPE = (int)dBToDataTable.Rows[i]["FLD_TYPE"];
					itmeClass.FLD_QUESTITEM = (int)dBToDataTable.Rows[i]["FLD_QUESTITEM"];
					itmeClass.FLD_CJL = (int)dBToDataTable.Rows[i]["FLD_CJL"];
					itmeClass.ItmeNAME = dBToDataTable.Rows[i]["FLD_NAME"].ToString();
					itmeClass.FLD_THONGBAO = (int)dBToDataTable.Rows[i]["FLD_THONGBAO"];
					if (!Itme.ContainsKey(itmeClass.FLD_PID))
					{
						Itme.Add(itmeClass.FLD_PID, itmeClass);
					}
					else
					{
						Form1.WriteLine(1, "Item added key: " + itmeClass.FLD_PID);
					}
				}
				Form1.WriteLine(2, "加载物品数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void SetGiftCode()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM GiftCode", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "Table GiftCode ---- NULL");
			}
			else
			{
				GiftCode.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					GiftCode.Add(new GiftcodeClass
					{
						GiftCode = dBToDataTable.Rows[i]["GiftCode"].ToString(),
						Type = int.Parse(dBToDataTable.Rows[i]["Type"].ToString())
					});
				}
				Form1.WriteLine(2, "Load GiftCode: " + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void SetGiftCodeRewards()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM GiftCode_Rewards", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "Table GiftCodeRewards ---- NULL");
			}
			else
			{
				GiftCodeRewards.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					GiftCodeRewards.Add(new GiftCodeRewardsClass
					{
						Type = int.Parse(dBToDataTable.Rows[i]["Type"].ToString()),
						Rewards = dBToDataTable.Rows[i]["Rewards"].ToString()
					});
				}
				Form1.WriteLine(2, "Load GiftCodeRewards: " + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void SetJianc()
		{
			if (查非法物品 != 2)
			{
				return;
			}
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM 装备检测", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count != 0)
			{
				装备检测list.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					装备检测list.Add((int)dBToDataTable.Rows[i]["物品类型"], new 装备检测类
					{
						物品最高攻击值 = (int)dBToDataTable.Rows[i]["物品最高攻击值"],
						物品最高防御值 = (int)dBToDataTable.Rows[i]["物品最高防御值"],
						物品最高生命值 = (int)dBToDataTable.Rows[i]["物品最高生命值"],
						物品最高内功值 = (int)dBToDataTable.Rows[i]["物品最高内功值"],
						物品最高命中值 = (int)dBToDataTable.Rows[i]["物品最高命中值"],
						物品最高回避值 = (int)dBToDataTable.Rows[i]["物品最高回避值"],
						物品最高武功值 = (int)dBToDataTable.Rows[i]["物品最高武功值"],
						物品最高气功值 = (int)dBToDataTable.Rows[i]["物品最高气功值"]
					});
				}
				Form1.WriteLine(2, "加载装备检测数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public void SetJl()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_XWWL_Jl", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载奖励物品完成----没有物品数据");
			}
			else
			{
				DropJl.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					DropJl.Add(new DropClass
					{
						FLD_LEVEL1 = (int)dBToDataTable.Rows[i]["FLD_LEVEL1"],
						FLD_LEVEL2 = (int)dBToDataTable.Rows[i]["FLD_LEVEL2"],
						FLD_PID = (int)dBToDataTable.Rows[i]["FLD_PID"],
						FLD_PP = (int)dBToDataTable.Rows[i]["FLD_PP"],
						FLD_NAME = dBToDataTable.Rows[i]["FLD_NAME"].ToString(),
						FLD_MAGIC0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC0"],
						FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
						FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
						FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
						FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"],
						FLD_MAGICNew0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC0"],
						FLD_MAGICNew1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
						FLD_MAGICNew2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
						FLD_MAGICNew3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
						FLD_MAGICNew4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"]
					});
				}
				Form1.WriteLine(2, "加载奖励物品 " + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void SetKill()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM XWWL_kill", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载过滤出错----没有公告数据");
			}
			else
			{
				Kill.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					Kill.Add(new KillClass
					{
						Txt = dBToDataTable.Rows[i]["txt"].ToString(),
						Sffh = (int)dBToDataTable.Rows[i]["sffh"]
					});
				}
				Form1.WriteLine(2, "加载过滤数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void SetQuestDrop()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_QUESTDROP", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "TBL_QUESTDROP ---- no data");
			}
			else
			{
				TblQuestDrop.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					TBL_QUESTDROP tBL_QUESTDROP = new TBL_QUESTDROP();
					tBL_QUESTDROP.id = (int)dBToDataTable.Rows[i]["id"];
					tBL_QUESTDROP.QuestID = (int)dBToDataTable.Rows[i]["QuestID"];
					tBL_QUESTDROP.QuestLevel = (int)dBToDataTable.Rows[i]["QuestLevel"];
					tBL_QUESTDROP.MonsterID = (int)dBToDataTable.Rows[i]["MonsterID"];
					tBL_QUESTDROP.MonsterID2 = (int)dBToDataTable.Rows[i]["MonsterID2"];
					tBL_QUESTDROP.QuestDropID = (int)dBToDataTable.Rows[i]["QuestDropID"];
					tBL_QUESTDROP.QuestDropID2 = (int)dBToDataTable.Rows[i]["QuestDropID2"];
					tBL_QUESTDROP.QuestItemMax = (int)dBToDataTable.Rows[i]["QuestItemMax"];
					tBL_QUESTDROP.QuestItemMax2 = (int)dBToDataTable.Rows[i]["QuestItemMax2"];
					tBL_QUESTDROP.DropRatePercent = (int)dBToDataTable.Rows[i]["DropRatePercent"];
					tBL_QUESTDROP.QuestName = dBToDataTable.Rows[i]["QuestName"].ToString();
					TblQuestDrop.Add(tBL_QUESTDROP.QuestID * 10000 + i * 100 + tBL_QUESTDROP.QuestLevel, tBL_QUESTDROP);
				}
				Form1.WriteLine(2, "Load QuestDrop: " + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void SetKongfu()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_XWWL_KONGFU", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载武功出错----没有武功数据");
			}
			else
			{
				TblKongfu.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					武功类 武功类 = new 武功类();
					武功类.FLD_AT = (int)dBToDataTable.Rows[i]["FLD_AT"];
					武功类.FLD_EFFERT = (int)dBToDataTable.Rows[i]["FLD_EFFERT"];
					武功类.FLD_INDEX = (int)dBToDataTable.Rows[i]["FLD_INDEX"];
					武功类.FLD_JOB = (int)dBToDataTable.Rows[i]["FLD_JOB"];
					武功类.FLD_JOBLEVEL = (int)dBToDataTable.Rows[i]["FLD_JOBLEVEL"];
					武功类.FLD_LEVEL = (int)dBToDataTable.Rows[i]["FLD_LEVEL"];
					武功类.FLD_MP = (int)dBToDataTable.Rows[i]["FLD_MP"];
					武功类.FLD_NEEDEXP = (int)dBToDataTable.Rows[i]["FLD_NEEDEXP"];
					武功类.FLD_PID = (int)dBToDataTable.Rows[i]["FLD_PID"];
					武功类.FLD_TYPE = (int)dBToDataTable.Rows[i]["FLD_TYPE"];
					武功类.FLD_ZX = (int)dBToDataTable.Rows[i]["FLD_ZX"];
					武功类.FLD_攻击数量 = (int)dBToDataTable.Rows[i]["FLD_攻击数量"];
					武功类.FLD_武功类型 = (int)dBToDataTable.Rows[i]["FLD_武功类型"];
					武功类.FLD_每级加等级 = (int)dBToDataTable.Rows[i]["FLD_每级加等级"];
					武功类.FLD_每级加MP = (int)dBToDataTable.Rows[i]["FLD_每级加MP"];
					武功类.FLD_每级加历练 = (int)dBToDataTable.Rows[i]["FLD_每级加历练"];
					武功类.FLD_每级加危害 = (int)dBToDataTable.Rows[i]["FLD_每级加危害"];
					武功类.FLD_每级武功点数 = (int)dBToDataTable.Rows[i]["FLD_每级武功点数"];
					武功类.FLD_SKILL_TIME = (int)dBToDataTable.Rows[i]["FLD_TIME"];
					武功类.最高武功_等级 = (int)dBToDataTable.Rows[i]["FLD_武功最高等级"];
					武功类.FLD_每级加等级_Array = ((dBToDataTable.Rows[i]["FLD_每级加等级_Array"] != DBNull.Value) ? dBToDataTable.Rows[i]["FLD_每级加等级_Array"].ToString().Split(',').Select(int.Parse)
						.ToList() : new List<int>());
					武功类.FLD_每级加MP_Array = ((dBToDataTable.Rows[i]["FLD_每级加MP_Array"] != DBNull.Value) ? dBToDataTable.Rows[i]["FLD_每级加MP_Array"].ToString().Split(',').Select(int.Parse)
						.ToList() : new List<int>());
					武功类.FLD_每级加历练_Array = ((dBToDataTable.Rows[i]["FLD_每级加历练_Array"] != DBNull.Value) ? dBToDataTable.Rows[i]["FLD_每级加历练_Array"].ToString().Split(',').Select(int.Parse)
						.ToList() : new List<int>());
					武功类.FLD_每级加危害_Array = ((dBToDataTable.Rows[i]["FLD_每级加危害_Array"] != DBNull.Value) ? dBToDataTable.Rows[i]["FLD_每级加危害_Array"].ToString().Split(',').Select(int.Parse)
						.ToList() : new List<int>());
					TblKongfu.Add(武功类.FLD_PID, 武功类);
				}
				Form1.WriteLine(2, "加载武功数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
			foreach (Players value in AllConnectedChars.Values)
			{
				value.UPDATECDSKILL(value.Player_FLD_Map);
			}
		}

		public static void SetLever()
		{
			Level.Clear();
			for (int i = 0; i <= 255; i++)
			{
				if (i <= 0)
				{
					Level.Add(i, 300.0);
				}
				else if (i >= 1 && i < 10)
				{
					Level.Add(i, Level[i - 1] * 1.25);
				}
				else if (i >= 10 && i < 35)
				{
					Level.Add(i, Level[i - 1] * 1.185);
				}
				else if (i >= 35 && i < 60)
				{
					Level.Add(i, Level[i - 1] * 1.175);
				}
				else if (i >= 60 && i < 80)
				{
					Level.Add(i, Level[i - 1] * 1.165);
				}
				else if (i >= 80 && i < 110)
				{
					Level.Add(i, Level[i - 1] * 1.155);
				}
				else if (i >= 110 && i < 113)
				{
					Level.Add(i, Level[i - 1] * 1.145);
				}
				else if (i >= 113 && i < 120)
				{
					Level.Add(i, Level[i - 1] * 1.16);
				}
				else if (i >= 120 && i < 125)
				{
					Level.Add(i, Level[i - 1] * 1.17);
				}
				else if (i >= 125 && i < 126)
				{
					Level.Add(i, Level[i - 1] * 1.22);
				}
				else if (i >= 126 && i < 130)
				{
					Level.Add(i, Level[i - 1] * 1.25);
				}
				else if (i >= 130 && i < 135)
				{
					Level.Add(i, Level[i - 1] * 1.3);
				}
				else if (i >= 135 && i < 140)
				{
					Level.Add(i, Level[i - 1] * 1.35);
				}
				else if (i >= 140 && i < 200)
				{
					Level.Add(i, Level[i - 1] * 1.4);
				}
				else
				{
					Level.Add(i, Level[i - 1] * 1.1);
				}
			}
			Form1.WriteLine(2, "Tải bảng kinh nghiệm thành công");
		}

		public static void SetMonSter()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_XWWL_MONSTER", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载怪物数据完成----没有怪物数据");
			}
			else
			{
				MonSter.Clear();
				int num = 0;
				while (true)
				{
					bool flag = true;
					if (num < dBToDataTable.Rows.Count)
					{
						try
						{
							MonSterClss monSterClss = new MonSterClss();
							monSterClss.FLD_PID = (int)dBToDataTable.Rows[num]["FLD_PID"];
							monSterClss.FLD_AT = (int)dBToDataTable.Rows[num]["FLD_AT"];
							monSterClss.FLD_AUTO = (int)dBToDataTable.Rows[num]["FLD_AUTO"];
							monSterClss.FLD_BOSS = (int)dBToDataTable.Rows[num]["FLD_BOSS"];
							monSterClss.FLD_DF = (int)dBToDataTable.Rows[num]["FLD_DF"];
							monSterClss.Level = (int)dBToDataTable.Rows[num]["FLD_LEVEL"];
							monSterClss.Name = dBToDataTable.Rows[num]["FLD_NAME"].ToString();
							monSterClss.Rxjh_Exp = (int)dBToDataTable.Rows[num]["FLD_EXP"];
							monSterClss.Rxjh_HP = (int)dBToDataTable.Rows[num]["FLD_HP"];
							MonSter.Add(monSterClss.FLD_PID, monSterClss);
						}
						catch (Exception arg)
						{
							Form1.WriteLine(1, "加载怪物数据 出错：" + arg);
						}
						num++;
						continue;
					}
					break;
				}
				Form1.WriteLine(2, "加载怪物数据完成 " + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void SetMover()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_XWWL_VOME", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载移动出错----没有移动数据");
			}
			else
			{
				Mover.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					Mover.Add(new MoveClass
					{
						MAP = (int)dBToDataTable.Rows[i]["MAP"],
						X = float.Parse(dBToDataTable.Rows[i]["X"].ToString()),
						Y = float.Parse(dBToDataTable.Rows[i]["Y"].ToString()),
						Z = float.Parse(dBToDataTable.Rows[i]["Z"].ToString()),
						ToMAP = (int)dBToDataTable.Rows[i]["ToMAP"],
						ToX = float.Parse(dBToDataTable.Rows[i]["ToX"].ToString()),
						ToY = float.Parse(dBToDataTable.Rows[i]["ToY"].ToString()),
						ToZ = float.Parse(dBToDataTable.Rows[i]["ToZ"].ToString())
					});
				}
				Form1.WriteLine(2, "加载移动数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void SetNpc()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_XWWL_NPC", "PublicDb");
			DataTable dBToDataTable2 = DBA.GetDBToDataTable($"SELECT * FROM TBL_XWWL_NPC_SL", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载NPC数据出错----没有NPC数据");
			}
			else
			{
				Map.Clear();
				int num = 0;
				MapClass value;
				while (true)
				{
					bool flag = true;
					if (num < dBToDataTable.Rows.Count)
					{
						try
						{
							NpcClass npcClass = new NpcClass();
							npcClass.FldPid = (int)dBToDataTable.Rows[num]["FLD_PID"];
							npcClass.Name = dBToDataTable.Rows[num]["FLD_NAME"].ToString();
							npcClass.Level = (int)dBToDataTable.Rows[num]["FLD_LEVEL"];
							npcClass.RxjhExp = (int)dBToDataTable.Rows[num]["FLD_EXP"];
							npcClass.RxjhX = float.Parse(dBToDataTable.Rows[num]["FLD_X"].ToString()) + (float)new Random(GetRandomSeed()).Next(-50, 50);
							npcClass.RxjhY = float.Parse(dBToDataTable.Rows[num]["FLD_Y"].ToString()) + (float)new Random(GetRandomSeed()).Next(-50, 50);
							npcClass.RxjhZ = float.Parse(dBToDataTable.Rows[num]["FLD_Z"].ToString());
							npcClass.RxjhCsX = float.Parse(dBToDataTable.Rows[num]["FLD_X"].ToString());
							npcClass.RxjhCsY = float.Parse(dBToDataTable.Rows[num]["FLD_Y"].ToString());
							npcClass.RxjhCsZ = float.Parse(dBToDataTable.Rows[num]["FLD_Z"].ToString());
							npcClass.IsNpc = (int)dBToDataTable.Rows[num]["FLD_NPC"];
							npcClass.FldFace1 = float.Parse(dBToDataTable.Rows[num]["FLD_FACE0"].ToString());
							npcClass.FldFace2 = float.Parse(dBToDataTable.Rows[num]["FLD_FACE"].ToString());
							npcClass.RxjhMap = (int)dBToDataTable.Rows[num]["FLD_MID"];
							npcClass.MaxRxjhHp = (int)dBToDataTable.Rows[num]["FLD_HP"];
							npcClass.RxjhHp = (int)dBToDataTable.Rows[num]["FLD_HP"];
							npcClass.FldAt = (int)dBToDataTable.Rows[num]["FLD_AT"];
							npcClass.FldDf = (int)dBToDataTable.Rows[num]["FLD_DF"];
							npcClass.FldAuto = (int)dBToDataTable.Rows[num]["FLD_AUTO"];
							npcClass.FldBoss = (int)dBToDataTable.Rows[num]["FLD_BOSS"];
							npcClass.FldNewtime = (int)dBToDataTable.Rows[num]["FLD_NEWTIME"];
							if (Map.TryGetValue(npcClass.RxjhMap, out value))
							{
								value.add(npcClass);
							}
							else
							{
								value = new MapClass();
								value.MapID = npcClass.RxjhMap;
								value.add(npcClass);
								Map.Add(value.MapID, value);
							}
						}
						catch (Exception arg)
						{
							Form1.WriteLine(1, "加载NPC数据 出错：" + arg);
						}
						num++;
						continue;
					}
					break;
				}
				num = 0;
				while (true)
				{
					bool flag = true;
					if (num < dBToDataTable2.Rows.Count)
					{
						try
						{
							NpcClass npcClass = new NpcClass();
							npcClass.FldPid = (int)dBToDataTable2.Rows[num]["FLD_PID"];
							npcClass.Name = dBToDataTable2.Rows[num]["FLD_NAME"].ToString();
							npcClass.Level = (int)dBToDataTable2.Rows[num]["FLD_LEVEL"];
							npcClass.RxjhExp = (int)dBToDataTable2.Rows[num]["FLD_EXP"];
							npcClass.RxjhX = float.Parse(dBToDataTable2.Rows[num]["FLD_X"].ToString());
							npcClass.RxjhY = float.Parse(dBToDataTable2.Rows[num]["FLD_Y"].ToString());
							npcClass.RxjhZ = float.Parse(dBToDataTable2.Rows[num]["FLD_Z"].ToString());
							npcClass.RxjhCsX = float.Parse(dBToDataTable2.Rows[num]["FLD_X"].ToString());
							npcClass.RxjhCsY = float.Parse(dBToDataTable2.Rows[num]["FLD_Y"].ToString());
							npcClass.RxjhCsZ = float.Parse(dBToDataTable2.Rows[num]["FLD_Z"].ToString());
							npcClass.IsNpc = 1;
							npcClass.FldFace1 = float.Parse(dBToDataTable2.Rows[num]["FLD_FACE0"].ToString());
							npcClass.FldFace2 = float.Parse(dBToDataTable2.Rows[num]["FLD_FACE"].ToString());
							npcClass.RxjhMap = (int)dBToDataTable2.Rows[num]["FLD_MID"];
							npcClass.MaxRxjhHp = (int)dBToDataTable2.Rows[num]["FLD_HP"];
							npcClass.RxjhHp = (int)dBToDataTable2.Rows[num]["FLD_HP"];
							npcClass.FldAt = (int)dBToDataTable2.Rows[num]["FLD_AT"];
							npcClass.FldDf = (int)dBToDataTable2.Rows[num]["FLD_DF"];
							npcClass.FldAuto = (int)dBToDataTable2.Rows[num]["FLD_AUTO"];
							npcClass.FldBoss = (int)dBToDataTable2.Rows[num]["FLD_BOSS"];
							npcClass.FldNewtime = (int)dBToDataTable2.Rows[num]["FLD_NEWTIME"];
							if (Map.TryGetValue(npcClass.RxjhMap, out value))
							{
								value.add(npcClass);
							}
							else
							{
								value = new MapClass();
								value.MapID = npcClass.RxjhMap;
								value.add(npcClass);
								Map.Add(value.MapID, value);
							}
						}
						catch (Exception arg)
						{
							Form1.WriteLine(1, "加载NPC数据 出错：" + arg);
						}
						num++;
						continue;
					}
					break;
				}
				Form1.WriteLine(2, "加载NPC数据完成 " + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void SetNpcDrop()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_XWWL_NPC_DROP", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载新掉落物品完成----没有物品数据");
			}
			else
			{
				NpcDrop.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					NpcDrop.Add(new NpcDropClass
					{
						FLD_LEVEL1 = (int)dBToDataTable.Rows[i]["FLD_LEVEL1"],
						FLD_LEVEL2 = (int)dBToDataTable.Rows[i]["FLD_LEVEL2"],
						FLD_NPC_PID = (int)dBToDataTable.Rows[i]["FLD_NPC_PID"],
						FLD_ITME_PID = (int)dBToDataTable.Rows[i]["FLD_ITME_PID"],
						FLD_NAME = dBToDataTable.Rows[i]["FLD_NAME"].ToString(),
						FLD_MAGIC0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC0"],
						FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
						FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
						FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
						FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"]
					});
				}
				Form1.WriteLine(2, "加载新掉落物品 " + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void SetOpen()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_XWWL_OPEN", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载开箱物品完成----没有开箱物品数据");
			}
			else
			{
				Open.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					Open.Add(new OpenClass
					{
						FLD_PID = (int)dBToDataTable.Rows[i]["FLD_PID"],
						FLD_PIDX = (int)dBToDataTable.Rows[i]["FLD_PIDX"],
						FLD_NUMBER = (int)dBToDataTable.Rows[i]["FLD_NUMBER"],
						FLD_PP = (int)dBToDataTable.Rows[i]["FLD_PP"],
						FLD_NAME = dBToDataTable.Rows[i]["FLD_NAME"].ToString(),
						FLD_NAMEX = dBToDataTable.Rows[i]["FLD_NAMEX"].ToString(),
						FLD_MAGIC0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
						FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
						FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
						FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"],
						FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC5"],
						FLD_初级附魂 = (int)dBToDataTable.Rows[i]["FLD_初级附魂"],
						FLD_中级附魂 = (int)dBToDataTable.Rows[i]["FLD_中级附魂"],
						FLD_进化 = (int)dBToDataTable.Rows[i]["FLD_进化"],
						FLD_是否绑定 = (int)dBToDataTable.Rows[i]["FLD_是否绑定"],
						使用天数 = (int)dBToDataTable.Rows[i]["使用天数"],
						FLD_THONGBAO = (int)dBToDataTable.Rows[i]["FLD_THONGBAO"]
					});
				}
				Form1.WriteLine(2, "加载开箱物品 " + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void SetScript()
		{
			脚本 = new ScriptClass();
		}

		public static void SetShot()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_XWWL_SELL ORDER BY FLD_NID, FLD_INDEX", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载物品商店----没有物品数据");
			}
			else
			{
				Shot.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					Shot.Add(new ShotClass
					{
						FLD_NID = int.Parse(dBToDataTable.Rows[i]["FLD_NID"].ToString()),
						FLD_INDEX = (int)dBToDataTable.Rows[i]["FLD_INDEX"],
						FLD_PID = int.Parse(dBToDataTable.Rows[i]["FLD_PID"].ToString()),
						FLD_MAGIC0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC0"],
						FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
						FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
						FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
						FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"],
						FLD_CJL = (int)dBToDataTable.Rows[i]["FLD_CJL"]
					});
				}
				Form1.WriteLine(2, "加载物品商店完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void SetstConfig()
		{
			try
			{
				Config.Pathst = Application.StartupPath + "\\StoneConfiguration.ini";
				启动职业气功热血石 = ((Config.IniReadValust("StoneConfiguration", "启动职业气功热血石").Trim() == "") ? 启动职业气功热血石 : int.Parse(Config.IniReadValust("StoneConfiguration", "启动职业气功热血石").Trim()));
				商店金刚石 = Config.IniReadValust("StoneConfiguration", "商店金刚石").Trim();
				商店寒玉石 = Config.IniReadValust("StoneConfiguration", "商店寒玉石").Trim();
				商店热血石 = Config.IniReadValust("StoneConfiguration", "商店热血石").Trim();
				商店混元金刚石 = Config.IniReadValust("StoneConfiguration", "商店混元金刚石").Trim();
				商店冰魄寒玉石武功防御 = Config.IniReadValust("StoneConfiguration", "商店冰魄寒玉石武功防御").Trim();
				商店冰魄寒玉石防御 = Config.IniReadValust("StoneConfiguration", "商店冰魄寒玉石防御").Trim();
				商店神秘金刚石追伤 = Config.IniReadValust("StoneConfiguration", "商店神秘金刚石追伤").Trim();
				商店神秘金刚石武功 = Config.IniReadValust("StoneConfiguration", "商店神秘金刚石武功").Trim();
				商店冰魄寒玉石类型设置 = ((!(Config.IniReadValust("StoneConfiguration", "商店冰魄寒玉石类型设置").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "商店冰魄寒玉石类型设置").Trim()) : 0);
				商店属性石 = ((!(Config.IniReadValust("StoneConfiguration", "商店属性石").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "商店属性石").Trim()) : 0);
				商店乾坤金刚石 = Config.IniReadValust("StoneConfiguration", "商店乾坤金刚石").Trim();
				商店凝霜寒玉石类型设置 = ((!(Config.IniReadValust("StoneConfiguration", "商店凝霜寒玉石类型设置").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "商店凝霜寒玉石类型设置").Trim()) : 0);
				商店凝霜寒玉石武功防御 = Config.IniReadValust("StoneConfiguration", "商店凝霜寒玉石武功防御").Trim();
				商店凝霜寒玉石防御 = Config.IniReadValust("StoneConfiguration", "商店凝霜寒玉石防御").Trim();
				百宝阁金刚石 = Config.IniReadValust("StoneConfiguration", "百宝阁金刚石").Trim();
				百宝阁寒玉石 = Config.IniReadValust("StoneConfiguration", "百宝阁寒玉石").Trim();
				百宝阁热血石 = Config.IniReadValust("StoneConfiguration", "百宝阁热血石").Trim();
				百宝阁混元金刚石 = Config.IniReadValust("StoneConfiguration", "百宝阁混元金刚石").Trim();
				百宝阁冰魄寒玉石武功防御 = Config.IniReadValust("StoneConfiguration", "百宝阁冰魄寒玉石武功防御").Trim();
				百宝阁冰魄寒玉石防御 = Config.IniReadValust("StoneConfiguration", "百宝阁冰魄寒玉石防御").Trim();
				百宝阁神秘金刚石追伤 = Config.IniReadValust("StoneConfiguration", "百宝阁神秘金刚石追伤").Trim();
				百宝阁神秘金刚石武功 = Config.IniReadValust("StoneConfiguration", "百宝阁神秘金刚石武功").Trim();
				百宝阁冰魄寒玉石类型设置 = ((!(Config.IniReadValust("StoneConfiguration", "百宝阁冰魄寒玉石类型设置").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "百宝阁冰魄寒玉石类型设置").Trim()) : 0);
				百宝阁属性石 = ((!(Config.IniReadValust("StoneConfiguration", "百宝阁属性石").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "百宝阁属性石").Trim()) : 0);
				百宝阁乾坤金刚石 = Config.IniReadValust("StoneConfiguration", "百宝阁乾坤金刚石").Trim();
				百宝阁凝霜寒玉石类型设置 = ((!(Config.IniReadValust("StoneConfiguration", "百宝阁凝霜寒玉石类型设置").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "百宝阁凝霜寒玉石类型设置").Trim()) : 0);
				百宝阁凝霜寒玉石武功防御 = Config.IniReadValust("StoneConfiguration", "百宝阁凝霜寒玉石武功防御").Trim();
				百宝阁凝霜寒玉石防御 = Config.IniReadValust("StoneConfiguration", "百宝阁凝霜寒玉石防御").Trim();
				百宝阁初级奇玉石 = Config.IniReadValust("StoneConfiguration", "百宝阁初级奇玉石").Trim();
				百宝阁中级奇玉石 = Config.IniReadValust("StoneConfiguration", "百宝阁中级奇玉石").Trim();
				百宝阁高级奇玉石 = Config.IniReadValust("StoneConfiguration", "百宝阁高级奇玉石").Trim();
				开箱金刚石 = Config.IniReadValust("StoneConfiguration", "开箱金刚石").Trim();
				开箱寒玉石 = Config.IniReadValust("StoneConfiguration", "开箱寒玉石").Trim();
				开箱热血石 = Config.IniReadValust("StoneConfiguration", "开箱热血石").Trim();
				开箱混元金刚石 = Config.IniReadValust("StoneConfiguration", "开箱混元金刚石").Trim();
				开箱冰魄寒玉石武功防御 = Config.IniReadValust("StoneConfiguration", "开箱冰魄寒玉石武功防御").Trim();
				开箱冰魄寒玉石防御 = Config.IniReadValust("StoneConfiguration", "开箱冰魄寒玉石防御").Trim();
				开箱冰魄寒玉石类型设置 = ((!(Config.IniReadValust("StoneConfiguration", "开箱冰魄寒玉石类型设置").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "开箱冰魄寒玉石类型设置").Trim()) : 0);
				开箱属性石 = ((!(Config.IniReadValust("StoneConfiguration", "开箱属性石").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "开箱属性石").Trim()) : 0);
				开箱乾坤金刚石攻击 = Config.IniReadValust("StoneConfiguration", "开箱乾坤金刚石攻击").Trim();
				开箱乾坤金刚石武功 = Config.IniReadValust("StoneConfiguration", "开箱乾坤金刚石武功").Trim();
				开箱乾坤金刚石类型设置 = ((!(Config.IniReadValust("StoneConfiguration", "开箱乾坤金刚石类型设置").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "开箱乾坤金刚石类型设置").Trim()) : 0);
				开箱凝霜寒玉石类型设置 = ((!(Config.IniReadValust("StoneConfiguration", "开箱凝霜寒玉石类型设置").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "开箱凝霜寒玉石类型设置").Trim()) : 0);
				开箱凝霜寒玉石武功防御 = Config.IniReadValust("StoneConfiguration", "开箱凝霜寒玉石武功防御").Trim();
				开箱凝霜寒玉石防御 = Config.IniReadValust("StoneConfiguration", "开箱凝霜寒玉石防御").Trim();
				奖励金刚石 = Config.IniReadValust("StoneConfiguration", "奖励金刚石").Trim();
				奖励寒玉石 = Config.IniReadValust("StoneConfiguration", "奖励寒玉石").Trim();
				奖励热血石 = Config.IniReadValust("StoneConfiguration", "奖励热血石").Trim();
				奖励混元金刚石 = Config.IniReadValust("StoneConfiguration", "奖励混元金刚石").Trim();
				奖励冰魄寒玉石武功防御 = Config.IniReadValust("StoneConfiguration", "奖励冰魄寒玉石武功防御").Trim();
				奖励冰魄寒玉石防御 = Config.IniReadValust("StoneConfiguration", "奖励冰魄寒玉石防御").Trim();
				奖励神秘金刚石追伤 = Config.IniReadValust("StoneConfiguration", "奖励神秘金刚石追伤").Trim();
				奖励神秘金刚石武功 = Config.IniReadValust("StoneConfiguration", "奖励神秘金刚石武功").Trim();
				奖励冰魄寒玉石类型设置 = ((!(Config.IniReadValust("StoneConfiguration", "奖励冰魄寒玉石类型设置").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "奖励冰魄寒玉石类型设置").Trim()) : 0);
				奖励属性石 = ((!(Config.IniReadValust("StoneConfiguration", "奖励属性石").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "奖励属性石").Trim()) : 0);
				奖励乾坤金刚石 = Config.IniReadValust("StoneConfiguration", "奖励乾坤金刚石").Trim();
				奖励凝霜寒玉石类型设置 = ((!(Config.IniReadValust("StoneConfiguration", "奖励凝霜寒玉石类型设置").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "奖励凝霜寒玉石类型设置").Trim()) : 0);
				奖励凝霜寒玉石武功防御 = Config.IniReadValust("StoneConfiguration", "奖励凝霜寒玉石武功防御").Trim();
				奖励凝霜寒玉石防御 = Config.IniReadValust("StoneConfiguration", "奖励凝霜寒玉石防御").Trim();
				普通怪暴金刚石 = Config.IniReadValust("StoneConfiguration", "普通怪暴金刚石").Trim();
				普通怪暴寒玉石 = Config.IniReadValust("StoneConfiguration", "普通怪暴寒玉石").Trim();
				普通怪暴热血石 = Config.IniReadValust("StoneConfiguration", "普通怪暴热血石").Trim();
				普通怪暴混元金刚石 = Config.IniReadValust("StoneConfiguration", "普通怪暴混元金刚石").Trim();
				普通怪暴冰魄寒玉石武功防御 = Config.IniReadValust("StoneConfiguration", "普通怪暴冰魄寒玉石武功防御").Trim();
				普通怪暴冰魄寒玉石防御 = Config.IniReadValust("StoneConfiguration", "普通怪暴冰魄寒玉石防御").Trim();
				普通怪暴神秘金刚石追伤 = Config.IniReadValust("StoneConfiguration", "普通怪暴神秘金刚石追伤").Trim();
				普通怪暴神秘金刚石武功 = Config.IniReadValust("StoneConfiguration", "普通怪暴神秘金刚石武功").Trim();
				普通怪暴冰魄寒玉石类型设置 = ((!(Config.IniReadValust("StoneConfiguration", "普通怪暴冰魄寒玉石类型设置").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "普通怪暴冰魄寒玉石类型设置").Trim()) : 0);
				普通怪暴属性石 = ((!(Config.IniReadValust("StoneConfiguration", "普通怪暴属性石").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "普通怪暴属性石").Trim()) : 0);
				普通怪暴乾坤金刚石 = Config.IniReadValust("StoneConfiguration", "普通怪暴乾坤金刚石").Trim();
				普通怪暴凝霜寒玉石类型设置 = ((!(Config.IniReadValust("StoneConfiguration", "普通怪暴凝霜寒玉石类型设置").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "普通怪暴凝霜寒玉石类型设置").Trim()) : 0);
				普通怪暴凝霜寒玉石武功防御 = Config.IniReadValust("StoneConfiguration", "普通怪暴凝霜寒玉石武功防御").Trim();
				普通怪暴凝霜寒玉石防御 = Config.IniReadValust("StoneConfiguration", "普通怪暴凝霜寒玉石防御").Trim();
				Boss怪暴金刚石 = Config.IniReadValust("StoneConfiguration", "BOSS怪暴金刚石").Trim();
				Boss怪暴寒玉石 = Config.IniReadValust("StoneConfiguration", "BOSS怪暴寒玉石").Trim();
				Boss怪暴热血石 = Config.IniReadValust("StoneConfiguration", "BOSS怪暴热血石").Trim();
				Boss怪暴混元金刚石 = Config.IniReadValust("StoneConfiguration", "BOSS怪暴混元金刚石").Trim();
				Boss怪暴冰魄寒玉石武功防御 = Config.IniReadValust("StoneConfiguration", "BOSS怪暴冰魄寒玉石武功防御").Trim();
				Boss怪暴冰魄寒玉石防御 = Config.IniReadValust("StoneConfiguration", "BOSS怪暴冰魄寒玉石防御").Trim();
				Boss怪暴神秘金刚石追伤 = Config.IniReadValust("StoneConfiguration", "BOSS怪暴神秘金刚石追伤").Trim();
				Boss怪暴神秘金刚石武功 = Config.IniReadValust("StoneConfiguration", "BOSS怪暴神秘金刚石武功").Trim();
				是否启用跑卡技能 = int.Parse(Config.IniReadValue("GameServer", "是否启用跑卡技能").Trim());
				Boss怪暴冰魄寒玉石类型设置 = ((!(Config.IniReadValust("StoneConfiguration", "BOSS怪暴冰魄寒玉石类型设置").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "BOSS怪暴冰魄寒玉石类型设置").Trim()) : 0);
				Boss怪暴属性石 = ((!(Config.IniReadValust("StoneConfiguration", "BOSS怪暴属性石").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "BOSS怪暴属性石").Trim()) : 0);
				Boss怪暴乾坤金刚石 = Config.IniReadValust("StoneConfiguration", "BOSS怪暴乾坤金刚石").Trim();
				Boss怪暴凝霜寒玉石类型设置 = ((!(Config.IniReadValust("StoneConfiguration", "BOSS怪暴凝霜寒玉石类型设置").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "BOSS怪暴凝霜寒玉石类型设置").Trim()) : 0);
				Boss怪暴凝霜寒玉石武功防御 = Config.IniReadValust("StoneConfiguration", "BOSS怪暴凝霜寒玉石武功防御").Trim();
				Boss怪暴凝霜寒玉石防御 = Config.IniReadValust("StoneConfiguration", "BOSS怪暴凝霜寒玉石防御").Trim();
				高手怪暴金刚石 = Config.IniReadValust("StoneConfiguration", "高手怪暴金刚石").Trim();
				高手怪暴寒玉石 = Config.IniReadValust("StoneConfiguration", "高手怪暴寒玉石").Trim();
				高手怪暴热血石 = Config.IniReadValust("StoneConfiguration", "高手怪暴热血石").Trim();
				高手怪暴混元金刚石 = Config.IniReadValust("StoneConfiguration", "高手怪暴混元金刚石").Trim();
				高手怪暴冰魄寒玉石武功防御 = Config.IniReadValust("StoneConfiguration", "高手怪暴冰魄寒玉石武功防御").Trim();
				高手怪暴冰魄寒玉石防御 = Config.IniReadValust("StoneConfiguration", "高手怪暴冰魄寒玉石防御").Trim();
				高手怪暴神秘金刚石追伤 = Config.IniReadValust("StoneConfiguration", "高手怪暴神秘金刚石追伤").Trim();
				高手怪暴神秘金刚石武功 = Config.IniReadValust("StoneConfiguration", "高手怪暴神秘金刚石武功").Trim();
				高手怪暴冰魄寒玉石类型设置 = ((!(Config.IniReadValust("StoneConfiguration", "高手怪暴冰魄寒玉石类型设置").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "高手怪暴冰魄寒玉石类型设置").Trim()) : 0);
				高手怪暴属性石 = ((!(Config.IniReadValust("StoneConfiguration", "高手怪暴属性石").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "高手怪暴属性石").Trim()) : 0);
				高手怪暴乾坤金刚石 = Config.IniReadValust("StoneConfiguration", "高手怪暴乾坤金刚石").Trim();
				高手怪暴凝霜寒玉石类型设置 = ((!(Config.IniReadValust("StoneConfiguration", "高手怪暴凝霜寒玉石类型设置").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "高手怪暴凝霜寒玉石类型设置").Trim()) : 0);
				高手怪暴凝霜寒玉石武功防御 = Config.IniReadValust("StoneConfiguration", "高手怪暴凝霜寒玉石武功防御").Trim();
				高手怪暴凝霜寒玉石防御 = Config.IniReadValust("StoneConfiguration", "高手怪暴凝霜寒玉石防御").Trim();
				再造金刚石攻击 = Config.IniReadValust("StoneConfiguration", "再造金刚石攻击").Trim();
				再造金刚石追伤 = Config.IniReadValust("StoneConfiguration", "再造金刚石追伤").Trim();
				再造金刚石武功 = Config.IniReadValust("StoneConfiguration", "再造金刚石武功").Trim();
				再造金刚石命中 = Config.IniReadValust("StoneConfiguration", "再造金刚石命中").Trim();
				再造金刚石生命 = Config.IniReadValust("StoneConfiguration", "再造金刚石生命").Trim();
				再造寒玉石防御 = Config.IniReadValust("StoneConfiguration", "再造寒玉石防御").Trim();
				再造寒玉石回避 = Config.IniReadValust("StoneConfiguration", "再造寒玉石回避").Trim();
				再造寒玉石生命 = Config.IniReadValust("StoneConfiguration", "再造寒玉石生命").Trim();
				再造寒玉石内功 = Config.IniReadValust("StoneConfiguration", "再造寒玉石内功").Trim();
				再造寒玉石武防 = Config.IniReadValust("StoneConfiguration", "再造寒玉石武防").Trim();
				每次再造消耗设置 = ((!(Config.IniReadValust("StoneConfiguration", "每次再造消耗设置").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "每次再造消耗设置").Trim()) : 0);
				每次消耗的数量 = ((!(Config.IniReadValust("StoneConfiguration", "每次消耗的数量").Trim() == "")) ? int.Parse(Config.IniReadValust("StoneConfiguration", "每次消耗的数量").Trim()) : 0);
			}
			catch (Exception ex)
			{
				Form1.WriteLine(100, "配置文件 StoneConfiguration.ini 配置错误:" + ex.Message);
				Form1.WriteLine(100, "7");
				Environment.Exit(0);
			}
		}

		public static void SetTz()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM 套装属性", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载套装出错----套装没有数据");
			}
			else
			{
				套装.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					套装.Add(new 套装属性类
					{
						价格 = (int)dBToDataTable.Rows[i]["价格"],
						等级 = (int)dBToDataTable.Rows[i]["等级"],
						类型 = (int)dBToDataTable.Rows[i]["类型"],
						magic0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC0"],
						magic1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
						magic2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
						magic3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
						magic4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"],
						中级魂 = (int)dBToDataTable.Rows[i]["FLD_中级魂"],
						觉醒 = (int)dBToDataTable.Rows[i]["FLD_觉醒"],
						进化 = (int)dBToDataTable.Rows[i]["FLD_进化"],
						绑定 = (int)dBToDataTable.Rows[i]["FLD_绑定"]
					});
				}
				Form1.WriteLine(2, "加载套装完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void SetTZlist()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM 套装列表", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载套装列表出错----套装列表没有数据");
			}
			else
			{
				套装列表.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					套装列表.Add((int)dBToDataTable.Rows[i]["PID"], new 套装列表类
					{
						_PID = (int)dBToDataTable.Rows[i]["PID"],
						_价格 = (int)dBToDataTable.Rows[i]["价格"],
						_女披风款式 = (int)dBToDataTable.Rows[i]["女披风款式"],
						_男披风款式 = (int)dBToDataTable.Rows[i]["男披风款式"],
						_增加等级 = (int)dBToDataTable.Rows[i]["增加等级"],
						_增加攻击 = (int)dBToDataTable.Rows[i]["增加攻击"],
						_增加防御 = (int)dBToDataTable.Rows[i]["增加防御"],
						_增加生命 = (int)dBToDataTable.Rows[i]["增加生命"],
						_增加魔法 = (int)dBToDataTable.Rows[i]["增加魔法"],
						_增加武勋 = (int)dBToDataTable.Rows[i]["增加武勋"],
						_赠送元宝 = (int)dBToDataTable.Rows[i]["赠送元宝"],
						_会员时间 = (int)dBToDataTable.Rows[i]["会员时间"],
						_会员等级 = (int)dBToDataTable.Rows[i]["会员等级"],
						_是否公告 = (int)dBToDataTable.Rows[i]["是否公告"],
						_公告内容 = dBToDataTable.Rows[i]["公告内容"].ToString()
					});
				}
				Form1.WriteLine(2, "加载套装列表数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void SetWxLever()
		{
			Wxlever.Clear();
			Wxlever.Add(0, 0.0);
			Wxlever.Add(1, 999.0);
			Wxlever.Add(2, 14999.0);
			Wxlever.Add(3, 49999.0);
			Wxlever.Add(4, 99999.0);
			Wxlever.Add(5, 599999.0);
			Wxlever.Add(6, 1199999.0);
			Wxlever.Add(7, 1499999.0);
			Form1.WriteLine(2, "Update Wuxun Config!");
		}

		public static void Set安全区()
		{
			安全区.Add(new 坐标Class
			{
				Rxjh_ID = "safezone_" + 安全区地图,
				Rxjh_Name = "安全区",
				Rxjh_Map = 安全区地图,
				Rxjh_X = 安全区x坐标,
				Rxjh_Y = 安全区y坐标,
				Rxjh_Z = 15f
			});
			Form1.WriteLine(2, "加载安全区成功");
		}

		public static void Set冲关地图()
		{
			try
			{
				冲关地图list.Clear();
				string[] array = 冲关地图.Split(';');
				if (array.Length > 1)
				{
					for (int i = 0; i < array.Length; i++)
					{
						string[] array2 = array[i].Split(',');
						if (array2.Length > 1 && !冲关地图list.ContainsKey(array2[0]))
						{
							冲关地图类 冲关地图类 = new 冲关地图类();
							冲关地图类.地图名 = array2[0];
							冲关地图类.ItmeID = int.Parse(array2[1]);
							冲关地图list.Add(冲关地图类.地图名, 冲关地图类);
						}
					}
				}
				Form1.WriteLine(2, "加载冲关地图成功");
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "加载冲关地图出错---" + ex.Message);
			}
		}

		public static void Set公告()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_XWWL_Gg", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载公告出错----没有公告数据");
			}
			else
			{
				公告.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					公告.Add(i, new 公告类
					{
						msg = dBToDataTable.Rows[i]["txt"].ToString(),
						type = (int)dBToDataTable.Rows[i]["type"]
					});
				}
				Form1.WriteLine(2, "加载公告数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public void Set检查物品()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM XWWL_JC", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载检查物品出错----没有检查物品数据");
			}
			else
			{
				物品检查.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					物品检查.Add(new 检查物品类
					{
						物品ID = (int)dBToDataTable.Rows[i]["FLD_PID"],
						物品类型 = (int)dBToDataTable.Rows[i]["FLD_TYPE"],
						FLD_MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"],
						FLD_MAGIC1_1 = dBToDataTable.Rows[i]["FLD_MAGIC1_1"].ToString(),
						FLD_MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"],
						FLD_MAGIC2_2 = dBToDataTable.Rows[i]["FLD_MAGIC2_2"].ToString(),
						FLD_MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"],
						FLD_MAGIC3_3 = dBToDataTable.Rows[i]["FLD_MAGIC3_3"].ToString(),
						FLD_MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"],
						FLD_MAGIC4_4 = dBToDataTable.Rows[i]["FLD_MAGIC4_4"].ToString(),
						FLD_MAGIC5 = (int)dBToDataTable.Rows[i]["FLD_MAGIC5"],
						FLD_MAGIC5_5 = dBToDataTable.Rows[i]["FLD_MAGIC5_5"].ToString()
					});
				}
				Form1.WriteLine(2, "加载检查物品数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void Set升天气功()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM 升天气功 ORDER BY 气功ID", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载升天气功完成----没有升天气功数据");
			}
			else
			{
				升天气功List.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					升天气功总类 升天气功总类 = new 升天气功总类();
					升天气功总类.气功ID = (int)dBToDataTable.Rows[i]["气功ID"];
					升天气功总类.物品ID = (int)dBToDataTable.Rows[i]["物品ID"];
					升天气功总类.人物职业1 = (int)dBToDataTable.Rows[i]["人物职业1"];
					升天气功总类.人物职业2 = (int)dBToDataTable.Rows[i]["人物职业2"];
					升天气功总类.人物职业3 = (int)dBToDataTable.Rows[i]["人物职业3"];
					升天气功总类.人物职业4 = (int)dBToDataTable.Rows[i]["人物职业4"];
					升天气功总类.人物职业5 = (int)dBToDataTable.Rows[i]["人物职业5"];
					升天气功总类.人物职业6 = (int)dBToDataTable.Rows[i]["人物职业6"];
					升天气功总类.人物职业7 = (int)dBToDataTable.Rows[i]["人物职业7"];
					升天气功总类.人物职业8 = (int)dBToDataTable.Rows[i]["人物职业8"];
					升天气功总类.人物职业9 = (int)dBToDataTable.Rows[i]["人物职业9"];
					升天气功总类.人物职业10 = (int)dBToDataTable.Rows[i]["人物职业10"];
					升天气功总类.人物职业11 = (int)dBToDataTable.Rows[i]["人物职业11"];
					升天气功总类.人物职业12 = (int)dBToDataTable.Rows[i]["人物职业12"];
					升天气功List.Add(升天气功总类.气功ID, 升天气功总类);
				}
				Form1.WriteLine(2, "加载升天气功 " + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void Set石头属性()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM 石头属性效果", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载石头属性效果出错----没有石头属性效果数据");
			}
			else
			{
				石头属性调整.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					石头属性调整.Add(i, new 石头属性调整类
					{
						FLD_ID = (int)dBToDataTable.Rows[i]["FLD_ID"],
						FLD_百分比 = (int)dBToDataTable.Rows[i]["FLD_百分比"]
					});
				}
				Form1.WriteLine(2, "加载石头属性效果数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void Set箱子送元宝()
		{
			try
			{
				箱子送元宝.Clear();
				string[] array = 开箱子送元宝.Split(';');
				if (array.Length > 1)
				{
					for (int i = 0; i < array.Length; i++)
					{
						string[] array2 = array[i].Split(',');
						if (array2.Length > 1 && !箱子送元宝.ContainsKey(int.Parse(array2[0])))
						{
							箱子送元宝类 箱子送元宝类 = new 箱子送元宝类();
							箱子送元宝类.ItmeID = int.Parse(array2[0]);
							箱子送元宝类.元宝 = int.Parse(array2[1]);
							箱子送元宝.Add(箱子送元宝类.ItmeID, 箱子送元宝类);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "加载箱子送元宝出错---" + ex.Message);
			}
		}

		public static void Set移动()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM TBL_XWWL_MAP WHERE (X IS NOT NULL)", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载自定义移动出错----没有移动数据");
			}
			else
			{
				Map_Move.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					Map_Move.Add(new 坐标Class
					{
						Rxjh_ID = dBToDataTable.Rows[i]["FLD_ID"].ToString(),
						Rxjh_Name = dBToDataTable.Rows[i]["FLD_NAME"].ToString(),
						Rxjh_Map = (int)dBToDataTable.Rows[i]["FLD_MID"],
						Rxjh_X = float.Parse(dBToDataTable.Rows[i]["X"].ToString()),
						Rxjh_Y = float.Parse(dBToDataTable.Rows[i]["Y"].ToString()),
						Rxjh_Z = 15f,
						Rxjh_LEVEL = (int)dBToDataTable.Rows[i]["FLD_LEVEL"]
					});
				}
				Form1.WriteLine(2, "加载自定义移动数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void Set制作物品()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM 制作物品列表 ORDER BY 物品ID", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载制作物品完成----没有制作物品数据");
				return;
			}
			制作物品列表.Clear();
			int num = 0;
			while (true)
			{
				bool flag = true;
				if (num < dBToDataTable.Rows.Count)
				{
					clsItemCraft clsItemCraft = new clsItemCraft();
					try
					{
						clsItemCraft.物品ID = (int)dBToDataTable.Rows[num]["物品ID"];
						clsItemCraft.物品名 = dBToDataTable.Rows[num]["物品名"].ToString();
						clsItemCraft.物品数量 = (int)dBToDataTable.Rows[num]["物品数量"];
						clsItemCraft.制作类型 = (int)dBToDataTable.Rows[num]["制作类型"];
						clsItemCraft.制作等级 = (int)dBToDataTable.Rows[num]["制作等级"];
						string value = dBToDataTable.Rows[num]["需要物品"].ToString();
						clsItemCraft.需要物品 = JsonConvert.DeserializeObject<List<clsItemCraftRequired>>(value);
						if (!制作物品列表.ContainsKey(clsItemCraft.物品ID))
						{
							制作物品列表.Add(clsItemCraft.物品ID, clsItemCraft);
						}
					}
					catch (Exception ex)
					{
						Form1.WriteLine(1, "加载制作物品 错误" + clsItemCraft.物品ID + "  " + ex.Message);
					}
					num++;
					continue;
				}
				break;
			}
			Form1.WriteLine(2, "加载制作物品 " + dBToDataTable.Rows.Count);
		}

		public static void Translation()
		{
			try
			{
				string[] array = File.ReadAllLines(Application.StartupPath + "\\translation.lua", Encoding.GetEncoding(1252));
				文本兑换.Clear();
				string[] array2 = array;
				foreach (string text in array2)
				{
					char[] separator = new char[1]
					{
						'*'
					};
					string[] array3 = text.Split(separator);
					if (!文本兑换.ContainsKey(array3[0]))
					{
						文本兑换.Add(array3[0], new 文本兑换类
						{
							中文 = array3[0],
							英文 = array3[1]
						});
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "加载文本替换出错---" + ex.Message);
			}
		}

		public static 百宝阁类 查询百宝物品(int pid)
		{
			foreach (百宝阁类 value in 百宝阁属性物品类list.Values)
			{
				if (value != null && value.PID == pid)
				{
					return value;
				}
			}
			return null;
		}

		public static void 发送公告(string msg)
		{
			foreach (Players value in AllConnectedChars.Values)
			{
				value.系统公告(msg);
			}
		}

		public static void 发送强化合成公告(int pid, string name, int level, int zx)
		{
			foreach (Players value in AllConnectedChars.Values)
			{
				value.强化合成公告(pid, name, level, zx);
			}
		}

		public static void 发送全服狮子吼消息广播数据(int 人物全服id, string name, int msgid, string msg, int 线, int map)
		{
			try
			{
				byte[] array = Converter.hexStringToByte("AA55B300012C016600A400CC00000000000000000000000000000000000000000000310000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
				if (Newversion >= 16)
				{
					array[11] = 204;
					Buffer.BlockCopy(BitConverter.GetBytes(线), 0, array, 168, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(0), 0, array, 172, 4);
					byte[] bytes = Encoding.GetEncoding(1252).GetBytes(name);
					byte[] bytes2 = Encoding.GetEncoding(1252).GetBytes(msg);
					Buffer.BlockCopy(bytes2, 0, array, 36, bytes2.Length);
					Buffer.BlockCopy(bytes, 0, array, 13, bytes.Length);
					Buffer.BlockCopy(BitConverter.GetBytes(人物全服id), 0, array, 5, 2);
					array[35] = (byte)msgid;
					foreach (Players value in AllConnectedChars.Values)
					{
						if (value.Client != null)
						{
							value.Client.Send(array, array.Length);
						}
					}
				}
				else
				{
					array[11] = 204;
					Buffer.BlockCopy(BitConverter.GetBytes(线), 0, array, 167, 4);
					Buffer.BlockCopy(BitConverter.GetBytes(map), 0, array, 171, 4);
					byte[] bytes = Encoding.GetEncoding(1252).GetBytes(name);
					byte[] bytes2 = Encoding.GetEncoding(1252).GetBytes(msg);
					Buffer.BlockCopy(bytes2, 0, array, 35, bytes2.Length);
					Buffer.BlockCopy(bytes, 0, array, 12, bytes.Length);
					Buffer.BlockCopy(BitConverter.GetBytes(人物全服id), 0, array, 5, 2);
					array[34] = (byte)msgid;
					foreach (Players value2 in AllConnectedChars.Values)
					{
						if (value2.Client != null)
						{
							value2.Client.Send(array, array.Length);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "World发送狮子吼消息广播数据出错![" + 人物全服id + "]-[" + name + "]-[" + msg + "]" + ex.Message);
			}
		}

		public static void 发送狮子吼消息广播数据(int 人物全服id, string name, int msgid, string msg)
		{
			try
			{
				byte[] array = Converter.hexStringToByte("AA55A6000000006600970000C8CEBDDC0000000000000000000000000000000000003000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000055AA");
				if (Newversion >= 16)
				{
					array[11] = 14;
					byte[] bytes = Encoding.GetEncoding(1252).GetBytes(name);
					byte[] bytes2 = Encoding.GetEncoding(1252).GetBytes(msg);
					Buffer.BlockCopy(bytes2, 0, array, 36, bytes2.Length);
					Buffer.BlockCopy(bytes, 0, array, 13, bytes.Length);
					Buffer.BlockCopy(BitConverter.GetBytes(人物全服id), 0, array, 5, 2);
					array[35] = (byte)msgid;
					foreach (Players value in AllConnectedChars.Values)
					{
						if (value.Client != null)
						{
							value.Client.Send(array, array.Length);
						}
					}
				}
				else
				{
					array[11] = 14;
					byte[] bytes = Encoding.GetEncoding(1252).GetBytes(name);
					byte[] bytes2 = Encoding.GetEncoding(1252).GetBytes(msg);
					Buffer.BlockCopy(bytes2, 0, array, 35, bytes2.Length);
					Buffer.BlockCopy(bytes, 0, array, 12, bytes.Length);
					Buffer.BlockCopy(BitConverter.GetBytes(人物全服id), 0, array, 5, 2);
					array[34] = (byte)msgid;
					foreach (Players value2 in AllConnectedChars.Values)
					{
						if (value2.Client != null)
						{
							value2.Client.Send(array, array.Length);
						}
					}
				}
			}
			catch (Exception ex)
			{
				Form1.WriteLine(1, "World发送狮子吼消息广播数据出错![" + 人物全服id + "]-[" + name + "]-[" + msg + "]" + ex.Message);
			}
		}

		public static void 加载百宝阁()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM ITEMSELL", "baibao");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载百宝阁物品----没有百宝阁数据");
			}
			else
			{
				百宝阁属性物品类list.Clear();
				百宝阁属性物品类list2.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					百宝阁类 百宝阁类 = new 百宝阁类();
					百宝阁类.id = (int)dBToDataTable.Rows[i]["id"];
					百宝阁类.PID = (int)dBToDataTable.Rows[i]["FLD_PID"];
					百宝阁类.NAME = dBToDataTable.Rows[i]["FLD_NAME"].ToString();
					百宝阁类.PRICE = (int)dBToDataTable.Rows[i]["FLD_PRICE"];
					百宝阁类.DESC = dBToDataTable.Rows[i]["FLD_DESC"].ToString();
					百宝阁类.TYPE = (int)dBToDataTable.Rows[i]["FLD_TYPE"];
					百宝阁类.RETURN = (int)dBToDataTable.Rows[i]["FLD_RETURN"];
					百宝阁类.NUMBER = (int)dBToDataTable.Rows[i]["FLD_NUMBER"];
					百宝阁类.MAGIC0 = (int)dBToDataTable.Rows[i]["FLD_MAGIC1"];
					百宝阁类.MAGIC1 = (int)dBToDataTable.Rows[i]["FLD_MAGIC2"];
					百宝阁类.MAGIC2 = (int)dBToDataTable.Rows[i]["FLD_MAGIC3"];
					百宝阁类.MAGIC3 = (int)dBToDataTable.Rows[i]["FLD_MAGIC4"];
					百宝阁类.MAGIC4 = (int)dBToDataTable.Rows[i]["FLD_MAGIC5"];
					百宝阁类.觉醒 = (int)dBToDataTable.Rows[i]["FLD_初级附魂"];
					百宝阁类.中级魂 = (int)dBToDataTable.Rows[i]["FLD_中级附魂"];
					百宝阁类.进化 = (int)dBToDataTable.Rows[i]["FLD_进化"];
					百宝阁类.绑定 = (int)dBToDataTable.Rows[i]["FLD_是否绑定"];
					百宝阁类.使用天数 = (int)dBToDataTable.Rows[i]["FLD_DAYS"];
					百宝阁属性物品类list.Add(百宝阁类.PID, 百宝阁类);
					百宝阁属性物品类list2.Add(百宝阁类.id, 百宝阁类);
				}
				Form1.WriteLine(2, "加载百宝阁数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void 加载等级奖励()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM 等级奖励", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载等级奖励出错----没有等级奖励数据");
			}
			else
			{
				等级奖励数据.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					等级奖励数据.Add(i, new 等级奖励类
					{
						级别 = (int)dBToDataTable.Rows[i]["级别"],
						武勋 = (int)dBToDataTable.Rows[i]["武勋"],
						元宝 = (int)dBToDataTable.Rows[i]["元宝"],
						生命 = (int)dBToDataTable.Rows[i]["生命"],
						攻击 = (int)dBToDataTable.Rows[i]["攻击"],
						防御 = (int)dBToDataTable.Rows[i]["防御"],
						回避 = (int)dBToDataTable.Rows[i]["回避"],
						命中 = (int)dBToDataTable.Rows[i]["命中"],
						内功 = (int)dBToDataTable.Rows[i]["内功"],
						套装ID = (int)dBToDataTable.Rows[i]["套装ID"],
						金钱 = dBToDataTable.Rows[i]["金钱"].ToString(),
						单件物品 = dBToDataTable.Rows[i]["单件物品1"].ToString(),
						单件物品2 = dBToDataTable.Rows[i]["单件物品2"].ToString(),
						会员等级 = (int)dBToDataTable.Rows[i]["会员等级"]
					});
				}
				Form1.WriteLine(2, "加载等级奖励数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void 加载物品兑换()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM 物品兑换", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载物品兑换出错----没有物品兑换数据");
			}
			else
			{
				物品兑换数据.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					物品兑换数据.Add(i, new 物品兑换类
					{
						需要物品 = dBToDataTable.Rows[i]["需要物品"].ToString(),
						武勋 = (int)dBToDataTable.Rows[i]["武勋"],
						元宝 = (int)dBToDataTable.Rows[i]["元宝"],
						生命 = (int)dBToDataTable.Rows[i]["生命"],
						攻击 = (int)dBToDataTable.Rows[i]["攻击"],
						防御 = (int)dBToDataTable.Rows[i]["防御"],
						回避 = (int)dBToDataTable.Rows[i]["回避"],
						命中 = (int)dBToDataTable.Rows[i]["命中"],
						内功 = (int)dBToDataTable.Rows[i]["内功"],
						套装ID = (int)dBToDataTable.Rows[i]["套装ID"],
						金钱 = dBToDataTable.Rows[i]["金钱"].ToString(),
						单件物品 = dBToDataTable.Rows[i]["单件物品"].ToString(),
						说明 = dBToDataTable.Rows[i]["说明"].ToString()
					});
				}
				Form1.WriteLine(2, "加载物品兑换数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void 加载在线时间奖励()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM 在线时间奖励", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载在线时间奖励出错----没有在线时间奖励数据");
			}
			else
			{
				在线时间奖励数据.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					在线时间奖励数据.Add(i, new 在线时间奖励类
					{
						时间分钟 = (int)dBToDataTable.Rows[i]["时间分钟"],
						武勋 = (int)dBToDataTable.Rows[i]["武勋"],
						元宝 = (int)dBToDataTable.Rows[i]["元宝"],
						生命 = (int)dBToDataTable.Rows[i]["生命"],
						攻击 = (int)dBToDataTable.Rows[i]["攻击"],
						防御 = (int)dBToDataTable.Rows[i]["防御"],
						回避 = (int)dBToDataTable.Rows[i]["回避"],
						命中 = (int)dBToDataTable.Rows[i]["命中"],
						内功 = (int)dBToDataTable.Rows[i]["内功"],
						套装ID = (int)dBToDataTable.Rows[i]["套装ID"],
						金钱 = dBToDataTable.Rows[i]["金钱"].ToString(),
						单件物品 = dBToDataTable.Rows[i]["单件物品"].ToString()
					});
				}
				Form1.WriteLine(2, "加载在线时间奖励数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void 加载转生次数奖励()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM 转生次数奖励", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载转生次数奖励出错----没有转生次数奖励数据");
			}
			else
			{
				转生次数数据.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					转生次数数据.Add(i, new 转生次数类
					{
						转生次数 = (int)dBToDataTable.Rows[i]["转生次数"],
						武勋 = (int)dBToDataTable.Rows[i]["武勋"],
						元宝 = (int)dBToDataTable.Rows[i]["元宝"],
						生命 = (int)dBToDataTable.Rows[i]["生命"],
						攻击 = (int)dBToDataTable.Rows[i]["攻击"],
						防御 = (int)dBToDataTable.Rows[i]["防御"],
						回避 = (int)dBToDataTable.Rows[i]["回避"],
						命中 = (int)dBToDataTable.Rows[i]["命中"],
						内功 = (int)dBToDataTable.Rows[i]["内功"],
						套装ID = (int)dBToDataTable.Rows[i]["套装ID"],
						金钱 = dBToDataTable.Rows[i]["金钱"].ToString(),
						单件物品 = dBToDataTable.Rows[i]["单件物品"].ToString(),
						会员等级 = (int)dBToDataTable.Rows[i]["会员等级"]
					});
				}
				Form1.WriteLine(2, "加载转生次数奖励数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static void 加载转职属性()
		{
			DataTable dBToDataTable = DBA.GetDBToDataTable($"SELECT * FROM 自定义转职属性", "PublicDb");
			if (dBToDataTable == null)
			{
				return;
			}
			if (dBToDataTable.Rows.Count == 0)
			{
				Form1.WriteLine(1, "加载人物转职属性出错----没有人物转职属性数据");
			}
			else
			{
				转职属性数据.Clear();
				for (int i = 0; i < dBToDataTable.Rows.Count; i++)
				{
					转职属性数据.Add(i, new TransferAttributes
					{
						FLD_JOB_LEVEL = (int)dBToDataTable.Rows[i]["FLD_JOB_LEVEL"],
						FLD_AT = (int)dBToDataTable.Rows[i]["FLD_AT"],
						FLD_DF = (int)dBToDataTable.Rows[i]["FLD_DF"],
						FLD_HP = (int)dBToDataTable.Rows[i]["FLD_HP"],
						FLD_MP = (int)dBToDataTable.Rows[i]["FLD_MP"]
					});
				}
				Form1.WriteLine(2, "加载人物转职属性数据完成" + dBToDataTable.Rows.Count);
			}
			dBToDataTable.Dispose();
		}

		public static bool 检查数据库配置()
		{
			using (SqlConnection sqlConnection = new SqlConnection(DBA.getstrConnection("rxjhaccount")))
			{
				try
				{
					sqlConnection.Open();
				}
				catch
				{
					Form1.WriteLine(1, "数据库rxjhaccount配置错误，无法连接");
					return false;
				}
				finally
				{
					sqlConnection.Close();
				}
			}
			using (SqlConnection sqlConnection = new SqlConnection(DBA.getstrConnection("baibao")))
			{
				try
				{
					sqlConnection.Open();
				}
				catch
				{
					Form1.WriteLine(1, "数据库bbg配置错误，无法连接");
					return false;
				}
				finally
				{
					sqlConnection.Close();
				}
			}
			using (SqlConnection sqlConnection = new SqlConnection(DBA.getstrConnection("GameServer")))
			{
				try
				{
					sqlConnection.Open();
				}
				catch
				{
					Form1.WriteLine(1, "数据库rxjhgame配置错误，无法连接");
					return false;
				}
				finally
				{
					sqlConnection.Close();
				}
			}
			using (SqlConnection sqlConnection = new SqlConnection(DBA.getstrConnection("PublicDb")))
			{
				try
				{
					sqlConnection.Open();
				}
				catch
				{
					Form1.WriteLine(1, "数据库PublicDb配置错误，无法连接");
					return false;
				}
				finally
				{
					sqlConnection.Close();
				}
			}
			return true;
		}

		public static Players 检查玩家(string userid)
		{
			foreach (Players value in AllConnectedChars.Values)
			{
				if (value.Userid.ToLower() == userid.ToLower())
				{
					return value;
				}
			}
			return null;
		}

		public static Players FindPlayerbyName(string username)
		{
			foreach (Players value in AllConnectedChars.Values)
			{
				if (value.UserName.ToLower() == username.ToLower())
				{
					return value;
				}
			}
			return null;
		}

		public static Players FindPlayerbyID(int id)
		{
			if (AllConnectedChars.TryGetValue(id, out Players value))
			{
				return value;
			}
			return null;
		}

		public static bool 检查物品是否被锁定(int pid)
		{
			string text = 物品锁定;
			char[] separator = new char[1]
			{
				','
			};
			string[] array = text.Split(separator);
			foreach (string a in array)
			{
				if (a == pid.ToString())
				{
					return true;
				}
			}
			return false;
		}

		public static int checkSpecialWeapons(long idItem)
		{
			if ((idItem >= 100204001 && idItem <= 100204010) || (idItem >= 100204026 && idItem <= 100204027) || (idItem >= 100204033 && idItem <= 100204034))
			{
				return 8;
			}
			if ((idItem >= 200204001 && idItem <= 200204010) || (idItem >= 200204026 && idItem <= 200204027) || (idItem >= 200204033 && idItem <= 200204034))
			{
				return 9;
			}
			if ((idItem >= 300204001 && idItem <= 300204010) || (idItem >= 300204026 && idItem <= 300204027) || (idItem >= 300204033 && idItem <= 300204034))
			{
				return 12;
			}
			if ((idItem >= 400204001 && idItem <= 400204010) || (idItem >= 400204026 && idItem <= 400204027) || (idItem >= 400204033 && idItem <= 400204034))
			{
				return 11;
			}
			return 0;
		}

		public static bool checkItemCanTrade(long iditem)
		{
			if ((Newversion != 15 && checkSpecialWeapons(iditem) != 0) || checkIsItemHeavePet(iditem))
			{
				return false;
			}
			return true;
		}

		public static bool checkItemCanStore(long iditem)
		{
			if (iditem == 1000001150)
			{
				return false;
			}
			return true;
		}

		public static bool checkIsItemHeavePet(long iditem)
		{
			if (iditem >= 1000001170 && iditem <= 1000001175)
			{
				return true;
			}
			return false;
		}

		public static int checkLuckyItem(long iditem)
		{
			int result = 0;
			if (iditem <= 800000022)
			{
				if (iditem <= 800000008)
				{
					if (iditem < 800000003)
					{
						goto IL_00d8;
					}
					switch (iditem - 800000003)
					{
					case 0L:
					case 4L:
						goto IL_00bb;
					case 1L:
					case 5L:
						goto IL_00bf;
					case 2L:
						goto IL_00c4;
					case 3L:
						goto IL_00d8;
					}
				}
				if (iditem <= 800000022 && iditem >= 800000020)
				{
					switch (iditem - 800000020)
					{
					case 0L:
						break;
					case 1L:
						goto IL_00bf;
					case 2L:
						goto IL_00c4;
					default:
						goto IL_00d8;
					}
					goto IL_00bb;
				}
			}
			else if (iditem != 800000029)
			{
				if (iditem != 1008000136)
				{
					if (iditem <= 1008001074 && iditem >= 1008001071)
					{
						switch (iditem - 1008001071)
						{
						case 0L:
							break;
						case 1L:
							goto IL_00bf;
						case 2L:
							goto IL_00c4;
						case 3L:
							result = 20;
							goto IL_00d8;
						default:
							goto IL_00d8;
						}
						goto IL_00bb;
					}
				}
				else
				{
					result = 25;
				}
			}
			else
			{
				result = -30;
			}
			goto IL_00d8;
			IL_00bb:
			result = 5;
			goto IL_00d8;
			IL_00d8:
			return result;
			IL_00bf:
			result = 10;
			goto IL_00d8;
			IL_00c4:
			result = 15;
			goto IL_00d8;
		}

		public static bool isExporllItem(int iditem)
		{
			if (iditem >= 9000085 && iditem <= 9009970)
			{
				return true;
			}
			return false;
		}

		public static int getTypeExporllItem(int iditem)
		{
			if (isExporllItem(iditem))
			{
				switch (iditem)
				{
				case 9000088:
				case 9000104:
				case 9000105:
				case 9000144:
				case 9000145:
				case 9000168:
				case 9000545:
				case 9000568:
				case 9001214:
				case 9009151:
				case 9009788:
				case 9009789:
				case 9009790:
				case 9009803:
				case 9009820:
				case 9009964:
					return 2;
				default:
					return 1;
				}
			}
			return 0;
		}

		public static bool isNTCItem(long iditem)
		{
			if ((iditem >= 1008000261 && iditem <= 1008000286) || (iditem >= 1008001390 && iditem <= 1008001392) || iditem == 1008000237)
			{
				return true;
			}
			return false;
		}

		public static bool isStone(long iditem)
		{
			if ((iditem >= 800000001 && iditem <= 800000002) || (iditem >= 800000011 && iditem <= 800000013) || (iditem >= 800000023 && iditem <= 800000028) || (iditem >= 800000032 && iditem <= 800000033) || (iditem >= 800000036 && iditem <= 800000044) || (iditem >= 800000060 && iditem <= 800000062))
			{
				return true;
			}
			return false;
		}

		public static bool isMapPK(long map)
		{
			if (map == 101 || map == 5501 || map == 20001 || map == 25301 || map == 25501 || map == 25701 || map == 30000 || map == 30100 || map == 30200 || map == 30300)
			{
				return false;
			}
			return true;
		}

		public static int getBuffTuLinh(int myTuLinh, int mySoul, int targetTuLinh, int targetSoul)
		{
			if (myTuLinh == 0 && targetTuLinh == 0)
			{
				return 0;
			}
			if (myTuLinh != 0 && targetTuLinh == 0)
			{
				return 5;
			}
			if (myTuLinh == 0 && targetTuLinh != 0)
			{
				return 4;
			}
			if (myTuLinh == targetTuLinh || (myTuLinh == 1 && targetTuLinh == 3) || (myTuLinh == 2 && targetTuLinh == 4) || (myTuLinh == 3 && targetTuLinh == 1) || (myTuLinh == 4 && targetTuLinh == 2))
			{
				if (mySoul > targetSoul)
				{
					return 5;
				}
				if (mySoul < targetSoul)
				{
					return 4;
				}
				return 0;
			}
			switch (myTuLinh)
			{
			case 1:
				switch (targetTuLinh)
				{
				case 2:
					return 5;
				case 4:
					return 4;
				}
				break;
			case 2:
				switch (targetTuLinh)
				{
				case 3:
					return 5;
				case 1:
					return 4;
				}
				break;
			case 3:
				switch (targetTuLinh)
				{
				case 4:
					return 5;
				case 2:
					return 4;
				}
				break;
			case 4:
				switch (targetTuLinh)
				{
				case 1:
					return 5;
				case 3:
					return 4;
				}
				break;
			}
			return 0;
		}

		public static int getTypeWar801()
		{
			if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
			{
				return 2;
			}
			if (DateTime.Now.DayOfWeek == DayOfWeek.Monday || DateTime.Now.DayOfWeek == DayOfWeek.Wednesday || DateTime.Now.DayOfWeek == DayOfWeek.Friday)
			{
				return 1;
			}
			if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday || DateTime.Now.DayOfWeek == DayOfWeek.Thursday || DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
			{
				return 0;
			}
			return -1;
		}

		public static int getwarboss()
		{
			if (DateTime.Now.DayOfWeek == DayOfWeek.Friday || DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
			{
				return 1;
			}
			return -1;
		}

		public static int getValueRankCouple(int rank)
		{
			switch (rank)
			{
			case 11:
				return 0;
			case 10:
				return 605;
			case 9:
				return 1513;
			case 8:
				return 3025;
			case 7:
				return 5042;
			case 6:
				return 7203;
			case 5:
				return 10290;
			case 4:
				return 14700;
			case 3:
				return 21000;
			case 2:
				return 30000;
			case 1:
				return 35000;
			case 0:
				return 35000;
			default:
				return 605;
			}
		}
	}
}

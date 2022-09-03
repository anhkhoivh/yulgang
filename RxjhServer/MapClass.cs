using RxjhServer.RxjhServer;
using System.Collections.Generic;

namespace RxjhServer
{
	public class MapClass
	{
		private int eval_a;

		public Dictionary<int, NpcClass> npcTemplate = new Dictionary<int, NpcClass>();

		public int MapID
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

		public void add(NpcClass npc)
		{
			int num = 10000;
			while (true)
			{
				if (num < 50000)
				{
					if (!npcTemplate.ContainsKey(num))
					{
						break;
					}
					num++;
					continue;
				}
				return;
			}
			npc.FldIndex = num;
			if (!npcTemplate.ContainsKey(npc.FldIndex))
			{
				npcTemplate.Add(npc.FldIndex, npc);
			}
		}

		public void del(int NpcWordId)
		{
			using (new Lock(npcTemplate, "MapClass-del"))
			{
				npcTemplate.Remove(NpcWordId);
			}
		}

		public static void delnpc(int mapp, int NpcWordId)
		{
			if (World.Map.TryGetValue(mapp, out MapClass value))
			{
				value.del(NpcWordId);
			}
		}

		public static NpcClass GetNpc(int mapp, int NpcWordId)
		{
			NpcClass value2 = default(NpcClass);
			if (World.Map.TryGetValue(mapp, out MapClass value) && value.npcTemplate.TryGetValue(NpcWordId, out value2))
			{
				return value2;
			}
			return null;
		}

		public static int GetNpcConn()
		{
			int num = 0;
			foreach (MapClass value in World.Map.Values)
			{
				num += value.npcTemplate.Count;
			}
			return num;
		}

		public static Dictionary<int, NpcClass> GetnpcTemplate(int mapp)
		{
			if (World.Map.TryGetValue(mapp, out MapClass value))
			{
				return value.npcTemplate;
			}
			return new Dictionary<int, NpcClass>();
		}
	}
}

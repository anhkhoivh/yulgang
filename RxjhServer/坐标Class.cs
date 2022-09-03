using RxjhServer.RxjhServer;
using System;

namespace RxjhServer
{
	public class CoordinateClass : IDisposable
	{
		private float _Rxjh_X;

		private float _Rxjh_Y;

		private float _Rxjh_Z;

		private int _Rxjh_Map;

		private int _Rxjh_LEVEL;

		private string _Rxjh_ID;

		private string _Rxjh_name;

		public int Rxjh_LEVEL
		{
			get
			{
				return _Rxjh_LEVEL;
			}
			set
			{
				_Rxjh_LEVEL = value;
			}
		}

		public int Rxjh_Map
		{
			get
			{
				return _Rxjh_Map;
			}
			set
			{
				_Rxjh_Map = value;
			}
		}

		public string Rxjh_ID
		{
			get
			{
				return _Rxjh_ID;
			}
			set
			{
				_Rxjh_ID = value;
			}
		}

		public string Rxjh_Name
		{
			get
			{
				return _Rxjh_name;
			}
			set
			{
				_Rxjh_name = value;
			}
		}

		public float Rxjh_X
		{
			get
			{
				return _Rxjh_X;
			}
			set
			{
				_Rxjh_X = value;
			}
		}

		public float Rxjh_Y
		{
			get
			{
				return _Rxjh_Y;
			}
			set
			{
				_Rxjh_Y = value;
			}
		}

		public float Rxjh_Z
		{
			get
			{
				return _Rxjh_Z;
			}
			set
			{
				_Rxjh_Z = value;
			}
		}

		public CoordinateClass()
		{
		}

		public CoordinateClass(float Rxjh__X, float Rxjh__Y, float Rxjh__Z, int Rxjh__Map)
		{
			Rxjh_X = Rxjh__X;
			Rxjh_Y = Rxjh__Y;
			Rxjh_Z = Rxjh__Z;
			Rxjh_Map = Rxjh__Map;
		}

		public void Dispose()
		{
		}

		public static string getmapname(int id)
		{
			foreach (CoordinateClass item in World.Map_Move)
			{
				if (item.Rxjh_Map == id)
				{
					return item.Rxjh_Name;
				}
			}
			return "";
		}
	}
}

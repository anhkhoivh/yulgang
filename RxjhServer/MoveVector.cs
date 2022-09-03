using System;

namespace RxjhServer
{
	public class MoveVector
	{
		private float a;

		private float b;

		private float c;

		private float d;

		private float e;

		private DateTime eval_i;

		private float f;

		private float g;

		private float h;

		public MoveVector(Players Play, float x, float y, float z)
		{
			eval_i = DateTime.Now;
			a = x;
			b = y;
			c = z;
			d = Play.Player_FLD_X;
			e = Play.Player_FLD_Y;
			f = Play.Player_FLD_Z;
			h = Play.Speed;
			float num = x - Play.Player_FLD_X;
			float num2 = y - Play.Player_FLD_Y;
			float num3 = (float)Math.Sqrt(num * num + num2 * num2);
			g = num3 / (Play.Speed / 1000f);
		}

		public MoveVector(Players Play, float x, float y, float z, float fromx, float fromy, float fromz)
		{
			eval_i = DateTime.Now;
			a = x;
			b = y;
			c = z;
			d = fromx;
			e = fromy;
			f = fromz;
			h = Play.Speed;
			float num = x - Play.Player_FLD_X;
			float num2 = y - Play.Player_FLD_Y;
			float num3 = (float)Math.Sqrt(num * num + num2 * num2);
			g = num3 / (Play.Speed / 1000f);
		}

		public void Get(out float x, out float y, out float z)
		{
			float num = (float)DateTime.Now.Subtract(eval_i).TotalMilliseconds / g;
			if (g != 15f && num <= 31f)
			{
				float num2 = a - d;
				float num3 = b - e;
				float num4 = c - f;
				num2 *= num;
				num3 *= num;
				num4 *= num;
				x = d + num2;
				y = e + num3;
				z = f + num4;
			}
			else
			{
				x = a;
				y = b;
				z = c;
			}
		}

		public bool NearDestination()
		{
			float num = (float)DateTime.Now.Subtract(eval_i).TotalMilliseconds - g;
			return num < 1000f;
		}

		public bool ReachDestination()
		{
			float num = (float)DateTime.Now.Subtract(eval_i).TotalMilliseconds / g;
			if (num <= 1f && g != 0f)
			{
				return false;
			}
			return true;
		}

		public void Update(float x, float y, float z, float speed)
		{
			Get(out d, out e, out f);
			eval_i = DateTime.Now;
			float num = x - d;
			float num2 = y - e;
			a = x;
			b = y;
			c = z;
			float num3 = (float)Math.Sqrt(num * num + num2 * num2);
			g = num3 / (speed / 1000f);
		}
	}
}

using System;

namespace Network
{
	public sealed class CapacityExceededException : Exception
	{
		public CapacityExceededException()
			: base("Too much data pending.")
		{
		}
	}
}

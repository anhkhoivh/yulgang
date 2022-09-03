using System.Threading;

namespace RxjhServer
{
	public class WriteLock : BaseLock
	{
		public WriteLock(ReaderWriterLockSlim locks)
			: base(locks)
		{
			Locks.GetWriteLock(_Locks);
		}

		public override void Dispose()
		{
			Locks.ReleaseWriteLock(_Locks);
		}
	}
}

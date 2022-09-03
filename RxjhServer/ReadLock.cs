using System.Threading;

namespace RxjhServer
{
	public class ReadLock : BaseLock
	{
		public ReadLock(ReaderWriterLockSlim locks)
			: base(locks)
		{
			Locks.GetReadLock(_Locks);
		}

		public override void Dispose()
		{
			Locks.ReleaseReadLock(_Locks);
		}
	}
}

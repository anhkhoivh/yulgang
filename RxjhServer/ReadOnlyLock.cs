using System.Threading;

namespace RxjhServer
{
	public class ReadOnlyLock : BaseLock
	{
		public ReadOnlyLock(ReaderWriterLockSlim locks)
			: base(locks)
		{
			Locks.GetReadOnlyLock(_Locks);
		}

		public override void Dispose()
		{
			Locks.ReleaseReadOnlyLock(_Locks);
		}
	}
}

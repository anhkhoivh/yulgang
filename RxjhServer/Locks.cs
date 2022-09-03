using System.Threading;

namespace RxjhServer
{
	public static class Locks
	{
		public static ReaderWriterLockSlim GetLockInstance()
		{
			return GetLockInstance(LockRecursionPolicy.SupportsRecursion);
		}

		public static ReaderWriterLockSlim GetLockInstance(LockRecursionPolicy recursionPolicy)
		{
			return new ReaderWriterLockSlim(recursionPolicy);
		}

		public static void GetReadLock(ReaderWriterLockSlim locks)
		{
			bool flag = false;
			while (!flag)
			{
				flag = locks.TryEnterUpgradeableReadLock(1);
			}
		}

		public static void GetReadOnlyLock(ReaderWriterLockSlim locks)
		{
			bool flag = false;
			while (!flag)
			{
				flag = locks.TryEnterReadLock(1);
			}
		}

		public static void GetWriteLock(ReaderWriterLockSlim locks)
		{
			bool flag = false;
			while (!flag)
			{
				flag = locks.TryEnterWriteLock(1);
			}
		}

		public static void ReleaseLock(ReaderWriterLockSlim locks)
		{
			ReleaseWriteLock(locks);
			ReleaseReadLock(locks);
			ReleaseReadOnlyLock(locks);
		}

		public static void ReleaseReadLock(ReaderWriterLockSlim locks)
		{
			if (locks.IsUpgradeableReadLockHeld)
			{
				locks.ExitUpgradeableReadLock();
			}
		}

		public static void ReleaseReadOnlyLock(ReaderWriterLockSlim locks)
		{
			if (locks.IsReadLockHeld)
			{
				locks.ExitReadLock();
			}
		}

		public static void ReleaseWriteLock(ReaderWriterLockSlim locks)
		{
			if (locks.IsWriteLockHeld)
			{
				locks.ExitWriteLock();
			}
		}
	}
}

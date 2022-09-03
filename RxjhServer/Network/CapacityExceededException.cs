namespace Network
{
    using System;

    public sealed class CapacityExceededException : Exception
    {
        public CapacityExceededException() : base("Too much data pending.")
        {
        }
    }
}


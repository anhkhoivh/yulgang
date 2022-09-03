namespace Network
{
    using System;

    public sealed class ByteQueueExceeded : Exception
    {
        public ByteQueueExceeded() : base("数据不够")
        {
        }
    }
}


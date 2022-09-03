using System;

namespace RxjhServer
{
    public class 气功类
    {
        private byte[] eval_a;
        public int 气功ID;

        public 气功类()
        {
        }

        public 气功类(byte[] 气功_byte_)
        {
            this.气功_byte = 气功_byte_;
        }

        public byte[] 气功_byte
        {
            get
            {
                return this.eval_a;
            }
            set
            {
                this.eval_a = value;
            }
        }

        public int 气功量
        {
            get
            {
                return BitConverter.ToInt16(this.气功_byte, 0);
            }
            set
            {
                Buffer.BlockCopy(BitConverter.GetBytes(value), 0, this.气功_byte, 0, 2);
            }
        }
    }
}


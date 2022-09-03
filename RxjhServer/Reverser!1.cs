namespace RxjhServer
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;

    public class Reverser<T> : IComparer<T>
    {
        private Type a_a;
        private ReverserInfo b;

        public Reverser(string className, string name, ReverserInfo.Direction direction)
        {
            try
            {
                this.a_a = Type.GetType(className, true);
                this.b.name = name;
                this.b.direction = direction;
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        }

        public Reverser(Type type, string name, ReverserInfo.Direction direction)
        {
            this.a_a = type;
            this.b.name = name;
            if (direction != ReverserInfo.Direction.ASC)
            {
                this.b.direction = direction;
            }
        }

        public Reverser(T t, string name, ReverserInfo.Direction direction)
        {
            this.a_a = t.GetType();
            this.b.name = name;
            this.b.direction = direction;
        }

        private void a(ref object A_0, ref object A_1)
        {
            object obj2 = null;
            obj2 = A_0;
            A_0 = A_1;
            A_1 = obj2;
        }

        int IComparer<T>.Compare(T t1, T t2)
        {
            object obj2 = this.a_a.InvokeMember(this.b.name, BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance, null, t1, null);
            object obj3 = this.a_a.InvokeMember(this.b.name, BindingFlags.GetProperty | BindingFlags.Public | BindingFlags.Instance, null, t2, null);
            if (this.b.direction != ReverserInfo.Direction.ASC)
            {
                this.a(ref obj2, ref obj3);
            }
            return new CaseInsensitiveComparer().Compare(obj2, obj3);
        }
    }
}


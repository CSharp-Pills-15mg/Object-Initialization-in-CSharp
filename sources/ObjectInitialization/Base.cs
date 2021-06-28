using System;

namespace ObjectInitialization
{
    internal class Base
    {
        private static Trace staticField = new Trace("Base.Static.Field");
        private Trace instanceField = new Trace("Base.Instance.Field");

        static Base()
        {
            Console.WriteLine("Base.Static.Constructor");
        }

        public Base()
        {
            Console.WriteLine("Base.Instance.Constructor");
        }
    }
}
using System;

namespace ObjectInitialization
{
    internal class Derived : Base
    {
        private static Trace staticField = new Trace("Derived.Static.Field");
        private Trace instanceField = new Trace("Derived.Instance.Field");

        static Derived()
        {
            Console.WriteLine("Derived.Static.Constructor");
        }

        public Derived()
        {
            Console.WriteLine("Derived.Instance.Constructor");
        }
    }
}
using System;

namespace Nagarro.ObjectInitialization
{
    internal class Derived : Base
    {
        private static Something staticField = new Something("Derived.Static.Field");
        private Something instanceField = new Something("Derived.Instance.Field");

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
using System;

namespace Nagarro.ObjectInitialization
{
    internal class Base
    {
        private static Something staticField = new Something("Base.Static.Field");
        private Something instanceField = new Something("Base.Instance.Field");

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
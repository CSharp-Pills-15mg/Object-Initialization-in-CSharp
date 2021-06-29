using System;

namespace ObjectInitialization
{
    internal class Base
    {
        private static Trace staticField = new Trace("Base.Static.Field");
        private Trace instanceField = new Trace("Base.Instance.Field");

        private static Trace StaticProperty { get; set; } = new Trace("Base.Static.Property");
        private Trace InstanceProperty { get; set; } = new Trace("Base.Instance.Property");

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
using System;

namespace ObjectInitialization
{
    internal class Base
    {
        // Static 

        private static Dummy staticField1 = new Dummy("Base.Static.Field1");

        public static Dummy StaticProperty1 { get; set; } = new Dummy("Base.Static.Property1");

        private static Dummy staticField2 = new Dummy("Base.Static.Field2");

        public static Dummy StaticProperty2 { get; set; } = new Dummy("Base.Static.Property2");

        static Base()
        {
            Console.WriteLine("Base.Static.Constructor");
        }

        // Instance

        private Dummy instanceField1 = new Dummy("Base.Instance.Field1");

        public Dummy InstanceProperty1 { get; set; } = new Dummy("Base.Instance.Property1");

        private Dummy instanceField2 = new Dummy("Base.Instance.Field2");

        public Dummy InstanceProperty2 { get; set; } = new Dummy("Base.Instance.Property2");

        public Base()
        {
            Console.WriteLine("Base.Instance.Constructor");
        }
    }
}
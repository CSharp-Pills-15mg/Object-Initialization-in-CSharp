using System;

namespace ObjectInitialization
{
    internal class Derived : Base
    {
        // Static 

        private static Dummy staticField1 = new Dummy("Derived.Static.Field1");

        public static Dummy StaticProperty1 { get; set; } = new Dummy("Derived.Static.Property1");

        private static Dummy staticField2 = new Dummy("Derived.Static.Field2");

        public static Dummy StaticProperty2 { get; set; } = new Dummy("Derived.Static.Property2");

        static Derived()
        {
            Console.WriteLine("Derived.Static.Constructor");
        }

        // Instance

        private Dummy instanceField1 = new Dummy("Derived.Instance.Field1");

        public Dummy InstanceProperty1 { get; set; } = new Dummy("Derived.Instance.Property1");

        private Dummy instanceField2 = new Dummy("Derived.Instance.Field2");

        public Dummy InstanceProperty2 { get; set; } = new Dummy("Derived.Instance.Property2");

        public Derived()
        {
            Console.WriteLine("Derived.Instance.Constructor");
        }
    }
}
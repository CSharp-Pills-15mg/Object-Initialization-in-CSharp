// C# Pills 15mg
// Copyright (C) 2021 Dust in the Wind
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;

namespace DustInTheWind.ObjectInitialization
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
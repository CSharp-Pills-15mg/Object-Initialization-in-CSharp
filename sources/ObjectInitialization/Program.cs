using System;

namespace Nagarro.ObjectInitialization
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Derived derived = new Derived();

            Pause();
        }

        private static void Pause()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
            Console.WriteLine();
        }
    }
}
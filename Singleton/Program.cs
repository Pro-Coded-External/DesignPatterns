using System;

namespace Singleton
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var bell = TheBell.Instance;
            bell.Ring();

            Console.ReadKey();
        }
    }
}
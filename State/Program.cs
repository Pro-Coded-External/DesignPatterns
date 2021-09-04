using System;

namespace State
{
    internal class Program
    {
        /// <summary>
        ///     The State pattern encapsulates states of an object as objects themselves, and uses a Context class
        ///     (the Steak class in this example) to store the current state of the object and the object itself.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            //Let's cook a steak!
            var steak = new Steak("T-Bone");

            // Apply temperature changes
            steak.AddTemp(120);
            steak.AddTemp(15);
            steak.AddTemp(15);
            steak.RemoveTemp(10); //Yes I know cooking doesn't work this way, bear with me.
            steak.RemoveTemp(15);
            steak.AddTemp(20);
            steak.AddTemp(20);
            steak.AddTemp(20);

            Console.ReadKey();
        }
    }
}
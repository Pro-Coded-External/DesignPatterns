using System;

namespace TemplateMethod
{
    internal class Program
    {
        /// <summary>
        ///     The Template Method pattern allows an abstract to define the skeleton or outline of an algorithm,
        ///     but leave the implementation of the individual steps in that algorithm up to the deriving classes.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var sourdough = new Sourdough();
            sourdough.Make();

            var twelveGrain = new TwelveGrain();
            twelveGrain.Make();

            var wholeWheat = new WholeWheat();
            wholeWheat.Make();

            Console.ReadKey();
        }
    }
}
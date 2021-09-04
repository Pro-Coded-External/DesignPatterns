using System;

namespace Flyweight
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Build a slider order using patron's input
            Console.WriteLine("Please enter your slider order (use characters B, V, Q with no spaces):");
            var order = Console.ReadLine();
            var chars = order.ToCharArray();

            var factory = new SliderFactory();

            var orderTotal = 0;

            //Get the slider from the factory
            foreach (var c in chars)
            {
                orderTotal++;
                var character = factory.GetSlider(c);
                character.Display(orderTotal);
            }

            Console.ReadKey();
        }
    }
}
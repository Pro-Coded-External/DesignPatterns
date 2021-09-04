using System;

namespace AbstractFactory
{
    internal class Program
    {
        /// <summary>
        ///     The Abstract Factory pattern provides an interface for creating related families of objects
        ///     without needing to specify the concrete implementations.  This pattern is critical for ideas
        ///     like Dependency Injection.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Who are you? (A)dult or (C)hild?");

            var input = char.ToLower(Console.ReadKey().KeyChar);

            RecipeFactory factory;

            switch (input)
            {
                case 'a':
                    factory = new AdultCuisineFactory();
                    break;

                case 'c':
                    factory = new KidCuisineFactory();
                    break;

                default:
                    throw new NotImplementedException();
            }

            var sandwich = factory.CreateSandwich();
            var dessert = factory.CreateDessert();

            Console.WriteLine("\nSandwich: " + sandwich.GetType().Name);
            Console.WriteLine("Dessert: " + dessert.GetType().Name);

            Console.ReadKey();
        }
    }
}
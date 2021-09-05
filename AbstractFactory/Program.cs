using System;
using AbstractFactory.ConfiguratorFactories;

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
            Console.WriteLine("Select country: (U)k, (S)weden or (D)enmark");

            var input = char.ToLower(Console.ReadKey().KeyChar);

            CarConfiguratorFactory factory = input switch
            {
                'u' => new UkConfiguratorFactory(),
                's' => new SwedenConfiguratorFactory(),
                'd' => new DenmarkConfiguratorFactory(),
                _ => throw new NotImplementedException("Unsupported market.")
            };

            var carBody = factory.CreateCarBody();
            var engine = factory.CreateEngine();

            Console.WriteLine();
            Console.WriteLine("Car Body: " + carBody.GetType().Name);
            Console.WriteLine("Engine: " + engine.GetType().Name);

            Console.ReadKey();
        }
    }
}
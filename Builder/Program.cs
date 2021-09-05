using System;

namespace Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CarBuilder carBuilder;

            var assemblyLine = new AssemblyLine();

            // Construct and display sandwiches
            carBuilder = new HatchBack();
            assemblyLine.Assemble(carBuilder);
            carBuilder.Car.Show();

            carBuilder = new Coupe();
            assemblyLine.Assemble(carBuilder);
            carBuilder.Car.Show();

            carBuilder = new Estate();
            assemblyLine.Assemble(carBuilder);
            carBuilder.Car.Show();

            // Wait for user
            Console.ReadKey();
        }
    }
}
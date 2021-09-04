using System;

namespace Builder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SandwichBuilder builder;

            // Create deli with sandwich assembly line
            var shop = new AssemblyLine();

            // Construct and display sandwiches
            builder = new HamAndCheese();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            builder = new BLT();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            builder = new TurkeyClub();
            shop.Assemble(builder);
            builder.Sandwich.Show();

            // Wait for user
            Console.ReadKey();
        }
    }
}
using System;

namespace Proxy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var proxy = new NewServerProxy();

            //Manage orders from a table
            Console.WriteLine("What would you like to order? ");
            var order = Console.ReadLine();
            proxy.TakeOrder(order);
            Console.WriteLine("Sure thing!  Here's your " + proxy.DeliverOrder() + ".");
            Console.WriteLine("How would you like to pay?");
            var payment = Console.ReadLine();
            proxy.ProcessPayment(payment);

            Console.ReadKey();
        }
    }
}
﻿using System;

namespace Proxy
{
    /// <summary>
    ///     The Subject interface which both the real subject and proxy will need to implement
    /// </summary>
    public interface IServer
    {
        void TakeOrder(string order);
        string DeliverOrder();
        void ProcessPayment(string payment);
    }

    /// <summary>
    ///     The real subject class which the Proxy can stand in for
    /// </summary>
    internal class Server : IServer
    {
        private string Order;

        public void TakeOrder(string order)
        {
            Console.WriteLine("Server takes order for " + order + ".");
            Order = order;
        }

        public string DeliverOrder()
        {
            return Order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("Payment for order (" + payment + ") processed.");
        }
    }

    /// <summary>
    ///     The Proxy class, which can substitute for the Real Subject.
    /// </summary>
    internal class NewServerProxy : IServer
    {
        private readonly Server _server = new();
        private string Order;

        public void TakeOrder(string order)
        {
            Console.WriteLine("New trainee server takes order for " + order + ".");
            Order = order;
        }

        public string DeliverOrder()
        {
            return Order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("New trainee cannot process payments yet!");
            _server.ProcessPayment(payment);
        }
    }
}
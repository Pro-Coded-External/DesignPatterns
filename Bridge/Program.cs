﻿using System;

namespace Bridge
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SendOrder _sendOrder = new SendDairyFreeOrder();
            _sendOrder._restaurant = new DinerOrders();
            _sendOrder.Send();

            _sendOrder._restaurant = new FancyRestaurantOrders();
            _sendOrder.Send();

            _sendOrder = new SendGlutenFreeOrder();
            _sendOrder._restaurant = new DinerOrders();
            _sendOrder.Send();

            _sendOrder._restaurant = new FancyRestaurantOrders();
            _sendOrder.Send();

            Console.ReadKey();
        }
    }
}
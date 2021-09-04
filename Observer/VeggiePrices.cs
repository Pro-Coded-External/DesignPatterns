using System;
using System.Collections.Generic;

namespace Observer
{
    /// <summary>
    ///     The Subject abstract class
    /// </summary>
    internal abstract class Veggies
    {
        private double _pricePerPound;
        private readonly List<IRestaurant> _restaurants = new();

        public Veggies(double pricePerPound)
        {
            _pricePerPound = pricePerPound;
        }

        public double PricePerPound
        {
            get => _pricePerPound;
            set
            {
                if (_pricePerPound != value)
                {
                    _pricePerPound = value;
                    Notify();
                }
            }
        }

        public void Attach(IRestaurant restaurant)
        {
            _restaurants.Add(restaurant);
        }

        public void Detach(IRestaurant restaurant)
        {
            _restaurants.Remove(restaurant);
        }

        public void Notify()
        {
            foreach (var restaurant in _restaurants) restaurant.Update(this);

            Console.WriteLine("");
        }
    }

    /// <summary>
    ///     The ConcreteSubject class
    /// </summary>
    internal class Carrots : Veggies
    {
        public Carrots(double price) : base(price)
        {
        }
    }

    /// <summary>
    ///     The Observer interface
    /// </summary>
    internal interface IRestaurant
    {
        void Update(Veggies veggies);
    }

    /// <summary>
    ///     The ConcreteObserver class
    /// </summary>
    internal class Restaurant : IRestaurant
    {
        private readonly string _name;
        private readonly double _purchaseThreshold;

        public Restaurant(string name, double purchaseThreshold)
        {
            _name = name;
            _purchaseThreshold = purchaseThreshold;
        }

        public void Update(Veggies veggie)
        {
            Console.WriteLine("Notified {0} of {1}'s " + " price change to {2:C} per pound.", _name,
                veggie.GetType().Name, veggie.PricePerPound);
            if (veggie.PricePerPound < _purchaseThreshold)
                Console.WriteLine(_name + " wants to buy some " + veggie.GetType().Name + "!");
        }
    }
}
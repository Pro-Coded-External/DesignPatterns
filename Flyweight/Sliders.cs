﻿using System;
using System.Collections.Generic;

namespace Flyweight
{
    /// <summary>
    ///     The Flyweight Factory class
    /// </summary>
    internal class SliderFactory
    {
        private readonly Dictionary<char, Slider> _sliders =
            new();

        public Slider GetSlider(char key)
        {
            Slider slider = null;
            if (
                _sliders.ContainsKey(
                    key)) //If we've already created an instance of the requested type of slider, just use that.
            {
                slider = _sliders[key];
            }
            else //Otherwise, create a brand new slider instance.
            {
                switch (key)
                {
                    case 'B':
                        slider = new BaconMaster();
                        break;
                    case 'V':
                        slider = new VeggieSlider();
                        break;
                    case 'Q':
                        slider = new BBQKing();
                        break;
                }

                _sliders.Add(key, slider);
            }

            return slider;
        }
    }

    /// <summary>
    ///     The 'Flyweight' abstract class
    /// </summary>
    internal abstract class Slider
    {
        protected string Cheese;
        protected string Name;
        protected decimal Price;
        protected string Toppings;

        public abstract void Display(int orderTotal);
    }

    /// <summary>
    ///     A  Concrete Flyweight class
    /// </summary>
    internal class BaconMaster : Slider
    {
        public BaconMaster()
        {
            Name = "Bacon Master";
            Cheese = "American";
            Toppings = "lots of bacon";
            Price = 2.39m;
        }

        public override void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal + ": " + Name + " - topped with " + Cheese + " cheese and " +
                              Toppings + "! $" + Price);
        }
    }

    /// <summary>
    ///     A Concrete Flyweight class
    /// </summary>
    internal class VeggieSlider : Slider
    {
        public VeggieSlider()
        {
            Name = "Veggie Slider";
            Cheese = "Swiss";
            Toppings = "lettuce, onion, tomato, and pickles";
            Price = 1.99m;
        }

        public override void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal + ": " + Name + " - topped with " + Cheese + " cheese and " +
                              Toppings + "! $" + Price);
        }
    }

    /// <summary>
    ///     A Concrete Flyweight class
    /// </summary>
    internal class BBQKing : Slider
    {
        public BBQKing()
        {
            Name = "BBQ King";
            Cheese = "American";
            Toppings = "Onion rings, lettuce, and BBQ sauce";
            Price = 2.49m;
        }

        public override void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal + ": " + Name + " - topped with " + Cheese + " cheese and " +
                              Toppings + "! $" + Price);
        }
    }
}
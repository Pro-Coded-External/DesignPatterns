﻿using System;
using System.Collections.Generic;

namespace Builder
{
    /// <summary>
    ///     The Director
    /// </summary>
    internal class AssemblyLine
    {
        // Builder uses a complex series of steps
        // 
        public void Assemble(SandwichBuilder sandwichBuilder)
        {
            sandwichBuilder.AddBread();
            sandwichBuilder.AddMeats();
            sandwichBuilder.AddCheese();
            sandwichBuilder.AddVeggies();
            sandwichBuilder.AddCondiments();
        }
    }

    /// <summary>
    ///     The Builder abstract class
    /// </summary>
    internal abstract class SandwichBuilder
    {
        protected Sandwich sandwich;

        // Gets sandwich instance
        public Sandwich Sandwich => sandwich;

        // Abstract build methods
        public abstract void AddBread();
        public abstract void AddMeats();
        public abstract void AddCheese();
        public abstract void AddVeggies();
        public abstract void AddCondiments();
    }

    /// <summary>
    ///     A Concrete Builder class
    /// </summary>
    internal class TurkeyClub : SandwichBuilder
    {
        public TurkeyClub()
        {
            sandwich = new Sandwich("Turkey Club");
        }

        public override void AddBread()
        {
            sandwich["bread"] = "12-Grain";
        }

        public override void AddMeats()
        {
            sandwich["meat"] = "Turkey";
        }

        public override void AddCheese()
        {
            sandwich["cheese"] = "Swiss";
        }

        public override void AddVeggies()
        {
            sandwich["veggies"] = "Lettuce, Tomato";
        }

        public override void AddCondiments()
        {
            sandwich["condiments"] = "Mayo";
        }
    }

    /// <summary>
    ///     A Concrete Builder class
    /// </summary>
    internal class BLT : SandwichBuilder
    {
        public BLT()
        {
            sandwich = new Sandwich("BLT");
        }

        public override void AddBread()
        {
            sandwich["bread"] = "Wheat";
        }

        public override void AddMeats()
        {
            sandwich["meat"] = "Bacon";
        }

        public override void AddCheese()
        {
            sandwich["cheese"] = "None";
        }

        public override void AddVeggies()
        {
            sandwich["veggies"] = "Lettuce, Tomato";
        }

        public override void AddCondiments()
        {
            sandwich["condiments"] = "Mayo, Mustard";
        }
    }

    /// <summary>
    ///     A Concrete Builder class
    /// </summary>
    internal class HamAndCheese : SandwichBuilder
    {
        public HamAndCheese()
        {
            sandwich = new Sandwich("Ham and Cheese");
        }

        public override void AddBread()
        {
            sandwich["bread"] = "White";
        }

        public override void AddMeats()
        {
            sandwich["meat"] = "Ham";
        }

        public override void AddCheese()
        {
            sandwich["cheese"] = "American";
        }

        public override void AddVeggies()
        {
            sandwich["veggies"] = "None";
        }

        public override void AddCondiments()
        {
            sandwich["condiments"] = "Mayo";
        }
    }

    /// <summary>
    ///     The Product class
    /// </summary>
    internal class Sandwich
    {
        private readonly Dictionary<string, string> _ingredients = new();
        private readonly string _sandwichType;

        // Constructor
        public Sandwich(string sandwichType)
        {
            _sandwichType = sandwichType;
        }

        // Indexer
        public string this[string key]
        {
            get => _ingredients[key];
            set => _ingredients[key] = value;
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Sandwich: {0}", _sandwichType);
            Console.WriteLine(" Bread: {0}", _ingredients["bread"]);
            Console.WriteLine(" Meat: {0}", _ingredients["meat"]);
            Console.WriteLine(" Cheese: {0}", _ingredients["cheese"]);
            Console.WriteLine(" Veggies: {0}", _ingredients["veggies"]);
            Console.WriteLine(" Condiments: {0}", _ingredients["condiments"]);
        }
    }
}
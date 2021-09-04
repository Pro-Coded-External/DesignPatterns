using System;

namespace Strategy
{
    /// <summary>
    ///     The Strategy abstract class, which defines an interface common to all supported strategy algorithms.
    /// </summary>
    internal abstract class CookStrategy
    {
        public abstract void Cook(string food);
    }

    /// <summary>
    ///     A Concrete Strategy class
    /// </summary>
    internal class Grilling : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by grilling it.");
        }
    }

    /// <summary>
    ///     A Concrete Strategy class
    /// </summary>
    internal class OvenBaking : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by oven baking it.");
        }
    }

    /// <summary>
    ///     A Concrete Strategy class
    /// </summary>
    internal class DeepFrying : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine("\nCooking " + food + " by deep frying it");
        }
    }

    /// <summary>
    ///     The Context class, which maintains a reference to the chosen Strategy.
    /// </summary>
    internal class CookingMethod
    {
        private CookStrategy _cookStrategy;
        private string Food;

        public void SetCookStrategy(CookStrategy cookStrategy)
        {
            _cookStrategy = cookStrategy;
        }

        public void SetFood(string name)
        {
            Food = name;
        }

        public void Cook()
        {
            _cookStrategy.Cook(Food);
            Console.WriteLine();
        }
    }
}
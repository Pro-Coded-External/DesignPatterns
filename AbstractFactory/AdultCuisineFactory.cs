﻿namespace AbstractFactory
{
    /// <summary>
    ///     A concrete factory which creates concrete objects by implementing the abstract factory's methods.
    /// </summary>
    internal class AdultCuisineFactory : RecipeFactory
    {
        public override Sandwich CreateSandwich()
        {
            return new BLT();
        }

        public override Dessert CreateDessert()
        {
            return new CremeBrulee();
        }
    }
}
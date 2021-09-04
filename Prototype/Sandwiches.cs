using System;
using System.Collections.Generic;

namespace Prototype
{
    /// <summary>
    ///     The Prototype abstract class
    /// </summary>
    internal abstract class SandwichPrototype
    {
        public abstract SandwichPrototype Clone();
    }

    internal class Sandwich : SandwichPrototype
    {
        private readonly string Bread;
        private readonly string Cheese; //I will use this pun everywhere I can
        private readonly string Meat;
        private readonly string Veggies;

        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            Bread = bread;
            Meat = meat;
            Cheese = cheese;
            Veggies = veggies;
        }

        public override SandwichPrototype Clone()
        {
            var ingredientList = GetIngredientList();
            Console.WriteLine("Cloning sandwich with ingredients: {0}",
                ingredientList.Remove(ingredientList.LastIndexOf(",")));

            return MemberwiseClone() as SandwichPrototype;
        }

        private string GetIngredientList()
        {
            var ingredientList = "";
            if (!string.IsNullOrWhiteSpace(Bread)) ingredientList += Bread + ", ";
            if (!string.IsNullOrWhiteSpace(Meat)) ingredientList += Meat + ", ";
            if (!string.IsNullOrWhiteSpace(Cheese)) ingredientList += Cheese + ", ";
            if (!string.IsNullOrWhiteSpace(Veggies)) ingredientList += Veggies + ", ";
            return ingredientList;
        }
    }

    internal class SandwichMenu
    {
        private readonly Dictionary<string, SandwichPrototype> _sandwiches = new();

        public SandwichPrototype this[string name]
        {
            get => _sandwiches[name];
            set => _sandwiches.Add(name, value);
        }
    }
}
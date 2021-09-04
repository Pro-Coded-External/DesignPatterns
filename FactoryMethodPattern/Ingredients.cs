using System.Collections.Generic;

namespace FactoryMethod
{
    /// <summary>
    ///     Product
    /// </summary>
    internal abstract class Ingredient
    {
    }

    /// <summary>
    ///     Concrete Product
    /// </summary>
    internal class Bread : Ingredient
    {
    }

    /// <summary>
    ///     Concrete Product
    /// </summary>
    internal class Turkey : Ingredient
    {
    }

    /// <summary>
    ///     Concrete Product
    /// </summary>
    internal class Lettuce : Ingredient
    {
    }

    /// <summary>
    ///     Concrete Product
    /// </summary>
    internal class Mayonnaise : Ingredient
    {
    }

    /// <summary>
    ///     Creator
    /// </summary>
    internal abstract class Sandwich
    {
        public Sandwich()
        {
            CreateIngredients();
        }

        public List<Ingredient> Ingredients { get; } = new();

        //Factory method
        public abstract void CreateIngredients();
    }

    /// <summary>
    ///     Concrete Creator
    /// </summary>
    internal class TurkeySandwich : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Bread());
        }
    }

    /// <summary>
    ///     Concrete Creator
    /// </summary>
    internal class Dagwood : Sandwich //OM NOM NOM
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Turkey());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Lettuce());
            Ingredients.Add(new Mayonnaise());
            Ingredients.Add(new Bread());
        }
    }
}
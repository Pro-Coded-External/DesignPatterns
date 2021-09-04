namespace AbstractFactory
{
    /// <summary>
    ///     The Abstract Factory class, which defines methods for creating abstract objects.
    /// </summary>
    internal abstract class RecipeFactory
    {
        public abstract Sandwich CreateSandwich();
        public abstract Dessert CreateDessert();
    }
}
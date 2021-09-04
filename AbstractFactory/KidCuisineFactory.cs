namespace AbstractFactory
{
    /// <summary>
    ///     A concrete factory which creates concrete objects by implementing the abstract factory's methods.
    /// </summary>
    internal class KidCuisineFactory : RecipeFactory
    {
        public override Sandwich CreateSandwich()
        {
            return new PBandJ();
        }

        public override Dessert CreateDessert()
        {
            return new IceCreamSundae();
        }
    }
}
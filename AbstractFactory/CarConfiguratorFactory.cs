namespace AbstractFactory
{
    /// <summary>
    ///     The Abstract Factory class, which defines methods for creating abstract objects.
    /// </summary>
    internal abstract class CarConfiguratorFactory
    {
        public abstract CarBody CreateCarBody();
        public abstract Engine CreateEngine();
    }
}
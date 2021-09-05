using AbstractFactory.CarBodies;
using AbstractFactory.Engines;

namespace AbstractFactory.ConfiguratorFactories
{
    /// <summary>
    ///     A concrete factory which creates concrete objects by implementing the abstract factory's methods.
    /// </summary>
    internal class SwedenConfiguratorFactory : CarConfiguratorFactory
    {
        public override CarBody CreateCarBody()
        {
            return new Cabriolet();
        }

        public override Engine CreateEngine()
        {
            return new ElectricEngine();
        }
    }
}
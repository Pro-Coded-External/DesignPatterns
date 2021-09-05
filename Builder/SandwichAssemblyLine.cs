using System;
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
        public void Assemble(CarBuilder carBuilder)
        {
            carBuilder.AddFrame();
            carBuilder.AddEngine();
            carBuilder.AddWheels();
            carBuilder.AddDoors();
            carBuilder.Paint();
        }
    }

    /// <summary>
    ///     The Builder abstract class
    /// </summary>
    internal abstract class CarBuilder
    {
        protected Car car;

        // Gets sandwich instance
        public Car Car => car;

        // Abstract build methods
        public abstract void AddFrame();
        public abstract void AddEngine();
        public abstract void AddWheels();
        public abstract void AddDoors();
        public abstract void Paint();
    }

    /// <summary>
    ///     A Concrete Builder class
    /// </summary>
    internal class Estate : CarBuilder
    {
        public Estate()
        {
            car = new Car("Estate");
        }

        public override void AddFrame()
        {
            car["frame"] = "Long";
        }

        public override void AddEngine()
        {
            car["engine"] = "Diesel";
        }

        public override void AddWheels()
        {
            car["wheels"] = "Standard";
        }

        public override void AddDoors()
        {
            car["doors"] = "Four";
        }

        public override void Paint()
        {
            car["paint"] = "Black";
        }
    }

    /// <summary>
    ///     A Concrete Builder class
    /// </summary>
    internal class Coupe : CarBuilder
    {
        public Coupe()
        {
            car = new Car("Coupe");
        }

        public override void AddFrame()
        {
            car["frame"] = "Sports";
        }

        public override void AddEngine()
        {
            car["engine"] = "V8";
        }

        public override void AddWheels()
        {
            car["wheels"] = "Alloy";
        }

        public override void AddDoors()
        {
            car["doors"] = "Two";
        }

        public override void Paint()
        {
            car["paint"] = "Red";
        }
    }

    /// <summary>
    ///     A Concrete Builder class
    /// </summary>
    internal class HatchBack : CarBuilder
    {
        public HatchBack()
        {
            car = new Car("HatchBack");
        }

        public override void AddFrame()
        {
            car["frame"] = "Standard";
        }

        public override void AddEngine()
        {
            car["engine"] = "Electric";
        }

        public override void AddWheels()
        {
            car["wheels"] = "Standard";
        }

        public override void AddDoors()
        {
            car["doors"] = "Five";
        }

        public override void Paint()
        {
            car["paint"] = "Blue";
        }
    }

    /// <summary>
    ///     The Product class
    /// </summary>
    internal class Car
    {
        private readonly Dictionary<string, string> _parts = new();
        private readonly string _carType;

        // Constructor
        public Car(string carType)
        {
            _carType = carType;
        }

        // Indexer
        public string this[string key]
        {
            get => _parts[key];
            set => _parts[key] = value;
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Car: {0}", _carType);
            Console.WriteLine(" Frame: {0}", _parts["frame"]);
            Console.WriteLine(" engine: {0}", _parts["engine"]);
            Console.WriteLine(" wheels: {0}", _parts["wheels"]);
            Console.WriteLine(" doors: {0}", _parts["doors"]);
            Console.WriteLine(" paint: {0}", _parts["paint"]);
        }
    }
}
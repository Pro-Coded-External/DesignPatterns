using System;

namespace Memento
{
    internal class Program
    {
        /// <summary>
        ///     In the Memento pattern, we need to capture and externalize an object's state so that the object can be
        ///     restored to that state at a later time.  A good example of this is undo/redo operations.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            //Here's a new supplier for our restaurant
            var s = new FoodSupplier();
            s.Name = "Harold Karstark";
            s.Phone = "(482) 449-1172";

            // Let's store that entry in our database.
            var m = new SupplierMemory();
            m.Memento = s.SaveMemento();

            // Continue changing originator
            s.Address = "548 S Main St. Nowhere, KS";

            // Crap, gotta undo that entry, I entered the wrong address
            s.RestoreMemento(m.Memento);

            Console.ReadKey();
        }
    }
}
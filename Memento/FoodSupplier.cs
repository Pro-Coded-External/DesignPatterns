using System;

namespace Memento
{
    /// <summary>
    ///     The Originator class, which is the class for which we want to save Mementos for its state.
    /// </summary>
    internal class FoodSupplier
    {
        private string _address;
        private string _name;
        private string _phone;

        public string Address
        {
            get => _address;
            set
            {
                _address = value;
                Console.WriteLine("Address: " + _address);
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                Console.WriteLine("Proprietor:  " + _name);
            }
        }

        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                Console.WriteLine("Phone Number: " + _phone);
            }
        }

        public FoodSupplierMemento SaveMemento()
        {
            Console.WriteLine("\nSaving current state\n");
            return new FoodSupplierMemento(_name, _phone, _address);
        }

        public void RestoreMemento(FoodSupplierMemento memento)
        {
            Console.WriteLine("\nRestoring previous state\n");
            Name = memento.Name;
            Phone = memento.PhoneNumber;
            Address = memento.Address;
        }
    }

    /// <summary>
    ///     The Memento class
    /// </summary>
    internal class FoodSupplierMemento
    {
        public FoodSupplierMemento(string name, string phone, string address)
        {
            Name = name;
            PhoneNumber = phone;
            Address = address;
        }

        public string Address { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }

    /// <summary>
    ///     The Caretaker class.  This class never examines the contents of any Memento and is
    ///     responsible for keeping that memento.
    /// </summary>
    internal class SupplierMemory
    {
        public FoodSupplierMemento Memento { set; get; }
    }
}
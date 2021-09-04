using System;

namespace Facade
{
    /// <summary>
    ///     All items sold in the restaurant must inherit from this.
    /// </summary>
    internal class FoodItem
    {
        public int DishID;
    }

    /// <summary>
    ///     Each section of the kitchen must implement this interface.
    /// </summary>
    internal interface KitchenSection
    {
        FoodItem PrepDish(int DishID);
    }

    /// <summary>
    ///     Orders placed by Patrons.
    /// </summary>
    internal class Order
    {
        public FoodItem Appetizer { get; set; }
        public FoodItem Drink { get; set; }
        public FoodItem Entree { get; set; }
    }

    /// <summary>
    ///     Patron of the restaurant
    /// </summary>
    internal class Patron
    {
        public Patron(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }

    /// <summary>
    ///     A division of the kitchen.
    /// </summary>
    internal class ColdPrep : KitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            Console.WriteLine("Cold Prep is preparing Appetizer #" + dishID);
            //Go prep the appetizer
            return new FoodItem
            {
                DishID = dishID
            };
        }
    }

    /// <summary>
    ///     A division of the kitchen.
    /// </summary>
    internal class HotPrep : KitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            Console.WriteLine("Hot Prep is preparing Entree #" + dishID);
            //Go prep the entree
            return new FoodItem
            {
                DishID = dishID
            };
        }
    }

    /// <summary>
    ///     A division of the kitchen.
    /// </summary>
    internal class Bar : KitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            Console.WriteLine("The Bar is preparing Drink #" + dishID);
            //Go mix the drink
            return new FoodItem
            {
                DishID = dishID
            };
        }
    }

    /// <summary>
    ///     The actual "Facade" class, which hides the complexity of the KitchenSection classes.
    ///     After all, there's no reason a patron should order each part of their meal individually.
    /// </summary>
    internal class Server
    {
        private readonly Bar _bar = new();
        private readonly ColdPrep _coldPrep = new();
        private readonly HotPrep _hotPrep = new();

        public Order PlaceOrder(Patron patron, int coldAppID, int hotEntreeID, int drinkID)
        {
            Console.WriteLine("{0} places order for cold app #" + coldAppID
                                                                + ", hot entree #" + hotEntreeID
                                                                + ", and drink #" + drinkID + ".", patron.Name);

            var order = new Order();

            order.Appetizer = _coldPrep.PrepDish(coldAppID);
            order.Entree = _hotPrep.PrepDish(hotEntreeID);
            order.Drink = _bar.PrepDish(drinkID);

            return order;
        }
    }
}
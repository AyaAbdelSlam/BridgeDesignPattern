using System;

namespace BridgeDesignPattern
{
    internal class FancyRestaurantOrders : IOrderingSystem
    {
        public void Place(string order)
        {
            Console.WriteLine("Placing order for " + order + " at the Fancy Restaurant.");
        }
    }
}
using System;
using System.Collections.Generic;

namespace DesignPatternCms2_MvcConsole.Views

{
    internal class AddOrderView
    {
        public RestaurantOrder Show()
        {
            Console.Clear();
            Console.WriteLine("Servitörens namn:");
            string namn = Console.ReadLine();
            Console.WriteLine("Bord nummer:");
            int tableNo = Convert.ToInt32(Console.ReadLine());
            var order = new RestaurantOrder
            {
                TableNumber = tableNo,
                Servant = namn,
                OrderStatus = RestaurantOrder.Status.Received,
                OrderParts = new List<RestaurantOrderRow>()
            };

            while (true)
            {
                Console.WriteLine("Produkt att lägga till (ex hamburgertallrik):");
                string prod = Console.ReadLine();
                Console.WriteLine("Antal");
                int count = Convert.ToInt32(Console.ReadLine());
                order.OrderParts.Add(new RestaurantOrderRow { Count = count, Product = prod });
                Console.WriteLine("Lägga till fler J/N?");
                if (Console.ReadLine().ToLower() != "j")
                    break;
            }
            return order;

        }
    }
}
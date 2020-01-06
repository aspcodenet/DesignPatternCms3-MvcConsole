using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCms2_MvcConsole.Views
{
    class ShowOrdersView
    {
        private List<RestaurantOrder> model;

        public ShowOrdersView(List<RestaurantOrder> model)
        {
            this.model = model;
        }

        internal void Show()
        {
            Console.Clear();
            int i = 1;
            foreach (string name in Enum.GetNames(typeof(RestaurantOrder.Status)))
            {
                Console.WriteLine($"{i} {name}");
                i++;
            }
            Console.WriteLine("Typ?");
            int sel = Convert.ToInt32(Console.ReadLine());
            var status = (RestaurantOrder.Status)sel - 1;

            foreach (var order in model.Where(o => o.OrderStatus == status))
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine($"   TABLE {order.TableNumber}      SERVANT: {order.Servant} ");
                foreach (var row in order.OrderParts)
                {
                    Console.WriteLine($"            {row.Product}     {row.Count} ");
                }
            }
            Console.WriteLine("-Det var alla-");
            Console.WriteLine("Trycke ENTER för att fortsätta");
            Console.ReadLine();

        }
    }
}

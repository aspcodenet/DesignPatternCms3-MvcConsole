using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCms2_MvcConsole.Views
{
    class HeadMenuView
    {
        private readonly List<RestaurantOrder> model;

        public HeadMenuView(List<RestaurantOrder> model)
        {
            this.model = model;
        }

        public int Show()
        {
            Console.Clear();
            Console.WriteLine(@"1. Show orders
2. Add order               
3. Change order status
9. Exit
");
            Console.WriteLine("Vad vill du göra?");
            int res = Convert.ToInt32(Console.ReadLine());
            return res;
        }
    }
}

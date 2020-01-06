using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCms2_MvcConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new List<RestaurantOrder>();
            var controller = new OrderController(model);
            controller.Start();
        }
    }
}

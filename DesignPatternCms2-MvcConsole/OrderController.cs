using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCms2_MvcConsole
{
    class OrderController
    {
        private List<RestaurantOrder> model;

        public OrderController(List<RestaurantOrder> model)
        {
            this.model = model;
        }

        public void Start()
        {
            while (true)
            {
                var view = new Views.HeadMenuView(model);
                var selection = view.Show();

                if (selection == 9) return;
                else if (selection == 1)
                    ShowOrders();
                else if (selection == 2)
                    AddOrder();
            }
        }

        private void AddOrder()
        {
            var view = new Views.AddOrderView();
            var addedOrder = view.Show();
            model.Add(addedOrder);
        }

        private void ShowOrders()
        {
            var view = new Views.ShowOrdersView(model);
            view.Show();
        }
    }
}

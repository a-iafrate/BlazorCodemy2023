using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCodemy.Shared
{
    public class OrderState
    {
        public Order Order { get; private set; } = new Order();

        public void ClearOrders()
        {
            Order.ShopElements.Clear();
        }
    }
}

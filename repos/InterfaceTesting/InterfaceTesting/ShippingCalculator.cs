using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTesting
{
    class ShippingCalculator
    {
        public int CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30)
                return order.TotalPrice + 20;

            return 0;
        }
    }
}

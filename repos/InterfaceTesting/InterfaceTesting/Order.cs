using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTesting
{
    public class Order
    {
        public DateTime DatePlaced { get; set; }
        public int TotalPrice { get; set; }

        public Order(DateTime DatePlaced, int TotalPrice)
        {
            this.DatePlaced = DatePlaced;
            this.TotalPrice = TotalPrice;
        }
        public Order()
        {

        }
    }
}

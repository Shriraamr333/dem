using System;
using System.Collections.Generic;
using System.Text;

namespace Datatypes
{
    public class Order
    {
        public string OrderID { get; set; }
        public String StringOrderDate { get; set; }
        public Decimal OrderAmount { get; set; } = 0.00M;
        public int OrderQuantity { get; set; } = 0;
        public String DeliveryAddress { get; set; }
        public string DeliveryStatus { get; set; } = "Order Placed";
    }
}

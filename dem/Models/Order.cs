using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dem.Models
{
    public class Order
    {
       
       public String OrderDate { get; set; }
        //public Decimal OrderAmount { get; set; } = 0.00M;
       public int OrderQuantity { get; set; } = 0;
       public String DeliveryAddress { get; set; }
        //public string DeliveryStatus { get; set; } = "Order Placed";
        //public Decimal SubTotal { get; set; } = 0.00M;
        //public Decimal OrderDeliveryCharge { get; set; } = 0.00M;
       public int OrderWeight { get; set; } = 0;
    }
   
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dem.Models
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Category { get; set; } = String.Empty;
        public string Photo { get; set; } = String.Empty;
        public string SubCategory { get; set; } = String.Empty;
        public string SubType { get; set; } = String.Empty;
        public string SubType2 { get; set; } = String.Empty;
        public string SubType3 { get; set; } = String.Empty;
        public string Brand { get; set; } = String.Empty;
        public decimal SellingPrice { get; set; } = 0.00M;
        public decimal RetailPrice { get; set; } = 0.00M;
        public decimal OfferPrice { get; set; } = 0.00M;
        public double InStock { get; set; } = 0.000;
        public string SellingUnit { get; set; } = string.Empty;
        public string QuantityType { get; set; } = string.Empty;
        public int ProductID { get; internal set; }
        public string ProductName { get; internal set; }
        public decimal ProductQuantity { get; internal set; }
        public string ProductRetailPrice { get; internal set; }
        public string ProductSellingPrice { get; internal set; }
    }
}
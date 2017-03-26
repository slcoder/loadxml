using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models.ViewModels
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductCost { get; set; }
        public int Quantity { get; set; }
        public string ProductImage { get; set; }
    }
}
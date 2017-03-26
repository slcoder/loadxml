using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductModel
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public decimal ProductCost { get; set; }

        public byte ProductImage { get; set; }

        public string ProductImagePath { get; set; }

        public string ProductImageName { get; set; }
    }
}

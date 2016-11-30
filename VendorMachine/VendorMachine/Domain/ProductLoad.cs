using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendorMachine.Domain
{
    public class ProductLoad
    {
        public Product Product { get; set; }
        public int Amount { get; set; }

        public ProductLoad(Product product, int amount)
        {
            Product = product;
            Amount = amount;
        }
    }
}
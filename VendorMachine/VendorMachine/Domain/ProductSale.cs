using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendorMachine.Domain
{
    public class ProductSale
    {
        public Product Product { get; set; }
        public int Amount { get; set; }

        public ProductSale(Product pr, int amount)
        {
            Product = pr;
            Amount = amount;
        }
    }
}
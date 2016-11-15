using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendorMachine.Domain
{
    public class ProductSale
    {
        public Sale Sale { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }

        public ProductSale(Sale sale, Product pr, int amount)
        {
            Sale = sale;
            Product = pr;
            Amount = amount;
        }
    }
}
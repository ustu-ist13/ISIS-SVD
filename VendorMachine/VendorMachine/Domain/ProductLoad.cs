using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendorMachine.Domain
{
    public class ProductLoad
    {
        public Product Product { get; set; }

        public Load Load { get; set; }

        public int Amount { get; set; }

        public ProductLoad(Product product, Load load, int amount)
        {
            Product = product;
            Load = load;
            Amount = amount;
        }
    }
}
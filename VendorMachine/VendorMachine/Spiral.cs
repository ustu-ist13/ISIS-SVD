using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendorMachine
{
    public class Spiral
    {
        public int Number { get; set; }
        public int ProductAmount { get; set; }
        public int MaxAmount { get; set; }
        public Product Product { get; set; }

        public Spiral(int nb, int prAmount, int maxAmount, Product pr)
        {
            Number = nb;
            ProductAmount = prAmount;
            MaxAmount = maxAmount;
            Product = pr;
        }
    }
}
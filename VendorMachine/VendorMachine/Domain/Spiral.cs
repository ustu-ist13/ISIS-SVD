using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendorMachine.Domain
{
    public class Spiral
    {
        public int Number { get; set; }
        public int CurrentAmount { get; set; }
        public int MaxAmount { get; set; }
        public Product Product { get; set; }

        public Spiral(int nb, int amount, int maxAmount, Product pr)
        {
            Number = nb;
            CurrentAmount = amount;
            MaxAmount = maxAmount;
            Product = pr;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendorMachine
{
    public class ValuteType
    {
        public string Name { get; set; }
        public int Par { get; set; }
        public int Amount { get; set; }

        public ValuteType(string name, int par, int amount)
        {
            Name = name;
            Par = par;
            Amount = amount;
        }

        public void AddAmount(int value) => Amount += value;
    }
}
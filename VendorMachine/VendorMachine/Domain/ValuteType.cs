using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendorMachine.Domain
{
    public class ValuteType
    {
        public string Name { get; set; }
        public int Par { get; set; }
        public int CurrentAmount { get; set; }

        public ValuteType(string name, int par, int amount)
        {
            Name = name;
            Par = par;
            CurrentAmount = amount;
        }

        public void AddAmount(int value) => CurrentAmount += value;
    }
}
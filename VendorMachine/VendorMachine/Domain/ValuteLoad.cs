using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendorMachine.Domain
{
    public class ValuteLoad
    {
        public ValuteType ValuteType { get; set; }
        public int Amount { get; set; }

        public ValuteLoad(ValuteType vtype, int amount)
        {
            ValuteType = vtype;
            Amount = amount;
        }
    }
}
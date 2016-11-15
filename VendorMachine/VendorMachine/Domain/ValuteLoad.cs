using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendorMachine.Domain
{
    public class ValuteLoad
    {
        public Load Load { get; set; }
        public ValuteType ValuteType { get; set; }
        public int Amount { get; set; }

        public ValuteLoad(Load load, ValuteType vtype, int amount)
        {
            Load = load;
            ValuteType = vtype;
            Amount = amount;
        }
    }
}
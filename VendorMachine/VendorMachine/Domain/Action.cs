using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendorMachine.Domain
{
    public class Action
    {
        public Load Load { get; set; }
        public Sale Sale { get; set; }

        public Action(Load load, Sale sale)
        {
            Load = load;
            Sale = sale;
        }
    }
}
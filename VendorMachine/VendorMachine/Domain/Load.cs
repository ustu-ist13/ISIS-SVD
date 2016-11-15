using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendorMachine.Domain
{
    public class Load
    {
        public DateTime DateTime { get; set; }

        public Load()
        {
            DateTime = DateTime.Now;
        }
    }
}
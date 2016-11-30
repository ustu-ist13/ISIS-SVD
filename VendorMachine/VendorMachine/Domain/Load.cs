using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendorMachine.Domain
{
    public class Load
    {
        public DateTime DateTime { get; set; }
        public List<ValuteLoad> LoadedValute { get; set; }
        public List<ProductLoad> LoadedProducts { get; set; }

        public Load()
        {
            DateTime = DateTime.Now;
            LoadedValute = new List<ValuteLoad>();
            LoadedProducts = new List<ProductLoad>();
        }
    }
}
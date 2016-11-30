using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendorMachine.Domain
{
    public class Journal
    {
        public DateTime Date { get; set; }
        public List<Action> Actions { get; set; }

        public Journal()
        {
            Date = DateTime.Now.Date;
            Actions = new List<Action>();
        }
    }
}
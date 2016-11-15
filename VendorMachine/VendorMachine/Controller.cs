using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorMachine.VendorInterface;

namespace VendorMachine
{
    public class Controller : ICalculation
    {
        public int CalculateChange(int balance, int total)
        {
            throw new NotImplementedException();
        }

        public int CalculateTotalCost(Sale sale)
        {
            throw new NotImplementedException();
        }
    }
}

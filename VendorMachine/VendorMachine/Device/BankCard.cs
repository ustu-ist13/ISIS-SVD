using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorMachine.Device
{
    public class BankCard
    {
        public string Number { get; set; }
        public short Pin { get; set; }
        public DateTime Date { get; set; }
        public string Owner { get; set; }
        public int Balance { get; set; }

        public BankCard(string nb, short pin, DateTime date, string owner, int balance)
        {
            Number = nb;
            Pin = pin;
            Date = date;
            Owner = owner;
            Balance = balance;
        }
    }
}

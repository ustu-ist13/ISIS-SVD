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
        public DateTime DateExpire { get; set; } // Дата истечения срока действия
        public string OwnerName { get; set; } // Имя владельца
        public int CurrentBalance { get; set; }

        public BankCard(string nb, short pin, DateTime date, string owner, int initial_balance)
        {
            Number = nb;
            Pin = pin;
            DateExpire = date;
            OwnerName = owner;
            CurrentBalance = initial_balance;
        }
    }
}

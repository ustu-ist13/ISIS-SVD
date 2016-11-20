using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorMachine.VendorInterface;

namespace VendorMachine.Device
{
    public class BankCardModule : IDevice
    {
        public string Name { get; set; } = "Модуль банковских карт";

        public bool Status { get; set; } = true;

        private IEnumerable<BankCard> cards;

        public bool CheckValidation(BankCard card) => cards.Contains(card) ? true : false;

        public void ChangeStatus(bool current) => Status = current ? false : true;
    }
}

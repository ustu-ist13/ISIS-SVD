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

        private List<BankCard> cards = new List<BankCard>();
        /// <summary>
        /// Проверка карты на действительность
        /// </summary>
        /// <param name="card"></param>
        /// <returns></returns>
        public bool CheckValidation(BankCard card) => cards.Contains(card) && card.DateExpire >= DateTime.Now ? true : false;
        /// <summary>
        /// Проверка пин-кода
        /// </summary>
        /// <param name="card"></param>
        /// <param name="pin"></param>
        /// <returns></returns>
        public bool CheckPinCode(BankCard card, short pin) => card.Pin == pin ? true : false;

        public void ChangeStatus(bool current) => Status = current ? false : true;
    }
}

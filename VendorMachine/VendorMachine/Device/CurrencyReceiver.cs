using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorMachine.VendorInterface;
using VendorMachine.Domain;

namespace VendorMachine.Device
{
    public class CurrencyReceiver : IDevice
    {
        public string Name { get; set; } = "Валютоприемник";
        public bool Status { get; set; } = true;

        private IEnumerable<ValuteType> StoredValuteTypes;
        /// <summary>
        /// Распознает вставленную валюту
        /// </summary>
        /// <param name="valute"></param>
        /// <returns></returns>
        private bool RecognizeValute(ValuteType valute) => StoredValuteTypes
            .Any(x => x.Name == valute.Name && x.Par == valute.Par) ? true : false;
        /// <summary>
        /// Возвращает сумму денег, которую следует добавить к текущему балансу клиента
        /// </summary>
        /// <param name="acceptedValute"></param>
        private int AddBalance(ValuteType acceptedValute) => acceptedValute.Par;
        
        /// <summary>
        /// Возвращает непринятую валюту или сумму денег, добавляемую к балансу клиента
        /// </summary>
        /// <param name="valute"></param>
        /// <returns></returns>
        public int AcceptMoney(ValuteType valute)
        {
            if (RecognizeValute(valute))
            {
                StoredValuteTypes.First(x => x.Name == valute.Name && x.Par == valute.Par).CurrentAmount++;
                return AddBalance(valute);
            }
            else return 0;
        }
        /// <summary>
        /// Изменяет статус устройства в зависимости от текущего
        /// </summary>
        /// <param name="current"></param>
        public void ChangeStatus(bool current) => Status = current ? false : true;
    }
}
// Добавил коммент в код, чтобы сделать коммит с базой данных
// Ещё один коммент, но уже после правки gitignore
// А этот комментарий сделан для того, чтобы добавить проект парадайма в систему контроля версий
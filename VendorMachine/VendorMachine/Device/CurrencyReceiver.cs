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
        public Tuple<ValuteType, int> AcceptMoney(ValuteType valute) //надо подумать
        {
            //Прим. Влад: как мы сможем возвращать непринятую валюту, если автомат не знает такой валюты?
            //Быть может, возвращать только добавляемую сумму?
            //Может быть, есть смысл принимать не ValuteType, а сами параметры, типа ("Рубль", "5")?

            if (RecognizeValute(valute))
            {
                StoredValuteTypes.First(x => x.Name == valute.Name && x.Par == valute.Par).CurrentAmount++;
                return new Tuple<ValuteType, int>(null, AddBalance(valute));
            }
            //Быть может, если автомат не знает такую валюту, то пусть не делает ничего, и возвращать будет он...
            //...И возвращать будет он 0, если возвращать только добавляемую сумму
            else return new Tuple<ValuteType, int>(valute, 0);
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorMachine.VendorInterface;

namespace VendorMachine.TestClass
{
    public class CurrencyReceiver : IDevice
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        public IEnumerable<ValuteType> ValuteTypes { get; set; }
        /// <summary>
        /// Распознает вставленную валюту
        /// </summary>
        /// <param name="valute"></param>
        /// <returns></returns>
        public bool RecognizeValute(ValuteType valute) => ValuteTypes
            .FirstOrDefault(x => x.Name == valute.Name && x.Par == valute.Par) != null ? true : false;
        /// <summary>
        /// Наращивает баланс клиента
        /// </summary>
        /// <param name="money"></param>
        public int AddBalance(IEnumerable<ValuteType> money) => money.Where(x => RecognizeValute(x)).Select(x => x.Par).Sum();
        //public int AddValuteAmount(IEnumerable<ValuteType> money) => 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendorMachine.VendorInterface;
using VendorMachine.Expantion;

namespace VendorMachine.TestClass
{
    public class CurrencyReceiver : IDevice
    {
        public string Name { get; set; }
        public bool Status { get; set; }
        /// <summary>
        /// Распознает вставленную валюту
        /// </summary>
        /// <param name="curr"></param>
        /// <returns></returns>
        public bool RecognizeCurrency(Currency curr) => true;
        /// <summary>
        /// Наращивает баланс клиента
        /// </summary>
        /// <param name="money"></param>
        //public int AddBalance(IEnumerable<Currency> money) => money.Where(x => RecognizeCurrency(x)).Select(x => x.).Sum();
    }
}
// Добавил коммент в код, чтобы сделать коммит с базой данных
// Ещё один коммент, но уже после правки gitignore
// А этот комментарий сделан для того, чтобы добавить проект парадайма в систему контроля версий
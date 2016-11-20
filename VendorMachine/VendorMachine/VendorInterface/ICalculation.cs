using System.Collections.Generic;
using VendorMachine.Domain;

namespace VendorMachine.VendorInterface
{
    public enum PaymentMethod { valute, bank, nfc }
    /// <summary>
    /// Интерфейс расчета с клиентом
    /// </summary>
    interface ICalculation
    {
        int ClientBalance { get; set; }
        int ClientTotalCost { get; set; }
        int ClientChange { get; set; }

        /// <summary>
        /// Подсчитывает общую сумму продажи
        /// </summary>
        int CalculateTotalCost(IEnumerable<ProductSale> productSales);
        /// <summary>
        /// Осуществляет подсчет сдачи
        /// </summary>
        /// <param name="balance">Текущий баланс клиента</param>
        /// <param name="total">Общая стоимость текущей покупки</param>
        /// <returns>Количество сдачи</returns>
        int CalculateChange(int balance, int total);

        PaymentMethod ChoosePaymentMethod(short id);
    }
}

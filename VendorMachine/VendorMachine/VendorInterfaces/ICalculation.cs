using VendorMachine.Expantion;

namespace VendorMachine.VendorInterfaces
{
    /// <summary>
    /// Интерфейс расчета с клиентом
    /// </summary>
    interface ICalculation
    {
        /// <summary>
        /// Подсчитывает общую сумму продажи
        /// </summary>
        /// <param name="sale">Текущая продажа</param>
        /// <returns></returns>
        int CalculateTotalCost(Sale sale);
        /// <summary>
        /// Осуществляет подсчет сдачи
        /// </summary>
        /// <param name="balance">Текущий баланс клиента</param>
        /// <param name="total">Общая стоимость текущей покупки</param>
        /// <returns>Количество сдачи</returns>
        int CalculateChange(int balance, int total);
    }
}

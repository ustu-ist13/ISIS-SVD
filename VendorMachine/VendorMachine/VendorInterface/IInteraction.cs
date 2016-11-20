using System.Collections.Generic;
using VendorMachine.Domain;

namespace VendorMachine.VendorInterface
{
    /// <summary>
    /// Интерфейс взаимодействия с клиентом
    /// </summary>
    interface IInteraction
    {
        /// <summary>
        /// Выбор товара по введенному коду
        /// </summary>
        /// <param name="code">Код товара</param>
        /// <returns>Выбранный товар</returns>
        Product SelectProduct(int code, IEnumerable<Spiral> spirals);
        /// <summary>
        /// Формирование продажи выбранного товара
        /// </summary>
        /// <param name="product">Товар для продажи</param>
        /// /// <param name="count">Количество товара</param>
        void AddProductSale(Product product, int count);
        /// <summary>
        /// Формирование общей продажи для текущего клиента
        /// </summary>
        /// <param name="productSales">Список продаж</param>
        /// <returns></returns>
        void CreateSale();
    }
}
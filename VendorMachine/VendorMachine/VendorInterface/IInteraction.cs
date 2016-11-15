using System.Collections.Generic;


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
        Product SelectProduct(int code);
        /// <summary>
        /// Продажа выбранного товара
        /// </summary>
        /// <param name="product">Товар для продажи</param>
        /// /// <param name="count">Количество товара</param>
        ProductSale SellProduct(Product product, int count);
        /// <summary>
        /// Формирование продажи для текущего клиента
        /// </summary>
        /// <param name="products">Список купленных товаров</param>
        /// <returns></returns>
        Sale CreateSale(IEnumerable<ProductSale> products);
    }
}
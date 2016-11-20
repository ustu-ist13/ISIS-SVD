using System.Collections.Generic;
using System.Linq;
using VendorMachine.VendorInterface;
using VendorMachine.Domain;
using VendorMachine.Device;

namespace VendorMachine
{
    public class Controller : ICalculation, IInteraction
    {
        #region Текущие данные

        public CurrencyReceiver receiver = new CurrencyReceiver();

        public ValuteType CurrentMoney;
        public List<ProductSale> CurrentProductSales;
        public Sale CurrentSale;

        public int ClientBalance { get; set; }
        public int ClientTotalCost { get; set; }
        public int ClientChange { get; set; }
        #endregion

        #region Расчет с клиентом

        public PaymentMethod ChoosePaymentMethod(short id) => (id == 0) ? PaymentMethod.valute
            : (id == 1) ? PaymentMethod.bank : PaymentMethod.nfc;

        public int CalculateChange(int balance, int total) => total - balance;

        public int CalculateTotalCost(IEnumerable<ProductSale> productSales) => productSales
            .Select(x => x.Amount * x.Product.Price)
            .Sum();

        public void ClientCalculation(PaymentMethod method)
        {
            switch (method)
            {
                case PaymentMethod.valute:
                    ClientBalance += receiver.AcceptMoney(CurrentMoney).Item2;
                    ClientTotalCost = CalculateTotalCost(CurrentProductSales);
                    ClientChange = CalculateChange(ClientBalance, ClientTotalCost);
                    break;
                case PaymentMethod.bank:
                    break;
                case PaymentMethod.nfc:
                    break;
            }
            
        }
        #endregion

        #region Взаимодействие с клиентом

        public Product SelectProduct(int code, IEnumerable<Spiral> spirals) => spirals.FirstOrDefault(x => x.Number == code).Product;

        public void AddProductSale(Product product, int count) => CurrentProductSales.Add(new ProductSale(product, count));

        public void CreateSale()
        {
            CurrentSale =  new Sale(ClientBalance, ClientTotalCost, ClientChange);
            CurrentProductSales.ForEach(x => x.Sale = CurrentSale);
        }
        #endregion

        #region Сервис и обслуживание
        #endregion
    }
}

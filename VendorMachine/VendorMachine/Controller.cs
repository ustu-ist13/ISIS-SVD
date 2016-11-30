using System.Collections.Generic;
using System.Linq;
using VendorMachine.VendorInterface;
using VendorMachine.Domain;
using VendorMachine.Device;
using System.IO;
using Newtonsoft.Json;

namespace VendorMachine
{
    public class Controller : ICalculation, IInteraction
    {
        #region Текущие данные

        public CurrencyReceiver receiver = new CurrencyReceiver();

        public ValuteType CurrentMoney;
        public BankCard CurrentCard;
        public List<ProductSale> CurrentProductSales;
        public Sale CurrentSale;
        public short PaymentMethodID;

        public List<Spiral> CurrentSpiralState;

        public int ClientBalance { get; set; }
        public int ClientTotalCost { get; set; }
        public int ClientChange { get; set; }
        #endregion

        #region Расчет с клиентом

        public PaymentMethod ChoosePaymentMethod(short id) => (id == 0) ? PaymentMethod.valute
            : (id == 1) ? PaymentMethod.bank : PaymentMethod.nfc;

        public int CalculateChange(int balance, int total) => total - balance;

        public int CalculateTotalCost(List<ProductSale> productSales) => productSales
            .Select(x => x.Amount * x.Product.Price)
            .Sum();

        public void ClientCalculation(PaymentMethod method)
        {
            switch (method)
            {
                case PaymentMethod.valute:
                    ClientBalance += receiver.AcceptMoney(CurrentMoney);
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

        public Product SelectProduct(int code) => CurrentSpiralState.FirstOrDefault(x => x.Number == code).Product;

        public void AddProductSale(Product product, int count) => CurrentProductSales.Add(new ProductSale(product, count));

        public void CreateSale()
        {
            ClientCalculation(ChoosePaymentMethod(PaymentMethodID));
            CurrentSale = new Sale(ClientBalance, ClientTotalCost, ClientChange, CurrentProductSales);
        } 

        #endregion

        #region Сервис и обслуживание

        public void AddSpiral(int number, int amount, int maxAmount, Product product)
        {
            if (CurrentSpiralState == null)
            {
                CurrentSpiralState = new List<Spiral>();            
            }
            CurrentSpiralState.Add(new Spiral(number, amount, maxAmount, product));
            //FileStream file = new FileStream("/DataStorage/Spirals.json", FileMode.Create);
            string spiralsserialize = JsonConvert.SerializeObject(CurrentSpiralState);
            File.WriteAllText("Spirals.json", spiralsserialize);
        }

        #endregion
    }
}

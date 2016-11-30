using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendorMachine.Domain
{
    public class Sale
    {
        public DateTime DateTime { get; set; }
        public int Balance { get; set; }
        public int TotalCost { get; set; }
        public int Change { get; set; }
        public List<ProductSale> ProductSales = new List<ProductSale>();

        public Sale(int balance, int total, int change, List<ProductSale> productSales)
        {
            DateTime = DateTime.Now;
            Balance = balance;
            TotalCost = total;
            Change = change;
            ProductSales = productSales;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendorMachine.Domain;

namespace VendorMachine
{
    public partial class MainMenu : Form
    {
        string ValueFromKeyboard;
        Controller AutomatProcessor = new Controller();

        public MainMenu()
        {
            InitializeComponent();
            AutomatProcessor.AddSpiral(1, 15, 15, new Product("Сникерс", 50));
            AutomatProcessor.AddSpiral(2, 16, 16, new Product("Шаверма", 150));
            AutomatProcessor.AddSpiral(3, 20, 20, new Product("Нямка", 42));
            AutomatProcessor.AddValuteType(1, "Бумажный рубль", 50, 5);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{ValueFromKeyboard}");
            ValueFromKeyboard = "";
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            ValueFromKeyboard += (sender as Button).Name[3];
        }

        private void cbNFC_CheckedChanged(object sender, EventArgs e)
        {
            txtPinCode.Enabled = txtPinCode.Enabled ? false : true;
        }

        private void btnEnterCurrency_Click(object sender, EventArgs e)
        {
            AutomatProcessor.PaymentMethodID = 0;
            txtDisplayInfo.Clear();
            AutomatProcessor.CurrentMoney = new ValuteType(cmbValuteType.Text, int.Parse(txtPar.Text));
            if (AutomatProcessor.CurrencyReceiver.AcceptMoney(AutomatProcessor.CurrentMoney) == 0)
                txtDisplayInfo.Text += $"Не удалось распознать: {AutomatProcessor.CurrentMoney.ToString()}. Данная валюта не поддерживается. {Environment.NewLine}";
            AutomatProcessor.ClientBalance += AutomatProcessor.CurrencyReceiver.AcceptMoney(AutomatProcessor.CurrentMoney);
            txtDisplayInfo.Text += $"Текущий баланс клиента: {AutomatProcessor.ClientBalance} {Environment.NewLine}";
        }
    }
}

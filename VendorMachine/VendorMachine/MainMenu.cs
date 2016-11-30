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

        public MainMenu()
        {
            InitializeComponent();
            Controller AutomatProcessor = new Controller();
            AutomatProcessor.AddSpiral(1, 15, 15, new Product("Сникерс", 50));
            AutomatProcessor.AddSpiral(2, 16, 16, new Product("Шаверма", 150));
            AutomatProcessor.AddSpiral(3, 20, 20, new Product("Нямка", 42));
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
    }
}

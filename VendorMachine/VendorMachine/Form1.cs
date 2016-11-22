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
using Newtonsoft.Json;

namespace VendorMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Controller AutomatProcessor = new Controller();
            AutomatProcessor.AddSpiral(1, 15, 15, new Product("Сникерс", 50));
            AutomatProcessor.AddSpiral(2, 16, 16, new Product("Шаверма", 150));
            AutomatProcessor.AddSpiral(3, 20, 20, new Product("Нямка", 42));
        }
    }
}

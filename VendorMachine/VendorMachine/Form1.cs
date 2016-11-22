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
            Product pr = new Product("Сникерс", 50);
            AutomatProcessor.AddSpiral(1, 15, 15, pr);
            string json = JsonConvert.SerializeObject(pr);
            string spiralsserialize = JsonConvert.SerializeObject(AutomatProcessor.CurrentSpiralState);
            MessageBox.Show(json);
            MessageBox.Show(spiralsserialize);
        }
    }
}

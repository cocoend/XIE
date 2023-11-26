using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.XPath;

namespace TaxCalc2
{
    public partial class TaxCalc : Form
    {
        public TaxCalc()
        {
            InitializeComponent();            
        }

        private void calc_Click(object sender, EventArgs e)
        {
            int price;
            bool success = int.TryParse(priceBox.Text, out price);
            if (success)
            {
                double result = (price * 1.1);
                this.resultBox.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }

        }
    }
}

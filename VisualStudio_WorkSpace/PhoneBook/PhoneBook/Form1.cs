using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook2
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> PhoneBook;
        public Form1()
        {
            InitializeComponent();
            this.PhoneBook = new Dictionary<string, string>();
            ReadFromFlie();
            /*
            {
                { "xiexin", "08068402333" },
                {"wang","08064587445"},
                {"bia","08045677894" },
                {"chen","080123456789784" }

            };*/
            
            foreach(KeyValuePair<string,string>data in PhoneBook)
            {
                this.namelist.Items.Add(data.Key);
            }
        }

        private void ReadFromFlie()
        {
            using(System.IO.StreamReader file = new System.IO.StreamReader(@"..\..\data.txt"))
            {
                while(!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    string[] data = line.Split(',');
                    this.PhoneBook[data[0]] = data[1];
                }
            }
        }

        private void NameSelected(object sender, EventArgs e)
        {
            string name = this.namelist.Text;
            phoneNumber.Text = PhoneBook[name];
        }
    }
}

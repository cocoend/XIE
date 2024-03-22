using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;

namespace STMS
{
    public partial class LoginForm : FormFarther
    {
        private PersonModel personModel;
        public PersonModel PersonModel
        {
            get { return personModel; }
        }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            //登録 
            personModel = new PersonModel
            {
                Name = TextboxName.Text.Trim(),
                Password = TextboxPassword.Text.Trim()
            };

            if(new PersonBLL().Select(personModel,out string messageStr) != null  && PersonBLL.success == true)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(messageStr);
                TextboxName.Text = "";
                TextboxPassword.Text = "";

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            //取消
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //新規登録
            SignUpForm sgnUpForm = new SignUpForm(new PersonModel(), new PersonModel()) ;
            sgnUpForm.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //パスワード忘れた
        }
    }
}

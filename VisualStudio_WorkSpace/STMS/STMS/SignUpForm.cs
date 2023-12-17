using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STMS
{
    public partial class SignUpForm : FormFarther
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            PersonModel personModel = new PersonModel();
            personModel.Name = this.nameTextBox.Text;
            personModel.Password = this.passwordTextBox.Text.Trim();
            personModel.PasswordVerify = this.passwordTextBox.Text.Trim();
            personModel.Brithday = brithdayDateTimePicker.Value;
            personModel.Sex = this.sexSkinComboBox.SelectedIndex;
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}

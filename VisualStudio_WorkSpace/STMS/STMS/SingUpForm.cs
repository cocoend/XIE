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
using CCWin.SkinClass;


namespace STMS
{
    public partial class SingUpForm :CCSkinMain
    {
        public SingUpForm()
        {
            InitializeComponent();

        }
        private void cancleButton_Click(object sender, EventArgs e)
        {
            //取消
            this.Close();
        }

        private void SingUploginButton_Click(object sender, EventArgs e)
        {
            //新規登録
            PersonModel personModel = new PersonModel();
            personModel.Name = this.nameTextBox.Text.Trim();
            personModel.Password = this.passwordTextBox.Text.Trim();
            personModel.PasswordVerify = this.passwordTextBox.Text.Trim();
            //personModel.Brithday = brithdayDateTimePicker.Value;
            personModel.address = this.addressTextBox.Text.Trim();
        }

    }
}

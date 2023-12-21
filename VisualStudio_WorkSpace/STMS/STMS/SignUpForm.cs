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
using BLL;

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
            personModel.Name = nameTextBox.Text;
            personModel.Password = passwordTextBox.Text.Trim();
            personModel.PasswordVerify = passwordTextBox.Text.Trim();
            personModel.Brithday = brithdayDateTimePicker.Value;
            personModel.Sex = sexSkinComboBox.SelectedIndex;
            personModel.Telphone = telephoneTextBox.Text.Trim();
            personModel.address = addressTextBox.Text.Trim();
            personModel.Father = fartherTextBox.Text.Trim();
            personModel.Mother = montherTextBox.Text.Trim();
            personModel.RegDate = RegdateTimePicker.Value;
            personModel.UserLevel = 2;//新規ユーザーは学生
            personModel.Enabled = false;//新規ユーザー登録できない
            PersonBLL personBLL = new BLL.PersonBLL();
            if (personBLL.Insert(personModel,out string messageStr)==true)
            {
                MessageBox.Show(messageStr);
                DialogResult = DialogResult.OK; 
            }
            else
            {
                MessageBox.Show(messageStr);

            }
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}

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
        PersonModel personModel;
        PersonModel myPersonModel;
        public SignUpForm(PersonModel _personModel, PersonModel _myPersonModel)
        {
            personModel = _personModel;
            myPersonModel = _myPersonModel;
            InitializeComponent();
            IntGlobal();
        }

        public void IntGlobal()
        {
            if(personModel == null || personModel.ID == 0)
            {
                //New User
                signupButton.Visible = true;
                Text = "新規登録";
            }
            else
            {
                //Edit User
                nameTextBox.Text= personModel.Name;
                passwordTextBox.Text = personModel.Password;
                passwordVerifyTextBox.Text = personModel.PasswordVerify;
                brithdayDateTimePicker.Value = personModel.Birthday;
                sexSkinComboBox.SelectedIndex = personModel.Sex;
                telephoneTextBox.Text = personModel.Telephone;
                addressTextBox.Text = personModel.Address;
                fartherTextBox.Text = personModel.Father;
                montherTextBox.Text = personModel.Mother;
                RegdateTimePicker.Value = personModel.RegDate;
                //UserLevel
                Common.UserLevelList.ForEach(item => skinComboLevelBox.Items.Add(item));
                skinComboLevelBox.SelectedIndex = personModel.UserLevel;
                //Enabled状態
                skinComboStatusBox.SelectedIndex = personModel.Enabled ? 1 : 0;

                if (myPersonModel.UserLevel == 0)
                {
                    DeleteButton.Visible = true;
                    signupButtonEdit.Visible = true;
                    nameTextBox.ReadOnly = true;
                    skinPanel1Admin.Visible = true;
                }

                passwordTextBox.ReadOnly = true;
                passwordVerifyTextBox.ReadOnly = true;
                Text = "ユーザー管理";
            }
            sexSkinComboBox.SelectedIndex = 0;
        }
        private void signupButton_Click(object sender, EventArgs e)
        {
            personModel.Name = nameTextBox.Text;
            personModel.Password = passwordTextBox.Text.Trim();
            personModel.PasswordVerify = passwordVerifyTextBox.Text.Trim();
            personModel.Birthday = brithdayDateTimePicker.Value;
            personModel.Sex = sexSkinComboBox.SelectedIndex;
            personModel.Telephone = telephoneTextBox.Text.Trim();
            personModel.Address = addressTextBox.Text.Trim();
            personModel.Father = fartherTextBox.Text.Trim();
            personModel.Mother = montherTextBox.Text.Trim();
            personModel.RegDate = RegdateTimePicker.Value;
            personModel.UserLevel = 2;//新規ユーザーは学生
            personModel.Enabled = false;//新規ユーザー登録できない
            PersonBLL personBLL = new PersonBLL();
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

        private void signupButtonEdit_Click(object sender, EventArgs e)
        {
            //更新数据-获取数据
            personModel.Password = passwordTextBox.Text.Trim();
            personModel.PasswordVerify = passwordVerifyTextBox.Text.Trim();
            personModel.Birthday = brithdayDateTimePicker.Value;
            personModel.Sex = sexSkinComboBox.SelectedIndex;
            personModel.Telephone = telephoneTextBox.Text.Trim();
            personModel.Address = addressTextBox.Text.Trim();
            personModel.Father = fartherTextBox.Text.Trim();
            personModel.Mother = montherTextBox.Text.Trim();
            personModel.RegDate = RegdateTimePicker.Value;
            personModel.UserLevel = skinComboLevelBox.SelectedIndex;
            if (skinComboStatusBox.SelectedIndex == 0)
            {
                personModel.Enabled = false;
            }
            else
            {
                personModel.Enabled = true;
            }

            //更新数据-执行
            PersonBLL personBLL = new PersonBLL();
            if (personBLL.UpDate(personModel, out string messageStr) == true)
            {
                MessageBox.Show(messageStr);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(messageStr);

            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(personModel.ID != myPersonModel.ID)
            {
                if (new PersonBLL().Delete(personModel, out string messageStr) == true)
                {
                    MessageBox.Show(messageStr);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(messageStr);

                }

            }
            else
            {
                MessageBox.Show("不能删除自己");
            }
        }
    }
}

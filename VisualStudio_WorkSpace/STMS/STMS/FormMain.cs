using BLL;
using Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace STMS
{
    public partial class FormMain : FormFarther
    {
        private PersonModel myPersonModel;
        private List<PersonModel> personsModelList;
        private List<SubjectModel> SubjectList;
        public FormMain(PersonModel p)
        {
            InitializeComponent();
            myPersonModel = p;  
            IntGlobal();
        }
        
        private void IntGlobal()
        {
            Text = "Welcome," +myPersonModel.Name+"! "+"LEVEL:"+Common.UserLevelList[myPersonModel.UserLevel];
            skinDataGridViewPerson.AutoGenerateColumns = false;
            InitPerson();
        }
        //加载用户表
        private void InitPerson()
        {
            personsModelList = new PersonBLL().Select();
            foreach (PersonModel item in personsModelList)
            {
                item.SexName = Common.Sexlist[item.Sex];
            }
            skinDataGridViewPerson.DataSource = personsModelList;
        }

        private void skinDataGridViewPerson_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (myPersonModel.UserLevel <= 1)
            {
                DataGridView dataGridView = sender as DataGridView;
                DataGridViewRow dataGridViewRow = dataGridView.CurrentRow;
                int number = int.Parse(dataGridViewRow.Cells[0].FormattedValue.ToString());
                PersonModel personModel = personsModelList.Find(item => item.ID == number);
                SignUpForm signUpForm = new SignUpForm(personModel,myPersonModel);
                if(signUpForm.ShowDialog()== DialogResult.OK)
                {
                    IntGlobal();
                }

            }
        } 
    }
}

using System.Collections.Generic;
using Model;
using System.Data.SqlClient;
using Beyondbit.CMS.InfoPublish.DAO;
using System.Data;
using Common;


namespace DAL
{
    public class PersonDAL : IDAL
    {
        private readonly string connString = SqlHelper.GetConnSting();
        public PersonModel Select(PersonModel p)
        {
            string commandText = @"select Name,
                                          Password,
                                          [Birthday],
                                          [Sex],
                                          [Telephone],
                                          [Address],
                                          [Father],
                                          [Mother],
                                          [RegDate],
                                          [UserLevel],
                                          [Enabled],
                                          [CreateDate],
                                          [UpdateTime]
                                   from Person 
                                   where Name = @Name and  Password = @Password";

            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@Name",p.Name),
                new SqlParameter("@Password",BaseUnit.GetMD5(p.Password)),
            };
            DataSet ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, commandText, paras);
            List<PersonModel> personModels = IDataSetToList.DataSetToList<PersonModel>(ds, 0);

            return personModels.Find(item => item.Name == p.Name ); ;

        }
        
        //Personテーブルのユーザー取得
        public List<PersonModel> Select() {
            string commandText = @"select 
                                          ID,
                                          Name,
                                          Password,
                                          [Birthday],
                                          [Sex],
                                          [Telephone],
                                          [Address],
                                          [Father],
                                          [Mother],
                                          [RegDate],
                                          [UserLevel],
                                          [Enabled],
                                          [CreateDate],
                                          [UpdateTime]
                                   from Person ";

            SqlParameter[] paras = new SqlParameter[]
            {

            };
            DataSet ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, commandText, paras);
            List<PersonModel> personModels = IDataSetToList.DataSetToList<PersonModel>(ds, 0);

            return personModels;

        }
        public bool IsReg(PersonModel p)
        {
            string commandText = @"select Name from Person 
                                   where Name = @Name";

            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@Name",p.Name)
            };
            DataSet ds = SqlHelper.ExecuteDataset(connString, CommandType.Text, commandText, paras);
            return ds.Tables[0].Rows.Count > 0;
        }
         
        /// <summary>
        /// 新しい記録をインサート
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int Insert(PersonModel p)
        {
            string commandText = @"insert into [Person](
                        Name,  
                        Password,
                        Birthday,
                        Sex,
                        Telephone,
                        Address,
                        Father,
                        Mother,
                        RegDate,
                        UserLevel, 
                        Enabled )values(
                        @Name,  
                        @Password,
                        @Birthday,
                        @Sex,
                        @Telephone,
                        @Address,
                        @Father,
                        @Mother,
                        @RegDate,
                        @UserLevel,
                        @Enabled )";

            SqlParameter[] paras = new SqlParameter[]
            { 
                new SqlParameter ("@Name",p.Name),
                new SqlParameter ("@Password",BaseUnit.GetMD5(p.Password)),
                new SqlParameter ("@Birthday",p.Birthday),
                new SqlParameter ("@Sex",p.Sex),
                new SqlParameter ("@Telephone",p.Telephone),
                new SqlParameter ("@Address",p.Address),
                new SqlParameter ("@Father",p.Father),
                new SqlParameter ("@Mother",p.Mother),
                new SqlParameter ("@RegDate",p.RegDate),
                new SqlParameter ("@UserLevel",p.UserLevel),
                new SqlParameter ("@Enabled",p.Enabled),
            };
            return SqlHelper.ExecuteNonQuery(connString,CommandType.Text,commandText,paras);
        }
        public int UpDate(PersonModel p)
        {
            string commandText = @"update Person set
                        Birthday = @Birthday,
                        Sex = @Sex,
                        Telephone = @Telephone,
                        Address = @Address,
                        Father = @Father,
                        Mother = @Mother,
                        RegDate = @RegDate,
                        UserLevel = @UserLevel,
                        Enabled = @Enabled
                        where ID = @ID";

            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter ("@ID",p.ID),
                new SqlParameter ("@Birthday",p.Birthday),
                new SqlParameter ("@Sex",p.Sex),
                new SqlParameter ("@Telephone",p.Telephone),
                new SqlParameter ("@Address",p.Address),
                new SqlParameter ("@Father",p.Father),
                new SqlParameter ("@Mother",p.Mother),
                new SqlParameter ("@RegDate",p.RegDate),
                new SqlParameter ("@UserLevel",p.UserLevel),
                new SqlParameter ("@Enabled",p.Enabled),
            };
            return SqlHelper.ExecuteNonQuery(connString, CommandType.Text, commandText, paras);
        }
        public int Delete(PersonModel p)
        {

            string commandText = @"Delete Person 
                        where ID = @ID";

            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter ("@ID",p.ID),
            };
            return SqlHelper.ExecuteNonQuery(connString, CommandType.Text, commandText, paras);

        }
    }
}

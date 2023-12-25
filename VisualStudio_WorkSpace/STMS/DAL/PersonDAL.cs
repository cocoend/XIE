using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Model;
using System.Data.SqlClient;
using Beyondbit.CMS.InfoPublish.DAO;
using System.Data;

namespace DAL
{
    public class PersonDAL
    {
        private string connString = SqlHelper.GetConnSting();
        /// <summary>
        /// 新しい記録をインサート
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int Insert(PersonModel p)
        {
            byte[] result = Encoding.Default.GetBytes(p.Password);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            p.Password = BitConverter.ToString(output).Replace("-", "");

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
                new SqlParameter ("@Password",p.Password),
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
    }
}

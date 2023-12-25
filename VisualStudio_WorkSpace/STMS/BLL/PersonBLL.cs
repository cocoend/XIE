using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class PersonBLL
    {
        public bool Insert(PersonModel p,out string messageStr)
        {
            messageStr = "";
            bool succcess = false;
            if (p.Name.Length == 0)
            {
                messageStr = "ユーザー名を入力してください。";
            }
            else if(p.Password.Length <6)
            {
                messageStr = "パスワードが６桁以上必要";
            }
            else if(p.Password != p.PasswordVerify)
            {
                messageStr = "パスワードが不一致";
            }
            else
            {
                //DLLに転送
                int count = new PersonDAL().Insert(p);
                if (count > 0)
                {
                    messageStr = "新規登録成功";
                    succcess = true;
                }
                else
                {
                    messageStr = "新規登録失敗";
                }
            }
            return succcess;
        }
    }
}

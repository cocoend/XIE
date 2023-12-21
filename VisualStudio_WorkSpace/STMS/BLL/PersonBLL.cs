using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BLL
{
    public class PersonBLL
    {
        public bool Insert(PersonModel t,out string messageStr)
        {
            messageStr = "";
            bool succcess = false;
            if (t.Name.Length == 0)
            {
                messageStr = "ユーザー名を入力してください。";
            }
            else if(t.Password.Length <6)
            {
                messageStr = "パスワードが６桁以上必要";
            }
            else if(t.Password != t.PasswordVerify)
            {
                messageStr = "パスワードが不一致";
            }
            else
            {
                //DLLに転送
            }
        }
    }
}

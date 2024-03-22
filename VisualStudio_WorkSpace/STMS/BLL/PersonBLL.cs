using Model;
using DAL;
using Common;
using System.Collections.Generic;


namespace BLL
{
    public class PersonBLL : IBLL <PersonModel>
    {
        public static bool success = false;

        /// <summary>
        /// ユーザー登録
        /// 
        /// </summary>
        /// <param name="p">personインスタンス</param>
        /// <param name="messageStr"></param>
        /// <returns></returns>
        public PersonModel Select(PersonModel p, out string messageStr)
        {
            messageStr = "";
            PersonDAL personDAL = new PersonDAL();
            PersonModel personModelBack = new PersonModel();

            //ユーザー名存在するかの判断
            if (personDAL.IsReg(p) == true)
            {
                //ユーザー名、パスワード認証確認
                personModelBack = personDAL.Select(p);
                if (personModelBack != null && BaseUnit.GetMD5(p.Password).Equals(personModelBack.Password))
                {
                    if(personModelBack.Enabled == true)
                    {
                        messageStr = "登録成功";
                        success = true;
                    }
                    else
                    {
                        messageStr = "User is unEnabled";

                    }
                }
                else
                {
                    messageStr = "パスワードが間違いました";
                }
            }
            else
            {
                messageStr = "ユーザー存在していません";
            }
            return personModelBack;

        }

        /// <summary>
        /// Personテーブルのユーザー取得
        /// </summary>
        /// <returns></returns>
        public List<PersonModel> Select()
        {
            return new PersonDAL().Select();
        }
        //用户注册
        public bool Insert(PersonModel p,out string messageStr)
        {
            messageStr = "";
            bool success = false;
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
                 PersonDAL personDAL = new PersonDAL();
                //ユーザー名存在するかの判断
                if (personDAL.IsReg(p) == false)
                {
                    //DLLに転送
                    int count = personDAL.Insert(p);
                    if (count > 0)
                    {
                        messageStr = "新規登録成功";
                        success = true;
                    }
                    else
                    {
                        messageStr = "新規登録失敗";
                    }
                }
                else
                {
                    messageStr = "ユーザー名がすでに存在している";
                }
            }
            return success;
        }

        //UpDate
        public bool UpDate(PersonModel p, out string messageStr)
        {
            messageStr = "";
            bool success = false;
            if (p.Name.Length == 0)
            {
                messageStr = "ユーザー名を入力してください。";
            }
            else if (p.Password.Length < 6)
            {
                messageStr = "パスワードが６桁以上必要";
            }
            /*
            else if (p.Password != p.PasswordVerify)
            {
                messageStr = "パスワードが不一致";
            }*/
            else
            {
                //DLLに転送
                int count = new PersonDAL().UpDate(p);
                if (count > 0)
                {
                    messageStr = "更新成功";
                    success = true;
                }
                else
                {
                    messageStr = "更新失敗";
                }
            }
            return success;
        }
        public bool Delete(PersonModel p, out string messageStr)
        {
            messageStr = "";
            bool success = false;
            if (p == null || p.ID <= 0)
            {
                messageStr = "削除対象ユーザーを選択していません。";
            }
            else
            {
                //DLLに転送
                int count = new PersonDAL().Delete(p);
                if (count > 0)
                {
                    messageStr = "削除成功";
                    success = true;
                }
                else
                {
                    messageStr = "削除失敗";
                }
            }
            return success;
        }

    }
}

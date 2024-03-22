using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STMS
{
    public class Common
    {
        public static List<string> Sexlist
        {
            get
            {
                string[] sl = { "秘密", "男", "女" };
                List<string> Sexlist = new List<string>();
                for (int i = 0;i < sl.Length; i++)
                {
                    Sexlist.Add(sl[i]);
                }
                return Sexlist;
            }
        }
        public static List<string> UserLevelList
        {
            get
            {
                string[] sl = { "super", "先生", "生徒" };
                List<string> UserLevelList = new List<string>();
                for (int i = 0; i < sl.Length; i++)
                {
                    UserLevelList.Add(sl[i]);
                }
                return UserLevelList;
            }
        }

    }
}

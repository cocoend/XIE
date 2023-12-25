using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public partial class PersonModel : FatherModel
    {
        public string Password { get; set; }
        public string PasswordVerify { get; set; }

        public DateTime Birthday { get; set; }
        public int Sex { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string Father { get; set; }
        public string Mother { get; set; }
        public DateTime RegDate { get; set; }
        /// <summary>
        /// デフォルト:0、管理者＝0、教師＝1、学生＝2
        /// </summary>
        public int UserLevel { get; set; }
        /// <summary>
        /// デフォルト:false
        /// </summary>
        public bool Enabled { get; set; }
    }
}

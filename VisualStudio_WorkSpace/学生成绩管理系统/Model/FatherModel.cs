using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
     public partial class FatherModel
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 作成者
        /// </summary>
        public int CreatorID { get; set; }
        /// <summary>
        /// 作成時刻
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 更新時刻
        /// </summary>
        public DateTime UpdateTime { get; set; }
    }
}

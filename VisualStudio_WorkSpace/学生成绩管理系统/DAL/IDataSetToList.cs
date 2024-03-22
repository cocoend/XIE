using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class IDataSetToList
    {
        /// <summary>
        /// DataSet to List<T>
        /// </summary>
        /// <typeparam name="T">调用该方法时制定的类型</typeparam>
        /// <param name="dataSet"></param>
        /// <param name="index">表的索引号</param>
        /// <returns></returns>
        public static List<T> DataSetToList<T>(DataSet dataSet,int index)
        {
            if (dataSet == null || dataSet.Tables.Count < 0)
            {
                return null;
            }
            if(index > dataSet.Tables.Count - 1)
            {
                return null;
            }
            if(index < 0)
            {
                index = 0;
            }

            DataTable dataTable = dataSet.Tables[index];
            List<T> result = new List<T>();

            //遍历DataTable
            for (int j = 0; j < dataTable.Rows.Count; j++)
            {
                T t = (T)Activator.CreateInstance(typeof(T));
                PropertyInfo[] propertyInfos = t.GetType().GetProperties();

                foreach (PropertyInfo p in propertyInfos)
                {
                    for(int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        if (p.Name.Equals(dataTable.Columns[i].ColumnName))
                        {
                            if (dataTable.Rows[j][i]!= DBNull.Value)
                            {
                                try { p.SetValue(t, Convert.ChangeType(dataTable.Rows[j][i], p.PropertyType), null); }
                                catch { p.SetValue(t, null, null); }
                            }
                            else
                            {
                                p.SetValue(t, null, null);
                            }
                            break;
                        }
                    }
                }
                result.Add(t);
            }
            return result;
        }
    }
}

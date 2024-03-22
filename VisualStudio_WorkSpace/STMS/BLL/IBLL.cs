using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BLL
{
    public interface IBLL <T>
    {
        List<T> Select();
        bool Insert(T p, out string messageStr);
        bool UpDate(T p, out string messageStr);
        bool Delete(T p, out string messageStr);
    }
}

using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IDAL
    {
        List<PersonModel> Select();
        int Insert(PersonModel p);
        int UpDate(PersonModel p);
        int Delete(PersonModel p);

    }
}

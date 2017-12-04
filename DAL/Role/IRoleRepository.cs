using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRoleRepository
    {
        Boolean Add(String role);
        Boolean Update(String role);
        Boolean Remove(String role);

        DataSet View();
        DataSet View(String role);
        DataSet ListRole();
    }
}

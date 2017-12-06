using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IObjectPrivilegeRepository
    {
        DataSet View();

        DataSet View(String grantee);

        Boolean Execute(String query);
    }
}

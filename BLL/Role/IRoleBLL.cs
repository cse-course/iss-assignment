using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IRoleBLL
    {
        Boolean Add(Role role);

        Boolean Update(Role role);

        Boolean Remove(Role role);

        List<Role> View();

        Role View(String role);

        List<String> ListRole();
    }
}

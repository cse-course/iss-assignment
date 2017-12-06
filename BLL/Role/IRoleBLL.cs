using Domain;
using System;
using System.Collections.Generic;

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

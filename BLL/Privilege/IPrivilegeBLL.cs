using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IPrivilegeBLL
    {
        Boolean HaveSystemPrivilege(String username, String privilege, Boolean isAdmin);

        Boolean GrantSystemPrivilege(String username, String privilege, Boolean isAdmin);

        Boolean RevokeSystemPrivilege(String username, String privilege);

        List<Privilege> SystemPrivileges(String username);

        Boolean HaveObjectPrivilege(String username, String privilege, Boolean isAdmin);

        Boolean GrantObjectPrivilege(String username, String privilege, Boolean isAdmin);

        Boolean RevokeObjectPrivilege(String username, String privilege);

        List<Privilege> ObjectPrivileges(String username);
    }
}

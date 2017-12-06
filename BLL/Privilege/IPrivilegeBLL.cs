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
        #region System
        Boolean HasSystemPrivilege(String username, Privilege privilege);

        Boolean GrantSystemPrivilege(String username, Privilege privilege);

        Boolean RevokeSystemPrivilege(String username, Privilege privilege);

        List<Privilege> SystemPrivileges(String username);
        List<Privilege> SystemPrivileges();

        #endregion System

        #region Table
        Boolean HasTablePrivilege(String username, Privilege privilege);

        Boolean GrantTablePrivilege(String username, Privilege privilege);

        Boolean RevokeTablePrivilege(String username, Privilege privilege);

        List<Privilege> TablePrivileges(String username);

        List<Privilege> TablePrivileges();

        #endregion Table

        #region Column
        Boolean HasColumnPrivilege(String username, Privilege privilege);

        Boolean GrantColumnPrivilege(String username, Privilege privilege);

        Boolean RevokeColumnPrivilege(String username, Privilege privilege);

        List<Privilege> ColumnPrivileges(String username);
        List<Privilege> ColumnPrivileges();
        #endregion Column


    }
}

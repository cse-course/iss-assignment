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

        Boolean GrantSystemPrivilege(SystemPrivilege privilege);

        Boolean RevokeSystemPrivilege(SystemPrivilege privilege);

        List<Privilege> SystemPrivileges(String username);

        List<Privilege> SystemPrivileges(String username, Boolean isAdmin);

        List<Privilege> SystemPrivileges();

        List<Grantee> GranteeSystemPrivileges(String privilege);

        List<Grantee> GranteeSystemPrivileges(String privilege, Boolean isAdmin);

        #endregion System

        #region Role
        Boolean HasRolePrivilege(String username, Privilege privilege);

        Boolean GrantRolePrivilege(RolePrivilege privilege);

        Boolean RevokeRolePrivilege(RolePrivilege privilege);

        List<Privilege> RolePrivileges(String username);

        List<Privilege> RolePrivileges(String username, Boolean isAdmin);
        List<Privilege> RolePrivileges();

        List<Grantee> GranteeRolePrivileges(String privilege, Boolean isAdmin);

        List<Grantee> GranteeRolePrivileges(String privilege);
        #endregion Role

        #region Table
        Boolean HasTablePrivilege(String username, Privilege privilege);

        Boolean GrantTablePrivilege(String username, Privilege privilege);

        Boolean RevokeTablePrivilege(String username, Privilege privilege);

        List<Privilege> TablePrivileges(String username);

        List<Privilege> TablePrivileges(String username, Boolean isAdmin);


        List<Privilege> TablePrivileges();

        List<Grantee> GranteeTablePrivileges(String privilege, Boolean isAdmin);

        #endregion Table

        #region Column
        Boolean HasColumnPrivilege(String username, Privilege privilege);

        Boolean GrantColumnPrivilege(String username, Privilege privilege);

        Boolean RevokeColumnPrivilege(String username, Privilege privilege);

        List<Privilege> ColumnPrivileges(String username);

        List<Privilege> ColumnPrivileges(String username, Boolean isAdmin);

        List<Privilege> ColumnPrivileges();

        List<Grantee> GranteeColumnPrivileges(String privilege, Boolean isAdmin);

        #endregion Column


    }
}
